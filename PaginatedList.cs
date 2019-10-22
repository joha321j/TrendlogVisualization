using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrendlogVisualization
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList(List<T> items, int pageIndex)
        {
            PageIndex = pageIndex;
            TotalPages = 2;

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex)
        {
            var count = await source.CountAsync();

            int pageSize;
            int previouslyTakenAmount;

            if (pageIndex == 1)
            {
                pageSize = (int) Math.Ceiling(((double)count /2));
                previouslyTakenAmount = 0;
            }
            else
            {
                pageSize = (int)Math.Floor(((double)count / 2));
                previouslyTakenAmount = pageSize + count%2;
            }

            
            var items = await source.Skip(previouslyTakenAmount).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, pageIndex);
        }
    }
}