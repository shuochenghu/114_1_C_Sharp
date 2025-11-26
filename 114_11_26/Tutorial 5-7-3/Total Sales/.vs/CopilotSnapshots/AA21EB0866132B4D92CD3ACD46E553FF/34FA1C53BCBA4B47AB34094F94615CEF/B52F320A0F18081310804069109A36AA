using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行                        

            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Downloads\Sales_updated_monthname.txt");  // 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容

                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    line = inputFile.ReadLine();  // 讀取一行資料
                    
                    // 分割行內容，以空白字元分隔月份和銷售額
                    string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    // 確認至少有兩個部分（月份和金額）
                    if (parts.Length >= 2)
                    {
                        string month = parts[0];  // 取得月份名稱
                        string salesValue = parts[1];  // 取得銷售額字串
                        
                        // 嘗試將銷售額轉換為數值
                        if (decimal.TryParse(salesValue, out currentSales))
                        {
                            // 將完整的資料（月份 + 銷售額）加入清單框，並格式化為貨幣格式
                            salesListBox.Items.Add(month + " " + currentSales.ToString("C"));
                            totalSales += currentSales;  // 加到總銷售額
                        }
                        else
                        {
                            MessageBox.Show("無法解析銷售額: " + line);
                            inputFile.Close();  // 關閉檔案
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤: " + line);
                        inputFile.Close();  // 關閉檔案
                        return;
                    }
                }
                inputFile.Close();  // 關閉檔案
                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
