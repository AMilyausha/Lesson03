Console.WriteLine("Введите пятизначное число");
int n =int.Parse(Console.ReadLine());
int a1 = n/10000; // первая цифра
Console.WriteLine(a1);
int a2 = (n%100) %10; // пятая цифра
Console.WriteLine(a2);
int b1 = (n/1000)%10; // вторая цифра
Console.WriteLine(b1);
int b2 = (n%100) /10; // четвертая цифра
Console.WriteLine(b2);
if ((a1==a2) && (b1==b2))
{
   Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
