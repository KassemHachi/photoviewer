Public Class Form2

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If CheckEdit1.Checked = False Then

        Else
            If RadioButton1.Checked = True Then
                NumericUpDown1.Enabled = False
                NumericUpDown2.Enabled = False
            End If

            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Form1.PictureBox1.Dock = DockStyle.None
        End If


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If RadioButton3.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Form1.PictureBox1.Size = New Size(NumericUpDown1.Value, NumericUpDown2.Value)
            Form1.PictureBox1.Dock = DockStyle.None
        ElseIf RadioButton2.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Form1.PictureBox1.Dock = DockStyle.Fill
        ElseIf RadioButton1.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Form1.PictureBox1.Dock = DockStyle.None

        End If

        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize Then
            RadioButton1.Checked = True
        ElseIf Form1.PictureBox1.Dock = DockStyle.Fill Then
            RadioButton2.Checked = True
        Else
            RadioButton3.Checked = True
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = True
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If RadioButton3.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Form1.PictureBox1.Size = New Size(NumericUpDown1.Value, NumericUpDown2.Value)
            Form1.PictureBox1.Dock = DockStyle.None
        ElseIf RadioButton2.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Form1.PictureBox1.Dock = DockStyle.Fill
        ElseIf RadioButton1.Checked = True Then
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Form1.PictureBox1.Dock = DockStyle.None

        End If
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged

    End Sub
End Class