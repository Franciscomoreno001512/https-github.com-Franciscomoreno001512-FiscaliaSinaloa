using Resources.Abstract;
using Resources.Concrete;
using System;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Resources
{
    public partial class OrientadorResources
    {
        //private static IResourceProvider resourceProviderOrientador = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Uploads\Resources\OrientadorResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        private static IResourceProvider resourceProviderOrientador = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\OrientadorResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        
        public static void SetPath()
        {
            resourceProviderOrientador = new XmlResourceProvider(Path.Combine(ConfigurationManager.AppSettings["BaseDirectoyPhysical"].ToString(), @"Uploads\Resources\OrientadorResource." + CultureInfo.CurrentUICulture.Name + ".xml"));
        }
        /// <summary>Orientador</summary>
        public static string Orientador
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Orientador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clave</summary>
        public static string Clave
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Clave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Registro</summary>
        public static string Fecha_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Fecha_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_de_Registro</summary>
        public static string Hora_de_Registro
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Hora_de_Registro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Usuario_que_Registra</summary>
        public static string Usuario_que_Registra
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Usuario_que_Registra", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Atencion_Medica</summary>
        public static string Atencion_Medica
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Atencion_Medica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Atencion_Psicologica</summary>
        public static string Atencion_Psicologica
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Atencion_Psicologica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Traductor</summary>
        public static string Traductor
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Traductor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_DM</summary>
        public static string Narrativa_DM
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Narrativa_DM", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Narrativa_DP</summary>
        public static string Narrativa_DP
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Narrativa_DP", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Idioma</summary>
        public static string Idioma
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Idioma", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nombre</summary>
        public static string Nombre
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Nombre", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Paterno</summary>
        public static string Apellido_Paterno
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_Paterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_Materno</summary>
        public static string Apellido_Materno
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_Materno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_de_Nacimiento</summary>
        public static string Fecha_de_Nacimiento
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Fecha_de_Nacimiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Edad</summary>
        public static string Edad
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sexo</summary>
        public static string Sexo
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Sexo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Civil</summary>
        public static string Estado_Civil
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado_Civil", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Identificacion</summary>
        public static string Tipo_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Tipo_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Identificacion</summary>
        public static string Numero_de_Identificacion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_de_Identificacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Nacionalidad</summary>
        public static string Nacionalidad
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Nacionalidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Escolaridad</summary>
        public static string Escolaridad
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Escolaridad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ocupacion</summary>
        public static string Ocupacion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Ocupacion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle</summary>
        public static string Calle
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior</summary>
        public static string Numero_Exterior
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Exterior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior</summary>
        public static string Numero_Interior
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Interior", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia</summary>
        public static string Colonia
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Colonia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal</summary>
        public static string Codigo_Postal
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Codigo_Postal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Localidad</summary>
        public static string Localidad
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Localidad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio</summary>
        public static string Municipio
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Municipio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado</summary>
        public static string Estado
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Telefono</summary>
        public static string Telefono
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Telefono", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Celular</summary>
        public static string Celular
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Celular", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Correo_Electronico</summary>
        public static string Correo_Electronico
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Correo_Electronico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_del_Hecho</summary>
        public static string Fecha_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Fecha_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Aproximada_del_Hecho</summary>
        public static string Hora_Aproximada_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Hora_Aproximada_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Lugar_del_Hecho</summary>
        public static string Tipo_de_Lugar_del_Hecho
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Tipo_de_Lugar_del_Hecho", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calle2</summary>
        public static string Calle2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Calle2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior2</summary>
        public static string Numero_Exterior2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Exterior2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior2</summary>
        public static string Numero_Interior2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Interior2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia2</summary>
        public static string Colonia2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Colonia2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_Postal2</summary>
        public static string Codigo_Postal2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Codigo_Postal2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona</summary>
        public static string Zona
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Zona", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio2</summary>
        public static string Municipio2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Municipio2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado2</summary>
        public static string Estado2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Grupo_Delito</summary>
        public static string Grupo_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Grupo_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito</summary>
        public static string Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia</summary>
        public static string Circunstancia
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Circunstancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_Delito</summary>
        public static string Tipo_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Tipo_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Comision_Delito</summary>
        public static string Forma_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Forma_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Forma_Accion_Delito</summary>
        public static string Forma_Accion_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Forma_Accion_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_Delito</summary>
        public static string Modalidad_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Modalidad_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Elementos_Comision_Delito</summary>
        public static string Elementos_Comision_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Elementos_Comision_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto</summary>
        public static string Monto
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Monto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>HViolencia_de_Genero</summary>
        public static string HViolencia_de_Genero
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("HViolencia_de_Genero", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Calificacion_del_Delito</summary>
        public static string Calificacion_del_Delito
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Calificacion_del_Delito", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CircunstanciaV</summary>
        public static string CircunstanciaV
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("CircunstanciaV", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Clase_Especifica</summary>
        public static string Clase_Especifica
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Clase_Especifica", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Marca</summary>
        public static string Marca
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Sub_Marca</summary>
        public static string Sub_Marca
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Sub_Marca", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Vehiculo</summary>
        public static string Tipo_de_Vehiculo
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Tipo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modelo</summary>
        public static string Modelo
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Modelo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Color</summary>
        public static string Color
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Color", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Placas</summary>
        public static string Placas
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Placas</summary>
        public static string Estado_Placas
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado_Placas", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Vehiculo_Robado</summary>
        public static string Vehiculo_Robado
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Vehiculo_Robado", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Seguro</summary>
        public static string Seguro
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Seguro", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Aseguradora</summary>
        public static string Aseguradora
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Aseguradora", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Tipo_de_Servicio</summary>
        public static string Tipo_de_Servicio
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Tipo_de_Servicio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta_del_Servicio_Publico</summary>
        public static string Ruta_del_Servicio_Publico
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Ruta_del_Servicio_Publico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Mercancia</summary>
        public static string Mercancia
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Mercancia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Descripcion</summary>
        public static string Descripcion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Descripcion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Monto_de_la_Carga</summary>
        public static string Monto_de_la_Carga
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Monto_de_la_Carga", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Senas_Particulares</summary>
        public static string Senas_Particulares
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Senas_Particulares", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Modalidad_del_Robo</summary>
        public static string Modalidad_del_Robo
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Modalidad_del_Robo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Circunstancia_Defuncion</summary>
        public static string Circunstancia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Circunstancia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Consecuencia_Defuncion</summary>
        public static string Consecuencia_Defuncion
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Consecuencia_Defuncion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Fecha_Levantamiento</summary>
        public static string Fecha_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Fecha_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Hora_Levantamiento</summary>
        public static string Hora_Levantamiento
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Hora_Levantamiento", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Domicilio</summary>
        public static string Domicilio
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Domicilio", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Interior3</summary>
        public static string Numero_Interior3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Interior3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_Exterior3</summary>
        public static string Numero_Exterior3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_Exterior3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia3</summary>
        public static string Colonia3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Colonia3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Colonia_no_Catalogada</summary>
        public static string Colonia_no_Catalogada
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Colonia_no_Catalogada", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Zona2</summary>
        public static string Zona2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Zona2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Municipio3</summary>
        public static string Municipio3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Municipio3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado3</summary>
        public static string Estado3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Necropsia</summary>
        public static string Necropsia
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Necropsia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Cronotanatodiagnostico</summary>
        public static string Cronotanatodiagnostico
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Cronotanatodiagnostico", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Ruta</summary>
        public static string Ruta
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Ruta", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Estado_Operador</summary>
        public static string Estado_Operador
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Estado_Operador", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Delito_Principal_o_Secundario</summary>
        public static string Delito_Principal_o_Secundario
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Delito_Principal_o_Secundario", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Concurso</summary>
        public static string Concurso
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Concurso", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Compareciente</summary>
        public static string Compareciente
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Compareciente", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NombreC</summary>
        public static string NombreC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("NombreC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_PaternoC</summary>
        public static string Apellido_PaternoC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_PaternoC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_MaternoC</summary>
        public static string Apellido_MaternoC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_MaternoC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NombreT</summary>
        public static string NombreT
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("NombreT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_PaternoT</summary>
        public static string Apellido_PaternoT
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_PaternoT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Apellido_MaternoT</summary>
        public static string Apellido_MaternoT
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Apellido_MaternoT", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>CalleC</summary>
        public static string CalleC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("CalleC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_ExteriorC</summary>
        public static string Numero_ExteriorC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_ExteriorC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_InteriorC</summary>
        public static string Numero_InteriorC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_InteriorC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ColoniaC</summary>
        public static string ColoniaC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("ColoniaC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Codigo_PostalC</summary>
        public static string Codigo_PostalC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Codigo_PostalC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>ZonaC</summary>
        public static string ZonaC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("ZonaC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>MunicipioC</summary>
        public static string MunicipioC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("MunicipioC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>EstadoC</summary>
        public static string EstadoC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("EstadoC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>NarrativaC</summary>
        public static string NarrativaC
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("NarrativaC", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Conocido</summary>
        public static string Conocido
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Conocido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Desconocido</summary>
        public static string Desconocido
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Desconocido", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Numero_de_Imputados</summary>
        public static string Numero_de_Imputados
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Numero_de_Imputados", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Procedencia</summary>
        public static string Procedencia
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Procedencia", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Motor</summary>
        public static string Motor
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Motor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Serie</summary>
        public static string Serie
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Serie", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Causa_de_Muerte</summary>
        public static string Causa_de_Muerte
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Causa_de_Muerte", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle</summary>
        public static string Entre_Calle
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Entre_Calle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Entre_Calle2</summary>
        public static string Entre_Calle2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Entre_Calle2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoriza</summary>
        public static string Autoriza
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Autoriza", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoriza2</summary>
        public static string Autoriza2
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Autoriza2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Autoriza3</summary>
        public static string Autoriza3
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Autoriza3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        /// <summary>Menor_de_Edad</summary>
        public static string Menor_de_Edad
        {
            get
            {
                SetPath();
                return resourceProviderOrientador.GetResource("Menor_de_Edad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


	/// <summary>Datos de Servicios de Apoyo</summary>	public static string TabDatos_de_Servicios_de_Apoyo 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_de_Servicios_de_Apoyo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Imputado</summary>	public static string TabDatos_del_Imputado 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_del_Imputado", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de los Hechos</summary>	public static string TabDatos_de_los_Hechos 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_de_los_Hechos", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos del Delito</summary>	public static string TabDatos_del_Delito 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_del_Delito", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Robo de Vehículo</summary>	public static string TabDatos_de_Robo_de_Vehiculo 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_de_Robo_de_Vehiculo", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Datos de Levantamiento de Cadáver</summary>	public static string TabDatos_de_Levantamiento_de_Cadaver 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabDatos_de_Levantamiento_de_Cadaver", CultureInfo.CurrentUICulture.Name) as String;             		}	}
	/// <summary>Imputado</summary>	public static string TabImputado 	{		get		{			SetPath();  			return resourceProviderOrientador.GetResource("TabImputado", CultureInfo.CurrentUICulture.Name) as String;             		}	}

    }
}
