using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Datos_GeneralesResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Datos_Generales = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Datos_GeneralesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Datos_Generales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_GeneralesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Datos_Generales = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Datos_GeneralesResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Datos_Generales</summary>
        public static string Detalle_de_Datos_Generales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Detalle_de_Datos_Generales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Confidenciales</summary>
        public static string Datos_Confidenciales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Datos_Confidenciales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Informo_sobre_el_Procedimiento</summary>
        public static string Se_Informo_sobre_el_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Se_Informo_sobre_el_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Compareciente</summary>
        public static string Tipo_de_Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Desaparecida</summary>
        public static string Persona_Desaparecida
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Persona_Desaparecida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Aparecio</summary>
        public static string Persona_Aparecio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Persona_Aparecio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Aparicion</summary>
        public static string Fecha_de_Aparicion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Fecha_de_Aparicion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Con_Vida</summary>
        public static string Con_Vida
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Con_Vida", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral</summary>
        public static string Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Q_Q_R_O_</summary>
        public static string Q_Q_R_O_
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Q_Q_R_O_", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Es_victima</summary>
        public static string Es_victima
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Es_victima", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Juridica</summary>
        public static string Calidad_Juridica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calidad_Juridica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_Social</summary>
        public static string Razon_Social
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Razon_Social", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_Corporacion</summary>
        public static string Municipio_Corporacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Municipio_Corporacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Corporacion</summary>
        public static string Corporacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Corporacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen</summary>
        public static string Pais_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Pais_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de</summary>
        public static string Originario_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Originario_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Domicilio</summary>
        public static string Referencia_de_Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Referencia_de_Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension</summary>
        public static string Extension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_de_Vulnerabilidad</summary>
        public static string Situacion_de_Vulnerabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Situacion_de_Vulnerabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_al_que_pertenece</summary>
        public static string Grupo_al_que_pertenece
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Grupo_al_que_pertenece", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Etnia</summary>
        public static string Etnia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Etnia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No_de_Hijos</summary>
        public static string No_de_Hijos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("No_de_Hijos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Religion</summary>
        public static string Religion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Religion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_Medico</summary>
        public static string Servicio_Medico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Servicio_Medico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_</summary>
        public static string Escolaridad_
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Escolaridad_", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estudios_Superiores</summary>
        public static string Estudios_Superiores
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estudios_Superiores", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incompleto</summary>
        public static string Incompleto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Incompleto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Migratoria</summary>
        public static string Calidad_Migratoria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calidad_Migratoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Nacimiento</summary>
        public static string Estado_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Nacimiento</summary>
        public static string Municipio_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Municipio_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dialecto</summary>
        public static string Dialecto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Dialecto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Involucrado</summary>
        public static string Estado_de_Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_de_Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incapaz</summary>
        public static string Incapaz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Incapaz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Inimputabilidad</summary>
        public static string Tipo_de_Inimputabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Inimputabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique</summary>
        public static string Especifique
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Especifique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Informaron_sobre_sus_Derechos</summary>
        public static string Se_Informaron_sobre_sus_Derechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Se_Informaron_sobre_sus_Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Gravidez</summary>
        public static string Gravidez
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Gravidez", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Adicciones_de_Involucrado</summary>
        public static string Adicciones_de_Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Adicciones_de_Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugares_que_Frecuenta</summary>
        public static string Lugares_que_Frecuenta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Lugares_que_Frecuenta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Personales_Adicionales</summary>
        public static string Datos_Personales_Adicionales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Datos_Personales_Adicionales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Identificaciones</summary>
        public static string Otras_Identificaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Otras_Identificaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Mental</summary>
        public static string Discapacidad_Mental
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Discapacidad_Mental", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Fisica</summary>
        public static string Discapacidad_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Discapacidad_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Sensorial</summary>
        public static string Discapacidad_Sensorial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Discapacidad_Sensorial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Psicosocial</summary>
        public static string Discapacidad_Psicosocial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Discapacidad_Psicosocial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros_Domicilios</summary>
        public static string Otros_Domicilios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Otros_Domicilios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Tutor</summary>
        public static string Nombre_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombre_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Tutor</summary>
        public static string Apellido_Paterno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Paterno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Tutor</summary>
        public static string Apellido_Materno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Materno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_del_Tutor</summary>
        public static string Nombre_Completo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombre_Completo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_del_Tutor</summary>
        public static string Fecha_de_Nacimiento_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Fecha_de_Nacimiento_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Tutor</summary>
        public static string Edad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Edad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Tutor</summary>
        public static string Sexo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Sexo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Tutor</summary>
        public static string Estado_Civil_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_Civil_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_del_Tutor</summary>
        public static string Tipo_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_del_Tutor</summary>
        public static string Numero_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP_Tutor</summary>
        public static string CURP_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("CURP_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC_Tutor</summary>
        public static string RFC_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("RFC_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Tutor</summary>
        public static string Nacionalidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nacionalidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_del_Tutor</summary>
        public static string Escolaridad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Escolaridad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_del_Tutor</summary>
        public static string Ocupacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Ocupacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen_Tutor</summary>
        public static string Pais_de_Origen_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Pais_de_Origen_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de_T</summary>
        public static string Originario_de_T
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Originario_de_T", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Tutor</summary>
        public static string Pais_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Pais_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Tutor</summary>
        public static string Estado_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Tutor</summary>
        public static string Municipio_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Municipio_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_Tutor</summary>
        public static string Poblacion_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Poblacion_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad_del_Tutor</summary>
        public static string Localidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Localidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Tutor</summary>
        public static string Colonia_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Colonia_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Tutor</summary>
        public static string Codigo_Postal_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Codigo_Postal_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Tutor</summary>
        public static string Calle_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calle_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Tutor</summary>
        public static string Numero_Exterior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Exterior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Tutor</summary>
        public static string Numero_Interior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Interior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Domicilio_Tutor</summary>
        public static string Referencia_de_Domicilio_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Referencia_de_Domicilio_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_Tutor</summary>
        public static string Latitud_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Latitud_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_Tutor</summary>
        public static string Longitud_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Longitud_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Tutor</summary>
        public static string Telefono_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Telefono_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension_del_Tutor</summary>
        public static string Extension_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Extension_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Tutor</summary>
        public static string Celular_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Celular_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Tutor</summary>
        public static string Correo_Electronico_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Correo_Electronico_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres2</summary>
        public static string Nombres2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombres2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno2</summary>
        public static string Apellido_Paterno2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Paterno2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno2</summary>
        public static string Apellido_Materno2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Apellido_Materno2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo2</summary>
        public static string Nombre_Completo2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nombre_Completo2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo2</summary>
        public static string Sexo2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Sexo2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad2</summary>
        public static string Nacionalidad2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Nacionalidad2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad2</summary>
        public static string Escolaridad2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Escolaridad2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_Estado_Institucion</summary>
        public static string ID_Estado_Institucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("ID_Estado_Institucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Titulo_del_Hecho</summary>
        public static string Titulo_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Titulo_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_hecho</summary>
        public static string Pais_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Pais_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Hecho</summary>
        public static string Estado_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estado_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_los_Hechos</summary>
        public static string Municipio_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Municipio_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_Hechos</summary>
        public static string Poblacion_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Poblacion_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_de_los_Hechos</summary>
        public static string Colonia_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Colonia_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_de_los_Hechos</summary>
        public static string Codigo_Postal_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Codigo_Postal_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_de_los_Hechos</summary>
        public static string Calle_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calle_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_de_los_Hechos</summary>
        public static string Entre_Calle_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Entre_Calle_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_calle_de_los_hechos</summary>
        public static string Y_calle_de_los_hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Y_calle_de_los_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_de_los_Hechos</summary>
        public static string Numero_Exterior_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Exterior_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_de_los_Hechos</summary>
        public static string Numero_Interior_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Numero_Interior_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_Hechos</summary>
        public static string Referencia_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Referencia_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_de_los_Hechos</summary>
        public static string Latitud_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Latitud_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_de_los_Hechos</summary>
        public static string Longitud_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Longitud_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documento_Extraviado</summary>
        public static string Documento_Extraviado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Documento_Extraviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Documento_Extraviado</summary>
        public static string Tipo_de_Documento_Extraviado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Documento_Extraviado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_lugar_del_hecho</summary>
        public static string Tipo_de_lugar_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_lugar_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso</summary>
        public static string Peso
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Peso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatura</summary>
        public static string Estatura
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Estatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Padecimiento_de_Enfermedad</summary>
        public static string Padecimiento_de_Enfermedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Padecimiento_de_Enfermedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cejas</summary>
        public static string Tipo_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo_de_Cabello</summary>
        public static string Largo_de_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Largo_de_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Cabello</summary>
        public static string Forma_de_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_de_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Cabello</summary>
        public static string Color_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Color_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Ojos</summary>
        public static string Tamano_de_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tamano_de_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Ojos</summary>
        public static string Forma_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anteojos</summary>
        public static string Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Nariz</summary>
        public static string Forma_de_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_de_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Nariz</summary>
        public static string Tamano_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tamano_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grosor_de_Labios</summary>
        public static string Grosor_de_Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Grosor_de_Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Menton</summary>
        public static string Forma_de_Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_de_Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen_Tatuaje</summary>
        public static string Imagen_Tatuaje
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Imagen_Tatuaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Senas_Particulares</summary>
        public static string Otras_Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Otras_Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causal</summary>
        public static string Causal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Causal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_de_Interrupcion</summary>
        public static string Causa_de_Interrupcion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Causa_de_Interrupcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Insuficientes</summary>
        public static string Datos_Insuficientes
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Datos_Insuficientes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Actualizacion_de_Sobreseimiento</summary>
        public static string Actualizacion_de_Sobreseimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Datos_Generales.GetResource("Actualizacion_de_Sobreseimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Representante Legal</summary>	public static string TabRepresentante_Legal 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabRepresentante_Legal", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Media Filiación</summary>	public static string TabDatos_de_Media_Filiacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabDatos_de_Media_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Desestimación</summary>	public static string TabDesestimacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Datos_Generales.GetResource("TabDesestimacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
