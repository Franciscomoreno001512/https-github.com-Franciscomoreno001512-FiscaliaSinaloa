using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_InmueblesResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Inmuebles = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_InmueblesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Inmuebles = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_InmueblesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Inmuebles = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_InmueblesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Inmuebles</summary>
        public static string Detalle_Aseguramiento_Inmuebles
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Detalle_Aseguramiento_Inmuebles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Terreno</summary>
        public static string Terreno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Terreno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique_Otro</summary>
        public static string Especifique_Otro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Especifique_Otro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Exterior</summary>
        public static string Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Interior</summary>
        public static string Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>C_P</summary>
        public static string C_P
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("C_P", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_Publico_Propiedad</summary>
        public static string Registro_Publico_Propiedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Registro_Publico_Propiedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entrecalles</summary>
        public static string Entrecalles
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Entrecalles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Propietario</summary>
        public static string Propietario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Propietario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Inmuebles.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
