
Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    Public Sub ouvrir()
        Try
            cn.ConnectionString = "data source=DESKTOP-DLEJU30\SQLEXPRESS;initial catalog=gestion_facturation; integrated security=true;"
            cn.Open()
            If cn.State = ConnectionState.Open Then
                MessageBox.Show("connection reussi")
            Else
                MessageBox.Show("connection échoue")
            End If
        Catch ex As Exception
            MessageBox.Show("ex.Message")
        End Try
    End Sub
End Module

