Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Dim Dirpath As String
    Dim listfiles As New List(Of String)

    Dim totalfile As Integer = 0

    Private Delegate Sub _setfilelabel(text As String, lb As Label)
    Private Sub setfilelabel(text As String, lb As Label)
        If lb.InvokeRequired Then
            lb.Invoke(New _setfilelabel(AddressOf setfilelabel), text, lb)
        Else
            lb.Text = text
        End If
    End Sub

    Private Delegate Sub _setLbpercen1(value As String, lb As Label)
    Private Sub Setlbpercen1(value As String, lb As Label)
        If lb.InvokeRequired Then
            lb.Invoke(New _setLbpercen1(AddressOf Setlbpercen1), value, lb)
        Else
            lb.Text = value
        End If
    End Sub

    Private Delegate Sub _setLbpercen2(value As String, lb As Label)
    Private Sub Setlbpercen2(value As String, lb As Label)
        If lb.InvokeRequired Then
            lb.Invoke(New _setLbpercen1(AddressOf Setlbpercen2), value, lb)
        Else
            lb.Text = value
        End If
    End Sub

    Private Delegate Sub _setLbpercen3(value As String, lb As Label)
    Private Sub Setlbpercen3(value As String, lb As Label)
        If lb.InvokeRequired Then
            lb.Invoke(New _setLbpercen1(AddressOf Setlbpercen3), value, lb)
        Else
            lb.Text = value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folder As New FolderBrowserDialog
        If (folder.ShowDialog) = DialogResult.OK Then
            TextBox1.Text = folder.SelectedPath
            Dirpath = folder.SelectedPath
        End If


    End Sub

    Private Sub ReadDir(path As String)

        Dim folderinfo As New DirectoryInfo(path)
        For Each file In folderinfo.GetFiles
            listfiles.Add(file.FullName)
            totalfile += 1
        Next
        For Each subfolderinfo In folderinfo.GetDirectories
            ReadDir(subfolderinfo.FullName)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ReadDir(TextBox1.Text.Trim)
        bg1.RunWorkerAsync()
    End Sub

    Private Sub bg1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bg1.DoWork

        Dim percen As Double = 0
        Dim running As Integer = 0
        For Each filess In listfiles
            setfilelabel(filess, lbstafile)
            running += 1
            percen = (running / totalfile) * 100

            Setlbpercen1(percen.ToString("###.00") & " %", lbpercen1)
            Setlbpercen2(percen.ToString("###.00") & " %", lbpercen2)
            Setlbpercen3(percen.ToString("###.00") & " %", lbpercen3)

            bg1.ReportProgress(percen)
            ' Threading.Thread.Sleep(10)
        Next
    End Sub


    Private Sub bg1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bg1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Guna2ProgressBar1.Value = e.ProgressPercentage
        ProgressBarX1.Value = e.ProgressPercentage
    End Sub

    Private Sub bg1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bg1.RunWorkerCompleted
        ProgressBar1.Value = 0
        Guna2ProgressBar1.Value = 0
        ProgressBarX1.Value = 0
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bg1.WorkerReportsProgress = True

    End Sub
End Class
