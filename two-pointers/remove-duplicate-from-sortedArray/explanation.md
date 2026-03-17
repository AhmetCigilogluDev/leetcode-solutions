# Remove Duplicates from Sorted Array

**Approach: Two Pointers**

## Algorithm

1. Start from the second element of the array
2. Keep track of the last unique element using `uniqueIndex`
3. Compare each element with the last unique element
4. If they are different:

   * Move `uniqueIndex` forward
   * Place the new unique element at that position
5. Continue until the end of the array
6. Return `uniqueIndex + 1` as the number of unique elements

---

**Time Complexity:** O(n)
**Space Complexity:** O(1)
