using BL.Farmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FormReporteMedicamentos : Form
    {
        public FormReporteMedicamentos()
        {
            InitializeComponent();

            var _medicamentoBL = new MedicamentosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _medicamentoBL.ObtenerMedicamentos();

            var reporte = new ReporteMedicamentos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
