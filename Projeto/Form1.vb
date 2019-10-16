Public Class Form1
    Dim Quadros() As PictureBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16}
    End Sub

    Private Sub Clicar(sender As Object, e As EventArgs) Handles P4.Click, P1.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P3.Click, P2.Click, P16.Click, P15.Click, P14.Click, P13.Click, P12.Click, P11.Click, P10.Click
        Dim Aux = Quadros(Int(Rnd() * 16))
        Aux.BackgroundImage = My.Resources._1
        P5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        P5.BackgroundImage = My.Resources._1
    End Sub
End Class
