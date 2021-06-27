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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine( "\n# Demo: Preview DB class size and attribute count\n" );
            Console.ResetColor();

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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine( "\nPress any key to continue." );
            Console.ResetColor();
            Console.ReadKey();
        }

        static void DemoColorizeFeast( DateTime feastDay, string feastString ) {
            string dateDisplay = feastDay.ToString("dddd,\tdd MMMM yyyy");

            Console.ResetColor();

            Console.Write( " " + dateDisplay + "\t" );
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( feastString );
            Console.ResetColor();

        }

        static void DemoCalendar() {

            DateTime today = DateTime.Now;
            Console.Clear();            // clear console

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine( "# Demo: liturgical calendar flags\n" );
            Console.ResetColor();
            Console.WriteLine( " Liturgical year:\t" +  today + "\n" );

            // Populate struct calendar
            LiturgicalCalendar.PopulateLiturgicalFlags( today );

            // Display Calendar struct

            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.ApostleStAndrew, "Feast of St. Andrew the Apostle" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.AdventSunday, "First Sunday of Advent" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.ImmaculateConception, "Feast of the Immaculate Conception of Mary The Mother of God" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.ChristmasDay, "Christmas Day" );
            //DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Dec31, "Dec31" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.SolemnityOfMary, "\tSolemnity Of Mary" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Epiphany, "\tEpiphany" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.EpiphanySunday, "\tEpiphany Sunday" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Baptism, "\tBaptism" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.StartFirstOrdinaryTime, "\tStart of 1st Ordinary Time" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.AshWednesday, "Ash Wednesday" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Easter, "\tEaster" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Ascension, "\tAscension" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.AscensionSunday, "\tAscension Sunday" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.Pentecost, "\tPentecost" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.PentecostSunday, "\tPentecost Sunday" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.StartSecondOrdinaryTime, "\tStart of 2nd Ordinary Time" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.AllSaints, "All Saints Day" );
            DemoColorizeFeast( LiturgicalCalendar.LiturgicalFlags.AllSouls, "All Souls Day" );

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine( "\n# Liturgical Seasons:\n" );
            Console.ResetColor();

	        //Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write( " Advent Season:\t\t" );
            Console.ResetColor();
            if ( LiturgicalCalendar.LiturgicalFlags.IsAdvent ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine( LiturgicalCalendar.LiturgicalFlags.IsAdvent );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( " Christmas Season:\t" );
            Console.ResetColor();
            if ( LiturgicalCalendar.LiturgicalFlags.IsChristmas ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine( LiturgicalCalendar.LiturgicalFlags.IsChristmas );

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write( " Lent Season:\t\t" );
            Console.ResetColor();
            if ( LiturgicalCalendar.LiturgicalFlags.IsLent ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine( LiturgicalCalendar.LiturgicalFlags.IsLent );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( " Easter Season:\t\t" );
            Console.ResetColor();
            if ( LiturgicalCalendar.LiturgicalFlags.IsEaster ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine( LiturgicalCalendar.LiturgicalFlags.IsEaster );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( " Ordinary Time:\t\t" );
            Console.ResetColor();
            if ( LiturgicalCalendar.LiturgicalFlags.IsOrdinary ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine( LiturgicalCalendar.LiturgicalFlags.IsOrdinary );

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine( "\nPress any key to continue." );
            Console.ResetColor();
            Console.ReadKey();
        }

        static void UILoop() {
            int i;

            i = CalendarCalculations.InitialMystery();  // Start position based on the today's date
            RenderDisplay.DisplayAbout();               // Display initial about info

            while ( i <= ERClass.RosaryBead.structRecords.Length ) {
                Console.Clear();                        // clear console

                RenderDisplay.UpdateMainView( i );      // Populate view struct with new query data
                RenderDisplay.DisplayView();            // render console display text

                i = UserInput.KeyNavigation(i);         // prompt for UI input, update to next position
            }
        }

        static void Greeter() {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();            // clear console

            Console.WriteLine( "## ################# ##");
            Console.WriteLine( "##   sharp-structs   ##");
            Console.WriteLine( "## ################# ##");
            Console.WriteLine( "");

            Console.ResetColor();
        }

        static void Main(string[] args) {
            Greeter();                       // Splash/header text
            //MyFunctions.GetOsInfo();       // display OS info
            MyFunctions.ImportCsvDatabase(); // import csv files into a struct ER DB
            DemoPreviewDB();                 // Display loaded database info
            DemoCalendar();                  // Display liturgical calendar dates
            UILoop();                        // Main application UI Loop
        }
    }
}
