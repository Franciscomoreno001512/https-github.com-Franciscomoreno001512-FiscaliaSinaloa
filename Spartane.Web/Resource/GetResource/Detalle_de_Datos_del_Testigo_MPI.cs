using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Datos_del_Testigo_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Datos_del_Testigo_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Datos_del_Testigo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Datos_del_Testigo_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Testigo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Datos_del_Testigo_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Testigo_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Datos_del_Testigo_MPI</summary>
        public static string Detalle_de_Datos_del_Testigo_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Detalle_de_Datos_del_Testigo_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extencion</summary>
        public static string Extencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Extencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incapaz</summary>
        public static string Incapaz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Incapaz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Tutor</summary>
        public static string Nombre_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nombre_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Tutor</summary>
        public static string Apellido_Paterno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Apellido_Paterno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Tutor</summary>
        public static string Apellido_Materno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Apellido_Materno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_del_Tutor</summary>
        public static string Nombre_Completo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nombre_Completo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimento_del_Tutor</summary>
        public static string Fecha_de_Nacimento_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Fecha_de_Nacimento_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Tutor</summary>
        public static string Edad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Edad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Tutor</summary>
        public static string Sexo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Sexo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Tutor</summary>
        public static string Estado_Civil_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Estado_Civil_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_del_Tutor</summary>
        public static string Tipo_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Tipo_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_del_Tutor</summary>
        public static string Numero_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Tutor</summary>
        public static string Nacionalidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Nacionalidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_del_Tutor</summary>
        public static string Escolaridad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Escolaridad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_del_Tutor</summary>
        public static string Ocupacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Ocupacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Tutor</summary>
        public static string Pais_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Pais_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Tutor</summary>
        public static string Estado_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Estado_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Tutor</summary>
        public static string Municipio_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Municipio_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Tutor</summary>
        public static string Colonia_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Colonia_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Tutor</summary>
        public static string Codigo_Postal_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Codigo_Postal_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Tutor</summary>
        public static string Calle_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Calle_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Tutor</summary>
        public static string Numero_Exterior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Exterior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Tutor</summary>
        public static string Numero_Interior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Interior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Tutor</summary>
        public static string Telefono_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Telefono_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extencion_del_Tutor</summary>
        public static string Extencion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Extencion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Tutor</summary>
        public static string Celular_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Celular_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Tutor</summary>
        public static string Correo_Electronico_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Correo_Electronico_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Compareciente</summary>
        public static string Tipo_de_Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Tipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_del_Testigo</summary>
        public static string Narrativa_del_Testigo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Narrativa_del_Testigo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Hecho</summary>
        public static string Pais_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Pais_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Hecho</summary>
        public static string Estado_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Estado_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Hecho</summary>
        public static string Municipio_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Municipio_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Hecho</summary>
        public static string Colonia_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Colonia_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Hecho</summary>
        public static string Codigo_Postal_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Codigo_Postal_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Hecho</summary>
        public static string Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_del_Hecho</summary>
        public static string Entre_Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Entre_Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_del_Hecho</summary>
        public static string Y_Calle_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Y_Calle_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Hecho</summary>
        public static string Numero_Exterior_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Exterior_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Hecho</summary>
        public static string Numero_Interior_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Numero_Interior_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_del_Hecho</summary>
        public static string Latitud_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Latitud_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_del_Hecho</summary>
        public static string Longitud_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Longitud_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_del_Lugar_del_Hecho</summary>
        public static string Tipo_del_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Tipo_del_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proteccion_de_Datos</summary>
        public static string Proteccion_de_Datos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Proteccion_de_Datos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary> Datos del Tutor</summary>	public static string Tab_Datos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("Tab_Datos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Testigo_MPI.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
