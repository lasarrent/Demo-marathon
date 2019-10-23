namespace demo_maraphon
{
    partial class Sponsorship_confirmation
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
            this.but_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_run = new System.Windows.Forms.Label();
            this.lab_fond = new System.Windows.Forms.Label();
            this.lab_sum = new System.Windows.Forms.Label();
            this.but_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 66);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(165, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Спасибо за вашу спонсорскую поддержку!";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(95, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Спасибо за поддержку бегуна в Marathon Skills 2016!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(95, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(710, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ваше пожертвование пойдет в его благотворительную организацию";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_run
            // 
            this.lab_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_run.Location = new System.Drawing.Point(95, 299);
            this.lab_run.Name = "lab_run";
            this.lab_run.Size = new System.Drawing.Size(710, 34);
            this.lab_run.TabIndex = 6;
            this.lab_run.Text = "Иван Прудов(204) из Russia";
            this.lab_run.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_fond
            // 
            this.lab_fond.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_fond.ForeColor = System.Drawing.Color.Gray;
            this.lab_fond.Location = new System.Drawing.Point(93, 342);
            this.lab_fond.Name = "lab_fond";
            this.lab_fond.Size = new System.Drawing.Size(710, 41);
            this.lab_fond.TabIndex = 7;
            this.lab_fond.Text = "Фонд Кошек";
            this.lab_fond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_sum
            // 
            this.lab_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 68F);
            this.lab_sum.ForeColor = System.Drawing.Color.Gray;
            this.lab_sum.Location = new System.Drawing.Point(92, 405);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(710, 105);
            this.lab_sum.TabIndex = 8;
            this.lab_sum.Text = "$50";
            this.lab_sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.Location = new System.Drawing.Point(406, 548);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(109, 41);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "Назад";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lab_date);
            this.panel2.Location = new System.Drawing.Point(-6, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 54);
            this.panel2.TabIndex = 30;
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_date.ForeColor = System.Drawing.Color.White;
            this.lab_date.Location = new System.Drawing.Point(189, 16);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(58, 29);
            this.lab_date.TabIndex = 3;
            this.lab_date.Text = "data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sponsorship_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.lab_sum);
            this.Controls.Add(this.lab_fond);
            this.Controls.Add(this.lab_run);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sponsorship_confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sponsorship confirmation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sponsorship_confirmation_FormClosed);
            this.Load += new System.EventHandler(this.Sponsorship_confirmation_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_run;
        private System.Windows.Forms.Label lab_fond;
        private System.Windows.Forms.Label lab_sum;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.Timer timer1;
    }
}