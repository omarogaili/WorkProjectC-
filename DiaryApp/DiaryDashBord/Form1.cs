using DiaryDataBase;
using Microsoft.VisualBasic.ApplicationServices;

namespace DiaryDashBord
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
          
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DiaryApp";
            SaveTheInfo save = new SaveTheInfo();
            string userName = save.GetUserName(textBox1.Text, connectionString);
            textBox1.Text = userName;
        }

    }
}
