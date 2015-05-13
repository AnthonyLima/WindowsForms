
Public Class frmBloc

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click  'handles especifica que esta ligado al evento btnabrir.click
        dlgAbrir.Filter = "Archivos de texto|*.txt"  'filter es para abrir solo un determinado tipo de archivo
        dlgAbrir.Title = "Abrir archivo"    'el titulo
        dlgAbrir.ShowDialog()  'llamamos accion showdialog
        If (dlgAbrir.FileName <> "") Then   'controla si es un archivo vacio o no selecciono ninguno
            txtEditor.Text = AbrirArchivo(dlgAbrir.FileName)
        End If
    End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		dlgGuardar.Filter = "Archivos de texto|*.txt"
		dlgGuardar.ShowDialog()
		If (dlgGuardar.FileName <> "") Then
			GuardarArchivo(dlgGuardar.FileName, txtEditor.Text)
		End If
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		txtEditor.Clear()
	End Sub

    Private Sub frmBloc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
