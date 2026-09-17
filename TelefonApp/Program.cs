using TelefonApp;
Okostelefon telefon1 = new Okostelefon();
telefon1.Modell = "anyu pénze 6";
telefon1.Toltottseg = -10;
Console.WriteLine("Modell: {0}, Töltöttség: {1}",telefon1.Modell,telefon1.Toltottseg);

telefon1.Toltottseg = 110;
Console.WriteLine("Modell: {0}, Töltöttség: {1}", telefon1.Modell, telefon1.Toltottseg);