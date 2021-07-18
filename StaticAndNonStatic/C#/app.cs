using System;
using System.Collections.Generic;

static class App
{
    static void Main() 
    {
        var myList = new List<List<Point>>();

        Add(myList);
        Loop(myList);
    }

    private static void Add(List<List<Point>> myList) 
    {
        for (int i=0; i<3; i++) 
        {
            var tempList = new List<Point>();

            for (int j=0; j<3; j++) 
            {
                var point = new Point(i, j);
                tempList.Add(point);

                tempList.Add(new Point(i * 10, j * 10));           
            }
            myList.Add(tempList);
        }
    }

    private static void Loop(List<List<Point>> myList) 
    {
        for (int i=0; i<myList.Count; i++)
            for (int j=0; j<myList[i].Count; j++) 
            {
                Console.Write(myList[i][j].x + " ");
                Console.WriteLine(myList[i][j].y);
            }        
    }

    private class Point 
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}