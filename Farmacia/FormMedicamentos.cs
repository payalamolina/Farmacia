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
    public partial class FormMedicamentos : Form
    {
        MedicamentosBL _medicamentos;

        public FormMedicamentos()
        {
            InitializeComponent();

            _medicamentos = new MedicamentosBL();

            listaMedicamentosBindingSource.DataSource = _medicamentos.ObtenerMedicamentos();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void listaMedicamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMedicamentosBindingSource.EndEdit();

            var medicamento1 = (Medicamento)listaMedicamentosBindingSource.Current;

            var resultado = _medicamentos.GuardarMedicamento(medicamento1);

            if (resultado.Exitoso == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarbotones(true);
                MessageBox.Show("Medicamento Guardado");
            }
            else
            {
                MessageBox.Show (resultado.Mensaje);
            }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _medicamentos.AgregarMedicamento();
            listaMedicamentosBindingSource.MoveLast();

            DeshabilitarHabilitarbotones(false);

        }

        private void DeshabilitarHabilitarbotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este medicamento?", "Eliminar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {

                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);

                }
            }        
        }
        

        private void Eliminar(int id)
        {
            
            var resultado = _medicamentos.EliminarMedicamentos(id);

            if (resultado == true)
            {
                listaMedicamentosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la eliminacion");

            }

        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarbotones(true);
            Eliminar(0);
        }

        private void FormMedicamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
