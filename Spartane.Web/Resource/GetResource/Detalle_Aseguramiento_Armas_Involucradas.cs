using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_Armas_InvolucradasResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Armas_Involucradas = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_Armas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Armas_Involucradas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Armas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Armas_Involucradas = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Armas_InvolucradasResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Armas_Involucradas</summary>
        public static string Detalle_Aseguramiento_Armas_Involucradas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Detalle_Aseguramiento_Armas_Involucradas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Registro</summary>
        public static string Motivo_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Motivo_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_del_Arma</summary>
        public static string Descripcion_del_Arma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Descripcion_del_Arma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calibre</summary>
        public static string Calibre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Calibre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Matricula</summary>
        public static string Matricula
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Matricula", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Arma_Oficial</summary>
        public static string Arma_Oficial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Arma_Oficial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inventario</summary>
        public static string Inventario
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Inventario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clasificacion</summary>
        public static string Clasificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Clasificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Valor_Estimado</summary>
        public static string Valor_Estimado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Valor_Estimado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_Hallazgo</summary>
        public static string Lugar_de_Hallazgo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Lugar_de_Hallazgo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Armas_Involucradas.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
