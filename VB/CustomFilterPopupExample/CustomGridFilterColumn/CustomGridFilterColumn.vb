Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFilterPopupExample
	Friend Class CustomGridFilterColumn
		Inherits GridFilterColumn
		Public Sub New(ByVal column As ColumnBase, ByVal useDomainDataSourceRestrictions As Boolean, ByVal useWcfSource As Boolean)
			MyBase.New(column, useDomainDataSourceRestrictions, useWcfSource)
		End Sub

		Public Overrides Function IsValidClause(ByVal clause As DevExpress.Data.Filtering.Helpers.ClauseType) As Boolean
			If Me.ColumnType Is GetType(Integer) Then
                If clause = ClauseType.Equals OrElse clause = ClauseType.Greater OrElse clause = ClauseType.GreaterOrEqual OrElse clause = ClauseType.Less OrElse clause = ClauseType.LessOrEqual OrElse clause = ClauseType.DoesNotEqual Then
                    Return True
                Else
                    Return False
                End If
			ElseIf Me.ColumnType Is GetType(String) Then
                If clause = ClauseType.Equals OrElse clause = ClauseType.BeginsWith OrElse clause = ClauseType.EndsWith OrElse clause = ClauseType.Contains OrElse clause = ClauseType.DoesNotEqual Then
                    Return True
                Else
                    Return False
                End If
			Else
				Return True
			End If
		End Function
	End Class
End Namespace
