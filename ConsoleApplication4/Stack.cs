using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Stack<T> : ClassVariable<T>
    {
        public Stack() //конструктор стека с размером по умолчанию
        {
            this._array = new T[defaultCapacity];
        }

        public Stack(int Capacity) //конструктор стека заданного размера
        {
            this._array = new T[Capacity];
        }

        public T Pop() //Удаляет и возвращает объект, находящийся в начале Stack.
        {
            if (this.size() == 0)
            {
                throw new InvalidOperationException(); //вброс ошибки при взятии с пустого стека
            }
            return this._array[--index];
        }

        public void Push(T obj) //добавление элемента в стек
        {
            if (index == _array.Length) //переполнение стека
            {
                T[] tmp = _array;
                _array = null;
                _array = new T[2 * tmp.Length];
                for (int i = 0; i <= tmp.Length; i++)
                {
                    _array[i] = tmp[i];
                }
            }
            else if ((index * 3) >= _array.Length)
            {
                T[] tmp = _array;
                _array = new T[_array.Length / 2];
                _array = tmp;
            }
            _array[index] = obj;
            index++;
        }
    }
    
}
