﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Quejas_de_MP;

namespace Spartane.Web.SqlModelMapper
{
    public class Quejas_de_MPPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Quejas_de_MP.Clave";
                case "Nombres":
                    return "Quejas_de_MP.Nombres";
                case "Apellido_Paterno":
                    return "Quejas_de_MP.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Quejas_de_MP.Apellido_Materno";
                case "Nombre_Completo":
                    return "Quejas_de_MP.Nombre_Completo";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_Quejas_MP.Descripcion";
                case "Peso":
                    return "Quejas_de_MP.Peso";
                case "Estatura":
                    return "Quejas_de_MP.Estatura";
                case "Padecimiento_de_Enfermedad":
                    return "Quejas_de_MP.Padecimiento_de_Enfermedad";
                case "Forma_Cara[Descripcion]":
                case "Forma_CaraDescripcion":
                    return "Forma_Cara.Descripcion";
                case "Tipo_de_Cejas[Descripcion]":
                case "Tipo_de_CejasDescripcion":
                    return "Cejas.Descripcion";
                case "Tamano_de_Cejas[Descripcion]":
                case "Tamano_de_CejasDescripcion":
                    return "Tamano_de_Cejas.Descripcion";
                case "Largo_de_Cabello[Descripcion]":
                case "Largo_de_CabelloDescripcion":
                    return "Largo_de_Cabello.Descripcion";
                case "Cantidad_Cabello[Descripcion]":
                case "Cantidad_CabelloDescripcion":
                    return "Cantidad_Cabello.Descripcion";
                case "Implantacion_Cabello[Descripcion]":
                case "Implantacion_CabelloDescripcion":
                    return "Implantacion_Cabello.Descripcion";
                case "Complexion[Descripcion]":
                case "ComplexionDescripcion":
                    return "Complexion.Descripcion";
                case "Color_Piel[Descrpicion]":
                case "Color_PielDescrpicion":
                    return "Color_Piel.Descrpicion";
                case "Frente[Descripcion]":
                case "FrenteDescripcion":
                    return "Frente.Descripcion";
                case "Forma_Cabello[Descripcion]":
                case "Forma_CabelloDescripcion":
                    return "Forma_Cabello.Descripcion";
                case "Color_Cabello[Descripcion]":
                case "Color_CabelloDescripcion":
                    return "Color_de_Cabello.Descripcion";
                case "Calvicie[Descripcion]":
                case "CalvicieDescripcion":
                    return "Calvicie.Descripcion";
                case "Color_Ojos[Descripcion]":
                case "Color_OjosDescripcion":
                    return "Color_Ojos.Descripcion";
                case "Tamano_de_Ojos[Descripcion]":
                case "Tamano_de_OjosDescripcion":
                    return "Ojos.Descripcion";
                case "Forma_Ojos[Descripcion]":
                case "Forma_OjosDescripcion":
                    return "Froma_Ojos.Descripcion";
                case "Anteojos[Descripcion]":
                case "AnteojosDescripcion":
                    return "Anteojos.Descripcion";
                case "Forma_de_Nariz[Descripcion]":
                case "Forma_de_NarizDescripcion":
                    return "Forma_de_Nariz.Descripcion";
                case "Tamano_Nariz[Descripcion]":
                case "Tamano_NarizDescripcion":
                    return "Nariz_Base.Descripcion";
                case "Labios[Descripcion]":
                case "LabiosDescripcion":
                    return "Labios.Descripcion";
                case "Boca[Descripcion]":
                case "BocaDescripcion":
                    return "Boca.Descripcion";
                case "Grosor_de_Labios[Descripcion]":
                case "Grosor_de_LabiosDescripcion":
                    return "Grosor_de_Labios.Descripcion";
                case "Menton[Descripcion]":
                case "MentonDescripcion":
                    return "Menton.Descripcion";
                case "Forma_de_Menton[Descripcion]":
                case "Forma_de_MentonDescripcion":
                    return "Forma_de_Menton.Descripcion";
                case "Barba[Descripcion]":
                case "BarbaDescripcion":
                    return "Barba.Descripcion";
                case "Forma_Orejas[Descripcion]":
                case "Forma_OrejasDescripcion":
                    return "Forma_Orejas.Descripcion";
                case "Tamano_Orejas[Descripcion]":
                case "Tamano_OrejasDescripcion":
                    return "Tamano_Orejas.Descripcion";
                case "Tipo_Lobulo[Descripcion]":
                case "Tipo_LobuloDescripcion":
                    return "Tipo_Lobulo.Descripcion";
                case "Bigote[Descripcion]":
                case "BigoteDescripcion":
                    return "Bigote.Descripcion";
                case "Senas_Particulares[Descripcion]":
                case "Senas_ParticularesDescripcion":
                    return "Senas_Particulares.Descripcion";
                case "Situacion_Fisica[Descripcion]":
                case "Situacion_FisicaDescripcion":
                    return "Situacion_Fisica.Descripcion";
                case "Otras_Senas_Particulares":
                    return "Quejas_de_MP.Otras_Senas_Particulares";
                case "Descripcion_de_los_Hechos":
                    return "Quejas_de_MP.Descripcion_de_los_Hechos";
                case "CURP":
                    return "Quejas_de_MP.CURP";
                case "Genero[Descripcion]":
                case "GeneroDescripcion":
                    return "Genero.Descripcion";
                case "Fecha_de_Nacimiento":
                    return "Quejas_de_MP.Fecha_de_Nacimiento";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Entidad_de_Nacimiento[Nombre]":
                case "Entidad_de_NacimientoNombre":
                    return "Estado.Nombre";
                case "Nombres_Hechos":
                    return "Quejas_de_MP.Nombres_Hechos";
                case "Apellido_Paterno_Hechos":
                    return "Quejas_de_MP.Apellido_Paterno_Hechos";
                case "Apellido_Materno_Hechos":
                    return "Quejas_de_MP.Apellido_Materno_Hechos";
                case "Fecha_de_Nacimiento_Hechos":
                    return "Quejas_de_MP.Fecha_de_Nacimiento_Hechos";
                case "Edad_Hechos":
                    return "Quejas_de_MP.Edad_Hechos";
                case "Genero_Hechos[Descripcion]":
                case "Genero_HechosDescripcion":
                    return "Genero.Descripcion";
                case "Celular_Hechos":
                    return "Quejas_de_MP.Celular_Hechos";
                case "Correo_Hechos":
                    return "Quejas_de_MP.Correo_Hechos";
                case "Tipo_de_Identificacion_Hechos[Nombre]":
                case "Tipo_de_Identificacion_HechosNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_Identificacion_Hechos":
                    return "Quejas_de_MP.Numero_Identificacion_Hechos";
                case "Nacionalidad_Hechos[NacionalidadC]":
                case "Nacionalidad_HechosNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Entidad_de_Nacimiento_Hechos[Nombre]":
                case "Entidad_de_Nacimiento_HechosNombre":
                    return "Estado.Nombre";
                case "CURP_Identificacion":
                    return "Quejas_de_MP.CURP_Identificacion";
                case "Nombres_Identificacion":
                    return "Quejas_de_MP.Nombres_Identificacion";
                case "Apellido_Paterno_Identificacion":
                    return "Quejas_de_MP.Apellido_Paterno_Identificacion";
                case "Apellido_Materno_Identificacion":
                    return "Quejas_de_MP.Apellido_Materno_Identificacion";
                case "Fecha_Nacimiento_Identificacion":
                    return "Quejas_de_MP.Fecha_Nacimiento_Identificacion";
                case "Edad_Identificacion":
                    return "Quejas_de_MP.Edad_Identificacion";
                case "Genero_Identificacion[Descripcion]":
                case "Genero_IdentificacionDescripcion":
                    return "Genero.Descripcion";
                case "Celular_Identificacion":
                    return "Quejas_de_MP.Celular_Identificacion";
                case "Correo_Identificacion":
                    return "Quejas_de_MP.Correo_Identificacion";
                case "Tipo_de_Identificacion_Identificacion[Nombre]":
                case "Tipo_de_Identificacion_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_Identificacion_Identificacion":
                    return "Quejas_de_MP.Numero_Identificacion_Identificacion";
                case "Nacionalidad_Identificacion[NacionalidadC]":
                case "Nacionalidad_IdentificacionNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Entidad_de_Nacimiento_Identificacion[Nombre]":
                case "Entidad_de_Nacimiento_IdentificacionNombre":
                    return "Estado.Nombre";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Codigo_Postal":
                    return "Quejas_de_MP.Codigo_Postal";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle":
                    return "Quejas_de_MP.Calle";
                case "Entre_Calle":
                    return "Quejas_de_MP.Entre_Calle";
                case "Y_Calle":
                    return "Quejas_de_MP.Y_Calle";
                case "Numero_Exterior":
                    return "Quejas_de_MP.Numero_Exterior";
                case "Numero_Interior":
                    return "Quejas_de_MP.Numero_Interior";
                case "Referencias_de_domicilio":
                    return "Quejas_de_MP.Referencias_de_domicilio";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Quejas_de_MP).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Nacimiento_Hechos")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_Nacimiento_Identificacion")
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

