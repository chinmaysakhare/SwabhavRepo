using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace JukeBoxApp.Module
{
    class JukeBoxTest
    {
        //static void Main(string[] args)
        
    }
}
/*
        {
            JukeBox obj = new JukeBox();
            obj.GetSongs();
            MainMenu();
            
            
            Console.ReadLine();
        }
        public static void MainMenu()
        {
            
            JukeBox obj = new JukeBox();
            obj.GetSongs();
            Console.WriteLine("\t\t\t\t\t JukeBox App");
            Console.WriteLine(" 1. Play a Song");
            Console.WriteLine(" 2. Display Song Frequency");
            Console.WriteLine(" 3. Most Popular Song ");
            Console.WriteLine(" 4. Exit");
            const int PLAYSONG = 1;
            const int DISPLAYSONGFREQ= 2;
            const int DISPLAYMOSTPOPULAR = 3;
            const int EXIT = 4;
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case PLAYSONG:
                    DisplaySong();
                    Console.Write(" \n\n Please select a song  : ");
                    int songSelect = Convert.ToInt32(Console.ReadLine());
                    songSelect--;
                    obj.PlaySong(songSelect);
                    Console.WriteLine("\n You Played : " + obj.songs[songSelect]);
                    Console.WriteLine(" Want to play a song the same song or other song again?\n Press 'y' for Yes or 'n' to go to Main menu ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                        Console.WriteLine(" Select a Song ");
                        songSelect = Convert.ToInt32(Console.ReadLine());
                        songSelect--;
                        obj.PlaySong(songSelect); 
                    }
                    else
                        MainMenu();
                    break;
                case DISPLAYSONGFREQ:
                    for (int i = 0; i < obj.songs.Count; i++)
                    {
                        Console.WriteLine(" "+obj.songs[i]+" was played "+obj.songCount[i]+" times");
                    }
                    Console.WriteLine(" Press any key to goto Main menu");
                    Console.ReadLine();
                    MainMenu();
                    break;
                case DISPLAYMOSTPOPULAR:
                    int index = obj.PopularSong();
                    Console.WriteLine(" Most Popular Song was : "+obj.songs[index]);
                    Console.WriteLine(" It was played " + obj.songCount[index] + " times");
                    Console.WriteLine("\n\n Press any key to goto main menu ");
                    Console.ReadLine();
                    MainMenu();
                    break;
                case EXIT:
                    Console.WriteLine("\n\n\n\n\t\t\t Thankyou for using this APP\n\t\t\t Press any key to exit ");
                    Console.ReadLine();
                    break;
            }
        }
        public static void DisplaySong()
        {

            JukeBox obj = new JukeBox();
            obj.GetSongs();
            Console.WriteLine("\t\t\t\t List of Songs");
            for (int i=0;i<obj.songs.Count;i++)
            {
                Console.WriteLine(" "+(i+1)+" "+obj.songs[i]);
            }
        }*/

