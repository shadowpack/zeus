using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
namespace puntoDeVenta.Classes
{
    public interface IGraphicalAddon
    {
        String Name { get; }
        String NameText { get; }
        String Category { get; }
        String idProduct { get; }
        Boolean mdiStatus { get; }
        Image Image { get; }
        Form ParentForm { set; }
        Object SaycSetting { set; }
        DataSet DataSource { set; }
        void OnClick(Object sender, System.EventArgs e);
    }
}
