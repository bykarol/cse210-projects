public class Comment
{
  public string authorComment;
  public string commentDescription;
  public Comment(string authorC, string commentD)
  {
    authorComment = authorC;
    commentDescription = commentD;
  }

  public void displayComment()
  {
    Console.WriteLine($"{authorComment} says: \"{commentDescription}\"");
  }
}