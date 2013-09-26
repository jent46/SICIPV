﻿Imports BLL_SICIPV
Imports ENTIDADES
Imports System.Windows.Forms

Public Class frm_IngresarProductoFactura
    Dim mensaje As String = ""
    Dim idProducto As Integer
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            ErrorProvider1.SetError(txtBusqueda, "Este campo no puede estar vacio")
        Else
            ErrorProvider1.Clear()
            dgvBusqueda.Columns.Clear()


            Dim dt As DataTable = Nothing

            Try
                dt = BLL_Producto.ConsultarProductosPorDescripcion(txtBusqueda.Text, mensaje)

                If dt.Rows.Count <> 0 Then
                    dgvBusqueda.DataSource = dt
                    dgvBusqueda.Columns("Id").Visible = False
                End If
            Catch ex As Exception
            End Try


        End If
    End Sub

    Private Sub txtBusqueda_TextKeyUp(sender As Object, e As EventArgs) Handles txtBusqueda.KeyUp
        btnBuscar_Click(Nothing, Nothing)
    End Sub

    Private Sub dgvBusqueda_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusqueda.DoubleClick
        Dim dr As DataGridViewRow = dgvBusqueda.Rows(e.RowIndex)
        Dim dt As DataTable = BLL_Producto.ConsultarProductosPorId(dr.Cells("Id").Value, mensaje)
        Dim prod As New ClsProducto()
        prod.IdProducto = dt.Rows(0)("idProducto")
        prod.Descripcion = dt.Rows(0)("descripcion")
        prod.Pvp = dt.Rows(0)("pvp")
        prod.Stock = dt.Rows(0)("stock")
        prod.Valor = dt.Rows(0)("valor")
        dgvBusqueda.Columns.Clear()
        frm_Facturacion.agregarProducto(prod)
        Me.Hide()

    End Sub
End Class