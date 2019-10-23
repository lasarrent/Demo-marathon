namespace demo_maraphon
{
    partial class Sponsor_a_runner
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_runner = new System.Windows.Forms.ComboBox();
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463zhmurovdemoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zhmurov_demoDataSet1 = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_card = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_fond = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lab_sum = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.but_minus = new System.Windows.Forms.Button();
            this.but_plus = new System.Windows.Forms.Button();
            this.but_pay = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_date = new System.Windows.Forms.Label();
            this.g463_zhmurov_demoDataSet = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.g463zhmurovdemoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnerTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.RunnerTableAdapter();
            this.tb_number_card = new System.Windows.Forms.MaskedTextBox();
            this.tb_month = new System.Windows.Forms.MaskedTextBox();
            this.tb_year = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_cvc = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463zhmurovdemoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463zhmurovdemoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 66);
            this.panel1.TabIndex = 1;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(290, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Спонсор бегуна";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(78, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 84);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму, которую в" +
    "ы хотели бы спонсировать.  Спасибо за вашу поддержку бегунов и их благотворитель" +
    "ных учреждений.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(77, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Информация о спонсоре";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_name.Location = new System.Drawing.Point(221, 299);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(235, 31);
            this.tb_name.TabIndex = 5;
            this.tb_name.Text = "Ваше имя";
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // cb_runner
            // 
            this.cb_runner.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.runnerBindingSource, "CountryCode", true));
            this.cb_runner.DataSource = this.runnerBindingSource;
            this.cb_runner.DisplayMember = "Display";
            this.cb_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_runner.FormattingEnabled = true;
            this.cb_runner.Location = new System.Drawing.Point(221, 348);
            this.cb_runner.Name = "cb_runner";
            this.cb_runner.Size = new System.Drawing.Size(235, 33);
            this.cb_runner.TabIndex = 6;
            this.cb_runner.ValueMember = "RegistrationId";
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "Runner";
            this.runnerBindingSource.DataSource = this.g463zhmurovdemoDataSet1BindingSource;
            // 
            // g463zhmurovdemoDataSet1BindingSource
            // 
            this.g463zhmurovdemoDataSet1BindingSource.DataSource = this.g463_zhmurov_demoDataSet1;
            this.g463zhmurovdemoDataSet1BindingSource.Position = 0;
            // 
            // g463_zhmurov_demoDataSet1
            // 
            this.g463_zhmurov_demoDataSet1.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(87, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ваше имя";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(87, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Бегун:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(87, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Карта:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_card
            // 
            this.tb_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_card.ForeColor = System.Drawing.Color.Gray;
            this.tb_card.Location = new System.Drawing.Point(221, 399);
            this.tb_card.Name = "tb_card";
            this.tb_card.Size = new System.Drawing.Size(235, 31);
            this.tb_card.TabIndex = 11;
            this.tb_card.Text = "Владелец карты";
            this.tb_card.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_card.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Номер карты:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(17, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Срок действия:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(17, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "CVC:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(567, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Благотворительность";
            // 
            // lab_fond
            // 
            this.lab_fond.AutoSize = true;
            this.lab_fond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_fond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_fond.Location = new System.Drawing.Point(650, 284);
            this.lab_fond.Name = "lab_fond";
            this.lab_fond.Size = new System.Drawing.Size(138, 25);
            this.lab_fond.TabIndex = 21;
            this.lab_fond.Text = "Фонд Кошек";
            this.lab_fond.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(567, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(299, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "Сумма пожертвования";
            // 
            // lab_sum
            // 
            this.lab_sum.AutoSize = true;
            this.lab_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_sum.ForeColor = System.Drawing.Color.Gray;
            this.lab_sum.Location = new System.Drawing.Point(648, 402);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(104, 73);
            this.lab_sum.TabIndex = 23;
            this.lab_sum.Text = "$0";
            this.lab_sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_money.ForeColor = System.Drawing.Color.Gray;
            this.tb_money.Location = new System.Drawing.Point(677, 499);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(82, 31);
            this.tb_money.TabIndex = 24;
            this.tb_money.Text = "0";
            this.tb_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_money.TextChanged += new System.EventHandler(this.tb_money_TextChanged);
            this.tb_money.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_money.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // but_minus
            // 
            this.but_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_minus.Location = new System.Drawing.Point(631, 499);
            this.but_minus.Name = "but_minus";
            this.but_minus.Size = new System.Drawing.Size(40, 31);
            this.but_minus.TabIndex = 25;
            this.but_minus.Text = "-";
            this.but_minus.UseVisualStyleBackColor = true;
            this.but_minus.Click += new System.EventHandler(this.but_minus_Click);
            // 
            // but_plus
            // 
            this.but_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_plus.Location = new System.Drawing.Point(765, 499);
            this.but_plus.Name = "but_plus";
            this.but_plus.Size = new System.Drawing.Size(40, 31);
            this.but_plus.TabIndex = 26;
            this.but_plus.Text = "+";
            this.but_plus.UseVisualStyleBackColor = true;
            this.but_plus.Click += new System.EventHandler(this.but_plus_Click);
            // 
            // but_pay
            // 
            this.but_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_pay.Location = new System.Drawing.Point(560, 575);
            this.but_pay.Name = "but_pay";
            this.but_pay.Size = new System.Drawing.Size(140, 37);
            this.but_pay.TabIndex = 27;
            this.but_pay.Text = "Заплатить";
            this.but_pay.UseVisualStyleBackColor = true;
            this.but_pay.Click += new System.EventHandler(this.but_pay_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.Location = new System.Drawing.Point(726, 575);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(105, 37);
            this.but_cancel.TabIndex = 28;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lab_date);
            this.panel2.Location = new System.Drawing.Point(-5, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 54);
            this.panel2.TabIndex = 29;
            // 
            // lab_date
            // 
            this.lab_date.AutoSize = true;
            this.lab_date.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_date.ForeColor = System.Drawing.Color.White;
            this.lab_date.Location = new System.Drawing.Point(178, 15);
            this.lab_date.Name = "lab_date";
            this.lab_date.Size = new System.Drawing.Size(58, 29);
            this.lab_date.TabIndex = 3;
            this.lab_date.Text = "data";
            // 
            // g463_zhmurov_demoDataSet
            // 
            this.g463_zhmurov_demoDataSet.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // g463zhmurovdemoDataSetBindingSource
            // 
            this.g463zhmurovdemoDataSetBindingSource.DataSource = this.g463_zhmurov_demoDataSet;
            this.g463zhmurovdemoDataSetBindingSource.Position = 0;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // tb_number_card
            // 
            this.tb_number_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number_card.ForeColor = System.Drawing.Color.Gray;
            this.tb_number_card.Location = new System.Drawing.Point(221, 450);
            this.tb_number_card.Mask = "0000 0000 0000 0000";
            this.tb_number_card.Name = "tb_number_card";
            this.tb_number_card.Size = new System.Drawing.Size(235, 31);
            this.tb_number_card.TabIndex = 30;
            this.tb_number_card.Text = "1234123412341234";
            this.tb_number_card.Enter += new System.EventHandler(this.tb_number_card_Enter);
            this.tb_number_card.Leave += new System.EventHandler(this.tb_number_card_Leave);
            // 
            // tb_month
            // 
            this.tb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_month.ForeColor = System.Drawing.Color.Gray;
            this.tb_month.Location = new System.Drawing.Point(221, 499);
            this.tb_month.Mask = "00";
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(50, 31);
            this.tb_month.TabIndex = 31;
            this.tb_month.Text = "01";
            this.tb_month.Enter += new System.EventHandler(this.tb_number_card_Enter);
            this.tb_month.Leave += new System.EventHandler(this.tb_number_card_Leave);
            // 
            // tb_year
            // 
            this.tb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_year.ForeColor = System.Drawing.Color.Gray;
            this.tb_year.Location = new System.Drawing.Point(295, 499);
            this.tb_year.Mask = "0000";
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(71, 31);
            this.tb_year.TabIndex = 32;
            this.tb_year.Text = "2017";
            this.tb_year.Enter += new System.EventHandler(this.tb_number_card_Enter);
            this.tb_year.Leave += new System.EventHandler(this.tb_number_card_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_cvc
            // 
            this.tb_cvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cvc.ForeColor = System.Drawing.Color.Gray;
            this.tb_cvc.Location = new System.Drawing.Point(221, 548);
            this.tb_cvc.Mask = "000";
            this.tb_cvc.Name = "tb_cvc";
            this.tb_cvc.Size = new System.Drawing.Size(71, 31);
            this.tb_cvc.TabIndex = 33;
            this.tb_cvc.Text = "123";
            this.tb_cvc.Enter += new System.EventHandler(this.tb_number_card_Enter);
            this.tb_cvc.Leave += new System.EventHandler(this.tb_number_card_Leave);
            // 
            // Sponsor_a_runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 695);
            this.Controls.Add(this.tb_cvc);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_number_card);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_pay);
            this.Controls.Add(this.but_plus);
            this.Controls.Add(this.but_minus);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.lab_sum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lab_fond);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_card);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_runner);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sponsor_a_runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sponsor_a_runner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sponsor_a_runner_FormClosed);
            this.Load += new System.EventHandler(this.Sponsor_a_runner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463zhmurovdemoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463zhmurovdemoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_card;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Button but_minus;
        private System.Windows.Forms.Button but_plus;
        private System.Windows.Forms.Button but_pay;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_date;
        private System.Windows.Forms.BindingSource g463zhmurovdemoDataSetBindingSource;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet1;
        private System.Windows.Forms.BindingSource g463zhmurovdemoDataSet1BindingSource;
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.RunnerTableAdapter runnerTableAdapter;
        public System.Windows.Forms.Label lab_sum;
        public System.Windows.Forms.ComboBox cb_runner;
        public System.Windows.Forms.Label lab_fond;
        private System.Windows.Forms.MaskedTextBox tb_number_card;
        private System.Windows.Forms.MaskedTextBox tb_month;
        private System.Windows.Forms.MaskedTextBox tb_year;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox tb_cvc;
    }
}