using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Farmacia
{
    public class MedicamentosBL
    {
        public BindingList<Medicamento> listaMedicamentos { get; set; }

        public MedicamentosBL()
        {
            listaMedicamentos = new BindingList<Medicamento>();

            var medicamento1 = new Medicamento();

            medicamento1.Id = 1;
            medicamento1.Descripcion = "Aspirina";
            medicamento1.Precio = 10;
            medicamento1.Existencia = 120;
            medicamento1.Activo = true;

            var medicamento2 = new Medicamento();

            medicamento2.Id = 2;
            medicamento2.Descripcion = "Amoxicilina";
            medicamento2.Precio = 25;
            medicamento2.Existencia = 150;
            medicamento2.Activo = true;

            var medicamento3 = new Medicamento();

            medicamento3.Id = 3;
            medicamento3.Descripcion = "Panadol";
            medicamento3.Precio = 7;
            medicamento3.Existencia = 80;
            medicamento3.Activo = true;

            listaMedicamentos.Add(medicamento1);
            listaMedicamentos.Add(medicamento2);
            listaMedicamentos.Add(medicamento3);
        }

        public BindingList<Medicamento> ObtenerMedicamentos()
        {
            return listaMedicamentos;
        }

        public Resultado GuardarMedicamento(Medicamento medicamento1)
        {
            var resultado = Validar(medicamento1);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (medicamento1.Id == 0)
            {
                medicamento1.Id = listaMedicamentos.Max(item => item.Id) + 1;
            }

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
  
 


