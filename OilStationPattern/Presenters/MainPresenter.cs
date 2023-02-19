using OilStationPattern.Data;
using OilStationPattern.Models;
using OilStationPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OilStationPattern.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly OilContext _db;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            _view.SelectionChange += ViewSelectionChange;
        }
        private void ViewSelectionChange(object sender, EventArgs e)
        {
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }
    }
}
