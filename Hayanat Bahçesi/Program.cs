Console.WriteLine("Hayvanat bahçesine hoşgeldiniz sesini duymak istediğiniz hayvanın ismini yazın");
string hayvan = Console.ReadLine();

switch(hayvan)
{
    case "kurt":
        Console.WriteLine("AUUUUUUUUUUU");
        break;
    case "aslan":
        Console.WriteLine("harrrrharrrharrr");
        break;
    case "fil":
        Console.WriteLine("öööööğğğğğğğğğğğğ");
        break;
    case "maymun":
        Console.WriteLine("u u a a a");
        break;
    case "zebra":
        Console.WriteLine("öğööğğööğöğö");
        break;
    case "hindi":
        Console.WriteLine("GuluGuluGuluGulu");
        break;
    case "tavuk":
        Console.WriteLine("gıkgıkgıdak");
        break;
    case "köpek":
        Console.WriteLine("HavHavHavHav");
        break;
    case "kedi":
        Console.WriteLine("MiyavMiyavMiyavMiyav");
        break;
    case "kuş":
        Console.WriteLine("CikCikCikCik");
        break;
    case "eşek":
        Console.WriteLine("AğhiiAğhiiAğhii");
        break;
    case "inek":
        Console.WriteLine("MööööMööööMöööö");
        break;
    case "koyun":
        Console.WriteLine("MeeeeeMeeeeMeeeeMeeee");
        break;
    case "at":
        Console.WriteLine("HışşşHışşşHışşş");
        break;
    default:
        Console.WriteLine("Bu hayvan hayvanat bahçesinde mevcut değil.");
        break;
}