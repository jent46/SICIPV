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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbIngreso.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbIngreso
        '
        Me.gbIngreso.BackColor = System.Drawing.Color.Transparent
        Me.gbIngreso.Controls.Add(Me.btnIngresar)
        Me.gbIngreso.Controls.Add(Me.txtClave)
        Me.gbIngreso.Controls.Add(Me.txtUsuario)
        Me.gbIngreso.Controls.Add(Me.Label1)
        Me.gbIngreso.Controls.Add(Me.Label2)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.AbonoToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ClienteToolStripMenuItem1, Me.UsuarioToolStripMenuItem, Me.IngresoProductoToolStripMenuItem, Me.GastoToolStripMenuItem, Me.CambiarDeUsuarioToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'AbonoToolStripMenuItem
        '
        Me.AbonoToolStripMenuItem.Name = "AbonoToolStripMenuItem"
        Me.AbonoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AbonoToolStripMenuItem.Text = "Abono"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'IngresoProductoToolStripMenuItem
        '
        Me.IngresoProductoToolStripMenuItem.Name = "IngresoProductoToolStripMenuItem"
        Me.IngresoProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.IngresoProductoToolStripMenuItem.Text = "IngresoProducto"
        '
        'GastoToolStripMenuItem
        '
        Me.GastoToolStripMenuItem.Name = "GastoToolStripMenuItem"
        Me.GastoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GastoToolStripMenuItem.Text = "Gasto"
        '
        'CambiarDeUsuarioToolStripMenuItem
        '
        Me.CambiarDeUsuarioToolStripMenuItem.Name = "CambiarDeUsuarioToolStripMenuItem"
        Me.CambiarDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = Global.UI_SICIPV.My.Resources.Resources.password
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(24, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLAVE :               "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = Global.UI_SICIPV.My.Resources.Resources.user
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(19, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO :          "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1244, 522)
        Me.Controls.Add(Me.gbIngreso)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: SCIPV ::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbIngreso.ResumeLayout(False)
        Me.gbIngreso.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbonoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
