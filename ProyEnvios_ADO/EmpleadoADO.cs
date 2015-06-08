using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_BE;
using System.Data.Entity;

namespace ProyEnvios_ADO
{
    public class EmpleadoADO
    {
        Boolean vexito = false;
        public List<EmpleadoBE> ListarEmpleado()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EmpleadoBE> objListarEmpleado = new List<EmpleadoBE>();

            try
            {
                var query = MisCargos.usp_ListarEmpleado();
                foreach (var emplea in query)
                {
                    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                    objEmpleadoBE.Idempleado = emplea.IDEmpleado;
                    objEmpleadoBE.Razon_Social = emplea.Razon_Social;
                    objEmpleadoBE.FechaNacimiento = Convert.ToDateTime(emplea.FechaNacimiento);
                    objEmpleadoBE.Direccion = emplea.Direccion;
                    objEmpleadoBE.Telefono = emplea.Telefono;
                    objEmpleadoBE.Dni = Convert.ToInt32(emplea.DNI);
                    objEmpleadoBE.Sexo = emplea.Sexo;
                    objEmpleadoBE.Usuario = emplea.Usuario;
                    objEmpleadoBE.Pass = emplea.Pass;

                    objListarEmpleado.Add(objEmpleadoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarEmpleado;
        }

        public bool InsertarEmpleado(EmpleadoBE objEmpBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Empleado objEmp = new tb_Empleado();

                objEmp.IDEmpleado = String.Empty;
                objEmp.Nombre = objEmpBE.Nombre;
                objEmp.Apellido_pat = objEmpBE.Apellido_pat;
                objEmp.Apellido_mat = objEmpBE.Apellido_mat;
                objEmp.FechaNacimiento = Convert.ToDateTime(objEmpBE.FechaNacimiento);
                objEmp.Direccion = objEmpBE.Direccion;
                objEmp.Telefono = objEmpBE.Telefono;
                objEmp.DNI = Convert.ToInt32(objEmpBE.Dni);
                objEmp.Sexo = objEmpBE.Sexo;
                objEmp.Usuario = objEmpBE.Usuario;
                objEmp.Pass = objEmpBE.Pass;
                objEmp.foto = objEmpBE.Foto;

                MisCargos.tb_Empleado.Add(objEmp);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }
    }
}
