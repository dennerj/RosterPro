Imports System
Imports System.IO

Public Class RosterPro
    Public fileDirFileNames As String()
    Public fileName As String
    Public fileExtension As String
    Public fileSourceDir As String
    Public fileSaveToDir As String
    Public mode As String

    Private Sub RosterPro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        tbProcessFrom.Text = read("C:\RosterProConfig.txt", "from")
        tbProcessTo1.Text = read("C:\RosterProConfig.txt", "to1")
        tbProcessTo2.Text = read("C:\RosterProConfig.txt", "to2")
        tbProcessTo3.Text = read("C:\RosterProConfig.txt", "to3")

        For Each arg As String In My.Application.CommandLineArgs
            Select Case Trim(LCase(arg))
                Case "-hide"
                    Call validateDirectory()
                    Call Main("-hide")
            End Select
        Next
        Call validateDirectory()
    End Sub

    Public Sub Main(behave As String)
        fileDirFileNames = Directory.GetFiles(fileSourceDir)
        Dim fileCount As Integer = fileDirFileNames.GetUpperBound(0)
        If fileCount > 0 Then
            Select Case behave
                Case "-hide"
                    mode = "hide"
                    Call validateDirectory()
                    Call read("C:\RosterProConfig.txt", "from")
                    Call read("C:\RosterProConfig.txt", "to1")
                    Call read("C:\RosterProConfig.txt", "to2")
                    Call read("C:\RosterProConfig.txt", "to3")
                    Call unZip()
                    Call ProcessData()
                    Call CleanDir()
                    If mode = "hide" Then End
            End Select
            Call read("C:\RosterProConfig.txt", "from")
            Call read("C:\RosterProConfig.txt", "to1")
            Call read("C:\RosterProConfig.txt", "to2")
            Call read("C:\RosterProConfig.txt", "to3")
            Call unZip()
            Call ProcessData()
            Call CleanDir()
        Else ListBox1.Items.Add("No files found.")
        End If
    End Sub

    Public Sub unZip()
        Dim SevenZip As Process

        ListBox1.Items.Clear()
        SevenZip = Process.Start("C:\Program Files\7-Zip\7z.exe", "e C:\Temp\OPI*.zip -y -oC:\Temp")
        ListBox1.Items.Add("Files Unzipped")
        SevenZip.WaitForExit()
    End Sub

    ' TODO Delete this later if all works well
    'Public Sub ProcessData()
    '    fileDirFileNames = Directory.GetFiles(fileSourceDir)
    '    For i As Integer = 0 To fileDirFileNames.GetUpperBound(0)
    '        fileName = System.IO.Path.GetFileName(fileDirFileNames(i))
    '        fileExtension = System.IO.Path.GetExtension(fileDirFileNames(i))

    '        If fileExtension = ".TXT" Then
    '            Select Case True
    '                Case fileName.Contains(fileOnlineVsIlt)
    '                    ListBox1.Items.Add(fileName)
    '                    My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileOnlineVsIlt & ".TXT", True)

    '                Case fileName.Contains(fileActiveUsers)
    '                    ListBox1.Items.Add(fileName)
    '                    My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileActiveUsers & ".TXT", True)

    '                Case fileName.Contains(filePastDue)
    '                    ListBox1.Items.Add(fileName)
    '                    My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & filePastDue & ".TXT", True)

    '                Case fileName.Contains(fileRosterData)
    '                    ListBox1.Items.Add(fileName)
    '                    My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileRosterData & ".TXT", True)

    '                Case fileName.Contains(fileOPIPastDue)
    '                    ListBox1.Items.Add(fileName)
    '                    My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileOPIPastDue & ".TXT", True)

    '            End Select
    '        End If
    '    Next

    '    ListBox1.Items.Add("Files moved.")
    '    ListBox1.Items.Add("Files renamed.")

    'End Sub

    Public Sub ProcessData()
        Dim fileCount As Integer = fileDirFileNames.GetUpperBound(0)
        fileDirFileNames = Directory.GetFiles(fileSourceDir)
        For i As Integer = 0 To fileCount
            fileName = Path.GetFileName(fileDirFileNames(i))
            fileExtension = Path.GetExtension(fileDirFileNames(i))
            If fileExtension = ".TXT" Or fileExtension = ".CSV" Then
                Dim trimIndex As Integer = Len(fileName) - 26
                Dim fileNameNew As String = fileName.Remove(trimIndex, 26) & fileExtension
                My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileNameNew, True)
                ListBox1.Items.Add(fileNameNew & " moved")
            End If
        Next

    End Sub

    Public Sub CleanDir()
        Dim fileCount As Integer = fileDirFileNames.GetUpperBound(0)
        For i As Integer = 0 To fileCount
            If Path.GetExtension(fileDirFileNames(i)) = ".TXT" Then
                File.Delete(fileDirFileNames(i))
            End If

            If Path.GetExtension(fileDirFileNames(i)) = ".zip" Then
                File.Delete(fileDirFileNames(i))
            End If
        Next
        ListBox1.Items.Add("Text and Zip files deleted.")
        ListBox1.Items.Add("DONE!!.")
    End Sub

    Sub Run_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call Main("")
    End Sub

    Private Sub validateDirectory() Handles MyBase.Click, tbProcessFrom.Leave, tbProcessTo1.Leave
        Me.Cursor = Cursors.WaitCursor
        btnRun.Enabled = False
        btnRun.BackColor = Color.Silver

        With tbStatus
            .Text = ""
            .Visible = True
            .ForeColor = Color.Black
            .Text = "Checking Process FROM Directory..."
        End With

        Me.Refresh()

        If Not My.Computer.FileSystem.DirectoryExists(tbProcessFrom.Text) Or My.Computer.FileSystem.DirectoryExists("") Then
            tbStatus.ForeColor = Color.Red
            tbStatus.Text = "Invalid process FROM path."
            tbProcessFrom.SelectAll()
            Me.Cursor = Cursors.Arrow
            tbProcessFrom.BackColor = Color.Pink
            If mode = "hide" Then MsgBox("An error in the path has halted the application from running in the background." & vbCrLf & vbCrLf &
                "Check the path and try again.", MsgBoxStyle.Critical)
            mode = ""
            Exit Sub
        End If

        tbProcessFrom.BackColor = Color.LightGreen

        tbStatus.Text = "Checking Process TO Directory..."
        Me.Refresh()
        If Not My.Computer.FileSystem.DirectoryExists(tbProcessTo1.Text) Or My.Computer.FileSystem.DirectoryExists("") Then
            tbStatus.ForeColor = Color.Red
            tbStatus.Text = "Invalid Process TO path."
            Me.Cursor = Cursors.Arrow
            tbProcessTo1.SelectAll()
            tbProcessTo1.BackColor = Color.Pink

            If mode = "hide" Then MsgBox("An error in the path has halted the application from running in the background." & vbCrLf & vbCrLf &
                "Check the path and try again.", MsgBoxStyle.Critical)
            mode = ""

            Exit Sub
        Else : tbProcessTo1.BackColor = Color.LightGreen
        End If

        tbStatus.ForeColor = Color.Green
        tbStatus.Text = "All paths are valid."
        Me.Cursor = Cursors.Arrow
        btnRun.Enabled = True
        btnRun.BackColor = Color.RoyalBlue

        tbProcessFrom.Text = tbProcessFrom.Text.TrimEnd(CChar("\"))
        tbProcessTo1.Text = tbProcessTo1.Text.TrimEnd(CChar("\"))

        If Not tbProcessFrom.Text.EndsWith("\") Then
            tbProcessFrom.Text = tbProcessFrom.Text & "\"
        End If

        If Not tbProcessTo1.Text.EndsWith("\") Then
            tbProcessTo1.Text = tbProcessTo1.Text & "\"
        End If

        fileSourceDir = tbProcessFrom.Text
        fileSaveToDir = tbProcessTo1.Text
        My.Settings.PROCESSFROM = fileSourceDir
        My.Settings.PROCESSTO = fileSaveToDir
        My.Settings.Save()

    End Sub

    Public Sub btnFromDir_Click(sender As Object, e As EventArgs) Handles btnFromDir.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessFrom.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

    Private Sub btnToDir1_Click(sender As Object, e As EventArgs) Handles btnToDir1.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessTo1.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

    Private Sub btnToDir2_Click(sender As Object, e As EventArgs) Handles btnToDir2.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessTo2.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

    Private Sub btnToDir3_Click(sender As Object, e As EventArgs) Handles btnToDir3.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessTo3.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

End Class
