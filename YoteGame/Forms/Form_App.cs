using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace YoteGame.Forms
{
    public class Form_App : Form
    {
        //private void Play_Sound()
        //{
        //    new WindowsMediaPlayer() { URL = "MyMusic.mp3",  }.controls.play();
        //    WindowsMediaPlayer player = new WindowsMediaPlayer();
        //    player.URL = Resources._5;
        //}

        public void PlayAudio()
        {
            SoundPlayer audio = new SoundPlayer(Resources.notification);
            audio.Play();
        }
    }
}
