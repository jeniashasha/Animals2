using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        
        static void AnimalSing(Animal[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].MakeSound();
            }
        }
        static Horse[] GetRacingHorses(Horse[] horses)
        {
            int sum = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse == true)
                {
                    sum = sum + 1;
                }
            }
            Horse[] racehorses = new Horse[sum];

            int g = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].racingHorse == true)
                {
                    racehorses[g] = horses[i];
                    g++;
                }

            }
            for (int i = 0; i < racehorses.Length; i++)
            {
                Console.WriteLine(racehorses[i]);
            }
            return racehorses;
        }
            

        static void Main(string[] args)
            {
                Dog d = new Dog("riki", "meat");

                Console.WriteLine(d);
                d.MakeSound();
                Horse h = new Horse("meni", true);
                Console.WriteLine(h);
            Horse j = new Horse("jack", false);
            Console.WriteLine(j);
            j.MakeSound();
            Horse y = new Horse("fin", true);
            Console.WriteLine(y);
            Horse r = new Horse("luke", true);
            Console.WriteLine(r);
            Poodle p = new Poodle("lucky", "bones", "two");
                Console.WriteLine(p);
               p.MakeSound();
                Wolf w = new Wolf("richie", "rabbit", "moonrunners");
                Console.WriteLine(w);
                w.MakeSound();
                PetWolf q = new PetWolf("jack", "fish", "skyyellers");
            Console.WriteLine(q);
            q.MakeSound();
            Console.WriteLine("-------------------------------");
            Horse[] horses = { h, j, y, r };
            GetRacingHorses(horses);
            
                            


        }

        }
    }


