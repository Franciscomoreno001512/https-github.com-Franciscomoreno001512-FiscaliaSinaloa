using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Asignacion_de_TurnosResources
    {
        //private static IResourceProvider resourceProviderAsignacion_de_Turnos = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Asignacion_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderAsignacion_de_Turnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderAsignacion_de_Turnos = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Asignacion_de_TurnosResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Asignacion_de_Turnos</summary>
        public static string Asignacion_de_Turnos
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Asignacion_de_Turnos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Turno</summary>
        public static string Fecha_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Fecha_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Turno</summary>
        public static string Hora_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Hora_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Turno</summary>
        public static string Numero_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Numero_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad_de_Atencion</summary>
        public static string Unidad_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Unidad_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Recepcion</summary>
        public static string Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres</summary>
        public static string Nombres
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Atencion</summary>
        public static string Tipo_de_Atencion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Tipo_de_Atencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otra_Identificacion</summary>
        public static string Otra_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Otra_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Urgencia</summary>
        public static string Urgencia
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Urgencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Urgencia</summary>
        public static string Tipo_de_Urgencia
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Tipo_de_Urgencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Denuncia_Ciudadana</summary>
        public static string Denuncia_Ciudadana
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Denuncia_Ciudadana", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno_Previo</summary>
        public static string Turno_Previo
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Turno_Previo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Orientador</summary>
        public static string Orientador
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Orientador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus_de_Turno</summary>
        public static string Estatus_de_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Estatus_de_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo</summary>
        public static string Modulo
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Modulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_Finalizacion_Turno</summary>
        public static string Motivo_Finalizacion_Turno
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Motivo_Finalizacion_Turno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Asignacion</summary>
        public static string Fecha_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Fecha_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Asignacion</summary>
        public static string Hora_de_Asignacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Hora_de_Asignacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Finalizacion</summary>
        public static string Fecha_de_Finalizacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Fecha_de_Finalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Finalizacion</summary>
        public static string Hora_de_Finalizacion
        {
            get
            {
                SetPath();
                return resourceProviderAsignacion_de_Turnos.GetResource("Hora_de_Finalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderAsignacion_de_Turnos.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
