using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class Detalle_de_DelitoResources
    {
        //private static IResourceProvider resourceProviderDetalle_de_Delito = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\Detalle_de_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderDetalle_de_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderDetalle_de_Delito = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\Detalle_de_DelitoResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Detalle_de_Delito</summary>
        public static string Detalle_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Detalle_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_corta</summary>
        public static string Descripcion_corta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Descripcion_corta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de_Vehiculo</summary>
        public static string Robo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Expediente_Inicial</summary>
        public static string Expediente_Inicial
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Expediente_Inicial", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Denuncia</summary>
        public static string Tipo_de_Denuncia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Denuncia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Delito</summary>
        public static string Fecha_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Fecha_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Delito</summary>
        public static string Hora_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Hora_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Violencia_de_Genero</summary>
        public static string Violencia_de_Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Violencia_de_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Violencia_Genero</summary>
        public static string Delito_Violencia_Genero
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Delito_Violencia_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Delito</summary>
        public static string Tipo_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_Delito</summary>
        public static string Grupo_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Grupo_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Agravantes_y_o_Calificactivas</summary>
        public static string Agravantes_y_o_Calificactivas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Agravantes_y_o_Calificactivas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancias_Delito</summary>
        public static string Circunstancias_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Circunstancias_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Delito</summary>
        public static string Circunstancia_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Circunstancia_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Articulado_de_Delito</summary>
        public static string Articulado_de_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Articulado_de_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Principal</summary>
        public static string Delito_Principal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Delito_Principal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Comision_Delito</summary>
        public static string Forma_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Forma_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Accion_Delito</summary>
        public static string Forma_Accion_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Forma_Accion_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_Delito</summary>
        public static string Modalidad_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Modalidad_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Elementos_Comision_Delito</summary>
        public static string Elementos_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Elementos_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clasificacion_con_Orden_de_Resultado</summary>
        public static string Clasificacion_con_Orden_de_Resultado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Clasificacion_con_Orden_de_Resultado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Concurso</summary>
        public static string Concurso
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Concurso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto</summary>
        public static string Monto
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Monto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Delito</summary>
        public static string Estado_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Estado_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Delito</summary>
        public static string Municipio_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Municipio_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Delito</summary>
        public static string Colonia_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Colonia_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>y_Calle</summary>
        public static string y_Calle
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("y_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Delito</summary>
        public static string Numero_Exterior_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Exterior_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Delito</summary>
        public static string Numero_Interior_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Interior_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia</summary>
        public static string Referencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Referencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud</summary>
        public static string Latitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Latitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud</summary>
        public static string Longitud
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Longitud", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Puede_Ser_Canalizado_a_JA</summary>
        public static string Puede_Ser_Canalizado_a_JA
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Puede_Ser_Canalizado_a_JA", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motivo_de_no_canalizacion</summary>
        public static string Motivo_de_no_canalizacion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Motivo_de_no_canalizacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Informaron_sus_Derechos</summary>
        public static string Se_Informaron_sus_Derechos
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Se_Informaron_sus_Derechos", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Se_Informo_el_Procedimiento</summary>
        public static string Se_Informo_el_Procedimiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Se_Informo_el_Procedimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Levantamiento_de_Cadaver</summary>
        public static string Levantamiento_de_Cadaver
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Levantamiento_de_Cadaver", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Robo</summary>
        public static string Fecha_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Fecha_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_del_Robo</summary>
        public static string Hora_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Hora_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Robo_de</summary>
        public static string Robo_de
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Robo_de", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Registro_Federal_Vehicular</summary>
        public static string Registro_Federal_Vehicular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Registro_Federal_Vehicular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Registro_Publico_Vehicular</summary>
        public static string Numero_de_Registro_Publico_Vehicular
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_de_Registro_Publico_Vehicular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_de_Vehiculo</summary>
        public static string Circunstancia_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Circunstancia_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clase</summary>
        public static string Clase
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Clase", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vehiculo_Robado</summary>
        public static string Vehiculo_Robado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Vehiculo_Robado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Marca</summary>
        public static string Sub_Marca
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Sub_Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Vehiculo</summary>
        public static string Tipo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_de_Origen_de_las_Placas</summary>
        public static string Estado_de_Origen_de_las_Placas
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Estado_de_Origen_de_las_Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Motor</summary>
        public static string Numero_de_Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_de_Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Serie</summary>
        public static string Numero_de_Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_de_Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Robo</summary>
        public static string Estado_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Estado_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio_del_Robo</summary>
        public static string Municipio_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Municipio_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_del_Robo</summary>
        public static string Colonia_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Colonia_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal_Robo</summary>
        public static string Codigo_Postal_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Codigo_Postal_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle_Robo</summary>
        public static string Calle_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Calle_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle_Robo</summary>
        public static string Entre_Calle_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Entre_Calle_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>y_Calle_Robo</summary>
        public static string y_Calle_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("y_Calle_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior_del_Delito_Robo</summary>
        public static string Numero_Exterior_del_Delito_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Exterior_del_Delito_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior_del_Delito_Robo</summary>
        public static string Numero_Interior_del_Delito_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Interior_del_Delito_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Referencia_Robo</summary>
        public static string Referencia_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Referencia_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Latitud_Robo</summary>
        public static string Latitud_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Latitud_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Longitud_Robo</summary>
        public static string Longitud_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Longitud_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Lugar_del_Robo</summary>
        public static string Lugar_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Lugar_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>El_Vehiculo_esta_Asegurado</summary>
        public static string El_Vehiculo_esta_Asegurado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("El_Vehiculo_esta_Asegurado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_de_la_Aseguradora</summary>
        public static string Nombre_de_la_Aseguradora
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Nombre_de_la_Aseguradora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motor</summary>
        public static string Motor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta_del_Servicio_Publico</summary>
        public static string Ruta_del_Servicio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Ruta_del_Servicio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedencia</summary>
        public static string Procedencia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Procedencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mercancia</summary>
        public static string Mercancia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Mercancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion_de_lo_que_Transportaba</summary>
        public static string Descripcion_de_lo_que_Transportaba
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Descripcion_de_lo_que_Transportaba", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_la_Carga</summary>
        public static string Monto_de_la_Carga
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Monto_de_la_Carga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cuenta_con_GPS</summary>
        public static string Cuenta_con_GPS
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Cuenta_con_GPS", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Robo</summary>
        public static string Tipo_de_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Robo</summary>
        public static string Tipo_de_Lugar_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Lugar_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Carretera</summary>
        public static string Tipo_de_Carretera
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Carretera", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_del_Robo</summary>
        public static string Modalidad_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Modalidad_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_de_Muerte</summary>
        public static string Causa_de_Muerte
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Causa_de_Muerte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Defuncion</summary>
        public static string Circunstancia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Circunstancia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecuencia_Defuncion</summary>
        public static string Consecuencia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Consecuencia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Levantamiento</summary>
        public static string Fecha_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Fecha_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Levantamiento</summary>
        public static string Hora_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Hora_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Pais</summary>
        public static string Pais
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Pais", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_no_Catalogada</summary>
        public static string Colonia_no_Catalogada
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Colonia_no_Catalogada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Necropsia</summary>
        public static string Necropsia
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Necropsia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cronotanatodiagnostico</summary>
        public static string Cronotanatodiagnostico
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Cronotanatodiagnostico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta</summary>
        public static string Ruta
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Ruta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_del_Conductor</summary>
        public static string Estado_del_Conductor
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Estado_del_Conductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Moral_Dueno</summary>
        public static string Persona_Moral_Dueno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Persona_Moral_Dueno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo</summary>
        public static string Nombre_Completo
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Nombre_Completo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Persona_Fisica_Dueno</summary>
        public static string Persona_Fisica_Dueno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Persona_Fisica_Dueno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Involucrado</summary>
        public static string Nombre_Completo_Involucrado
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Nombre_Completo_Involucrado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Denunciante_dueno</summary>
        public static string Denunciante_dueno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Denunciante_dueno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre_Completo_Dueno</summary>
        public static string Nombre_Completo_Dueno
        {
            get
            {
                SetPath();
                return resourceProviderDetalle_de_Delito.GetResource("Nombre_Completo_Dueno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos Generales</summary>	public static string TabDatos_Generales 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito.GetResource("TabDatos_Generales", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Robo de Vehículo</summary>	public static string TabDatos_de_Robo_de_Vehiculo 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito.GetResource("TabDatos_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Levantamiento del Cadáver</summary>	public static string TabDatos_del_Levantamiento_del_Cadaver 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito.GetResource("TabDatos_del_Levantamiento_del_Cadaver", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Asignar Dueño</summary>	public static string TabAsignar_Dueno 	{		get		{			SetPath();  			return resourceProviderDetalle_de_Delito.GetResource("TabAsignar_Dueno", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
