using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewList
{

    public class MyPlanetColl : IList<MyPlanet>
    {
        private readonly MyPlanet[] MyPlanetArr = new MyPlanet[50];
        
        private int count;


        public IEnumerator GetEnumerator()
        {
            return MyPlanetArr.GetEnumerator();
        }

        public int IndexOf(MyPlanet item)
        {
            return ((IList<MyPlanet>)MyPlanetArr).IndexOf(item);
        }

        public void Insert(int index, MyPlanet item)
        {
            ((IList<MyPlanet>)MyPlanetArr).Insert(index, item);
        }

        public void Add(MyPlanet item)
        {
            if (count < MyPlanetArr.Length)
            {
                MyPlanetArr[count] = item;
                count++;   
            }         
            ((IList<MyPlanet>)MyPlanetArr).Add(item);
        }

        public bool Contains(MyPlanet item)
        {
            return ((IList<MyPlanet>)MyPlanetArr).Contains(item);
        }

        public void CopyTo(MyPlanet[] array, int arrayIndex)
        {
            var j = arrayIndex;
            for(var i=0;i<Count;i++)
            {
                array.SetValue(MyPlanetArr[i], j);
                j++;
            }
          
        }

        public bool Remove(MyPlanet item)
        {
            if(IndexOf(item)==-1)
            { return false; }
            RemoveAt(IndexOf(item));
            return true;
        }

        IEnumerator<MyPlanet> IEnumerable<MyPlanet>.GetEnumerator()
        {
            return ((IList<MyPlanet>)MyPlanetArr).GetEnumerator();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MyPlanet this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Printf()
        {
            Console.WriteLine("Есть   {0} элементов  и сейчас содержит {1} планет(у) ", MyPlanetArr.Length, count);
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Название планеты:{0}", MyPlanetArr[i]);
               
            }  
        }

    }
   
}
