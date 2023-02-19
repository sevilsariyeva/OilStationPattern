﻿using OilStationPattern.Models;
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
        EventHandler<EventArgs> LoadMain { get; set; }
        Oil SelectedOil { get; }
        List<Oil> Oils { set; }
        ComboBox OilComboBoxText { get; set; }
        string PriceText { get; set; }
        string QuantityText { get; set; }
        string QuantumText { get; set; }
        string TotalAmountText { get; set; }
    }
}
