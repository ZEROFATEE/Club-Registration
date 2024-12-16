namespace Club_Registration
{
    partial class FrmUpdateMember
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
            label6 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            cmbStudentId = new ComboBox();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            textBox1 = new TextBox();
            txtAge = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 51);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 37;
            label6.Text = "Program:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 111);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 36;
            label5.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(35, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(178, 23);
            txtFirstName.TabIndex = 35;
            // 
            // cmbStudentId
            // 
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Items.AddRange(new object[] { "Bachelor of Computer Science", "Bachelor of Information Technology ", "Bachelor of Computer Animation", "Bachelor of Software Engineering" });
            cmbStudentId.Location = new Point(35, 25);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(197, 23);
            cmbStudentId.TabIndex = 34;
            cmbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Bachelor of Computer Science", "Bachelor of Information Technology ", "Bachelor of Computer Animation", "Bachelor of Software Engineering" });
            cmbGender.Location = new Point(35, 340);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(197, 23);
            cmbGender.TabIndex = 38;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "Bachelor of Computer Science", "Bachelor of Information Technology ", "Bachelor of Computer Animation", "Bachelor of Software Engineering" });
            cmbProgram.Location = new Point(35, 382);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(197, 23);
            cmbProgram.TabIndex = 39;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(35, 129);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(178, 23);
            txtMiddleName.TabIndex = 40;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(35, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(178, 23);
            txtLastName.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 42;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(35, 234);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(178, 23);
            txtAge.TabIndex = 43;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(107, 433);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 44;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 510);
            Controls.Add(btnConfirm);
            Controls.Add(txtAge);
            Controls.Add(textBox1);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(cmbStudentId);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox txtFirstName;
        private ComboBox cmbStudentId;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox textBox1;
        private TextBox txtAge;
        private Button btnConfirm;
    }
}