Imports DevExpress.Xpf.Core.FilteringUI
Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace CustomFilterPopupExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnQueryOperators(ByVal sender As Object, ByVal e As FilterEditorQueryOperatorsEventArgs)
		    If e.FieldName = "Name" Then
			e.Operators.Clear()
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.Equal))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.NotEqual))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.Contains))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.StartsWith))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.EndsWith))
			e.DefaultOperator = e.Operators(FilterEditorOperatorType.Contains)
		    ElseIf e.FieldName = "SubscribeNumber" Then
			e.Operators.Clear()
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.Equal))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.NotEqual))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.Greater))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.GreaterOrEqual))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.Less))
			e.Operators.Add(New FilterEditorOperatorItem(FilterEditorOperatorType.LessOrEqual))
			e.DefaultOperator = e.Operators(FilterEditorOperatorType.LessOrEqual)
		    End If
		End Sub
	End Class
End Namespace
