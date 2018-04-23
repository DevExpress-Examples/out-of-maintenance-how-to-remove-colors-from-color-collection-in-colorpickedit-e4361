Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorPick.Popup.Galleries
Imports DevExpress.XtraEditors.Popup
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraBars.Ribbon
Imports System.Reflection

Namespace Q445945
	Public Class MyColorPickEdit
		Inherits ColorPickEdit
		Protected Function GetTargetGallery(ByVal _tabPageName As String) As GalleryControlGallery
			Dim targetPage As XtraTabPage = GetTabPageByName((TryCast(Me.PopupForm, PopupColorPickEditForm)).TabControl, _tabPageName)
			Dim _ctrl As PropertyInfo = targetPage.Controls(0).GetType().GetProperty("GalleryControl")
			Dim gallery As GalleryControlGallery = (TryCast(_ctrl.GetValue(targetPage.Controls(0), Nothing), SystemGalleryControl)).Gallery
			Return gallery

		End Function

		Protected Function GetTabPageByName(ByVal _tabControl As XtraTabControl, ByVal _name As String) As XtraTabPage
			Dim index As Integer = -1
			Do While index < _tabControl.TabPages.Count
				index += 1
				If _tabControl.TabPages(index).Text = _name Then
					Return _tabControl.TabPages(index)
				End If
			Loop
			Return Nothing
		End Function

		Public Sub RemoveColorByName(ByVal _tabPageName As String, ByVal _nameList As List(Of String))
			If PopupForm Is Nothing Then
				Me.GetPopupForm()
			End If

			Dim _gallery As GalleryControlGallery = GetTargetGallery(_tabPageName)
			For i As Integer = _gallery.Groups(0).Items.Count -1 To 0 Step -1
				Dim nameIndex As Integer = _nameList.IndexOf(_gallery.Groups(0).Items(i).Caption)
				If nameIndex <> -1 Then
					_gallery.Groups(0).Items.RemoveAt(i)
					_nameList.RemoveAt(nameIndex)
					If _nameList.Count = 0 Then
						Return
					End If
				End If
			Next i
		End Sub
		Public Sub RemoveColorByName(ByVal _tabPageName As String, ByVal _name As String)
			If PopupForm Is Nothing Then
				Me.GetPopupForm()
			End If

			Dim _gallery As GalleryControlGallery = GetTargetGallery(_tabPageName)
			Dim i As Integer = 0
			Do While i < _gallery.Groups(0).Items.Count
				If _gallery.Groups(0).Items(i).Caption = _name Then
					_gallery.Groups(0).Items.RemoveAt(i)
					Return
				End If
				i += 1
			Loop
		End Sub
	End Class
End Namespace
