using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace Club_Registration
{
    public class ClubRegistrationQuery
    {
        public SqlConnection sqlConnect;
        public SqlCommand sqlCommand;
        public SqlDataAdapter sqlAdapter;
        public SqlDataReader sqlReader;
        public string connectionString;
        public DataTable dataTable;
        public BindingSource bindingSource;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\BRUH\source\repos\Club Registration\Club Registration\ClubDB.mdf"";Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }
        public DataTable GetStudentDetails(long studentId)
        {
            DataTable studentDetails = new DataTable();
            string query = "SELECT * FROM ClubMembers WHERE StudentId = @StudentId";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnect))
            {
                cmd.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = studentId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(studentDetails);
            }

            return studentDetails;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
    
       
        // Method to update student details in the database
        public bool UpdateStudent(long studentId, string firstName, string middleName, string lastName, int age, string gender, string program)
        {
            string query = @"UPDATE ClubMembers 
                         SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, 
                             Age = @Age, Gender = @Gender, Program = @Program 
                         WHERE StudentId = @StudentId";

            using (SqlCommand cmd = new SqlCommand(query, sqlConnect))
            {
                cmd.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = studentId;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = firstName;
                cmd.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = middleName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = age;
                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
                cmd.Parameters.Add("@Program", SqlDbType.VarChar).Value = program;

                sqlConnect.Open();
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
            }

            return true;
        }
    }
}