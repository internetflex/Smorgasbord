using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    /*
    Write a function that checks the correctness of the placed parentheses in the string. 
    We are going to check the string for a balanced parenthesis, that is, that all 
    opening parentheses have a closing parenthesis and that they are logically 
    placed in the string.

    Correct placement of parentheses
    e.g. () (()) [] {} <> [<({})>] [[]] (((())))

    Incorrect placement:
    e.g. )
    (
        > <
    ()) [] ((()) () () (()) ()) (
    */
    
    public class Brackets
    {
        public bool IsBalanced(string input)
        {
            var matches = new Dictionary<char, char>
            {
                { '{', '}' },
                { '(', ')' },
                { '[', ']' },
                { '<', '>' },
            };

            var brackets = new Stack<char>();

            foreach (var ch in input)
            {
                if (matches.ContainsKey(ch))
                    brackets.Push(matches[ch]);
                if (!matches.Values.Contains(ch)) 
                    continue;
                if (!brackets.TryPop(out var closingChar))
                    return false;
                if (closingChar != ch)
                    return false;
            }

            return brackets.Count == 0;
        }
    }
}