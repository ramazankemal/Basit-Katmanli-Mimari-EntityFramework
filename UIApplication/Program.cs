using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace UIApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuManager menuManager = new MenuManager();
            Menu menu = new Menu();
            menu.Title = "Katmanlı Mimari 2";
            menu.Description = "Test denemesi yapılıyor 2";

            menuManager.Add(menu);
            Console.WriteLine("İşlem başarılı..");

            Console.ReadLine();
            
        }
    }
}
