using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery_Application
{
    public partial class MainForm : Form
    {
        public Dictionary<string, PhotoInfo> photoList = new Dictionary<string, PhotoInfo>();
        private List<Image> imageName = new List<Image>();
        private string[] fileType = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

        public void getPhotoData()
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (openFileDialog.FileName.ToLower().Contains(fileType[0]) ||
                    openFileDialog.FileName.ToLower().Contains(fileType[1]) ||
                    openFileDialog.FileName.ToLower().Contains(fileType[2]) ||
                    openFileDialog.FileName.ToLower().Contains(fileType[3]) ||
                    openFileDialog.FileName.ToLower().Contains(fileType[4]))
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    PhotoInfo photoInfo = new PhotoInfo(fileName, date);
                    photoList.Add(setTag(),photoInfo);
                    imageName.Add(Image.FromFile(openFileDialog.FileName)); 
                    lbImages.Items.Add(photoList.Last().Key);
                }
                else
                {
                    MessageBox.Show("Please select a valid image file.");
                }
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }

        public string setTag()
        {
            var tagForm = new TagForm();
            tagForm.ShowDialog();
            return tagForm.tbTag.Text;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            getPhotoData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbImageTitle.Text = lbImages.SelectedItem.ToString();
            pbImage.Image = imageName[lbImages.SelectedIndex];
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int index = lbImages.SelectedIndex;
            var displayForm = new ImageInfo();

            displayForm.lblTags.Text = photoList.ElementAt(index).Key;
            displayForm.lblDate.Text = photoList.ElementAt(index).Value.Date;
            displayForm.lblFileName.Text = photoList.ElementAt(index).Value.FileName;

            displayForm.ShowDialog();
        }
    }
}
