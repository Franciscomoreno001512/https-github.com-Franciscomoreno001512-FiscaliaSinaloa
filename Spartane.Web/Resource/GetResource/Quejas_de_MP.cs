using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Quejas_de_MPResources
    {
        //private static IResourceProvider resourceProviderQuejas_de_MP = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Quejas_de_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderQuejas_de_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Quejas_de_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderQuejas_de_MP = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Quejas_de_MPResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Quejas_de_MP</summary>
        public static string Quejas_de_MP
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Quejas_de_MP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres</summary>
        public static string Nombres
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Nombres", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatus</summary>
        public static string Estatus
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Estatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Peso</summary>
        public static string Peso
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Peso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estatura</summary>
        public static string Estatura
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Estatura", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Padecimiento_de_Enfermedad</summary>
        public static string Padecimiento_de_Enfermedad
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Padecimiento_de_Enfermedad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cara</summary>
        public static string Forma_Cara
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_Cara", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Cejas</summary>
        public static string Tipo_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tipo_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Cejas</summary>
        public static string Tamano_de_Cejas
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tamano_de_Cejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Largo_de_Cabello</summary>
        public static string Largo_de_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Largo_de_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cantidad_Cabello</summary>
        public static string Cantidad_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Cantidad_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Implantacion_Cabello</summary>
        public static string Implantacion_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Implantacion_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Complexion</summary>
        public static string Complexion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Complexion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Piel</summary>
        public static string Color_Piel
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Color_Piel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Frente</summary>
        public static string Frente
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Frente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Cabello</summary>
        public static string Forma_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Cabello</summary>
        public static string Color_Cabello
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Color_Cabello", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calvicie</summary>
        public static string Calvicie
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Calvicie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color_Ojos</summary>
        public static string Color_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Color_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_de_Ojos</summary>
        public static string Tamano_de_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tamano_de_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Ojos</summary>
        public static string Forma_Ojos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_Ojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Anteojos</summary>
        public static string Anteojos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Anteojos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Nariz</summary>
        public static string Forma_de_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_de_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Nariz</summary>
        public static string Tamano_Nariz
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tamano_Nariz", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Labios</summary>
        public static string Labios
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Boca</summary>
        public static string Boca
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Boca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grosor_de_Labios</summary>
        public static string Grosor_de_Labios
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Grosor_de_Labios", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menton</summary>
        public static string Menton
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Menton</summary>
        public static string Forma_de_Menton
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_de_Menton", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Barba</summary>
        public static string Barba
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Barba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Orejas</summary>
        public static string Forma_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Forma_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tamano_Orejas</summary>
        public static string Tamano_Orejas
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tamano_Orejas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Lobulo</summary>
        public static string Tipo_Lobulo
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tipo_Lobulo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Bigote</summary>
        public static string Bigote
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Bigote", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Imagen_Tatuaje</summary>
        public static string Imagen_Tatuaje
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Imagen_Tatuaje", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Situacion_Fisica</summary>
        public static string Situacion_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Situacion_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Otras_Senas_Particulares</summary>
        public static string Otras_Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Otras_Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_los_Hechos</summary>
        public static string Descripcion_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Descripcion_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_los_Hechos</summary>
        public static string Fecha_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Fecha_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_los_Hechos</summary>
        public static string Hora_de_los_Hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Hora_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_hechos</summary>
        public static string Municipio_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Municipio_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion_hechos</summary>
        public static string Poblacion_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Poblacion_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_hechos</summary>
        public static string Colonia_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Colonia_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_hechos</summary>
        public static string Calle_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Calle_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_hechos</summary>
        public static string Entre_Calle_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Entre_Calle_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_hechos</summary>
        public static string Y_Calle_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Y_Calle_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_hechos</summary>
        public static string Numero_Exterior_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Numero_Exterior_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_hechos</summary>
        public static string Numero_Interior_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Numero_Interior_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_hechos</summary>
        public static string Codigo_Postal_hechos
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Codigo_Postal_hechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CURP_Identificacion</summary>
        public static string CURP_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("CURP_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombres_Identificacion</summary>
        public static string Nombres_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Nombres_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno_Identificacion</summary>
        public static string Apellido_Paterno_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Apellido_Paterno_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno_Identificacion</summary>
        public static string Apellido_Materno_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Apellido_Materno_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Alias</summary>
        public static string Alias
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Alias", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Nacimiento_Identificacion</summary>
        public static string Fecha_Nacimiento_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Fecha_Nacimiento_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad_Identificacion</summary>
        public static string Edad_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Edad_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Genero_Identificacion</summary>
        public static string Genero_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Genero_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular_Identificacion</summary>
        public static string Celular_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Celular_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Identificacion</summary>
        public static string Correo_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Correo_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion_Identificacion</summary>
        public static string Tipo_de_Identificacion_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Tipo_de_Identificacion_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Identificacion_Identificacion</summary>
        public static string Numero_Identificacion_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Numero_Identificacion_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad_Identificacion</summary>
        public static string Nacionalidad_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Nacionalidad_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entidad_de_Nacimiento_Identificacion</summary>
        public static string Entidad_de_Nacimiento_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Entidad_de_Nacimiento_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Poblacion</summary>
        public static string Poblacion
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Poblacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle</summary>
        public static string Y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencias_de_domicilio</summary>
        public static string Referencias_de_domicilio
        {
            get
            {
                SetPath();
                return resourceProviderQuejas_de_MP.GetResource("Referencias_de_domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderQuejas_de_MP.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Rasgos Físicos</summary>	public static string TabRasgos_Fisicos 	{		get		{			SetPath();  			return resourceProviderQuejas_de_MP.GetResource("TabRasgos_Fisicos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Hechos Sucedidos</summary>	public static string TabHechos_Sucedidos 	{		get		{			SetPath();  			return resourceProviderQuejas_de_MP.GetResource("TabHechos_Sucedidos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Identificación del Servidor Público</summary>	public static string TabIdentificacion_del_Servidor_Publico 	{		get		{			SetPath();  			return resourceProviderQuejas_de_MP.GetResource("TabIdentificacion_del_Servidor_Publico", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Domicilio del Servidor Público</summary>	public static string TabDomicilio_del_Servidor_Publico 	{		get		{			SetPath();  			return resourceProviderQuejas_de_MP.GetResource("TabDomicilio_del_Servidor_Publico", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
