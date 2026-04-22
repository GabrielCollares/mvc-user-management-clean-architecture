using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Banking.Services.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string PhoneNumber { get; private set; }
        public decimal Balance { get; private set; }

        public  User (string name, string email, string cpf, string phoneNumber)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Cpf = cpf;
        PhoneNumber = phoneNumber;
        Balance = 0;
    }
    

    public void AddBalance(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor do depósito deve ser maior que zero.");

        Balance += amount;
    }


    public void RemoveBalance(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("O valor deve ser maior que zero.");

        if (amount > Balance)
            throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");

        Balance -= amount;
    }

    
    
    }
}