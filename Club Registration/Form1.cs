using System.Windows.Forms;

namespace Club_Registration
{
    public partial class Form1 : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count = 0;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public Form1()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }
        private int RegistrationID()
        {
            return ++count;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID();
            StudentId = long.Parse(txtStudID.Text);
            FirstName = txtFirstName.Text;
            MiddleName = txtMiddleName.Text;
            LastName = txtLastName.Text;
            Age = int.Parse(txtAge.Text);
            Gender = txtGender.Text;
            Program = txtProgram.Text;

            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RefreshListOfClubMembers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateForm = new FrmUpdateMember(clubRegistrationQuery);
            updateForm.ShowDialog();
            RefreshListOfClubMembers();
        }
    }
}
