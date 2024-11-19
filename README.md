# Solution for "aVeryBigSum" Problem

This C# program solves the problem where you are tasked with calculating the sum of a list of very large integers. The solution reads the integers from input, computes their sum, and outputs the result.

## Problem Description

You are given a list of integers, and your goal is to compute their sum. The integers can be very large (up to 10^10 or more), so it's important to use a data type capable of handling such large numbers.

### Input Format:
- The first line contains an integer `n` (1 ≤ n ≤ 10^3), the number of integers in the list.
- The second line contains `n` space-separated integers, each integer `a_i` (0 ≤ a_i ≤ 10^10).

### Output Format:
- Output a single integer, the sum of all integers in the list.

## Approach

1. **Input Handling:**
   - The number of integers is read from the first line.
   - The integers are then read from the second line, split by spaces, and converted into a list of `long` integers.

2. **Summing the List:**
   - The program uses a simple loop to iterate through each number in the list, adding each number to a cumulative sum.

3. **Output:**
   - After calculating the sum, the result is printed to the console.

## Code Breakdown

- **`aVeryBigSum(List<long> ar)`**: 
  This method receives a list of `long` integers and calculates their sum. It uses a `foreach` loop to iterate over each number in the list, adding it to a cumulative sum variable.

- **`Main()`**:
  - Reads the number of elements from the console.
  - Reads and splits the next line of space-separated integers into a list of `long` values.
  - Calls the `aVeryBigSum` function to calculate the sum and prints the result.

## Example

### Input:
```
5
1000000001 1000000002 1000000003 1000000004 1000000005
```

### Output:
```5000000015```
