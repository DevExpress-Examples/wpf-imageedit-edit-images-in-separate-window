Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Core
Imports System.Windows.Media

Namespace ImageEditToEditModeBehavior

    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MainViewModel
        Inherits DevExpress.Mvvm.ViewModelBase

        Public Property Source As ImageSource
            Get
                Return GetValue(Of ImageSource)()
            End Get

            Set(ByVal value As ImageSource)
                SetValue(value)
            End Set
        End Property

        Protected ReadOnly Property DialogService As IDialogService
            Get
                Return GetService(Of DevExpress.Mvvm.IDialogService)()
            End Get
        End Property

        <Command>
        Public Sub Edit()
            Dim imageEditViewModel = New ImageEditToEditModeBehavior.EditImageWindowViewModel() With {.Source = Me.Source}
            Dim result As DevExpress.Mvvm.MessageResult
            result = Me.DialogService.ShowDialog(dialogButtons:=DevExpress.Mvvm.MessageButton.OKCancel, title:="Edit Image", viewModel:=imageEditViewModel)
            If result Is DevExpress.Mvvm.MessageResult.OK Then Me.Source = imageEditViewModel.Source
        End Sub
    End Class
End Namespace
