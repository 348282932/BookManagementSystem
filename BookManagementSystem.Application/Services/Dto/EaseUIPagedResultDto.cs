using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Services.Dto
{
    public class EaseUIPagedResultDto<T> : ListResultDto<T>, IPagedResult<T>, IListResult<T>, IHasTotalCount
    {
        public EaseUIPagedResultDto();

        public EaseUIPagedResultDto(int totalCount, IReadOnlyList<T> items)
        {
            total = totalCount;
            rows = items;
        }

        public int total { get; set; }

        public IReadOnlyList<T> rows { get; set; }
    }
}
