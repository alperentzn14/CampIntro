using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// categoryId Referans 
        /// kodun okunurluğu için ID ler başa yazılır.
        /// </summary>
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
