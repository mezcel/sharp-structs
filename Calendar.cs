/*
    Callendar.cs
    About:
        Time related calulations
*/

using System; // DateTime

namespace sharp_structs {

    public class CalendarCalculations {
		/*public static DateTime ReturnToday() {
			DateTime today = DateTime.Now;
			return today;
		}*/

        public static string TodaysMysteryName( DateTime today ) {
			// DateTime today = DateTime.Now;

			int weekdayIndex = (int)today.DayOfWeek;

			switch( weekdayIndex ) {
				case 0 or 3:
					weekdayIndex = 4;
					break;
				case 1 or 6:
					weekdayIndex = 1;
					break;
				case 2 or 5:
					weekdayIndex = 3;
					break;
				case 4:
					weekdayIndex = 2;
					break;
			}

			string mysteryName = ERClass.Mystery.structRecords[ weekdayIndex ].mysteryName;

			return mysteryName;
		}
	}
}