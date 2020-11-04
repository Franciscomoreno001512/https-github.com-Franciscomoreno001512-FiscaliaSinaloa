using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Expediente_Inicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Expediente_InicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Expediente_Inicial.Clave";
                case "Fecha_de_Registro":
                    return "Expediente_Inicial.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Expediente_Inicial.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Detenido[Descripcion]":
                case "DetenidoDescripcion":
                    return "Catalogo_Estatus_Detenido_MPI.Descripcion";
                case "NUC":
                    return "Expediente_Inicial.NUC";
                case "NIC":
                    return "Expediente_Inicial.NIC";
                case "Hora_del_Detenido":
                    return "Expediente_Inicial.Hora_del_Detenido";
                case "Hora_Puesto_a_Disposicion":
                    return "Expediente_Inicial.Hora_Puesto_a_Disposicion";
                case "Solicitar_Servicos_de_Apoyo[Folio]":
                case "Solicitar_Servicos_de_ApoyoFolio":
                    return "Modulo_Atencion_Inicial.Folio";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Expediente_Inicial.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Turno":
                    return "Expediente_Inicial.Turno";
                case "Fecha_del_Hecho":
                    return "Expediente_Inicial.Fecha_del_Hecho";
                case "Hora_del_Hecho":
                    return "Expediente_Inicial.Hora_del_Hecho";
                case "Pais_de_los_Hechos_MPI[Nombre]":
                case "Pais_de_los_Hechos_MPINombre":
                    return "Pais.Nombre";
                case "Estado_de_los_Hechos_MPI[Nombre]":
                case "Estado_de_los_Hechos_MPINombre":
                    return "Estado.Nombre";
                case "Municipio_de_los_Hechos_MPI[Nombre]":
                case "Municipio_de_los_Hechos_MPINombre":
                    return "Municipio.Nombre";
                case "Colonia_de_los_Hechos_MPI[Nombre]":
                case "Colonia_de_los_Hechos_MPINombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_los_Hechos_MPI":
                    return "Expediente_Inicial.Codigo_Postal_de_los_Hechos_MPI";
                case "Calle_de_los_Hechos_MPI":
                    return "Expediente_Inicial.Calle_de_los_Hechos_MPI";
                case "Entre_Calle_MPI":
                    return "Expediente_Inicial.Entre_Calle_MPI";
                case "Y_Calle_MPI":
                    return "Expediente_Inicial.Y_Calle_MPI";
                case "Numero_Exrterior_de_los_Hechos_MPI":
                    return "Expediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI";
                case "Numero_Interior_de_los_Hechos_MPI":
                    return "Expediente_Inicial.Numero_Interior_de_los_Hechos_MPI";
                case "Latitud_MPI":
                    return "Expediente_Inicial.Latitud_MPI";
                case "Longitud_MPI":
                    return "Expediente_Inicial.Longitud_MPI";
                case "Tipo_de_Lugar_del_Hecho_MPI[Descripcion]":
                case "Tipo_de_Lugar_del_Hecho_MPIDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Persona_Moral":
                    return "Expediente_Inicial.Persona_Moral";
                case "Requiere_Diligencia":
                    return "Expediente_Inicial.Requiere_Diligencia";
                case "Numero_de_Expediente_Victima":
                    return "Expediente_Inicial.Numero_de_Expediente_Victima";
                case "Requiere_Traductor":
                    return "Expediente_Inicial.Requiere_Traductor";
                case "Lengua_Originaria[Descripcion]":
                case "Lengua_OriginariaDescripcion":
                    return "Dialecto.Descripcion";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Titulo_del_Hecho":
                    return "Expediente_Inicial.Titulo_del_Hecho";
                case "Asignar_Agente_del_Ministerio_Publico":
                    return "Expediente_Inicial.Asignar_Agente_del_Ministerio_Publico";
                case "Nombre_de_Agente_del_Ministerio_Publico[Name]":
                case "Nombre_de_Agente_del_Ministerio_PublicoName":
                    return "Spartan_User.Name";
                case "Tipo_de_Oficio[Descripcion]":
                case "Tipo_de_OficioDescripcion":
                    return "Tipo_de_Oficio.Descripcion";
                case "Delegacion[Descripcion]":
                case "DelegacionDescripcion":
                    return "Delegacion.Descripcion";
                case "Agencia[Descripcion]":
                case "AgenciaDescripcion":
                    return "Agencia.Descripcion";
                case "Solicitar_Diligencias":
                    return "Expediente_Inicial.Solicitar_Diligencias";
                case "NUC_Audiencias":
                    return "Expediente_Inicial.NUC_Audiencias";
                case "NIC_Audiencias":
                    return "Expediente_Inicial.NIC_Audiencias";
                case "Fecha_de_Registro_Audiencias":
                    return "Expediente_Inicial.Fecha_de_Registro_Audiencias";
                case "Hora_de_Registro_Audiencias":
                    return "Expediente_Inicial.Hora_de_Registro_Audiencias";
                case "Tipo_de_Oficio_Audiencias[Descripcion]":
                case "Tipo_de_Oficio_AudienciasDescripcion":
                    return "Tipo_de_Oficio.Descripcion";
                case "Delegacion_Audiencias[Descripcion]":
                case "Delegacion_AudienciasDescripcion":
                    return "Delegacion.Descripcion";
                case "Domicilio_Delegacion_A":
                    return "Expediente_Inicial.Domicilio_Delegacion_A";
                case "Numero_de_Expediente":
                    return "Expediente_Inicial.Numero_de_Expediente";
                case "NUAT":
                    return "Expediente_Inicial.NUAT";
                case "Fecha_de_RegistroI":
                    return "Expediente_Inicial.Fecha_de_RegistroI";
                case "Hora_de_RegistroI":
                    return "Expediente_Inicial.Hora_de_RegistroI";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Expediente_Inicial.Descripcion";
                case "Canalizar_a[Descripcion]":
                case "Canalizar_aDescripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Delito_Principal[Delito]":
                case "Delito_PrincipalDelito":
                    return "Delito_Principal_MPI.Delito";
                case "Tipo_de_Acuerdo[Descripcion]":
                case "Tipo_de_AcuerdoDescripcion":
                    return "Tipo_de_Acuerdo.Descripcion";
                case "Fecha_de_Inicio_de_Acuerdo":
                    return "Expediente_Inicial.Fecha_de_Inicio_de_Acuerdo";
                case "Fecha_de_Cumplimiento":
                    return "Expediente_Inicial.Fecha_de_Cumplimiento";
                case "Hora_de_Cumplimiento":
                    return "Expediente_Inicial.Hora_de_Cumplimiento";
                case "Domicilio_para_el_Cumplimiento":
                    return "Expediente_Inicial.Domicilio_para_el_Cumplimiento";
                case "Monto_de_Reparacion_de_Danos":
                    return "Expediente_Inicial.Monto_de_Reparacion_de_Danos";
                case "Parcialidades":
                    return "Expediente_Inicial.Parcialidades";
                case "Periodicidad[Descripcion]":
                case "PeriodicidadDescripcion":
                    return "Periodicidad.Descripcion";
                case "Acepta_Acuerdo":
                    return "Expediente_Inicial.Acepta_Acuerdo";
                case "Motivo_de_Rechazo_de_Acuerdo":
                    return "Expediente_Inicial.Motivo_de_Rechazo_de_Acuerdo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Expediente_Inicial).GetProperty(columnName));
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
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Persona_Moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requiere_Diligencia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requiere_Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Asignar_Agente_del_Ministerio_Publico")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Solicitar_Diligencias")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Registro_Audiencias")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_RegistroI")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Inicio_de_Acuerdo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Cumplimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Acepta_Acuerdo")
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

