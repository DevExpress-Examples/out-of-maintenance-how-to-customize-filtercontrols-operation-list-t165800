# How to customize FilterControl's operation list


This example demonstrates how to customize FilterEditor's operation list and how to set a default operation value to the desired value.<br />To provide this capability in this sample, we create a GridFilterColumn class descendant and override its IsValidClause method. Then we create a TableView class descendant and override its CreateFilterColumn method to return our GridFilterColumn class descendant object instead of the default GridFilterColumn object.<br />To change a default operation value, we subscribe to the TableView's FilterEditorCreated event. In this handler we subscribe to the FilterControl's BeforeShowValueEditor event. When BeforeShowValueEditor is raised, we set the CurrentNode.Operation value to the desired value.

<br/>


