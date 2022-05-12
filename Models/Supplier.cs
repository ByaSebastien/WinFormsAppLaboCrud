using Utility;

namespace Models
{
    public class Supplier
    {
        private static int _ID = 1;

        private string _Name;
        private string _PhoneNumber;
        private string _EmailAddress;
        private string _City;
        private bool _Ordered;
        private Supplier supplier;

        public int ID { get; }
        public string Name
        {
            get { return _Name; }
            set { _Name = ValidationUtility.ValidName(value) ? value : throw new InvalidDataException("Nom invalide"); }
        }
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = ValidationUtility.ValidPhoneNumber(value) ? value : throw new InvalidDataException("Numéro de téléphone nonvalide"); }
        }
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = ValidationUtility.ValidEmailAddress(value) ? value : throw new InvalidDataException("Email non valide"); }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public bool Ordered
        {
            get { return _Ordered; }
            set { _Ordered = value; }
        }
        public Supplier(string name, string phoneNumber, string emailAddress, string city, bool ordered)
        {
            ID = _ID++;
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            City = city;
            Ordered = ordered;
        }

        public Supplier(Supplier supplier)
        {
            ID =supplier.ID;
            Name = supplier.Name;
            PhoneNumber = supplier.PhoneNumber;
            EmailAddress = supplier.EmailAddress;
            City = supplier.City;
            Ordered = supplier.Ordered;
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