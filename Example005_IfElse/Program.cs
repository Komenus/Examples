Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура!Это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}    