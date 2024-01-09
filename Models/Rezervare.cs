using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proiect_hotel_app.Models
{
    public class Rezervare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Data_start { get; set; }
        public DateTime Data_end { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }


    }
}
