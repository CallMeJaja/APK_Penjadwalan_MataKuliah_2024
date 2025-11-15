Namespace Core
    ''' <summary>
    ''' Application enumerations
    ''' </summary>

    Public Enum UserLevel
        Guest = 0
        Mahasiswa = 1
        Dosen = 2
        Admin = 3
        SuperAdmin = 4
    End Enum

    Public Enum StatusMahasiswa
        Aktif = 1
        Cuti = 2
        NonAktif = 3
        Lulus = 4
        DropOut = 5
    End Enum

    Public Enum JenisKelamin
        LakiLaki = 1
        Perempuan = 2
    End Enum

    Public Enum HariKuliah
        Senin = 1
        Selasa = 2
        Rabu = 3
        Kamis = 4
        Jumat = 5
        Sabtu = 6
    End Enum

    Public Enum StatusJadwal
        Draft = 0
        Active = 1
        Archived = 2
    End Enum

End Namespace
