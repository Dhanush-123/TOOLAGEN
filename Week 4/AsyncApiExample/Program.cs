using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace FetchDataExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var products = await FetchProductsAsync();
            DisplayProducts(products);
        }

        // Async method to fetch data from the database
        public static async Task<List<Product>> FetchProductsAsync()
        {
            string connectionString = "Server=SARIKA\\SQLEXPRESS;Database=NewWorkSpace;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
            string storedProcedure = "GetProducts";

            var products = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                products.Add(new Product
                                {
                                    ProductID = reader.GetInt32(0),
                                    ProductName = reader.GetString(1),
                                    Price = reader.GetDecimal(2),
                                    CreatedAt = reader.GetDateTime(3)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return products;
        }

        
        public static void DisplayProducts(List<Product> products)
        {
            Console.WriteLine("Fetched Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductID}, Name: {product.ProductName}, Price: {product.Price}, Created At: {product.CreatedAt}");
            }
        }
    }

    // Product model
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty; 
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
