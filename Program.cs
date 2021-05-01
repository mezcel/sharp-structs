/*
    Program.cs
    About:
        Main()
*/

using System; // console

namespace sharp_structs {

    class Program {

        static void DemoPreviewDB() {
            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.WriteLine( " class array        \trecords\tfields" );
            Console.WriteLine( " -------------------\t-------\t------" );

            Console.WriteLine( " ERClass.RosaryBead\t" + ERClass.RosaryBead.structRecords.Length + "\t " + ERClass.RosaryBead.attributeNames.Length );
            Console.WriteLine( " ERClass.Bead\t\t"    + ERClass.Bead.structRecords.Length + "\t " + ERClass.Bead.attributeNames.Length );
            Console.WriteLine( " ERClass.Book\t\t"    + ERClass.Book.structRecords.Length + "\t " + ERClass.Book.attributeNames.Length );
            Console.WriteLine( " ERClass.Decade\t\t"  + ERClass.Decade.structRecords.Length + "\t " + ERClass.Decade.attributeNames.Length );
            Console.WriteLine( " ERClass.Message\t" + ERClass.Message.structRecords.Length + "\t " + ERClass.Message.attributeNames.Length );
            Console.WriteLine( " ERClass.Mystery\t" + ERClass.Mystery.structRecords.Length + "\t " + ERClass.Mystery.attributeNames.Length );
            Console.WriteLine( " ERClass.Prayer\t\t"  + ERClass.Prayer.structRecords.Length + "\t " + ERClass.Prayer.attributeNames.Length );
            Console.WriteLine( " ERClass.Scripture\t" + ERClass.Scripture.structRecords.Length + "\t " + ERClass.Scripture.attributeNames.Length );
            Console.WriteLine( " ERClass.Feast\t\t" + ERClass.Feast.structRecords.Length + "\t " + ERClass.Feast.attributeNames.Length );
        }

        static void DemoMysteryQuery() {
            DateTime today = DateTime.Now;

            Console.WriteLine( "\n# Demo: Query the mystery of the day\n" );

            Console.WriteLine( " The day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t" + today.ToString("dddd, dd MMMM yyyy") );

            string todaysMystery = CalendarCalculations.TodaysMysteryName( today );
            Console.WriteLine( "\tMystery of the day: " + todaysMystery );

        }

        static void Main(string[] args) {
            Console.Clear();            // clear console

            Console.WriteLine("## ################# ##");
            Console.WriteLine("##   sharp-structs   ##");
            Console.WriteLine("## ################# ##");
            Console.WriteLine("");

            //MyFunctions.GetOsInfo();         // display OS info
            MyFunctions.ImportCsvDatabase(); // import csv files into a struct ER DB

            DemoPreviewDB();            // demo ER DB
            DemoMysteryQuery();         // demo query

            Console.ReadLine();

            int i = 0;
            while ( i < ERClass.RosaryBead.totalRecords ) {
                Console.Clear();        // clear console

                RenderDisplay.UpdateMainView( i );
                RenderDisplay.DisplayView();

                i = UserInput.KeyNavigation(i);
            }

        }
    }
}
