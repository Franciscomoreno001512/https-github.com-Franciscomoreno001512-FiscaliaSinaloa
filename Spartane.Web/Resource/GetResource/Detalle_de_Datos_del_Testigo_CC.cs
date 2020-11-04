using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Datos_del_Testigo_CCResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Datos_del_Testigo_CC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Datos_del_Testigo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Datos_del_Testigo_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Testigo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Datos_del_Testigo_CC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_del_Testigo_CCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Datos_del_Testigo_CC</summary>
        public static string Detalle_de_Datos_del_Testigo_CC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Detalle_de_Datos_del_Testigo_CC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension</summary>
        public static string Extension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_nacimiento</summary>
        public static string Fecha_de_nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Fecha_de_nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inimputable</summary>
        public static string Inimputable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Inimputable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_identificacion</summary>
        public static string Numero_de_identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Numero_de_identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proteccion_de_Datos</summary>
        public static string Proteccion_de_Datos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Proteccion_de_Datos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Genero</summary>
        public static string Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_compareciente</summary>
        public static string Tipo_de_compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Tipo_de_compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_identificacion</summary>
        public static string Tipo_de_identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Tipo_de_identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_inimputabilidad</summary>
        public static string Tipo_de_inimputabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Tipo_de_inimputabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_del_Domicilio</summary>
        public static string Referencia_del_Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Referencia_del_Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique</summary>
        public static string Especifique
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Especifique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Galeria</summary>
        public static string Galeria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("Galeria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Galería</summary>	public static string TabGaleria 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_del_Testigo_CC.GetResource("TabGaleria", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
