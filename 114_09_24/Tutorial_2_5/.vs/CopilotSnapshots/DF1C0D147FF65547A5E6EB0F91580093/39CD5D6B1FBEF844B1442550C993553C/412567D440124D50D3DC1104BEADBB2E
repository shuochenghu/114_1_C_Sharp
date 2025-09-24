using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_5
{
    // Form1 是主視窗表單類別
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化元件（由 Designer 產生）
        }

        // 當表單載入時觸發的事件處理函式
        private void Form1_Load(object sender, EventArgs e)
        {
            // 隱藏卡片背面與正面的圖片元件
            cardBackPictureBox.Visible = false; // cardBackPictureBox：卡片背面圖片
            cardFacePictureBox.Visible = false; // cardFacePictureBox：卡片正面圖片
        }

        // 按下顯示背面按鈕時觸發的事件處理函式
        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = true;  // 顯示卡片背面
            cardFacePictureBox.Visible = false; // 隱藏卡片正面
        }

        // 按下顯示正面按鈕時觸發的事件處理函式
        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = false; // 隱藏卡片背面
            cardFacePictureBox.Visible = true;  // 顯示卡片正面
        }
    }
}
