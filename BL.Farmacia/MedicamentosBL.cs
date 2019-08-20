using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Farmacia
{
    public class MedicamentosBL
    {

        Contexto _contexto;

        public BindingList<Medicamento> listaMedicamentos { get; set; }

        public MedicamentosBL()
        {

            _contexto = new Contexto();

            listaMedicamentos = new BindingList<Medicamento>();           
        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {

            _contexto.Medicamentos.Load();
            listaMedicamentos = _contexto.Medicamentos.Local.ToBindingList();

            return listaMedicamentos;
        }

        public Resultado GuardarMedicamento(Medicamento medicamento1)
        {
            var resultado = Validar(medicamento1);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarMedicamento()
        {
            var nuevoMedicamento = new Medicamento();
            listaMedicamentos.Add(nuevoMedicamento);
        }

        public bool EliminarMedicamentos(int id)
        {
            foreach (var medicamento in listaMedicamentos)
            {
                if (medicamento.Id == id)
                {
                    listaMedicamentos.Remove(medicamento);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Medicamento medicamento1)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(medicamento1.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }

            if (medicamento1.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }


            if (medicamento1.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;

        }

    }
    public class Medicamento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }

    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
 }
  
 


