using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Proceso_PenalResources
    {
        //private static IResourceProvider resourceProviderProceso_Penal = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderProceso_Penal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderProceso_Penal = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Proceso_PenalResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Proceso_Penal</summary>
        public static string Proceso_Penal
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Proceso_Penal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imputado</summary>
        public static string Imputado
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Reclasificacion_Juridica</summary>
        public static string Reclasificacion_Juridica
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Reclasificacion_Juridica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delitos</summary>
        public static string Delitos
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Delitos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Plazo_Constitucional</summary>
        public static string Plazo_Constitucional
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Plazo_Constitucional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Continuacion_Audiencia</summary>
        public static string Fecha_Continuacion_Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha_Continuacion_Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Continuacion_Audiencia</summary>
        public static string Hora_Continuacion_Audiencia
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora_Continuacion_Audiencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vinculacion</summary>
        public static string Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_No_Vinculacion</summary>
        public static string Resultado_No_Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Resultado_No_Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_Vinculacion</summary>
        public static string Resultado_Vinculacion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Resultado_Vinculacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>plazo_investigacion_complementaria</summary>
        public static string plazo_investigacion_complementaria
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("plazo_investigacion_complementaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado_de_Investigacion_Complementari</summary>
        public static string Resultado_de_Investigacion_Complementari
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Resultado_de_Investigacion_Complementari", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecha_investigacion_complementaria</summary>
        public static string fecha_investigacion_complementaria
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("fecha_investigacion_complementaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>hora_investigacion_complementaria</summary>
        public static string hora_investigacion_complementaria
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("hora_investigacion_complementaria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medidas_Cautelares</summary>
        public static string Medidas_Cautelares
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Medidas_Cautelares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Juez_de_Control</summary>
        public static string Nombre_del_Juez_de_Control
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Nombre_del_Juez_de_Control", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Entrega_de_Escrito_de_Acusacion</summary>
        public static string Fecha_de_Entrega_de_Escrito_de_Acusacion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha_de_Entrega_de_Escrito_de_Acusacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Entrega_de_Escrito_de_Acusacion</summary>
        public static string Hora_de_Entrega_de_Escrito_de_Acusacion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora_de_Entrega_de_Escrito_de_Acusacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Audiencia_Intermedia</summary>
        public static string Fecha_de_Audiencia_Intermedia
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha_de_Audiencia_Intermedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Audiencia_Intermedia</summary>
        public static string Hora_de_Audiencia_Intermedia
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora_de_Audiencia_Intermedia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_de_Prueba_del_Imputado</summary>
        public static string Medios_de_Prueba_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Medios_de_Prueba_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acusador_Coadyudante</summary>
        public static string Acusador_Coadyudante
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Acusador_Coadyudante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_de_Prueba_de_la_Victima</summary>
        public static string Medios_de_Prueba_de_la_Victima
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Medios_de_Prueba_de_la_Victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cumplio_descubrimiento_probatorio</summary>
        public static string cumplio_descubrimiento_probatorio
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("cumplio_descubrimiento_probatorio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Medios_de_Prueba_Admitidos</summary>
        public static string Medios_de_Prueba_Admitidos
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Medios_de_Prueba_Admitidos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acuerdos_Probatorios</summary>
        public static string Acuerdos_Probatorios
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Acuerdos_Probatorios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>acuerdos_probatorios_cuales_fueron</summary>
        public static string acuerdos_probatorios_cuales_fueron
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("acuerdos_probatorios_cuales_fueron", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado</summary>
        public static string Resultado
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tribunal_de_Enjuiciamiento</summary>
        public static string Tribunal_de_Enjuiciamiento
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Tribunal_de_Enjuiciamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Juez</summary>
        public static string Nombre_del_Juez
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Nombre_del_Juez", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Colegiado</summary>
        public static string Juez_Colegiado
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Juez_Colegiado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Relator</summary>
        public static string Juez_Relator
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Juez_Relator", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez_Vocal</summary>
        public static string Juez_Vocal
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Juez_Vocal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Audiencia_de_Juicio</summary>
        public static string Fecha_de_Audiencia_de_Juicio
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fecha_de_Audiencia_de_Juicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Audiencia_de_Juicio</summary>
        public static string Hora_de_Audiencia_de_Juicio
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Hora_de_Audiencia_de_Juicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fallo_del_Tribunal</summary>
        public static string Fallo_del_Tribunal
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Fallo_del_Tribunal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>pruebas_a_desahogar</summary>
        public static string pruebas_a_desahogar
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("pruebas_a_desahogar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resolucion</summary>
        public static string Resolucion
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Resolucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Plazo_meses</summary>
        public static string Plazo_meses
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Plazo_meses", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Condiciones</summary>
        public static string Condiciones
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Condiciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Sentencia</summary>
        public static string Tipo_de_Sentencia
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Tipo_de_Sentencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cuantia_de_pena_anios</summary>
        public static string cuantia_de_pena_anios
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("cuantia_de_pena_anios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>cuantia_de_pena_meses</summary>
        public static string cuantia_de_pena_meses
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("cuantia_de_pena_meses", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_la_Reparacion_del_Dano</summary>
        public static string Monto_de_la_Reparacion_del_Dano
        {
            get
            {
                SetPath();
                return resourceProviderProceso_Penal.GetResource("Monto_de_la_Reparacion_del_Dano", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Fase Complementaria</summary>	public static string TabFase_Complementaria 	{		get		{			SetPath();  			return resourceProviderProceso_Penal.GetResource("TabFase_Complementaria", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fase Escrita</summary>	public static string TabFase_Escrita 	{		get		{			SetPath();  			return resourceProviderProceso_Penal.GetResource("TabFase_Escrita", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Audiencia Intermedia</summary>	public static string TabAudiencia_Intermedia 	{		get		{			SetPath();  			return resourceProviderProceso_Penal.GetResource("TabAudiencia_Intermedia", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Juicio Oral</summary>	public static string TabJuicio_Oral 	{		get		{			SetPath();  			return resourceProviderProceso_Penal.GetResource("TabJuicio_Oral", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Resolución</summary>	public static string TabResolucion 	{		get		{			SetPath();  			return resourceProviderProceso_Penal.GetResource("TabResolucion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
