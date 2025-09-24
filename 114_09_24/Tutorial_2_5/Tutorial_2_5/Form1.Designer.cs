namespace Tutorial_2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Tutorial_2_5.Properties.Resources.Backface_Red;
            this.cardBackPictureBox.Location = new System.Drawing.Point(254, 71);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(301, 428);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPictureBox.TabIndex = 1;
            this.cardBackPictureBox.TabStop = false;
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::Tutorial_2_5.Properties.Resources.Ace_Hearts;
            this.cardFacePictureBox.Location = new System.Drawing.Point(254, 71);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(301, 428);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFacePictureBox.TabIndex = 0;
            this.cardFacePictureBox.TabStop = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showBackButton.Location = new System.Drawing.Point(128, 543);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(221, 115);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showFaceButton.Location = new System.Drawing.Point(473, 543);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(221, 115);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardBackPictureBox);
            this.Controls.Add(this.cardFacePictureBox);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

