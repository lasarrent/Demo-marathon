namespace demo_maraphon
{
    partial class Registr_for_an_event
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_full = new System.Windows.Forms.CheckBox();
            this.checkBox_half = new System.Windows.Forms.CheckBox();
            this.checkBox_min = new System.Windows.Forms.CheckBox();
            this.rb_a = new System.Windows.Forms.RadioButton();
            this.rb_b = new System.Windows.Forms.RadioButton();
            this.rb_c = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_contribution = new System.Windows.Forms.ComboBox();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zhmurov_demoDataSet = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_registration = new System.Windows.Forms.Button();
            this.lab_sum_contribution = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.charityTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter();
            this.but_info = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 66);
            this.panel1.TabIndex = 3;
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(122, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 85);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пожалуйста, заполните всю информацию, чтобы зарегистрироваться на Skills Marathon" +
    " 2016 проводимом в Москве. Russia. С вами свяжутся после регистрации для уточнен" +
    "ия оплаты и другой информации.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(335, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Регистрация на марафон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(106, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вид марафона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(549, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Варианты комплектов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(106, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Детали спонсорства";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(530, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Регистрационный взнос";
            // 
            // checkBox_full
            // 
            this.checkBox_full.AutoSize = true;
            this.checkBox_full.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_full.Location = new System.Drawing.Point(91, 317);
            this.checkBox_full.Name = "checkBox_full";
            this.checkBox_full.Size = new System.Drawing.Size(295, 28);
            this.checkBox_full.TabIndex = 12;
            this.checkBox_full.Text = "42 km Полный марафон ($145)";
            this.checkBox_full.UseVisualStyleBackColor = true;
            this.checkBox_full.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // checkBox_half
            // 
            this.checkBox_half.AutoSize = true;
            this.checkBox_half.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_half.Location = new System.Drawing.Point(91, 362);
            this.checkBox_half.Name = "checkBox_half";
            this.checkBox_half.Size = new System.Drawing.Size(254, 28);
            this.checkBox_half.TabIndex = 13;
            this.checkBox_half.Text = "21 km Полумарафон ($75)";
            this.checkBox_half.UseVisualStyleBackColor = true;
            this.checkBox_half.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // checkBox_min
            // 
            this.checkBox_min.AutoSize = true;
            this.checkBox_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_min.Location = new System.Drawing.Point(91, 402);
            this.checkBox_min.Name = "checkBox_min";
            this.checkBox_min.Size = new System.Drawing.Size(278, 28);
            this.checkBox_min.TabIndex = 14;
            this.checkBox_min.Text = "5 km Малая дистанция ($20)";
            this.checkBox_min.UseVisualStyleBackColor = true;
            this.checkBox_min.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // rb_a
            // 
            this.rb_a.AutoSize = true;
            this.rb_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_a.Location = new System.Drawing.Point(535, 317);
            this.rb_a.Name = "rb_a";
            this.rb_a.Size = new System.Drawing.Size(178, 28);
            this.rb_a.TabIndex = 15;
            this.rb_a.TabStop = true;
            this.rb_a.Text = "Вариант А ($0):";
            this.rb_a.UseVisualStyleBackColor = true;
            this.rb_a.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // rb_b
            // 
            this.rb_b.AutoSize = true;
            this.rb_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_b.Location = new System.Drawing.Point(535, 384);
            this.rb_b.Name = "rb_b";
            this.rb_b.Size = new System.Drawing.Size(188, 28);
            this.rb_b.TabIndex = 16;
            this.rb_b.TabStop = true;
            this.rb_b.Text = "Вариант В ($20):";
            this.rb_b.UseVisualStyleBackColor = true;
            this.rb_b.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // rb_c
            // 
            this.rb_c.AutoSize = true;
            this.rb_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_c.Location = new System.Drawing.Point(535, 450);
            this.rb_c.Name = "rb_c";
            this.rb_c.Size = new System.Drawing.Size(189, 28);
            this.rb_c.TabIndex = 17;
            this.rb_c.TabStop = true;
            this.rb_c.Text = "Вариант С ($45):";
            this.rb_c.UseVisualStyleBackColor = true;
            this.rb_c.CheckedChanged += new System.EventHandler(this.checkBox_full_EnabledChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(719, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер бегуна +";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(550, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "RFID браслет.";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(719, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Вариант А +";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(550, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 33);
            this.label11.TabIndex = 21;
            this.label11.Text = "бейсболка + бутылка воды";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(719, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "Вариант В";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(550, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 33);
            this.label13.TabIndex = 23;
            this.label13.Text = "+ футболка + сувенирный буклет";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(86, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Взнос:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_contribution
            // 
            this.cb_contribution.DataSource = this.charityBindingSource;
            this.cb_contribution.DisplayMember = "CharityName";
            this.cb_contribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_contribution.FormattingEnabled = true;
            this.cb_contribution.Location = new System.Drawing.Point(220, 529);
            this.cb_contribution.Name = "cb_contribution";
            this.cb_contribution.Size = new System.Drawing.Size(237, 33);
            this.cb_contribution.TabIndex = 30;
            this.cb_contribution.ValueMember = "CharityName";
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.g463_zhmurov_demoDataSet;
            // 
            // g463_zhmurov_demoDataSet
            // 
            this.g463_zhmurov_demoDataSet.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(12, 586);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Сумма взноса:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_sum
            // 
            this.tb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sum.ForeColor = System.Drawing.Color.Gray;
            this.tb_sum.Location = new System.Drawing.Point(220, 583);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(237, 31);
            this.tb_sum.TabIndex = 32;
            this.tb_sum.Text = "$500";
            this.tb_sum.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_sum.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.White;
            this.but_cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.Color.Black;
            this.but_cancel.Location = new System.Drawing.Point(235, 638);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(115, 38);
            this.but_cancel.TabIndex = 35;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = false;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_registration
            // 
            this.but_registration.BackColor = System.Drawing.Color.White;
            this.but_registration.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_registration.ForeColor = System.Drawing.Color.Black;
            this.but_registration.Location = new System.Drawing.Point(55, 638);
            this.but_registration.Name = "but_registration";
            this.but_registration.Size = new System.Drawing.Size(153, 38);
            this.but_registration.TabIndex = 34;
            this.but_registration.Text = "Регистрация";
            this.but_registration.UseVisualStyleBackColor = false;
            this.but_registration.Click += new System.EventHandler(this.but_registration_Click);
            // 
            // lab_sum_contribution
            // 
            this.lab_sum_contribution.AutoSize = true;
            this.lab_sum_contribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_sum_contribution.ForeColor = System.Drawing.Color.Gray;
            this.lab_sum_contribution.Location = new System.Drawing.Point(582, 571);
            this.lab_sum_contribution.Name = "lab_sum_contribution";
            this.lab_sum_contribution.Size = new System.Drawing.Size(127, 91);
            this.lab_sum_contribution.TabIndex = 36;
            this.lab_sum_contribution.Text = "$0";
            this.lab_sum_contribution.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 54);
            this.panel2.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(274, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 29);
            this.label17.TabIndex = 3;
            this.label17.Text = "data";
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // but_info
            // 
            this.but_info.BackColor = System.Drawing.Color.White;
            this.but_info.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_info.ForeColor = System.Drawing.Color.Black;
            this.but_info.Location = new System.Drawing.Point(463, 527);
            this.but_info.Name = "but_info";
            this.but_info.Size = new System.Drawing.Size(44, 38);
            this.but_info.TabIndex = 39;
            this.but_info.Text = "i";
            this.but_info.UseVisualStyleBackColor = false;
            // 
            // Registr_for_an_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 749);
            this.Controls.Add(this.but_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lab_sum_contribution);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_registration);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_contribution);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rb_c);
            this.Controls.Add(this.rb_b);
            this.Controls.Add(this.rb_a);
            this.Controls.Add(this.checkBox_min);
            this.Controls.Add(this.checkBox_half);
            this.Controls.Add(this.checkBox_full);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registr_for_an_event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+ футболка + сувенирный буклет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registr_for_an_event_FormClosed);
            this.Load += new System.EventHandler(this.Registr_for_an_event_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_full;
        private System.Windows.Forms.CheckBox checkBox_half;
        private System.Windows.Forms.CheckBox checkBox_min;
        private System.Windows.Forms.RadioButton rb_a;
        private System.Windows.Forms.RadioButton rb_b;
        private System.Windows.Forms.RadioButton rb_c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_contribution;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_registration;
        private System.Windows.Forms.Label lab_sum_contribution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
        private System.Windows.Forms.Button but_info;
    }
}