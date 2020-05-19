using PaperCave_Models.Enums;
using PaperCave_Models.Objects;
using PaperCave_Models.People;
using System.Collections.Generic;

namespace PaperCave_Mocks
{
    public class MockServices
    {
        public static List<CustomerModel> ReturnMappedCustomerData_Mock()
        {
            return new List<CustomerModel>() {
                new CustomerModel(){
                    CustomerID = "00001",
                    CustomerHistory = new HistoryModel(){
                       CustomerHistory = new List<SingleTransaction>(){
                        new SingleTransaction(){
                            TransactionId = "1234",
                            BookBought = new BookModel(){
                                BookID = "0001",
                                BookName = "To Kill a Mocking Bird",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "Harper", SecondName = "Lee", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        },
                        new SingleTransaction(){
                            TransactionId = "3234",
                            BookBought = new BookModel(){
                                BookID = "0023",
                                BookName = "Animal Farm",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "George", SecondName = "Orwell", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        }
                       }
                    },
                    Name = "Something",
                    Email = "something@yahoo.com",
                    Dob = new DateModel(){ Day = 16, Month = 10, Year = 1996},
                    PhoneNo = "9656031573",
                    Address = new AddressModel(){ HouseNumber = 1, Street = "Second Street", 
                        Locality = "Some street", CityorTown = "Sasitown", State = "Kerala", PostCode = "695005"}
                },
                new CustomerModel(){
                    CustomerID = "00001",
                    CustomerHistory = new HistoryModel(){
                       CustomerHistory = new List<SingleTransaction>(){
                        new SingleTransaction(){
                            TransactionId = "1234",
                            BookBought = new BookModel(){
                                BookID = "0001",
                                BookName = "To Kill a Mocking Bird",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "Harper", SecondName = "Lee", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        },
                        new SingleTransaction(){
                            TransactionId = "3234",
                            BookBought = new BookModel(){
                                BookID = "0023",
                                BookName = "Animal Farm",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "George", SecondName = "Orwell", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        }
                       }
                    },
                    Name = "Something",
                    Email = "something@yahoo.com",
                    Dob = new DateModel(){ Day = 16, Month = 10, Year = 1996},
                    PhoneNo = "9656031573",
                    Address = new AddressModel(){ HouseNumber = 1, Street = "Second Street",
                        Locality = "Some street", CityorTown = "Sasitown", State = "Kerala", PostCode = "695005"}
                },
                new CustomerModel(){
                    CustomerID = "00001",
                    CustomerHistory = new HistoryModel(){
                       CustomerHistory = new List<SingleTransaction>(){
                        new SingleTransaction(){
                            TransactionId = "1234",
                            BookBought = new BookModel(){
                                BookID = "0001",
                                BookName = "To Kill a Mocking Bird",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "Harper", SecondName = "Lee", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        },
                        new SingleTransaction(){
                            TransactionId = "3234",
                            BookBought = new BookModel(){
                                BookID = "0023",
                                BookName = "Animal Farm",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "George", SecondName = "Orwell", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        }
                       }
                    },
                    Name = "Something",
                    Email = "something@yahoo.com",
                    Dob = new DateModel(){ Day = 16, Month = 10, Year = 1996},
                    PhoneNo = "9656031573",
                    Address = new AddressModel(){ HouseNumber = 1, Street = "Second Street",
                        Locality = "Some street", CityorTown = "Sasitown", State = "Kerala", PostCode = "695005"}
                }
            };
        }

        public static CustomerModel ReturnMappedCustomerData_Mock(string parameter)
        {
            return new CustomerModel()
            {
                CustomerID = parameter,
                CustomerHistory = new HistoryModel()
                {
                    CustomerHistory = new List<SingleTransaction>(){
                        new SingleTransaction(){
                            TransactionId = "1344",
                            BookBought = new BookModel(){
                                BookID = "0021",
                                BookName = "Fathers and Sons",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "Ivan", SecondName = "Turgenev", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        },
                        new SingleTransaction(){
                            TransactionId = "4234",
                            BookBought = new BookModel(){
                                BookID = "0323",
                                BookName = "1984",
                                Price = 500,
                                Author = new AuthorModel(){ FirstName = "George", SecondName = "Orwell", ListofWorks = null},
                                Rating = AverageRatings.FiveStar,
                                Publisher  = new PublisherModel(){ PublisherId = "0321", PublisherName  = "Penguin Books", Address = null},
                            },
                            AddressDelivered = new AddressModel(){ }
                        }
                       }
                },
                Name = "Something",
                Email = "something@yahoo.com",
                Dob = new DateModel() { Day = 16, Month = 10, Year = 1996 },
                PhoneNo = "9656031573",
                Address = new AddressModel()
                {
                    HouseNumber = 1,
                    Street = "Second Street",
                    Locality = "Some street",
                    CityorTown = "Sasitown",
                    State = "Kerala",
                    PostCode = "695005"
                }
            };
        }
    }
}
