using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulyotor.KalkulyatorDastur
{
    internal class Kalkulyator
    {
        public string Name { get; set; }
        public char Belgi { get; set; }
        public int Son1 { get; set; }
        public int Son2 { get; set;}

        public void MusbatManfiyAniqlash(int son1, int son2)
        {
                    string mesagge =
            son1 > 0 || son2 > 0
                ? $"{son1} va {son2} + son "
                : $"{son1} va {son2} - son";
                    Console.WriteLine(mesagge);
        }
        public void KattaKichikAniqlash(int son1 , int son2)
        {
            if (son1 > son2)
            {
                Console.WriteLine($"{son1} katta {son2} dan");
            }
            else if (son1 == son2)
            {
                Console.WriteLine($"{son1} bulan {son2} teng sonlar");
            }
            else
            {
                Console.WriteLine($"{son1} kichkina {son2} dan");
            }
        }
        
        public void Hisoblash(char belgi, int son1, int son2)
        {
            string result = belgi switch
            {
                '+' => $"Qo'shilganda Javob: {son1 + son2}",
                '-' => $"Ayirilganda Javob: {son1 - son2}",
                '*' => $"Ko'paytirilganda Javob: {son1 * son2}",
                '/' => $"Bo'liganda Javob: {son1 / son2}",

                _ => "Notug'ri amal kiritildi!"
            };

            Console.WriteLine(result);

            switch (belgi)
            {
                case '+':
                    Console.WriteLine($"Qo'shilganda Javob: {son1 + son2}");
                    break;
                case '-':
                    Console.WriteLine($"Ayirilganda Javob: {son1 - son2}");
                    break;
                case '*':
                    Console.WriteLine($"Ko'paytirilganda Javob: {son1 * son2}");
                    break;
                case '/':
                    if (son1 != 0)
                    {
                        Console.WriteLine($"Bo'liganda Javob: {son1 / son2}");
                    }
                    else
                    {
                        Console.WriteLine("Nolga bo'lib bo'lmaydi");
                    }
                    break;
                default:
                    Console.WriteLine("Notug'ri amal kiritildi!");
                    break;
            }
        }
        public void KarraKarra()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.Write("\n");
            }
        }
    }
}
