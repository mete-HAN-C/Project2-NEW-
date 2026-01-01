using SQLite;
using System;

namespace Project2.Models;

[Table("tblActivity")]
public class tblActivity
{
    // ActivityID INTEGER PRIMARY KEY AUTOINCREMENT
    [PrimaryKey, AutoIncrement]
    public int ActivityID { get; set; }

    // PersonID INTEGER NOT NULL
    // İlişkili kayıtları hızlı bulmak için indexlendi
    [Indexed]
    public int PersonID { get; set; }

    // ActivityTitle TEXT
    public string ActivityTitle { get; set; }

    // ActivityExplanation TEXT
    public string ActivityExplanation { get; set; }

    // ActivityStartDate TEXT
    // Veritabanında metin olarak tutulur, kodda DateTime olarak kullanılır.
    public DateTime ActivityStartDate { get; set; }

    // ActivityEndDate TEXT
    public DateTime ActivityEndDate { get; set; }
}