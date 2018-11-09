using System;
namespace Labb2
{
    public class Position
    {
        public int XCoordinate { get; set; } //Får aldrig bli negativa
        public int YCoordinate { get; set; } //Får aldrig bli negativa

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;

        }

        public double Length()
        {
            //TODO - returnera avståndet till origo
            return 0;
        }

        public bool Equals(Position p)
        {
            return p.XCoordinate == XCoordinate && p.YCoordinate == YCoordinate ? true : false;
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
            return p1.Length() == p2.Length() ? p1.XCoordinate > p2.XCoordinate : p1.Length() > p2.Length();
        }

        public static bool operator <(Position p1, Position p2)
        {
            return p1.Length() == p2.Length() ? p1.XCoordinate < p2.XCoordinate : p1.Length() < p2.Length();
        }



    }
}
