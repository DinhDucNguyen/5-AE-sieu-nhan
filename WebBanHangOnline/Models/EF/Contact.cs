using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ten khong duoc de trong")]
        [StringLength(150,ErrorMessage ="Khong duoc vuot qua 150 ki tu")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "Khong duoc vuot qua 150 ki tu")]
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public bool isRead { get; set; }
    }
}