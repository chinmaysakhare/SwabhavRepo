using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace JukeBoxApp.Module
{
    class JukeBox
    {
        public string filePath = @"E:\Swabhav\C#\OOP\JukeBoxApp\Songs.txt";
        public ArrayList songs = new ArrayList();
        public int temp = 30;
        public int[] songCount = new int[15];
        public string[] songString = new string[15];
        int count = 0;
        public void GetSongs()
        {
            List<string> lines = System.IO.File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                songs.Add(line);
            }
            songs.Sort();
            for (int i = 0; i <= songs.Count; i++)
            {
                songString[i] = (string)songs[i]; 
            }
            GetSongCount();
        }

        public void GetSongCount()
        {
            foreach (var line in songs)
            {
                count++;
            }
            for (int i=0;i<count;i++)
            {
                songCount[i] = 0;
            }
        }
        public void PlaySong(int index)
        {
            songCount[index]++;
            for (int i = 0; i < songString.Length; i++)
            {
                
            }
        }




    }
}
