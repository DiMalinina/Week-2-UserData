using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib ksautaja sünniastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutaja vanust kobsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;
            // Console.WriteLine("Oled " + userAge + " aastat vana.");

            // string inerpolation

            Console.WriteLine($"Oled {userAge} aastat vana."); 





        }
    }
}