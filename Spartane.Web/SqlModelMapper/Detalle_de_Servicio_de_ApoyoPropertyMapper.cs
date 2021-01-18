using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Servicio_de_ApoyoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Servicio_de_Apoyo.Clave";
                case "Origen[Descripcion]":
                case "OrigenDescripcion":
                    return "Origen_de_Invitacion.Descripcion";
                case "Modulo_de_Atencion_Inicial[Folio]":
                case "Modulo_de_Atencion_InicialFolio":
                    return "Modulo_Atencion_Inicial.Folio";
                case "Modulo_Mecanismos_Alternos[CDI]":
                case "Modulo_Mecanismos_AlternosCDI":
                    return "Solicitud.CDI";
                case "Modulo_Ministerio_Publico[nic]":
                case "Modulo_Ministerio_Publiconic":
                    return "expediente_ministerio_publico.nic";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Requiere_Traductor":
                    return "Detalle_de_Servicio_de_Apoyo.Requiere_Traductor";
                case "Lengua_Originaria[Descripcion]":
                case "Lengua_OriginariaDescripcion":
                    return "Dialecto.Descripcion";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Responsable":
                    return "Detalle_de_Servicio_de_Apoyo.Responsable";
                case "Compareciente[Nombre_Completo]":
                case "ComparecienteNombre_Completo":
                    return "Compareciente.Nombre_Completo";
                case "Diligencia[Descripcion]":
                case "DiligenciaDescripcion":
                    return "Documento.Descripcion";
                case "Archivo":
                    return "Detalle_de_Servicio_de_Apoyo.Archivo";
                case "Fecha_de_Registro":
                    return "Detalle_de_Servicio_de_Apoyo.Fecha_de_Registro";
                case "Fecha_de_Solicitud":
                    return "Detalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud";
                case "Numero_Oficio":
                    return "Detalle_de_Servicio_de_Apoyo.Numero_Oficio";
                case "Nombre_Solicitante":
                    return "Detalle_de_Servicio_de_Apoyo.Nombre_Solicitante";
                case "Rango_Solicitante":
                    return "Detalle_de_Servicio_de_Apoyo.Rango_Solicitante";
                case "Autoridades[Descripcion]":
                case "AutoridadesDescripcion":
                    return "Autoridad_Servicio_Pericial.Descripcion";
                case "Agencia[Descripcion]":
                case "AgenciaDescripcion":
                    return "Agencia_Servicio_Pericial.Descripcion";
                case "Observaciones":
                    return "Detalle_de_Servicio_de_Apoyo.Observaciones";
                case "Dictamen[Descripcion]":
                case "DictamenDescripcion":
                    return "Dictamen_Servicio_Pericial.Descripcion";
                case "Contestacion_lista_para_enviarse":
                    return "Detalle_de_Servicio_de_Apoyo.Contestacion_lista_para_enviarse";
                case "Area_Pericial[Descripcion]":
                case "Area_PericialDescripcion":
                    return "Area_Pericial.Descripcion";
                case "Perito[Name]":
                case "PeritoName":
                    return "Spartan_User.Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Servicio_de_Apoyo).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Requiere_Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
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
            if (columnName == "Contestacion_lista_para_enviarse")
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

