Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "тагир")
{
    Console.WriteLine("Ура, это же Тагир! Люблю тебя!");
}
else
{
    Console.Write("Привет, обычный человек ");
    Console.WriteLine(username);
}

