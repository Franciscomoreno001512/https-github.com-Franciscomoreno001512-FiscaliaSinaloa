using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Diligencias;

namespace Spartane.Web.SqlModelMapper
{
    public class DiligenciasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Fecha_de_Registro":
                    return "Diligencias.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Diligencias.Hora_de_Registro";
                case "Servicio[Servicio]":
                case "ServicioServicio":
                    return "Servicios_Periciales.Servicio";
                case "Especialista":
                    return "Diligencias.Especialista";
                case "Estatus_del_Dictamen[Descripcion]":
                case "Estatus_del_DictamenDescripcion":
                    return "Estatus_del_Dictamen.Descripcion";
                case "Fecha_del_Dictamen":
                    return "Diligencias.Fecha_del_Dictamen";
                case "Dictamen":
                    return "Diligencias.Dictamen";
                case "Rol_de_Donde_Proviene[Descripcion]":
                case "Rol_de_Donde_ProvieneDescripcion":
                    return "Rol_de_Diligencia.Descripcion";
                case "Clave":
                    return "Diligencias.Clave";
                case "Clave_Diligencia":
                    return "Diligencias.Clave_Diligencia";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Diligencias).GetProperty(columnName));
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

