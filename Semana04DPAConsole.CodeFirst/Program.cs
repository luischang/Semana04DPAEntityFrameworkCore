// See https://aka.ms/new-console-template for more information
using Semana04DPAConsole.CodeFirst.Models;

Console.WriteLine("Hello, World!");

// DbContext
var context = new FPFDbContext();

//// Insert player
//var player = new Player();
//player.FullName = "Lionel Messi";
//player.Dorsal = 10;

////Add player to context
//context.Player.Add(player);
//context.SaveChanges();

// Insert player
//var player2 = new Player();
//player2.FullName = "Cristiano Ronaldo";
//player2.Dorsal = 7;

//var player3 = new Player();
//player3.FullName = "Paolo Guerrero";
//player3.Dorsal = 9;

//var player4 = new Player();
//player4.FullName = "Gianluca Lapadula";
//player4.Dorsal = 11;

//var player5 = new Player("Luka Modric", 12);
//var player6 = new Player()
//{
//    FullName = "Karim Benzema",
//    Dorsal = 21
//};

//Create List
//var players = new List<Player>();
//players.Add(player2);
//players.Add(player3);
//players.Add(player4);


////Add player to context
//context.Player.AddRange(players);
//context.SaveChanges();

//Get All PLayers
//Get player with Linq

//var allAplayers = context.Player.ToList();

////Print all players
//foreach (var player in allAplayers)
//{
//    Console.WriteLine($"{player.FullName} - {player.Dorsal}");
//}

////Get player with Linq
//var search = context.Player.Where(p => p.Id == 5).FirstOrDefault();

//Console.WriteLine($"{search.FullName} - {search.Dorsal}");

////Get All with Lambda Expressions

//var allPlayerv2 = (from p 
//                  in context.Player
//                   select p).ToList();
//Get player
var searchv2 = (from p
               in context.Player
               where p.Id == 5
                select p).FirstOrDefault();

//searchv2.Dorsal = 1;
//searchv2.FullName = "Juan Flores";
//context.SaveChanges();

//Delete player
context.Player.Remove(searchv2);
context.SaveChanges();



