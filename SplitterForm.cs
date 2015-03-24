using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Globalization;


namespace Splitter
{
    public partial class SplitterLoader : Form
    {
        private Dictionary<string, int> m_encodingList;
        private bool isHTMLRTL = false;
        private string[] m_sections;
        string m_fileExtension = "txt";
        String m_htmlExtension, m_inputFolder, m_outputFolder, m_fileNamePrefix,
                m_splitCharacter, m_staticFolder, m_IndexFileName;
        int m_LineCountToCombine;

        private void SplitterLoader_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadConfigurationSettings() 
        {
            m_inputFolder = ConfigurationManager.AppSettings["InputFolder"];
            m_outputFolder = ConfigurationManager.AppSettings["OutputFolder"];
            m_staticFolder = ConfigurationManager.AppSettings["StaticFolder"];
            m_fileNamePrefix = ConfigurationManager.AppSettings["FileNamePrefix"];
            m_htmlExtension = ConfigurationManager.AppSettings["HTMLExtension"];
            m_splitCharacter = ConfigurationManager.AppSettings["SplitCharacter"];
            m_IndexFileName = ConfigurationManager.AppSettings["IndexFileName"];
            m_LineCountToCombine = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfLinesWhenSplitterAbsent"]);
        }

        public SplitterLoader()
        {
            InitializeComponent();

            LoadConfigurationSettings();
            m_encodingList = new Dictionary<string, int>();

            m_encodingList.Add("Arabic (Windows)", 1256);
            m_encodingList.Add("Arabic (ASMO 708)", 708);
            m_encodingList.Add("Arabic (DOS)", 720);
            m_encodingList.Add("Arabic (ISO)", 28596);
            m_encodingList.Add("Baltic (ISO)", 28594);
            m_encodingList.Add("Baltic (Windows)", 1257);
            m_encodingList.Add("Central European (DOS)", 852);
            m_encodingList.Add("Central European (ISO)", 28592);
            m_encodingList.Add("Central European (Windows)", 1250);
            m_encodingList.Add("Chinese Simplified (GB18030)", 54936);
            m_encodingList.Add("Chinese Simplified (GB2312)", 936);
            m_encodingList.Add("Chinese Simplified (HZ)", 52936);
            m_encodingList.Add("Chinese Traditional (Big5)", 950);
            m_encodingList.Add("Cyrillic (DOS)", 866);
            m_encodingList.Add("Cyrillic (ISO)", 28595);
            m_encodingList.Add("Cyrillic (KOI8-R)", 20866);
            m_encodingList.Add("Cyrillic (KOI8-U)", 21866);
            m_encodingList.Add("Cyrillic (Windows)", 1251);
            m_encodingList.Add("Greek (ISO)", 28597);
            m_encodingList.Add("Greek (Windows)", 1253);
            m_encodingList.Add("Hebrew (DOS)", 862);
            m_encodingList.Add("Hebrew (ISO-Logical)", 38598);
            m_encodingList.Add("Hebrew (ISO-Visual)", 28598);
            m_encodingList.Add("Hebrew (Windows)", 1255);
            m_encodingList.Add("Japanese (EUC)", 51932);
            m_encodingList.Add("Japanese (Shift-JIS)", 932);
            m_encodingList.Add("Korean", 949);
            m_encodingList.Add("Thai (Windows)", 874);
            m_encodingList.Add("Turkish (ISO)", 28599);
            m_encodingList.Add("Turkish (Windows)", 1254);
            m_encodingList.Add("Unicode (UTF-8)", 65001);
            m_encodingList.Add("Vietnamese (Windows)", 1258);
            m_encodingList.Add("Western European (ISO)", 28591);
            m_encodingList.Add("Western European (Windows)", 1252);

            encodingListComboBox.DataSource = new BindingSource(m_encodingList, null);
            encodingListComboBox.DisplayMember = "Key";
            encodingListComboBox.ValueMember = "Value";

        }

        private void aLLAHcomMuhammadcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "www.allah.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFileName.Text = LoadFileDialogBox();

            LoadBookFile(txtFileName.Text);
        }

        private string LoadFileDialogBox()
        {
            of1.FileName = Environment.CurrentDirectory;
            DialogResult dr = of1.ShowDialog();
            if (dr == DialogResult.OK)
                return of1.FileName;

            return "";
        }

        

        /// <summary>
        /// Load Input File for reading
        /// </summary>
        private void LoadBookFile(string bookFileName)
        {
            if (bookFileName == "") return;            

            String wholeFileText;
            using (TextReader reader = new StreamReader(bookFileName, Encoding.UTF8))
            {
                wholeFileText = reader.ReadToEnd();
            }

            //.NET GC is kind but still clear memory from last book
            if (m_sections != null && m_sections.Length > 0)
            {
                Array.Clear(m_sections, 0, m_sections.Length);    
            }

            m_sections = wholeFileText.Split(new string[] { m_splitCharacter }, StringSplitOptions.RemoveEmptyEntries);
            
            //if no splitter character is found in the book then combine N lines and make one section (page) out of it
            if (m_sections.Length <= 1)
            {
                // clear memory
                wholeFileText = ""; 
                Array.Clear(m_sections, 0, m_sections.Length);

                var sections = new List<string>();
                
                String[] lines = File.ReadAllLines(bookFileName, Encoding.UTF8);
                var combinedLines = new StringBuilder();
                for (int i = 0; i < lines.Length; i++)
                {
                    //once N lines are read, save them as one section in sections LIST<string>
                    if ((i + 1) % (m_LineCountToCombine + 1) == 0)
                    {
                        sections.Add(combinedLines.ToString());
                        combinedLines.Clear();
                    }
                    else
                    {
                        combinedLines.AppendLine(lines[i]);
                    }
                }
                m_sections = sections.ToArray();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtInFolder4Split.Text = GetFolderPath();
        }

        private string GetFolderPath()
        {
            DialogResult dr = fb1.ShowDialog();
            if (dr == DialogResult.OK)
                return fb1.SelectedPath;

            return "";

        }

        

        /// <summary>
        /// Start Task action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStart_Click(object sender, EventArgs e)
        {
            m_fileExtension = chkHTML.Checked ? m_htmlExtension : "txt"; //html-extension is either htm or html in app.config file

            //read all folders list in alphabteical order from input path
            List<String> languageFolders = GetListOfLanguageFolders(m_inputFolder);

            foreach (String langFolder in languageFolders)
            {
                String bookLanguage = Path.GetFileName(langFolder); //returns name of language folder as there are no file names in this path, so we are good.  
                isHTMLRTL = bookLanguage.Equals("arabic", StringComparison.InvariantCultureIgnoreCase) || bookLanguage.Equals("hebrew", StringComparison.InvariantCultureIgnoreCase);
                //get list of all files (book files) from this language folder, sorted
                List<String> booksList = GetListOfAllBooks(langFolder);  
                
                foreach (String bookFile in booksList)
                {
                    String bookName = Path.GetFileNameWithoutExtension(bookFile);

                    //generate book pages from this book file                    
                    GeneratePagesFromBookFile(bookFile, bookLanguage);                                  

                    //copy static files (css/js/img etc.) to very own folder for each book per language
                    CopyAllStaticFoldersAndFiles(m_staticFolder, Path.Combine(m_outputFolder, bookLanguage, bookName.Replace(" ", "-")));
                }                
            }            

            MessageBox.Show("Task Completed, files copied.", "bismillah", MessageBoxButtons.OK);
        }

        private void CopyAllStaticFoldersAndFiles(string sourceFolder, string destinationFolder)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
            proc.StartInfo.Arguments = "\"" + sourceFolder + "\"  \"" + destinationFolder + "\"  /E /I /R /Y /Q";  //"C:\source folder"  "C:\destination folder"  /E /I";
            proc.Start();
            proc.Close();
        }

        private void GeneratePagesFromBookFile(string bookFileName, string bookLanguage)
        {
            LoadBookFile(bookFileName);
            if (m_sections == null || m_sections.Length == 0)
            {
                MessageBox.Show("File not read properly or is empty. (" + txtFileName.Text + ") continuing to next file...");                       
            }
            
            //create output folder for language if does not exist
            if (!Directory.Exists(Path.Combine(m_outputFolder, bookLanguage)))
            {
                Directory.CreateDirectory(Path.Combine(m_outputFolder, bookLanguage));
            }

            string outBookName = Path.GetFileNameWithoutExtension(bookFileName.Replace(" ", "-"));
            MainBookTextProcessing(outBookName, bookLanguage);
        }

        private List<String> GetListOfAllBooks(string languageFolder)
        {
            var bookFiles = Directory.GetFiles(languageFolder).ToList();
            bookFiles.Sort();
            return bookFiles;
        }

        private List<String> GetListOfLanguageFolders(string inputFolder)
        {
            var folders = Directory.GetDirectories(inputFolder).ToList();
            folders.Sort();
            return folders;
        }

        private void MainBookTextProcessing(string bookName, string bookLanguageName)
        {
            TextWriter textWriterFile;            
            string TOCIndexFileName = "";
            for (int sectionNumber = 0; sectionNumber < m_sections.Length; sectionNumber++)
            {

                // to be used in HTML pages
                //subSections[0] only will be used for naming file
                string[] subSections = m_sections[sectionNumber].Split(new char[] { '\r', '\n' });

                string fileSectionName = CleanFileName(subSections[0], bookLanguageName);                

                string prefixPart = m_fileNamePrefix + sectionNumber; //e.g. page1                
                String outputBookFolder = Path.Combine(m_outputFolder, bookLanguageName, bookName);
                if (!Directory.Exists(outputBookFolder))
                {
                    Directory.CreateDirectory(outputBookFolder);
                }

                // e.g. C:\OutData\Arabic\index.html or C:\OutData\Arabic\Page1.html
                String outFileNamePath = (sectionNumber == 0) ? Path.Combine(outputBookFolder, m_IndexFileName) : 
                                                  Path.Combine(outputBookFolder, prefixPart + "." + m_fileExtension);
                
                if (outFileNamePath.Length >= 256)
                {
                    outFileNamePath = outFileNamePath.Substring(0, 255);
                }
                textWriterFile = new StreamWriter(outFileNamePath, false, Encoding.UTF8); 

                if (sectionNumber == 0) // save TOC (index) file name
                {
                    TOCIndexFileName = outFileNamePath;
                }
                else // append topic file names and page links in the TOC (index) file
                {
                    using (StreamWriter writerTOC = new StreamWriter(TOCIndexFileName, append: true, encoding: Encoding.UTF8))
                    {
                        string pageLinkText = String.Format("{0}.{1}", prefixPart, m_fileExtension);
                        writerTOC.WriteLine("<a data-role='button' href='" + pageLinkText + "' rel='external' data-transition='flip' data-theme='a'> " + 
                                                fileSectionName + "</a>");
                        writerTOC.Close();
                    }
                }

                if (chkHTML.Checked)
                {
                    WriteHTMLStructure(textWriterFile, TOCIndexFileName, sectionNumber, subSections);
                }

                else
                { // only text files
                    textWriterFile.WriteLine(m_sections[sectionNumber]);
                    textWriterFile.Close();
                }

                
            }
        }

        private void WriteHTMLStructure(TextWriter textWriterHtml, string TOCIndexFileName, int sectionNumber, string[] subSections)
        {
            
            //a. top section
            if (sectionNumber == 0) //index file
            {
                textWriterHtml.WriteLine(File.ReadAllText(@"Templates\index\index-top-content.txt"));
            }
            else
            {
                //normal pages, TBD according to template
                if (isHTMLRTL)
                {
                    textWriterHtml.Write(@"<html dir=""rtl"">");
                }
                else
                {
                    textWriterHtml.Write("<html>");
                }
                textWriterHtml.WriteLine(@"<head> 
                                           <meta content=""text/html; charset=UTF-8"" http-equiv=""content-type"">
                                           <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
                                           <title>Muhammad.com</title>
                                    </head>
                                    <body>");
            }

            //b. middle content section
            WriteHTMLBodyContent(textWriterHtml, TOCIndexFileName, sectionNumber, subSections);



            //c. bottom section
            if (sectionNumber != 0)
            {
                textWriterHtml.WriteLine("</body></html>");
            }
            else //index file
            {
                textWriterHtml.WriteLine(File.ReadAllText(@"Templates\index\index-bottom-content.txt"));
            }
            
            textWriterHtml.Close();
        }

        private static void WriteHTMLBodyContent(TextWriter tr, string TOCIndexFileName, int sectionNumber, string[] subSections)
        {
            tr.WriteLine("<a href='" + Path.GetFileName(TOCIndexFileName) + "'>Home</a> <br/>"); // Link to Home- TOC file at top
            tr.WriteLine("<h1>" + subSections[0] + "</h1>");

            //skip first line, that is a header
            for (int i = 1; i < subSections.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(subSections[i]))
                {
                    tr.WriteLine("<p>" + subSections[i] + "</p>");
                }              
            }

            if (sectionNumber != 0)
                tr.WriteLine("<br/> <a href='" + Path.GetFileName(TOCIndexFileName) + "'>Home</a> <br/>"); // Link to Home- TOC file at bottom
        }

        private string CleanFileName(string fileName, string languageName)
        {
            if (fileName == null || fileName.Length == 0) return "";

            var sb = new StringBuilder();
            foreach (char c in fileName)
            {
                if (Char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            string fileSectionName = sb.ToString().Trim();
            if (languageName.Equals("english", StringComparison.InvariantCultureIgnoreCase))
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                fileSectionName = textInfo.ToTitleCase(fileSectionName.ToLower());
            }

            return fileSectionName;
        }

      
    }

}























