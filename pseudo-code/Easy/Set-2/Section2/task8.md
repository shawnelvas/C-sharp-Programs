
# Task 8: Pattern Formation: Diamond
 
## Pseudocode :
1. Accept `rows` as paramters
2. loop from `i=1` to `i<=rows` to print top pyramid
    * use nested loop from `j=1` to `j<=(2*rows-1)`
        * check if `j>=rows-(i-1)` and `j<=rows+(i-1)` then append `"*"` to `result`
        * else append space `" "` to `result`
    * append new line to the `result`
3. loop from `i=rows-1` to `i>=1` to print bottom pyramid
    * use nested loop from `j=1` to `j<=(2*rows-1)`
        * check if `j>=rows-(i-1)` and `j<=rows+(i-1)` then append `"*"` to `result`
        * else append space `" "` to `result`
    * append new line to the `result`
4. return `result`
