using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Mepas_Task.Models
{
    public class BaseClass
    {

        [DisplayName("Aktif Kullanıcı Id"), Required(ErrorMessage = "Aktif Kullanıcı Bulunamadı. !"),]
        public int CurrentUserId { get; set; }
    }
}
