namespace LocalizaApp.Domain;

public class Customer
{
    public Customer(string id, string city, string name)
    {
        Id = id;
        City = city;
        Name = name;
    }
    public string Id { get; private set; }

    public string City { get; private set; }    

    public string Name { get; private set; }
    
}