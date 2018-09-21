<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.TelnoLabel = New System.Windows.Forms.Label()
        Me.Addr1Label = New System.Windows.Forms.Label()
        Me.Addr2Label = New System.Windows.Forms.Label()
        Me.CityLbl = New System.Windows.Forms.Label()
        Me.StateLbl = New System.Windows.Forms.Label()
        Me.ZipLbl = New System.Windows.Forms.Label()
        Me.TelnoBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Addr1Box = New System.Windows.Forms.TextBox()
        Me.Addr2Box = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.StateBox = New System.Windows.Forms.TextBox()
        Me.ZipBox = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.RetrieveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Location = New System.Drawing.Point(13, 13)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(35, 13)
        Me.NameLbl.TabIndex = 0
        Me.NameLbl.Text = "Name"
        '
        'TelnoLabel
        '
        Me.TelnoLabel.AutoSize = True
        Me.TelnoLabel.Location = New System.Drawing.Point(13, 57)
        Me.TelnoLabel.Name = "TelnoLabel"
        Me.TelnoLabel.Size = New System.Drawing.Size(98, 13)
        Me.TelnoLabel.TabIndex = 1
        Me.TelnoLabel.Text = "Telephone Number"
        '
        'Addr1Label
        '
        Me.Addr1Label.AutoSize = True
        Me.Addr1Label.Location = New System.Drawing.Point(13, 87)
        Me.Addr1Label.Name = "Addr1Label"
        Me.Addr1Label.Size = New System.Drawing.Size(60, 13)
        Me.Addr1Label.TabIndex = 2
        Me.Addr1Label.Text = "Address (1)"
        '
        'Addr2Label
        '
        Me.Addr2Label.AutoSize = True
        Me.Addr2Label.Location = New System.Drawing.Point(13, 133)
        Me.Addr2Label.Name = "Addr2Label"
        Me.Addr2Label.Size = New System.Drawing.Size(60, 13)
        Me.Addr2Label.TabIndex = 3
        Me.Addr2Label.Text = "Address (2)"
        '
        'CityLbl
        '
        Me.CityLbl.AutoSize = True
        Me.CityLbl.Location = New System.Drawing.Point(13, 163)
        Me.CityLbl.Name = "CityLbl"
        Me.CityLbl.Size = New System.Drawing.Size(24, 13)
        Me.CityLbl.TabIndex = 4
        Me.CityLbl.Text = "City"
        '
        'StateLbl
        '
        Me.StateLbl.AutoSize = True
        Me.StateLbl.Location = New System.Drawing.Point(13, 201)
        Me.StateLbl.Name = "StateLbl"
        Me.StateLbl.Size = New System.Drawing.Size(32, 13)
        Me.StateLbl.TabIndex = 5
        Me.StateLbl.Text = "State"
        '
        'ZipLbl
        '
        Me.ZipLbl.AutoSize = True
        Me.ZipLbl.Location = New System.Drawing.Point(13, 236)
        Me.ZipLbl.Name = "ZipLbl"
        Me.ZipLbl.Size = New System.Drawing.Size(52, 13)
        Me.ZipLbl.TabIndex = 6
        Me.ZipLbl.Text = "ZIP Code"
        '
        'TelnoBox
        '
        Me.TelnoBox.Location = New System.Drawing.Point(117, 50)
        Me.TelnoBox.Name = "TelnoBox"
        Me.TelnoBox.Size = New System.Drawing.Size(100, 20)
        Me.TelnoBox.TabIndex = 8
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(117, 13)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 7
        '
        'Addr1Box
        '
        Me.Addr1Box.Location = New System.Drawing.Point(117, 87)
        Me.Addr1Box.Name = "Addr1Box"
        Me.Addr1Box.Size = New System.Drawing.Size(100, 20)
        Me.Addr1Box.TabIndex = 9
        '
        'Addr2Box
        '
        Me.Addr2Box.Location = New System.Drawing.Point(117, 126)
        Me.Addr2Box.Name = "Addr2Box"
        Me.Addr2Box.Size = New System.Drawing.Size(100, 20)
        Me.Addr2Box.TabIndex = 10
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(117, 163)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 11
        '
        'StateBox
        '
        Me.StateBox.Location = New System.Drawing.Point(117, 198)
        Me.StateBox.Name = "StateBox"
        Me.StateBox.Size = New System.Drawing.Size(100, 20)
        Me.StateBox.TabIndex = 12
        '
        'ZipBox
        '
        Me.ZipBox.Location = New System.Drawing.Point(117, 233)
        Me.ZipBox.Name = "ZipBox"
        Me.ZipBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipBox.TabIndex = 13
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Location = New System.Drawing.Point(36, 276)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 14
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'RetrieveBtn
        '
        Me.RetrieveBtn.Location = New System.Drawing.Point(118, 275)
        Me.RetrieveBtn.Name = "RetrieveBtn"
        Me.RetrieveBtn.Size = New System.Drawing.Size(75, 23)
        Me.RetrieveBtn.TabIndex = 15
        Me.RetrieveBtn.Text = "Retrieve"
        Me.RetrieveBtn.UseVisualStyleBackColor = True
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 330)
        Me.Controls.Add(Me.RetrieveBtn)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.ZipBox)
        Me.Controls.Add(Me.StateBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.Addr2Box)
        Me.Controls.Add(Me.Addr1Box)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.TelnoBox)
        Me.Controls.Add(Me.ZipLbl)
        Me.Controls.Add(Me.StateLbl)
        Me.Controls.Add(Me.CityLbl)
        Me.Controls.Add(Me.Addr2Label)
        Me.Controls.Add(Me.Addr1Label)
        Me.Controls.Add(Me.TelnoLabel)
        Me.Controls.Add(Me.NameLbl)
        Me.Name = "ContactForm"
        Me.Text = "Contact Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLbl As Label
    Friend WithEvents TelnoLabel As Label
    Friend WithEvents Addr1Label As Label
    Friend WithEvents Addr2Label As Label
    Friend WithEvents CityLbl As Label
    Friend WithEvents StateLbl As Label
    Friend WithEvents ZipLbl As Label
    Friend WithEvents TelnoBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Addr1Box As TextBox
    Friend WithEvents Addr2Box As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents StateBox As TextBox
    Friend WithEvents ZipBox As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents RetrieveBtn As Button
End Class
