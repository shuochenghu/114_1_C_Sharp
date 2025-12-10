using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    /// <summary>
    /// 主要表單類別，用於顯示撲克牌應用程式
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構函式，初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 當使用者點擊「顯示卡片」按鈕時觸發此事件處理程序
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件引數</param>
        private void showCardButton_Click(object sender, EventArgs e)
        {
           if (cardListBox.SelectedIndex != -1)
           {
                showSelectedCard(cardListBox.SelectedItem.ToString());
           }
           else
           {
                MessageBox.Show("請先選擇一張卡片！");
           }
        }

        private  void showSelectedCard(string cardName)
        {
            switch (cardName)
            {
                case "黑桃A":
                    // 在此處添加顯示黑桃A的邏輯
                    showAceSpades();
                    break;
                case "紅心10":
                    // 在此處添加顯示紅心10的邏輯
                    showTenHearts();
                    break;
                case "梅花K":
                    // 在此處添加顯示梅花K的邏輯
                    showKingClubs();
                    break;
                default:
                    MessageBox.Show("未知的卡片選擇！");
                    break;
            }
        }


        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
        /// <summary>
        /// 當使用者點擊「離開」按鈕時觸發此事件處理程序
        /// 此方法會關閉應用程式表單
        /// </summary>
        /// <param name="sender">事件來源物件</param>
        /// <param name="e">事件引數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
