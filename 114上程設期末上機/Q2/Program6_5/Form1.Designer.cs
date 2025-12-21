namespace Program6_5
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
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.oilLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeesValueLabel = new System.Windows.Forms.Label();
            this.taxValueLabel = new System.Windows.Forms.Label();
            this.partsValueLabel = new System.Windows.Forms.Label();
            this.serviceLaborValueLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsSummaryLabel = new System.Windows.Forms.Label();
            this.serviceLaborLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeGroupBox
            // 
            this.oilLubeGroupBox.Controls.Add(this.lubeCheckBox);
            this.oilLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilLubeGroupBox.Location = new System.Drawing.Point(20, 18);
            this.oilLubeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.oilLubeGroupBox.Name = "oilLubeGroupBox";
            this.oilLubeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.oilLubeGroupBox.Size = new System.Drawing.Size(240, 100);
            this.oilLubeGroupBox.TabIndex = 0;
            this.oilLubeGroupBox.TabStop = false;
            this.oilLubeGroupBox.Text = "機油和潤滑";
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(10, 60);
            this.lubeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(177, 22);
            this.lubeCheckBox.TabIndex = 1;
            this.lubeCheckBox.Text = "潤滑保養 (NT$540)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(10, 28);
            this.oilChangeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(177, 22);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "更換機油 (NT$780)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(270, 18);
            this.flushesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.flushesGroupBox.Size = new System.Drawing.Size(260, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "清洗服務";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(10, 60);
            this.transmissionFlushCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(207, 22);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "變速箱清洗 (NT$2,400)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(10, 28);
            this.radiatorFlushCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(177, 22);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "水箱清洗 (NT$900)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.mufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(20, 127);
            this.miscGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.miscGroupBox.Size = new System.Drawing.Size(240, 138);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "其他服務";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(10, 94);
            this.tireRotationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(177, 22);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "輪胎換位 (NT$600)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Location = new System.Drawing.Point(10, 61);
            this.mufflerCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(207, 22);
            this.mufflerCheckBox.TabIndex = 1;
            this.mufflerCheckBox.Text = "更換消音器 (NT$3,000)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(10, 28);
            this.inspectionCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(141, 22);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "檢驗 (NT$450)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLaborGroupBox
            // 
            this.partsLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsLaborGroupBox.Location = new System.Drawing.Point(270, 127);
            this.partsLaborGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.partsLaborGroupBox.Name = "partsLaborGroupBox";
            this.partsLaborGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.partsLaborGroupBox.Size = new System.Drawing.Size(260, 138);
            this.partsLaborGroupBox.TabIndex = 3;
            this.partsLaborGroupBox.TabStop = false;
            this.partsLaborGroupBox.Text = "零件和工時";
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(131, 76);
            this.laborTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(72, 29);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(131, 28);
            this.partsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(72, 29);
            this.partsTextBox.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(8, 79);
            this.laborLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(115, 18);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "工時數 (小時)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(20, 31);
            this.partsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(86, 18);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "零件(NT$)";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalFeesValueLabel);
            this.summaryGroupBox.Controls.Add(this.taxValueLabel);
            this.summaryGroupBox.Controls.Add(this.partsValueLabel);
            this.summaryGroupBox.Controls.Add(this.serviceLaborValueLabel);
            this.summaryGroupBox.Controls.Add(this.totalFeesLabel);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.serviceLaborLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(20, 276);
            this.summaryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.summaryGroupBox.Size = new System.Drawing.Size(510, 187);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "費用摘要";
            // 
            // totalFeesValueLabel
            // 
            this.totalFeesValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesValueLabel.Location = new System.Drawing.Point(164, 132);
            this.totalFeesValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalFeesValueLabel.Name = "totalFeesValueLabel";
            this.totalFeesValueLabel.Size = new System.Drawing.Size(150, 32);
            this.totalFeesValueLabel.TabIndex = 6;
            this.totalFeesValueLabel.Text = " ";
            // 
            // taxValueLabel
            // 
            this.taxValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxValueLabel.Location = new System.Drawing.Point(164, 96);
            this.taxValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxValueLabel.Name = "taxValueLabel";
            this.taxValueLabel.Size = new System.Drawing.Size(150, 32);
            this.taxValueLabel.TabIndex = 5;
            this.taxValueLabel.Text = " ";
            // 
            // partsValueLabel
            // 
            this.partsValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsValueLabel.Location = new System.Drawing.Point(164, 58);
            this.partsValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsValueLabel.Name = "partsValueLabel";
            this.partsValueLabel.Size = new System.Drawing.Size(150, 32);
            this.partsValueLabel.TabIndex = 5;
            this.partsValueLabel.Text = " ";
            // 
            // serviceLaborValueLabel
            // 
            this.serviceLaborValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceLaborValueLabel.Location = new System.Drawing.Point(164, 19);
            this.serviceLaborValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceLaborValueLabel.Name = "serviceLaborValueLabel";
            this.serviceLaborValueLabel.Size = new System.Drawing.Size(150, 32);
            this.serviceLaborValueLabel.TabIndex = 4;
            this.serviceLaborValueLabel.Text = " ";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Location = new System.Drawing.Point(69, 145);
            this.totalFeesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(62, 18);
            this.totalFeesLabel.TabIndex = 3;
            this.totalFeesLabel.Text = "總費用";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(46, 107);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(97, 18);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "稅金 (零件)";
            // 
            // partsSummaryLabel
            // 
            this.partsSummaryLabel.AutoSize = true;
            this.partsSummaryLabel.Location = new System.Drawing.Point(87, 72);
            this.partsSummaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsSummaryLabel.Name = "partsSummaryLabel";
            this.partsSummaryLabel.Size = new System.Drawing.Size(44, 18);
            this.partsSummaryLabel.TabIndex = 1;
            this.partsSummaryLabel.Text = "零件";
            // 
            // serviceLaborLabel
            // 
            this.serviceLaborLabel.AutoSize = true;
            this.serviceLaborLabel.Location = new System.Drawing.Point(36, 31);
            this.serviceLaborLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceLaborLabel.Name = "serviceLaborLabel";
            this.serviceLaborLabel.Size = new System.Drawing.Size(99, 27);
            this.serviceLaborLabel.TabIndex = 0;
            this.serviceLaborLabel.Text = "服務與工資";
            this.serviceLaborLabel.UseCompatibleTextRendering = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(93, 487);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 32);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "計算總額";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 487);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 32);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(346, 487);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 536);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilLubeGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "汽車維修服務";
            this.oilLubeGroupBox.ResumeLayout(false);
            this.oilLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsLaborGroupBox.ResumeLayout(false);
            this.partsLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsLaborGroupBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label totalFeesValueLabel;
        private System.Windows.Forms.Label taxValueLabel;
        private System.Windows.Forms.Label partsValueLabel;
        private System.Windows.Forms.Label serviceLaborValueLabel;
        private System.Windows.Forms.Label totalFeesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsSummaryLabel;
        private System.Windows.Forms.Label serviceLaborLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

