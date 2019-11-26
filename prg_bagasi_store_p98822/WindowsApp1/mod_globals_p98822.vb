Module mod_globals_p98822
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BAGASI_STORE_P98822.accdb;Persist Security Info=False;"
    Public shoppingCart As ArrayList = New ArrayList()
    Public loggedUserName As String = ""
    Public loggedFullName As String = ""
    Public isLogIn As Boolean = False
    Public isCustomer As Boolean = False
    Public loggedId As Integer = 0

End Module
