namespace Formularios
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.picLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabProductos = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblMsgProductoEliminado = new System.Windows.Forms.Label();
            this.btnBorrarProductos = new MetroFramework.Controls.MetroButton();
            this.lblMsgErrorAgregarProducto = new System.Windows.Forms.Label();
            this.lblMsgProductoAñadido = new System.Windows.Forms.Label();
            this.btnAnadirProducto = new MetroFramework.Controls.MetroButton();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.lblBuscarPor = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.lblMedida = new MetroFramework.Controls.MetroLabel();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblTipoProducto = new MetroFramework.Controls.MetroLabel();
            this.cboMedida = new MetroFramework.Controls.MetroComboBox();
            this.cboCategoria = new MetroFramework.Controls.MetroComboBox();
            this.btnExportarExcel = new MetroFramework.Controls.MetroButton();
            this.cboTipoProducto = new MetroFramework.Controls.MetroComboBox();
            this.pnlOpcionesBusqueda = new MetroFramework.Controls.MetroPanel();
            this.rdbTipoProducto = new MetroFramework.Controls.MetroRadioButton();
            this.rdbCategoria = new MetroFramework.Controls.MetroRadioButton();
            this.rdbMedida = new MetroFramework.Controls.MetroRadioButton();
            this.rdbDescripcion = new MetroFramework.Controls.MetroRadioButton();
            this.lblBuscar = new MetroFramework.Controls.MetroLabel();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.tabAdministrar = new MetroFramework.Controls.MetroTabPage();
            this.tabAdministrarDatos = new MetroFramework.Controls.MetroTabControl();
            this.tabAdministrarDatosEmpresa = new MetroFramework.Controls.MetroTabPage();
            this.lblMsgNoLogueadoDatos = new MetroFramework.Controls.MetroLabel();
            this.grbAjustesEmpresa = new System.Windows.Forms.GroupBox();
            this.lblAjustesAceptados = new System.Windows.Forms.Label();
            this.btnAceptarAjustes = new MetroFramework.Controls.MetroButton();
            this.picLogoAjustes = new System.Windows.Forms.PictureBox();
            this.btnPickLogo = new System.Windows.Forms.Button();
            this.chkContrasenaAjustes = new System.Windows.Forms.CheckBox();
            this.txtContrasenaAjustes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabAdministrarProductos = new MetroFramework.Controls.MetroTabPage();
            this.lblMsgNoLogueadoProductos = new MetroFramework.Controls.MetroLabel();
            this.grbAjustesProductos = new System.Windows.Forms.GroupBox();
            this.lblMsgMedidaAgregada = new System.Windows.Forms.Label();
            this.btnEliminarMedida = new MetroFramework.Controls.MetroButton();
            this.txtAgregarMedida = new MetroFramework.Controls.MetroTextBox();
            this.cboAdministrarMedida = new MetroFramework.Controls.MetroComboBox();
            this.lblAdministrarMedida = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarMedida = new MetroFramework.Controls.MetroButton();
            this.lblMsgCategoriaAgregada = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new MetroFramework.Controls.MetroButton();
            this.txtAgregarCategoria = new MetroFramework.Controls.MetroTextBox();
            this.cboAdministrarCategoria = new MetroFramework.Controls.MetroComboBox();
            this.lblAdministrarCategoria = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarCategoria = new MetroFramework.Controls.MetroButton();
            this.lblMsgTipoProductoAgregado = new System.Windows.Forms.Label();
            this.btnEliminarTipoProducto = new MetroFramework.Controls.MetroButton();
            this.txtAgregarTipoProducto = new MetroFramework.Controls.MetroTextBox();
            this.cboAdministrarTipoProducto = new MetroFramework.Controls.MetroComboBox();
            this.lblAdministrarTipoProducto = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarTipoProducto = new MetroFramework.Controls.MetroButton();
            this.chkContrasena = new System.Windows.Forms.CheckBox();
            this.txtContrasenaLogin = new System.Windows.Forms.TextBox();
            this.btnAceptarContrasena = new MetroFramework.Controls.MetroButton();
            this.lblContrasenaLogin = new MetroFramework.Controls.MetroLabel();
            this.lblErrorContrasena = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.lblCerrarSesion = new MetroFramework.Controls.MetroLabel();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.pnlOpcionesBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabAdministrar.SuspendLayout();
            this.tabAdministrarDatos.SuspendLayout();
            this.tabAdministrarDatosEmpresa.SuspendLayout();
            this.grbAjustesEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAjustes)).BeginInit();
            this.tabAdministrarProductos.SuspendLayout();
            this.grbAjustesProductos.SuspendLayout();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoEmpresa
            // 
            this.picLogoEmpresa.Location = new System.Drawing.Point(342, 29);
            this.picLogoEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.picLogoEmpresa.MaximumSize = new System.Drawing.Size(400, 150);
            this.picLogoEmpresa.Name = "picLogoEmpresa";
            this.picLogoEmpresa.Size = new System.Drawing.Size(301, 150);
            this.picLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoEmpresa.TabIndex = 2;
            this.picLogoEmpresa.TabStop = false;
            this.picLogoEmpresa.WaitOnLoad = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProductos);
            this.tabControl.Controls.Add(this.tabAdministrar);
            this.tabControl.Location = new System.Drawing.Point(101, 184);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1052, 493);
            this.tabControl.TabIndex = 5;
            this.tabControl.UseSelectable = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.metroLabel1);
            this.tabProductos.Controls.Add(this.lblMsgProductoEliminado);
            this.tabProductos.Controls.Add(this.btnBorrarProductos);
            this.tabProductos.Controls.Add(this.lblMsgErrorAgregarProducto);
            this.tabProductos.Controls.Add(this.lblMsgProductoAñadido);
            this.tabProductos.Controls.Add(this.btnAnadirProducto);
            this.tabProductos.Controls.Add(this.txtDescripcion);
            this.tabProductos.Controls.Add(this.txtStock);
            this.tabProductos.Controls.Add(this.txtPrecio);
            this.tabProductos.Controls.Add(this.lblDescripcion);
            this.tabProductos.Controls.Add(this.lblStock);
            this.tabProductos.Controls.Add(this.lblPrecio);
            this.tabProductos.Controls.Add(this.lblBuscarPor);
            this.tabProductos.Controls.Add(this.btnBuscar);
            this.tabProductos.Controls.Add(this.lblMedida);
            this.tabProductos.Controls.Add(this.lblCategoria);
            this.tabProductos.Controls.Add(this.lblTipoProducto);
            this.tabProductos.Controls.Add(this.cboMedida);
            this.tabProductos.Controls.Add(this.cboCategoria);
            this.tabProductos.Controls.Add(this.btnExportarExcel);
            this.tabProductos.Controls.Add(this.cboTipoProducto);
            this.tabProductos.Controls.Add(this.pnlOpcionesBusqueda);
            this.tabProductos.Controls.Add(this.lblBuscar);
            this.tabProductos.Controls.Add(this.txtBuscar);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.HorizontalScrollbarBarColor = true;
            this.tabProductos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProductos.HorizontalScrollbarSize = 10;
            this.tabProductos.Location = new System.Drawing.Point(4, 38);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(1044, 451);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "Productos";
            this.tabProductos.VerticalScrollbarBarColor = true;
            this.tabProductos.VerticalScrollbarHighlightOnWheel = false;
            this.tabProductos.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(822, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(222, 15);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "(Por trozo de texto, blanco muestra todos)";
            // 
            // lblMsgProductoEliminado
            // 
            this.lblMsgProductoEliminado.AutoSize = true;
            this.lblMsgProductoEliminado.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgProductoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMsgProductoEliminado.ForeColor = System.Drawing.Color.Green;
            this.lblMsgProductoEliminado.Location = new System.Drawing.Point(318, 433);
            this.lblMsgProductoEliminado.Name = "lblMsgProductoEliminado";
            this.lblMsgProductoEliminado.Size = new System.Drawing.Size(208, 15);
            this.lblMsgProductoEliminado.TabIndex = 35;
            this.lblMsgProductoEliminado.Text = "Productos eliminados correctamente";
            this.lblMsgProductoEliminado.Visible = false;
            // 
            // btnBorrarProductos
            // 
            this.btnBorrarProductos.Location = new System.Drawing.Point(131, 419);
            this.btnBorrarProductos.Name = "btnBorrarProductos";
            this.btnBorrarProductos.Size = new System.Drawing.Size(181, 29);
            this.btnBorrarProductos.TabIndex = 34;
            this.btnBorrarProductos.Text = "Borrar productos seleccionados";
            this.btnBorrarProductos.UseSelectable = true;
            this.btnBorrarProductos.Visible = false;
            this.btnBorrarProductos.Click += new System.EventHandler(this.BtnBorrarProductos_Click);
            // 
            // lblMsgErrorAgregarProducto
            // 
            this.lblMsgErrorAgregarProducto.AutoSize = true;
            this.lblMsgErrorAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgErrorAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgErrorAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMsgErrorAgregarProducto.Location = new System.Drawing.Point(694, 394);
            this.lblMsgErrorAgregarProducto.Name = "lblMsgErrorAgregarProducto";
            this.lblMsgErrorAgregarProducto.Size = new System.Drawing.Size(149, 15);
            this.lblMsgErrorAgregarProducto.TabIndex = 33;
            this.lblMsgErrorAgregarProducto.Text = "Rellena todos los campos";
            this.lblMsgErrorAgregarProducto.Visible = false;
            // 
            // lblMsgProductoAñadido
            // 
            this.lblMsgProductoAñadido.AutoSize = true;
            this.lblMsgProductoAñadido.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgProductoAñadido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMsgProductoAñadido.ForeColor = System.Drawing.Color.Green;
            this.lblMsgProductoAñadido.Location = new System.Drawing.Point(694, 379);
            this.lblMsgProductoAñadido.Name = "lblMsgProductoAñadido";
            this.lblMsgProductoAñadido.Size = new System.Drawing.Size(186, 15);
            this.lblMsgProductoAñadido.TabIndex = 32;
            this.lblMsgProductoAñadido.Text = "Producto añadido correctamente";
            this.lblMsgProductoAñadido.Visible = false;
            // 
            // btnAnadirProducto
            // 
            this.btnAnadirProducto.Location = new System.Drawing.Point(921, 379);
            this.btnAnadirProducto.Name = "btnAnadirProducto";
            this.btnAnadirProducto.Size = new System.Drawing.Size(110, 30);
            this.btnAnadirProducto.TabIndex = 31;
            this.btnAnadirProducto.Text = "&Añadir producto";
            this.btnAnadirProducto.UseSelectable = true;
            this.btnAnadirProducto.Click += new System.EventHandler(this.BtnAnadirProducto_Click);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(705, 347);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(213, 23);
            this.txtDescripcion.TabIndex = 30;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(977, 347);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(40, 23);
            this.txtStock.TabIndex = 29;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(22, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(924, 347);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(44, 23);
            this.txtPrecio.TabIndex = 28;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(701, 325);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(977, 325);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(40, 19);
            this.lblStock.TabIndex = 26;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(919, 325);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBuscarPor.Location = new System.Drawing.Point(691, 160);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(103, 25);
            this.lblBuscarPor.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblBuscarPor.TabIndex = 24;
            this.lblBuscarPor.Text = "Buscar por...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(797, 262);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 31);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(963, 192);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(54, 19);
            this.lblMedida.TabIndex = 22;
            this.lblMedida.Text = "Medida";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(835, 192);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(697, 192);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(112, 19);
            this.lblTipoProducto.TabIndex = 11;
            this.lblTipoProducto.Text = "Tipo de producto";
            // 
            // cboMedida
            // 
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.ItemHeight = 23;
            this.cboMedida.Location = new System.Drawing.Point(966, 214);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(65, 29);
            this.cboMedida.TabIndex = 10;
            this.cboMedida.UseSelectable = true;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.ItemHeight = 23;
            this.cboCategoria.Location = new System.Drawing.Point(835, 214);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 29);
            this.cboCategoria.TabIndex = 9;
            this.cboCategoria.UseSelectable = true;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(0, 419);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(106, 29);
            this.btnExportarExcel.TabIndex = 8;
            this.btnExportarExcel.Text = "&Exportar a Excel";
            this.btnExportarExcel.UseSelectable = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.ItemHeight = 23;
            this.cboTipoProducto.Location = new System.Drawing.Point(697, 214);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(121, 29);
            this.cboTipoProducto.TabIndex = 7;
            this.cboTipoProducto.UseSelectable = true;
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.CboTipoProducto_SelectedIndexChanged);
            // 
            // pnlOpcionesBusqueda
            // 
            this.pnlOpcionesBusqueda.Controls.Add(this.rdbTipoProducto);
            this.pnlOpcionesBusqueda.Controls.Add(this.rdbCategoria);
            this.pnlOpcionesBusqueda.Controls.Add(this.rdbMedida);
            this.pnlOpcionesBusqueda.Controls.Add(this.rdbDescripcion);
            this.pnlOpcionesBusqueda.HorizontalScrollbarBarColor = true;
            this.pnlOpcionesBusqueda.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlOpcionesBusqueda.HorizontalScrollbarSize = 10;
            this.pnlOpcionesBusqueda.Location = new System.Drawing.Point(691, 33);
            this.pnlOpcionesBusqueda.Name = "pnlOpcionesBusqueda";
            this.pnlOpcionesBusqueda.Size = new System.Drawing.Size(147, 98);
            this.pnlOpcionesBusqueda.TabIndex = 6;
            this.pnlOpcionesBusqueda.VerticalScrollbarBarColor = true;
            this.pnlOpcionesBusqueda.VerticalScrollbarHighlightOnWheel = false;
            this.pnlOpcionesBusqueda.VerticalScrollbarSize = 10;
            // 
            // rdbTipoProducto
            // 
            this.rdbTipoProducto.AutoSize = true;
            this.rdbTipoProducto.Checked = true;
            this.rdbTipoProducto.Location = new System.Drawing.Point(10, 10);
            this.rdbTipoProducto.Name = "rdbTipoProducto";
            this.rdbTipoProducto.Size = new System.Drawing.Size(114, 15);
            this.rdbTipoProducto.TabIndex = 8;
            this.rdbTipoProducto.TabStop = true;
            this.rdbTipoProducto.Text = "Tipo de producto";
            this.rdbTipoProducto.UseSelectable = true;
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(10, 31);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(74, 15);
            this.rdbCategoria.TabIndex = 7;
            this.rdbCategoria.Text = "Categoría";
            this.rdbCategoria.UseSelectable = true;
            // 
            // rdbMedida
            // 
            this.rdbMedida.AutoSize = true;
            this.rdbMedida.Location = new System.Drawing.Point(10, 74);
            this.rdbMedida.Name = "rdbMedida";
            this.rdbMedida.Size = new System.Drawing.Size(63, 15);
            this.rdbMedida.TabIndex = 6;
            this.rdbMedida.Text = "Medida";
            this.rdbMedida.UseSelectable = true;
            // 
            // rdbDescripcion
            // 
            this.rdbDescripcion.AutoSize = true;
            this.rdbDescripcion.Location = new System.Drawing.Point(10, 52);
            this.rdbDescripcion.Name = "rdbDescripcion";
            this.rdbDescripcion.Size = new System.Drawing.Size(85, 15);
            this.rdbDescripcion.TabIndex = 5;
            this.rdbDescripcion.Text = "Descripción";
            this.rdbDescripcion.UseSelectable = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBuscar.Location = new System.Drawing.Point(688, 5);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(140, 25);
            this.lblBuscar.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Búsqueda rápida";
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(844, 64);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(196, 23);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProductos.Location = new System.Drawing.Point(3, 16);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(660, 397);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.DgvProductos_SelectionChanged);
            // 
            // tabAdministrar
            // 
            this.tabAdministrar.Controls.Add(this.tabAdministrarDatos);
            this.tabAdministrar.HorizontalScrollbarBarColor = true;
            this.tabAdministrar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdministrar.HorizontalScrollbarSize = 10;
            this.tabAdministrar.Location = new System.Drawing.Point(4, 38);
            this.tabAdministrar.Name = "tabAdministrar";
            this.tabAdministrar.Size = new System.Drawing.Size(1044, 451);
            this.tabAdministrar.TabIndex = 2;
            this.tabAdministrar.Text = "Administrar";
            this.tabAdministrar.VerticalScrollbarBarColor = true;
            this.tabAdministrar.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdministrar.VerticalScrollbarSize = 10;
            // 
            // tabAdministrarDatos
            // 
            this.tabAdministrarDatos.Controls.Add(this.tabAdministrarDatosEmpresa);
            this.tabAdministrarDatos.Controls.Add(this.tabAdministrarProductos);
            this.tabAdministrarDatos.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabAdministrarDatos.Location = new System.Drawing.Point(5, -3);
            this.tabAdministrarDatos.Name = "tabAdministrarDatos";
            this.tabAdministrarDatos.SelectedIndex = 1;
            this.tabAdministrarDatos.Size = new System.Drawing.Size(1043, 439);
            this.tabAdministrarDatos.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabAdministrarDatos.TabIndex = 10;
            this.tabAdministrarDatos.UseSelectable = true;
            // 
            // tabAdministrarDatosEmpresa
            // 
            this.tabAdministrarDatosEmpresa.Controls.Add(this.lblMsgNoLogueadoDatos);
            this.tabAdministrarDatosEmpresa.Controls.Add(this.grbAjustesEmpresa);
            this.tabAdministrarDatosEmpresa.HorizontalScrollbarBarColor = true;
            this.tabAdministrarDatosEmpresa.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdministrarDatosEmpresa.HorizontalScrollbarSize = 10;
            this.tabAdministrarDatosEmpresa.Location = new System.Drawing.Point(4, 34);
            this.tabAdministrarDatosEmpresa.Name = "tabAdministrarDatosEmpresa";
            this.tabAdministrarDatosEmpresa.Size = new System.Drawing.Size(1035, 401);
            this.tabAdministrarDatosEmpresa.TabIndex = 0;
            this.tabAdministrarDatosEmpresa.Text = "Datos";
            this.tabAdministrarDatosEmpresa.VerticalScrollbarBarColor = true;
            this.tabAdministrarDatosEmpresa.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdministrarDatosEmpresa.VerticalScrollbarSize = 10;
            // 
            // lblMsgNoLogueadoDatos
            // 
            this.lblMsgNoLogueadoDatos.AutoSize = true;
            this.lblMsgNoLogueadoDatos.Location = new System.Drawing.Point(13, 9);
            this.lblMsgNoLogueadoDatos.Name = "lblMsgNoLogueadoDatos";
            this.lblMsgNoLogueadoDatos.Size = new System.Drawing.Size(412, 19);
            this.lblMsgNoLogueadoDatos.TabIndex = 9;
            this.lblMsgNoLogueadoDatos.Text = "Para acceder a los ajustes de administración, introduce la contraseña.";
            // 
            // grbAjustesEmpresa
            // 
            this.grbAjustesEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.grbAjustesEmpresa.Controls.Add(this.lblAjustesAceptados);
            this.grbAjustesEmpresa.Controls.Add(this.btnAceptarAjustes);
            this.grbAjustesEmpresa.Controls.Add(this.picLogoAjustes);
            this.grbAjustesEmpresa.Controls.Add(this.btnPickLogo);
            this.grbAjustesEmpresa.Controls.Add(this.chkContrasenaAjustes);
            this.grbAjustesEmpresa.Controls.Add(this.txtContrasenaAjustes);
            this.grbAjustesEmpresa.Controls.Add(this.label1);
            this.grbAjustesEmpresa.Controls.Add(this.txtNombreEmpresa);
            this.grbAjustesEmpresa.Controls.Add(this.lblImagen);
            this.grbAjustesEmpresa.Controls.Add(this.lblNombre);
            this.grbAjustesEmpresa.Location = new System.Drawing.Point(13, 31);
            this.grbAjustesEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.grbAjustesEmpresa.Name = "grbAjustesEmpresa";
            this.grbAjustesEmpresa.Padding = new System.Windows.Forms.Padding(2);
            this.grbAjustesEmpresa.Size = new System.Drawing.Size(996, 368);
            this.grbAjustesEmpresa.TabIndex = 8;
            this.grbAjustesEmpresa.TabStop = false;
            this.grbAjustesEmpresa.Text = "Ajustes";
            // 
            // lblAjustesAceptados
            // 
            this.lblAjustesAceptados.AutoSize = true;
            this.lblAjustesAceptados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAjustesAceptados.ForeColor = System.Drawing.Color.Green;
            this.lblAjustesAceptados.Location = new System.Drawing.Point(75, 309);
            this.lblAjustesAceptados.Name = "lblAjustesAceptados";
            this.lblAjustesAceptados.Size = new System.Drawing.Size(146, 15);
            this.lblAjustesAceptados.TabIndex = 12;
            this.lblAjustesAceptados.Text = "Mensaje de confirmación";
            // 
            // btnAceptarAjustes
            // 
            this.btnAceptarAjustes.Location = new System.Drawing.Point(78, 275);
            this.btnAceptarAjustes.Name = "btnAceptarAjustes";
            this.btnAceptarAjustes.Size = new System.Drawing.Size(88, 31);
            this.btnAceptarAjustes.TabIndex = 11;
            this.btnAceptarAjustes.Text = "&Aceptar";
            this.btnAceptarAjustes.UseSelectable = true;
            this.btnAceptarAjustes.Click += new System.EventHandler(this.BtnAceptarAjustes_Click);
            // 
            // picLogoAjustes
            // 
            this.picLogoAjustes.Location = new System.Drawing.Point(402, 153);
            this.picLogoAjustes.Name = "picLogoAjustes";
            this.picLogoAjustes.Size = new System.Drawing.Size(188, 95);
            this.picLogoAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogoAjustes.TabIndex = 10;
            this.picLogoAjustes.TabStop = false;
            // 
            // btnPickLogo
            // 
            this.btnPickLogo.Location = new System.Drawing.Point(297, 151);
            this.btnPickLogo.Name = "btnPickLogo";
            this.btnPickLogo.Size = new System.Drawing.Size(93, 24);
            this.btnPickLogo.TabIndex = 9;
            this.btnPickLogo.Text = "&Buscar imagen";
            this.btnPickLogo.UseVisualStyleBackColor = true;
            this.btnPickLogo.Click += new System.EventHandler(this.BtnPickLogo_Click);
            // 
            // chkContrasenaAjustes
            // 
            this.chkContrasenaAjustes.AutoSize = true;
            this.chkContrasenaAjustes.Location = new System.Drawing.Point(298, 113);
            this.chkContrasenaAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.chkContrasenaAjustes.Name = "chkContrasenaAjustes";
            this.chkContrasenaAjustes.Size = new System.Drawing.Size(117, 17);
            this.chkContrasenaAjustes.TabIndex = 8;
            this.chkContrasenaAjustes.Tag = "Ajustes";
            this.chkContrasenaAjustes.Text = "Mostrar contraseña";
            this.chkContrasenaAjustes.UseVisualStyleBackColor = true;
            this.chkContrasenaAjustes.CheckedChanged += new System.EventHandler(this.ChkContrasena_CheckedChanged);
            // 
            // txtContrasenaAjustes
            // 
            this.txtContrasenaAjustes.Location = new System.Drawing.Point(298, 84);
            this.txtContrasenaAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenaAjustes.Name = "txtContrasenaAjustes";
            this.txtContrasenaAjustes.Size = new System.Drawing.Size(169, 20);
            this.txtContrasenaAjustes.TabIndex = 7;
            this.txtContrasenaAjustes.UseSystemPasswordChar = true;
            this.txtContrasenaAjustes.TextChanged += new System.EventHandler(this.TxtAjustes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña de la empresa";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(298, 50);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(169, 20);
            this.txtNombreEmpresa.TabIndex = 3;
            this.txtNombreEmpresa.TextChanged += new System.EventHandler(this.TxtAjustes_TextChanged);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(75, 153);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(131, 15);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen de la empresa";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(75, 54);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre de la empresa";
            // 
            // tabAdministrarProductos
            // 
            this.tabAdministrarProductos.Controls.Add(this.lblMsgNoLogueadoProductos);
            this.tabAdministrarProductos.Controls.Add(this.grbAjustesProductos);
            this.tabAdministrarProductos.HorizontalScrollbarBarColor = true;
            this.tabAdministrarProductos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdministrarProductos.HorizontalScrollbarSize = 10;
            this.tabAdministrarProductos.Location = new System.Drawing.Point(4, 34);
            this.tabAdministrarProductos.Name = "tabAdministrarProductos";
            this.tabAdministrarProductos.Size = new System.Drawing.Size(1035, 401);
            this.tabAdministrarProductos.TabIndex = 1;
            this.tabAdministrarProductos.Text = "Productos";
            this.tabAdministrarProductos.VerticalScrollbarBarColor = true;
            this.tabAdministrarProductos.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdministrarProductos.VerticalScrollbarSize = 10;
            // 
            // lblMsgNoLogueadoProductos
            // 
            this.lblMsgNoLogueadoProductos.AutoSize = true;
            this.lblMsgNoLogueadoProductos.Location = new System.Drawing.Point(13, 9);
            this.lblMsgNoLogueadoProductos.Name = "lblMsgNoLogueadoProductos";
            this.lblMsgNoLogueadoProductos.Size = new System.Drawing.Size(412, 19);
            this.lblMsgNoLogueadoProductos.TabIndex = 10;
            this.lblMsgNoLogueadoProductos.Text = "Para acceder a los ajustes de administración, introduce la contraseña.";
            // 
            // grbAjustesProductos
            // 
            this.grbAjustesProductos.BackColor = System.Drawing.Color.Transparent;
            this.grbAjustesProductos.Controls.Add(this.lblMsgMedidaAgregada);
            this.grbAjustesProductos.Controls.Add(this.btnEliminarMedida);
            this.grbAjustesProductos.Controls.Add(this.txtAgregarMedida);
            this.grbAjustesProductos.Controls.Add(this.cboAdministrarMedida);
            this.grbAjustesProductos.Controls.Add(this.lblAdministrarMedida);
            this.grbAjustesProductos.Controls.Add(this.btnAgregarMedida);
            this.grbAjustesProductos.Controls.Add(this.lblMsgCategoriaAgregada);
            this.grbAjustesProductos.Controls.Add(this.btnEliminarCategoria);
            this.grbAjustesProductos.Controls.Add(this.txtAgregarCategoria);
            this.grbAjustesProductos.Controls.Add(this.cboAdministrarCategoria);
            this.grbAjustesProductos.Controls.Add(this.lblAdministrarCategoria);
            this.grbAjustesProductos.Controls.Add(this.btnAgregarCategoria);
            this.grbAjustesProductos.Controls.Add(this.lblMsgTipoProductoAgregado);
            this.grbAjustesProductos.Controls.Add(this.btnEliminarTipoProducto);
            this.grbAjustesProductos.Controls.Add(this.txtAgregarTipoProducto);
            this.grbAjustesProductos.Controls.Add(this.cboAdministrarTipoProducto);
            this.grbAjustesProductos.Controls.Add(this.lblAdministrarTipoProducto);
            this.grbAjustesProductos.Controls.Add(this.btnAgregarTipoProducto);
            this.grbAjustesProductos.Location = new System.Drawing.Point(13, 31);
            this.grbAjustesProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grbAjustesProductos.Name = "grbAjustesProductos";
            this.grbAjustesProductos.Padding = new System.Windows.Forms.Padding(2);
            this.grbAjustesProductos.Size = new System.Drawing.Size(587, 308);
            this.grbAjustesProductos.TabIndex = 9;
            this.grbAjustesProductos.TabStop = false;
            this.grbAjustesProductos.Text = "Ajustes";
            // 
            // lblMsgMedidaAgregada
            // 
            this.lblMsgMedidaAgregada.AutoSize = true;
            this.lblMsgMedidaAgregada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMsgMedidaAgregada.ForeColor = System.Drawing.Color.Green;
            this.lblMsgMedidaAgregada.Location = new System.Drawing.Point(329, 265);
            this.lblMsgMedidaAgregada.Name = "lblMsgMedidaAgregada";
            this.lblMsgMedidaAgregada.Size = new System.Drawing.Size(169, 15);
            this.lblMsgMedidaAgregada.TabIndex = 25;
            this.lblMsgMedidaAgregada.Text = "Se ha añadido correctamente";
            this.lblMsgMedidaAgregada.Visible = false;
            // 
            // btnEliminarMedida
            // 
            this.btnEliminarMedida.Location = new System.Drawing.Point(459, 209);
            this.btnEliminarMedida.Name = "btnEliminarMedida";
            this.btnEliminarMedida.Size = new System.Drawing.Size(56, 23);
            this.btnEliminarMedida.TabIndex = 24;
            this.btnEliminarMedida.Text = "Eliminar";
            this.btnEliminarMedida.UseSelectable = true;
            this.btnEliminarMedida.Click += new System.EventHandler(this.BtnEliminarMedida_Click);
            // 
            // txtAgregarMedida
            // 
            // 
            // 
            // 
            this.txtAgregarMedida.CustomButton.Image = null;
            this.txtAgregarMedida.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAgregarMedida.CustomButton.Name = "";
            this.txtAgregarMedida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAgregarMedida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgregarMedida.CustomButton.TabIndex = 1;
            this.txtAgregarMedida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgregarMedida.CustomButton.UseSelectable = true;
            this.txtAgregarMedida.CustomButton.Visible = false;
            this.txtAgregarMedida.Lines = new string[0];
            this.txtAgregarMedida.Location = new System.Drawing.Point(332, 239);
            this.txtAgregarMedida.MaxLength = 32767;
            this.txtAgregarMedida.Name = "txtAgregarMedida";
            this.txtAgregarMedida.PasswordChar = '\0';
            this.txtAgregarMedida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgregarMedida.SelectedText = "";
            this.txtAgregarMedida.SelectionLength = 0;
            this.txtAgregarMedida.SelectionStart = 0;
            this.txtAgregarMedida.ShortcutsEnabled = true;
            this.txtAgregarMedida.Size = new System.Drawing.Size(121, 23);
            this.txtAgregarMedida.TabIndex = 23;
            this.txtAgregarMedida.UseSelectable = true;
            this.txtAgregarMedida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgregarMedida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboAdministrarMedida
            // 
            this.cboAdministrarMedida.FormattingEnabled = true;
            this.cboAdministrarMedida.ItemHeight = 23;
            this.cboAdministrarMedida.Location = new System.Drawing.Point(332, 203);
            this.cboAdministrarMedida.Name = "cboAdministrarMedida";
            this.cboAdministrarMedida.Size = new System.Drawing.Size(121, 29);
            this.cboAdministrarMedida.TabIndex = 22;
            this.cboAdministrarMedida.UseSelectable = true;
            // 
            // lblAdministrarMedida
            // 
            this.lblAdministrarMedida.AutoSize = true;
            this.lblAdministrarMedida.Location = new System.Drawing.Point(332, 181);
            this.lblAdministrarMedida.Name = "lblAdministrarMedida";
            this.lblAdministrarMedida.Size = new System.Drawing.Size(59, 19);
            this.lblAdministrarMedida.TabIndex = 21;
            this.lblAdministrarMedida.Text = "Medidas";
            // 
            // btnAgregarMedida
            // 
            this.btnAgregarMedida.Location = new System.Drawing.Point(459, 239);
            this.btnAgregarMedida.Name = "btnAgregarMedida";
            this.btnAgregarMedida.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarMedida.TabIndex = 20;
            this.btnAgregarMedida.Text = "Agregar";
            this.btnAgregarMedida.UseSelectable = true;
            this.btnAgregarMedida.Click += new System.EventHandler(this.BtnAgregarMedida_Click);
            // 
            // lblMsgCategoriaAgregada
            // 
            this.lblMsgCategoriaAgregada.AutoSize = true;
            this.lblMsgCategoriaAgregada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMsgCategoriaAgregada.ForeColor = System.Drawing.Color.Green;
            this.lblMsgCategoriaAgregada.Location = new System.Drawing.Point(329, 133);
            this.lblMsgCategoriaAgregada.Name = "lblMsgCategoriaAgregada";
            this.lblMsgCategoriaAgregada.Size = new System.Drawing.Size(169, 15);
            this.lblMsgCategoriaAgregada.TabIndex = 19;
            this.lblMsgCategoriaAgregada.Text = "Se ha añadido correctamente";
            this.lblMsgCategoriaAgregada.Visible = false;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(459, 77);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(56, 23);
            this.btnEliminarCategoria.TabIndex = 18;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseSelectable = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.BtnEliminarCategoria_Click);
            // 
            // txtAgregarCategoria
            // 
            // 
            // 
            // 
            this.txtAgregarCategoria.CustomButton.Image = null;
            this.txtAgregarCategoria.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAgregarCategoria.CustomButton.Name = "";
            this.txtAgregarCategoria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAgregarCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgregarCategoria.CustomButton.TabIndex = 1;
            this.txtAgregarCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgregarCategoria.CustomButton.UseSelectable = true;
            this.txtAgregarCategoria.CustomButton.Visible = false;
            this.txtAgregarCategoria.Lines = new string[0];
            this.txtAgregarCategoria.Location = new System.Drawing.Point(332, 107);
            this.txtAgregarCategoria.MaxLength = 32767;
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.PasswordChar = '\0';
            this.txtAgregarCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgregarCategoria.SelectedText = "";
            this.txtAgregarCategoria.SelectionLength = 0;
            this.txtAgregarCategoria.SelectionStart = 0;
            this.txtAgregarCategoria.ShortcutsEnabled = true;
            this.txtAgregarCategoria.Size = new System.Drawing.Size(121, 23);
            this.txtAgregarCategoria.TabIndex = 17;
            this.txtAgregarCategoria.UseSelectable = true;
            this.txtAgregarCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgregarCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboAdministrarCategoria
            // 
            this.cboAdministrarCategoria.FormattingEnabled = true;
            this.cboAdministrarCategoria.ItemHeight = 23;
            this.cboAdministrarCategoria.Location = new System.Drawing.Point(332, 71);
            this.cboAdministrarCategoria.Name = "cboAdministrarCategoria";
            this.cboAdministrarCategoria.Size = new System.Drawing.Size(121, 29);
            this.cboAdministrarCategoria.TabIndex = 16;
            this.cboAdministrarCategoria.UseSelectable = true;
            // 
            // lblAdministrarCategoria
            // 
            this.lblAdministrarCategoria.AutoSize = true;
            this.lblAdministrarCategoria.Location = new System.Drawing.Point(332, 49);
            this.lblAdministrarCategoria.Name = "lblAdministrarCategoria";
            this.lblAdministrarCategoria.Size = new System.Drawing.Size(72, 19);
            this.lblAdministrarCategoria.TabIndex = 15;
            this.lblAdministrarCategoria.Text = "Categorías";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(459, 107);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarCategoria.TabIndex = 14;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseSelectable = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // lblMsgTipoProductoAgregado
            // 
            this.lblMsgTipoProductoAgregado.AutoSize = true;
            this.lblMsgTipoProductoAgregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMsgTipoProductoAgregado.ForeColor = System.Drawing.Color.Green;
            this.lblMsgTipoProductoAgregado.Location = new System.Drawing.Point(33, 169);
            this.lblMsgTipoProductoAgregado.Name = "lblMsgTipoProductoAgregado";
            this.lblMsgTipoProductoAgregado.Size = new System.Drawing.Size(169, 15);
            this.lblMsgTipoProductoAgregado.TabIndex = 13;
            this.lblMsgTipoProductoAgregado.Text = "Se ha añadido correctamente";
            this.lblMsgTipoProductoAgregado.Visible = false;
            // 
            // btnEliminarTipoProducto
            // 
            this.btnEliminarTipoProducto.Location = new System.Drawing.Point(163, 113);
            this.btnEliminarTipoProducto.Name = "btnEliminarTipoProducto";
            this.btnEliminarTipoProducto.Size = new System.Drawing.Size(56, 23);
            this.btnEliminarTipoProducto.TabIndex = 5;
            this.btnEliminarTipoProducto.Text = "Eliminar";
            this.btnEliminarTipoProducto.UseSelectable = true;
            this.btnEliminarTipoProducto.Click += new System.EventHandler(this.BtnEliminarTipoProducto_Click);
            // 
            // txtAgregarTipoProducto
            // 
            // 
            // 
            // 
            this.txtAgregarTipoProducto.CustomButton.Image = null;
            this.txtAgregarTipoProducto.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtAgregarTipoProducto.CustomButton.Name = "";
            this.txtAgregarTipoProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAgregarTipoProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgregarTipoProducto.CustomButton.TabIndex = 1;
            this.txtAgregarTipoProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgregarTipoProducto.CustomButton.UseSelectable = true;
            this.txtAgregarTipoProducto.CustomButton.Visible = false;
            this.txtAgregarTipoProducto.Lines = new string[0];
            this.txtAgregarTipoProducto.Location = new System.Drawing.Point(36, 143);
            this.txtAgregarTipoProducto.MaxLength = 32767;
            this.txtAgregarTipoProducto.Name = "txtAgregarTipoProducto";
            this.txtAgregarTipoProducto.PasswordChar = '\0';
            this.txtAgregarTipoProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgregarTipoProducto.SelectedText = "";
            this.txtAgregarTipoProducto.SelectionLength = 0;
            this.txtAgregarTipoProducto.SelectionStart = 0;
            this.txtAgregarTipoProducto.ShortcutsEnabled = true;
            this.txtAgregarTipoProducto.Size = new System.Drawing.Size(121, 23);
            this.txtAgregarTipoProducto.TabIndex = 4;
            this.txtAgregarTipoProducto.UseSelectable = true;
            this.txtAgregarTipoProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgregarTipoProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboAdministrarTipoProducto
            // 
            this.cboAdministrarTipoProducto.FormattingEnabled = true;
            this.cboAdministrarTipoProducto.ItemHeight = 23;
            this.cboAdministrarTipoProducto.Location = new System.Drawing.Point(36, 107);
            this.cboAdministrarTipoProducto.Name = "cboAdministrarTipoProducto";
            this.cboAdministrarTipoProducto.Size = new System.Drawing.Size(121, 29);
            this.cboAdministrarTipoProducto.TabIndex = 3;
            this.cboAdministrarTipoProducto.UseSelectable = true;
            this.cboAdministrarTipoProducto.SelectedIndexChanged += new System.EventHandler(this.CboAdministrarTipoProducto_SelectedIndexChanged);
            // 
            // lblAdministrarTipoProducto
            // 
            this.lblAdministrarTipoProducto.AutoSize = true;
            this.lblAdministrarTipoProducto.Location = new System.Drawing.Point(36, 85);
            this.lblAdministrarTipoProducto.Name = "lblAdministrarTipoProducto";
            this.lblAdministrarTipoProducto.Size = new System.Drawing.Size(117, 19);
            this.lblAdministrarTipoProducto.TabIndex = 2;
            this.lblAdministrarTipoProducto.Text = "Tipos de producto";
            // 
            // btnAgregarTipoProducto
            // 
            this.btnAgregarTipoProducto.Location = new System.Drawing.Point(163, 143);
            this.btnAgregarTipoProducto.Name = "btnAgregarTipoProducto";
            this.btnAgregarTipoProducto.Size = new System.Drawing.Size(56, 23);
            this.btnAgregarTipoProducto.TabIndex = 0;
            this.btnAgregarTipoProducto.Text = "Agregar";
            this.btnAgregarTipoProducto.UseSelectable = true;
            this.btnAgregarTipoProducto.Click += new System.EventHandler(this.BtnAgregarTipoProducto_Click);
            // 
            // chkContrasena
            // 
            this.chkContrasena.AutoSize = true;
            this.chkContrasena.Location = new System.Drawing.Point(191, 45);
            this.chkContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.chkContrasena.Name = "chkContrasena";
            this.chkContrasena.Size = new System.Drawing.Size(117, 17);
            this.chkContrasena.TabIndex = 14;
            this.chkContrasena.Text = "Mostrar contraseña";
            this.chkContrasena.UseVisualStyleBackColor = true;
            this.chkContrasena.CheckedChanged += new System.EventHandler(this.ChkContrasena_CheckedChanged);
            // 
            // txtContrasenaLogin
            // 
            this.txtContrasenaLogin.Location = new System.Drawing.Point(191, 21);
            this.txtContrasenaLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenaLogin.Name = "txtContrasenaLogin";
            this.txtContrasenaLogin.Size = new System.Drawing.Size(131, 20);
            this.txtContrasenaLogin.TabIndex = 13;
            this.txtContrasenaLogin.UseSystemPasswordChar = true;
            this.txtContrasenaLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress);
            // 
            // btnAceptarContrasena
            // 
            this.btnAceptarContrasena.Location = new System.Drawing.Point(333, 20);
            this.btnAceptarContrasena.Name = "btnAceptarContrasena";
            this.btnAceptarContrasena.Size = new System.Drawing.Size(77, 23);
            this.btnAceptarContrasena.TabIndex = 15;
            this.btnAceptarContrasena.Text = "&Aceptar";
            this.btnAceptarContrasena.UseSelectable = true;
            this.btnAceptarContrasena.Click += new System.EventHandler(this.BtnAceptarContrasena_Click);
            // 
            // lblContrasenaLogin
            // 
            this.lblContrasenaLogin.AutoSize = true;
            this.lblContrasenaLogin.Location = new System.Drawing.Point(6, 21);
            this.lblContrasenaLogin.Name = "lblContrasenaLogin";
            this.lblContrasenaLogin.Size = new System.Drawing.Size(180, 19);
            this.lblContrasenaLogin.TabIndex = 16;
            this.lblContrasenaLogin.Text = "Contraseña de administrador";
            // 
            // lblErrorContrasena
            // 
            this.lblErrorContrasena.AutoSize = true;
            this.lblErrorContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorContrasena.Location = new System.Drawing.Point(187, 67);
            this.lblErrorContrasena.Name = "lblErrorContrasena";
            this.lblErrorContrasena.Size = new System.Drawing.Size(101, 15);
            this.lblErrorContrasena.TabIndex = 17;
            this.lblErrorContrasena.Text = "Mensaje de error";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.Teal;
            this.lblEmpresa.Location = new System.Drawing.Point(20, 60);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(290, 109);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Nombre de la empresa";
            // 
            // ofdLogo
            // 
            this.ofdLogo.FileName = "ofdLogo";
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.lblContrasenaLogin);
            this.grbLogin.Controls.Add(this.txtContrasenaLogin);
            this.grbLogin.Controls.Add(this.lblErrorContrasena);
            this.grbLogin.Controls.Add(this.btnAceptarContrasena);
            this.grbLogin.Controls.Add(this.chkContrasena);
            this.grbLogin.Location = new System.Drawing.Point(735, 60);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(418, 100);
            this.grbLogin.TabIndex = 19;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Location = new System.Drawing.Point(863, 58);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(199, 19);
            this.lblCerrarSesion.TabIndex = 20;
            this.lblCerrarSesion.Text = "Sesión de administrador iniciada";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1068, 54);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(77, 23);
            this.btnCerrarSesion.TabIndex = 21;
            this.btnCerrarSesion.Text = "&Salir";
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(749, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Aplicación realizada por 2ºDam";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.grbLogin);
            this.Controls.Add(this.picLogoEmpresa);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            this.pnlOpcionesBusqueda.ResumeLayout(false);
            this.pnlOpcionesBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabAdministrar.ResumeLayout(false);
            this.tabAdministrarDatos.ResumeLayout(false);
            this.tabAdministrarDatosEmpresa.ResumeLayout(false);
            this.tabAdministrarDatosEmpresa.PerformLayout();
            this.grbAjustesEmpresa.ResumeLayout(false);
            this.grbAjustesEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAjustes)).EndInit();
            this.tabAdministrarProductos.ResumeLayout(false);
            this.tabAdministrarProductos.PerformLayout();
            this.grbAjustesProductos.ResumeLayout(false);
            this.grbAjustesProductos.PerformLayout();
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogoEmpresa;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabProductos;
        private MetroFramework.Controls.MetroTabPage tabAdministrar;
        private System.Windows.Forms.GroupBox grbAjustesEmpresa;
        private System.Windows.Forms.PictureBox picLogoAjustes;
        private System.Windows.Forms.Button btnPickLogo;
        private System.Windows.Forms.CheckBox chkContrasenaAjustes;
        private System.Windows.Forms.TextBox txtContrasenaAjustes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkContrasena;
        private System.Windows.Forms.TextBox txtContrasenaLogin;
        private MetroFramework.Controls.MetroLabel lblContrasenaLogin;
        private MetroFramework.Controls.MetroButton btnAceptarContrasena;
        private System.Windows.Forms.Label lblErrorContrasena;
        private System.Windows.Forms.Label lblEmpresa;
        private MetroFramework.Controls.MetroLabel lblMsgNoLogueadoDatos;
        private MetroFramework.Controls.MetroButton btnAceptarAjustes;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private System.Windows.Forms.Label lblAjustesAceptados;
        private System.Windows.Forms.GroupBox grbLogin;
        private MetroFramework.Controls.MetroLabel lblCerrarSesion;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
        private MetroFramework.Controls.MetroTabControl tabAdministrarDatos;
        private MetroFramework.Controls.MetroTabPage tabAdministrarDatosEmpresa;
        private MetroFramework.Controls.MetroTabPage tabAdministrarProductos;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroLabel lblBuscar;
        private MetroFramework.Controls.MetroRadioButton rdbDescripcion;
        private MetroFramework.Controls.MetroPanel pnlOpcionesBusqueda;
        private MetroFramework.Controls.MetroRadioButton rdbMedida;
        private MetroFramework.Controls.MetroRadioButton rdbCategoria;
        private MetroFramework.Controls.MetroRadioButton rdbTipoProducto;
        private MetroFramework.Controls.MetroComboBox cboTipoProducto;
        private System.Windows.Forms.GroupBox grbAjustesProductos;
        private MetroFramework.Controls.MetroLabel lblMsgNoLogueadoProductos;
        private MetroFramework.Controls.MetroButton btnExportarExcel;
        private MetroFramework.Controls.MetroButton btnAgregarTipoProducto;
        private MetroFramework.Controls.MetroLabel lblAdministrarTipoProducto;
        private MetroFramework.Controls.MetroComboBox cboAdministrarTipoProducto;
        private MetroFramework.Controls.MetroTextBox txtAgregarTipoProducto;
        private MetroFramework.Controls.MetroButton btnEliminarTipoProducto;
        private System.Windows.Forms.Label lblMsgTipoProductoAgregado;
        private System.Windows.Forms.Label lblMsgCategoriaAgregada;
        private MetroFramework.Controls.MetroButton btnEliminarCategoria;
        private MetroFramework.Controls.MetroTextBox txtAgregarCategoria;
        private MetroFramework.Controls.MetroComboBox cboAdministrarCategoria;
        private MetroFramework.Controls.MetroLabel lblAdministrarCategoria;
        private MetroFramework.Controls.MetroButton btnAgregarCategoria;
        private System.Windows.Forms.Label lblMsgMedidaAgregada;
        private MetroFramework.Controls.MetroButton btnEliminarMedida;
        private MetroFramework.Controls.MetroTextBox txtAgregarMedida;
        private MetroFramework.Controls.MetroComboBox cboAdministrarMedida;
        private MetroFramework.Controls.MetroLabel lblAdministrarMedida;
        private MetroFramework.Controls.MetroButton btnAgregarMedida;
        private MetroFramework.Controls.MetroComboBox cboCategoria;
        private MetroFramework.Controls.MetroComboBox cboMedida;
        private MetroFramework.Controls.MetroLabel lblTipoProducto;
        private MetroFramework.Controls.MetroLabel lblMedida;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel lblBuscarPor;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroButton btnAnadirProducto;
        private System.Windows.Forms.Label lblMsgProductoAñadido;
        private System.Windows.Forms.Label lblMsgErrorAgregarProducto;
        private MetroFramework.Controls.MetroButton btnBorrarProductos;
        private System.Windows.Forms.Label lblMsgProductoEliminado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label3;
    }
}

