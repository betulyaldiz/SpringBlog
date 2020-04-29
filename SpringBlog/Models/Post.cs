using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SpringBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [ForeignKey("Author")]
        [Required] //post yazarsız olamaz
        public string AuthorId { get; set; } // yazar id sadece author id string

        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string PhotoPath { get; set; } //Resim yolu

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; }


        [Required]
        public DateTime? CreateTime { get; set; } //(? nullable) null kabul etmiyor

        [Required]
        public DateTime? ModificationTime { get; set; } //değişiklik zamanı

        public virtual ApplicationUser Author { get; set; }
        public virtual Category Category { get; set; } //her postun bir kategorisi olacak

    }
}