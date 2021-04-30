using System; // console

namespace sharp_structs {

    class Program {

        static void DemoBeadER() {

            Console.WriteLine( "# Demo2: Preview bead.csv ER class\n" );

            // Class Attributes
            string csvFile = MyFunctions.CsvFilePath( "bead.csv" );
            string[] headerAttr = MyFunctions.ReturnHeaderArray( csvFile );

            Console.WriteLine(
                " ERClass.Bead.csvBaseName = "          + ERClass.Bead.csvBaseName +
                "\t\tERClass.Bead.attributes.Length = " + ERClass.Bead.attributeNames.Length );

            Console.WriteLine(
                " ERClass.Bead.attributes[ 0 ] = "      + ERClass.Bead.attributeNames[0] +
                "\t\tERClass.Bead.attributes[ 1 ] = "   + ERClass.Bead.attributeNames[1] );

            // Attribute recoed data
            int i = 0;
            foreach( ERClass.Bead.bead_t bead in ERClass.Bead.structRecords ) {

                Console.WriteLine(
                    " ERClass.Bead.structRecords[ " + i + " ].beadID = "    + ERClass.Bead.structRecords[i].beadID +
                    "\tERClass.Bead.structRecords[ " + i + " ].beadType = " + ERClass.Bead.structRecords[i].beadType );

                i++;
            }

        }

        static void DemoPreviewDB() {
            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.WriteLine( " class array              \t\trecords\tfields" );
            Console.WriteLine( " -------------------------\t\t-------\t------" );

            Console.WriteLine( " ERClass.RosaryBead.structRecords\t" + ERClass.RosaryBead.structRecords.Length + "\t " + ERClass.RosaryBead.attributeNames.Length );
            Console.WriteLine( " ERClass.Bead.totalRecords\t\t"    + ERClass.Bead.totalRecords + "\t " + ERClass.Bead.attributeNames.Length );
            Console.WriteLine( " ERClass.Book.totalRecords\t\t"    + ERClass.Book.totalRecords + "\t " + ERClass.Book.attributeNames.Length );
            Console.WriteLine( " ERClass.Decade.totalRecords\t\t"  + ERClass.Decade.totalRecords + "\t " + ERClass.Decade.attributeNames.Length );
            Console.WriteLine( " ERClass.Message.totalRecords\t\t" + ERClass.Message.totalRecords + "\t " + ERClass.Message.attributeNames.Length );
            Console.WriteLine( " ERClass.Mystery.totalRecords\t\t" + ERClass.Mystery.totalRecords + "\t " + ERClass.Mystery.attributeNames.Length );
            Console.WriteLine( " ERClass.Prayer.totalRecords\t\t"  + ERClass.Prayer.totalRecords + "\t " + ERClass.Prayer.attributeNames.Length );
            Console.WriteLine( " ERClass.Scripture.totalRecords\t" + ERClass.Scripture.totalRecords + "\t " + ERClass.Scripture.attributeNames.Length );
        }

        static void DemoMysteryQuery() {
            DateTime today = CalendarCalculations.ReturnToday();

            Console.WriteLine( "\n# Demo: Query the mystery of the day\n" );

            Console.WriteLine( " The day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t" + today.ToString("dddd, dd MMMM yyyy") );

            string todaysMystery = RosaryMethods.TodaysMysteryName( today );
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
