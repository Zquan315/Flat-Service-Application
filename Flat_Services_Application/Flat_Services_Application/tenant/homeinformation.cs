using Flat_Services_Application.connectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Services_Application.tenant
{
    public partial class homeinformation : Form
    {
        public homeinformation()
        {
            InitializeComponent();
        }

        Modify modify;
        roomate roomMate;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void homeinformation_Load(object sender, EventArgs e)
        {
            this.infoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)41))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.infoBtn.ForeColor = Color.White;

            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllRoomate();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homenavigation homenavigation = new homenavigation();
            homenavigation.StartPosition = FormStartPosition.CenterScreen;
            homenavigation.Show();
        }

        private void costsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homecostsing homecostsing = new homecostsing();
            homecostsing.StartPosition = FormStartPosition.CenterScreen;
            homecostsing.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeinformation homeinformation = new homeinformation();
            homeinformation.StartPosition = FormStartPosition.CenterScreen;
            homeinformation.Show();
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeservices homeservices = new homeservices(); 
            homeservices.StartPosition = FormStartPosition.CenterScreen;
            homeservices.Show();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homechating homechating = new homechating();    
            homechating.StartPosition = FormStartPosition.CenterScreen;
            homechating.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            differencesfee differencesfee = new differencesfee();
            differencesfee.StartPosition = FormStartPosition.CenterScreen;
            differencesfee.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeinformation homeinformation1 = new homeinformation();
            homeinformation1.StartPosition = FormStartPosition.CenterScreen;
            homeinformation1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idRoomate = this.textBox3.Text; //textBox3 la txbIDNumberRoomate
            string name = this.txbName.Text;
            string sex = (rbMale.Checked ? rbMale.Text : rbFemale.Text);
            DateTime dateOfBirth = this.datetime.Value;
            string idVehical = this.txbVehical.Text;
            string addRess = this.txbAddress.Text;
            string phoneNum = this.txbPhoneNumber.Text;
            string idTenant = this.txbIDNumberTenant.Text;
            roomMate = new roomate(idRoomate, name, sex, dateOfBirth, idVehical, addRess, phoneNum, idTenant);
            if(modify.insert(roomMate))
            {
                dataGridView1.DataSource = modify.getAllRoomate();
            }
            else
            {
                MessageBox.Show("Error: " + "Can not insert data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
