using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Involucrados_PC;

namespace Spartane.Web.SqlModelMapper
{
    public class Involucrados_PCPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Involucrados_PC.Clave";
                case "Solicitud[Folio]":
                case "SolicitudFolio":
                    return "Solicitud_de_Denuncia_Ciudadana.Folio";
                case "Desea_indicar_datos_adicionales":
                    return "Involucrados_PC.Desea_indicar_datos_adicionales";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Compareciente[Descripcion]":
                case "Tipo_de_ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "Tipo_de_Victima[Descripcion]":
                case "Tipo_de_VictimaDescripcion":
                    return "Tipo_de_Victima.Descripcion";
                case "Nombres":
                    return "Involucrados_PC.Nombres";
                case "Apellido_Paterno":
                    return "Involucrados_PC.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Involucrados_PC.Apellido_Materno";
                case "Nombre_Completo":
                    return "Involucrados_PC.Nombre_Completo";
                case "Fecha_de_Nacimiento":
                    return "Involucrados_PC.Fecha_de_Nacimiento";
                case "Edad":
                    return "Involucrados_PC.Edad";
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
                    return "Involucrados_PC.Numero_de_Identificacion";
                case "CURP":
                    return "Involucrados_PC.CURP";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Originario_de":
                    return "Involucrados_PC.Originario_de";
                case "Existieron_testigos":
                    return "Involucrados_PC.Existieron_testigos";
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
                case "Codigo_Postal":
                    return "Involucrados_PC.Codigo_Postal";
                case "Calle":
                    return "Involucrados_PC.Calle";
                case "Entre_Calle":
                    return "Involucrados_PC.Entre_Calle";
                case "Y_Calle":
                    return "Involucrados_PC.Y_Calle";
                case "Numero_Exterior":
                    return "Involucrados_PC.Numero_Exterior";
                case "Numero_Interior":
                    return "Involucrados_PC.Numero_Interior";
                case "Referencia_de_Domicilio":
                    return "Involucrados_PC.Referencia_de_Domicilio";
                case "Latitud":
                    return "Involucrados_PC.Latitud";
                case "Longitud":
                    return "Involucrados_PC.Longitud";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Involucrados_PC).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Desea_indicar_datos_adicionales")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
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
            if (columnName == "Existieron_testigos")
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

