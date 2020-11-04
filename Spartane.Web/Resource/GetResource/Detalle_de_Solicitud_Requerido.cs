using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Solicitud_RequeridoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Solicitud_Requerido = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Solicitud_RequeridoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Solicitud_Requerido = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_RequeridoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Solicitud_Requerido = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Solicitud_RequeridoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Solicitud_Requerido</summary>
        public static string Detalle_de_Solicitud_Requerido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Detalle_de_Solicitud_Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroAT</summary>
        public static string idRegistroAT
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("idRegistroAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroUI</summary>
        public static string idRegistroUI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("idRegistroUI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>A_Quien_Sea_Responsable</summary>
        public static string A_Quien_Sea_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("A_Quien_Sea_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apodo</summary>
        public static string Apodo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Apodo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros_Nombres</summary>
        public static string Otros_Nombres
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Otros_Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Domicilio_Requerido</summary>
        public static string Referencia_de_Domicilio_Requerido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Referencia_de_Domicilio_Requerido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros_Domicilios</summary>
        public static string Otros_Domicilios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Otros_Domicilios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extencion</summary>
        public static string Extencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Extencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen</summary>
        public static string Pais_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Pais_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de</summary>
        public static string Originario_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Originario_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Nacimiento</summary>
        public static string Estado_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estado_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Nacimiento</summary>
        public static string Municipio_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Municipio_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inimputable</summary>
        public static string Inimputable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Inimputable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Inimputabilidad</summary>
        public static string Tipo_de_Inimputabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Tipo_de_Inimputabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Presenta_con_Detenido</summary>
        public static string Se_Presenta_con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Se_Presenta_con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_Registro_Nacional_de_Detenciones</summary>
        public static string Folio_Registro_Nacional_de_Detenciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Folio_Registro_Nacional_de_Detenciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Detencion</summary>
        public static string Fecha_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Fecha_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Detencion</summary>
        public static string Municipio_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Municipio_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Corporacion</summary>
        public static string Corporacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Corporacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Suspension_Condicional</summary>
        public static string Suspension_Condicional
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Suspension_Condicional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Suspension_Condicional</summary>
        public static string Fecha_de_Suspension_Condicional
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Fecha_de_Suspension_Condicional", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_donde_se_Encuentra_Detenido</summary>
        public static string Lugar_donde_se_Encuentra_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Lugar_donde_se_Encuentra_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Etnia</summary>
        public static string Etnia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Etnia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No__de_Hijos</summary>
        public static string No__de_Hijos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("No__de_Hijos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Religion</summary>
        public static string Religion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Religion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_Medico</summary>
        public static string Servicio_Medico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Servicio_Medico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estudios_Superiores</summary>
        public static string Estudios_Superiores
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estudios_Superiores", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Migratoria</summary>
        public static string Calidad_Migratoria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Calidad_Migratoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dialecto</summary>
        public static string Dialecto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Dialecto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Viene_en_Estado_de_Ebriedad</summary>
        public static string Viene_en_Estado_de_Ebriedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Viene_en_Estado_de_Ebriedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bajo_el_Efecto_de_una_Droga</summary>
        public static string Bajo_el_Efecto_de_una_Droga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Bajo_el_Efecto_de_una_Droga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Droga</summary>
        public static string Nombre_de_Droga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nombre_de_Droga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Adicciones_Probable_Responsable</summary>
        public static string Adicciones_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Adicciones_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugares_que_Frecuenta</summary>
        public static string Lugares_que_Frecuenta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Lugares_que_Frecuenta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Personales_Adicionales</summary>
        public static string Datos_Personales_Adicionales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Datos_Personales_Adicionales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Identificaciones</summary>
        public static string Otras_Identificaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Otras_Identificaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Mental</summary>
        public static string Discapacidad_Mental
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Discapacidad_Mental", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Fisica</summary>
        public static string Discapacidad_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Discapacidad_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Sensorial</summary>
        public static string Discapacidad_Sensorial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Discapacidad_Sensorial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Psicosocial</summary>
        public static string Discapacidad_Psicosocial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Discapacidad_Psicosocial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Tutor</summary>
        public static string Nombre_de_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nombre_de_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_Tutor</summary>
        public static string Apellido_Paterno_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Apellido_Paterno_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_Tutor</summary>
        public static string Apellido_Materno_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Apellido_Materno_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Tutor</summary>
        public static string Nombre_Completo_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nombre_Completo_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_tutor</summary>
        public static string Fecha_de_Nacimiento_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Fecha_de_Nacimiento_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_tutor</summary>
        public static string Edad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Edad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_tutor</summary>
        public static string Sexo_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Sexo_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_tutor</summary>
        public static string Estado_Civil_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estado_Civil_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_tutor</summary>
        public static string Tipo_de_Identificacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Tipo_de_Identificacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_tutor</summary>
        public static string Numero_de_Identificacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_de_Identificacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_tutor</summary>
        public static string Nacionalidad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nacionalidad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_tutor</summary>
        public static string Escolaridad_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Escolaridad_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_tutor</summary>
        public static string Ocupacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Ocupacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_tutor</summary>
        public static string Pais_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Pais_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_tutor</summary>
        public static string Estado_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Estado_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_tutor</summary>
        public static string Municipio_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Municipio_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_tutor</summary>
        public static string Poblacion_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Poblacion_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_tutor</summary>
        public static string Colonia_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Colonia_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_tutor</summary>
        public static string Codigo_Postal_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Codigo_Postal_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_tutor</summary>
        public static string Calle_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Calle_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_tutor</summary>
        public static string Numero_Exterior_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_Exterior_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_tutor</summary>
        public static string Numero_Interior_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Numero_Interior_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_tutor</summary>
        public static string Latitud_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Latitud_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_tutor</summary>
        public static string Longitud_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Longitud_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension_tutor</summary>
        public static string Extension_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Extension_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_tutor</summary>
        public static string Celular_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Celular_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_tutor</summary>
        public static string Correo_Electronico_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Correo_Electronico_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen_Tutor</summary>
        public static string Pais_de_Origen_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Pais_de_Origen_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de_Tutor</summary>
        public static string Originario_de_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Originario_de_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP_Tutor</summary>
        public static string CURP_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("CURP_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC_Tutor</summary>
        public static string RFC_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("RFC_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Padecimiento_de_Enfermedad</summary>
        public static string Padecimiento_de_Enfermedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Padecimiento_de_Enfermedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cejas</summary>
        public static string Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anteojos</summary>
        public static string Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Nariz</summary>
        public static string Forma_de_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Forma_de_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nariz_base</summary>
        public static string Nariz_base
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Nariz_base", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grosor_de_Labios</summary>
        public static string Grosor_de_Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Grosor_de_Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Menton</summary>
        public static string Forma_de_Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Forma_de_Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen_Tatuaje</summary>
        public static string Imagen_Tatuaje
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Imagen_Tatuaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Senas_Particulares</summary>
        public static string Otras_Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Otras_Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imputado_Recluido</summary>
        public static string Imputado_Recluido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("Imputado_Recluido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Media Filiación</summary>	public static string TabDatos_de_Media_Filiacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Solicitud_Requerido.GetResource("TabDatos_de_Media_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
