using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_Servicios_de_ApoyoResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Servicios_de_Apoyo = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Servicios_de_ApoyoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Servicios_de_Apoyo</summary>
        public static string Solicitud_de_Servicios_de_Apoyo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Solicitud_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Solicitud</summary>
        public static string Fecha_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Fecha_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Solicitud</summary>
        public static string Hora_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Hora_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Solicita</summary>
        public static string Usuario_que_Solicita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Usuario_que_Solicita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Origen</summary>
        public static string Origen
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente_AT</summary>
        public static string Numero_de_Expediente_AT
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Numero_de_Expediente_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_AT</summary>
        public static string Diligencia_AT
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Diligencia_AT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente_MP</summary>
        public static string Numero_de_Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Numero_de_Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Diligencia_MP</summary>
        public static string Diligencia_MP
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Diligencia_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Denuncia</summary>
        public static string Numero_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Numero_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Carpeta_de_Investigacion</summary>
        public static string Carpeta_de_Investigacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Carpeta_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Oficio</summary>
        public static string Numero_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Numero_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud_de_Apoyo_Externa</summary>
        public static string Solicitud_de_Apoyo_Externa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Solicitud_de_Apoyo_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud_Externa</summary>
        public static string Solicitud_Externa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Solicitud_Externa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoridad_que_Solicita</summary>
        public static string Autoridad_que_Solicita
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Autoridad_que_Solicita", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narracion_Solicitud</summary>
        public static string Narracion_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Narracion_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ver_Documento</summary>
        public static string Ver_Documento
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Ver_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Recepcion</summary>
        public static string Fecha_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Fecha_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Recepcion</summary>
        public static string Hora_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Hora_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Recibe</summary>
        public static string Usuario_que_Recibe
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Usuario_que_Recibe", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Area_Asignada</summary>
        public static string Area_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Area_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>SubArea_Asignada</summary>
        public static string SubArea_Asignada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("SubArea_Asignada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Recepcion</summary>
        public static string Observaciones_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Observaciones_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Asignacion</summary>
        public static string Fecha_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Fecha_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Asignacion</summary>
        public static string Hora_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Hora_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Asigna</summary>
        public static string Usuario_que_Asigna
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Usuario_que_Asigna", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Asignacion</summary>
        public static string Tipo_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Tipo_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable_Asignado</summary>
        public static string Responsable_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Responsable_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Asignacion</summary>
        public static string Observaciones_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Observaciones_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Contestacion</summary>
        public static string Fecha_de_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Fecha_de_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Contestacion</summary>
        public static string Hora_de_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Hora_de_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_contesta</summary>
        public static string Usuario_que_contesta
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Usuario_que_contesta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dictamen</summary>
        public static string Dictamen
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Dictamen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>numero_contestacion</summary>
        public static string numero_contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("numero_contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Enviar_Contestacion</summary>
        public static string Enviar_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Enviar_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Contestacion</summary>
        public static string Observaciones_Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Observaciones_Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Revision</summary>
        public static string Fecha_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Fecha_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Revision</summary>
        public static string Hora_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Hora_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Revisa</summary>
        public static string Usuario_que_Revisa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Usuario_que_Revisa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_de_Autorizacion</summary>
        public static string Resultado_de_Autorizacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Resultado_de_Autorizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo</summary>
        public static string Motivo_de_Rechazo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Motivo_de_Rechazo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Autorizacion</summary>
        public static string Observaciones_Autorizacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("Observaciones_Autorizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Recepción</summary>	public static string TabRecepcion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabRecepcion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignación</summary>	public static string TabAsignacion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabAsignacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Contestación</summary>	public static string TabContestacion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabContestacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Autorización</summary>	public static string TabAutorizacion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Servicios_de_Apoyo.GetResource("TabAutorizacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
