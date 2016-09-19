using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewList
{

    class MyStarColl : IList
    {
        private readonly object[] MyArr = new object[50];
        private readonly object[] MyStarName = new object[50];
        private readonly object[] MyStarMass = new object[50];
        private readonly object[] MyStarRange = new object[50];
        private readonly object[] MyStarClass = new object[50];
        private readonly object[] MyStarLight= new object[50];
        private readonly object[] MyPlanetArround = new object[50];
        private int count;
        private int countStarName = 0;
        private int countStarMass = 0;
        private int countStarRange = 0;
        private int countStarClass = 0;
        private int countStarLight = 0;
        private int countPlanetArround  = 0;
        public void SimpleList()
        {
            count = 0;
        }
        public int AddStarName(object value)
        {
            if (countStarName < MyStarName.Length)
            {
                MyStarName[countStarName] = value;
                countStarName++;
                return (countStarName - 1);
            }
            return -1;
        }

        public int AddStarMass(object value)
        {
            if (countStarMass < MyStarMass.Length)
            {
                MyStarMass[countStarMass] = value;
                countStarMass++;
                return (countStarMass - 1);
            }
            return -1;
        }

        public int AddStarRange(object value)
        {
            if (countStarRange < MyStarRange.Length)
            {
                MyStarRange[countStarRange] = value;
                countStarRange++;
                return (countStarRange - 1);
            }
            return -1;
        }

        public int AddStarLight(object value)
        {
            if (countStarLight < MyStarLight.Length)
            {
                MyStarLight[countStarLight] = value;
                countStarLight++;
                return (countStarLight - 1);
            }
            return -1;
        }

        public int AddStarClass(object value)
        {
            if (countStarClass < MyStarClass.Length)
            {
                MyStarClass[countStarClass] = value;
                countStarClass++;
                return (countStarClass - 1);
            }
            return -1;
        }

        public int AddPlanetArround(object value)
        {
            if (countPlanetArround < MyPlanetArround.Length)
            {
                MyPlanetArround[countPlanetArround] = value;
                countPlanetArround++;
                return (countPlanetArround - 1);
            }
            return -1;
        }

        public int Add(object value)
        {
            if (count < MyArr.Length)
            {
                MyArr[count] = value;
                count++;
                return (count - 1);
            }
            return -1;
        }
        public void Clear()
        {
            count = 0;
        }
        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
                if (MyArr[i] == value)
                {
                    return i;
                }
            return -1;
        }
        public void Insert(int index, object value)
        {
            if ((count + 1 <= MyArr.Length) && (index < Count) && (index >= 0))
            {
                count++;
                for (int i = Count - 1; i > index; i--)
                {
                    MyArr[i] = MyArr[i - 1];
                }
                MyArr[index] = value;
            }
        }
        public bool IsFixedSize
        {
            get { return true; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = Count - 1; i > index; i++)
                {
                    MyArr[i] = MyArr[i + 1];
                    count--;
                }
            }
        }
        public void RemoveStar(int index)
        {
            if ((index >= 0) && (index < CountStarName))
            {
                for (int i = CountStarName - 1; i > index; i++)
                {
                    MyStarName[i] = MyStarName[i + 1];
                    count--;
                }
            }
        }
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(MyArr[i], j);
                j++;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public int CountStarName
        {
            get { return countStarName; }
        }

        public int CountStarMass
        {
            get { return countStarMass; }
        }

        public int CountStarRange
        {
            get { return countStarRange; }
        }

        public int CountStarLight
        {
            get { return countStarLight; }
        }

        public int CountStarClass
        {
            get { return countStarClass; }
        }

        public int CountPlanetArround
        {
            get { return countPlanetArround; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        public object this[int index]
        {
            get
            {
                return ((IList)MyArr)[index];
            }

            set
            {
                ((IList)MyArr)[index] = value;
            }
        }

        public IEnumerator GetIEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return MyArr[i];
            }
        }

        public void Printf()
        {
            Console.WriteLine("Есть   {0} элементов  и сейчас содержит {1} планет(у) ", MyArr.Length, countStarName);
            for (int i = 0; i < CountStarName; i++)
            {
                Console.WriteLine("Название звезды:{0}", MyStarName[i]);
                Console.WriteLine("ее радиус {0}", MyStarRange[i]);
                Console.WriteLine("ее вес : {0} ", MyStarMass[i]);
                Console.WriteLine("ее светимость :{0}", MyStarLight[i]);
                Console.WriteLine("ее класс  {0}", MyStarClass[i]);
                Console.WriteLine("ее планеты-спутники : {0} ", MyPlanetArround[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return MyArr.GetEnumerator();
        }
    }

}
