using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    /// <summary>
    /// 樂透號碼產生器主表單類別
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構函式：初始化表單元件
        /// </summary>
        public Form1()
        {
            // 初始化表單中的所有元件
            InitializeComponent();
        }

        /// <summary>
        /// 產生號碼按鈕的點擊事件處理程序
        /// 當使用者點擊「產生號碼」按鈕時執行
        /// </summary>
        /// <param name="sender">事件發送者物件</param>
        /// <param name="e">事件參數</param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            // 此處將實作產生樂透號碼的邏輯
            const int SIZE = 5; // 樂透號碼數量
            int[] lotteryNumbers = new int[SIZE];
            /***************************
             * 在此產生樂透號碼並顯示在對應的標籤上
             ***************************/
            Label[] labels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            
            Random rand = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                lotteryNumbers[i] = rand.Next(1, 50); // 產生1到49之間的隨機數字
            }
            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        /// <summary>
        /// 離開按鈕的點擊事件處理程序
        /// 當使用者點擊「離開」按鈕時執行
        /// </summary>
        /// <param name="sender">事件發送者物件</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式表單
            this.Close();
        }
    }
}
