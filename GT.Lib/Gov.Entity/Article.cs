using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 内容
    /// </summary>
    public partial class Article : EntityBase
    {
        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(100)]
        public string Title { get; set; }
        /// <summary>
        /// 概要
        /// </summary>
        [MaxLength(500)]
        public string Summary { get; set; }
        /// <summary>
        /// 作者名称
        /// </summary>
        [MaxLength(100)]
        public string AuthorName { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        [MaxLength(100)]
        public string Tags { get; set; }

        /// <summary>
        /// 文章扩展内容
        /// </summary>
        public ArticleExtend Extend { get; set; }
        public ArticleCatalog Catalog { get; set; }

    }
}
