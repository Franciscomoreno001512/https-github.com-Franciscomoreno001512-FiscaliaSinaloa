using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Judicializacion;

namespace Spartane.Web.SqlModelMapper
{
    public class JudicializacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Judicializacion.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Resolucion[Observaciones]":
                case "ResolucionObservaciones":
                    return "Resolucion_MP.Observaciones";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_Judicializacion.Descripcion";
                case "causa_o_cuadernillo":
                    return "Judicializacion.causa_o_cuadernillo";
                case "Fase_Actual[Descripcion]":
                case "Fase_ActualDescripcion":
                    return "Fase_de_Judicializacion.Descripcion";
                case "Fecha_Actos":
                    return "Judicializacion.Fecha_Actos";
                case "Hora_Actos":
                    return "Judicializacion.Hora_Actos";
                case "Observaciones_Actos":
                    return "Judicializacion.Observaciones_Actos";
                case "Fecha_Genericos":
                    return "Judicializacion.Fecha_Genericos";
                case "Hora_Genericos":
                    return "Judicializacion.Hora_Genericos";
                case "Observaciones_Genericos":
                    return "Judicializacion.Observaciones_Genericos";
                case "Fecha_Fase_Inicial":
                    return "Judicializacion.Fecha_Fase_Inicial";
                case "Hora_Fase_Inicial":
                    return "Judicializacion.Hora_Fase_Inicial";
                case "Observaciones_Fase_Inicial":
                    return "Judicializacion.Observaciones_Fase_Inicial";
                case "Fecha_Fase_Intermedia":
                    return "Judicializacion.Fecha_Fase_Intermedia";
                case "Hora_Fase_Intermedia":
                    return "Judicializacion.Hora_Fase_Intermedia";
                case "Observaciones_Fase_Intermedia":
                    return "Judicializacion.Observaciones_Fase_Intermedia";
                case "Fecha_de_Audiencia_de_Juicio":
                    return "Judicializacion.Fecha_de_Audiencia_de_Juicio";
                case "Hora_de_Audiencia_de_Juicio":
                    return "Judicializacion.Hora_de_Audiencia_de_Juicio";
                case "Tribunal_de_Enjuiciamiento[Descripcion]":
                case "Tribunal_de_EnjuiciamientoDescripcion":
                    return "Tribunal_de_Enjuiciamiento.Descripcion";
                case "Nombre_del_Juez":
                    return "Judicializacion.Nombre_del_Juez";
                case "Juez_Presidente":
                    return "Judicializacion.Juez_Presidente";
                case "Juez_Relator":
                    return "Judicializacion.Juez_Relator";
                case "Juez_Vocal":
                    return "Judicializacion.Juez_Vocal";
                case "medios_desahogo":
                    return "Judicializacion.medios_desahogo";
                case "Tipo_de_Sentencia[Descripcion]":
                case "Tipo_de_SentenciaDescripcion":
                    return "Sentencia.Descripcion";
                case "Cuantia_de_Pena_Anos":
                    return "Judicializacion.Cuantia_de_Pena_Anos";
                case "Cuantia_de_Pena_Meses":
                    return "Judicializacion.Cuantia_de_Pena_Meses";
                case "Monto_de_Reparacion_del_Dano":
                    return "Judicializacion.Monto_de_Reparacion_del_Dano";
                case "Observaciones_Fase_Juicio_Oral":
                    return "Judicializacion.Observaciones_Fase_Juicio_Oral";
                case "Fecha_Fase_Salidas_Alternas":
                    return "Judicializacion.Fecha_Fase_Salidas_Alternas";
                case "Hora_Fase_Salidas_Alternas":
                    return "Judicializacion.Hora_Fase_Salidas_Alternas";
                case "Observaciones_Fase_Salidas_Alternas":
                    return "Judicializacion.Observaciones_Fase_Salidas_Alternas";
                case "Fecha_Fase_Sobreseimientos":
                    return "Judicializacion.Fecha_Fase_Sobreseimientos";
                case "Hora_Fase_Sobreseimientos":
                    return "Judicializacion.Hora_Fase_Sobreseimientos";
                case "Observaciones_Fase_Sobreseimientos":
                    return "Judicializacion.Observaciones_Fase_Sobreseimientos";
                case "Observaciones":
                    return "Judicializacion.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Judicializacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_Actos")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Genericos")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Fase_Inicial")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Fase_Intermedia")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Audiencia_de_Juicio")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Fase_Salidas_Alternas")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Fase_Sobreseimientos")
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

