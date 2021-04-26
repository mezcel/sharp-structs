
namespace sharp_structs {

	public class MyStructs {

		/* ER Class Struct: Rosary Bead */
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

		/* ER Class Struct: Bead */
		public struct bead_t {
			public int beadID;
			public string beadType;
		}

		/* ER Class Struct: Book */
		public struct book_t {
			public int bookID;
			public string bookName;
			public string library;
		}

		/* ER Class Struct: Decade */
		public struct decade_t {
			public int decadeID;
			public int mysteryIndex;
			public int decadeNo;
			public string decadeName;
			public string decadeInfo;
			public string infoRefference;
		}

		/* ER Class Struct: Message */
		public struct message_t {
			public int messageID;
			public string mesageText;
		}

		/* ER Class Struct: Mystery */
		public struct mystery_t {
			public int mysteryID;
			public int mysteryNo;
			public string mysteryName;
		}

		/* ER Class Struct: Prayer */
		public struct prayer_t {
			public int prayerID;
			public string prayerName;
			public string prayerText;
		}

		/* ER Class Struct: Scripture */
		public struct scripture_t {
			public int scriptureID;
			public int bookIndex;
			public int chapterIndex;
			public int verseIndex;
			public string scriptureText;
		}

	}

	public class ERClass {

		public static MyStructs.rosaryBead_t[] rosaryBead_dbArray = new MyStructs.rosaryBead_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "rosaryBead.csv" ) ) - 1 ];
		public static MyStructs.bead_t[] bead_dbArray = new MyStructs.bead_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "bead.csv" ) ) - 1 ];
		public static MyStructs.book_t[] book_dbArray = new MyStructs.book_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "book.csv" ) ) - 1 ];
		public static MyStructs.decade_t[] decade_dbArray = new MyStructs.decade_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "decade.csv" ) ) - 1 ];
		public static MyStructs.message_t[] message_dbArray = new MyStructs.message_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "message.csv" ) ) - 1 ];
		public static MyStructs.mystery_t[] mystery_dbArray = new MyStructs.mystery_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "mystery.csv" ) ) - 1 ];
		public static MyStructs.prayer_t[] prayer_dbArray = new MyStructs.prayer_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "prayer.csv" ) ) - 1 ];
		public static MyStructs.scripture_t[] scripture_dbArray = new MyStructs.scripture_t[ MyFunctions.RecordCount( MyFunctions.CsvFilePath( "scripture.csv" ) ) - 1 ];
	}
}
