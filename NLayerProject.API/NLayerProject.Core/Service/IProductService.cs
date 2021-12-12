using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Service
{
    public  interface IProductService :IService<Product>
    {
        // Burada veritabanı dşında bir işlem yapacaksak burada yapacağız
        // bool ControlInnerBarcode(Product product);
        
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
