
namespace XmlParser
{
    partial class ARXMLParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARXMLParser));
            this.imgContinental = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtProcessStatus = new System.Windows.Forms.RichTextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.radioBtnDestructive = new System.Windows.Forms.RadioButton();
            this.radioBtnNonDestructive = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.radioBtnFaster = new System.Windows.Forms.RadioButton();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.radioBtnLessMemory = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeRegex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).BeginInit();
            this.panelProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgContinental
            // 
            this.imgContinental.Image = global::ARXML_Parser.Properties.Resources.ContiLogo;
            this.imgContinental.Location = new System.Drawing.Point(162, 12);
            this.imgContinental.Name = "imgContinental";
            this.imgContinental.Size = new System.Drawing.Size(488, 88);
            this.imgContinental.TabIndex = 0;
            this.imgContinental.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(308, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ARXML Parser";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFileSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileSelect.FlatAppearance.BorderSize = 0;
            this.btnFileSelect.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileSelect.Location = new System.Drawing.Point(217, 151);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(371, 55);
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "SELECT EXCEL";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // txtProcessStatus
            // 
            this.txtProcessStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProcessStatus.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProcessStatus.Location = new System.Drawing.Point(12, 409);
            this.txtProcessStatus.Name = "txtProcessStatus";
            this.txtProcessStatus.ReadOnly = true;
            this.txtProcessStatus.Size = new System.Drawing.Size(787, 387);
            this.txtProcessStatus.TabIndex = 3;
            this.txtProcessStatus.Text = "";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(217, 216);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(169, 32);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "EXCEL Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.SeaGreen;
            this.btnParse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParse.FlatAppearance.BorderSize = 0;
            this.btnParse.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParse.Location = new System.Drawing.Point(217, 348);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(371, 55);
            this.btnParse.TabIndex = 9;
            this.btnParse.Text = "PARSE FILE";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // radioBtnDestructive
            // 
            this.radioBtnDestructive.AutoSize = true;
            this.radioBtnDestructive.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnDestructive.Location = new System.Drawing.Point(256, 254);
            this.radioBtnDestructive.Name = "radioBtnDestructive";
            this.radioBtnDestructive.Size = new System.Drawing.Size(110, 26);
            this.radioBtnDestructive.TabIndex = 10;
            this.radioBtnDestructive.Tag = "FileManipulation";
            this.radioBtnDestructive.Text = "Destructive";
            this.radioBtnDestructive.UseVisualStyleBackColor = true;
            // 
            // radioBtnNonDestructive
            // 
            this.radioBtnNonDestructive.AutoSize = true;
            this.radioBtnNonDestructive.Checked = true;
            this.radioBtnNonDestructive.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnNonDestructive.Location = new System.Drawing.Point(425, 254);
            this.radioBtnNonDestructive.Name = "radioBtnNonDestructive";
            this.radioBtnNonDestructive.Size = new System.Drawing.Size(143, 26);
            this.radioBtnNonDestructive.TabIndex = 11;
            this.radioBtnNonDestructive.TabStop = true;
            this.radioBtnNonDestructive.Tag = "FileManipulation";
            this.radioBtnNonDestructive.Text = "Non-Destructive";
            this.radioBtnNonDestructive.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(256, 315);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 30);
            this.progressBar.TabIndex = 13;
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearConsole.FlatAppearance.BorderSize = 0;
            this.btnClearConsole.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearConsole.Location = new System.Drawing.Point(662, 364);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(137, 39);
            this.btnClearConsole.TabIndex = 14;
            this.btnClearConsole.Text = "Clear console";
            this.btnClearConsole.UseVisualStyleBackColor = false;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // radioBtnFaster
            // 
            this.radioBtnFaster.AutoSize = true;
            this.radioBtnFaster.Checked = true;
            this.radioBtnFaster.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnFaster.Location = new System.Drawing.Point(169, 7);
            this.radioBtnFaster.Name = "radioBtnFaster";
            this.radioBtnFaster.Size = new System.Drawing.Size(75, 26);
            this.radioBtnFaster.TabIndex = 0;
            this.radioBtnFaster.TabStop = true;
            this.radioBtnFaster.Text = "Faster";
            this.radioBtnFaster.UseVisualStyleBackColor = true;
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.radioBtnFaster);
            this.panelProcess.Controls.Add(this.radioBtnLessMemory);
            this.panelProcess.Location = new System.Drawing.Point(256, 275);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(309, 35);
            this.panelProcess.TabIndex = 19;
            // 
            // radioBtnLessMemory
            // 
            this.radioBtnLessMemory.AutoSize = true;
            this.radioBtnLessMemory.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnLessMemory.Location = new System.Drawing.Point(0, 7);
            this.radioBtnLessMemory.Name = "radioBtnLessMemory";
            this.radioBtnLessMemory.Size = new System.Drawing.Size(123, 26);
            this.radioBtnLessMemory.TabIndex = 2;
            this.radioBtnLessMemory.Text = "Less memory";
            this.radioBtnLessMemory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(712, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "v. 1.0.1-beta";
            // 
            // btnChangeRegex
            // 
            this.btnChangeRegex.BackColor = System.Drawing.Color.GhostWhite;
            this.btnChangeRegex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRegex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRegex.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeRegex.Location = new System.Drawing.Point(419, 216);
            this.btnChangeRegex.Name = "btnChangeRegex";
            this.btnChangeRegex.Size = new System.Drawing.Size(169, 32);
            this.btnChangeRegex.TabIndex = 21;
            this.btnChangeRegex.Text = "Change REGEX";
            this.btnChangeRegex.UseVisualStyleBackColor = false;
            this.btnChangeRegex.Click += new System.EventHandler(this.btnChangeRegex_Click);
            // 
            // ARXMLParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(811, 808);
            this.Controls.Add(this.btnChangeRegex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.radioBtnNonDestructive);
            this.Controls.Add(this.radioBtnDestructive);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtProcessStatus);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgContinental);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ARXMLParser";
            this.Text = "ARXML Parser";
            this.Load += new System.EventHandler(this.XMLParser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgContinental)).EndInit();
            this.panelProcess.ResumeLayout(false);
            this.panelProcess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgContinental;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.RichTextBox txtProcessStatus;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.RadioButton radioBtnDestructive;
        private System.Windows.Forms.RadioButton radioBtnNonDestructive;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.RadioButton radioBtnFaster;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.RadioButton radioBtnLessMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeRegex;
    }
}