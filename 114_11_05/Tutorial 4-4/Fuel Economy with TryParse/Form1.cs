using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double fuelEconomy;

            if ( double.TryParse( milesTextBox.Text, out kms) )
            {
                if ( double.TryParse( gallonsTextBox.Text, out liters) )
                {
                    // 計算每公升公里數。
                    fuelEconomy = kms / liters;
                    // 顯示結果，格式化到兩位小數。
                    mpgLabel.Text = fuelEconomy.ToString("n2") + " 公里/公升";
                }
                else
                {
                    // 若輸入無效，顯示錯誤訊息。
                    MessageBox.Show("請輸入有效的公升數值。");
                }
            }
            else
            {
                // 若輸入無效，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的公里數值。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
