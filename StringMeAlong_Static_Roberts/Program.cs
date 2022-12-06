// See https://aka.ms/new-console-template for more information

//Roberts, Rayleen
//IT 113
//Notes: This is a redo
//Behaviors Not Implemented and Why: String Reverse keeping case...can't figure it out. 
//                                   Also, this is the static version so ToString and Equals
//                                   are just static methods, no override

using StringMeAlong_Static_Roberts;


Console.WriteLine("Hello, World!");
Console.WriteLine(StringManager.goBackwards("Sunbeam Tiger"));
Console.WriteLine(StringManager.ToString("Sunbeam Tiger"));
Console.WriteLine("\t\nIs ABBA Symetrical?  " + StringManager.symetrical("ABBA"));
Console.WriteLine("\t\nIs ABA  Symetrical?  " + StringManager.symetrical("ABA"));
Console.WriteLine("\t\nIs ABba Symetrical?  " + StringManager.symetrical("ABba"));
Console.WriteLine("\t\n Does Sunbeam Tiger = Sunbeam Tiger? " + (StringManager.Equals("Sunbeam Tiger", "Sunbeam Tiger")));
Console.WriteLine("\t\n Does Tiger Sunbeam = Sunbeam Tiger? " + (StringManager.Equals("Sunbeam Tiger", "Tiger Sunbeam")));

//Console.WriteLine(StringManager.casePreservation("Lets Give This A Try"));//not working correctly I remarked it out
