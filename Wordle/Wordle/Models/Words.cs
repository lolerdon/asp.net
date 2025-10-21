namespace Wordle.Models;

public class Words
{
    public int Id { get; set; }
    required
    public string Letters
    { get; set; }
    required
    public string Lenght
    { get; set; }
    public DateTime CreatedAt { get; set; }
}