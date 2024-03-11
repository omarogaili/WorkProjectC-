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
        private string LoadData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DiaryApp";
            SaveTheInfo save = new SaveTheInfo();
            string userName = save.GetUserName(textBox1.Text, connectionString);
            textBox1.Text = userName;
            return userName;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_btn_Comment_Click(object sender, EventArgs e)
        {
            LoadData();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DiaryApp";

            Comment comment = new Comment();
            SaveTheInfo saveComment= new SaveTheInfo();
            Customer customer = new Customer();
            if(comment.IsContentAComment(Comment_Box.Text))
            {
                int id = customer.Id;
                DateTime selectTime= dateTimePicker1.Value;
                saveComment.SaveTheComment(title_box.Text, Comment_Box.Text, selectTime, LoadData(), connectionString);
                Comment_Box.Text = "";
            }
        }
    }
}
