public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //dizinin ilk elemanýný seç, bu referans eleman olacak
        for (int i = 0; i < nums.Length; i++)
        {
            //referans elemandan sonraký sayýlarý gez
            for (int j = i + 1; j < nums.Length; j++)
            {

                //bu iki sayýnýn toplamýný hesapla
                if (nums[i] + nums[j] == target)
                {
                    //eðer targeta eþitse bu iki elemanýn indexlerini döndür
                    return new int[] { i, j };
                }

            }

        }

        //derleyici hata vermesin diye boþ bir dizi döndür,DÖNGÜ DISINA KOY
        return new int[] { };
    }
}