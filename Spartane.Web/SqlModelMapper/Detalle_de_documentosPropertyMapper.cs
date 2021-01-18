using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_documentos;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_documentosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_documentos.Clave";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Fecha":
                    return "Detalle_de_documentos.Fecha";
                case "Hora_de_Registro":
                    return "Detalle_de_documentos.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Documento[Descripcion]":
                case "Tipo_de_DocumentoDescripcion":
                    return "Tipo_de_Documento.Descripcion";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";
                case "Numero_de_Oficio":
                    return "Detalle_de_documentos.Numero_de_Oficio";
                case "Solicitante[Nombre_Completo]":
                case "SolicitanteNombre_Completo":
                    return "Detalle_de_Solicitud_Solicitante.Nombre_Completo";
                case "Requerido[Nombre_Completo]":
                case "RequeridoNombre_Completo":
                    return "Detalle_de_Solicitud_Requerido.Nombre_Completo";
                case "Observaciones":
                    return "Detalle_de_documentos.Observaciones";
                case "Archivo":
                    return "Detalle_de_documentos.Archivo";
                case "Lista_para_periciales":
                    return "Detalle_de_documentos.Lista_para_periciales";
                case "Descripcion":
                    return "Detalle_de_documentos.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_documentos).GetProperty(columnName));
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
            if (columnName == "Lista_para_periciales")
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

