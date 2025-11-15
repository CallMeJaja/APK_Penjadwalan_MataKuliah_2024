Imports APK_Penjadwalan_MataKuliah_2024_New.Core

Namespace Models
    Public Class Dosen
        Public Property NIDN As String
        Public Property Nama As String
        Public Property JenisKelamin As JenisKelamin
        Public Property Email As String
        Public Property NoTelepon As String
        Public Property Alamat As String
        Public Property KodeProdi As String
        Public Property NamaProdi As String
        Public Property Status As StatusDosen
        Public Property PhotoPath As String

        Public Sub New()
            Status = StatusDosen.Aktif
        End Sub
    End Class
End Namespace
