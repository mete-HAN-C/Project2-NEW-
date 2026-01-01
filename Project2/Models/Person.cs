using SQLite;

namespace Project2.Models;

// tblPerson tablosu
[Table("tblPerson")]
public class Person
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }

    // Name TEXT NOT NULL Default 'No Name' CHECK(length(trim(Name))>0)
    [NotNull]
    public string Name { get; set; } = "No Name";

    // Surname TEXT NOT NULL Default 'No Surname' CHECK(length(trim(Surname))>0)
    [NotNull]
    public string Surname { get; set; } = "No Surname";

    // Age INTEGER NOT NULL Default 0 CHECK(Age>=0 AND Age<=100)
    public int Age { get; set; } = 0;

    // Email TEXT NOT NULL UNIQUE CHECK(Email like '%@%.%')
    [NotNull, Unique]
    public string Email { get; set; } = "";

    // Password TEXT NOT NULL CHECK(length... and glob for [A-Z] and [0-9])
    [NotNull]
    public string Password { get; set; } = "";

    // Height REAL NULLABLE CHECK (Height IS NULL OR (Height>=1.40 AND Height<=2.20))
    public double? Height { get; set; }

    // Weight REAL NULLABLE CHECK (Weight IS NULL OR (Weight>=45.00 AND Weight<=200.00))
    public double? Weight { get; set; }

    // Gender INTEGER CHECK (Gender IN (0,1,2)) Default 2
    public int Gender { get; set; } = 2;
}
