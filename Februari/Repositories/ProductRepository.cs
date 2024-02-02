﻿using Februari.Contexts;
using Februari.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Februari.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override ProductEntity Get(Expression<Func<ProductEntity, bool>> expression)
        {
            var entity = _context.Products
                .Include(i => i.Category)
                .FirstOrDefault(expression);
            return entity!;
        }

        public override IEnumerable<ProductEntity> GetAlll()
        {
            return _context.Products
                .Include(i => i.Category)
                .ToList();
        }
    }
}
