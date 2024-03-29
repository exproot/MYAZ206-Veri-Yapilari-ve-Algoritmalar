namespace ArrayTests
{
    // Unit Test
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(3, count);
            Assert.Equal(4, array.Capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");
            array.Add("Canan");
            array.Add("Filiz");

            // Act
            int count = array.Count;

            // Assertion
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);
        }

        [Fact]
        public void Array_GetItem_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            var item = array.GetItem(1);

            // Assert
            Assert.Equal(item, "Mehmet");
        }

        [Fact]
        public void Array_Divide_Test() // HAFTA 1 ÖDEV
        {
            var array = new Array.Array<int>();
            array.Add(0); 
            array.Add(1);
            array.Add(2);
            array.Add(3); // dizi uzunlugu 4
            array.Add(4); // 5.elemani ekledik double metodu calisti ve uzunluk 8e cikacak.

            array.Remove(); // 1 eleman sildik, index 5 oldu.
            array.Remove(); // 1 eleman daha sildik index uzunlugun yarisi olan 4e dustu ve dizi uzunlugu yariya dusuruldu.

            Assert.Equal(4, array.Capacity);
        }

        /// <summary>
        /// Week 1 - GetItem Metot Hata Firlatma Test
        /// </summary>
        [Fact]
        public void Array_GetItem_Exception_Test()
        {
            try
            {
                // Arrange
                var array = new Array.Array<string>();
                array.Add("Ahmet");
                array.Add("Mehmet");

                // Act
                var item = array.GetItem(1);

                // Assert
                Assert.False(item.Equals("Ahmet"));
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        /// <summary>
        /// Week 1 - Swap Metot Test
        /// </summary>
        [Fact]
        public void Array_Swap_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet");     // 0
            array.Add("Mehmet");    // 1
            array.Add("Metin");     // 2

            // Act
            array.Swap(0, 2);
            var item1 = array.GetItem(0);   // Metin
            var item2 = array.GetItem(2);   // Ahmet

            // Assert
            Assert.Equal(item1, "Metin");
            Assert.Equal(item2, "Ahmet");
        }

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            Assert.Equal("AhmetMehmetCan", result);

        }

        [Fact]
        public void Array_Constructor_Test()
        {
            // Arrange
            var array = new Array.Array<int>(36,23,55,44,61);

            // Act
            var result = array.Capacity; // 5
            
            var result2 = String.Empty;
            foreach (var item in array)
            {
                result2 = string.Concat(result2, item);
            }

            // Assert
            Assert.Equal(5, result);
            Assert.Equal("3623554461", result2);
        }

        [Fact]
        public void Array_SetItem_Test()
        {
            // Arrange
            var numbers = new Array.Array<int>(1, 3, 5, 7);

            // Act
            numbers.SetItem(2, 55);

            // Assert
            Assert.Equal(55,numbers.GetItem(2));
            Assert.True(numbers.GetItem(2).Equals(55));
        }

        /// <summary>
        /// Week 1 - Find Metot Test
        /// </summary>
        [Fact]
        public void Array_Find_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            array.Add("Ahmet"); //0
            array.Add("Mehmet");// 1

            // Act
            var item1 = array.Find("Mehmet");
            var item2 = array.Find("Ali");

            // Assert
            Assert.Equal(item1, 1);
            Assert.Equal(item2, -1);
        }

        
        /// <summary>
        /// Week 2 - Test
        /// </summary>
        [Fact]
        public void Array_Remove_Test()
        {
            // Arrange
            var array = new Array.Array<int>();
            array.Add(0);   // 0
            array.Add(1);   // 1
            array.Add(2);   // 2
            array.Add(3);   // 3
            array.Add(4);   // 4

            // Act
            var item = array.RemoveItem(2);
            var item2 = array.GetItem(2);
            array.RemoveItem(3);
            
            // Assert
            Assert.Equal(2, item);
            Assert.Equal(3, item2);
            Assert.Equal(4, array.Capacity);
        }


        [Fact]
        public void Array_Copy_Test()
        {
            // Arrange
            var array = new Array.Array<string>();
            
            array.Add("Ahmet");     // 0
            array.Add("Mehmet");    // 1
            array.Add("Can");       // 2
            array.Add("Deniz");     // 3

            // Act
            var newArray = array.Copy(2, 3);
            var item = newArray[0];

            // Assert
            Assert.Equal("Can", item);
        }
    }
}