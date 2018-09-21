Public Class ContactForm
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim contactFile As System.IO.StreamWriter
        contactFile = My.Computer.FileSystem.OpenTextFileWriter("H:\ContactMgrFiles\" + TelnoBox.Text + ".txt", False)
        contactFile.WriteLine(NameLbl.Text + ": " + NameBox.Text + vbCrLf)
        contactFile.WriteLine(TelnoLabel.Text + ": " + TelnoBox.Text + vbCrLf)
        contactFile.WriteLine(Addr1Label.Text + ": " + Addr1Box.Text + vbCrLf)
        contactFile.WriteLine(Addr2Label.Text + ": " + Addr2Box.Text + vbCrLf)
        contactFile.WriteLine(CityLbl.Text + ": " + CityBox.Text + vbCrLf)
        contactFile.WriteLine(StateLbl.Text + ": " + StateBox.Text + vbCrLf)
        contactFile.WriteLine(ZipLbl.Text + ": " + ZipBox.Text + vbCrLf)
        contactFile.Close()
    End Sub

    Private Sub RetrieveBtn_Click(sender As Object, e As EventArgs) Handles RetrieveBtn.Click
        Dim contactReader As String
        contactReader = My.Computer.FileSystem.ReadAllText("H:\ContactMgrFiles\" + TelnoBox.Text + ".txt")
        MsgBox(contactReader)
    End Sub
End Class
