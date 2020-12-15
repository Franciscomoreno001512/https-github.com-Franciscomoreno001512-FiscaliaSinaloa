using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Medidas_de_ProteccionResources
    {
        //private static IResourceProvider resourceProviderMedidas_de_Proteccion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Medidas_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderMedidas_de_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Medidas_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderMedidas_de_Proteccion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Medidas_de_ProteccionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Medidas_de_Proteccion</summary>
        public static string Medidas_de_Proteccion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Medidas_de_Proteccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_AT</summary>
        public static string Expediente_AT
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Expediente_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MASC</summary>
        public static string Expediente_MASC
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Expediente_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orden_de_Proteccion</summary>
        public static string Orden_de_Proteccion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Orden_de_Proteccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Medida</summary>
        public static string Tipo_de_Medida
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Tipo_de_Medida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medidas</summary>
        public static string Medidas
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Medidas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Tipo</summary>
        public static string Sub_Tipo
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Sub_Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Inicio</summary>
        public static string Fecha_de_Inicio
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Fecha_de_Inicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Inicio</summary>
        public static string Hora_de_Inicio
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Hora_de_Inicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Conclusion</summary>
        public static string Fecha_de_Conclusion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Fecha_de_Conclusion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Conclusion</summary>
        public static string Hora_de_Conclusion
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Hora_de_Conclusion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Duracion_en_Dias</summary>
        public static string Duracion_en_Dias
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Duracion_en_Dias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aplicar_a</summary>
        public static string Aplicar_a
        {
            get
            {
                SetPath();
                return resourceProviderMedidas_de_Proteccion.GetResource("Aplicar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderMedidas_de_Proteccion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
