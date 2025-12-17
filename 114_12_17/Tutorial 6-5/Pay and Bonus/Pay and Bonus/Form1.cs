using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    /// <summary>
    /// 主表單類別：薪資與獎金計算器
    /// 此表單用於計算員工的退休金提撥金額
    /// </summary>
    public partial class Form1 : Form
    {
        // 常數欄位：退休金提撥比率 (5%)
        // 此比率用於計算員工退休金帳戶的提撥金額
        private const decimal CONTRIB_RATE = 0.05m;

        /// <summary>
        /// 表單建構子：初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid 方法：驗證並轉換使用者輸入
        // 此方法將使用者輸入的文字轉換為數值，並透過參考參數傳遞儲存
        // 如果轉換成功，方法回傳 true；否則回傳 false
        

        /// <summary>
        /// 計算按鈕點擊事件處理程序
        /// 當使用者點擊「計算提撥」按鈕時執行
        /// 功能：計算並顯示退休金提撥金額
        /// </summary>
        /// <param name="sender">事件發送者</param>
        /// <param name="e">事件參數</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告變數以儲存總薪資、獎金及提撥金額
            decimal grossPay = 0.0m;
            decimal bonus = 0.0m;
            decimal contribution;
            // 驗證並轉換使用者輸入的總薪資與獎金
            if (InputIsValid(ref grossPay, ref bonus))
            {
                // 計算退休金提撥金額
                contribution = CONTRIB_RATE * (grossPay + bonus);
                // 顯示計算結果，格式化為貨幣形式
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                // 顯示錯誤訊息，提示使用者輸入有效的數值
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤");
            }
        }

        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool inputIsValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))              
            {
               if (decimal.TryParse(bonusTextBox.Text, out bonus))
               {
                   inputIsValid = true;
                }
               else
               {
                   MessageBox.Show("獎金金額輸入無效，請輸入數字。", "輸入錯誤");
                    //inputIsValid = false;
                }
            }
            else
            {
                MessageBox.Show("總薪資金額輸入無效，請輸入數字。", "輸入錯誤");
                //inputIsValid = false;
            }
            return inputIsValid;
        }

        /// <summary>
        /// 離開按鈕點擊事件處理程序
        /// 當使用者點擊「離開」按鈕時執行
        /// 功能：關閉應用程式視窗
        /// </summary>
        /// <param name="sender">事件發送者</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束應用程式
            this.Close();
        }
    }
}
