using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Drawing2D;

namespace CapturaWebcam
{
    public partial class Frm_Index : Form
    {
        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        private String ruta = null;
        private string nameFile = null;


        /*
         *  Inicialización
         */
        public Frm_Index()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        /*
         *  Carga del formulario
         */
        private void Frm_Index_Load(object sender, EventArgs e)
        {
            
        }

        /*
         *  Cerrando el formulario (evento)
         */
        private void Frm_Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            CerrarFormulario();
        }

        /*
         *  Cerrar el formulario
         */
        private void CerrarFormulario()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
            Dispose();
            Close();
        }
        private void closeConection()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
        }




        /*
         *  Botón de Capturar
         */
        private void btn_capturar_Click(object sender, EventArgs e)
        {
            if (existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CerrarFormulario();
            }
        }

        /*
         *  Botón de Guardar
         */
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Capturar();
            fotografiaHecha = true;
            closeConection();
            
        }









        /*
         *  Identifica los dispositivos disponibles
         */
        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;
        }

        /*
         *  Muestra imagen en el PictureBox
         */
        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)RedimensionarImagen((Image)eventArgs.Frame.Clone(), new Size(300, 300));
            pctbox_webcam.Image = imagen;
        }

        /*
         *  Deja de capturar imágenes, obteniendo la última capturada
         */
        private void Capturar()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    pctbox_webcam.Image = pctbox_webcam.Image;
                }
            }
        }
        public void setName(string name)
        {
            this.nameFile = name;
        }
        public void setPath(string path)
        {
            this.ruta = path;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (fotografiaHecha)
            {
                // Recorto la imagen conforme lo mostrado (Size del pctbox_webcam)
                Rectangle formaRecorte = new Rectangle(0, 0, 300, 300);
                Bitmap imagenOrigen = (Bitmap)pctbox_webcam.Image;
                Bitmap imagen = imagenOrigen.Clone(formaRecorte, imagenOrigen.PixelFormat);

                // Y la guardo
                try
                {
                    String ruta = this.ruta.Trim();
                    if (!ruta.Substring(ruta.Length - 1).Equals("\\"))
                        ruta += "\\";
                    ruta += this.nameFile;
                    imagen.Save(ruta);

                    MessageBox.Show("Fotografía almacenada", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Para guardar la fotografía, use en primer lugar el botón de Captura", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public Boolean getPhotoStatus()
        {
            if (this.fotografiaHecha)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Image RedimensionarImagen(Image img, Size _Dimensiones)
        {
            if (img == null || _Dimensiones == null)
                //No hay con qué trabajar
                return null;

            //Obtenemos las dimensiones de salida deseadas
            int destAncho = _Dimensiones.Width;
            int destAlto = _Dimensiones.Height;

            //Creamos un objeto Bitmap con las dimensiones que obtuvimos en la instrucción anterior
            Bitmap b = new Bitmap(destAncho, destAlto);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //Dibujamos la imagen con las nuevas dimensiones
            g.DrawImage(img, 0, 0, destAncho, destAlto);
            g.Dispose();

            //Finalmente retornamos esa imagen (=
            return (Image)b;
        }

    }
}
