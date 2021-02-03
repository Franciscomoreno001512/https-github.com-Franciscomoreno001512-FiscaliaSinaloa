using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Robo_de_Vehiculo_PC;

namespace Spartane.Web.SqlModelMapper
{
    public class Robo_de_Vehiculo_PCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Robo_de_Vehiculo_PC.Clave";
                case "Solicitud[Folio]":
                case "SolicitudFolio":
                    return "Solicitud_de_Denuncia_Ciudadana.Folio";
                case "Tipo_de_Solicitud[Descripcion]":
                case "Tipo_de_SolicitudDescripcion":
                    return "Tipo_de_Solicitud.Descripcion";
                case "Robo_de_Vehiculo":
                    return "Robo_de_Vehiculo_PC.Robo_de_Vehiculo";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_del_Vehiculo.Descripcion";
                case "Sub_Marca[Descripcion]":
                case "Sub_MarcaDescripcion":
                    return "Sub_Marca_del_Vehiculo.Descripcion";
                case "Tipo_de_Vehiculo[Descripcion]":
                case "Tipo_de_VehiculoDescripcion":
                    return "Tipo_de_Vehiculo.Descripcion";
                case "Modelo":
                    return "Robo_de_Vehiculo_PC.Modelo";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_Vehiculo.Descripcion";
                case "Placas":
                    return "Robo_de_Vehiculo_PC.Placas";
                case "Senas_Particulares":
                    return "Robo_de_Vehiculo_PC.Senas_Particulares";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Robo_de_Vehiculo_PC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Robo_de_Vehiculo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

