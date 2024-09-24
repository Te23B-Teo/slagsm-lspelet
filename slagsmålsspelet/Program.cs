while(true){
    int hp1 = 100;
int hp2 = 100;
string namn;
string response;
string level;
int nummer = 21;
int nummer2 = 21;
Console.WriteLine("hej främling vad heter du?");
namn = Console.ReadLine();
Console.Clear();
Console.WriteLine($"{namn} du är vårat ända hopp och vi behöver din hjälp att besegra skurken");
Thread.Sleep(2000);
Console.WriteLine("tryck på enter");
Console.ReadLine();
Console.WriteLine("vilken nivå vill du köra 1 2 eller 3");
level = Console.ReadLine();
if (level == "1"){
nummer = 10;
nummer = 10;
}
else if(level == "3"){
    nummer = 10;
    nummer2 = 10;
}

while(true){
int p1damage = Random.Shared.Next(0,nummer);
int p2damage = Random.Shared.Next(0,nummer2);

if (p1damage == p2damage){
hp1 += 10;
hp2 += 10;
Console.WriteLine("Både du och skurken fick +10 HP för båda fick licka mycket skada!");
Thread.Sleep(2000);
}
else if(hp1 > 0 && hp2 > 0){
Console.Clear();
    Console.WriteLine($"du gjorde {p1damage} skada och skurken gjorde {p2damage}");
    hp1 -= p2damage;
    hp2 -= p1damage;  
    Console.WriteLine($"du har {hp1} hp kvar och skurken har {hp2} hp kvar");
    Console.ReadLine();
}
else if(hp1 <= 0){
Console.Clear();
Console.WriteLine("åh nej du förlorade och skurken vann");
Thread.Sleep(3000);
Console.Clear();
break;
 }
else if (hp2 <= 0){
Console.Clear();
Console.WriteLine("tack för att du räddade oss");
Thread.Sleep(3000);
Console.Clear();
break;
 }
 }
    Console.WriteLine("Vill du spela igen? ja/nej");
    response = Console.ReadLine().ToLower();

    if (response != "ja"){
        Console.WriteLine("Tack för att du spelade! Hej då!");
        break;
    }
    Console.Clear(); 
}
void variablar(){
    
}