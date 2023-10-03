Public Class Calculadora

    Dim primerNumero As Double
    Dim segundoNumero As Double
    Dim resultado As Double
    Dim operador As Char
    Dim banderaResultado As Boolean = False 'Si se carga un resultado la bandera se levanta en True

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCero.Click, BtnUno.Click, BtnDos.Click, BtnTres.Click, BtnCuatro.Click, BtnCinco.Click, BtnSeis.Click, BtnSiete.Click, BtnOcho.Click, BtnNueve.Click, BtnMas.Click, BtnMin.Click, BtnMult.Click, BtnDiv.Click, BtnIgual.Click, BtnLimpiar.Click
        Dim botonPresionado As Button = CType(sender, Button)

        ' Verificar qué botón se presionó y realizar la acción correspondiente
        Select Case botonPresionado.Text
            Case "0"
                If TxtDisplay.Text <> "" OrElse TxtDisplay.Text <> "0" And TxtDisplay.TextLength < 13 Then
                    ' Agregar el dígito al número actual
                    TxtDisplay.Text &= botonPresionado.Text
                End If

            Case "1" To "9"
                If TxtDisplay.Text = "0" Then
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    If banderaResultado = True Then
                        banderaResultado = False
                        TxtDisplay.Clear()
                    End If
                    TxtDisplay.Text &= botonPresionado.Text
                End If

            Case "+", "-", "x", "/"
                    ' Guardar el operador
                    operador = botonPresionado.Text
                    ' Guardar el primer número
                    If TxtDisplay.Text <> "" Then
                        primerNumero = CDbl(TxtDisplay.Text)
                    End If
                    ' Limpiar la caja de texto para ingresar el segundo número
                    TxtDisplay.Clear()
            Case "C"
                    TxtDisplay.Clear()
                    primerNumero = 0
            Case "="
                    If TxtDisplay.Text = "" OrElse TxtDisplay.Text = "Error" Then
                        ' Guardar el segundo número
                        segundoNumero = 0
                    Else
                        segundoNumero = CDbl(TxtDisplay.Text)
                    End If

                    ' Realizar la operación según el operador seleccionado
                    Select Case operador
                        Case "+"
                            resultado = primerNumero + segundoNumero
                        Case "-"
                            resultado = primerNumero - segundoNumero
                        Case "x"
                            resultado = primerNumero * segundoNumero
                        Case "/"
                            ' Verificar la división por cero
                            If segundoNumero <> 0 Then
                                resultado = primerNumero / segundoNumero
                            Else
                                TxtDisplay.Text = "Error"
                                Exit Sub
                            End If
                    End Select
                    ' Mostrar el resultado en la caja de texto
                If resultado < 0 Then
                    'MessageBox.Show("Resultado Negativo")
                    banderaResultado = True
                    TxtDisplay.Text = Math.Abs(resultado) & "-"
                Else
                    banderaResultado = True
                    TxtDisplay.Text = resultado.ToString()
                End If
        End Select
    End Sub

    Private Sub Calculadora_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Dim keyName As String = e.KeyCode.ToString()

        Select Case keyName
            Case "Return"
                If TxtDisplay.Text = "" OrElse TxtDisplay.Text = "Error" Then
                    ' Guardar el segundo número
                    segundoNumero = 0
                Else
                    segundoNumero = CDbl(TxtDisplay.Text)
                End If

                ' Realizar la operación según el operador seleccionado
                Select Case operador
                    Case "+"
                        resultado = primerNumero + segundoNumero
                    Case "-"
                        resultado = primerNumero - segundoNumero
                    Case "*"
                        resultado = primerNumero * segundoNumero
                    Case "/"
                        ' Verificar la división por cero
                        If segundoNumero <> 0 Then
                            resultado = primerNumero / segundoNumero
                        Else
                            TxtDisplay.Text = "Error"
                            Exit Sub
                        End If
                End Select
                ' Mostrar el resultado en la caja de texto
                If resultado < 0 Then
                    'MessageBox.Show("Resultado Negativo")
                    banderaResultado = True
                    TxtDisplay.Text = Math.Abs(resultado) & "-"
                Else
                    banderaResultado = True
                    TxtDisplay.Text = resultado.ToString()
                End If
                BtnIgual.Focus()
            Case "C"
                TxtDisplay.Clear()
                BtnLimpiar.Focus()
            Case "Back"
                TxtDisplay.Clear()
                BtnLimpiar.Focus()
            Case "NumPad0"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.Text <> "" And TxtDisplay.Text <> "0" And TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("0")
                End If
                BtnCero.Focus()
            Case "NumPad1"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("1")
                End If
                BtnUno.Focus()
            Case "NumPad2"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("2")
                End If
                BtnDos.Focus()
            Case "NumPad3"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("3")
                End If
                BtnTres.Focus()
            Case "NumPad4"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("4")
                End If
                BtnCuatro.Focus()
            Case "NumPad5"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("5")
                End If
                BtnCinco.Focus()
            Case "NumPad6"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("6")
                End If
                BtnSeis.Focus()
            Case "NumPad7"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("7")
                End If
                BtnSiete.Focus()
            Case "NumPad8"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("8")
                End If
                BtnOcho.Focus()
            Case "NumPad9"
                If banderaResultado = True Then
                    banderaResultado = False
                    TxtDisplay.Clear()
                End If
                If TxtDisplay.TextLength < 13 Then
                    TxtDisplay.AppendText("9")
                End If
                BtnNueve.Focus()
            Case "Add"
                If TxtDisplay.Text <> "" Then
                    primerNumero = CDbl(TxtDisplay.Text)
                    TxtDisplay.Clear()
                Else
                    primerNumero = 0
                End If
                operador = "+"
                BtnMas.Focus()
            Case "Subtract"
                operador = "-"
                BtnMin.Focus()
            Case "Multiply"
                operador = "*"
                BtnMult.Focus()
            Case "Divide"
                operador = "/"
                BtnDiv.Focus()
        End Select
    End Sub

End Class
