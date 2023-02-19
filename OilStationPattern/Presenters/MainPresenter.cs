using OilStationPattern.Data;
using OilStationPattern.Models;
using OilStationPattern.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OilStationPattern.Presenters
{

    public class MainPresenter
    {
        public List<Oil> oils = new List<Oil>()
            {
                new Oil()
                {
                    OilName="AI-92",
                    Price=1
                },
                new Oil()
                {
                    OilName="AI-95",
                    Price=2
                },
                new Oil()
                {
                    OilName="AI-98",
                    Price=2.3M
                },
                new Oil()
                {
                    OilName="Diesel",
                    Price=0.8M
                }
            };
        private readonly IMainView _view;
        private readonly OilContext _db;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _db = new OilContext();
            
            // _view.OilComboBoxText.Items.Add(oil1);
            //if (_db.Oils.Any(d => d.OilId != oil1.OilId && d.OilId != oil2.OilId))
            //{
            //
            _view.SelectionChange += ViewSelectionChange;
            _view.LoadMain += ViewLoadMain;
           
        }

        private void ViewLoadMain(object sender, EventArgs e)
        {
            var oil1 = new Oil
            {
                OilName = "AI-92",
                Price = 1
            };
            var oil2 = new Oil
            {
                OilName = "AI-95",
                Price = 2
            };
            _db.Oils.Add(oil1);
            _db.Oils.Add(oil2);

            _db.SaveChanges();
            var myoils = _db.Oils.ToList();
            _view.Oils = myoils;
        }

        private void ViewSelectionChange(object sender, EventArgs e)
        {
            
            var oil = _view.SelectedOil;
            _view.PriceText = oil.Price.ToString();
        }
    }
}
