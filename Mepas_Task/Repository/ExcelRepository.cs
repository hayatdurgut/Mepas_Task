using ClosedXML.Excel;
using Mepas_Task.DataLayer;
using Mepas_Task.Models;

namespace Mepas_Task.Repository
{
    public class ExcelRepository : IExcelRepository
    {

        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();

            /**
             *  AppContext.BaseDirectory: bin klasörünün dizin konumu
             *  "\\Files\\veritabani.xlsx": excel dosyasının bin klasöründeki konumu
            **/
            string filePath = AppContext.BaseDirectory + "Files\\Veritabani.xlsx";
            using (XLWorkbook workBook = new XLWorkbook(filePath)) //excel dosyasını açıyor. 
            {
                //Exceldeki sayfaları okuyor.(1. sayfayı seçmiş)
                IXLWorksheet workSheet = workBook.Worksheet(1);


                foreach (IXLRow row in workSheet.Rows())  //tüm satırları dönüyor.
                {
                    products.Add(new Products
                    {
                        Id = row.Cell(1).GetValue<int>(),
                        Name = row.Cell(2).GetText(),
                        Category_Id = row.Cell(3).GetValue<int>(),
                        Price = row.Cell(4).GetValue<Double>(),
                        Unit = row.Cell(5).GetText(),
                        Stock = row.Cell(6).GetValue<int>(),
                        Color = row.Cell(7).GetText(),
                        Weight = row.Cell(8).GetValue<int>(),
                        Height = row.Cell(9).GetValue<int>(),
                        Width = row.Cell(10).GetValue<int>(),
                        Added_User_Id = row.Cell(11).GetValue<int>(),
                        Update_User_Id = row.Cell(12).GetValue<int>(),
                        Created_Date = row.Cell(13).GetValue<DateTime>(),
                        Updated_Date = row.Cell(14).GetValue<DateTime>(),


                    });
                }
            }
            return products;
        }

        public List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();

            /**
             *  AppContext.BaseDirectory: bin klasörünün dizin konumu
             *  "\\Files\\veritabani.xlsx": excel dosyasının bin klasöründeki konumu
            **/
            string filePath = AppContext.BaseDirectory + "Files\\Veritabani.xlsx"; 
            using (XLWorkbook workBook = new XLWorkbook(filePath)) //excel dosyasını açıyor. 
            {
                //Exceldeki sayfaları okuyor.(2. sayfayı seçmiş)
                IXLWorksheet workSheet = workBook.Worksheet(2); 


                foreach (IXLRow row in workSheet.Rows())  //tüm satırları dönüyor.
                {
                    categories.Add(new Categories
                    {
                        Id = row.Cell(1).GetValue<int>(),
                        Name = row.Cell(2).GetText(),
                    });
                }
            }
            return categories;
        }

        
    }
};

