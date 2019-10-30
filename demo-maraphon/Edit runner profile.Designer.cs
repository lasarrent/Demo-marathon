namespace demo_maraphon
{
    partial class Edit_runner_profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_logout = new System.Windows.Forms.Button();
            this.but_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_email = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zhmurov_demoDataSet = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_yearBorn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_photoName = new System.Windows.Forms.TextBox();
            this.but_view = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_repass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.genderTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.GenderTableAdapter();
            this.countryTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.CountryTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(162, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Редактирование профиля";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_logout);
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 66);
            this.panel1.TabIndex = 5;
            // 
            // but_logout
            // 
            this.but_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.but_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_logout.Location = new System.Drawing.Point(831, 12);
            this.but_logout.Name = "but_logout";
            this.but_logout.Size = new System.Drawing.Size(92, 31);
            this.but_logout.TabIndex = 3;
            this.but_logout.Text = "logout";
            this.but_logout.UseVisualStyleBackColor = false;
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
            // pic_photo
            // 
            this.pic_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_photo.Location = new System.Drawing.Point(733, 88);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(136, 159);
            this.pic_photo.TabIndex = 28;
            this.pic_photo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(130, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lab_email
            // 
            this.lab_email.AutoSize = true;
            this.lab_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_email.ForeColor = System.Drawing.Color.Gray;
            this.lab_email.Location = new System.Drawing.Point(219, 161);
            this.lab_email.Name = "lab_email";
            this.lab_email.Size = new System.Drawing.Size(243, 25);
            this.lab_email.TabIndex = 30;
            this.lab_email.Text = "the.email@address.com";
            this.lab_email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(90, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Пол:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_gender
            // 
            this.cb_gender.DataSource = this.genderBindingSource;
            this.cb_gender.DisplayMember = "Gender";
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_gender.ForeColor = System.Drawing.Color.Gray;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(224, 319);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(143, 33);
            this.cb_gender.TabIndex = 35;
            this.cb_gender.ValueMember = "Gender";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.g463_zhmurov_demoDataSet;
            // 
            // g463_zhmurov_demoDataSet
            // 
            this.g463_zhmurov_demoDataSet.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(82, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Фамилия:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_name.Location = new System.Drawing.Point(224, 265);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(210, 31);
            this.tb_name.TabIndex = 33;
            this.tb_name.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(82, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Имя:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_firstName.ForeColor = System.Drawing.Color.Gray;
            this.tb_firstName.Location = new System.Drawing.Point(224, 209);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(210, 31);
            this.tb_firstName.TabIndex = 31;
            this.tb_firstName.Text = "Имя";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(86, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Страна:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_country
            // 
            this.cb_country.DataSource = this.countryBindingSource;
            this.cb_country.DisplayMember = "CountryName";
            this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_country.ForeColor = System.Drawing.Color.Gray;
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(220, 424);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(191, 33);
            this.cb_country.TabIndex = 39;
            this.cb_country.ValueMember = "CountryCode";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.g463_zhmurov_demoDataSet;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(19, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 38;
            this.label11.Text = "Дата рождения:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_yearBorn
            // 
            this.dtp_yearBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_yearBorn.Location = new System.Drawing.Point(220, 374);
            this.dtp_yearBorn.Name = "dtp_yearBorn";
            this.dtp_yearBorn.Size = new System.Drawing.Size(190, 31);
            this.dtp_yearBorn.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(573, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Фото файл:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_photoName
            // 
            this.tb_photoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_photoName.ForeColor = System.Drawing.Color.Gray;
            this.tb_photoName.Location = new System.Drawing.Point(578, 304);
            this.tb_photoName.Name = "tb_photoName";
            this.tb_photoName.Size = new System.Drawing.Size(182, 31);
            this.tb_photoName.TabIndex = 41;
            this.tb_photoName.Text = "Photo_log.jpg";
            // 
            // but_view
            // 
            this.but_view.BackColor = System.Drawing.Color.White;
            this.but_view.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_view.ForeColor = System.Drawing.Color.Black;
            this.but_view.Location = new System.Drawing.Point(766, 302);
            this.but_view.Name = "but_view";
            this.but_view.Size = new System.Drawing.Size(137, 38);
            this.but_view.TabIndex = 43;
            this.but_view.Text = "Просмотр...";
            this.but_view.UseVisualStyleBackColor = false;
            this.but_view.Click += new System.EventHandler(this.but_view_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(609, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Смена пароля";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(527, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 53);
            this.label7.TabIndex = 45;
            this.label7.Text = "Оставьте эти поля незаполненными, если вы не хотите изменять пароль.";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(431, 525);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Повтор пароль:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_repass
            // 
            this.tb_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_repass.ForeColor = System.Drawing.Color.Gray;
            this.tb_repass.Location = new System.Drawing.Point(672, 519);
            this.tb_repass.Name = "tb_repass";
            this.tb_repass.Size = new System.Drawing.Size(210, 31);
            this.tb_repass.TabIndex = 48;
            this.tb_repass.Text = "Повторите пароль";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(501, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 25);
            this.label14.TabIndex = 47;
            this.label14.Text = "Пароль:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.ForeColor = System.Drawing.Color.Gray;
            this.tb_pass.Location = new System.Drawing.Point(672, 464);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(210, 31);
            this.tb_pass.TabIndex = 46;
            this.tb_pass.Text = "Пароль";
            // 
            // but_cancel
            // 
            this.but_cancel.BackColor = System.Drawing.Color.White;
            this.but_cancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cancel.ForeColor = System.Drawing.Color.Black;
            this.but_cancel.Location = new System.Drawing.Point(489, 585);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(115, 38);
            this.but_cancel.TabIndex = 51;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = false;
            // 
            // but_save
            // 
            this.but_save.BackColor = System.Drawing.Color.White;
            this.but_save.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_save.ForeColor = System.Drawing.Color.Black;
            this.but_save.Location = new System.Drawing.Point(309, 585);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(153, 38);
            this.but_save.TabIndex = 50;
            this.but_save.Text = "Сохранить";
            this.but_save.UseVisualStyleBackColor = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label_date);
            this.panel2.Location = new System.Drawing.Point(0, 646);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 54);
            this.panel2.TabIndex = 52;
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
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Edit_runner_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_repass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_view);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_photoName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtp_yearBorn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.lab_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_runner_profile";
            this.Text = "Edit_runner_profile";
            this.Load += new System.EventHandler(this.Edit_runner_profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_logout;
        private System.Windows.Forms.PictureBox pic_photo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_yearBorn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_photoName;
        private System.Windows.Forms.Button but_view;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_repass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_date;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Timer timer1;
    }
}