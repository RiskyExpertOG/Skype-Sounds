Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Public Class Form1

    Public prefix As String
    Public asardir As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.Is64BitOperatingSystem Then
            prefix = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
        Else
            prefix = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        End If
        BackgroundWorker1.RunWorkerAsync()
        chkfalse()
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
            BackgroundWorker2.RunWorkerAsync()
        Catch ex As Exception
            Enabled = False
            Dim exc As String
            exc = ex.ToString.Substring(0, ex.ToString.IndexOf(" at "))
            MsgBox("You are missing some dependencies!" & vbNewLine & vbNewLine & exc & vbNewLine & "Exiting...", vbCritical)
            Close()
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If System.IO.File.Exists(prefix & "\Microsoft\Skype for Desktop\resources\app.asar") Then
            MsgBox("All dependencies are satisfied! You may now use the utility.", vbInformation)
            process_btn.BackColor = Color.Green
            classic_btn.BackColor = Color.Green
        Else
            MsgBox("No Skype for Desktop installation could be found!")
            MsgBox(prefix & "Microsoft\Skype for Desktop\resources\app.asar")
        End If
    End Sub

    Public Sub chktrue()
        call_con_ch.Enabled = True
        call_dial_ch.Enabled = True
        call_end_ch.Enabled = True
        call_recon_ch.Enabled = True
        call_ring_ch.Enabled = True
        cam_cap_ch.Enabled = True
        call_err_ch.Enabled = True
        call_end_ch.Enabled = True
        file_tcom_ch.Enabled = True
        file_tfail_ch.Enabled = True
        file_tinc_ch.Enabled = True
        login_ch.Enabled = True
        mess_ch.Enabled = True
        notif_ch.Enabled = True

        call_con_btn.Enabled = True
        call_dial_btn.Enabled = True
        call_end_btn.Enabled = True
        call_recon_btn.Enabled = True
        call_ring_btn.Enabled = True
        cam_cap_btn.Enabled = True
        call_err_btn.Enabled = True
        call_end_btn.Enabled = True
        file_tcom_btn.Enabled = True
        file_tfail_btn.Enabled = True
        file_tinc_btn.Enabled = True
        login_btn.Enabled = True
        mess_btn.Enabled = True
        notif_btn.Enabled = True

        call_con_txt.Enabled = True
        call_dial_txt.Enabled = True
        call_end_txt.Enabled = True
        call_recon_txt.Enabled = True
        call_ring_txt.Enabled = True
        cam_cap_txt.Enabled = True
        call_err_txt.Enabled = True
        call_end_txt.Enabled = True
        file_tcom_txt.Enabled = True
        file_tfail_txt.Enabled = True
        file_tinc_txt.Enabled = True
        login_txt.Enabled = True
        mess_txt.Enabled = True
        notif_txt.Enabled = True

        call_con_sel.Enabled = True
        call_dial_sel.Enabled = True
        call_end_sel.Enabled = True
        call_recon_sel.Enabled = True
        call_ring_sel.Enabled = True
        cam_cap_sel.Enabled = True
        call_err_sel.Enabled = True
        call_end_sel.Enabled = True
        file_tcom_sel.Enabled = True
        file_tfail_sel.Enabled = True
        file_tinc_sel.Enabled = True
        login_sel.Enabled = True
        mess_sel.Enabled = True
        notif_sel.Enabled = True

        process_btn.Enabled = True
    End Sub

    Public Sub chkfalse()
        call_con_ch.Enabled = False
        call_dial_ch.Enabled = False
        call_end_ch.Enabled = False
        call_recon_ch.Enabled = False
        call_ring_ch.Enabled = False
        cam_cap_ch.Enabled = False
        call_err_ch.Enabled = False
        call_end_ch.Enabled = False
        file_tcom_ch.Enabled = False
        file_tfail_ch.Enabled = False
        file_tinc_ch.Enabled = False
        login_ch.Enabled = False
        mess_ch.Enabled = False
        notif_ch.Enabled = False

        call_con_btn.Enabled = False
        call_dial_btn.Enabled = False
        call_end_btn.Enabled = False
        call_recon_btn.Enabled = False
        call_ring_btn.Enabled = False
        cam_cap_btn.Enabled = False
        call_err_btn.Enabled = False
        call_end_btn.Enabled = False
        file_tcom_btn.Enabled = False
        file_tfail_btn.Enabled = False
        file_tinc_btn.Enabled = False
        login_btn.Enabled = False
        mess_btn.Enabled = False
        notif_btn.Enabled = False

        call_con_txt.Enabled = False
        call_dial_txt.Enabled = False
        call_end_txt.Enabled = False
        call_recon_txt.Enabled = False
        call_ring_txt.Enabled = False
        cam_cap_txt.Enabled = False
        call_err_txt.Enabled = False
        call_end_txt.Enabled = False
        file_tcom_txt.Enabled = False
        file_tfail_txt.Enabled = False
        file_tinc_txt.Enabled = False
        login_txt.Enabled = False
        mess_txt.Enabled = False
        notif_txt.Enabled = False

        call_con_sel.Enabled = False
        call_dial_sel.Enabled = False
        call_end_sel.Enabled = False
        call_recon_sel.Enabled = False
        call_ring_sel.Enabled = False
        cam_cap_sel.Enabled = False
        call_err_sel.Enabled = False
        call_end_sel.Enabled = False
        file_tcom_sel.Enabled = False
        file_tfail_sel.Enabled = False
        file_tinc_sel.Enabled = False
        login_sel.Enabled = False
        mess_sel.Enabled = False
        notif_sel.Enabled = False

        process_btn.Enabled = False
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles custom_ch.CheckedChanged
        If custom_ch.Checked = True Then
            chktrue()
        Else
            chkfalse()
        End If
    End Sub

    Private Sub classic_btn_Click(sender As Object, e As EventArgs) Handles classic_btn.Click
        BackgroundWorker3.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        asardir = Chr(34) & prefix & "\Microsoft\Skype for Desktop\resources"
        pipe("npx asar extract " & asardir & "\app.asar" & Chr(34) & " " & asardir & "\app" & Chr(34))
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        BackgroundWorker4.RunWorkerAsync()
        ProgressBar1.Value = 20
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        pipe("Remove-Item " & asardir & "\app\media" & Chr(34) & " -Recurse -Force -Confirm:$false")
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        BackgroundWorker5.RunWorkerAsync()
        ProgressBar1.Value = ProgressBar1.Value + 20
    End Sub

    Private Sub BackgroundWorker5_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        pipe("Copy-Item -Path " & Chr(34) & "media" & Chr(34) & " -Destination " & asardir & "\app" & Chr(34) & "-Recurse -Force -Confirm:$false")
    End Sub

    Private Sub BackgroundWorker5_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker5.RunWorkerCompleted
        BackgroundWorker6.RunWorkerAsync()
        ProgressBar1.Value = ProgressBar1.Value + 20
    End Sub

    Private Sub BackgroundWorker6_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        pipe("Rename-Item -Path " & asardir & "\app.asar" & Chr(34) & " -NewName " & Chr(34) & "appbak.asar" & Chr(34))
    End Sub

    Private Sub BackgroundWorker6_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker6.RunWorkerCompleted
        BackgroundWorker7.RunWorkerAsync()
        ProgressBar1.Value = ProgressBar1.Value + 20
    End Sub

    Private Sub BackgroundWorker7_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        pipe("npx asar pack " & asardir & "\app" & Chr(34) & " " & asardir & "\app.asar" & Chr(34))
    End Sub

    Private Sub BackgroundWorker7_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker7.RunWorkerCompleted
        ProgressBar1.Value = ProgressBar1.Value + 20
        MsgBox("Done. (Exported old configuration as appbak.asar)", vbInformation)
    End Sub
End Class
