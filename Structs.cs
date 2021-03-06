/*
    Structs.cs
    About:
        ER Database objects
        Define entity classes
*/

namespace sharp_structs {

	public class ERClass {

		public class RosaryBead {
			public static string csvBaseName = "rosaryBead.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct rosaryBead_t {
				public int rosaryBeadID;
				public int beadIndex;
				public int decadeIndex;
				public int mysteryIndex;
				public int prayerIndex;
				public int scriptureIndex;
				public int messageIndex;
				public int loopBody;
				public int smallbeadPercent;
				public int mysteryPercent;
			}
			public static rosaryBead_t[] structRecords = new rosaryBead_t[ totalRecords ];
                // Array.Resize( ref ERClass.RosaryBead.structRecords, ERClass.RosaryBead.totalRecords );
		}

		public class Bead {
			/* ER Class Struct: Bead */

			public static string csvBaseName = "bead.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct bead_t {
				public int beadID;
				public string beadType;
			}
			public static bead_t[] structRecords = new bead_t[ totalRecords ];
                // Array.Resize( ref ERClass.Bead.structRecords, ERClass.Bead.totalRecords );
		}

		public class Book {
			public static string csvBaseName = "book.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct book_t {
				public int bookID;
				public string bookName;
				public string library;
			}
			public static book_t[] structRecords = new book_t[ totalRecords ];
                // Array.Resize( ref ERClass.Book.structRecords, ERClass.Book.totalRecords );
		}

		public class Decade {
			public static string csvBaseName = "decade.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct decade_t {
				public int decadeID;
				public int mysteryIndex;
				public int decadeNo;
				public string decadeName;
				public string decadeInfo;
				public string infoRefference;
			}
			public static decade_t[] structRecords = new decade_t[ totalRecords ];
                // Array.Resize( ref ERClass.Decade.structRecords, ERClass.Decade.totalRecords );
		}

		public class Message {
			public static string csvBaseName = "message.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct message_t {
				public int messageID;
				public string mesageText;
			}
			public static message_t[] structRecords = new message_t[ totalRecords ];
                // Array.Resize( ref ERClass.Message.structRecords, ERClass.Message.totalRecords );
		}

		public class Mystery {
			/* ER Class Struct: Bead */

			public static string csvBaseName = "mystery.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct mystery_t {
				public int mysteryID;
				public int mysteryNo;
				public string mysteryName;
			}
			public static mystery_t[] structRecords = new mystery_t[ totalRecords ];
                // Array.Resize( ref ERClass.Mystery.structRecords, ERClass.Mystery.totalRecords );
		}

		public class Prayer {
			/* ER Class Struct: Bead */

			public static string csvBaseName = "prayer.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct prayer_t {
				public int prayerID;
				public string prayerName;
				public string prayerText;
			}
			public static prayer_t[] structRecords = new prayer_t[ totalRecords ];
                // Array.Resize( ref ERClass.Prayer.structRecords, ERClass.Prayer.totalRecords );
		}

		public class Scripture {
			/* ER Class Struct: Bead */

			public static string csvBaseName = "scripture.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct scripture_t {
				public int scriptureID;
				public int bookIndex;
				public int chapterIndex;
				public int verseIndex;
				public string scriptureText;
			}
			public static scripture_t[] structRecords = new scripture_t[ totalRecords ];
                // Array.Resize( ref ERClass.Scripture.structRecords, ERClass.Scripture.totalRecords );
		}

		public class Feast {
			/* ER Class Struct: Bead */

			public static string csvBaseName = "feast.csv";
			public static string path; 				// = MyFunctions.CsvFilePath( csvBaseName );
			public static string[] attributeNames; 	// = MyFunctions.ReturnHeaderArray( path );
			public static int totalRecords = 0;     // = MyFunctions.RecordCount( path );

			// Attribute metadata
			public struct feast_t {
				public int feastID;
				public string feastName;
				public int feastDay;
				public int feastMonth;
				public string monthName;
			}
			public static feast_t[] structRecords = new feast_t[ totalRecords ];
                // Array.Resize( ref ERClass.Feast.structRecords, ERClass.Feast.totalRecords );
		}

	}

    public class ERView {
        public struct meditationPoint_t {
				public static int rosaryBeadID = 0;
                public static string beadType;
				public static string decadeName;
				public static string decadeInfo;
				public static int mysteryNo;
				public static string mysteryName;
				public static string prayerName;
				public static string prayerText;
				public static string scriptureText;
				public static string mesageText;
				public static int loopBody;
				public static int smallbeadPercent;
				public static int mysteryPercent;

        }
    }

}
