using System.Drawing;

namespace Mepas_Task.Models
{
    public class Products : BaseClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Category_Id { get; set; }
        public Double Price { get; set; }
        public string? Unit { get; set; }
        public int Stock { get; set; }
        public string? Color { get; set; }
        public Double Weight { get; set; }
        public Double Height { get; set; }
        public Double Width { get; set; }
        public int Added_User_Id { get; set; }
        public int Update_User_Id { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }


    }
}
