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

    public partial class Viewflight : Form
    {
        public Viewflight()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\avije\OneDrive\Documents\AirlineDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from FlightTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Viewflight_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (FcodeTb.Text == "" || Seatnum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update FlightTable set Fsrc= '" + SourceCb.SelectedItem.ToString() + "',FDest='" + DestCb.SelectedItem.ToString() + "',FDate='" + FDate.Value.Date.ToString() + "',FCap='" + Seatnum.Text + "' where Fcode='" + FcodeTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Details Updated Successfully.");
                    Con.Close();
                    populate();
                }
                catch
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            Seatnum.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter the Flight Details to delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Flighttable where Fcode='" + FcodeTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Details Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Flighttable f1 = new Flighttable();
            f1.Show();
            this.Hide();

        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.FlightDGV.Rows[e.RowIndex];
                FcodeTb.Text = row.Cells[0].Value.ToString();
                SourceCb.SelectedItem = row.Cells[1].Value.ToString();
                DestCb.SelectedItem = row.Cells[2].Value.ToString();
                Seatnum.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}


