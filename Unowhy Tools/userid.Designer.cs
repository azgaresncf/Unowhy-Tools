﻿
namespace Unowhy_Tools
{
    partial class userid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userid));
            this.lab = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.ForeColor = System.Drawing.Color.White;
            this.lab.Location = new System.Drawing.Point(9, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(121, 13);
            this.lab.TabIndex = 0;
            this.lab.Text = "The new account ID is :";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Black;
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(12, 25);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(223, 20);
            this.id.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(168, 56);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Unowhy_Tools.Properties.Resources.yes;
            this.pictureBox1.Location = new System.Drawing.Point(143, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(247, 82);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lab);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User ID";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}