using System;
using System.ComponentModel.DataAnnotations;

namespace Gov.Entity
{
    public partial class ArticleExtend
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
    }
}