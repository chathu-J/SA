using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.BL;
using WindowsFormsApplication.PL;

namespace WindowsFormsApplication
{
    public partial class UserForm : MetroForm
    {
        public UserForm()
        {
            InitializeComponent();
        }

        //load all users
        private void UserForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.testDataSet.Users);
            this.buttonEdit.Enabled = false;
            this.buttonDelete.Enabled = false;

            try
            {
                StudentBL s = new StudentBL();
                metroGridUsers.DataSource = s.GetUsers();


            }
            catch
            {
                MessageBox.Show("Error Occurred while retrieving");
            }
        }

        //get specific user
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                StudentBL s = new StudentBL();
                if (s.GetUser(Convert.ToInt32(this.textBoxGetUser.Text)).Rows.Count > 0)
                {
                    this.metroGridUsers.DataSource = s.GetUser(Convert.ToInt32(this.textBoxGetUser.Text));
                }

                else
                {
                    MessageBox.Show("No user found");
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred while retrieving search results");
            }
        }

        //create user
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                StudentBL s = new StudentBL();
                s.Name = this.textBoxName.Text;
                s.Surname = this.textBoxSurname.Text;
                s.Age = Convert.ToInt32(this.textBoxAge.Text);
                s.Address = this.textBoxAddress.Text;
                s.Username = this.textBoxUsername.Text;
                s.Password = this.textBoxPassword.Text;

                if (s.CreateUser(s))
                {
                    this.metroGridUsers.DataSource = s.GetUsers();
                    MessageBox.Show("Inserted successfully");
                }
                else {
                    MessageBox.Show("Insertion failed");
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred while inserting");
            }
        }

        
        //load details of user in textboxes
        private void metroGridUsers_MouseClick_1(object sender, MouseEventArgs e)
        {

            if (metroGridUsers.Rows.Count > 0)
            {
                this.buttonEdit.Enabled = true;
                this.buttonDelete.Enabled = true;

                DataGridViewRow dr = metroGridUsers.SelectedRows[0];

                labelID.Text = dr.Cells[0].Value.ToString();
                textBoxName.Text = dr.Cells[1].Value.ToString();
                textBoxSurname.Text = dr.Cells[2].Value.ToString();
                textBoxAge.Text = dr.Cells[4].Value.ToString();
                textBoxAddress.Text = dr.Cells[5].Value.ToString();
                textBoxUsername.Text = dr.Cells[6].Value.ToString();
                textBoxPassword.Text = dr.Cells[6].Value.ToString();
                textBoxConfirmPassword.Text = dr.Cells[6].Value.ToString();

                this.buttonCreate.Enabled = false;
            }
        }

        //update user
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                StudentBL s = new StudentBL();
                s.Id = Convert.ToInt32(this.labelID.Text);
                s.Name = this.textBoxName.Text;
                s.Surname = this.textBoxSurname.Text;
                s.Age = Convert.ToInt32(this.textBoxAge.Text);
                s.Address = this.textBoxAddress.Text;
                s.Username = this.textBoxUsername.Text;
                s.Password = this.textBoxPassword.Text;

                if (s.UpdateUser(s))
                {
                    this.metroGridUsers.DataSource = s.GetUsers();
                    MessageBox.Show("Updated successfully");
                }
                else
                {
                    MessageBox.Show("Updation failed");
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred while updating");
            }
        }

        //delete user
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentBL s = new StudentBL();
                s.Id = Convert.ToInt32(this.labelID.Text);

                if (s.DeleteUser(s.Id))
                {
                    labelID.Text = null;
                    textBoxName.Text = "";
                    textBoxSurname.Text = "";
                    textBoxAge.Text = "";
                    textBoxAddress.Text = "";
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    this.buttonCreate.Enabled = true;
                    this.buttonEdit.Enabled = false;
                    this.buttonDelete.Enabled = false;
                    this.metroGridUsers.DataSource = s.GetUsers();
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Deletion failed");
                }

            }
            catch
            {
                MessageBox.Show("Error Occurred while deleting");
            }
        }


        private void textBoxGetUser_MouseClick(object sender, MouseEventArgs e)
        {
            this.metroGridUsers.DataSource = null;
            this.buttonCreate.Enabled = false;
            this.buttonEdit.Enabled = false;
            this.buttonDelete.Enabled = false;

        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            StudentBL s = new StudentBL();
            this.metroGridUsers.DataSource = s.GetUsers();

            this.buttonCreate.Enabled = true;
            this.buttonEdit.Enabled = false;
            this.buttonDelete.Enabled = false;
            
            this.textBoxGetUser.Text = "";
            labelID.Text = null;
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxAge.Text = "";
            textBoxAddress.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }


    }
}
