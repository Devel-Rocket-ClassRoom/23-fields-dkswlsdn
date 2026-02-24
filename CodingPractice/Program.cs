using System;


Console.WriteLine("\n================================");

Player player = new Player();
player.ShowStatus();


Console.WriteLine("\n================================");

Character character = new Character();
character.name = "용사";
character.level = 10;
Console.WriteLine(character.name);
Console.WriteLine(character.level);


Console.WriteLine("\n================================");

Character2 character2 = new Character2();
character2.SetInfo("용사", 10);
character2.ShowInfo();


Console.WriteLine("\n================================");

Player2 player2 = new Player2();
player2.ShowStatus();


Console.WriteLine("\n================================");

Say say = new Say();
say.Hi();


Console.WriteLine("\n================================");

Schedule schedule = new Schedule();

schedule.PrintWeekDays();


Console.WriteLine("\n================================");

DefaultValues defaultValues = new DefaultValues();

defaultValues.ShowDefaultValues();


Console.WriteLine("\n================================");

Counter counter1 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");

Counter counter2 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");

Counter counter3 = new Counter();
Console.WriteLine($"현재 카운트: {Counter.count}");


Console.WriteLine("\n================================");

Player3 player3 = new Player3("용사");
Console.WriteLine(player3.name);

Player3 player4 = new Player3("마법사");
Console.WriteLine(player4.name);

Player3 player5 = new Player3("궁수");
Console.WriteLine(player5.name);

Console.WriteLine($"총 플레이어 수: {Player3.totalCount}");


Console.WriteLine("\n================================");

GameConfig gameConfig = new GameConfig();

gameConfig.ShowConfig();


Console.WriteLine("\n================================");

Example example = new Example();

example.ShowValues();


Console.WriteLine("\n================================");

Player4 player41 = new Player4();

player41.SetInfo("용사", 10);


Console.WriteLine("\n================================");

string[] site = { "네이버", "구글" };

Person person = new Person("홍길동", 21, "길동이", site);

person.ShowProfile();


Console.WriteLine("\n\n================================");

GameCharacter character3 = new GameCharacter("용사", 15);
GameCharacter character4 = new GameCharacter("마법사", 25);

character3.ShowStatus();
Console.WriteLine();

character4.ShowStatus();
Console.WriteLine();

character3.TakeDamage(30);
character3.TakeDamage(50);
character3.TakeDamage(50);

Console.WriteLine();

GameCharacter.PrintTotalCharacterNumber();