 ## Pattern Formation: Right Triangle

 
## Pseudo Code
1. Accept `rows` as parameter
2. initialise `result` as string
3. loop from `i=1` to `i<=rows`
    * use nested loop from `j=rows-i` to `j>0`
        * append space `" "` to `result`
    * use another nested loop from `k=1` to `k<=i`
        * append `i` to the `result`
    * append new line to the `result`
4. return `result`
