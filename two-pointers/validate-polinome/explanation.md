# Valid Palindrome (Two Pointers)

## Algorithm
1. İki pointer tanımla:
   - left = 0
   - right = s.Length - 1

2. Döngü:
   - left < right olduğu sürece devam et

3. Geçersiz karakterleri atla:
   - left alfanumerik değilse → left++
   - right alfanumerik değilse → right--

4. Karakterleri karşılaştır:
   - Küçük harfe çevir
   - Eğer eşit değilse → return false

5. Pointerları ilerlet:
   - left++
   - right--

6. Döngü bittiyse → return true

## Logic
- Sadece harf ve rakamlar dikkate alınır
- Büyük/küçük harf farkı yoktur
- İki uçtan kontrol edilir (Two Pointers)

## Complexity
- Time: O(n)
- Space: O(1)