Imports System
Imports System.IO

Public Class RosterPro
    Public fileDirFileNames As String()
    Public fileName As String
    Public fileExtension As String
    Public fileOnlineVsIlt As String = "OPI-OES-ALL-TrainingOnlineVsILT"
    Public fileActiveUsers As String = "OPI-OES-Active Users"
    Public filePastDue As String = "OPI-OES-ALL-PastDueTrainingStatus"
    Public fileRosterData As String = "OPI-ALL-UserID_Login_Location"
    Public fileSourceDir As String
    Public fileSaveToDir As String
    Public mode As String

    Private Sub RosterPro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        tbProcessFrom.Text = FileOps.read("C:\RosterProConfig.txt", "from")
        tbProcessTo.Text = FileOps.read("C:\RosterProConfig.txt", "to")

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

        Select Case behave
            Case "-hide"
                mode = "hide"
                Call validateDirectory()
                'Call read("C:\RosterProConfig.txt", "from")
                'Call read("C:\RosterProConfig.txt", "to")
                Call unZip()
                Call ProcessData()
                'Call CleanDir()
                If mode = "hide" Then End
        End Select
        Call read("C:\RosterProConfig.txt", "from")
        Call read("C:\RosterProConfig.txt", "to")
        Call unZip()
        Call ProcessData()
        'Call CleanDir()
    End Sub

    Public Sub unZip()
        Dim SevenZip As Process

        ListBox1.Items.Clear()
        SevenZip = Process.Start("C:\Program Files\7-Zip\7z.exe", "e C:\Temp\OPI*.zip -y -oC:\Temp")
        ListBox1.Items.Add("Files Unzipped")
        SevenZip.WaitForExit()
    End Sub

    Public Sub ProcessData()
        fileDirFileNames = Directory.GetFiles(fileSourceDir)
        For i As Integer = 0 To fileDirFileNames.GetUpperBound(0)
            fileName = System.IO.Path.GetFileName(fileDirFileNames(i))
            fileExtension = System.IO.Path.GetExtension(fileDirFileNames(i))

            If fileExtension = ".TXT" Then
                Select Case True
                    Case fileName.Contains(fileOnlineVsIlt)
                        ListBox1.Items.Add(fileName)
                        My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileOnlineVsIlt & ".TXT", True)

                    Case fileName.Contains(fileActiveUsers)
                        ListBox1.Items.Add(fileName)
                        My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileActiveUsers & ".TXT", True)

                    Case fileName.Contains(filePastDue)
                        ListBox1.Items.Add(fileName)
                        My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & filePastDue & ".TXT", True)

                    Case fileName.Contains(fileRosterData)
                        ListBox1.Items.Add(fileName)
                        My.Computer.FileSystem.MoveFile(fileDirFileNames(i), fileSaveToDir & fileRosterData & ".TXT", True)

                End Select
            End If
        Next

        ListBox1.Items.Add("Files moved.")
        ListBox1.Items.Add("Files renamed.")

    End Sub

    Public Sub CleanDir()

        For i As Integer = 0 To fileDirFileNames.GetUpperBound(0)
            If System.IO.Path.GetExtension(fileDirFileNames(i)) = ".TXT" Then
                System.IO.File.Delete(fileDirFileNames(i))
            End If

            If System.IO.Path.GetExtension(fileDirFileNames(i)) = ".zip" Then
                System.IO.File.Delete(fileDirFileNames(i))
            End If
        Next

        ListBox1.Items.Add("Text and Zip files deleted.")
        ListBox1.Items.Add("DONE!!.")

    End Sub

    Sub Run_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call Main("")
    End Sub

   

    Private Sub validateDirectory() Handles MyBase.Click, tbProcessFrom.Leave, tbProcessTo.Leave
        Me.Cursor = Cursors.WaitCursor
        btnRun.Enabled = False
        btnRun.BackColor = Color.Silver

        tbStatus.Text = ""
        tbStatus.Visible = True
        tbStatus.ForeColor = Color.Black
        tbStatus.Text = "Checking Process FROM Directory..."
        Me.Refresh()

        If Not My.Computer.FileSystem.DirectoryExists(tbProcessFrom.Text) Or My.Computer.FileSystem.DirectoryExists("") Then
            tbStatus.ForeColor = Color.Red
            tbStatus.Text = "Invalid process FROM path."
            tbProcessFrom.SelectAll()
            Me.Cursor = Cursors.Arrow
            tbProcessFrom.BackColor = Color.Pink
            If mode = "hide" Then MsgBox("An error in the path has halted the application from running in the background." & vbCrLf & vbCrLf & _
                "Check the path and try again.", MsgBoxStyle.Critical)
            mode = ""
            Exit Sub
        End If

        tbProcessFrom.BackColor = Color.LightGreen

        tbStatus.Text = "Checking Process TO Directory..."
        Me.Refresh()
        If Not My.Computer.FileSystem.DirectoryExists(tbProcessTo.Text) Or My.Computer.FileSystem.DirectoryExists("") Then
            tbStatus.ForeColor = Color.Red
            tbStatus.Text = "Invalid Process TO path."
            Me.Cursor = Cursors.Arrow
            tbProcessTo.SelectAll()
            tbProcessTo.BackColor = Color.Pink

            If mode = "hide" Then MsgBox("An error in the path has halted the application from running in the background." & vbCrLf & vbCrLf & _
                "Check the path and try again.", MsgBoxStyle.Critical)
            mode = ""

            Exit Sub
        Else : tbProcessTo.BackColor = Color.LightGreen
        End If

        tbStatus.ForeColor = Color.Green
        tbStatus.Text = "All paths are valid."
        Me.Cursor = Cursors.Arrow
        btnRun.Enabled = True
        btnRun.BackColor = Color.RoyalBlue

        tbProcessFrom.Text = tbProcessFrom.Text.TrimEnd(CChar("\"))
        tbProcessTo.Text = tbProcessTo.Text.TrimEnd(CChar("\"))

        If Not tbProcessFrom.Text.EndsWith("\") Then
            tbProcessFrom.Text = tbProcessFrom.Text & "\"
        End If

        If Not tbProcessTo.Text.EndsWith("\") Then
            tbProcessTo.Text = tbProcessTo.Text & "\"
        End If

        fileSourceDir = tbProcessFrom.Text
        fileSaveToDir = tbProcessTo.Text
        My.Settings.PROCESSFROM = fileSourceDir
        My.Settings.PROCESSTO = fileSaveToDir
        My.Settings.Save()

    End Sub

    Public Sub btnFromDir_Click(sender As Object, e As EventArgs) Handles btnFromDir.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessFrom.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

    Private Sub btnToDir_Click(sender As Object, e As EventArgs) Handles btnToDir.Click
        FolderBrowserDialog1.ShowDialog()
        tbProcessTo.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub
End Class
