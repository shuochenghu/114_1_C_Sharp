using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容: ";
            String drink = "";
            String sandwitch = "";

            // 飲料部分
            if (coffeeRadioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (milkTeaRadioButton.Checked)
            {
                drink = "奶茶 ";
            }
            else if (blackTeaRadioButton.Checked)
            {
                drink = "紅茶 ";
            }
            else if (juiceRadioButton.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = "";
            }

            // 三明治部分
            if (jellySanRadioButton.Checked)
            {
                sandwitch = "果醬三明治 ";
            }
            else if (hamSanRadioButton.Checked)
            {
                sandwitch = "火腿三明治 ";
            }
            else if (tunaSanRadioButton.Checked)
            {
                sandwitch = "鮪魚三明治 ";
            }
            else
            {
                sandwitch = "";
            }

            message = drink + sandwitch;
            MessageBox.Show(message, "您的點餐內容");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
