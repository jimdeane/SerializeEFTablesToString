# SerializeEFTablesToString
Published to NuGet

Takes an Entity Framework DBContext and Serialises the contents of all the tables specified in the List of strings to a string. 

The utility Class can be used as follows:

```csharp
string parameterString= $"Customers," +                    // Outputs all columns for all records in the Customer Table

                        $"Customers[]" +                   // same as above

                        $"Orders[OrderId;OrderQuantity]" + // outputs only the OrderId and 


                                                           // OrderQuantity from all records in the Orders table

                        $"Payments[!PaymentId;Date]";      // Outputs columns  EXCEPT PaymentId and Date from the Payments Table

SomeDbContext context = new SomeDbContext();

Formatter formatter = new Formatter();

String formattedOutputString = formatter.FormatEntities(context, parameterString);

```
The output string will have newline delimited lines as follows:
```
Customers

| CustomerId | Name      | DateOfBirth |
| 1          | Jon Doe   | 1982-03-12  |
| 2          | Eric Hand | 1966-04-15  |

Customers[]
| CustomerId | Name      | DateOfBirth |
| 1          | Jon Doe   | 1982-03-12  |
| 2          | Eric Hand | 1966-04-15  |

Orders[OrderId;OrderQuantity]
| OrderId | Quantity |
| 456     | 78       |
| 6578    | 65       |

Payments[!PaymentId;Date]
| PaymentAmount |
| 23.56         |
| 45.89         |
```

This last example assumes there were three columns in the table two of which were excluded.

Note these are TABLE names not the Entity names as DbContext.Database.SqlQuery is used.
