<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Facturacion
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
        Me.gbProductos = New System.Windows.Forms.GroupBox()
        Me.txtTarifa12 = New System.Windows.Forms.TextBox()
        Me.txtTarifa0 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GravaIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslIngresar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslModificar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslConsultar = New System.Windows.Forms.ToolStripLabel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.gbInfoGeneral = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCuotas = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nupEntrada = New System.Windows.Forms.NumericUpDown()
        Me.txtValorEntrada = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPorcentajeDscto = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNoContrato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.rbContrato = New System.Windows.Forms.RadioButton()
        Me.rbCedula = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbGarante = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCedulaGarante = New System.Windows.Forms.TextBox()
        Me.btnEditarGarante = New System.Windows.Forms.Button()
        Me.btnBuscarGarante = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtGarante = New System.Windows.Forms.TextBox()
        Me.txtTelefonoGarante = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDireccionGarante = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gbProductos.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.gbInfoGeneral.SuspendLayout()
        CType(Me.nupEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentajeDscto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGarante.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProductos
        '
        Me.gbProductos.Controls.Add(Me.txtTarifa12)
        Me.gbProductos.Controls.Add(Me.txtTarifa0)
        Me.gbProductos.Controls.Add(Me.Label23)
        Me.gbProductos.Controls.Add(Me.Label22)
        Me.gbProductos.Controls.Add(Me.btnEliminar)
        Me.gbProductos.Controls.Add(Me.btnAnadir)
        Me.gbProductos.Controls.Add(Me.txtTotal)
        Me.gbProductos.Controls.Add(Me.Label13)
        Me.gbProductos.Controls.Add(Me.txtIva)
        Me.gbProductos.Controls.Add(Me.Label14)
        Me.gbProductos.Controls.Add(Me.txtDescuento)
        Me.gbProductos.Controls.Add(Me.Label12)
        Me.gbProductos.Controls.Add(Me.txtSubtotal)
        Me.gbProductos.Controls.Add(Me.Label11)
        Me.gbProductos.Controls.Add(Me.dgvProductos)
        Me.gbProductos.Location = New System.Drawing.Point(12, 291)
        Me.gbProductos.Name = "gbProductos"
        Me.gbProductos.Size = New System.Drawing.Size(874, 316)
        Me.gbProductos.TabIndex = 3
        Me.gbProductos.TabStop = False
        Me.gbProductos.Text = "Productos"
        Me.gbProductos.Visible = False
        '
        'txtTarifa12
        '
        Me.txtTarifa12.Enabled = False
        Me.txtTarifa12.Location = New System.Drawing.Point(776, 220)
        Me.txtTarifa12.Name = "txtTarifa12"
        Me.txtTarifa12.Size = New System.Drawing.Size(72, 20)
        Me.txtTarifa12.TabIndex = 26
        Me.txtTarifa12.Text = "0.00"
        '
        'txtTarifa0
        '
        Me.txtTarifa0.Enabled = False
        Me.txtTarifa0.Location = New System.Drawing.Point(604, 282)
        Me.txtTarifa0.Name = "txtTarifa0"
        Me.txtTarifa0.Size = New System.Drawing.Size(72, 20)
        Me.txtTarifa0.TabIndex = 25
        Me.txtTarifa0.Text = "0.00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(689, 227)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 13)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Tarifa Iva 12% :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(523, 289)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Tarifa Iva 0% :"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.UI_SICIPV.My.Resources.Resources.remove
        Me.btnEliminar.Location = New System.Drawing.Point(6, 48)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(28, 23)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Image = Global.UI_SICIPV.My.Resources.Resources.add
        Me.btnAnadir.Location = New System.Drawing.Point(6, 19)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(28, 23)
        Me.btnAnadir.TabIndex = 21
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(776, 278)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(72, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(736, 285)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total:"
        '
        'txtIva
        '
        Me.txtIva.Enabled = False
        Me.txtIva.Location = New System.Drawing.Point(776, 249)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(72, 20)
        Me.txtIva.TabIndex = 9
        Me.txtIva.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(722, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Iva 12%:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(604, 253)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(72, 20)
        Me.txtDescuento.TabIndex = 7
        Me.txtDescuento.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(536, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Descuento:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(604, 224)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(72, 20)
        Me.txtSubtotal.TabIndex = 5
        Me.txtSubtotal.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(549, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Subtotal:"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.GravaIva, Me.stock, Me.Cantidad, Me.Costo, Me.Descripcion, Me.ValorUnitario, Me.ValorTotal})
        Me.dgvProductos.Location = New System.Drawing.Point(40, 19)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(820, 195)
        Me.dgvProductos.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'GravaIva
        '
        Me.GravaIva.HeaderText = "gravaIva"
        Me.GravaIva.Name = "GravaIva"
        Me.GravaIva.Visible = False
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Width = 50
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 70
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 455
        '
        'ValorUnitario
        '
        Me.ValorUnitario.HeaderText = "Valor Unitario"
        Me.ValorUnitario.Name = "ValorUnitario"
        Me.ValorUnitario.ReadOnly = True
        '
        'ValorTotal
        '
        Me.ValorTotal.HeaderText = "Valor Toral"
        Me.ValorTotal.Name = "ValorTotal"
        Me.ValorTotal.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslIngresar, Me.ToolStripSeparator1, Me.tslModificar, Me.ToolStripSeparator2, Me.tslConsultar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(904, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslIngresar
        '
        Me.tslIngresar.Image = Global.UI_SICIPV.My.Resources.Resources.ingresar
        Me.tslIngresar.Name = "tslIngresar"
        Me.tslIngresar.Size = New System.Drawing.Size(65, 22)
        Me.tslIngresar.Text = "Ingresar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslModificar
        '
        Me.tslModificar.Enabled = False
        Me.tslModificar.Image = Global.UI_SICIPV.My.Resources.Resources.modificar
        Me.tslModificar.Name = "tslModificar"
        Me.tslModificar.Size = New System.Drawing.Size(74, 22)
        Me.tslModificar.Text = "Modificar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tslConsultar
        '
        Me.tslConsultar.Image = Global.UI_SICIPV.My.Resources.Resources.consultar
        Me.tslConsultar.Name = "tslConsultar"
        Me.tslConsultar.Size = New System.Drawing.Size(74, 22)
        Me.tslConsultar.Text = "Consultar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(335, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = " Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(492, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnCancelar)
        Me.pnlBotones.Controls.Add(Me.btnAceptar)
        Me.pnlBotones.Location = New System.Drawing.Point(12, 613)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(874, 45)
        Me.pnlBotones.TabIndex = 4
        Me.pnlBotones.Visible = False
        '
        'gbInfoGeneral
        '
        Me.gbInfoGeneral.Controls.Add(Me.Label15)
        Me.gbInfoGeneral.Controls.Add(Me.cbCuotas)
        Me.gbInfoGeneral.Controls.Add(Me.Label25)
        Me.gbInfoGeneral.Controls.Add(Me.nupEntrada)
        Me.gbInfoGeneral.Controls.Add(Me.txtValorEntrada)
        Me.gbInfoGeneral.Controls.Add(Me.Label24)
        Me.gbInfoGeneral.Controls.Add(Me.txtPorcentajeDscto)
        Me.gbInfoGeneral.Controls.Add(Me.Label19)
        Me.gbInfoGeneral.Controls.Add(Me.Label17)
        Me.gbInfoGeneral.Controls.Add(Me.txtCedula)
        Me.gbInfoGeneral.Controls.Add(Me.btnEditarCliente)
        Me.gbInfoGeneral.Controls.Add(Me.btnBuscarCliente)
        Me.gbInfoGeneral.Controls.Add(Me.Label16)
        Me.gbInfoGeneral.Controls.Add(Me.cbTipoVenta)
        Me.gbInfoGeneral.Controls.Add(Me.txtNoFactura)
        Me.gbInfoGeneral.Controls.Add(Me.Label5)
        Me.gbInfoGeneral.Controls.Add(Me.Label6)
        Me.gbInfoGeneral.Controls.Add(Me.txtCliente)
        Me.gbInfoGeneral.Controls.Add(Me.txtTelefono)
        Me.gbInfoGeneral.Controls.Add(Me.txtNoContrato)
        Me.gbInfoGeneral.Controls.Add(Me.Label7)
        Me.gbInfoGeneral.Controls.Add(Me.txtDireccion)
        Me.gbInfoGeneral.Controls.Add(Me.dtpFecha)
        Me.gbInfoGeneral.Controls.Add(Me.Label3)
        Me.gbInfoGeneral.Controls.Add(Me.Label10)
        Me.gbInfoGeneral.Controls.Add(Me.Label9)
        Me.gbInfoGeneral.Controls.Add(Me.Label8)
        Me.gbInfoGeneral.Controls.Add(Me.Label4)
        Me.gbInfoGeneral.Controls.Add(Me.Label1)
        Me.gbInfoGeneral.Location = New System.Drawing.Point(11, 28)
        Me.gbInfoGeneral.Name = "gbInfoGeneral"
        Me.gbInfoGeneral.Size = New System.Drawing.Size(875, 150)
        Me.gbInfoGeneral.TabIndex = 33
        Me.gbInfoGeneral.TabStop = False
        Me.gbInfoGeneral.Text = "Información General"
        Me.gbInfoGeneral.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(849, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "%"
        '
        'cbCuotas
        '
        Me.cbCuotas.FormattingEnabled = True
        Me.cbCuotas.Location = New System.Drawing.Point(790, 45)
        Me.cbCuotas.Name = "cbCuotas"
        Me.cbCuotas.Size = New System.Drawing.Size(56, 21)
        Me.cbCuotas.TabIndex = 41
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(707, 105)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 13)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "Valor Entrada :"
        '
        'nupEntrada
        '
        Me.nupEntrada.DecimalPlaces = 2
        Me.nupEntrada.Location = New System.Drawing.Point(789, 73)
        Me.nupEntrada.Name = "nupEntrada"
        Me.nupEntrada.Size = New System.Drawing.Size(57, 20)
        Me.nupEntrada.TabIndex = 39
        Me.nupEntrada.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'txtValorEntrada
        '
        Me.txtValorEntrada.Enabled = False
        Me.txtValorEntrada.Location = New System.Drawing.Point(792, 102)
        Me.txtValorEntrada.Name = "txtValorEntrada"
        Me.txtValorEntrada.Size = New System.Drawing.Size(57, 20)
        Me.txtValorEntrada.TabIndex = 38
        Me.txtValorEntrada.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(733, 73)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Entrada :"
        '
        'txtPorcentajeDscto
        '
        Me.txtPorcentajeDscto.DecimalPlaces = 2
        Me.txtPorcentajeDscto.Location = New System.Drawing.Point(788, 20)
        Me.txtPorcentajeDscto.Name = "txtPorcentajeDscto"
        Me.txtPorcentajeDscto.Size = New System.Drawing.Size(58, 20)
        Me.txtPorcentajeDscto.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(849, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 16)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 13
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(94, 50)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(161, 20)
        Me.txtCedula.TabIndex = 3
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Location = New System.Drawing.Point(295, 48)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(28, 23)
        Me.btnEditarCliente.TabIndex = 5
        Me.btnEditarCliente.Text = "E"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(261, 48)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscarCliente.TabIndex = 4
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Cedula:"
        '
        'cbTipoVenta
        '
        Me.cbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoVenta.FormattingEnabled = True
        Me.cbTipoVenta.Location = New System.Drawing.Point(493, 49)
        Me.cbTipoVenta.Name = "cbTipoVenta"
        Me.cbTipoVenta.Size = New System.Drawing.Size(205, 21)
        Me.cbTipoVenta.TabIndex = 9
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(94, 26)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(85, 20)
        Me.txtNoFactura.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No. Contrato:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de Venta:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(94, 72)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(301, 20)
        Me.txtCliente.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(493, 72)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(205, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'txtNoContrato
        '
        Me.txtNoContrato.Location = New System.Drawing.Point(493, 26)
        Me.txtNoContrato.Name = "txtNoContrato"
        Me.txtNoContrato.Size = New System.Drawing.Size(205, 20)
        Me.txtNoContrato.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Teléfono:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(94, 95)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(301, 43)
        Me.txtDireccion.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(493, 95)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(205, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(721, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Descuento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(740, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cuotas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "No. Factura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dirección:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'gbBuscar
        '
        Me.gbBuscar.Controls.Add(Me.dgvBusqueda)
        Me.gbBuscar.Controls.Add(Me.btnBuscar)
        Me.gbBuscar.Controls.Add(Me.txtBusqueda)
        Me.gbBuscar.Controls.Add(Me.rbFactura)
        Me.gbBuscar.Controls.Add(Me.rbContrato)
        Me.gbBuscar.Controls.Add(Me.rbCedula)
        Me.gbBuscar.Controls.Add(Me.rbNombre)
        Me.gbBuscar.Enabled = False
        Me.gbBuscar.Location = New System.Drawing.Point(11, 664)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(875, 328)
        Me.gbBuscar.TabIndex = 34
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Busqueda Factura"
        Me.gbBuscar.Visible = False
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(16, 90)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.Size = New System.Drawing.Size(845, 208)
        Me.dgvBusqueda.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(537, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(275, 43)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(256, 20)
        Me.txtBusqueda.TabIndex = 3
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Location = New System.Drawing.Point(509, 19)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(81, 17)
        Me.rbFactura.TabIndex = 2
        Me.rbFactura.Text = "No. Factura"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'rbContrato
        '
        Me.rbContrato.AutoSize = True
        Me.rbContrato.Location = New System.Drawing.Point(404, 19)
        Me.rbContrato.Name = "rbContrato"
        Me.rbContrato.Size = New System.Drawing.Size(85, 17)
        Me.rbContrato.TabIndex = 2
        Me.rbContrato.Text = "No. Contrato"
        Me.rbContrato.UseVisualStyleBackColor = True
        '
        'rbCedula
        '
        Me.rbCedula.AutoSize = True
        Me.rbCedula.Location = New System.Drawing.Point(323, 19)
        Me.rbCedula.Name = "rbCedula"
        Me.rbCedula.Size = New System.Drawing.Size(58, 17)
        Me.rbCedula.TabIndex = 2
        Me.rbCedula.Text = "Cedula"
        Me.rbCedula.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Checked = True
        Me.rbNombre.Location = New System.Drawing.Point(249, 19)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(57, 17)
        Me.rbNombre.TabIndex = 0
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Cliente"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'gbGarante
        '
        Me.gbGarante.Controls.Add(Me.Label2)
        Me.gbGarante.Controls.Add(Me.txtCedulaGarante)
        Me.gbGarante.Controls.Add(Me.btnEditarGarante)
        Me.gbGarante.Controls.Add(Me.btnBuscarGarante)
        Me.gbGarante.Controls.Add(Me.Label18)
        Me.gbGarante.Controls.Add(Me.txtGarante)
        Me.gbGarante.Controls.Add(Me.txtTelefonoGarante)
        Me.gbGarante.Controls.Add(Me.Label21)
        Me.gbGarante.Controls.Add(Me.txtDireccionGarante)
        Me.gbGarante.Controls.Add(Me.Label27)
        Me.gbGarante.Controls.Add(Me.Label28)
        Me.gbGarante.Location = New System.Drawing.Point(11, 184)
        Me.gbGarante.Name = "gbGarante"
        Me.gbGarante.Size = New System.Drawing.Size(875, 101)
        Me.gbGarante.TabIndex = 33
        Me.gbGarante.TabStop = False
        Me.gbGarante.Text = "Información Garante"
        Me.gbGarante.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 13
        '
        'txtCedulaGarante
        '
        Me.txtCedulaGarante.Location = New System.Drawing.Point(89, 21)
        Me.txtCedulaGarante.Name = "txtCedulaGarante"
        Me.txtCedulaGarante.Size = New System.Drawing.Size(161, 20)
        Me.txtCedulaGarante.TabIndex = 15
        '
        'btnEditarGarante
        '
        Me.btnEditarGarante.Location = New System.Drawing.Point(290, 19)
        Me.btnEditarGarante.Name = "btnEditarGarante"
        Me.btnEditarGarante.Size = New System.Drawing.Size(28, 23)
        Me.btnEditarGarante.TabIndex = 17
        Me.btnEditarGarante.Text = "E"
        Me.btnEditarGarante.UseVisualStyleBackColor = True
        '
        'btnBuscarGarante
        '
        Me.btnBuscarGarante.Location = New System.Drawing.Point(256, 19)
        Me.btnBuscarGarante.Name = "btnBuscarGarante"
        Me.btnBuscarGarante.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscarGarante.TabIndex = 16
        Me.btnBuscarGarante.Text = "..."
        Me.btnBuscarGarante.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Cedula:"
        '
        'txtGarante
        '
        Me.txtGarante.Enabled = False
        Me.txtGarante.Location = New System.Drawing.Point(89, 43)
        Me.txtGarante.Name = "txtGarante"
        Me.txtGarante.Size = New System.Drawing.Size(301, 20)
        Me.txtGarante.TabIndex = 18
        '
        'txtTelefonoGarante
        '
        Me.txtTelefonoGarante.Enabled = False
        Me.txtTelefonoGarante.Location = New System.Drawing.Point(493, 19)
        Me.txtTelefonoGarante.Name = "txtTelefonoGarante"
        Me.txtTelefonoGarante.Size = New System.Drawing.Size(205, 20)
        Me.txtTelefonoGarante.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(412, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Teléfono:"
        '
        'txtDireccionGarante
        '
        Me.txtDireccionGarante.Enabled = False
        Me.txtDireccionGarante.Location = New System.Drawing.Point(493, 45)
        Me.txtDireccionGarante.Multiline = True
        Me.txtDireccionGarante.Name = "txtDireccionGarante"
        Me.txtDireccionGarante.Size = New System.Drawing.Size(301, 43)
        Me.txtDireccionGarante.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(413, 50)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(55, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Dirección:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(17, 50)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Garante:"
        '
        'frm_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(904, 750)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbGarante)
        Me.Controls.Add(Me.gbInfoGeneral)
        Me.Controls.Add(Me.gbProductos)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "frm_Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".::Facturación::."
        Me.gbProductos.ResumeLayout(False)
        Me.gbProductos.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.gbInfoGeneral.ResumeLayout(False)
        Me.gbInfoGeneral.PerformLayout()
        CType(Me.nupEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentajeDscto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGarante.ResumeLayout(False)
        Me.gbGarante.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbProductos As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslIngresar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslModificar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslConsultar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents gbInfoGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNoContrato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbContrato As System.Windows.Forms.RadioButton
    Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents gbGarante As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarGarante As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtGarante As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoGarante As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionGarante As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents txtCedulaGarante As System.Windows.Forms.TextBox
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnEditarGarante As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeDscto As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtTarifa12 As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifa0 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtValorEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GravaIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents nupEntrada As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
