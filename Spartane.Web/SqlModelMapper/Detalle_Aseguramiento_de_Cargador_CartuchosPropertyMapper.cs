using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_de_Cargador_CartuchosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_de_Cargador_Cartuchos.Clave";
                case "Calibre[Descripcion]":
                case "CalibreDescripcion":
                    return "Calibre_de_Arma.Descripcion";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "cartuchos_municiones":
                    return "Detalle_Aseguramiento_de_Cargador_Cartuchos.cartuchos_municiones";
                case "Cartuchos_Habiles":
                    return "Detalle_Aseguramiento_de_Cargador_Cartuchos.Cartuchos_Habiles";
                case "Cartuchos_Percutidos":
                    return "Detalle_Aseguramiento_de_Cargador_Cartuchos.Cartuchos_Percutidos";
                case "cargadores":
                    return "Detalle_Aseguramiento_de_Cargador_Cartuchos.cargadores";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_de_Cargador_Cartuchos).GetProperty(columnName));
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

