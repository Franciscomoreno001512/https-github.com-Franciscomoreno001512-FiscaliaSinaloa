using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Datos_de_Delito_MPIGridModel
    {
        public int Clave { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public string Tipo_de_DelitoDescripcion { get; set; }
        public int? Grupo_Delito { get; set; }
        public string Grupo_DelitoDescripcion { get; set; }
        public int? Delito { get; set; }
        public string DelitoDescripcion { get; set; }
        public int? Circunstancia_Delito { get; set; }
        public string Circunstancia_DelitoDescripcion { get; set; }
        public bool? Delito_Principal { get; set; }
        public int? Forma_Comision_Delito { get; set; }
        public string Forma_Comision_DelitoDescripcion { get; set; }
        public short? Forma_Accion_Delito { get; set; }
        public string Forma_Accion_DelitoDescripcion { get; set; }
        public short? Modalidad_Delito { get; set; }
        public string Modalidad_DelitoDescripcion { get; set; }
        public int? Elementos_Comision_Delito { get; set; }
        public string Elementos_Comision_DelitoDescripcion { get; set; }
        public decimal? Monto { get; set; }
        public bool? Violencia_de_Genero { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public bool? Levantamiento_de_Cadaver { get; set; }
        public short? Circunstancia_de_Vehiculo { get; set; }
        public string Circunstancia_de_VehiculoDescripcion { get; set; }
        public short? Clase { get; set; }
        public string ClaseDescripcion { get; set; }
        public bool? Vehiculo_Robado { get; set; }
        public int? Marca { get; set; }
        public string MarcaDescripcion { get; set; }
        public int? Sub_Marca { get; set; }
        public string Sub_MarcaDescripcion { get; set; }
        public int? Tipo_de_Vehiculo { get; set; }
        public string Tipo_de_VehiculoDescripcion { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string ColorDescripcion { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Estado_de_Origen_de_las_PlacasNombre { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public bool? El_Vehiculo_esta_Asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public string Nombre_de_la_AseguradoraDescripcion { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Tipo_de_ServicioDescripcion { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public short? Procedencia { get; set; }
        public string ProcedenciaDescripcion { get; set; }
        public bool? Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        public decimal? Monto_de_la_Carga { get; set; }
        public string Senas_Particulares { get; set; }
        public short? Modalidad_del_Robo { get; set; }
        public string Modalidad_del_RoboDescripcion { get; set; }
        public string Causa_de_Muerte { get; set; }
        public short? Circunstancia_Defuncion { get; set; }
        public string Circunstancia_DefuncionDescripcion { get; set; }
        public short? Consecuencia_Defuncion { get; set; }
        public string Consecuencia_DefuncionDescripcion { get; set; }
        public string Fecha_Levantamiento { get; set; }
        public string Hora_Levantamiento { get; set; }
        public int? Tipo_de_Lugar_del_Hecho { get; set; }
        public string Tipo_de_Lugar_del_HechoDescripcion { get; set; }
        public int? Pais { get; set; }
        public string PaisNombre { get; set; }
        public int? Estado { get; set; }
        public string EstadoNombre { get; set; }
        public int? Municipio { get; set; }
        public string MunicipioNombre { get; set; }
        public int? Zona { get; set; }
        public string ZonaDescripcion { get; set; }
        public int? Colonia { get; set; }
        public string ColoniaNombre { get; set; }
        public string Colonia_no_Catalogada { get; set; }
        public int? Numero_Exterior { get; set; }
        public string Numero_Interior { get; set; }
        public string Necropsia { get; set; }
        public string Cronotanatodiagnostico { get; set; }
        public string Ruta { get; set; }
        public bool? Estado_del_Conductor { get; set; }
        public int? Codigo_Postal { get; set; }
        
    }
}

