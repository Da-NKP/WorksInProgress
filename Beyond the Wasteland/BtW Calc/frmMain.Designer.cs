partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.radD100 = new System.Windows.Forms.RadioButton();
            this.radD20 = new System.Windows.Forms.RadioButton();
            this.radD6 = new System.Windows.Forms.RadioButton();
            this.txtSkill = new System.Windows.Forms.TextBox();
            this.txtTaskDifficulty = new System.Windows.Forms.TextBox();
            this.txtChanceSuccess = new System.Windows.Forms.TextBox();
            this.btnCalcSuccess = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSkillSheet = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.radItems = new System.Windows.Forms.RadioButton();
            this.radSpells = new System.Windows.Forms.RadioButton();
            this.radPerks = new System.Windows.Forms.RadioButton();
            this.radTraits = new System.Windows.Forms.RadioButton();
            this.radBio = new System.Windows.Forms.RadioButton();
            this.btnDisplayDetail = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCarry = new System.Windows.Forms.TextBox();
            this.txtEndurance = new System.Windows.Forms.TextBox();
            this.txtAgility = new System.Windows.Forms.TextBox();
            this.txtSurvival = new System.Windows.Forms.TextBox();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtMelee = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLockPick = new System.Windows.Forms.TextBox();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtElectricWeapons = new System.Windows.Forms.TextBox();
            this.txtBarter = new System.Windows.Forms.TextBox();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.txtPerception = new System.Windows.Forms.TextBox();
            this.txtSneak = new System.Windows.Forms.TextBox();
            this.txtRepair = new System.Windows.Forms.TextBox();
            this.txtGuns = new System.Windows.Forms.TextBox();
            this.txtExplosion = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboReferenceBot = new System.Windows.Forms.ComboBox();
            this.btnRefernce = new System.Windows.Forms.Button();
            this.cboReferenceTop = new System.Windows.Forms.ComboBox();
            this.txtMainDisplay = new System.Windows.Forms.TextBox();
            this.btnSupport = new System.Windows.Forms.Button();
            this.radManualImport = new System.Windows.Forms.RadioButton();
            this.radSupportProgram = new System.Windows.Forms.RadioButton();
            this.radAutoSave = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Difficulty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chance of Success";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Roll Option";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoll);
            this.groupBox1.Controls.Add(this.btnRoll);
            this.groupBox1.Controls.Add(this.radD100);
            this.groupBox1.Controls.Add(this.radD20);
            this.groupBox1.Controls.Add(this.radD6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(499, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Die Roll";
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(87, 70);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.ReadOnly = true;
            this.txtRoll.Size = new System.Drawing.Size(129, 20);
            this.txtRoll.TabIndex = 12;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(6, 68);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 11;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // radD100
            // 
            this.radD100.AutoSize = true;
            this.radD100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radD100.Location = new System.Drawing.Point(144, 36);
            this.radD100.Name = "radD100";
            this.radD100.Size = new System.Drawing.Size(71, 17);
            this.radD100.TabIndex = 6;
            this.radD100.TabStop = true;
            this.radD100.Text = "Roll D100";
            this.radD100.UseVisualStyleBackColor = true;
            // 
            // radD20
            // 
            this.radD20.AutoSize = true;
            this.radD20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radD20.Location = new System.Drawing.Point(72, 36);
            this.radD20.Name = "radD20";
            this.radD20.Size = new System.Drawing.Size(65, 17);
            this.radD20.TabIndex = 5;
            this.radD20.TabStop = true;
            this.radD20.Text = "Roll D20";
            this.radD20.UseVisualStyleBackColor = true;
            // 
            // radD6
            // 
            this.radD6.AutoSize = true;
            this.radD6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radD6.Location = new System.Drawing.Point(6, 36);
            this.radD6.Name = "radD6";
            this.radD6.Size = new System.Drawing.Size(59, 17);
            this.radD6.TabIndex = 4;
            this.radD6.TabStop = true;
            this.radD6.Text = "Roll D6";
            this.radD6.UseVisualStyleBackColor = true;
            // 
            // txtSkill
            // 
            this.txtSkill.Location = new System.Drawing.Point(110, 12);
            this.txtSkill.Name = "txtSkill";
            this.txtSkill.Size = new System.Drawing.Size(100, 20);
            this.txtSkill.TabIndex = 7;
            // 
            // txtTaskDifficulty
            // 
            this.txtTaskDifficulty.Location = new System.Drawing.Point(110, 38);
            this.txtTaskDifficulty.Name = "txtTaskDifficulty";
            this.txtTaskDifficulty.Size = new System.Drawing.Size(100, 20);
            this.txtTaskDifficulty.TabIndex = 8;
            // 
            // txtChanceSuccess
            // 
            this.txtChanceSuccess.Location = new System.Drawing.Point(110, 93);
            this.txtChanceSuccess.Name = "txtChanceSuccess";
            this.txtChanceSuccess.ReadOnly = true;
            this.txtChanceSuccess.Size = new System.Drawing.Size(100, 20);
            this.txtChanceSuccess.TabIndex = 9;
            // 
            // btnCalcSuccess
            // 
            this.btnCalcSuccess.Location = new System.Drawing.Point(135, 64);
            this.btnCalcSuccess.Name = "btnCalcSuccess";
            this.btnCalcSuccess.Size = new System.Drawing.Size(75, 23);
            this.btnCalcSuccess.TabIndex = 10;
            this.btnCalcSuccess.Text = "Calculate!";
            this.btnCalcSuccess.UseVisualStyleBackColor = true;
            this.btnCalcSuccess.Click += new System.EventHandler(this.btnCalcSuccess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSkill);
            this.groupBox2.Controls.Add(this.txtChanceSuccess);
            this.groupBox2.Controls.Add(this.btnCalcSuccess);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTaskDifficulty);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(499, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 127);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skill Chance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtSkillSheet);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.txtRace);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 417);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Local Skill Sheet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            // 
            // txtSkillSheet
            // 
            this.txtSkillSheet.Location = new System.Drawing.Point(6, 258);
            this.txtSkillSheet.Multiline = true;
            this.txtSkillSheet.Name = "txtSkillSheet";
            this.txtSkillSheet.Size = new System.Drawing.Size(469, 89);
            this.txtSkillSheet.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUpdate);
            this.groupBox6.Controls.Add(this.radItems);
            this.groupBox6.Controls.Add(this.radSpells);
            this.groupBox6.Controls.Add(this.radPerks);
            this.groupBox6.Controls.Add(this.radTraits);
            this.groupBox6.Controls.Add(this.radBio);
            this.groupBox6.Controls.Add(this.btnDisplayDetail);
            this.groupBox6.Location = new System.Drawing.Point(6, 353);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(469, 58);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detailed Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(388, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // radItems
            // 
            this.radItems.AutoSize = true;
            this.radItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radItems.Location = new System.Drawing.Point(323, 22);
            this.radItems.Name = "radItems";
            this.radItems.Size = new System.Drawing.Size(49, 17);
            this.radItems.TabIndex = 5;
            this.radItems.TabStop = true;
            this.radItems.Text = "Items";
            this.radItems.UseVisualStyleBackColor = true;
            // 
            // radSpells
            // 
            this.radSpells.AutoSize = true;
            this.radSpells.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radSpells.Location = new System.Drawing.Point(264, 22);
            this.radSpells.Name = "radSpells";
            this.radSpells.Size = new System.Drawing.Size(52, 17);
            this.radSpells.TabIndex = 4;
            this.radSpells.TabStop = true;
            this.radSpells.Text = "Spells";
            this.radSpells.UseVisualStyleBackColor = true;
            // 
            // radPerks
            // 
            this.radPerks.AutoSize = true;
            this.radPerks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radPerks.Location = new System.Drawing.Point(149, 22);
            this.radPerks.Name = "radPerks";
            this.radPerks.Size = new System.Drawing.Size(51, 17);
            this.radPerks.TabIndex = 3;
            this.radPerks.TabStop = true;
            this.radPerks.Text = "Perks";
            this.radPerks.UseVisualStyleBackColor = true;
            // 
            // radTraits
            // 
            this.radTraits.AutoSize = true;
            this.radTraits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radTraits.Location = new System.Drawing.Point(207, 22);
            this.radTraits.Name = "radTraits";
            this.radTraits.Size = new System.Drawing.Size(50, 17);
            this.radTraits.TabIndex = 2;
            this.radTraits.TabStop = true;
            this.radTraits.Text = "Traits";
            this.radTraits.UseVisualStyleBackColor = true;
            // 
            // radBio
            // 
            this.radBio.AutoSize = true;
            this.radBio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radBio.Location = new System.Drawing.Point(103, 22);
            this.radBio.Name = "radBio";
            this.radBio.Size = new System.Drawing.Size(39, 17);
            this.radBio.TabIndex = 1;
            this.radBio.TabStop = true;
            this.radBio.Text = "Bio";
            this.radBio.UseVisualStyleBackColor = true;
            // 
            // btnDisplayDetail
            // 
            this.btnDisplayDetail.Location = new System.Drawing.Point(6, 19);
            this.btnDisplayDetail.Name = "btnDisplayDetail";
            this.btnDisplayDetail.Size = new System.Drawing.Size(84, 23);
            this.btnDisplayDetail.TabIndex = 0;
            this.btnDisplayDetail.Text = "Display";
            this.btnDisplayDetail.UseVisualStyleBackColor = true;
            this.btnDisplayDetail.Click += new System.EventHandler(this.btnDisplayDetail_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtCarry);
            this.groupBox5.Controls.Add(this.txtEndurance);
            this.groupBox5.Controls.Add(this.txtAgility);
            this.groupBox5.Controls.Add(this.txtSurvival);
            this.groupBox5.Controls.Add(this.txtSpeak);
            this.groupBox5.Controls.Add(this.txtScience);
            this.groupBox5.Controls.Add(this.txtMelee);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtLockPick);
            this.groupBox5.Controls.Add(this.txtMedicine);
            this.groupBox5.Controls.Add(this.txtElectricWeapons);
            this.groupBox5.Controls.Add(this.txtBarter);
            this.groupBox5.Controls.Add(this.txtCharisma);
            this.groupBox5.Controls.Add(this.txtPerception);
            this.groupBox5.Controls.Add(this.txtSneak);
            this.groupBox5.Controls.Add(this.txtRepair);
            this.groupBox5.Controls.Add(this.txtGuns);
            this.groupBox5.Controls.Add(this.txtExplosion);
            this.groupBox5.Controls.Add(this.txtIntelligence);
            this.groupBox5.Controls.Add(this.txtStrength);
            this.groupBox5.Controls.Add(this.txtHP);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(6, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 207);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quick Info";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(327, 74);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 52;
            this.label30.Text = "SUR";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(334, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 13);
            this.label29.TabIndex = 51;
            this.label29.Text = "SCI";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(315, 100);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 13);
            this.label28.TabIndex = 50;
            this.label28.Text = "SPEAK";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(25, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 13);
            this.label27.TabIndex = 49;
            this.label27.Text = "AGI";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(327, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 48;
            this.label26.Text = "END";
            // 
            // txtCarry
            // 
            this.txtCarry.Location = new System.Drawing.Point(363, 19);
            this.txtCarry.Name = "txtCarry";
            this.txtCarry.ReadOnly = true;
            this.txtCarry.Size = new System.Drawing.Size(100, 20);
            this.txtCarry.TabIndex = 4;
            this.txtCarry.TabStop = false;
            // 
            // txtEndurance
            // 
            this.txtEndurance.Location = new System.Drawing.Point(363, 45);
            this.txtEndurance.Name = "txtEndurance";
            this.txtEndurance.ReadOnly = true;
            this.txtEndurance.Size = new System.Drawing.Size(100, 20);
            this.txtEndurance.TabIndex = 7;
            this.txtEndurance.TabStop = false;
            // 
            // txtAgility
            // 
            this.txtAgility.Location = new System.Drawing.Point(56, 45);
            this.txtAgility.Name = "txtAgility";
            this.txtAgility.ReadOnly = true;
            this.txtAgility.Size = new System.Drawing.Size(100, 20);
            this.txtAgility.TabIndex = 5;
            this.txtAgility.TabStop = false;
            // 
            // txtSurvival
            // 
            this.txtSurvival.Location = new System.Drawing.Point(363, 71);
            this.txtSurvival.Name = "txtSurvival";
            this.txtSurvival.ReadOnly = true;
            this.txtSurvival.Size = new System.Drawing.Size(100, 20);
            this.txtSurvival.TabIndex = 10;
            this.txtSurvival.TabStop = false;
            // 
            // txtSpeak
            // 
            this.txtSpeak.Location = new System.Drawing.Point(363, 97);
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.ReadOnly = true;
            this.txtSpeak.Size = new System.Drawing.Size(100, 20);
            this.txtSpeak.TabIndex = 13;
            this.txtSpeak.TabStop = false;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(363, 149);
            this.txtScience.Name = "txtScience";
            this.txtScience.ReadOnly = true;
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 19;
            this.txtScience.TabStop = false;
            // 
            // txtMelee
            // 
            this.txtMelee.Location = new System.Drawing.Point(363, 123);
            this.txtMelee.Name = "txtMelee";
            this.txtMelee.ReadOnly = true;
            this.txtMelee.Size = new System.Drawing.Size(100, 20);
            this.txtMelee.TabIndex = 16;
            this.txtMelee.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(315, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "MELEE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "HP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "BOOM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "SNEAK";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(170, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "PICK";
            // 
            // txtLockPick
            // 
            this.txtLockPick.Location = new System.Drawing.Point(207, 173);
            this.txtLockPick.Name = "txtLockPick";
            this.txtLockPick.ReadOnly = true;
            this.txtLockPick.Size = new System.Drawing.Size(100, 20);
            this.txtLockPick.TabIndex = 21;
            this.txtLockPick.TabStop = false;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(207, 149);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.ReadOnly = true;
            this.txtMedicine.Size = new System.Drawing.Size(100, 20);
            this.txtMedicine.TabIndex = 18;
            this.txtMedicine.TabStop = false;
            // 
            // txtElectricWeapons
            // 
            this.txtElectricWeapons.Location = new System.Drawing.Point(207, 123);
            this.txtElectricWeapons.Name = "txtElectricWeapons";
            this.txtElectricWeapons.ReadOnly = true;
            this.txtElectricWeapons.Size = new System.Drawing.Size(100, 20);
            this.txtElectricWeapons.TabIndex = 15;
            this.txtElectricWeapons.TabStop = false;
            // 
            // txtBarter
            // 
            this.txtBarter.Location = new System.Drawing.Point(207, 97);
            this.txtBarter.Name = "txtBarter";
            this.txtBarter.ReadOnly = true;
            this.txtBarter.Size = new System.Drawing.Size(100, 20);
            this.txtBarter.TabIndex = 12;
            this.txtBarter.TabStop = false;
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(207, 71);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.ReadOnly = true;
            this.txtCharisma.Size = new System.Drawing.Size(100, 20);
            this.txtCharisma.TabIndex = 9;
            this.txtCharisma.TabStop = false;
            // 
            // txtPerception
            // 
            this.txtPerception.Location = new System.Drawing.Point(207, 45);
            this.txtPerception.Name = "txtPerception";
            this.txtPerception.ReadOnly = true;
            this.txtPerception.Size = new System.Drawing.Size(100, 20);
            this.txtPerception.TabIndex = 6;
            this.txtPerception.TabStop = false;
            // 
            // txtSneak
            // 
            this.txtSneak.Location = new System.Drawing.Point(56, 177);
            this.txtSneak.Name = "txtSneak";
            this.txtSneak.ReadOnly = true;
            this.txtSneak.Size = new System.Drawing.Size(100, 20);
            this.txtSneak.TabIndex = 20;
            this.txtSneak.TabStop = false;
            // 
            // txtRepair
            // 
            this.txtRepair.Location = new System.Drawing.Point(56, 149);
            this.txtRepair.Name = "txtRepair";
            this.txtRepair.ReadOnly = true;
            this.txtRepair.Size = new System.Drawing.Size(100, 20);
            this.txtRepair.TabIndex = 17;
            this.txtRepair.TabStop = false;
            // 
            // txtGuns
            // 
            this.txtGuns.Location = new System.Drawing.Point(56, 123);
            this.txtGuns.Name = "txtGuns";
            this.txtGuns.ReadOnly = true;
            this.txtGuns.Size = new System.Drawing.Size(100, 20);
            this.txtGuns.TabIndex = 14;
            this.txtGuns.TabStop = false;
            // 
            // txtExplosion
            // 
            this.txtExplosion.Location = new System.Drawing.Point(56, 97);
            this.txtExplosion.Name = "txtExplosion";
            this.txtExplosion.ReadOnly = true;
            this.txtExplosion.Size = new System.Drawing.Size(100, 20);
            this.txtExplosion.TabIndex = 11;
            this.txtExplosion.TabStop = false;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(56, 71);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.ReadOnly = true;
            this.txtIntelligence.Size = new System.Drawing.Size(100, 20);
            this.txtIntelligence.TabIndex = 8;
            this.txtIntelligence.TabStop = false;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(207, 19);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(100, 20);
            this.txtStrength.TabIndex = 3;
            this.txtStrength.TabStop = false;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(56, 19);
            this.txtHP.Name = "txtHP";
            this.txtHP.ReadOnly = true;
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 2;
            this.txtHP.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(172, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "BAR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "EWEP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "REP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "GUNS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "STR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "INT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "PER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "CARRY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "MED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CHA";
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(309, 19);
            this.txtRace.Name = "txtRace";
            this.txtRace.ReadOnly = true;
            this.txtRace.Size = new System.Drawing.Size(166, 20);
            this.txtRace.TabIndex = 1;
            this.txtRace.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Race";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboReferenceBot);
            this.groupBox4.Controls.Add(this.btnRefernce);
            this.groupBox4.Controls.Add(this.cboReferenceTop);
            this.groupBox4.Location = new System.Drawing.Point(499, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 103);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reference";
            // 
            // cboReferenceBot
            // 
            this.cboReferenceBot.FormattingEnabled = true;
            this.cboReferenceBot.Location = new System.Drawing.Point(6, 46);
            this.cboReferenceBot.Name = "cboReferenceBot";
            this.cboReferenceBot.Size = new System.Drawing.Size(209, 21);
            this.cboReferenceBot.TabIndex = 2;
            // 
            // btnRefernce
            // 
            this.btnRefernce.Location = new System.Drawing.Point(72, 73);
            this.btnRefernce.Name = "btnRefernce";
            this.btnRefernce.Size = new System.Drawing.Size(75, 23);
            this.btnRefernce.TabIndex = 1;
            this.btnRefernce.Text = "Go";
            this.btnRefernce.UseVisualStyleBackColor = true;
            this.btnRefernce.Click += new System.EventHandler(this.btnRefernce_Click);
            // 
            // cboReferenceTop
            // 
            this.cboReferenceTop.FormattingEnabled = true;
            this.cboReferenceTop.Location = new System.Drawing.Point(6, 19);
            this.cboReferenceTop.Name = "cboReferenceTop";
            this.cboReferenceTop.Size = new System.Drawing.Size(209, 21);
            this.cboReferenceTop.TabIndex = 0;
            // 
            // txtMainDisplay
            // 
            this.txtMainDisplay.Location = new System.Drawing.Point(12, 435);
            this.txtMainDisplay.Multiline = true;
            this.txtMainDisplay.Name = "txtMainDisplay";
            this.txtMainDisplay.ReadOnly = true;
            this.txtMainDisplay.Size = new System.Drawing.Size(708, 159);
            this.txtMainDisplay.TabIndex = 14;
            // 
            // btnSupport
            // 
            this.btnSupport.Location = new System.Drawing.Point(140, 42);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(75, 23);
            this.btnSupport.TabIndex = 15;
            this.btnSupport.Text = "Go";
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // radManualImport
            // 
            this.radManualImport.AutoSize = true;
            this.radManualImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radManualImport.Location = new System.Drawing.Point(128, 19);
            this.radManualImport.Name = "radManualImport";
            this.radManualImport.Size = new System.Drawing.Size(91, 17);
            this.radManualImport.TabIndex = 16;
            this.radManualImport.TabStop = true;
            this.radManualImport.Text = "Manual Import";
            this.radManualImport.UseVisualStyleBackColor = true;
            // 
            // radSupportProgram
            // 
            this.radSupportProgram.AutoSize = true;
            this.radSupportProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radSupportProgram.Location = new System.Drawing.Point(6, 19);
            this.radSupportProgram.Name = "radSupportProgram";
            this.radSupportProgram.Size = new System.Drawing.Size(88, 17);
            this.radSupportProgram.TabIndex = 17;
            this.radSupportProgram.TabStop = true;
            this.radSupportProgram.Text = "Program Help";
            this.radSupportProgram.UseVisualStyleBackColor = true;
            // 
            // radAutoSave
            // 
            this.radAutoSave.AutoSize = true;
            this.radAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radAutoSave.Location = new System.Drawing.Point(6, 42);
            this.radAutoSave.Name = "radAutoSave";
            this.radAutoSave.Size = new System.Drawing.Size(74, 17);
            this.radAutoSave.TabIndex = 18;
            this.radAutoSave.TabStop = true;
            this.radAutoSave.Text = "Auto Save";
            this.radAutoSave.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radSupportProgram);
            this.groupBox7.Controls.Add(this.btnSupport);
            this.groupBox7.Controls.Add(this.radAutoSave);
            this.groupBox7.Controls.Add(this.radManualImport);
            this.groupBox7.Location = new System.Drawing.Point(499, 121);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(221, 69);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Support";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(732, 606);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.txtMainDisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Bordering the Wastes Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtRoll;
    private System.Windows.Forms.Button btnRoll;
    private System.Windows.Forms.RadioButton radD100;
    private System.Windows.Forms.RadioButton radD20;
    private System.Windows.Forms.RadioButton radD6;
    private System.Windows.Forms.TextBox txtSkill;
    private System.Windows.Forms.TextBox txtTaskDifficulty;
    private System.Windows.Forms.TextBox txtChanceSuccess;
    private System.Windows.Forms.Button btnCalcSuccess;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.RadioButton radItems;
    private System.Windows.Forms.RadioButton radSpells;
    private System.Windows.Forms.RadioButton radPerks;
    private System.Windows.Forms.RadioButton radTraits;
    private System.Windows.Forms.RadioButton radBio;
    private System.Windows.Forms.Button btnDisplayDetail;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.TextBox txtCarry;
    private System.Windows.Forms.TextBox txtEndurance;
    private System.Windows.Forms.TextBox txtAgility;
    private System.Windows.Forms.TextBox txtSurvival;
    private System.Windows.Forms.TextBox txtSpeak;
    private System.Windows.Forms.TextBox txtScience;
    private System.Windows.Forms.TextBox txtMelee;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox txtLockPick;
    private System.Windows.Forms.TextBox txtMedicine;
    private System.Windows.Forms.TextBox txtElectricWeapons;
    private System.Windows.Forms.TextBox txtBarter;
    private System.Windows.Forms.TextBox txtCharisma;
    private System.Windows.Forms.TextBox txtPerception;
    private System.Windows.Forms.TextBox txtRace;
    private System.Windows.Forms.TextBox txtSneak;
    private System.Windows.Forms.TextBox txtRepair;
    private System.Windows.Forms.TextBox txtGuns;
    private System.Windows.Forms.TextBox txtExplosion;
    private System.Windows.Forms.TextBox txtIntelligence;
    private System.Windows.Forms.TextBox txtStrength;
    private System.Windows.Forms.TextBox txtHP;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnRefernce;
    private System.Windows.Forms.ComboBox cboReferenceTop;
    private System.Windows.Forms.TextBox txtMainDisplay;
    private System.Windows.Forms.ComboBox cboReferenceBot;
    private System.Windows.Forms.TextBox txtSkillSheet;
    private System.Windows.Forms.Button btnSupport;
    private System.Windows.Forms.RadioButton radManualImport;
    private System.Windows.Forms.RadioButton radSupportProgram;
    private System.Windows.Forms.RadioButton radAutoSave;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtName;
}