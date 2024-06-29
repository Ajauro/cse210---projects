using System;
using System.Collections.Generic;
using System.Linq;

class Program
{   
    static void Main(string[] args)
    {   
        
        // Initialize the list of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {   
            //Showing Creativity and Exceeding Requirements
            //Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that He gave his one and only Son that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Moses", 1, 39), "This is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Moses", 7, 18), "The Lord called his people Zion, because they were of one heart and one mind."),
            new Scripture(new Reference("Genesis", 1, 26, 27), "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Malachi", 4, 5, 6), "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord: And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse."),
            new Scripture(new Reference("Matthew", 11, 28, 30), "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),
            new Scripture(new Reference("2 Nephi", 28, 30), "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have."),
            new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
            new Scripture(new Reference("Doctrine and Covenants", 19, 16, 19), "For behold, I, God, have suffered these things for all, that they might not suffer if they would repent; But if they would not repent they must suffer even as I; Which suffering caused myself, even God, the greatest of all, to tremble because of pain, and to bleed at every pore, and to suffer both body and spirit—and would that I might not drink the bitter cup, and shrink— Nevertheless, glory be to the Father, and I partook and finished my preparations unto the children of men."),
            new Scripture(new Reference("3 Nephi", 11, 10, 11), "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.")
            // Add more scriptures as needed
        };

        Random random = new Random();

        while (true)
        {
            // Select a random scripture
            Scripture scripture = scriptures[random.Next(scriptures.Count)];
            
            Console.Clear();
            Console.WriteLine(scripture.GetFullText());

            Console.Write("Press 'enter' to hide the words or type 'quit' to finish ");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            while (true)
            {
                Console.Clear();
                scripture.HideRandomWords(2);
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All the words are hidden. Finish");
                    break;
                }

                Console.Write("\nPress 'enter' to hide the words or type 'quit' to finish ");
                input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                {
                    return;
                }
            }
            //Showing Creativity and Exceeding Requirements
            //perguntar ao usuario se ele gostaria de memorizare mais escrituras
            Console.Write("\nWould you like to memorize another scripture? (s/n) ");
            input = Console.ReadLine();
            if (input.Trim().ToLower() != "s")
            {
                break;
            }
        }
    }
}