while (true)
{
    int hp1 = 100;
    int hp2 = 100;
    string name;
    string response;
    string level;
    int number = 21;
    int number2 = 21;
    Console.WriteLine("hej främling vad heter du?");
    name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"{name} du är vårat ända hopp och vi behöver din hjälp att besegra skurken");
    Thread.Sleep(2000);
    Console.WriteLine("tryck på enter");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("vilken nivå vill du köra 1 som är easy 2 som är medium eller 3 som är hard");
    level = Console.ReadLine();
    if (level == "1")
    {
        number = 30;
        number2 = 15;
    }
    else if (level == "3")
    {
        number = 15;
        number2 = 30;
    }

    while (true)
    {
        int p1damage = Random.Shared.Next(0, number);
        int p2damage = Random.Shared.Next(0, number2);

        if (p1damage == p2damage)
        {
            hp1 += 10;
            hp2 += 10;
            Console.WriteLine("Både du och skurken fick +10 HP för båda fick licka mycket skada!");
            Thread.Sleep(2000);
        }
        else if (hp1 > 0 && hp2 > 0)
        {
            Console.Clear();
            Console.WriteLine($"du gjorde {p1damage} skada och skurken gjorde {p2damage}");
            hp1 -= p2damage;
            hp2 -= p1damage;
            Console.WriteLine($"du har {hp1} hp kvar och skurken har {hp2} hp kvar");
            Console.ReadLine();
        }
        else if (hp1 < 0 && hp2 < 0)
        {
            Console.WriteLine("både du och skurken döda varandra på sista slaget");
            Console.WriteLine("byborna tackar din uppofring");
        }
        else if (hp1 <= 0)
        {
            Console.Clear();
            Console.WriteLine("åh nej du förlorade och skurken vann");
            Thread.Sleep(3000);
            Console.Clear();
            break;
        }
        else if (hp2 <= 0)
        {
            Console.Clear();
            Console.WriteLine("tack för att du räddade oss");
            Thread.Sleep(3000);
            Console.Clear();
            break;
        }
    }
    Console.WriteLine("Vill du spela igen? ja/nej");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("skriv secret för en secret");
    Console.ForegroundColor = ConsoleColor.White;
    response = Console.ReadLine().ToLower();

    if (response == "nej")
    {
        Console.WriteLine("Tack för att du spelade! Hej då!");
        Console.Clear();
        Thread.Sleep(1000);
        break;
    }
    else if (response == "ja")
    {
        Console.Clear();
    }
    else if (response == "secret")
    {
        Console.Clear();
        int randomnummer = Random.Shared.Next(0, 11);
        Console.WriteLine("du väntade på vad inget, nä du väntade på det här, kul för dig om du gissar en siffra från 1-10 rätt så får du 10 000 $");
        string saker = Console.ReadLine();
        Console.Clear();
        if (saker == randomnummer.ToString())
        {
            Console.WriteLine("grattis du gissade rätt och fick 10 000 dollar woho");
            Thread.Sleep(2000);
            break;
        }
        else if (saker != randomnummer.ToString())
        {
            Console.WriteLine("du hade fel och nu sprängs din dator!");
            Thread.Sleep(2000);
            break;
        }
    }
    else if (response != "ja" || response != "secret" || response != "nej")
    {
        break;
    }
}