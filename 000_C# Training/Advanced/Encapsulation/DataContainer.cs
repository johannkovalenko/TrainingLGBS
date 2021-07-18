using System;
using System.Collections.Generic;

namespace MyProject
{
    public class DataContainer
    {
        private List<int> myList;

        public int MyListCount
        { 
            get {return myList.Count;}
        }
        
        public DataContainer(List<int> myList)
        {
            this.myList = myList;
        }
    }
}