using System;
using System.Data;
using System.Data.SqlClient;

namespace StatesCapitalsQuiz
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Connect to database and get scores to display
                string cs = @"Data Source=DESKTOP-5JT7K0O\SQLEXPRESS;Initial Catalog=ProgrammerTest;Integrated Security=True;Encrypt=False;";
                SqlConnection conn = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT Top 1 TotalQuestions, NumberCorrect FROM TestResult WHERE UserId = @userid ORDER BY TestResultId DESC", conn);
                cmd.Parameters.AddWithValue("@userid", Program.LoginInfo.UserID);
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    txtNumCorrect.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    txtTotalQuestions.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnNewQuiz_Click(object sender, EventArgs e)
        {
            //reload quiz
            QuizForm quizForm = new QuizForm();
            quizForm.Show();
            this.Hide();
        }
    }
}
