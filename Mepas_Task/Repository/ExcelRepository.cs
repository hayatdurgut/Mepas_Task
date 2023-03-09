using ClosedXML.Excel;
using Mepas_Task.DataLayer;
using Mepas_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Spire.Xls;
using DocumentFormat.OpenXml.Spreadsheet;

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

        public void AddProduct(Products product)
        {
                /**
          *  AppContext.BaseDirectory: bin klasörünün dizin konumu
          *  "\\Files\\veritabani.xlsx": excel dosyasının bin klasöründeki konumu
         **/
                string filePath = AppContext.BaseDirectory + "Files\\Veritabani.xlsx";
                using (XLWorkbook workBook = new XLWorkbook(filePath)) //excel dosyasını açıyor. 
                {
                    //Exceldeki sayfaları okuyor.(1. sayfayı seçmiş)
                    IXLWorksheet workSheet = workBook.Worksheet(1);
                    var rowSize = GetProducts().ToList().Count;
                    workSheet.Cell(rowSize + 1, 1).Value = rowSize + 1;
                    workSheet.Cell(rowSize + 1, 2).Value = product.Name;
                    workSheet.Cell(rowSize + 1, 3).Value = product.Category_Id;
                    workSheet.Cell(rowSize + 1, 4).Value = product.Price;
                    workSheet.Cell(rowSize + 1, 5).Value = product.Unit;
                    workSheet.Cell(rowSize + 1, 6).Value = product.Stock;
                    workSheet.Cell(rowSize + 1, 7).Value = product.Color;
                    workSheet.Cell(rowSize + 1, 8).Value = product.Weight;
                    workSheet.Cell(rowSize + 1, 9).Value = product.Height;
                    workSheet.Cell(rowSize + 1, 10).Value = product.Width;
                    workSheet.Cell(rowSize + 1, 11).Value = 1;// user Id
                    workSheet.Cell(rowSize + 1, 12).Value = 1; // update user ıd
                    workSheet.Cell(rowSize + 1, 13).Value = DateTime.Now;
                    workSheet.Cell(rowSize + 1, 14).Value = DateTime.Now;
                    workBook.Save();
                }
               
           

        }

        public List<Models.Users> GetUsers()
        {
            List<Models.Users> users = new List<Models.Users>();

            /**
             *  AppContext.BaseDirectory: bin klasörünün dizin konumu
             *  "\\Files\\veritabani.xlsx": excel dosyasının bin klasöründeki konumu
            **/
            string filePath = AppContext.BaseDirectory + "Files\\Veritabani.xlsx";
            using (XLWorkbook workBook = new XLWorkbook(filePath)) //excel dosyasını açıyor. 
            {
                //Exceldeki sayfaları okuyor.(3. sayfayı seçmiş)
                IXLWorksheet workSheet = workBook.Worksheet(3);


                foreach (IXLRow row in workSheet.Rows())  //tüm satırları dönüyor.
                {
                    users.Add(new Models.Users
                    {
                        Id = row.Cell(1).GetValue<int>(),
                        Name = row.Cell(2).GetText(),
                        Surname = row.Cell(3).GetText(),
                        Username = row.Cell(4).GetText(),
                        Password = row.Cell(5).GetText(),
                        Status = row.Cell(6).GetValue<bool>(),
                    }) ;
                }
            }
            return users;
        }
    }


}

      

