using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;

namespace Spartane.Web.SqlModelMapper
{
    public class Registro_de_Mandamiento_JudicialPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Registro_de_Mandamiento_Judicial.Clave";
                case "Folio_de_la_Orden_de_Aprehension":
                    return "Registro_de_Mandamiento_Judicial.Folio_de_la_Orden_de_Aprehension";
                case "Pais_al_que_Pertenece_la_Informacion[Nombre]":
                case "Pais_al_que_Pertenece_la_InformacionNombre":
                    return "Pais.Nombre";
                case "Estado_que_Envia_la_Informacion[Nombre]":
                case "Estado_que_Envia_la_InformacionNombre":
                    return "Estado.Nombre";
                case "Municipio_que_Envia_la_Informacion[Nombre]":
                case "Municipio_que_Envia_la_InformacionNombre":
                    return "Municipio.Nombre";
                case "Institucion_que_Remite[Nombre]":
                case "Institucion_que_RemiteNombre":
                    return "Institucion_Emisora.Nombre";
                case "Entidad_que_Emite_Mandamiento[Nombre]":
                case "Entidad_que_Emite_MandamientoNombre":
                    return "Estado.Nombre";
                case "Juzgado_que_Emitio_Mandamiento[Nombre]":
                case "Juzgado_que_Emitio_MandamientoNombre":
                    return "Juzgado.Nombre";
                case "Numero_de_Mandamiento":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento";
                case "Oficio_de_Juzgado":
                    return "Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado";
                case "Nombre":
                    return "Registro_de_Mandamiento_Judicial.Nombre";
                case "Alias":
                    return "Registro_de_Mandamiento_Judicial.Alias";
                case "Apellido_Paterno":
                    return "Registro_de_Mandamiento_Judicial.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Registro_de_Mandamiento_Judicial.Apellido_Materno";
                case "Fecha_de_Nacimiento":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Nacimiento";
                case "Edad":
                    return "Registro_de_Mandamiento_Judicial.Edad";
                case "Estatura":
                    return "Registro_de_Mandamiento_Judicial.Estatura";
                case "Peso":
                    return "Registro_de_Mandamiento_Judicial.Peso";
                case "Usa_Anteojos":
                    return "Registro_de_Mandamiento_Judicial.Usa_Anteojos";
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
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_de_Nacimiento[Nombre]":
                case "Pais_de_NacimientoNombre":
                    return "Pais.Nombre";
                case "Estado_de_Nacimiento[Nombre]":
                case "Estado_de_NacimientoNombre":
                    return "Estado.Nombre";
                case "Tipo_de_Orden[Tipo_de_Ordenx]":
                case "Tipo_de_OrdenTipo_de_Ordenx":
                    return "Tipo_de_Orden.Tipo_de_Ordenx";
                case "Fecha_de_Orden":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Orden";
                case "Hora_de_Orden":
                    return "Registro_de_Mandamiento_Judicial.Hora_de_Orden";
                case "Dirigida_Por":
                    return "Registro_de_Mandamiento_Judicial.Dirigida_Por";
                case "Ambito[Ambitox]":
                case "AmbitoAmbitox":
                    return "Ambito.Ambitox";
                case "Juzgado[Nombre]":
                case "JuzgadoNombre":
                    return "Juzgado.Nombre";
                case "Juez":
                    return "Registro_de_Mandamiento_Judicial.Juez";
                case "Especialidad[Descripcion]":
                case "EspecialidadDescripcion":
                    return "Especialidad_MP.Descripcion";
                case "Numero_de_Causa":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Causa";
                case "Fecha_de_Oficio":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Oficio";
                case "Tipo_de_Cuantia[Descripcion]":
                case "Tipo_de_CuantiaDescripcion":
                    return "Tipo_de_Cuantia.Descripcion";
                case "Observaciones":
                    return "Registro_de_Mandamiento_Judicial.Observaciones";
                case "Forma_Cara[Descripcion]":
                case "Forma_CaraDescripcion":
                    return "Forma_Cara.Descripcion";
                case "Cejas[Descripcion]":
                case "CejasDescripcion":
                    return "Cejas.Descripcion";
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
                case "Ojos[Descripcion]":
                case "OjosDescripcion":
                    return "Ojos.Descripcion";
                case "Forma_Ojos[Descripcion]":
                case "Forma_OjosDescripcion":
                    return "Froma_Ojos.Descripcion";
                case "Nariz_Base[Descripcion]":
                case "Nariz_BaseDescripcion":
                    return "Nariz_Base.Descripcion";
                case "Labios[Descripcion]":
                case "LabiosDescripcion":
                    return "Labios.Descripcion";
                case "Boca[Descripcion]":
                case "BocaDescripcion":
                    return "Boca.Descripcion";
                case "Menton[Descripcion]":
                case "MentonDescripcion":
                    return "Menton.Descripcion";
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
                case "Situacion_Fisica[Descripcion]":
                case "Situacion_FisicaDescripcion":
                    return "Situacion_Fisica.Descripcion";
                case "Fecha_de_Libramiento":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Libramiento";
                case "Fuerzo[Descripcion]":
                case "FuerzoDescripcion":
                    return "Fuerzo.Descripcion";
                case "Tipo_Mandato[Descripcion]":
                case "Tipo_MandatoDescripcion":
                    return "Tipo_de_Mandamiento.Descripcion";
                case "Numero_de_Proceso_Judicial":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial";
                case "Numero_de_Averiguacion":
                    return "Registro_de_Mandamiento_Judicial.Numero_de_Averiguacion";
                case "Fecha_de_Captura":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Captura";
                case "Fecha_de_Recepcion":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Recepcion";
                case "Fecha_de_Prescripcion":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Prescripcion";
                case "Fecha_de_Cumplimiento":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Cumplimiento";
                case "Oficio_de_Cumplimiento":
                    return "Registro_de_Mandamiento_Judicial.Oficio_de_Cumplimiento";
                case "Fecha_de_Cancelacion":
                    return "Registro_de_Mandamiento_Judicial.Fecha_de_Cancelacion";
                case "Motivo_de_Cancelacion[Descripcion]":
                case "Motivo_de_CancelacionDescripcion":
                    return "Motivo_de_Cancelacion_del_Proceso.Descripcion";
                case "Oficio_de_Cancelacion":
                    return "Registro_de_Mandamiento_Judicial.Oficio_de_Cancelacion";
                case "Tipo_de_Proceso[Descripcion]":
                case "Tipo_de_ProcesoDescripcion":
                    return "Tipo_de_Proceso.Descripcion";
                case "Proceso_de_Extradiccion[Descripcion]":
                case "Proceso_de_ExtradiccionDescripcion":
                    return "Tipo_de_Extradiccion.Descripcion";
                case "Observacionesx":
                    return "Registro_de_Mandamiento_Judicial.Observacionesx";
                case "Huellas_Digitales":
                    return "Registro_de_Mandamiento_Judicial.Huellas_Digitales";
                case "Mano_Izquierda_dedos":
                    return "Registro_de_Mandamiento_Judicial.Mano_Izquierda_dedos";
                case "Mano_Derecha_Pulgar":
                    return "Registro_de_Mandamiento_Judicial.Mano_Derecha_Pulgar";
                case "Mano_Derecha_Dedos":
                    return "Registro_de_Mandamiento_Judicial.Mano_Derecha_Dedos";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Registro_de_Mandamiento_Judicial).GetProperty(columnName));
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
            if (columnName == "Usa_Anteojos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Orden")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Oficio")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Libramiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Captura")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Recepcion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Prescripcion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Cumplimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Cancelacion")
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

