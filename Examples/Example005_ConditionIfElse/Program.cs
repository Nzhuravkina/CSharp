Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАШA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}