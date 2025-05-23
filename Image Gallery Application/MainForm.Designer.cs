﻿namespace Image_Gallery_Application
{
    partial class MainForm
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
            this.gbImageTitle = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbImageTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbImageTitle
            // 
            this.gbImageTitle.Controls.Add(this.pbImage);
            this.gbImageTitle.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImageTitle.Location = new System.Drawing.Point(20, 53);
            this.gbImageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.gbImageTitle.Name = "gbImageTitle";
            this.gbImageTitle.Padding = new System.Windows.Forms.Padding(4);
            this.gbImageTitle.Size = new System.Drawing.Size(548, 350);
            this.gbImageTitle.TabIndex = 2;
            this.gbImageTitle.TabStop = false;
            this.gbImageTitle.Text = "Blank";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Enabled = false;
            this.pbImage.Location = new System.Drawing.Point(8, 23);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(531, 308);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(229, 430);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 52);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(92, 430);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(129, 52);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnOrganize
            // 
            this.btnOrganize.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganize.Location = new System.Drawing.Point(367, 430);
            this.btnOrganize.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrganize.Name = "btnOrganize";
            this.btnOrganize.Size = new System.Drawing.Size(129, 52);
            this.btnOrganize.TabIndex = 4;
            this.btnOrganize.Text = "Organize";
            this.btnOrganize.UseVisualStyleBackColor = true;
            this.btnOrganize.Click += new System.EventHandler(this.btnOrganize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(633, 430);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbImages);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(576, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(253, 350);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image List";
            // 
            // lbImages
            // 
            this.lbImages.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImages.FormattingEnabled = true;
            this.lbImages.ItemHeight = 14;
            this.lbImages.Location = new System.Drawing.Point(8, 23);
            this.lbImages.Margin = new System.Windows.Forms.Padding(4);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(236, 298);
            this.lbImages.TabIndex = 0;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image Gallery";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrganize);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.gbImageTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Image Gallery Application";
            this.gbImageTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbImageTitle;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
    }
}

