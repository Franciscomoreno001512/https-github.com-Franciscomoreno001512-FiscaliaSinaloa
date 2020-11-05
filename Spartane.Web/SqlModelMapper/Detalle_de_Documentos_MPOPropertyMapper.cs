using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Documentos_MPOPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Documentos_MPO.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Fecha":
                    return "Detalle_de_Documentos_MPO.Fecha";
                case "Hora":
                    return "Detalle_de_Documentos_MPO.Hora";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Documento[Descripcion]":
                case "Tipo_de_DocumentoDescripcion":
                    return "Tipo_de_Documento.Descripcion";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";
                case "Involucrado[Nombre_Completo_del_Tutor]":
                case "InvolucradoNombre_Completo_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor";
                case "Probable_Responsable[Nombre_Completo_del_Tutor]":
                case "Probable_ResponsableNombre_Completo_del_Tutor":
                    return "Detalle_de_Imputado.Nombre_Completo_del_Tutor";
                case "Observaciones":
                    return "Detalle_de_Documentos_MPO.Observaciones";
                case "Archivo":
                    return "Detalle_de_Documentos_MPO.Archivo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Documentos_MPO).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha")
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

