using System;

public interface ICustomerRepository
{
    void GetCustomerById(int customerId);
}

// Implementación concreta de ICustomerRepository
public class CustomerRepository : ICustomerRepository
{
    public void GetCustomerById(int customerId)
    {
  
        Console.WriteLine($"Obteniendo cliente con ID: {customerId}");
    }
}

public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;


    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public void GetCustomer(int customerId)
    {
        _customerRepository.GetCustomerById(customerId);
    }
}


public class Program
{
    public static void Main(string[] args)
    {
  
        ICustomerRepository customerRepository = new CustomerRepository();


        CustomerService customerService = new CustomerService(customerRepository);

   
        customerService.GetCustomer(1);
    }
}
