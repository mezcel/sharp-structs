using System;
using System.IO; // Environment

namespace sharp_structs {

	public class MyFunctions {

		public static void GetOsInfo() {
            OperatingSystem os = Environment.OSVersion;

			Console.WriteLine( "Operation System Information" );
            Console.WriteLine("\tOS Version:   " + os.Version.ToString());
            Console.WriteLine("\tOS Platoform: " + os.Platform.ToString());
            Console.WriteLine("\tOS SP:        " + os.ServicePack.ToString());
            Console.WriteLine("\tOS Version String: " + os.VersionString.ToString());

            // Get Version details
            Version ver = os.Version;

            Console.WriteLine("Operating System Detaiils");
            Console.WriteLine("\tMajor version:  " + ver.Major);
            Console.WriteLine("\tMajor Revision: " + ver.MajorRevision);
            Console.WriteLine("\tMinor version:  " + ver.Minor);
            Console.WriteLine("\tMinor Revision: " + ver.MinorRevision);
            Console.WriteLine("\tBuild:          " + ver.Build);
			Console.WriteLine("");
		}

		public static string CsvFilePath ( string csvFileName ) {
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
				count++;
			}

			return count;
		}

		public static void PopulateRosaryBeadClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.rosaryBead_dbArray[noRecord].rosaryBeadID = Int32.Parse( fields[0] );
					ERClass.rosaryBead_dbArray[noRecord].beadIndex = Int32.Parse( fields[1] );
					ERClass.rosaryBead_dbArray[noRecord].decadeIndex = Int32.Parse( fields[2] );
					ERClass.rosaryBead_dbArray[noRecord].mysteryIndex = Int32.Parse( fields[3] );
					ERClass.rosaryBead_dbArray[noRecord].prayerIndex = Int32.Parse( fields[4] );
					ERClass.rosaryBead_dbArray[noRecord].scriptureIndex = Int32.Parse( fields[5] );
					ERClass.rosaryBead_dbArray[noRecord].messageIndex = Int32.Parse( fields[6] );
					ERClass.rosaryBead_dbArray[noRecord].loopBody = Int32.Parse( fields[7] );
					ERClass.rosaryBead_dbArray[noRecord].smallbeadPercent = Int32.Parse( fields[8] );
					ERClass.rosaryBead_dbArray[noRecord].mysteryPercent = Int32.Parse( fields[9] );

				}
				csvLineCount++;
			}
		}

		public static void PopulateBeadClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.bead_dbArray[noRecord].beadID = Int32.Parse( fields[0] );
					ERClass.bead_dbArray[noRecord].beadType = fields[1];
				}
				csvLineCount++;
			}
		}

		public static void PopulateBookClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.book_dbArray[noRecord].bookID = Int32.Parse( fields[0] );
					ERClass.book_dbArray[noRecord].bookName = fields[1];
					ERClass.book_dbArray[noRecord].library = fields[2];

				}
				csvLineCount++;
			}
		}

		public static void PopulateDecadeClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.decade_dbArray[noRecord].decadeID = Int32.Parse( fields[0] );
					ERClass.decade_dbArray[noRecord].mysteryIndex = Int32.Parse( fields[1] );
					ERClass.decade_dbArray[noRecord].decadeNo = Int32.Parse( fields[2] );
					ERClass.decade_dbArray[noRecord].decadeName = fields[3];
					ERClass.decade_dbArray[noRecord].decadeInfo = fields[4];
					ERClass.decade_dbArray[noRecord].infoRefference = fields[5];
				}
				csvLineCount++;
			}
		}

		public static void PopulateMessageClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.message_dbArray[noRecord].messageID = Int32.Parse( fields[0] );
					ERClass.message_dbArray[noRecord].mesageText = fields[1];
				}
				csvLineCount++;
			}
		}

		public static void PopulateMysteryClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.mystery_dbArray[noRecord].mysteryID = Int32.Parse( fields[0] );
					ERClass.mystery_dbArray[noRecord].mysteryNo = Int32.Parse( fields[1] );
					ERClass.mystery_dbArray[noRecord].mysteryName = fields[2];
				}
				csvLineCount++;
			}
		}

		public static void PopulatePrayerClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.prayer_dbArray[noRecord].prayerID = Int32.Parse( fields[0] );
					ERClass.prayer_dbArray[noRecord].prayerName = fields[1];
					ERClass.prayer_dbArray[noRecord].prayerText = fields[2];
				}
				csvLineCount++;
			}
		}

		public static void PopulateScriptureClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			string[] readText = File.ReadAllLines( path );

			csvLineCount = 0;

			foreach( string record in readText ) {
				if ( csvLineCount > 0 && csvLineCount < noRecords ) {
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					ERClass.scripture_dbArray[noRecord].scriptureID = Int32.Parse( fields[0] );
					ERClass.scripture_dbArray[noRecord].bookIndex = Int32.Parse( fields[1] );
					ERClass.scripture_dbArray[noRecord].chapterIndex = Int32.Parse( fields[2] );
					ERClass.scripture_dbArray[noRecord].verseIndex = Int32.Parse( fields[3] );
					ERClass.scripture_dbArray[noRecord].scriptureText = fields[4];
				}
				csvLineCount++;
			}
		}

		public static void CsvToStructs() {
			string path;
            int noRecords;

            path = MyFunctions.CsvFilePath( "rosaryBead.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateRosaryBeadClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "bead.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateBeadClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "book.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateBookClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "decade.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateDecadeClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "message.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateMessageClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "mystery.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateMysteryClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "prayer.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulatePrayerClass( path, noRecords );

            path = MyFunctions.CsvFilePath( "scripture.csv" );
            noRecords = MyFunctions.RecordCount( path ) - 1;
            MyFunctions.PopulateScriptureClass( path, noRecords );
		}

	}

}
