Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dimentions
        Dim btnnum As Integer = 40
        Dim btnopt = New Integer() {50, 40}
        Dim lblheigh As Short = 25
        Dim lblwidth As Short = 75

        'Date Time Picker
        datepicker.Location = New Point(5, 5)
        datepicker.Height = lblheigh

        'Timer
        timer1.Interval = 500
        timer1.Enabled = True

        'Result Textbox
        txtRes.Location = New Point(datepicker.Location.X, datepicker.Location.Y + lblheigh + 5)
        txtRes.Width = lblwidth
        txtRes.Height = lblheigh
        txtRes.ReadOnly = True

        'Button 1
        btn1.Text = "1"
        btn1.Width = btnnum
        btn1.Height = btnnum
        btn1.Location = New Point(txtRes.Location.X, txtRes.Location.Y + lblheigh + 5)




        'Button 2
        btn2.Text = "2"
        btn2.Width = btnnum
        btn2.Height = btnnum
        btn2.Location = New Point(btn1.Location.X + btnnum + 10, btn1.Location.Y)



        'Button 3
        btn3.Text = "3"
        btn3.Width = btnnum
        btn3.Height = btnnum
        btn3.Location = New Point(btn2.Location.X + btnnum + 10, btn2.Location.Y)


        'Button 4
        btn4.Text = "4"
        btn4.Width = btnnum
        btn4.Height = btnnum
        btn4.Location = New Point(btn1.Location.X, btn1.Location.Y + btnnum + 10)


        'Button 5
        btn5.Text = "5"
        btn5.Width = btnnum
        btn5.Height = btnnum
        btn5.Location = New Point(btn4.Location.X + btnnum + 10, btn4.Location.Y)


        'Button 6
        btn6.Text = "6"
        btn6.Width = btnnum
        btn6.Height = btnnum
        btn6.Location = New Point(btn5.Location.X + btnnum + 10, btn5.Location.Y)


        'Button 7
        btn7.Text = "7"
        btn7.Width = btnnum
        btn7.Height = btnnum
        btn7.Location = New Point(btn4.Location.X, btn4.Location.Y + btnnum + 10)


        'Button 8
        btn8.Text = "8"
        btn8.Width = btnnum
        btn8.Height = btnnum
        btn8.Location = New Point(btn7.Location.X + btnnum + 10, btn7.Location.Y)


        'Button 9
        btn9.Text = "9"
        btn9.Width = btnnum
        btn9.Height = btnnum
        btn9.Location = New Point(btn8.Location.X + btnnum + 10, btn8.Location.Y)



        'Button 0
        btn0.Text = "0"
        btn0.Width = btnnum
        btn0.Height = btnnum
        btn0.Location = New Point(btn7.Location.X, btn7.Location.Y + btnnum + 10)


        'Soma Button
        btnSoma.Text = "+"
        btnSoma.Width = btnnum
        btnSoma.Height = btnnum
        btnSoma.Location = New Point(btn3.Location.X + 50, btn3.Location.Y)
        btnSoma.Enabled = False

        'Sub Button
        btnSub.Text = "-"
        btnSub.Width = btnnum
        btnSub.Height = btnnum
        btnSub.Location = New Point(btn6.Location.X + 50, btn6.Location.Y)
        btnSub.Enabled = False

        'Times Button
        btnTimes.Text = "*"
        btnTimes.Width = btnnum
        btnTimes.Height = btnnum
        btnTimes.Location = New Point(btn9.Location.X + 50, btn9.Location.Y)
        btnTimes.Enabled = False

        'Div Button
        btnDiv.Text = "/"
        btnDiv.Width = btnnum
        btnDiv.Height = btnnum
        btnDiv.Location = New Point(btnTimes.Location.X, btnTimes.Location.Y + btnnum + 10)
        btnDiv.Enabled = False

        'Operand1 Label
        lblOper1.Text = "Operador 1"
        lblOper1.Location = New Point(btn0.Location.X, btn0.Location.Y + btnnum + 10)
        lblOper1.Height = lblheigh
        lblOper1.TextAlign = ContentAlignment.MiddleCenter

        'Operand2 Label
        lblOper2.Text = "Operador 2"
        lblOper2.Location = New Point(lblOper1.Location.X + lblwidth + 10, lblOper1.Location.Y)
        lblOper2.Height = lblheigh
        lblOper2.TextAlign = ContentAlignment.MiddleCenter

        'Operation Label
        lblOper.Text = "Operador"
        lblOper.Location = New Point(lblOper2.Location.X + lblwidth + 10, lblOper2.Location.Y)
        lblOper.Height = lblheigh
        lblOper.TextAlign = ContentAlignment.MiddleCenter

        'Operand1 Textbox
        txtOper1.Location = New Point(lblOper1.Location.X, lblOper1.Location.Y + lblheigh)
        txtOper1.Height = lblheigh
        txtOper1.Width = lblwidth
        txtOper1.ReadOnly = True

        'Operand2 Textbox
        txtOper2.Location = New Point(lblOper2.Location.X, lblOper2.Location.Y + lblheigh)
        txtOper2.Height = lblheigh
        txtOper2.Width = lblwidth
        txtOper2.ReadOnly = True

        'Operation Textbox
        txtOper.Location = New Point(lblOper.Location.X, lblOper.Location.Y + lblheigh)
        txtOper.Height = lblheigh
        txtOper.Width = lblwidth
        txtOper.ReadOnly = True

        'Clear Button
        btnClear.Text = "Clear"
        btnClear.Width = btnopt(0)
        btnClear.Height = btnopt(1)
        btnClear.Location = New Point(btnSoma.Location.X + btnnum + 10, btnSoma.Location.Y)
        btnClear.Font = New Font(btnSair.Font, FontStyle.Bold)
        btnClear.Enabled = False

        'Equal Button
        btnEq.Text = "="
        btnEq.Width = btnopt(0)
        btnEq.Height = btnopt(1)
        btnEq.Location = New Point(btnSub.Location.X + btnnum + 10, btnSub.Location.Y)
        btnEq.Font = New Font(btnEq.Font, FontStyle.Bold)
        btnEq.Enabled = False

        'Exit Button
        btnSair.Text = "Sair"
        btnSair.Width = btnopt(0)
        btnSair.Height = btnopt(1)
        btnSair.Location = New Point(btnDiv.Location.X + btnnum + 10, btnDiv.Location.Y)
        btnSair.Font = New Font(btnSair.Font, FontStyle.Bold)

        'Form1
        Me.Width = btnSair.Location.X + btnopt(0) + 20
        Me.Height = txtOper1.Location.Y + txtOper1.Height + 70

    End Sub

    ' Timer Callback
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        ToolStripStatusLabel1.Text = Format(Now, "HH:mm:ss")
    End Sub

    '------------------------------------------
    '   Numeric Button Callbacks
    '------------------------------------------

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtRes.Text = txtRes.Text + "1"
        EnAllbtn()

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtRes.Text = txtRes.Text + "2"
        EnAllbtn()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtRes.Text = txtRes.Text + "3"
        EnAllbtn()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtRes.Text = txtRes.Text + "4"
        EnAllbtn()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtRes.Text = txtRes.Text + "5"
        EnAllbtn()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtRes.Text = txtRes.Text + "6"
        EnAllbtn()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtRes.Text = txtRes.Text + "7"
        EnAllbtn()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtRes.Text = txtRes.Text + "8"
        EnAllbtn()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtRes.Text = txtRes.Text + "9"
        EnAllbtn()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtRes.Text = txtRes.Text + "0"
        EnAllbtn()
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        SetOper("+")

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        SetOper("-")

    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        SetOper("*")

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        SetOper("/")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOper1.Text = ""
        txtOper2.Text = ""
        txtOper.Text = ""
        txtRes.Text = ""

        btnSoma.Enabled = False
        btnSub.Enabled = False
        btnTimes.Enabled = False
        btnDiv.Enabled = False

    End Sub

    Private Sub btnEq_Click(sender As Object, e As EventArgs) Handles btnEq.Click
        Dim oper1, oper2, res As Double
        Dim aux As Integer = InStr(txtRes.Text, "+") + InStr(txtRes.Text, "-") + InStr(txtRes.Text, "*") + InStr(txtRes.Text, "/")

        Try
            oper1 = CDbl(Mid(txtRes.Text, 1, aux - 1))
            oper2 = CDbl(Mid(txtRes.Text, aux + 1, txtRes.TextLength - 1))
        Catch ex As Exception
            MsgBox("Error! Try agian")
        End Try


        Console.WriteLine(Mid(txtRes.Text, aux, 1))
        Select Case Mid(txtRes.Text, aux, 1)
            Case "+"
                res = oper1 + oper2
                Console.WriteLine("sUM")
            Case "-"
                res = oper1 - oper2
                Console.WriteLine("Sub")
            Case "*"
                res = oper1 * oper2
                Console.WriteLine("Times")
            Case "/"
                Try
                    res = oper1 / oper2
                    Console.WriteLine("Div")
                Catch
                    MsgBox("Cant divvide by 0!")
                End Try
        End Select

        Try
            txtOper1.Text = CStr(oper1)
            txtOper2.Text = CStr(oper2)
            txtOper.Text = Mid(txtRes.Text, aux, 1)
            txtRes.Text = Mid(CStr(res), 1, 4)
        Catch
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub setOpt(ByVal oper As String)
        txtOper.Text = oper
        txtOper1.Text = Mid(txtRes.Text, 1, txtRes.TextLength - 1)
        Console.WriteLine(Mid(txtRes.Text, 1, txtRes.TextLength - 1))
        txtRes.Text = txtOper1.Text + txtOper.Text
    End Sub


    Private Sub txtRes_TextChanged(sender As Object, e As EventArgs) Handles txtRes.TextChanged
        CheckEq()
    End Sub

    Private Sub CheckEq()
        'Check if there is  Operation Available in String
        Dim aux As Short = InStr(txtRes.Text, "+") + InStr(txtRes.Text, "-") + InStr(txtRes.Text, "*") + InStr(txtRes.Text, "/")

        If aux > 0 Then
            If Mid(txtRes.Text, 1, aux - 1).Length > 0 And Mid(txtRes.Text, aux + 1, txtRes.TextLength).Length > 0 Then
                btnEq.Enabled = True
            Else
                btnEq.Enabled = False
            End If
        Else
            btnEq.Enabled = False

        End If

    End Sub

    Private Sub SetOper(ByVal op As String)
        Dim aux As Boolean = txtRes.Text(txtRes.TextLength - 1) = "+" Or txtRes.Text(txtRes.TextLength - 1) = "-" Or
            txtRes.Text(txtRes.TextLength - 1) = "*" Or txtRes.Text(txtRes.TextLength - 1) = "/"

        If aux Then
            txtRes.Text = Mid(txtRes.Text, 1, txtRes.TextLength - 1) + op
        Else
            txtRes.Text = txtRes.Text + op
        End If

    End Sub

    Private Sub EnAllbtn()
        btnSoma.Enabled = True
        btnSub.Enabled = True
        btnTimes.Enabled = True
        btnDiv.Enabled = True
        btnClear.Enabled = True

    End Sub

End Class
