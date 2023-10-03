<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtDisplay = New System.Windows.Forms.RichTextBox()
        Me.BtnSiete = New System.Windows.Forms.Button()
        Me.BtnOcho = New System.Windows.Forms.Button()
        Me.BtnNueve = New System.Windows.Forms.Button()
        Me.BtnMas = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnSeis = New System.Windows.Forms.Button()
        Me.BtnCinco = New System.Windows.Forms.Button()
        Me.BtnCuatro = New System.Windows.Forms.Button()
        Me.BtnMult = New System.Windows.Forms.Button()
        Me.BtnTres = New System.Windows.Forms.Button()
        Me.BtnDos = New System.Windows.Forms.Button()
        Me.BtnUno = New System.Windows.Forms.Button()
        Me.BtnDiv = New System.Windows.Forms.Button()
        Me.BtnIgual = New System.Windows.Forms.Button()
        Me.BtnCero = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtDisplay
        '
        Me.TxtDisplay.BackColor = System.Drawing.Color.White
        Me.TxtDisplay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisplay.Location = New System.Drawing.Point(12, 12)
        Me.TxtDisplay.MaxLength = 16
        Me.TxtDisplay.Multiline = False
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TxtDisplay.Size = New System.Drawing.Size(378, 128)
        Me.TxtDisplay.TabIndex = 0
        Me.TxtDisplay.TabStop = False
        Me.TxtDisplay.Text = ""
        '
        'BtnSiete
        '
        Me.BtnSiete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiete.Location = New System.Drawing.Point(12, 146)
        Me.BtnSiete.Name = "BtnSiete"
        Me.BtnSiete.Size = New System.Drawing.Size(90, 90)
        Me.BtnSiete.TabIndex = 0
        Me.BtnSiete.TabStop = False
        Me.BtnSiete.Text = "7"
        Me.BtnSiete.UseVisualStyleBackColor = True
        '
        'BtnOcho
        '
        Me.BtnOcho.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOcho.Location = New System.Drawing.Point(108, 146)
        Me.BtnOcho.Name = "BtnOcho"
        Me.BtnOcho.Size = New System.Drawing.Size(90, 90)
        Me.BtnOcho.TabIndex = 0
        Me.BtnOcho.TabStop = False
        Me.BtnOcho.Text = "8"
        Me.BtnOcho.UseVisualStyleBackColor = True
        '
        'BtnNueve
        '
        Me.BtnNueve.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNueve.Location = New System.Drawing.Point(204, 146)
        Me.BtnNueve.Name = "BtnNueve"
        Me.BtnNueve.Size = New System.Drawing.Size(90, 90)
        Me.BtnNueve.TabIndex = 0
        Me.BtnNueve.TabStop = False
        Me.BtnNueve.Text = "9"
        Me.BtnNueve.UseVisualStyleBackColor = True
        '
        'BtnMas
        '
        Me.BtnMas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMas.Location = New System.Drawing.Point(300, 146)
        Me.BtnMas.Name = "BtnMas"
        Me.BtnMas.Size = New System.Drawing.Size(90, 90)
        Me.BtnMas.TabIndex = 0
        Me.BtnMas.TabStop = False
        Me.BtnMas.Text = "+"
        Me.BtnMas.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMin.Location = New System.Drawing.Point(300, 242)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(90, 90)
        Me.BtnMin.TabIndex = 0
        Me.BtnMin.TabStop = False
        Me.BtnMin.Text = "-"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnSeis
        '
        Me.BtnSeis.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeis.Location = New System.Drawing.Point(204, 242)
        Me.BtnSeis.Name = "BtnSeis"
        Me.BtnSeis.Size = New System.Drawing.Size(90, 90)
        Me.BtnSeis.TabIndex = 0
        Me.BtnSeis.TabStop = False
        Me.BtnSeis.Text = "6"
        Me.BtnSeis.UseVisualStyleBackColor = True
        '
        'BtnCinco
        '
        Me.BtnCinco.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCinco.Location = New System.Drawing.Point(108, 242)
        Me.BtnCinco.Name = "BtnCinco"
        Me.BtnCinco.Size = New System.Drawing.Size(90, 90)
        Me.BtnCinco.TabIndex = 0
        Me.BtnCinco.TabStop = False
        Me.BtnCinco.Text = "5"
        Me.BtnCinco.UseVisualStyleBackColor = True
        '
        'BtnCuatro
        '
        Me.BtnCuatro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuatro.Location = New System.Drawing.Point(12, 242)
        Me.BtnCuatro.Name = "BtnCuatro"
        Me.BtnCuatro.Size = New System.Drawing.Size(90, 90)
        Me.BtnCuatro.TabIndex = 0
        Me.BtnCuatro.TabStop = False
        Me.BtnCuatro.Text = "4"
        Me.BtnCuatro.UseVisualStyleBackColor = True
        '
        'BtnMult
        '
        Me.BtnMult.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMult.Location = New System.Drawing.Point(300, 338)
        Me.BtnMult.Name = "BtnMult"
        Me.BtnMult.Size = New System.Drawing.Size(90, 90)
        Me.BtnMult.TabIndex = 0
        Me.BtnMult.TabStop = False
        Me.BtnMult.Text = "x"
        Me.BtnMult.UseVisualStyleBackColor = True
        '
        'BtnTres
        '
        Me.BtnTres.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTres.Location = New System.Drawing.Point(204, 338)
        Me.BtnTres.Name = "BtnTres"
        Me.BtnTres.Size = New System.Drawing.Size(90, 90)
        Me.BtnTres.TabIndex = 0
        Me.BtnTres.TabStop = False
        Me.BtnTres.Text = "3"
        Me.BtnTres.UseVisualStyleBackColor = True
        '
        'BtnDos
        '
        Me.BtnDos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDos.Location = New System.Drawing.Point(108, 338)
        Me.BtnDos.Name = "BtnDos"
        Me.BtnDos.Size = New System.Drawing.Size(90, 90)
        Me.BtnDos.TabIndex = 0
        Me.BtnDos.TabStop = False
        Me.BtnDos.Text = "2"
        Me.BtnDos.UseVisualStyleBackColor = True
        '
        'BtnUno
        '
        Me.BtnUno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUno.Location = New System.Drawing.Point(12, 338)
        Me.BtnUno.Name = "BtnUno"
        Me.BtnUno.Size = New System.Drawing.Size(90, 90)
        Me.BtnUno.TabIndex = 0
        Me.BtnUno.TabStop = False
        Me.BtnUno.Text = "1"
        Me.BtnUno.UseVisualStyleBackColor = True
        '
        'BtnDiv
        '
        Me.BtnDiv.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiv.Location = New System.Drawing.Point(300, 434)
        Me.BtnDiv.Name = "BtnDiv"
        Me.BtnDiv.Size = New System.Drawing.Size(90, 90)
        Me.BtnDiv.TabIndex = 0
        Me.BtnDiv.TabStop = False
        Me.BtnDiv.Text = "/"
        Me.BtnDiv.UseVisualStyleBackColor = True
        '
        'BtnIgual
        '
        Me.BtnIgual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIgual.Location = New System.Drawing.Point(204, 434)
        Me.BtnIgual.Name = "BtnIgual"
        Me.BtnIgual.Size = New System.Drawing.Size(90, 90)
        Me.BtnIgual.TabIndex = 1
        Me.BtnIgual.TabStop = False
        Me.BtnIgual.Text = "="
        Me.BtnIgual.UseVisualStyleBackColor = True
        '
        'BtnCero
        '
        Me.BtnCero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCero.Location = New System.Drawing.Point(108, 434)
        Me.BtnCero.Name = "BtnCero"
        Me.BtnCero.Size = New System.Drawing.Size(90, 90)
        Me.BtnCero.TabIndex = 0
        Me.BtnCero.TabStop = False
        Me.BtnCero.Text = "0"
        Me.BtnCero.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Red
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(12, 434)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(90, 90)
        Me.BtnLimpiar.TabIndex = 0
        Me.BtnLimpiar.TabStop = False
        Me.BtnLimpiar.Text = "C"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 533)
        Me.Controls.Add(Me.BtnDiv)
        Me.Controls.Add(Me.BtnIgual)
        Me.Controls.Add(Me.BtnCero)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnMult)
        Me.Controls.Add(Me.BtnTres)
        Me.Controls.Add(Me.BtnDos)
        Me.Controls.Add(Me.BtnUno)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnSeis)
        Me.Controls.Add(Me.BtnCinco)
        Me.Controls.Add(Me.BtnCuatro)
        Me.Controls.Add(Me.BtnMas)
        Me.Controls.Add(Me.BtnNueve)
        Me.Controls.Add(Me.BtnOcho)
        Me.Controls.Add(Me.BtnSiete)
        Me.Controls.Add(Me.TxtDisplay)
        Me.KeyPreview = True
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnSiete As System.Windows.Forms.Button
    Friend WithEvents BtnOcho As System.Windows.Forms.Button
    Friend WithEvents BtnNueve As System.Windows.Forms.Button
    Friend WithEvents BtnMas As System.Windows.Forms.Button
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnSeis As System.Windows.Forms.Button
    Friend WithEvents BtnCinco As System.Windows.Forms.Button
    Friend WithEvents BtnCuatro As System.Windows.Forms.Button
    Friend WithEvents BtnMult As System.Windows.Forms.Button
    Friend WithEvents BtnTres As System.Windows.Forms.Button
    Friend WithEvents BtnDos As System.Windows.Forms.Button
    Friend WithEvents BtnUno As System.Windows.Forms.Button
    Friend WithEvents BtnDiv As System.Windows.Forms.Button
    Friend WithEvents BtnIgual As System.Windows.Forms.Button
    Friend WithEvents BtnCero As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button

End Class
