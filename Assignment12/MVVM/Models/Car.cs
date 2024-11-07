using System;
using SQLite;

namespace Assignment12.MVVM.Models;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get ; set ; }

    [Column("car_id")]
    public string CarId { get; set; }

    [Column("car_model")]
    public string Model { get; set; }

    [Column("car_color")]
    public string Color { get; set; }

}
