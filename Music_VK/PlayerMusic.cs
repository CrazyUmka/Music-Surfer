using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Media;

namespace Music_VK
{
    class PlayerMusic
    {
        Hashtable[] audio_vk;
        int move_music_list = 0;
        public PlayerMusic(Hashtable[] data_audio)
        {
            audio_vk = data_audio;
        }
        private string create_time_remain()
        {
            int minute = 0;
            int seconds = 0;
            int time_remain = Convert.ToInt32(audio_vk[move_music_list]["duration"]);
            for (int i = 0; i < time_remain; i++)
            {
                if (time_remain > 60)
                    minute++;
                else
                { break; }
                time_remain -= 60;
            }
            minute *= -1;
            seconds = time_remain;
            return (minute.ToString() + "." + time_remain);
        }

        public bool play(bool bRepeat, int index_song)
        {
            Player.GetPlayer().Open(audio_vk[index_song]["url"].ToString());
            if (Player.GetPlayer().IsOpen() == true)
            {
                Player.GetPlayer().Play(bRepeat);
                return true;
            }
            else
                return false;

        }
        public void stop()
        {
            if (Player.GetPlayer().IsPlaying() == true)
            {
                Player.GetPlayer().Pause();
                Player.GetPlayer().Close();
            }
            else if (Player.GetPlayer().IsOpen() == true)
            {
                Player.GetPlayer().Close();
            }
        }
        public void repeat_song(bool bRepeat)
        {
            Player.GetPlayer().Play(bRepeat);
        }
        public bool pause(bool bRepeat)
        {
            if (Player.GetPlayer().IsPlaying() == true)
            {
                Player.GetPlayer().Pause();
                return true;
            }
            else
            {
                Player.GetPlayer().Play(bRepeat);
                return false;
            }
        }
    }
}
