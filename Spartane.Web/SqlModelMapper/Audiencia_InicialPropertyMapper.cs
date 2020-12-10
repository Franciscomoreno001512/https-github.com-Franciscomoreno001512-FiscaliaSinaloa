using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Audiencia_Inicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Audiencia_InicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Audiencia_Inicial.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Registro":
                    return "Audiencia_Inicial.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Audiencia_Inicial.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Nombre_del_Juez_de_Control":
                    return "Audiencia_Inicial.Nombre_del_Juez_de_Control";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Judicializacion.Descripcion";
                case "causa_penal":
                    return "Audiencia_Inicial.causa_penal";
                case "Fecha_Audiencia_Inicial":
                    return "Audiencia_Inicial.Fecha_Audiencia_Inicial";
                case "Hora_Audiencia_Inicial":
                    return "Audiencia_Inicial.Hora_Audiencia_Inicial";
                case "Sala_de_Audiencia":
                    return "Audiencia_Inicial.Sala_de_Audiencia";
                case "Con_Detenido[Descripcion]":
                case "Con_DetenidoDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Especificar_Detencion[Descripcion]":
                case "Especificar_DetencionDescripcion":
                    return "Especificacion_Detencion.Descripcion";
                case "Control_de_Detencion[Descripcion]":
                case "Control_de_DetencionDescripcion":
                    return "Control_de_Detencion.Descripcion";
                case "Especificar_Control_Detencion[Descripcion]":
                case "Especificar_Control_DetencionDescripcion":
                    return "Continuacion_de_Proceso.Descripcion";
                case "Formulacion_de_Imputacion[Descripcion]":
                case "Formulacion_de_ImputacionDescripcion":
                    return "Formulacion_de_Imputacion.Descripcion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Audiencia_Inicial).GetProperty(columnName));
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
            if (columnName == "Fecha_Audiencia_Inicial")
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

