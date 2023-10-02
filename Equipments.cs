using GYMMANAGEMENT;
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
    public partial class Equipments : Form
    {
        public  Equipments()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String Description = txtDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);



            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = LAPTOP-IM5K1G91; database = Equipment ; intergrated security = True";
            con.ConnectionString = "data source = LAPTOP-IM5K1G91; database = Equipment ;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into types(EquipName,EDescription,MUsed,DDate,Cost) values('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "'," + cost + ")";
            //('"+ EquipName +"',"+cost+")

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;

        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            NewEquipment ve = new NewEquipment();
            ve.Show();
        }

        private void Equipments_Load(object sender, EventArgs e)
        {

        }
    }
}

