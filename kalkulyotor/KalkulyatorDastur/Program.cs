
using kalkulyotor.KalkulyatorDastur;

namespace Kalkukyator
{
    class Programm
    {
        static void Main(string[] args)
        {
            string password = null;
            do
            {
                Console.Write("Parolni kiriting: ");
                password = Console.ReadLine();

            } while (password != "Thebude");


            Console.WriteLine("Assalomu allaykum men kalkulyator dasturiman.\nMenga uzingizni tanishtirng");
            Console.Write("Ismingiz: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Tanishganimdan Xursandman {name} !\nMen +,-,*,/, amalarini bajaruvchi dasturman.");
            Console.Write("Amalardan birini tanlang(+,-,*,/,): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("1-sonni kiriting: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("2-sonni kiriting: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Kalkulyator HisobKitob = new Kalkulyator();
            HisobKitob.MusbatManfiyAniqlash(son1: num, son2: num1);
            HisobKitob.KattaKichikAniqlash(son1: num1, son2: num1);
            HisobKitob.Hisoblash(son1: num, son2: num1, belgi: op);
            HisobKitob.KarraKarra();
        }
    }
}
