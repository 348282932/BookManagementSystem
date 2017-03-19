using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Books
{
    public class BookType : Entity, ISoftDelete, IHasCreationTime
    {
        [Required]
        public virtual string Name { get; set; }

        public virtual int SotrNumber { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
