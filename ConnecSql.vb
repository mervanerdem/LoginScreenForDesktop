Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient

Namespace Mybudget
    Friend Class ConnecSql
        Public Function Connec() As SqlConnection
            Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-NEIDSN5\SQLEXPRESS;Initial Catalog=MyBudget;Integrated Security=True")
            conn.Open()
            Return conn
        End Function
    End Class
End Namespace
