using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Airline_registration
{
    public partial class ViewPassengers : Form
    {
        public ViewPassengers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\avije\OneDrive\Documents\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from PassengerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassengers addpas = new AddPassengers();
            addpas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "")
            {
                MessageBox.Show("Enter the Passenger Details to delete");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Passengertable where PassId="+PidTb.Text+"";
                    SqlCommand cmd = new SqlCommand(query,Con); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Details Deleted Successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PpassTb.Text = "";
            PaddTb.Text = "";
            NatCb.SelectedItem = "";
            GendCb.SelectedItem = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PidTb.Text == "" || PnameTb.Text == "" || PpassTb.Text == "" || PaddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengerTable set PassName= '"+PnameTb.Text+"',Passport='"+PpassTb.Text+"',PassAd='"+PaddTb.Text+"',PassNat='"+NatCb.SelectedItem.ToString()+"',PassGend='"+GendCb.SelectedItem.ToString()+"',PassPhone='"+PphoneTb.Text+"' where PassId="+PidTb.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Psssenger Details Updated Successfully.");
                    Con.Close();
                    populate();
                }catch
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }

        private void PassengerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PassengerDGV.Rows[e.RowIndex];
                PidTb.Text = row.Cells[0].Value.ToString();
                PnameTb.Text =          row.Cells[1].Value.ToString();
                PpassTb.Text =          row.Cells[2].Value.ToString();
                PaddTb.Text =           row.Cells[3].Value.ToString();
                NatCb.SelectedItem =    row.Cells[4].Value.ToString();
                GendCb.SelectedItem =   row.Cells[5].Value.ToString();
                PphoneTb.Text =         row.Cells[6].Value.ToString();

            }
        }
    }
}
