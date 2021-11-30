
namespace CheckBox
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FreeCheckBox = new System.Windows.Forms.CheckBox();
            this.FreeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FreeCheckBox
            // 
            this.FreeCheckBox.AutoSize = true;
            this.FreeCheckBox.Location = new System.Drawing.Point(87, 66);
            this.FreeCheckBox.Name = "FreeCheckBox";
            this.FreeCheckBox.Size = new System.Drawing.Size(188, 28);
            this.FreeCheckBox.TabIndex = 0;
            this.FreeCheckBox.Text = "FreeCheckBox";
            this.FreeCheckBox.UseVisualStyleBackColor = true;
            this.FreeCheckBox.CheckedChanged += new System.EventHandler(this.FreeCheckBox_CheckedChanged);
            // 
            // FreeLabel
            // 
            this.FreeLabel.AutoSize = true;
            this.FreeLabel.Location = new System.Drawing.Point(87, 162);
            this.FreeLabel.Name = "FreeLabel";
            this.FreeLabel.Size = new System.Drawing.Size(98, 24);
            this.FreeLabel.TabIndex = 1;
            this.FreeLabel.Text = "無料です";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 726);
            this.Controls.Add(this.FreeLabel);
            this.Controls.Add(this.FreeCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FreeCheckBox;
        private System.Windows.Forms.Label FreeLabel;
    }
}

