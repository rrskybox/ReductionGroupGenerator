
namespace ReductionGroupGenerator
{
    partial class FormReductionGroupGenerator
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CalDirBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CalibrationDirectoryBox = new System.Windows.Forms.TextBox();
            this.AppSettingsDirBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AppSettingsDirBrowseButton = new System.Windows.Forms.Button();
            this.CalDirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.AppSettingsDirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BinningBox = new System.Windows.Forms.ComboBox();
            this.TemperatureBox = new System.Windows.Forms.ComboBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(544, 92);
            this.StartButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(89, 28);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Assemble";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CalDirBrowseButton
            // 
            this.CalDirBrowseButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalDirBrowseButton.Location = new System.Drawing.Point(648, 15);
            this.CalDirBrowseButton.Name = "CalDirBrowseButton";
            this.CalDirBrowseButton.Size = new System.Drawing.Size(89, 28);
            this.CalDirBrowseButton.TabIndex = 1;
            this.CalDirBrowseButton.Text = "Browse";
            this.CalDirBrowseButton.UseVisualStyleBackColor = true;
            this.CalDirBrowseButton.Click += new System.EventHandler(this.CalDirBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calibration Image Directory";
            // 
            // CalibrationDirectoryBox
            // 
            this.CalibrationDirectoryBox.Location = new System.Drawing.Point(192, 19);
            this.CalibrationDirectoryBox.Name = "CalibrationDirectoryBox";
            this.CalibrationDirectoryBox.Size = new System.Drawing.Size(441, 20);
            this.CalibrationDirectoryBox.TabIndex = 3;
            // 
            // AppSettingsDirBox
            // 
            this.AppSettingsDirBox.Location = new System.Drawing.Point(192, 57);
            this.AppSettingsDirBox.Name = "AppSettingsDirBox";
            this.AppSettingsDirBox.Size = new System.Drawing.Size(441, 20);
            this.AppSettingsDirBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = " AppSettings.ini Directory";
            // 
            // AppSettingsDirBrowseButton
            // 
            this.AppSettingsDirBrowseButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppSettingsDirBrowseButton.Location = new System.Drawing.Point(648, 53);
            this.AppSettingsDirBrowseButton.Name = "AppSettingsDirBrowseButton";
            this.AppSettingsDirBrowseButton.Size = new System.Drawing.Size(89, 28);
            this.AppSettingsDirBrowseButton.TabIndex = 4;
            this.AppSettingsDirBrowseButton.Text = "Browse";
            this.AppSettingsDirBrowseButton.UseVisualStyleBackColor = true;
            this.AppSettingsDirBrowseButton.Click += new System.EventHandler(this.AppSettingsDirBrowseButton_Click);
            // 
            // CalDirBrowserDialog
            // 
            this.CalDirBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.CalDirBrowserDialog.ShowNewFolderButton = false;
            // 
            // AppSettingsDirBrowserDialog
            // 
            this.AppSettingsDirBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Binning";
            // 
            // BinningBox
            // 
            this.BinningBox.FormattingEnabled = true;
            this.BinningBox.Location = new System.Drawing.Point(324, 94);
            this.BinningBox.Name = "BinningBox";
            this.BinningBox.Size = new System.Drawing.Size(50, 21);
            this.BinningBox.TabIndex = 11;
            // 
            // TemperatureBox
            // 
            this.TemperatureBox.FormattingEnabled = true;
            this.TemperatureBox.Location = new System.Drawing.Point(479, 95);
            this.TemperatureBox.Name = "TemperatureBox";
            this.TemperatureBox.Size = new System.Drawing.Size(50, 21);
            this.TemperatureBox.TabIndex = 12;
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(648, 92);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(89, 28);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FormReductionGroupGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(749, 138);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TemperatureBox);
            this.Controls.Add(this.BinningBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppSettingsDirBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppSettingsDirBrowseButton);
            this.Controls.Add(this.CalibrationDirectoryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalDirBrowseButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FormReductionGroupGenerator";
            this.Text = "Reduction Group Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CalDirBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CalibrationDirectoryBox;
        private System.Windows.Forms.TextBox AppSettingsDirBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AppSettingsDirBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog CalDirBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog AppSettingsDirBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BinningBox;
        private System.Windows.Forms.ComboBox TemperatureBox;
        private System.Windows.Forms.Button CloseButton;
    }
}

