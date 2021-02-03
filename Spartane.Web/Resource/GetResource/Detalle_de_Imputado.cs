using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_ImputadoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Imputado = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Imputado = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_ImputadoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Imputado</summary>
        public static string Detalle_de_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Detalle_de_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral</summary>
        public static string Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modulo_Atencion_Inicial</summary>
        public static string Modulo_Atencion_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Modulo_Atencion_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MP</summary>
        public static string Expediente_MP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Expediente_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_MASC</summary>
        public static string Expediente_MASC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Expediente_MASC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Quien_Resulte_Responsable</summary>
        public static string Quien_Resulte_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Quien_Resulte_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Presenta_con_Detenido</summary>
        public static string Se_Presenta_con_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Se_Presenta_con_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_Registro_Nacional_de_Detenciones</summary>
        public static string Folio_Registro_Nacional_de_Detenciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Folio_Registro_Nacional_de_Detenciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_Detencion</summary>
        public static string Lugar_de_Detencion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Lugar_de_Detencion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Detenido</summary>
        public static string Nombre_Completo_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre_Completo_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Juridica</summary>
        public static string Calidad_Juridica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calidad_Juridica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_Social</summary>
        public static string Razon_Social
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Razon_Social", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen</summary>
        public static string Pais_de_Origen
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Pais_de_Origen", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de</summary>
        public static string Originario_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Originario_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Imputado</summary>
        public static string Calle_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calle_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Domicilio</summary>
        public static string Referencia_de_Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Referencia_de_Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension</summary>
        public static string Extension
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apodo</summary>
        public static string Apodo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apodo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Etnia</summary>
        public static string Etnia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Etnia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>No_de_Hijos</summary>
        public static string No_de_Hijos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("No_de_Hijos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Religion</summary>
        public static string Religion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Religion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Servicio_Medico</summary>
        public static string Servicio_Medico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Servicio_Medico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_Detenido</summary>
        public static string Escolaridad_Detenido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Escolaridad_Detenido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estudios_Superiores</summary>
        public static string Estudios_Superiores
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estudios_Superiores", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Incompleto</summary>
        public static string Incompleto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Incompleto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calidad_Migratoria</summary>
        public static string Calidad_Migratoria
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calidad_Migratoria", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Nacimiento</summary>
        public static string Estado_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Nacimiento</summary>
        public static string Municipio_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Municipio_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dialecto</summary>
        public static string Dialecto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Dialecto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Viene_en_Estado_de_Ebriedad</summary>
        public static string Viene_en_Estado_de_Ebriedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Viene_en_Estado_de_Ebriedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bajo_el_Efecto_de_una_Droga</summary>
        public static string Bajo_el_Efecto_de_una_Droga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Bajo_el_Efecto_de_una_Droga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_Droga</summary>
        public static string Nombre_de_Droga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre_de_Droga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Inimputable</summary>
        public static string Inimputable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Inimputable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Gravidez</summary>
        public static string Gravidez
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Gravidez", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Inimputabilidad</summary>
        public static string Tipo_de_Inimputabilidad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tipo_de_Inimputabilidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especifique</summary>
        public static string Especifique
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Especifique", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Adicciones_Probable_Responsable</summary>
        public static string Adicciones_Probable_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Adicciones_Probable_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugares_que_Frecuenta</summary>
        public static string Lugares_que_Frecuenta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Lugares_que_Frecuenta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Datos_Personales_Adicionales</summary>
        public static string Datos_Personales_Adicionales
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Datos_Personales_Adicionales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Identificaciones</summary>
        public static string Otras_Identificaciones
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Otras_Identificaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Mental</summary>
        public static string Discapacidad_Mental
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Discapacidad_Mental", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Fisica</summary>
        public static string Discapacidad_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Discapacidad_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Sensorial</summary>
        public static string Discapacidad_Sensorial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Discapacidad_Sensorial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Discapacidad_Psicosocial</summary>
        public static string Discapacidad_Psicosocial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Discapacidad_Psicosocial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros_Domicilios</summary>
        public static string Otros_Domicilios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Otros_Domicilios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otros_Nombres</summary>
        public static string Otros_Nombres
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Otros_Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres2</summary>
        public static string Nombres2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombres2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno2</summary>
        public static string Apellido_Paterno2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Paterno2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno2</summary>
        public static string Apellido_Materno2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Materno2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo2</summary>
        public static string Nombre_Completo2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre_Completo2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo2</summary>
        public static string Sexo2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Sexo2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad2</summary>
        public static string Nacionalidad2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nacionalidad2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad2</summary>
        public static string Escolaridad2
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Escolaridad2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ID_Estado_Institucion</summary>
        public static string ID_Estado_Institucion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("ID_Estado_Institucion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso</summary>
        public static string Peso
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Peso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatura</summary>
        public static string Estatura
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Padecimiento_de_Enfermedad</summary>
        public static string Padecimiento_de_Enfermedad
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Padecimiento_de_Enfermedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cejas</summary>
        public static string Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo_de_Cabello</summary>
        public static string Largo_de_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Largo_de_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cabello</summary>
        public static string Forma_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Cabello</summary>
        public static string Color_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Color_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ojos</summary>
        public static string Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Ojos</summary>
        public static string Forma_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anteojos</summary>
        public static string Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Nariz</summary>
        public static string Forma_de_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_de_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nariz_Base</summary>
        public static string Nariz_Base
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nariz_Base", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grosor_de_Labios</summary>
        public static string Grosor_de_Labios
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Grosor_de_Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Menton</summary>
        public static string Forma_de_Menton
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_de_Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen_Tatuaje</summary>
        public static string Imagen_Tatuaje
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Imagen_Tatuaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Senas_Particulares</summary>
        public static string Otras_Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Otras_Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imputado_Recluido</summary>
        public static string Imputado_Recluido
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Imputado_Recluido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_Breve_de_los_Hechos</summary>
        public static string Narrativa_Breve_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Narrativa_Breve_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Prioridad_del_Hecho</summary>
        public static string Prioridad_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Prioridad_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_hecho</summary>
        public static string Pais_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Pais_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Hecho</summary>
        public static string Estado_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Hecho</summary>
        public static string Municipio_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Municipio_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_Hechos</summary>
        public static string Poblacion_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Poblacion_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_hecho</summary>
        public static string Colonia_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Colonia_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_hecho</summary>
        public static string Codigo_Postal_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Codigo_Postal_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_hecho</summary>
        public static string Calle_del_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calle_del_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_de_los_Hechos</summary>
        public static string Numero_Exterior_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_Exterior_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_interior_de_los_hecho</summary>
        public static string Numero_interior_de_los_hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_interior_de_los_hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_de_los_hechos</summary>
        public static string Latitud_de_los_hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Latitud_de_los_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_de_los_Hechos</summary>
        public static string Longitud_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Longitud_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_del_lugar_del_he</summary>
        public static string Tipo_del_lugar_del_he
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tipo_del_lugar_del_he", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_del_Tutor</summary>
        public static string Nombre_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_del_Tutor</summary>
        public static string Apellido_Paterno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Paterno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_del_Tutor</summary>
        public static string Apellido_Materno_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Apellido_Materno_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_del_Tutor</summary>
        public static string Nombre_Completo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nombre_Completo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento_del_Tutor</summary>
        public static string Fecha_de_Nacimiento_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Fecha_de_Nacimiento_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_del_Tutor</summary>
        public static string Edad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Edad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo_del_Tutor</summary>
        public static string Sexo_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Sexo_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil_del_Tutor</summary>
        public static string Estado_Civil_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado_Civil_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_del_Tutor</summary>
        public static string Tipo_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Tipo_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion_del_Tutor</summary>
        public static string Numero_de_Identificacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_de_Identificacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP_Tutor</summary>
        public static string CURP_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("CURP_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC_Tutor</summary>
        public static string RFC_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("RFC_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_del_Tutor</summary>
        public static string Nacionalidad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Nacionalidad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad_del_Tutor</summary>
        public static string Escolaridad_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Escolaridad_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion_del_Tutor</summary>
        public static string Ocupacion_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Ocupacion_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Origen_tutor</summary>
        public static string Pais_de_Origen_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Pais_de_Origen_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Originario_de_tutor</summary>
        public static string Originario_de_tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Originario_de_tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_del_Tutor</summary>
        public static string Pais_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Pais_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Tutor</summary>
        public static string Estado_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Estado_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Tutor</summary>
        public static string Municipio_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Municipio_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_Tutor</summary>
        public static string Poblacion_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Poblacion_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Tutor</summary>
        public static string Colonia_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Colonia_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_del_Tutor</summary>
        public static string Codigo_Postal_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Codigo_Postal_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Tutor</summary>
        public static string Calle_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Calle_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Tutor</summary>
        public static string Numero_Exterior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_Exterior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Tutor</summary>
        public static string Numero_Interior_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Numero_Interior_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_Tutor</summary>
        public static string Latitud_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Latitud_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_Tutor</summary>
        public static string Longitud_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Longitud_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono_del_Tutor</summary>
        public static string Telefono_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Telefono_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Extension_del_Tutor</summary>
        public static string Extension_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Extension_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_del_Tutor</summary>
        public static string Celular_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Celular_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico_del_Tutor</summary>
        public static string Correo_Electronico_del_Tutor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Imputado.GetResource("Correo_Electronico_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Imputado.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Representante Legal</summary>	public static string TabRepresentante_Legal 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Imputado.GetResource("TabRepresentante_Legal", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Media Filiación</summary>	public static string TabDatos_de_Media_Filiacion 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Imputado.GetResource("TabDatos_de_Media_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Imputado.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Tutor</summary>	public static string TabDatos_del_Tutor 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Imputado.GetResource("TabDatos_del_Tutor", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
