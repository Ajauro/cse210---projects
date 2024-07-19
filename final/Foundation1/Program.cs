using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando vídeos
        Video video1 = new Video("Learning C#", "Lídia", 600);
        Video video2 = new Video("Come to Christ", "James", 800);
        Video video3 = new Video("Learning Python", "Scott", 1200);
        Video video4 = new Video("Cooking Class", "Ronald", 2000);

        // Adicionando comentários aos vídeos
        video1.AddComment(new Comment("John", "Thank you, that's very informative."));
        video1.AddComment(new Comment("Betina", "Now it makes more sense, thanks for the explanation."));
        video1.AddComment(new Comment("Breno", "Why is the video so short? I wanna learn more, you teach very well."));

        video2.AddComment(new Comment("Jax", "I really love this video!"));
        video2.AddComment(new Comment("Maia", "I feel so good watching this video."));
        video2.AddComment(new Comment("Louise", "I wanna know more about this message."));

        video3.AddComment(new Comment("Nikki", "Python looks easy with this explanation."));
        video3.AddComment(new Comment("Meg", "Great video!"));
        video3.AddComment(new Comment("Johnny", "Your videos help me a lot"));

        video4.AddComment(new Comment("Joyce", "I really like your tips."));
        video4.AddComment(new Comment("Diana", "I will try this recipe."));
        video4.AddComment(new Comment("Cole", "Looks delicious!"));

        // Colocando os vídeos numa lista
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Exibindo informações sobre os vídeos
        foreach (var video in videos)
        {
            Console.WriteLine(video);
        }
    }
}