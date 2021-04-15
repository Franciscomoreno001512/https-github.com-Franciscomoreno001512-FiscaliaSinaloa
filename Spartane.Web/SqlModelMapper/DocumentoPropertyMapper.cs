using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Documento;

namespace Spartane.Web.SqlModelMapper
{
    public class DocumentoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Documento.Clave";
                case "Descripcion":
                    return "Documento.Descripcion";
                case "Diligencia[Descripcion]":
                case "DiligenciaDescripcion":
                    return "Dilgencia_MASC.Descripcion";
                case "Origen[Descripcion]":
                case "OrigenDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Tipo_de_Documento[Descripcion]":
                case "Tipo_de_DocumentoDescripcion":
                    return "Tipo_de_Documento.Descripcion";
                case "Area_de_Servicios_de_Apoyo[Descripcion]":
                case "Area_de_Servicios_de_ApoyoDescripcion":
                    return "Area_de_Servicios_de_Apoyo.Descripcion";
                case "SubArea_de_Servicios_de_Apoyo[Descripcion]":
                case "SubArea_de_Servicios_de_ApoyoDescripcion":
                    return "SubArea_de_Servicios_de_Apoyo.Descripcion";
                case "idFormato":
                    return "Documento.idFormato";
                case "Requerido":
                    return "Documento.Requerido";
                case "Solicitante":
                    return "Documento.Solicitante";
                case "Requerido_o_Solicitante":
                    return "Documento.Requerido_o_Solicitante";
                case "Solicitar_Archivo_Adjunto":
                    return "Documento.Solicitar_Archivo_Adjunto";
                case "Solicitar_Numero_de_Oficio":
                    return "Documento.Solicitar_Numero_de_Oficio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Documento).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Requerido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Solicitante")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requerido_o_Solicitante")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Solicitar_Archivo_Adjunto")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Solicitar_Numero_de_Oficio")
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

