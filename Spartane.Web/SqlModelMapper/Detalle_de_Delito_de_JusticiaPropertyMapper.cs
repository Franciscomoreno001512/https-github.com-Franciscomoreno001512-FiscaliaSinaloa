using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_Delito_de_JusticiaPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Delito_de_Justicia.Clave";
                case "idRegistroAT":
                    return "Detalle_de_Delito_de_Justicia.idRegistroAT";
                case "idRegistroUI":
                    return "Detalle_de_Delito_de_Justicia.idRegistroUI";
                case "Solicitud[Numero_de_Folio]":
                case "SolicitudNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Tipo_de_Denuncia[Descripcion]":
                case "Tipo_de_DenunciaDescripcion":
                    return "Tipo_de_Denuncia.Descripcion";
                case "Fecha_de_Delito":
                    return "Detalle_de_Delito_de_Justicia.Fecha_de_Delito";
                case "Violencia_de_Genero":
                    return "Detalle_de_Delito_de_Justicia.Violencia_de_Genero";
                case "Delito_Violencia_Genero[Descripcion]":
                case "Delito_Violencia_GeneroDescripcion":
                    return "Delitos_Violencia_Genero.Descripcion";
                case "Hora_de_Delito":
                    return "Detalle_de_Delito_de_Justicia.Hora_de_Delito";
                case "Tipo_de_Delito[Descripcion]":
                case "Tipo_de_DelitoDescripcion":
                    return "Titulo_del_Delito.Descripcion";
                case "Grupo_de_Delito[Descripcion]":
                case "Grupo_de_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Delito_Principal":
                    return "Detalle_de_Delito_de_Justicia.Delito_Principal";
                case "Forma_de_Comision_de_Delito[Descripcion]":
                case "Forma_de_Comision_de_DelitoDescripcion":
                    return "Forma_Comision_Delito.Descripcion";
                case "Forma_de_Accion_de_Delito[Descripcion]":
                case "Forma_de_Accion_de_DelitoDescripcion":
                    return "Forma_Accion_Delito.Descripcion";
                case "Modalidad_de_Delito[Descripcion]":
                case "Modalidad_de_DelitoDescripcion":
                    return "Modalidad_Delito.Descripcion";
                case "Elementos_de_Comision_de_Delito[Descripcion]":
                case "Elementos_de_Comision_de_DelitoDescripcion":
                    return "Elementos_Comision_Delito.Descripcion";
                case "Clasificacion_con_Orden_de_Resultado[Descripcion]":
                case "Clasificacion_con_Orden_de_ResultadoDescripcion":
                    return "Clasificacion_en_Orden_de_Resultado.Descripcion";
                case "Concurso[Descripcion]":
                case "ConcursoDescripcion":
                    return "Concurso.Descripcion";
                case "Monto_de_Reparacion_de_Danos":
                    return "Detalle_de_Delito_de_Justicia.Monto_de_Reparacion_de_Danos";
                case "Estado_del_Delito[Nombre]":
                case "Estado_del_DelitoNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Delito[Nombre]":
                case "Municipio_del_DelitoNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Delito[Nombre]":
                case "Colonia_del_DelitoNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Detalle_de_Delito_de_Justicia.Codigo_Postal";
                case "Calle_del_Delito":
                    return "Detalle_de_Delito_de_Justicia.Calle_del_Delito";
                case "Entre_Calle_del_Delito":
                    return "Detalle_de_Delito_de_Justicia.Entre_Calle_del_Delito";
                case "Y_Calle_del_Delito":
                    return "Detalle_de_Delito_de_Justicia.Y_Calle_del_Delito";
                case "Numero_Exterior_del_Delito":
                    return "Detalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito";
                case "Numero_Interior_del_Delito":
                    return "Detalle_de_Delito_de_Justicia.Numero_Interior_del_Delito";
                case "Referencia":
                    return "Detalle_de_Delito_de_Justicia.Referencia";
                case "Latitud":
                    return "Detalle_de_Delito_de_Justicia.Latitud";
                case "Longitud":
                    return "Detalle_de_Delito_de_Justicia.Longitud";
                case "Robo_de_Vehiculo":
                    return "Detalle_de_Delito_de_Justicia.Robo_de_Vehiculo";
                case "Fecha_del_Robo":
                    return "Detalle_de_Delito_de_Justicia.Fecha_del_Robo";
                case "Hora_del_Robo":
                    return "Detalle_de_Delito_de_Justicia.Hora_del_Robo";
                case "Robo_de[Descripcion]":
                case "Robo_deDescripcion":
                    return "Elemento_Robado.Descripcion";
                case "Registro_Federal_Vehicular":
                    return "Detalle_de_Delito_de_Justicia.Registro_Federal_Vehicular";
                case "Numero_de_Registro_Publico_Vehicular":
                    return "Detalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular";
                case "Circunstancia_de_Robo_de_Vehiculo[Descripcion]":
                case "Circunstancia_de_Robo_de_VehiculoDescripcion":
                    return "Circunstancia_Vehiculo.Descripcion";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_del_Vehiculo.Descripcion";
                case "Sub_Marca[Descripcion]":
                case "Sub_MarcaDescripcion":
                    return "Sub_Marca_del_Vehiculo.Descripcion";
                case "Tipo_de_vehiculo[Descripcion]":
                case "Tipo_de_vehiculoDescripcion":
                    return "Tipo_de_Vehiculo.Descripcion";
                case "Modelo":
                    return "Detalle_de_Delito_de_Justicia.Modelo";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_Vehiculo.Descripcion";
                case "Placas":
                    return "Detalle_de_Delito_de_Justicia.Placas";
                case "Estado_de_Origen_de_las_Placas[Nombre]":
                case "Estado_de_Origen_de_las_PlacasNombre":
                    return "Estado.Nombre";
                case "Motor":
                    return "Detalle_de_Delito_de_Justicia.Motor";
                case "Serie":
                    return "Detalle_de_Delito_de_Justicia.Serie";
                case "Estado_De_Robo[Nombre]":
                case "Estado_De_RoboNombre":
                    return "Estado.Nombre";
                case "Municipio_de_Robo[Nombre]":
                case "Municipio_de_RoboNombre":
                    return "Municipio.Nombre";
                case "Colonia_de_Robo[Nombre]":
                case "Colonia_de_RoboNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Codigo_Postal_de_Robo";
                case "Calle_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Calle_de_Robo";
                case "Entre_Calle_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Entre_Calle_de_Robo";
                case "Y_Calle_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Y_Calle_de_Robo";
                case "Numero_Exterior_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo";
                case "Numero_Interior_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Numero_Interior_de_Robo";
                case "Referencia_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Referencia_de_Robo";
                case "Latitud_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Latitud_de_Robo";
                case "Longitud_de_Robo":
                    return "Detalle_de_Delito_de_Justicia.Longitud_de_Robo";
                case "Lugar_de_Robo[Descripcion]":
                case "Lugar_de_RoboDescripcion":
                    return "Lugar_del_Robo.Descripcion";
                case "El_vehiculo_esta_asegurado":
                    return "Detalle_de_Delito_de_Justicia.El_vehiculo_esta_asegurado";
                case "Nombre_de_la_Aseguradora[Descripcion]":
                case "Nombre_de_la_AseguradoraDescripcion":
                    return "Aseguradora_de_Vehiculo.Descripcion";
                case "Ruta_del_Servicio_Publico":
                    return "Detalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico";
                case "El_Vehiculo_Transportaba_Mercancia":
                    return "Detalle_de_Delito_de_Justicia.El_Vehiculo_Transportaba_Mercancia";
                case "Descripcion_de_lo_que_Transportaba":
                    return "Detalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba";
                case "Monto_de_carga":
                    return "Detalle_de_Delito_de_Justicia.Monto_de_carga";
                case "Senas_particulares":
                    return "Detalle_de_Delito_de_Justicia.Senas_particulares";
                case "Cuenta_con_GPS[Descripcion]":
                case "Cuenta_con_GPSDescripcion":
                    return "Binario.Descripcion";
                case "Tipo_de_Robo[Descripcion]":
                case "Tipo_de_RoboDescripcion":
                    return "Tipo_de_Robo.Descripcion";
                case "Tipo_de_Lugar_del_Robo[Descripcion]":
                case "Tipo_de_Lugar_del_RoboDescripcion":
                    return "Tipo_de_Lugar_del_Robo.Descripcion";
                case "Tipo_de_Carretera[Descripcion]":
                case "Tipo_de_CarreteraDescripcion":
                    return "Tipo_de_Carretera.Descripcion";
                case "Tipo_de_Servicio[Descripcion]":
                case "Tipo_de_ServicioDescripcion":
                    return "Servicio_del_Vehiculo.Descripcion";
                case "Numero_de_Serie":
                    return "Detalle_de_Delito_de_Justicia.Numero_de_Serie";
                case "Numero_de_Motor":
                    return "Detalle_de_Delito_de_Justicia.Numero_de_Motor";
                case "Persona_Moral":
                    return "Detalle_de_Delito_de_Justicia.Persona_Moral";
                case "Nombre_Completo_Persona_Moral[Nombre]":
                case "Nombre_Completo_Persona_MoralNombre":
                    return "Detalle_de_Persona_Moral_JA.Nombre";
                case "Persona_Fisica":
                    return "Detalle_de_Delito_de_Justicia.Persona_Fisica";
                case "Nombre_Completo_Persona_Fisica[Nombre]":
                case "Nombre_Completo_Persona_FisicaNombre":
                    return "Detalle_de_Solicitud_Solicitante.Nombre";
                case "Denunciante":
                    return "Detalle_de_Delito_de_Justicia.Denunciante";
                case "Nombre_Completo_Denunciante[Nombre]":
                case "Nombre_Completo_DenuncianteNombre":
                    return "Detalle_de_Solicitud_Solicitante.Nombre";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Delito_de_Justicia).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Delito")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Violencia_de_Genero")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Delito_Principal")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Robo_de_Vehiculo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_del_Robo")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "El_vehiculo_esta_asegurado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "El_Vehiculo_Transportaba_Mercancia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Moral")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Fisica")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Denunciante")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }


            var operatorCondition = GetOperationType(columnName);
            columnName = GetPropertyName(columnName);

            switch (operatorCondition)
            {
                case SqlOperationType.Contains:
                    return string.IsNullOrEmpty(Convert.ToString(value)) ? "" : columnName + " LIKE '%" + value + "%'";
                case SqlOperationType.Equals:
                    return Convert.ToString(value) == "0" || Convert.ToString(value) == "" ? "" : columnName + "='" + value + "'";

            }
            return null;
        }
    }
}

