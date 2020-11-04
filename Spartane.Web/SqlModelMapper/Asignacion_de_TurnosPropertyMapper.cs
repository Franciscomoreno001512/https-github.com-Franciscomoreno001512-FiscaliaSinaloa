using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Asignacion_de_Turnos;

namespace Spartane.Web.SqlModelMapper
{
    public class Asignacion_de_TurnosPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Asignacion_de_Turnos.Folio";
                case "Fecha_de_Turno":
                    return "Asignacion_de_Turnos.Fecha_de_Turno";
                case "Hora_de_Turno":
                    return "Asignacion_de_Turnos.Hora_de_Turno";
                case "Numero_de_Turno":
                    return "Asignacion_de_Turnos.Numero_de_Turno";
                case "Unidad_de_Atencion[Descripcion]":
                case "Unidad_de_AtencionDescripcion":
                    return "Unidad.Descripcion";
                case "Recepcion[Name]":
                case "RecepcionName":
                    return "Spartan_User.Name";
                case "Nombres":
                    return "Asignacion_de_Turnos.Nombres";
                case "Apellido_Paterno":
                    return "Asignacion_de_Turnos.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Asignacion_de_Turnos.Apellido_Materno";
                case "Nombre_Completo":
                    return "Asignacion_de_Turnos.Nombre_Completo";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Edad":
                    return "Asignacion_de_Turnos.Edad";
                case "Tipo_de_Atencion[Descripcion]":
                case "Tipo_de_AtencionDescripcion":
                    return "Tipo_de_Atencion.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Asignacion_de_Turnos.Numero_de_Identificacion";
                case "Urgencia":
                    return "Asignacion_de_Turnos.Urgencia";
                case "Tipo_de_Urgencia[Descripcion]":
                case "Tipo_de_UrgenciaDescripcion":
                    return "Tipo_de_Urgencia.Descripcion";
                case "Orientador[Name]":
                case "OrientadorName":
                    return "Spartan_User.Name";
                case "Estatus_de_Turno[Descripcion]":
                case "Estatus_de_TurnoDescripcion":
                    return "Estatus_de_Turno.Descripcion";
                case "Modulo[Descripcion]":
                case "ModuloDescripcion":
                    return "Modulo.Descripcion";
                case "Motivo_Finalizacion_Turno[Descripcion]":
                case "Motivo_Finalizacion_TurnoDescripcion":
                    return "Motivo_Finalizacion_Turno.Descripcion";
                case "Observaciones":
                    return "Asignacion_de_Turnos.Observaciones";
                case "Fecha_de_Asignacion":
                    return "Asignacion_de_Turnos.Fecha_de_Asignacion";
                case "Hora_de_Asignacion":
                    return "Asignacion_de_Turnos.Hora_de_Asignacion";
                case "Fecha_de_Finalizacion":
                    return "Asignacion_de_Turnos.Fecha_de_Finalizacion";
                case "Hora_de_Finalizacion":
                    return "Asignacion_de_Turnos.Hora_de_Finalizacion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Asignacion_de_Turnos).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Turno")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Urgencia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Asignacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Finalizacion")
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

