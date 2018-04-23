Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraTab

Namespace Q445945
    <UserRepositoryItem("RegisterAnotherColorPickEdit")> _
    Public Class RepositoryItemAnotherColorPickEdit
        Inherits RepositoryItemColorPickEdit

        Shared Sub New()
            RegisterAnotherColorPickEdit()
        End Sub
        Public Const CustomEditName As String = "AnotherColorPickEdit"
        Public Sub New()
        End Sub
        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property
        Public Shared Sub RegisterAnotherColorPickEdit()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(AnotherColorPickEdit), GetType(RepositoryItemAnotherColorPickEdit), GetType(ColorEditViewInfo), New ColorEditPainter(), True, img))
        End Sub
    End Class

    <ToolboxItem(True)> _
    Public Class AnotherColorPickEdit
        Inherits ColorPickEdit

        Shared Sub New()
            RepositoryItemAnotherColorPickEdit.RegisterAnotherColorPickEdit()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemAnotherColorPickEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemAnotherColorPickEdit)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemAnotherColorPickEdit.CustomEditName
            End Get
        End Property

        Public Sub RemoveColorsByNames(ByVal pageName As String, ByVal colorNames As List(Of String))
            For Each name As String In colorNames
                RemoveColorByName(pageName, name)
            Next name
        End Sub

        Public Sub RemoveColorByName(ByVal pageName As String, ByVal colorName As String)
            Dim frm As PopupColorPickEditForm = TryCast(GetPopupForm(), PopupColorPickEditForm)
            Dim tabs As XtraTabControl = frm.Controls.OfType(Of XtraTabControl)().FirstOrDefault()
            If tabs IsNot Nothing Then
                Dim page As XtraTabPage = TryCast(tabs.TabPages.Where(Function(pg) pg.Text = pageName).FirstOrDefault(), XtraTabPage)
                If page IsNot Nothing Then
                    Dim colorList As InnerColorListControl = page.Controls.OfType(Of InnerColorListControl)().FirstOrDefault()
                    If colorList IsNot Nothing Then
                        Dim item As ColorItem = colorList.Colors.OfType(Of ColorItem)().Where(Function(c) c.Color = Color.FromName(colorName)).FirstOrDefault()
                        colorList.Colors.Remove(item)
                    End If
                End If
            End If
        End Sub
    End Class
End Namespace
