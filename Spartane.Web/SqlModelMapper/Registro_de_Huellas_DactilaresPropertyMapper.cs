using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Huellas_Dactilares;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_Huellas_DactilaresPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Huellas_Dactilares.Clave";
                case "Carpeta_de_Investigacion[nic]":
                case "Carpeta_de_Investigacionnic":
                    return "expediente_ministerio_publico.nic";
                case "Probable_Responsable[Nombre_Completo]":
                case "Probable_ResponsableNombre_Completo":
                    return "Detalle_de_Datos_Generales.Nombre_Completo";
                case "Izquierda_Menique":
                    return "Registro_de_Huellas_Dactilares.Izquierda_Menique";
                case "Izquierda_Anular":
                    return "Registro_de_Huellas_Dactilares.Izquierda_Anular";
                case "Izquierda_Medio":
                    return "Registro_de_Huellas_Dactilares.Izquierda_Medio";
                case "Izquierda_Indice":
                    return "Registro_de_Huellas_Dactilares.Izquierda_Indice";
                case "Izquierda_Pulgar":
                    return "Registro_de_Huellas_Dactilares.Izquierda_Pulgar";
                case "Derecha_Menique":
                    return "Registro_de_Huellas_Dactilares.Derecha_Menique";
                case "Derecha_Anular":
                    return "Registro_de_Huellas_Dactilares.Derecha_Anular";
                case "Derecha_Medio":
                    return "Registro_de_Huellas_Dactilares.Derecha_Medio";
                case "Derecha_Indice":
                    return "Registro_de_Huellas_Dactilares.Derecha_Indice";
                case "Derecha_Pulgar":
                    return "Registro_de_Huellas_Dactilares.Derecha_Pulgar";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Huellas_Dactilares).GetProperty(columnName));
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

