using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Plan_Actos_de_InvestigacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Plan_Actos_de_Investigacion.Clave";
                case "Categoria[Descripcion]":
                case "CategoriaDescripcion":
                    return "Categoria_de_Servicio_de_Apoyo.Descripcion";
                case "Servicio_a_Solicitar[Servicio]":
                case "Servicio_a_SolicitarServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Hecho_Delictivo_Acreditado":
                    return "Detalle_Plan_Actos_de_Investigacion.Hecho_Delictivo_Acreditado";
                case "Tiempo_Estandar":
                    return "Detalle_Plan_Actos_de_Investigacion.Tiempo_Estandar";
                case "Ponderacion":
                    return "Detalle_Plan_Actos_de_Investigacion.Ponderacion";
                case "Fecha_Contestacion":
                    return "Detalle_Plan_Actos_de_Investigacion.Fecha_Contestacion";
                case "Hora_Contestacion":
                    return "Detalle_Plan_Actos_de_Investigacion.Hora_Contestacion";
                case "Contestacion":
                    return "Detalle_Plan_Actos_de_Investigacion.Contestacion";
                case "Usuario_que_Contesta[Name]":
                case "Usuario_que_ContestaName":
                    return "Spartan_User.Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Plan_Actos_de_Investigacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_Contestacion")
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

