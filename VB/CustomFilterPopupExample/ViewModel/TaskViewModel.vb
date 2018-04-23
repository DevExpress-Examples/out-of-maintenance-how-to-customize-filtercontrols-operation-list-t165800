Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFilterPopupExample
	Friend Class TaskViewModel
		Private _List As ObservableCollection(Of Task)

		Public ReadOnly Property List() As ObservableCollection(Of Task)
			Get
				If _List Is Nothing Then
					_List = New ObservableCollection(Of Task)()
					For i As Integer = 0 To 99
						_List.Add(New Task() With {.Name = "Task" & i, .Date = New DateTime(2014, 10, New Random().Next(1, 31)), .SubscribeNumber = i * i})
					Next i
				End If
				Return _List
			End Get
		End Property

		Public Class Task
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
			Private privateDate As DateTime
            Public Property [Date]() As DateTime
                Get
                    Return privateDate
                End Get
                Set(ByVal value As DateTime)
                    privateDate = value
                End Set
            End Property
			Private privateSubscribeNumber As Integer
			Public Property SubscribeNumber() As Integer
				Get
					Return privateSubscribeNumber
				End Get
				Set(ByVal value As Integer)
					privateSubscribeNumber = value
				End Set
			End Property
		End Class
	End Class
End Namespace
