namespace Presentacio
{
    partial class frmAgenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlContenedor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEncabezado.BackgroundImage")));
            this.pnlEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEncabezado.Controls.Add(this.btnCerrar);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlEncabezado.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnlEncabezado.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlEncabezado.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Quality = 10;
            this.pnlEncabezado.Size = new System.Drawing.Size(859, 31);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(827, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(3, 5);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(236, 25);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "AGENDA DE CONTACTOS";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlEncabezado;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenedor.Controls.Add(this.btnEliminar);
            this.pnlContenedor.Controls.Add(this.btnEditar);
            this.pnlContenedor.Controls.Add(this.label9);
            this.pnlContenedor.Controls.Add(this.label8);
            this.pnlContenedor.Controls.Add(this.label7);
            this.pnlContenedor.Controls.Add(this.label6);
            this.pnlContenedor.Controls.Add(this.label5);
            this.pnlContenedor.Controls.Add(this.label4);
            this.pnlContenedor.Controls.Add(this.label3);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.btnNuevo);
            this.pnlContenedor.Controls.Add(this.txtFiltro);
            this.pnlContenedor.Controls.Add(this.cboFiltro);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.dgvContactos);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlContenedor.GradientBottomRight = System.Drawing.Color.White;
            this.pnlContenedor.GradientTopLeft = System.Drawing.Color.White;
            this.pnlContenedor.GradientTopRight = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 31);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Quality = 10;
            this.pnlContenedor.Size = new System.Drawing.Size(859, 500);
            this.pnlContenedor.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(731, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(116, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 7;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(595, 453);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(116, 35);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(706, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "CIUDAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(558, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "DIRECCION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(423, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-MAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(336, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "TEL. CASA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(252, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TEL. MOVIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(169, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(92, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "COD";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.BorderRadius = 7;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 90D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(459, 453);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(116, 35);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltro.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.HintText = "";
            this.txtFiltro.isPassword = false;
            this.txtFiltro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(124)))));
            this.txtFiltro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFiltro.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtFiltro.LineThickness = 4;
            this.txtFiltro.Location = new System.Drawing.Point(19, 8);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(183, 38);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.Text = "Buscar";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltro.OnValueChanged += new System.EventHandler(this.txtFiltro_OnValueChanged);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboFiltro
            // 
            this.cboFiltro.BackColor = System.Drawing.Color.White;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "NOMBRE",
            "APELLIDO",
            "TELEFONO"});
            this.cboFiltro.Location = new System.Drawing.Point(328, 21);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(129, 25);
            this.cboFiltro.TabIndex = 3;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FILTRAR POR:";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContactos.BackgroundColor = System.Drawing.Color.White;
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvContactos.Location = new System.Drawing.Point(19, 97);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvContactos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            this.dgvContactos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(828, 327);
            this.dgvContactos.TabIndex = 1;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 531);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlEncabezado;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblEncabezado;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlContenedor;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltro;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
    }
}

