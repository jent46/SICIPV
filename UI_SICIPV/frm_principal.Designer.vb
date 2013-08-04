<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.gbIngreso = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbMenu = New System.Windows.Forms.MenuStrip()
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbIngreso.SuspendLayout()
        Me.TbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbIngreso
        '
        Me.gbIngreso.BackColor = System.Drawing.Color.Transparent
        Me.gbIngreso.Controls.Add(Me.btnIngresar)
        Me.gbIngreso.Controls.Add(Me.txtClave)
        Me.gbIngreso.Controls.Add(Me.txtUsuario)
        Me.gbIngreso.Controls.Add(Me.Label2)
        Me.gbIngreso.Controls.Add(Me.Label1)
        Me.gbIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIngreso.Location = New System.Drawing.Point(544, 260)
        Me.gbIngreso.Name = "gbIngreso"
        Me.gbIngreso.Size = New System.Drawing.Size(292, 250)
        Me.gbIngreso.TabIndex = 4
        Me.gbIngreso.TabStop = False
        Me.gbIngreso.Text = "INGRESO AL SISTEMA"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(103, 158)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(95, 32)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(112, 106)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(146, 20)
        Me.txtClave.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(112, 47)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(146, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLAVE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO :"
        '
        'TbMenu
        '
        Me.TbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.NuevoToolStripMenuItem})
        Me.TbMenu.Location = New System.Drawing.Point(0, 0)
        Me.TbMenu.Name = "TbMenu"
        Me.TbMenu.Size = New System.Drawing.Size(1244, 24)
        Me.TbMenu.TabIndex = 6
        Me.TbMenu.Text = "MenuStrip1"
        Me.TbMenu.Visible = False
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.IngresoToolStripMenuItem.Text = "ingreso"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "ventana"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.NuevoToolStripMenuItem.Text = "nuevo"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1244, 522)
        Me.Controls.Add(Me.gbIngreso)
        Me.Controls.Add(Me.TbMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.TbMenu
        Me.Name = "frm_principal"
        Me.Text = ".:: SCIPV ::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbIngreso.ResumeLayout(False)
        Me.gbIngreso.PerformLayout()
        Me.TbMenu.ResumeLayout(False)
        Me.TbMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents IngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
