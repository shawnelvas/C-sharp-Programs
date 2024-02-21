# Sentence Value

## Problem Statement

Write a program that prints total value of a sentence where
a sentence can only contain alphabets from a to z (all smallcase),
each alphabet represents a value starting from a = 11 , b= 12 , c=13 ...to z = 36
you are not allowed to use array to store values of each alphabet such as 11, 12, .. 36
you are not allowed to use 26 If statements


1. Change string  to lower case
2. Declare a variable to store the total value of the sentence
3. total_value = 0
4. Prompt the user to enter a sentence
5. print "Enter a sentence:"

6. Read the user input as a string
7. sentence = input

8. Loop through each character in the sentence
9. for each char in sentence
10. Check if the character is an alphabet from a to z
11.  if char is between 'a' and 'z'
12. Convert the character to its ASCII value
13. ascii_value = ord(char)
14. Subtract 86 from the ASCII value to get the corresponding value from 11 to 36
15. value = ascii_value - 86
16. Add the value to the total value
17. total_value = total_value + value
18. End if
19. End for
20. Print the total value of the sentence
21. print "The total value of the sentence is " + total_value
