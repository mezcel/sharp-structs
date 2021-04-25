using System;
using System.IO;
//using System.Collections.Generic;

namespace Csv_to_Struct {

	class MyStructs {
		/*
		* Data Structures
		* Structs which server as ER Database Classes
		* Scripture Rosary Database
		* */

		/* ER Class Struct: Rosary Bead */
		struct rosaryBead_struct {
			int rosaryBeadID;
			int beadIndex;
			int decadeIndex;
			int mysteryIndex;
			int prayerIndex;
			int scriptureIndex;
			int messageIndex;
			int loopBody;
			int smallbeadPercent;
			int mysteryPercent;
		} 

		/* ER Class Struct: Bead */
		struct bead_struct {
			int beadID;
			string beadType;
		} 

		/* ER Class Struct: Book */
		struct book_struct {
			int bookID;
			string bookName;
			string library;
		} 

		/* ER Class Struct: Decade */
		struct decade_struct {
			int decadeID;
			int mysteryIndex;
			int decadeNo;
			string decadeName;
			string decadeInfo;
			string infoRefference;
		} 

		/* ER Class Struct: Message */
		struct message_struct {
			int messageID;
			string mesageText;
		} 

		/* ER Class Struct: Mystery */
		struct mystery_struct {
			int mysteryID;
			int mysteryNo;
			string mysteryName;
		} 

		/* ER Class Struct: Prayer */
		struct prayer_struct {
			int prayerID;
			string prayerName;
			string prayerText;
		} 

		/* ER Class Struct: Scripture */
		struct scripture_struct {
			int scriptureID;
			int bookIndex;
			int chapterIndex;
			int verseIndex;
			string scriptureText;
		} 

		/* ER Database Struct: Scripture Rosary Database */
		struct rosary_db {
			// one must know beforehand how big each array needs to be

			rosaryBead_t rosaryBead_dbArray[317];
			bead_t bead_dbArray[9];
			book_t book_dbArray[17];
			decade_t decade_dbArray[22];
			message_t message_dbArray[22];
			mystery_t mystery_dbArray[7];
			prayer_t prayer_dbArray[11];
			scripture_t scripture_dbArray[202];
		} 

		/*
		* Feast day mini db
		* Additional ER Class for the feast day database
		* */

		/* ER Class Struct: Feast */
		struct feast_struct {
			int feastID;
			string feastName;
			int feastDay;
			int feastMonth;
			string monthName;
		} 

		/* ER Database Struct: Feast Day Database */
		struct feast_db {
			// one must know beforehand how many records are there
			feast_t feast_dbArray[100]; // this will accomidate 100 feasts records
		} feast_db_t;
	}
    
    class Program {
        private const string databseDir = @"C:\Users\mezcel\Downloads\Csv-to-Struct\database\csv\";

        public static int ReturnRecordCount( string path ) {
			var lineCount = 0;

			using ( var reader = File.OpenText( path ) ) {
				while (reader.ReadLine() != null) {
					lineCount++;
				}
			}
			
			return lineCount;

		}

		public static string[] ReturnHeaderArray( string path ) {
			var reader 			 = File.OpenText( path );
			string header 		 = reader.ReadLine();
			string[] headerArray = header.Split(';');

			return headerArray;
		}

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
			
			string path = databseDir + "book.csv";
			int lineCount = ReturnRecordCount( path );

            Console.WriteLine( "\npath: " + path + "\nlineCount: " + lineCount );

			string[] headerArray = ReturnHeaderArray( path );

            Console.WriteLine( "\npath: " + path + "\nheaderArray.Length: " + headerArray.Length);

			int i=0;
			foreach(var item in headerArray)
			{
				Console.WriteLine("\theaderArray[" + i + "]: " + item.ToString());
				i++;
			}

        }

    }
}
