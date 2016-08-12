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
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlpha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurpose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevelopment = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnWordContext = new System.Windows.Forms.Button();
            this.lstBigDataOutput = new System.Windows.Forms.ListBox();
            this.lstWordContext = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveTerm = new System.Windows.Forms.Button();
            this.btnAddTerm = new System.Windows.Forms.Button();
            this.mnuOpenDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenSearchDict = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenBlacklist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sortToolStripMenuItem,
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
            this.mnuResetDoc,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenDocument,
            this.mnuOpenSearchDict,
            this.mnuOpenBlacklist});
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(161, 22);
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
            this.mnuSaveDefault.Size = new System.Drawing.Size(161, 22);
            this.mnuSaveDefault.Text = "Save";
            this.mnuSaveDefault.Click += new System.EventHandler(this.mnuSaveDefault_Click);
            // 
            // mnuSaveContext
            // 
            this.mnuSaveContext.Name = "mnuSaveContext";
            this.mnuSaveContext.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveContext.Text = "Save Context";
            this.mnuSaveContext.Click += new System.EventHandler(this.mnuSaveContext_Click);
            // 
            // mnuSaveOriginal
            // 
            this.mnuSaveOriginal.Name = "mnuSaveOriginal";
            this.mnuSaveOriginal.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveOriginal.Text = "Save Original";
            this.mnuSaveOriginal.Click += new System.EventHandler(this.mnuSaveOriginal_Click);
            // 
            // mnuSaveAnalysis
            // 
            this.mnuSaveAnalysis.Name = "mnuSaveAnalysis";
            this.mnuSaveAnalysis.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveAnalysis.Text = "Save Analysis";
            this.mnuSaveAnalysis.Click += new System.EventHandler(this.mnuSaveAnalysis_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(161, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortToolStripMenuItem.Text = "Sort By";
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAscending,
            this.mnuDescending});
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.numberToolStripMenuItem.Text = "Number";
            // 
            // mnuAscending
            // 
            this.mnuAscending.Name = "mnuAscending";
            this.mnuAscending.Size = new System.Drawing.Size(152, 22);
            this.mnuAscending.Text = "Most";
            this.mnuAscending.Click += new System.EventHandler(this.mnuAscending_Click);
            // 
            // mnuDescending
            // 
            this.mnuDescending.Name = "mnuDescending";
            this.mnuDescending.Size = new System.Drawing.Size(152, 22);
            this.mnuDescending.Text = "Least";
            this.mnuDescending.Click += new System.EventHandler(this.mnuDescending_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlpha,
            this.mnuReverse});
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wordToolStripMenuItem.Text = "Word";
            // 
            // mnuAlpha
            // 
            this.mnuAlpha.Name = "mnuAlpha";
            this.mnuAlpha.Size = new System.Drawing.Size(152, 22);
            this.mnuAlpha.Text = "Alphabetical";
            this.mnuAlpha.Click += new System.EventHandler(this.mnuAlpha_Click);
            // 
            // mnuReverse
            // 
            this.mnuReverse.Name = "mnuReverse";
            this.mnuReverse.Size = new System.Drawing.Size(152, 22);
            this.mnuReverse.Text = "Reverse";
            this.mnuReverse.Click += new System.EventHandler(this.mnuReverse_Click);
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
            this.mnuHowTo.Size = new System.Drawing.Size(152, 22);
            this.mnuHowTo.Text = "Usage";
            this.mnuHowTo.Click += new System.EventHandler(this.mnuHowTo_Click);
            // 
            // mnuPurpose
            // 
            this.mnuPurpose.Name = "mnuPurpose";
            this.mnuPurpose.Size = new System.Drawing.Size(152, 22);
            this.mnuPurpose.Text = "Purpose";
            this.mnuPurpose.Click += new System.EventHandler(this.mnuPurpose_Click);
            // 
            // mnuDevelopment
            // 
            this.mnuDevelopment.Name = "mnuDevelopment";
            this.mnuDevelopment.Size = new System.Drawing.Size(152, 22);
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
            // btnWordContext
            // 
            this.btnWordContext.Enabled = false;
            this.btnWordContext.Location = new System.Drawing.Point(345, 149);
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
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(345, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveTerm
            // 
            this.btnRemoveTerm.Enabled = false;
            this.btnRemoveTerm.Location = new System.Drawing.Point(345, 120);
            this.btnRemoveTerm.Name = "btnRemoveTerm";
            this.btnRemoveTerm.Size = new System.Drawing.Size(84, 23);
            this.btnRemoveTerm.TabIndex = 16;
            this.btnRemoveTerm.Text = "Remove Term";
            this.btnRemoveTerm.UseVisualStyleBackColor = true;
            this.btnRemoveTerm.Click += new System.EventHandler(this.btnRemoveTerm_Click);
            // 
            // btnAddTerm
            // 
            this.btnAddTerm.Enabled = false;
            this.btnAddTerm.Location = new System.Drawing.Point(345, 91);
            this.btnAddTerm.Name = "btnAddTerm";
            this.btnAddTerm.Size = new System.Drawing.Size(84, 23);
            this.btnAddTerm.TabIndex = 17;
            this.btnAddTerm.Text = "Add Term";
            this.btnAddTerm.UseVisualStyleBackColor = true;
            this.btnAddTerm.Click += new System.EventHandler(this.btnAddTerm_Click);
            // 
            // mnuOpenDocument
            // 
            this.mnuOpenDocument.Name = "mnuOpenDocument";
            this.mnuOpenDocument.Size = new System.Drawing.Size(166, 22);
            this.mnuOpenDocument.Text = "Document";
            this.mnuOpenDocument.Click += new System.EventHandler(this.mnuOpenDocument_Click);
            // 
            // mnuOpenSearchDict
            // 
            this.mnuOpenSearchDict.Name = "mnuOpenSearchDict";
            this.mnuOpenSearchDict.Size = new System.Drawing.Size(166, 22);
            this.mnuOpenSearchDict.Text = "Search Dictionary";
            this.mnuOpenSearchDict.Click += new System.EventHandler(this.mnuOpenSearchDict_Click);
            // 
            // mnuOpenBlacklist
            // 
            this.mnuOpenBlacklist.Name = "mnuOpenBlacklist";
            this.mnuOpenBlacklist.Size = new System.Drawing.Size(166, 22);
            this.mnuOpenBlacklist.Text = "Blacklist";
            this.mnuOpenBlacklist.Click += new System.EventHandler(this.mnuOpenBlacklist_Click);
            // 
            // mnuResetDoc
            // 
            this.mnuResetDoc.Name = "mnuResetDoc";
            this.mnuResetDoc.Size = new System.Drawing.Size(161, 22);
            this.mnuResetDoc.Text = "Reset Document";
            this.mnuResetDoc.Click += new System.EventHandler(this.mnuResetDoc_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(673, 369);
            this.Controls.Add(this.btnAddTerm);
            this.Controls.Add(this.btnRemoveTerm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWordContext);
            this.Controls.Add(this.lstBigDataOutput);
            this.Controls.Add(this.btnWordContext);
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
    private System.Windows.Forms.Button btnWordContext;
    private System.Windows.Forms.ListBox lstBigDataOutput;
    private System.Windows.Forms.ListBox lstWordContext;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveContext;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveOriginal;
    private System.Windows.Forms.ToolStripMenuItem mnuSaveAnalysis;
    private System.Windows.Forms.ToolStripMenuItem mnuHowTo;
    private System.Windows.Forms.ToolStripMenuItem mnuPurpose;
    private System.Windows.Forms.ToolStripMenuItem mnuDevelopment;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuAscending;
    private System.Windows.Forms.ToolStripMenuItem mnuDescending;
    private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuAlpha;
    private System.Windows.Forms.ToolStripMenuItem mnuReverse;
    private System.Windows.Forms.Button btnRemoveTerm;
    private System.Windows.Forms.Button btnAddTerm;
    private System.Windows.Forms.ToolStripMenuItem mnuOpenDocument;
    private System.Windows.Forms.ToolStripMenuItem mnuOpenSearchDict;
    private System.Windows.Forms.ToolStripMenuItem mnuOpenBlacklist;
    private System.Windows.Forms.ToolStripMenuItem mnuResetDoc;
}