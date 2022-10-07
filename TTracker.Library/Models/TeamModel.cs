namespace TTracker.Library.Models;

public class TeamModel
{
    public int Id { get; set; }
    public string TeamName { get; set; }
    public List<UserModel> TeamMembers { get; set; }
}