
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Entity.Models
{
    public class Article
    {//makale sınıfı
        [Key]
        public int ArticleID { get; set; }
        [Required(ErrorMessage ="Title is required")]
        [MaxLength(500)]
        [StringLength(500,ErrorMessage = "Title should be 3-500 character", MinimumLength =3)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Desciription is required")]
        [MaxLength(2000)]
        [StringLength(2000, ErrorMessage = "Description should be 3-2000 character", MinimumLength = 3)]
        public string Description { get; set; }
        [Column(TypeName ="text")]
        public string Content { get; set; }
        public string Picture { get; set; }
        public string YouTubeLink { get; set; }
        public string Tags { get; set; }
        public DateTime InsertDate { get; set; }
        
        public string AuthorID { get; set; }
        public int TotalRate { get; set; }
        public Article()
        {
            InsertDate = DateTime.Now;
        }
    }
}
