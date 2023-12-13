Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class StudentEntry
    Private userEmail As String = ""
    Private cn As MySqlConnection ' Declare MySqlConnection
    Private cm As MySqlCommand ' Declare MySqlCommand
    Dim connectionString As String = "server=localhost; user id=root; password=; database=dbstudentmng"
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SendConfirmationEmail(email As String)
        Try
            Using Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage

                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("abaigarmagatcuriaslaurebacon2@gmail.com", "vxvy xesh dczi sxxw")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"
                Smtp_Server.DeliveryMethod = SmtpDeliveryMethod.Network ' Set delivery method to Network

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("abaigarmagatcuriaslaurebacon2@gmail.com")
                e_mail.To.Add(email) ' Use the email entered during registration
                e_mail.Subject = "Registration Confirmation"
                e_mail.Body = "Thank you for registering! This is a confirmation email."

                Smtp_Server.Send(e_mail)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim today As String = DateTime.Now.ToShortDateString
        userEmail = txtemail.Text

        If txtlname.Text.Equals("") OrElse txtfname.Text.Equals("") OrElse txtaddress.Text.Equals("") OrElse txtstudid.Text.Equals("") OrElse cbgender.Text.Equals("") OrElse cbyear.Text.Equals("") OrElse cbprogram.Text.Equals("") OrElse txtemail.Text.Equals("") OrElse cbsec.Text.Equals("") Then
            MessageBox.Show("Please fill up all fields", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf dtbirth.Text.Equals(today) Then
            MessageBox.Show("Birthday must not be today", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Try
                cn = New MySqlConnection("Server=localhost;User=root;Database=dbstudentmng;Port=3306;") ' Replace with your MySQL connection string
                cn.Open()

                cm = New MySqlCommand("insert into tbleinfo (studentID, lastname, firstname, middlename, birthday, gender, year, section, program, email, address, num, password) values (@studentid, @lname, @nname, @mname, @bday, @gender, @year, @section, @program, @email, @address, @num, @password)", cn)
                With cm.Parameters
                    .AddWithValue("@studentID", txtstudid.Text)
                    .AddWithValue("@lname", txtlname.Text)
                    .AddWithValue("@nname", txtfname.Text)
                    .AddWithValue("@mname", txtmname.Text)
                    .AddWithValue("@bday", dtbirth.Text.ToString)
                    .AddWithValue("@gender", cbgender.Text)
                    .AddWithValue("@year", cbyear.Text)
                    .AddWithValue("@section", cbsec.Text)
                    .AddWithValue("@program", cbprogram.Text)
                    .AddWithValue("@email", txtemail.Text)
                    .AddWithValue("@address", txtaddress.Text)
                    .AddWithValue("@num", txtmn.Text)
                    .AddWithValue("@password", txtpw.Text)
                End With

                SendConfirmationEmail(userEmail)
                cm.ExecuteNonQuery()
                MessageBox.Show("Student Information successfully saved! You can now Login to your Account", "Student Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try

            Form1.Show()
            Me.Hide()
        End If
    End Sub
    Private sql As String ' Assuming sql is a global variable
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Clear textboxes and comboboxes in GroupBox2
        For Each control As Control In GroupBox2.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Text = String.Empty
            ElseIf TypeOf control Is ComboBox Then
                CType(control, ComboBox).SelectedIndex = -1
                ' or you can use: CType(control, ComboBox).Text = String.Empty
            End If
        Next

        ' Execute the SQL query
        sql = "SELECT * FROM acady"

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub
End Class