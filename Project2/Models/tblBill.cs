using SQLite;
using System;

namespace Project2.Models;

[Table("tblBill")]
public class tblBill
{
    // BillID INTEGER PRIMARY KEY AUTOINCREMENT
    [PrimaryKey, AutoIncrement]
    public int BillID { get; set; }

    // PersonID INTEGER NOT NULL
    // Kişiye ait faturaları hızlı listelemek için [Indexed] ekledik.
    [Indexed]
    public int PersonID { get; set; }

    // BillName TEXT
    public string BillName { get; set; }

    // BillPrice REAL
    public double BillPrice { get; set; }

    // BillPaymentDay TEXT
    // Veritabanında TEXT saklanır, kodda DateTime kullanılır.
    public DateTime BillPaymentDay { get; set; }
}