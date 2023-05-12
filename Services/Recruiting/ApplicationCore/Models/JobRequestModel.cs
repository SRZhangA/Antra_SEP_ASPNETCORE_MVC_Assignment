namespace ApplicationCore.Models;

public class JobRequestModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public int NumbersOfPosotions { get; set; }
}
