<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Logeo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Logeo))
        Me.btn_ingresaar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contrase = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ingresaar
        '
        Me.btn_ingresaar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresaar.Location = New System.Drawing.Point(476, 88)
        Me.btn_ingresaar.Name = "btn_ingresaar"
        Me.btn_ingresaar.Size = New System.Drawing.Size(185, 45)
        Me.btn_ingresaar.TabIndex = 0
        Me.btn_ingresaar.Text = "Ingresar"
        Me.btn_ingresaar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(314, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 31)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(314, 150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 31)
        Me.TextBox2.TabIndex = 2
        '
        'btn_crear
        '
        Me.btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear.Location = New System.Drawing.Point(476, 139)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(185, 49)
        Me.btn_crear.TabIndex = 3
        Me.btn_crear.Text = "Crear nuevo Usuario"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.White
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(185, 24)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(460, 39)
        Me.lbl_titulo.TabIndex = 4
        Me.lbl_titulo.Text = "Seguimiento de expediente"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.GhostWhite
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(210, 102)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(96, 29)
        Me.lbl_usuario.TabIndex = 5
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_contrase
        '
        Me.lbl_contrase.AutoSize = True
        Me.lbl_contrase.BackColor = System.Drawing.Color.Lavender
        Me.lbl_contrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contrase.Location = New System.Drawing.Point(170, 152)
        Me.lbl_contrase.Name = "lbl_contrase"
        Me.lbl_contrase.Size = New System.Drawing.Size(136, 29)
        Me.lbl_contrase.TabIndex = 6
        Me.lbl_contrase.Text = "Contraseña"
        '
        'frm_Logeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 237)
        Me.Controls.Add(Me.lbl_contrase)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_ingresaar)
        Me.Name = "frm_Logeo"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ingresaar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_crear As Button
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contrase As Label
End Class
