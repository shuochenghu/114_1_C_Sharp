using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHighest_Click(object sender, EventArgs e)
        {
            string surname = textBoxSurname.Text;
            string givenName = textBoxGiven.Text;
            int quzi1 = 0, quiz2 = 0, quiz3 = 0;
            if (int.TryParse(textBoxExam1.Text, out quzi1) &&
                int.TryParse(textBoxExam2.Text, out quiz2) &&
                int.TryParse(textBoxExam3.Text, out quiz3))
            {
                showResult(surname, givenName, quzi1,  quiz2, quiz3); 
            }
            else
            {
                MessageBox.Show("成績一律輸入整數", "資料錯誤");
                clearTextBoxes();
            }
            //MessageBox.Show(string.Format("小考2 = {0}", quiz2));
        }

        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore = 0;

            findHighestScore(quiz1, quiz2, quiz3, ref highestScore);          

            lblResult.Text = string.Format("{0}{1}的最高成績是 {2} 分", givenName, surname, highestScore);

            //MessageBox.Show(string.Format("Quiz2 = {0}", quiz2));
        }

        private void findHighestScore(int quiz1, int quiz2, int quiz3, ref int highestScore)
        {
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }
        }

        private void clearTextBoxes()
        {
            textBoxExam1.Clear();
            textBoxExam2.Clear();
            textBoxExam3.Clear();
            textBoxExam1.Focus();
        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
