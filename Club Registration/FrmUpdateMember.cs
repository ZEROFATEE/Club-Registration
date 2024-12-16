using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlTypes;

namespace Club_Registration
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();
            LoadStudentIds();
        }

        private void LoadStudentIds()
        {
            // Assuming a method that fetches all student IDs from the database
            string query = "SELECT StudentId FROM ClubMembers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, clubRegistrationQuery.sqlConnect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmbStudentId.DataSource = dt;
            cmbStudentId.DisplayMember = "StudentId";
            cmbStudentId.ValueMember = "StudentId";
        }
        public FrmUpdateMember(ClubRegistrationQuery query)
        {
            InitializeComponent();
            clubRegistrationQuery = query; // Initialize the query instance
            LoadStudentIds();
        }


        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudentId.SelectedValue is DataRowView rowView)
            {
                // Extract the actual value from DataRowView
                long studentId = Convert.ToInt64(rowView["StudentId"]);
                LoadStudentDetails(studentId);
            }
            else if (cmbStudentId.SelectedValue != null)
            {
                long studentId = Convert.ToInt64(cmbStudentId.SelectedValue);
                LoadStudentDetails(studentId);
            }
        }

        private void LoadStudentDetails(long studentId)
        {
            // Fetch current data for the selected student ID
            string query = "SELECT * FROM ClubMembers WHERE StudentId = @StudentId";
            SqlCommand cmd = new SqlCommand(query, clubRegistrationQuery.sqlConnect);
            cmd.Parameters.AddWithValue("@StudentId", studentId);

            clubRegistrationQuery.sqlConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtFirstName.Text = reader["FirstName"].ToString();
                txtMiddleName.Text = reader["MiddleName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtAge.Text = reader["Age"].ToString();
                cmbGender.SelectedItem = reader["Gender"].ToString();
                cmbProgram.SelectedItem = reader["Program"].ToString();
            }

            clubRegistrationQuery.sqlConnect.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            long studentId = Convert.ToInt64(cmbStudentId.SelectedValue);
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            int age = int.Parse(txtAge.Text);
            string gender = cmbGender.SelectedItem.ToString();
            string program = cmbProgram.SelectedItem.ToString();

         
            string updateQuery = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, " +
                                 "LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program " +
                                 "WHERE StudentId = @StudentId";

            SqlCommand cmd = new SqlCommand(updateQuery, clubRegistrationQuery.sqlConnect);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@MiddleName", middleName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Program", program);
            cmd.Parameters.AddWithValue("@StudentId", studentId);

            clubRegistrationQuery.sqlConnect.Open();
            cmd.ExecuteNonQuery();
            clubRegistrationQuery.sqlConnect.Close();

            this.Close();
        }
    }
}
