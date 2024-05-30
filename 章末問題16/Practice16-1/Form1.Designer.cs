namespace Practice16_1 {
    partial class FFormDisplayText {
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
            this.FLabelFilePath = new System.Windows.Forms.Label();
            this.FTextBoxFilePath = new System.Windows.Forms.TextBox();
            this.FButtonSearchFile = new System.Windows.Forms.Button();
            this.ShowTextLabel = new System.Windows.Forms.Label();
            this.FLabelResultText = new System.Windows.Forms.Label();
            this.FButtonDisplayText = new System.Windows.Forms.Button();
            this.FTextBoxResult = new System.Windows.Forms.TextBox();
            this.FButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FLabelFilePath
            // 
            this.FLabelFilePath.AutoSize = true;
            this.FLabelFilePath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FLabelFilePath.Location = new System.Drawing.Point(36, 32);
            this.FLabelFilePath.Name = "FLabelFilePath";
            this.FLabelFilePath.Size = new System.Drawing.Size(543, 20);
            this.FLabelFilePath.TabIndex = 0;
            this.FLabelFilePath.Text = "ファイル検索をクリックし、読み込むテキストファイルを指定してください。";
            // 
            // FTextBoxFilePath
            // 
            this.FTextBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FTextBoxFilePath.Location = new System.Drawing.Point(40, 97);
            this.FTextBoxFilePath.Name = "FTextBoxFilePath";
            this.FTextBoxFilePath.ReadOnly = true;
            this.FTextBoxFilePath.Size = new System.Drawing.Size(869, 22);
            this.FTextBoxFilePath.TabIndex = 1;
            // 
            // FButtonSearchFile
            // 
            this.FButtonSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FButtonSearchFile.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonSearchFile.Location = new System.Drawing.Point(945, 97);
            this.FButtonSearchFile.Name = "FButtonSearchFile";
            this.FButtonSearchFile.Size = new System.Drawing.Size(134, 39);
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
            // FLabelResultText
            // 
            this.FLabelResultText.AutoSize = true;
            this.FLabelResultText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FLabelResultText.Location = new System.Drawing.Point(36, 164);
            this.FLabelResultText.Name = "FLabelResultText";
            this.FLabelResultText.Size = new System.Drawing.Size(613, 20);
            this.FLabelResultText.TabIndex = 4;
            this.FLabelResultText.Text = "テキスト表示をクリックすると、上記ファイルのテキストを表示することができます。";
            // 
            // FButtonDisplayText
            // 
            this.FButtonDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FButtonDisplayText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonDisplayText.Location = new System.Drawing.Point(861, 702);
            this.FButtonDisplayText.Name = "FButtonDisplayText";
            this.FButtonDisplayText.Size = new System.Drawing.Size(134, 39);
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
            this.FTextBoxResult.Location = new System.Drawing.Point(40, 196);
            this.FTextBoxResult.Multiline = true;
            this.FTextBoxResult.Name = "FTextBoxResult";
            this.FTextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FTextBoxResult.Size = new System.Drawing.Size(1090, 482);
            this.FTextBoxResult.TabIndex = 6;
            // 
            // FButtonCancel
            // 
            this.FButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FButtonCancel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FButtonCancel.Location = new System.Drawing.Point(1015, 702);
            this.FButtonCancel.Name = "FButtonCancel";
            this.FButtonCancel.Size = new System.Drawing.Size(134, 39);
            this.FButtonCancel.TabIndex = 7;
            this.FButtonCancel.Text = "キャンセル";
            this.FButtonCancel.UseVisualStyleBackColor = true;
            this.FButtonCancel.Click += new System.EventHandler(this.FButtonCancel_Click);
            // 
            // FFormDisplayText
            // 
            this.AcceptButton = this.FButtonDisplayText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FButtonCancel;
            this.ClientSize = new System.Drawing.Size(1175, 766);
            this.Controls.Add(this.FButtonCancel);
            this.Controls.Add(this.FTextBoxResult);
            this.Controls.Add(this.FButtonDisplayText);
            this.Controls.Add(this.FLabelResultText);
            this.Controls.Add(this.ShowTextLabel);
            this.Controls.Add(this.FButtonSearchFile);
            this.Controls.Add(this.FTextBoxFilePath);
            this.Controls.Add(this.FLabelFilePath);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "FFormDisplayText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  テキスト表示フォーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FLabelFilePath;
        private System.Windows.Forms.TextBox FTextBoxFilePath;
        private System.Windows.Forms.Button FButtonSearchFile;
        private System.Windows.Forms.Label ShowTextLabel;
        private System.Windows.Forms.Label FLabelResultText;
        private System.Windows.Forms.Button FButtonDisplayText;
        private System.Windows.Forms.TextBox FTextBoxResult;
        private System.Windows.Forms.Button FButtonCancel;
    }
}

