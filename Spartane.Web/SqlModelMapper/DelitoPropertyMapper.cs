using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Delito;

namespace Spartane.Web.SqlModelMapper
{
    public class DelitoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Delito.Clave";
                case "Titulo_del_Delito[Descripcion]":
                case "Titulo_del_DelitoDescripcion":
                    return "Titulo_del_Delito.Descripcion";
                case "Grupo_del_Delito[Descripcion]":
                case "Grupo_del_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Descripcion":
                    return "Delito.Descripcion";
                case "Grave":
                    return "Delito.Grave";
                case "Alto_Impacto":
                    return "Delito.Alto_Impacto";
                case "Alta_Incidencia":
                    return "Delito.Alta_Incidencia";
                case "Tentativa":
                    return "Delito.Tentativa";
                case "Activo":
                    return "Delito.Activo";
                case "Robo_de_Vehiculo":
                    return "Delito.Robo_de_Vehiculo";
                case "delitox":
                    return "Delito.delitox";
                case "ARTICULO":
                    return "Delito.ARTICULO";
                case "DETALLE":
                    return "Delito.DETALLE";
                case "TIPO_AGENCIA":
                    return "Delito.TIPO_AGENCIA";
                case "ESTADISTICO_SSP":
                    return "Delito.ESTADISTICO_SSP";
                case "VAL_VEHICULO":
                    return "Delito.VAL_VEHICULO";
                case "TIPO_DELITO":
                    return "Delito.TIPO_DELITO";
                case "circunstancia_clasif":
                    return "Delito.circunstancia_clasif";
                case "PRINCIPAL":
                    return "Delito.PRINCIPAL";
                case "orden":
                    return "Delito.orden";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Delito).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Grave")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Alto_Impacto")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Alta_Incidencia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Tentativa")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Activo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
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

