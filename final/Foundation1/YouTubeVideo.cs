public class YouTubeVideo
{
  public string title;
  public string author;
  public double duration;
  public List<Comment> comments = new List<Comment>();
  public int commentsNum;

  public YouTubeVideo(string videoTitle, string videoAuthor, double videoDuration)
  {
    title = videoTitle;
    author = videoAuthor;
    duration = videoDuration;
  }

  public void displayVideoSummary()
  {
    commentsNum = numberOfComments();
    Console.WriteLine($"-Title: {title} (duration: {duration} secs)\n-Posted by: {author}\n-This video has {commentsNum} comments:");
    for (int i = 0; i < comments.Count; i++)
    {
      Console.Write($"-- {i + 1}. ");
      comments[i].displayComment();
    }
  }

  public int numberOfComments()
  {
    return comments.Count;
  }
}