Imports System.IO

Namespace UnitTest

    Public Class FileSystem

        Public Function ReadAllText(ByVal fileName As String) As String
            Return File.ReadAllText(fileName)
        End Function


    End Class

End Namespace