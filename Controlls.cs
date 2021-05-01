/*
    Controlls.cs
    About:
        UI and progress navigation controlls.
*/

using System; // console

namespace sharp_structs {
    public class RenderDisplay {
        public static void UpdateMainView( int position ) {
			int rosaryBeadID, beadIndex, decadeIndex, mysteryIndex, prayerIndex, scriptureIndex, messageIndex;

            rosaryBeadID    = position; // ERClass.RosaryBead.structRecords[ position ].rosaryBeadID;
            beadIndex       = ERClass.RosaryBead.structRecords[ position ].beadIndex;
            decadeIndex     = ERClass.RosaryBead.structRecords[ position ].decadeIndex;
            mysteryIndex    = ERClass.RosaryBead.structRecords[ position ].mysteryIndex;
            prayerIndex     = ERClass.RosaryBead.structRecords[ position ].prayerIndex;;
            scriptureIndex  = ERClass.RosaryBead.structRecords[ position ].scriptureIndex;
            messageIndex    = ERClass.RosaryBead.structRecords[ position ].messageIndex;


            ERView.meditationPoint_t.rosaryBeadID   = position; // ERClass.RosaryBead.structRecords[rosaryBeadID].rosaryBeadID;
            ERView.meditationPoint_t.beadType       = ERClass.Bead.structRecords[beadIndex].beadType;
            ERView.meditationPoint_t.decadeName     = ERClass.Decade.structRecords[decadeIndex].decadeName;
            ERView.meditationPoint_t.decadeInfo     = ERClass.Decade.structRecords[decadeIndex].decadeInfo;
            ERView.meditationPoint_t.mysteryNo      = ERClass.Mystery.structRecords[mysteryIndex].mysteryNo;
            ERView.meditationPoint_t.mysteryName    = ERClass.Mystery.structRecords[mysteryIndex].mysteryName;
            ERView.meditationPoint_t.prayerName     = ERClass.Prayer.structRecords[prayerIndex].prayerName;
            ERView.meditationPoint_t.prayerText     = ERClass.Prayer.structRecords[prayerIndex].prayerText;
            ERView.meditationPoint_t.scriptureText  = ERClass.Scripture.structRecords[scriptureIndex].scriptureText;
            ERView.meditationPoint_t.mesageText     = ERClass.Message.structRecords[messageIndex].mesageText;

        }

        public static void DisplayView() {
            Console.WriteLine( "Mystery:\t"   + ERView.meditationPoint_t.mysteryName );
            Console.WriteLine( "Decade:\t\t"    + ERView.meditationPoint_t.decadeName );
            Console.WriteLine( "Fruit:\t\t"     + ERView.meditationPoint_t.mesageText );
            Console.WriteLine( "Info:\t\t"      + ERView.meditationPoint_t.decadeInfo + "\n" );
            Console.WriteLine( "Scripture:\t"   + ERView.meditationPoint_t.scriptureText + "\n");
            Console.WriteLine( "Bead:\t\t"        + ERView.meditationPoint_t.beadType );
            Console.WriteLine( "Prayer:\t\t"    + ERView.meditationPoint_t.prayerName );
            Console.WriteLine( "\t\t"           + ERView.meditationPoint_t.prayerText );
        }

        public static void DisplayAbout() {
            string about = "This program is a scripture rosary for the command line interface ( CLI ). This app reads from a scripture database arranged in an ER schema. English readings are quoted from The New American Bible ( CSV files ).";
            string vimKeys = "Use vim keys to navigate. Use h/l for backwards and forward. Use j/k to display help. Use Esc key to quit.";

            DateTime today = DateTime.Now;
            string todaysMystery = CalendarCalculations.TodaysMysteryName( today );

            Console.Clear();            // clear console

            Console.WriteLine( " About:" );
            Console.WriteLine( "\t\t" + about );
            Console.WriteLine( "" );

            Console.WriteLine( " Controlls:" );
            Console.WriteLine( "\t\t" + vimKeys );
            Console.WriteLine( "" );

            Console.WriteLine( " Date:" );
            Console.WriteLine( "\t\tThe day of the week for {0:d} is {1}.", today.DayOfWeek, today.DayOfWeek );
            Console.WriteLine( "\t\t" + today.ToString("dddd, dd MMMM yyyy") );
            Console.WriteLine( "\t\tMystery of the day: " + todaysMystery );

            Console.WriteLine( "\nPress any key to continue." );
            Console.ReadKey();

        }


    }

    public class UserInput {
        public static int KeyNavigation( int i ) {

            ConsoleKeyInfo k = Console.ReadKey();
            string keyString = k.Key.ToString();


			switch( keyString ) {
				case "q" or "Q" or "Escape" : // Quit Application
                    Console.WriteLine( "\n\t_Terminated Application." );
                    Environment.Exit(0);
					break;
                case "l" or "L" or "Enter" or "RightArrow" or "Spacebar": // Next
                    i++;
                    if ( i > ERClass.RosaryBead.totalRecords ) {
                        i = 1;
                    }
					break;
                case "h" or "H" or "LeftArrow": // Next
                    i--;
                    if ( i < 0 ) {
                        i = ERClass.RosaryBead.totalRecords ;
                    }
					break;
                case "j" or "J" or "k" or "K": // About
                    RenderDisplay.DisplayAbout();
					break;
                default:
                    //Console.WriteLine( "\nk.Key: " + k.Key + "\tkeyString: " + keyString + "\n" );
                    //Environment.Exit(0);
                    break;
			}

            return i;
        }
    }
}