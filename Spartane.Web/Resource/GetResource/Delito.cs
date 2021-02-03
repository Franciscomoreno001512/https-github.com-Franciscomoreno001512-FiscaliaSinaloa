using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class DelitoResources
    {
        //private static IResourceProvider resourceProviderDelito = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDelito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDelito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Delito</summary>
        public static string Titulo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Titulo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_del_Delito</summary>
        public static string Grupo_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Grupo_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grave</summary>
        public static string Grave
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Grave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alto_Impacto</summary>
        public static string Alto_Impacto
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Alto_Impacto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alta_Incidencia</summary>
        public static string Alta_Incidencia
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Alta_Incidencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tentativa</summary>
        public static string Tentativa
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Tentativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Activo</summary>
        public static string Activo
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Activo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Configuracion_de_Planeacion</summary>
        public static string Configuracion_de_Planeacion
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Configuracion_de_Planeacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de_Vehiculo</summary>
        public static string Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>delitox</summary>
        public static string delitox
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("delitox", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ARTICULO</summary>
        public static string ARTICULO
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("ARTICULO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>DETALLE</summary>
        public static string DETALLE
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("DETALLE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>TIPO_AGENCIA</summary>
        public static string TIPO_AGENCIA
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("TIPO_AGENCIA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ESTADISTICO_SSP</summary>
        public static string ESTADISTICO_SSP
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("ESTADISTICO_SSP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>VAL_VEHICULO</summary>
        public static string VAL_VEHICULO
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("VAL_VEHICULO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>TIPO_DELITO</summary>
        public static string TIPO_DELITO
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("TIPO_DELITO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>circunstancia_clasif</summary>
        public static string circunstancia_clasif
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("circunstancia_clasif", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PRINCIPAL</summary>
        public static string PRINCIPAL
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("PRINCIPAL", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>orden</summary>
        public static string orden
        {
            get
            {
                SetPath();
                return resourceProviderDelito.GetResource("orden", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDelito.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
