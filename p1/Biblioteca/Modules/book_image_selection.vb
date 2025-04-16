Imports System.IO

Module book_image_selection

    Public Sub HandleBookImageClick(bookImagePictureBox As PictureBox, openFileDialog As OpenFileDialog)
        Try
            With openFileDialog
                .Title = "Selecione uma foto"
                .Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"
                .InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
                .FileName = ""

                If .ShowDialog() = DialogResult.OK Then
                    Dim selectedImagePath = .FileName
                    Dim fileInfo = New FileInfo(selectedImagePath)

                    ' O limite de tamanho é 500 KB
                    If fileInfo.Length > 500 * 1024 Then
                        ' Diminui a imagem se ultrapassar o limite de 500 KB
                        bookImagePictureBox.Image = ResizeImage(Image.FromFile(selectedImagePath), 800, 800)
                    Else
                        ' Carrega diretamente se for leve
                        bookImagePictureBox.Load(selectedImagePath)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar a imagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ResizeImage(image As Image, maxWidth As Integer, maxHeight As Integer) As Image
        Dim ratio = Math.Min(maxWidth / image.Width, maxHeight / image.Height)
        Dim newSize = New Size(CInt(image.Width * ratio), CInt(image.Height * ratio))

        Dim resizedImage = New Bitmap(newSize.Width, newSize.Height)
        Using g = Graphics.FromImage(resizedImage)
            With g
                .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                .DrawImage(image, 0, 0, newSize.Width, newSize.Height)
            End With
        End Using

        Return resizedImage
    End Function

End Module
