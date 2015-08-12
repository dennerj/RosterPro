Imports System
Imports System.IO

Module FileOps
    Function read(readfile As String, fromto As String) As String
        Using reader As StreamReader = New StreamReader(readfile)
            Dim line As String

            Select Case fromto
                Case "from"
                    line = reader.ReadLine
                    Return line
                Case "to"
                    line = reader.ReadLine
                    line = reader.ReadLine
                    Return line
            End Select

        End Using

    End Function

    Private Sub write()
        Dim objWriter As New System.IO.StreamWriter("c:\RosterProConfig.txt")

        objWriter.WriteLine("come on mplease")
        objWriter.WriteLine("come on please")
        objWriter.Close()


    End Sub


End Module
