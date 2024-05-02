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
using RestSharp;
using System.Net.Mail;

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
            
            tbMail.Text = s;
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
            if (tbOTP.Text == "" || tbMail.Text == "")
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
                changePass_forgot c = new changePass_forgot(tbMail.Text);
                c.Show();
            }
            
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbMail.Text == "")
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

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            
            //Random rdm = new Random();
            //randomNum = (rdm.Next(100000, 999999)).ToString();
            //string cnt = "Your OTP code is " + randomNum;
            //bool a = Send(tbMail.Text, "OTP code", cnt);
            //if (a)
            //    MessageBox.Show("Sent OTP");
            //else
            //    MessageBox.Show("Erorr");
            
        }

        //private static readonly string _from = "flatservicesapp@gmail.com"; // Email của Sender (của bạn)
        //private static readonly string _pass = "flatservice258#"; // Mật khẩu Email của Sender (của bạn)

        //public static bool Send(string sendto, string subject, string content)
        //{
        //    //sendto: Email receiver (người nhận)
        //    //subject: Tiêu đề email
        //    //content: Nội dung của email, bạn có thể viết mã HTML
        //    //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin loi
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        //        mail.From = new MailAddress(_from);
        //        mail.To.Add(sendto);
        //        mail.Subject = subject;
        //        //mail.IsBodyHtml = true;
        //        mail.Body = content;

        //        mail.Priority = MailPriority.High;

        //        SmtpServer.Port =  25;
        //        SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
        //        SmtpServer.EnableSsl = true;

        //        SmtpServer.Send(mail);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
    }
}
