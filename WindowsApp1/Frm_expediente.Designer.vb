<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_expediente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_expediente))
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_agregarExpediente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_buscar.Location = New System.Drawing.Point(117, 61)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(193, 25)
        Me.lbl_buscar.TabIndex = 0
        Me.lbl_buscar.Text = "Buscar Expediente"
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Location = New System.Drawing.Point(363, 58)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(180, 31)
        Me.txt_buscar.TabIndex = 2
        '
        'btn_agregarExpediente
        '
        Me.btn_agregarExpediente.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_agregarExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregarExpediente.Location = New System.Drawing.Point(201, 145)
        Me.btn_agregarExpediente.Name = "btn_agregarExpediente"
        Me.btn_agregarExpediente.Size = New System.Drawing.Size(247, 43)
        Me.btn_agregarExpediente.TabIndex = 3
        Me.btn_agregarExpediente.Text = "Agregar Expediente"
        Me.btn_agregarExpediente.UseVisualStyleBackColor = False
        '
        'Frm_expediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(680, 246)
        Me.Controls.Add(Me.btn_agregarExpediente)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.lbl_buscar)
        Me.Name = "Frm_expediente"
        Me.Text = "Seguimiento de Expediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_buscar As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents btn_agregarExpediente As Button
End Class
