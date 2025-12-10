using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    // Form1 類別：負責處理視窗表單行為，包含燈泡狀態的切換與關閉表單功能。
    // 實作說明：
    // - 使用兩個 PictureBox (lightOnPictureBox, lightOffPictureBox) 分別顯示開燈與關燈的影像，
    //   透過 Visible 屬性來控制哪一個影像可見，藉此達成燈的開/關切換。
    // - 另外透過 lightStateLabel 顯示目前狀態 ("ON" / "OFF")。
    // - 這些註解為繁體中文詳細說明，原有英文註解已保留不變。
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // switchButton_Click：切換燈的事件處理器
        // 詳細說明：
        // 當使用者按下切換按鈕時，檢查目前表示「開燈」影像的 PictureBox (lightOnPictureBox) 的 Visible 屬性。
        // - 若為 true，代表目前燈是開啟狀態，則呼叫 turnLightOff() 將燈關閉（隱藏開燈影像並顯示關燈影像）。
        // - 若為 false，代表目前燈是關閉狀態，則呼叫 turnLightOn() 將燈開啟。
        // 使用 Visible 屬性而非直接比較 Image 的原因：
        // - Image 物件不宜直接用相等比較來判斷狀態（物件參考可能不同），透過 Visible 狀態可以更明確表達目前 UI 的呈現。
        private void switchButton_Click(object sender, EventArgs e)
        {
           if (lightOnPictureBox.Visible == true) // Light is currently ON
            {
                turnLightOff();
            }
            else // Light is currently OFF
            {
                turnLightOn();
            }
        }

        // turnLightOn：將燈打開
        // 詳細說明：
        // - 將表示「開燈」的 PictureBox 設為 Visible = true，使其顯示。
        // - 將表示「關燈」的 PictureBox 設為 Visible = false，使其隱藏。
        // - 更新狀態標籤為 "ON" 以反映使用者介面的目前狀態。
        private void turnLightOn()
        {
            // Turn on the light.
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }

        // turnLightOff：將燈關閉
        // 詳細說明：
        // - 將表示「開燈」的 PictureBox 設為 Visible = false，使其隱藏。
        // - 將表示「關燈」的 PictureBox 設為 Visible = true，使其顯示。
        // - 更新狀態標籤為 "OFF" 以反映使用者介面的目前狀態。
        private void turnLightOff()
        {
            // Turn off the light.
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }

        // exitButton_Click：關閉表單的事件處理器
        // 詳細說明：
        // - 當使用者按下離開或關閉按鈕時，呼叫 this.Close() 關閉目前表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
