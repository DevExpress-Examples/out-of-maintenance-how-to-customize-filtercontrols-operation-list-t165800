<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649678/14.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T165800)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomGridFilterColumn.cs](./CS/CustomFilterPopupExample/CustomGridFilterColumn/CustomGridFilterColumn.cs) (VB: [CustomGridFilterColumn.vb](./VB/CustomFilterPopupExample/CustomGridFilterColumn/CustomGridFilterColumn.vb))
* [CustomTableView.cs](./CS/CustomFilterPopupExample/CustomGridFilterColumn/CustomTableView.cs) (VB: [CustomTableView.vb](./VB/CustomFilterPopupExample/CustomGridFilterColumn/CustomTableView.vb))
* [MainWindow.xaml](./CS/CustomFilterPopupExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomFilterPopupExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomFilterPopupExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomFilterPopupExample/MainWindow.xaml.vb))
* [TaskViewModel.cs](./CS/CustomFilterPopupExample/ViewModel/TaskViewModel.cs) (VB: [TaskViewModel.vb](./VB/CustomFilterPopupExample/ViewModel/TaskViewModel.vb))
<!-- default file list end -->
# How to customize FilterControl's operation list


This example demonstrates how to customize FilterEditor's operation list and how to set a default operation value to the desired value.<br />To provide this capability in this sample, we create a GridFilterColumn class descendant and override its IsValidClause method. Then we create a TableView class descendant and override its CreateFilterColumn method to return our GridFilterColumn class descendant object instead of the default GridFilterColumn object.<br />To change a default operation value, we subscribe to the TableView's FilterEditorCreated event. In this handler we subscribe to the FilterControl's BeforeShowValueEditor event. When BeforeShowValueEditor is raised, we set the CurrentNode.Operation value to the desired value.

<br/>


