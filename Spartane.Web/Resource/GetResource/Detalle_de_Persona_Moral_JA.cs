using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Persona_Moral_JAResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Persona_Moral_JA = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Persona_Moral_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Persona_Moral_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Persona_Moral_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Persona_Moral_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Persona_Moral_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Persona_Moral_JA</summary>
        public static string Detalle_de_Persona_Moral_JA
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Detalle_de_Persona_Moral_JA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroAT</summary>
        public static string idRegistroAT
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("idRegistroAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroUI</summary>
        public static string idRegistroUI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("idRegistroUI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Juridica</summary>
        public static string Calidad_Juridica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Calidad_Juridica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_Social</summary>
        public static string Razon_Social
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Razon_Social", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension</summary>
        public static string Extension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Persona_Moral_JA.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
