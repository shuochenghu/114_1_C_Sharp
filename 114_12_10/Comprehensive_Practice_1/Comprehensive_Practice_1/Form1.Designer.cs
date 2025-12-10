namespace Comprehensive_Practice_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelGiven;
        private System.Windows.Forms.Label labelExam1;
        private System.Windows.Forms.Label labelExam2;
        private System.Windows.Forms.Label labelExam3;

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGiven;
        private System.Windows.Forms.TextBox textBoxExam1;
        private System.Windows.Forms.TextBox textBoxExam2;
        private System.Windows.Forms.TextBox textBoxExam3;

        private System.Windows.Forms.Button btnShowHighest;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblResult;

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
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGiven = new System.Windows.Forms.Label();
            this.labelExam1 = new System.Windows.Forms.Label();
            this.labelExam2 = new System.Windows.Forms.Label();
            this.labelExam3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxGiven = new System.Windows.Forms.TextBox();
            this.textBoxExam1 = new System.Windows.Forms.TextBox();
            this.textBoxExam2 = new System.Windows.Forms.TextBox();
            this.textBoxExam3 = new System.Windows.Forms.TextBox();
            this.btnShowHighest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSurname.Location = new System.Drawing.Point(20, 23);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(68, 55);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "名";
            this.labelSurname.Click += new System.EventHandler(this.labelSurname_Click);
            // 
            // labelGiven
            // 
            this.labelGiven.AutoSize = true;
            this.labelGiven.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGiven.Location = new System.Drawing.Point(579, 20);
            this.labelGiven.Name = "labelGiven";
            this.labelGiven.Size = new System.Drawing.Size(68, 55);
            this.labelGiven.TabIndex = 2;
            this.labelGiven.Text = "姓";
            // 
            // labelExam1
            // 
            this.labelExam1.AutoSize = true;
            this.labelExam1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelExam1.Location = new System.Drawing.Point(29, 135);
            this.labelExam1.Name = "labelExam1";
            this.labelExam1.Size = new System.Drawing.Size(138, 55);
            this.labelExam1.TabIndex = 4;
            this.labelExam1.Text = "小考1";
            // 
            // labelExam2
            // 
            this.labelExam2.AutoSize = true;
            this.labelExam2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelExam2.Location = new System.Drawing.Point(20, 223);
            this.labelExam2.Name = "labelExam2";
            this.labelExam2.Size = new System.Drawing.Size(138, 55);
            this.labelExam2.TabIndex = 6;
            this.labelExam2.Text = "小考2";
            // 
            // labelExam3
            // 
            this.labelExam3.AutoSize = true;
            this.labelExam3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelExam3.Location = new System.Drawing.Point(20, 309);
            this.labelExam3.Name = "labelExam3";
            this.labelExam3.Size = new System.Drawing.Size(138, 55);
            this.labelExam3.TabIndex = 8;
            this.labelExam3.Text = "小考3";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSurname.Location = new System.Drawing.Point(145, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(300, 66);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxGiven
            // 
            this.textBoxGiven.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGiven.Location = new System.Drawing.Point(687, 12);
            this.textBoxGiven.Name = "textBoxGiven";
            this.textBoxGiven.Size = new System.Drawing.Size(300, 66);
            this.textBoxGiven.TabIndex = 3;
            // 
            // textBoxExam1
            // 
            this.textBoxExam1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxExam1.Location = new System.Drawing.Point(217, 132);
            this.textBoxExam1.Name = "textBoxExam1";
            this.textBoxExam1.Size = new System.Drawing.Size(150, 66);
            this.textBoxExam1.TabIndex = 5;
            // 
            // textBoxExam2
            // 
            this.textBoxExam2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxExam2.Location = new System.Drawing.Point(217, 223);
            this.textBoxExam2.Name = "textBoxExam2";
            this.textBoxExam2.Size = new System.Drawing.Size(150, 66);
            this.textBoxExam2.TabIndex = 7;
            // 
            // textBoxExam3
            // 
            this.textBoxExam3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxExam3.Location = new System.Drawing.Point(217, 309);
            this.textBoxExam3.Name = "textBoxExam3";
            this.textBoxExam3.Size = new System.Drawing.Size(150, 66);
            this.textBoxExam3.TabIndex = 9;
            // 
            // btnShowHighest
            // 
            this.btnShowHighest.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowHighest.Location = new System.Drawing.Point(182, 483);
            this.btnShowHighest.Name = "btnShowHighest";
            this.btnShowHighest.Size = new System.Drawing.Size(341, 60);
            this.btnShowHighest.TabIndex = 10;
            this.btnShowHighest.Text = "顯示最高分";
            this.btnShowHighest.UseVisualStyleBackColor = true;
            this.btnShowHighest.Click += new System.EventHandler(this.btnShowHighest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(720, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(589, 294);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(580, 70);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 646);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelGiven);
            this.Controls.Add(this.textBoxGiven);
            this.Controls.Add(this.labelExam1);
            this.Controls.Add(this.textBoxExam1);
            this.Controls.Add(this.labelExam2);
            this.Controls.Add(this.textBoxExam2);
            this.Controls.Add(this.labelExam3);
            this.Controls.Add(this.textBoxExam3);
            this.Controls.Add(this.btnShowHighest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

