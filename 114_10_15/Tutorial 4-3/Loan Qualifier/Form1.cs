using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「檢查資格」按鈕時觸發的事件處理函式
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入檢查資格的邏輯
            const decimal MINIMUM_SALARY = 1200000m; // 最低年薪
            const int MINIMUM_YEARS = 2; // 最低年資

            decimal salary; // 年薪
            int yearsOnJob; // 年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text); // 將輸入年薪轉換為decimal
                yearsOnJob = int.Parse(yearsTextBox.Text); // 將輸入年資轉換為int

                // 根據年薪決定是否符合資格
                if ( salary >= MINIMUM_SALARY )
                {
                    if ( yearsOnJob >= MINIMUM_YEARS )
                    {
                        decisionLabel.Text = "符合資格";
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格：年資未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格：收入未達最低標準";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 顯示錯誤訊息
            }
        }

        // 當使用者點擊「清除」按鈕時觸發的事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與年資的輸入框，以及結果標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標焦點回到年薪輸入框
            salaryTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時觸發的事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束程式）
            this.Close();
        }
    }
}
