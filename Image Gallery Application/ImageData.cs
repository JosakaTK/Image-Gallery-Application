using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery_Application
{
    public partial class ImageData : Form
    {
        public ImageData()
        {
            InitializeComponent();
        }

        private void ImageData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageDetailsDataSet.ImageDetails' table. You can move, or remove it, as needed.
            this.imageDetailsTableAdapter.Fill(this.imageDetailsDataSet.ImageDetails);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
