using SignInFormDiary;

namespace DiaryAppForms
{
    public partial class Diary_IEN : Form
    {
        public Diary_IEN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
            this.Close();
            
        }
    }
}
