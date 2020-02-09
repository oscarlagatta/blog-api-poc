using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlogNews.API.Entities
{
    public class BlogEntries
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

        [MaxLength(1500)]
        public string EntryText { get; set; }
    }
}
