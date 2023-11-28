using DevExpress.Mvvm;
using System.Windows.Controls;
using System.Windows.Media;

namespace ImageEditToEditModeBehavior {
    public partial class EditImageWindow : UserControl {
        public EditImageWindow() {
            InitializeComponent();
        }

        private void editBehavior_CustomEditMenuItems(object sender, DevExpress.Xpf.Editors.CustomEditMenuItemsEventArgs e) {
            e.EditMenuItems.Clear();
        }
    }
    public class EditImageWindowViewModel : ViewModelBase {
        public ImageSource Source { get { return GetValue<ImageSource>(); } set { SetValue(value); } }
    }
}
