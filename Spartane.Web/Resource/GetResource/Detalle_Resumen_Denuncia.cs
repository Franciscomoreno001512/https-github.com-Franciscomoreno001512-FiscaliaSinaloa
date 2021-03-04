using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Resumen_DenunciaResources
    {
        //private static IResourceProvider resourceProviderDetalle_Resumen_Denuncia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Resumen_DenunciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Resumen_Denuncia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Resumen_DenunciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Resumen_Denuncia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Resumen_DenunciaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Resumen_Denuncia</summary>
        public static string Detalle_Resumen_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Detalle_Resumen_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_registro</summary>
        public static string Fecha_de_registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Fecha_de_registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_registro</summary>
        public static string Hora_de_registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Hora_de_registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_registra</summary>
        public static string Usuario_que_registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Usuario_que_registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Generar</summary>
        public static string Generar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Generar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Generado</summary>
        public static string Numero_Generado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Numero_Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio</summary>
        public static string Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probable_Responsable</summary>
        public static string Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Victima</summary>
        public static string Victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Relacion</summary>
        public static string Relacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Relacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hechos</summary>
        public static string Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Generado</summary>
        public static string Generado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Generado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Descargado</summary>
        public static string Archivo_Descargado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Archivo_Descargado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Resumen_Denuncia.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Resumen_Denuncia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
