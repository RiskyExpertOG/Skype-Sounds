Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Public Class Form1

    Public prefix As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.Is64BitOperatingSystem Then
            prefix = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        Else
            prefix = Environment.SpecialFolder.ProgramFiles
        End If
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    'Pipeline - PowerShell
    Private Function pipe(ByVal script As String) As String
        Dim runspace As Runspace = RunspaceFactory.CreateRunspace()
        runspace.Open()
        Dim pipeline As Pipeline = runspace.CreatePipeline()
        pipeline.Commands.AddScript(script)
        pipeline.Commands.Add("Out-String")
        Dim results As Collection(Of PSObject) = pipeline.Invoke()
        runspace.Close()
        Dim stringBuilder As StringBuilder = New StringBuilder()
        For Each ps As PSObject In results
            stringBuilder.AppendLine(ps.ToString())
        Next
        Return stringBuilder.ToString
    End Function

    'Checks if npm is installed and works on PowerShell
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            pipe("npx")
            duplicate.BackColor = Color.Green
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception
            Enabled = False
            MsgBox("You do not have node.js installed. Please install it!" & vbNewLine & "Exiting...")
            Close()
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If System.IO.File.Exists(prefix & "\Microsoft\Skype for Desktop\resources\app.asar") Then
            MsgBox("asar located!")
        Else
            MsgBox("No Skype for Desktop installation could be found!")
            MsgBox(prefix & "Microsoft\Skype for Desktop\resources\app.asar")
        End If
    End Sub
End Class
