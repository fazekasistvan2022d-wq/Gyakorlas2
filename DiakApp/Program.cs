using DiakApp;
Diak diak1 = new Diak();

Diak diak2 = new Diak("Nagy Alma",4.75);

Console.WriteLine($"1. Diák neve: {diak1.Nev}, átlag: {diak1.Atlag}");
Console.WriteLine($"2. Diák neve: {diak2.Nev}, átlag: {diak2.Atlag}");