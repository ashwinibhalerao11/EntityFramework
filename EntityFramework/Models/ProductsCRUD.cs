﻿namespace EntityFramework.Models
{
    public class ProductsCRUD
    {
        private readonly ApplicationDbContext db;
        public ProductsCRUD(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Products> GetProducts()
        {
            //var result = from p in db.Products
            //             select p;
            //return result;
            return db.Products.ToList();
        }
        public Products GetProductById(int id)
        {
            //var result = from p in db.Products
            //             where p.Id == id
            //             select p;
            // OR

            var result = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }
        public int AddProduct(Products product)
        {
            int result = 0;
            db.Products.Add(product); // add product object in the DbSet
            result = db.SaveChanges(); // reflect the changes from DbSet to DB
            return result;
        }
        public int EditProduct(Products product) // new data
        {
            int result = 0;
            var prod = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (prod != null) // prod contains old data
            {
                prod.Name = product.Name;
                prod.Company = product.Company;
                prod.Price = product.Price;
                result = db.SaveChanges();
            }
            return result;
        }
        public int DeleteProduct(int id)
        {
            int result = 0;
            var prod = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (prod != null) // prod contains old data
            {
                db.Products.Remove(prod);
                result = db.SaveChanges();
            }
            return result;

        }

    }
}
