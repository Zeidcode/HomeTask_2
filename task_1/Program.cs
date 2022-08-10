Console.WriteLine("Введите ваше 3-хзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int FrstDig =  a / 100;
int ScndDig = a % 100;
int ThrdDig = ScndDig / 10;
Console.WriteLine(ThrdDig);