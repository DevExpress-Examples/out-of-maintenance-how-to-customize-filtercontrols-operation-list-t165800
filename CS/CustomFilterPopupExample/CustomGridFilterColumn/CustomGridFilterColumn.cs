using DevExpress.Data.Filtering.Helpers;
using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterPopupExample
{
    class CustomGridFilterColumn : GridFilterColumn
    {
        public CustomGridFilterColumn(ColumnBase column, bool useDomainDataSourceRestrictions, bool useWcfSource)
            : base(column, useDomainDataSourceRestrictions, useWcfSource) { }

        public override bool IsValidClause(DevExpress.Data.Filtering.Helpers.ClauseType clause)
        {
            if (this.ColumnType == typeof(int))
            {
                if (clause == ClauseType.Equals || clause == ClauseType.Greater || clause == ClauseType.GreaterOrEqual || clause == ClauseType.Less || clause == ClauseType.LessOrEqual || clause == ClauseType.DoesNotEqual)
                {
                    return true;
                }
                else return false;
            }
            else if (this.ColumnType == typeof(string))
            {
                if (clause == ClauseType.Equals || clause == ClauseType.BeginsWith || clause == ClauseType.EndsWith || clause == ClauseType.Contains || clause == ClauseType.DoesNotEqual)
                {
                    return true;
                }
                else return false;
            }
            else return true;
        }
    }
}
