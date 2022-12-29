namespace KoloBazilla
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.bgslash_box = new System.Windows.Forms.PictureBox();
            this.wheel_box = new System.Windows.Forms.PictureBox();
            this.wheel_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newPassword_button = new System.Windows.Forms.Button();
            this.newGame_button = new System.Windows.Forms.Button();
            this.showPassword_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.players_label = new System.Windows.Forms.Label();
            this.playerBoard = new System.Windows.Forms.ListView();
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerSmiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName_tb = new System.Windows.Forms.TextBox();
            this.playerPoints_tb = new System.Windows.Forms.TextBox();
            this.playerSmiles_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.incorrectLetters_box = new System.Windows.Forms.TextBox();
            this.incorrectLetters_label = new System.Windows.Forms.Label();
            this.playFor_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wheelResult_label = new System.Windows.Forms.Label();
            this.checkLetter_label = new System.Windows.Forms.Label();
            this.checkLetter_tb = new System.Windows.Forms.TextBox();
            this.checkLetter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bgslash_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheel_box)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgslash_box
            // 
            this.bgslash_box.Image = global::KoloBazilla.Properties.Resources.slash1;
            this.bgslash_box.Location = new System.Drawing.Point(-12, -19);
            this.bgslash_box.Name = "bgslash_box";
            this.bgslash_box.Size = new System.Drawing.Size(1891, 370);
            this.bgslash_box.TabIndex = 0;
            this.bgslash_box.TabStop = false;
            // 
            // wheel_box
            // 
            this.wheel_box.Enabled = false;
            this.wheel_box.Image = global::KoloBazilla.Properties.Resources.Wedges_1_1s_300px;
            this.wheel_box.Location = new System.Drawing.Point(1567, 31);
            this.wheel_box.Name = "wheel_box";
            this.wheel_box.Size = new System.Drawing.Size(300, 300);
            this.wheel_box.TabIndex = 1;
            this.wheel_box.TabStop = false;
            // 
            // wheel_button
            // 
            this.wheel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.wheel_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.wheel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wheel_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wheel_button.ForeColor = System.Drawing.Color.White;
            this.wheel_button.Location = new System.Drawing.Point(1636, 163);
            this.wheel_button.Name = "wheel_button";
            this.wheel_button.Size = new System.Drawing.Size(162, 36);
            this.wheel_button.TabIndex = 2;
            this.wheel_button.Text = "Zakręć kołem";
            this.wheel_button.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.newPassword_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.newGame_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.showPassword_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.about_button, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 986);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 52);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // newPassword_button
            // 
            this.newPassword_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPassword_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.newPassword_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.newPassword_button.Enabled = false;
            this.newPassword_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPassword_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPassword_button.ForeColor = System.Drawing.Color.White;
            this.newPassword_button.Location = new System.Drawing.Point(478, 3);
            this.newPassword_button.Name = "newPassword_button";
            this.newPassword_button.Size = new System.Drawing.Size(469, 46);
            this.newPassword_button.TabIndex = 5;
            this.newPassword_button.Text = "Nowe hasło";
            this.newPassword_button.UseVisualStyleBackColor = false;
            this.newPassword_button.Click += new System.EventHandler(this.newPassword_button_Click);
            // 
            // newGame_button
            // 
            this.newGame_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGame_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.newGame_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.newGame_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGame_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGame_button.ForeColor = System.Drawing.Color.White;
            this.newGame_button.Location = new System.Drawing.Point(3, 3);
            this.newGame_button.Name = "newGame_button";
            this.newGame_button.Size = new System.Drawing.Size(469, 46);
            this.newGame_button.TabIndex = 4;
            this.newGame_button.Text = "Nowa gra";
            this.newGame_button.UseVisualStyleBackColor = false;
            this.newGame_button.Click += new System.EventHandler(this.newGame_button_Click);
            // 
            // showPassword_button
            // 
            this.showPassword_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPassword_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.showPassword_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.showPassword_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showPassword_button.ForeColor = System.Drawing.Color.White;
            this.showPassword_button.Location = new System.Drawing.Point(953, 3);
            this.showPassword_button.Name = "showPassword_button";
            this.showPassword_button.Size = new System.Drawing.Size(469, 46);
            this.showPassword_button.TabIndex = 6;
            this.showPassword_button.Text = "Pokaż hasło";
            this.showPassword_button.UseVisualStyleBackColor = false;
            this.showPassword_button.Click += new System.EventHandler(this.showPassword_button_Click);
            // 
            // about_button
            // 
            this.about_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.about_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about_button.ForeColor = System.Drawing.Color.White;
            this.about_button.Location = new System.Drawing.Point(1428, 3);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(471, 46);
            this.about_button.TabIndex = 7;
            this.about_button.Text = "Giga koxy";
            this.about_button.UseVisualStyleBackColor = false;
            // 
            // players_label
            // 
            this.players_label.Font = new System.Drawing.Font("Planet Kosmos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.players_label.Location = new System.Drawing.Point(5, 347);
            this.players_label.Name = "players_label";
            this.players_label.Size = new System.Drawing.Size(469, 77);
            this.players_label.TabIndex = 5;
            this.players_label.Text = "Gracze";
            this.players_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerBoard
            // 
            this.playerBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playerBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerName,
            this.playerMoney,
            this.playerSmiles});
            this.playerBoard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBoard.ForeColor = System.Drawing.Color.White;
            this.playerBoard.FullRowSelect = true;
            this.playerBoard.GridLines = true;
            this.playerBoard.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playerBoard.HideSelection = false;
            this.playerBoard.Location = new System.Drawing.Point(19, 427);
            this.playerBoard.Name = "playerBoard";
            this.playerBoard.Size = new System.Drawing.Size(469, 529);
            this.playerBoard.TabIndex = 6;
            this.playerBoard.UseCompatibleStateImageBehavior = false;
            this.playerBoard.View = System.Windows.Forms.View.Details;
            // 
            // playerName
            // 
            this.playerName.Text = "Nazwa";
            this.playerName.Width = 253;
            // 
            // playerMoney
            // 
            this.playerMoney.Text = "Punkty";
            this.playerMoney.Width = 156;
            // 
            // playerSmiles
            // 
            this.playerSmiles.Text = ":-)";
            // 
            // playerName_tb
            // 
            this.playerName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playerName_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName_tb.ForeColor = System.Drawing.Color.White;
            this.playerName_tb.Location = new System.Drawing.Point(19, 427);
            this.playerName_tb.Multiline = true;
            this.playerName_tb.Name = "playerName_tb";
            this.playerName_tb.ReadOnly = true;
            this.playerName_tb.Size = new System.Drawing.Size(255, 34);
            this.playerName_tb.TabIndex = 7;
            this.playerName_tb.Text = "Nazwa";
            // 
            // playerPoints_tb
            // 
            this.playerPoints_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playerPoints_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPoints_tb.ForeColor = System.Drawing.Color.White;
            this.playerPoints_tb.Location = new System.Drawing.Point(271, 427);
            this.playerPoints_tb.Multiline = true;
            this.playerPoints_tb.Name = "playerPoints_tb";
            this.playerPoints_tb.ReadOnly = true;
            this.playerPoints_tb.Size = new System.Drawing.Size(160, 34);
            this.playerPoints_tb.TabIndex = 8;
            this.playerPoints_tb.Text = "Pitos";
            // 
            // playerSmiles_tb
            // 
            this.playerSmiles_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playerSmiles_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSmiles_tb.ForeColor = System.Drawing.Color.White;
            this.playerSmiles_tb.Location = new System.Drawing.Point(427, 427);
            this.playerSmiles_tb.Multiline = true;
            this.playerSmiles_tb.Name = "playerSmiles_tb";
            this.playerSmiles_tb.ReadOnly = true;
            this.playerSmiles_tb.Size = new System.Drawing.Size(62, 34);
            this.playerSmiles_tb.TabIndex = 9;
            this.playerSmiles_tb.Text = ":-)";
            // 
            // password_tb
            // 
            this.password_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.password_tb.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.White;
            this.password_tb.Location = new System.Drawing.Point(512, 427);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.ReadOnly = true;
            this.password_tb.Size = new System.Drawing.Size(1369, 320);
            this.password_tb.TabIndex = 11;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incorrectLetters_box
            // 
            this.incorrectLetters_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectLetters_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.incorrectLetters_box.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLetters_box.ForeColor = System.Drawing.Color.White;
            this.incorrectLetters_box.Location = new System.Drawing.Point(953, 767);
            this.incorrectLetters_box.Multiline = true;
            this.incorrectLetters_box.Name = "incorrectLetters_box";
            this.incorrectLetters_box.ReadOnly = true;
            this.incorrectLetters_box.Size = new System.Drawing.Size(928, 189);
            this.incorrectLetters_box.TabIndex = 12;
            // 
            // incorrectLetters_label
            // 
            this.incorrectLetters_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectLetters_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.incorrectLetters_label.Font = new System.Drawing.Font("Planet Kosmos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLetters_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.incorrectLetters_label.Location = new System.Drawing.Point(1461, 886);
            this.incorrectLetters_label.Name = "incorrectLetters_label";
            this.incorrectLetters_label.Size = new System.Drawing.Size(416, 67);
            this.incorrectLetters_label.TabIndex = 13;
            this.incorrectLetters_label.Text = "Nietrafione";
            this.incorrectLetters_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playFor_label
            // 
            this.playFor_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playFor_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playFor_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playFor_label.Font = new System.Drawing.Font("Planet Kosmos", 24F);
            this.playFor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.playFor_label.Location = new System.Drawing.Point(1325, 351);
            this.playFor_label.Name = "playFor_label";
            this.playFor_label.Size = new System.Drawing.Size(233, 82);
            this.playFor_label.TabIndex = 15;
            this.playFor_label.Text = "grasz o:";
            this.playFor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Planet Kosmos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(512, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 77);
            this.label2.TabIndex = 16;
            this.label2.Text = "hasto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wheelResult_label
            // 
            this.wheelResult_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wheelResult_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.wheelResult_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wheelResult_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelResult_label.ForeColor = System.Drawing.Color.White;
            this.wheelResult_label.Location = new System.Drawing.Point(1557, 351);
            this.wheelResult_label.Name = "wheelResult_label";
            this.wheelResult_label.Size = new System.Drawing.Size(323, 78);
            this.wheelResult_label.TabIndex = 17;
            this.wheelResult_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkLetter_label
            // 
            this.checkLetter_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.checkLetter_label.Font = new System.Drawing.Font("Planet Kosmos", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLetter_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.checkLetter_label.Location = new System.Drawing.Point(512, 767);
            this.checkLetter_label.Name = "checkLetter_label";
            this.checkLetter_label.Size = new System.Drawing.Size(238, 186);
            this.checkLetter_label.TabIndex = 18;
            this.checkLetter_label.Text = "podaj \r\nlitere:";
            this.checkLetter_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkLetter_tb
            // 
            this.checkLetter_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkLetter_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.checkLetter_tb.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLetter_tb.ForeColor = System.Drawing.Color.White;
            this.checkLetter_tb.Location = new System.Drawing.Point(756, 767);
            this.checkLetter_tb.MaxLength = 1;
            this.checkLetter_tb.Multiline = true;
            this.checkLetter_tb.Name = "checkLetter_tb";
            this.checkLetter_tb.Size = new System.Drawing.Size(180, 132);
            this.checkLetter_tb.TabIndex = 19;
            this.checkLetter_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkLetter_button
            // 
            this.checkLetter_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkLetter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.checkLetter_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkLetter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLetter_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkLetter_button.ForeColor = System.Drawing.Color.White;
            this.checkLetter_button.Location = new System.Drawing.Point(756, 905);
            this.checkLetter_button.Name = "checkLetter_button";
            this.checkLetter_button.Size = new System.Drawing.Size(180, 51);
            this.checkLetter_button.TabIndex = 20;
            this.checkLetter_button.Text = "Sprawdź";
            this.checkLetter_button.UseVisualStyleBackColor = false;
            this.checkLetter_button.Click += new System.EventHandler(this.checkLetter_button_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.checkLetter_button);
            this.Controls.Add(this.checkLetter_tb);
            this.Controls.Add(this.checkLetter_label);
            this.Controls.Add(this.wheelResult_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.incorrectLetters_label);
            this.Controls.Add(this.incorrectLetters_box);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.playerSmiles_tb);
            this.Controls.Add(this.playerPoints_tb);
            this.Controls.Add(this.playerName_tb);
            this.Controls.Add(this.playerBoard);
            this.Controls.Add(this.players_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.wheel_button);
            this.Controls.Add(this.wheel_box);
            this.Controls.Add(this.bgslash_box);
            this.Controls.Add(this.playFor_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Koło Bazilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bgslash_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheel_box)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bgslash_box;
        private System.Windows.Forms.PictureBox wheel_box;
        private System.Windows.Forms.Button wheel_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button newGame_button;
        private System.Windows.Forms.Button newPassword_button;
        private System.Windows.Forms.Button showPassword_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Label players_label;
        private System.Windows.Forms.ListView playerBoard;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader playerMoney;
        private System.Windows.Forms.TextBox playerName_tb;
        private System.Windows.Forms.TextBox playerPoints_tb;
        private System.Windows.Forms.ColumnHeader playerSmiles;
        private System.Windows.Forms.TextBox playerSmiles_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox incorrectLetters_box;
        private System.Windows.Forms.Label incorrectLetters_label;
        private System.Windows.Forms.Label playFor_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wheelResult_label;
        private System.Windows.Forms.Label checkLetter_label;
        private System.Windows.Forms.TextBox checkLetter_tb;
        private System.Windows.Forms.Button checkLetter_button;
    }
}

