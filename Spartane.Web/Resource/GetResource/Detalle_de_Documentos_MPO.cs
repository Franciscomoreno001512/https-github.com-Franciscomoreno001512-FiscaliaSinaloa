using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Documentos_MPOResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Documentos_MPO = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Documentos_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Documentos_MPO = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documentos_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Documentos_MPO = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Documentos_MPOResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Documentos_MPO</summary>
        public static string Detalle_de_Documentos_MPO
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Detalle_de_Documentos_MPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha</summary>
        public static string Fecha
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Fecha", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora</summary>
        public static string Hora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Hora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento</summary>
        public static string Tipo_de_Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Tipo_de_Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento</summary>
        public static string Documento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Documento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Involucrado</summary>
        public static string Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Probable_Responsable</summary>
        public static string Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo_Adjunto</summary>
        public static string Archivo_Adjunto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Archivo_Adjunto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Archivo</summary>
        public static string Archivo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Archivo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lista_para_periciales</summary>
        public static string Lista_para_periciales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Lista_para_periciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Indicios_a_enviar</summary>
        public static string Indicios_a_enviar
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Indicios_a_enviar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_Persona</summary>
        public static string Estatus_Persona
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Estatus_Persona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Localizacion</summary>
        public static string Fecha_Localizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Fecha_Localizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Localizacion</summary>
        public static string Hora_Localizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Hora_Localizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Condiciones_de_Localizacion</summary>
        public static string Condiciones_de_Localizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Condiciones_de_Localizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_Hallazgo</summary>
        public static string Lugar_de_Hallazgo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Lugar_de_Hallazgo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Posible_Causa_de_la_Desaparacion</summary>
        public static string Posible_Causa_de_la_Desaparacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Posible_Causa_de_la_Desaparacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ente_que_localiza_al_no_localizado</summary>
        public static string Ente_que_localiza_al_no_localizado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Ente_que_localiza_al_no_localizado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ente_Paterno</summary>
        public static string ente_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("ente_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ente_Materno</summary>
        public static string ente_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("ente_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ente_Nombre</summary>
        public static string ente_Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("ente_Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoridad_que_conoce_el_hecho</summary>
        public static string Autoridad_que_conoce_el_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("Autoridad_que_conoce_el_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>autoridad_Paterno</summary>
        public static string autoridad_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("autoridad_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>autoridad_Materno</summary>
        public static string autoridad_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("autoridad_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>autoridad_Nombre</summary>
        public static string autoridad_Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Documentos_MPO.GetResource("autoridad_Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Documentos_MPO.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Localización</summary>	public static string TabLocalizacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Documentos_MPO.GetResource("TabLocalizacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Ente y Autoridad</summary>	public static string TabEnte_y_Autoridad 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Documentos_MPO.GetResource("TabEnte_y_Autoridad", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
