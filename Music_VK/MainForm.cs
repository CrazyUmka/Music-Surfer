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
using System.Net;
using System.IO;

namespace Music_VK
{
    public partial class MainForm : Form
    {
        #region Fields
        PlayerMusic music_vk;
        bool bRepeat = false;
        bool bMixPlay = false;
        private int seconds = 0;
        private int minute = 0;
        private int iTimePassed = 0;
        string folder_path = @"D:\Temp_Library\";
        #endregion

        #region Init Form
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Forms
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIconMainForm.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIconMainForm.Visible = false;
        }
        #endregion

        #region My_Func

        private void clean_data()
        {
            minute = 0;
            seconds = 0;
            timerTrack.Stop();
            music_vk.stop();
            progressBarTrack.Value = 0;
            iTimePassed = 0;
            labelTimeTrack.Text = "00.00";
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

        private string correct_file_rec(string name_file)
        {
            if(name_file.IndexOf("?") != -1)
                name_file = name_file.Replace("?", "");
            if (name_file.IndexOf("/") != -1)
                name_file = name_file.Replace("/", "-");
            if (name_file.IndexOf('"') != -1)
                name_file = name_file.Replace('"', ' ');
            return name_file;
        }

        private void download_music(string name_song, string url)
        {
            var filename = correct_file_rec(folder_path + name_song + ".mp3");
            // Делаем загрузку с помощью System.Net.WebClient.
            var webClient = new WebClient();
            var beforeProgress = 0; // счетчик прогресса

            // подписываемся на событие изменения прогресса, чтобы выводить на экран
            webClient.DownloadProgressChanged += (s, e) =>
               {
                   // ну и выводим соответственно через каждые 10%
                   if (e.ProgressPercentage - 10 > beforeProgress)
                   {
                       beforeProgress += 10;
                   }
               };

            // подписываемся на событие окончания загрузки, чтобы знать когда загрузка закончится
            webClient.DownloadFileCompleted += (s, e) =>
            {
                toolStripProgressBar1.Value += 1;
                notifyIconMainForm.BalloonTipTitle = "Status Download: " + toolStripProgressBar1.Value.ToString() + "/" + toolStripProgressBar1.Maximum.ToString();
                notifyIconMainForm.BalloonTipText = "File downloaded";
                notifyIconMainForm.ShowBalloonTip(1000);
            };

            // запускаем загрузку асинхронно.
            webClient.DownloadFileAsync(new Uri(url), filename);
        }

        private void init_song()
        {
            bool status_player;
            int index_song;

            if (listPlaylistView.FocusedItem.Text.Length > 35)
                labelNameTrack.Text = listPlaylistView.FocusedItem.Text.Substring(0, 35) + "...";
            else
                labelNameTrack.Text = listPlaylistView.FocusedItem.Text;
            index_song = listPlaylistView.FocusedItem.Index;
            progressBarTrack.Maximum = Convert.ToInt32(music_vk.duration_song(index_song));
            status_player = music_vk.play(bRepeat, index_song);
            if (status_player == true)
                timerTrack.Start();
        }

        #endregion

        #region Elements Form
        private void listPlaylistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            clean_data();
            music_vk.stop();

            if (listPlaylistView.FocusedItem != null)
            {
                init_song();
            }
        }

        private void timerTrack_Tick(object sender, EventArgs e)
        {
            iTimePassed++;
            if (progressBarTrack.Value < progressBarTrack.Maximum)
            {
                forming_time_passed();
                progressBarTrack.Value = iTimePassed;
            }
            if (music_vk.Playing_Song() == false)
            {
                clean_data();
                listPlaylistView.FocusedItem = listPlaylistView.Items[listPlaylistView.FocusedItem.Index + 1];
                listPlaylistView.FocusedItem.Selected = true;
                init_song();
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

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            clean_data();
            if (listPlaylistView.FocusedItem.Index + 1 != listPlaylistView.Items.Count - 1)
                listPlaylistView.FocusedItem = listPlaylistView.Items[listPlaylistView.FocusedItem.Index + 1];
            else
                listPlaylistView.FocusedItem = listPlaylistView.Items[0];
            listPlaylistView.FocusedItem.Selected = true;
            init_song();
        }

        private void pictureBoxPrev_Click(object sender, EventArgs e)
        {
            clean_data();
            if (listPlaylistView.FocusedItem.Index - 1 != -1)
                listPlaylistView.FocusedItem = listPlaylistView.Items[listPlaylistView.FocusedItem.Index - 1];
            else
                listPlaylistView.FocusedItem = listPlaylistView.Items[listPlaylistView.Items.Count - 1];
            listPlaylistView.FocusedItem.Selected = true;
            init_song();
        }

        private void pictureBoxRepeat_Click(object sender, EventArgs e)
        {
            if (bRepeat == false)
            {
                bRepeat = true;
                notifyIconMainForm.BalloonTipText = "Repeat ON";
            }
            else
            {
                bRepeat = false;
                notifyIconMainForm.BalloonTipText = "Repeat OFF";
            }
            music_vk.repeat_song(bRepeat);
            notifyIconMainForm.ShowBalloonTip(1000);
        }

        private void pictureBoxMix_Click(object sender, EventArgs e)
        {
            if (bMixPlay == false)
                bMixPlay = true;
            else
                bMixPlay = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count_download = 0;
            LibVk current_user_vk = new LibVk("21881340", "80d1ddbc6532da5ed954ae37a11c938ec8fe971b74b86a7bc72bd280985cb7d7fa4bda6a6bacde2eed557");
            var data_audio = current_user_vk.audio_get();
            music_vk = new PlayerMusic(data_audio);
            int number_element = 0;
            foreach (var element in data_audio)
            {
                if (element != null)
                {
                    number_element++;
                    string name_song = number_element.ToString() + ". " + element["artist"].ToString() + " - " + element["title"].ToString();
                    listPlaylistView.Items.Add(name_song);
                    if (File.Exists(correct_file_rec(folder_path + name_song + ".mp3")) == true)
                        count_download++;

                }
            }
            toolStripStatusLabelDownload.Text += " " + count_download.ToString() + "/" + number_element.ToString();
            number_element = 0;
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Maximum = listPlaylistView.CheckedItems.Count;
            for (int i = 0; i < listPlaylistView.CheckedItems.Count; i++)
            {
                string name = listPlaylistView.CheckedItems[i].Text;
                if (File.Exists(folder_path + name + ".mp3") == false)
                    download_music(name, music_vk.url_song(listPlaylistView.CheckedItems[i].Index).ToString());
                else
                {
                    toolStripProgressBar1.Value++;
                    notifyIconMainForm.BalloonTipText = "File " + name + " already exists in the directory";
                    notifyIconMainForm.ShowBalloonTip(1000);
                }
            }

        }
        #endregion

        #region Work Notification Icon
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            this.Activate();
        }
        #endregion
    }
}
