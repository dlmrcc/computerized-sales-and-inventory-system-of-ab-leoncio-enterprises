namespace ABLECSIS
{
    partial class wfForgotPassword
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbSecQuest = new System.Windows.Forms.Label();
            this.bnPassOk = new System.Windows.Forms.Button();
            this.lbShowPass = new System.Windows.Forms.LinkLabel();
            this.bnPassClose = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtSecAns = new System.Windows.Forms.TextBox();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bnUserOk = new System.Windows.Forms.Button();
            this.bnUserClose = new System.Windows.Forms.Button();
            this.pnSecurity = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnPassword.SuspendLayout();
            this.pnUsername.SuspendLayout();
            this.pnSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(126, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lbSecQuest
            // 
            this.lbSecQuest.BackColor = System.Drawing.Color.Transparent;
            this.lbSecQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecQuest.ForeColor = System.Drawing.Color.White;
            this.lbSecQuest.Location = new System.Drawing.Point(106, 2);
            this.lbSecQuest.Name = "lbSecQuest";
            this.lbSecQuest.Size = new System.Drawing.Size(236, 24);
            this.lbSecQuest.TabIndex = 0;
            this.lbSecQuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnPassOk
            // 
            this.bnPassOk.Location = new System.Drawing.Point(106, 108);
            this.bnPassOk.Name = "bnPassOk";
            this.bnPassOk.Size = new System.Drawing.Size(129, 27);
            this.bnPassOk.TabIndex = 2;
            this.bnPassOk.Text = "Change Password";
            this.bnPassOk.UseVisualStyleBackColor = true;
            this.bnPassOk.Click += new System.EventHandler(this.bnPassOk_Click);
            // 
            // lbShowPass
            // 
            this.lbShowPass.AutoSize = true;
            this.lbShowPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowPass.LinkColor = System.Drawing.Color.Yellow;
            this.lbShowPass.Location = new System.Drawing.Point(217, 82);
            this.lbShowPass.Name = "lbShowPass";
            this.lbShowPass.Size = new System.Drawing.Size(97, 13);
            this.lbShowPass.TabIndex = 4;
            this.lbShowPass.TabStop = true;
            this.lbShowPass.Text = "Retrieve Password";
            this.lbShowPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowPass_LinkClicked);
            // 
            // bnPassClose
            // 
            this.bnPassClose.Location = new System.Drawing.Point(243, 108);
            this.bnPassClose.Name = "bnPassClose";
            this.bnPassClose.Size = new System.Drawing.Size(87, 27);
            this.bnPassClose.TabIndex = 3;
            this.bnPassClose.Text = "Cancel";
            this.bnPassClose.UseVisualStyleBackColor = true;
            this.bnPassClose.Click += new System.EventHandler(this.bnPassClose_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(126, 12);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(189, 21);
            this.txtNewPassword.TabIndex = 0;
            // 
            // pnPassword
            // 
            this.pnPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnPassword.Controls.Add(this.label2);
            this.pnPassword.Controls.Add(this.label1);
            this.pnPassword.Controls.Add(this.bnPassOk);
            this.pnPassword.Controls.Add(this.lbShowPass);
            this.pnPassword.Controls.Add(this.bnPassClose);
            this.pnPassword.Controls.Add(this.txtNewPassword);
            this.pnPassword.Controls.Add(this.txtConPass);
            this.pnPassword.Location = new System.Drawing.Point(1, 58);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(345, 144);
            this.pnPassword.TabIndex = 1;
            this.pnPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Password";
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.ForeColor = System.Drawing.Color.Black;
            this.txtConPass.Location = new System.Drawing.Point(126, 45);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(189, 21);
            this.txtConPass.TabIndex = 1;
            // 
            // txtSecAns
            // 
            this.txtSecAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecAns.ForeColor = System.Drawing.Color.Black;
            this.txtSecAns.Location = new System.Drawing.Point(126, 36);
            this.txtSecAns.Name = "txtSecAns";
            this.txtSecAns.Size = new System.Drawing.Size(189, 20);
            this.txtSecAns.TabIndex = 0;
            // 
            // pnUsername
            // 
            this.pnUsername.BackColor = System.Drawing.Color.Transparent;
            this.pnUsername.Controls.Add(this.label3);
            this.pnUsername.Controls.Add(this.bnUserOk);
            this.pnUsername.Controls.Add(this.bnUserClose);
            this.pnUsername.Controls.Add(this.pnSecurity);
            this.pnUsername.Controls.Add(this.txtUsername);
            this.pnUsername.Location = new System.Drawing.Point(1, 58);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(345, 144);
            this.pnUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // bnUserOk
            // 
            this.bnUserOk.Location = new System.Drawing.Point(148, 110);
            this.bnUserOk.Name = "bnUserOk";
            this.bnUserOk.Size = new System.Drawing.Size(87, 27);
            this.bnUserOk.TabIndex = 1;
            this.bnUserOk.Text = "Continue";
            this.bnUserOk.UseVisualStyleBackColor = true;
            this.bnUserOk.Click += new System.EventHandler(this.bnUserOk_Click);
            // 
            // bnUserClose
            // 
            this.bnUserClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnUserClose.Location = new System.Drawing.Point(243, 110);
            this.bnUserClose.Name = "bnUserClose";
            this.bnUserClose.Size = new System.Drawing.Size(87, 27);
            this.bnUserClose.TabIndex = 2;
            this.bnUserClose.Text = "Cancel";
            this.bnUserClose.UseVisualStyleBackColor = true;
            this.bnUserClose.Click += new System.EventHandler(this.bnUserClose_Click);
            // 
            // pnSecurity
            // 
            this.pnSecurity.Controls.Add(this.label5);
            this.pnSecurity.Controls.Add(this.label4);
            this.pnSecurity.Controls.Add(this.lbSecQuest);
            this.pnSecurity.Controls.Add(this.txtSecAns);
            this.pnSecurity.Location = new System.Drawing.Point(0, 40);
            this.pnSecurity.Name = "pnSecurity";
            this.pnSecurity.Size = new System.Drawing.Size(345, 65);
            this.pnSecurity.TabIndex = 1;
            this.pnSecurity.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 305;
            this.label5.Text = "Security Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Security Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Forgot Password";
            // 
            // wfForgotPassword
            // 
            this.AcceptButton = this.bnUserOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::ABLECSIS.Properties.Resources.New;
            this.ClientSize = new System.Drawing.Size(346, 203);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnUsername);
            this.Controls.Add(this.pnPassword);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.wfForgotPassword_Load);
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.pnSecurity.ResumeLayout(false);
            this.pnSecurity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbSecQuest;
        private System.Windows.Forms.Button bnPassOk;
        private System.Windows.Forms.LinkLabel lbShowPass;
        private System.Windows.Forms.Button bnPassClose;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtSecAns;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.Button bnUserOk;
        private System.Windows.Forms.Button bnUserClose;
        private System.Windows.Forms.Panel pnSecurity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}