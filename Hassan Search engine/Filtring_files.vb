Imports System.IO

Public Class Filtring_files
    Dim sw As IO.StreamReader
    Dim text_name As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            System.IO.Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath + "\" + TextBox1.Text)
            For Each f As String In IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.xml")
                sw = New IO.StreamReader(f)
                text_name = f.Substring(FolderBrowserDialog1.SelectedPath.ToString.Length + 1)
                If sw.ReadLine.Contains(TextBox1.Text) Then
                    sw.Close()
                    My.Computer.FileSystem.MoveFile(f, FolderBrowserDialog1.SelectedPath + "\" + TextBox1.Text + "\" + text_name, True)
                End If
            Next
        End If
        MsgBox("Done")

    End Sub


End Class
