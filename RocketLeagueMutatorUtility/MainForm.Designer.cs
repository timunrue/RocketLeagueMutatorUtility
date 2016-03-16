namespace RocketLeagueMutatorUtility
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxRLExeLocation = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonManuallyLocate = new System.Windows.Forms.Button();
            this.groupBoxExeLocation = new System.Windows.Forms.GroupBox();
            this.buttonAutoLocate = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxBotDifficulty = new System.Windows.Forms.MaskedTextBox();
            this.labelBotDifficulty = new System.Windows.Forms.Label();
            this.labelBotNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxNumberBots = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxMutatorDebug = new System.Windows.Forms.CheckBox();
            this.comboBoxMutator = new System.Windows.Forms.ComboBox();
            this.labelMutator = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.checkBoxDebuggerAllowed = new System.Windows.Forms.CheckBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.comboBoxGameMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelRedditPost = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRLRunning = new System.Windows.Forms.Label();
            this.buttonKill = new System.Windows.Forms.Button();
            this.groupBoxPresets = new System.Windows.Forms.GroupBox();
            this.groupBoxExeLocation.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRLExeLocation
            // 
            this.textBoxRLExeLocation.Location = new System.Drawing.Point(6, 19);
            this.textBoxRLExeLocation.Name = "textBoxRLExeLocation";
            this.textBoxRLExeLocation.Size = new System.Drawing.Size(581, 20);
            this.textBoxRLExeLocation.TabIndex = 2;
            this.textBoxRLExeLocation.TextChanged += new System.EventHandler(this.textBoxRLExeLocation_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonManuallyLocate
            // 
            this.buttonManuallyLocate.Location = new System.Drawing.Point(482, 45);
            this.buttonManuallyLocate.Name = "buttonManuallyLocate";
            this.buttonManuallyLocate.Size = new System.Drawing.Size(105, 25);
            this.buttonManuallyLocate.TabIndex = 1;
            this.buttonManuallyLocate.Text = "Manually Locate";
            this.buttonManuallyLocate.UseVisualStyleBackColor = true;
            this.buttonManuallyLocate.Click += new System.EventHandler(this.buttonManuallyLocate_Click);
            // 
            // groupBoxExeLocation
            // 
            this.groupBoxExeLocation.Controls.Add(this.buttonAutoLocate);
            this.groupBoxExeLocation.Controls.Add(this.textBoxRLExeLocation);
            this.groupBoxExeLocation.Controls.Add(this.buttonManuallyLocate);
            this.groupBoxExeLocation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxExeLocation.Name = "groupBoxExeLocation";
            this.groupBoxExeLocation.Size = new System.Drawing.Size(636, 81);
            this.groupBoxExeLocation.TabIndex = 0;
            this.groupBoxExeLocation.TabStop = false;
            this.groupBoxExeLocation.Text = "RocketLeague.exe Location";
            // 
            // buttonAutoLocate
            // 
            this.buttonAutoLocate.Location = new System.Drawing.Point(371, 45);
            this.buttonAutoLocate.Name = "buttonAutoLocate";
            this.buttonAutoLocate.Size = new System.Drawing.Size(105, 25);
            this.buttonAutoLocate.TabIndex = 0;
            this.buttonAutoLocate.Text = "Auto Locate";
            this.buttonAutoLocate.UseVisualStyleBackColor = true;
            this.buttonAutoLocate.Click += new System.EventHandler(this.buttonAutoLocate_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.maskedTextBoxBotDifficulty);
            this.groupBoxSettings.Controls.Add(this.labelBotDifficulty);
            this.groupBoxSettings.Controls.Add(this.labelBotNumber);
            this.groupBoxSettings.Controls.Add(this.maskedTextBoxNumberBots);
            this.groupBoxSettings.Controls.Add(this.checkBoxMutatorDebug);
            this.groupBoxSettings.Controls.Add(this.comboBoxMutator);
            this.groupBoxSettings.Controls.Add(this.labelMutator);
            this.groupBoxSettings.Controls.Add(this.comboBoxDifficulty);
            this.groupBoxSettings.Controls.Add(this.checkBoxDebuggerAllowed);
            this.groupBoxSettings.Controls.Add(this.checkBoxLog);
            this.groupBoxSettings.Controls.Add(this.comboBoxGameMode);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.comboBoxMap);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Controls.Add(this.comboBoxGame);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Location = new System.Drawing.Point(13, 100);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(586, 131);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // maskedTextBoxBotDifficulty
            // 
            this.maskedTextBoxBotDifficulty.Location = new System.Drawing.Point(549, 95);
            this.maskedTextBoxBotDifficulty.Mask = "0.00";
            this.maskedTextBoxBotDifficulty.Name = "maskedTextBoxBotDifficulty";
            this.maskedTextBoxBotDifficulty.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBoxBotDifficulty.TabIndex = 15;
            this.maskedTextBoxBotDifficulty.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxBotDifficulty_MaskInputRejected);
            // 
            // labelBotDifficulty
            // 
            this.labelBotDifficulty.AutoSize = true;
            this.labelBotDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotDifficulty.Location = new System.Drawing.Point(459, 98);
            this.labelBotDifficulty.Name = "labelBotDifficulty";
            this.labelBotDifficulty.Size = new System.Drawing.Size(84, 13);
            this.labelBotDifficulty.TabIndex = 14;
            this.labelBotDifficulty.Text = "Bot Difficulty:";
            // 
            // labelBotNumber
            // 
            this.labelBotNumber.AutoSize = true;
            this.labelBotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotNumber.Location = new System.Drawing.Point(322, 98);
            this.labelBotNumber.Name = "labelBotNumber";
            this.labelBotNumber.Size = new System.Drawing.Size(98, 13);
            this.labelBotNumber.TabIndex = 13;
            this.labelBotNumber.Text = "Number of Bots:";
            // 
            // maskedTextBoxNumberBots
            // 
            this.maskedTextBoxNumberBots.Location = new System.Drawing.Point(427, 94);
            this.maskedTextBoxNumberBots.Mask = "90";
            this.maskedTextBoxNumberBots.Name = "maskedTextBoxNumberBots";
            this.maskedTextBoxNumberBots.Size = new System.Drawing.Size(19, 20);
            this.maskedTextBoxNumberBots.TabIndex = 12;
            this.maskedTextBoxNumberBots.TextChanged += new System.EventHandler(this.maskedTextBoxNumberBots_TextChanged);
            // 
            // checkBoxMutatorDebug
            // 
            this.checkBoxMutatorDebug.AutoSize = true;
            this.checkBoxMutatorDebug.Location = new System.Drawing.Point(522, 67);
            this.checkBoxMutatorDebug.Name = "checkBoxMutatorDebug";
            this.checkBoxMutatorDebug.Size = new System.Drawing.Size(58, 17);
            this.checkBoxMutatorDebug.TabIndex = 11;
            this.checkBoxMutatorDebug.Text = "Debug";
            this.checkBoxMutatorDebug.UseVisualStyleBackColor = true;
            this.checkBoxMutatorDebug.CheckedChanged += new System.EventHandler(this.checkBoxMutatorDebug_CheckedChanged);
            // 
            // comboBoxMutator
            // 
            this.comboBoxMutator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMutator.FormattingEnabled = true;
            this.comboBoxMutator.Items.AddRange(new object[] {
            "Aerial",
            "FreePlay",
            "Goalie",
            "Striker"});
            this.comboBoxMutator.Location = new System.Drawing.Point(325, 63);
            this.comboBoxMutator.Name = "comboBoxMutator";
            this.comboBoxMutator.Size = new System.Drawing.Size(191, 21);
            this.comboBoxMutator.TabIndex = 10;
            this.comboBoxMutator.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMutator_SelectionChangeCommitted);
            // 
            // labelMutator
            // 
            this.labelMutator.AutoSize = true;
            this.labelMutator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMutator.Location = new System.Drawing.Point(265, 68);
            this.labelMutator.Name = "labelMutator";
            this.labelMutator.Size = new System.Drawing.Size(54, 13);
            this.labelMutator.TabIndex = 9;
            this.labelMutator.Text = "Mutator:";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(462, 30);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(118, 21);
            this.comboBoxDifficulty.TabIndex = 8;
            this.comboBoxDifficulty.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDifficulty_SelectionChangeCommitted);
            // 
            // checkBoxDebuggerAllowed
            // 
            this.checkBoxDebuggerAllowed.AutoSize = true;
            this.checkBoxDebuggerAllowed.Location = new System.Drawing.Point(114, 97);
            this.checkBoxDebuggerAllowed.Name = "checkBoxDebuggerAllowed";
            this.checkBoxDebuggerAllowed.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDebuggerAllowed.TabIndex = 7;
            this.checkBoxDebuggerAllowed.Text = "Allow Debugger";
            this.checkBoxDebuggerAllowed.UseVisualStyleBackColor = true;
            this.checkBoxDebuggerAllowed.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Location = new System.Drawing.Point(55, 97);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(59, 17);
            this.checkBoxLog.TabIndex = 6;
            this.checkBoxLog.Text = "Logger";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // comboBoxGameMode
            // 
            this.comboBoxGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGameMode.FormattingEnabled = true;
            this.comboBoxGameMode.Items.AddRange(new object[] {
            "Aerial",
            "FreePlay",
            "Goalie",
            "Striker"});
            this.comboBoxGameMode.Location = new System.Drawing.Point(325, 30);
            this.comboBoxGameMode.Name = "comboBoxGameMode";
            this.comboBoxGameMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGameMode.TabIndex = 5;
            this.comboBoxGameMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxGameMode_SelectedIndexChanged);
            this.comboBoxGameMode.SelectionChangeCommitted += new System.EventHandler(this.comboBoxGameMode_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Mode:";
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Items.AddRange(new object[] {
            "Beckwith Park",
            "Beckwith Park (Midnight)",
            "Beckwith Park (Stormy)",
            "DFH Stadium",
            "DFH Stadium (Snowy)",
            "Double Goal (Rocket Labs)",
            "Mannfield",
            "Mannfield (Stormy)",
            "Underpass (Rocket Labs)",
            "Urban Central",
            "Urban Central (Night)",
            "Utopia Coliseum",
            "Utopia Coliseum (Dusk)",
            "Utopia Retro (Rocket Labs)",
            "Wasteland"});
            this.comboBoxMap.Location = new System.Drawing.Point(55, 30);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(160, 21);
            this.comboBoxMap.TabIndex = 1;
            this.comboBoxMap.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMap_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Map:";
            // 
            // comboBoxGame
            // 
            this.comboBoxGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGame.FormattingEnabled = true;
            this.comboBoxGame.Location = new System.Drawing.Point(55, 63);
            this.comboBoxGame.Name = "comboBoxGame";
            this.comboBoxGame.Size = new System.Drawing.Size(160, 21);
            this.comboBoxGame.TabIndex = 3;
            this.comboBoxGame.SelectionChangeCommitted += new System.EventHandler(this.comboBoxGame_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game:";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(319, 339);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(280, 33);
            this.buttonLaunch.TabIndex = 2;
            this.buttonLaunch.Text = "Launch Game";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelRedditPost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // linkLabelRedditPost
            // 
            this.linkLabelRedditPost.AutoSize = true;
            this.linkLabelRedditPost.Location = new System.Drawing.Point(14, 16);
            this.linkLabelRedditPost.Name = "linkLabelRedditPost";
            this.linkLabelRedditPost.Size = new System.Drawing.Size(55, 13);
            this.linkLabelRedditPost.TabIndex = 0;
            this.linkLabelRedditPost.TabStop = true;
            this.linkLabelRedditPost.Text = "linkLabel1";
            this.linkLabelRedditPost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRedditPost_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Coded by ObeseCamelz";
            // 
            // labelRLRunning
            // 
            this.labelRLRunning.AutoSize = true;
            this.labelRLRunning.Location = new System.Drawing.Point(319, 383);
            this.labelRLRunning.Name = "labelRLRunning";
            this.labelRLRunning.Size = new System.Drawing.Size(144, 13);
            this.labelRLRunning.TabIndex = 4;
            this.labelRLRunning.Text = "Rocket League Not Running";
            // 
            // buttonKill
            // 
            this.buttonKill.Location = new System.Drawing.Point(518, 378);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(81, 23);
            this.buttonKill.TabIndex = 5;
            this.buttonKill.Text = "Kill Process";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // groupBoxPresets
            // 
            this.groupBoxPresets.Location = new System.Drawing.Point(13, 238);
            this.groupBoxPresets.Name = "groupBoxPresets";
            this.groupBoxPresets.Size = new System.Drawing.Size(586, 95);
            this.groupBoxPresets.TabIndex = 6;
            this.groupBoxPresets.TabStop = false;
            this.groupBoxPresets.Text = "Presets";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 408);
            this.Controls.Add(this.groupBoxPresets);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.labelRLRunning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxExeLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mutator Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxExeLocation.ResumeLayout(false);
            this.groupBoxExeLocation.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRLExeLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonManuallyLocate;
        private System.Windows.Forms.GroupBox groupBoxExeLocation;
        private System.Windows.Forms.Button buttonAutoLocate;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGameMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelRedditPost;
        private System.Windows.Forms.CheckBox checkBoxDebuggerAllowed;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.ComboBox comboBoxMutator;
        private System.Windows.Forms.Label labelMutator;
        private System.Windows.Forms.Label labelRLRunning;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.CheckBox checkBoxMutatorDebug;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBotDifficulty;
        private System.Windows.Forms.Label labelBotDifficulty;
        private System.Windows.Forms.Label labelBotNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberBots;
        private System.Windows.Forms.GroupBox groupBoxPresets;
    }
}

