partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveContext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowTopTen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowTopHundred = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowTopThousand = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurpose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevelopment = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnOrderNum = new System.Windows.Forms.Button();
            this.btnOrderAlphaBeta = new System.Windows.Forms.Button();
            this.btnWordContext = new System.Windows.Forms.Button();
            this.lstBigDataOutput = new System.Windows.Forms.ListBox();
            this.lstWordContext = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnPrevWord = new System.Windows.Forms.Button();
            this.btnLastWord = new System.Windows.Forms.Button();
            this.btnFirstWord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSaveDefault,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSaveDefault
            // 
            this.mnuSaveDefault.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveContext,
            this.mnuSaveOriginal,
            this.mnuSaveAnalysis});
            this.mnuSaveDefault.Name = "mnuSaveDefault";
            this.mnuSaveDefault.Size = new System.Drawing.Size(103, 22);
            this.mnuSaveDefault.Text = "Save";
            this.mnuSaveDefault.Click += new System.EventHandler(this.mnuSaveDefault_Click);
            // 
            // mnuSaveContext
            // 
            this.mnuSaveContext.Name = "mnuSaveContext";
            this.mnuSaveContext.Size = new System.Drawing.Size(144, 22);
            this.mnuSaveContext.Text = "Save Context";
            this.mnuSaveContext.Click += new System.EventHandler(this.mnuSaveContext_Click);
            // 
            // mnuSaveOriginal
            // 
            this.mnuSaveOriginal.Name = "mnuSaveOriginal";
            this.mnuSaveOriginal.Size = new System.Drawing.Size(144, 22);
            this.mnuSaveOriginal.Text = "Save Original";
            this.mnuSaveOriginal.Click += new System.EventHandler(this.mnuSaveOriginal_Click);
            // 
            // mnuSaveAnalysis
            // 
            this.mnuSaveAnalysis.Name = "mnuSaveAnalysis";
            this.mnuSaveAnalysis.Size = new System.Drawing.Size(144, 22);
            this.mnuSaveAnalysis.Text = "Save Analysis";
            this.mnuSaveAnalysis.Click += new System.EventHandler(this.mnuSaveAnalysis_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowTopTen,
            this.mnuShowTopHundred,
            this.mnuShowTopThousand});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuShowTopTen
            // 
            this.mnuShowTopTen.Enabled = false;
            this.mnuShowTopTen.Name = "mnuShowTopTen";
            this.mnuShowTopTen.Size = new System.Drawing.Size(121, 22);
            this.mnuShowTopTen.Text = "Top 10";
            this.mnuShowTopTen.Click += new System.EventHandler(this.mnuShowTopTen_Click);
            // 
            // mnuShowTopHundred
            // 
            this.mnuShowTopHundred.Enabled = false;
            this.mnuShowTopHundred.Name = "mnuShowTopHundred";
            this.mnuShowTopHundred.Size = new System.Drawing.Size(121, 22);
            this.mnuShowTopHundred.Text = "Top 100";
            this.mnuShowTopHundred.Click += new System.EventHandler(this.mnuShowTopHundred_Click);
            // 
            // mnuShowTopThousand
            // 
            this.mnuShowTopThousand.Enabled = false;
            this.mnuShowTopThousand.Name = "mnuShowTopThousand";
            this.mnuShowTopThousand.Size = new System.Drawing.Size(121, 22);
            this.mnuShowTopThousand.Text = "Top 1000";
            this.mnuShowTopThousand.Click += new System.EventHandler(this.mnuShowTopThousand_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHowTo,
            this.mnuPurpose,
            this.mnuDevelopment});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mnuHowTo
            // 
            this.mnuHowTo.Name = "mnuHowTo";
            this.mnuHowTo.Size = new System.Drawing.Size(145, 22);
            this.mnuHowTo.Text = "Usage";
            this.mnuHowTo.Click += new System.EventHandler(this.mnuHowTo_Click);
            // 
            // mnuPurpose
            // 
            this.mnuPurpose.Name = "mnuPurpose";
            this.mnuPurpose.Size = new System.Drawing.Size(145, 22);
            this.mnuPurpose.Text = "Purpose";
            this.mnuPurpose.Click += new System.EventHandler(this.mnuPurpose_Click);
            // 
            // mnuDevelopment
            // 
            this.mnuDevelopment.Name = "mnuDevelopment";
            this.mnuDevelopment.Size = new System.Drawing.Size(145, 22);
            this.mnuDevelopment.Text = "Development";
            this.mnuDevelopment.Click += new System.EventHandler(this.mnuDevelopment_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 31);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(327, 139);
            this.txtInput.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(345, 33);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(84, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnOrderNum
            // 
            this.btnOrderNum.Enabled = false;
            this.btnOrderNum.Location = new System.Drawing.Point(345, 60);
            this.btnOrderNum.Name = "btnOrderNum";
            this.btnOrderNum.Size = new System.Drawing.Size(84, 23);
            this.btnOrderNum.TabIndex = 3;
            this.btnOrderNum.Text = "Sort Number";
            this.btnOrderNum.UseVisualStyleBackColor = true;
            this.btnOrderNum.Click += new System.EventHandler(this.btnOrderNum_Click);
            // 
            // btnOrderAlphaBeta
            // 
            this.btnOrderAlphaBeta.Enabled = false;
            this.btnOrderAlphaBeta.Location = new System.Drawing.Point(345, 89);
            this.btnOrderAlphaBeta.Name = "btnOrderAlphaBeta";
            this.btnOrderAlphaBeta.Size = new System.Drawing.Size(84, 23);
            this.btnOrderAlphaBeta.TabIndex = 4;
            this.btnOrderAlphaBeta.Text = "Sort Word";
            this.btnOrderAlphaBeta.UseVisualStyleBackColor = true;
            this.btnOrderAlphaBeta.Click += new System.EventHandler(this.btnOrderAlphaBeta_Click);
            // 
            // btnWordContext
            // 
            this.btnWordContext.Enabled = false;
            this.btnWordContext.Location = new System.Drawing.Point(345, 118);
            this.btnWordContext.Name = "btnWordContext";
            this.btnWordContext.Size = new System.Drawing.Size(84, 23);
            this.btnWordContext.TabIndex = 5;
            this.btnWordContext.Text = "Isolate Word";
            this.btnWordContext.UseVisualStyleBackColor = true;
            this.btnWordContext.Click += new System.EventHandler(this.btnWordContext_Click);
            // 
            // lstBigDataOutput
            // 
            this.lstBigDataOutput.FormattingEnabled = true;
            this.lstBigDataOutput.Location = new System.Drawing.Point(435, 33);
            this.lstBigDataOutput.Name = "lstBigDataOutput";
            this.lstBigDataOutput.Size = new System.Drawing.Size(225, 329);
            this.lstBigDataOutput.TabIndex = 7;
            this.lstBigDataOutput.SelectedIndexChanged += new System.EventHandler(this.lstBigDataOutput_SelectedIndexChanged);
            // 
            // lstWordContext
            // 
            this.lstWordContext.FormattingEnabled = true;
            this.lstWordContext.Location = new System.Drawing.Point(12, 176);
            this.lstWordContext.Name = "lstWordContext";
            this.lstWordContext.Size = new System.Drawing.Size(327, 186);
            this.lstWordContext.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Key Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Instances";
            // 
            // btnNextWord
            // 
            this.btnNextWord.Enabled = false;
            this.btnNextWord.Location = new System.Drawing.Point(345, 305);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(84, 23);
            this.btnNextWord.TabIndex = 11;
            this.btnNextWord.Text = "Next Word";
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // btnPrevWord
            // 
            this.btnPrevWord.Enabled = false;
            this.btnPrevWord.Location = new System.Drawing.Point(345, 276);
            this.btnPrevWord.Name = "btnPrevWord";
            this.btnPrevWord.Size = new System.Drawing.Size(84, 23);
            this.btnPrevWord.TabIndex = 12;
            this.btnPrevWord.Text = "Prev Word";
            this.btnPrevWord.UseVisualStyleBackColor = true;
            this.btnPrevWord.Click += new System.EventHandler(this.btnPrevWord_Click);
            // 
            // btnLastWord
            // 
            this.btnLastWord.Enabled = false;
            this.btnLastWord.Location = new System.Drawing.Point(345, 334);
            this.btnLastWord.Name = "btnLastWord";
            this.btnLastWord.Size = new System.Drawing.Size(84, 23);
            this.btnLastWord.TabIndex = 13;
            this.btnLastWord.Text = "Last Word";
            this.btnLastWord.UseVisualStyleBackColor = true;
            this.btnLastWord.Click += new System.EventHandler(this.btnLastWord_Click);
            // 
            // btnFirstWord
            // 
            this.btnFirstWord.Enabled = false;
            this.btnFirstWord.Location = new System.Drawing.Point(345, 247);
            this.btnFirstWord.Name = "btnFirstWord";
            this.btnFirstWord.Size = new System.Drawing.Size(84, 23);
            this.btnFirstWord.TabIndex = 14;
            this.btnFirstWord.Text = "First Word";
            this.btnFirstWord.UseVisualStyleBackColor = true;
            this.btnFirstWord.Click += new System.EventHandler(this.btnFirstWord_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(673, 369);
            this.Controls.Add(this.btnFirstWord);
            this.Controls.Add(this.btnLastWord);
            this.Controls.Add(this.btnPrevWord);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWordContext);
            this.Controls.Add(this.lstBigDataOutput);
            this.Controls.Add(this.btnWordContext);
            this.Controls.Add(this.btnOrderAlphaBeta);
            this.Controls.Add(this.btnOrderNum);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Large Document Collider";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveDefault;
    private System.Windows.Forms.ToolStripMenuItem mnuExit;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnAnalyze;
    private System.Windows.Forms.Button btnOrderNum;
    private System.Windows.Forms.Button btnOrderAlphaBeta;
    private System.Windows.Forms.Button btnWordContext;
    private System.Windows.Forms.ListBox lstBigDataOutput;
    private System.Windows.Forms.ListBox lstWordContext;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveContext;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveOriginal;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveAnalysis;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuShowTopTen;
    private System.Windows.Forms.ToolStripMenuItem mnuShowTopHundred;
    private System.Windows.Forms.ToolStripMenuItem mnuShowTopThousand;
    private System.Windows.Forms.ToolStripMenuItem mnuHowTo;
    private System.Windows.Forms.ToolStripMenuItem mnuPurpose;
    private System.Windows.Forms.ToolStripMenuItem mnuDevelopment;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnNextWord;
    private System.Windows.Forms.Button btnPrevWord;
    private System.Windows.Forms.Button btnLastWord;
    private System.Windows.Forms.Button btnFirstWord;
}