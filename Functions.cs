using System;
using System.IO; // Environment
using System.Text; // ReadAllLines
using Microsoft.VisualBasic.FileIO; // TextFieldParser

namespace sharp_structs {

	public class MyFunctions {
		
		public static void GetOsInfo() {
			Console.WriteLine( "Operation System Information" );
            Console.WriteLine("Operating System Detaiils");
            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine("OS Version: " + os.Version.ToString());
            Console.WriteLine("OS Platoform: " + os.Platform.ToString());
            Console.WriteLine("OS SP: " + os.ServicePack.ToString());
            Console.WriteLine("OS Version String: " + os.VersionString.ToString());            

            // Get Version details
            Version ver = os.Version;
            Console.WriteLine("Major version: " + ver.Major);
            Console.WriteLine("Major Revision: " + ver.MajorRevision);
            Console.WriteLine("Minor version: " + ver.Minor);
            Console.WriteLine("Minor Revision: " + ver.MinorRevision);
            Console.WriteLine("Build: " + ver.Build);
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
	}
		
}
