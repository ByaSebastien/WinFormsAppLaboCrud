using LINQtoCSV;
using Models;
using Utility;

namespace DAL
{
    public static class FileDataAccess
    {
        /// <summary>
        /// Contact DAL to read a file path and return a Ilist of suppliers.
        /// </summary>
        /// <param name="pPath">string file path</param>
        /// <returns>An Ilist of suppliers.</returns>
        /// <exception cref="Exception"></exception>
        public static IList<Supplier> ReadCsvFile(string pPath)
        {
            try
            {
                CsvFileDescription csvFileDescription = new CsvFileDescription
                {
                    FirstLineHasColumnNames = true,
                    IgnoreUnknownColumns = true,
                    SeparatorChar = ';',
                };
                CsvContext csvContext = new CsvContext();
                var suppliers = csvContext.Read<Supplier>(pPath, csvFileDescription);
                return suppliers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Format du csv incompatible");
            }
            return null;
        }
        /// <summary>
        /// Contact DAL to write an Ilist into a file
        /// </summary>
        /// <param name="pSuppliers">Ilist of suppliers</param>
        /// <param name="pPath">string file path</param>
        public static void WriteCsvFile(IList<Supplier> pSuppliers, string pPath)
        {
            CsvFileDescription csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
            };
            CsvContext csvContext = new CsvContext();
            csvContext.Write(pSuppliers, pPath, csvFileDescription);
        }
    }
}