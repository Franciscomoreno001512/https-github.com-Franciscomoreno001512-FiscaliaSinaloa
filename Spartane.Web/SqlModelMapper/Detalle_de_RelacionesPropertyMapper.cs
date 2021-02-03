using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Relaciones;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_RelacionesPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Relaciones.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Involucrado[Nombre_Completo2]":
                case "InvolucradoNombre_Completo2":
                    return "Detalle_de_Datos_Generales.Nombre_Completo2";
                case "Probable_Responsable[Nombre_Completo_Detenido]":
                case "Probable_ResponsableNombre_Completo_Detenido":
                    return "Detalle_de_Imputado.Nombre_Completo_Detenido";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Es_Familiar[Descripcion]":
                case "Es_FamiliarDescripcion":
                    return "Binario.Descripcion";
                case "Parentesco[Descripcion]":
                case "ParentescoDescripcion":
                    return "Parentesco.Descripcion";
                case "Descripcion":
                    return "Detalle_de_Relaciones.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Relaciones).GetProperty(columnName));
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

