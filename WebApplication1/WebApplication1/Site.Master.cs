using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net.Mail;


namespace WebApplication1
{

    
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NavigationMenu_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {   
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            {
                string[] validFileTypes = { "pdf", "doc"};
                string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
                bool isValidFile = false;
                for (int i = 0; i < validFileTypes.Length; i++)
                {
                    if (ext == "." + validFileTypes[i])
                    {
                        isValidFile = true;
                        break;
                    }
                }
                if (!isValidFile)
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Invalid File. Please upload a File with extension " +
                                   string.Join(",", validFileTypes);
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Label1.Text = "File uploaded successfully.";
                }
            }
        }

        protected void Button2_Click2(object sender, EventArgs e)
        {

        }

        protected void Button2_Click3(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click4(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("best@technosys.com");
            mail.To.Add("pree011235@gmail.com,pree011235@gmail.com");
            mail.Subject = "Accept Request";
            mail.Body = "aaaaa";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Credentials = new System.Net.NetworkCredential("pree011235@gmail.com", "iitmadras1");
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Send(mail);
        }
        }
    }

