using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaData.Models
{
    public class User: BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
