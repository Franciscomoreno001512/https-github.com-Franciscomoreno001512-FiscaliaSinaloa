using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Datos_del_Imputado_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Datos_del_Imputado_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Datos_del_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Datos_del_Imputado_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Datos_del_Imputado_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Imputado_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Datos_del_Imputado_MPI</summary>
        public static string Detalle_de_Datos_del_Imputado_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Detalle_de_Datos_del_Imputado_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad</summary>
        public static string Localidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Localidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Imputado</summary>
        public static string Calle_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Calle_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extencion</summary>
        public static string Extencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Extencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cejas</summary>
        public static string Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cabello</summary>
        public static string Forma_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Forma_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ojos</summary>
        public static string Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Ojos</summary>
        public static string Forma_de_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Forma_de_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nariz_Base</summary>
        public static string Nariz_Base
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nariz_Base", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias_media_diliacion</summary>
        public static string Alias_media_diliacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Alias_media_diliacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Detencion</summary>
        public static string Fecha_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Fecha_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Detencion</summary>
        public static string Hora_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Hora_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Puesto_a_Disposicion</summary>
        public static string Fecha_de_Puesto_a_Disposicion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Fecha_de_Puesto_a_Disposicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Puesto_a_Disposicion</summary>
        public static string Hora_de_Puesto_a_Disposicion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Hora_de_Puesto_a_Disposicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Con_Detenido</summary>
        public static string Con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>A_Quien_Resulte_Responsable</summary>
        public static string A_Quien_Resulte_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("A_Quien_Resulte_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiempo_Restante_para_Vinculacion</summary>
        public static string Tiempo_Restante_para_Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tiempo_Restante_para_Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vincular</summary>
        public static string Vincular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Vincular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medidas_Cautelares</summary>
        public static string Medidas_Cautelares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Medidas_Cautelares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitar_Prorroga</summary>
        public static string Solicitar_Prorroga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Solicitar_Prorroga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nuevo_Plazo</summary>
        public static string Nuevo_Plazo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nuevo_Plazo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orden_de_Aprehension</summary>
        public static string Orden_de_Aprehension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Orden_de_Aprehension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medidas_Cautelares_en_Imputado</summary>
        public static string Medidas_Cautelares_en_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Medidas_Cautelares_en_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Hecho</summary>
        public static string Pais_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Pais_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Hecho</summary>
        public static string Estado_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estado_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Hecho</summary>
        public static string Municipio_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Municipio_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Hecho</summary>
        public static string Colonia_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Colonia_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Hecho</summary>
        public static string Codigo_Postal_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Codigo_Postal_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Hecho</summary>
        public static string Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_del_Hecho</summary>
        public static string Entre_Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Entre_Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_del_Hecho</summary>
        public static string Y_Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Y_Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Hecho</summary>
        public static string Numero_Exterior_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Exterior_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Hecho</summary>
        public static string Numero_Interior_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Interior_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_del_Hecho</summary>
        public static string Latitud_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Latitud_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_del_Hecho</summary>
        public static string Longitud_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Longitud_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Abogados</summary>
        public static string Abogados
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Abogados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incapaz</summary>
        public static string Incapaz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Incapaz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Tutor</summary>
        public static string Nombre_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nombre_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Tutor</summary>
        public static string Apellido_Paterno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Apellido_Paterno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Tutor</summary>
        public static string Apellido_Materno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Apellido_Materno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_del_Tutor</summary>
        public static string Fecha_de_Nacimiento_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Fecha_de_Nacimiento_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Tutor</summary>
        public static string Edad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Edad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Tutor</summary>
        public static string Sexo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Sexo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Tutor</summary>
        public static string Estado_Civil_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estado_Civil_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_del_Tutor</summary>
        public static string Tipo_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Tipo_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_del_Tutor</summary>
        public static string Numero_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Tutor</summary>
        public static string Nacionalidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Nacionalidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_del_Tutor</summary>
        public static string Escolaridad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Escolaridad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_del_Tutor</summary>
        public static string Ocupacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Ocupacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Tutor</summary>
        public static string Pais_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Pais_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Tutor</summary>
        public static string Estado_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estado_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Tutor</summary>
        public static string Municipio_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Municipio_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Tutor</summary>
        public static string Colonia_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Colonia_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Tutor</summary>
        public static string Codigo_Postal_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Codigo_Postal_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Tutor</summary>
        public static string Calle_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Calle_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Tutor</summary>
        public static string Numero_Exterior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Exterior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Tutor</summary>
        public static string Numero_Interior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Numero_Interior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Tutor</summary>
        public static string Telefono_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Telefono_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension_del_Tutor</summary>
        public static string Extension_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Extension_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Tutor</summary>
        public static string Celular_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Celular_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Tutor</summary>
        public static string Correo_Electronico_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Correo_Electronico_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proteccion_de_Datos</summary>
        public static string Proteccion_de_Datos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Proteccion_de_Datos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sentencias</summary>
        public static string Sentencias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Sentencias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Judicializar</summary>
        public static string Judicializar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("Judicializar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Media Filiación</summary>	public static string TabDatos_de_Media_Filiacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabDatos_de_Media_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Control de Tiempos</summary>	public static string TabControl_de_Tiempos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabControl_de_Tiempos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Abogado</summary>	public static string TabDatos_del_Abogado 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabDatos_del_Abogado", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Sentencias</summary>	public static string TabSentencias 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Imputado_MPI.GetResource("TabSentencias", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
