﻿
namespace Unowhy_Tools
{
    partial class nonew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nonew));
            this.noverlab = new System.Windows.Forms.Label();
            this.nook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noverlab
            // 
            this.noverlab.AutoSize = true;
            this.noverlab.BackColor = System.Drawing.Color.Transparent;
            this.noverlab.ForeColor = System.Drawing.Color.White;
            this.noverlab.Location = new System.Drawing.Point(12, 18);
            this.noverlab.Name = "noverlab";
            this.noverlab.Size = new System.Drawing.Size(126, 13);
            this.noverlab.TabIndex = 0;
            this.noverlab.Text = "No new version available";
            // 
            // nook
            // 
            this.nook.Location = new System.Drawing.Point(64, 52);
            this.nook.Name = "nook";
            this.nook.Size = new System.Drawing.Size(75, 23);
            this.nook.TabIndex = 1;
            this.nook.Text = "OK";
            this.nook.UseVisualStyleBackColor = true;
            this.nook.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(151, 87);
            this.Controls.Add(this.nook);
            this.Controls.Add(this.noverlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nonew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noverlab;
        private System.Windows.Forms.Button nook;
    }
}