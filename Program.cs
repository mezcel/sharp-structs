using System; // console

namespace sharp_structs {

    class Program {

        static void Main(string[] args) {
            Console.Clear();

            MyFunctions.GetOsInfo();

			string path = MyFunctions.CsvFilePath( "bead.csv" );

            int noRecords = MyFunctions.RecordCount( path ) - 1;


            MyFunctions.PopulateBeadClass( path, noRecords );

            // demo ER Class
            int i = 0;
            foreach( MyStructs.bead_t bead in ERClass.bead_dbArray ) {
                Console.WriteLine("ERClass.bead_dbArray[" + i + "].beadID = " + ERClass.bead_dbArray[i].beadID );
                Console.WriteLine("\tERClass.bead_dbArray[" + i + "].beadType = " + ERClass.bead_dbArray[i].beadType );
                i++;
            }

        }
    }
}
