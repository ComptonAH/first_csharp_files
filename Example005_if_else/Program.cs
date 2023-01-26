Console.Write("Enter your username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray! It's Masha!");
}
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}