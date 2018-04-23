using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void CustomTableView_FilterEditorCreated(object sender, DevExpress.Xpf.Grid.FilterEditorEventArgs e)
        {
            e.FilterControl.BeforeShowValueEditor += FilterControl_BeforeShowValueEditor;
        }

        void FilterControl_BeforeShowValueEditor(object sender, DevExpress.Xpf.Editors.Filtering.ShowValueEditorEventArgs e)
        {
            var column = grid.Columns.GetColumnByFieldName(e.CurrentNode.FirstOperand.PropertyName) as GridColumn;

            if (column.FieldType == typeof(int))
            {
                e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.DoesNotEqual;
            }
            else if (column.FieldType == typeof(string))
            {
                e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.Contains;
            }
            else e.CurrentNode.Operation = DevExpress.Data.Filtering.Helpers.ClauseType.Equals;
        }
    }
}
