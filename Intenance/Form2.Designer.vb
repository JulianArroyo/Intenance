<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalWindow))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrincipalTabControl = New System.Windows.Forms.TabControl()
        Me.CandidatosTabPage = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.PrincipalTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'PrincipalTabControl
        '
        Me.PrincipalTabControl.Controls.Add(Me.CandidatosTabPage)
        Me.PrincipalTabControl.Controls.Add(Me.TabPage2)
        Me.PrincipalTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PrincipalTabControl.ItemSize = New System.Drawing.Size(100, 30)
        Me.PrincipalTabControl.Location = New System.Drawing.Point(0, 27)
        Me.PrincipalTabControl.Multiline = True
        Me.PrincipalTabControl.Name = "PrincipalTabControl"
        Me.PrincipalTabControl.SelectedIndex = 0
        Me.PrincipalTabControl.Size = New System.Drawing.Size(1008, 666)
        Me.PrincipalTabControl.TabIndex = 1
        '
        'CandidatosTabPage
        '
        Me.CandidatosTabPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CandidatosTabPage.Location = New System.Drawing.Point(4, 34)
        Me.CandidatosTabPage.Name = "CandidatosTabPage"
        Me.CandidatosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CandidatosTabPage.Size = New System.Drawing.Size(1000, 628)
        Me.CandidatosTabPage.TabIndex = 0
        Me.CandidatosTabPage.Text = "Candidatos"
        Me.CandidatosTabPage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 628)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PrincipalWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.PrincipalTabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 730)
        Me.MinimumSize = New System.Drawing.Size(1024, 730)
        Me.Name = "PrincipalWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intenance RRHH"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PrincipalTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrincipalTabControl As TabControl
    Friend WithEvents CandidatosTabPage As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
