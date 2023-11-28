Imports DevExpress.Mvvm
Imports System.Windows.Controls

Namespace ImageEditToEditModeBehavior

    Public Partial Class EditImageWindow
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub editBehavior_CustomEditMenuItems(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.CustomEditMenuItemsEventArgs)
            e.EditMenuItems.Clear()
        End Sub
    End Class

    Public Class EditImageWindowViewModel
        Inherits ViewModelBase

        Public Property Source As ImageSource
            Get
                Return GetValue(Of ImageSource)()
            End Get

            Set(ByVal value As ImageSource)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
