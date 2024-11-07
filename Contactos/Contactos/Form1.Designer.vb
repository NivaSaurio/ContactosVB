<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNumContacto = New Label()
        lblTipoContacto = New Label()
        lblNombre = New Label()
        lblEmail = New Label()
        lblMovil = New Label()
        lblDireccion = New Label()
        lblPoblacion = New Label()
        txtNumContacto = New TextBox()
        txtNombre = New TextBox()
        txtEmail = New TextBox()
        txtDireccion = New TextBox()
        txtMovil = New TextBox()
        lvContactos = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        cbTipoContacto = New ComboBox()
        cbPoblacion = New ComboBox()
        SuspendLayout()
        ' 
        ' lblNumContacto
        ' 
        lblNumContacto.AutoSize = True
        lblNumContacto.Font = New Font("Segoe UI", 14.0F)
        lblNumContacto.Location = New Point(13, 45)
        lblNumContacto.Margin = New Padding(4, 0, 4, 0)
        lblNumContacto.Name = "lblNumContacto"
        lblNumContacto.Size = New Size(110, 25)
        lblNumContacto.TabIndex = 0
        lblNumContacto.Text = "NºContacto"
        ' 
        ' lblTipoContacto
        ' 
        lblTipoContacto.AutoSize = True
        lblTipoContacto.Font = New Font("Segoe UI", 14.0F)
        lblTipoContacto.Location = New Point(577, 45)
        lblTipoContacto.Margin = New Padding(4, 0, 4, 0)
        lblTipoContacto.Name = "lblTipoContacto"
        lblTipoContacto.Size = New Size(130, 25)
        lblTipoContacto.TabIndex = 1
        lblTipoContacto.Text = "Tipo Contacto"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 14.0F)
        lblNombre.Location = New Point(13, 95)
        lblNombre.Margin = New Padding(4, 0, 4, 0)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(81, 25)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 14.0F)
        lblEmail.Location = New Point(13, 145)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(58, 25)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' lblMovil
        ' 
        lblMovil.AutoSize = True
        lblMovil.Font = New Font("Segoe UI", 14.0F)
        lblMovil.Location = New Point(577, 145)
        lblMovil.Name = "lblMovil"
        lblMovil.Size = New Size(59, 25)
        lblMovil.TabIndex = 4
        lblMovil.Text = "Móvil"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Segoe UI", 14.0F)
        lblDireccion.Location = New Point(13, 195)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(92, 25)
        lblDireccion.TabIndex = 5
        lblDireccion.Text = "Dirección"
        ' 
        ' lblPoblacion
        ' 
        lblPoblacion.AutoSize = True
        lblPoblacion.Font = New Font("Segoe UI", 14.0F)
        lblPoblacion.Location = New Point(577, 195)
        lblPoblacion.Name = "lblPoblacion"
        lblPoblacion.Size = New Size(95, 25)
        lblPoblacion.TabIndex = 6
        lblPoblacion.Text = "Población"
        ' 
        ' txtNumContacto
        ' 
        txtNumContacto.Location = New Point(130, 45)
        txtNumContacto.Name = "txtNumContacto"
        txtNumContacto.Size = New Size(100, 23)
        txtNumContacto.TabIndex = 7
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(130, 95)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(302, 23)
        txtNombre.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(130, 145)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(302, 23)
        txtEmail.TabIndex = 10
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(130, 195)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(302, 23)
        txtDireccion.TabIndex = 11
        ' 
        ' txtMovil
        ' 
        txtMovil.Location = New Point(714, 145)
        txtMovil.Name = "txtMovil"
        txtMovil.Size = New Size(121, 23)
        txtMovil.TabIndex = 12
        ' 
        ' lvContactos
        ' 
        lvContactos.GridLines = True
        lvContactos.Location = New Point(13, 309)
        lvContactos.Name = "lvContactos"
        lvContactos.Size = New Size(1035, 246)
        lvContactos.TabIndex = 14
        lvContactos.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.0F)
        Button1.Location = New Point(306, 247)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 39)
        Button1.TabIndex = 15
        Button1.Text = "ACEPTAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.0F)
        Button2.Location = New Point(466, 247)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 39)
        Button2.TabIndex = 16
        Button2.Text = "CANCELAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14.0F)
        Button3.Location = New Point(637, 247)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 39)
        Button3.TabIndex = 17
        Button3.Text = "SALIR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' cbTipoContacto
        ' 
        cbTipoContacto.FormattingEnabled = True
        cbTipoContacto.Location = New Point(714, 45)
        cbTipoContacto.Name = "cbTipoContacto"
        cbTipoContacto.Size = New Size(121, 23)
        cbTipoContacto.TabIndex = 18
        ' 
        ' cbPoblacion
        ' 
        cbPoblacion.FormattingEnabled = True
        cbPoblacion.Location = New Point(714, 195)
        cbPoblacion.Name = "cbPoblacion"
        cbPoblacion.Size = New Size(121, 23)
        cbPoblacion.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 567)
        Controls.Add(cbPoblacion)
        Controls.Add(cbTipoContacto)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lvContactos)
        Controls.Add(txtMovil)
        Controls.Add(txtDireccion)
        Controls.Add(txtEmail)
        Controls.Add(txtNombre)
        Controls.Add(txtNumContacto)
        Controls.Add(lblPoblacion)
        Controls.Add(lblDireccion)
        Controls.Add(lblMovil)
        Controls.Add(lblEmail)
        Controls.Add(lblNombre)
        Controls.Add(lblTipoContacto)
        Controls.Add(lblNumContacto)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumContacto As Label
    Friend WithEvents lblTipoContacto As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblMovil As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents txtNumContacto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents lvContactos As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cbTipoContacto As ComboBox
    Friend WithEvents cbPoblacion As ComboBox

End Class
