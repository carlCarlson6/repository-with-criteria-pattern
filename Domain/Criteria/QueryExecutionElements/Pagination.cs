using System;

namespace Criteria.QueryExecutionElements
{
    public class Pagination
    {
        private int limit;
        private int offset;

        public int Limit { get => this.limit; }
        public int Offset { get => this.offset; }

        public Pagination(int offset, int limit)
        {
            this.offset = offset;
            this.limit = limit;
        }

        public override String ToString() => String.Concat("LIMIT ", this.limit, " OFFSET ", this.offset);
        
    }
}