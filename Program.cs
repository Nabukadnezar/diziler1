// See https://aka.ms/new-console-template for more information

//Dizi Tanımı
string[] renkler = new string[5];

string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

int[] dizi;
dizi = new int[5];

//Dizilere değer atama

renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[0]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//Döngülerle dizi kullanımı
// klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.Write("Lütfen dzinin eleman sayısını giriniz: ");

int dizinUzunlugu = int.Parse(Console.ReadLine());

int[] sayiDizisi = new int[dizinUzunlugu];

for (var i = 0; i<dizinUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);

    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;

foreach (var sayi in sayiDizisi)
toplam += sayi;

Console.WriteLine("Ortalamam :" + (toplam/dizinUzunlugu));
