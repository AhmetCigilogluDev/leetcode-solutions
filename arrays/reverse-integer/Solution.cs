public class Solution
{
    public int Reverse(int x)
    {
        //reversed sayıyı bir değişkene atayalım, 0 olarak kabul ediyorum 
        int reversed = 0;
        //x sıfır olmadıgı surece işlemi devam ettir, x burada aldıgımız sayı oluyor
        while (x != 0)
        {
            //Sayının son basamığını al
            int digit = x % 10;



            // Sonra x sayısının son basamığını kaldır
            x /= 10;

            //her adımda 32 bit integer sınırı aşılıyor mu kontrol et, aşıyorsa
            // sıfır döndür
            if (reversed > int.MaxValue / 10 && reversed < int.MaxValue / 10)
                return 0;


            // bu basamağı yeni oluşturulan sayının son basamagına ekle
            reversed = reversed * 10 + digit;


        }

        return reversed;
    }
}