Imports System.Drawing.Text

Public Class Form1
    Private currentTextBox As TextBox
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Form2 As New Form2()

        Form2.Label20.Text = txtGrade1.Text
        Form2.Label21.Text = txtGrade2.Text
        Form2.Label22.Text = txtGrade3.Text
        Form2.Label23.Text = txtGrade4.Text
        Form2.Label24.Text = txtGrade5.Text
        Form2.Label25.Text = txtGrade6.Text
        Form2.Label26.Text = txtGrade7.Text
        Form2.Label27.Text = txtGrade8.Text
        Form2.Label28.Text = txtGrade9.Text
        Form2.Label29.Text = txtGrade10.Text
        Form2.Label30.Text = txtGrade11.Text
        Form2.Label42.Text = txtName.Text
        Form2.Label43.Text = ComboBox1.Text

        Dim subjectgrade1 As Integer = Convert.ToInt32(Form2.Label20.Text)
        Dim subjectgrade2 As Integer = Convert.ToInt32(Form2.Label21.Text)
        Dim subjectgrade3 As Integer = Convert.ToInt32(Form2.Label22.Text)
        Dim subjectgrade4 As Integer = Convert.ToInt32(Form2.Label23.Text)
        Dim subjectgrade5 As Integer = Convert.ToInt32(Form2.Label24.Text)
        Dim subjectgrade6 As Integer = Convert.ToInt32(Form2.Label25.Text)
        Dim subjectgrade7 As Integer = Convert.ToInt32(Form2.Label26.Text)
        Dim subjectgrade8 As Integer = Convert.ToInt32(Form2.Label27.Text)
        Dim subjectgrade9 As Integer = Convert.ToInt32(Form2.Label28.Text)
        Dim subjectgrade10 As Integer = Convert.ToInt32(Form2.Label29.Text)
        Dim subjectgrade11 As Integer = Convert.ToInt32(Form2.Label30.Text)

        Dim remarksubject1 As String = GetRemarkForGrade(subjectgrade1)
        Dim remarksubject2 As String = GetRemarkForGrade(subjectgrade2)
        Dim remarksubject3 As String = GetRemarkForGrade(subjectgrade3)
        Dim remarksubject4 As String = GetRemarkForGrade(subjectgrade4)
        Dim remarksubject5 As String = GetRemarkForGrade(subjectgrade5)
        Dim remarksubject6 As String = GetRemarkForGrade(subjectgrade6)
        Dim remarksubject7 As String = GetRemarkForGrade(subjectgrade7)
        Dim remarksubject8 As String = GetRemarkForGrade(subjectgrade8)
        Dim remarksubject9 As String = GetRemarkForGrade(subjectgrade9)
        Dim remarksubject10 As String = GetRemarkForGrade(subjectgrade10)
        Dim remarksubject11 As String = GetRemarkForGrade(subjectgrade11)

        Form2.Label31.Text = remarksubject1
        Form2.Label32.Text = remarksubject2
        Form2.Label33.Text = remarksubject3
        Form2.Label34.Text = remarksubject4
        Form2.Label35.Text = remarksubject5
        Form2.Label36.Text = remarksubject6
        Form2.Label37.Text = remarksubject7
        Form2.Label38.Text = remarksubject8
        Form2.Label39.Text = remarksubject9
        Form2.Label40.Text = remarksubject10
        Form2.Label41.Text = remarksubject11

        Dim grade1 As Integer
        Dim grade2 As Integer
        Dim grade3 As Integer
        Dim grade4 As Integer
        Dim grade5 As Integer
        Dim grade6 As Integer
        Dim grade7 As Integer
        Dim grade8 As Integer
        Dim grade9 As Integer
        Dim grade10 As Integer
        Dim grade11 As Integer

        If Not Integer.TryParse(txtGrade1.Text, grade1) Then
        End If
        If Not Integer.TryParse(txtGrade2.Text, grade2) Then
        End If
        If Not Integer.TryParse(txtGrade3.Text, grade3) Then
        End If
        If Not Integer.TryParse(txtGrade4.Text, grade4) Then
        End If
        If Not Integer.TryParse(txtGrade5.Text, grade5) Then
        End If
        If Not Integer.TryParse(txtGrade6.Text, grade6) Then
        End If
        If Not Integer.TryParse(txtGrade7.Text, grade7) Then
        End If
        If Not Integer.TryParse(txtGrade8.Text, grade8) Then
        End If
        If Not Integer.TryParse(txtGrade9.Text, grade9) Then
        End If
        If Not Integer.TryParse(txtGrade10.Text, grade10) Then
        End If
        If Not Integer.TryParse(txtGrade11.Text, grade11) Then
        End If

        Dim sumGrade As Double = grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8 + grade9 + grade10 + grade11
        Dim averageGrade As Double = sumGrade / 11
        Form2.lblAverage.Text = averageGrade

        Dim feedback As String
        If averageGrade >= 90 Then
            feedback = "Excellent"
        ElseIf averageGrade >= 80 AndAlso averageGrade < 90 Then
            feedback = "Good"
        ElseIf averageGrade >= 70 AndAlso averageGrade < 80 Then
            feedback = "Average"
        Else
            feedback = "Below Average"
        End If

        Form2.lblRemarks.Text = feedback


        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim button As Button = DirectCast(sender, Button)

        If currentTextBox IsNot Nothing Then
            currentTextBox.Text &= button.Text
        End If
    End Sub

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles txtGrade1.Click, txtGrade2.Click, txtGrade3.Click, txtGrade4.Click, txtGrade5.Click, txtGrade6.Click, txtGrade7.Click, txtGrade8.Click, txtGrade9.Click, txtGrade10.Click, txtGrade11.Click
        currentTextBox = DirectCast(sender, TextBox)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtID.Text = ""
        txtGrade1.Text = ""
        txtGrade2.Text = ""
        txtGrade3.Text = ""
        txtGrade4.Text = ""
        txtGrade5.Text = ""
        txtGrade6.Text = ""
        txtGrade7.Text = ""
        txtGrade8.Text = ""
        txtGrade9.Text = ""
        txtGrade10.Text = ""
        txtGrade11.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Function GetRemarkForGrade(ByVal grade As Integer) As String
        Dim remark As String

        If grade >= 90 Then
            remark = "Excellent"
        ElseIf grade >= 80 AndAlso grade < 90 Then
            remark = "Good"
        ElseIf grade >= 70 AndAlso grade < 80 Then
            remark = "Average"
        Else
            remark = "Below Average"
        End If

        Return remark
    End Function

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
