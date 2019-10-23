namespace demo_maraphon
{
    partial class Главное_окно_системы
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.But_runner = new System.Windows.Forms.Button();
            this.but_viewer = new System.Windows.Forms.Button();
            this.but_info = new System.Windows.Forms.Button();
            this.but_sponsor = new System.Windows.Forms.Button();
            this.but_log = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 199);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(258, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "среда 21 октября 2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(295, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Москва, Россия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // But_runner
            // 
            this.But_runner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.But_runner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.But_runner.Location = new System.Drawing.Point(12, 239);
            this.But_runner.Name = "But_runner";
            this.But_runner.Size = new System.Drawing.Size(367, 63);
            this.But_runner.TabIndex = 1;
            this.But_runner.Text = "Я хочу стать бегуном";
            this.But_runner.UseVisualStyleBackColor = false;
            this.But_runner.Click += new System.EventHandler(this.But_runner_Click);
            // 
            // but_viewer
            // 
            this.but_viewer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_viewer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_viewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_viewer.Location = new System.Drawing.Point(385, 239);
            this.but_viewer.Name = "but_viewer";
            this.but_viewer.Size = new System.Drawing.Size(367, 63);
            this.but_viewer.TabIndex = 2;
            this.but_viewer.Text = "Я хочу стать зрителем";
            this.but_viewer.UseVisualStyleBackColor = false;
            // 
            // but_info
            // 
            this.but_info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_info.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_info.Location = new System.Drawing.Point(383, 308);
            this.but_info.Name = "but_info";
            this.but_info.Size = new System.Drawing.Size(367, 63);
            this.but_info.TabIndex = 4;
            this.but_info.Text = "Я хочу узнать больше о событии";
            this.but_info.UseVisualStyleBackColor = false;
            this.but_info.Click += new System.EventHandler(this.but_info_Click);
            // 
            // but_sponsor
            // 
            this.but_sponsor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_sponsor.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sponsor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_sponsor.Location = new System.Drawing.Point(10, 308);
            this.but_sponsor.Name = "but_sponsor";
            this.but_sponsor.Size = new System.Drawing.Size(367, 63);
            this.but_sponsor.TabIndex = 3;
            this.but_sponsor.Text = "Я хочу стать спонсором бегуна";
            this.but_sponsor.UseVisualStyleBackColor = false;
            this.but_sponsor.Click += new System.EventHandler(this.but_sponsor_Click);
            // 
            // but_log
            // 
            this.but_log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.but_log.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_log.ForeColor = System.Drawing.Color.Black;
            this.but_log.Location = new System.Drawing.Point(639, 419);
            this.but_log.Name = "but_log";
            this.but_log.Size = new System.Drawing.Size(111, 38);
            this.but_log.TabIndex = 5;
            this.but_log.Text = "Login";
            this.but_log.UseVisualStyleBackColor = false;
            this.but_log.Click += new System.EventHandler(this.but_log_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-2, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 54);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(176, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Главное_окно_системы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_log);
            this.Controls.Add(this.but_info);
            this.Controls.Add(this.but_sponsor);
            this.Controls.Add(this.but_viewer);
            this.Controls.Add(this.But_runner);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Главное_окно_системы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно системы";
            this.Load += new System.EventHandler(this.Главное_окно_системы_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_runner;
        private System.Windows.Forms.Button but_viewer;
        private System.Windows.Forms.Button but_info;
        private System.Windows.Forms.Button but_sponsor;
        private System.Windows.Forms.Button but_log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

