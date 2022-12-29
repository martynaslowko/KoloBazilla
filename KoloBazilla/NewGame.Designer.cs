namespace KoloBazilla
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.playersList = new System.Windows.Forms.ListView();
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName_tb = new System.Windows.Forms.TextBox();
            this.addPlayer_button = new System.Windows.Forms.Button();
            this.removePlayer_button = new System.Windows.Forms.Button();
            this.players_label = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.vowelPrice_numeric = new System.Windows.Forms.NumericUpDown();
            this.vowelPrice_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.startGame_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vowelPrice_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerName});
            this.playersList.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersList.ForeColor = System.Drawing.Color.White;
            this.playersList.FullRowSelect = true;
            this.playersList.GridLines = true;
            this.playersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.playersList.HideSelection = false;
            this.playersList.Location = new System.Drawing.Point(12, 54);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(254, 221);
            this.playersList.TabIndex = 7;
            this.playersList.UseCompatibleStateImageBehavior = false;
            this.playersList.View = System.Windows.Forms.View.Details;
            // 
            // playerName
            // 
            this.playerName.Text = "Gracze";
            this.playerName.Width = 253;
            // 
            // playerName_tb
            // 
            this.playerName_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerName_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.playerName_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerName_tb.ForeColor = System.Drawing.Color.White;
            this.playerName_tb.Location = new System.Drawing.Point(12, 281);
            this.playerName_tb.MaxLength = 50;
            this.playerName_tb.Name = "playerName_tb";
            this.playerName_tb.Size = new System.Drawing.Size(254, 37);
            this.playerName_tb.TabIndex = 20;
            // 
            // addPlayer_button
            // 
            this.addPlayer_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPlayer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.addPlayer_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.addPlayer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayer_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPlayer_button.ForeColor = System.Drawing.Color.White;
            this.addPlayer_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPlayer_button.Location = new System.Drawing.Point(142, 324);
            this.addPlayer_button.Name = "addPlayer_button";
            this.addPlayer_button.Size = new System.Drawing.Size(124, 41);
            this.addPlayer_button.TabIndex = 21;
            this.addPlayer_button.Text = "+";
            this.addPlayer_button.UseVisualStyleBackColor = false;
            this.addPlayer_button.Click += new System.EventHandler(this.addPlayer_button_Click);
            // 
            // removePlayer_button
            // 
            this.removePlayer_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removePlayer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.removePlayer_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.removePlayer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayer_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removePlayer_button.ForeColor = System.Drawing.Color.White;
            this.removePlayer_button.Location = new System.Drawing.Point(12, 324);
            this.removePlayer_button.Name = "removePlayer_button";
            this.removePlayer_button.Size = new System.Drawing.Size(124, 41);
            this.removePlayer_button.TabIndex = 22;
            this.removePlayer_button.Text = "-";
            this.removePlayer_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removePlayer_button.UseVisualStyleBackColor = false;
            this.removePlayer_button.Click += new System.EventHandler(this.removePlayer_button_Click);
            // 
            // players_label
            // 
            this.players_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.players_label.Font = new System.Drawing.Font("Planet Kosmos", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.players_label.Location = new System.Drawing.Point(12, 13);
            this.players_label.Name = "players_label";
            this.players_label.Size = new System.Drawing.Size(254, 38);
            this.players_label.TabIndex = 23;
            this.players_label.Text = "Gracze";
            this.players_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_tb
            // 
            this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.password_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_tb.ForeColor = System.Drawing.Color.White;
            this.password_tb.Location = new System.Drawing.Point(280, 145);
            this.password_tb.MaxLength = 100;
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(508, 173);
            this.password_tb.TabIndex = 24;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vowelPrice_numeric
            // 
            this.vowelPrice_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vowelPrice_numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.vowelPrice_numeric.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vowelPrice_numeric.ForeColor = System.Drawing.Color.White;
            this.vowelPrice_numeric.Location = new System.Drawing.Point(375, 54);
            this.vowelPrice_numeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.vowelPrice_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vowelPrice_numeric.Name = "vowelPrice_numeric";
            this.vowelPrice_numeric.Size = new System.Drawing.Size(320, 37);
            this.vowelPrice_numeric.TabIndex = 25;
            this.vowelPrice_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vowelPrice_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vowelPrice_label
            // 
            this.vowelPrice_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vowelPrice_label.Font = new System.Drawing.Font("Planet Kosmos", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vowelPrice_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.vowelPrice_label.Location = new System.Drawing.Point(280, 13);
            this.vowelPrice_label.Name = "vowelPrice_label";
            this.vowelPrice_label.Size = new System.Drawing.Size(508, 38);
            this.vowelPrice_label.TabIndex = 26;
            this.vowelPrice_label.Text = "Cena samogtoski";
            this.vowelPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.Font = new System.Drawing.Font("Planet Kosmos", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.password_label.Location = new System.Drawing.Point(280, 104);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(508, 38);
            this.password_label.TabIndex = 27;
            this.password_label.Text = "Pierwsze hasto";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGame_button
            // 
            this.startGame_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGame_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.startGame_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.startGame_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGame_button.ForeColor = System.Drawing.Color.White;
            this.startGame_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startGame_button.Location = new System.Drawing.Point(280, 324);
            this.startGame_button.Name = "startGame_button";
            this.startGame_button.Size = new System.Drawing.Size(508, 40);
            this.startGame_button.TabIndex = 28;
            this.startGame_button.Text = "Rozpocznij grę";
            this.startGame_button.UseVisualStyleBackColor = false;
            this.startGame_button.Click += new System.EventHandler(this.startGame_button_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.startGame_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.vowelPrice_label);
            this.Controls.Add(this.vowelPrice_numeric);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.players_label);
            this.Controls.Add(this.removePlayer_button);
            this.Controls.Add(this.addPlayer_button);
            this.Controls.Add(this.playerName_tb);
            this.Controls.Add(this.playersList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGame";
            this.Text = "Nowa gra";
            ((System.ComponentModel.ISupportInitialize)(this.vowelPrice_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView playersList;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.TextBox playerName_tb;
        private System.Windows.Forms.Button addPlayer_button;
        private System.Windows.Forms.Button removePlayer_button;
        private System.Windows.Forms.Label players_label;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.NumericUpDown vowelPrice_numeric;
        private System.Windows.Forms.Label vowelPrice_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button startGame_button;
    }
}