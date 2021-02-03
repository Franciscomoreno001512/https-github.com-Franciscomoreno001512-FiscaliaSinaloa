using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Medios_de_TransportePropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Tipo[Descripcion]":
                case "TipoDescripcion":
                    return "Tipo_de_medios_de_transporte.Descripcion";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_de_Medio_de_transporte.Descripcion";
                case "Submarca":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Submarca";
                case "Modelo[Descripcion]":
                case "ModeloDescripcion":
                    return "Modelo_de_medio_de_transporte.Descripcion";
                case "Placas":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Placas";
                case "Color":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Color";
                case "Numero_de_Motor":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Numero_de_Motor";
                case "Serie":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Serie";
                case "Uso[Descripcion]":
                case "UsoDescripcion":
                    return "Uso_del_medio_de_transporte.Descripcion";
                case "Cap__De_Pasajeros":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Cap__De_Pasajeros";
                case "Procedencia[Descripcion]":
                case "ProcedenciaDescripcion":
                    return "Procedencia_del_medio_de_transporte.Descripcion";
                case "Seguro[Descripcion]":
                case "SeguroDescripcion":
                    return "A_Tiempo.Descripcion";
                case "Compania_de_Seguros[Descripcion]":
                case "Compania_de_SegurosDescripcion":
                    return "Compania_de_Seguros.Descripcion";
                case "Empresa":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Empresa";
                case "Capacidad_de_Carga":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Capacidad_de_Carga";
                case "Origen":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Origen";
                case "Destino":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Destino";
                case "Ubicacion[Descripcion]":
                case "UbicacionDescripcion":
                    return "Ubicacion_de_Medio_de_Transporte.Descripcion";
                case "Pension[Descripcion]":
                case "PensionDescripcion":
                    return "Pension.Descripcion";
                case "Domicilio_Resguardo":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Domicilio_Resguardo";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Medios_de_Transporte.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Medios_de_Transporte).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


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

