namespace ZipCompressTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZipFlo = new System.Windows.Forms.Button();
            this.btnUnZipFlo = new System.Windows.Forms.Button();
            this.btnBatchZipFlo = new System.Windows.Forms.Button();
            this.btnBatchUnZipFlo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZipFlo
            // 
            this.btnZipFlo.Location = new System.Drawing.Point(47, 37);
            this.btnZipFlo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZipFlo.Name = "btnZipFlo";
            this.btnZipFlo.Size = new System.Drawing.Size(70, 31);
            this.btnZipFlo.TabIndex = 0;
            this.btnZipFlo.Text = "压缩文件";
            this.btnZipFlo.UseVisualStyleBackColor = true;
            this.btnZipFlo.Click += new System.EventHandler(this.btnZipFlo_Click);
            // 
            // btnUnZipFlo
            // 
            this.btnUnZipFlo.Location = new System.Drawing.Point(47, 119);
            this.btnUnZipFlo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnZipFlo.Name = "btnUnZipFlo";
            this.btnUnZipFlo.Size = new System.Drawing.Size(70, 31);
            this.btnUnZipFlo.TabIndex = 1;
            this.btnUnZipFlo.Text = "解压文件";
            this.btnUnZipFlo.UseVisualStyleBackColor = true;
            this.btnUnZipFlo.Click += new System.EventHandler(this.btnUnZipFlo_Click);
            // 
            // btnBatchZipFlo
            // 
            this.btnBatchZipFlo.Location = new System.Drawing.Point(190, 37);
            this.btnBatchZipFlo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatchZipFlo.Name = "btnBatchZipFlo";
            this.btnBatchZipFlo.Size = new System.Drawing.Size(93, 31);
            this.btnBatchZipFlo.TabIndex = 2;
            this.btnBatchZipFlo.Text = "批量压缩文件";
            this.btnBatchZipFlo.UseVisualStyleBackColor = true;
            this.btnBatchZipFlo.Click += new System.EventHandler(this.btnBatchZipFlo_Click);
            // 
            // btnBatchUnZipFlo
            // 
            this.btnBatchUnZipFlo.Location = new System.Drawing.Point(190, 119);
            this.btnBatchUnZipFlo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatchUnZipFlo.Name = "btnBatchUnZipFlo";
            this.btnBatchUnZipFlo.Size = new System.Drawing.Size(93, 31);
            this.btnBatchUnZipFlo.TabIndex = 3;
            this.btnBatchUnZipFlo.Text = "批量解压文件";
            this.btnBatchUnZipFlo.UseVisualStyleBackColor = true;
            this.btnBatchUnZipFlo.Click += new System.EventHandler(this.btnBatchUnZipFlo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 190);
            this.Controls.Add(this.btnBatchUnZipFlo);
            this.Controls.Add(this.btnBatchZipFlo);
            this.Controls.Add(this.btnUnZipFlo);
            this.Controls.Add(this.btnZipFlo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZipFlo;
        private System.Windows.Forms.Button btnUnZipFlo;
        private System.Windows.Forms.Button btnBatchZipFlo;
        private System.Windows.Forms.Button btnBatchUnZipFlo;
    }
}

