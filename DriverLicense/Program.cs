using System;

namespace DriverLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis;
            //"oled liiga noor,; et juhilube saada";
            //kui kasutaja on vanem kui 18 , siis programm kuvab konsoolis; 
            //"oled piisavalat vana, et juhilube taotleda";
            //kui kasutaja on 18, siis programm kuvab konsoolis ;
            //" Palju õnne! Nüüd sa saad juhilube taotleda"

            Console.WriteLine("Palun, sisesta oma sünniaasta: ");

            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearOfBirth;

            if (userAge > 18)
            {
                Console.WriteLine("oled piisavalat vana, et juhilube taotleda.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("oled liiga noor,et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda");
            }

          
        }
    }
}
