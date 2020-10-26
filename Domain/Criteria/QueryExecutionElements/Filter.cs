using System;

namespace Criteria.QueryExecutionElements
{
    public class Filter
    {
        private String field;
        private String operatorFilter;
        private ValueFilter valueFilter;

        public String Field { get => this.field; }
        public String OperatorFilter { get => this.operatorFilter; }
        public ValueFilter ValueFilter { get => this.valueFilter; }

        public Filter(String field, String operatorFilter, ValueFilter valueFilter)
        {
            this.field = field;
            this.operatorFilter = operatorFilter;
            this.valueFilter = valueFilter;
        }

        public override String ToString() => String.Concat(this.field, this.operatorFilter, this.valueFilter.Value);
    }
}