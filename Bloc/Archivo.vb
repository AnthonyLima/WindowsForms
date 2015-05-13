Imports System.IO
'es las funciones para abrir un archivo
Module Archivo
	Public Function AbrirArchivo(ByVal NombreArchivo As String) As String
		Dim srArchivo As StreamReader
        srArchivo = New StreamReader(NombreArchivo, System.Text.Encoding.Default)  'streamreader para leer archivos parametros(nombre, el tipo de archivo con su codificacion)
        AbrirArchivo = srArchivo.ReadToEnd()  'este readtoend para leer 
	End Function

	Public Sub GuardarArchivo(ByVal NombreArchivo As String, ByVal Contenido As String)
        Dim swArchivo As StreamWriter   'para poder guardar el archivo 
        swArchivo = New StreamWriter(NombreArchivo, False, System.Text.Encoding.Default)  '
        swArchivo.Write(Contenido)  'al final lee y guarda en un texto
		swArchivo.Close()
	End Sub
End Module
