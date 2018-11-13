//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lesson1113 //10장 배열
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int[] scores = new int[] { 8, 71, 81, 90, 34 };
//            foreach (int score in scores)
//                Console.Write($"{score} ");
//            Console.WriteLine();

//            Array.Sort(scores);
//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            Console.WriteLine("Binary Search : 81 is at {0}",
//                Array.BinarySearch<int>(scores, 81)); //배열을 이진탐색해줌, 정렬안되어있어도 정렬해서 찾아줌

//            Console.WriteLine("Everyone Passed ? : {0}", 
//                Array.TrueForAll<int>(scores, CheckPassed));

//            int index = Array.FindIndex<int>(scores,
//                delegate (int score) //delegate 대리, 위임   여기서는 한번쓰고 버리는 위임자
//             {
//                 if (score < 60) return true;
//                 else return false;
//             });
//            scores[index] = 61;


//            Array.ForEach<int>(scores, new Action<int>(Print));
//            Console.WriteLine();

//            Console.WriteLine("Everyone Passed ? : {0}", 
//                Array.TrueForAll<int>(scores, CheckPassed));
//        }

//        private static bool CheckPassed(int obj)
//        {
//            if (obj >= 60) return true;
//            else return false;
//            throw new NotImplementedException();
//        }
//        private static void Print(int obj)
//        {
//            Console.Write($"{obj}");
//            throw new NotImplementedException();
//        }
//    }
//}





//10장 예제
//using System;
//using System.Collections;

//namespace Enumerable
//{
//    class MyList : IEnumerable, IEnumerator
//    {
//        private int[] array;
//        int position = -1;

//        public MyList()
//        {
//            array = new int[3];
//        }

//        public int this[int index]
//        {
//            get
//            {
//                return array[index];
//            }

//            set
//            {
//                if (index >= array.Length)
//                {
//                    Array.Resize<int>(ref array, index + 1);
//                    Console.WriteLine($"Array Resized : {array.Length}");
//                }

//                array[index] = value;
//            }
//        }

//        // IEnumerator 멤버
//        public object Current
//        {
//            get
//            {
//                return array[position];
//            }
//        }

//        // IEnumerator 멤버
//        public bool MoveNext()
//        {
//            if (position == array.Length - 1)
//            {
//                Reset();
//                return false;
//            }

//            position++;
//            return (position < array.Length);
//        }

//        // IEnumerator 멤버
//        public void Reset()
//        {
//            position = -1;
//        }

//        // IEnumerable 멤버
//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                yield return (array[i]);
//            }
//        }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            MyList list = new MyList();
//            for (int i = 0; i < 5; i++)
//                list[i] = i;
//            list[5] = 6;
//            list[7] = 8;

//            list[6] = 7;

//            foreach (int e in list)
//                Console.WriteLine(e);
//        }
//    }
//}


// 11장 예제
//using System;

//namespace CopyingArray
//{
//    class MainApp
//    {
//        static void CopyArray<T>(T[] source, T[] target)
//        {
//            for (int i = 0; i < source.Length; i++)
//                target[i] = source[i];
//        }

//        static void Main(string[] args)
//        {
//            int[] source = { 1, 2, 3, 4, 5 };
//            int[] target = new int[source.Length];

//            CopyArray<int>(source, target);

//            foreach (int element in target)
//                Console.WriteLine(element);

//            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
//            string[] target2 = new string[source2.Length];

//            CopyArray<string>(source2, target2);

//            foreach (string element in target2)
//                Console.WriteLine(element);
//        }
//    }
//}




//using System;

//namespace ConstraintsOnTypeParameters
//{
//    class StructArray<T> where T : struct
//    {
//        public T[] Array { get; set; }
//        public StructArray(int size)
//        {
//            Array = new T[size];
//        }
//    }

//    class RefArray<T> where T : class
//    {
//        public T[] Array { get; set; }
//        public RefArray(int size)
//        {
//            Array = new T[size];
//        }
//    }

//    class Base { }
//    class Derived : Base { }
//    class BaseArray<U> where U : Base
//    {
//        public U[] Array { get; set; }
//        public BaseArray(int size)
//        {
//            Array = new U[size];
//        }

//        public void CopyyArray<T>(T[] Target) where T : U
//        {
//            Target.CopyTo(Array, 0);
//        }
//    }

//    class MainApp
//    {
//        public static T CreateInstance<T>() where T : new()
//        {
//            return new T();
//        }

//        static void Main(string[] args)
//        {
//            StructArray<int> a = new StructArray<int>(3);
//            a.Array[0] = 0;
//            a.Array[1] = 1;
//            a.Array[2] = 2;

//            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
//            b.Array[0] = new StructArray<double>(5);
//            b.Array[1] = new StructArray<double>(10);
//            b.Array[2] = new StructArray<double>(1005);

//            BaseArray<Base> c = new BaseArray<Base>(3);
//            c.Array[0] = new Base();
//            c.Array[1] = new Derived();
//            c.Array[2] = CreateInstance<Base>();

//            BaseArray<Derived> d = new BaseArray<Derived>(3);
//            d.Array[0] = new Derived(); // Base 형식은 여기에 할당 할 수 없다.
//            d.Array[1] = CreateInstance<Derived>();
//            d.Array[2] = CreateInstance<Derived>();

//            BaseArray<Derived> e = new BaseArray<Derived>(3);
//            e.CopyyArray<Derived>(d.Array);
//        }
//    }
//}


using System;
using System.Collections.Generic;

namespace UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 10; i < 15; i++)
                list.Add(i);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 7);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
    }
}
