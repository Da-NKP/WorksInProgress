partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.lstScenes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMainEditor = new System.Windows.Forms.TabPage();
            this.tabMainTestor = new System.Windows.Forms.TabPage();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.txtTestDisplay = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnScenesAdd = new System.Windows.Forms.Button();
            this.btnScenesRemove = new System.Windows.Forms.Button();
            this.lstEditorEventOrder = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDisplayEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisplayEventText = new System.Windows.Forms.TextBox();
            this.btnDisplayTextOk = new System.Windows.Forms.Button();
            this.txtChoiceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChoiceResultText = new System.Windows.Forms.TextBox();
            this.radText = new System.Windows.Forms.RadioButton();
            this.radSystem = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddDisplay = new System.Windows.Forms.Button();
            this.btnAddChoice = new System.Windows.Forms.Button();
            this.btnEventRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMainEditor.SuspendLayout();
            this.tabMainTestor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstScenes
            // 
            this.lstScenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstScenes.FormattingEnabled = true;
            this.lstScenes.Location = new System.Drawing.Point(12, 27);
            this.lstScenes.Name = "lstScenes";
            this.lstScenes.Size = new System.Drawing.Size(120, 444);
            this.lstScenes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuSave,
            this.mnuLoad,
            this.mnuQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.rPGToolStripMenuItem,
            this.devToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(152, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuLoad.Text = "Load";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(152, 22);
            this.mnuQuit.Text = "Quit";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // rPGToolStripMenuItem
            // 
            this.rPGToolStripMenuItem.Name = "rPGToolStripMenuItem";
            this.rPGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rPGToolStripMenuItem.Text = "RPG";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // lstProperties
            // 
            this.lstProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(1132, 27);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(120, 496);
            this.lstProperties.TabIndex = 2;
            // 
            // txtEditor
            // 
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditor.Location = new System.Drawing.Point(12, 537);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(1240, 132);
            this.txtEditor.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabMain);
            this.groupBox1.Location = new System.Drawing.Point(138, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 498);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMainEditor);
            this.tabMain.Controls.Add(this.tabMainTestor);
            this.tabMain.Location = new System.Drawing.Point(3, 16);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(979, 476);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // tabMainEditor
            // 
            this.tabMainEditor.BackColor = System.Drawing.Color.White;
            this.tabMainEditor.Controls.Add(this.btnEventRemove);
            this.tabMainEditor.Controls.Add(this.btnAddChoice);
            this.tabMainEditor.Controls.Add(this.btnAddDisplay);
            this.tabMainEditor.Controls.Add(this.groupBox2);
            this.tabMainEditor.Controls.Add(this.lstEditorEventOrder);
            this.tabMainEditor.Location = new System.Drawing.Point(4, 22);
            this.tabMainEditor.Name = "tabMainEditor";
            this.tabMainEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainEditor.Size = new System.Drawing.Size(971, 450);
            this.tabMainEditor.TabIndex = 0;
            this.tabMainEditor.Text = "Editor";
            // 
            // tabMainTestor
            // 
            this.tabMainTestor.Controls.Add(this.btnNext);
            this.tabMainTestor.Controls.Add(this.btnFour);
            this.tabMainTestor.Controls.Add(this.btnThree);
            this.tabMainTestor.Controls.Add(this.btnTwo);
            this.tabMainTestor.Controls.Add(this.btnOne);
            this.tabMainTestor.Controls.Add(this.txtTestDisplay);
            this.tabMainTestor.Location = new System.Drawing.Point(4, 22);
            this.tabMainTestor.Name = "tabMainTestor";
            this.tabMainTestor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainTestor.Size = new System.Drawing.Size(971, 450);
            this.tabMainTestor.TabIndex = 1;
            this.tabMainTestor.Text = "Tester";
            this.tabMainTestor.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFour.Location = new System.Drawing.Point(612, 234);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(353, 72);
            this.btnFour.TabIndex = 14;
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThree.Location = new System.Drawing.Point(612, 158);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(353, 70);
            this.btnThree.TabIndex = 13;
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwo.Location = new System.Drawing.Point(612, 82);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(353, 70);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOne.Location = new System.Drawing.Point(612, 6);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(353, 70);
            this.btnOne.TabIndex = 11;
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // txtTestDisplay
            // 
            this.txtTestDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestDisplay.Location = new System.Drawing.Point(6, 6);
            this.txtTestDisplay.Multiline = true;
            this.txtTestDisplay.Name = "txtTestDisplay";
            this.txtTestDisplay.ReadOnly = true;
            this.txtTestDisplay.Size = new System.Drawing.Size(600, 300);
            this.txtTestDisplay.TabIndex = 10;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(6, 312);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(959, 132);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnScenesAdd
            // 
            this.btnScenesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScenesAdd.Location = new System.Drawing.Point(12, 479);
            this.btnScenesAdd.Name = "btnScenesAdd";
            this.btnScenesAdd.Size = new System.Drawing.Size(120, 23);
            this.btnScenesAdd.TabIndex = 5;
            this.btnScenesAdd.Text = "Add Scene";
            this.btnScenesAdd.UseVisualStyleBackColor = true;
            // 
            // btnScenesRemove
            // 
            this.btnScenesRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScenesRemove.Location = new System.Drawing.Point(12, 508);
            this.btnScenesRemove.Name = "btnScenesRemove";
            this.btnScenesRemove.Size = new System.Drawing.Size(120, 23);
            this.btnScenesRemove.TabIndex = 6;
            this.btnScenesRemove.Text = "Remove Scene";
            this.btnScenesRemove.UseVisualStyleBackColor = true;
            // 
            // lstEditorEventOrder
            // 
            this.lstEditorEventOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEditorEventOrder.FormattingEnabled = true;
            this.lstEditorEventOrder.Location = new System.Drawing.Point(6, 6);
            this.lstEditorEventOrder.Name = "lstEditorEventOrder";
            this.lstEditorEventOrder.Size = new System.Drawing.Size(120, 340);
            this.lstEditorEventOrder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(132, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Editor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisplayTextOk);
            this.groupBox3.Controls.Add(this.txtDisplayEventText);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDisplayEventName);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 413);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DisplayText";
            // 
            // txtDisplayEventName
            // 
            this.txtDisplayEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayEventName.Location = new System.Drawing.Point(78, 32);
            this.txtDisplayEventName.Name = "txtDisplayEventName";
            this.txtDisplayEventName.Size = new System.Drawing.Size(323, 20);
            this.txtDisplayEventName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Text";
            // 
            // txtDisplayEventText
            // 
            this.txtDisplayEventText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayEventText.Location = new System.Drawing.Point(6, 74);
            this.txtDisplayEventText.Multiline = true;
            this.txtDisplayEventText.Name = "txtDisplayEventText";
            this.txtDisplayEventText.Size = new System.Drawing.Size(395, 304);
            this.txtDisplayEventText.TabIndex = 3;
            // 
            // btnDisplayTextOk
            // 
            this.btnDisplayTextOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayTextOk.Location = new System.Drawing.Point(6, 384);
            this.btnDisplayTextOk.Name = "btnDisplayTextOk";
            this.btnDisplayTextOk.Size = new System.Drawing.Size(395, 23);
            this.btnDisplayTextOk.TabIndex = 4;
            this.btnDisplayTextOk.Text = "OK";
            this.btnDisplayTextOk.UseVisualStyleBackColor = true;
            // 
            // txtChoiceText
            // 
            this.txtChoiceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChoiceText.Location = new System.Drawing.Point(73, 32);
            this.txtChoiceText.Name = "txtChoiceText";
            this.txtChoiceText.Size = new System.Drawing.Size(329, 20);
            this.txtChoiceText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ChoiceText";
            // 
            // txtChoiceResultText
            // 
            this.txtChoiceResultText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChoiceResultText.Location = new System.Drawing.Point(6, 81);
            this.txtChoiceResultText.Multiline = true;
            this.txtChoiceResultText.Name = "txtChoiceResultText";
            this.txtChoiceResultText.Size = new System.Drawing.Size(396, 296);
            this.txtChoiceResultText.TabIndex = 4;
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radText.Location = new System.Drawing.Point(92, 58);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(45, 17);
            this.radText.TabIndex = 5;
            this.radText.TabStop = true;
            this.radText.Text = "Text";
            this.radText.UseVisualStyleBackColor = true;
            // 
            // radSystem
            // 
            this.radSystem.AutoSize = true;
            this.radSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radSystem.Location = new System.Drawing.Point(256, 58);
            this.radSystem.Name = "radSystem";
            this.radSystem.Size = new System.Drawing.Size(63, 17);
            this.radSystem.TabIndex = 6;
            this.radSystem.TabStop = true;
            this.radSystem.Text = "Property";
            this.radSystem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(6, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.radSystem);
            this.groupBox4.Controls.Add(this.radText);
            this.groupBox4.Controls.Add(this.txtChoiceResultText);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtChoiceText);
            this.groupBox4.Location = new System.Drawing.Point(419, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 413);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choice";
            // 
            // btnAddDisplay
            // 
            this.btnAddDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDisplay.Location = new System.Drawing.Point(6, 354);
            this.btnAddDisplay.Name = "btnAddDisplay";
            this.btnAddDisplay.Size = new System.Drawing.Size(120, 23);
            this.btnAddDisplay.TabIndex = 2;
            this.btnAddDisplay.Text = "Add DisplayText";
            this.btnAddDisplay.UseVisualStyleBackColor = true;
            // 
            // btnAddChoice
            // 
            this.btnAddChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddChoice.Location = new System.Drawing.Point(6, 387);
            this.btnAddChoice.Name = "btnAddChoice";
            this.btnAddChoice.Size = new System.Drawing.Size(120, 23);
            this.btnAddChoice.TabIndex = 3;
            this.btnAddChoice.Text = "Add Choice";
            this.btnAddChoice.UseVisualStyleBackColor = true;
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventRemove.Location = new System.Drawing.Point(6, 421);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(120, 23);
            this.btnEventRemove.TabIndex = 4;
            this.btnEventRemove.Text = "Remove Event";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result Kind and Text";
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnScenesRemove);
            this.Controls.Add(this.btnScenesAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstScenes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "RPG Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMainEditor.ResumeLayout(false);
            this.tabMainTestor.ResumeLayout(false);
            this.tabMainTestor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstScenes;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuNew;
    private System.Windows.Forms.ToolStripMenuItem mnuSave;
    private System.Windows.Forms.ToolStripMenuItem mnuLoad;
    private System.Windows.Forms.ToolStripMenuItem mnuQuit;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rPGToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
    private System.Windows.Forms.ListBox lstProperties;
    private System.Windows.Forms.TextBox txtEditor;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tabMainEditor;
    private System.Windows.Forms.TabPage tabMainTestor;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnFour;
    private System.Windows.Forms.Button btnThree;
    private System.Windows.Forms.Button btnTwo;
    private System.Windows.Forms.Button btnOne;
    private System.Windows.Forms.TextBox txtTestDisplay;
    private System.Windows.Forms.Button btnScenesAdd;
    private System.Windows.Forms.Button btnScenesRemove;
    private System.Windows.Forms.ListBox lstEditorEventOrder;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnDisplayTextOk;
    private System.Windows.Forms.TextBox txtDisplayEventText;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDisplayEventName;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.RadioButton radSystem;
    private System.Windows.Forms.RadioButton radText;
    private System.Windows.Forms.TextBox txtChoiceResultText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtChoiceText;
    private System.Windows.Forms.Button btnEventRemove;
    private System.Windows.Forms.Button btnAddChoice;
    private System.Windows.Forms.Button btnAddDisplay;
    private System.Windows.Forms.Label label4;
}