using System;
using System.IO;
using System.Data.SQLite;
using Clases;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Entidades;

namespace GestionDatos
{
    public class Datos
    {
        private const string sqlPath = "./BaseDatos/" + "inventarioDB.sql";
        private const string DBPath = "./BaseDatos/" + "inventarioDB.db";
        private string connectionStr = string.Format("Data Source={0};Version=3;", DBPath);

        public Datos(out string msg)
        {
            msg = "";
            if (!File.Exists(Path.GetFullPath(DBPath)))
            {
                SQLiteConnection.CreateFile(DBPath);

                using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
                {
                    try
                    {
                        conex.Open();

                        FileInfo file = new FileInfo(sqlPath);
                        string script = file.OpenText().ReadToEnd();

                        SQLiteCommand command = new SQLiteCommand(script, conex);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        msg = e.Message;
                    }
                }
            }
        }

        public string AnadirProducto(string descripcion, float precio, int stock, int idCategoria, int idMedida, int idTipoProducto)
        {
            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "INSERT INTO productos VALUES (null, @descripcion, @precio, @stock, @idCategoria, @idMedida, @idTipoProducto)";
                    SQLiteCommand cmdAnadir = new SQLiteCommand(sql, conex);

                    cmdAnadir.CommandText = sql;
                    cmdAnadir.Parameters.AddWithValue("@descripcion", descripcion);
                    cmdAnadir.Parameters.AddWithValue("@precio", precio);
                    cmdAnadir.Parameters.AddWithValue("@stock", stock);
                    cmdAnadir.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmdAnadir.Parameters.AddWithValue("@idMedida", idMedida);
                    cmdAnadir.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);

                    int numFilas = cmdAnadir.ExecuteNonQuery();
                    if (numFilas <= 0)
                    {
                        return "No has añadido nada.";
                    }

                    return "";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public string AnadirCategoria(string descripcion, int idTipoProducto)
        {
            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "INSERT INTO categoria VALUES (null, @descripcion, @idTipoProducto)";
                    SQLiteCommand cmdAnadir = new SQLiteCommand(sql, conex);

                    cmdAnadir.CommandText = sql;
                    cmdAnadir.Parameters.AddWithValue("@descripcion", descripcion);
                    cmdAnadir.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);

                    int numFilas = cmdAnadir.ExecuteNonQuery();
                    if (numFilas <= 0)
                    {
                        return "No has añadido nada.";
                    }

                    return "";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public string AnadirMedida(string descripcion, int idTipoProducto)
        {
            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "INSERT INTO medidas VALUES (null, @descripcion, @idTipoProducto)";
                    SQLiteCommand cmdAnadir = new SQLiteCommand(sql, conex);

                    cmdAnadir.CommandText = sql;
                    cmdAnadir.Parameters.AddWithValue("@descripcion", descripcion);
                    cmdAnadir.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);

                    int numFilas = cmdAnadir.ExecuteNonQuery();
                    if (numFilas <= 0)
                    {
                        return "No has añadido nada.";
                    }

                    return "";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public string AnadirTipoProducto(string descripcion)
        {
            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "INSERT INTO tipo_producto VALUES (null, @descripcion)";
                    SQLiteCommand cmdAnadir = new SQLiteCommand(sql, conex);

                    cmdAnadir.CommandText = sql;
                    cmdAnadir.Parameters.AddWithValue("@descripcion", descripcion);

                    int numFilas = cmdAnadir.ExecuteNonQuery();
                    if (numFilas <= 0)
                    {
                        return "No has añadido nada.";
                    }

                    return "";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public string ModificarEmpresa(string nombre, string logo, string contrasenia)
        {
            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "UPDATE EMPRESA SET nombre = @nombre, logo = @logo, contrasenia = @contrasenia";
                    SQLiteCommand cmdModificar = new SQLiteCommand(sql, conex);

                    cmdModificar.CommandText = sql;
                    cmdModificar.Parameters.AddWithValue("@nombre", nombre);
                    cmdModificar.Parameters.AddWithValue("@logo", logo);
                    cmdModificar.Parameters.AddWithValue("@contrasenia", contrasenia);

                    int numFilas = cmdModificar.ExecuteNonQuery();
                    if (numFilas <= 0)
                    {
                        return "No has modificado nada.";
                    }

                    return "";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
        }

        public Empresa LeerEmpresa(out string msg)
        {
            msg = "";
            Empresa empresa = new Empresa();

            using (SQLiteConnection conex = new SQLiteConnection(connectionStr))
            {
                try
                {
                    conex.Open();
                    string sql = "SELECT * FROM EMPRESA";
                    SQLiteCommand cmdLeer = new SQLiteCommand(sql, conex);

                    using (SQLiteDataReader drEmpresa = cmdLeer.ExecuteReader())
                    {
                        if (!drEmpresa.HasRows)
                        {
                            msg = "No hay ninguna empresa";
                            return empresa;
                        }

                        if (drEmpresa.Read())
                        {
                            empresa.Nombre = drEmpresa["nombre"].ToString();
                            empresa.Logo = drEmpresa["logo"].ToString();
                            empresa.Contrasenia = drEmpresa["contrasenia"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    msg = e.Message;
                }

                return empresa;
            }
        }

        public ReadOnlyCollection<TipoProducto> MostrarTipoProductos(out string mens)
        {
            mens = "";
            List<TipoProducto> tProductos = new List<TipoProducto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idTipoProducto, descripcion FROM TIPO_PRODUCTO";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    using (SQLiteDataReader drTproducto = cmd.ExecuteReader())
                    {
                        if (!drTproducto.HasRows)
                        {
                            mens = "No hay Tipos de Producto";
                            return tProductos.AsReadOnly();
                        }

                        //Si solo esperas un dato con if sino con while
                        while (drTproducto.Read())
                        {
                            TipoProducto tipoProducto = new TipoProducto();
                            tipoProducto.IdTipoProducto = int.Parse(drTproducto["idTipoProducto"].ToString());

                            tipoProducto.Descripcion = drTproducto["descripcion"].ToString();

                            tProductos.Add(tipoProducto);
                        }

                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return tProductos.AsReadOnly();
            }
        }

        public ReadOnlyCollection<Categoria> MostrarCategorias(int idTipoProducto, out string mens)
        {
            mens = "";
            List<Categoria> listCategorias = new List<Categoria>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idCategoria, descripcion FROM CATEGORIA WHERE idTipoProducto = @idTipoProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    using (SQLiteDataReader drCategorias = cmd.ExecuteReader())
                    {
                        if (!drCategorias.HasRows)
                        {
                            mens = "No hay categorias";
                            return listCategorias.AsReadOnly();
                        }

                        //Si solo esperas un dato con if sino con while
                        while (drCategorias.Read())
                        {
                            Categoria cate = new Categoria();
                            cate.IdCategoria = int.Parse(drCategorias["idCategoria"].ToString());
                            cate.Descripcion = drCategorias["descripcion"].ToString();
                            listCategorias.Add(cate);
                        }

                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listCategorias.AsReadOnly();
            }
        }

        public ReadOnlyCollection<Medidas> MostrarMedidas(int idTipoProducto, out string mens)
        {
            mens = "";
            List<Medidas> listMedidas = new List<Medidas>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idMedida, descripcion FROM MEDIDAS WHERE idTipoProducto = @idTipoProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    using (SQLiteDataReader drCategorias = cmd.ExecuteReader())
                    {
                        if (!drCategorias.HasRows)
                        {
                            mens = "No hay Medidas";
                            return listMedidas.AsReadOnly();
                        }

                        //Si solo esperas un dato con if sino con while
                        while (drCategorias.Read())
                        {
                            Medidas medida = new Medidas();
                            medida.IdMedidas = int.Parse(drCategorias["idMedida"].ToString());
                            medida.Descripcion = drCategorias["descripcion"].ToString();
                            listMedidas.Add(medida);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listMedidas.AsReadOnly();
            }
        }


        public ReadOnlyCollection<Producto> MostrarProductos(out string mens)
        {
            mens = "";
            List<Producto> listProductos = new List<Producto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM PRODUCTOS";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    using (SQLiteDataReader drProducto = cmd.ExecuteReader())
                    {
                        if (!drProducto.HasRows)
                        {
                            mens = "No hay Productos";
                            return listProductos.AsReadOnly();
                        }

                        while (drProducto.Read())
                        {
                            Producto prod = new Producto();
                            prod.IdProducto = int.Parse(drProducto["idProducto"].ToString());
                            prod.Descripcion = drProducto["descripcion"].ToString();
                            prod.Precio = float.Parse(drProducto["precio"].ToString());
                            prod.Stock = int.Parse(drProducto["stock"].ToString());


                            int idTipoProducto = int.Parse(drProducto["idTipoProducto"].ToString());

                            string sqlTProducto = "SELECT descripcion FROM TIPO_PRODUCTO WHERE idTipoProducto = @idTipoProducto";
                            SQLiteCommand cmdTProducto = new SQLiteCommand(sqlTProducto, con);
                            cmdTProducto.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                            using (SQLiteDataReader drTProducto = cmdTProducto.ExecuteReader())
                            {
                                if (drTProducto.Read())
                                {
                                    prod.TipoProducto = new TipoProducto(idTipoProducto, drTProducto["descripcion"].ToString());
                                }
                            }


                            int idMedida = int.Parse(drProducto["idMedida"].ToString());

                            string sqlMedida = "SELECT descripcion FROM MEDIDAS WHERE idMedida = @idMedida";
                            SQLiteCommand cmdMedida = new SQLiteCommand(sqlMedida, con);
                            cmdMedida.Parameters.AddWithValue("@idMedida", idMedida);
                            using (SQLiteDataReader drMedida = cmdMedida.ExecuteReader())
                            {
                                if (drMedida.Read())
                                {
                                    prod.Medida = new Medidas(idMedida, drMedida["descripcion"].ToString());
                                }
                            }


                            int idCategoria = int.Parse(drProducto["idCategoria"].ToString());

                            string sqlCategoria = "SELECT descripcion FROM CATEGORIA WHERE idCategoria = @idCategoria";
                            SQLiteCommand cmdCategoria = new SQLiteCommand(sqlCategoria, con);
                            cmdCategoria.Parameters.AddWithValue("@idCategoria", idCategoria);
                            using (SQLiteDataReader drCategoria = cmdCategoria.ExecuteReader())
                            {
                                if (drCategoria.Read())
                                {
                                    prod.Categoria = new Categoria(idCategoria, drCategoria["descripcion"].ToString());
                                }
                            }


                            listProductos.Add(prod);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listProductos.AsReadOnly();
            }
        }


        public ReadOnlyCollection<Producto> MostrarProductosPorTipoCategoria(int idTipoProducto, int idCategoria, TipoProducto tipoProducto, Categoria cate, out string mens)
        {
            mens = "";
            List<Producto> listProductos = new List<Producto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idProducto, descripcion, precio, stock, idMedida FROM PRODUCTOS WHERE idTipoProducto = @idTipoProducto and idCategoria = @idCategoria";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    using (SQLiteDataReader drProducto = cmd.ExecuteReader())
                    {
                        if (!drProducto.HasRows)
                        {
                            mens = "No hay Productos";
                            return listProductos.AsReadOnly();
                        }

                        while (drProducto.Read())
                        {
                            Producto prod = new Producto();
                            prod.IdProducto = int.Parse(drProducto["idProducto"].ToString());
                            prod.Descripcion = drProducto["descripcion"].ToString();
                            prod.Precio = float.Parse(drProducto["precio"].ToString());
                            prod.Stock = int.Parse(drProducto["stock"].ToString());
                            prod.TipoProducto = tipoProducto;
                            prod.Categoria = cate;


                            int idMedida = int.Parse(drProducto["idMedidas"].ToString());

                            string sqlMedida = "SELECT descripcion FROM MEDIDAS WHERE idMedida = @idMedida";
                            SQLiteCommand cmdMedida = new SQLiteCommand(sqlMedida, con);
                            cmdMedida.Parameters.AddWithValue("@idMedida", idMedida);
                            using (SQLiteDataReader drMedida = cmdMedida.ExecuteReader())
                            {
                                if (drMedida.Read())
                                {
                                    prod.Medida = new Medidas(idMedida, drMedida["descripcion"].ToString());
                                }
                            }


                            listProductos.Add(prod);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listProductos.AsReadOnly();
            }
        }


        public ReadOnlyCollection<Producto> MostrarProductosPorTipoMedida(int idTipoProducto, int idMedida, TipoProducto tipoProducto, Medidas medida, out string mens)
        {
            mens = "";
            List<Producto> listProductos = new List<Producto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idProducto, descripcion, precio, stock, idCategoria FROM PRODUCTOS WHERE idTipoProducto = @idTipoProducto and idMedida = @idMedida";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    cmd.Parameters.AddWithValue("@idMedida", idMedida);
                    using (SQLiteDataReader drProducto = cmd.ExecuteReader())
                    {
                        if (!drProducto.HasRows)
                        {
                            mens = "No hay Productos";
                            return listProductos.AsReadOnly();
                        }

                        while (drProducto.Read())
                        {
                            Producto prod = new Producto();
                            prod.IdProducto = int.Parse(drProducto["idProducto"].ToString());
                            prod.Descripcion = drProducto["descripcion"].ToString();
                            prod.Precio = float.Parse(drProducto["precio"].ToString());
                            prod.Stock = int.Parse(drProducto["stock"].ToString());
                            prod.TipoProducto = tipoProducto;
                            prod.Medida = medida;


                            int idCategoria = int.Parse(drProducto["idCategoria"].ToString());

                            string sqlCategoria = "SELECT descripcion FROM CATEGORIA WHERE idCategoria = @idCategoria";
                            SQLiteCommand cmdCategoria = new SQLiteCommand(sqlCategoria, con);
                            cmdCategoria.Parameters.AddWithValue("@idCategoria", idCategoria);
                            using (SQLiteDataReader drCategoria = cmdCategoria.ExecuteReader())
                            {
                                if (drCategoria.Read())
                                {
                                    prod.Categoria = new Categoria(idCategoria, drCategoria["descripcion"].ToString());
                                }
                            }


                            listProductos.Add(prod);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listProductos.AsReadOnly();
            }
        }



        public ReadOnlyCollection<Producto> MostrarProductosPorTipoCategoriaMedida(int idTipoProducto, int idCategoria, int idMedida, TipoProducto tipoProducto, Categoria cate, Medidas medida, out string mens)
        {
            mens = "";
            List<Producto> listProductos = new List<Producto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idProducto, descripcion, precio, stock FROM PRODUCTOS WHERE idTipoProducto = @idTipoProducto and idCategoria = @idCategoria and idMedida = @idMedida";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@idMedida", idMedida);
                    using (SQLiteDataReader drProducto = cmd.ExecuteReader())
                    {
                        if (!drProducto.HasRows)
                        {
                            mens = "No hay Productos";
                            return listProductos.AsReadOnly();
                        }

                        //Si solo esperas un dato con if sino con while
                        while (drProducto.Read())
                        {
                            Producto prod = new Producto();
                            prod.IdProducto = int.Parse(drProducto["idProducto"].ToString());
                            prod.Descripcion = drProducto["descripcion"].ToString();
                            prod.Precio = float.Parse(drProducto["precio"].ToString());
                            prod.Stock = int.Parse(drProducto["stock"].ToString());
                            prod.TipoProducto = tipoProducto;
                            prod.Medida = medida;
                            prod.Categoria = cate;
                            listProductos.Add(prod);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listProductos.AsReadOnly();
            }
        }



        public ReadOnlyCollection<Producto> MostrarProductosPorTipo(int idTipoProducto, TipoProducto tipoProducto, out string mens)
        {
            mens = "";
            List<Producto> listProductos = new List<Producto>();
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT idProducto, descripcion, precio, stock, idCategoria, idMedida FROM PRODUCTOS WHERE idTipoProducto = @idTipoProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                    using (SQLiteDataReader drProducto = cmd.ExecuteReader())
                    {
                        if (!drProducto.HasRows)
                        {
                            mens = "No hay Productos";
                            return listProductos.AsReadOnly();
                        }

                        while (drProducto.Read())
                        {
                            Producto prod = new Producto();
                            prod.IdProducto = int.Parse(drProducto["idProducto"].ToString());
                            prod.Descripcion = drProducto["descripcion"].ToString();
                            prod.Precio = float.Parse(drProducto["precio"].ToString());
                            prod.Stock = int.Parse(drProducto["stock"].ToString());
                            prod.TipoProducto = tipoProducto;


                            int idMedida = int.Parse(drProducto["idMedidas"].ToString());

                            string sqlMedida = "SELECT descripcion FROM MEDIDAS WHERE idMedida = @idMedida";
                            SQLiteCommand cmdMedida = new SQLiteCommand(sqlMedida, con);
                            cmdMedida.Parameters.AddWithValue("@idMedida", idMedida);
                            using (SQLiteDataReader drMedida = cmdMedida.ExecuteReader())
                            {
                                if (drMedida.Read())
                                {
                                    prod.Medida = new Medidas(idMedida, drMedida["descripcion"].ToString());
                                }
                            }


                            int idCategoria = int.Parse(drProducto["idCategoria"].ToString());

                            string sqlCategoria = "SELECT descripcion FROM CATEGORIA WHERE idCategoria = @idCategoria";
                            SQLiteCommand cmdCategoria = new SQLiteCommand(sqlCategoria, con);
                            cmdCategoria.Parameters.AddWithValue("@idCategoria", idCategoria);
                            using (SQLiteDataReader drCategoria = cmdCategoria.ExecuteReader())
                            {
                                if (drCategoria.Read())
                                {
                                    prod.Categoria = new Categoria(idCategoria, drCategoria["descripcion"].ToString());
                                }
                            }


                            listProductos.Add(prod);
                        }
                    }

                }
                catch (Exception ex)
                {
                    mens = ex.Message;
                }
                return listProductos.AsReadOnly();
            }
        }

        public String VenderProducto(Producto producto)
        {


            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                if (producto.Stock<=0)
                {
                    return "No puedes vender este producto porque no queda stock";
                }
                try
                {
                    con.Open();

                    string sql = "UPDATE PRODUCTOS Set stock = @stock WHERE idProducto = @idProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock-1);
                    cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "El producto que quieres vender no existe";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }



        public string BorrarProducto(Producto producto)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM PRODUCTOS WHERE idProducto = @idProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "El producto que quieres borrar no existe";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }

        public string BorrarCategoria(Categoria cate)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM CATEGORIA WHERE idCategoria = @idCategoria";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idCategoria", cate.IdCategoria);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "La categoria que quieres borrar no existe";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }

        public string BorrarMedida(Medidas med)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM MEDIDAS WHERE idMedida = @idMedida";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idMedida", med.IdMedidas);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "La medida que quieres borrar no existe";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }

        public string BorrarTipoProducto(TipoProducto tProd)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "DELETE FROM TIPO_PRODUCTO WHERE idTipoProducto = @idTipoProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idTipoProducto", tProd.IdTipoProducto);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "El tipo de producto que quieres borrar no existe";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }

        public string EditarProducto(Producto prod)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionStr))
            {
                try
                {
                    con.Open();
                    string sql = "UPDATE PRODUCTOS SET descripcion = @descripcion, precio = @precio, stock = @stock, idCategoria = @idCategoria, idMedida = @idMedida WHERE idProducto = @idProducto";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idProducto", prod.IdProducto);
                    cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                    cmd.Parameters.AddWithValue("@precio", prod.Precio);
                    cmd.Parameters.AddWithValue("@stock", prod.Stock);
                    cmd.Parameters.AddWithValue("@idCategoria", prod.Categoria.IdCategoria);
                    cmd.Parameters.AddWithValue("@idMedida", prod.Medida.IdMedidas);



                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "No has actualizado ningún registro";
                    }

                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return "";
        }
    }
}
