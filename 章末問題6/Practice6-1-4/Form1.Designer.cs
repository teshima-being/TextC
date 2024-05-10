namespace Practice6_1_4 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.ArrayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ShowResultLabel = new System.Windows.Forms.Label();
            this.AscendingButton = new System.Windows.Forms.Button();
            this.DescendingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題用配列";
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ArrayLabel.Location = new System.Drawing.Point(51, 80);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(0, 22);
            this.ArrayLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(50, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "抽出要素数を指定してください";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputTextBox.Location = new System.Drawing.Point(55, 199);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(336, 29);
            this.InputTextBox.TabIndex = 3;
            // 
            // ShowResultLabel
            // 
            this.ShowResultLabel.AutoSize = true;
            this.ShowResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowResultLabel.Location = new System.Drawing.Point(51, 280);
            this.ShowResultLabel.Name = "ShowResultLabel";
            this.ShowResultLabel.Size = new System.Drawing.Size(235, 22);
            this.ShowResultLabel.TabIndex = 4;
            this.ShowResultLabel.Text = "結果はここに表示されます";
            // 
            // AscendingButton
            // 
            this.AscendingButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AscendingButton.Location = new System.Drawing.Point(465, 156);
            this.AscendingButton.Name = "AscendingButton";
            this.AscendingButton.Size = new System.Drawing.Size(206, 60);
            this.AscendingButton.TabIndex = 5;
            this.AscendingButton.Text = "昇順で抽出";
            this.AscendingButton.UseVisualStyleBackColor = true;
            this.AscendingButton.Click += new System.EventHandler(this.AscendingButton_Click);
            // 
            // DescendingButton
            // 
            this.DescendingButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DescendingButton.Location = new System.Drawing.Point(465, 261);
            this.DescendingButton.Name = "DescendingButton";
            this.DescendingButton.Size = new System.Drawing.Size(206, 60);
            this.DescendingButton.TabIndex = 6;
            this.DescendingButton.Text = "降順で抽出";
            this.DescendingButton.UseVisualStyleBackColor = true;
            this.DescendingButton.Click += new System.EventHandler(this.DescendingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 395);
            this.Controls.Add(this.DescendingButton);
            this.Controls.Add(this.AscendingButton);
            this.Controls.Add(this.ShowResultLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrayLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ArrayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label ShowResultLabel;
        private System.Windows.Forms.Button AscendingButton;
        private System.Windows.Forms.Button DescendingButton;
    }
}

