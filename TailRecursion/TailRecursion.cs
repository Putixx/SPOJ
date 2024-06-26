﻿using System;

namespace MOHIBPIZ_PIZZA
{
    public static class TailRecursion
    {
        public static T Execute<T>(Func<RecursionResult<T>> func)
        {
            do
            {
                var recursionResult = func();
                if (recursionResult.IsFinalResult)
                    return recursionResult.Result;
                func = recursionResult.NextStep;
            } while (true);
        }

        public static RecursionResult<T> Return<T>(T result)
        {
            return new RecursionResult<T>(true, result, null);
        }

        public static RecursionResult<T> Next<T>(Func<RecursionResult<T>> nextStep)
        {
            return new RecursionResult<T>(false, default(T), nextStep);
        }

    }
    public class RecursionResult<T>
    {
        private readonly bool _isFinalResult;
        private readonly T _result;
        private readonly Func<RecursionResult<T>> _nextStep;
        internal RecursionResult(bool isFinalResult, T result, Func<RecursionResult<T>> nextStep)
        {
            _isFinalResult = isFinalResult;
            _result = result;
            _nextStep = nextStep;
        }

        public bool IsFinalResult { get { return _isFinalResult; } }
        public T Result { get { return _result; } }
        public Func<RecursionResult<T>> NextStep { get { return _nextStep; } }
    }
    class Program
    {
        public static RecursionResult<long> Pizza(long t, long x)
        {
            if (t == 0)
                return TailRecursion.Return(x - 1);
            else
                return TailRecursion.Next(() => Pizza(t - 1, x + t));
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            int[] dane = new int[t];

            for (int i = 0; i < t; i++)
                dane[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
                Console.WriteLine(TailRecursion.Execute(() => Pizza(dane[i], 2)));
        }
    }
}