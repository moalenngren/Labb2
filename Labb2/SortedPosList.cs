using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb2
{
    public class SortedPosList
    {

        List<Position> PositionList = new List<Position>();

        public SortedPosList()
        {
        }

        public override string ToString()
        {
            return string.Join(", ", PositionList);
        }

        public int Count()
        {
            return PositionList.Count;  
        }

        public void Add(Position pos)
        {
            PositionList.Add(pos);
            PositionList = PositionList.OrderBy(o => o.Length()).ToList();
        }

        public bool Remove(Position pos)
        {
            if (PositionList.Contains(pos))
            {
                PositionList.Remove(pos);
                return true;
            }
            return false;
            
        }

        public SortedPosList Clone()
        {

            SortedPosList copy = new SortedPosList();

            foreach (Position pos in PositionList)
            {
                copy.PositionList.Add(pos.Clone());
            }
            return copy;
        }

        public SortedPosList CircleContent(Position centerPos, double radius)
        {

            SortedPosList copy = new SortedPosList();

            foreach (Position pos in PositionList)
            {

                if (Math.Sqrt(Math.Pow(centerPos.XCoordinate - pos.XCoordinate, 2) + Math.Pow(centerPos.YCoordinate - pos.YCoordinate, 2)) < radius)
                {
                    copy.PositionList.Add(pos.Clone());
                }
            }
            return copy;

        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList copy = sp1.Clone();

            foreach (Position pos in sp2.PositionList)
            {
                copy.Add(pos);
            }
            return copy;
        }

        public Position this[int index]
        {
            get
            {
                return PositionList[index];
            }
        }

        public static SortedPosList operator *(SortedPosList listA, SortedPosList listB)
        {

        SortedPosList copy = listA.Clone();
            foreach (Position pos1 in listA.PositionList) 
            {
                foreach(Position pos2 in listB.PositionList)
                {
                    if (pos1 == pos2)
                    {
                        copy.PositionList.Remove(pos1);
                    }
                }
            }
        return copy;
        }
    }
}
