using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Control_de_Documentos;

namespace Spartane.Web.SqlModelMapper
{
    public class Control_de_DocumentosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Control_de_Documentos.Folio";
                case "Fecha_de_Registro":
                    return "Control_de_Documentos.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Control_de_Documentos.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "idFormato":
                    return "Control_de_Documentos.idFormato";
                case "LlaveRegistro":
                    return "Control_de_Documentos.LlaveRegistro";
                case "TablaPersona":
                    return "Control_de_Documentos.TablaPersona";
                case "LlaveRegistroPersona":
                    return "Control_de_Documentos.LlaveRegistroPersona";
                case "Proceso[Descripcion]":
                case "ProcesoDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Numero_de_Expediente":
                    return "Control_de_Documentos.Numero_de_Expediente";
                case "Cuerpo_del_Documento":
                    return "Control_de_Documentos.Cuerpo_del_Documento";
                case "Encabezado":
                    return "Control_de_Documentos.Encabezado";
                case "Pie_de_Pagina":
                    return "Control_de_Documentos.Pie_de_Pagina";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Control_de_Documentos).GetProperty(columnName));
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

