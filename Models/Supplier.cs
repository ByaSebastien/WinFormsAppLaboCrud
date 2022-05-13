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
        public Supplier()
        {
        }
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
        public void ModifyAllProp(string name, string phoneNumber, string emailAddress, string city, bool ordered)
        {
            ModifyName(name);
            ModifyPhoneNumber(phoneNumber);
            ModifyEmailAddress(emailAddress);
            ModifyCity(city);
            ModifyOrdered(ordered);
        }
        public void ModifyName(string name)
        {
            Name = name;
        }
        public void ModifyPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void ModifyEmailAddress(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public void ModifyCity(string city)
        {
            City = city;
        }
        public void ModifyOrdered(bool ordered)
        {
            Ordered = ordered;
        }
    }
}