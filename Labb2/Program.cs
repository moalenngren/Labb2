using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Creates two positions and uses + on them. Returns a new position with added values from both.
            Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");

            //Creates two positions and uses - on them. Returns a new position with subtracted values from both. Cannot be negative tho.
            Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");

            //Creates two positions and uses - on them. Returns a new position with subtracted values from both. Cannot be negative tho.
            Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");

            //Creates two positions and uses % on them. Returns the length between them.
            Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");

            SortedPosList list1 = new SortedPosList();
            SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));
            Console.WriteLine(list1 + "\n");
            list1.Remove(new Position(2, 6));
            Console.WriteLine(list1 + "\n");

            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            Console.WriteLine((list2 + list1) + "\n");

            SortedPosList circleList = new SortedPosList();
            circleList.Add(new Position(1, 1));
            circleList.Add(new Position(2, 2));
            circleList.Add(new Position(3, 3));
            Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");
            */

            /*
            SortedPosList list1 = new SortedPosList();
            SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));

            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));

            Console.WriteLine("List2" + list2);

            Console.WriteLine("List1 before circle: " + list1);
            SortedPosList s3 = list1.CircleContent(new Position(7, 5), 5);
            Console.WriteLine("List1 after circle: " + s3); */

            Position p1 = new Position(2, 4);
            Position p2 = new Position(4, 2);
            Console.WriteLine($"P1: {p1}");
            Console.WriteLine($"P2: {p2}");
            Console.WriteLine(p1.Length());
            Console.WriteLine(p1.Equals(p2));
            Position p3 = p2.Clone();
            Console.WriteLine($"P3: {p3}");
            Console.WriteLine(p1);
            Console.WriteLine(p1 > p2);
            Console.WriteLine(p1 < p2);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 % p2);


            SortedPosList sp1 = new SortedPosList();
            SortedPosList sp2 = new SortedPosList();
            sp1.Add(new Position(2, 4));
            sp1.Add(new Position(3, 5));
            sp1.Add(new Position(1, 5));
            sp1.Add(new Position(1, 1));
            sp2.Add(new Position(2, 2));
            sp2.Add(new Position(5, 5));
            sp1.Add(p1);
            Console.WriteLine(sp1.ToString());
            Console.WriteLine(sp1.Count());
            sp1.Remove(p1);
            Console.WriteLine(sp1);
            SortedPosList sp3 = sp1.Clone();
            Console.WriteLine(sp3);
            SortedPosList sp4 = sp1.CircleContent(new Position(5, 5), 4);
            Console.WriteLine(sp4);
            Console.WriteLine(sp1 + sp2);
            Console.WriteLine(sp1[1]);
            Console.WriteLine(sp1 * sp2);
        }
    }
}