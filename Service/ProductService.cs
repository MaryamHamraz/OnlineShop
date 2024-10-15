
using Model.DataServices;
using Model.DomainModels;

namespace Services
{
    public class ProductService
    {
        private readonly ProductDataService _productdataService;

        #region [- Ctor -]
        public ProductService()
        {
            _productdataService = new ProductDataService();
        }
        #endregion

        #region [- FillGrid() -]

        public List<Product> FillGrid() => _productdataService.SelectAll();

        #endregion

        #region [- Save() -]
        public void Save(Product product) => _productdataService.Insert(product);
        #endregion

        #region [- Edit() -]
        public void Edit(int id, Product product) => _productdataService.Update(id, product);
        #endregion

        #region [- Delete() -]
        public void Delete(int id) => _productdataService.Delete(id);
        #endregion
    }
}
