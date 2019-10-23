namespace demo_maraphon
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 66);
            this.panel1.TabIndex = 2;
            // 
            // but_back
            // 
            this.but_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_back.Location = new System.Drawing.Point(17, 12);
            this.but_back.Name = "but_back";
            this.but_back.Size = new System.Drawing.Size(92, 31);
            this.but_back.TabIndex = 2;
            this.but_back.Text = "Назад";
            this.but_back.UseVisualStyleBackColor = false;
            this.but_back.Click += new System.EventHandler(this.but_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(300, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Форма авторизации";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(84, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 84);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пожалуйста, авторизируйтесь в системе, используя ваш адрес электронный почты и па" +
    "роль.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(260, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_email.ForeColor = System.Drawing.Color.Gray;
            this.tb_email.Location = new System.Drawing.Point(354, 251);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(338, 31);
            this.tb_email.TabIndex = 10;
            this.tb_email.Text = "Enter your email address";
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(212, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.ForeColor = System.Drawing.Color.Gray;
            this.tb_pass.Location = new System.Drawing.Point(354, 303);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(338, 31);
            this.tb_pass.TabIndex = 13;
            this.tb_pass.Text = "Enter your password";
            this.tb_pass.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_login.ForeColor = System.Drawing.Color.Black;
            this.but_login.Location = new System.Drawing.Point(354, 364);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(111, 38);
            this.but_login.TabIndex = 15;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.Color.Black;
            this.but_cancel.Location = new System.Drawing.Point(478, 364);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(111, 38);
            this.but_cancel.TabIndex = 16;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 54);
            this.panel2.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(274, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 29);
            this.label15.TabIndex = 3;
            this.label15.Text = "data";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
    }
}