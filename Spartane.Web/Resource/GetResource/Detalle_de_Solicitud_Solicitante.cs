using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_SolicitanteResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_Solicitante = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_SolicitanteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_Solicitante = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_SolicitanteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_Solicitante = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_SolicitanteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_Solicitante</summary>
        public static string Detalle_de_Solicitud_Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Detalle_de_Solicitud_Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroAT</summary>
        public static string idRegistroAT
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("idRegistroAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroUI</summary>
        public static string idRegistroUI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("idRegistroUI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Indentificacion</summary>
        public static string Numero_de_Indentificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_de_Indentificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen</summary>
        public static string Pais_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Pais_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de</summary>
        public static string Originario_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Originario_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Compareciente</summary>
        public static string Tipo_de_Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Tipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incapaz</summary>
        public static string Incapaz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Incapaz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Inimputabilidad</summary>
        public static string Tipo_de_Inimputabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Tipo_de_Inimputabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_tutor</summary>
        public static string Nombre_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nombre_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_tutor</summary>
        public static string Apellido_Paterno_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Apellido_Paterno_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_tutor</summary>
        public static string Apellido_Materno_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Apellido_Materno_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_tutor</summary>
        public static string Nombre_Completo_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nombre_Completo_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_tutor</summary>
        public static string Fecha_de_Nacimiento_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Fecha_de_Nacimiento_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP_Tutor</summary>
        public static string CURP_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("CURP_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC_Tutor</summary>
        public static string RFC_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("RFC_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_tutor</summary>
        public static string Edad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Edad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_tutor</summary>
        public static string Sexo_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Sexo_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_tutor</summary>
        public static string Estado_Civil_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Estado_Civil_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_tutor</summary>
        public static string Tipo_de_Identificacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Tipo_de_Identificacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_tutor</summary>
        public static string Numero_de_Identificacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_de_Identificacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_tutor</summary>
        public static string Nacionalidad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Nacionalidad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_tutor</summary>
        public static string Escolaridad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Escolaridad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_tutor</summary>
        public static string Ocupacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Ocupacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_tutor</summary>
        public static string Pais_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Pais_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_tutor</summary>
        public static string Estado_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Estado_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_tutor</summary>
        public static string Municipio_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Municipio_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad_tutor</summary>
        public static string Localidad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Localidad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_tutor</summary>
        public static string Colonia_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Colonia_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_tutor</summary>
        public static string Codigo_Postal_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Codigo_Postal_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_tutor</summary>
        public static string Calle_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Calle_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_tutor</summary>
        public static string Numero_Exterior_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Exterior_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_tutor</summary>
        public static string Numero_Interior_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Interior_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_tutor</summary>
        public static string Telefono_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Telefono_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension_tutor</summary>
        public static string Extension_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Extension_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_tutor</summary>
        public static string Celular_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Celular_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_tutor</summary>
        public static string Correo_Electronico_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Correo_Electronico_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen_T</summary>
        public static string Pais_de_Origen_T
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Pais_de_Origen_T", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de_T</summary>
        public static string Originario_de_T
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Originario_de_T", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_los_Hechos</summary>
        public static string Lugar_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Lugar_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_Hechos</summary>
        public static string Pais_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Pais_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Hechos</summary>
        public static string Estado_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Estado_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_Hechos</summary>
        public static string Municipio_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Municipio_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_Hechos</summary>
        public static string Colonia_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Colonia_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_Hechos</summary>
        public static string Codigo_Postal_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Codigo_Postal_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_Hechos</summary>
        public static string Calle_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Calle_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_Hechos</summary>
        public static string Numero_Exterior_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Exterior_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_Hechos</summary>
        public static string Numero_Interior_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Numero_Interior_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_Hechos</summary>
        public static string Entre_Calle_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Entre_Calle_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>y_Calle_Hechos</summary>
        public static string y_Calle_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("y_Calle_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_Hechos</summary>
        public static string Longitud_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Longitud_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_H</summary>
        public static string Latitud_H
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("Latitud_H", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Solicitante.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
