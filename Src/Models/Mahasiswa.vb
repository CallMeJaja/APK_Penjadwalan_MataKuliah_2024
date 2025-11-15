Imports APK_Penjadwalan_MataKuliah_2024_New.Core

Namespace Models
    ''' <summary>
    ''' Mahasiswa entity/model
    ''' </summary>
    Public Class Mahasiswa
        Public Property NIM As String
        Public Property Nama As String
        Public Property JenisKelamin As JenisKelamin
        Public Property TempatLahir As String
        Public Property TanggalLahir As Date
        Public Property Alamat As String
        Public Property KodeProdi As String
        Public Property NamaProdi As String
        Public Property Status As StatusMahasiswa
        Public Property Email As String
        Public Property NoTelepon As String
        Public Property TahunMasuk As Integer
        Public Property PhotoPath As String

        ' Computed properties
        Public ReadOnly Property NamaLengkap As String
            Get
                Return Nama
            End Get
        End Property

        Public ReadOnly Property Umur As Integer
            Get
                Dim today As Date = Date.Today
                Dim age As Integer = today.Year - TanggalLahir.Year
                If TanggalLahir.Date > today.AddYears(-age) Then age -= 1
                Return age
            End Get
        End Property

        ' Constructor
        Public Sub New()
            ' Default values
            Status = StatusMahasiswa.Aktif
            TahunMasuk = Date.Now.Year
        End Sub
    End Class
End Namespace
