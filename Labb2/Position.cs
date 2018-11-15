using System;
namespace Labb2
{
    public class Position
    {
        private int x;
        private int y;

        public int XCoordinate
        {
            get => x; 
            set => x = value < 0 ? 0 : value; 
        }

        public int YCoordinate
        {
            get => y; 
            set => y = value < 0 ? 0 : value;
        }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;

        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(XCoordinate, 2) + Math.Pow(YCoordinate, 2));
        }

        public bool Equals(Position p)
        {
            return p.XCoordinate == XCoordinate && p.YCoordinate == YCoordinate;
        }

        public Position Clone()
        {
            return new Position(XCoordinate, YCoordinate);
        }

        public override string ToString()
        {
            return "(" + XCoordinate + "," + YCoordinate + ")";
        }

        public static bool operator >(Position p1, Position p2)
        {
            return Math.Abs(p1.Length() - p2.Length()) < 0.001 ? p1.XCoordinate > p2.XCoordinate : p1.Length() > p2.Length();
        }

        public static bool operator <(Position p1, Position p2)
        {
            //return Math.Abs(p1.Length() - p2.Length()) < 0.001 ? p1.XCoordinate < p2.XCoordinate : p1.Length() < p2.Length();
            return !(p1 > p2);
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.XCoordinate + p2.XCoordinate, p1.YCoordinate + p2.YCoordinate);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.XCoordinate - p2.XCoordinate, p1.YCoordinate - p2.YCoordinate);
        }

        public static double operator %(Position p1, Position p2)
        {
            return Math.Sqrt(Math.Pow(p1.XCoordinate - p2.XCoordinate, 2) + Math.Pow(p1.YCoordinate - p2.YCoordinate, 2));
        }

    }
}
