// See https://aka.ms/new-console-template for more information
using Business;
using Business.Interfaces;
using Infraestructure;
using Infraestructure.Database;
using Infraestructure.Service;
using Model;

Console.WriteLine("Hello, World!");

ICustomerService businessDb = new CustomerService(new CustomerDatabaseRepository());
Customer customer = businessDb.Get(1);

Console.WriteLine($"ID: {customer.Id} Nome: {customer.Name}");



ICustomerService businessApi = new CustomerService(new CustomerApiRepository());
customer = businessApi.Get(1);

Console.WriteLine($"ID: {customer.Id} Nome: {customer.Name}");