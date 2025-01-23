using System.Text;
using System.Threading;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // выходное декодирование
            Console.InputEncoding = Encoding.UTF8; //входное декодирование
            while (true)
            {
                Console.WriteLine("Регистрируем нового пользвателя?");
                if (Console.ReadLine().ToLower() == "да")
                {
                    RegNewUser();
                }
                else
                {
                    Console.WriteLine("Всего хорошего!");
                    break;
                }
            }
        }
        public static void RegNewUser()
        {
            Console.WriteLine("Напишите ваш логин");
            string login = Console.ReadLine();
            Console.WriteLine("Напишите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Оформили ли вы премиум-подписку");

            bool ispremium = Console.ReadLine().ToLower() == "да" ? true : false;
            User user = new(login, name, ispremium);
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium {  get; set; }

        public User(string login,string name,bool isPremium) 
        { 
            Login = login;
            Name = name;
            IsPremium = isPremium;
            Console.WriteLine($"Приветствуем тебя {Name}, твой логин {Login}{Environment.NewLine}");
            if (!IsPremium)
            {
                Console.WriteLine($"Ты не имеешь премиум подписку, поэтому смотри рекламу =){Environment.NewLine}") ;
                ShowAds();
            }
            else
            {
                Console.WriteLine("Ты имеешь премиум подписку, можешь продолжить пользоваться нашим сервисом без рекламы =)");
            }
        }

        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми! free.games.for.a.fool.com");
            Thread.Sleep(1000);
            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда");
            Thread.Sleep(2000);
            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу");
            Thread.Sleep(3000) ;
        }
    }
}

