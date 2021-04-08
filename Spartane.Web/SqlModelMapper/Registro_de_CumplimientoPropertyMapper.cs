using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Cumplimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_CumplimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Cumplimiento.Clave";
                case "Mandamiento_Judicial[Numero_de_Mandamiento]":
                case "Mandamiento_JudicialNumero_de_Mandamiento":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento";
                case "Fecha_de_Registro":
                    return "Registro_de_Cumplimiento.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Registro_de_Cumplimiento.Hora_de_Registro";
                case "Usuario_de_Registro[Name]":
                case "Usuario_de_RegistroName":
                    return "Spartan_User.Name";
                case "Resolucion[Descripcion]":
                case "ResolucionDescripcion":
                    return "Resolucion_de_Mandamiento_Judicial.Descripcion";
                case "Fecha_de_Resolucion":
                    return "Registro_de_Cumplimiento.Fecha_de_Resolucion";
                case "Numero_de_Oficio":
                    return "Registro_de_Cumplimiento.Numero_de_Oficio";
                case "Radiograma":
                    return "Registro_de_Cumplimiento.Radiograma";
                case "Partida_que_cumplimenta[Descripcion]":
                case "Partida_que_cumplimentaDescripcion":
                    return "Partida_que_Cumplimenta.Descripcion";
                case "Area_que_envia_cumplimiento[Descripcion]":
                case "Area_que_envia_cumplimientoDescripcion":
                    return "Area_envia_Cumplimiento.Descripcion";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Observaciones_del_Cumplimiento":
                    return "Registro_de_Cumplimiento.Observaciones_del_Cumplimiento";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Cumplimiento).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
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

