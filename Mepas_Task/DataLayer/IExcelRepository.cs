using Mepas_Task.Models;

namespace Mepas_Task.DataLayer
{
    public interface IExcelRepository
    {

       
        public List<Products> GetProducts();
        public List<Categories> GetCategories();
        
    }
}
