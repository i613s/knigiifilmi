using System;
using System.Collections.Generic;
using System.Text;
using knigiifilmi.GoshoRibata;
using System.Windows;
namespace knigiifilmi.display
{
    class Display
    {
        int choice;


        public string Knigi { get; set; }
        public void PeshoRibata()
        {
            Console.WriteLine("izberete knigi ili filmi");
            Console.WriteLine("1-Knigi");
            Console.WriteLine("2-Filmi");
            Console.WriteLine("0 za da izlezesh ot programata");
            choice = int.Parse(Console.ReadLine());
            Choice();

        }

        public void Choice()
        {
           
         
            if (choice == 1)
            {
                Neshtosi();

            }
            else if (choice == 2)
            {
                Cowmilk();
            }
            else if (choice == 0)
            {
                Environment.Exit(0);
            }
            
        }
        public void Neshtosi()
        {
            List<Gunai> gunai = new List<Gunai>()
            {
                new Gunai ("The art of war","sun tzu"),
                new Gunai("Hobbit", "J R.R Tolkin"),
                

            };
            for (int i = 0; i < gunai.Count; i++)
            {
                
               Console.Write($"Name:{gunai[i].authorname}");
                
               Console.WriteLine($"        Author:{gunai[i].miyagi}");

            }

        }
        public void Cowmilk()
        {
            List<Sultan> sultan= new List<Sultan>
            {
                new Sultan("Transformers","pesho slepiq"),
                new Sultan("alo alo slunchice", "gosho debeliq"),

            };
            for (int i = 0; i < sultan.Count; i++)
            {

                Console.Write($"Name:{sultan[i].kusem}");
                Console.WriteLine($"        Studio:{sultan[i].ahmed}");

            }



        }
        


    }
}
