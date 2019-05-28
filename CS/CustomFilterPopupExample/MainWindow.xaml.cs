using DevExpress.Xpf.Core.FilteringUI;
using DevExpress.Xpf.Grid;
using System.Windows;

namespace CustomFilterPopupExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnQueryOperators(object sender, FilterEditorQueryOperatorsEventArgs e) {
            if (e.FieldName == "Name") {
                e.Operators.Clear();
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.Equal));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.NotEqual));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.Contains));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.StartsWith));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.EndsWith));
                e.DefaultOperator = e.Operators[FilterEditorOperatorType.Contains];
            }
            else if (e.FieldName == "SubscribeNumber") {
                e.Operators.Clear();
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.Equal));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.NotEqual));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.Greater));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.GreaterOrEqual));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.Less));
                e.Operators.Add(new FilterEditorOperatorItem(FilterEditorOperatorType.LessOrEqual));
                e.DefaultOperator = e.Operators[FilterEditorOperatorType.LessOrEqual];
            }
        }
    }
}
