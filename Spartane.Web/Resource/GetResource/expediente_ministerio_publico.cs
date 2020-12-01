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

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Region</summary>
        public static string Region
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Region", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_los_Hechos</summary>
        public static string Lugar_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Lugar_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>PaisH</summary>
        public static string PaisH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("PaisH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_Hechos</summary>
        public static string Municipio_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Municipio_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ColoniaH</summary>
        public static string ColoniaH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("ColoniaH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CalleH</summary>
        public static string CalleH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("CalleH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_InteriorH</summary>
        public static string Numero_InteriorH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Numero_InteriorH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_ExteriorH</summary>
        public static string Numero_ExteriorH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Numero_ExteriorH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_PostalH</summary>
        public static string Codigo_PostalH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Codigo_PostalH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LongitudH</summary>
        public static string LongitudH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("LongitudH", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>LatitudH</summary>
        public static string LatitudH
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("LatitudH", CultureInfo.CurrentUICulture.Name) as String;
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

        /// <summary>Usuario_que_Cierra</summary>
        public static string Usuario_que_Cierra
        {
            get
            {
                SetPath();
                return resourceProviderexpediente_ministerio_publico.GetResource("Usuario_que_Cierra", CultureInfo.CurrentUICulture.Name) as String;
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
	/// <summary>Hechos</summary>	public static string TabHechos 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabHechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Canalizar</summary>	public static string TabCanalizar 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabCanalizar", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Acuerdo</summary>	public static string TabDatos_del_Acuerdo 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabDatos_del_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución o Dictaminación</summary>	public static string TabResolucion_o_Dictaminacion 	{		get		{			SetPath();  			return resourceProviderexpediente_ministerio_publico.GetResource("TabResolucion_o_Dictaminacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
