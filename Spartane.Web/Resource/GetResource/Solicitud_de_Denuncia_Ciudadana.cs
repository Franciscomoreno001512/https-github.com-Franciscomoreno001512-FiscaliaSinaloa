using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Solicitud_de_Denuncia_CiudadanaResources
    {
        //private static IResourceProvider resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderSolicitud_de_Denuncia_Ciudadana = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Solicitud_de_Denuncia_CiudadanaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Solicitud_de_Denuncia_Ciudadana</summary>
        public static string Solicitud_de_Denuncia_Ciudadana
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Solicitud_de_Denuncia_Ciudadana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contrasena</summary>
        public static string Contrasena
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Contrasena", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Solicitud</summary>
        public static string Tipo_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Tipo_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Solicitud</summary>
        public static string Estatus_de_Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Estatus_de_Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo</summary>
        public static string Motivo
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Motivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Canalizar_a</summary>
        public static string Canalizar_a
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Canalizar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Revision</summary>
        public static string Fecha_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Fecha_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Revision</summary>
        public static string Hora_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Hora_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Revisa</summary>
        public static string Usuario_que_Revisa
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Usuario_que_Revisa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Resolucion</summary>
        public static string Tipo_de_Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Tipo_de_Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_canaliza</summary>
        public static string Unidad_canaliza
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Unidad_canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Contestacion</summary>
        public static string Contestacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Contestacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_resolucion</summary>
        public static string Observaciones_resolucion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Observaciones_resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Asignacion</summary>
        public static string Fecha_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Fecha_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Asignacion</summary>
        public static string Hora_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Hora_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Asigna</summary>
        public static string Usuario_que_Asigna
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Usuario_que_Asigna", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Responsable_Asignado</summary>
        public static string Responsable_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Responsable_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_responsable</summary>
        public static string Observaciones_responsable
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Observaciones_responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Atencion</summary>
        public static string Fecha_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Fecha_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Atencion</summary>
        public static string Hora_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Hora_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Atiende</summary>
        public static string Usuario_que_Atiende
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Usuario_que_Atiende", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Atencion_Realizada</summary>
        public static string Atencion_Realizada
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Atencion_Realizada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_atencion</summary>
        public static string Observaciones_atencion
        {
            get
            {
                SetPath();
                return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("Observaciones_atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos de la Solicitud</summary>	public static string TabDatos_de_la_Solicitud 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabDatos_de_la_Solicitud", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución</summary>	public static string TabResolucion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabResolucion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignar Responsable de Atención</summary>	public static string TabAsignar_Responsable_de_Atencion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabAsignar_Responsable_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Atención</summary>	public static string TabAtencion 	{		get		{			SetPath();  			return resourceProviderSolicitud_de_Denuncia_Ciudadana.GetResource("TabAtencion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
