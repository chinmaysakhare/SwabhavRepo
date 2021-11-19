using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternSoln
{
    public class Folder:IStorageItem
    {
        private string _name;
        public List<IStorageItem> movieList = new List<IStorageItem>();

        public Folder(string name)
        {
            _name = name;
           
        }
        public void addItem(IStorageItem movie)
        {
            movieList.Add(movie);   
        }
        public void Display(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}   {1}",new string(' ',indentation),_name));
            foreach(var m in movieList)
            {
                m.Display(indentation+1);
            }
        }
    }
}       