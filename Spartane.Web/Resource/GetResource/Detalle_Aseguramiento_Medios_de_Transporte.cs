using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Aseguramiento_Medios_de_TransporteResources
    {
        //private static IResourceProvider resourceProviderDetalle_Aseguramiento_Medios_de_Transporte = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Aseguramiento_Medios_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Aseguramiento_Medios_de_Transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Medios_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Aseguramiento_Medios_de_Transporte = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Aseguramiento_Medios_de_TransporteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Aseguramiento_Medios_de_Transporte</summary>
        public static string Detalle_Aseguramiento_Medios_de_Transporte
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Detalle_Aseguramiento_Medios_de_Transporte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Registro</summary>
        public static string Motivo_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Motivo_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Submarca</summary>
        public static string Submarca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Submarca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Motor</summary>
        public static string Numero_de_Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Numero_de_Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Uso</summary>
        public static string Uso
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Uso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cap__De_Pasajeros</summary>
        public static string Cap__De_Pasajeros
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Cap__De_Pasajeros", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedencia</summary>
        public static string Procedencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Procedencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seguro</summary>
        public static string Seguro
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Seguro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Compania_de_Seguros</summary>
        public static string Compania_de_Seguros
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Compania_de_Seguros", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Empresa</summary>
        public static string Empresa
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Empresa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Capacidad_de_Carga</summary>
        public static string Capacidad_de_Carga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Capacidad_de_Carga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Destino</summary>
        public static string Destino
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Destino", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ubicacion</summary>
        public static string Ubicacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Ubicacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pension</summary>
        public static string Pension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Pension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_Resguardo</summary>
        public static string Domicilio_Resguardo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Domicilio_Resguardo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Aseguramiento_Medios_de_Transporte.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
