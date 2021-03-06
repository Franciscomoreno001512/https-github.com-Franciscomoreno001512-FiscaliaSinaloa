﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Guardado_de_Movimiento;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Guardado_de_MovimientoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Guardado_de_Movimiento.Clave";
                case "Registro_de_Movimiento[Informacion]":
                case "Registro_de_MovimientoInformacion":
                    return "Registro_de_Movimiento.Informacion";
                case "Campo[Dato]":
                case "CampoDato":
                    return "Detalle_Datos_Adicionales_Movimiento.Dato";
                case "Etiqueta":
                    return "Detalle_de_Guardado_de_Movimiento.Etiqueta";
                case "Valor":
                    return "Detalle_de_Guardado_de_Movimiento.Valor";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Guardado_de_Movimiento).GetProperty(columnName));
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

