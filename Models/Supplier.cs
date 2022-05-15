using Utility;
using LINQtoCSV;

namespace Models
{
    public class Supplier
    {
        public static int _ID = 1;

        private string _Name;
        private string _PhoneNumber;
        private string _EmailAddress;
        private string _City;
        private bool _Ordered;

        [CsvColumn(Name = "ID")]
        public int ID { get; private set; }
        [CsvColumn(Name = "Nom")]
        public string Name
        {
            get { return _Name; }
            set { _Name = ValidationUtility.ValidName(value) ? value : throw new InvalidDataException("Nom invalide"); }
        }
        [CsvColumn(Name = "Telephone")]
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = ValidationUtility.ValidPhoneNumber(value) ? value : throw new InvalidDataException("Numéro de téléphone nonvalide"); }
        }
        [CsvColumn(Name = "Adresse email")]
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = ValidationUtility.ValidEmailAddress(value) ? value : throw new InvalidDataException("Email non valide"); }
        }
        [CsvColumn(Name = "Ville")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        [CsvColumn(Name = "Commande")]
        public bool Ordered
        {
            get { return _Ordered; }
            set { _Ordered = value; }
        }
        [CsvColumn(Name = "Date de moddification",OutputFormat = "dd-MM-yyyy HH:mm")]
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// Initializes a new instance of the Models.Supplier class that
        /// is empty and has the default initial capacity.
        /// </summary>
        public Supplier()
        {
        }
        /// <summary>
        /// Initializes a new instance of the Models.Supplier class with all properties
        /// </summary>
        public Supplier(string name, string phoneNumber, string emailAddress, string city, bool ordered)
        {
            ID = _ID++;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            City = city;
            Ordered = ordered;
            CreationDateTime = DateTime.Now;
        }
    }
}