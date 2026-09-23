using BookLibrary;

namespace BookLibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_ValidPages_SetPages()
        {
            // Arrange
            string title = "Clean Code";
            int pages = 464;
            // Act
            var book = new Book(title, pages);
            // Assert
            Assert.Equal(pages, book.Pages);
        }
    }
}
