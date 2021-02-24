using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Datos_del_Imputado_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Datos_del_Imputado_MPI.Clave";
                case "Nombre":
                    return "Detalle_de_Datos_del_Imputado_MPI.Nombre";
                case "Apellido_Paterno":
                    return "Detalle_de_Datos_del_Imputado_MPI.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Detalle_de_Datos_del_Imputado_MPI.Apellido_Materno";
                case "Fecha_de_Nacimiento":
                    return "Detalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento";
                case "Edad":
                    return "Detalle_de_Datos_del_Imputado_MPI.Edad";
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
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Datos_del_Imputado_MPI.Codigo_Postal";
                case "Localidad[Descripcion]":
                case "LocalidadDescripcion":
                    return "Localidad.Descripcion";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Calle_del_Imputado":
                    return "Detalle_de_Datos_del_Imputado_MPI.Calle_del_Imputado";
                case "Numero_Exterior":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Interior";
                case "Telefono":
                    return "Detalle_de_Datos_del_Imputado_MPI.Telefono";
                case "Extencion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Extencion";
                case "Celular":
                    return "Detalle_de_Datos_del_Imputado_MPI.Celular";
                case "Correo_Electronico":
                    return "Detalle_de_Datos_del_Imputado_MPI.Correo_Electronico";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
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
                case "Calvicie[Descripcion]":
                case "CalvicieDescripcion":
                    return "Calvicie.Descripcion";
                case "Color_Ojos[Descripcion]":
                case "Color_OjosDescripcion":
                    return "Color_Ojos.Descripcion";
                case "Ojos[Descripcion]":
                case "OjosDescripcion":
                    return "Ojos.Descripcion";
                case "Forma_de_Ojos[Descripcion]":
                case "Forma_de_OjosDescripcion":
                    return "Forma_Ojos.Descripcion";
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
                    return "Forma_Orejas.Descripcion";
                case "Tipo_Lobulo[Descripcion]":
                case "Tipo_LobuloDescripcion":
                    return "Tipo_Lobulo.Descripcion";
                case "Bigote[Descripcion]":
                case "BigoteDescripcion":
                    return "Bigote.Descripcion";
                case "Situacion_Fisica[Descripcion]":
                case "Situacion_FisicaDescripcion":
                    return "Situacion_Fisica.Descripcion";
                case "Alias_media_diliacion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Alias_media_diliacion";
                case "Fecha_de_Detencion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Fecha_de_Detencion";
                case "Hora_de_Detencion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Hora_de_Detencion";
                case "Fecha_de_Puesto_a_Disposicion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Fecha_de_Puesto_a_Disposicion";
                case "Hora_de_Puesto_a_Disposicion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Hora_de_Puesto_a_Disposicion";
                case "Con_Detenido[Descripcion]":
                case "Con_DetenidoDescripcion":
                    return "Catalogo_Estatus_Detenido_MPI.Descripcion";
                case "A_Quien_Resulte_Responsable":
                    return "Detalle_de_Datos_del_Imputado_MPI.A_Quien_Resulte_Responsable";
                case "Tiempo_Restante_para_Vinculacion":
                    return "Detalle_de_Datos_del_Imputado_MPI.Tiempo_Restante_para_Vinculacion";
                case "Vincular":
                    return "Detalle_de_Datos_del_Imputado_MPI.Vincular";
                case "Medidas_Cautelares[Descripcion]":
                case "Medidas_CautelaresDescripcion":
                    return "Medidas_Cautelares.Descripcion";
                case "Solicitar_Prorroga":
                    return "Detalle_de_Datos_del_Imputado_MPI.Solicitar_Prorroga";
                case "Nuevo_Plazo":
                    return "Detalle_de_Datos_del_Imputado_MPI.Nuevo_Plazo";
                case "Orden_de_Aprehension":
                    return "Detalle_de_Datos_del_Imputado_MPI.Orden_de_Aprehension";
                case "Medidas_Cautelares_en_Imputado[Descripcion]":
                case "Medidas_Cautelares_en_ImputadoDescripcion":
                    return "Medidas_Cautelares.Descripcion";
                case "Titulo_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Titulo_del_Hecho";
                case "Narrativa_Breve_de_los_Hechos":
                    return "Detalle_de_Datos_del_Imputado_MPI.Narrativa_Breve_de_los_Hechos";
                case "Prioridad_del_Hecho[Descripcion]":
                case "Prioridad_del_HechoDescripcion":
                    return "Prioridad_del_Hecho.Descripcion";
                case "Fecha_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Hora_Aproximada_del_Hecho";
                case "Pais_del_Hecho[Nombre]":
                case "Pais_del_HechoNombre":
                    return "Pais.Nombre";
                case "Estado_del_Hecho[Nombre]":
                case "Estado_del_HechoNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Hecho[Nombre]":
                case "Municipio_del_HechoNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Hecho[Nombre]":
                case "Colonia_del_HechoNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Codigo_Postal_del_Hecho";
                case "Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Calle_del_Hecho";
                case "Entre_Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Entre_Calle_del_Hecho";
                case "Y_Calle_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Y_Calle_del_Hecho";
                case "Numero_Exterior_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Exterior_del_Hecho";
                case "Numero_Interior_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Interior_del_Hecho";
                case "Latitud_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Latitud_del_Hecho";
                case "Longitud_del_Hecho":
                    return "Detalle_de_Datos_del_Imputado_MPI.Longitud_del_Hecho";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Incapaz":
                    return "Detalle_de_Datos_del_Imputado_MPI.Incapaz";
                case "Nombre_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Nombre_del_Tutor";
                case "Apellido_Paterno_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Apellido_Paterno_del_Tutor";
                case "Apellido_Materno_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Apellido_Materno_del_Tutor";
                case "Fecha_de_Nacimiento_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento_del_Tutor";
                case "Edad_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Edad_del_Tutor";
                case "Sexo_del_Tutor[Descripcion]":
                case "Sexo_del_TutorDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil_del_Tutor[Descripcion]":
                case "Estado_Civil_del_TutorDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion_del_Tutor[Nombre]":
                case "Tipo_de_Identificacion_del_TutorNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_de_Identificacion_del_Tutor";
                case "Nacionalidad_del_Tutor[NacionalidadC]":
                case "Nacionalidad_del_TutorNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad_del_Tutor[Descripcion]":
                case "Escolaridad_del_TutorDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion_del_Tutor[Descripcion]":
                case "Ocupacion_del_TutorDescripcion":
                    return "Ocupacion.Descripcion";
                case "Pais_del_Tutor[Nombre]":
                case "Pais_del_TutorNombre":
                    return "Pais.Nombre";
                case "Estado_del_Tutor[Nombre]":
                case "Estado_del_TutorNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Tutor[Nombre]":
                case "Municipio_del_TutorNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Tutor[Nombre]":
                case "Colonia_del_TutorNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Codigo_Postal_del_Tutor";
                case "Calle_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Calle_del_Tutor";
                case "Numero_Exterior_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Exterior_del_Tutor";
                case "Numero_Interior_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Numero_Interior_del_Tutor";
                case "Telefono_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Telefono_del_Tutor";
                case "Extension_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Extension_del_Tutor";
                case "Celular_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Celular_del_Tutor";
                case "Correo_Electronico_del_Tutor":
                    return "Detalle_de_Datos_del_Imputado_MPI.Correo_Electronico_del_Tutor";
                case "Proteccion_de_Datos":
                    return "Detalle_de_Datos_del_Imputado_MPI.Proteccion_de_Datos";
                case "Estatus[Descripcion]":
                case "EstatusDescripcion":
                    return "Estatus_del_Imputado.Descripcion";
                case "Judicializar":
                    return "Detalle_de_Datos_del_Imputado_MPI.Judicializar";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Datos_del_Imputado_MPI).GetProperty(columnName));
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
            if (columnName == "Fecha_de_Detencion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_de_Puesto_a_Disposicion")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "A_Quien_Resulte_Responsable")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Vincular")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Orden_de_Aprehension")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Incapaz")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento_del_Tutor")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Proteccion_de_Datos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Judicializar")
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

