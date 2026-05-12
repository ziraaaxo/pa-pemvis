' =========================================================
' CONNECTION MODULE
' File : ConnectionModule.vb
' =========================================================

Imports MySql.Data.MySqlClient

Module ConnectionModule

    Public Conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public DT As DataTable

    Public Sub OpenConnection()

        Dim connectionString As String =
            "server=localhost;
             userid=root;
             password=;
             database=db_pet_hotel"

        Conn = New MySqlConnection(connectionString)

        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

    End Sub

    Public Sub CloseConnection()

        If Conn IsNot Nothing Then

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If

        End If

    End Sub

End Module