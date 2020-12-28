using System;

namespace Exam
{
    class Fonoteca
    {
        public string ispolnitel;
        public string janr;
        public string album;
        public int godvipuska;
        public Fonoteca(string ispolnitel, string janr, string album, int godvipuska)
        {
            this.ispolnitel = ispolnitel;
            this.janr = janr;
            this.album = album;
            this.godvipuska = godvipuska;
        }

        public static bool Ispolnitel { get; internal set; }
    }
    class Autors
    {
        static void Main()
        {
            Fonoteca Decl = new Fonoteca("Party", "HipHop", "Album", 2010);
            Fonoteca ACDC = new Fonoteca("Slam", "Rock", "Album", 2007);
            Fonoteca Lolita = new Fonoteca("Lola", "Pop", "Album", 2011);
            Fonoteca[] Fonotecas =
                {Decl,ACDC,Lolita };
            Console.WriteLine("Введите 1 если поиск по жанру,другую если по году");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Введите janr");
                string janr = Console.ReadLine();
                foreach (var Fonoteca in Fonotecas)
                {
                    if (Fonoteca.janr == janr)
                    {
                        Console.WriteLine(Fonoteca.ispolnitel);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите godvipuska");
                int god = Convert.ToInt32(Console.ReadLine());
                foreach (var Fonoteca in Fonotecas)
                {
                    if (Fonoteca.godvipuska == god) ;
                }
                {
                    Console.WriteLine(Fonoteca.Ispolnitel);
                }



            }

        }
    }
}
