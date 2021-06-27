/*
    Controls.cs
    About:
        UI and progress navigation controls.
*/

using System; // console

namespace sharp_structs {
    public class RenderDisplay {

        public static void UpdateMainView( int position ) {

			int rosaryBeadID, beadIndex, decadeIndex, mysteryIndex, prayerIndex, scriptureIndex, messageIndex;

            rosaryBeadID    = ERClass.RosaryBead.structRecords[ position ].rosaryBeadID;
            beadIndex       = ERClass.RosaryBead.structRecords[ position ].beadIndex;
            decadeIndex     = ERClass.RosaryBead.structRecords[ position ].decadeIndex;
            mysteryIndex    = ERClass.RosaryBead.structRecords[ position ].mysteryIndex;
            prayerIndex     = ERClass.RosaryBead.structRecords[ position ].prayerIndex;
            scriptureIndex  = ERClass.RosaryBead.structRecords[ position ].scriptureIndex;
            messageIndex    = ERClass.RosaryBead.structRecords[ position ].messageIndex;

            ERView.meditationPoint_t.rosaryBeadID   = ERClass.RosaryBead.structRecords[rosaryBeadID].rosaryBeadID;
            ERView.meditationPoint_t.beadType       = ERClass.Bead.structRecords[beadIndex].beadType;
            ERView.meditationPoint_t.decadeName     = ERClass.Decade.structRecords[decadeIndex].decadeName;
            ERView.meditationPoint_t.decadeInfo     = ERClass.Decade.structRecords[decadeIndex].decadeInfo;
            ERView.meditationPoint_t.mysteryNo      = ERClass.Mystery.structRecords[mysteryIndex].mysteryNo;
            ERView.meditationPoint_t.mysteryName    = ERClass.Mystery.structRecords[mysteryIndex].mysteryName;
            ERView.meditationPoint_t.prayerName     = ERClass.Prayer.structRecords[prayerIndex].prayerName;
            ERView.meditationPoint_t.prayerText     = ERClass.Prayer.structRecords[prayerIndex].prayerText;
            ERView.meditationPoint_t.scriptureText  = ERClass.Scripture.structRecords[scriptureIndex].scriptureText;
            ERView.meditationPoint_t.mesageText     = ERClass.Message.structRecords[messageIndex].mesageText;

            ERView.meditationPoint_t.loopBody         = ERClass.RosaryBead.structRecords[rosaryBeadID].loopBody;

            if ( ERView.meditationPoint_t.loopBody == 0 ) {
                if ( ( prayerIndex == 7 ) || ( prayerIndex == 8 ) ) {
                    ERView.meditationPoint_t.loopBody = 2;
                }
            }

            ERView.meditationPoint_t.smallbeadPercent = ERClass.RosaryBead.structRecords[rosaryBeadID].smallbeadPercent;
            ERView.meditationPoint_t.mysteryPercent   = ERClass.RosaryBead.structRecords[rosaryBeadID].mysteryPercent;
        }

        static void ColoredMeditationInfo( string label, string meta) {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write( label  );
            Console.ResetColor();
            Console.WriteLine( meta );
        }

        public static void DisplayView() {

            string mysteryName  = ERView.meditationPoint_t.mysteryName;
            string decadeName   = ERView.meditationPoint_t.decadeName;
            string mesageText   = ERView.meditationPoint_t.mesageText;
            string decadeInfo   = ERView.meditationPoint_t.decadeInfo;
            string scriptureText = ERView.meditationPoint_t.scriptureText;
            string beadType     = ERView.meditationPoint_t.beadType;
            //string prayerName = ERView.meditationPoint_t.prayerName;
            string prayerText   = ERView.meditationPoint_t.prayerText;

            double smallbeadPercent = ( ERView.meditationPoint_t.smallbeadPercent * 1.00 / 10.00 ) * 100.00;
            double mysteryPercent   = ( ERView.meditationPoint_t.mysteryPercent * 1.00 / 50.00 ) * 100.00;

            string loopBodyString;
            switch( ERView.meditationPoint_t.loopBody ) {
				case 0 :
                    loopBodyString = "Introduction Progress:\t";
					break;
				case 1 :
                    loopBodyString = "Decade Progress:\t";
					break;
				case 2 :
                    loopBodyString = "Conclusion Progress:\t";
					break;
				default :
                    loopBodyString = "Transition Progress:\t";
					break;
            }

            ColoredMeditationInfo( "Decade:\t\t" , decadeName );
            ColoredMeditationInfo( "Fruit:\t\t" , mesageText );
            ColoredMeditationInfo( "Info:\t\t" , decadeInfo );
            Console.WriteLine( "\n" );
            ColoredMeditationInfo( "Scripture:\t" , scriptureText );
            Console.WriteLine( "\n" );
            ColoredMeditationInfo( "Prayer:\t\t" , prayerText );
            Console.WriteLine( "" );

            // Progress info
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write( loopBodyString );
            Console.ResetColor();
            Console.Write( String.Format( "{0:0.##}", smallbeadPercent ) + " %\t" );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write( "Bead:\t " );
            Console.ResetColor();
            Console.Write( beadType + "\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write( "Rosary Progress:\t" );
            Console.ResetColor();
            Console.Write( String.Format( "{0:0.##}", mysteryPercent ) + " %\t" );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write( "Mystery: " );
            Console.ResetColor();
            Console.Write( mysteryName );
            Console.ResetColor();
        }

        public static void DisplayAbout() {
            string about = "\t\tThis program is a scripture rosary for the command line interface ( CLI ).\n\t\tThis app reads from a scripture database arranged in an ER schema.\n\t\tEnglish readings are quoted from The New American Bible ( CSV files ).";

            string vimKeys = "\t\tUse vim keys to navigate.\n\t\tUse h/l for backwards and forward.\n\t\tUse j/k to display help.\n\t\tUse Esc or 'q' key to quit.";

            DateTime today = DateTime.Now;
            string todaysMystery = CalendarCalculations.TodaysMysteryName( today );

            Console.ResetColor();
            Console.Clear();            // clear console

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( "## ############# ##" );
            Console.WriteLine( "## Instructions  ##" );
            Console.WriteLine( "## ############# ##\n" );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( " About:" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( about );
            Console.WriteLine( "" );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( " Controls:" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( vimKeys );
            Console.WriteLine( "" );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine( " Date:" );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( "\t\tThe day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t\t" + today.ToString("dddd, dd MMMM yyyy") );
            Console.WriteLine( "\t\tMystery of the day: " + todaysMystery );
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine( "\nPress any key to continue." );
            Console.ResetColor();
            Console.ReadKey();
        }

    }

    public class UserInput {
        public static int KeyNavigation( int i ) {

            ConsoleKeyInfo k = Console.ReadKey();
            string keyString = k.Key.ToString();

			switch( keyString ) {
				case "q" or "Q" or "Escape" :                               // Quit Application
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "\n\n\t_Terminated Application.\n" );
                    Console.ResetColor();
                    Environment.Exit(0);
					break;
                case "l" or "L" or "Enter" or "RightArrow" or "Spacebar":   // Next
                    i++;
                    if ( i >= ERClass.RosaryBead.totalRecords ) {
                        i = 0;
                    }
					break;
                case "h" or "H" or "LeftArrow":                             // Previous
                    if ( i == 0 ) {
                        i = ERClass.RosaryBead.totalRecords;
                    }
                    i--;
					break;
                case "j" or "J" or "k" or "K":                              // About
                    RenderDisplay.DisplayAbout();
					break;
                default:
                    //Console.WriteLine( "\nk.Key: " + k.Key + "\tkeyString: " + keyString + "\n" );
                    //Environment.Exit(0);
                    RenderDisplay.DisplayAbout();
                    break;
			}

            return i;
        }
    }
}