Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module mdl_sql
    Dim cmd As New SqlCommand

    Public con As New SqlConnection("Data Source=.;Initial Catalog=Tech_config;Integrated Security=True;")
    'Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
    '

    Public Function OpenCon() As Boolean
        On Error Resume Next
        If con.State = ConnectionState.Closed Then
            con.Open()
            Return True
        End If
    End Function

    Public Function CloseCon() As Boolean
        On Error Resume Next
        If con.State = ConnectionState.Open Then
            con.Close()
            Return True
        End If
    End Function

    Function SQL_Command(sql As String) As DataTable
        con = New SqlConnection("Data Source=.;Initial Catalog=Tech_config;Integrated Security=True;")
        cmd = New SqlCommand(sql, con)
        OpenCon()
        cmd.ExecuteNonQuery()
        MsgBox("Done ")
        CloseCon()
    End Function
End Module
