using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Books
{
    /// <summary>
    /// 作者
    /// </summary>
    public class Author : Entity, ISoftDelete, IHasCreationTime
    {
        public virtual string Name { get; set; }

        public virtual SexEnum Sex { get; set; }

        public virtual string ImgUrl { get; set; }

        public ICollection<Book> Books { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
