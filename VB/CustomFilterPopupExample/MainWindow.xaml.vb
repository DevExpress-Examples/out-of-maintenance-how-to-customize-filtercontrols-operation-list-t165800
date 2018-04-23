Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace CustomFilterPopupExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CustomTableView_FilterEditorCreated(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.FilterEditorEventArgs)
			AddHandler e.FilterControl.BeforeShowValueEditor, AddressOf FilterControl_BeforeShowValueEditor
		End Sub

		Private Sub FilterControl_BeforeShowValueEditor(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.Filtering.ShowValueEditorEventArgs)
			Dim column = TryCast(grid.Columns.GetColumnByFieldName(e.CurrentNode.FirstOperand.PropertyName), GridColumn)

			If column.FieldType Is GetType(Integer) Then
				e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.DoesNotEqual
			ElseIf column.FieldType Is GetType(String) Then
				e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.Contains
			Else
				e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.Equals
			End If
		End Sub
	End Class
End Namespace
