Public Class Penyewa
    Private myId As Integer
    Private myNama As String
    Private myAlamat As String
    Private myTelpon As String
    Private myTgl_mulai As Date
    Private myTgl_selesai As Date
    Private myCode As Integer

    Public Sub New(ByVal id As Integer, ByVal nama As String,
                    ByVal alamat As String, ByVal telpon As String, ByVal tgl_mulai As Date, ByVal tgl_selesai As Date, ByVal code As Integer)
        Me.myId = id
        Me.myNama = nama
        Me.myAlamat = alamat
        Me.myTelpon = telpon
        Me.myTgl_mulai = tgl_mulai
        Me.myTgl_selesai = tgl_selesai
        Me.myCode = code

    End Sub


    Public Property id As Integer
        Get
            Return myId
        End Get
        Set(ByVal value As Integer)
            myId = value
        End Set
    End Property

    Public Property nama As String
        Get
            Return myNama
        End Get
        Set(ByVal value As String)
            myNama = value
        End Set
    End Property

    Public Property alamat As String
        Get
            Return myAlamat
        End Get
        Set(ByVal value As String)
            myAlamat = value
        End Set
    End Property

    Public Property telpon As String
        Get
            Return myTelpon
        End Get
        Set(ByVal value As String)
            myTelpon = value
        End Set
    End Property

    Public Property tgl_mulai As Date
        Get
            Return myTgl_mulai
        End Get
        Set(ByVal value As Date)
            myTgl_mulai = value
        End Set
    End Property

    Public Property tgl_selesai As Date
        Get
            Return myTgl_selesai
        End Get
        Set(ByVal value As Date)
            myTgl_selesai = value
        End Set
    End Property

    Public Property code As Integer
        Get
            Return myCode
        End Get
        Set(ByVal value As Integer)
            myCode = value
        End Set
    End Property

End Class
