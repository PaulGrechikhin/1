Console.Write("Введите ваше имя: ");
string username = Console.ReadLine()!;
Console.WriteLine(username);

if (username.ToLower() == "paul")
{
    Console.WriteLine("Да это же Павел!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}