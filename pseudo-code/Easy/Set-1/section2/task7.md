# Format Date

## Problem Statement

Write a program, which given any date as input would print the date using the format day of the month with
'st,nd,th' based on which date it is.

## Pseudo Code

1. Accept the date as input.
2. Extract the day of the month from the input date.
3. If the day of the month is 1, 21, or 31, append "st" to the day of the month.
4. If the day of the month is 2 or 22, append "nd" to the day of the month.
5. If the day of the month is 3 or 23, append "rd" to the day of the month.
6. For all other days of the month, append "th" to the day of the month.
7. Print the date in the format "day of the month with st, nd, th".
8. using an array containing all the months of th year map each index of the array to the specified month
9. save the months starting from january at index 1 instead of zero to get correct mapping.
10. use to second part of the date string that is the month using the value match it to the index of the month array which ever index it point that value of the maunth array will be printed,
11. append the date -suffix ,the month  and  add the year as it is.
