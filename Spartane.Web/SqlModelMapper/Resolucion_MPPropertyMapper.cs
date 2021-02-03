using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Resolucion_MP;

namespace Spartane.Web.SqlModelMapper
{
    public class Resolucion_MPPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Resolucion_MP.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Resolucion":
                    return "Resolucion_MP.Fecha_de_Resolucion";
                case "Persona_que_Resuelve[Name]":
                case "Persona_que_ResuelveName":
                    return "Spartan_User.Name";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Resolucion.Descripcion";
                case "Resolucion[Descripcion]":
                case "ResolucionDescripcion":
                    return "Resolucion.Descripcion";
                case "Juzgado[Nombre]":
                case "JuzgadoNombre":
                    return "Juzgado.Nombre";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Judicializacion.Descripcion";
                case "No__De_Causa_o_Cuadernillo":
                    return "Resolucion_MP.No__De_Causa_o_Cuadernillo";
                case "Ano_de_Causa_o_Cuadernillo[Descripcion]":
                case "Ano_de_Causa_o_CuadernilloDescripcion":
                    return "Ano.Descripcion";
                case "Observaciones":
                    return "Resolucion_MP.Observaciones";
                case "Fecha_de_Validacion":
                    return "Resolucion_MP.Fecha_de_Validacion";
                case "Hora_de_Validacion":
                    return "Resolucion_MP.Hora_de_Validacion";
                case "Dictaminador[Name]":
                case "DictaminadorName":
                    return "Spartan_User.Name";
                case "Resultado_de_Validacion[Descripcion]":
                case "Resultado_de_ValidacionDescripcion":
                    return "Resolucion.Descripcion";
                case "Observaciones_Dictaminador":
                    return "Resolucion_MP.Observaciones_Dictaminador";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Resolucion_MP).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Resolucion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Validacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }


            var operatorCondition = GetOperationType(columnName);
            columnName = GetPropertyName(columnName);

            switch (operatorCondition)
            {
                case SqlOperationType.Contains:
                    return string.IsNullOrEmpty(Convert.ToString(value)) ? "" : columnName + " LIKE '%" + value + "%'";
                case SqlOperationType.Equals:
                    return Convert.ToString(value) == "0" || Convert.ToString(value) == "" ? "" : columnName + "='" + value + "'";

            }
            return null;
        }
    }
}

