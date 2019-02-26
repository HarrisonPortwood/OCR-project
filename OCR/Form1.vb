Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure

Public Class Form1

    Dim OCRz As Tesseract = New Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_TESSERACT_ONLY)
    Dim pic As Bitmap = New Bitmap(270, 100)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 8, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing

    End Sub

    Private Sub BtnOCR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOCR.Click

        OCRz.Recognize(New Image(Of Bgr, Byte)(pic))
        RichTextBox1.Text = OCRz.GetText

    End Sub
End Class
