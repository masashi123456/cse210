// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();

Player adam = new Player("Asam Hayes", 4);

Team firebolts = new Team("Firebolts");
firebolts.AddPlayer(ronaldo);
firebolts.AddPlayer(adam);

firebolts.DisplayRoster();