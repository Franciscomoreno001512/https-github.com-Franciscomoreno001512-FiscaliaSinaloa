using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class expediente_ministerio_publicoResources
    {
        //private static IResourceProvider resourceProviderexpediente_ministerio_publico = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\expediente_ministerio_publicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderexpediente_ministerio_publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\expediente_ministerio_publicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderexpediente_ministerio_publico = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\expediente_ministerio_publicoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>expediente_ministerio_publico</summary>
        public static string expediente_ministerio_publico
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("expediente_ministerio_publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>clave</summary>
        public static string clave
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha_de_registro</summary>
        public static string fecha_de_registro
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("fecha_de_registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_de_registro</summary>
        public static string hora_de_registro
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("hora_de_registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>usuario_que_registra</summary>
        public static string usuario_que_registra
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("usuario_que_registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>unidad</summary>
        public static string unidad
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>nuat</summary>
        public static string nuat
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("nuat", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>nic</summary>
        public static string nic
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("nic", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>detenido</summary>
        public static string detenido
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_del_detenido</summary>
        public static string hora_del_detenido
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("hora_del_detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_puesto_a_disposicion</summary>
        public static string hora_puesto_a_disposicion
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("hora_puesto_a_disposicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>estatus</summary>
        public static string estatus
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>observaciones</summary>
        public static string observaciones
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Canalizacion</summary>
        public static string Fecha_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Fecha_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Canalizacion</summary>
        public static string Hora_de_Canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Hora_de_Canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>usuario_que_canaliza</summary>
        public static string usuario_que_canaliza
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("usuario_que_canaliza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>canalizar_a</summary>
        public static string canalizar_a
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("canalizar_a", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>tipo_de_acuerdo</summary>
        public static string tipo_de_acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("tipo_de_acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha_de_inicio_de_acuerdo</summary>
        public static string fecha_de_inicio_de_acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("fecha_de_inicio_de_acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha_de_cumplimiento</summary>
        public static string fecha_de_cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("fecha_de_cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_de_cumplimiento</summary>
        public static string hora_de_cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("hora_de_cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>domicilio_para_el_cumplimiento</summary>
        public static string domicilio_para_el_cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("domicilio_para_el_cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>monto_de_reparacion_de_danos</summary>
        public static string monto_de_reparacion_de_danos
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("monto_de_reparacion_de_danos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>parcialidades</summary>
        public static string parcialidades
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("parcialidades", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>periodicidad</summary>
        public static string periodicidad
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("periodicidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>acepta_acuerdo</summary>
        public static string acepta_acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("acepta_acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>motivo_de_rechazo_de_acuerdo</summary>
        public static string motivo_de_rechazo_de_acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("motivo_de_rechazo_de_acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha_de_cierre</summary>
        public static string fecha_de_cierre
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("fecha_de_cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_de_cierre</summary>
        public static string hora_de_cierre
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("hora_de_cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>tipo_de_cierre</summary>
        public static string tipo_de_cierre
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("tipo_de_cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>comentarios_de_cierre</summary>
        public static string comentarios_de_cierre
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("comentarios_de_cierre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos del Caso</summary>	public static string TabDatos_del_Caso 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabDatos_del_Caso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Acuerdo</summary>	public static string TabDatos_del_Acuerdo 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabDatos_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Cierre de Expediente</summary>	public static string TabCierre_de_Expediente 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabCierre_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
