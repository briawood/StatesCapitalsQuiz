namespace StatesCapitalsQuiz
{
    partial class ScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumCorrect = new TextBox();
            label2 = new Label();
            txtTotalQuestions = new TextBox();
            BtnNewQuiz = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Size = new Size(561, 54);
            label1.TabIndex = 0;
            label1.Text = "Congratulations. You scored:";
            // 
            // txtNumCorrect
            // 
            txtNumCorrect.Location = new Point(43, 178);
            txtNumCorrect.Name = "txtNumCorrect";
            txtNumCorrect.ReadOnly = true;
            txtNumCorrect.Size = new Size(150, 31);
            txtNumCorrect.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 158);
            label2.Name = "label2";
            label2.Size = new Size(136, 54);
            label2.TabIndex = 2;
            label2.Text = "out of";
            // 
            // txtTotalQuestions
            // 
            txtTotalQuestions.Location = new Point(426, 178);
            txtTotalQuestions.Name = "txtTotalQuestions";
            txtTotalQuestions.ReadOnly = true;
            txtTotalQuestions.Size = new Size(150, 31);
            txtTotalQuestions.TabIndex = 3;
            // 
            // BtnNewQuiz
            // 
            BtnNewQuiz.Location = new Point(245, 293);
            BtnNewQuiz.Name = "BtnNewQuiz";
            BtnNewQuiz.Size = new Size(112, 34);
            BtnNewQuiz.TabIndex = 4;
            BtnNewQuiz.Text = "New Quiz";
            BtnNewQuiz.UseVisualStyleBackColor = true;
            BtnNewQuiz.Click += BtnNewQuiz_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 408);
            Controls.Add(BtnNewQuiz);
            Controls.Add(txtTotalQuestions);
            Controls.Add(label2);
            Controls.Add(txtNumCorrect);
            Controls.Add(label1);
            Name = "ScoreForm";
            Text = "Results";
            Load += ScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumCorrect;
        private Label label2;
        private TextBox txtTotalQuestions;
        private Button BtnNewQuiz;
    }
}