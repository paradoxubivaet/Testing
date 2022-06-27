using System;
using System.Collections.Generic;

namespace SimpleApp.Tests
{

    public class Comparer
    {
        public static Comparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new Comparer<U>(func);
        }
    }

    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> comprasionFunction;

        public Comparer(Func<T, T, bool> func)
        {
            comprasionFunction = func;
        }

        public bool Equals(T x, T y)
        {
            return comprasionFunction(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
