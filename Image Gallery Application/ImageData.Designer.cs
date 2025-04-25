namespace Image_Gallery_Application
{
    partial class ImageData
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageDetailsDataSet = new Image_Gallery_Application.ImageDetailsDataSet();
            this.imageDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageDetailsTableAdapter = new Image_Gallery_Application.ImageDetailsDataSetTableAdapters.ImageDetailsTableAdapter();
            this.imageTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUploadedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblsubTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOtherView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageTagDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn,
            this.dateUploadedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imageDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(107, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageDetailsDataSet
            // 
            this.imageDetailsDataSet.DataSetName = "ImageDetailsDataSet";
            this.imageDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageDetailsBindingSource
            // 
            this.imageDetailsBindingSource.DataMember = "ImageDetails";
            this.imageDetailsBindingSource.DataSource = this.imageDetailsDataSet;
            // 
            // imageDetailsTableAdapter
            // 
            this.imageDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // imageTagDataGridViewTextBoxColumn
            // 
            this.imageTagDataGridViewTextBoxColumn.DataPropertyName = "Image Tag";
            this.imageTagDataGridViewTextBoxColumn.HeaderText = "Image Tag";
            this.imageTagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageTagDataGridViewTextBoxColumn.Name = "imageTagDataGridViewTextBoxColumn";
            this.imageTagDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "Image Name";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "Image Name";
            this.imageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateUploadedDataGridViewTextBoxColumn
            // 
            this.dateUploadedDataGridViewTextBoxColumn.DataPropertyName = "Date Uploaded";
            this.dateUploadedDataGridViewTextBoxColumn.HeaderText = "Date Uploaded";
            this.dateUploadedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateUploadedDataGridViewTextBoxColumn.Name = "dateUploadedDataGridViewTextBoxColumn";
            this.dateUploadedDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(250, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Image Details";
            // 
            // lblsubTitle
            // 
            this.lblsubTitle.AutoSize = true;
            this.lblsubTitle.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubTitle.Location = new System.Drawing.Point(300, 93);
            this.lblsubTitle.Name = "lblsubTitle";
            this.lblsubTitle.Size = new System.Drawing.Size(166, 24);
            this.lblsubTitle.TabIndex = 2;
            this.lblsubTitle.Text = "(Database View)";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(475, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOtherView
            // 
            this.btnOtherView.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherView.Location = new System.Drawing.Point(155, 357);
            this.btnOtherView.Name = "btnOtherView";
            this.btnOtherView.Size = new System.Drawing.Size(208, 39);
            this.btnOtherView.TabIndex = 4;
            this.btnOtherView.Text = "Detailed View";
            this.btnOtherView.UseVisualStyleBackColor = true;
            this.btnOtherView.Click += new System.EventHandler(this.btnOtherView_Click);
            // 
            // ImageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtherView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblsubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ImageData";
            this.Text = "ImageData";
            this.Load += new System.EventHandler(this.ImageData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ImageDetailsDataSet imageDetailsDataSet;
        private System.Windows.Forms.BindingSource imageDetailsBindingSource;
        private ImageDetailsDataSetTableAdapters.ImageDetailsTableAdapter imageDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUploadedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblsubTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOtherView;
    }
}