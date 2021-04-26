using System; // console

namespace sharp_structs {
	
    class Program {
		
        static void Main(string[] args) {
            Console.Clear();
			
			string path = MyFunctions.CsvFilePath( "bead.csv" );
			
			//MyFunctions.ParseCsvDemo( path );

            int noRecords = MyFunctions.RecordCount( path ) - 1;
            MyStructs.bead_t[] bead = MyFunctions.PopulateBeadClass( path, noRecords );

            foreach( MyStructs.bead_t bead_t in bead ){
                Console.WriteLine( "bead_t.beadId = " + bead_t.beadId + ", bead_t.beadType = " + bead_t.beadType );
            }

        }
    }
}
