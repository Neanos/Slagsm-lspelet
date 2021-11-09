using System;

int hp1 = 200;
int hp2 = 200;

Random generator = new Random();

while (hp1 > 0 && hp2 > 0){
    
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
    Console.WriteLine($"Fighter 1: {hp1}  Fighter 2: {hp2}\n");

    int fighter1Damage = generator.Next(20);
    hp2 -= fighter1Damage;
    hp2 = Math.Max(0, hp2);
    Console.WriteLine($"Fighter 1 gör {fighter1Damage} skada på Fighter 2");

    int fighter2Damage = generator.Next(20);
    hp1 -= fighter2Damage;
    hp1 = Math.Max(0, hp1);
    Console.WriteLine($"Fighter 2 gör {fighter2Damage} skada på Fighter 1");

    Console.WriteLine("Tryck på valfri tangent med bokstav för att fortsätta.");
    Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if(hp1 == 0 && hp2 == 0){
    Console.WriteLine("Oavgjort");
}

else if(hp1 == 0){
    Console.WriteLine("Fighter 2 vann!");
}

else{
    Console.WriteLine("Fighter 1 vann!");
}

Console.WriteLine("Tryck på valfri knappa för att avsluta.");
Console.ReadKey();
