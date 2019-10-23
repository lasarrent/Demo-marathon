namespace demo_maraphon
{
    partial class Register_as_a_runner
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.But_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.but_earlier = new System.Windows.Forms.Button();
            this.but_new = new System.Windows.Forms.Button();
            this.but_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.But_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 66);
            this.panel1.TabIndex = 2;
            // 
            // But_back
            // 
            this.But_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.But_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But_back.Location = new System.Drawing.Point(17, 12);
            this.But_back.Name = "But_back";
            this.But_back.Size = new System.Drawing.Size(92, 31);
            this.But_back.TabIndex = 2;
            this.But_back.Text = "Назад";
            this.But_back.UseVisualStyleBackColor = false;
            this.But_back.Click += new System.EventHandler(this.But_back_Click_1);
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
            // but_earlier
            // 
            this.but_earlier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_earlier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_earlier.Location = new System.Drawing.Point(226, 175);
            this.but_earlier.Name = "but_earlier";
            this.but_earlier.Size = new System.Drawing.Size(396, 95);
            this.but_earlier.TabIndex = 3;
            this.but_earlier.Text = "Я учавствовал ранее";
            this.but_earlier.UseVisualStyleBackColor = true;
            this.but_earlier.Click += new System.EventHandler(this.but_earlier_Click);
            // 
            // but_new
            // 
            this.but_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_new.Location = new System.Drawing.Point(226, 294);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(396, 95);
            this.but_new.TabIndex = 4;
            this.but_new.Text = "Я новый участник";
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // but_login
            // 
            this.but_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_login.Location = new System.Drawing.Point(714, 495);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(108, 47);
            this.but_login.TabIndex = 5;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label_date);
            this.panel2.Location = new System.Drawing.Point(-4, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 54);
            this.panel2.TabIndex = 30;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(274, 11);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(58, 29);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Register_as_a_runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.but_new);
            this.Controls.Add(this.but_earlier);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register_as_a_runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_as_a_runner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_as_a_runner_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button But_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_earlier;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Timer timer1;
    }
}