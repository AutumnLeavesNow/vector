using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Vector <T> where T: struct,
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {
        private List<T> Vect { get; set; }
        public int Length { get; private set; }
        //Constructors
        public Vector (int l)
        {
            Length = l;
            Vect = new List<T>(l);
        }
        public Vector (List<T> l)
        {
            Vect = l;
        }
        public Vector (int l, T el)
        {
            Length = l;
            Vect = new List<T>(l);
            for (int i=0; i<l;i++)
            {
                Vect.Add(el);
            }
        }

        //Indexer
        public T this[int i]
        {
            get { return Vect[i]; }
            set { Vect[i] = value; }
        }
        public double VectMod 
        {
            get
            {
                double res=0;
                dynamic val;
                for (int i=0; i<Length; i++)
                {
                    val = (dynamic)Vect[i] * (dynamic)Vect[i];
                    res += val;
                }
                return res;  
            }
        }
        //Operators 
        public static Vector<T> operator + (Vector<T> v1, Vector<T> v2)
        {
            if (v1.Length != v2.Length)
                throw new ArgumentException();
            Vector<T> res = new Vector<T>(v1.Length);
            for (int i=0;i<res.Length;i++)
            {
                dynamic p1 = v1[i];
                dynamic p2 = v2[i];
                T val = p1 + p2;
                res.Vect.Add(val);
            }
            return res;
        }
        public static Vector<T> operator- (Vector<T> v1, Vector<T> v2)
        {
            if (v1.Length != v2.Length)
                throw new ArgumentException();
            Vector<T> res = new Vector<T>(v1.Length);
            for (int i = 0; i < res.Length; i++)
            {
                dynamic p1 = v1[i];
                dynamic p2 = v2[i];
                T val = p1 - p2;
                res.Vect.Add(val);
            }
            return res;
        }
        public static Vector<T> operator *(Vector<T> v1, T v2)
        {
            Vector<T> res = new Vector<T>(v1.Length);
            for (int i = 0; i < res.Length; i++)
            {
                dynamic p1 = v1[i];
                dynamic p2 =v2;
                T val = p1 * p2;
                res.Vect.Add(val);
            }
            return res;
        }
        public static Vector<T> operator *( T v2,Vector<T> v1)
        {
            Vector<T> res = new Vector<T>(v1.Length);
            for (int i = 0; i < res.Length; i++)
            {
                dynamic p1 = v1[i];
                dynamic p2 = v2;
                T val = p1 * p2;
                res.Vect.Add(val);
            }
            return res;
        }
        public static Vector<T> operator *(Vector<T> v1, Vector<T> v2)
        {
            if (v1.Length != v2.Length || v1.Length!=3)
                throw new ArgumentException();
            Vector<T> res = new Vector<T>(3);
            res.Vect.Add((dynamic)v1[1] * (dynamic)v2[2] - (dynamic)v1[2] * (dynamic)v2[1]);
            res.Vect.Add((dynamic)v1[2] * (dynamic)v2[0] - (dynamic)v1[0] * (dynamic)v2[2]);
            res.Vect.Add((dynamic)v1[0] * (dynamic)v2[2] - (dynamic)v1[2] * (dynamic)v2[0]);
            return res;
        }

    }
}
