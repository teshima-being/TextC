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
            this.FTextBoxFilePath = new System.Windows.Forms.TextBox();
            this.FButtonSearchFile = new System.Windows.Forms.Button();
            this.ShowTextLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.FButtonDisplayText = new System.Windows.Forms.Button();
            this.FTextBoxResult = new System.Windows.Forms.TextBox();
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
            // FTextBoxFilePath
            // 
            this.FTextBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBoxFilePath.Location = new System.Drawing.Point(40, 97);
            this.FTextBoxFilePath.Name = "FTextBoxFilePath";
            this.FTextBoxFilePath.ReadOnly = true;
            this.FTextBoxFilePath.Size = new System.Drawing.Size(630, 22);
            this.FTextBoxFilePath.TabIndex = 1;
            // 
            // FButtonSearchFile
            // 
            this.FButtonSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FButtonSearchFile.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonSearchFile.Location = new System.Drawing.Point(716, 73);
            this.FButtonSearchFile.Name = "FButtonSearchFile";
            this.FButtonSearchFile.Size = new System.Drawing.Size(146, 62);
            this.FButtonSearchFile.TabIndex = 2;
            this.FButtonSearchFile.Text = "ファイル検索";
            this.FButtonSearchFile.UseVisualStyleBackColor = true;
            this.FButtonSearchFile.Click += new System.EventHandler(this.FButtonSearchFile_Click);
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
            // FButtonDisplayText
            // 
            this.FButtonDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FButtonDisplayText.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonDisplayText.Location = new System.Drawing.Point(716, 164);
            this.FButtonDisplayText.Name = "FButtonDisplayText";
            this.FButtonDisplayText.Size = new System.Drawing.Size(146, 62);
            this.FButtonDisplayText.TabIndex = 5;
            this.FButtonDisplayText.Text = "テキスト表示";
            this.FButtonDisplayText.UseVisualStyleBackColor = true;
            this.FButtonDisplayText.Click += new System.EventHandler(this.FButtonDisplayText_Click);
            // 
            // FTextBoxResult
            // 
            this.FTextBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBoxResult.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FTextBoxResult.Location = new System.Drawing.Point(40, 234);
            this.FTextBoxResult.Multiline = true;
            this.FTextBoxResult.Name = "FTextBoxResult";
            this.FTextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FTextBoxResult.Size = new System.Drawing.Size(630, 332);
            this.FTextBoxResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 603);
            this.Controls.Add(this.FTextBoxResult);
            this.Controls.Add(this.FButtonDisplayText);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ShowTextLabel);
            this.Controls.Add(this.FButtonSearchFile);
            this.Controls.Add(this.FTextBoxFilePath);
            this.Controls.Add(this.Label1);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox FTextBoxFilePath;
        private System.Windows.Forms.Button FButtonSearchFile;
        private System.Windows.Forms.Label ShowTextLabel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button FButtonDisplayText;
        private System.Windows.Forms.TextBox FTextBoxResult;
    }
}

