using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.Xml.Linq;
using System.IO;
using System.Collections.Specialized;

namespace Flat_Services_Application
{
    public partial class ForgotPass : Form
    {
       
        public ForgotPass()
        {
            InitializeComponent();
        }

        
        public ForgotPass(String s)
        {
            InitializeComponent();
            s = s.Substring(1);
            tbPhone.Text = "+84" + s;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login login = new Login();  
            login.Show();   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //neu sdt ton tai, otp gui ve may dung thi dang hap thanh cong
            if (tbOTP.Text == "" || tbPhone.Text == "")
                return;           
            //dieu kien otp
            //if(tbOTP.Text != randomNum)
            //{
            //    lb2.Text = "!";
            //    lb2.ForeColor = Color.Red;
            //    return;
            //}
            else 
            {
                lb2.Text = "";
                this.Hide();
                changePass_forgot c = new changePass_forgot(tbPhone.Text);
                c.Show();
            }
            
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                lb1.Text = "*";
                lb1.ForeColor = Color.Red;
            }
            else
                lb1.Text = "";
        }

        private void tbOTP_TextChanged(object sender, EventArgs e)
        {
            if (tbOTP.Text == "")
            {
                lb2.Text = "*";
                lb2.ForeColor = Color.Red;
            }
            else
                lb2.Text = "";
        }
        public bool IsNumberPhone(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' || (a[i] < '0' || a[i] > '9'))
                    return false;
            }
            if (a.Length < 10 || a.Length > 11)
                return false;
            return true;
        }
        string randomNum;
        private void ForgotPass_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //String result;
            //string apiKey = "NTUzMTQ2NTE2NzRmNDY1NTcyNTE2NDMyNDc0MTQxNTI=";
            //string numbers = tbPhone.Text; // in a comma seperated list
            //string message = "This is OTP code sent to " + tbPhone.Text + ": " + randomNum + ". Please don't share with anyone.";
            //string send = "quan315";
            //Random rdm = new Random();
            //randomNum = (rdm.Next(100000, 999999)).ToString();
            //String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
            ////refer to parameters to complete correct url string

            //StreamWriter myWriter = null;
            //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            //objRequest.Method = "POST";
            //objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            //objRequest.ContentType = "application/x-www-form-urlencoded";
            //try
            //{
            //    myWriter = new StreamWriter(objRequest.GetRequestStream());
            //    myWriter.Write(url);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    myWriter.Close();
            //}

            //HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            //using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            //{
            //    result = sr.ReadToEnd();
            //    // Close and clean up the StreamReader
            //    sr.Close();
            //}
            //MessageBox.Show("OTP code is sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
