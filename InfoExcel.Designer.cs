
namespace XmlParser
{
    partial class InfoExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoExcel));
            this.lblTitle = new System.Windows.Forms.Label();
            this.boxInfo = new System.Windows.Forms.RichTextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(32, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "EXCEL Info";
            // 
            // boxInfo
            // 
            this.boxInfo.BackColor = System.Drawing.Color.SeaShell;
            this.boxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.boxInfo.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.boxInfo.Location = new System.Drawing.Point(32, 73);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.ReadOnly = true;
            this.boxInfo.Size = new System.Drawing.Size(454, 278);
            this.boxInfo.TabIndex = 2;
            this.boxInfo.Text = "";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(183, 367);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(126, 29);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "GOT IT";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // InfoExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 443);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.boxInfo);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoExcel";
            this.Text = "InfoExcel";
            this.Load += new System.EventHandler(this.InfoExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox boxInfo;
        private System.Windows.Forms.Button btnInfo;
    }
}