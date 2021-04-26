using System; // console

namespace sharp_structs {
	
    class Program {
		
        static void Main(string[] args) {
            //Console.Clear();
			
			string path = MyFunctions.CsvFilePath( "bead.csv" );

			//bead_t[] beadStruct = new bead_t[8];

			int recordCount = MyFunctions.RecordCount( path );
			
			MyFunctions.ParseCsvDemo( path );

        }
    }
}
