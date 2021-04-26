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

	}

}
