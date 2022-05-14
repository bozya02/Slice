using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slice.Model
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string FullName { get; set; }

        [Unique]
        public string Login { get; set; }
        public string Passwrod { get; set; }
    }
}
