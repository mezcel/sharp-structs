using System; // console

namespace sharp_structs {

    class Program {

        static void DemoBeadER() {
            int i = 0;

            Console.WriteLine( "# Demo: Preview bead.csv ER class\n" );

            foreach( MyStructs.bead_t bead in ERClass.bead_dbArray ) {
                Console.WriteLine(" ERClass.bead_dbArray[ " + i + " ].beadID = " + ERClass.bead_dbArray[i].beadID + "\tERClass.bead_dbArray[ " + i + " ].beadType = " + ERClass.bead_dbArray[i].beadType );
                i++;
            }

        }

        static void DemoPreviewDB() {
            int noFields;

            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.WriteLine( " class array              \trecords\tfields" );
            Console.WriteLine( " -------------------------\t-------\t------" );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "rosaryBead.csv" ) ) ;
            Console.WriteLine( " ERClass.rosaryBead_dbArray\t" + ERClass.rosaryBead_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "bead.csv" ) ) ;
            Console.WriteLine( " ERClass.bead_dbArray\t\t" + ERClass.bead_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "book.csv" ) ) ;
            Console.WriteLine( " ERClass.book_dbArray\t\t" + ERClass.book_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "decade.csv" ) ) ;
            Console.WriteLine( " ERClass.decade_dbArray\t\t" + ERClass.decade_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "message.csv" ) ) ;
            Console.WriteLine( " ERClass.message_dbArray\t" + ERClass.message_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "mystery.csv" ) ) ;
            Console.WriteLine( " ERClass.mystery_dbArray\t" + ERClass.mystery_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "prayer.csv" ) ) ;
            Console.WriteLine( " ERClass.prayer_dbArray\t\t" + ERClass.prayer_dbArray.Length + "\t " + noFields );

            noFields = MyFunctions.FieldCount( MyFunctions.CsvFilePath ( "scripture.csv" ) ) ;
            Console.WriteLine( " ERClass.scripture_dbArray\t" + ERClass.scripture_dbArray.Length + "\t " + noFields );

        }

        static void DemoMysteryQuery() {
            DateTime today = DateTime.Now;

            Console.WriteLine( "\n# Demo: Query the mystery of the day\n" );

            Console.WriteLine( " The day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t" + today.ToString("dddd, dd MMMM yyyy") );

            string todaysMystery = RosaryMethods.TodaysMysteryName();
            Console.WriteLine( "\tMystery of the day: " + todaysMystery );

        }

        static void Main(string[] args) {
            Console.Clear();            // clear console

            Console.WriteLine("## ##############\n## sharp-structs\n## ##############\n");

            MyFunctions.GetOsInfo();    // display OS info
            MyFunctions.CsvToStructs(); // import csv files into a struct ER DB

            DemoBeadER();               // demo ER Class
            DemoPreviewDB();            // demo ER DB
            DemoMysteryQuery();         // demo query

            Console.WriteLine("");

        }
    }
}
