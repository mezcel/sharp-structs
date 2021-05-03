/*
    Program.cs
    About:
        Main()
*/

using System; // console

namespace sharp_structs {

    class Program {

        static void DemoPreviewDB() {
            //Console.Clear();            // clear console

            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.WriteLine( " class array        \trecords\tfields" );
            Console.WriteLine( " -------------------\t-------\t------" );

            Console.WriteLine( " ERClass.RosaryBead\t" + ERClass.RosaryBead.structRecords.Length + "\t " + ERClass.RosaryBead.attributeNames.Length );
            Console.WriteLine( " ERClass.Bead\t\t"    + ERClass.Bead.structRecords.Length + "\t " + ERClass.Bead.attributeNames.Length );
            Console.WriteLine( " ERClass.Book\t\t"    + ERClass.Book.structRecords.Length + "\t " + ERClass.Book.attributeNames.Length );
            Console.WriteLine( " ERClass.Decade\t\t"  + ERClass.Decade.structRecords.Length + "\t " + ERClass.Decade.attributeNames.Length );
            Console.WriteLine( " ERClass.Message\t"   + ERClass.Message.structRecords.Length + "\t " + ERClass.Message.attributeNames.Length );
            Console.WriteLine( " ERClass.Mystery\t"   + ERClass.Mystery.structRecords.Length + "\t " + ERClass.Mystery.attributeNames.Length );
            Console.WriteLine( " ERClass.Prayer\t\t"  + ERClass.Prayer.structRecords.Length + "\t " + ERClass.Prayer.attributeNames.Length );
            Console.WriteLine( " ERClass.Scripture\t" + ERClass.Scripture.structRecords.Length + "\t " + ERClass.Scripture.attributeNames.Length );
            Console.WriteLine( " ERClass.Feast\t\t"   + ERClass.Feast.structRecords.Length + "\t " + ERClass.Feast.attributeNames.Length );

            Console.WriteLine( "\nPress any key to continue." );
            Console.ReadKey();
        }

        static void DemoCalendar() {

            string dateDisplay;
            DateTime today = DateTime.Now;
            Console.Clear();            // clear console

            Console.WriteLine( "# Demo: liturgical calendar flags\n" );
            Console.WriteLine( "Liturgical year:\t" +  today + "\n" );

            // Populate struct calendar
            LiturgicalCalendar.PopulateLiturgicalFlags( today );

            // Display Calendar struct

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.StartAdvent.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "StartAdvent:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.AdventSunday.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "AdventSunday:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.ChristmadDay.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "ChristmadDay:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Dec31.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Dec31:\t\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.SolemnityOfMary.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "SolemnityOfMary:\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Epiphany.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Epiphany:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.EpiphanySunday.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "EpiphanySunday:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Baptism.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Baptism:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.StartFirstOrdinaryTime.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "StartFirstOrdinaryTime: Date: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.AshWednesday.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "AshWednesday:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Easter.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Easter:\t\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Ascension.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Ascension:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.AscensionSunday.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "AscensionSunday:\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.Pentacost.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "Pentacost:\t\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.PentacostSunday.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "PentacostSunday:\tDate: " + dateDisplay );

            dateDisplay = LiturgicalCalendar.LiturgicalFlags.StartSecondOrdinaryTime.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine( "StartSecondOrdinaryTime: Date: " + dateDisplay );

            Console.WriteLine( "" );

            Console.WriteLine( "IsAdvent:\t" + LiturgicalCalendar.IsAdvent( today ) );
            Console.WriteLine( "IsChristmas:\t" + LiturgicalCalendar.IsChristmas( today ) );
            Console.WriteLine( "IsLent:\t\t" + LiturgicalCalendar.IsLent( today ) );
            Console.WriteLine( "IsEaster:\t" + LiturgicalCalendar.IsEaster( today ) );
            Console.WriteLine( "IsOrdinary:\t" + LiturgicalCalendar.IsOrdinary( today ) );

            Console.WriteLine( "\nPress any key to continue." );
            Console.ReadKey();
        }

        static void UILoop() {
            int i = CalendarCalculations.InitialMystery();

            //Console.WriteLine( "\nPress any key to continue." );
            //Console.ReadKey();
            RenderDisplay.DisplayAbout();

            while ( i <= ERClass.RosaryBead.structRecords.Length ) {
                Console.Clear();        // clear console

                RenderDisplay.UpdateMainView( i );
                RenderDisplay.DisplayView();

                i = UserInput.KeyNavigation(i);
            }
        }

        static void Main(string[] args) {
            Console.Clear();            // clear console

            Console.WriteLine( "## ################# ##");
            Console.WriteLine( "##   sharp-structs   ##");
            Console.WriteLine( "## ################# ##");
            Console.WriteLine( "");

            //MyFunctions.GetOsInfo();         // display OS info
            MyFunctions.ImportCsvDatabase(); // import csv files into a struct ER DB
            DemoPreviewDB();

            //Console.Clear();            // clear console
            DemoCalendar();

            UILoop(); // Main application UI Loop

        }
    }
}
