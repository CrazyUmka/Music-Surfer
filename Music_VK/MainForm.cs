using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Music_VK
{
    public partial class MainForm : Form
    {
        private Hashtable[] data_audio;
        PlayerMusic music_vk;
        bool bRepeat = false;
        bool bMixPlay = false;
        private int seconds = 0;
        private int minute = 0;
        private int iTimePassed = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibVk current_user_vk = new LibVk("21881340", "80d1ddbc6532da5ed954ae37a11c938ec8fe971b74b86a7bc72bd280985cb7d7fa4bda6a6bacde2eed557");
            data_audio = current_user_vk.audio_get();
            music_vk = new PlayerMusic(data_audio);
            int number_element = 0;
            foreach(var element in data_audio)
            {
                if (element != null)
                {
                    number_element++;
                    listPlaylistView.Items.Add(number_element.ToString() + ". " + element["artist"].ToString() + " - " + element["title"].ToString());
                }
            }
            number_element = 0;
        }

        private void forming_time_passed()
        {
            seconds++;
            if (seconds == 60)
            {
                minute++;
                seconds = 0;
            }
            if (seconds <= 9)
                labelTimeTrack.Text = "0" + minute.ToString() + ".0" + seconds.ToString();
            else
                labelTimeTrack.Text = "0" + minute.ToString() + "." + seconds.ToString();
        }

        private void listPlaylistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool status_player;
            int index_song;

            minute = 0;
            seconds = 0;
            labelTimeTrack.Text = "00.00";
            iTimePassed = 0;
            progressBarTrack.Value = 0;
            timerTrack.Stop();
            music_vk.stop();

            if (listPlaylistView.FocusedItem.Text.Length > 35)
                labelNameTrack.Text = listPlaylistView.FocusedItem.Text.Substring(0, 40) + "...";
            else
                labelNameTrack.Text = listPlaylistView.FocusedItem.Text;
            index_song = listPlaylistView.FocusedItem.Index;
            progressBarTrack.Maximum = Convert.ToInt32(data_audio[index_song]["duration"]);
            status_player = music_vk.play(bRepeat, index_song);
            if (status_player == true)
                timerTrack.Start();
        }

        private void pictureBoxRepeat_Click(object sender, EventArgs e)
        {
            if (bRepeat == false)
                bRepeat = true;
            else
                bRepeat = false;
            music_vk.repeat_song(bRepeat);
        }

        private void pictureBoxMix_Click(object sender, EventArgs e)
        {
            if (bMixPlay == false)
                bMixPlay = true;
            else
                bMixPlay = false;
        }

        private void timerTrack_Tick(object sender, EventArgs e)
        {
            iTimePassed++;
            if (progressBarTrack.Value < progressBarTrack.Maximum)
            {
                forming_time_passed();
                progressBarTrack.Value = iTimePassed;
            }
            else
            {
                minute = 0;
                seconds = 0;
                timerTrack.Stop();
                progressBarTrack.Value = 0;
                iTimePassed = 0;
                labelTimeTrack.Text = "00.00";
            }
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            bool status_player = music_vk.pause(bRepeat);
            if (status_player == true)
                timerTrack.Stop();
            else
                timerTrack.Start();
        }
    }
}
