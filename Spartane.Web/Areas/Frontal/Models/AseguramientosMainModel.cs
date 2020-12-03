using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class AseguramientosMainModel
    {
        public AseguramientosModel AseguramientosInfo { set; get; }
        public Detalle_Aseguramiento_Medios_de_TransporteGridModelPost Detalle_Aseguramiento_Medios_de_TransporteGridInfo { set; get; }
        public Detalle_Aseguramiento_de_Drogas_InvolucradasGridModelPost Detalle_Aseguramiento_de_Drogas_InvolucradasGridInfo { set; get; }
        public Detalle_Aseguramiento_Armas_InvolucradasGridModelPost Detalle_Aseguramiento_Armas_InvolucradasGridInfo { set; get; }
        public Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModelPost Detalle_Aseguramiento_Artefactos_y_ExplosivosGridInfo { set; get; }
        public Detalle_Aseguramiento_de_Cargador_CartuchosGridModelPost Detalle_Aseguramiento_de_Cargador_CartuchosGridInfo { set; get; }
        public Detalle_Aseguramiento_Objetos_AseguradosGridModelPost Detalle_Aseguramiento_Objetos_AseguradosGridInfo { set; get; }
        public Detalle_Aseguramiento_DocumentosGridModelPost Detalle_Aseguramiento_DocumentosGridInfo { set; get; }
        public Detalle_Aseguramiento_MonedaGridModelPost Detalle_Aseguramiento_MonedaGridInfo { set; get; }
        public Detalle_Aseguramiento_Otros_AseguramientosGridModelPost Detalle_Aseguramiento_Otros_AseguramientosGridInfo { set; get; }
        public Detalle_Aseguramiento_Electronicos_y_MultimediaGridModelPost Detalle_Aseguramiento_Electronicos_y_MultimediaGridInfo { set; get; }
        public Detalle_Aseguramiento_PirateriaGridModelPost Detalle_Aseguramiento_PirateriaGridInfo { set; get; }
        public Detalle_Aseguramiento_InmueblesGridModelPost Detalle_Aseguramiento_InmueblesGridInfo { set; get; }
        public Detalle_Aseguramiento_de_PlantiosGridModelPost Detalle_Aseguramiento_de_PlantiosGridInfo { set; get; }
        public Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModelPost Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridInfo { set; get; }
        public Detalle_Aseguramiento_OtrosGridModelPost Detalle_Aseguramiento_OtrosGridInfo { set; get; }

    }

    public class Detalle_Aseguramiento_Medios_de_TransporteGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string Especifique { get; set; }
        public short? Marca { get; set; }
        public short? Submarca { get; set; }
        public short? Modelo { get; set; }
        public string Placas { get; set; }
        public short? Color { get; set; }
        public string Numero_de_Motor { get; set; }
        public string Serie { get; set; }
        public short? Uso { get; set; }
        public short? Cap__De_Pasajeros { get; set; }
        public short? Procedencia { get; set; }
        public string Empresa { get; set; }
        public string Capacidad_de_Carga { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Observaciones { get; set; }
        public short? Detencion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_de_Drogas_InvolucradasGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_Armas_InvolucradasGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo { get; set; }
        public string Descripcion_del_Arma { get; set; }
        public int? Marca { get; set; }
        public short? Calibre { get; set; }
        public string Matricula { get; set; }
        public string Serie { get; set; }
        public string Inventario { get; set; }
        public short? Clasificacion { get; set; }
        public int? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModelPost
    {
        public int Clave { get; set; }
        public int? Clasificacion { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Lugar_de_Hallazgo { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_de_Cargador_CartuchosGridModelPost
    {
        public int Clave { get; set; }
        public int? cartuchos_municiones { get; set; }
        public string Cartuchos_Habiles { get; set; }
        public int? Cartuchos_Percutidos { get; set; }
        public int? cargadores { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_Objetos_AseguradosGridModelPost
    {
        public int Clave { get; set; }
        public string Numero { get; set; }
        public short? Tipo { get; set; }
        public short? Marca { get; set; }
        public string Serie { get; set; }
        public string IMEI { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_DocumentosGridModelPost
    {
        public int Clave { get; set; }
        public int? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public string Descipcion_de_Documento { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_MonedaGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }
        public short? Descripcion { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_Otros_AseguramientosGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public short? Marca { get; set; }
        public short? Modelo { get; set; }
        public string Inventario { get; set; }
        public string Serie { get; set; }
        public short? Unidad_de_Medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_Electronicos_y_MultimediaGridModelPost
    {
        public int Clave { get; set; }
        public short? Aparatos { get; set; }
        public short? Documentos_Multimedia { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string A_resguardo { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_PirateriaGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public short? Unidad_de_Medicion { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_InmueblesGridModelPost
    {
        public int Clave { get; set; }
        public short? Zona { get; set; }
        public short? Tipo { get; set; }
        public short? Terreno { get; set; }
        public string Especifique_Otro { get; set; }
        public string Calle { get; set; }
        public string Exterior { get; set; }
        public string Interior { get; set; }
        public string C_P { get; set; }
        public int? Estado { get; set; }
        public int? Municipio { get; set; }
        public string Colonia { get; set; }
        public string Registro_Publico_Propiedad { get; set; }
        public string Entrecalles { get; set; }
        public string Propietario { get; set; }
        public string Observaciones { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_de_PlantiosGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public int? No__de_Plantios { get; set; }
        public decimal? Kilogramos { get; set; }
        public short? Metodo_de_Destruccion { get; set; }
        public string Superficie { get; set; }
        public string Altura { get; set; }
        public string Densidad { get; set; }
        public string Peso_por_planta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModelPost
    {
        public int Clave { get; set; }
        public short? Tipo { get; set; }
        public int? Suelo { get; set; }
        public string Descripcion { get; set; }
        public string Localizacion_1 { get; set; }
        public string Localizacion_2 { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? Orientacion_de { get; set; }
        public int? Orientacion { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }

        public bool Removed { set; get; }
    }

    public class Detalle_Aseguramiento_OtrosGridModelPost
    {
        public int Clave { get; set; }
        public string Tipo { get; set; }
        public string Unidad_de_medida { get; set; }
        public decimal? Cantidad { get; set; }
        public string Descripcion { get; set; }

        public bool Removed { set; get; }
    }



}

