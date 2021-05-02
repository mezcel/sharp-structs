/*
    Functions.cs
    About:
        Miscellaneous functions and methods.
*/

using System; // console
using System.IO; // Environment

namespace sharp_structs {
	public class PopulateER {

		public static void RosaryBead( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.RosaryBead.path 		    = path;
			ERClass.RosaryBead.attributeNames	= MyFunctions.ReturnHeaderArray( ERClass.RosaryBead.path );
			ERClass.RosaryBead.totalRecords 	= MyFunctions.RecordCount( ERClass.RosaryBead.path );

			string[] readText = File.ReadAllLines( ERClass.RosaryBead.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.RosaryBead.structRecords, ERClass.RosaryBead.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.RosaryBead.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.RosaryBead.structRecords[recordIndex].rosaryBeadID      = Int32.Parse( fields[0] );
					ERClass.RosaryBead.structRecords[recordIndex].beadIndex         = Int32.Parse( fields[1] );
					ERClass.RosaryBead.structRecords[recordIndex].decadeIndex       = Int32.Parse( fields[2] );
					ERClass.RosaryBead.structRecords[recordIndex].mysteryIndex      = Int32.Parse( fields[3] );
					ERClass.RosaryBead.structRecords[recordIndex].prayerIndex       = Int32.Parse( fields[4] );
					ERClass.RosaryBead.structRecords[recordIndex].scriptureIndex 	= Int32.Parse( fields[5] );
					ERClass.RosaryBead.structRecords[recordIndex].messageIndex      = Int32.Parse( fields[6] );
					ERClass.RosaryBead.structRecords[recordIndex].loopBody          = Int32.Parse( fields[7] );
					ERClass.RosaryBead.structRecords[recordIndex].smallbeadPercent 	= Int32.Parse( fields[8] );
					ERClass.RosaryBead.structRecords[recordIndex].mysteryPercent 	= Int32.Parse( fields[9] );
				}

				csvLineCount++;
			}
		}
		public static void Bead( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Bead.path 		    = path;
			ERClass.Bead.attributeNames	= MyFunctions.ReturnHeaderArray( ERClass.Bead.path );
			ERClass.Bead.totalRecords 	= MyFunctions.RecordCount( ERClass.Bead.path );

			string[] readText = File.ReadAllLines( ERClass.Bead.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Bead.structRecords, ERClass.Bead.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Bead.structRecords[recordIndex].beadID 	= Int32.Parse( fields[0] );
					ERClass.Bead.structRecords[recordIndex].beadType = fields[1];
				}

				csvLineCount++;
			}
		}

		public static void Book( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Book.path 		    = path;
			ERClass.Book.attributeNames	= MyFunctions.ReturnHeaderArray( ERClass.Book.path );
			ERClass.Book.totalRecords 	= MyFunctions.RecordCount( ERClass.Book.path );

			string[] readText = File.ReadAllLines( ERClass.Book.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Book.structRecords, ERClass.Book.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Book.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Book.structRecords[recordIndex].bookID   = Int32.Parse( fields[0] );
					ERClass.Book.structRecords[recordIndex].bookName = fields[1];
					ERClass.Book.structRecords[recordIndex].library  = fields[2];
				}

				csvLineCount++;
			}
		}

		public static void Decade( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Decade.path 		  = path;
			ERClass.Decade.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Decade.path );
			ERClass.Decade.totalRecords   = MyFunctions.RecordCount( ERClass.Decade.path );

			string[] readText = File.ReadAllLines( ERClass.Decade.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Decade.structRecords, ERClass.Decade.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Decade.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Decade.structRecords[recordIndex].decadeID      = Int32.Parse( fields[0] );
					ERClass.Decade.structRecords[recordIndex].mysteryIndex 	= Int32.Parse( fields[1] );
					ERClass.Decade.structRecords[recordIndex].decadeNo      = Int32.Parse( fields[2] );
					ERClass.Decade.structRecords[recordIndex].decadeName    = fields[3];
					ERClass.Decade.structRecords[recordIndex].decadeInfo    = fields[4];
					ERClass.Decade.structRecords[recordIndex].infoRefference = fields[5];
				}

				csvLineCount++;
			}
		}

		public static void Message( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Message.path 		   = path;
			ERClass.Message.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Message.path );
			ERClass.Message.totalRecords   = MyFunctions.RecordCount( ERClass.Message.path );

			string[] readText = File.ReadAllLines( ERClass.Message.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Message.structRecords, ERClass.Message.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Message.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Message.structRecords[recordIndex].messageID 	= Int32.Parse( fields[0] );
					ERClass.Message.structRecords[recordIndex].mesageText = fields[1];
				}

				csvLineCount++;
			}
		}

		public static void Mystery( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Mystery.path           = path;
			ERClass.Mystery.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Mystery.path );
			ERClass.Mystery.totalRecords   = MyFunctions.RecordCount( ERClass.Mystery.path );

			string[] readText = File.ReadAllLines( ERClass.Mystery.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Mystery.structRecords, ERClass.Mystery.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Mystery.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Mystery.structRecords[recordIndex].mysteryID    = Int32.Parse( fields[0] );
					ERClass.Mystery.structRecords[recordIndex].mysteryNo    = Int32.Parse( fields[1] );
					ERClass.Mystery.structRecords[recordIndex].mysteryName  = fields[2];
				}

				csvLineCount++;
			}
		}

		public static void Prayer( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Prayer.path 		  = path;
			ERClass.Prayer.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Prayer.path );
			ERClass.Prayer.totalRecords   = MyFunctions.RecordCount( ERClass.Prayer.path );

			string[] readText = File.ReadAllLines( ERClass.Prayer.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Prayer.structRecords, ERClass.Prayer.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Prayer.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Prayer.structRecords[recordIndex].prayerID   = Int32.Parse( fields[0] );
					ERClass.Prayer.structRecords[recordIndex].prayerName = fields[1];
					ERClass.Prayer.structRecords[recordIndex].prayerText = fields[2];
				}

				csvLineCount++;
			}
		}

        public static void Scripture( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Scripture.path 		     = path;
			ERClass.Scripture.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Scripture.path );
			ERClass.Scripture.totalRecords   = MyFunctions.RecordCount( ERClass.Scripture.path );

			string[] readText = File.ReadAllLines( ERClass.Scripture.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Scripture.structRecords, ERClass.Scripture.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Scripture.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Scripture.structRecords[recordIndex].scriptureID    = Int32.Parse( fields[0] );
					ERClass.Scripture.structRecords[recordIndex].bookIndex      = Int32.Parse( fields[1] );
					ERClass.Scripture.structRecords[recordIndex].chapterIndex   = Int32.Parse( fields[2] );
					ERClass.Scripture.structRecords[recordIndex].verseIndex     = Int32.Parse( fields[3] );
					ERClass.Scripture.structRecords[recordIndex].scriptureText  = fields[4];
				}

				csvLineCount++;
			}
		}

        public static void Feast( string path ) {

			int csvLineCount  = 0;
			int recordIndex   = 0;

            // Update Class info
			ERClass.Feast.path 		     = path;
			ERClass.Feast.attributeNames = MyFunctions.ReturnHeaderArray( ERClass.Scripture.path );
			ERClass.Feast.totalRecords   = MyFunctions.RecordCount( ERClass.Feast.path );

			string[] readText = File.ReadAllLines( ERClass.Feast.path );

			// Resize Array of record structs from initial array size [0]
			Array.Resize( ref ERClass.Feast.structRecords, ERClass.Feast.totalRecords );

			foreach( string record in readText ) {
				if ( record.Trim() == "" ) { continue; }

				if ( csvLineCount > 0 && csvLineCount <= ERClass.Feast.totalRecords ) {
					string[] fields = record.Split(';');
					recordIndex     = csvLineCount - 1;

					ERClass.Feast.structRecords[recordIndex].feastID    = Int32.Parse( fields[0] );
					ERClass.Feast.structRecords[recordIndex].feastName  = fields[1];
					ERClass.Feast.structRecords[recordIndex].feastDay   = Int32.Parse( fields[2] );
					ERClass.Feast.structRecords[recordIndex].feastMonth = Int32.Parse( fields[3] );
					ERClass.Feast.structRecords[recordIndex].monthName  = fields[4];
				}

				csvLineCount++;
			}
		}
	}

	public class MyFunctions {

		public static void GetOsInfo() {
            OperatingSystem os = Environment.OSVersion;

			Console.WriteLine( "# Operation System Information" );
            Console.WriteLine("\tOS Version:   " + os.Version.ToString());
            Console.WriteLine("\tOS Platform: " + os.Platform.ToString());
            Console.WriteLine("\tOS SP:        " + os.ServicePack.ToString());
            Console.WriteLine("\tOS Version String: " + os.VersionString.ToString());
			Console.WriteLine("");

            // Get Version details
            Version ver = os.Version;

            Console.WriteLine("# Operating System Details");
            Console.WriteLine("\tMajor version:  " + ver.Major);
            Console.WriteLine("\tMajor Revision: " + ver.MajorRevision);
            Console.WriteLine("\tMinor version:  " + ver.Minor);
            Console.WriteLine("\tMinor Revision: " + ver.MinorRevision);
            Console.WriteLine("\tBuild:          " + ver.Build);
			Console.WriteLine("");
		}

		public static string CsvFilePath( string csvBaseName ) {
			string currentDir, myOs, path;

            OperatingSystem os = Environment.OSVersion;

			currentDir = Directory.GetCurrentDirectory();
            myOs       = os.Platform.ToString();

            if ( myOs == "Unix" ) {
				currentDir+= @"/database/csv/";
			} else {
				currentDir+= @"\database\csv\";
			}

			path = currentDir + csvBaseName;

			return path;
		}

		public static int RecordCount( string path ) {
			int count = 0;
			string[] readText = File.ReadAllLines(path);

			foreach( string s in readText ) {
				if ( s.Trim() == "" ) { continue; } // skip empty lines
				count++;
			}
            count--;

			return count;
		}

		public static int FieldCount( string path ) {
			int count = 0;

			string[] readText = File.ReadAllLines(path);
			string[] fields   = readText[0].Split(';');

			count = fields.Length;

			return count;
		}

		public static string[] ReturnHeaderArray( string path ) {
			System.IO.StreamReader readFile = new System.IO.StreamReader( path );
			string readLine = readFile.ReadLine();
			string[] fields = readLine.Split(';');

			// remove doublequotes return only the attr name
			// input string format "clasName.classAttrName"
			int i = 0;
			foreach ( string attr in fields ) {
				fields[i] = attr.Split('.')[1].Replace( "\"", string.Empty ).Trim();
				i++;
			}

			return fields;
		}

		public static void ImportCsvDatabase() {
            // astDiffSume csvs are contained within ".\database\csv\*.csv"
			string path, csvName;
            DateTime t0, t1;
            TimeSpan tDiffSum, tDiff;

            t0 = t1 = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum = t0 - t0;
			Console.WriteLine( " Import Start Time:\t" + DateTime.Now + "\tTimeSpan: " + tDiffSum + "\t\tms:" + tDiffSum.Milliseconds  + "\n---" );

			csvName = "rosaryBead.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.RosaryBead( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "bead.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Bead( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "book.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Book( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "decade.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Decade( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "message.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Message( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "mystery.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Mystery( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "prayer.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Prayer( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "scripture.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Scripture( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			csvName = "feast.csv";
            t0      = DateTime.Now;
            path    = MyFunctions.CsvFilePath( csvName );
            PopulateER.Feast( path );
            t1       = DateTime.Now;
            tDiff    = t1 - t0;
            tDiffSum += tDiff;
			Console.WriteLine( " Importing: " + csvName + "\t\t...\t\tTimeSpan: " + tDiff + "\tms:" + tDiff.Milliseconds );

			Console.WriteLine( "---\n Import End Time:\t" +  DateTime.Now + "\tTimeSpan: " + tDiffSum + "\tms:" + tDiffSum.Milliseconds  + "\n" );
		}

	}

}