namespace Employee_Registration
{
    partial class Form1
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
            this.empRegGB = new System.Windows.Forms.GroupBox();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jobBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.MaskedTextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.procedGB = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.graphicsBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.listBtn = new System.Windows.Forms.Button();
            this.recGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet1 = new Employee_Registration.employeesDataSet1();
            this.employeesTableAdapter = new Employee_Registration.employeesDataSet1TableAdapters.employeesTableAdapter();
            this.empRegGB.SuspendLayout();
            this.procedGB.SuspendLayout();
            this.recGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // empRegGB
            // 
            this.empRegGB.Controls.Add(this.radioS);
            this.empRegGB.Controls.Add(this.radioM);
            this.empRegGB.Controls.Add(this.label7);
            this.empRegGB.Controls.Add(this.label6);
            this.empRegGB.Controls.Add(this.label5);
            this.empRegGB.Controls.Add(this.jobBox);
            this.empRegGB.Controls.Add(this.cityBox);
            this.empRegGB.Controls.Add(this.nameBox);
            this.empRegGB.Controls.Add(this.label4);
            this.empRegGB.Controls.Add(this.label2);
            this.empRegGB.Controls.Add(this.salaryBox);
            this.empRegGB.Controls.Add(this.surnameBox);
            this.empRegGB.Controls.Add(this.label3);
            this.empRegGB.Controls.Add(this.IDBox);
            this.empRegGB.Controls.Add(this.label1);
            this.empRegGB.Location = new System.Drawing.Point(12, 15);
            this.empRegGB.Name = "empRegGB";
            this.empRegGB.Size = new System.Drawing.Size(443, 239);
            this.empRegGB.TabIndex = 0;
            this.empRegGB.TabStop = false;
            this.empRegGB.Text = "Registration";
            // 
            // radioS
            // 
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(271, 198);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(69, 23);
            this.radioS.TabIndex = 8;
            this.radioS.TabStop = true;
            this.radioS.Text = "Single";
            this.radioS.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(186, 198);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(79, 23);
            this.radioM.TabIndex = 7;
            this.radioM.TabStop = true;
            this.radioM.Text = "Married";
            this.radioM.UseVisualStyleBackColor = true;
            this.radioM.CheckedChanged += new System.EventHandler(this.radioM_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary:";
            // 
            // jobBox
            // 
            this.jobBox.Location = new System.Drawing.Point(315, 143);
            this.jobBox.Name = "jobBox";
            this.jobBox.Size = new System.Drawing.Size(104, 27);
            this.jobBox.TabIndex = 6;
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Ankara",
            "Antalya",
            "İstanbul",
            "İzmir",
            "Eskişehir",
            "Bursa",
            "Çanakkale",
            "Kocaeli",
            "Edirne"});
            this.cityBox.Location = new System.Drawing.Point(86, 145);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(104, 27);
            this.cityBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(315, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(104, 27);
            this.nameBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(315, 86);
            this.salaryBox.Mask = "0000";
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(104, 27);
            this.salaryBox.TabIndex = 5;
            this.salaryBox.ValidatingType = typeof(int);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(86, 86);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(104, 27);
            this.surnameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(86, 26);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(104, 27);
            this.IDBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // procedGB
            // 
            this.procedGB.Controls.Add(this.exitBtn);
            this.procedGB.Controls.Add(this.graphicsBtn);
            this.procedGB.Controls.Add(this.statisticsBtn);
            this.procedGB.Controls.Add(this.clearBtn);
            this.procedGB.Controls.Add(this.updateBtn);
            this.procedGB.Controls.Add(this.deleteBtn);
            this.procedGB.Controls.Add(this.saveBtn);
            this.procedGB.Controls.Add(this.listBtn);
            this.procedGB.Location = new System.Drawing.Point(461, 15);
            this.procedGB.Name = "procedGB";
            this.procedGB.Size = new System.Drawing.Size(304, 259);
            this.procedGB.TabIndex = 1;
            this.procedGB.TabStop = false;
            this.procedGB.Text = "Procedures";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(186, 196);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 30);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // graphicsBtn
            // 
            this.graphicsBtn.Location = new System.Drawing.Point(23, 196);
            this.graphicsBtn.Name = "graphicsBtn";
            this.graphicsBtn.Size = new System.Drawing.Size(112, 30);
            this.graphicsBtn.TabIndex = 15;
            this.graphicsBtn.Text = "Graphics";
            this.graphicsBtn.UseVisualStyleBackColor = true;
            this.graphicsBtn.Click += new System.EventHandler(this.graphicsBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Location = new System.Drawing.Point(186, 143);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(112, 30);
            this.statisticsBtn.TabIndex = 14;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(23, 143);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 30);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(186, 86);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(112, 30);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(23, 86);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 30);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(186, 26);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 30);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.Location = new System.Drawing.Point(23, 26);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(112, 29);
            this.listBtn.TabIndex = 9;
            this.listBtn.Text = "List";
            this.listBtn.UseVisualStyleBackColor = true;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // recGB
            // 
            this.recGB.Controls.Add(this.dataGridView1);
            this.recGB.Location = new System.Drawing.Point(13, 257);
            this.recGB.Name = "recGB";
            this.recGB.Size = new System.Drawing.Size(758, 171);
            this.recGB.TabIndex = 1;
            this.recGB.TabStop = false;
            this.recGB.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.mstatusDataGridViewCheckBoxColumn,
            this.jobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 145);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // mstatusDataGridViewCheckBoxColumn
            // 
            this.mstatusDataGridViewCheckBoxColumn.DataPropertyName = "Mstatus";
            this.mstatusDataGridViewCheckBoxColumn.HeaderText = "Mstatus";
            this.mstatusDataGridViewCheckBoxColumn.Name = "mstatusDataGridViewCheckBoxColumn";
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.employeesDataSet1;
            // 
            // employeesDataSet1
            // 
            this.employeesDataSet1.DataSetName = "employeesDataSet1";
            this.employeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 440);
            this.Controls.Add(this.recGB);
            this.Controls.Add(this.procedGB);
            this.Controls.Add(this.empRegGB);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.empRegGB.ResumeLayout(false);
            this.empRegGB.PerformLayout();
            this.procedGB.ResumeLayout(false);
            this.recGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox empRegGB;
        private System.Windows.Forms.GroupBox procedGB;
        private System.Windows.Forms.GroupBox recGB;
        private System.Windows.Forms.TextBox jobBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox salaryBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button graphicsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private employeesDataSet1 employeesDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private employeesDataSet1TableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitBtn;
    }
}

