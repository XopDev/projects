# projects C#

int triesCount = 5;
string password = "123456";
string userInput;

for (int i = 0; i < triesCount; i++)
{
    Thread.Sleep(300);
    Console.Write("[!] Введи пароль: ");
    userInput = Console.ReadLine();
    if (userInput == password)
    {
        Console.WriteLine("[!] Добро пожаловать!");
        break;
    }
    else
    {

    }
    {
        Console.WriteLine("[X] Ошибка! Пароль не подходит, попробуй ещё раз.");
        Console.WriteLine("[X] У вас осталось " + (triesCount - (i - 1)) + " попыток!");
    }


}
