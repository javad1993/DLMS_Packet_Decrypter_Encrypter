namespace DLMS_Packet_Decrypter_Encrypter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbEandA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbEncrypted = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbAuthenticated = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblInputText = new System.Windows.Forms.Label();
            this.txtInputText = new System.Windows.Forms.RichTextBox();
            this.txtFrameCounter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.RichTextBox();
            this.txtOutputText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAction = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEK = new System.Windows.Forms.ComboBox();
            this.cmbAK = new System.Windows.Forms.ComboBox();
            this.cmbSystemTitle = new System.Windows.Forms.ComboBox();
            this.rdbEncryption = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbDecryption = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRayatinLink = new System.Windows.Forms.LinkLabel();
            this.btnRemoveSystemTitle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRemoveAK = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRemoveEK = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSaveSystemTitle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSaveAK = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSaveEK = new Guna.UI2.WinForms.Guna2ImageButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption Key (16 Bytes)";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authentication Key (16 Bytes)";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "System Title";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frame Counter (4 bytes)";
            this.label4.UseWaitCursor = true;
            // 
            // rdbEandA
            // 
            this.rdbEandA.AutoSize = true;
            this.rdbEandA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEandA.CheckedState.BorderThickness = 0;
            this.rdbEandA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEandA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbEandA.CheckedState.InnerOffset = -4;
            this.rdbEandA.ForeColor = System.Drawing.Color.White;
            this.rdbEandA.Location = new System.Drawing.Point(436, 27);
            this.rdbEandA.Name = "rdbEandA";
            this.rdbEandA.Size = new System.Drawing.Size(184, 17);
            this.rdbEandA.TabIndex = 9;
            this.rdbEandA.TabStop = true;
            this.rdbEandA.Text = "Encrypted and Authebticated (30)";
            this.rdbEandA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbEandA.UncheckedState.BorderThickness = 2;
            this.rdbEandA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbEandA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbEandA.UseVisualStyleBackColor = true;
            this.rdbEandA.UseWaitCursor = true;
            this.rdbEandA.CheckedChanged += new System.EventHandler(this.rdbEandA_CheckedChanged);
            // 
            // rdbEncrypted
            // 
            this.rdbEncrypted.AutoSize = true;
            this.rdbEncrypted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEncrypted.CheckedState.BorderThickness = 0;
            this.rdbEncrypted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEncrypted.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbEncrypted.CheckedState.InnerOffset = -4;
            this.rdbEncrypted.ForeColor = System.Drawing.Color.White;
            this.rdbEncrypted.Location = new System.Drawing.Point(333, 27);
            this.rdbEncrypted.Name = "rdbEncrypted";
            this.rdbEncrypted.Size = new System.Drawing.Size(94, 17);
            this.rdbEncrypted.TabIndex = 10;
            this.rdbEncrypted.TabStop = true;
            this.rdbEncrypted.Text = "Encrypted (20)";
            this.rdbEncrypted.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbEncrypted.UncheckedState.BorderThickness = 2;
            this.rdbEncrypted.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbEncrypted.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbEncrypted.UseVisualStyleBackColor = true;
            this.rdbEncrypted.UseWaitCursor = true;
            this.rdbEncrypted.CheckedChanged += new System.EventHandler(this.rdbEncrypted_CheckedChanged);
            // 
            // rdbAuthenticated
            // 
            this.rdbAuthenticated.AutoSize = true;
            this.rdbAuthenticated.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbAuthenticated.CheckedState.BorderThickness = 0;
            this.rdbAuthenticated.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbAuthenticated.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbAuthenticated.CheckedState.InnerOffset = -4;
            this.rdbAuthenticated.ForeColor = System.Drawing.Color.White;
            this.rdbAuthenticated.Location = new System.Drawing.Point(211, 27);
            this.rdbAuthenticated.Name = "rdbAuthenticated";
            this.rdbAuthenticated.Size = new System.Drawing.Size(112, 17);
            this.rdbAuthenticated.TabIndex = 11;
            this.rdbAuthenticated.TabStop = true;
            this.rdbAuthenticated.Text = "Authenticated (10)";
            this.rdbAuthenticated.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbAuthenticated.UncheckedState.BorderThickness = 2;
            this.rdbAuthenticated.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbAuthenticated.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbAuthenticated.UseVisualStyleBackColor = true;
            this.rdbAuthenticated.UseWaitCursor = true;
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.ForeColor = System.Drawing.Color.White;
            this.lblInputText.Location = new System.Drawing.Point(59, 298);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(61, 13);
            this.lblInputText.TabIndex = 13;
            this.lblInputText.Text = "Cipher Text";
            this.lblInputText.UseWaitCursor = true;
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(211, 250);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(384, 96);
            this.txtInputText.TabIndex = 14;
            this.txtInputText.Text = "";
            this.txtInputText.UseWaitCursor = true;
            // 
            // txtFrameCounter
            // 
            this.txtFrameCounter.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtFrameCounter.DefaultText = "";
            this.txtFrameCounter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrameCounter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrameCounter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrameCounter.DisabledState.Parent = this.txtFrameCounter;
            this.txtFrameCounter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrameCounter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrameCounter.FocusedState.Parent = this.txtFrameCounter;
            this.txtFrameCounter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFrameCounter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrameCounter.HoverState.Parent = this.txtFrameCounter;
            this.txtFrameCounter.Location = new System.Drawing.Point(211, 212);
            this.txtFrameCounter.Name = "txtFrameCounter";
            this.txtFrameCounter.PasswordChar = '\0';
            this.txtFrameCounter.PlaceholderText = "";
            this.txtFrameCounter.SelectedText = "";
            this.txtFrameCounter.ShadowDecoration.Parent = this.txtFrameCounter;
            this.txtFrameCounter.Size = new System.Drawing.Size(131, 26);
            this.txtFrameCounter.TabIndex = 15;
            this.txtFrameCounter.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tag";
            this.label6.UseWaitCursor = true;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(208, 377);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(384, 26);
            this.txtTag.TabIndex = 17;
            this.txtTag.Text = "";
            this.txtTag.UseWaitCursor = true;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(208, 433);
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(384, 96);
            this.txtOutputText.TabIndex = 18;
            this.txtOutputText.Text = "";
            this.txtOutputText.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Output Text";
            this.label7.UseWaitCursor = true;
            // 
            // btnAction
            // 
            this.btnAction.CheckedState.Parent = this.btnAction;
            this.btnAction.CustomImages.Parent = this.btnAction;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.HoverState.Parent = this.btnAction;
            this.btnAction.Location = new System.Drawing.Point(481, 533);
            this.btnAction.Name = "btnAction";
            this.btnAction.ShadowDecoration.Parent = this.btnAction;
            this.btnAction.Size = new System.Drawing.Size(111, 27);
            this.btnAction.TabIndex = 20;
            this.btnAction.Text = "Action";
            this.btnAction.UseWaitCursor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // cmbEK
            // 
            this.cmbEK.BackColor = System.Drawing.Color.White;
            this.cmbEK.DropDownHeight = 130;
            this.cmbEK.FormattingEnabled = true;
            this.cmbEK.IntegralHeight = false;
            this.cmbEK.ItemHeight = 13;
            this.cmbEK.Location = new System.Drawing.Point(211, 88);
            this.cmbEK.MaximumSize = new System.Drawing.Size(381, 0);
            this.cmbEK.Name = "cmbEK";
            this.cmbEK.Size = new System.Drawing.Size(381, 21);
            this.cmbEK.TabIndex = 22;
            this.cmbEK.UseWaitCursor = true;
            // 
            // cmbAK
            // 
            this.cmbAK.BackColor = System.Drawing.Color.White;
            this.cmbAK.DropDownHeight = 130;
            this.cmbAK.FormattingEnabled = true;
            this.cmbAK.IntegralHeight = false;
            this.cmbAK.ItemHeight = 13;
            this.cmbAK.Location = new System.Drawing.Point(211, 132);
            this.cmbAK.MaximumSize = new System.Drawing.Size(381, 0);
            this.cmbAK.Name = "cmbAK";
            this.cmbAK.Size = new System.Drawing.Size(381, 21);
            this.cmbAK.TabIndex = 23;
            this.cmbAK.UseWaitCursor = true;
            // 
            // cmbSystemTitle
            // 
            this.cmbSystemTitle.BackColor = System.Drawing.Color.White;
            this.cmbSystemTitle.DropDownHeight = 130;
            this.cmbSystemTitle.FormattingEnabled = true;
            this.cmbSystemTitle.IntegralHeight = false;
            this.cmbSystemTitle.ItemHeight = 13;
            this.cmbSystemTitle.Location = new System.Drawing.Point(211, 177);
            this.cmbSystemTitle.MaximumSize = new System.Drawing.Size(381, 0);
            this.cmbSystemTitle.Name = "cmbSystemTitle";
            this.cmbSystemTitle.Size = new System.Drawing.Size(277, 21);
            this.cmbSystemTitle.TabIndex = 30;
            this.cmbSystemTitle.UseWaitCursor = true;
            // 
            // rdbEncryption
            // 
            this.rdbEncryption.AutoSize = true;
            this.rdbEncryption.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEncryption.CheckedState.BorderThickness = 0;
            this.rdbEncryption.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbEncryption.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbEncryption.CheckedState.InnerOffset = -4;
            this.rdbEncryption.ForeColor = System.Drawing.Color.White;
            this.rdbEncryption.Location = new System.Drawing.Point(12, 21);
            this.rdbEncryption.Name = "rdbEncryption";
            this.rdbEncryption.Size = new System.Drawing.Size(75, 17);
            this.rdbEncryption.TabIndex = 32;
            this.rdbEncryption.TabStop = true;
            this.rdbEncryption.Text = "Encryption";
            this.rdbEncryption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbEncryption.UncheckedState.BorderThickness = 2;
            this.rdbEncryption.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbEncryption.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbEncryption.UseVisualStyleBackColor = true;
            this.rdbEncryption.UseWaitCursor = true;
            this.rdbEncryption.CheckedChanged += new System.EventHandler(this.rdbEncryption_CheckedChanged);
            // 
            // rdbDecryption
            // 
            this.rdbDecryption.AutoSize = true;
            this.rdbDecryption.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDecryption.CheckedState.BorderThickness = 0;
            this.rdbDecryption.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbDecryption.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbDecryption.CheckedState.InnerOffset = -4;
            this.rdbDecryption.ForeColor = System.Drawing.Color.White;
            this.rdbDecryption.Location = new System.Drawing.Point(12, 45);
            this.rdbDecryption.Name = "rdbDecryption";
            this.rdbDecryption.Size = new System.Drawing.Size(76, 17);
            this.rdbDecryption.TabIndex = 31;
            this.rdbDecryption.TabStop = true;
            this.rdbDecryption.Text = "Decryption";
            this.rdbDecryption.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbDecryption.UncheckedState.BorderThickness = 2;
            this.rdbDecryption.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbDecryption.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbDecryption.UseVisualStyleBackColor = true;
            this.rdbDecryption.UseWaitCursor = true;
            this.rdbDecryption.CheckedChanged += new System.EventHandler(this.rdbDecryption_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbEncryption);
            this.groupBox1.Controls.Add(this.rdbDecryption);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 74);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            this.groupBox1.UseWaitCursor = true;
            // 
            // lblRayatinLink
            // 
            this.lblRayatinLink.AutoSize = true;
            this.lblRayatinLink.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRayatinLink.LinkColor = System.Drawing.Color.White;
            this.lblRayatinLink.Location = new System.Drawing.Point(259, 539);
            this.lblRayatinLink.Name = "lblRayatinLink";
            this.lblRayatinLink.Size = new System.Drawing.Size(136, 21);
            this.lblRayatinLink.TabIndex = 34;
            this.lblRayatinLink.TabStop = true;
            this.lblRayatinLink.Text = "https://rayatin.ir";
            this.lblRayatinLink.UseWaitCursor = true;
            this.lblRayatinLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRayatinLink_LinkClicked);
            // 
            // btnRemoveSystemTitle
            // 
            this.btnRemoveSystemTitle.CheckedState.Parent = this.btnRemoveSystemTitle;
            this.btnRemoveSystemTitle.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px_hover;
            this.btnRemoveSystemTitle.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnRemoveSystemTitle.HoverState.Parent = this.btnRemoveSystemTitle;
            this.btnRemoveSystemTitle.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px;
            this.btnRemoveSystemTitle.Location = new System.Drawing.Point(536, 171);
            this.btnRemoveSystemTitle.Name = "btnRemoveSystemTitle";
            this.btnRemoveSystemTitle.PressedState.Parent = this.btnRemoveSystemTitle;
            this.btnRemoveSystemTitle.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveSystemTitle.TabIndex = 29;
            this.btnRemoveSystemTitle.UseWaitCursor = true;
            this.btnRemoveSystemTitle.Click += new System.EventHandler(this.btnRemoveSystemTitle_Click);
            // 
            // btnRemoveAK
            // 
            this.btnRemoveAK.CheckedState.Parent = this.btnRemoveAK;
            this.btnRemoveAK.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px_hover;
            this.btnRemoveAK.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnRemoveAK.HoverState.Parent = this.btnRemoveAK;
            this.btnRemoveAK.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px;
            this.btnRemoveAK.Location = new System.Drawing.Point(638, 126);
            this.btnRemoveAK.Name = "btnRemoveAK";
            this.btnRemoveAK.PressedState.Parent = this.btnRemoveAK;
            this.btnRemoveAK.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveAK.TabIndex = 28;
            this.btnRemoveAK.UseWaitCursor = true;
            this.btnRemoveAK.Click += new System.EventHandler(this.btnRemoveAK_Click);
            // 
            // btnRemoveEK
            // 
            this.btnRemoveEK.CheckedState.Parent = this.btnRemoveEK;
            this.btnRemoveEK.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px_hover;
            this.btnRemoveEK.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnRemoveEK.HoverState.Parent = this.btnRemoveEK;
            this.btnRemoveEK.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.delete_32px;
            this.btnRemoveEK.Location = new System.Drawing.Point(638, 83);
            this.btnRemoveEK.Name = "btnRemoveEK";
            this.btnRemoveEK.PressedState.Parent = this.btnRemoveEK;
            this.btnRemoveEK.Size = new System.Drawing.Size(32, 32);
            this.btnRemoveEK.TabIndex = 27;
            this.btnRemoveEK.UseWaitCursor = true;
            this.btnRemoveEK.Click += new System.EventHandler(this.btnRemoveEK_Click);
            // 
            // btnSaveSystemTitle
            // 
            this.btnSaveSystemTitle.CheckedState.Parent = this.btnSaveSystemTitle;
            this.btnSaveSystemTitle.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px_hover;
            this.btnSaveSystemTitle.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnSaveSystemTitle.HoverState.Parent = this.btnSaveSystemTitle;
            this.btnSaveSystemTitle.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px;
            this.btnSaveSystemTitle.Location = new System.Drawing.Point(494, 171);
            this.btnSaveSystemTitle.Name = "btnSaveSystemTitle";
            this.btnSaveSystemTitle.PressedState.Parent = this.btnSaveSystemTitle;
            this.btnSaveSystemTitle.Size = new System.Drawing.Size(32, 32);
            this.btnSaveSystemTitle.TabIndex = 26;
            this.btnSaveSystemTitle.UseWaitCursor = true;
            this.btnSaveSystemTitle.Click += new System.EventHandler(this.btnSaveSystemTitle_Click);
            // 
            // btnSaveAK
            // 
            this.btnSaveAK.CheckedState.Parent = this.btnSaveAK;
            this.btnSaveAK.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px_hover;
            this.btnSaveAK.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnSaveAK.HoverState.Parent = this.btnSaveAK;
            this.btnSaveAK.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px;
            this.btnSaveAK.Location = new System.Drawing.Point(597, 126);
            this.btnSaveAK.Name = "btnSaveAK";
            this.btnSaveAK.PressedState.Parent = this.btnSaveAK;
            this.btnSaveAK.Size = new System.Drawing.Size(32, 32);
            this.btnSaveAK.TabIndex = 25;
            this.btnSaveAK.UseWaitCursor = true;
            this.btnSaveAK.Click += new System.EventHandler(this.btnSaveAK_Click);
            // 
            // btnSaveEK
            // 
            this.btnSaveEK.CheckedState.Parent = this.btnSaveEK;
            this.btnSaveEK.HoverState.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px_hover;
            this.btnSaveEK.HoverState.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnSaveEK.HoverState.Parent = this.btnSaveEK;
            this.btnSaveEK.Image = global::DLMS_Packet_Decrypter_Encrypter.Properties.Resources.save_32px;
            this.btnSaveEK.Location = new System.Drawing.Point(597, 83);
            this.btnSaveEK.Name = "btnSaveEK";
            this.btnSaveEK.PressedState.Parent = this.btnSaveEK;
            this.btnSaveEK.Size = new System.Drawing.Size(32, 32);
            this.btnSaveEK.TabIndex = 24;
            this.btnSaveEK.UseWaitCursor = true;
            this.btnSaveEK.Click += new System.EventHandler(this.btnSaveEK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(678, 564);
            this.Controls.Add(this.lblRayatinLink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSystemTitle);
            this.Controls.Add(this.btnRemoveSystemTitle);
            this.Controls.Add(this.btnRemoveAK);
            this.Controls.Add(this.btnRemoveEK);
            this.Controls.Add(this.btnSaveSystemTitle);
            this.Controls.Add(this.btnSaveAK);
            this.Controls.Add(this.btnSaveEK);
            this.Controls.Add(this.cmbAK);
            this.Controls.Add(this.cmbEK);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFrameCounter);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.lblInputText);
            this.Controls.Add(this.rdbAuthenticated);
            this.Controls.Add(this.rdbEncrypted);
            this.Controls.Add(this.rdbEandA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DLMS Packet Decrypter Encrypter  v1.0";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rdbEandA;
        private Guna.UI2.WinForms.Guna2RadioButton rdbEncrypted;
        private Guna.UI2.WinForms.Guna2RadioButton rdbAuthenticated;
        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.RichTextBox txtInputText;
        private Guna.UI2.WinForms.Guna2TextBox txtFrameCounter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtTag;
        private System.Windows.Forms.RichTextBox txtOutputText;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAction;
        private System.Windows.Forms.ComboBox cmbEK;
        private System.Windows.Forms.ComboBox cmbAK;
        private Guna.UI2.WinForms.Guna2ImageButton btnSaveEK;
        private Guna.UI2.WinForms.Guna2ImageButton btnSaveAK;
        private Guna.UI2.WinForms.Guna2ImageButton btnSaveSystemTitle;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemoveEK;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemoveAK;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemoveSystemTitle;
        private System.Windows.Forms.ComboBox cmbSystemTitle;
        private Guna.UI2.WinForms.Guna2RadioButton rdbEncryption;
        private Guna.UI2.WinForms.Guna2RadioButton rdbDecryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lblRayatinLink;
    }
}

