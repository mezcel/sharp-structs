using System;
using System.IO; // Environment

namespace sharp_structs {

	public class MyFunctions {

		public static void GetOsInfo() {
            OperatingSystem os = Environment.OSVersion;

			Console.WriteLine( "# Operation System Information" );
            Console.WriteLine("\tOS Version:   " + os.Version.ToString());
            Console.WriteLine("\tOS Platoform: " + os.Platform.ToString());
            Console.WriteLine("\tOS SP:        " + os.ServicePack.ToString());
            Console.WriteLine("\tOS Version String: " + os.VersionString.ToString());

            // Get Version details
            Version ver = os.Version;

            Console.WriteLine("# Operating System Detaiils");
            Console.WriteLine("\tMajor version:  " + ver.Major);
            Console.WriteLine("\tMajor Revision: " + ver.MajorRevision);
            Console.WriteLine("\tMinor version:  " + ver.Minor);
            Console.WriteLine("\tMinor Revision: " + ver.MinorRevision);
            Console.WriteLine("\tBuild:          " + ver.Build);
			Console.WriteLine("");
		}

		public static string CsvFilePath( string csvFileName ) {
			string currentDir, myOs, path;

            OperatingSystem os = Environment.OSVersion;

			currentDir = Directory.GetCurrentDirectory();
            myOs = os.Platform.ToString();

            if ( myOs == "Unix" ) {
				currentDir+= @"/database/csv/";
			} else {
				currentDir+= @"\database\csv\";
			}

			path = currentDir + csvFileName;

			return path;
		}

		public static int RecordCount( string path ) {
			int count = 0;

			string[] readText = File.ReadAllLines(path);
			foreach( string s in readText ) {
				// skip empty lines
				if ( s.Trim() == "" ) {
					continue;
				} else {
					count++;
				}
			}

			return count;
		}

		public static int FieldCount( string path ) {
			int count = 0;

			string[] readText = File.ReadAllLines(path);
			string[] fields = readText[0].Split(';');

			count = fields.Length;

			return count;
		}

		public static void PopulateRosaryBeadClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {

					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.rosaryBead_dbArray[recordIndex].rosaryBeadID = Int32.Parse( fields[0] );
					ERClass.rosaryBead_dbArray[recordIndex].beadIndex = Int32.Parse( fields[1] );
					ERClass.rosaryBead_dbArray[recordIndex].decadeIndex = Int32.Parse( fields[2] );
					ERClass.rosaryBead_dbArray[recordIndex].mysteryIndex = Int32.Parse( fields[3] );
					ERClass.rosaryBead_dbArray[recordIndex].prayerIndex = Int32.Parse( fields[4] );
					ERClass.rosaryBead_dbArray[recordIndex].scriptureIndex = Int32.Parse( fields[5] );
					ERClass.rosaryBead_dbArray[recordIndex].messageIndex = Int32.Parse( fields[6] );
					ERClass.rosaryBead_dbArray[recordIndex].loopBody = Int32.Parse( fields[7] );
					ERClass.rosaryBead_dbArray[recordIndex].smallbeadPercent = Int32.Parse( fields[8] );
					ERClass.rosaryBead_dbArray[recordIndex].mysteryPercent = Int32.Parse( fields[9] );

				}
				csvLineCount++;
			}
		}

		public static void PopulateBeadClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.bead_dbArray[recordIndex].beadID = Int32.Parse( fields[0] );
					ERClass.bead_dbArray[recordIndex].beadType = fields[1];
				}

				csvLineCount++;
			}
		}

		public static void PopulateBookClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.book_dbArray[recordIndex].bookID = Int32.Parse( fields[0] );
					ERClass.book_dbArray[recordIndex].bookName = fields[1];
					ERClass.book_dbArray[recordIndex].library = fields[2];

				}
				csvLineCount++;
			}
		}

		public static void PopulateDecadeClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.decade_dbArray[recordIndex].decadeID = Int32.Parse( fields[0] );
					ERClass.decade_dbArray[recordIndex].mysteryIndex = Int32.Parse( fields[1] );
					ERClass.decade_dbArray[recordIndex].decadeNo = Int32.Parse( fields[2] );
					ERClass.decade_dbArray[recordIndex].decadeName = fields[3];
					ERClass.decade_dbArray[recordIndex].decadeInfo = fields[4];
					ERClass.decade_dbArray[recordIndex].infoRefference = fields[5];
				}
				csvLineCount++;
			}
		}

		public static void PopulateMessageClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.message_dbArray[recordIndex].messageID = Int32.Parse( fields[0] );
					ERClass.message_dbArray[recordIndex].mesageText = fields[1];
				}
				csvLineCount++;
			}
		}

		public static void PopulateMysteryClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.mystery_dbArray[recordIndex].mysteryID = Int32.Parse( fields[0] );
					ERClass.mystery_dbArray[recordIndex].mysteryNo = Int32.Parse( fields[1] );
					ERClass.mystery_dbArray[recordIndex].mysteryName = fields[2];
				}
				csvLineCount++;
			}
		}

		public static void PopulatePrayerClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.prayer_dbArray[recordIndex].prayerID = Int32.Parse( fields[0] );
					ERClass.prayer_dbArray[recordIndex].prayerName = fields[1];
					ERClass.prayer_dbArray[recordIndex].prayerText = fields[2];
				}
				csvLineCount++;
			}
		}

		public static void PopulateScriptureClass( string path, int noRecords ) {
			int csvLineCount, recordIndex;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					recordIndex = csvLineCount - 1;

					ERClass.scripture_dbArray[recordIndex].scriptureID = Int32.Parse( fields[0] );
					ERClass.scripture_dbArray[recordIndex].bookIndex = Int32.Parse( fields[1] );
					ERClass.scripture_dbArray[recordIndex].chapterIndex = Int32.Parse( fields[2] );
					ERClass.scripture_dbArray[recordIndex].verseIndex = Int32.Parse( fields[3] );
					ERClass.scripture_dbArray[recordIndex].scriptureText = fields[4];
				}
				csvLineCount++;
			}
		}

		public static void CsvToStructs() {
			string path, csvName;
            int noRecords;

			Console.WriteLine( " Import Strt Time: " +  DateTime.Now  + "\n---" );

			csvName = "rosaryBead.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateRosaryBeadClass( path, noRecords );

			csvName = "bead.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateBeadClass( path, noRecords );

			csvName = "decade.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateDecadeClass( path, noRecords );

			csvName = "message.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateMessageClass( path, noRecords );

			csvName = "mystery.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateMysteryClass( path, noRecords );

			csvName = "prayer.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulatePrayerClass( path, noRecords );

			csvName = "scripture.csv";
			Console.WriteLine( " Importing: " + csvName + " ... ms: " + DateTime.Now.Millisecond );
            path = MyFunctions.CsvFilePath( csvName );
            noRecords = MyFunctions.RecordCount( path );
            MyFunctions.PopulateScriptureClass( path, noRecords );

			Console.WriteLine( "---\n Import End Time: " +  DateTime.Now + "\n" );
		}

	}

	public class RosaryMethods {

		public static string TodaysMysteryName() {
			int todayIndex = (int)DateTime.Now.DayOfWeek;

			switch( todayIndex ) {
				case 0 or 3:
					todayIndex = 4;
					break;
				case 1 or 6:
					todayIndex = 1;
					break;
				case 2 or 5:
					todayIndex = 3;
					break;
				case 4:
					todayIndex = 2;
					break;

			}
			string mysteryName = ERClass.mystery_dbArray[todayIndex].mysteryName;

			return mysteryName;
		}
	}

	public class CalendarCalculations {
		public static DateTime ReturnToday() {
			DateTime today = DateTime.Now;
			return today;
		}
	}
}
