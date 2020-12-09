using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class ComparecienteResources
    {
        //private static IResourceProvider resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderCompareciente = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\ComparecienteResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_de_Atencion_Inicial</summary>
        public static string Registro_de_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("Registro_de_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AVPR_NAVPR</summary>
        public static string AVPR_NAVPR
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("AVPR_NAVPR", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AVPR_APBIS</summary>
        public static string AVPR_APBIS
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("AVPR_APBIS", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AVPR_CVEMU</summary>
        public static string AVPR_CVEMU
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("AVPR_CVEMU", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>AVPR_CVEAG</summary>
        public static string AVPR_CVEAG
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("AVPR_CVEAG", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_CONOF</summary>
        public static string OFEN_CONOF
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_CONOF", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_OPATE</summary>
        public static string OFEN_OPATE
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_OPATE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_OMATE</summary>
        public static string OFEN_OMATE
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_OMATE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_ONOMB</summary>
        public static string OFEN_ONOMB
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_ONOMB", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_INSTI</summary>
        public static string OFEN_INSTI
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_INSTI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_ESTAD</summary>
        public static string OFEN_ESTAD
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_ESTAD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_EDAD</summary>
        public static string OFEN_EDAD
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_EDAD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_OCUPA</summary>
        public static string OFEN_OCUPA
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_OCUPA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>FECHAREGIS</summary>
        public static string FECHAREGIS
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("FECHAREGIS", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>USUARIO</summary>
        public static string USUARIO
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("USUARIO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>HORAREGIST</summary>
        public static string HORAREGIST
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("HORAREGIST", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fuente</summary>
        public static string fuente
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("fuente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>fecenvio</summary>
        public static string fecenvio
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("fecenvio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_PROBABLE</summary>
        public static string OFEN_PROBABLE
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_PROBABLE", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>OFEN_RSOMENOR</summary>
        public static string OFEN_RSOMENOR
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("OFEN_RSOMENOR", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>REPR_Sexo</summary>
        public static string REPR_Sexo
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("REPR_Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>REPR_NACIONALIDAD</summary>
        public static string REPR_NACIONALIDAD
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("REPR_NACIONALIDAD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>REPR_ESCOLARIDAD</summary>
        public static string REPR_ESCOLARIDAD
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("REPR_ESCOLARIDAD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>TIPO_EDAD</summary>
        public static string TIPO_EDAD
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("TIPO_EDAD", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>IdEstadoInstitucion</summary>
        public static string IdEstadoInstitucion
        {
            get
            {
                SetPath();
                return resourceProviderCompareciente.GetResource("IdEstadoInstitucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderCompareciente.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
