namespace Presentacio
{
    partial class FrmAgregarEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditar));
            this.pnlPrincipal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtDireccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCasa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMovil = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCiudad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellido = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMovil = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCasa = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCiudad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDireccion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPrincipal.BackgroundImage")));
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPrincipal.Controls.Add(this.btnCerrar);
            this.pnlPrincipal.Controls.Add(this.btnGuardar);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.bunifuCards1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlPrincipal.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))));
            this.pnlPrincipal.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlPrincipal.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(81)))));
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Quality = 10;
            this.pnlPrincipal.Size = new System.Drawing.Size(422, 429);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATOS DEL CONTACTO:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(104)))));
            this.bunifuCards1.Controls.Add(this.lblDireccion);
            this.bunifuCards1.Controls.Add(this.lblCiudad);
            this.bunifuCards1.Controls.Add(this.lblEmail);
            this.bunifuCards1.Controls.Add(this.lblCasa);
            this.bunifuCards1.Controls.Add(this.lblMovil);
            this.bunifuCards1.Controls.Add(this.lblApellido);
            this.bunifuCards1.Controls.Add(this.lblNombre);
            this.bunifuCards1.Controls.Add(this.txtCiudad);
            this.bunifuCards1.Controls.Add(this.txtDireccion);
            this.bunifuCards1.Controls.Add(this.txtEmail);
            this.bunifuCards1.Controls.Add(this.txtCasa);
            this.bunifuCards1.Controls.Add(this.txtMovil);
            this.bunifuCards1.Controls.Add(this.txtApellido);
            this.bunifuCards1.Controls.Add(this.txtNombre);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 33);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(398, 325);
            this.bunifuCards1.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDireccion.HintText = "";
            this.txtDireccion.isPassword = false;
            this.txtDireccion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDireccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDireccion.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtDireccion.LineThickness = 3;
            this.txtDireccion.Location = new System.Drawing.Point(11, 249);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(373, 44);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(11, 177);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 44);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Correo Electronico";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtCasa
            // 
            this.txtCasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCasa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCasa.HintForeColor = System.Drawing.Color.Empty;
            this.txtCasa.HintText = "";
            this.txtCasa.isPassword = false;
            this.txtCasa.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCasa.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCasa.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtCasa.LineThickness = 3;
            this.txtCasa.Location = new System.Drawing.Point(206, 99);
            this.txtCasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(178, 44);
            this.txtCasa.TabIndex = 4;
            this.txtCasa.Text = "Tel. Casa";
            this.txtCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCasa_KeyPress);
            // 
            // txtMovil
            // 
            this.txtMovil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMovil.HintForeColor = System.Drawing.Color.Empty;
            this.txtMovil.HintText = "";
            this.txtMovil.isPassword = false;
            this.txtMovil.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMovil.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMovil.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtMovil.LineThickness = 3;
            this.txtMovil.Location = new System.Drawing.Point(11, 99);
            this.txtMovil.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(178, 44);
            this.txtMovil.TabIndex = 3;
            this.txtMovil.Text = "Tel. Movil";
            this.txtMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMovil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMovil_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellido.HintText = "";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtApellido.LineThickness = 3;
            this.txtApellido.Location = new System.Drawing.Point(206, 25);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 44);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(11, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 44);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCiudad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCiudad.HintText = "";
            this.txtCiudad.isPassword = false;
            this.txtCiudad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCiudad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCiudad.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtCiudad.LineThickness = 3;
            this.txtCiudad.Location = new System.Drawing.Point(206, 177);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(178, 44);
            this.txtCiudad.TabIndex = 7;
            this.txtCiudad.Text = "Cuidad";
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(205)))), ((int)(((byte)(41)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(205)))), ((int)(((byte)(41)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(205)))), ((int)(((byte)(41)))));
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(67, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(205)))), ((int)(((byte)(41)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(129)))), ((int)(((byte)(32)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(134, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Activecolor = System.Drawing.Color.Gray;
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.BorderRadius = 7;
            this.btnCerrar.ButtonText = "Cerrar";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Iconimage")));
            this.btnCerrar.Iconimage_right = null;
            this.btnCerrar.Iconimage_right_Selected = null;
            this.btnCerrar.Iconimage_Selected = null;
            this.btnCerrar.IconMarginLeft = 0;
            this.btnCerrar.IconMarginRight = 0;
            this.btnCerrar.IconRightVisible = true;
            this.btnCerrar.IconRightZoom = 0D;
            this.btnCerrar.IconVisible = true;
            this.btnCerrar.IconZoom = 90D;
            this.btnCerrar.IsTab = false;
            this.btnCerrar.Location = new System.Drawing.Point(218, 373);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Normalcolor = System.Drawing.Color.Gray;
            this.btnCerrar.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrar.selected = false;
            this.btnCerrar.Size = new System.Drawing.Size(134, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Textcolor = System.Drawing.Color.White;
            this.btnCerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(6, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(203, 14);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(53, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Visible = false;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovil.Location = new System.Drawing.Point(7, 91);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(58, 13);
            this.lblMovil.TabIndex = 10;
            this.lblMovil.Text = "Tel. Movil:";
            this.lblMovil.Visible = false;
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa.ForeColor = System.Drawing.Color.DimGray;
            this.lblCasa.Location = new System.Drawing.Point(203, 91);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(51, 13);
            this.lblCasa.TabIndex = 11;
            this.lblCasa.Text = "Tel. Casa";
            this.lblCasa.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(7, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Corre Electronico:";
            this.lblEmail.Visible = false;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.DimGray;
            this.lblCiudad.Location = new System.Drawing.Point(203, 169);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(47, 13);
            this.lblCiudad.TabIndex = 13;
            this.lblCiudad.Text = "Ciudad:";
            this.lblCiudad.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDireccion.Location = new System.Drawing.Point(7, 245);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion:";
            this.lblDireccion.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlPrincipal;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmAgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 429);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmAgregarEditar_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlPrincipal;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiudad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDireccion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCasa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMovil;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDireccion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCiudad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCasa;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMovil;
        private Bunifu.Framework.UI.BunifuCustomLabel lblApellido;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}