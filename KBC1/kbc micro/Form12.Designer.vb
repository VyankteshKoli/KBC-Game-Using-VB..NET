<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(668, 359)
        Label1.Name = "Label1"
        Label1.Size = New Size(652, 106)
        Label1.TabIndex = 0
        Label1.Text = "Wrong Answer !"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Font = New Font("Tahoma", 19.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(809, 513)
        Button1.Name = "Button1"
        Button1.Size = New Size(346, 134)
        Button1.TabIndex = 1
        Button1.Text = "Get Your Winning Amount"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.kbc_background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1055)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Form12"
        Text = "Form12"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
