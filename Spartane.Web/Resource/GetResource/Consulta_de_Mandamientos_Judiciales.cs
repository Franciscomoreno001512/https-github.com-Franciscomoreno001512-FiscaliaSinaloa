using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Consulta_de_Mandamientos_JudicialesResources
    {
        //private static IResourceProvider resourceProviderConsulta_de_Mandamientos_Judiciales = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Consulta_de_Mandamientos_JudicialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderConsulta_de_Mandamientos_Judiciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Consulta_de_Mandamientos_JudicialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderConsulta_de_Mandamientos_Judiciales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Consulta_de_Mandamientos_JudicialesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Consulta_de_Mandamientos_Judiciales</summary>
        public static string Consulta_de_Mandamientos_Judiciales
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Consulta_de_Mandamientos_Judiciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MandamientoJudicialId</summary>
        public static string MandamientoJudicialId
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("MandamientoJudicialId", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juzgado</summary>
        public static string Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_Solicitud_Juzgado</summary>
        public static string Oficio_Solicitud_Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Oficio_Solicitud_Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carpeta_de_Investigacion</summary>
        public static string Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_Penal</summary>
        public static string Causa_Penal
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Causa_Penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultados</summary>
        public static string Resultados
        {
            get
            {
                SetPath();
                return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("Resultados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderConsulta_de_Mandamientos_Judiciales.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
