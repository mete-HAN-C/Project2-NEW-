using SQLite;

namespace Project2.Models;

[Table("tblLesson")]
public class tblLesson
{
    // LessonID INTEGER PRIMARY KEY AUTOINCREMENT
    [PrimaryKey, AutoIncrement]
    public int LessonID { get; set; }

    // PersonID INTEGER NOT NULL
    // Foreign Key aramaları için [Indexed] eklemek performansı artırır.
    [Indexed]
    public int PersonID { get; set; }

    // LessonName TEXT
    public string LessonName { get; set; }

    // LessonPlace TEXT
    public string LessonPlace { get; set; }

    // LessonDay TEXT (Örn: "Pazartesi", "Salı" gibi gün isimleri için)
    public string LessonDay { get; set; }

    // LessonStartHour TEXT (Örn: "09:00")
    public string LessonStartHour { get; set; }

    // LessonFinishHour TEXT (Örn: "10:30")
    public string LessonFinishHour { get; set; }
}