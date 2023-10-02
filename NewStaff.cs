using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMMANAGEMENT
{
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirsName.Text;
            String lname = txtLastName.Text;

            String gender = "";
            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJoinDate.Text;
            String state = txtState.Text;
            String city = txtCity.Text;


            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = LAPTOP-IM5K1G91; database = NewStaff intergrated security = True";
            con.ConnectionString = "data source = LAPTOP-IM5K1G91; database = NewStaff ;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Teacher (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Statee,City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + state + "','" + city +"')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data saved.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirsName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobileNo.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtEmail.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;

        }
    }
}

