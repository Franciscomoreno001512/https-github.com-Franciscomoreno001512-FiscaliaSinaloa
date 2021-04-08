using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_CumplimientoResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Cumplimiento = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Cumplimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Cumplimiento = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_CumplimientoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Cumplimiento</summary>
        public static string Registro_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Registro_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mandamiento_Judicial</summary>
        public static string Mandamiento_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Mandamiento_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_de_Registro</summary>
        public static string Usuario_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Usuario_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Resolucion</summary>
        public static string Fecha_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Fecha_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio</summary>
        public static string Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Radiograma</summary>
        public static string Radiograma
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Radiograma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Partida_que_cumplimenta</summary>
        public static string Partida_que_cumplimenta
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Partida_que_cumplimenta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_que_envia_cumplimiento</summary>
        public static string Area_que_envia_cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Area_que_envia_cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_del_Cumplimiento</summary>
        public static string Observaciones_del_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Observaciones_del_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Personas_donde_se_ejecuto_mandamiento</summary>
        public static string Personas_donde_se_ejecuto_mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Cumplimiento.GetResource("Personas_donde_se_ejecuto_mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Cumplimiento.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
