using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Collections.Specialized;
namespace Registration_Form
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string destinationaddr = "91" + TextBox2.Text;
            string message = "Hi " + TextBox1.Text+ " , Your entry was Registered to the Guneet Database. Thanks!!";

            String message1 = HttpUtility.UrlEncode(message);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
                {
                {"apikey" , "Ym0npAw0Zuo-CG4pFBjKc4c5ES96sVTXz7uPiWy82s"},    
                {"numbers" , destinationaddr},
                {"message" , message1},
                {"sender" , "TXTLCL"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                savedata();
                Label3.Text = "You Have Successfully Registered";
            }
        }

       public void savedata()
        {
            String query = "insert into NewRegistration(uName,gender,contact,email,city) values('" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            String mycon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NewRegistration;Integrated Security=True;";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label3.Text = "Record Saved Successfully";
           sendusermail(TextBox1.Text,DropDownList1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text );
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }


        private void sendusermail(String name1, String gender, String contact, String email, String city)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("guneetsinghbali@gmail.com", "fighterman");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "New User Registration Details";
            msg.Body = "New Registration Details \n\n-------------------\n\nName : " + name1 + "\n\nEmail Address :" + gender + "\n\nMobile Number:" + contact + "\n\nState:" + email + "\n\nCountry:" + city;
            string toaddress = "guneetsinghbali@gmail.com";
            msg.To.Add(toaddress);
            string fromaddress = "New Registration <guneetsinghbali@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);


            }
            catch
            {
                throw;
            }
            Label3.Text = "User Has Been Registered Successfully";
        }
    }
}