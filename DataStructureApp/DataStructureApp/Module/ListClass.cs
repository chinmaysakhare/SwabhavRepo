using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructureApp.Module
{
    class ListClass
    {
        public ArrayList aList = new ArrayList();
        public void CreateaList(string e)
        { 
            aList.Add(e);            
        }
        public void UpdateaList(String e,int ind)
        {
            aList[ind] = e;
        }
    
        public void RemoveFromList(int a)
        {
            aList.RemoveAt(a);
        }
    }
}
