using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMPLE_MUSIC_PLAYER
{
    public partial class MasterWindow : Form
    {
        public MasterWindow()
        {
            InitializeComponent();
        }

        string[] trackName, trackUrl;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true; 

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                trackName = ofd.SafeFileNames;
                trackUrl = ofd.FileNames;

                for(int i = 0; i < trackName.Length; i++)
                {
                    listBox1.Items.Add(trackName[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //(listBox1.SelectedIndex < trackUrl.Length)
            {
                axWindowsMediaPlayer1.URL = trackUrl[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch
            {

            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
