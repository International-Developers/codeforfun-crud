﻿using CodeForFun.Repository.Business.Abstract.Services;
using CodeForFun.Repository.DataAccess.Abstract;
using CodeForFun.Repository.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeForFun.Repository.Business.Concrete.Managers
{
    public class ProductDetailsManager : IProductDetailsService
	{
        private readonly IRepositoryWrapper _dal;

        public ProductDetailsManager(IRepositoryWrapper dal)
        {
            _dal = dal;
        }


        // GET ASYNC
        public async Task<ProductDetails> GetAsync(int id)
        {
            return await _dal.ProductDetails.ReadAsync(p => p.Id == id);
        }

        // GET ALL ASYNC
        public async Task<List<ProductDetails>> GetListAsync()
        {
            return await _dal.ProductDetails.ReadListAsync();
        }


        // ADD ASYNC
        public async void AddAsync(ProductDetails entity)
        {
            await Task.Run(() => { _dal.ProductDetails.CreateAsync(entity); });
        }

        // ADD RANGE ASYNC
        public async void AddRangeAsync(List<ProductDetails> entities)
        {
            await Task.Run(() => { _dal.ProductDetails.CreateRangeAsync(entities); });
        }


        // UPDATE ASYNC
        public async void UpdateAsync(ProductDetails entity)
        {
            await Task.Run(() => { _dal.ProductDetails.UpdateAsync(entity); });
        }

        // UPDATE RANGE ASYNC
        public async void UpdateRangeAsync(List<ProductDetails> entities)
        {
            await Task.Run(() => { _dal.ProductDetails.UpdateRangeAsync(entities); });
        }


        // DELETE ASYNC
        public async void DeleteAsync(ProductDetails productDetail)
        {
            await Task.Run(() =>  _dal.ProductDetails.DeleteAsync(productDetail));
        }

        // DELETE RANGE ASYNC
        public async void DeleteRangeAsync(IEnumerable<int> ids)
        {
            await Task.Run(() => { _dal.ProductDetails.DeleteRange(ids.Select(id => new ProductDetails { Id = id }).ToList()); });
        }
    }
}
