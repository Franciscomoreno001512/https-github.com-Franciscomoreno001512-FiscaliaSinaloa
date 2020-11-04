using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using Spartane.Core.Domain.Concurso;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Elemento_Robado;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_del_Robo;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Binario;
using Spartane.Core.Domain.Tipo_de_Robo;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;
using Spartane.Core.Domain.Tipo_de_Carretera;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_JA;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.Detalle_de_Delito_de_Justicia
{
    /// <summary>
    /// Detalle_de_Delito_de_Justicia table
    /// </summary>
    public class Detalle_de_Delito_de_Justicia: BaseEntity
    {
        public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public DateTime? Fecha_de_Delito { get; set; }
        public bool? Violencia_de_Genero { get; set; }
        public int? Delito_Violencia_Genero { get; set; }
        public string Hora_de_Delito { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public int? Grupo_de_Delito { get; set; }
        public int? Delito { get; set; }
        public bool? Delito_Principal { get; set; }
        public int? Forma_de_Comision_de_Delito { get; set; }
        public short? Forma_de_Accion_de_Delito { get; set; }
        public short? Modalidad_de_Delito { get; set; }
        public int? Elementos_de_Comision_de_Delito { get; set; }
        public int? Clasificacion_con_Orden_de_Resultado { get; set; }
        public int? Concurso { get; set; }
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public int? Estado_del_Delito { get; set; }
        public int? Municipio_del_Delito { get; set; }
        public int? Colonia_del_Delito { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Delito { get; set; }
        public string Entre_Calle_del_Delito { get; set; }
        public string Y_Calle_del_Delito { get; set; }
        public string Numero_Exterior_del_Delito { get; set; }
        public string Numero_Interior_del_Delito { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }
        public DateTime? Fecha_del_Robo { get; set; }
        public string Hora_del_Robo { get; set; }
        public int? Robo_de { get; set; }
        public string Registro_Federal_Vehicular { get; set; }
        public string Numero_de_Registro_Publico_Vehicular { get; set; }
        public short? Circunstancia_de_Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_vehiculo { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public int? Estado_De_Robo { get; set; }
        public int? Municipio_de_Robo { get; set; }
        public int? Colonia_de_Robo { get; set; }
        public int? Codigo_Postal_de_Robo { get; set; }
        public string Calle_de_Robo { get; set; }
        public string Entre_Calle_de_Robo { get; set; }
        public string Y_Calle_de_Robo { get; set; }
        public string Numero_Exterior_de_Robo { get; set; }
        public string Numero_Interior_de_Robo { get; set; }
        public string Referencia_de_Robo { get; set; }
        public string Latitud_de_Robo { get; set; }
        public string Longitud_de_Robo { get; set; }
        public int? Lugar_de_Robo { get; set; }
        public bool? El_vehiculo_esta_asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? El_Vehiculo_Transportaba_Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        public decimal? Monto_de_carga { get; set; }
        public string Senas_particulares { get; set; }
        public int? Cuenta_con_GPS { get; set; }
        public int? Tipo_de_Robo { get; set; }
        public int? Tipo_de_Lugar_del_Robo { get; set; }
        public int? Tipo_de_Carretera { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Numero_de_Serie { get; set; }
        public string Numero_de_Motor { get; set; }
        public bool? Persona_Moral { get; set; }
        public int? Nombre_Completo_Persona_Moral { get; set; }
        public bool? Persona_Fisica { get; set; }
        public int? Nombre_Completo_Persona_Fisica { get; set; }
        public bool? Denunciante { get; set; }
        public int? Nombre_Completo_Denunciante { get; set; }

        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Delito_Violencia_Genero")]
        public virtual Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero Delito_Violencia_Genero_Delitos_Violencia_Genero { get; set; }
        [ForeignKey("Tipo_de_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Tipo_de_Delito_Titulo_del_Delito { get; set; }
        [ForeignKey("Grupo_de_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_de_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Forma_de_Comision_de_Delito")]
        public virtual Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito Forma_de_Comision_de_Delito_Forma_Comision_Delito { get; set; }
        [ForeignKey("Forma_de_Accion_de_Delito")]
        public virtual Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito Forma_de_Accion_de_Delito_Forma_Accion_Delito { get; set; }
        [ForeignKey("Modalidad_de_Delito")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_de_Delito_Modalidad_Delito { get; set; }
        [ForeignKey("Elementos_de_Comision_de_Delito")]
        public virtual Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito Elementos_de_Comision_de_Delito_Elementos_Comision_Delito { get; set; }
        [ForeignKey("Clasificacion_con_Orden_de_Resultado")]
        public virtual Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado { get; set; }
        [ForeignKey("Concurso")]
        public virtual Spartane.Core.Domain.Concurso.Concurso Concurso_Concurso { get; set; }
        [ForeignKey("Estado_del_Delito")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Delito_Estado { get; set; }
        [ForeignKey("Municipio_del_Delito")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Delito_Municipio { get; set; }
        [ForeignKey("Colonia_del_Delito")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Delito_Colonia { get; set; }
        [ForeignKey("Robo_de")]
        public virtual Spartane.Core.Domain.Elemento_Robado.Elemento_Robado Robo_de_Elemento_Robado { get; set; }
        [ForeignKey("Circunstancia_de_Robo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }
        [ForeignKey("Estado_de_Origen_de_las_Placas")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Origen_de_las_Placas_Estado { get; set; }
        [ForeignKey("Estado_De_Robo")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_De_Robo_Estado { get; set; }
        [ForeignKey("Municipio_de_Robo")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Robo_Municipio { get; set; }
        [ForeignKey("Colonia_de_Robo")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_Robo_Colonia { get; set; }
        [ForeignKey("Lugar_de_Robo")]
        public virtual Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo Lugar_de_Robo_Lugar_del_Robo { get; set; }
        [ForeignKey("Nombre_de_la_Aseguradora")]
        public virtual Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo { get; set; }
        [ForeignKey("Cuenta_con_GPS")]
        public virtual Spartane.Core.Domain.Binario.Binario Cuenta_con_GPS_Binario { get; set; }
        [ForeignKey("Tipo_de_Robo")]
        public virtual Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo Tipo_de_Robo_Tipo_de_Robo { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Robo")]
        public virtual Spartane.Core.Domain.Tipo_de_Lugar_del_Robo.Tipo_de_Lugar_del_Robo Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo { get; set; }
        [ForeignKey("Tipo_de_Carretera")]
        public virtual Spartane.Core.Domain.Tipo_de_Carretera.Tipo_de_Carretera Tipo_de_Carretera_Tipo_de_Carretera { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo Tipo_de_Servicio_Servicio_del_Vehiculo { get; set; }
        [ForeignKey("Nombre_Completo_Persona_Moral")]
        public virtual Spartane.Core.Domain.Detalle_de_Persona_Moral_JA.Detalle_de_Persona_Moral_JA Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA { get; set; }
        [ForeignKey("Nombre_Completo_Persona_Fisica")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Nombre_Completo_Denunciante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante { get; set; }

    }
	
	public class Detalle_de_Delito_de_Justicia_Datos_Generales
    {
                public int Clave { get; set; }
        public int? idRegistroAT { get; set; }
        public int? idRegistroUI { get; set; }
        public int? Solicitud { get; set; }
        public int? Tipo_de_Denuncia { get; set; }
        public DateTime? Fecha_de_Delito { get; set; }
        public bool? Violencia_de_Genero { get; set; }
        public int? Delito_Violencia_Genero { get; set; }
        public string Hora_de_Delito { get; set; }
        public int? Tipo_de_Delito { get; set; }
        public int? Grupo_de_Delito { get; set; }
        public int? Delito { get; set; }
        public bool? Delito_Principal { get; set; }
        public int? Forma_de_Comision_de_Delito { get; set; }
        public short? Forma_de_Accion_de_Delito { get; set; }
        public short? Modalidad_de_Delito { get; set; }
        public int? Elementos_de_Comision_de_Delito { get; set; }
        public int? Clasificacion_con_Orden_de_Resultado { get; set; }
        public int? Concurso { get; set; }
        public decimal? Monto_de_Reparacion_de_Danos { get; set; }
        public int? Estado_del_Delito { get; set; }
        public int? Municipio_del_Delito { get; set; }
        public int? Colonia_del_Delito { get; set; }
        public int? Codigo_Postal { get; set; }
        public string Calle_del_Delito { get; set; }
        public string Entre_Calle_del_Delito { get; set; }
        public string Y_Calle_del_Delito { get; set; }
        public string Numero_Exterior_del_Delito { get; set; }
        public string Numero_Interior_del_Delito { get; set; }
        public string Referencia { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? Robo_de_Vehiculo { get; set; }

		        [ForeignKey("Solicitud")]
        public virtual Spartane.Core.Domain.Solicitud.Solicitud Solicitud_Solicitud { get; set; }
        [ForeignKey("Tipo_de_Denuncia")]
        public virtual Spartane.Core.Domain.Tipo_de_Denuncia.Tipo_de_Denuncia Tipo_de_Denuncia_Tipo_de_Denuncia { get; set; }
        [ForeignKey("Delito_Violencia_Genero")]
        public virtual Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero Delito_Violencia_Genero_Delitos_Violencia_Genero { get; set; }
        [ForeignKey("Tipo_de_Delito")]
        public virtual Spartane.Core.Domain.Titulo_del_Delito.Titulo_del_Delito Tipo_de_Delito_Titulo_del_Delito { get; set; }
        [ForeignKey("Grupo_de_Delito")]
        public virtual Spartane.Core.Domain.Grupo_del_Delito.Grupo_del_Delito Grupo_de_Delito_Grupo_del_Delito { get; set; }
        [ForeignKey("Delito")]
        public virtual Spartane.Core.Domain.Delito.Delito Delito_Delito { get; set; }
        [ForeignKey("Forma_de_Comision_de_Delito")]
        public virtual Spartane.Core.Domain.Forma_Comision_Delito.Forma_Comision_Delito Forma_de_Comision_de_Delito_Forma_Comision_Delito { get; set; }
        [ForeignKey("Forma_de_Accion_de_Delito")]
        public virtual Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito Forma_de_Accion_de_Delito_Forma_Accion_Delito { get; set; }
        [ForeignKey("Modalidad_de_Delito")]
        public virtual Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito Modalidad_de_Delito_Modalidad_Delito { get; set; }
        [ForeignKey("Elementos_de_Comision_de_Delito")]
        public virtual Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito Elementos_de_Comision_de_Delito_Elementos_Comision_Delito { get; set; }
        [ForeignKey("Clasificacion_con_Orden_de_Resultado")]
        public virtual Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado { get; set; }
        [ForeignKey("Concurso")]
        public virtual Spartane.Core.Domain.Concurso.Concurso Concurso_Concurso { get; set; }
        [ForeignKey("Estado_del_Delito")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_del_Delito_Estado { get; set; }
        [ForeignKey("Municipio_del_Delito")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_del_Delito_Municipio { get; set; }
        [ForeignKey("Colonia_del_Delito")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_del_Delito_Colonia { get; set; }

    }

	public class Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_Vehiculo
    {
                public int Clave { get; set; }
        public DateTime? Fecha_del_Robo { get; set; }
        public string Hora_del_Robo { get; set; }
        public int? Robo_de { get; set; }
        public string Registro_Federal_Vehicular { get; set; }
        public string Numero_de_Registro_Publico_Vehicular { get; set; }
        public short? Circunstancia_de_Robo_de_Vehiculo { get; set; }
        public int? Marca { get; set; }
        public int? Sub_Marca { get; set; }
        public int? Tipo_de_vehiculo { get; set; }
        public int? Modelo { get; set; }
        public int? Color { get; set; }
        public string Placas { get; set; }
        public int? Estado_de_Origen_de_las_Placas { get; set; }
        public string Motor { get; set; }
        public string Serie { get; set; }
        public int? Estado_De_Robo { get; set; }
        public int? Municipio_de_Robo { get; set; }
        public int? Colonia_de_Robo { get; set; }
        public int? Codigo_Postal_de_Robo { get; set; }
        public string Calle_de_Robo { get; set; }
        public string Entre_Calle_de_Robo { get; set; }
        public string Y_Calle_de_Robo { get; set; }
        public string Numero_Exterior_de_Robo { get; set; }
        public string Numero_Interior_de_Robo { get; set; }
        public string Referencia_de_Robo { get; set; }
        public string Latitud_de_Robo { get; set; }
        public string Longitud_de_Robo { get; set; }
        public int? Lugar_de_Robo { get; set; }
        public bool? El_vehiculo_esta_asegurado { get; set; }
        public int? Nombre_de_la_Aseguradora { get; set; }
        public string Ruta_del_Servicio_Publico { get; set; }
        public bool? El_Vehiculo_Transportaba_Mercancia { get; set; }
        public string Descripcion_de_lo_que_Transportaba { get; set; }
        public decimal? Monto_de_carga { get; set; }
        public string Senas_particulares { get; set; }
        public int? Cuenta_con_GPS { get; set; }
        public int? Tipo_de_Robo { get; set; }
        public int? Tipo_de_Lugar_del_Robo { get; set; }
        public int? Tipo_de_Carretera { get; set; }
        public int? Tipo_de_Servicio { get; set; }
        public string Numero_de_Serie { get; set; }
        public string Numero_de_Motor { get; set; }

		        [ForeignKey("Robo_de")]
        public virtual Spartane.Core.Domain.Elemento_Robado.Elemento_Robado Robo_de_Elemento_Robado { get; set; }
        [ForeignKey("Circunstancia_de_Robo_de_Vehiculo")]
        public virtual Spartane.Core.Domain.Circunstancia_Vehiculo.Circunstancia_Vehiculo Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo { get; set; }
        [ForeignKey("Marca")]
        public virtual Spartane.Core.Domain.Marca_del_Vehiculo.Marca_del_Vehiculo Marca_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Sub_Marca")]
        public virtual Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo Sub_Marca_Sub_Marca_del_Vehiculo { get; set; }
        [ForeignKey("Tipo_de_vehiculo")]
        public virtual Spartane.Core.Domain.Tipo_de_Vehiculo.Tipo_de_Vehiculo Tipo_de_vehiculo_Tipo_de_Vehiculo { get; set; }
        [ForeignKey("Color")]
        public virtual Spartane.Core.Domain.Color_Vehiculo.Color_Vehiculo Color_Color_Vehiculo { get; set; }
        [ForeignKey("Estado_de_Origen_de_las_Placas")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_de_Origen_de_las_Placas_Estado { get; set; }
        [ForeignKey("Estado_De_Robo")]
        public virtual Spartane.Core.Domain.Estado.Estado Estado_De_Robo_Estado { get; set; }
        [ForeignKey("Municipio_de_Robo")]
        public virtual Spartane.Core.Domain.Municipio.Municipio Municipio_de_Robo_Municipio { get; set; }
        [ForeignKey("Colonia_de_Robo")]
        public virtual Spartane.Core.Domain.Colonia.Colonia Colonia_de_Robo_Colonia { get; set; }
        [ForeignKey("Lugar_de_Robo")]
        public virtual Spartane.Core.Domain.Lugar_del_Robo.Lugar_del_Robo Lugar_de_Robo_Lugar_del_Robo { get; set; }
        [ForeignKey("Nombre_de_la_Aseguradora")]
        public virtual Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo { get; set; }
        [ForeignKey("Cuenta_con_GPS")]
        public virtual Spartane.Core.Domain.Binario.Binario Cuenta_con_GPS_Binario { get; set; }
        [ForeignKey("Tipo_de_Robo")]
        public virtual Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo Tipo_de_Robo_Tipo_de_Robo { get; set; }
        [ForeignKey("Tipo_de_Lugar_del_Robo")]
        public virtual Spartane.Core.Domain.Tipo_de_Lugar_del_Robo.Tipo_de_Lugar_del_Robo Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo { get; set; }
        [ForeignKey("Tipo_de_Carretera")]
        public virtual Spartane.Core.Domain.Tipo_de_Carretera.Tipo_de_Carretera Tipo_de_Carretera_Tipo_de_Carretera { get; set; }
        [ForeignKey("Tipo_de_Servicio")]
        public virtual Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo Tipo_de_Servicio_Servicio_del_Vehiculo { get; set; }

    }

	public class Detalle_de_Delito_de_Justicia_Asignar_Dueno
    {
                public int Clave { get; set; }
        public bool? Persona_Moral { get; set; }
        public int? Nombre_Completo_Persona_Moral { get; set; }
        public bool? Persona_Fisica { get; set; }
        public int? Nombre_Completo_Persona_Fisica { get; set; }
        public bool? Denunciante { get; set; }
        public int? Nombre_Completo_Denunciante { get; set; }

		        [ForeignKey("Nombre_Completo_Persona_Moral")]
        public virtual Spartane.Core.Domain.Detalle_de_Persona_Moral_JA.Detalle_de_Persona_Moral_JA Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA { get; set; }
        [ForeignKey("Nombre_Completo_Persona_Fisica")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante { get; set; }
        [ForeignKey("Nombre_Completo_Denunciante")]
        public virtual Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante.Detalle_de_Solicitud_Solicitante Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante { get; set; }

    }


}

