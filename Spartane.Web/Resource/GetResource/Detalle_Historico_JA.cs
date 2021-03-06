﻿using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Historico_JAResources
    {
        //private static IResourceProvider resourceProviderDetalle_Historico_JA = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Historico_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Historico_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Historico_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Historico_JA = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Historico_JAResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Historico_JA</summary>
        public static string Detalle_Historico_JA
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Detalle_Historico_JA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario</summary>
        public static string Usuario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Usuario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Historico_JA.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Historico_JA.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
