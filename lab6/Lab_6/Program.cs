using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

            bool rep = true;

            while (rep)
            {
                Console.Clear();
                Console.WriteLine("Creating object of combine:\n");
                Combine combine = new Combine();
                Console.WriteLine(combine.funk1());
                Console.WriteLine(combine.funk2());
                combine.NewFunk();
                Console.WriteLine("Max speed\t=\t" + combine.speed().ToString());
                Console.WriteLine("\n\n");


                Console.WriteLine("Creating object of car:\n");
                Car car = new Car();
                Console.WriteLine(car.funk1());
                Console.WriteLine(car.funk2());
                car.NewFunk();
                Console.WriteLine("Max speed\t=\t" + car.speed().ToString());
                Console.WriteLine("\n\n");

                Console.WriteLine("Creating object of ElectroCar:\n");
                ElectroCar elcar = new ElectroCar();
                Console.WriteLine(elcar.funk1());
                Console.WriteLine(elcar.funk2());
                elcar.NewFunk();
                Console.WriteLine("Max speed\t=\t" + elcar.speed().ToString());
                Console.WriteLine("\n\n");

                Console.WriteLine("Creating object of sportcar:\n");
                SportCar sportcar = new SportCar();
                Console.WriteLine(sportcar.funk1());
                Console.WriteLine(sportcar.funk2());
                sportcar.NewFunk();
                Console.WriteLine("Max speed\t=\t" + sportcar.speed().ToString());
                Console.WriteLine("\n\n");
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                Console.WriteLine("\n\n");
                int action = 1;
                do
                {
                    Console.WriteLine("Choose action to continue: \n1.  set anoter speed\n2.  exit");
                    action = int.Parse(Console.ReadLine());
                } while (action != 1 && action != 2);
                switch (action)
                {
                    case 1:
                        {
                            int obj = 0;
                            do
                            {
                                Console.WriteLine("\nChoose object:\n1.  combine\n2.  car\n3.  electrocar\n4.  sportcar");
                                obj = int.Parse(Console.ReadLine());
                            } while (obj < 1 || obj > 4);
                            Console.WriteLine("input new speed:");
                            int speed = int.Parse(Console.ReadLine());

                            switch (obj)
                            {
                                case 1:
                                    {
                                        combine.SetSpeed(speed);
                                        break;
                                    }
                                case 2:
                                    {
                                        car.SetSpeed(speed);
                                        break;
                                    }
                                case 3:
                                    {
                                        elcar.SetSpeed(speed);
                                        break;
                                    }
                                case 4:
                                    {
                                        sportcar.SetSpeed(speed);
                                        break;
                                    }
                            }



                            break;
                        }
                    case 2:
                        {
                            rep = false;
                            break;
                        }
                }
            }

            Console.ReadKey();

        }
    }
}
