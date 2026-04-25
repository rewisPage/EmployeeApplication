namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDatabase));
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new Panel();
            txtPosition = new ReaLTaiizor.Controls.CrownTextBox();
            label4 = new Label();
            txtLastName = new ReaLTaiizor.Controls.CrownTextBox();
            label1 = new Label();
            txtFirstName = new ReaLTaiizor.Controls.CrownTextBox();
            label3 = new Label();
            txtEmployeeID = new ReaLTaiizor.Controls.CrownTextBox();
            label2 = new Label();
            btnSubmit = new ReaLTaiizor.Controls.Button();
            dgvEmployeeList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // controlBox1
            // 
            controlBox1.BackColor = Color.FromArgb(53, 53, 53);
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = true;
            controlBox1.Dock = DockStyle.Right;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(810, 0);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 0;
            controlBox1.Text = "controlBox1";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Dock = DockStyle.Top;
            bigLabel1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(0, 122, 204);
            bigLabel1.Location = new Point(0, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Padding = new Padding(10, 25, 0, 0);
            bigLabel1.Size = new Size(334, 70);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Employee Database";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPosition);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmployeeID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(19, 95);
            panel1.Margin = new Padding(10, 25, 25, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 321);
            panel1.TabIndex = 2;
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.FromArgb(69, 73, 74);
            txtPosition.BorderStyle = BorderStyle.FixedSingle;
            txtPosition.Dock = DockStyle.Top;
            txtPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosition.ForeColor = Color.FromArgb(220, 220, 220);
            txtPosition.Location = new Point(0, 281);
            txtPosition.Margin = new Padding(3, 3, 3, 30);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(312, 29);
            txtPosition.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(0, 230);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 20, 0, 10);
            label4.Size = new Size(72, 51);
            label4.TabIndex = 7;
            label4.Text = "Position :";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(69, 73, 74);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Dock = DockStyle.Top;
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(220, 220, 220);
            txtLastName.Location = new Point(0, 201);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(312, 29);
            txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(0, 150);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 20, 0, 10);
            label1.Size = new Size(88, 51);
            label1.TabIndex = 5;
            label1.Text = "Last name :";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(69, 73, 74);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Dock = DockStyle.Top;
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.FromArgb(220, 220, 220);
            txtFirstName.Location = new Point(0, 121);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(312, 29);
            txtFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(0, 70);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 20, 0, 10);
            label3.Size = new Size(90, 51);
            label3.TabIndex = 3;
            label3.Text = "First name :";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.BackColor = Color.FromArgb(69, 73, 74);
            txtEmployeeID.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeID.Dock = DockStyle.Top;
            txtEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.ForeColor = Color.FromArgb(220, 220, 220);
            txtEmployeeID.Location = new Point(0, 41);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(312, 29);
            txtEmployeeID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.Size = new Size(104, 41);
            label2.TabIndex = 1;
            label2.Text = "Employee ID :";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.BorderColor = Color.FromArgb(0, 122, 204);
            btnSubmit.EnteredBorderColor = Color.LightSkyBlue;
            btnSubmit.EnteredColor = Color.LightSkyBlue;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Image = null;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.InactiveColor = Color.FromArgb(0, 122, 204);
            btnSubmit.Location = new Point(19, 439);
            btnSubmit.Margin = new Padding(3, 20, 3, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(0, 20, 0, 0);
            btnSubmit.PressedBorderColor = Color.FromArgb(0, 122, 204);
            btnSubmit.PressedColor = Color.FromArgb(32, 34, 37);
            btnSubmit.Size = new Size(312, 50);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.TextAlignment = StringAlignment.Center;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeList.BackgroundColor = Color.FromArgb(69, 69, 69);
            dgvEmployeeList.BorderStyle = BorderStyle.None;
            dgvEmployeeList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(69, 69, 69);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(75, 75, 79);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmployeeList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployeeList.EnableHeadersVisualStyles = false;
            dgvEmployeeList.Location = new Point(359, 95);
            dgvEmployeeList.Margin = new Padding(3, 3, 10, 3);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 69, 69);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 75, 79);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmployeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployeeList.RowHeadersVisible = false;
            dgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeList.Size = new Size(522, 321);
            dgvEmployeeList.TabIndex = 10;
            // 
            // frmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 53, 53);
            ClientSize = new Size(900, 550);
            Controls.Add(dgvEmployeeList);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(bigLabel1);
            Controls.Add(controlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Database";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
        private Label label2;
        private ReaLTaiizor.Controls.CrownTextBox txtEmployeeID;
        private ReaLTaiizor.Controls.CrownTextBox txtFirstName;
        private Label label3;
        private ReaLTaiizor.Controls.CrownTextBox txtLastName;
        private Label label1;
        private ReaLTaiizor.Controls.CrownTextBox txtPosition;
        private Label label4;
        private ReaLTaiizor.Controls.Button btnSubmit;
        private DataGridView dgvEmployeeList;
    }
}
