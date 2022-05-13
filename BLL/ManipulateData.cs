using DAL;
using Models;
using Utility;

namespace BLL
{
    public static class ManipulateData
    {
        public static void WriteFileData(IList<Supplier>pSuppliers,string pPath)
        {
            FileDataAccess.WriteCsvFile(pSuppliers,pPath);
        }
        public static IList<Supplier> ReadFileData(string pPath)
        {
            return FileDataAccess.ReadCsvFile(pPath);
        }
    }
}