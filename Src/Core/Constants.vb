Namespace Core
    ''' <summary>
    ''' Application-wide constants
    ''' </summary>
    Public Class Constants
        ' Application Info
        Public Const APP_NAME As String = "Sistem Penjadwalan Mata Kuliah"
        Public Const APP_VERSION As String = "2.0.0"
        Public Const COMPANY_NAME As String = "Universitas XYZ"

        ' Database
        Public Const DB_NAME As String = "db_akademik24"
        Public Const CONNECTION_STRING_NAME As String = "AkademikDB"

        ' Date/Time Formats
        Public Const DATE_FORMAT As String = "yyyy-MM-dd"
        Public Const DATETIME_FORMAT As String = "yyyy-MM-dd HH:mm:ss"
        Public Const DISPLAY_DATE_FORMAT As String = "dd MMMM yyyy"

        ' Validation
        Public Const MIN_PASSWORD_LENGTH As Integer = 6
        Public Const MAX_LOGIN_ATTEMPTS As Integer = 3

        ' UI Colors (Hex)
        Public Const COLOR_PRIMARY As String = "#2C3E50"
        Public Const COLOR_SECONDARY As String = "#3498DB"
        Public Const COLOR_SUCCESS As String = "#27AE60"
        Public Const COLOR_WARNING As String = "#F39C12"
        Public Const COLOR_DANGER As String = "#E74C3C"
        Public Const COLOR_BACKGROUND As String = "#ECF0F1"
    End Class
End Namespace
