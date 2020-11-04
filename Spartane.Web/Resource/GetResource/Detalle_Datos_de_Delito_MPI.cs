using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_Datos_de_Delito_MPIResources
    {
        //private static IResourceProvider resourceProviderDetalle_Datos_de_Delito_MPI = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_Datos_de_Delito_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_Datos_de_Delito_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Datos_de_Delito_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_Datos_de_Delito_MPI = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_Datos_de_Delito_MPIResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_Datos_de_Delito_MPI</summary>
        public static string Detalle_Datos_de_Delito_MPI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Detalle_Datos_de_Delito_MPI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Delito</summary>
        public static string Tipo_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Tipo_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_Delito</summary>
        public static string Grupo_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Grupo_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Delito</summary>
        public static string Circunstancia_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Circunstancia_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Principal</summary>
        public static string Delito_Principal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Delito_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Comision_Delito</summary>
        public static string Forma_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Forma_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Accion_Delito</summary>
        public static string Forma_Accion_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Forma_Accion_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_Delito</summary>
        public static string Modalidad_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Modalidad_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Elementos_Comision_Delito</summary>
        public static string Elementos_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Elementos_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto</summary>
        public static string Monto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Monto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Violencia_de_Genero</summary>
        public static string Violencia_de_Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Violencia_de_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de_Vehiculo</summary>
        public static string Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Levantamiento_de_Cadaver</summary>
        public static string Levantamiento_de_Cadaver
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Levantamiento_de_Cadaver", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_de_Vehiculo</summary>
        public static string Circunstancia_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Circunstancia_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clase</summary>
        public static string Clase
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Clase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vehiculo_Robado</summary>
        public static string Vehiculo_Robado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Vehiculo_Robado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Marca</summary>
        public static string Sub_Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Sub_Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Vehiculo</summary>
        public static string Tipo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Tipo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Origen_de_las_Placas</summary>
        public static string Estado_de_Origen_de_las_Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Estado_de_Origen_de_las_Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motor</summary>
        public static string Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_Vehiculo_esta_Asegurado</summary>
        public static string El_Vehiculo_esta_Asegurado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("El_Vehiculo_esta_Asegurado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Aseguradora</summary>
        public static string Nombre_de_la_Aseguradora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Nombre_de_la_Aseguradora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta_del_Servicio_Publico</summary>
        public static string Ruta_del_Servicio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Ruta_del_Servicio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedencia</summary>
        public static string Procedencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Procedencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mercancia</summary>
        public static string Mercancia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Mercancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_lo_que_Transportaba</summary>
        public static string Descripcion_de_lo_que_Transportaba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Descripcion_de_lo_que_Transportaba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_la_Carga</summary>
        public static string Monto_de_la_Carga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Monto_de_la_Carga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_del_Robo</summary>
        public static string Modalidad_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Modalidad_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_de_Muerte</summary>
        public static string Causa_de_Muerte
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Causa_de_Muerte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Defuncion</summary>
        public static string Circunstancia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Circunstancia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecuencia_Defuncion</summary>
        public static string Consecuencia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Consecuencia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Levantamiento</summary>
        public static string Fecha_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Fecha_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Levantamiento</summary>
        public static string Hora_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Hora_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_no_Catalogada</summary>
        public static string Colonia_no_Catalogada
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Colonia_no_Catalogada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Necropsia</summary>
        public static string Necropsia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Necropsia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cronotanatodiagnostico</summary>
        public static string Cronotanatodiagnostico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Cronotanatodiagnostico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta</summary>
        public static string Ruta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Ruta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Conductor</summary>
        public static string Estado_del_Conductor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Estado_del_Conductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Robo de Vehículo</summary>	public static string TabDatos_de_Robo_de_Vehiculo 	{		get		{			SetPath();  			return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("TabDatos_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Levantamiento del Cadáver </summary>	public static string TabDatos_del_Levantamiento_del_Cadaver_ 	{		get		{			SetPath();  			return resourceProviderDetalle_Datos_de_Delito_MPI.GetResource("TabDatos_del_Levantamiento_del_Cadaver_", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
