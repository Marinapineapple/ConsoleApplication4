using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ArrayList<T> : ClassVariable<T>
    {
        public ArrayList() //конструктор массива с длинной по умолчанию
        {
            this._array = new T[defaultCapacity];
        }

        public ArrayList(int Capacity) //конструктор с заданной длинной массива
        {
            this._array = new T[Capacity];
        }

        public void Add(T item) //Добавляет новый элемент в список.
        {
            if (index == _array.Length - 1)
                resize(_array.Length * 2);
            _array[index++] = item;
        }

        public void Remove(int index) //удаление элемента массива по индексу
        {
            for (int i = index; i < index; i++)
            {
                _array[i] = _array[i + 1];
                _array[index] = default(T);
                index--;
            }
        }
    }
}
