using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_Delito_de_JusticiaResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Delito_de_Justicia = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_Delito_de_JusticiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Delito_de_Justicia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Delito_de_JusticiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Delito_de_Justicia = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_Delito_de_JusticiaResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Delito_de_Justicia</summary>
        public static string Detalle_de_Delito_de_Justicia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Detalle_de_Delito_de_Justicia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroAT</summary>
        public static string idRegistroAT
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("idRegistroAT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>idRegistroUI</summary>
        public static string idRegistroUI
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("idRegistroUI", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Solicitud</summary>
        public static string Solicitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Solicitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Delito</summary>
        public static string Fecha_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Fecha_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Violencia_de_Genero</summary>
        public static string Violencia_de_Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Violencia_de_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Violencia_Genero</summary>
        public static string Delito_Violencia_Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Delito_Violencia_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Delito</summary>
        public static string Hora_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Hora_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Delito</summary>
        public static string Tipo_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_de_Delito</summary>
        public static string Grupo_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Grupo_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agravantes_y_o_Calificativas</summary>
        public static string Agravantes_y_o_Calificativas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Agravantes_y_o_Calificativas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancias_Delito</summary>
        public static string Circunstancias_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Circunstancias_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Principal</summary>
        public static string Delito_Principal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Delito_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Comision_de_Delito</summary>
        public static string Forma_de_Comision_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Forma_de_Comision_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_de_Accion_de_Delito</summary>
        public static string Forma_de_Accion_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Forma_de_Accion_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_de_Delito</summary>
        public static string Modalidad_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Modalidad_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Elementos_de_Comision_de_Delito</summary>
        public static string Elementos_de_Comision_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Elementos_de_Comision_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clasificacion_con_Orden_de_Resultado</summary>
        public static string Clasificacion_con_Orden_de_Resultado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Clasificacion_con_Orden_de_Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Concurso</summary>
        public static string Concurso
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Concurso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_Reparacion_de_Danos</summary>
        public static string Monto_de_Reparacion_de_Danos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Monto_de_Reparacion_de_Danos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Delito</summary>
        public static string Estado_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Estado_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Delito</summary>
        public static string Municipio_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Municipio_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Delito</summary>
        public static string Colonia_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Colonia_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_del_Delito</summary>
        public static string Calle_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Calle_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_del_Delito</summary>
        public static string Entre_Calle_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Entre_Calle_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_del_Delito</summary>
        public static string Y_Calle_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Y_Calle_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Delito</summary>
        public static string Numero_Exterior_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_Exterior_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Delito</summary>
        public static string Numero_Interior_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_Interior_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de_Vehiculo</summary>
        public static string Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Robo</summary>
        public static string Fecha_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Fecha_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Robo</summary>
        public static string Hora_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Hora_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de</summary>
        public static string Robo_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Robo_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_Federal_Vehicular</summary>
        public static string Registro_Federal_Vehicular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Registro_Federal_Vehicular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Registro_Publico_Vehicular</summary>
        public static string Numero_de_Registro_Publico_Vehicular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_de_Registro_Publico_Vehicular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_de_Robo_de_Vehiculo</summary>
        public static string Circunstancia_de_Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Circunstancia_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Marca</summary>
        public static string Sub_Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Sub_Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_vehiculo</summary>
        public static string Tipo_de_vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Origen_de_las_Placas</summary>
        public static string Estado_de_Origen_de_las_Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Estado_de_Origen_de_las_Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motor</summary>
        public static string Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_De_Robo</summary>
        public static string Estado_De_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Estado_De_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_de_Robo</summary>
        public static string Municipio_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Municipio_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_de_Robo</summary>
        public static string Colonia_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Colonia_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_de_Robo</summary>
        public static string Codigo_Postal_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Codigo_Postal_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_de_Robo</summary>
        public static string Calle_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Calle_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_de_Robo</summary>
        public static string Entre_Calle_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Entre_Calle_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Y_Calle_de_Robo</summary>
        public static string Y_Calle_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Y_Calle_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_de_Robo</summary>
        public static string Numero_Exterior_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_Exterior_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_de_Robo</summary>
        public static string Numero_Interior_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_Interior_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_de_Robo</summary>
        public static string Referencia_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Referencia_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_de_Robo</summary>
        public static string Latitud_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Latitud_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_de_Robo</summary>
        public static string Longitud_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Longitud_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_de_Robo</summary>
        public static string Lugar_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Lugar_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_vehiculo_esta_asegurado</summary>
        public static string El_vehiculo_esta_asegurado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("El_vehiculo_esta_asegurado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Aseguradora</summary>
        public static string Nombre_de_la_Aseguradora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Nombre_de_la_Aseguradora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta_del_Servicio_Publico</summary>
        public static string Ruta_del_Servicio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Ruta_del_Servicio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_Vehiculo_Transportaba_Mercancia</summary>
        public static string El_Vehiculo_Transportaba_Mercancia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("El_Vehiculo_Transportaba_Mercancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_lo_que_Transportaba</summary>
        public static string Descripcion_de_lo_que_Transportaba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Descripcion_de_lo_que_Transportaba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_carga</summary>
        public static string Monto_de_carga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Monto_de_carga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_particulares</summary>
        public static string Senas_particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Senas_particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuenta_con_GPS</summary>
        public static string Cuenta_con_GPS
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Cuenta_con_GPS", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Robo</summary>
        public static string Tipo_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Robo</summary>
        public static string Tipo_de_Lugar_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Lugar_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Carretera</summary>
        public static string Tipo_de_Carretera
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Carretera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Serie</summary>
        public static string Numero_de_Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_de_Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Motor</summary>
        public static string Numero_de_Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Numero_de_Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral</summary>
        public static string Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Persona_Moral</summary>
        public static string Nombre_Completo_Persona_Moral
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Nombre_Completo_Persona_Moral", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Fisica</summary>
        public static string Persona_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Persona_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Persona_Fisica</summary>
        public static string Nombre_Completo_Persona_Fisica
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Nombre_Completo_Persona_Fisica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Denunciante</summary>
        public static string Denunciante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Denunciante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Denunciante</summary>
        public static string Nombre_Completo_Denunciante
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("Nombre_Completo_Denunciante", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Robo de Vehículo</summary>	public static string TabDatos_de_Robo_de_Vehiculo 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("TabDatos_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignar Dueño</summary>	public static string TabAsignar_Dueno 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito_de_Justicia.GetResource("TabAsignar_Dueno", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
