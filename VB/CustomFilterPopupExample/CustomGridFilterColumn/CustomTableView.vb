Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFilterPopupExample
	Friend Class CustomTableView
		Inherits TableView
		Protected Overrides Function CreateFilterColumn(ByVal column As ColumnBase, ByVal useDomainDataSourceRestrictions As Boolean, ByVal useWcfSource As Boolean) As GridFilterColumn
			Return New CustomGridFilterColumn(column, useDomainDataSourceRestrictions, useWcfSource)
		End Function
	End Class
End Namespace
