using System;

namespace Room_Library
{
    public class Room
    {
        private double roomLength;

        private double roomWidth;

        public double RoomLength
        {
            get
            {
                return roomLength;
            }
            set
            {
                roomLength = value;
            }
        }

        public double RoomWidth
        {
            get
            {
                return roomWidth;
            }
            set
            {
                roomWidth = value;
            }
        }

        public double RoomPerimetr()
        {
            return 2.0 * (roomLength + roomWidth);
        }

        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        public double PersonArea(int np)
        {
            return RoomArea() / (double)np;
        }

        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }

    public class LivingRoom : Room
        {
            private int numWin;

            public int NumWin
            {
                get
                {
                    return numWin;
                }
                set
                {
                    numWin = value;
                }
            }

            public override string Info()
            {
                return "Жилая комната площадью " + RoomArea() + " кв.м, с " + numWin + " окнами";
            }

    }

    public class Office : Room
    {
        private int numSockets;

        public int NumSockets
        {
            get
            {
                return numSockets;
            }
            set
            {
                numSockets = value;
            }
        }

        public int NumWorkplaces()
        {
            int val = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, val);
        }

        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
