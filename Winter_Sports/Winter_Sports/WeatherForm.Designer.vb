<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeatherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeatherForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtBrowserAddress = New System.Windows.Forms.ToolStripTextBox()
        Me.TSBtnwebGo = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnGoBack = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnClose = New System.Windows.Forms.ToolStripButton()
        Me.weatherBrowser = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtBrowserAddress, Me.TSBtnwebGo, Me.TSBtnGoBack, Me.TSBtnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(968, 33)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtBrowserAddress
        '
        Me.txtBrowserAddress.Name = "txtBrowserAddress"
        Me.txtBrowserAddress.Size = New System.Drawing.Size(532, 33)
        '
        'TSBtnwebGo
        '
        Me.TSBtnwebGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBtnwebGo.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnwebGo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TSBtnwebGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnwebGo.Name = "TSBtnwebGo"
        Me.TSBtnwebGo.Size = New System.Drawing.Size(48, 30)
        Me.TSBtnwebGo.Text = "GO"
        '
        'TSBtnGoBack
        '
        Me.TSBtnGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBtnGoBack.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnGoBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TSBtnGoBack.Image = CType(resources.GetObject("TSBtnGoBack.Image"), System.Drawing.Image)
        Me.TSBtnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnGoBack.Name = "TSBtnGoBack"
        Me.TSBtnGoBack.Size = New System.Drawing.Size(92, 30)
        Me.TSBtnGoBack.Text = "Go Back"
        '
        'TSBtnClose
        '
        Me.TSBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBtnClose.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSBtnClose.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TSBtnClose.Image = CType(resources.GetObject("TSBtnClose.Image"), System.Drawing.Image)
        Me.TSBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnClose.Name = "TSBtnClose"
        Me.TSBtnClose.Size = New System.Drawing.Size(66, 30)
        Me.TSBtnClose.Text = "Close"
        '
        'weatherBrowser
        '
        Me.weatherBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weatherBrowser.Location = New System.Drawing.Point(0, 0)
        Me.weatherBrowser.Margin = New System.Windows.Forms.Padding(4)
        Me.weatherBrowser.Name = "weatherBrowser"
        Me.weatherBrowser.Size = New System.Drawing.Size(968, 450)
        Me.weatherBrowser.TabIndex = 4
        '
        'WeatherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.weatherBrowser)
        Me.Name = "WeatherForm"
        Me.Text = "WeatherForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtBrowserAddress As ToolStripTextBox
    Friend WithEvents TSBtnwebGo As ToolStripButton
    Friend WithEvents TSBtnGoBack As ToolStripButton
    Friend WithEvents TSBtnClose As ToolStripButton
    Friend WithEvents weatherBrowser As WebBrowser
End Class
