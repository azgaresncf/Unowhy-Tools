﻿
namespace Unowhy_Tools
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aver = new System.Windows.Forms.Label();
            this.asty1001 = new System.Windows.Forms.Label();
            this.website = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.alogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alogo)).BeginInit();
            this.SuspendLayout();
            // 
            // aver
            // 
            this.aver.AutoSize = true;
            this.aver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aver.ForeColor = System.Drawing.Color.White;
            this.aver.Location = new System.Drawing.Point(11, 56);
            this.aver.Name = "aver";
            this.aver.Size = new System.Drawing.Size(93, 20);
            this.aver.TabIndex = 12;
            this.aver.Text = "Version 4.0";
            this.aver.Click += new System.EventHandler(this.label2_Click);
            // 
            // asty1001
            // 
            this.asty1001.AutoSize = true;
            this.asty1001.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asty1001.ForeColor = System.Drawing.Color.White;
            this.asty1001.Location = new System.Drawing.Point(12, 88);
            this.asty1001.Name = "asty1001";
            this.asty1001.Size = new System.Drawing.Size(230, 16);
            this.asty1001.TabIndex = 13;
            this.asty1001.Text = "by STY1001 | sty1001.wordpress.com";
            // 
            // website
            // 
            this.website.Location = new System.Drawing.Point(12, 120);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(101, 34);
            this.website.TabIndex = 14;
            this.website.Text = "STY1001\'s WebSite";
            this.website.UseVisualStyleBackColor = true;
            this.website.Click += new System.EventHandler(this.button1_Click);
            // 
            // github
            // 
            this.github.Location = new System.Drawing.Point(119, 120);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(101, 34);
            this.github.TabIndex = 15;
            this.github.Text = "Unowhy Tools\'s Github";
            this.github.UseVisualStyleBackColor = true;
            this.github.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(226, 120);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 34);
            this.update.TabIndex = 17;
            this.update.Text = "Check for update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button3_Click);
            // 
            // separator
            // 
            this.separator.AutoSize = true;
            this.separator.ForeColor = System.Drawing.Color.White;
            this.separator.Location = new System.Drawing.Point(1, 104);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(343, 13);
            this.separator.TabIndex = 18;
            this.separator.Text = "========================================================";
            // 
            // alogo
            // 
            this.alogo.Image = global::Unowhy_Tools.Properties.Resources.UT_Logo;
            this.alogo.Location = new System.Drawing.Point(12, 12);
            this.alogo.Name = "alogo";
            this.alogo.Size = new System.Drawing.Size(114, 41);
            this.alogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alogo.TabIndex = 19;
            this.alogo.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(342, 164);
            this.Controls.Add(this.alogo);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.update);
            this.Controls.Add(this.github);
            this.Controls.Add(this.website);
            this.Controls.Add(this.asty1001);
            this.Controls.Add(this.aver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.alogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aver;
        private System.Windows.Forms.Label asty1001;
        private System.Windows.Forms.Button website;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.PictureBox alogo;
    }
}