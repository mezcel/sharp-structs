using System; // console

namespace sharp_structs {

    class Program {

        static void Main(string[] args) {
            Console.Clear();    // clear console

            Console.WriteLine("## sharp-structs\n");

            MyFunctions.GetOsInfo();    // display OS info
            MyFunctions.CsvToStructs(); // import csv files into a struct ER DB

            // demo ER Class
            int i = 0;
            foreach( MyStructs.bead_t bead in ERClass.bead_dbArray ) {
                Console.WriteLine("ERClass.bead_dbArray[ " + i + " ].beadID = " + ERClass.bead_dbArray[i].beadID + "\tERClass.bead_dbArray[ " + i + " ].beadType = " + ERClass.bead_dbArray[i].beadType );
                i++;
            }

            Console.WriteLine("");

            int noFields;

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "rosaryBead.csv" ) ) ;
            Console.WriteLine( "ERClass.rosaryBead_dbArray.Length\t" + ERClass.rosaryBead_dbArray.Length + "\tnoFields " + noFields);

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "bead.csv" ) ) ;
            Console.WriteLine( "ERClass.bead_dbArray.Length\t\t" + ERClass.bead_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "book.csv" ) ) ;
            Console.WriteLine( "ERClass.book_dbArray.Length\t\t" + ERClass.book_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "decade.csv" ) ) ;
            Console.WriteLine( "ERClass.decade_dbArray.Length\t\t" + ERClass.decade_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "message.csv" ) ) ;
            Console.WriteLine( "ERClass.message_dbArray.Length\t\t" + ERClass.message_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "mystery.csv" ) ) ;
            Console.WriteLine( "ERClass.mystery_dbArray.Length\t\t" + ERClass.mystery_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "prayer.csv" ) ) ;
            Console.WriteLine( "ERClass.prayer_dbArray.Length\t\t" + ERClass.prayer_dbArray.Length + "\tnoFields " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "scripture.csv" ) ) ;
            Console.WriteLine( "ERClass.scripture_dbArray.Length\t" + ERClass.scripture_dbArray.Length + "\tnoFields " + noFields );

            Console.WriteLine( "" );

            DateTime today = DateTime.Now;
            Console.WriteLine( "The day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t" + today.ToString("dddd, dd MMMM yyyy") );

            string todaysMystery = RosaryMethods.TodaysMysteryName();
            Console.WriteLine( "\tMystery of the day: " + todaysMystery );


        }
    }
}
