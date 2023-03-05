using System;

namespace clubMemberIndexer
{
   
    class Program
    {
        public const int Size = 15;  // global variable (not)
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                ClubType = "";
                ClubLocation = "";
                MeetingDate = "";
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = "";
                }
            }

            //indexer get and set methods
            public string this[int Size]
            {
                get => Members[Size];
                set => Members[Size] = value;
            }
        }
        static void Main(string[] args)
        {
            ClubMembers clubmem = new ClubMembers();
            clubmem[0] = "1";
            clubmem[1] = "2";
            clubmem[2] = "3";
            clubmem[3] = "4";
            clubmem[4] = "5";
            clubmem[5] = "6";
            clubmem[6] = "7";
            clubmem[7] = "8";
            clubmem[8] = "9";
            clubmem[9] = "10";
            clubmem[10] = "11";
            clubmem[11] = "12";
            clubmem[12] = "13";
            clubmem[13] = "14";
            clubmem[14] = "15";
            clubmem.ClubLocation = "location";
            clubmem.MeetingDate = "meetingdate";
            clubmem.ClubType = "clubtype";
            for (int i = 0; i < Size; i++)
            {
                    Console.WriteLine(clubmem[i]);
            }
            Console.WriteLine(clubmem.ClubLocation);
            Console.WriteLine(clubmem.ClubType);
            Console.WriteLine(clubmem.MeetingDate);
        }
    }
}