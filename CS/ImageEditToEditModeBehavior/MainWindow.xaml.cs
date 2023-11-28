using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Core;
using System.Windows.Media;

namespace ImageEditToEditModeBehavior {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class MainViewModel : ViewModelBase {
        public ImageSource Source { get { return GetValue<ImageSource>(); } set { SetValue(value); } }
        protected IDialogService DialogService { get { return GetService<IDialogService>(); } }

        [Command]
        public void Edit() {
            var imageEditViewModel = new EditImageWindowViewModel() { Source = this.Source };
            MessageResult result;
            result = DialogService.ShowDialog(
                dialogButtons: MessageButton.OKCancel,
                title: "Edit Image",
                viewModel: imageEditViewModel
            );
            if (result == MessageResult.OK)
                Source = imageEditViewModel.Source;
        }
    }
}
