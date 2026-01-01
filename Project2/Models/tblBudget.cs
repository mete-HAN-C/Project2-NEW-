using SQLite;

namespace Project2.Models;

[Table("tblBudget")]
public class tblBudget
{
    // PersonID INTEGER PRIMARY KEY
    // AutoIncrement YOK. Çünkü ID'yi tblPerson tablosundaki ID ile aynı yapmalıyız.
    [PrimaryKey]
    public int PersonID { get; set; }

    // BudgetLimit REAL
    public double BudgetLimit { get; set; }
}