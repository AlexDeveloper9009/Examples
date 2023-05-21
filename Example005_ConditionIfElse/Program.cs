Console.Write("Введите ваше имя: ");
string username = Console.ReadLine()!;
if(username.ToLower() == "маша")
{
    Console.Write("Ура, это же ");
    Console.WriteLine(username);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}