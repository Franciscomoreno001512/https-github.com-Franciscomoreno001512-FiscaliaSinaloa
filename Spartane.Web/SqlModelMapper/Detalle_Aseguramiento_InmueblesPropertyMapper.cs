using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_InmueblesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Inmuebles.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Zona[Descripcion]":
                case "ZonaDescripcion":
                    return "Tipo_de_Zona.Descripcion";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Inmueble.Descripcion";
                case "Calle":
                    return "Detalle_Aseguramiento_Inmuebles.Calle";
                case "Exterior":
                    return "Detalle_Aseguramiento_Inmuebles.Exterior";
                case "Interior":
                    return "Detalle_Aseguramiento_Inmuebles.Interior";
                case "C_P":
                    return "Detalle_Aseguramiento_Inmuebles.C_P";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Registro_Publico_Propiedad":
                    return "Detalle_Aseguramiento_Inmuebles.Registro_Publico_Propiedad";
                case "Entrecalles":
                    return "Detalle_Aseguramiento_Inmuebles.Entrecalles";
                case "Propietario":
                    return "Detalle_Aseguramiento_Inmuebles.Propietario";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Inmuebles.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Inmuebles).GetProperty(columnName));
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

