Imports System.IO

Public Class FilesFolders

    Public Shared Sub CreateDirectory(ByVal newdir As String)
        If (Not System.IO.Directory.Exists(newdir)) Then
            System.IO.Directory.CreateDirectory(newdir)
        End If
    End Sub

    Public Shared Sub MoveDirectory(ByVal source As String, ByVal target As String)
        Dim sourcePath = source.TrimEnd("\"c, " "c)
        Dim targetPath = target.TrimEnd("\"c, " "c)
        Dim files = Directory.EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories).GroupBy(Function(s) Path.GetDirectoryName(s))
        For Each folder In files
            Dim targetFolder = folder.Key.Replace(sourcePath, targetPath)
            Directory.CreateDirectory(targetFolder)

            For Each file In folder
                Dim targetFile = Path.Combine(targetFolder, Path.GetFileName(file))
                If System.IO.File.Exists(targetFile) Then System.IO.File.Delete(targetFile)
                System.IO.File.Move(file, targetFile)
            Next
        Next
        Directory.Delete(source, True)
    End Sub

    Public Shared Sub HideFolder(hidedir As String)
        If System.IO.Directory.Exists(hidedir) Then
            Dim ToHideDir As New System.IO.DirectoryInfo(hidedir) With {
            .Attributes = IO.FileAttributes.Hidden
        }
        End If
    End Sub

    Public Shared Sub HideFile(hidefile As String)
        If System.IO.File.Exists(hidefile) Then
            Dim ToHideFile As New System.IO.FileInfo(hidefile) With {
                .Attributes = IO.FileAttributes.Hidden}
        End If
    End Sub

    Public Shared Function CountFiles(dir As String, ext As String) As Integer
        CountFiles = Directory.GetFiles(dir, ext).Count
    End Function


End Class
