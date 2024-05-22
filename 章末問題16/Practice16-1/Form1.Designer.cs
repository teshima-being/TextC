namespace Practice16_1 {
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
            this.Label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileSearchButton = new System.Windows.Forms.Button();
            this.ShowTextLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ShowTextButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(36, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(543, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ファイル検索をクリックし、読み込むテキストファイルを指定してください。";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(40, 97);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(612, 22);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // FileSearchButton
            // 
            this.FileSearchButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FileSearchButton.Location = new System.Drawing.Point(698, 73);
            this.FileSearchButton.Name = "FileSearchButton";
            this.FileSearchButton.Size = new System.Drawing.Size(146, 62);
            this.FileSearchButton.TabIndex = 2;
            this.FileSearchButton.Text = "ファイル検索";
            this.FileSearchButton.UseVisualStyleBackColor = true;
            this.FileSearchButton.Click += new System.EventHandler(this.ShowSelectedFilePath);
            // 
            // ShowTextLabel
            // 
            this.ShowTextLabel.AutoSize = true;
            this.ShowTextLabel.Location = new System.Drawing.Point(49, 160);
            this.ShowTextLabel.Name = "ShowTextLabel";
            this.ShowTextLabel.Size = new System.Drawing.Size(0, 15);
            this.ShowTextLabel.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new System.Drawing.Point(36, 185);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(613, 20);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "テキスト表示をクリックすると、上記ファイルのテキストを表示することができます。";
            // 
            // ShowTextButton
            // 
            this.ShowTextButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowTextButton.Location = new System.Drawing.Point(698, 164);
            this.ShowTextButton.Name = "ShowTextButton";
            this.ShowTextButton.Size = new System.Drawing.Size(146, 62);
            this.ShowTextButton.TabIndex = 5;
            this.ShowTextButton.Text = "テキスト表示";
            this.ShowTextButton.UseVisualStyleBackColor = true;
            this.ShowTextButton.Click += new System.EventHandler(this.ShowFileText);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultTextBox.Location = new System.Drawing.Point(40, 234);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(612, 306);
            this.ResultTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 577);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ShowTextButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ShowTextLabel);
            this.Controls.Add(this.FileSearchButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button FileSearchButton;
        private System.Windows.Forms.Label ShowTextLabel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button ShowTextButton;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

