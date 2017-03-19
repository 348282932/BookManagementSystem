using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Books
{
    public class Book : Entity<long>, ISoftDelete, IHasCreationTime
    {
        [Description("书籍名称")]
        [Required]
        public virtual string Name { get; set; }

        [Description("封面图片")]
        public virtual string CoverImgUrl { get; set; }
        
        [Description("状态")]
        [Required]
        public virtual BookStatusEnum BookStatus { get; set; }

        [Description("封面图片")]
        [Required]
        [MaxLength(500)]
        public virtual string Introduction { get; set; }

        [Description("字数")]
        public virtual string WordCount { get; set; }

        [Description("关键字")]
        public virtual string[] KeyWords { get; set; }

        [Description("最新章节名称")]
        [Required]
        public virtual string LatestChapters {get;set;}

        public virtual int AuthorId { get; set; }

        [Description("作者")]
        public virtual Author Author { get; set; }

        public virtual int BookTypeId { get; set; }

        [Description("书籍类型")]
        public virtual BookType BookType { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

        [Description("删除标记")]
        public bool IsDeleted { get; set; }

        [Description("创建时间")]
        public DateTime CreationTime { get; set; }

        [Description("总点击次数")]
        public long ClickNumber { get; set; }

        [Description("收藏数")]
        public int CollectionNumber { get; set; }
    }
}
