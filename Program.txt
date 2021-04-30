using System; // console
using System.IO; // Environment
using System.Collections; // ArrayList()

namespace sharp_structs {

    class Program {

        static void DemoBeadER() {
            int i = 0;

            Console.WriteLine( "# Demo2: Preview bead.csv ER class\n" );

            // Class Arrtibute
            string csvFile = MyFunctions.CsvFilePath( "bead.csv" );
            string[] headerAttr = MyFunctions.ReturnHeaderArray( csvFile );

            Console.WriteLine( " ERClass.Bead.csvBaseName = " + ERClass.Bead.csvBaseName +
                "\t\tERClass.Bead.attributes.Length = " + ERClass.Bead.attributeNames.Length );

            Console.WriteLine( " ERClass.Bead.attributes[ 0 ] = " + ERClass.Bead.attributeNames[0] +
                "\t\tERClass.Bead.attributes[ 1 ] = " + ERClass.Bead.attributeNames[1] );

            // Attribute Data
            foreach( ERClass.Bead.bead_t bead in ERClass.Bead.structRecords ) {

                Console.WriteLine(
                    " ERClass.Bead.structRecords[ " + i + " ].beadID = " + ERClass.Bead.structRecords[i].beadID +
                    "\tERClass.Bead.structRecords[ " + i + " ].beadType = " + ERClass.Bead.structRecords[i].beadType );

                i++;
            }

        }

        static void DemoPreviewDB() {

            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.WriteLine( " class array              \trecords\tfields" );
            Console.WriteLine( " -------------------------\t-------\t------" );

            Console.WriteLine( " ERClass.rosaryBead_dbArray\t" + ERClass.RosaryBead.structRecords.Length + "\t " + ERClass.RosaryBead.totalRecords );

            Console.WriteLine( " ERClass.bead_dbArray\t\t" + ERClass.Bead.structRecords.Length + "\t " + ERClass.Bead.totalRecords );

            Console.WriteLine( " ERClass.book_dbArray\t\t" + ERClass.Book.structRecords.Length + "\t " + ERClass.Book.totalRecords );

            Console.WriteLine( " ERClass.decade_dbArray\t\t" + ERClass.Decade.structRecords.Length + "\t " + ERClass.Decade.totalRecords );

            Console.WriteLine( " ERClass.message_dbArray\t" + ERClass.Message.structRecords.Length + "\t " + ERClass.Message.totalRecords );

            Console.WriteLine( " ERClass.mystery_dbArray\t" + ERClass.Mystery.structRecords.Length + "\t " + ERClass.Mystery.totalRecords );

            Console.WriteLine( " ERClass.prayer_dbArray\t\t" + ERClass.Prayer.structRecords.Length + "\t " + ERClass.Prayer.totalRecords );

            Console.WriteLine( " ERClass.scripture_dbArray\t" + ERClass.Scripture.structRecords.Length + "\t " + ERClass.Scripture.totalRecords );

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

            Console.WriteLine("## ################# ##");
            Console.WriteLine("##   sharp-structs   ##");
            Console.WriteLine("## ################# ##");
            Console.WriteLine("");

            MyFunctions.GetOsInfo();         // display OS info
            MyFunctions.ImportCsvDatabase(); // import csv files into a struct ER DB

            DemoBeadER();               // demo ER Class
            DemoPreviewDB();            // demo ER DB
            DemoMysteryQuery();         // demo query

            Console.WriteLine("");
        }
    }
}
