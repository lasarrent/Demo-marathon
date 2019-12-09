namespace demo_maraphon
{
    partial class inventar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameOptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceKitOptionADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceKitOptionBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceKitOptionCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zhmurov_demoDataSet1 = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.raceKitOptionSumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g463_zhmurov_demoDataSet = new demo_maraphon.g463_zhmurov_demoDataSet();
            this.raceKitOptionSumTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.RaceKitOptionSumTableAdapter();
            this.inventoryTableAdapter = new demo_maraphon.g463_zhmurov_demoDataSetTableAdapters.inventoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RaceA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaceB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaceC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaceSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butReceipt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionSumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.but_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 66);
            this.panel1.TabIndex = 8;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(427, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 56;
            this.label7.Text = "Инвентарь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Всего зарегистрировано бегунов на марафон: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameOptionDataGridViewTextBoxColumn,
            this.raceKitOptionADataGridViewTextBoxColumn,
            this.raceKitOptionBDataGridViewTextBoxColumn,
            this.raceKitOptionCDataGridViewTextBoxColumn,
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inventoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(78, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(797, 169);
            this.dataGridView2.TabIndex = 59;
            // 
            // nameOptionDataGridViewTextBoxColumn
            // 
            this.nameOptionDataGridViewTextBoxColumn.DataPropertyName = "NameOption";
            this.nameOptionDataGridViewTextBoxColumn.HeaderText = "NameOption";
            this.nameOptionDataGridViewTextBoxColumn.Name = "nameOptionDataGridViewTextBoxColumn";
            this.nameOptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceKitOptionADataGridViewTextBoxColumn
            // 
            this.raceKitOptionADataGridViewTextBoxColumn.DataPropertyName = "RaceKitOptionA";
            this.raceKitOptionADataGridViewTextBoxColumn.HeaderText = "RaceKitOptionA";
            this.raceKitOptionADataGridViewTextBoxColumn.Name = "raceKitOptionADataGridViewTextBoxColumn";
            this.raceKitOptionADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceKitOptionBDataGridViewTextBoxColumn
            // 
            this.raceKitOptionBDataGridViewTextBoxColumn.DataPropertyName = "RaceKitOptionB";
            this.raceKitOptionBDataGridViewTextBoxColumn.HeaderText = "RaceKitOptionB";
            this.raceKitOptionBDataGridViewTextBoxColumn.Name = "raceKitOptionBDataGridViewTextBoxColumn";
            this.raceKitOptionBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceKitOptionCDataGridViewTextBoxColumn
            // 
            this.raceKitOptionCDataGridViewTextBoxColumn.DataPropertyName = "RaceKitOptionC";
            this.raceKitOptionCDataGridViewTextBoxColumn.HeaderText = "RaceKitOptionC";
            this.raceKitOptionCDataGridViewTextBoxColumn.Name = "raceKitOptionCDataGridViewTextBoxColumn";
            this.raceKitOptionCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumOfRaceKitOptionsDataGridViewTextBoxColumn
            // 
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn.DataPropertyName = "SumOfRaceKitOptions";
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn.HeaderText = "SumOfRaceKitOptions";
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn.Name = "sumOfRaceKitOptionsDataGridViewTextBoxColumn";
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumOfRaceKitOptionsDataGridViewTextBoxColumn.Width = 150;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.g463_zhmurov_demoDataSet1;
            // 
            // g463_zhmurov_demoDataSet1
            // 
            this.g463_zhmurov_demoDataSet1.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceKitOptionSumBindingSource
            // 
            this.raceKitOptionSumBindingSource.DataMember = "RaceKitOptionSum";
            this.raceKitOptionSumBindingSource.DataSource = this.g463_zhmurov_demoDataSet;
            // 
            // g463_zhmurov_demoDataSet
            // 
            this.g463_zhmurov_demoDataSet.DataSetName = "g463_zhmurov_demoDataSet";
            this.g463_zhmurov_demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raceKitOptionSumTableAdapter
            // 
            this.raceKitOptionSumTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RaceA,
            this.RaceB,
            this.RaceC,
            this.RaceSum});
            this.dataGridView1.Location = new System.Drawing.Point(258, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 73);
            this.dataGridView1.TabIndex = 60;
            // 
            // RaceA
            // 
            this.RaceA.HeaderText = "RaceA";
            this.RaceA.Name = "RaceA";
            // 
            // RaceB
            // 
            this.RaceB.HeaderText = "RaceB";
            this.RaceB.Name = "RaceB";
            // 
            // RaceC
            // 
            this.RaceC.HeaderText = "RaceC";
            this.RaceC.Name = "RaceC";
            // 
            // RaceSum
            // 
            this.RaceSum.HeaderText = "RaceSum";
            this.RaceSum.Name = "RaceSum";
            // 
            // butReceipt
            // 
            this.butReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReceipt.Location = new System.Drawing.Point(680, 518);
            this.butReceipt.Name = "butReceipt";
            this.butReceipt.Size = new System.Drawing.Size(195, 31);
            this.butReceipt.TabIndex = 3;
            this.butReceipt.Text = "Поступление";
            this.butReceipt.UseVisualStyleBackColor = false;
            this.butReceipt.Click += new System.EventHandler(this.butReceipt_Click);
            // 
            // inventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 580);
            this.Controls.Add(this.butReceipt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "inventar";
            this.Text = "inventar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inventar_FormClosed);
            this.Load += new System.EventHandler(this.inventar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionSumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g463_zhmurov_demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet;
        private System.Windows.Forms.BindingSource raceKitOptionSumBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.RaceKitOptionSumTableAdapter raceKitOptionSumTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private g463_zhmurov_demoDataSet g463_zhmurov_demoDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private g463_zhmurov_demoDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceKitOptionADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceKitOptionBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceKitOptionCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfRaceKitOptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceSum;
        private System.Windows.Forms.Button butReceipt;
    }
}