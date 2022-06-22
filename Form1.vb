Imports System.Data.SqlClient
Imports MyBudgetSystem.Mybudget

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TxtUsername.EditValueChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.[Exit]()
    End Sub

    Dim conn As ConnecSql = New ConnecSql()

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim KullaniciAdi As String = TxtUsername.Text
        Dim Sifre As String = TxtPassword.Text

        Dim comm As New SqlCommand("Select Username,Password From Account Where Username = @p1 and Password =@p2 ", conn.Connec())
        comm.Parameters.AddWithValue("@p1", TxtUsername.Text)
        comm.Parameters.AddWithValue("@p2", TxtPassword.Text)
        Dim dr As SqlDataReader = comm.ExecuteReader()

        If dr.Read() Then
            Me.Hide()
            Dim ac As FrmMain = New FrmMain()
            ac.ShowDialog()
        Else
            MessageBox.Show("You entered incorrectly", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
