using System;

namespace ConsoleApp6
{
    interface Lamp
    {
        static string type = "Lampa from Japan";
        static string produser = "Japan";
        static int power = 300;
        static int kilkist = 5;
        void set_power(int new_power) { }
        void lamp_show_info() { }

    }
    interface Camera
    {
        static string type = "UJHGFJGKH";
        static string produser = "Japan";
        static int sensitivity_min = 1;
        static int sensitivity_max = 100;
        void set_sensitivity() { }
        void camera_show_info() { }

    }
    class PhotoStudio : Lamp
    {
        public void lamp_show_info()
        {
            Console.WriteLine("Тип: " + Lamp.type + "\nВиробник: " + Lamp.produser + "\nПотужнiсть у люменах: " + Lamp.power + "СИ\nКiлькiсть освiтлювальних елементiв: " + Lamp.kilkist);
        }
        public void camera_show_info()
        {
            Console.WriteLine("Тип: " + Camera.type + "\nВиробник: " + Camera.produser + "\nСвiтлочутливiсть: " + Camera.sensitivity_min + "lux - " + Camera.sensitivity_max + "lux");
        }
        public void show_info()
        {
            lamp_show_info();
            Console.WriteLine("\n");
            camera_show_info();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoStudio ps = new PhotoStudio();
            ps.show_info();
        }
    }
}