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

		public static void ParseCsvDemo( string path ) {
			bool isInt;
			int i, number;
			
			string[] readText = File.ReadAllLines(path);

			i=0;
			
			foreach( string record in readText ) {
				
				string[] fields = record.Split(';');
				
				foreach( string field in fields ) {
					
					isInt = Int32.TryParse(field, out number);
					
					if ( isInt ) {
						Console.WriteLine("["+i+"]field number= " + number);
					} else {
						Console.WriteLine("["+i+"]field string= " + field);
					}
				}
				
				i++;
			}
		}

		public static MyStructs.bead_t[] PopulateBeadClass( string path, int noRecords ) {
			int csvLineCount, noRecord;
			
			string[] readText = File.ReadAllLines( path );

			MyStructs.bead_t[] bead = new MyStructs.bead_t[noRecords];

			csvLineCount = 0;
			
			foreach( string record in readText ) {
				if ( csvLineCount > 0 ) {
						
					string[] fields = record.Split(';');
					noRecord = csvLineCount - 1;

					bead[noRecord].beadId = Int32.Parse( fields[0] );
					bead[noRecord].beadType = fields[1];
				}
				
				csvLineCount++;
			}

			return bead;
		}

	}
		
}
