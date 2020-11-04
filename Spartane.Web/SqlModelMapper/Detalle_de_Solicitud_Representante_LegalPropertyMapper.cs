using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Solicitud_Representante_LegalPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Solicitud_Representante_Legal.Clave";
                case "idRegistroAT":
                    return "Detalle_de_Solicitud_Representante_Legal.idRegistroAT";
                case "idRegistroUI":
                    return "Detalle_de_Solicitud_Representante_Legal.idRegistroUI";
                case "Numero_de_Expediente[Numero_de_Folio]":
                case "Numero_de_ExpedienteNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Nombre":
                    return "Detalle_de_Solicitud_Representante_Legal.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Solicitud_Representante_Legal.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Solicitud_Representante_Legal.Apellido_Materno";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Solicitud_Representante_Legal.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Solicitud_Representante_Legal.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Detalle_de_Solicitud_Representante_Legal.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia_[Nombre]":
                case "Colonia_Nombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Solicitud_Representante_Legal.Codigo_Postal";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Detalle_de_Solicitud_Representante_Legal.Calle";
                case "Numero_Exterior":
                    return "Detalle_de_Solicitud_Representante_Legal.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Solicitud_Representante_Legal.Numero_Interior";
                case "Entre_Calle":
                    return "Detalle_de_Solicitud_Representante_Legal.Entre_Calle";
                case "Y_Calle":
                    return "Detalle_de_Solicitud_Representante_Legal.Y_Calle";
                case "Longitud":
                    return "Detalle_de_Solicitud_Representante_Legal.Longitud";
                case "Latitud":
                    return "Detalle_de_Solicitud_Representante_Legal.Latitud";
                case "Telefono":
                    return "Detalle_de_Solicitud_Representante_Legal.Telefono";
                case "Extencion":
                    return "Detalle_de_Solicitud_Representante_Legal.Extencion";
                case "Celular":
                    return "Detalle_de_Solicitud_Representante_Legal.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Solicitud_Representante_Legal.Correo_Electronico";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Solicitud_Representante_Legal).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Nacimiento")
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

