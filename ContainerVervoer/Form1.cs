using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerVervoer.Models;


namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private Service _service;
        private readonly List<Models.Container> _containers;
        private int _count;
        public Form1()
        {
            InitializeComponent();
            _containers = new List<Models.Container>();
            btnAdd.Enabled = false;
            btnBegin.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var weight = Convert.ToDouble(nudContainerWeight.Value);
            var valuable = rbValuable.Checked;
            var cooled = rbCooled.Checked;

            // Making container
            var container = new Models.Container(valuable, cooled, weight);
            _containers.Add(container);

            // Visualise container
            lbContainers.Items.Add(container.ToString());
            _count++;
            lblCount.Text = _count.ToString();
            btnBegin.Enabled = true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            var weight = ndShipWeight.Value;
            _service = new Service(6, Convert.ToDouble(weight));

            btnAdd.Enabled = true;
            btnSet.Enabled = false;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            try { _service.QuickChecker(_containers); }
            catch (ExceptionHandler exceptionHandler) { rbxLog.Text = exceptionHandler.Message; return; }
            rbxLog.Text = @"Started..";

            try { _service.SetContainers(_containers); }
            catch (ExceptionHandler exceptionHandler) { rbxLog.Text = exceptionHandler.Message; return; }

            lblPlace1.DataSource = _service.GetPlaces()[0].Containers;
            lblPlace2.DataSource = _service.GetPlaces()[1].Containers;
            lblPlace3.DataSource = _service.GetPlaces()[2].Containers;
            lblPlace4.DataSource = _service.GetPlaces()[3].Containers;
            lblPlace5.DataSource = _service.GetPlaces()[4].Containers;
            lblPlace6.DataSource = _service.GetPlaces()[5].Containers;

            lblFullWeight.Text = Convert.ToString(_service.CalculateWeight(), CultureInfo.InvariantCulture);
            lblBalance.Text = Convert.ToString(_service.GetShipBalance(), CultureInfo.InvariantCulture);

            btnBegin.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;

            rbxLog.Text = @"Done! Reset to start again.";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbContainers.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show(@"Please select container");
                return;
            }
            lbContainers.Items.RemoveAt(index);
            _containers.RemoveAt(index);
            _count--;
            lblCount.Text = _count.ToString();
        }

        private void TsmiFileReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
