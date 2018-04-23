Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace Q445945
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            anotherColorPickEdit1.RemoveColorByName("Web", "Transparent")
        End Sub

        Private Sub simpleButton2_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
            anotherColorPickEdit1.RemoveColorsByNames("Web", New List(Of String)() From {"Black", "Red"})
        End Sub
    End Class
End Namespace
