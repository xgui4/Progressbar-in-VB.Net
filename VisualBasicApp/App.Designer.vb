<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
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
        PB = New ProgressBar()
        MainLabel = New Label()
        SuspendLayout()
        ' 
        ' PB
        ' 
        PB.BackColor = SystemColors.Control
        PB.Location = New Point(12, 133)
        PB.Name = "PB"
        PB.Size = New Size(776, 185)
        PB.TabIndex = 0
        PB.Value = 5
        ' 
        ' MainLabel
        ' 
        MainLabel.AutoSize = True
        MainLabel.Font = New Font("Segoe UI", 30.0F)
        MainLabel.ForeColor = SystemColors.ControlLightLight
        MainLabel.Location = New Point(120, 53)
        MainLabel.Name = "MainLabel"
        MainLabel.Size = New Size(515, 67)
        MainLabel.TabIndex = 1
        MainLabel.Text = "Progressbar in VB.NET"
        ' 
        ' App
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(800, 450)
        Controls.Add(MainLabel)
        Controls.Add(PB)
        MaximizeBox = False
        Name = "App"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Progressbar Visual Basic"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PB As ProgressBar
    Friend WithEvents MainLabel As Label

End Class
