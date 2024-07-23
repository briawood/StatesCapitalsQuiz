using System.Data;
using System.Data.SqlClient;
using static StatesCapitalsQuiz.Program;

namespace StatesCapitalsQuiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        int loginAttempts = 0;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;
            //Connection String
            string cs = @"Data Source=DESKTOP-5JT7K0O\SQLEXPRESS;Initial Catalog=ProgrammerTest;Integrated Security=True;Encrypt=False;";

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                //Connect to database and check if user exists
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT * FROM \"User\" WHERE UserName=@username and Password=@password",conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", user_password);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show quiz form
                if (count == 1)
                {
                    //save UserId to session
                    LoginInfo.UserID = ds.Tables[0].Rows[0]["UserId"].ToString();

                    //Load quiz
                    QuizForm quizForm = new QuizForm();
                    quizForm.Show();
                    this.Hide();
                }
                else
                {
                    if (loginAttempts > 1)
                    {
                        MessageBox.Show("You have attempted to login too many times. Quiz will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); var timer = new System.Windows.Forms.Timer();
                        timer.Tick += new EventHandler(CloseTimer_Tick);
                        timer.Interval = 1000;
                        timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();

                        txt_username.Focus();
                    }
                    loginAttempts++;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you ready to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}