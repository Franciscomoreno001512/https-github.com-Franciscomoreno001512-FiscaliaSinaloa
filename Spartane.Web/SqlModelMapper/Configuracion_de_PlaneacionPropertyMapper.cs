using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Configuracion_de_Planeacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Configuracion_de_PlaneacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Configuracion_de_Planeacion.Folio";
                case "Categoria[Descripcion]":
                case "CategoriaDescripcion":
                    return "Categoria_de_Servicio_de_Apoyo.Descripcion";
                case "Servicio[Servicio]":
                case "ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Entregable":
                    return "Configuracion_de_Planeacion.Entregable";
                case "Tiempo_Estandar":
                    return "Configuracion_de_Planeacion.Tiempo_Estandar";
                case "Ponderacion":
                    return "Configuracion_de_Planeacion.Ponderacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Configuracion_de_Planeacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


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

