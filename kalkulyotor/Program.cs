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

string mesagge =
    num > 0 || num1 > 0
        ? $"{num} va {num1} + son emas"
        : $"{num} va {num1} - son emas";
Console.WriteLine(mesagge);

if (num > num1)
{
    Console.WriteLine($"{num} katta {num1} dan");
}
else if (num == num1)
{
    Console.WriteLine($"{num} bulan {num1} teng sonlar");
}
else
{
    Console.WriteLine($"{num} kichkina {num1} dan");
}

string result = op switch
{
    '+' => $"Qo'shilganda Javob: {num + num1}",
    '-' => $"Ayirilganda Javob: {num - num1}",
    '*' => $"Ko'paytirilganda Javob: {num * num1}",
    '/' => $"Bo'liganda Javob: {num / num1}",

    _ => "Notug'ri amal kiritildi!"
};

Console.WriteLine(result);

switch (op)
{
    case '+':
        Console.WriteLine($"Qo'shilganda Javob: {num + num1}");
        break;
    case '-':
        Console.WriteLine($"Ayirilganda Javob: {num - num1}");
        break;
    case '*':
        Console.WriteLine($"Ko'paytirilganda Javob: {num * num1}");
        break;
    case '/':
        if (num1 != 0)
        {
            Console.WriteLine($"Bo'liganda Javob: {num / num1}");
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

int sum = 2;
while(sum < num)
{
    Console.WriteLine(sum);
    sum += 2;
}


for (int i = 1; i <= 10; i++)
{
    Console.Write("\n");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.Write("\n");
}