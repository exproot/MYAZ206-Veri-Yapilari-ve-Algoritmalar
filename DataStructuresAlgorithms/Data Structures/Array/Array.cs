﻿using System.Collections;

namespace Array
{
    public class Array<T> : IEnumerable
    {
        // Object
        // Type : Array
        private T[] _InnerArray; // null
        private int index = 0;

        public int Count => index;  // Dizi kaç eleman var?
        public int Capacity => _InnerArray.Length;


        public Array()
        {
            _InnerArray = new T[4]; // Block allocation
        }

         public Array(params T[] init) {
            var newArray = new T[init.Length];
            System.Array.Copy(init, newArray, init.Length);
            _InnerArray = newArray;
        }

        public void Add(T item)
        {
            if (index == _InnerArray.Length)
            {
                DoubleArray(_InnerArray);
            }

            _InnerArray[index] = item;
            index++;
        }

        private void DoubleArray(T[] array)
        {
            var newArray = new T[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray = newArray;
        }

        /// <summary>
        /// Week 1
        /// </summary>
        /// <param name="position"></param>
        /// <returns>
        ///     Verilen pozisyonda bulunan elemanı geri döndürür.
        ///     Eğer pozisyon sınırlar dışındaysa IndexOutOfRangeException hata fırlatır.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public T GetItem(int position)
        {
            // throw new NotImplementedException();
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            return _InnerArray[position];
        }
        /// <summary>
        /// Week 2 - Implematation 1
        /// SetItem içerisinde verilen pozisyon değeri aralık dışarısında ise hata fırlatılmalı.
        /// Exception() // IndexOutOfRangeException()
        /// </summary>
        /// <param name="position"></param>
        /// <param name="item"></param>
        public void SetItem(int position, T item) {
             if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            _InnerArray[position] = item;
        }

        public T Remove()
        {
            if (index == 0)
                throw new Exception("Out of index!");
            if (index == _InnerArray.Length / 2) {
                DivideArray(_InnerArray); // HAFTA 1 ÖDEV
            }
            var temp = _InnerArray[index - 1];
            _InnerArray[index - 1] = default;
            index--;
            return temp;
        }

        private void DivideArray(T[] arr) { // HAFTA 1 ÖDEV
            try
            {
                var newArray = new T[arr.Length / 2];
                System.Array.Copy(arr, newArray, arr.Length / 2);
                _InnerArray = newArray;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        /// <summary>
        /// Week 2 - Implementation 2 
        /// Remove işleminde girilen pozisyondaki eleman çıkarılmalıdır.
        /// Çıkarma işleminden sonra eleman geri döndürülmelidir.
        /// Çıkarılan elemanın yerine diğerleri kaydırılmalıdır.
        /// </summary>
        /// <param name="position"></param>
        /// <exception cref="NotImplementedException"></exception>
        public T RemoveItem(int position) {
            var item = GetItem(position);
            SetItem(position, default);
            for (int i = position; i < Count -1; i++)
            {
                Swap(i, i+1);
            }
            index--;

            if (index == _InnerArray.Length / 2) {
                var newArr = new T[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArr, newArr.Length);
                _InnerArray = newArr;
            }
            return item;
        }

        /// <summary>
        /// Week 1 - Verilen pozisyondaki elemanları yer değiştirir.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public void Swap(int p1, int p2)
        {
            var temp = _InnerArray[p1];
            _InnerArray[p1] = _InnerArray[p2];
            _InnerArray[p2] = temp;
        }

        /// <summary>
        /// Week 1
        /// </summary>
        /// <param name="item"></param>
        /// <returns>
        ///     Verilen elemana ait pozisyon bilgisini geri döndürür.
        ///     Eğer eleman yoksa -1 geri döndürür.
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Find(T item) // Index
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (item.Equals(_InnerArray[i]))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Week 2 - Implementation 3
        /// Verilen değer aralındaki elemanlar kopyalanmalıdır.
        /// Geri dönüş değeri dizidir.
        /// Verilen pozisyon bilgileri kontrol edilmelidir.
        /// </summary>
        /// <returns></returns>
        public T[] Copy(int v1, int v2)
        {
            var newArray = new T[v2]; // v2 - v1
            int j = 0;
            for(int i=v1; i < v2; i++)
            {
                newArray[j] = GetItem(i); // Object
                j++;
            }
            return newArray;
        }

        public IEnumerator GetEnumerator()
        {
            return _InnerArray.GetEnumerator();
        }
    }
}