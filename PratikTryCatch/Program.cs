try
{
    Console.WriteLine("Bir sayi girin: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    int square = userInput * userInput;
    Console.WriteLine("Girdiğiniz sayi: " + square);
}
catch (Exception)
{
    Console.WriteLine("Hatali giris yaptiniz, lütfen sayi giriniz.");
}
finally
{
    Console.WriteLine("İslem tamamlandi");
}