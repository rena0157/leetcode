// leetcode - Two Sums

using System;
using P1;

Example1();
Example2();
Example3();
Example4();

void Example1()
{
    var solution = new Solution();
    var nums = new[] { 2, 7, 11, 15 };
    const int target = 9;

    var example = solution.TwoSum(nums, target);
    Console.WriteLine($"Example 1 Solution: ({example[0]},{example[1]})");
}

void Example2()
{
    var solution = new Solution();
    var nums = new[] { 3, 2, 4 };
    const int target = 6;

    var example = solution.TwoSum(nums, target);
    Console.WriteLine($"Example 2 Solution: ({example[0]},{example[1]})");
}

void Example3()
{
    var solution = new Solution();
    var nums = new[] { 3, 3 };
    const int target = 6;
    
    var example = solution.TwoSum(nums, target);
    Console.WriteLine($"Example 3 Solution: ({example[0]},{example[1]})");
}

void Example4()
{
    var solution = new Solution();
    var nums = new[] { 3, 5, 5, 11 };
    const int target = 10;
    
    var example = solution.TwoSum(nums, target);
    Console.WriteLine($"Example 3 Solution: ({example[0]},{example[1]})");
}

