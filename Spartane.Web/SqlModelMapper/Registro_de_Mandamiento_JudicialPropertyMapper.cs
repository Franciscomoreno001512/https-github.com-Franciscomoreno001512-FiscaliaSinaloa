using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_Mandamiento_JudicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Mandamiento_Judicial.Clave";
                case "Fecha_de_Registro":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Registro_de_Mandamiento_Judicial.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Numero_de_Mandamiento":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento";
                case "Tipo_Mandato[Descripcion]":
                case "Tipo_MandatoDescripcion":
                    return "Tipo_de_Mandamiento.Descripcion";
                case "Fuente[Descripcion]":
                case "FuenteDescripcion":
                    return "Fuente_de_Mandamiento_Judicial.Descripcion";
                case "Fecha_de_Solicitud":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Solicitud";
                case "Pais_al_que_Pertenece_la_Informacion[Nombre]":
                case "Pais_al_que_Pertenece_la_InformacionNombre":
                    return "Pais.Nombre";
                case "Estado_que_Envia_la_Informacion[Nombre]":
                case "Estado_que_Envia_la_InformacionNombre":
                    return "Estado.Nombre";
                case "Municipio_que_Envia_la_Informacion[Nombre]":
                case "Municipio_que_Envia_la_InformacionNombre":
                    return "Municipio.Nombre";
                case "Institucion_que_Remite[Nombre]":
                case "Institucion_que_RemiteNombre":
                    return "Institucion_Emisora.Nombre";
                case "Dependencia_Autoridad_Remitente":
                    return "Registro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente";
                case "Entidad_que_Emite_Mandamiento[Nombre]":
                case "Entidad_que_Emite_MandamientoNombre":
                    return "Estado.Nombre";
                case "Juzgado_que_Emitio_Mandamiento[Nombre]":
                case "Juzgado_que_Emitio_MandamientoNombre":
                    return "Juzgado.Nombre";
                case "Oficio_de_Juzgado":
                    return "Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado";
                case "Area_que_envia_Orden[Descripcion]":
                case "Area_que_envia_OrdenDescripcion":
                    return "Unidad.Descripcion";
                case "Observaciones":
                    return "Registro_de_Mandamiento_Judicial.Observaciones";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_de_Mandamiento_Judicial.Descripcion";
                case "Numero_de_Proceso_Judicial":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial";
                case "Fecha_de_Libramiento":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Libramiento";
                case "Oficio_de_Libramiento":
                    return "Registro_de_Mandamiento_Judicial.Oficio_de_Libramiento";
                case "Fecha_de_Transcripcion":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Transcripcion";
                case "Oficio_Transcripcion":
                    return "Registro_de_Mandamiento_Judicial.Oficio_Transcripcion";
                case "Carpeta_de_Investigacion[nic]":
                case "Carpeta_de_Investigacionnic":
                    return "expediente_ministerio_publico.nic";
                case "Causa_Penal[causa_o_cuadernillo]":
                case "Causa_Penalcausa_o_cuadernillo":
                    return "Judicializacion.causa_o_cuadernillo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Mandamiento_Judicial).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Solicitud")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Libramiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Transcripcion")
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

