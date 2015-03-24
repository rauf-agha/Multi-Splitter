namespace Splitter
{
    partial class SplitterLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitterLoader));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLAHcomMuhammadcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.of1 = new System.Windows.Forms.OpenFileDialog();
            this.fb1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerPause = new System.Windows.Forms.Timer(this.components);
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encodingListComboBox = new System.Windows.Forms.ComboBox();
            this.lnkSplitOutFolder = new System.Windows.Forms.LinkLabel();
            this.chkHTML = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInFolder4Split = new System.Windows.Forms.TextBox();
            this.txtSplitChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLLAHcomMuhammadcomToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aLLAHcomMuhammadcomToolStripMenuItem
            // 
            this.aLLAHcomMuhammadcomToolStripMenuItem.Name = "aLLAHcomMuhammadcomToolStripMenuItem";
            this.aLLAHcomMuhammadcomToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aLLAHcomMuhammadcomToolStripMenuItem.Text = "ALLAH.com Muhammad.com";
            this.aLLAHcomMuhammadcomToolStripMenuItem.Click += new System.EventHandler(this.aLLAHcomMuhammadcomToolStripMenuItem_Click);
            // 
            // of1
            // 
            this.of1.FileName = "openFileDialog1";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split Topics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.encodingListComboBox);
            this.groupBox1.Controls.Add(this.lnkSplitOutFolder);
            this.groupBox1.Controls.Add(this.chkHTML);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdStart);
            this.groupBox1.Controls.Add(this.txtPrefix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtInFolder4Split);
            this.groupBox1.Controls.Add(this.txtSplitChar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Choose Default Encoding: ";
            // 
            // encodingListComboBox
            // 
            this.encodingListComboBox.FormattingEnabled = true;
            this.encodingListComboBox.Location = new System.Drawing.Point(151, 22);
            this.encodingListComboBox.Name = "encodingListComboBox";
            this.encodingListComboBox.Size = new System.Drawing.Size(171, 21);
            this.encodingListComboBox.TabIndex = 42;
            // 
            // lnkSplitOutFolder
            // 
            this.lnkSplitOutFolder.AutoSize = true;
            this.lnkSplitOutFolder.Location = new System.Drawing.Point(6, 131);
            this.lnkSplitOutFolder.Name = "lnkSplitOutFolder";
            this.lnkSplitOutFolder.Size = new System.Drawing.Size(95, 13);
            this.lnkSplitOutFolder.TabIndex = 41;
            this.lnkSplitOutFolder.TabStop = true;
            this.lnkSplitOutFolder.Text = "Destination Folder:";
            // 
            // chkHTML
            // 
            this.chkHTML.AutoSize = true;
            this.chkHTML.Checked = true;
            this.chkHTML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHTML.Location = new System.Drawing.Point(9, 201);
            this.chkHTML.Name = "chkHTML";
            this.chkHTML.Size = new System.Drawing.Size(110, 17);
            this.chkHTML.TabIndex = 12;
            this.chkHTML.Text = "Make HTML Files";
            this.chkHTML.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 10);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(107, 225);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(87, 29);
            this.cmdStart.TabIndex = 10;
            this.cmdStart.Text = "Start Task";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(107, 163);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(389, 20);
            this.txtPrefix.TabIndex = 9;
            this.txtPrefix.Text = "Koran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Target File Prefix:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInFolder4Split
            // 
            this.txtInFolder4Split.Location = new System.Drawing.Point(107, 128);
            this.txtInFolder4Split.Name = "txtInFolder4Split";
            this.txtInFolder4Split.Size = new System.Drawing.Size(389, 20);
            this.txtInFolder4Split.TabIndex = 6;
            // 
            // txtSplitChar
            // 
            this.txtSplitChar.Location = new System.Drawing.Point(107, 99);
            this.txtSplitChar.Name = "txtSplitChar";
            this.txtSplitChar.Size = new System.Drawing.Size(389, 20);
            this.txtSplitChar.TabIndex = 4;
            this.txtSplitChar.Text = "@";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Split Character:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(107, 70);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(389, 20);
            this.txtFileName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose File:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // SplitterLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 410);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SplitterLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Data Splitter";
            this.Load += new System.EventHandler(this.SplitterLoader_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLAHcomMuhammadcomToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog of1;
        private System.Windows.Forms.FolderBrowserDialog fb1;
        private System.Windows.Forms.Timer timerPause;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker bgWorker2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox encodingListComboBox;
        private System.Windows.Forms.LinkLabel lnkSplitOutFolder;
        private System.Windows.Forms.CheckBox chkHTML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInFolder4Split;
        private System.Windows.Forms.TextBox txtSplitChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

