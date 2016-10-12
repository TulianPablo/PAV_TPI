Public Class Colores
    Dim verde As Color
    Dim gris As Color

    'PARA MODIFICAR EL COLOR DE LOS BOTONES CUANDO ESTAN DESHABILITADOS
    Public Shared Function GetVerdeAgua() As Color
        Dim verdeAgua As New Color()
        verdeAgua = Color.FromArgb(0, 192, 192)
        Return verdeAgua
    End Function

    Public Shared Function GetGris() As Color
        Dim gris As New Color()
        gris = Color.FromArgb(222, 222, 222)
        Return gris
    End Function

    Public Shared Sub ChangeColor(btn As Button)
        If (btn.Enabled = False) Then
            btn.BackColor = Colores.GetGris
            btn.ForeColor = Colores.GetGris
        Else
            btn.BackColor = Color.White
            btn.ForeColor = Colores.GetVerdeAgua
        End If
    End Sub
End Class
