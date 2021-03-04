using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Resumen_Denuncia;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Resumen_DenunciaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Resumen_Denuncia.Clave";
                case "Modulo_Atencion_Inicial[NUAT]":
                case "Modulo_Atencion_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MP[nuat]":
                case "Expediente_MPnuat":
                    return "expediente_ministerio_publico.nuat";
                case "Fecha_de_registro":
                    return "Detalle_Resumen_Denuncia.Fecha_de_registro";
                case "Hora_de_registro":
                    return "Detalle_Resumen_Denuncia.Hora_de_registro";
                case "Usuario_que_registra[Name]":
                case "Usuario_que_registraName":
                    return "Spartan_User.Name";
                case "Generar[Descripcion]":
                case "GenerarDescripcion":
                    return "Tipo_de_Expediente_Generado.Descripcion";
                case "Numero_Generado":
                    return "Detalle_Resumen_Denuncia.Numero_Generado";
                case "Numero_de_Oficio":
                    return "Detalle_Resumen_Denuncia.Numero_de_Oficio";
                case "Probable_Responsable":
                    return "Detalle_Resumen_Denuncia.Probable_Responsable";
                case "Delito":
                    return "Detalle_Resumen_Denuncia.Delito";
                case "Victima":
                    return "Detalle_Resumen_Denuncia.Victima";
                case "Relacion":
                    return "Detalle_Resumen_Denuncia.Relacion";
                case "Hechos":
                    return "Detalle_Resumen_Denuncia.Hechos";
                case "Generado":
                    return "Detalle_Resumen_Denuncia.Generado";
                case "Archivo_Descargado":
                    return "Detalle_Resumen_Denuncia.Archivo_Descargado";
                case "Documento[Descripcion]":
                case "DocumentoDescripcion":
                    return "Documento.Descripcion";
                case "Archivo":
                    return "Detalle_Resumen_Denuncia.Archivo";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Resumen_Denuncia).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Generado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Archivo_Descargado")
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

