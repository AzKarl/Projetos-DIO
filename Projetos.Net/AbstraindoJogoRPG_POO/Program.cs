using AbstraindoJogoRPG_POO.src.Entities;
  
   Knight arus = new Knight("Hero", 2, "Knight");
   Wizard Wwizard = new Wizard("Jennica", 93, "White Wizard");
   Ninja wedge = new Ninja("Wedge", 42, "Ninja");
   Wizard Bwizard = new Wizard("Topapa", 30, "Black Wizard");

    Console.WriteLine(arus.Attack(4));
    Console.WriteLine(Wwizard.Attack(8));
    Console.WriteLine(wedge.Attack());
    Console.WriteLine(Bwizard.Attack(3));

