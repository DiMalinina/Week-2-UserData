using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja vanust;
            // programm arvutab kasutaja sünniaastat;
            // programm kuvab sünniaastat konsoolis;
            // "oled sündinud aastal {yearOfBirth}";

            Console.WriteLine("Plaun, sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirthe = 2022 - userAge;
            // Console.WriteLine("Oled " + userAge + " aastat vana.");

            // string inerpolation

            Console.WriteLine($"Oled sündinud aastal {yearOfBirthe}");

        }
    }
}
