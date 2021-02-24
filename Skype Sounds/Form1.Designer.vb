<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.duplicate = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'duplicate
        '
        Me.duplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.duplicate.Location = New System.Drawing.Point(12, 12)
        Me.duplicate.Name = "duplicate"
        Me.duplicate.Size = New System.Drawing.Size(95, 43)
        Me.duplicate.TabIndex = 0
        Me.duplicate.Text = "Duplicate local resource file"
        Me.duplicate.UseVisualStyleBackColor = True
        '
        'BackgroundWorker2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 680)
        Me.Controls.Add(Me.duplicate)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Skype Sound Changer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents duplicate As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
