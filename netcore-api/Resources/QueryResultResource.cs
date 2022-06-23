using System.Collections.Generic;

namespace netcore_api.Resources
{
    public class QueryResultResource<T>
    {
        public int TotalItems { get; set; } = 0;
        public List<T> Items { get; set; } = new List<T>();
    }
}