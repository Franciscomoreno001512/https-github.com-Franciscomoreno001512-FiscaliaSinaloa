using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Cadena_de_Custodia;

namespace Spartane.Web.SqlModelMapper
{
    public class Cadena_de_CustodiaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Cadena_de_Custodia.Clave";
                case "NUC":
                    return "Cadena_de_Custodia.NUC";
                case "NIC":
                    return "Cadena_de_Custodia.NIC";
                case "Delito_Referencia[Descripcion]":
                case "Delito_ReferenciaDescripcion":
                    return "Delito.Descripcion";
                case "Fecha":
                    return "Cadena_de_Custodia.Fecha";
                case "Hora":
                    return "Cadena_de_Custodia.Hora";
                case "Lugar_Exacto_del_Levantamiento":
                    return "Cadena_de_Custodia.Lugar_Exacto_del_Levantamiento";
                case "Condicion_y_Ubicacion":
                    return "Cadena_de_Custodia.Condicion_y_Ubicacion";
                case "Levantada_por":
                    return "Cadena_de_Custodia.Levantada_por";
                case "Cargo[Tipo_de_Cargo]":
                case "CargoTipo_de_Cargo":
                    return "Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo";
                case "Asignar[Name]":
                case "AsignarName":
                    return "Spartan_User.Name";
                case "Folio_NUE":
                    return "Cadena_de_Custodia.Folio_NUE";
                case "Unidad_Policial[Unidad_Policial]":
                case "Unidad_PolicialUnidad_Policial":
                    return "Catalogo_Unidad_Policial.Unidad_Policial";
                case "Caracterististicas_del_indicio":
                    return "Cadena_de_Custodia.Caracterististicas_del_indicio";
                case "Condiciones_De_Manejo":
                    return "Cadena_de_Custodia.Condiciones_De_Manejo";
                case "Numero_de_Parte":
                    return "Cadena_de_Custodia.Numero_de_Parte";
                case "CUIP":
                    return "Cadena_de_Custodia.CUIP";
                case "Observaciones":
                    return "Cadena_de_Custodia.Observaciones";
                case "Longitud":
                    return "Cadena_de_Custodia.Longitud";
                case "Latitud":
                    return "Cadena_de_Custodia.Latitud";
                case "Clima":
                    return "Cadena_de_Custodia.Clima";
                case "Grados":
                    return "Cadena_de_Custodia.Grados";
                case "Mensaje":
                    return "Cadena_de_Custodia.Mensaje";
                case "Unidad_Administrativa[Descripcion]":
                case "Unidad_AdministrativaDescripcion":
                    return "Catalogo_Unidad_Administrativa_CC.Descripcion";
                case "Entidad_Federativa[Nombre]":
                case "Entidad_FederativaNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Numero_de_Oficio":
                    return "Cadena_de_Custodia.Numero_de_Oficio";
                case "Fecha_CC":
                    return "Cadena_de_Custodia.Fecha_CC";
                case "Hora_CC":
                    return "Cadena_de_Custodia.Hora_CC";
                case "Motivo_de_Intervencion[Descripcion]":
                case "Motivo_de_IntervencionDescripcion":
                    return "Catalogo_Motivo_de_Intervencion_CC.Descripcion";
                case "Otro":
                    return "Cadena_de_Custodia.Otro";
                case "Estatus[Estatus]":
                case "EstatusEstatus":
                    return "Catalogo_Estatus_CC.Estatus";
                case "Nombre_Completo":
                    return "Cadena_de_Custodia.Nombre_Completo";
                case "Usuario_que_Registra":
                    return "Cadena_de_Custodia.Usuario_que_Registra";
                case "FAE":
                    return "Cadena_de_Custodia.FAE";
                case "Fecha_de_la_Emergencia":
                    return "Cadena_de_Custodia.Fecha_de_la_Emergencia";
                case "Hora_de_la_Emergencia":
                    return "Cadena_de_Custodia.Hora_de_la_Emergencia";
                case "Fuente":
                    return "Cadena_de_Custodia.Fuente";
                case "Telefono":
                    return "Cadena_de_Custodia.Telefono";
                case "Celular":
                    return "Cadena_de_Custodia.Celular";
                case "Correo_Electronico":
                    return "Cadena_de_Custodia.Correo_Electronico";
                case "Red_Social":
                    return "Cadena_de_Custodia.Red_Social";
                case "Medio_Masivo":
                    return "Cadena_de_Custodia.Medio_Masivo";
                case "Cargo_de_la_Autoridad":
                    return "Cadena_de_Custodia.Cargo_de_la_Autoridad";
                case "Tipo_de_Emergencia":
                    return "Cadena_de_Custodia.Tipo_de_Emergencia";
                case "Descripcion_de_la_Emergencia":
                    return "Cadena_de_Custodia.Descripcion_de_la_Emergencia";
                case "Probables_Detenidos":
                    return "Cadena_de_Custodia.Probables_Detenidos";
                case "Fecha_de_la_Detencion":
                    return "Cadena_de_Custodia.Fecha_de_la_Detencion";
                case "Hora_de_la_Detencion":
                    return "Cadena_de_Custodia.Hora_de_la_Detencion";
                case "Pais_Emergencia":
                    return "Cadena_de_Custodia.Pais_Emergencia";
                case "Estado_Emergencia":
                    return "Cadena_de_Custodia.Estado_Emergencia";
                case "Municipio_Emergencia":
                    return "Cadena_de_Custodia.Municipio_Emergencia";
                case "Colonia_Emergencia":
                    return "Cadena_de_Custodia.Colonia_Emergencia";
                case "Calle_Emergencia":
                    return "Cadena_de_Custodia.Calle_Emergencia";
                case "Entre_Calle_Emergencia":
                    return "Cadena_de_Custodia.Entre_Calle_Emergencia";
                case "Y_Calle_Emergencia":
                    return "Cadena_de_Custodia.Y_Calle_Emergencia";
                case "Latitud_Emergencia":
                    return "Cadena_de_Custodia.Latitud_Emergencia";
                case "Longitud_Emergencia":
                    return "Cadena_de_Custodia.Longitud_Emergencia";
                case "Nombre_de_la_Autoridad":
                    return "Cadena_de_Custodia.Nombre_de_la_Autoridad";
                case "Especifique":
                    return "Cadena_de_Custodia.Especifique";
                case "Tipo_de_Agente":
                    return "Cadena_de_Custodia.Tipo_de_Agente";
                case "Area":
                    return "Cadena_de_Custodia.Area";
                case "Unidad":
                    return "Cadena_de_Custodia.Unidad";
                case "Zona":
                    return "Cadena_de_Custodia.Zona";
                case "Agente_Investigador":
                    return "Cadena_de_Custodia.Agente_Investigador";
                case "Narrativa_de_los_Hechos":
                    return "Cadena_de_Custodia.Narrativa_de_los_Hechos";
                case "Probable_Delito_Principal":
                    return "Cadena_de_Custodia.Probable_Delito_Principal";
                case "Fecha_de_Asignacion":
                    return "Cadena_de_Custodia.Fecha_de_Asignacion";
                case "Hora_de_Asignacion":
                    return "Cadena_de_Custodia.Hora_de_Asignacion";
                case "Estatus_NUE":
                    return "Cadena_de_Custodia.Estatus_NUE";
                case "Inicio_de_Cadena_de_Custodia[Descripcion]":
                case "Inicio_de_Cadena_de_CustodiaDescripcion":
                    return "Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion";
                case "Calidad_de_quien_aporta[Descripcion]":
                case "Calidad_de_quien_aportaDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Fecha_del_arribo":
                    return "Cadena_de_Custodia.Fecha_del_arribo";
                case "Hora_del_arribo":
                    return "Cadena_de_Custodia.Hora_del_arribo";
                case "Descripcion_de_recoleccion[Descripcion]":
                case "Descripcion_de_recoleccionDescripcion":
                    return "Catalogo_de_Recoleccion.Descripcion";
                case "Movil_para_Traslado[Descripcion]":
                case "Movil_para_TrasladoDescripcion":
                    return "Catalogo_de_Movil_para_traslado.Descripcion";
                case "Servidor_Publico_que_Preserva":
                    return "Cadena_de_Custodia.Servidor_Publico_que_Preserva";
                case "Servidor_Publico_que_Busca":
                    return "Cadena_de_Custodia.Servidor_Publico_que_Busca";
                case "Servidor_Publico_que_Localiza":
                    return "Cadena_de_Custodia.Servidor_Publico_que_Localiza";
                case "Servidor_Publico_que_Recolecta":
                    return "Cadena_de_Custodia.Servidor_Publico_que_Recolecta";
                case "Servidor_Publico_que_Traslada":
                    return "Cadena_de_Custodia.Servidor_Publico_que_Traslada";
                case "Preservacion":
                    return "Cadena_de_Custodia.Preservacion";
                case "Busqueda":
                    return "Cadena_de_Custodia.Busqueda";
                case "Localizacion":
                    return "Cadena_de_Custodia.Localizacion";
                case "Recoleccion":
                    return "Cadena_de_Custodia.Recoleccion";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Cadena_de_Custodia).GetProperty(columnName));
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
            if (columnName == "Fecha_CC")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_la_Emergencia")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Probables_Detenidos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_la_Detencion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
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
            if (columnName == "Fecha_del_arribo")
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

