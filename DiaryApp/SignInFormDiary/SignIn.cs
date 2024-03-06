
using DiaryDashBord;
using DiaryDataBase;
using Microsoft.VisualBasic.ApplicationServices;
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
            SaveTheInfo saveinfo = new SaveTheInfo();
            saveinfo.SaveData(user_name_in.Text, password_in.Text);
            Dashbord dashbord = new Dashbord();
            dashbord.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lägg till din logik här för att hantera textändringar i textBox1
        }
    }
}
