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
                    loopBodyString = "Introduction Progress:";
					break;
				case 1 :
                    loopBodyString = "Decade Progress:";
					break;
				case 2 :
                    loopBodyString = "Conclusion Progress:";
					break;
				default :
                    loopBodyString = "Transition Progress:";
					break;
            }

            Console.WriteLine( "Decade:\t\t"    + decadeName );
            Console.WriteLine( "Fruit:\t\t"     + mesageText );
            Console.WriteLine( "Info:\t\t"      + decadeInfo + "\n" );
            Console.WriteLine( "Scripture:\t"   + scriptureText + "\n");
            Console.WriteLine( "Prayer:\t\t"    + prayerText );

            Console.WriteLine( "" );
            Console.WriteLine( loopBodyString + "\t"+ String.Format("{0:0.##}", smallbeadPercent) + " %\tBead:\t " + beadType );
            Console.WriteLine( "Rosary Progres:\t\t" + String.Format("{0:0.##}", mysteryPercent) + " %\tMystery: " + mysteryName );
        }

        public static void DisplayAbout() {
            string about = "\t\tThis program is a scripture rosary for the command line interface ( CLI ).\n\t\tThis app reads from a scripture database arranged in an ER schema.\n\t\tEnglish readings are quoted from The New American Bible ( CSV files ).";

            string vimKeys = "\t\tUse vim keys to navigate.\n\t\tUse h/l for backwards and forward.\n\t\tUse j/k to display help.\n\t\tUse Esc key to quit.";

            DateTime today = DateTime.Now;
            string todaysMystery = CalendarCalculations.TodaysMysteryName( today );

            Console.Clear();            // clear console

            Console.WriteLine( " About:" );
            Console.WriteLine( about );
            Console.WriteLine( "" );

            Console.WriteLine( " Controlls:" );
            Console.WriteLine( vimKeys );
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
				case "q" or "Q" or "Escape" :                               // Quit Application
                    Console.WriteLine( "\n\t_Terminated Application." );
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