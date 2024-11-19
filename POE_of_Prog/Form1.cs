namespace POE_of_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginLecturere loginLecturere = new LoginLecturere();
            loginLecturere.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
