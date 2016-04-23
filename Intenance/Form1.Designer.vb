<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashWindow
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashWindow))
        Me.SplashProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SplashLabel = New System.Windows.Forms.Label()
        Me.SplashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SplashProgressBar
        '
        Me.SplashProgressBar.BackColor = System.Drawing.Color.Orange
        Me.SplashProgressBar.ForeColor = System.Drawing.Color.Gold
        Me.SplashProgressBar.Location = New System.Drawing.Point(12, 340)
        Me.SplashProgressBar.Name = "SplashProgressBar"
        Me.SplashProgressBar.Size = New System.Drawing.Size(501, 8)
        Me.SplashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.SplashProgressBar.TabIndex = 0
        '
        'SplashLabel
        '
        Me.SplashLabel.AutoSize = True
        Me.SplashLabel.BackColor = System.Drawing.Color.Transparent
        Me.SplashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplashLabel.ForeColor = System.Drawing.Color.Gold
        Me.SplashLabel.Location = New System.Drawing.Point(12, 286)
        Me.SplashLabel.Name = "SplashLabel"
        Me.SplashLabel.Size = New System.Drawing.Size(167, 51)
        Me.SplashLabel.TabIndex = 1
        Me.SplashLabel.Text = "Developed by:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Julián Arroyo Serrano" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MIT License"
        '
        'SplashTimer
        '
        Me.SplashTimer.Enabled = True
        Me.SplashTimer.Interval = 50
        '
        'SplashWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(525, 360)
        Me.Controls.Add(Me.SplashLabel)
        Me.Controls.Add(Me.SplashProgressBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(525, 360)
        Me.MinimumSize = New System.Drawing.Size(525, 360)
        Me.Name = "SplashWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplashProgressBar As ProgressBar
    Friend WithEvents SplashLabel As Label
    Friend WithEvents SplashTimer As Timer
End Class
