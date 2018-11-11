using System;

namespace PizzaFactoryApi.ViewModels
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}