<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnTicker = New System.Windows.Forms.Button()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.btnPE = New System.Windows.Forms.Button()
        Me.chkDescending = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Items.AddRange(New Object() {"MMA, price = 40.00, P/E = 8.00", "ABC, price =80.00. P/E = 4.00", "SBA, price = 42.00, P/E = 6.00", "LLT, price = 43.00, P/E = 8.60", "XYZ, price = 80.00, P/E = 4.00"})
        Me.lstBox.Location = New System.Drawing.Point(182, 61)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(248, 95)
        Me.lstBox.TabIndex = 0
        '
        'btnTicker
        '
        Me.btnTicker.Location = New System.Drawing.Point(28, 61)
        Me.btnTicker.Name = "btnTicker"
        Me.btnTicker.Size = New System.Drawing.Size(86, 23)
        Me.btnTicker.TabIndex = 1
        Me.btnTicker.Text = "Sort by Ticker"
        Me.btnTicker.UseVisualStyleBackColor = True
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(28, 106)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(86, 23)
        Me.btnPrice.TabIndex = 2
        Me.btnPrice.Text = "Sort by Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'btnPE
        '
        Me.btnPE.Location = New System.Drawing.Point(28, 146)
        Me.btnPE.Name = "btnPE"
        Me.btnPE.Size = New System.Drawing.Size(86, 23)
        Me.btnPE.TabIndex = 3
        Me.btnPE.Text = "Sort by PE Ratio"
        Me.btnPE.UseVisualStyleBackColor = True
        '
        'chkDescending
        '
        Me.chkDescending.AutoSize = True
        Me.chkDescending.Location = New System.Drawing.Point(195, 182)
        Me.chkDescending.Name = "chkDescending"
        Me.chkDescending.Size = New System.Drawing.Size(110, 17)
        Me.chkDescending.TabIndex = 5
        Me.chkDescending.Text = "Descending order"
        Me.chkDescending.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "This application sorts a list of  stocks in different ways"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 221)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkDescending)
        Me.Controls.Add(Me.btnPE)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.btnTicker)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "Form1"
        Me.Text = "Ordering Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnTicker As Button
    Friend WithEvents btnPrice As Button
    Friend WithEvents btnPE As Button
    Friend WithEvents chkDescending As CheckBox
    Friend WithEvents Label1 As Label
End Class
