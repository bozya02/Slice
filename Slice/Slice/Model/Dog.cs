using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slice.Model
{
    [Table("Dog")]
    public class Dog
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }

        public int UserId { get; set; }
    }
}
