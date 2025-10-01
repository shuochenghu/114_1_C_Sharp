using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_1
{
    // Form1 類別，繼承自 Windows Forms 的 Form 類別
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的控制項
        }

        // 當使用者點擊 showDateButton 時觸發的事件處理方法
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的星期幾
            string dayOfWeek = dayOfWeekTextBox.Text;
            // 取得使用者輸入的月份
            string month = monthTextBox.Text;
            // 取得使用者輸入的年份
            string year = yearTextBox.Text;
            // 取得使用者輸入的日期
            string dayOfMonth = dayOfMonthTextBox.Text;
            
            // 組合成指定格式的日期字串
            string output = "中華民國 " + year + " 年 " + month + " 月 " + dayOfMonth + " 日 " + ", 星期 " + dayOfWeek;

            // 將結果顯示在 dateOutputLabel 控制項上
            dateOutputLabel.Text = output;
        }

        // 當使用者點擊 exitButton 時觸發的事件處理方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉目前的表單
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            dateOutputLabel.Text = "";
        }
    }
}
