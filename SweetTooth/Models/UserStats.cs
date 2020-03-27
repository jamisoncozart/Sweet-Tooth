namespace SweetTooth.Models
{
  public class UserStats
  {
    public int UserStatsId { get; set; }
    public int UserId { get; set; }
    public int TimesCreatedSweet { get; set; }
    public int TimesEdittedSweet { get; set; }
    public int TimesDeletedSweet { get; set; }
    public int TimesViewedSweet { get; set; }
  }
}