using QuartzOgrenci;

public class Program
{
    private static void Main(string[] args)
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>()
        {
        new Ogrenci { OgrenciNo = 1, Adi="Ali", SoyAdi = "Yıldırım", Ceza = false},
        new Ogrenci { OgrenciNo = 2, Adi="Veli", SoyAdi = "Gök", Ceza = false},
        new Ogrenci { OgrenciNo = 3, Adi="Mehmet", SoyAdi = "Onbaşı", Ceza = false},
        new Ogrenci { OgrenciNo = 4, Adi="Ayşe", SoyAdi = "Candar", Ceza = true},
        new Ogrenci { OgrenciNo = 5, Adi="Can", SoyAdi = "Köse", Ceza = false},
        new Ogrenci { OgrenciNo = 6, Adi="Turgay", SoyAdi = "Arslan", Ceza = false},
        new Ogrenci { OgrenciNo = 7, Adi="Faruk", SoyAdi = "Menteş", Ceza = true}
        };

        foreach (var Ogrenci in ogrenciler)
        {
            if (Ogrenci.Ceza)
            {
                Tetikleyici tetikle = new Tetikleyici();
                tetikle.Ogrenci = Ogrenci;
                tetikle.DersTetikte();
            }
            
        }
        Console.Read();
    }
}