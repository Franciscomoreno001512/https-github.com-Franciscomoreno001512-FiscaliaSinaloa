using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Acuerdos_MASCResources
    {
        //private static IResourceProvider resourceProviderAcuerdos_MASC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Acuerdos_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAcuerdos_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Acuerdos_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAcuerdos_MASC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Acuerdos_MASCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Acuerdos_MASC</summary>
        public static string Acuerdos_MASC
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Acuerdos_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Acuerdo</summary>
        public static string Tipo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Tipo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Cumplimiento</summary>
        public static string Forma_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Forma_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_del_Cumplimiento</summary>
        public static string Descripcion_del_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Descripcion_del_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitante</summary>
        public static string Solicitante
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Solicitante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requerido</summary>
        public static string Requerido
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_Acordado</summary>
        public static string Lugar_Acordado
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Lugar_Acordado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio_Acordado</summary>
        public static string Domicilio_Acordado
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Domicilio_Acordado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Acuerdo</summary>
        public static string Hora_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Hora_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Inicio_de_Acuerdo</summary>
        public static string Fecha_de_Inicio_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Fecha_de_Inicio_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_Total</summary>
        public static string Monto_Total
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Monto_Total", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Parcialidades</summary>
        public static string Parcialidades
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Parcialidades", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Periodicidad</summary>
        public static string Periodicidad
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Periodicidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_la_Parcialidad</summary>
        public static string Monto_de_la_Parcialidad
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Monto_de_la_Parcialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Personal_de_Seguimiento_Asignado</summary>
        public static string Personal_de_Seguimiento_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Personal_de_Seguimiento_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acuerdo</summary>
        public static string Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Comentarios</summary>
        public static string Comentarios
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Comentarios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Acuerdo_Cumplido</summary>
        public static string Acuerdo_Cumplido
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Acuerdo_Cumplido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento_de_Acuerdo</summary>
        public static string Fecha_de_Cumplimiento_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Fecha_de_Cumplimiento_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_de_Incumplimiento</summary>
        public static string Razon_de_Incumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Razon_de_Incumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Revision</summary>
        public static string Fecha_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Fecha_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Revision</summary>
        public static string Hora_de_Revision
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Hora_de_Revision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Revisa</summary>
        public static string Usuario_que_Revisa
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Usuario_que_Revisa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Resultado</summary>
        public static string Resultado
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Rechazo_de_Acuerdo</summary>
        public static string Motivo_de_Rechazo_de_Acuerdo
        {
            get
            {
                SetPath();
                return resourceProviderAcuerdos_MASC.GetResource("Motivo_de_Rechazo_de_Acuerdo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAcuerdos_MASC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Autorización</summary>	public static string TabAutorizacion 	{		get		{			SetPath();  			return resourceProviderAcuerdos_MASC.GetResource("TabAutorizacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
