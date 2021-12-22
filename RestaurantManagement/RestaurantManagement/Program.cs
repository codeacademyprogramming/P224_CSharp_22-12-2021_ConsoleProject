using System;
using RestaurantManagement.Enums;
using RestaurantManagement.Models;
using RestaurantManagement.Services;

namespace RestaurantManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantManager restaurantManager = new RestaurantManager();

            do
            {
                Console.WriteLine("-------------------------Restaurant Management---------------------------");
                Console.WriteLine("Etmek Isdediyniz Emeliyyatin Qarsisindaki Nomreni Daxil Edin:");
                Console.WriteLine("1 - Menular Uzerinde Emeliyyatlar:");
                Console.WriteLine("2 - Sifarisler Uzerinde Emeliyyatlar:");
                Console.WriteLine("3 - Sistemden Cix:");
                Console.Write("Daxil Et:");
                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        MenuOperation(ref restaurantManager);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Menu Emeliyyatlari:");
                        break;
                    case 3:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Et");
                        break;
                }

            } while (true);
            
        }

        static void MenuOperation(ref RestaurantManager restaurantManager)
        {
            do
            {
                
                Console.WriteLine("-------------------------Menu Emeliyyatlari---------------------------");
                Console.WriteLine("Etmek Isdediyniz Emeliyyatin Qarsisindaki Nomreni Daxil Edin:");
                Console.WriteLine("1 - Yeni item elave et:");
                Console.WriteLine("2 - Item uzerinde duzelis et:");
                Console.WriteLine("3 - Item sil:");
                Console.WriteLine("4 - Butun Item-lari goster:");
                Console.WriteLine("5 - Categoriyasina gore menu item-lari goster:");
                Console.WriteLine("6 - Qiymet araligina gore menu item-lar goster:");
                Console.WriteLine("7 - Menu item-lar arasinda ada gore axtaris et (search):");
                Console.WriteLine("8 - Esas menuya qayit:");
                Console.Write("Daxil Et:");
                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        AddMenuItem(ref restaurantManager);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3");

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4");

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5");

                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6");

                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("7");

                        break;
                    case 8:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Et");
                        break;
                }

            } while (true);
        }

        static void AddMenuItem(ref RestaurantManager restaurantManager)
        {
            Console.Write("Menu-nun Adini Daxil Et: ");
            string name = Console.ReadLine();

            Console.Write("Menu-nun Qiymetini Daxil Et: ");
            string price = Console.ReadLine();
            double priceNum;

            while (!double.TryParse(price, out priceNum) || priceNum <= 0)
            {
                Console.WriteLine("Duzgun Qiymet Daxil Et:");
                price = Console.ReadLine();
            }

            Console.WriteLine("Kategoriyalar: ");

            string[] categories = Enum.GetNames(typeof(Category));
            for (int i = 0; i < categories.Length; i++)
            {
                Console.WriteLine($"{i} {categories[i]}");
            }

            Console.WriteLine("Kategoriyani Nomresini Daxil Et:");
            string category = Console.ReadLine();
            int categoryNum;

             while (!int.TryParse(category, out categoryNum) || categoryNum < 0 || categoryNum >= categories.Length)
            {
                Console.WriteLine("Duzgun Kategoriya Nomresi Daxil Et:");
                category = Console.ReadLine();
            }

            Category selectedCategory = (Category)categoryNum;

            restaurantManager.AddMenuItem(name, priceNum, selectedCategory);
        }
    }
}
