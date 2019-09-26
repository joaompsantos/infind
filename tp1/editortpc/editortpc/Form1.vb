
Imports System.IO
'
' JOão Santos 76552
'
Public Class Form1

    Dim writer As StreamWriter
    Dim reader As StreamReader

    Dim file As String = vbNullString
    Dim count As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox.Visible = False
        txtbox.Margin = New Padding(30)
        saveasmnitem.Enabled = False
        savemnitem.Enabled = False
        lblstatustime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        lblstatuslog.Text = ""
        lblstatuscount.Text = ""

    End Sub

    Private Sub Openmnitem_Click(sender As Object, e As EventArgs) Handles openmnitem.Click

        Dim opendialog = New OpenFileDialog
        opendialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        opendialog.ShowDialog()
        file = opendialog.FileName

        Try
            reader = New StreamReader(file)
            txtbox.Text = reader.ReadToEnd
            reader.Close()
            txtbox.Visible = True
            lblstatuslog.Text = "File Opened"
        Catch ex As Exception
            lblstatuslog.Text = "Error while reading"
        End Try

        savemnitem.Enabled = True
        saveasmnitem.Enabled = True

        lblstatuscount.Text = "Char Count: " + CStr(txtbox.TextLength)

    End Sub

    Private Sub Savemnitem_Click(sender As Object, e As EventArgs) Handles savemnitem.Click
        Dim savedialog = New SaveFileDialog

        Try
            writer = New StreamWriter(file)
            writer.Write(txtbox.Text)
            writer.Close()
            lblstatuslog.Text = "File Saved"
            count = txtbox.TextLength()
        Catch ex As Exception
            lblstatuslog.Text = "Error while saving"
        End Try

    End Sub

    Private Sub Saveasmnitem_Click(sender As Object, e As EventArgs) Handles saveasmnitem.Click
        Dim savedialog = New SaveFileDialog
        savedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        savedialog.ShowDialog()
        file = savedialog.FileName

        Try
            writer = New StreamWriter(file)
            writer.Write(txtbox.Text)
            writer.Close()
            lblstatuslog.Text = "File Saved"
            savemnitem.Enabled = True
            count = txtbox.TextLength()
        Catch ex As Exception
            lblstatuslog.Text = "Error while saving"
        End Try



    End Sub

    Private Sub Newmnitem_Click(sender As Object, e As EventArgs) Handles newmnitem.Click
        txtbox.Visible = True

        savemnitem.Enabled = False
        saveasmnitem.Enabled = True

        lblstatuslog.Text = "New File Created"
        lblstatuscount.Text = "Char Count: 0"
    End Sub

    Private Sub txtbox_TextChanged(sender As Object, e As EventArgs) Handles txtbox.TextChanged
        lblstatuscount.Text = "Char Count: " + CStr(txtbox.TextLength)
    End Sub

    Private Sub Exitmnitem_Click(sender As Object, e As EventArgs) Handles exitmnitem.Click


        Me.Close()

        'save before exit try

        'If count = txtbox.TextLength Then
        'Me.Close()
        'Else
        'Dim result As Integer = MessageBox.Show("File Not Saved, Save before exit?", "Warning", MessageBoxButtons.YesNo)
        'Select Case result
        'Case result = DialogResult.No
        'Me.Close()
        'Case result = DialogResult.Yes
        'If file.Length <> vbNullString Then
        'saveasmnitem(sender, e)
        'Me.Close()
        'Else
        'Me.saveasmnitem.PerformClick()
        'Me.Close()
        'End If
        'End Select
        'End If

    End Sub
End Class
