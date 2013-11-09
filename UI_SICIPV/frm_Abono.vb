Imports BLL_SICIPV
Imports ENTIDADES
Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_Abono

    Public usuario As ClsUsuario
    Private idPersona As Integer
    Private operacion As String = ""
    Private mensaje As String = ""
    Private idCuota As Integer
    Private valorFinal As Decimal
    Private comentarioFinal As String = ""



    Private Sub tslIngresar_Click(sender As Object, e As EventArgs) Handles tslIngresar.Click
        txtFiltrar.Visible = True
        labelFiltrar.Visible = True
        btnFiltrar.Visible = True
        gbDatos.Visible = True
        gbDatos.Enabled = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslIngresar.Enabled = False
        operacion = "I"
        labelFiltrar.Visible = True
        txtFiltrar.Visible = True
        txtFiltrar.Enabled = True
        btnFiltrar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If operacion <> "" Then
            ErrorProvider1.Clear()
            gbDatos.Visible = False
            gbDatos.Enabled = False
            pnlBotones.Enabled = False
            pnlBotones.Visible = False
            tslIngresar.Enabled = True
            btnAceptar.Enabled = True
            operacion = ""
            limpiarCampos()

        End If

    End Sub

    Private Sub tslModificar_Click(sender As Object, e As EventArgs)
        gbDatos.Enabled = True
        gbDatos.Visible = True
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        btnAceptar.Enabled = True
        tslIngresar.Enabled = False
        operacion = "M"
    End Sub

    Private Sub tslConsultar_Click(sender As Object, e As EventArgs)
        gbDatos.Visible = False
        gbDatos.Enabled = False
        pnlBotones.Enabled = True
        pnlBotones.Visible = True
        tslIngresar.Enabled = False
        btnAceptar.Enabled = False
        operacion = "C"
    End Sub

    Private Sub limpiarCampos()
        DataGridViewAbono.Rows.Clear() 'Limpia el contenido del datagridview
        txtFiltrar.Text = String.Empty
        txt_fdIngreso.Text = String.Empty
        txt_vendedor.Text = String.Empty
        txt_codigo.Text = String.Empty
        txt_nombreApellido.Text = String.Empty
        txt_cedula.Text = String.Empty
        txt_direccion.Text = String.Empty
        txt_telefono.Text = String.Empty
        txt_descripcionArticulo.Text = String.Empty
        txt_valorTotal.Text = String.Empty
        txt_entrada.Text = String.Empty
        txt_saldo.Text = String.Empty
        txt_fdeVenc.Text = String.Empty
        txt_formaDePago.Text = String.Empty
        txt_Cuotas.Text = String.Empty
        txt_de.Text = String.Empty
        txt_cada.Text = String.Empty
        txtDeuda.Text = String.Empty
        txtTotalAbono.Text = String.Empty
        txtSaldoRestante.Text = String.Empty
        labelFiltrar.Visible = False
        txtFiltrar.Visible = False
        btnFiltrar.Visible = False
    End Sub

    Private Sub frm_Abono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(250, 0, 840, 700)
        txtFiltrar.Visible = False
        labelFiltrar.Visible = False
        btnFiltrar.Visible = False

    End Sub

    Private Sub deshabilitar()
        txt_fdIngreso.Enabled = False
        txt_vendedor.Enabled = False
        txt_codigo.Enabled = False
        txt_nombreApellido.Enabled = False
        txt_cedula.Enabled = False
        txt_direccion.Enabled = False
        txt_telefono.Enabled = False
        txt_descripcionArticulo.Enabled = False
        txt_valorTotal.Enabled = False
        txt_entrada.Enabled = False
        txt_saldo.Enabled = False
        txt_fdeVenc.Enabled = False
        txt_formaDePago.Enabled = False
        txt_Cuotas.Enabled = False
        txt_de.Enabled = False
        txt_cada.Enabled = False

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim dt As DataTable = Nothing
        Dim dtPersona As DataTable = Nothing
        Dim dtCuotaValor As DataTable = Nothing
        Dim dtTipoVenta As DataTable = Nothing
        Dim dataTableDGV As DataTable = Nothing

        If txtFiltrar.Text = "" Then
            ErrorProvider1.SetError(txtFiltrar, "Cedula es requerido")
            ErrorProvider1.Clear()

        Else
            Try
                dt = BLL_Abono.LlenarCartilla(txtFiltrar.Text, mensaje)
                If (dt.Rows.Count = 0) Then 'dt.Rows.Count <> 1
                    MsgBox("No existen cartilla con ese numero de factura", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                    txtFiltrar.Enabled = True
                Else
                    txtFiltrar.Enabled = False

                    dtPersona = BLL_Persona.ConsultarPersonasPorId(dt.Rows(0)("idPersona"), mensaje)
                    dtCuotaValor = BLL_CuotaValor.ConsultarCuotaValorPorId(dt.Rows(0)("idCuotaValor"), mensaje)
                    dtTipoVenta = BLL_Abono.ConsultarTipoVentaPorId(dt.Rows(0)("idTipoVenta"), mensaje)
                    dataTableDGV = BLL_Abono.ConsultarCuotaPorIdFactura(dt.Rows(0)("idFactura"), mensaje)

                    txt_fdIngreso.Text = dt.Rows(0)("fechaDeIngreso")
                    txt_vendedor.Text = dt.Rows(0)("vendedor")
                    txt_codigo.Text = dtPersona.Rows(0)("codigoPersona")
                    txt_nombreApellido.Text = dtPersona.Rows(0)("nombre") + dtPersona.Rows(0)("apellido")
                    txt_cedula.Text = dtPersona.Rows(0)("cedula")
                    txt_direccion.Text = dtPersona.Rows(0)("direccion")
                    txt_telefono.Text = dtPersona.Rows(0)("telefono")
                    txt_descripcionArticulo.Text = dt.Rows(0)("descripcionDelArticulo")
                    txt_valorTotal.Text = Decimal.Round(dt.Rows(0)("valorTotal"), 2)
                    txt_entrada.Text = Decimal.Round(dt.Rows(0)("entrada"), 2)
                    txt_saldo.Text = Decimal.Round(dt.Rows(0)("valorTotal") - dt.Rows(0)("entrada"), 2) 'Saldo
                    txt_fdeVenc.Text = dt.Rows((dt.Rows.Count) - 1)("cada") 'Fecha de la ultima letra del credito
                    txt_formaDePago.Text = dtTipoVenta.Rows(0)("descripcion") 'Forma de pago
                    txt_Cuotas.Text = dtCuotaValor.Rows(0)("cuota")
                    txt_de.Text = Decimal.Round(dt.Rows(0)("de"), 2)
                    txt_cada.Text = dt.Rows(0)("cada")
                    Call deshabilitar()

                    For index = 0 To dataTableDGV.Rows.Count - 1
                        Dim ID = dataTableDGV.Rows(index)("ID")
                        Dim No_LETRA = dataTableDGV.Rows(index)("No_LETRA")
                        Dim F_DE_PAGO As Date = dataTableDGV.Rows(index)("F_DE_PAGO")
                        Dim CUOTA = Decimal.Round(dataTableDGV.Rows(index)("CUOTA"), 2)
                        Dim VALOR As Double
                        Dim DIFERENCIA As Double
                        Dim COMENTARIO As String = ""

                        DataGridViewAbono.Rows.Add(ID, No_LETRA, F_DE_PAGO.ToShortDateString, CUOTA, VALOR, DIFERENCIA, COMENTARIO)
                        DataGridViewAbono.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow
                        DataGridViewAbono.RowsDefaultCellStyle.BackColor = Color.LightCyan

                    Next

                    'DataGridViewAbono.DataSource = dataTableDGV

                    txtDeuda.Text = dtCuotaValor.Rows(0)("cuota") * dt.Rows(0)("de")
                    txtTotalAbono.Text = 0
                    txtSaldoRestante.Text = txtDeuda.Text - txtTotalAbono.Text
                    txtDeuda.Enabled = False
                    txtTotalAbono.Enabled = False
                    txtSaldoRestante.Enabled = False

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
            End Try
        End If
    End Sub

    Private Sub DataGridViewAbono_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbono.CellClick
        Dim dr As DataGridViewRow
        If DataGridViewAbono.Columns(e.ColumnIndex).Name = "btnImpresion" Then
            dr = DataGridViewAbono.Rows(e.RowIndex)
            dr.Cells("VALOR").Value = 0.0
            dr.Cells("COMENTARIO").Value = ""
        End If
    End Sub

    Private Sub DataGridViewAbono_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAbono.CellValueChanged

        If DataGridViewAbono.Rows.Count <> 0 Then 'Preguntamos si el datagridview esta lleno.
            Dim dr As DataGridViewRow = DataGridViewAbono.Rows(e.RowIndex) 'Para capturar la fila en donde se realizo el cambio
            Dim dt As DataTable = BLL_Abono.deshabilitarAbono(dr.Cells("ID").Value, mensaje)
            Dim totalAbonadoPorCuota As Decimal = dt.Rows(0)("totalAbonado")
            Dim cuota As Decimal = Decimal.Round(dr.Cells("CUOTA").Value, 2)
            Dim diferencia As Double = Decimal.Round(dr.Cells("DIFERENCIA").Value, 2)

            If (dr.Cells("COMENTARIO").IsInEditMode) Then 'Indica que se ha cambiado un valor en dicha celda
                comentarioFinal = dr.Cells("COMENTARIO").Value
            End If
            If (dr.Cells("VALOR").IsInEditMode) Then 'Indica que se ha cambiado un valor en dicha celda
                Dim valor As Double = Decimal.Round(dr.Cells("VALOR").Value, 2)

                If (totalAbonadoPorCuota = cuota) Then
                    dr.Cells("VALOR").ReadOnly = True
                    dr.Cells("COMENTARIO").ReadOnly = True
                    dr.DefaultCellStyle.BackColor = Color.Red
                    'DataGridViewAbono.RowsDefaultCellStyle.BackColor = Color.Blue
                End If


                If ((totalAbonadoPorCuota + valor) <= dr.Cells("CUOTA").Value And valor <= cuota And dr.Cells("VALOR").Value <> 0) Then 'validar que no se abone mas de el valor en una cuota
                    'Para llenar el objeto abono ---------------
                    valorFinal = valor
                    idCuota = dr.Cells("ID").Value
                    '-------------------------------------------

                    If (Decimal.TryParse(dr.Cells("VALOR").Value, New Decimal())) Then
                        dr.Cells("DIFERENCIA").Value = cuota - valor
                        txtTotalAbono.Text = txtTotalAbono.Text + valor
                        txtSaldoRestante.Text = txtDeuda.Text - txtTotalAbono.Text
                    Else
                        MsgBox("Tiene que ingresar una cantidad correcta", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                    End If
                Else
                    Dim valorMaximo As String = CStr(cuota - totalAbonadoPorCuota)
                    dr.Cells("VALOR").Value = 0.0
                    MsgBox("La cantidad maxima que puede ingresar en esa cuota es : $" + valorMaximo + ", o tiene que ser diferente de $0.00.", MsgBoxStyle.Information, My.Settings.NOMBREAPP)
                End If
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim abono As ClsAbono = New ClsAbono
        Dim cuota As ClsCuota = New ClsCuota
        abono.IdCuota = New ClsCuota()
        abono.IdCuota.IdCuota = idCuota
        abono.Valor = valorFinal
        abono.Comentario = comentarioFinal
        abono.Fecha = Date.Now
        Select Case operacion
            Case "I"
                abono.IdUsuarioCreacion = usuario
                abono.IdUsuarioModificacion = usuario
                BLL_Abono.ingresarBD(abono, mensaje)
                cuota.Abonos.Add(abono)
                limpiarCampos()
                MsgBox(mensaje, MsgBoxStyle.Information, My.Settings.NOMBREAPP)
        End Select
        Me.Close()
    End Sub
End Class