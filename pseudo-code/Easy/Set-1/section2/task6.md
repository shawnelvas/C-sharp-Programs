# Number exists in array

## Problem Statement

Given 2 arrays of different length, each one containing numbers in sorted order. Write a program that prints if
a given number is present in either of the array.


## Pseudo Code 
1. Accept two arrays as **array_one** and **array_two** and target **input_number** as parameters
2.  flag1 = 0 , flag2 = 0
3. loop through _array_one_ from _i = 0_ to _i < array_one.length()_
4. check if _input_number == array_one[i]_ then goto step 5 else conitnue
5. update _flag1 = 1_
6. break
7. loop through _array_two_ from _i = 0_ to _i < array_two.length()_
8. check if _input_number == array_two[i]_ then goto step 9 else conitnue
9. update _flag2 = 1_
10. break
11. check if _flag1 == 1 && flag2 == 1_ then goto step 13 else 14
12. return ` number found in both arrays`
13. check if _flag2 == 1_ then goto step 15 else 16
14 return ` number found in array_two array`
15. check if _flag1 == 1_ then goto step 17 else 18
16. return ` number found in array_one array`
17. return ` number  not found in arrays`
