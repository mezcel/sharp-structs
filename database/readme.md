# CSV from [printf-time.git](https://github.com/mezcel/printf-time.git)

## 1.0 Rosary Database

There are two database file types.
* A CSV database featuring English quotations
* A JSON version featuring Latin quotations.

## 2.0 CSV
### 2.1 The CSV is a multi file database.

* Developed for use on Win10 and Linux
* Contains English translations

### 2.1 Data Structures limitation ( feast.csv )

* Feast database must be within 100 records long.
    * Number of feast days <= 100
    <!--* ```feast_t feast_dbArray[100];```-->
* Each record needs to be within 100 chars long
    <!--* ```csvToStruct_feast( feast_db_struct, 100, filePath );```-->

### 2.2 User Defined Feast Days

* I made a standalone CSV file for static feast days.
    * Note: Feast days that designate the Liturgical calendar are embedded into the code. Adding those days are redundant.
* The user may add their own additional days.
* Edit the [sharp-structs/database/csv/feast.csv](csv/feast.csv) file.
    * Note: January starts at month 0, not 1.
