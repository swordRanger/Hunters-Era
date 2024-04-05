/*
 * Object pooling copied from ChatGPT.
 * I didn't even know it exists +_+
 */

using System.Media;
using System.Collections.Generic;

namespace SoundTracks
{
    public static class SoundPlayerPool
    {
        private static Queue<SoundPlayer> soundPlayerPool = new Queue<SoundPlayer>();

        //Initialize the pool
        /*static SoundPlayer;*/
    }

    //Class containing all music used in the game.
    public class GameMusic
    {
        static string startMusic = "SoundTracks\\welcomeSound.wav";
        static string keyPressSound = "SoundTracks\\clickSound.wav";

        SoundPlayer launcherMusic = new SoundPlayer(startMusic);
        SoundPlayer keyPress = new SoundPlayer(keyPressSound);

        public void LauncherMusic()
        {
            launcherMusic.Play(); //Play music on launch
            launcherMusic.Dispose();
        }

        public void KeyPress()
        {
           
        }
    }
}