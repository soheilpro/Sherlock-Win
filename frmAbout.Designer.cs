using System;

namespace Sherlock {
    partial class frmAbout {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblSherlock = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.picKeys = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblRights = new System.Windows.Forms.Label();
            this.lnlWebSite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSherlock
            // 
            this.lblSherlock.AutoSize = true;
            this.lblSherlock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSherlock.Location = new System.Drawing.Point(66, 30);
            this.lblSherlock.Name = "lblSherlock";
            this.lblSherlock.Size = new System.Drawing.Size(56, 13);
            this.lblSherlock.TabIndex = 0;
            this.lblSherlock.Text = "Sherlock";
            // 
            // lblSeparator
            // 
            this.lblSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(7, 171);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(303, 2);
            this.lblSeparator.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(235, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "O&K";
            // 
            // picKeys
            // 
            this.picKeys.Image = ((System.Drawing.Image)(resources.GetObject("picKeys.Image")));
            this.picKeys.Location = new System.Drawing.Point(12, 12);
            this.picKeys.Name = "picKeys";
            this.picKeys.Size = new System.Drawing.Size(48, 48);
            this.picKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picKeys.TabIndex = 0;
            this.picKeys.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(66, 47);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(65, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: {0}";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(66, 81);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(181, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright 2004-2013 Soheil Rashidi.";
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Location = new System.Drawing.Point(66, 99);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(104, 13);
            this.lblRights.TabIndex = 3;
            this.lblRights.Text = "All Rights Reserved.";
            // 
            // lnlWebSite
            // 
            this.lnlWebSite.AutoSize = true;
            this.lnlWebSite.Location = new System.Drawing.Point(66, 131);
            this.lnlWebSite.Name = "lnlWebSite";
            this.lnlWebSite.Size = new System.Drawing.Size(205, 13);
            this.lnlWebSite.TabIndex = 6;
            this.lnlWebSite.TabStop = true;
            this.lnlWebSite.Text = "http://github.com/soheilpro/Sherlock-Win";
            this.lnlWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlWebSite_LinkClicked);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(316, 212);
            this.Controls.Add(this.lnlWebSite);
            this.Controls.Add(this.lblRights);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSherlock);
            this.Controls.Add(this.picKeys);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sherlock";
            ((System.ComponentModel.ISupportInitialize)(this.picKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picKeys;
        private System.Windows.Forms.Label lblSherlock;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.LinkLabel lnlWebSite;
    }
}