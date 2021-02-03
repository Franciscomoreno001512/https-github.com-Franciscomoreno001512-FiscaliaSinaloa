using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class JudicializacionResources
    {
        //private static IResourceProvider resourceProviderJudicializacion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\JudicializacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderJudicializacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\JudicializacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderJudicializacion = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\JudicializacionResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Judicializacion</summary>
        public static string Judicializacion
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Judicializacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo</summary>
        public static string Tipo
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Tipo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>causa_o_cuadernillo</summary>
        public static string causa_o_cuadernillo
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("causa_o_cuadernillo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fase_Actual</summary>
        public static string Fase_Actual
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fase_Actual", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vinculacion</summary>
        public static string Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Actos</summary>
        public static string Fecha_Actos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Actos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Actos</summary>
        public static string Hora_Actos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Actos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Actos</summary>
        public static string Observaciones_Actos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Actos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Genericos</summary>
        public static string Fecha_Genericos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Genericos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Genericos</summary>
        public static string Hora_Genericos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Genericos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Genericos</summary>
        public static string Observaciones_Genericos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Genericos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Fase_Inicial</summary>
        public static string Fecha_Fase_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Fase_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Fase_Inicial</summary>
        public static string Hora_Fase_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Fase_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Fase_Inicial</summary>
        public static string Observaciones_Fase_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Fase_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Fase_Intermedia</summary>
        public static string Fecha_Fase_Intermedia
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Fase_Intermedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Fase_Intermedia</summary>
        public static string Hora_Fase_Intermedia
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Fase_Intermedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Fase_Intermedia</summary>
        public static string Observaciones_Fase_Intermedia
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Fase_Intermedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Audiencia_de_Juicio</summary>
        public static string Fecha_de_Audiencia_de_Juicio
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_de_Audiencia_de_Juicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Audiencia_de_Juicio</summary>
        public static string Hora_de_Audiencia_de_Juicio
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_de_Audiencia_de_Juicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tribunal_de_Enjuiciamiento</summary>
        public static string Tribunal_de_Enjuiciamiento
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Tribunal_de_Enjuiciamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Juez</summary>
        public static string Nombre_del_Juez
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Nombre_del_Juez", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Presidente</summary>
        public static string Juez_Presidente
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Juez_Presidente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Relator</summary>
        public static string Juez_Relator
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Juez_Relator", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Vocal</summary>
        public static string Juez_Vocal
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Juez_Vocal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>medios_desahogo</summary>
        public static string medios_desahogo
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("medios_desahogo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Sentencia</summary>
        public static string Tipo_de_Sentencia
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Tipo_de_Sentencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuantia_de_Pena_Anos</summary>
        public static string Cuantia_de_Pena_Anos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Cuantia_de_Pena_Anos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuantia_de_Pena_Meses</summary>
        public static string Cuantia_de_Pena_Meses
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Cuantia_de_Pena_Meses", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_Reparacion_del_Dano</summary>
        public static string Monto_de_Reparacion_del_Dano
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Monto_de_Reparacion_del_Dano", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Fase_Juicio_Oral</summary>
        public static string Observaciones_Fase_Juicio_Oral
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Fase_Juicio_Oral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Fase_Salidas_Alternas</summary>
        public static string Fecha_Fase_Salidas_Alternas
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Fase_Salidas_Alternas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Fase_Salidas_Alternas</summary>
        public static string Hora_Fase_Salidas_Alternas
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Fase_Salidas_Alternas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Fase_Salidas_Alternas</summary>
        public static string Observaciones_Fase_Salidas_Alternas
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Fase_Salidas_Alternas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Fase_Sobreseimientos</summary>
        public static string Fecha_Fase_Sobreseimientos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Fecha_Fase_Sobreseimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Fase_Sobreseimientos</summary>
        public static string Hora_Fase_Sobreseimientos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Hora_Fase_Sobreseimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones_Fase_Sobreseimientos</summary>
        public static string Observaciones_Fase_Sobreseimientos
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones_Fase_Sobreseimientos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderJudicializacion.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Actos de Investigación</summary>	public static string TabActos_de_Investigacion 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabActos_de_Investigacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Genéricos</summary>	public static string TabGenericos 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabGenericos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fase Inicial</summary>	public static string TabFase_Inicial 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabFase_Inicial", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fase Intermedia</summary>	public static string TabFase_Intermedia 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabFase_Intermedia", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fase Juicio Oral</summary>	public static string TabFase_Juicio_Oral 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabFase_Juicio_Oral", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Salidas Alternas</summary>	public static string TabSalidas_Alternas 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabSalidas_Alternas", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Sobreseimientos</summary>	public static string TabSobreseimientos 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabSobreseimientos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Movimientos</summary>	public static string TabMovimientos 	{		get		{			SetPath();  			return resourceProviderJudicializacion.GetResource("TabMovimientos", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
