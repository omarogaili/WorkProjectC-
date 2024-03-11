
using DiaryDashBord;
using DiaryDataBase;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using AppContext = DiaryDataBase.AppContext;

namespace SignInFormDiary
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DiaryApp";
            SaveTheInfo saving= new SaveTheInfo();
            Customer customer = new Customer();
            Password password = new Password();
            if (customer.IsvalidName(user_name_in.Text) && password.IsvalidPassWord(password_in.Text)&& 
                !saving.CheckingUserName(user_name_in.Text,connectionString))
            {
                SaveTheInfo saveinfo = new SaveTheInfo();
                saveinfo.SignUp(user_name_in.Text, password_in.Text);
                this.Hide();
                Dashbord dashbord = new Dashbord();
                dashbord.ShowDialog();
                this.Close();
            }
            else
            {
                if(!customer.IsvalidName(user_name_in.Text))
                {
                    errorProvider1.SetError(user_name_in, "Fel Anv�ndare namn! Namet ska inte inneh�lla ! % & 3. anv�nd dig av " +
                        "Bokst�ver f�rsta bokstavet Stort");


                }
                //else if(password.IsvalidPassWord(password_in.Text))
                //{
                //    errorProvider1.SetError(password_in, "Fel L�senord! L�senordet ska vara minst 8 tecken. F�rsta bokstav �r Stort");
                //}
                else if(saving.CheckingUserName(user_name_in.Text, connectionString))
                {
                    errorProvider1.SetError(user_name_in, "Anv�ndare namnet �r anv�nt! v�lje n�got annat");

                }
                //errorProvider1 = new ErrorProvider();
                //Error_name.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // L�gg till din logik h�r f�r att hantera text�ndringar i textBox1
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
             string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DiaryApp";
            SaveTheInfo saveinfo = new SaveTheInfo();
            if(saveinfo.Login(user_name_in.Text, password_in.Text, connectionString)) 
            { 
            saveinfo.Login(user_name_in.Text, password_in.Text, connectionString);
            this.Hide();
            Dashbord dashbord = new Dashbord();
            dashbord.textBox1.Text = user_name_in.Text;
            dashbord.ShowDialog();
            this.Close();
            }
            else
            {
                errorProvider1.SetError(user_name_in, "Anv�ndaren kan inte Hittas! Skapa ett konto");
                user_name_in.Text = "";
                password_in.Text = "";
            }
        }
    }
}
