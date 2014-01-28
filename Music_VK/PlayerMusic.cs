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
        private Hashtable[] audio_vk;
        public PlayerMusic(Hashtable[] data_audio)
        {
            audio_vk = data_audio;
        }

        public string duration_song(int index_song)
        {
            return audio_vk[index_song]["duration"].ToString();
        }

        public object url_song(int index_song)
        {
            return audio_vk[index_song]["url"];
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

        public bool Playing_Song()
        {
            return Player.GetPlayer().IsPlaying();
        }
    }
}
