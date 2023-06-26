using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
        abstract class Product
        {
            private string productId;
            private string name;
            private double price;
            private string producer;
             
            public Product(string productId, string name, double price, string producer)
            {
                this.productId = productId;
                this.name = name;
                this.price = price;
                this.producer = producer;
            }

            public abstract double ComputeTax();
        }

    }

