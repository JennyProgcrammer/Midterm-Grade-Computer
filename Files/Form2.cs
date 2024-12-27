using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marinay___Lab_Activity_1F
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form previousForm = new Form1();
            previousForm.Show();
            this.Hide();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            try
            {
                //Quizzes

                double quiz1 = Convert.ToDouble(textBoxQuiz1.Text);
                double quiz2 = Convert.ToDouble(textBoxQuiz2.Text);

                double ans1, ansQ, ans2, ansL, ansMidExam, ansTotal;

                ans1 = quiz1 + quiz2;
                ansQ = ans1 / 80 * 0.25 * 100;

                textBoxQuizTotal.Text = ansQ.ToString("#.##");

                //Laboratory Activities

                double lab1 = Convert.ToDouble(textBoxLA1.Text);
                double lab2 = Convert.ToDouble(textBoxLA2.Text);
                double lab3 = Convert.ToDouble(textBoxLA3.Text);


                ans2 = lab1 + lab2 + lab3;
                ansL = ans2 / 300 * 0.25 * 100;

                textBoxLabActTotal.Text = ansL.ToString("#.##");

                // Midterm Exam

                double midtermExam = Convert.ToDouble(textBoxMidtermExam.Text);

                ansMidExam = midtermExam / 40 * 0.30 * 100;

                textBoxMidtermExamTotal.Text = ansMidExam.ToString("#.##");

                //Assignments 


                double ansA, assignTotal; 

                double assign1 = Convert.ToDouble(textBoxAssign1.Text);
                double assign2 = Convert.ToDouble(textBoxAssign2.Text);



                ansA = assign1 + assign2;
                assignTotal = ansA / 200 * 0.20 * 100;

                textBoxMidtermAssign.Text = assignTotal.ToString("#.##"); 
           
                // Midterm Grade 

                ansTotal = ansQ + ansL + assignTotal + ansMidExam;

                textBoxMidtermGrade.Text = ansTotal.ToString("#.##");

                if (ansTotal >= 70)
                {
                    labelMessage.Text = ("Passed!");
                }
                else
                {
                    labelMessage.Text = ("Failed!");
                }
            }
            catch
            {
                MessageBox.Show("Please fill-out all required fields!");  
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxQuiz1.Clear();
            textBoxQuiz2.Clear();
            textBoxLA1.Clear();
            textBoxLA2.Clear();
            textBoxLA3.Clear();
            textBoxMidtermExam.Clear();
            textBoxLabActTotal.Clear();
            textBoxQuizTotal.Clear();
            textBoxMidtermExamTotal.Clear();
            textBoxMidtermGrade.Clear();
            textBoxAssign1.Clear();
            textBoxAssign2.Clear();
            textBoxMidtermAssign.Clear(); 

        }
    }
}
