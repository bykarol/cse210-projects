using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("***********************");
    Console.WriteLine("Tracking YouTube Videos");
    Console.WriteLine("***********************");
    List<YouTubeVideo> videos = new List<YouTubeVideo>();
    //Video 1 - instance of YouTubeVideo class
    YouTubeVideo video1 = new YouTubeVideo("Learn how to drink water", "John Doe", 210);
    //video 1 creating comments
    Comment v1Comment1 = new Comment("@dankjista", "I was very thirsty and I forgot how to drink water since I was 10 years old. Thank you much star fishy for making me relive my glory days of drinking water once again");
    Comment v1Comment2 = new Comment("@amispo429", "I could have never drank water without these instructions!! Thanks for the tips");
    Comment v1Comment3 = new Comment("@voltage4176", "I now can drink water like a pro, thanks for the tip!");
    Comment v1Comment4 = new Comment("@CloudFizzle", "Thanks for letting me know the basics! I always ate it by chewing it!");
    //adding comments to the list of comments of video1
    video1.comments.Add(v1Comment1);
    video1.comments.Add(v1Comment2);
    video1.comments.Add(v1Comment3);
    video1.comments.Add(v1Comment4);
    //adding video1 to a list of videos
    videos.Add(video1);
    //same proceed for the next videos
    //Video 2
    YouTubeVideo video2 = new YouTubeVideo("Easy water purification secret", "Jane Doe", 500);
    Comment v2Comment1 = new Comment("@ewtoudoors", "Good tip and I think people should remember that this is a survival tip, not your drinking water for the next 20 years. Take care and thanks.");
    Comment v2Comment2 = new Comment("@JesterBushcraft", "A great tip, worth knowing if you ever need to rely on it. Great video");
    Comment v2Comment3 = new Comment("@thesjbother", "Would this work with glass bottles?");
    video2.comments.Add(v2Comment1);
    video2.comments.Add(v2Comment2);
    video2.comments.Add(v2Comment3);
    videos.Add(video2);
    //Video 3
    YouTubeVideo video3 = new YouTubeVideo("What happens if you don't drink water?", "Jiminy Cricket", 300);
    Comment v3Comment1 = new Comment("@demostudios6474", "I thought, If I need water, I'll feel thirsty. But apparently, that's not the case.");
    Comment v3Comment2 = new Comment("@DumAndddDummer", "I just learned more than I did in this 5 minutes than 8 hours at school");
    Comment v3Comment3 = new Comment("@kellykerr1228", "Water is my favorite drink. I drink it all day every day");
    video3.comments.Add(v3Comment1);
    video3.comments.Add(v3Comment2);
    video3.comments.Add(v3Comment3);
    videos.Add(video3);
    //Video 4
    YouTubeVideo video4 = new YouTubeVideo("How to conserve water", "Someone Else", 8.3);
    Comment v4Comment1 = new Comment("@woocheongan1437", "I hope more people will see this video and change their current status of water use. Water resources are precious and scarce");
    Comment v4Comment2 = new Comment("@akshaysehgal8944", "I need to be on that team. To do things that people neglect in daily life");
    Comment v4Comment3 = new Comment("@SM-1010", "The sad thing is, there are people who think there is no such thing as wasting water");
    Comment v4Comment4 = new Comment("@subhicshas7553", "Using the shower water to flush toilets is a genius idea . I want more and more people to promote it");
    video4.comments.Add(v4Comment1);
    video4.comments.Add(v4Comment2);
    video4.comments.Add(v4Comment3);
    video4.comments.Add(v4Comment4);
    videos.Add(video4);

    //iterating through the list of videos and display info of each of them
    foreach (YouTubeVideo video in videos)
    {
      video.displayVideoSummary();
      Console.WriteLine("***********************");
    }
  }
}