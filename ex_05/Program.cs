Console.Write("Имя мне напиши!");
string username = Console.ReadLine();

if(username.ToLower() == "lopushka")
{
    Console.WriteLine("привет мастер!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}