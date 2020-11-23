﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NLayerApp.DAL.Model;
using NLayerApp.DAL.Model.Enums;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Interfaces
{
    public interface IProductAppService
    {
        Task<ProductViewModel> GetProduct(int id);
        Task<IEnumerable<ProductViewModel>> GetProducts();
        Task<IEnumerable<ProductViewModel>> GetCategoryOfProducts(string type);
        Task<OrderViewModel> CreateOrder(Order order);
    }
}