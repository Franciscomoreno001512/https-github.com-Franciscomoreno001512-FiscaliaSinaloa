using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Probable_Responsable_PCResources
    {
        //private static IResourceProvider resourceProviderProbable_Responsable_PC = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Probable_Responsable_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderProbable_Responsable_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Probable_Responsable_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderProbable_Responsable_PC = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Probable_Responsable_PCResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Probable_Responsable_PC</summary>
        public static string Probable_Responsable_PC
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Probable_Responsable_PC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiene_informacion_responsable</summary>
        public static string Tiene_informacion_responsable
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tiene_informacion_responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Quien_Resulte_Responsable</summary>
        public static string Quien_Resulte_Responsable
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Quien_Resulte_Responsable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_moral</summary>
        public static string Persona_moral
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Persona_moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Conoce_los_datos_del_representante_legal</summary>
        public static string Conoce_los_datos_del_representante_legal
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Conoce_los_datos_del_representante_legal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Razon_Social</summary>
        public static string Razon_Social
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Razon_Social", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres</summary>
        public static string Nombres
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fotografia_de_la_identificacion</summary>
        public static string Fotografia_de_la_identificacion
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Fotografia_de_la_identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP</summary>
        public static string CURP
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("CURP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>RFC</summary>
        public static string RFC
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("RFC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tiene_informacion__domicilio</summary>
        public static string Tiene_informacion__domicilio
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tiene_informacion__domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Imputado</summary>
        public static string Calle_del_Imputado
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Calle_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Domicilio</summary>
        public static string Referencia_de_Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Referencia_de_Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso</summary>
        public static string Peso
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Peso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatura</summary>
        public static string Estatura
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Estatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Padecimiento_de_Enfermedad</summary>
        public static string Padecimiento_de_Enfermedad
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Padecimiento_de_Enfermedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cejas</summary>
        public static string Tipo_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tipo_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo_de_Cabello</summary>
        public static string Largo_de_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Largo_de_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cabello</summary>
        public static string Forma_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Cabello</summary>
        public static string Color_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Color_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Ojos</summary>
        public static string Tamano_de_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tamano_de_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Ojos</summary>
        public static string Forma_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anteojos</summary>
        public static string Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Nariz</summary>
        public static string Forma_de_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_de_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Nariz</summary>
        public static string Tamano_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tamano_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grosor_de_Labios</summary>
        public static string Grosor_de_Labios
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Grosor_de_Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Menton</summary>
        public static string Forma_de_Menton
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_de_Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen_Tatuaje</summary>
        public static string Imagen_Tatuaje
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Imagen_Tatuaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Senas_Particulares</summary>
        public static string Otras_Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Otras_Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imputado_Recluido</summary>
        public static string Imputado_Recluido
        {
            get
            {
                SetPath();
                return resourceProviderProbable_Responsable_PC.GetResource("Imputado_Recluido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderProbable_Responsable_PC.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Domicilio</summary>	public static string TabDomicilio 	{		get		{			SetPath();  			return resourceProviderProbable_Responsable_PC.GetResource("TabDomicilio", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Media Filiación</summary>	public static string TabDatos_de_Media_Filiacion 	{		get		{			SetPath();  			return resourceProviderProbable_Responsable_PC.GetResource("TabDatos_de_Media_Filiacion", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
