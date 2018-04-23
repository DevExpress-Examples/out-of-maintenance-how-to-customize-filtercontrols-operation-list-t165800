using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterPopupExample
{
    class CustomTableView : TableView
    {
        protected override GridFilterColumn CreateFilterColumn(ColumnBase column, bool useDomainDataSourceRestrictions, bool useWcfSource)
        {
            return new CustomGridFilterColumn(column, useDomainDataSourceRestrictions, useWcfSource);
        }
    }
}
