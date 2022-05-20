
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        Dim r_asc, r_des As String
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If (a >= b) And (a >= c) Then GoTo a_mayor Else GoTo boc_mayor
a_mayor:
        If b >= c Then GoTo cba Else GoTo bca
boc_mayor:
        If (b >= a) And (b >= c) Then GoTo b_mayor Else GoTo c_mayor
b_mayor:
        If a >= c Then GoTo cab Else GoTo acb
c_mayor:
        If a >= b Then GoTo bac Else GoTo abc
cba:
        r_asc = c.ToString + " , " + b.ToString + " , " + a.ToString
        r_des = a.ToString + " , " + b.ToString + " , " + c.ToString
        GoTo fin
bca:
        r_asc = b.ToString + " , " + c.ToString + " , " + a.ToString
        r_des = a.ToString + " , " + c.ToString + " , " + b.ToString
        GoTo fin
cab:
        r_asc = c.ToString + " , " + a.ToString + " , " + b.ToString
        r_des = b.ToString + " , " + a.ToString + " , " + c.ToString
        GoTo fin
acb:
        r_asc = a.ToString + " , " + c.ToString + " , " + b.ToString
        r_des = b.ToString + " , " + c.ToString + " , " + a.ToString
        GoTo fin
bac:
        r_asc = b.ToString + " , " + a.ToString + " , " + c.ToString
        r_des = c.ToString + " , " + a.ToString + " , " + b.ToString
        GoTo fin
abc:
        r_asc = a.ToString + " , " + b.ToString + " , " + c.ToString
        r_des = c.ToString + " , " + b.ToString + " , " + a.ToString
fin:
        TextBox4.Text = r_asc
        TextBox5.Text = r_des
    End Sub


End Class
