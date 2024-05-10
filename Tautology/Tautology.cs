using System;
using System.Collections.Generic;

namespace Tautology
{
    class Program
    {
        public static bool Not(bool operand) { return !operand; }
        public static bool And(bool op1, bool op2) { return (op1 && op2); }
        public static bool Or(bool op1, bool op2) { return (op1 || op2); }
        public static bool Implies(bool op1, bool op2) { return (op1 && !op2) ? false : true; }
        public static bool Equivalence(bool op1, bool op2) { return (op1 == op2); }

        static void Main(string[] args)
        {
            string operators = "CIDEN";
            byte n = Convert.ToByte(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Dictionary<char, int> positions = new Dictionary<char, int>();

                if (IsTautology(Console.ReadLine(), operators, positions))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        public static int PreProcess(string prefixExp, Dictionary<char, int> positions, string operators)
        {
            int pos = 0;
            foreach (char c in prefixExp)
            {
                if (!operators.Contains(c) && !positions.ContainsKey(c))
                {
                    positions.Add(c, pos++);
                }
            }
            return positions.Count;
        }

        public static bool IsTautology(string exp, string operators, Dictionary<char, int> positions)
        {
            int num_vars = PreProcess(exp, positions, operators);
            int num_states = Convert.ToInt32(Math.Pow(2, num_vars));
            bool[] binary_state;
            bool truth = true;
            for (int state = 0; state < num_states; state++)
            {
                binary_state = ToBooleanState(state, num_vars);
                truth = Evaluate(exp, positions, binary_state);
                if (!truth)
                    break;
            }
            return truth;
        }

        public static bool[] ToBooleanState(int integerState, int num_vars)
        {
            bool[] state = new bool[num_vars];
            string str = Convert.ToString(integerState, 2);
            for (int i = 0; i < str.Length; i++)
                state[i] = (str[i] == '1') ? true : false;
            return state;
        }

        public static bool Evaluate(string expression, Dictionary<char, int> positions, bool[] state)
        {
            bool op1, op2;
            char elm;
            Stack<bool> eval = new Stack<bool>();

            for (int i = expression.Length - 1; i >= 0; i--)
            {
                elm = expression[i];
                switch (elm)
                {
                    case 'C':
                        op1 = eval.Pop();
                        op2 = eval.Pop();
                        eval.Push(And(op1, op2));
                        break;
                    case 'I':
                        op1 = eval.Pop();
                        op2 = eval.Pop();
                        eval.Push(Implies(op1, op2));
                        break;
                    case 'D':
                        op1 = eval.Pop();
                        op2 = eval.Pop();
                        eval.Push(Or(op1, op2));
                        break;
                    case 'E':
                        op1 = eval.Pop();
                        op2 = eval.Pop();
                        eval.Push(Equivalence(op1, op2));
                        break;
                    case 'N':
                        op1 = eval.Pop();
                        eval.Push(Not(op1));
                        break;
                    default:
                        eval.Push(state[positions[elm]]);
                        break;
                }
            }
            return eval.Pop();
        }
    }
}