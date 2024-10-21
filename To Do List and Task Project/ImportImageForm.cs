using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_and_Task_Project
{
    public partial class ImportImageForm : Form
    {
        public ImportImageForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportImageForm_Load(object sender, EventArgs e)
        {
            commonClickPictureBox.ImageLocation = "images/image1.png";
            pictureBox2.ImageLocation = "images/image2.png";
            pictureBox3.ImageLocation = "images/image3.png";
            pictureBox4.ImageLocation = "images/image4.png";
            pictureBox5.ImageLocation = "images/image5.png";
            pictureBox6.ImageLocation = "images/image6.png";
            pictureBox7.ImageLocation = "images/image7.png";
            pictureBox8.ImageLocation = "images/image8.png";
            pictureBox9.ImageLocation = "images/image9.png";
        }

        private void commonClickPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;  //found out how to link multiple controls to one event handler through this video by Code Synergy: https://www.youtube.com/watch?v=sth1b2BYpJU
            global.filepath = ((PictureBox)sender).ImageLocation;
            Close();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";   //filter for images found here, post made by HermF: https://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            openFileDialog.ShowDialog();
            global.filepath = openFileDialog.FileName;
            this.Close();

        }
    }
}
