using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Control_de_DocumentosResources
    {
        //private static IResourceProvider resourceProviderControl_de_Documentos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderControl_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderControl_de_Documentos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Control_de_DocumentosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Control_de_Documentos</summary>
        public static string Control_de_Documentos
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Control_de_Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idFormato</summary>
        public static string idFormato
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("idFormato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LlaveRegistro</summary>
        public static string LlaveRegistro
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("LlaveRegistro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>TablaPersona</summary>
        public static string TablaPersona
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("TablaPersona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LlaveRegistroPersona</summary>
        public static string LlaveRegistroPersona
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("LlaveRegistroPersona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proceso</summary>
        public static string Proceso
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Proceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuerpo_del_Documento</summary>
        public static string Cuerpo_del_Documento
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Cuerpo_del_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Encabezado</summary>
        public static string Encabezado
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Encabezado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pie_de_Pagina</summary>
        public static string Pie_de_Pagina
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Pie_de_Pagina", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Historial_de_Cambios</summary>
        public static string Historial_de_Cambios
        {
            get
            {
                SetPath();
                return resourceProviderControl_de_Documentos.GetResource("Historial_de_Cambios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderControl_de_Documentos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Documento</summary>	public static string TabDocumento 	{		get		{			SetPath();  			return resourceProviderControl_de_Documentos.GetResource("TabDocumento", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Historial</summary>	public static string TabHistorial 	{		get		{			SetPath();  			return resourceProviderControl_de_Documentos.GetResource("TabHistorial", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
