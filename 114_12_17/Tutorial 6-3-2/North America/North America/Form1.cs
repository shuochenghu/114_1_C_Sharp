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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetFileName 方法從使用者取得檔案名稱
        // 並將它指派給作為參數傳遞的變數。

        // GetCountries 方法接受一個檔案名稱作為參數。
        // 它會開啟指定的檔案，並在 countriesListBox 控制項中
        // 顯示其內容。
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName;
            // 取得檔案名稱。
            fileName = GetFileName();
            // 顯示國家清單。
            GetCountries(fileName);
        }

        private string GetFileName()
        {            
            string fileName;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 取得檔案名稱。
                fileName = openFile.FileName;
            }
            else
            {
                // 使用者未選取檔案，將檔案名稱設為空字串。
                fileName = string.Empty;
            }
            return fileName;
        }

        private void GetCountries(string fileName)
        {
            string country;
            // 清除清單方塊中的任何現有項目。
            countriesListBox.Items.Clear();
            // 確定使用者已選取檔案。
            if (fileName != string.Empty)
            {
                // 開啟檔案並讀取其內容。
                StreamReader inputFile = File.OpenText(fileName);
                // 讀取檔案的每一行，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    // 讀取國家名稱。
                    country = inputFile.ReadLine();
                    // 將國家名稱加入清單方塊。
                    countriesListBox.Items.Add(country);
                }
                // 關閉檔案。
                inputFile.Close();
            }
            else
            {
                // 顯示錯誤訊息。
                MessageBox.Show("未選取任何檔案。", "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

    }
}
