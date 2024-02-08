<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        firstnum = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        secondnum = New TextBox()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' firstnum
        ' 
        firstnum.Location = New Point(97, 37)
        firstnum.Name = "firstnum"
        firstnum.Size = New Size(100, 23)
        firstnum.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 1
        Label1.Text = "firstnumber"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 15)
        Label2.TabIndex = 2
        Label2.Text = "secondnumber"
        ' 
        ' secondnum
        ' 
        secondnum.Location = New Point(105, 84)
        secondnum.Name = "secondnum"
        secondnum.Size = New Size(100, 23)
        secondnum.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(97, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "subtraction"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(28, 189)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(secondnum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(firstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents secondnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
