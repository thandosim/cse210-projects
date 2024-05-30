public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public bool IsUsa()
    {
        return true;
    }

    public string GetAddressString()
    {
        return "";
    }
    

}