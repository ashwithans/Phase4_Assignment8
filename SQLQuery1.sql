select * from Author
select * from Publisher
select * from BookCategory
select * from Book
select * from BookAuthor

INSERT INTO Author (AuthorId, Name) VALUES (4, 'Simran Raj');

INSERT INTO Publisher (PublisherId, PublisherName, Address) VALUES (4, 'XYZ Publishing', '789 Oak Street');

INSERT INTO BookCategory (CategoryId, CategoryName) VALUES (4, 'Mystery');

INSERT INTO Book (BookId, Name, Price, CategoryId, PublisherId) VALUES (4, 'Hidden Secrets', 14.99, 4, 4);

INSERT INTO BookAuthor (BookId, AuthorId) VALUES (4, 4);
