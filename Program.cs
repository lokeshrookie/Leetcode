using Leetcode.Easy;
using System.ComponentModel.DataAnnotations;


// 1. Two sum inputs:
var nums = new int[] { 2, 7, 11, 15 };

var target = 9;


Easy easy = new Easy();

var twoSumResult = easy.TwoSum(nums, target);

Console.WriteLine(twoSumResult);


// Display the elements of the result (indices of the two numbers)
Console.WriteLine($"Indices of the two numbers: {twoSumResult[0]}, {twoSumResult[1]}");
Console.WriteLine($"Values of the two numbers: {nums[twoSumResult[0]]}, {nums[twoSumResult[1]]}");

// -------------------------------------------------------------------------------------------------------------



// 2. 





