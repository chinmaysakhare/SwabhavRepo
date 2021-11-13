using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JukeBoxApp
{
    class Demo
    {
        public static void Main(string[] args)
        {
            IDictionary<String, int> songList = new Dictionary<string, int>();
            songList = null;
            string filePath = @"E:\Swabhav\C#\OOP\JukeBoxApp\Songs.txt";
            List<string> song = File.ReadAllLines(filePath).ToList();
            song.Sort();
            string []songString = new string[5];
            for (int i = 0; i < song.Count; i++)
            {
                songString[i] = (string)song[i];
            }
            for (int i = 0; i < songString.Length; i++)
            {
                songList.Add(songString[i], 0);
            }
            foreach (KeyValuePair<string, int> ed in songList)
            {
                Console.WriteLine("Song : \n"+ed.Key+"\t No. of times song  was played : "+ed.Value);
            }
            DisplayOnlySong(songList);
            Console.ReadLine();
            
        }
        public static void DisplayOnlySong(IDictionary<string, int> songList)
        {
            foreach (KeyValuePair<string, int> ed in songList)
            {
                Console.WriteLine("Song : " + ed.Key);
            }
            Console.WriteLine(" Select a Song");
            int opt = Convert.ToInt32(Console.ReadLine());
            opt--;
            string temp = songList.Keys.ElementAt(opt);
            int temp1 = songList.Values.ElementAt(opt);
            temp1++;
            songList[temp] = temp1;
            foreach (KeyValuePair<string, int> ed in songList)
            {
                Console.WriteLine("Song : " + ed.Key+" "+ed.Value);
            }


        }

    }
}
