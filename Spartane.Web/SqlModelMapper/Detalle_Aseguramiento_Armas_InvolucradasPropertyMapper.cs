﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Aseguramiento_Armas_InvolucradasPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Clave";
                case "Motivo_de_Registro[Descripcion]":
                case "Motivo_de_RegistroDescripcion":
                    return "Motivo_de_Registro.Descripcion";
                case "Tipo[Nombre]":
                case "TipoNombre":
                    return "Tipo_de_Arma.Nombre";
                case "Descripcion_del_Arma":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Descripcion_del_Arma";
                case "Marca[Nombre]":
                case "MarcaNombre":
                    return "Marca_de_Arma.Nombre";
                case "Calibre[Descripcion]":
                case "CalibreDescripcion":
                    return "Calibre_de_Arma.Descripcion";
                case "Matricula":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Matricula";
                case "Serie":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Serie";
                case "Arma_Oficial":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Arma_Oficial";
                case "Inventario":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Inventario";
                case "Clasificacion[Descripcion]":
                case "ClasificacionDescripcion":
                    return "Tipo_Clasificacion.Descripcion";
                case "Valor_Estimado":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Valor_Estimado";
                case "Lugar_de_Hallazgo":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Lugar_de_Hallazgo";
                case "Observaciones":
                    return "Detalle_Aseguramiento_Armas_Involucradas.Observaciones";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Aseguramiento_Armas_Involucradas).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Arma_Oficial")
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

