using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Documentos_MPOPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Documentos_MPO.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Fecha":
                    return "Detalle_de_Documentos_MPO.Fecha";
                case "Hora":
                    return "Detalle_de_Documentos_MPO.Hora";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Documento[Descripcion]":
                case "Tipo_de_DocumentoDescripcion":
                    return "Tipo_de_Documento.Descripcion";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";
                case "Involucrado[Nombre_Completo_del_Tutor]":
                case "InvolucradoNombre_Completo_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor";
                case "Probable_Responsable[Nombre_Completo_Detenido]":
                case "Probable_ResponsableNombre_Completo_Detenido":
                    return "Detalle_de_Imputado.Nombre_Completo_Detenido";
                case "Observaciones":
                    return "Detalle_de_Documentos_MPO.Observaciones";
                case "Archivo":
                    return "Detalle_de_Documentos_MPO.Archivo";
                case "Lista_para_periciales":
                    return "Detalle_de_Documentos_MPO.Lista_para_periciales";
                case "Folio":
                    return "Detalle_de_Documentos_MPO.Folio";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Descripcion":
                    return "Detalle_de_Documentos_MPO.Descripcion";
                case "Estatus_Persona[Descripcion]":
                case "Estatus_PersonaDescripcion":
                    return "Estatus_Persona.Descripcion";
                case "Fecha_Localizacion":
                    return "Detalle_de_Documentos_MPO.Fecha_Localizacion";
                case "Hora_Localizacion":
                    return "Detalle_de_Documentos_MPO.Hora_Localizacion";
                case "Condiciones_de_Localizacion[Descripcion]":
                case "Condiciones_de_LocalizacionDescripcion":
                    return "Condiciones_de_Localizacion.Descripcion";
                case "Lugar_de_Hallazgo[Descripcion]":
                case "Lugar_de_HallazgoDescripcion":
                    return "Lugar_del_Hallazgo.Descripcion";
                case "Posible_Causa_de_la_Desaparacion":
                    return "Detalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Poblacion[Nombre]":
                case "PoblacionNombre":
                    return "Colonia.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Documentos_MPO.Calle";
                case "Numero_Interior":
                    return "Detalle_de_Documentos_MPO.Numero_Interior";
                case "Numero_Exterior":
                    return "Detalle_de_Documentos_MPO.Numero_Exterior";
                case "Codigo_Postal":
                    return "Detalle_de_Documentos_MPO.Codigo_Postal";
                case "Ente_que_localiza_al_no_localizado[Descripcion]":
                case "Ente_que_localiza_al_no_localizadoDescripcion":
                    return "Ente_que_localiza.Descripcion";
                case "ente_Paterno":
                    return "Detalle_de_Documentos_MPO.ente_Paterno";
                case "ente_Materno":
                    return "Detalle_de_Documentos_MPO.ente_Materno";
                case "ente_Nombre":
                    return "Detalle_de_Documentos_MPO.ente_Nombre";
                case "Autoridad_que_conoce_el_hecho":
                    return "Detalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho";
                case "autoridad_Paterno":
                    return "Detalle_de_Documentos_MPO.autoridad_Paterno";
                case "autoridad_Materno":
                    return "Detalle_de_Documentos_MPO.autoridad_Materno";
                case "autoridad_Nombre":
                    return "Detalle_de_Documentos_MPO.autoridad_Nombre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Documentos_MPO).GetProperty(columnName));
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
            if (columnName == "Fecha_Localizacion")
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

