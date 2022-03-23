
namespace ARXML_Parser
{
    partial class RegexMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtCurrentRegex = new System.Windows.Forms.TextBox();
            this.lblCurrentRegex = new System.Windows.Forms.Label();
            this.lblNewRegex = new System.Windows.Forms.Label();
            this.txtNewRegex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(29, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Change REGEX";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lblWarning.Location = new System.Drawing.Point(29, 77);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(459, 72);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "WARNING: Changing the REGEX pattern will result in \r\nchanges regarding how the pr" +
    "ogram matches the strings. \r\nBe very careful. ";
            // 
            // txtCurrentRegex
            // 
            this.txtCurrentRegex.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrentRegex.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCurrentRegex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrentRegex.Location = new System.Drawing.Point(229, 202);
            this.txtCurrentRegex.Name = "txtCurrentRegex";
            this.txtCurrentRegex.ReadOnly = true;
            this.txtCurrentRegex.Size = new System.Drawing.Size(219, 27);
            this.txtCurrentRegex.TabIndex = 5;
            // 
            // lblCurrentRegex
            // 
            this.lblCurrentRegex.AutoSize = true;
            this.lblCurrentRegex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentRegex.Location = new System.Drawing.Point(77, 202);
            this.lblCurrentRegex.Name = "lblCurrentRegex";
            this.lblCurrentRegex.Size = new System.Drawing.Size(136, 24);
            this.lblCurrentRegex.TabIndex = 6;
            this.lblCurrentRegex.Text = "Current REGEX:";
            // 
            // lblNewRegex
            // 
            this.lblNewRegex.AutoSize = true;
            this.lblNewRegex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewRegex.Location = new System.Drawing.Point(90, 235);
            this.lblNewRegex.Name = "lblNewRegex";
            this.lblNewRegex.Size = new System.Drawing.Size(112, 24);
            this.lblNewRegex.TabIndex = 7;
            this.lblNewRegex.Text = "New REGEX:";
            // 
            // txtNewRegex
            // 
            this.txtNewRegex.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewRegex.Location = new System.Drawing.Point(229, 235);
            this.txtNewRegex.Name = "txtNewRegex";
            this.txtNewRegex.Size = new System.Drawing.Size(219, 27);
            this.txtNewRegex.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.GhostWhite;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(117, 330);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 29);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(261, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 29);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RegexMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 443);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNewRegex);
            this.Controls.Add(this.lblNewRegex);
            this.Controls.Add(this.lblCurrentRegex);
            this.Controls.Add(this.txtCurrentRegex);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegexMenu";
            this.Text = "RegexMenu";
            this.Load += new System.EventHandler(this.RegexMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtCurrentRegex;
        private System.Windows.Forms.Label lblCurrentRegex;
        private System.Windows.Forms.Label lblNewRegex;
        private System.Windows.Forms.TextBox txtNewRegex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
    }
}