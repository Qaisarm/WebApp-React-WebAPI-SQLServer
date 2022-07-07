namespace WebAPI.Models;

public class ActivityModel
{
    public int Id {get; set;}
    public string? Title {get; set;}
     public string? Category {get; set;}

      public DateTime DateOpened { get; set; }

       public DateTime ExpiryDate { get; set; }
}