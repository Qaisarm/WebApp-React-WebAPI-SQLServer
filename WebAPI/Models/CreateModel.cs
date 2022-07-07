using System.Text.Json.Serialization;

namespace WebAPI.Models;

public class CreateModel
{
    [JsonPropertyName("title")]
    public string? Title {get; set;}

 [JsonPropertyName("category")]
    public string? Category {get; set;}
 [JsonPropertyName("dateOpened")]
    public DateTime DateOpened { get; set; }
 [JsonPropertyName("expiryDate")]
       public DateTime ExpiryDate { get; set; }
   
}