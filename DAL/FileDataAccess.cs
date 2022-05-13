using LINQtoCSV;
using Models;
using Utility;

namespace DAL
{
    public static class FileDataAccess
    {
        public static IList<Supplier> ReadCsvFile(string pPath)
        {
            CsvFileDescription csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
            };
            CsvContext csvContext = new CsvContext();
            var suppliers = csvContext.Read<Supplier>(pPath,csvFileDescription);
            return suppliers.ToList();
        }
        public static void WriteCsvFile(IList<Supplier>pSuppliers,string pPath)
        {
            CsvFileDescription csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
            };
            CsvContext csvContext = new CsvContext();
            csvContext.Write(pSuppliers,pPath,csvFileDescription);
        }
    }
}