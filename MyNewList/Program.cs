using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPlanetColl PlanetColl = new MyPlanetColl();
            MyPlanet myplanet = new MyPlanet();
            string changer1, changer2;
            int i = 0;
            do
            {
                changer1 = Console.ReadLine();
                switch (changer1)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали операции с планетами");
                        PlanetColl.Printf();
                        Console.WriteLine("1-добавить планету");
                        Console.WriteLine("2-найти  планету");
                        Console.WriteLine("3-выход");
                        changer2 = Console.ReadLine();
                        switch (changer2)
                        {
                   case "1":
                              
                                
                                PlanetColl.Printf();
                                Console.WriteLine("Введите название планеты :");
                                i++;
                                break;
                            case "2":
                                Console.WriteLine("Введите название планеты :");
                                break;
                            case "3":
                                Console.WriteLine("exit");

                                break;



                            default:
                                Console.WriteLine("Введена неправильная комманда :");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Вы выбрали операции со звездами");
                        PlanetColl.Printf();
                        Console.WriteLine("1-добавить звезду");
                        Console.WriteLine("2-найти  звезду");
                        Console.WriteLine("3-выход");
                        changer2 = Console.ReadLine();
                        switch (changer2)
                        {

                            case "1":
                                Console.WriteLine("Введите название звезды :");
                                Console.WriteLine("Введите вес звезды :");
                                Console.WriteLine("Введите радиус звезды :");
                                Console.WriteLine("Введите светимость звезды :");
                                Console.WriteLine("Введите класс звезды :");
                                Console.WriteLine("Введите Планеты-спутники:");
                                i++;
                                break;
                            case "2":


                                break;
                            case "3":
                                Console.WriteLine("exit");

                                break;
                        }
                        break;


                }



            } while (changer1 != "4");
            Console.ReadLine();
        }
    }
}
