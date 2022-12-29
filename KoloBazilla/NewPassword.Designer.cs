namespace KoloBazilla
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            this.startRound_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startRound_button
            // 
            this.startRound_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startRound_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.startRound_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.startRound_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRound_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startRound_button.ForeColor = System.Drawing.Color.White;
            this.startRound_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startRound_button.Location = new System.Drawing.Point(12, 231);
            this.startRound_button.Name = "startRound_button";
            this.startRound_button.Size = new System.Drawing.Size(508, 40);
            this.startRound_button.TabIndex = 31;
            this.startRound_button.Text = "Rozpocznij rundę";
            this.startRound_button.UseVisualStyleBackColor = false;
            this.startRound_button.Click += new System.EventHandler(this.startRound_button_Click);
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.Font = new System.Drawing.Font("Planet Kosmos", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.password_label.Location = new System.Drawing.Point(12, 11);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(508, 38);
            this.password_label.TabIndex = 30;
            this.password_label.Text = "nowe hasto";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_tb
            // 
            this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.password_tb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.password_tb.ForeColor = System.Drawing.Color.White;
            this.password_tb.Location = new System.Drawing.Point(12, 52);
            this.password_tb.MaxLength = 100;
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(508, 173);
            this.password_tb.TabIndex = 29;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(532, 282);
            this.Controls.Add(this.startRound_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPassword";
            this.Text = "Nowe hasło";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startRound_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_tb;
    }
}