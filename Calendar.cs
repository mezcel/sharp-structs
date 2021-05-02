/*
    Calendar.cs
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

    public class LiturgicalCalendar {
        public static DateTime Easter( int year ) {
            int a, b, c, d, e, f, g, h, i, k, l, m, month, day;

            a       = year % 19;
            b       = year / 100;
            c       = year % 100;
            d       = b / 4;
            e       = b % 4;
            f       = (b + 8 ) / 25;
            g       = (b - f + 1 ) / 3;
            h       = ((19 * a ) + b - d - g + 15 ) % 30;
            i       = c / 4;
            k       = c % 4;
            l       = ( 32 + (2 * e ) + (2 * i ) - h - k ) % 7;
            m       = ( a + (11 * h ) + (22 * l ) ) / 451;
            month   = ( h + l - (7 * m ) + 114 ) / 31;
            day     = ( (h + l - (7 * m ) + 114 ) % 31 ) + 1;

            DateTime date = new DateTime(year, month, day);;

            return date;
        }

    }

}