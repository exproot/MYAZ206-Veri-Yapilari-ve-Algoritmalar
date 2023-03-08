namespace ArrayTests
{
    // Unit Test
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
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
            var array = new Array.Array();
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
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            var item = array.GetItem(1);

            // Assert
            Assert.Equal(item, "Mehmet");
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
                var array = new Array.Array();
                array.Add("Ahmet");
                array.Add("Mehmet");

                // Act
                var item = array.GetItem(-1);

                // Assert
                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        /// <summary>
        /// Week 1 - RemoveItem Metot Test
        /// </summary>
        [Fact]
        public void Array_RemoveItem_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add(0);
            array.Add(1);

            // Act
            var item1 = array.RemoveItem(0);
            var item2 = array.RemoveItem(2);

            // Assert
            Assert.Equal(0, item1);
            Assert.Equal(-1, item2);
        }

        /// <summary>
        /// Week 1 - RemoveItem Metot Hata Firlatma Test
        /// </summary>
        [Fact]
        public void Array_RemoveItem_Exception_Test()
        {
            try
            {
                // Arrange
                var array = new Array.Array();
                array.Add(0);
                array.Add(1);

                // Act
                var item = array.RemoveItem(-1);

                // Assert
                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                // Assert
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
            var array = new Array.Array();
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

        /// <summary>
        /// Week 1 - Find Metot Test
        /// </summary>
        [Fact]
        public void Array_Find_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet"); //0
            array.Add("Mehmet");// 1

            // Act
            var item1 = array.Find("Mehmet");
            var item2 = array.Find("Ali");

            // Assert
            Assert.Equal(item1, 1);
            Assert.Equal(item2, -1);
        }

        [Fact]
        public void Array_Remove_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet"); //0
            array.Add("Mehmet");// 1

            // Act
            var item1 = array.Remove();
            var item2 = array.Remove();

            // Assert
            Assert.Equal(item1, "Mehmet");
            Assert.Equal(item2, "Ahmet");
        }

        [Fact]
        public void Array_Remove_Exception_Test()
        {
            // Try
            try
            {
                // Arrange
                var array = new Array.Array();

                // Act
                var item1 = array.Remove();

                // Assert
                Assert.True(false);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }
    }
}