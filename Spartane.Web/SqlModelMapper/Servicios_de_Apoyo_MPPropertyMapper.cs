using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Servicios_de_Apoyo_MP;

namespace Spartane.Web.SqlModelMapper
{
    public class Servicios_de_Apoyo_MPPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Servicios_de_Apoyo_MP.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha_de_Registro":
                    return "Servicios_de_Apoyo_MP.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Servicios_de_Apoyo_MP.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Categoria[Descripcion]":
                case "CategoriaDescripcion":
                    return "Categoria_de_Servicio_de_Apoyo.Descripcion";
                case "Tipo_de_Servicio[Servicio]":
                case "Tipo_de_ServicioServicio":
                    return "Tipo_de_Servicio_de_Apoyo.Servicio";
                case "Solicitud":
                    return "Servicios_de_Apoyo_MP.Solicitud";
                case "Fecha_de_Termino_para_Entrega":
                    return "Servicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega";
                case "Hora_de_Termino_para_Entrega":
                    return "Servicios_de_Apoyo_MP.Hora_de_Termino_para_Entrega";
                case "Diligencia_a_Enviar[Descripcion]":
                case "Diligencia_a_EnviarDescripcion":
                    return "Diligencias_MP.Descripcion";
                case "Archivo":
                    return "Servicios_de_Apoyo_MP.Archivo";
                case "Fecha_de_Atencion":
                    return "Servicios_de_Apoyo_MP.Fecha_de_Atencion";
                case "Hora_de_Atencion":
                    return "Servicios_de_Apoyo_MP.Hora_de_Atencion";
                case "Usuario_que_Atiende[Name]":
                case "Usuario_que_AtiendeName":
                    return "Spartan_User.Name";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Servicios_de_Apoyo_MP).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Termino_para_Entrega")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Atencion")
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

