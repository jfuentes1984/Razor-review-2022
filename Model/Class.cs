namespace Razor_review_2022.Model;

public class Class
{
    public int ClassId { get; set; }
    public string? Name { get; set; }
    public virtual School? School { get; set; }

}