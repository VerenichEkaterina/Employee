using System;

namespace ConsoleApp2
{
    using System;

    namespace MyApp
    {
        class Employee
        {

            public int experience;
            public int ExpIndex;
            public string name;
            public string surname;
            public int bonus;


            public void getBonusPercent()

            {
                Console.WriteLine($"Имя: {name} Фамилия: {surname}  Стаж: {experience} Уровень: {ExpIndex} Бонус: {bonus}");
            }
        }  
        class Program
        {
            static void Main(string[] args)
            {
                Employee Jane = new Employee();
                Jane.getBonusPercent();     

                Jane.name = "Jane";
                Jane.surname = "Eyr";
                Jane.experience = 5;
                Jane.ExpIndex = 2;
                {
                    for (int level = 1; level <= 5; ++level)
                    {
                        if (Jane.experience < 1)
                        {
                            Jane.bonus = 0;
                        }
                        else if (Jane.experience < 5)
                        {
                            Jane.bonus = 5;
                        }
                        else if (Jane.experience >= 5 && Jane.ExpIndex < 3)
                        {
                            Jane.bonus = 10;
                        }
                        else if (Jane.experience > 5 && ((Jane.ExpIndex >= 3) && (Jane.ExpIndex <= 4)))
                        {
                            Jane.bonus = 15;
                        }
                        else if ((Jane.experience > 5) && (Jane.ExpIndex == 5))
                        {
                            Jane.bonus = 20;
                        }
                    }
                }


                Jane.getBonusPercent();
                Console.ReadKey();
            }
        }
    }
}
