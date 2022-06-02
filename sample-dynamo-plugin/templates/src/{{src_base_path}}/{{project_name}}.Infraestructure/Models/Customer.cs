using Amazon.DynamoDBv2.DataModel;

namespace {{project_name}}.Infrastructure; 

[DynamoDBTable("customers")]
public class Customer
{
    //Chave de Partição 
    [DynamoDBHashKey("id")]
    public string Id { get; set; }

    //Chave de Classificação
    [DynamoDBProperty("city")]
    public string City { get; set; }    

    [DynamoDBProperty("name")]
    public string Name { get; set; }
    
}