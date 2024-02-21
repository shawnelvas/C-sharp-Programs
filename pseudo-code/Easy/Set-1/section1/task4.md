# Sum of 2 number

## Problem Statement
Given an array of integers numbers and an integer target, return indices of the two numbers such that they
add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element
twice.


### Example 1

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Output: Because nums[0] + nums[1] == 9, we return [0, 1].

## Pseudo Code
1.  Accept array `nums[]` as parameter
2. validate the array length and elements according to the constraints
3. initialise an array to store the indices of the elements adding to the target value as `index[]`
4. loop the array `nums[]` from `i=0 to i<n`
5. store the value of i in the index array at first position
6. nested loop `nums[]` from `j=i+1 to j<=n`
7. check if `nums[i] + nums[j] == target` then go to step 8  else continue
8. store the value of j in the index array at second position
9. break
10. return `index array`


