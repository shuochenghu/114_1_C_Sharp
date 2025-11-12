namespace Time_Zone
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.promptLabel.Location = new System.Drawing.Point(103, 20);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(521, 40);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "選擇一個城市，我會告訴你時區";
            // 
            // cityListBox
            // 
            this.cityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 40;
            this.cityListBox.Items.AddRange(new object[] {
            "丹佛",
            "檀香山",
            "明尼亞波利斯",
            "紐約",
            "舊金山",
            "台北"});
            this.cityListBox.Location = new System.Drawing.Point(189, 111);
            this.cityListBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(317, 204);
            this.cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(80, 380);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(125, 40);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "時區：";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timeZoneLabel.Location = new System.Drawing.Point(213, 347);
            this.timeZoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(274, 107);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.okButton.Location = new System.Drawing.Point(99, 526);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(177, 98);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "確定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(369, 526);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(197, 98);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 678);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.promptLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "時區";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;        // 提示使用者選擇城市的標籤
        private System.Windows.Forms.ListBox cityListBox;      // 顯示城市選項的列表框
        private System.Windows.Forms.Label outputDescriptionLabel;  // 顯示「時區：」文字的標籤
        private System.Windows.Forms.Label timeZoneLabel;      // 顯示選定城市時區結果的標籤
        private System.Windows.Forms.Button okButton;          // 確定按鈕，用於顯示時區資訊
        private System.Windows.Forms.Button exitButton;        // 離開按鈕，用於關閉應用程式
    }
}

