using SQLite;
using System;

namespace Project2.Models;

[Table("tblTransaction")]
public class tblTransaction
{
    // TransactionID INTEGER PRIMARY KEY AUTOINCREMENT
    [PrimaryKey, AutoIncrement]
    public int TransactionID { get; set; }

    // PersonID INTEGER NOT NULL
    [Indexed]
    public int PersonID { get; set; }

    // TransactionAmount REAL
    public double TransactionAmount { get; set; }

    // TransactionType INTEGER NOT NULL Check... Default 2
    // Varsayılan değerin 2 olması için "= 2" ataması yapıldı.
    // 0: Gider, 1: Gelir, 2: Diğer (Sizin mantığınıza göre)
    public int TransactionType { get; set; } = 2;

    // TransactionDescription TEXT
    public string TransactionDescription { get; set; }

    // TransactionDate TEXT
    public DateTime TransactionDate { get; set; }
}