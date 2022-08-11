Console.WriteLine("Введите ваше число:");
int num = Convert.ToInt32(Console.ReadLine());

if(num<=99)
{
    Console.WriteLine("Третье число отсутствует!!!");
}

int digitIndex = 2;
int digit      = num.ToString()[digitIndex] - '0';

Console.WriteLine(digit);