Imports System.IO

Namespace UnitTest


    Public Class FileSystemUsingInterface
        Implements IFileSystem

        Public Function ReadAllText(ByVal fileName As String) As String Implements IFileSystem.ReadAllText
            Return File.ReadAllText(fileName)
        End Function

    End Class

End Namespace
