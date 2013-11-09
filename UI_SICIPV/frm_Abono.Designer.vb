<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Abono
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslIngresar = New System.Windows.Forms.ToolStripLabel()
        Me.labelFiltrar = New System.Windows.Forms.Label()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.txtTotalAbono = New System.Windows.Forms.TextBox()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewAbono = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_letra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f_de_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImpresion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_cada = New System.Windows.Forms.TextBox()
        Me.txt_de = New System.Windows.Forms.TextBox()
        Me.txt_Cuotas = New System.Windows.Forms.TextBox()
        Me.txt_formaDePago = New System.Windows.Forms.TextBox()
        Me.txt_fdeVenc = New System.Windows.Forms.TextBox()
        Me.txt_saldo = New System.Windows.Forms.TextBox()
        Me.txt_entrada = New System.Windows.Forms.TextBox()
        Me.txt_valorTotal = New System.Windows.Forms.TextBox()
        Me.txt_descripcionArticulo = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_nombreApellido = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_vendedor = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_fdIngreso = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.DataGridViewAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslIngresar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(817, 25)
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
        'labelFiltrar
        '
        Me.labelFiltrar.AutoSize = True
        Me.labelFiltrar.Location = New System.Drawing.Point(21, 47)
        Me.labelFiltrar.Name = "labelFiltrar"
        Me.labelFiltrar.Size = New System.Drawing.Size(129, 13)
        Me.labelFiltrar.TabIndex = 36
        Me.labelFiltrar.Text = "NUMERO DE FACTURA:"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(160, 43)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrar.TabIndex = 37
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.UI_SICIPV.My.Resources.Resources.consultar
        Me.btnFiltrar.Location = New System.Drawing.Point(266, 18)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(43, 45)
        Me.btnFiltrar.TabIndex = 38
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.gbDatos)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlBotones)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(18, 82)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(787, 603)
        Me.FlowLayoutPanel1.TabIndex = 39
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtSaldoRestante)
        Me.gbDatos.Controls.Add(Me.txtTotalAbono)
        Me.gbDatos.Controls.Add(Me.txtDeuda)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.DataGridViewAbono)
        Me.gbDatos.Controls.Add(Me.txt_cada)
        Me.gbDatos.Controls.Add(Me.txt_de)
        Me.gbDatos.Controls.Add(Me.txt_Cuotas)
        Me.gbDatos.Controls.Add(Me.txt_formaDePago)
        Me.gbDatos.Controls.Add(Me.txt_fdeVenc)
        Me.gbDatos.Controls.Add(Me.txt_saldo)
        Me.gbDatos.Controls.Add(Me.txt_entrada)
        Me.gbDatos.Controls.Add(Me.txt_valorTotal)
        Me.gbDatos.Controls.Add(Me.txt_descripcionArticulo)
        Me.gbDatos.Controls.Add(Me.txt_telefono)
        Me.gbDatos.Controls.Add(Me.txt_direccion)
        Me.gbDatos.Controls.Add(Me.txt_cedula)
        Me.gbDatos.Controls.Add(Me.txt_nombreApellido)
        Me.gbDatos.Controls.Add(Me.txt_codigo)
        Me.gbDatos.Controls.Add(Me.Label18)
        Me.gbDatos.Controls.Add(Me.Label19)
        Me.gbDatos.Controls.Add(Me.PictureBox2)
        Me.gbDatos.Controls.Add(Me.Label20)
        Me.gbDatos.Controls.Add(Me.Label21)
        Me.gbDatos.Controls.Add(Me.Label22)
        Me.gbDatos.Controls.Add(Me.Label23)
        Me.gbDatos.Controls.Add(Me.Label24)
        Me.gbDatos.Controls.Add(Me.Label25)
        Me.gbDatos.Controls.Add(Me.Label26)
        Me.gbDatos.Controls.Add(Me.Label27)
        Me.gbDatos.Controls.Add(Me.Label28)
        Me.gbDatos.Controls.Add(Me.Label29)
        Me.gbDatos.Controls.Add(Me.Label30)
        Me.gbDatos.Controls.Add(Me.txt_vendedor)
        Me.gbDatos.Controls.Add(Me.Label31)
        Me.gbDatos.Controls.Add(Me.Label32)
        Me.gbDatos.Controls.Add(Me.txt_fdIngreso)
        Me.gbDatos.Controls.Add(Me.Label33)
        Me.gbDatos.Location = New System.Drawing.Point(3, 3)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(776, 528)
        Me.gbDatos.TabIndex = 23
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos Cartilla"
        Me.gbDatos.Visible = False
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Location = New System.Drawing.Point(664, 477)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoRestante.TabIndex = 73
        '
        'txtTotalAbono
        '
        Me.txtTotalAbono.Location = New System.Drawing.Point(664, 448)
        Me.txtTotalAbono.Name = "txtTotalAbono"
        Me.txtTotalAbono.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAbono.TabIndex = 72
        '
        'txtDeuda
        '
        Me.txtDeuda.Location = New System.Drawing.Point(664, 421)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.Size = New System.Drawing.Size(100, 20)
        Me.txtDeuda.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(572, 484)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Saldo Restante :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 455)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Total Abono :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(613, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Deuda :"
        '
        'DataGridViewAbono
        '
        Me.DataGridViewAbono.AllowUserToAddRows = False
        Me.DataGridViewAbono.AllowUserToDeleteRows = False
        Me.DataGridViewAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAbono.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no_letra, Me.f_de_pago, Me.cuota, Me.valor, Me.diferencia, Me.comentario, Me.btnImpresion})
        Me.DataGridViewAbono.Location = New System.Drawing.Point(16, 211)
        Me.DataGridViewAbono.Name = "DataGridViewAbono"
        Me.DataGridViewAbono.Size = New System.Drawing.Size(748, 201)
        Me.DataGridViewAbono.TabIndex = 67
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'no_letra
        '
        Me.no_letra.HeaderText = "No_LETRA"
        Me.no_letra.Name = "no_letra"
        Me.no_letra.ReadOnly = True
        Me.no_letra.Width = 75
        '
        'f_de_pago
        '
        Me.f_de_pago.HeaderText = "F_DE_PAGO"
        Me.f_de_pago.Name = "f_de_pago"
        Me.f_de_pago.ReadOnly = True
        Me.f_de_pago.Width = 80
        '
        'cuota
        '
        Me.cuota.HeaderText = "CUOTA"
        Me.cuota.Name = "cuota"
        Me.cuota.ReadOnly = True
        Me.cuota.Width = 60
        '
        'valor
        '
        Me.valor.HeaderText = "VALOR"
        Me.valor.Name = "valor"
        Me.valor.Width = 60
        '
        'diferencia
        '
        Me.diferencia.HeaderText = "DIFERENCIA"
        Me.diferencia.Name = "diferencia"
        Me.diferencia.ReadOnly = True
        Me.diferencia.Width = 75
        '
        'comentario
        '
        Me.comentario.HeaderText = "COMENTARIO"
        Me.comentario.Name = "comentario"
        Me.comentario.Width = 245
        '
        'btnImpresion
        '
        Me.btnImpresion.HeaderText = "IMPRESION"
        Me.btnImpresion.Name = "btnImpresion"
        Me.btnImpresion.Text = "IMPRIMIR"
        Me.btnImpresion.UseColumnTextForButtonValue = True
        '
        'txt_cada
        '
        Me.txt_cada.Location = New System.Drawing.Point(664, 167)
        Me.txt_cada.Name = "txt_cada"
        Me.txt_cada.Size = New System.Drawing.Size(100, 20)
        Me.txt_cada.TabIndex = 66
        '
        'txt_de
        '
        Me.txt_de.Location = New System.Drawing.Point(478, 167)
        Me.txt_de.Name = "txt_de"
        Me.txt_de.Size = New System.Drawing.Size(86, 20)
        Me.txt_de.TabIndex = 65
        '
        'txt_Cuotas
        '
        Me.txt_Cuotas.Location = New System.Drawing.Point(321, 167)
        Me.txt_Cuotas.Name = "txt_Cuotas"
        Me.txt_Cuotas.Size = New System.Drawing.Size(60, 20)
        Me.txt_Cuotas.TabIndex = 64
        '
        'txt_formaDePago
        '
        Me.txt_formaDePago.Location = New System.Drawing.Point(123, 167)
        Me.txt_formaDePago.Name = "txt_formaDePago"
        Me.txt_formaDePago.Size = New System.Drawing.Size(100, 20)
        Me.txt_formaDePago.TabIndex = 63
        '
        'txt_fdeVenc
        '
        Me.txt_fdeVenc.Location = New System.Drawing.Point(664, 138)
        Me.txt_fdeVenc.Name = "txt_fdeVenc"
        Me.txt_fdeVenc.Size = New System.Drawing.Size(100, 20)
        Me.txt_fdeVenc.TabIndex = 62
        '
        'txt_saldo
        '
        Me.txt_saldo.Location = New System.Drawing.Point(478, 138)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(86, 20)
        Me.txt_saldo.TabIndex = 61
        '
        'txt_entrada
        '
        Me.txt_entrada.Location = New System.Drawing.Point(281, 142)
        Me.txt_entrada.Name = "txt_entrada"
        Me.txt_entrada.Size = New System.Drawing.Size(100, 20)
        Me.txt_entrada.TabIndex = 60
        '
        'txt_valorTotal
        '
        Me.txt_valorTotal.Location = New System.Drawing.Point(106, 138)
        Me.txt_valorTotal.Name = "txt_valorTotal"
        Me.txt_valorTotal.Size = New System.Drawing.Size(74, 20)
        Me.txt_valorTotal.TabIndex = 59
        '
        'txt_descripcionArticulo
        '
        Me.txt_descripcionArticulo.Location = New System.Drawing.Point(189, 112)
        Me.txt_descripcionArticulo.Name = "txt_descripcionArticulo"
        Me.txt_descripcionArticulo.Size = New System.Drawing.Size(575, 20)
        Me.txt_descripcionArticulo.TabIndex = 58
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(651, 80)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(113, 20)
        Me.txt_telefono.TabIndex = 57
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(264, 80)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(314, 20)
        Me.txt_direccion.TabIndex = 56
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(642, 52)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(122, 20)
        Me.txt_cedula.TabIndex = 55
        '
        'txt_nombreApellido
        '
        Me.txt_nombreApellido.Location = New System.Drawing.Point(319, 55)
        Me.txt_nombreApellido.Name = "txt_nombreApellido"
        Me.txt_nombreApellido.Size = New System.Drawing.Size(259, 20)
        Me.txt_nombreApellido.TabIndex = 54
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(664, 25)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(601, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "TELF :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(186, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "DIRECCION :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 73)
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(614, 174)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "CADA :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(444, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "DE :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(251, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "CUOTAS :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 174)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 13)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "FORMA DE PAGO :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(584, 145)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "F. DE VENC. :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(423, 145)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "SALDO :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(197, 145)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "ENTRADA :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 145)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 13)
        Me.Label27.TabIndex = 42
        Me.Label27.Text = "VALOR TOTAL :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 119)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(167, 13)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "DESCRIPCION DEL ARTICULO :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(601, 59)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 40
        Me.Label29.Text = "C./Y :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(186, 62)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 13)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "NOMBRE Y APELLIDO :"
        '
        'txt_vendedor
        '
        Me.txt_vendedor.Location = New System.Drawing.Point(478, 25)
        Me.txt_vendedor.Name = "txt_vendedor"
        Me.txt_vendedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_vendedor.TabIndex = 38
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(601, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 13)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "CODIGO :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(398, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 13)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "VENDEDOR :"
        '
        'txt_fdIngreso
        '
        Me.txt_fdIngreso.Location = New System.Drawing.Point(284, 25)
        Me.txt_fdIngreso.Name = "txt_fdIngreso"
        Me.txt_fdIngreso.Size = New System.Drawing.Size(97, 20)
        Me.txt_fdIngreso.TabIndex = 35
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(186, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 13)
        Me.Label33.TabIndex = 34
        Me.Label33.Text = "F. DE INGRESO :"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btnCancelar)
        Me.pnlBotones.Controls.Add(Me.btnAceptar)
        Me.pnlBotones.Enabled = False
        Me.pnlBotones.Location = New System.Drawing.Point(3, 537)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(760, 55)
        Me.pnlBotones.TabIndex = 25
        Me.pnlBotones.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(397, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(225, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 24
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frm_Abono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 697)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.labelFiltrar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_Abono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: Abono ::."
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.DataGridViewAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslIngresar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents labelFiltrar As System.Windows.Forms.Label
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewAbono As System.Windows.Forms.DataGridView
    Friend WithEvents txt_cada As System.Windows.Forms.TextBox
    Friend WithEvents txt_de As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cuotas As System.Windows.Forms.TextBox
    Friend WithEvents txt_formaDePago As System.Windows.Forms.TextBox
    Friend WithEvents txt_fdeVenc As System.Windows.Forms.TextBox
    Friend WithEvents txt_saldo As System.Windows.Forms.TextBox
    Friend WithEvents txt_entrada As System.Windows.Forms.TextBox
    Friend WithEvents txt_valorTotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_cedula As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreApellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_fdIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSaldoRestante As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_letra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents f_de_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImpresion As System.Windows.Forms.DataGridViewButtonColumn
End Class
