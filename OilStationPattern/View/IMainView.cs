using OilStationPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationPattern.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> SelectionChange { get; set; }
        List<Oil> Oils { set; }
        Oil SelectedOil { get; }
        string PriceText { get; set; }
        string QuantityText { get; set; }
        string QuantumText { get; set; }
        string TotalAmountText { get; set; }
    }
}
