Imports System.Text

Namespace UnitTest

    Public Class UnitTestExample

        'Static Method
        Public Shared Function Capitalize(ByVal value As String) As String

            'Adding Pre-Condition (Added to instruct PEX NullReferenceException is a expected exception if NULL value is passed to this method)
            If value Is Nothing Then
                Throw New ArgumentNullException("value")
            End If

            Dim sb = New StringBuilder()
            Dim word As Boolean = False
            'word
            For Each c As Char In value
                If Char.IsLetter(c) Then
                    If Not word Then
                        sb.Append(Char.ToUpper(c))
                        word = True
                    Else
                        sb.Append(c)
                    End If
                Else

                    If Char.IsPunctuation(c) Then
                        sb.Append("_"c)
                    End If
                    word = False
                End If
            Next
            Return sb.ToString()

        End Function

        'Shared Function
        Public Shared Function GetFileContent(ByVal fileName As String) As String
            Dim content As String
            Dim fs As New FileSystem()
            'Instance function used for showing usage of Moles type Mocking
            content = fs.ReadAllText(fileName)
            Return content
        End Function

        Dim Ifs As IFileSystem
        'Class Constructor with Dependency Injection
        Public Sub New(ByVal fs As IFileSystem)
            Me.Ifs = fs
        End Sub

        'Instance Function used for showing usage of Stub type Mocking
        Public Function GetFileContentUsingInterface(ByVal fileName As String) As String
            Dim content As String
            content = Me.Ifs.ReadAllText(fileName)
            Return content
        End Function

        'Example of Data Driven Test Method
        Public Shared Function Add(ByVal int1 As Integer, ByVal int2 As Integer) As Integer
            Return int1 + int2
        End Function

    End Class

End Namespace