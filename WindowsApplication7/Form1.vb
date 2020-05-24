Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenImageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Try

            PictureBox1.Image = Image.FromFile((CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString))
        Catch ex As Exception
            MsgBox("Error Doing Drag/Drop")
        End Try
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Try

            PictureBox1.Image = Image.FromFile((CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString))
        Catch ex As Exception
            MsgBox("Error Doing Drag/Drop")
        End Try
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        With e
            Me.AllowDrop = True
            If (.Data.GetDataPresent(DataFormats.FileDrop)) Then
                .Effect = DragDropEffects.Copy
            End If
        End With
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        With e
            Me.AllowDrop = True
            If (.Data.GetDataPresent(DataFormats.FileDrop)) Then
                .Effect = DragDropEffects.Copy
            End If
        End With
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Str As String = "Name : Photo viewer" & vbNewLine & "version : 1.0.0" & vbNewLine & "developped by : Kassem Hachi" & vbNewLine & "Email : kassem.hachi@outlook.com" & vbNewLine & "project url : https://github.com/KassemHachi/photoviewer"
        MsgBox(Str, MsgBoxStyle.Information, "About")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        OpenFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Form2.Show()

    End Sub
End Class
