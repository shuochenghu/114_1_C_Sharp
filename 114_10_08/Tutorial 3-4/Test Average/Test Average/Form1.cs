using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算平均」按鈕時執行此事件處理函式
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告三個變數來儲存三個測驗分數
            double test1, test2, test3;

            try
            {
                // 嘗試將使用者輸入的文字轉換為數字
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三個分數的平均值
                double average = (test1 + test2 + test3) / 3.0;

                // 將平均分數格式化為兩位小數並顯示在 averageLabel 上
                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                // 如果轉換失敗，顯示錯誤訊息
                MessageBox.Show(ex.Message, "例外發生！");
                // 清空三個分數輸入框與平均分數顯示欄位
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                // 將游標焦點設回第一個輸入框
                test1TextBox.Focus();
            }
        }

        // 當使用者點擊「清除」按鈕時執行此事件處理函式
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空三個分數輸入框與平均分數顯示欄位
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            // 將游標焦點設回第一個輸入框
            test1TextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時執行此事件處理函式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // test3TextBox 內容變更時的事件處理函式（目前未使用）
        private void test3TextBox_TextChanged(object sender, EventArgs e)
        {
            // 此處可加入需要在 test3TextBox 內容變更時執行的程式碼
        }

        // test1PromptLabel 被點擊時的事件處理函式（目前未使用）
        private void test1PromptLabel_Click(object sender, EventArgs e)
        {
            // 此處可加入需要在 test1PromptLabel 被點擊時執行的程式碼
        }
    }
}
