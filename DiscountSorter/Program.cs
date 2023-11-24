using System;

public class Task2
{
    static void Customers1()
    {
        var Customers = new List<Dictionary<string, string>>();

        var Customer1 = new Dictionary<string, string>();
        Customer1.Add("Id", "1");
        Customer1.Add("name", "Alice");
        Customer1.Add("TotalAmountSpent", "150");
        Customer1.Add("TotalProductsPurchased", "5");

        var Customer2 = new Dictionary<string, string>();
        Customer2.Add("Id", "2");
        Customer2.Add("name", "Bob");
        Customer2.Add("TotalAmountSpent", "100");
        Customer2.Add("TotalProductsPurchased", "3");

        var Customer3 = new Dictionary<string, string>();
        Customer3.Add("Id", "3");
        Customer3.Add("name", "Charlie");
        Customer3.Add("TotalAmountSpent", "300");
        Customer3.Add("TotalProductsPurchased", "8");

        Customers.Add(Customer1);
        Customers.Add(Customer2);
        Customers.Add(Customer3);


        foreach (var item in Customers)
        {

            if (Convert.ToInt32(item["TotalProductsPurchased"]) > 4 && Convert.ToInt32(item["TotalAmountSpent"]) > 200)
            {
                item.Add("DiscountApplied", "10% + $25 Off");
            }
            else if (Convert.ToInt32(item["TotalAmountSpent"]) > 200)
            {
                item.Add("DiscountApplied", "$25 Off");
            }
            else if (Convert.ToInt32(item["TotalProductsPurchased"]) > 4)
            {
                item.Add("DiscountApplied", "10%");
            }

        }
        foreach (var item in Customers)
        {
            if (item.Count > 4)
            {
                foreach (var details in item)
                {
                    Console.WriteLine(details);
                }
                Console.WriteLine();
            }
            else
            {
                continue;
            }

        }

    }
    static void Main(String[] args)
    {
        Customers1();
    }
}
