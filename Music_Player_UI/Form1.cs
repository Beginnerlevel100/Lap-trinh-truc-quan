using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            recent1.BringToFront();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            player1.BringToFront();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider3_ValueChanged(object sender, EventArgs e)
        {
            bunifuSlider3.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            bunifuSlider3.MaximumValue = (int)axWindowsMediaPlayer1.currentMedia.duration;
        }
    
        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.URL = paths[PlayList.SelectedIndex];
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

        }

        private void recent1_Load(object sender, EventArgs e)
        {

        }

        private void player1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            recently_viewed1.BringToFront();
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            if(PlayList.SelectedIndex<PlayList.Items.Count-1)
            {
                PlayList.SelectedIndex = PlayList.SelectedIndex + 1; //Chuyển sang bài hát tiếp theo
            }
        }

        private void bunifuImageButton8_Click_1(object sender, EventArgs e)
        {
            if(PlayList.SelectedIndex>0)
            {
                PlayList.SelectedIndex = PlayList.SelectedIndex - 1; //Lùi lại 1 bài hát
            }
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e) 
        {
            bunifuCustomLabel4.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            bunifuCustomLabel5.Text = axWindowsMediaPlayer1.currentMedia.durationString;
        }
        String[] paths, files;
        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            //Chọn nhạc
            OpenFileDialog List = new OpenFileDialog();
            List.Multiselect = true;
            if (List.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = List.SafeFileNames;// Lưu tên bài nhạc vào trong mảng files
                paths = List.FileNames; //Lưu đường dẫn nhạc vào mảng paths
                //Hiển thị tên nhạc trong PlayList
                for (int i = 0; i < files.Length; i++)
                {
                    PlayList.Items.Add(files[i]);
                }
            }
        }
    }
}
