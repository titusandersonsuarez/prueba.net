using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proyecto.tbProducMain;

namespace proyecto
{
    public partial class tbProducMain : Form
    {

        public tbProducMain()
        {
            InitializeComponent();
            pOrderDetails.Visible = false;
            pDtw.Visible = false;
            listaProductos = new List<Producto>();

        // Ejemplo de añadir productos a listaProductos (puedes ajustar esto según tu lógica)

        listaProductos.Add(new Producto { Nombre = "Producto1", Cantidad = 10, Precio = 50.0m, Comentario = "Descripción del producto 1" });
            listaProductos.Add(new Producto { Nombre = "Producto2", Cantidad = 5, Precio = 30.0m, Comentario = "Descripción del producto 2" });
            listaProductos.Add(new Producto { Nombre = "Producto3", Cantidad = 8, Precio = 20.0m, Comentario = "Descripción del producto 3" });

        }
        public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public string Comentario { get; set; }
        }

        public class Compra
        {
            public int IdCompra { get; set; }
            public int IdCliente { get; set; }
            public List<Producto> Productos { get; set; }
            public decimal PrecioTotal { get; set; }
            public DateTime FechaRegistro { get; set; }
        }

        private List<Compra> listaCompras = new List<Compra>();
        private List<Producto> listaProductos;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Incrementar el índice para mostrar la siguiente fila si es posible
            if (currentRowIndex < dtgOrderDetails.Rows.Count - 1)
            {
                currentRowIndex++;
                MostrarFilaActual();
            }
            else
            {
                MessageBox.Show("Ya estás en la última fila.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pOrderDetails.Visible = true;
            pOrderDetails.Visible = true;
            btAddDetails.Visible = true;
            btSave.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int numeroOrden;
            if (int.TryParse(tbSearch.Text, out numeroOrden))
            {
                Compra compraEncontrada = listaCompras.FirstOrDefault(c => c.IdCompra == numeroOrden);

                if (compraEncontrada != null)
                {
                    // Mostrar los detalles de la compra en el DataGridView de detalles (dtgOrderDetails)
                    pOrderDetails.Visible = true;
                    btAddDetails.Visible = true;
                    btSave.Visible = true;

                    dtgOrderDetails.Rows.Clear();
                    foreach (Producto producto in compraEncontrada.Productos)
                    {
                        int rowIndex = dtgOrderDetails.Rows.Add();
                        dtgOrderDetails.Rows[rowIndex].Cells[0].Value = producto.Nombre;
                        dtgOrderDetails.Rows[rowIndex].Cells[1].Value = producto.Cantidad;
                        dtgOrderDetails.Rows[rowIndex].Cells[2].Value = producto.Precio;
                        dtgOrderDetails.Rows[rowIndex].Cells[3].Value = producto.Comentario;
                    }
                }
                else
                {
                    MessageBox.Show("Orden no encontrada. Por favor, ingrese un número de orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btAddDtw_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos y sean válidos
            if (tbProduc.Text.Length > 0 &&
                tbPrice.Text.Length > 0 &&
                tbQty.Text.Length > 0 &&
                tbComments.Text.Length > 0)
            {
                int quantity;
                decimal price;

                // Intentar convertir los valores de cantidad y precio
                if (int.TryParse(tbQty.Text, out quantity) && decimal.TryParse(tbPrice.Text, out price))
                {
                    // Agregar nueva fila al DataGridView
                    int rowIndex = dtgOrderDetails.Rows.Add();
                    dtgOrderDetails.Rows[rowIndex].Cells[0].Value = tbProduc.Text;
                    dtgOrderDetails.Rows[rowIndex].Cells[1].Value = tbQty.Text;
                    dtgOrderDetails.Rows[rowIndex].Cells[2].Value = tbPrice.Text;
                    dtgOrderDetails.Rows[rowIndex].Cells[3].Value = tbComments.Text;



                    // Limpiar los campos de entrada después de agregar la fila
                    LimpiarCamposEntrada();

                    // Ocultar o mostrar paneles según sea necesario
                    pDtw.Visible = false;
                    pOrderDetails.Visible = true;
                }
                else
                {
                    // Mostrar mensaje de error si la cantidad o el precio no son válidos
                    MessageBox.Show("La cantidad y el precio deben ser números válidos.");
                }
            }
            else
            {
                // Mostrar mensaje de error si uno o más campos están vacíos
                MessageBox.Show("Todos los campos deben estar llenos.");
            }
        }
        private void LimpiarCamposEntrada()
        {
            // Limpiar los campos de entrada después de agregar la fila
            tbProduc.Text = "";
            tbPrice.Text = "";
            tbQty.Text = "";
            tbComments.Text = "";
        }

        private void btCancelDtw_Click(object sender, EventArgs e)
        {
            tbProduc.Text = "";
            tbPrice.Text = "";
            tbQty.Text = "";
            tbComments.Text = "";
            pDtw.Visible = false;

        }


        private int CalcularTotalProductos()
        {
            int totalProductos = 0;

            foreach (DataGridViewRow row in dtgOrderDetails.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    int qty;

                    bool isQtyValid = int.TryParse(row.Cells[1].Value.ToString(), out qty);

                    if (isQtyValid)
                    {
                        totalProductos += qty;
                    }
                }
            }

            return totalProductos;
        }
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgOrderDetails.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[1].Value != null)
                {
                    decimal price;
                    int qty;

                    bool isPriceValid = decimal.TryParse(row.Cells[2].Value.ToString(), out price);
                    bool isQtyValid = int.TryParse(row.Cells[1].Value.ToString(), out qty);

                    if (isPriceValid && isQtyValid)
                    {
                        total += price * qty;
                    }
                }
            }

            return total;
        }

        int contador = 0;
        private void btClose_Click(object sender, EventArgs e)
        {
            contador++;
            string cliente = "Cliente" + contador;
            decimal totalItems = CalcularTotalProductos(); // Calcula el total de productos
            decimal totalPrice = CalcularTotal(); // Calcula el total del precio de los productos

            DateTime createdOrder = DateTime.Now;

            // Crear una lista de productos para esta compra
            List<Producto> productosCompra = new List<Producto>();
            bool datosValidos = true;

            foreach (DataGridViewRow row in dtgOrderDetails.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string nombre = row.Cells[0].Value.ToString();
                    int cantidad;
                    decimal precio;

                    if (!int.TryParse(row.Cells[1].Value.ToString(), out cantidad))
                    {
                        datosValidos = false;
                        MessageBox.Show("Cantidad inválida para el producto " + nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (!decimal.TryParse(row.Cells[2].Value.ToString(), out precio))
                    {
                        datosValidos = false;
                        MessageBox.Show("Precio inválido para el producto " + nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    Producto producto = new Producto
                    {
                        Nombre = nombre,
                        Cantidad = cantidad,
                        Precio = precio,
                        Comentario = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty
                    };

                    // Agregar el producto a la lista de productos de la compra actual
                    productosCompra.Add(producto);

                    // Agregar el producto a la lista global de productos
                    listaProductos.Add(producto);
                }
                else if (!row.IsNewRow)
                {
                    datosValidos = false;
                    MessageBox.Show("Por favor, complete todos los campos para el producto en la fila " + (row.Index + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (datosValidos)
            {
                // Continuar con la inserción de la compra en dtgOrder
                int rowIndex = dtgOrder.Rows.Add();
                dtgOrder.Rows[rowIndex].Cells[0].Value = contador;
                dtgOrder.Rows[rowIndex].Cells[1].Value = cliente;
                dtgOrder.Rows[rowIndex].Cells[2].Value = totalItems;
                dtgOrder.Rows[rowIndex].Cells[3].Value = totalPrice;
                dtgOrder.Rows[rowIndex].Cells[4].Value = createdOrder;

                // Crear la compra
                Compra compra = new Compra
                {
                    IdCompra = contador,
                    IdCliente = ObtenerIdCliente(), // Este método debe obtener el ID del cliente de algún lado
                    Productos = productosCompra, // Usar la lista de productos de esta compra
                    PrecioTotal = totalPrice,
                    FechaRegistro = createdOrder
                };

                // Guardar la compra en una lista o en una base de datos
                GuardarCompra(compra);
                listaCompras.Add(compra);

                // Limpiar el DataGridView después de guardar la compra
                dtgOrderDetails.Rows.Clear();
                pOrderDetails.Visible = false;
            }
        }




        private void GuardarCompra(Compra compra)
        {
            // Implementar la lógica para guardar la compra en una lista o base de datos
            // Por ejemplo:
            List<Compra> listaCompras = new List<Compra>();
            listaCompras.Add(compra);
        }
        private int ObtenerIdCliente()
        {
            return contador;
        }


        private void btAddDetails_Click(object sender, EventArgs e)
        {
            pDtw.Visible = true;
        }
        private int currentRowIndex = -1;
        private void btPreviusDetails_Click(object sender, EventArgs e)
        {
            // Decrementar el índice para mostrar la fila anterior si es posible
            if (currentRowIndex > 0)
            {
                currentRowIndex--;
                MostrarFilaActual();
            }
            else
            {
                MessageBox.Show("Ya estás en la primera fila.");
            }
        }
        private void MostrarFilaActual()
        {// Verificar si el índice de la fila actual es válido
            if (currentRowIndex >= 0 && currentRowIndex < dtgOrderDetails.Rows.Count)
            {
                // Desplazar hasta la fila actual sin seleccionarla
                dtgOrderDetails.CurrentCell = dtgOrderDetails.Rows[currentRowIndex].Cells[0];

                // Hacer scroll para asegurarse de que la fila sea visible
                dtgOrderDetails.FirstDisplayedScrollingRowIndex = currentRowIndex;
            }
        }

        private void btNextOrder_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila actualmente seleccionada
            int currentRowIndex = dtgOrder.CurrentCell.RowIndex;

            // Calcular el índice de la siguiente fila
            int nextRowIndex = currentRowIndex + 1;

            // Verificar si estamos dentro de los límites de las filas
            if (nextRowIndex < dtgOrder.Rows.Count)
            {
                // Verificar si la fila siguiente no es nueva y tiene valores válidos
                if (!dtgOrder.Rows[nextRowIndex].IsNewRow &&
                    dtgOrder.Rows[nextRowIndex].Cells[0].Value != null)
                {
                    // Seleccionar la siguiente fila
                    dtgOrder.CurrentCell = dtgOrder.Rows[nextRowIndex].Cells[0];

                    // Mostrar los detalles de la compra seleccionada (simulando la búsqueda por número de orden)
                    MostrarDetallesCompra(nextRowIndex);
                }
                else
                {
                    MessageBox.Show("La fila siguiente no contiene datos válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ya estás en la última fila o no hay más filas disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MostrarDetallesCompra(int rowIndex)
        {
            // Obtener el número de orden de la fila seleccionada
            int numeroOrden = (int)dtgOrder.Rows[rowIndex].Cells[0].Value;

            // Buscar la compra correspondiente en listaCompras
            Compra compraEncontrada = listaCompras.FirstOrDefault(c => c.IdCompra == numeroOrden);

            if (compraEncontrada != null)
            {
                // Mostrar los detalles de la compra en el DataGridView de detalles (dtgOrderDetails)
                pOrderDetails.Visible = true;
                btAddDetails.Visible = false;
                btSave.Visible = false;

                dtgOrderDetails.Rows.Clear();
                foreach (Producto producto in compraEncontrada.Productos)
                {
                    int index = dtgOrderDetails.Rows.Add();
                    dtgOrderDetails.Rows[index].Cells[0].Value = producto.Nombre;
                    dtgOrderDetails.Rows[index].Cells[1].Value = producto.Cantidad;
                    dtgOrderDetails.Rows[index].Cells[2].Value = producto.Precio;
                    dtgOrderDetails.Rows[index].Cells[3].Value = producto.Comentario;
                }
            }
        }

        private void btPreviousOrder_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila actualmente seleccionada
            int currentRowIndex = dtgOrder.CurrentCell.RowIndex;

            // Calcular el índice de la fila anterior
            int previousRowIndex = currentRowIndex - 1;

            // Verificar si estamos dentro de los límites de las filas
            if (previousRowIndex >= 0)
            {
                // Seleccionar la fila anterior
                dtgOrder.CurrentCell = dtgOrder.Rows[previousRowIndex].Cells[0];

                // Mostrar los detalles de la compra seleccionada (simulando la búsqueda por número de orden)
                MostrarDetallesCompra(previousRowIndex);
            }
            else
            {
                // Manejar el caso en que ya no hay más filas hacia atrás
                MessageBox.Show("Ya estás en la primera fila.");
            }
        }

        private void btUpdateDetails_Click(object sender, EventArgs e)
        {
        }

        private void btSearchOrder_Click(object sender, EventArgs e)
        {
            int numeroOrden;
            if (int.TryParse(tbSearch.Text, out numeroOrden))
            {
                Compra compraEncontrada = listaCompras.FirstOrDefault(c => c.IdCompra == numeroOrden);

                if (compraEncontrada != null)
                {
                    // Mostrar los detalles de la compra en el DataGridView de detalles (dtgOrderDetails)
                    pOrderDetails.Visible = true;
                    btAddDetails.Visible = false;
                    btSave.Visible = false;
                    tbSearch.Text = "";

                    dtgOrderDetails.Rows.Clear();
                    foreach (Producto producto in compraEncontrada.Productos)
                    {
                        int rowIndex = dtgOrderDetails.Rows.Add();
                        dtgOrderDetails.Rows[rowIndex].Cells[0].Value = producto.Nombre;
                        dtgOrderDetails.Rows[rowIndex].Cells[1].Value = producto.Cantidad;
                        dtgOrderDetails.Rows[rowIndex].Cells[2].Value = producto.Precio;
                        dtgOrderDetails.Rows[rowIndex].Cells[3].Value = producto.Comentario;
                    }
                    

                }
                else
                {
                    MessageBox.Show("Orden no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pOrderDetails.Visible=false;
            btnClose.Visible = true;
            dtgOrderDetails.Rows.Clear();

        }

        private void pOrderDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pDtw_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btDetailsOrder_Click(object sender, EventArgs e)
        {

        }
        // Evento Click del botón de búsqueda por nombre de producto
        private void btSearchDetails_Click(object sender, EventArgs e)
        {
            string nombreProducto = tbSearchDetails.Text.Trim(); // Obtener el nombre del producto a buscar

            // Mostrar un mensaje de depuración para verificar que el evento se activa correctamente
            // Verificar si se ingresó un nombre de producto válido
            if (!string.IsNullOrEmpty(nombreProducto))
            {
                // Verificar si listaProductos está poblada y no es nula
                if (listaProductos != null && listaProductos.Count > 0)
                {
                    // Crear lista para almacenar productos encontrados
                    List<Producto> productosEncontrados = new List<Producto>();

                    // Recorrer lista de productos y buscar por nombre (insensible a mayúsculas y minúsculas)
                    foreach (var producto in listaProductos)
                    {
                        // Mostrar mensaje para depurar y verificar que el bucle se está ejecutando

                        if (producto.Nombre.IndexOf(nombreProducto, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            productosEncontrados.Add(producto);
                        }
                    }

                    // Mostrar los productos encontrados en el DataGridView
                    MostrarProductosEncontrados(productosEncontrados);
                }
                else
                {
                    // Mostrar mensaje si listaProductos está vacía o nula
                    MessageBox.Show("La lista de productos está vacía o no está inicializada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Si no se ingresó ningún nombre, mostrar mensaje informativo
                MessageBox.Show("Por favor, ingrese un nombre de producto para realizar la búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para mostrar productos encontrados en el DataGridView
        private void MostrarProductosEncontrados(List<Producto> productos)
        {
            // Limpiar el DataGridView antes de mostrar los resultados
            dtgOrderDetails.Rows.Clear();

            // Mostrar los productos encontrados en el DataGridView
            foreach (var producto in productos)
            {
                int rowIndex = dtgOrderDetails.Rows.Add();
                dtgOrderDetails.Rows[rowIndex].Cells[0].Value = producto.Nombre;
                dtgOrderDetails.Rows[rowIndex].Cells[1].Value = producto.Cantidad;
                dtgOrderDetails.Rows[rowIndex].Cells[2].Value = producto.Precio;
                dtgOrderDetails.Rows[rowIndex].Cells[3].Value = producto.Comentario;
                // Agregar más columnas según sea necesario
            }

            // Mostrar mensaje si no se encontraron productos
            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con el nombre especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }

}
