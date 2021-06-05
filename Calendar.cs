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

        public static DateTime NearestSunday( DateTime inputDate ) {
            DateTime sundayDate;
            int weekdyaNo, dayDiff;

            weekdyaNo = (int)inputDate.DayOfWeek;
            dayDiff = 0;

            if ( weekdyaNo > 3 ) {
                dayDiff = 7 - weekdyaNo;
            } else {
                dayDiff = 0 - weekdyaNo;
            }

            sundayDate = inputDate.AddDays( dayDiff );

            return sundayDate;
        }

        public static bool IsWithinDates( DateTime inputDate, DateTime startDate, DateTime endDate ) {
            bool isWithin = false;

            if ( inputDate >= startDate && inputDate < endDate ) {
                isWithin = true;
            }

            return isWithin;
        }
	}

    public class LiturgicalCalendar {
        public struct LiturgicalFlags {
            public static int year;
            public static bool IsAdvent, IsChristmas, IsLent, IsEaster, IsOrdinary;
            public static DateTime ApostleStAndrew;
            public static DateTime ImmaculateConception;
            public static DateTime AdventSunday;
            public static DateTime ChristmasDay;
            public static DateTime Dec31;
            public static DateTime SolemnityOfMary;
            public static DateTime Epiphany;
            public static DateTime EpiphanySunday;
            public static DateTime Baptism;
            public static DateTime StartFirstOrdinaryTime;
            public static DateTime Easter;
            public static DateTime AshWednesday;
            public static DateTime Ascension;
            public static DateTime AscensionSunday;
            public static DateTime Pentecost;
            public static DateTime PentecostSunday;
            public static DateTime StartSecondOrdinaryTime;
            public static DateTime AllSaints;
            public static DateTime AllSouls;
        }

        public static void PopulateLiturgicalFlags( DateTime inputDate ) {

            LiturgicalCalendar.LiturgicalFlags.year = inputDate.Year;

            // previous year
            LiturgicalCalendar.LiturgicalFlags.ApostleStAndrew  = new DateTime( LiturgicalCalendar.LiturgicalFlags.year - 1, 11, 30);
            LiturgicalCalendar.LiturgicalFlags.AdventSunday     = CalendarCalculations.NearestSunday( LiturgicalCalendar.LiturgicalFlags.ApostleStAndrew );
            LiturgicalCalendar.LiturgicalFlags.ImmaculateConception = new DateTime( LiturgicalCalendar.LiturgicalFlags.year - 1, 12, 6);
            LiturgicalCalendar.LiturgicalFlags.ChristmasDay     = new DateTime( LiturgicalCalendar.LiturgicalFlags.year - 1, 12, 25);
            LiturgicalCalendar.LiturgicalFlags.Dec31            = new DateTime( LiturgicalCalendar.LiturgicalFlags.year - 1, 12, 31);

            // this year
            LiturgicalCalendar.LiturgicalFlags.SolemnityOfMary  = new DateTime( LiturgicalCalendar.LiturgicalFlags.year, 1, 1);
            LiturgicalCalendar.LiturgicalFlags.Epiphany         = LiturgicalCalendar.LiturgicalFlags.ChristmasDay.AddDays( 12 );
            LiturgicalCalendar.LiturgicalFlags.EpiphanySunday   = CalendarCalculations.NearestSunday( LiturgicalCalendar.LiturgicalFlags.Epiphany );
            LiturgicalCalendar.LiturgicalFlags.Baptism          = LiturgicalCalendar.LiturgicalFlags.EpiphanySunday.AddDays( 7 );
            LiturgicalCalendar.LiturgicalFlags.StartFirstOrdinaryTime = LiturgicalCalendar.LiturgicalFlags.Baptism.AddDays( 1 );
            LiturgicalCalendar.LiturgicalFlags.Easter           = LiturgicalCalendar.Easter( LiturgicalCalendar.LiturgicalFlags.year );
            LiturgicalCalendar.LiturgicalFlags.AshWednesday     = LiturgicalCalendar.LiturgicalFlags.Easter.AddDays( -46 );
            LiturgicalCalendar.LiturgicalFlags.Ascension        = LiturgicalCalendar.LiturgicalFlags.Easter.AddDays( 39 );
            LiturgicalCalendar.LiturgicalFlags.AscensionSunday  = CalendarCalculations.NearestSunday( LiturgicalCalendar.LiturgicalFlags.Ascension );
            LiturgicalCalendar.LiturgicalFlags.Pentecost        = LiturgicalCalendar.LiturgicalFlags.Easter.AddDays( 49 );
            LiturgicalCalendar.LiturgicalFlags.PentecostSunday  = CalendarCalculations.NearestSunday( LiturgicalCalendar.LiturgicalFlags.Pentecost );
            LiturgicalCalendar.LiturgicalFlags.StartSecondOrdinaryTime = LiturgicalCalendar.LiturgicalFlags.Easter.AddDays( 50 );
            LiturgicalCalendar.LiturgicalFlags.AllSaints        = new DateTime( LiturgicalCalendar.LiturgicalFlags.year, 11, 1);
            LiturgicalCalendar.LiturgicalFlags.AllSouls         = new DateTime( LiturgicalCalendar.LiturgicalFlags.year, 11, 2);

            LiturgicalCalendar.LiturgicalFlags.IsAdvent     = IsAdvent( inputDate );
            LiturgicalCalendar.LiturgicalFlags.IsChristmas  = IsChristmas( inputDate );
            LiturgicalCalendar.LiturgicalFlags.IsLent       = IsLent( inputDate );
            LiturgicalCalendar.LiturgicalFlags.IsEaster     = IsEaster( inputDate );
            LiturgicalCalendar.LiturgicalFlags.IsOrdinary   = IsOrdinary( inputDate );
        }
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

        public static bool IsAdvent( DateTime today ) {
            DateTime startDate = LiturgicalCalendar.LiturgicalFlags.ApostleStAndrew ;
            DateTime endDate = LiturgicalCalendar.LiturgicalFlags.Dec31;

            bool isAdvent = CalendarCalculations.IsWithinDates( today, startDate, endDate );

            return isAdvent;
        }
        public static bool IsChristmas( DateTime today ) {
            DateTime startDate = LiturgicalCalendar.LiturgicalFlags.Dec31;
            DateTime endDate = LiturgicalCalendar.LiturgicalFlags.Baptism;

            bool isChristmas = CalendarCalculations.IsWithinDates( today, startDate, endDate );

            return isChristmas;
        }
        public static bool IsLent( DateTime today ) {
            DateTime startDate = LiturgicalCalendar.LiturgicalFlags.AshWednesday;
            DateTime endDate = LiturgicalCalendar.LiturgicalFlags.Easter;

            bool isAdvent = CalendarCalculations.IsWithinDates( today, startDate, endDate );

            return isAdvent;
        }
        public static bool IsEaster( DateTime today ) {
            DateTime startDate = LiturgicalCalendar.LiturgicalFlags.Easter;
            DateTime endDate = LiturgicalCalendar.LiturgicalFlags.PentecostSunday;

            bool isEaster = CalendarCalculations.IsWithinDates( today, startDate, endDate );

            return isEaster;
        }
        public static bool IsOrdinary( DateTime today ) {
            DateTime startDate1 = LiturgicalCalendar.LiturgicalFlags.StartFirstOrdinaryTime;
            DateTime endDate1 = LiturgicalCalendar.LiturgicalFlags.AshWednesday;

            DateTime startDate2 = LiturgicalCalendar.LiturgicalFlags.StartSecondOrdinaryTime;
            DateTime endDate2 = CalendarCalculations.NearestSunday(  new DateTime( LiturgicalCalendar.LiturgicalFlags.year, 11, 30) ); // ApostleStAndrew this year

            bool isOrdinary1 = CalendarCalculations.IsWithinDates( today, startDate1, endDate1 );
            bool isOrdinary2 = CalendarCalculations.IsWithinDates( today, startDate2, endDate2 );

            bool isOrdinary  = ( isOrdinary1 || isOrdinary2 );

            return isOrdinary ;
        }

    }

}