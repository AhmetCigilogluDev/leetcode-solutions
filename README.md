Algoritmik Patternler : Endüstiride ve leetcode da kullanılan core 15 civarı pattern vardır.

Pattern : Benzer problem tiplerinde kullanılan çözüm şablonudur.

1.Two-Pointer Pattern'u: En çok array ve string türleri üzerinde kullanılır.
Two Pointers tekniği iki ana türe ayrılır: Opposite Direction ve Fast & Slow. Opposite Direction yaklaşımında iki pointer dizinin iki ucundan başlar; biri baştan (left), diğeri sondan (right)
ilerleyerek ortada buluşur. Bu yöntem özellikle sorted array üzerinde hedef değer arama, palindrome kontrolü, reverse işlemleri ve iki uçtan karar verilmesi gereken problemler için kullanılır.
Bu kategorideki tipik problemler arasında Two Sum II, Valid Palindrome, Reverse String, Container With Most Water, 3Sum, 4Sum ve Trapping Rain Water yer alır. Bu türü seçmen gereken durumlar
genelde soldan ve sağdan karşılaştırma yapılması, pair/triplet arama, maksimum-minimum hesaplama veya sorted veri üzerinde hedefe gitme gibi senaryolardır; problemde “pair, target sum, palindrome, 
reverse, max area, sorted array” gibi ifadeler varsa bu yaklaşım öne çıkar.

Fast & Slow yaklaşımında ise iki pointer da aynı yönde başlar ancak farklı roller üstlenir: fast pointer veri yapısını tararken, slow pointer sonucu yazdığın veya doğru konumu tuttuğun
pointer’dır. Bu yöntem genellikle eleman silme/taşıma, duplicate temizleme, sıfırları sona atma, in-place düzenleme ve linked list üzerinde cycle ya da orta eleman bulma gibi durumlarda
kullanılır. Bu kategoriye Remove Duplicates from Sorted Array, Remove Element, Move Zeroes, Linked List Cycle, Middle of the Linked List gibi problemler girer; ayrıca bazı durumlarda
Sort Colors ve Partition List gibi problemler de bu mantıkla çözülür. Eğer problemde “remove, move, compact, unique, in-place, cycle, middle” gibi ifadeler geçiyorsa ve bir pointer gezerken
diğerinin veri yerleştirdiğini görüyorsan, doğru yaklaşım Fast & Slow’dur.
