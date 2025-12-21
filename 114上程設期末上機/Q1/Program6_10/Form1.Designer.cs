namespace Program6_10
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
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
            this.stoneButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stoneButton
            // 
            this.stoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.stoneButton.Location = new System.Drawing.Point(38, 236);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(130, 55);
            this.stoneButton.TabIndex = 0;
            this.stoneButton.Text = "石頭";
            this.stoneButton.UseVisualStyleBackColor = true;
            this.stoneButton.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.paperButton.Location = new System.Drawing.Point(186, 236);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(130, 55);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "布";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.scissorButton.Location = new System.Drawing.Point(341, 236);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(130, 55);
            this.scissorButton.TabIndex = 2;
            this.scissorButton.Text = "剪刀";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.resultLabel.Location = new System.Drawing.Point(101, 180);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(310, 40);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = " ";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::Program6_10.Properties.Resources.stone_player;
            this.playerPictureBox.Location = new System.Drawing.Point(298, 69);
            this.playerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(173, 83);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 7;
            this.playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Image = global::Program6_10.Properties.Resources.stone_computer;
            this.computerPictureBox.Location = new System.Drawing.Point(64, 69);
            this.computerPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(173, 83);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 5;
            this.computerPictureBox.TabStop = false;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerLabel.Location = new System.Drawing.Point(115, 32);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(82, 24);
            this.computerLabel.TabIndex = 8;
            this.computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerLabel.Location = new System.Drawing.Point(337, 32);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(82, 24);
            this.playerLabel.TabIndex = 9;
            this.playerLabel.Text = "玩家出";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.exitButton.Location = new System.Drawing.Point(151, 310);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 55);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "結束遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 393);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.stoneButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

