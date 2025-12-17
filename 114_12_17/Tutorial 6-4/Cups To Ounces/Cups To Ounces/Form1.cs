using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    /// <summary>
    /// 杯數轉換為液量盎司的主表單類別
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // CupsToOunces 方法接受杯數作為參數
        // 並返回相對應的液量盎司數值
        // 轉換公式：1 杯 = 8 液量盎司
     

        /// <summary>
        /// 轉換按鈕點擊事件處理器
        /// 當使用者點擊「轉換」按鈕時，將杯數轉換為液量盎司
        /// </summary>
        /// <param name="sender">事件發送者</param>
        /// <param name="e">事件參數</param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups; // 用於存儲使用者輸入的杯數
            double ounces; // 用於存儲轉換後的液量盎司數值

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // 呼叫 CupsToOunces 方法進行轉換
                ounces = CupsToOunces(cups);
                // 顯示轉換結果
                ouncesLabel.Text = ounces.ToString("F2") + " 盎司";
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字作為杯數。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CupsToOunces(double cups)
        {      
            return cups*8.0;
        }

        /// <summary>
        /// 離開按鈕點擊事件處理器
        /// 當使用者點擊「離開」按鈕時，關閉表單並結束程式
        /// </summary>
        /// <param name="sender">事件發送者</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
