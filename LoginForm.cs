using System.Data;
using System.Data.SqlClient;

namespace StatesCapitalsQuiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new(@"Data Source=DESKTOP-5JT7K0O\SQLEXPRESS;Initial Catalog=ProgrammerTest;Integrated Security=True;Encrypt=False;");

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String query = "SELECT * FROM User WHERE UserName = '"+txt_username.Text+"' AND Password = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txt_username.Text.Trim();
                    user_password = txt_password.Text.Trim();

                    //Load quiz
                    QuizForm quizForm = new QuizForm();
                    quizForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
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
    }
}