namespace Lab1
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
            this.testConnection = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cat_CafeDataSet = new Lab1.Cat_CafeDataSet();
            this.staffTableAdapter = new Lab1.Cat_CafeDataSetTableAdapters.StaffTableAdapter();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.staffidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsTableAdapter = new Lab1.Cat_CafeDataSetTableAdapters.ShiftsTableAdapter();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxCnp = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxShiftDate = new System.Windows.Forms.TextBox();
            this.textBoxShiftId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddShift = new System.Windows.Forms.Button();
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_CafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testConnection
            // 
            this.testConnection.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.testConnection.ForeColor = System.Drawing.Color.White;
            this.testConnection.Location = new System.Drawing.Point(694, 209);
            this.testConnection.Margin = new System.Windows.Forms.Padding(2);
            this.testConnection.Name = "testConnection";
            this.testConnection.Size = new System.Drawing.Size(225, 44);
            this.testConnection.TabIndex = 0;
            this.testConnection.Text = "Test Connection";
            this.testConnection.UseVisualStyleBackColor = false;
            this.testConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AutoGenerateColumns = false;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn});
            this.dataGridViewStaff.DataSource = this.staffBindingSource;
            this.dataGridViewStaff.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(560, 209);
            this.dataGridViewStaff.TabIndex = 1;
            this.dataGridViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellClick);
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "cnp";
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.cat_CafeDataSet;
            // 
            // cat_CafeDataSet
            // 
            this.cat_CafeDataSet.DataSetName = "Cat_CafeDataSet";
            this.cat_CafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AutoGenerateColumns = false;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn1,
            this.shiftidDataGridViewTextBoxColumn,
            this.shiftdateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn});
            this.dataGridViewShifts.DataSource = this.shiftsBindingSource;
            this.dataGridViewShifts.Location = new System.Drawing.Point(12, 374);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.Size = new System.Drawing.Size(560, 150);
            this.dataGridViewShifts.TabIndex = 2;
            // 
            // staffidDataGridViewTextBoxColumn1
            // 
            this.staffidDataGridViewTextBoxColumn1.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn1.HeaderText = "staff_id";
            this.staffidDataGridViewTextBoxColumn1.Name = "staffidDataGridViewTextBoxColumn1";
            // 
            // shiftidDataGridViewTextBoxColumn
            // 
            this.shiftidDataGridViewTextBoxColumn.DataPropertyName = "shift_id";
            this.shiftidDataGridViewTextBoxColumn.HeaderText = "shift_id";
            this.shiftidDataGridViewTextBoxColumn.Name = "shiftidDataGridViewTextBoxColumn";
            // 
            // shiftdateDataGridViewTextBoxColumn
            // 
            this.shiftdateDataGridViewTextBoxColumn.DataPropertyName = "shift_date";
            this.shiftdateDataGridViewTextBoxColumn.HeaderText = "shift_date";
            this.shiftdateDataGridViewTextBoxColumn.Name = "shiftdateDataGridViewTextBoxColumn";
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this.cat_CafeDataSet;
            // 
            // shiftsTableAdapter
            // 
            this.shiftsTableAdapter.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add.ForeColor = System.Drawing.SystemColors.Control;
            this.Add.Location = new System.Drawing.Point(694, 160);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(225, 44);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add Staff";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(691, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "staff_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "last_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "first_name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "cnp";
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Location = new System.Drawing.Point(755, 30);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(164, 20);
            this.textBoxStaffId.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(755, 56);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(164, 20);
            this.textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(755, 82);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(164, 20);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(755, 108);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(164, 20);
            this.textBoxAge.TabIndex = 12;
            // 
            // textBoxCnp
            // 
            this.textBoxCnp.Location = new System.Drawing.Point(755, 134);
            this.textBoxCnp.Name = "textBoxCnp";
            this.textBoxCnp.Size = new System.Drawing.Size(164, 20);
            this.textBoxCnp.TabIndex = 13;
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(755, 404);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(164, 20);
            this.textBoxEndTime.TabIndex = 23;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(755, 378);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(164, 20);
            this.textBoxStartTime.TabIndex = 22;
            // 
            // textBoxShiftDate
            // 
            this.textBoxShiftDate.Location = new System.Drawing.Point(755, 352);
            this.textBoxShiftDate.Name = "textBoxShiftDate";
            this.textBoxShiftDate.Size = new System.Drawing.Size(164, 20);
            this.textBoxShiftDate.TabIndex = 21;
            // 
            // textBoxShiftId
            // 
            this.textBoxShiftId.Location = new System.Drawing.Point(755, 326);
            this.textBoxShiftId.Name = "textBoxShiftId";
            this.textBoxShiftId.Size = new System.Drawing.Size(164, 20);
            this.textBoxShiftId.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "end_time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "start_time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "shift_date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "shift_id";
            // 
            // buttonAddShift
            // 
            this.buttonAddShift.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddShift.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddShift.Location = new System.Drawing.Point(694, 430);
            this.buttonAddShift.Name = "buttonAddShift";
            this.buttonAddShift.Size = new System.Drawing.Size(225, 44);
            this.buttonAddShift.TabIndex = 24;
            this.buttonAddShift.Text = "Add Shift";
            this.buttonAddShift.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteShift.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteShift.Location = new System.Drawing.Point(694, 480);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(225, 44);
            this.buttonDeleteShift.TabIndex = 25;
            this.buttonDeleteShift.Text = "Delete Shift";
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUpdateShift.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdateShift.Location = new System.Drawing.Point(694, 530);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(225, 44);
            this.buttonUpdateShift.TabIndex = 26;
            this.buttonUpdateShift.Text = "Update Shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 638);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonAddShift);
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.textBoxShiftDate);
            this.Controls.Add(this.textBoxShiftId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCnp);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxStaffId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridViewShifts);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.testConnection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_CafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testConnection;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private Cat_CafeDataSet cat_CafeDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Cat_CafeDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private Cat_CafeDataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStaffId;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxCnp;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxShiftDate;
        private System.Windows.Forms.TextBox textBoxShiftId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddShift;
        private System.Windows.Forms.Button buttonDeleteShift;
        private System.Windows.Forms.Button buttonUpdateShift;
    }
}

