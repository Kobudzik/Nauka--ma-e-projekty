namespace Momento;

public class CustomerBetterMemento(
    int id,
    string name,
    string address,
    string city,
    string stateProvince,
    string postalCode)
{
    // This is the memento object, which holds the original values.
    private readonly CustomerMemento _customerMemento = new(name, address, city, stateProvince, postalCode);

    public int ID { get; set; } = id;
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;
    public string City { get; set; } = city;
    public string StateProvince { get; set; } = stateProvince;
    public string PostalCode { get; set; } = postalCode;

    public bool IsDirty
    {
        get
        {
            return Name != _customerMemento.Name ||
                   Address != _customerMemento.Address ||
                   City != _customerMemento.City ||
                   StateProvince != _customerMemento.StateProvince ||
                   PostalCode != _customerMemento.PostalCode;
        }
    }

    public void RevertToOriginalValues()
    {
        Name = _customerMemento.Name;
        Address = _customerMemento.Address;
        City = _customerMemento.City;
        StateProvince = _customerMemento.StateProvince;
        PostalCode = _customerMemento.PostalCode;
    }

    // This is one of the rare cases where you might declare more than one class in a file.
    // The CustomerMemento class will never be used any place, other than in the Customer class.
    // So, you can make it a private class inside the one class where it's used.
    // Or, you could put it in its own file, and declare it an internal or public class.
    private class CustomerMemento(string name, string address,
        string city, string stateProvince, string postalCode)
    {
        public string Name { get; } = name;
        public string Address { get; } = address;
        public string City { get; } = city;
        public string StateProvince { get; } = stateProvince;
        public string PostalCode { get; } = postalCode;
    }
}