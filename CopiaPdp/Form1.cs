using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CopiaPdp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPathOrigen_Click(object sender, EventArgs e)
        {
            obtenerPathOrigen();
        }

        private void btnPathDestino_Click(object sender, EventArgs e)
        {
            obtenerPathDestino();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtPathOrigen.Text)) || (string.IsNullOrEmpty(txtPathDestino.Text)))
            {
                MessageBox.Show("No pueden quedar vacios los Path Origen ni Destino");
                return;
            }
            crearCarpetasFaltantes(); //verifico si falta alguna carpeta en el destino, la creo

            
            copiar();
        }

        private void obtenerPathOrigen() //obtengo los archivos .rar con los pdp
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
        
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                dgvOrigen.Rows.Clear();
                txtPathOrigen.Text = dialog.SelectedPath;
                DirectoryInfo source = new DirectoryInfo(dialog.SelectedPath);

                FileInfo[] archivos = source.GetFiles();
               

                foreach(FileInfo info in archivos)
                {
                    
                    dgvOrigen.Rows.Add(Path.GetFileNameWithoutExtension(info.ToString()),Path.GetExtension(info.ToString())); //agrego el nombre sin la extencion
                }
               

            }
                       
        }

        private void obtenerPathDestino() //muestro las carpetas donde se van a copiar
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dgvDestino.Rows.Clear();
                txtPathDestino.Text = dialog.SelectedPath;
                DirectoryInfo source = new DirectoryInfo(dialog.SelectedPath);

                DirectoryInfo[] carpetas = source.GetDirectories();

                foreach (DirectoryInfo di in carpetas)
                {
                    dgvDestino.Rows.Add(di.ToString());
                }

            }
        }


        private void crearCarpetasFaltantes() //me fijo el nombre de los archivos y creo las carpetas faltantes
        {
            string path_o = @txtPathOrigen.Text;
            string path_d = @txtPathDestino.Text;
            int contador = 0; //variable para ver ctas carpetas voy a crear

            List<String> lista = new List<string>();

            for (int i = 0; i < dgvOrigen.RowCount; i++) //recorro la grilla origen
            {
                string fila_origen = dgvOrigen.Rows[i].Cells[0].Value.ToString();
                bool existe_carpeta = false; //variable para ver si la carpeta existe en el destino

                for (int j = 0; j < dgvDestino.RowCount; j++) //recorro la grilla destino
                {
                    string fila_destino = dgvDestino.Rows[j].Cells[0].Value.ToString();

                    if (string.Equals(fila_origen, fila_destino)) //si alguna fila de la grilla origen es igual a la del detino, avanzo
                    {
                        existe_carpeta = true;
                        break;
                    }
                }

                if(existe_carpeta==false) //si al recorrer toda la grilla de la carpeta destino no encontro una carpeta con el nombre del archivo
                {
                    lista.Add(fila_origen);
                    contador++;
                }
            }

            if(contador==0)
            {
                return;
            }

            if (MessageBox.Show("Se van a crear " + contador + " nuevas carpetas en destino. ¿Confirmar?", "Craer carpetas", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string nombre_carpeta_destino = "";

                foreach (string li in lista)
                {
                    nombre_carpeta_destino = Path.Combine(path_d, li);

                    if (!Directory.Exists(nombre_carpeta_destino)) //veo si existe la carpeta, si no la creo
                    {
                        Directory.CreateDirectory(nombre_carpeta_destino);
                    }
                }

                dgvDestino.Rows.Clear();

                DirectoryInfo source = new DirectoryInfo(@txtPathDestino.Text);

                DirectoryInfo[] carpetas = source.GetDirectories();

                foreach (DirectoryInfo di in carpetas)
                {
                    dgvDestino.Rows.Add(di.ToString());
                }
            }
            else
            {
                MessageBox.Show("Carpetas no creadas");
                return;
            }
        }


        private void copiar() //preparo la ruta origen y la destino
        {
            string full_path_origen = "";
            string full_path_destino = "";
            DateTime date = DateTime.Now;
            string fecha = date.ToShortDateString();
            string fecha_final = fecha.Replace("/", "");

            pbProgreso.Maximum = dgvOrigen.RowCount;
            progreso("Iniiciando", 0);


            for (int i=0; i<dgvOrigen.RowCount;i++)
            {
                full_path_origen = @txtPathOrigen.Text + "\\"+ dgvOrigen.Rows[i].Cells[0].Value.ToString() + dgvOrigen.Rows[i].Cells[1].Value.ToString();

                for(int j=0; j<dgvDestino.RowCount;j++)
                {
                    //full_path_destino = lo que hay en el txt destino + la carpeta destino + nombre origen + fecha + extencion
                    full_path_destino = @txtPathDestino.Text + "\\" + dgvDestino.Rows[j].Cells[0].Value.ToString() + "\\" + dgvOrigen.Rows[i].Cells[0].Value.ToString() + "_" + fecha_final + dgvOrigen.Rows[i].Cells[1].Value.ToString();
                    if (string.Equals(dgvOrigen.Rows[i].Cells[0].Value.ToString(),dgvDestino.Rows[j].Cells[0].Value.ToString() )) //si el archivo es igual a la carpeta, copio el archivo
                    {
                        if(File.Exists(full_path_destino))
                        {
                            string nuevo_nom = nuevoNombre(@txtPathDestino.Text + "\\" + dgvDestino.Rows[j].Cells[0].Value.ToString(),dgvOrigen.Rows[i].Cells[0].Value.ToString() + "_" + fecha_final);
                            string nuevo_pa = @txtPathDestino.Text + "\\" + dgvDestino.Rows[j].Cells[0].Value.ToString() + "\\" + nuevo_nom + dgvOrigen.Rows[i].Cells[1].Value.ToString();

                            try
                            {
                                File.Copy(full_path_origen, nuevo_pa, false);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Error al copiar el archivo " + full_path_origen + ". Todos los archivos siguientes a éste no se van a copiar", "Error");
                                return;
                            }
                        }
                        else
                        {
                            try
                            {
                                File.Copy(full_path_origen, full_path_destino, false);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Error al copiar el archivo " + full_path_origen + ". Todos los archivos siguientes a éste no se van a copiar", "Error");
                                return;
                            }
                            
                        }
                        break;
                    }
                }
                progreso(string.Format("posicion {0}...", i), i);
            }
            progreso("Fin", dgvOrigen.RowCount);
            MessageBox.Show("Todos los archivos fueron copiados","Fin copiado");
        }

        private string nuevoNombre(string directorio, string nombre_archivo)
        {
            string nuevo_nombre = nombre_archivo;
            int con = 0;
           
            DirectoryInfo source = new DirectoryInfo(directorio);

            FileInfo[] archivos = source.GetFiles();


            for(int i=0;i<archivos.Length;i++)
            {
                if(string.Equals(nuevo_nombre, Path.GetFileNameWithoutExtension(archivos[i].ToString())))
                {
                    i = -1;
                    con++;
                    nuevo_nombre = nombre_archivo + "("+con + ")";
                }
            }
         

            return nuevo_nombre;
        }


        delegate void CambiarProgresoDelegado(string texto, int valor);

        private void progreso(string texto, int valor)
        {
            if (this.InvokeRequired) //preguntamos si la llamada se hace desde un hilo 
            {
                //si es así entonces volvemos a llamar a CambiarProgreso pero esta vez a través del delegado 
                //instanciamos el delegado indicandole el método que va a ejecutar 
                CambiarProgresoDelegado delegado = new CambiarProgresoDelegado(progreso);
                //ya que el delegado invocará a CambiarProgreso debemos indicarle los parámetros 
                object[] parametros = new object[] { texto, valor };
                //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                this.Invoke(delegado, parametros);
            }
            else
            {
                //en caso contrario, se realiza el llamado a los controles 
                lblTrabajando.Text = texto;
                pbProgreso.Value = valor;
            }

        }

    }
}
