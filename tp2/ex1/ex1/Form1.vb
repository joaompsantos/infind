'
' João Santos, nº 76552
'


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Some Constants
        Dim lblwidth As Short = 75
        Dim lblheight As Short = 20

        Me.Width = 4 * lblwidth + 3 * 50
        Me.Height = 4 * lblheight + 5 * 50

        ' Operador 1 Label
        lblOper1.Location = New Point(50, 50)
        lblOper1.Text = "Operador 1"
        lblOper1.Font = New Font(lblOper1.Font, FontStyle.Bold)
        lblOper1.TextAlign = ContentAlignment.MiddleCenter
        lblOper1.Width = lblwidth
        lblOper1.Height = lblheight

        ' Operador 2 Label
        lblOper2.Location = New Point(lblOper1.Location.X + lblwidth + 50, lblOper1.Location.Y)
        lblOper2.Text = "Operador 2"
        lblOper2.Font = New Font(lblOper1.Font, FontStyle.Bold)
        lblOper2.TextAlign = ContentAlignment.MiddleCenter
        lblOper2.Width = lblwidth
        lblOper2.Height = lblheight

        ' Resultado Label
        lblRes.Location = New Point(lblOper2.Location.X + lblwidth + 50, lblOper1.Location.Y)
        lblRes.Text = "Resultado"
        lblRes.Font = New Font(lblOper1.Font, FontStyle.Bold)
        lblRes.TextAlign = ContentAlignment.MiddleCenter
        lblRes.Width = lblwidth
        lblRes.Height = lblheight

        ' Operador 1 Textbox
        txtOper1.Location = New Point(lblOper1.Location.X, lblOper1.Location.Y + lblheight)
        txtOper1.Width = lblwidth
        txtOper1.Height = lblheight

        ' Operador 2 Textbox
        txtOper2.Location = New Point(lblOper2.Location.X, lblOper2.Location.Y + lblheight)
        txtOper2.Width = lblwidth
        txtOper2.Height = lblheight

        ' Resultado Textbox
        txtRes.Location = New Point(lblRes.Location.X, lblRes.Location.Y + lblheight)
        txtRes.Width = lblwidth
        txtRes.Height = lblheight

        ' Soma btn
        btnSum.Location = New Point(txtOper1.Location.X, txtOper1.Location.Y + lblheight + 50)
        btnSum.Width = lblwidth
        btnSum.Height = 2 * lblheight
        btnSum.Font = New Font(btnSum.Font.ToString, 20, FontStyle.Bold)
        btnSum.Text = "+"


        ' Sub btn
        btnSub.Location = New Point(txtOper2.Location.X, txtOper2.Location.Y + lblheight + 50)
        btnSub.Width = lblwidth
        btnSub.Height = 2 * lblheight
        btnSub.Font = New Font(btnSum.Font.ToString, 20, FontStyle.Bold)
        btnSub.Text = "-"

        ' Times btn
        btnTimes.Location = New Point(btnSum.Location.X, btnSum.Location.Y + lblheight + 50)
        btnTimes.Width = lblwidth
        btnTimes.Height = 2 * lblheight
        btnTimes.Font = New Font(btnSum.Font.ToString, 20, FontStyle.Bold)
        btnTimes.Text = "*"

        ' Div btn
        btnDiv.Location = New Point(btnSub.Location.X, btnSub.Location.Y + lblheight + 50)
        btnDiv.Width = lblwidth
        btnDiv.Height = 2 * lblheight
        btnDiv.Font = New Font(btnSum.Font.ToString, 20, FontStyle.Bold)
        btnDiv.Text = "/"

        ' Sair btn
        btnExit.Location = New Point(txtRes.Location.X, txtRes.Location.Y + lblheight + 50)
        btnExit.Width = lblwidth
        btnExit.Height = lblheight * 2 + 75
        btnExit.Font = New Font(btnSum.Font.ToString, 16, FontStyle.Bold)
        btnExit.Text = "Sair"



    End Sub

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Try
            txtRes.Text = Mid(CStr(CDbl(txtOper1.Text) + CDbl(txtOper2.Text)), 1, 5)
        Catch ex As Exception
            MsgBox("Sorry, Error While Computing")
        End Try
    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Try
            txtRes.Text = Mid(CStr(CDbl(txtOper1.Text) - CDbl(txtOper2.Text)), 1, 5)
        Catch ex As Exception
            MsgBox("Sorry, Error While Computing")
        End Try
    End Sub

    Private Sub BtnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        Try
            txtRes.Text = Mid(CStr(CDbl(txtOper1.Text) * CDbl(txtOper2.Text)), 1, 5)
        Catch ex As Exception
            MsgBox("Sorry, Error While Computing")
        End Try
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Try
            txtRes.Text = Mid(CStr(CDbl(txtOper1.Text) / CDbl(txtOper2.Text)), 1, 5)
        Catch ex As Exception
            MsgBox("Sorry, Error While Computing")
        End Try

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
