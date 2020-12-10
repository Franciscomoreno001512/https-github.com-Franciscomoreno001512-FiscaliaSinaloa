using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Proceso_Penal;

namespace Spartane.Web.SqlModelMapper
{
    public class Proceso_PenalPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Proceso_Penal.Folio";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Registro":
                    return "Proceso_Penal.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Proceso_Penal.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Imputado[Nombre_Completo_Detenido]":
                case "ImputadoNombre_Completo_Detenido":
                    return "Detalle_de_Imputado.Nombre_Completo_Detenido";
                case "Reclasificacion_Juridica[Descripcion]":
                case "Reclasificacion_JuridicaDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Plazo_Constitucional[Descripcion]":
                case "Plazo_ConstitucionalDescripcion":
                    return "Plazo_Constitucional.Descripcion";
                case "Fecha_Continuacion_Audiencia":
                    return "Proceso_Penal.Fecha_Continuacion_Audiencia";
                case "Hora_Continuacion_Audiencia":
                    return "Proceso_Penal.Hora_Continuacion_Audiencia";
                case "Vinculacion[Descripcion]":
                case "VinculacionDescripcion":
                    return "Vinculacion_a_Proceso.Descripcion";
                case "Resultado_No_Vinculacion[Descripcion]":
                case "Resultado_No_VinculacionDescripcion":
                    return "Continuacion_de_Proceso.Descripcion";
                case "Resultado_Vinculacion[Descripcion]":
                case "Resultado_VinculacionDescripcion":
                    return "Auto_de_Vinculacion_a_Proceso.Descripcion";
                case "plazo_investigacion_complementaria":
                    return "Proceso_Penal.plazo_investigacion_complementaria";
                case "Resultado_de_Investigacion_Complementari[Descripcion]":
                case "Resultado_de_Investigacion_ComplementariDescripcion":
                    return "Resultado_de_Investigacion_Complementaria.Descripcion";
                case "fecha_investigacion_complementaria":
                    return "Proceso_Penal.fecha_investigacion_complementaria";
                case "hora_investigacion_complementaria":
                    return "Proceso_Penal.hora_investigacion_complementaria";
                case "Nombre_del_Juez_de_Control":
                    return "Proceso_Penal.Nombre_del_Juez_de_Control";
                case "Fecha_de_Entrega_de_Escrito_de_Acusacion":
                    return "Proceso_Penal.Fecha_de_Entrega_de_Escrito_de_Acusacion";
                case "Hora_de_Entrega_de_Escrito_de_Acusacion":
                    return "Proceso_Penal.Hora_de_Entrega_de_Escrito_de_Acusacion";
                case "Fecha_de_Audiencia_Intermedia":
                    return "Proceso_Penal.Fecha_de_Audiencia_Intermedia";
                case "Hora_de_Audiencia_Intermedia":
                    return "Proceso_Penal.Hora_de_Audiencia_Intermedia";
                case "Acusador_Coadyudante[Descripcion]":
                case "Acusador_CoadyudanteDescripcion":
                    return "A_Tiempo.Descripcion";
                case "cumplio_descubrimiento_probatorio[Descripcion]":
                case "cumplio_descubrimiento_probatorioDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Fecha":
                    return "Proceso_Penal.Fecha";
                case "Hora":
                    return "Proceso_Penal.Hora";
                case "Acuerdos_Probatorios[Descripcion]":
                case "Acuerdos_ProbatoriosDescripcion":
                    return "A_Tiempo.Descripcion";
                case "acuerdos_probatorios_cuales_fueron":
                    return "Proceso_Penal.acuerdos_probatorios_cuales_fueron";
                case "Resultado[Descripcion]":
                case "ResultadoDescripcion":
                    return "Resultado_de_Audiencia_Intermedia.Descripcion";
                case "Tribunal_de_Enjuiciamiento[Descripcion]":
                case "Tribunal_de_EnjuiciamientoDescripcion":
                    return "Tribunal_de_Enjuiciamiento.Descripcion";
                case "Nombre_del_Juez":
                    return "Proceso_Penal.Nombre_del_Juez";
                case "Juez_Colegiado":
                    return "Proceso_Penal.Juez_Colegiado";
                case "Juez_Relator":
                    return "Proceso_Penal.Juez_Relator";
                case "Juez_Vocal":
                    return "Proceso_Penal.Juez_Vocal";
                case "Fecha_de_Audiencia_de_Juicio":
                    return "Proceso_Penal.Fecha_de_Audiencia_de_Juicio";
                case "Hora_de_Audiencia_de_Juicio":
                    return "Proceso_Penal.Hora_de_Audiencia_de_Juicio";
                case "Fallo_del_Tribunal[Descripcion]":
                case "Fallo_del_TribunalDescripcion":
                    return "Sentencia.Descripcion";
                case "pruebas_a_desahogar":
                    return "Proceso_Penal.pruebas_a_desahogar";
                case "Resolucion[Descripcion]":
                case "ResolucionDescripcion":
                    return "Resolucion.Descripcion";
                case "Plazo_meses":
                    return "Proceso_Penal.Plazo_meses";
                case "Tipo_de_Sentencia[Descripcion]":
                case "Tipo_de_SentenciaDescripcion":
                    return "Sentencia.Descripcion";
                case "cuantia_de_pena_anios":
                    return "Proceso_Penal.cuantia_de_pena_anios";
                case "cuantia_de_pena_meses":
                    return "Proceso_Penal.cuantia_de_pena_meses";
                case "Monto_de_la_Reparacion_del_Dano":
                    return "Proceso_Penal.Monto_de_la_Reparacion_del_Dano";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Proceso_Penal).GetProperty(columnName));
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
            if (columnName == "Fecha_Continuacion_Audiencia")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "fecha_investigacion_complementaria")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Entrega_de_Escrito_de_Acusacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Audiencia_Intermedia")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
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

