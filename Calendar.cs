/*
    Callendar.cs
    About:
        Time related calulations
*/

using System; // DateTime

namespace sharp_structs {

    public class CalendarCalculations {
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

        public static int InitialMystery() {
            DateTime today = DateTime.Now;
            int weekdayNo = (int)today.DayOfWeek;
            int[] navigtionPosition = { 237, 0, 158, 237, 79, 158, 0 };

            if ( ( weekdayNo > 6 ) || ( weekdayNo < 0 ) ) {
                weekdayNo = 0;
            }
            return navigtionPosition[ weekdayNo ];
        }

	}
}