namespace Array
{
    public class Array
    {
        // Object
        // Type : Array
        private Object[] _InnerArray; // null
        private int index = 0;

        public int Count => index;  // Dizi kaç eleman var?
        public int Capacity => _InnerArray.Length;


        public Array()
        {
            _InnerArray = new Object[4]; // Block allocation
        }

        public void Add(Object item)
        {
            if (index == _InnerArray.Length)
            {
                DoubleArray(_InnerArray);
            }

            _InnerArray[index] = item;
            index++;
        }

        private void DoubleArray(object[] array)
        {
            var newArray = new Object[array.Length * 2];
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
        public Object GetItem(int position)
        {
            // throw new NotImplementedException();
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            return _InnerArray[position];
        }

        public Object Remove()
        {
            if (index == 0)
                throw new Exception("Out of index!");
            if (index == _InnerArray.Length / 2)
                throw new NotImplementedException();
            var temp = _InnerArray[index - 1];
            _InnerArray[index - 1] = null;
            index--;
            return temp;
        }

        /// <summary>
        /// Week 1
        /// </summary>
        /// <param name="position"></param>
        /// <returns>
        ///     Verilen pozisyonda bulunan elemanı siler ve elemanı geri döndürür.
        ///     Eğer eleman yoksa veya sınırlar dışındaysa IndexOutOfRangeException hatası fırlatır.
        ///     Eğer pozisyonda eleman yoksa -1 döndür. 
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public Object RemoveItem(int position)
        {
            // throw new NotImplementedException();
            var item = GetItem(position);
            if (item != null)
            {
                _InnerArray[position] = null;
                return item;
            }
            return -1;
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
        public Object Find(Object item) // Index
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (item == _InnerArray[i])
                    return i;
            }
            return -1;
        }
    }
}