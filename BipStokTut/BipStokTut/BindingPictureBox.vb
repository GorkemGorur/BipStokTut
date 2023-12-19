Public Class BindingPictureBox
    Inherits PictureBox

    Private _imagePath As String
    Public Property ImagePath() As String
        Get
            Return _imagePath
        End Get
        Set(ByVal value As String)
            _imagePath = value
            Try
                Me.Image = New Bitmap(_imagePath)
            Catch ex As Exception
                Me.Image = Nothing
            End Try
        End Set
    End Property

End Class

