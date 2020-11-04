using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Modulo_de_Atencion_InicialResources
    {
        //private static IResourceProvider resourceProviderModulo_de_Atencion_Inicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Modulo_de_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderModulo_de_Atencion_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_de_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderModulo_de_Atencion_Inicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Modulo_de_Atencion_InicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Modulo_de_Atencion_Inicial</summary>
        public static string Modulo_de_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Modulo_de_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio</summary>
        public static string Folio
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Folio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NUAT</summary>
        public static string NUAT
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("NUAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menor_de_Edad</summary>
        public static string Menor_de_Edad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Menor_de_Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Representante_Legal</summary>
        public static string Representante_Legal
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Representante_Legal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Tutor</summary>
        public static string Nombre_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Nombre_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Tutor</summary>
        public static string Apellido_Paterno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Paterno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Tutor</summary>
        public static string Apellido_Materno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Materno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_del_Tutor</summary>
        public static string Fecha_de_Nacimiento_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Fecha_de_Nacimiento_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Tutor</summary>
        public static string Edad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Edad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Tutor</summary>
        public static string Sexo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Sexo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Tutor</summary>
        public static string Estado_Civil_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estado_Civil_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_del_Tutor</summary>
        public static string Tipo_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Tipo_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_del_Tutor</summary>
        public static string Numero_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Tutor</summary>
        public static string Nacionalidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Nacionalidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_del_Tutor</summary>
        public static string Escolaridad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Escolaridad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_del_Tutor</summary>
        public static string Ocupacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Ocupacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Tutor</summary>
        public static string Calle_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Calle_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Tutor</summary>
        public static string Numero_Exterior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Exterior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Tutor</summary>
        public static string Numero_Interior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Interior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Tutor</summary>
        public static string Colonia_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Colonia_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Tutor</summary>
        public static string Codigo_Postal_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Codigo_Postal_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad_del_Tutor</summary>
        public static string Localidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Localidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Tutor</summary>
        public static string Municipio_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Municipio_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Tutor</summary>
        public static string Estado_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estado_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Tutor</summary>
        public static string Telefono_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Telefono_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Tutor</summary>
        public static string Celular_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Celular_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Tutor</summary>
        public static string Correo_Electronico_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Correo_Electronico_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Representante</summary>
        public static string Nombre_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Nombre_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Representante</summary>
        public static string Apellido_Paterno_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Paterno_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Representante</summary>
        public static string Apellido_Materno_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Apellido_Materno_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Juridica</summary>
        public static string Calidad_Juridica
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Calidad_Juridica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Representante</summary>
        public static string Calle_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Calle_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Representante</summary>
        public static string Numero_Exterior_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Exterior_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Representante</summary>
        public static string Numero_Interior_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_Interior_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Representante</summary>
        public static string Colonia_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Colonia_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad_del_Representante</summary>
        public static string Localidad_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Localidad_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Representante</summary>
        public static string Municipio_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Municipio_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Representante</summary>
        public static string Estado_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estado_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Representante</summary>
        public static string Telefono_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Telefono_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Representante</summary>
        public static string Celular_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Celular_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Representante</summary>
        public static string Correo_Electronico_del_Representante
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Correo_Electronico_del_Representante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa</summary>
        public static string Narrativa
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Narrativa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Atencion_Medica</summary>
        public static string Atencion_Medica
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Atencion_Medica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Atencion_Psicologica</summary>
        public static string Atencion_Psicologica
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Atencion_Psicologica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Requiere_Traductor</summary>
        public static string Requiere_Traductor
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Requiere_Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Compareciente</summary>
        public static string Tipo_de_Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Tipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Turno_Asignado</summary>
        public static string Turno_Asignado
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Turno_Asignado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Unidad</summary>
        public static string Unidad
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Unidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_Caso</summary>
        public static string Municipio_Caso
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Municipio_Caso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Expediente</summary>
        public static string Numero_de_Expediente
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Numero_de_Expediente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_Hechos_MPO</summary>
        public static string Colonia_Hechos_MPO
        {
            get
            {
                SetPath();
                return resourceProviderModulo_de_Atencion_Inicial.GetResource("Colonia_Hechos_MPO", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos del Caso</summary>	public static string TabDatos_del_Caso 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_del_Caso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Representante Legal</summary>	public static string TabDatos_del_Representante_Legal 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_del_Representante_Legal", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Servicios de Apoyo</summary>	public static string TabDatos_de_Servicios_de_Apoyo 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Servicios de Apoyo</summary>	public static string TabServicios_de_Apoyo 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabServicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Tipo de Compareciente</summary>	public static string TabTipo_de_Compareciente 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabTipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos en MPO</summary>	public static string TabDatos_de_los_Hechos_en_MPO 	{		get		{			SetPath();  			return resourceProviderModulo_de_Atencion_Inicial.GetResource("TabDatos_de_los_Hechos_en_MPO", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
