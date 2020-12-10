using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Modulo_Atencion_InicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Modulo_Atencion_Inicial.Clave";
                case "Folio":
                    return "Modulo_Atencion_Inicial.Folio";
                case "Fecha_de_Registro":
                    return "Modulo_Atencion_Inicial.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Modulo_Atencion_Inicial.Hora_de_Registro";
                case "Turno_Asignado[Numero_de_Turno]":
                case "Turno_AsignadoNumero_de_Turno":
                    return "Asignacion_de_Turnos.Numero_de_Turno";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Unidad[Descripcion]":
                case "UnidadDescripcion":
                    return "Unidad.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Region[Descripcion]":
                case "RegionDescripcion":
                    return "Region.Descripcion";
                case "Tipo_de_Denuncia[Descripcion]":
                case "Tipo_de_DenunciaDescripcion":
                    return "Tipo_de_Denuncia.Descripcion";
                case "NUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "CDI":
                    return "Modulo_Atencion_Inicial.CDI";
                case "Expedientes_Relacionados":
                    return "Modulo_Atencion_Inicial.Expedientes_Relacionados";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus.Descripcion";
                case "Generar_Cita":
                    return "Modulo_Atencion_Inicial.Generar_Cita";
                case "Nombres_del_Remitente":
                    return "Modulo_Atencion_Inicial.Nombres_del_Remitente";
                case "Apellido_Paterno_del_Remitente":
                    return "Modulo_Atencion_Inicial.Apellido_Paterno_del_Remitente";
                case "Apellido_Materno_del_Remitente":
                    return "Modulo_Atencion_Inicial.Apellido_Materno_del_Remitente";
                case "Fecha_en_que_llega_para_validacion":
                    return "Modulo_Atencion_Inicial.Fecha_en_que_llega_para_validacion";
                case "Delegacion[Descripcion]":
                case "DelegacionDescripcion":
                    return "Delegacion.Descripcion";
                case "Agencia[Descripcion]":
                case "AgenciaDescripcion":
                    return "Agencia.Descripcion";
                case "Ministerio_Publico_en_Turno[Ministerio_Publico_en_Turno]":
                case "Ministerio_Publico_en_TurnoMinisterio_Publico_en_Turno":
                    return "Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno";
                case "Nombres_turno":
                    return "Modulo_Atencion_Inicial.Nombres_turno";
                case "Apellido_Paterno_turno":
                    return "Modulo_Atencion_Inicial.Apellido_Paterno_turno";
                case "Apellido_Materno_turno":
                    return "Modulo_Atencion_Inicial.Apellido_Materno_turno";
                case "Sexo_turno[Descripcion]":
                case "Sexo_turnoDescripcion":
                    return "Genero.Descripcion";
                case "Edad_turno":
                    return "Modulo_Atencion_Inicial.Edad_turno";
                case "Tipo_de_Atencion_turno[Descripcion]":
                case "Tipo_de_Atencion_turnoDescripcion":
                    return "Tipo_de_Atencion.Descripcion";
                case "Tipo_de_Identificacion_turno[Nombre]":
                case "Tipo_de_Identificacion_turnoNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_turno":
                    return "Modulo_Atencion_Inicial.Numero_de_Identificacion_turno";
                case "Urgencia_turno":
                    return "Modulo_Atencion_Inicial.Urgencia_turno";
                case "Tipo_de_Urgencia_turno[Descripcion]":
                case "Tipo_de_Urgencia_turnoDescripcion":
                    return "Tipo_de_Urgencia.Descripcion";
                case "Motivo_Finalizacion_Turno[Descripcion]":
                case "Motivo_Finalizacion_TurnoDescripcion":
                    return "Motivo_Finalizacion_Turno.Descripcion";
                case "Observaciones_turno":
                    return "Modulo_Atencion_Inicial.Observaciones_turno";
                case "Requiere_Traductor":
                    return "Modulo_Atencion_Inicial.Requiere_Traductor";
                case "Lengua_Originaria[Descripcion]":
                case "Lengua_OriginariaDescripcion":
                    return "Dialecto.Descripcion";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Autoriza_Traductor":
                    return "Modulo_Atencion_Inicial.Autoriza_Traductor";
                case "Finalizar_Servicios_de_Apoyo":
                    return "Modulo_Atencion_Inicial.Finalizar_Servicios_de_Apoyo";
                case "Estatus2[Descripcion]":
                case "Estatus2Descripcion":
                    return "Estatus_Orientador.Descripcion";
                case "Unidad_canaliza[Descripcion]":
                case "Unidad_canalizaDescripcion":
                    return "Unidad.Descripcion";
                case "Enviar_a_MP":
                    return "Modulo_Atencion_Inicial.Enviar_a_MP";
                case "Correccion_de_Estatus":
                    return "Modulo_Atencion_Inicial.Correccion_de_Estatus";
                case "Requiere_Servicios_de_Apoyo":
                    return "Modulo_Atencion_Inicial.Requiere_Servicios_de_Apoyo";
                case "Persona_Moral":
                    return "Modulo_Atencion_Inicial.Persona_Moral";
                case "Titulo_del_Hecho":
                    return "Modulo_Atencion_Inicial.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Modulo_Atencion_Inicial.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Orientador[Name]":
                case "OrientadorName":
                    return "Spartan_User.Name";
                case "Fecha_del_Hecho":
                    return "Modulo_Atencion_Inicial.Fecha_del_Hecho";
                case "Hora_del_Hecho":
                    return "Modulo_Atencion_Inicial.Hora_del_Hecho";
                case "Pais_de_los_Hechos[Nombre]":
                case "Pais_de_los_HechosNombre":
                    return "Pais.Nombre";
                case "Estado_de_los_Hechos[Nombre]":
                case "Estado_de_los_HechosNombre":
                    return "Estado.Nombre";
                case "Municipio_de_los_Hechos[Nombre]":
                case "Municipio_de_los_HechosNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia_de_los_Hechos[Nombre]":
                case "Colonia_de_los_HechosNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_los_Hechos":
                    return "Modulo_Atencion_Inicial.Codigo_Postal_de_los_Hechos";
                case "Calle_de_los_Hechos":
                    return "Modulo_Atencion_Inicial.Calle_de_los_Hechos";
                case "Entre_Calle":
                    return "Modulo_Atencion_Inicial.Entre_Calle";
                case "Y_Calle":
                    return "Modulo_Atencion_Inicial.Y_Calle";
                case "Numero_Exrterior_de_los_Hechos":
                    return "Modulo_Atencion_Inicial.Numero_Exrterior_de_los_Hechos";
                case "Numero_Interior_de_los_Hechos":
                    return "Modulo_Atencion_Inicial.Numero_Interior_de_los_Hechos";
                case "Latitud":
                    return "Modulo_Atencion_Inicial.Latitud";
                case "Longitud":
                    return "Modulo_Atencion_Inicial.Longitud";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Zona_de_los_Hechos[Descripcion]":
                case "Zona_de_los_HechosDescripcion":
                    return "Zona.Descripcion";
                case "Turno":
                    return "Modulo_Atencion_Inicial.Turno";
                case "Tipo_de_Acuerdo[Descripcion]":
                case "Tipo_de_AcuerdoDescripcion":
                    return "Tipo_de_Acuerdo.Descripcion";
                case "Fecha_de_Inicio_de_Acuerdo":
                    return "Modulo_Atencion_Inicial.Fecha_de_Inicio_de_Acuerdo";
                case "Fecha_de_Cumplimiento_del_Acuerdo":
                    return "Modulo_Atencion_Inicial.Fecha_de_Cumplimiento_del_Acuerdo";
                case "Hora_de_Cumplimiento_del_Acuerdo":
                    return "Modulo_Atencion_Inicial.Hora_de_Cumplimiento_del_Acuerdo";
                case "Domicilio_para_el_Cumplimiento":
                    return "Modulo_Atencion_Inicial.Domicilio_para_el_Cumplimiento";
                case "Monto_de_Reparacion_de_Danos":
                    return "Modulo_Atencion_Inicial.Monto_de_Reparacion_de_Danos";
                case "Parcialidades":
                    return "Modulo_Atencion_Inicial.Parcialidades";
                case "Periodicidad[Descripcion]":
                case "PeriodicidadDescripcion":
                    return "Periodicidad.Descripcion";
                case "Se_Acepta_Acuerdo":
                    return "Modulo_Atencion_Inicial.Se_Acepta_Acuerdo";
                case "Motivo_de_Rechazo_de_Acuerdo":
                    return "Modulo_Atencion_Inicial.Motivo_de_Rechazo_de_Acuerdo";
                case "Cerrar":
                    return "Modulo_Atencion_Inicial.Cerrar";
                case "Fecha_de_Cierre":
                    return "Modulo_Atencion_Inicial.Fecha_de_Cierre";
                case "Hora_de_Cierre":
                    return "Modulo_Atencion_Inicial.Hora_de_Cierre";
                case "NUC":
                    return "Modulo_Atencion_Inicial.NUC";
                case "Fecha_de_Vencimiento_1":
                    return "Modulo_Atencion_Inicial.Fecha_de_Vencimiento_1";
                case "EspecialistaJA":
                    return "Modulo_Atencion_Inicial.EspecialistaJA";
                case "Campo_Oculto1":
                    return "Modulo_Atencion_Inicial.Campo_Oculto1";
                case "JefeMPO[Ministerio_Publico_en_Turno]":
                case "JefeMPOMinisterio_Publico_en_Turno":
                    return "Jefes_de_Usuarios_del_Sistema.Ministerio_Publico_en_Turno";
                case "Campo_Oculto2":
                    return "Modulo_Atencion_Inicial.Campo_Oculto2";
                case "Campo_Oculto3":
                    return "Modulo_Atencion_Inicial.Campo_Oculto3";
                case "CoordinadorJA[Name]":
                case "CoordinadorJAName":
                    return "Spartan_User.Name";
                case "EspJA[Name]":
                case "EspJAName":
                    return "Spartan_User.Name";
                case "Ano_Actual":
                    return "Modulo_Atencion_Inicial.Ano_Actual";
                case "Secuencial":
                    return "Modulo_Atencion_Inicial.Secuencial";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Modulo_Atencion_Inicial).GetProperty(columnName));
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
            if (columnName == "Generar_Cita")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_en_que_llega_para_validacion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Urgencia_turno")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requiere_Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Autoriza_Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Finalizar_Servicios_de_Apoyo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Enviar_a_MP")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Correccion_de_Estatus")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Requiere_Servicios_de_Apoyo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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
            if (columnName == "Fecha_de_Cumplimiento_del_Acuerdo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Se_Acepta_Acuerdo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Cerrar")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Cierre")
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

