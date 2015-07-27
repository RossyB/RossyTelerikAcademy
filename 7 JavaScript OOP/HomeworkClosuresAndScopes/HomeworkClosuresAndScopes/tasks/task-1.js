/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function validateTitle(title) {
            
		    if (title.length < 2 || title.length > 100) {
		        throw new Error('Title must be between 2 and 100 characters')
		    }
		}

		function validateCategory(category) {

		    if (category.length < 2 || category.length > 100) {
		        throw new Error('Category must be between 2 and 100 characters');
		    }
		}

		function validateAutor(autor) {
            
		    if (autor === '') {
		        throw new Error('Author must be non-empty string');
		    }
		}

		function validateISBN(ISBN) {

		    if (!(/^[0-9]{10,13}$/.test(ISBN))) {
		        throw new Error('ISBN must be 10 or 13 digits');
		    }
		}

		function isBookInList(newBook) {
		    return books.some(function (book) {
		        return book.title == newBook.title || book.isbn == newBook.isbn;
		    });
		}

		function addCategory(newCategory) {
            
		    if (!categories.some(function (category) {
                return category === newCategory;
		    })) {
		        categories.push(newCategory);
		    }
		}

		function addBook(book) {
		    validateTitle(book.title);
		    validateCategory(book.category);
		    validateAutor(book.autor);
		    validateISBN(book.isbn);

		    if (isBookInList(book)) {
		        throw new Error('A book with the same title or ISBN is already added');
		    }

		    book.ID = books.length + 1;
		    books.push(book);
		    addCategory(book.category);
			return book;
		}

		function listBooks(sortBy) {
		    var sortedbooks = [];

		    if (!sortBy || sortBy.length == 0) {
		        sortedbooks = books;
		    }

		    else if (sortBy.hasOwnProperty('category') || sortBy.hasOwnProperty('author')) {
		        sortedbooks = books.filter(function (book) {
		            return book.category == sortBy.category || book.author == sortBy.author;
		        })
		    }

		    return sortedbooks;
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};

	} ());
	return library;
}

module.exports = solve;
