using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Books
{
    public class Chapter : Entity<long>, ISoftDelete, IHasCreationTime, IHasModificationTime
    {
        [Required]
        [MaxLength(20)]
        public virtual string Name { get; set; }

        public virtual int WordCount { get { return this.WordCount; } private set { this.WordCount = Content.Length; } }

        [Required]
        public virtual string Content { get; set; }

        public virtual long BookId { get; set; }

        public virtual Book Book { get; set; }

        public bool IsDeleted { get;set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}
