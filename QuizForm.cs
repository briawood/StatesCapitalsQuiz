using System.Data;
using System.Data.SqlClient;

namespace StatesCapitalsQuiz
{
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }

        private List<string> correctAnswers = new List<string>();
        //Connection String
        string cs = @"Data Source=DESKTOP-5JT7K0O\SQLEXPRESS;Initial Catalog=ProgrammerTest;Integrated Security=True;Encrypt=False;";

        private void QuizForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Connect to database and get random states to display
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT TOP 10 State, Capital FROM \"State\" ORDER BY NEWID()", conn);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                int index = 0;
                foreach (var textBox in this.Controls.OfType<TextBox>())
                {
                    if (textBox.Name.StartsWith("state"))
                    {
                        textBox.Text = ds.Tables[0].Rows[index]["State"].ToString();
                        correctAnswers.Add(ds.Tables[0].Rows[index]["Capital"].ToString());
                        index++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //grade answers
            int numAnswered = 0;
            int correctScore = 0;
            int index = 0;
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Name.StartsWith("capital"))
                {
                    if (textBox.Text != "")
                    {
                        if (correctAnswers[index] == textBox.Text)
                        {
                            correctScore++;
                        }
                        index++;
                        numAnswered++;
                    }
                }
            }

            //Load results
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.Show();
            this.Hide();

            try
            {
                //Connect to database and save quiz results
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO TestResult (UserId, TestDateTime, TotalQuestions, NumberCorrect) VALUES (@userid, @testDateTime, @totalQuestions, @numberCorrect)", conn);
                cmd.Parameters.AddWithValue("@userid", Program.LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@testDateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@totalQuestions", numAnswered);
                cmd.Parameters.AddWithValue("@numberCorrect", correctScore);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}