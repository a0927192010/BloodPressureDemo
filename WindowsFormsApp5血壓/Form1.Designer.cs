namespace WindowsFormsApp5血壓
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl收縮 = new System.Windows.Forms.Label();
            this.lbl舒張 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn檢測 = new System.Windows.Forms.Button();
            this.tb收縮 = new System.Windows.Forms.TextBox();
            this.tb舒張 = new System.Windows.Forms.TextBox();
            this.tb結果 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(125, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入血壓";
            // 
            // lbl收縮
            // 
            this.lbl收縮.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl收縮.Location = new System.Drawing.Point(12, 139);
            this.lbl收縮.Name = "lbl收縮";
            this.lbl收縮.Size = new System.Drawing.Size(113, 45);
            this.lbl收縮.TabIndex = 1;
            this.lbl收縮.Text = "收縮壓";
            // 
            // lbl舒張
            // 
            this.lbl舒張.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl舒張.Location = new System.Drawing.Point(12, 235);
            this.lbl舒張.Name = "lbl舒張";
            this.lbl舒張.Size = new System.Drawing.Size(113, 42);
            this.lbl舒張.TabIndex = 2;
            this.lbl舒張.Text = "舒張壓";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(291, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "毫米汞柱";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(291, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "毫米汞柱";
            // 
            // btn檢測
            // 
            this.btn檢測.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn檢測.Location = new System.Drawing.Point(132, 294);
            this.btn檢測.Name = "btn檢測";
            this.btn檢測.Size = new System.Drawing.Size(155, 66);
            this.btn檢測.TabIndex = 5;
            this.btn檢測.Text = "檢測";
            this.btn檢測.UseVisualStyleBackColor = true;
            this.btn檢測.Click += new System.EventHandler(this.btn檢測_Click);
            // 
            // tb收縮
            // 
            this.tb收縮.Location = new System.Drawing.Point(150, 142);
            this.tb收縮.Multiline = true;
            this.tb收縮.Name = "tb收縮";
            this.tb收縮.Size = new System.Drawing.Size(135, 34);
            this.tb收縮.TabIndex = 6;
            this.tb收縮.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb舒張
            // 
            this.tb舒張.Location = new System.Drawing.Point(150, 238);
            this.tb舒張.Multiline = true;
            this.tb舒張.Name = "tb舒張";
            this.tb舒張.Size = new System.Drawing.Size(135, 30);
            this.tb舒張.TabIndex = 7;
            this.tb舒張.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb結果
            // 
            this.tb結果.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb結果.Location = new System.Drawing.Point(107, 366);
            this.tb結果.Multiline = true;
            this.tb結果.Name = "tb結果";
            this.tb結果.Size = new System.Drawing.Size(216, 116);
            this.tb結果.TabIndex = 8;
            this.tb結果.Text = "結果顯示";
            this.tb結果.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 494);
            this.Controls.Add(this.tb結果);
            this.Controls.Add(this.tb舒張);
            this.Controls.Add(this.tb收縮);
            this.Controls.Add(this.btn檢測);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl舒張);
            this.Controls.Add(this.lbl收縮);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "血壓檢測系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl收縮;
        private System.Windows.Forms.Label lbl舒張;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn檢測;
        private System.Windows.Forms.TextBox tb收縮;
        private System.Windows.Forms.TextBox tb舒張;
        private System.Windows.Forms.TextBox tb結果;
    }
}

