﻿using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Medidas_Cautelares_Proceso_PenalResources
    {
        //private static IResourceProvider resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Medidas_Cautelares_Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medidas_Cautelares_Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Medidas_Cautelares_Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Medidas_Cautelares_Proceso_Penal</summary>
        public static string Detalle_Medidas_Cautelares_Proceso_Penal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal.GetResource("Detalle_Medidas_Cautelares_Proceso_Penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medida_Cautelar</summary>
        public static string Medida_Cautelar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal.GetResource("Medida_Cautelar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Medidas_Cautelares_Proceso_Penal.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
