using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Entidades;
using System.Collections.ObjectModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;

namespace Formularios
{
    public partial class FrmPrincipal : MetroForm
    {
        ReadOnlyCollection<Producto> ListProductos { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnCerrarSesion.Visible = false;
            lblCerrarSesion.Visible = false;

            lblErrorContrasena.Text = "";

            try
            {
                // Cargar nombre y logo de la empresa
                Empresa empresa = Program.gestor.LeerEmpresa(out string msg);

                if (msg != "")
                {
                    MetroMessageBox.Show(this, msg, "Error", 250);
                }
                else
                {
                    lblEmpresa.Text = empresa.Nombre;
                    picLogoEmpresa.ImageLocation = empresa.Logo;
                }


                // DataGridView de productos
                ListProductos = Program.gestor.MostrarProductos(out string msgProductos);
                dgvProductos.DataSource = (from p in ListProductos
                                           select new { TipoProducto = p.TipoProducto.Descripcion, Categoria = p.Categoria.Descripcion, p.Descripcion, Medida = p.Medida.Descripcion, p.Precio, p.Stock })
                                           .ToList();

                dgvProductos.Columns[0].HeaderText = "Tipo de producto";
                dgvProductos.Columns[1].HeaderText = "Categoría";
                dgvProductos.Columns[2].HeaderText = "Descripción";
                dgvProductos.Columns[3].HeaderText = "Medida";
                dgvProductos.Columns[4].HeaderText = "Precio";
                dgvProductos.Columns[5].HeaderText = "Stock";
                dgvProductos.Columns[3].Width = 75;
                dgvProductos.Columns[4].Width = 75;
                dgvProductos.Columns[5].Width = 75;


                // ComboBox de búsqueda
                CargarCboTipoProducto(cboTipoProducto);


                // Administrar productos
                CargarCboTipoProducto(cboAdministrarTipoProducto);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }

            // Opciones de administrador bloqueadas
            grbAjustesEmpresa.Visible = false;
            grbAjustesProductos.Visible = false;

            //Valoracion
            float total = 0;
            foreach (var item in ListProductos)
            {
                total += ((float)item.Precio * item.Stock);
            };
            txtValoracion.Text = total.ToString();
        }


        // Funciones para cargar ComboBoxes

        /// <summary>
        /// Carga un ComboBox con los tipos de producto.
        /// </summary>
        private void CargarCboTipoProducto(ComboBox cbo)
        {
            try
            {
                ReadOnlyCollection<TipoProducto> listTipoProducto = Program.gestor.MostrarTipoProductos(out string msg);

                cbo.Items.Clear();
                if (msg == "")
                {
                    foreach (TipoProducto tipo in listTipoProducto)
                    {
                        cbo.Items.Add(tipo);
                        cbo.DisplayMember = "Descripcion";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        /// <summary>
        /// Carga un ComboBox con las categorias.
        /// </summary>
        private void CargarCboCategoria(ComboBox cbo, ComboBox cboTipoProducto)
        {
            try
            {
                TipoProducto tipoProducto = (TipoProducto)cboTipoProducto.SelectedItem;
                ReadOnlyCollection<Categoria> listCategorias = Program.gestor.MostrarCategorias(tipoProducto.IdTipoProducto, out string msg);

                cbo.Items.Clear();
                if (msg == "")
                {
                    foreach (Categoria categorias in listCategorias)
                    {
                        cbo.Items.Add(categorias);
                        cbo.DisplayMember = "Descripcion";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        /// <summary>
        /// Carga un ComboBox con las medidas.
        /// </summary>
        private void CargarCboMedida(ComboBox cbo, ComboBox cboTipoProducto)
        {
            try
            {
                TipoProducto tipoProducto = (TipoProducto)cboTipoProducto.SelectedItem;
                ReadOnlyCollection<Medidas> listaMedidas = Program.gestor.MostrarMedidas(tipoProducto.IdTipoProducto, out string msg);

                cbo.Items.Clear();
                if (msg == "")
                {
                    foreach (Medidas medida in listaMedidas)
                    {
                        cbo.Items.Add(medida);
                        cbo.DisplayMember = "Descripcion";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        // Fin de funciones para cargar ComboBoxes


        // Login

        private void BtnAceptarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresa = Program.gestor.LeerEmpresa(out string msg);

                if (msg != "")
                {
                    MetroMessageBox.Show(this, msg, "Error", 250);
                }
                else
                {
                    if (txtContrasenaLogin.Text == empresa.Contrasenia)
                    {
                        txtContrasenaLogin.Text = "";
                        lblErrorContrasena.Text = "";
                        grbLogin.Visible = false;
                        btnCerrarSesion.Visible = true;
                        lblCerrarSesion.Visible = true;

                        lblAjustesAceptados.Text = "";
                        grbAjustesEmpresa.Visible = true;
                        grbAjustesProductos.Visible = true;
                        lblMsgNoLogueadoDatos.Visible = false;
                        lblMsgNoLogueadoProductos.Visible = false;
                        CargarAjustes();
                    }
                    else
                    {
                        lblErrorContrasena.Text = "Contraseña incorrecta";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            grbLogin.Visible = true;
            btnCerrarSesion.Visible = false;
            lblCerrarSesion.Visible = false;

            grbAjustesEmpresa.Visible = false;
            grbAjustesProductos.Visible = false;
            lblMsgNoLogueadoDatos.Visible = true;
            lblMsgNoLogueadoProductos.Visible = true;
        }

        private void ChkContrasena_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TextBox txt;

            if (chk.Tag == null)
            {
                txt = txtContrasenaLogin;
            }
            else
            {
                txt = txtContrasenaAjustes;
            }

            if (chk.Checked)
            {
                txt.UseSystemPasswordChar = false;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
            }
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                BtnAceptarContrasena_Click(sender, e);
            }
        }

        // Fin login


        // Buscar

        /// <summary>
        /// Función de búsqueda rápida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Producto> productos;
            string textoBuscado = txtBuscar.Text.ToLower();
            if (textoBuscado == "")
            {
                productos = ListProductos;
            }
            else
            {
                if (rdbTipoProducto.Checked)
                {
                    productos = from p in ListProductos
                                where p.TipoProducto.Descripcion.ToLower().Contains(textoBuscado)
                                select p;
                }
                else if (rdbDescripcion.Checked)
                {
                    productos = from p in ListProductos
                                where p.Descripcion.ToLower().Contains(textoBuscado)
                                select p;
                }
                else if (rdbCategoria.Checked)
                {
                    productos = from p in ListProductos
                                where p.Categoria.Descripcion.ToLower().Contains(textoBuscado)
                                select p;
                }
                else if (rdbMedida.Checked)
                {
                    productos = from p in ListProductos
                                where p.Medida.Descripcion.ToLower().Contains(textoBuscado)
                                select p;
                }
                else
                {
                    productos = ListProductos;
                }
            }


            var productosFiltrados = (from p in productos
                                       select new { TipoProducto = p.TipoProducto.Descripcion, Categoria = p.Categoria.Descripcion, p.Descripcion, Medida = p.Medida.Descripcion, p.Precio, p.Stock })
                                       .ToList();
            dgvProductos.DataSource = productosFiltrados;


            //Valoracion
            float total = 0;
            foreach (var item in productosFiltrados)
            {
                total += ((float)item.Precio * item.Stock);
            };
            txtValoracion.Text = total.ToString();
        }

        /// <summary>
        /// Función de búsqueda específica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipoProducto.SelectedIndex != -1)
            {
                IEnumerable<Producto> productos;

                TipoProducto tipoProducto = (TipoProducto)cboTipoProducto.SelectedItem;
                Categoria categoria = (Categoria)cboCategoria.SelectedItem;
                Medidas medida = (Medidas)cboMedida.SelectedItem;

                if (cboCategoria.SelectedIndex == -1 && cboMedida.SelectedIndex == -1)
                {
                    productos = from p in ListProductos
                                where p.TipoProducto.Descripcion == tipoProducto.Descripcion
                                select p;
                }
                else if (cboCategoria.SelectedIndex != -1 && cboMedida.SelectedIndex == -1)
                {
                    productos = from p in ListProductos
                                where p.TipoProducto.Descripcion == tipoProducto.Descripcion && p.Categoria.Descripcion == categoria.Descripcion
                                select p;
                }
                else if (cboCategoria.SelectedIndex == -1 && cboMedida.SelectedIndex != -1)
                {
                    productos = from p in ListProductos
                                where p.TipoProducto.Descripcion == tipoProducto.Descripcion && p.Medida.Descripcion == medida.Descripcion
                                select p;
                }
                else
                {
                    productos = from p in ListProductos
                                where p.TipoProducto.Descripcion == tipoProducto.Descripcion && p.Categoria.Descripcion == categoria.Descripcion && p.Medida.Descripcion == medida.Descripcion
                                select p;
                }

                var productosFiltrados = (from p in productos
                                           select new { TipoProducto = p.TipoProducto.Descripcion, Categoria = p.Categoria.Descripcion, p.Descripcion, Medida = p.Medida.Descripcion, p.Precio, p.Stock })
                                           .ToList();
                dgvProductos.DataSource = productosFiltrados;

                //Valoracion
                float total = 0;
                foreach (var item in productosFiltrados)
                {
                    total += ((float)item.Precio * item.Stock);
                };
                txtValoracion.Text = total.ToString();
            }
            else
            {

                var productosFiltrados = (from p in ListProductos
                                           select new { TipoProducto = p.TipoProducto.Descripcion, Categoria = p.Categoria.Descripcion, p.Descripcion, Medida = p.Medida.Descripcion, p.Precio, p.Stock })
                                          .ToList();
                dgvProductos.DataSource = productosFiltrados;

                //Valoracion
                float total = 0;
                foreach (var item in productosFiltrados)
                {
                    total += ((float)item.Precio * item.Stock);
                };
                txtValoracion.Text = total.ToString();
            }
        }

        private void CboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCboCategoria(cboCategoria, cboTipoProducto);
            CargarCboMedida(cboMedida, cboTipoProducto);
        }

        // Fin buscar


        // Añadir producto

        private void BtnAnadirProducto_Click(object sender, EventArgs e)
        {
            Timer t;

            if (cboTipoProducto.SelectedItem == null || cboCategoria.SelectedItem == null || cboMedida.SelectedItem == null || txtPrecio.Text == "" || txtStock.Text == "" || txtDescripcion.Text == "")
            {
                lblMsgErrorAgregarProducto.Visible = true;
                t = new Timer();
                t.Interval = 4000;
                t.Tick += (s, ev) =>
                {
                    lblMsgErrorAgregarProducto.Hide();
                    t.Stop();
                };
                t.Start();
            }
            else
            {
                TipoProducto tipoProducto = (TipoProducto)cboTipoProducto.SelectedItem;
                Categoria categoria = (Categoria)cboCategoria.SelectedItem;
                Medidas medida = (Medidas)cboMedida.SelectedItem;

                try
                {
                    Program.gestor.AnadirProducto(txtDescripcion.Text, float.Parse(txtPrecio.Text), int.Parse(txtStock.Text), categoria.IdCategoria, medida.IdMedidas, tipoProducto.IdTipoProducto);

                    // Actualizamos la lista de productos.
                    ListProductos = Program.gestor.MostrarProductos(out string msg);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message + "\nNo se ha podido añadir el producto.", "Error", 250);
                }

                lblMsgProductoAñadido.Visible = true;
                t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, ev) =>
                {
                    lblMsgProductoAñadido.Hide();
                    t.Stop();
                };
                t.Start();

                txtStock.ResetText();
                txtPrecio.ResetText();
                txtDescripcion.ResetText();
            }
        }

        /// <summary>
        /// Evita la introducción de caracteres que no sean números y el pegado(Ctrl+V).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        // Fin añadir producto


        // Borrar productos

        private void BtnBorrarProductos_Click(object sender, EventArgs e)
        {
            string msg = "";

            DialogResult result = MetroMessageBox.Show(this, "¿Estás seguro de querer borrar estos productos?", "¡Atención!", MessageBoxButtons.YesNo, 250);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow fila in dgvProductos.SelectedRows)
                {
                    foreach (Producto producto in ListProductos)
                    {
                        if (fila.Cells["TipoProducto"].Value.ToString() == producto.TipoProducto.Descripcion &&
                            fila.Cells["Categoria"].Value.ToString() == producto.Categoria.Descripcion &&
                            fila.Cells["Descripcion"].Value.ToString() == producto.Descripcion &&
                            fila.Cells["Medida"].Value.ToString() == producto.Medida.Descripcion &&
                            fila.Cells["Precio"].Value.ToString() == producto.Precio.ToString() &&
                            fila.Cells["Stock"].Value.ToString() == producto.Stock.ToString())
                        {
                            try
                            {
                                msg = Program.gestor.BorrarProducto(producto);
                            }
                            catch (Exception ex)
                            {
                                MetroMessageBox.Show(this, ex.Message, "Error", 250);
                            }
                        }
                    }
                }

                if (msg != "")
                {
                    MetroMessageBox.Show(this, msg, "Error", 250);
                }
                else
                {
                    lblMsgProductoEliminado.Visible = true;
                    Timer t = new Timer();
                    t.Interval = 6000;
                    t.Tick += (s, ev) =>
                    {
                        lblMsgProductoEliminado.Hide();
                        t.Stop();
                    };
                    t.Start();
                }

                try
                {
                    // Actualizamos la lista de productos.
                    ListProductos = Program.gestor.MostrarProductos(out msg);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message + "\nNo se ha podido actualizar la lista de productos.", "Error", 250);
                }
            }
        }

        /// <summary>
        /// Se asegura de que al darle al botón de borrar siempre haya alguna fila seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnBorrarProductos.Visible = dgvProductos.SelectedRows != null ? true : false;
        }

        // Fin borrar productos


        // Ajustes empresa

        private void BtnAceptarAjustes_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = Program.gestor.ModificarEmpresa(txtNombreEmpresa.Text, picLogoAjustes.ImageLocation, txtContrasenaAjustes.Text);

                if (msg != "")
                {
                    MetroMessageBox.Show(this, msg, "Error", 250);
                }
                else
                {
                    lblAjustesAceptados.Text = "Cambios realizados con éxito";
                    lblEmpresa.Text = txtNombreEmpresa.Text;
                    picLogoEmpresa.ImageLocation = picLogoAjustes.ImageLocation;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        private void BtnPickLogo_Click(object sender, EventArgs e)
        {
            if (ofdLogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picLogoAjustes.ImageLocation = ofdLogo.FileName;
                    lblAjustesAceptados.Text = "";
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error", 250);
                }
            }
        }

        private void CargarAjustes()
        {
            try
            {
                Empresa empresa = Program.gestor.LeerEmpresa(out string msg);

                if (msg != "")
                {
                    MetroMessageBox.Show(this, msg, "Error", 250);
                }
                else
                {
                    txtNombreEmpresa.Text = empresa.Nombre;
                    txtContrasenaAjustes.Text = empresa.Contrasenia;
                    picLogoAjustes.ImageLocation = empresa.Logo;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", 250);
            }
        }

        private void TxtAjustes_TextChanged(object sender, EventArgs e)
        {
            lblAjustesAceptados.Text = "";
        }

        // Fin ajustes empresa


        // Ajustes productos

        private void BtnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            if (txtAgregarTipoProducto.Text != "")
            {
                try
                {
                    string msg = Program.gestor.AnadirTipoProducto(txtAgregarTipoProducto.Text);
                    if (msg != "")
                    {
                        MetroMessageBox.Show(this, msg, "Error", 250);
                    }
                    else
                    {
                        lblMsgTipoProductoAgregado.Visible = true;
                        txtAgregarTipoProducto.Text = "";
                        var t = new Timer();
                        t.Interval = 5000;
                        t.Tick += (s, ev) =>
                        {
                            lblMsgTipoProductoAgregado.Hide();
                            t.Stop();
                        };
                        t.Start();

                        CargarCboTipoProducto(cboAdministrarTipoProducto);
                        CargarCboTipoProducto(cboTipoProducto);
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error", 250);
                }
            }
        }

        private void BtnEliminarTipoProducto_Click(object sender, EventArgs e)
        {
            if (cboAdministrarTipoProducto.SelectedItem != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "¿Estás seguro de querer borrar el tipo de producto?\n" +
                                            "Realizar está acción puede conllevar la pérdida de la información de todos los productos de este tipo.", "¡Atención!", MessageBoxButtons.YesNo, 250);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string msg = Program.gestor.BorrarTipoProducto((TipoProducto)cboAdministrarTipoProducto.SelectedItem);
                        if (msg != "")
                        {
                            MetroMessageBox.Show(this, msg, "Error", 250);
                        }
                        else
                        {
                            CargarCboTipoProducto(cboAdministrarTipoProducto);
                            CargarCboTipoProducto(cboTipoProducto);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "Error", 250);
                    }
                }
            }
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (txtAgregarCategoria.Text != "" && cboAdministrarTipoProducto.SelectedItem != null)
            {
                try
                {
                    TipoProducto tipoProducto = (TipoProducto)cboAdministrarTipoProducto.SelectedItem;
                    string msg = Program.gestor.AnadirCategoria(txtAgregarCategoria.Text, tipoProducto.IdTipoProducto);

                    if (msg != "")
                    {
                        MetroMessageBox.Show(this, msg, "Error", 250);
                    }
                    else
                    {
                        lblMsgCategoriaAgregada.Visible = true;
                        txtAgregarCategoria.Text = "";
                        var t = new Timer();
                        t.Interval = 5000;
                        t.Tick += (s, ev) =>
                        {
                            lblMsgCategoriaAgregada.Hide();
                            t.Stop();
                        };
                        t.Start();

                        CargarCboCategoria(cboAdministrarCategoria, cboAdministrarTipoProducto);
                        CargarCboCategoria(cboCategoria, cboTipoProducto);
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error", 250);
                }
            }
        }

        private void BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (cboAdministrarCategoria.SelectedItem != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "¿Estás seguro de querer borrar la categoría?\n" +
                                            "Realizar está acción puede conllevar la pérdida de la información de todos los productos de esta categoría.", "¡Atención!", MessageBoxButtons.YesNo, 250);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string msg = Program.gestor.BorrarCategoria((Categoria)cboAdministrarCategoria.SelectedItem);
                        if (msg != "")
                        {
                            MetroMessageBox.Show(this, msg, "Error", 250);
                        }
                        else
                        {
                            CargarCboCategoria(cboAdministrarCategoria, cboAdministrarTipoProducto);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "Error", 250);
                    }
                }
            }
        }

        private void BtnAgregarMedida_Click(object sender, EventArgs e)
        {
            if (txtAgregarMedida.Text != "" && cboAdministrarTipoProducto.SelectedItem != null)
            {
                try
                {
                    TipoProducto tipoProducto = (TipoProducto)cboAdministrarTipoProducto.SelectedItem;
                    string msg = Program.gestor.AnadirMedida(txtAgregarMedida.Text, tipoProducto.IdTipoProducto);

                    if (msg != "")
                    {
                        MetroMessageBox.Show(this, msg, "Error", 250);
                    }
                    else
                    {
                        lblMsgMedidaAgregada.Visible = true;
                        txtAgregarMedida.Text = "";
                        var t = new Timer();
                        t.Interval = 5000;
                        t.Tick += (s, ev) =>
                        {
                            lblMsgMedidaAgregada.Hide();
                            t.Stop();
                        };
                        t.Start();

                        CargarCboMedida(cboAdministrarMedida, cboAdministrarTipoProducto);
                        CargarCboMedida(cboMedida, cboTipoProducto);
                    }
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error", 250);
                }
            }
        }

        private void BtnEliminarMedida_Click(object sender, EventArgs e)
        {
            if (cboAdministrarMedida.SelectedItem != null)
            {
                DialogResult result = MetroMessageBox.Show(this, "¿Estás seguro de querer borrar la medida?\n" +
                                            "Realizar está acción puede conllevar la pérdida de la información de todos los productos con esta medida.", "¡Atención!", MessageBoxButtons.YesNo, 250);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string msg = Program.gestor.BorrarMedida((Medidas)cboAdministrarMedida.SelectedItem);
                        if (msg != "")
                        {
                            MetroMessageBox.Show(this, msg, "Error", 250);
                        }
                        else
                        {
                            CargarCboMedida(cboAdministrarMedida, cboAdministrarTipoProducto);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "Error", 250);
                    }
                }
            }
        }

        /// <summary>
        /// Actualiza los ComboBoxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboAdministrarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCboCategoria(cboAdministrarCategoria, cboAdministrarTipoProducto);
            CargarCboMedida(cboAdministrarMedida, cboAdministrarTipoProducto);
        }

        // Fin ajustes productos


        // Exportar a Excel

        private void copyAlltoClipboard()
        {
            dgvProductos.SelectAll();
            DataObject dataObj = dgvProductos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        // Fin exportar a Excel


        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        //Función que genera el documento Pdf
        public void GenerarDocumentos(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView 
            PdfPTable datatable = new PdfPTable(dgvProductos.ColumnCount);

            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgvProductos);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            //DEFINIMOS EL COLOR DE LAS CELDAS EN EL PDF
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            //DEFINIMOS EL COLOR DE LOS BORDES
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

            //LA FUENTE DE NUESTRO TEXTO
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < dgvProductos.ColumnCount; i++)
            {

                objP = new Phrase(dgvProductos.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;

                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;

            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgvProductos.RowCount; i++)
            {
                for (int j = 0; j < dgvProductos.ColumnCount; j++)
                {
                    objP = new Phrase(dgvProductos[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        //Función que obtiene los tamaños de las columnas del datagridview
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            //Tomamos el numero de columnas
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                //Tomamos el ancho de cada columna
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }


    }
}
