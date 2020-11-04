using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_del_Abogado_Victima_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_del_Abogado_Victima_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_del_Abogado_Victima_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_del_Abogado_Victima_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_del_Abogado_Victima_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_del_Abogado_Victima_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_del_Abogado_Victima_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_del_Abogado_Victima_MPI</summary>
        public static string Detalle_del_Abogado_Victima_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Detalle_del_Abogado_Victima_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecutivo_Victima</summary>
        public static string Consecutivo_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Consecutivo_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_del_Abogado_Victima</summary>
        public static string Nombre_Completo_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Nombre_Completo_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Abogado_Victima</summary>
        public static string Nombre_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Nombre_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Abogado_Victima</summary>
        public static string Apellido_Paterno_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Apellido_Paterno_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Abogado_Victima</summary>
        public static string Apellido_Materno_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Apellido_Materno_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_del_Abogado_Victima</summary>
        public static string Fecha_de_Nacimiento_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Fecha_de_Nacimiento_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Abogado_Victima</summary>
        public static string Edad_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Edad_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Abogado_Victima</summary>
        public static string Sexo_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Sexo_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Abogado_Victima</summary>
        public static string Estado_Civil_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Estado_Civil_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_Abogado_Victima</summary>
        public static string Tipo_de_Identificacion_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Tipo_de_Identificacion_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_Abogado_Victima</summary>
        public static string Numero_de_Identificacion_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Numero_de_Identificacion_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Abogado_Victima</summary>
        public static string Nacionalidad_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Nacionalidad_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cedula_Profesional_del_Abogado_Victima</summary>
        public static string Cedula_Profesional_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Cedula_Profesional_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Abogado_Victima</summary>
        public static string Pais_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Pais_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Abogado_Victima</summary>
        public static string Estado_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Estado_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Abogado_Victima</summary>
        public static string Municipio_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Municipio_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Abogado_Victima</summary>
        public static string Colonia_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Colonia_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Abogado_Victima</summary>
        public static string Codigo_Postal_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Codigo_Postal_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Abogado_Victima</summary>
        public static string Calle_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Calle_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Abogado_Victima</summary>
        public static string Numero_Exterior_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Numero_Exterior_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Abogado_Victima</summary>
        public static string Numero_Interior_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Numero_Interior_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Abogado_Victima</summary>
        public static string Telefono_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Telefono_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Abogado_Victima</summary>
        public static string Celular_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Celular_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Abogado_Victima</summary>
        public static string Correo_Electronico_del_Abogado_Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Correo_Electronico_del_Abogado_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aceptar_Notificaciones</summary>
        public static string Aceptar_Notificaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("Aceptar_Notificaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_del_Abogado_Victima_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
