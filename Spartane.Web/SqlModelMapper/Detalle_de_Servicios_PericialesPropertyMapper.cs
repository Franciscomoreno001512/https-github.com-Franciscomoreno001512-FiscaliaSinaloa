using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Servicios_Periciales;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Servicios_PericialesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Servicios_Periciales.Clave";
                case "Servicio[Servicio]":
                case "ServicioServicio":
                    return "Servicios_Periciales.Servicio";
                case "Especialista":
                    return "Detalle_de_Servicios_Periciales.Especialista";
                case "Estatus_del_Dictamen[Descripcion]":
                case "Estatus_del_DictamenDescripcion":
                    return "Estatus_del_Dictamen.Descripcion";
                case "Observaciones":
                    return "Detalle_de_Servicios_Periciales.Observaciones";
                case "Fecha_del_Dictamen":
                    return "Detalle_de_Servicios_Periciales.Fecha_del_Dictamen";
                case "Dictamen":
                    return "Detalle_de_Servicios_Periciales.Dictamen";
                case "Rol_de_Donde_Proviene[Descripcion]":
                case "Rol_de_Donde_ProvieneDescripcion":
                    return "Rol_de_Diligencia.Descripcion";
                case "ObservacionesD":
                    return "Detalle_de_Servicios_Periciales.ObservacionesD";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Servicios_Periciales).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_del_Dictamen")
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

