Namespace Q445945
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.anotherColorPickEdit1 = New Q445945.AnotherColorPickEdit()
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.anotherColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(245, 9)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(119, 23)
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Remove transparent"
            ' 
            ' anotherColorPickEdit1
            ' 
            Me.anotherColorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.anotherColorPickEdit1.Location = New System.Drawing.Point(12, 12)
            Me.anotherColorPickEdit1.Name = "anotherColorPickEdit1"
            Me.anotherColorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.anotherColorPickEdit1.Size = New System.Drawing.Size(171, 20)
            Me.anotherColorPickEdit1.TabIndex = 5
            ' 
            ' simpleButton2
            ' 
            Me.simpleButton2.Location = New System.Drawing.Point(245, 38)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(119, 23)
            Me.simpleButton2.TabIndex = 7
            Me.simpleButton2.Text = "Remove Black and Red"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(376, 162)
            Me.Controls.Add(Me.simpleButton2)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.anotherColorPickEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.anotherColorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private anotherColorPickEdit1 As AnotherColorPickEdit
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

