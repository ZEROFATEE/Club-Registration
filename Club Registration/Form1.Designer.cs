namespace Club_Registration
{
    partial class Form1
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
            label8 = new Label();
            btnRefresh = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGender = new ComboBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            txtMiddleName = new TextBox();
            txtProgram = new ComboBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtStudID = new TextBox();
            btnRegister = new Button();
            txtFirstName = new TextBox();
            btnUpdate = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 11);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 17;
            label8.Text = "List of Club Members:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(682, 29);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 12);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 34;
            label7.Text = "Student ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 12);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 33;
            label6.Text = "Program:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 72);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 32;
            label5.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 72);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 31;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 72);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 30;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 133);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 29;
            label2.Text = "Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 133);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 28;
            label1.Text = "Age:";
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(216, 151);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(115, 23);
            txtGender.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnRefresh);
            panel2.Location = new Point(18, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 207);
            panel2.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 175);
            dataGridView1.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(409, 94);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(178, 23);
            txtMiddleName.TabIndex = 26;
            // 
            // txtProgram
            // 
            txtProgram.FormattingEnabled = true;
            txtProgram.Items.AddRange(new object[] { "Bachelor of Computer Science", "Bachelor of Information Technology ", "Bachelor of Computer Animation", "Bachelor of Software Engineering" });
            txtProgram.Location = new Point(409, 30);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(197, 23);
            txtProgram.TabIndex = 24;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(19, 151);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(76, 23);
            txtAge.TabIndex = 23;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(19, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(178, 23);
            txtLastName.TabIndex = 21;
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(19, 30);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(100, 23);
            txtStudID.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(700, 31);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(216, 94);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(178, 23);
            txtFirstName.TabIndex = 25;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(700, 76);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGender);
            Controls.Add(panel2);
            Controls.Add(txtMiddleName);
            Controls.Add(txtProgram);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudID);
            Controls.Add(btnRegister);
            Controls.Add(txtFirstName);
            Controls.Add(btnUpdate);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btnRefresh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox txtGender;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtMiddleName;
        private ComboBox txtProgram;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtStudID;
        private Button btnRegister;
        private TextBox txtFirstName;
        private Button btnUpdate;
    }
}
