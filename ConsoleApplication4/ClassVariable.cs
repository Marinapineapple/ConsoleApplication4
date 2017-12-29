using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class ClassVariable<T> //базовый универсальный класс с общими для всех классов-наследников методами
    {
        protected T[] _array; //массив для хранения данных типа T
        protected const int defaultCapacity = 15; //вместимость по умолчанию, потом можно расширить
        public int index = 0;
   
        public int Count //параметр для вывода размера 
        {
            get
            {
                return this.size();
            }
        }

        public int size() //возвращает количество элементов в списке
        {
            return index;
        }

        public bool isEmpty() //проверка на пустоту
        {
            return this.size() == 0;
        }
       
        public T get(int index) //возвращает элемент списка по индексу
        {
            return (T)_array[index];
        }

        public T Peek() //берёт вершину стека/конец очереди БЕЗ удаления
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return this._array[Count - 1];
        }

        public void resize(int newlength) //метод изменения размера
          {
           T[] newarray = new T[newlength];
           System.Array.Copy(_array, 0, newarray, 0, index);
           _array = newarray;
          }      
         };
 }

