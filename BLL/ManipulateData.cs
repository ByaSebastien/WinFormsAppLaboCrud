using DAL;
using Models;
using Utility;

namespace BLL
{
    public static class ManipulateData
    {
        /// <summary>
        /// Bridge from BLL to DAL to read a file path and return a Ilist of suppliers.
        /// </summary>
        /// <param name="pPath">string file path</param>
        /// <returns>An Ilist of suppliers.</returns>
        /// <exception cref="Exception"></exception>
        public static IList<Supplier> ReadFileData(string pPath)
        {
            return FileDataAccess.ReadCsvFile(pPath);
        }
        /// <summary>
        /// Bridge from BLL to DAL to write an Ilist into a file
        /// </summary>
        /// <param name="pSuppliers">Ilist of suppliers</param>
        /// <param name="pPath">string file path</param>
        public static void WriteFileData(IList<Supplier>pSuppliers,string pPath)
        {
            FileDataAccess.WriteCsvFile(pSuppliers,pPath);
        }
    }
}