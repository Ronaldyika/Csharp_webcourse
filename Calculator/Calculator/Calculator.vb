Public Class Calculator

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnone.Click
        txtdisplay.Text += btnone.Text

    End Sub


    Private Sub txtdisplay_TextChanged(sender As Object, e As EventArgs) Handles txtdisplay.TextChanged
        txtdisplay.Focus()
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntwo_Click(sender As Object, e As EventArgs) Handles btntwo.Click
        txtdisplay.Text += btntwo.Text
    End Sub

    Private Sub btnseven_Click(sender As Object, e As EventArgs) Handles btnseven.Click

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtdisplay.Clear()

    End Sub

    Private Sub clearall_Click(sender As Object, e As EventArgs) Handles clearall.Click
        txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1)


    End Sub



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click


    End Sub

End Class
