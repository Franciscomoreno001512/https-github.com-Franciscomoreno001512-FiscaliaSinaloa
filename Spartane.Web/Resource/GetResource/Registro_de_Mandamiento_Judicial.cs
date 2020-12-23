using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Registro_de_Mandamiento_JudicialResources
    {
        //private static IResourceProvider resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderRegistro_de_Mandamiento_Judicial = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Registro_de_Mandamiento_JudicialResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Registro_de_Mandamiento_Judicial</summary>
        public static string Registro_de_Mandamiento_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Registro_de_Mandamiento_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Folio_de_la_Orden_de_Aprehension</summary>
        public static string Folio_de_la_Orden_de_Aprehension
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Folio_de_la_Orden_de_Aprehension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_al_que_Pertenece_la_Informacion</summary>
        public static string Pais_al_que_Pertenece_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Pais_al_que_Pertenece_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_que_Envia_la_Informacion</summary>
        public static string Estado_que_Envia_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estado_que_Envia_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_que_Envia_la_Informacion</summary>
        public static string Municipio_que_Envia_la_Informacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Municipio_que_Envia_la_Informacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Institucion_que_Remite</summary>
        public static string Institucion_que_Remite
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Institucion_que_Remite", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entidad_que_Emite_Mandamiento</summary>
        public static string Entidad_que_Emite_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Entidad_que_Emite_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juzgado_que_Emitio_Mandamiento</summary>
        public static string Juzgado_que_Emitio_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Juzgado_que_Emitio_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Mandamiento</summary>
        public static string Numero_de_Mandamiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Mandamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_de_Juzgado</summary>
        public static string Oficio_de_Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_de_Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatura</summary>
        public static string Estatura
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso</summary>
        public static string Peso
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Peso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usa_Anteojos</summary>
        public static string Usa_Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Usa_Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais_de_Nacimiento</summary>
        public static string Pais_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Pais_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Nacimiento</summary>
        public static string Estado_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Estado_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio</summary>
        public static string Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefonos</summary>
        public static string Telefonos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Telefonos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otro_Nombre_del_Individuo</summary>
        public static string Otro_Nombre_del_Individuo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Otro_Nombre_del_Individuo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Orden</summary>
        public static string Tipo_de_Orden
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_de_Orden", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Orden</summary>
        public static string Fecha_de_Orden
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Orden", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Orden</summary>
        public static string Hora_de_Orden
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Hora_de_Orden", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Dirigida_Por</summary>
        public static string Dirigida_Por
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Dirigida_Por", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ambito</summary>
        public static string Ambito
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Ambito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juzgado</summary>
        public static string Juzgado
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Juzgado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Juez</summary>
        public static string Juez
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Juez", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Especialidad</summary>
        public static string Especialidad
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Especialidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Causa</summary>
        public static string Numero_de_Causa
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Causa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Oficio</summary>
        public static string Fecha_de_Oficio
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Oficio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cuantia</summary>
        public static string Tipo_de_Cuantia
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_de_Cuantia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observaciones</summary>
        public static string Observaciones
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Observaciones", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delitos</summary>
        public static string Delitos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Delitos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Amparo</summary>
        public static string Amparo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Amparo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cejas</summary>
        public static string Cejas
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cabello</summary>
        public static string Forma_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Forma_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Cabello</summary>
        public static string Color_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Color_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ojos</summary>
        public static string Ojos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Ojos</summary>
        public static string Forma_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Forma_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nariz_Base</summary>
        public static string Nariz_Base
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Nariz_Base", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Libramiento</summary>
        public static string Fecha_de_Libramiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Libramiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fuerzo</summary>
        public static string Fuerzo
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fuerzo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Mandato</summary>
        public static string Tipo_Mandato
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_Mandato", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Proceso_Judicial</summary>
        public static string Numero_de_Proceso_Judicial
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Proceso_Judicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Averiguacion</summary>
        public static string Numero_de_Averiguacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Numero_de_Averiguacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Captura</summary>
        public static string Fecha_de_Captura
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Captura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Recepcion</summary>
        public static string Fecha_de_Recepcion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Recepcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Prescripcion</summary>
        public static string Fecha_de_Prescripcion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Prescripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cumplimiento</summary>
        public static string Fecha_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_de_Cumplimiento</summary>
        public static string Oficio_de_Cumplimiento
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_de_Cumplimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Cancelacion</summary>
        public static string Fecha_de_Cancelacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fecha_de_Cancelacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_Cancelacion</summary>
        public static string Motivo_de_Cancelacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Motivo_de_Cancelacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Oficio_de_Cancelacion</summary>
        public static string Oficio_de_Cancelacion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Oficio_de_Cancelacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Proceso</summary>
        public static string Tipo_de_Proceso
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Tipo_de_Proceso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Proceso_de_Extradiccion</summary>
        public static string Proceso_de_Extradiccion
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Proceso_de_Extradiccion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Observacionesx</summary>
        public static string Observacionesx
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Observacionesx", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotos</summary>
        public static string Fotos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Fotos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Documentos</summary>
        public static string Documentos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Documentos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Huellas_Digitales</summary>
        public static string Huellas_Digitales
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Huellas_Digitales", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mano_Izquierda_dedos</summary>
        public static string Mano_Izquierda_dedos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Mano_Izquierda_dedos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mano_Derecha_Pulgar</summary>
        public static string Mano_Derecha_Pulgar
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Mano_Derecha_Pulgar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mano_Derecha_Dedos</summary>
        public static string Mano_Derecha_Dedos
        {
            get
            {
                SetPath();
                return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("Mano_Derecha_Dedos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Domicilio</summary>	public static string TabDomicilio 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDomicilio", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Teléfonos</summary>	public static string TabTelefonos 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabTelefonos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Otros Nombres</summary>	public static string TabOtros_Nombres 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabOtros_Nombres", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de la Orden</summary>	public static string TabDatos_de_la_Orden 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDatos_de_la_Orden", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Delito</summary>	public static string TabDelito 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDelito", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Amparo</summary>	public static string TabAmparo 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabAmparo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Media Filiación</summary>	public static string TabMedia_Filiacion 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabMedia_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Proceso</summary>	public static string TabProceso 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabProceso", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Fotos</summary>	public static string TabFotos 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabFotos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Documentos</summary>	public static string TabDocumentos 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabDocumentos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Huellas Digitales</summary>	public static string TabHuellas_Digitales 	{		get		{			SetPath();  			return resourceProviderRegistro_de_Mandamiento_Judicial.GetResource("TabHuellas_Digitales", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
