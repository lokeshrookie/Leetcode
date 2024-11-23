using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Easy
    {
        // 1. Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                else
                {
                    map.TryAdd(nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }

        // 2. Valid Parenthesis
        public bool IsValid(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0)
                {
                    return false;
                }
                else if (c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        public bool IsValidV2(string s)
        {
            var bracketPairs = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count > 0 && stack.Peek() == bracketPairs[c])
                        stack.Pop();
                    else
                        return false;
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }


    }
}
