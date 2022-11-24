using System;
class Program{ 
    static void Main(string[] args){
        
        Flower thai = new Flower();
        thai.Moji();
        thai.ERROR();
    }
}

class Flower{
    CircularLinkedList<char> Lao = new CircularLinkedList<char>();
        public void thailand(char gold)
        {
            int FLove = Lao.GetLength();

        while (true)
        {
           if (gold == 'J')
           {
                if (FLove > 0)
                {
                    if (Lao.Get(FLove-1) == 'R' && Lao.Get(FLove-2) == gold)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
                    else
                    {
                        Lao.Add(gold);
                    }
                }
                if (FLove == 0)
                {
                Lao.Add(gold);
                }
                Moji();    
            }
            if (gold == 'G')
            {        
                if (FLove > 0)
                {
                    if (Lao.Get(FLove-1) == 'R' && Lao.Get(FLove-2) == gold)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                }    
                if (FLove > 2 )
                {
                    if (Lao.Get(FLove-1) == gold && Lao.Get(FLove-2) == gold && Lao.Get(FLove-3) == gold)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    if (Lao.Get(0) == gold && Lao.Get(FLove-1) == gold && Lao.Get(FLove-2) == gold)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    if (Lao.Get(0) == gold && Lao.Get(1) == gold && Lao.Get(FLove-1) == gold)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    else
                    {
                        Lao.Add(gold); 
                    }
                }
                    else
                    {
                        Lao.Add(gold);          
                    }    
                    Moji();        
                }
            if (gold == 'O')
            {
                    if (FLove > 0)
                    {
                        if (Lao.Get(FLove-1) == 'R' && Lao.Get(FLove-2) == gold)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }
                        else
                        {
                            Lao.Add(gold); 
                        }
                    }
                    Moji(); 
                }
            if (gold == 'R')
            {
                if (FLove < 1)
                {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern."); 
                }
                if (FLove > 0)
                {
                    if (Lao.Get(FLove-1) == gold && Lao.Get(FLove-2) == gold)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
                    if (Lao.Get(0) == gold && Lao.Get(FLove-3) == gold)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
                    if (FLove > 2)
                    {
                        if (Lao.Get(FLove-1) == 'J' && Lao.Get(0) == 'J')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }                     
                        if (Lao.Get(FLove-1) == 'O' && Lao.Get(0) == 'O')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }
                        if (Lao.Get(FLove-1) == 'G' && Lao.Get(0) == 'G')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }                     
                            else
                            {
                            Lao.Add(gold); 
                            }                      
                    }
                        else
                        {
                            Lao.Add(gold); 
                        }
                    }
                    Moji(); 
                }

            if (gold != 'R' || gold != 'G'  || gold != 'O' || gold != 'J'  )
            {
                break;
            }                    
        }
 
    }
                char Input()
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Input : ");
                return (Console.ReadKey().KeyChar);
            }
            public void Moji()
            {
                thailand(Input());
            }
            public void ERROR()
            {
            Console.WriteLine("");
            Console.WriteLine("");
            int FLove = Lao.GetLength();
            for (int i = 0; i < FLove; i++)
            {
                Console.Write(Lao.Get(i));
            }
        }
}