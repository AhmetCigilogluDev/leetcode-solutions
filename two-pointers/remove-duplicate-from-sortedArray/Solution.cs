public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {


        // dizi boþsa 0 döndür, bos dizide benzersiz eleman bulunamaz
        if (nums.Length == 0)
            return 0;
        // unique index belirle
        int uniqueIndex = 0;

        // diziyi ikinci elemandan itibaren gezmeye baþlayalým, çünkü ilk elemaný 
        // zaten benzersiz kabul ettik
        for (int i = 1; i < nums.Length; i++)
        {

            // eðer þu anki eleman son benzersiz elemandan farklýysa
            if (nums[i] != nums[uniqueIndex])
            {
                //uniqueIndex pointerini bir arttýr
                uniqueIndex++;
                //Yeni benzersiz elemaný bu konuma yerleþtir
                nums[uniqueIndex] = nums[i];
            }
        }

        // bizden benzersiz eleman sayýsýný integer türünde return etmemizi istiyor
        // O halde benzersiz eleman sayýsýný return edelim
        return uniqueIndex + 1;
    }
}