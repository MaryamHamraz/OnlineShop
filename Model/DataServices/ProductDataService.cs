using Model.DomainModels;

namespace Model.DataServices
{
    public class ProductDataService
    {
        #region [- SelectAll() -]
        public List<Product> SelectAll()
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    var products = context.Product.ToList();
                    return products;
                }
            }
            catch
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Product product)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    context.Product.Add(product);
                    context.SaveChanges();
                }
            }
            catch 
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Update() -]
        public void Update(int id, Product product)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    var productToModify = context.Product.SingleOrDefault(p => p.Id == id);
                    productToModify.Title = product.Title;
                    productToModify.UnitPrice = product.UnitPrice;
                    productToModify.Quantity = product.Quantity;
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(int id)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    var productToDelete = context.Product.SingleOrDefault(p => p.Id == id);
                    context.Product.Remove(productToDelete);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
