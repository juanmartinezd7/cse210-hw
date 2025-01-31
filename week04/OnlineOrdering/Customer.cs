

using System.Net.Sockets;

class Customer
{
    private string _customerName;
    private Address _address;


    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

    public string GetShippingLabel()
    {
        return $"{_customerName}\n{_address.GetFullAddress()}";
    }

}