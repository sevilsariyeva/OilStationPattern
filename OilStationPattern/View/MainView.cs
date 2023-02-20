using OilStationPattern.Models;
using OilStationPattern.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilStationPattern
{
    public partial class MainView : Form, IMainView
    {
        //public List<Oil> oils = new List<Oil>()
        //    {
        //        new Oil()
        //        {
        //            OilName="AI-92",
        //            Price=1
        //        },
        //        new Oil()
        //        {
        //            OilName="AI-95",
        //            Price=2
        //        },
        //        new Oil()
        //        {
        //            OilName="AI-98",
        //            Price=2.3M
        //        },
        //        new Oil()
        //        {
        //            OilName="Diesel",
        //            Price=0.8M
        //        }
        //    };
        public MainView()
        {
            InitializeComponent();
           //oilComboBox.Items.AddRange(oils.ToArray());            
        }
        public EventHandler<EventArgs> SelectionChange { get; set ; }
        public EventHandler<EventArgs> LoadMain { get; set ; }
        public EventHandler<EventArgs> QuantityChange { get; set ; }
        public EventHandler<EventArgs> QuantumChange { get; set ; }

        public Oil SelectedOil {
            get
            {
                return oilComboBox.SelectedItem as Oil;
            } 
        }

        public List<Oil> Oils
        {
            set
            {
                oilComboBox.DataSource = null;
                oilComboBox.DataSource = value;
            }
        }

        public string PriceText { get => priceLbl.Text; set => priceLbl.Text = value; }
        public string QuantityText { get => quantityTxtb.Text; set => quantityTxtb.Text = value; }
        public string QuantumText { get => quantumTxtb.Text; set => quantumTxtb.Text = value; }
        public string TotalAmountText { get => totalamountLbl.Text; set => totalamountLbl.Text = value; }
        private void oilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChange.Invoke(sender, e);
        }


        private void MainView_Load(object sender, EventArgs e)
        {
            LoadMain.Invoke(sender, e);
        }


        private void quantityTxtb_TextChanged(object sender, EventArgs e)
        {
            QuantityChange.Invoke(sender, e);
        }


        private void priceLbl_TextChanged(object sender, EventArgs e)
        {
            QuantityChange.Invoke(sender, e);
        }

        private void quantumTxtb_TextChanged(object sender, EventArgs e)
        {
            QuantumChange.Invoke(sender, e);
        }
        public bool Quantity { get; set; } = false;
        private void quantityBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Quantity)
            {
                quantityTxtb.Enabled = true;
            }
            else
            {
                quantityTxtb.Enabled = false;
            }
            Quantity = !Quantity;
        }

        public bool Quantum { get; set; } = false;
        private void quantumBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Quantum)
            {
                quantumTxtb.Enabled = true;
            }
            else
            {
                quantumTxtb.Enabled = false;
            }
            Quantum = !Quantum;
        }
    }
}
