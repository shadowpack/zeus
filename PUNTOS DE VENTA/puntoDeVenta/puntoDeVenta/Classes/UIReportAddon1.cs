using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using puntoDeVenta.Forms;
namespace puntoDeVenta.Classes
{
    class UIReportAddon1 : IGraphicalAddon
    {
        private DataSet _dataSource;
        private Form _parentForm;
        private Object _saycSetting;
        public DataSet DataSource {
            set {
                this._dataSource = value;
            }
        }
        public String Name {
            get {
                return "PVenta";
            }
        }
        public String NameText{
            get {
                return "Punto de Venta";
            }
        }
        public String idProduct{
            get {
                return "B101";
            }
        }
        public String Category {
            get{
                return "Ventas";
            }
        }
        public Boolean mdiStatus{
            get{
                return false;
            }
        }
        public Image Image{
            get{
                return null;
            }
        }
        public Form ParentForm{
            set{
                this._parentForm = value;
            }
        }
        public Object SaycSetting{
            set{
                this._saycSetting = value;
            }
        }
        public void onClick(Object sender, System.EventArgs e){
            PuntoVenta newUiReportingAddonForm = new PuntoVenta(this._saycSetting);
            if(this.mdiStatus){
                newUiReportingAddonForm.MdiParent = this._parentForm;
                newUiReportingAddonForm.MaximizeBox = true;
            }
            newUiReportingAddonForm.ShowDialog();
        }   
    }
}
