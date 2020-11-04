using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Cadena_de_CustodiaMainModel
    {
        public Cadena_de_CustodiaModel Cadena_de_CustodiaInfo { set; get; }
        public Detalle_del_Certificado_CCGridModelPost Detalle_del_Certificado_CCGridInfo { set; get; }
        public Detalle_de_Fotos_CCGridModelPost Detalle_de_Fotos_CCGridInfo { set; get; }
        public Detalle_de_Videos_CCGridModelPost Detalle_de_Videos_CCGridInfo { set; get; }
        public Detalle_de_Registro_de_Intervinientes_CCGridModelPost Detalle_de_Registro_de_Intervinientes_CCGridInfo { set; get; }
        public Detalle_de_Descripcion_de_Evidencia_CCGridModelPost Detalle_de_Descripcion_de_Evidencia_CCGridInfo { set; get; }
        public Detalle_de_Lista_de_Documentos_CCGridModelPost Detalle_de_Lista_de_Documentos_CCGridInfo { set; get; }
        public Detalle_de_RetroalimentacionGridModelPost Detalle_de_RetroalimentacionGridInfo { set; get; }
        public Detalle_de_ReferenciaGridModelPost Detalle_de_ReferenciaGridInfo { set; get; }
        public Detalle_de_Fotos_de_Emergencia_CCGridModelPost Detalle_de_Fotos_de_Emergencia_CCGridInfo { set; get; }
        public Detalle_de_Historial_de_Emergencia_CCGridModelPost Detalle_de_Historial_de_Emergencia_CCGridInfo { set; get; }
        public Detalle_de_Datos_del_Imputado_CCGridModelPost Detalle_de_Datos_del_Imputado_CCGridInfo { set; get; }
        public Detalle_de_Datos_del_Testigo_CCGridModelPost Detalle_de_Datos_del_Testigo_CCGridInfo { set; get; }
        public Catalogo_Tipo_de_Embalaje_CCGridModelPost Catalogo_Tipo_de_Embalaje_CCGridInfo { set; get; }
        public Detalle_de_Lista_de_AsignacionesGridModelPost Detalle_de_Lista_de_AsignacionesGridInfo { set; get; }
        public Catalogo_Tipo_de_Fijacion_CCGridModelPost Catalogo_Tipo_de_Fijacion_CCGridInfo { set; get; }
        public Detalle_de_Traslado_de_CCGridModelPost Detalle_de_Traslado_de_CCGridInfo { set; get; }
        public Catalogo_Tipo_de_Indicio_CCGridModelPost Catalogo_Tipo_de_Indicio_CCGridInfo { set; get; }

    }

    public class Detalle_del_Certificado_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Certificado { get; set; }
        public short? Archivo { get; set; }
        public string Fecha { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Fotos_CCGridModelPost
    {
        public int Clave { get; set; }
        public short? Fotos { get; set; }
        public string Pie_de_Foto { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Videos_CCGridModelPost
    {
        public int Clave { get; set; }
        public short? Video { get; set; }
        public string Pie_de_Video { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Registro_de_Intervinientes_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Alias { get; set; }
        public bool? Anonimo { get; set; }
        public string Fecha_de_Nacimiento { get; set; }
        public short? Edad { get; set; }
        public int? Sexo { get; set; }
        public int? Estado_Civil { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public short? Escolaridad { get; set; }
        public int? Ocupacion { get; set; }
        public int? Nacionalidad { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public int? Colonia { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }
        public int? Pais { get; set; }

        public string Entre_calle { get; set; }
        public string Especifique { get; set; }
        public short? Extension { get; set; }
        public bool? Inimputable { get; set; }
        public string Nombre_Completo { get; set; }
        public string Originario_de { get; set; }
        public int? Pais_de_Origen { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public string Referencia_de_Domicilio { get; set; }
        public string Y_calle { get; set; }
        public int? Tipo_de_Compareciente { get; set; }
        public int? Tipo_de_inimputabilidad { get; set; }
        public string Nombre { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Descripcion_de_Evidencia_CCGridModelPost
    {
        public int Clave { get; set; }
        public int? Numero_de_Evidencia { get; set; }
        public string Descripcion_de_la_Evidencia { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public int? Examen_Solicitado { get; set; }
        public string Codigo_de_Barras { get; set; }
        public string Archivo_de_Foto { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Lista_de_Documentos_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Nombre_del_Archivo { get; set; }
        public short? Archivo { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_RetroalimentacionGridModelPost
    {
        public int Clave { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public string Retroalimentacion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_ReferenciaGridModelPost
    {
        public int Clave { get; set; }
        public string Punto_de_Referencia { get; set; }
        public string Descripcion { get; set; }
        public string Distancia { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Fotos_de_Emergencia_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Historial_de_Emergencia_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Estatus { get; set; }
        public string Comentarios { get; set; }
        public string Usuario_que_registra { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Datos_del_Imputado_CCGridModelPost
    {
        public int Clave { get; set; }
        public bool? A_Quien_Resulte_Responsable { get; set; }
        public string Alias { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Calle { get; set; }
        public string Celular { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Colonia { get; set; }
        public string Correo_Electronico { get; set; }
        public short? Edad { get; set; }
        public string Entre_calle { get; set; }
        public short? Escolaridad { get; set; }
        public int? Estado { get; set; }
        public int? Estado_Civil { get; set; }
        public string Estension { get; set; }
        public string Fecha_de_Nacimiento { get; set; }

        public bool? Inimputable { get; set; }
        public int? Tipo_de_Inimputabilidad { get; set; }
        public string Especifique { get; set; }
        public int? Municipio { get; set; }
        public int? Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Completo { get; set; }
        public string Numero_de_Identificacion { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Ocupacion { get; set; }
        public string Originario_de { get; set; }
        public int? Pais { get; set; }
        public int? Pais_de_Origen { get; set; }
        public bool? Proteccion_de_datos { get; set; }
        public string Referencia_de_domicilio { get; set; }
        public int? Genero { get; set; }
        public string Telefono { get; set; }
        public int? Tipo_de_Identificacion { get; set; }
        public string Y_calle { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Datos_del_Testigo_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Calle { get; set; }
        public string Celular { get; set; }
        public int? Codigo_Postal { get; set; }
        public int? Colonia { get; set; }
        public string Correo_Electronico { get; set; }
        public short? Edad { get; set; }
        public short? Escolaridad { get; set; }
        public int? Estado { get; set; }
        public int? Estado_Civil { get; set; }
        public short? Extension { get; set; }
        public string Fecha_de_nacimiento { get; set; }
        public bool? Inimputable { get; set; }
        public int? Municipio { get; set; }
        public int? Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Completo { get; set; }
        public string Numero_de_identificacion { get; set; }
        public string Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public int? Ocupacion { get; set; }
        public int? Pais { get; set; }
        public bool? Proteccion_de_Datos { get; set; }
        public int? Genero { get; set; }
        public string Telefono { get; set; }
        public int? Tipo_de_compareciente { get; set; }
        public int? Tipo_de_identificacion { get; set; }
        public int? Tipo_de_inimputabilidad { get; set; }
        public string Entre_Calle { get; set; }
        public string Y_Calle { get; set; }
        public string Referencia_del_Domicilio { get; set; }
        public string Especifique { get; set; }


        public bool Removed { set; get; }
    }

    public class Catalogo_Tipo_de_Embalaje_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Lista_de_AsignacionesGridModelPost
    {
        public int Clave { get; set; }
        public int? Numero_de_Asignacion { get; set; }
        public string Nombre { get; set; }
        public bool? Realizado { get; set; }
        public string Especifique { get; set; }

        public bool Removed { set; get; }
    }

    public class Catalogo_Tipo_de_Fijacion_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_de_Traslado_de_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Temperatura { get; set; }
        public string Humedad { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Estatus { get; set; }

        public bool Removed { set; get; }
    }

    public class Catalogo_Tipo_de_Indicio_CCGridModelPost
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }



}

