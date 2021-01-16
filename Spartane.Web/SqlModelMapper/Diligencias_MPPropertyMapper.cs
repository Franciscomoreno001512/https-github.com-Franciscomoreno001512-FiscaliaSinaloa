using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Diligencias_MP;

namespace Spartane.Web.SqlModelMapper
{
    public class Diligencias_MPPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Diligencias_MP.Clave";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Fecha":
                    return "Diligencias_MP.Fecha";
                case "Hora":
                    return "Diligencias_MP.Hora";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Tipo_de_Documento[Descripcion]":
                case "Tipo_de_DocumentoDescripcion":
                    return "Tipo_de_Documento.Descripcion";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";
                case "Numero_de_Oficio":
                    return "Diligencias_MP.Numero_de_Oficio";
                case "Involucrado[Nombre_Completo]":
                case "InvolucradoNombre_Completo":
                    return "Detalle_de_Datos_Generales.Nombre_Completo";
                case "Probable_Responsable[Nombre_Completo_Detenido]":
                case "Probable_ResponsableNombre_Completo_Detenido":
                    return "Detalle_de_Imputado.Nombre_Completo_Detenido";
                case "Observaciones":
                    return "Diligencias_MP.Observaciones";
                case "Archivo":
                    return "Diligencias_MP.Archivo";
                case "Descripcion":
                    return "Diligencias_MP.Descripcion";
                case "Lista_para_periciales":
                    return "Diligencias_MP.Lista_para_periciales";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Diligencias_MP).GetProperty(columnName));
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

