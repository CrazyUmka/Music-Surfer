using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;
using System.Xml;
using System.IO;

namespace Music_VK
{
    class LibVk
    {
        IDictionary<string, string> ht_API_METHODS = new Dictionary<string, string>();
        public LibVk(string id_user, string access_token)
        {
            //url базис для формирования запроса получения музыки
            string temp_url = "https://api.vk.com/method/audio.get.xml?owner_id=%uid_user&need_user=1&v=5.2&access_token=%token";
            temp_url = temp_url.Replace("%uid_user", id_user);
            temp_url = temp_url.Replace("%token", access_token);
            ht_API_METHODS.Add("audio.get", temp_url);
            //url базис для формирования запроса получения информации о пользовател
            temp_url = "https://api.vk.com/method/users.get.xml?&fields=photo_200&uid=%uid_user";
            temp_url = temp_url.Replace("%uid_user", id_user);
            ht_API_METHODS.Add("users.get", temp_url);
        }
        public Hashtable[] audio_get()
        {
            string xml_data_audio = GetMethodRequest(ht_API_METHODS["audio.get"]);
            Hashtable[] data_audio = xml_parse_audio(xml_data_audio);
            return data_audio;
        }

        public string user_get()
        {
            var data_user = GetMethodRequest(ht_API_METHODS["users.get"]);
            XmlReader reader = XmlReader.Create(new StringReader(data_user));
            reader.ReadToFollowing("photo_200");
            reader.Read();
            return reader.Value;
        }
        private string GetMethodRequest(string postUrl)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(postUrl);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            String sLine = objReader.ReadToEnd();
            return sLine;
        }

        private Hashtable[] xml_parse_audio(String xml_data)
        {
            XmlReader reader = XmlReader.Create(new StringReader(xml_data));
            //List<Hashtable> lAudioUser = new List<Hashtable>();
            int i = 0;
            string sTemp = "";
            // Create an XmlReader
            reader.ReadToFollowing("count");
            reader.Read();
            Hashtable[] dict_audio = new Hashtable[Convert.ToInt32(reader.Value)];
            reader.ReadToFollowing("name");
            reader.Read();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        sTemp = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        if (sTemp != "id" && sTemp != "owner_id")
                        {
                            if (dict_audio[i] == null)
                                dict_audio[i] = new Hashtable();
                            dict_audio[i].Add(sTemp, reader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "audio")
                        {
                            i++;
                        }
                        break;
                }
            }
            return dict_audio;
        }
    }
}
