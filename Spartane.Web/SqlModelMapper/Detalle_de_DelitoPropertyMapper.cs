using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_de_Delito;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_de_DelitoPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_de_Delito.Clave";
                case "Descripcion_corta":
                    return "Detalle_de_Delito.Descripcion_corta";
                case "Robo_de_Vehiculo":
                    return "Detalle_de_Delito.Robo_de_Vehiculo";
                case "Expediente_Inicial[NUAT]":
                case "Expediente_InicialNUAT":
                    return "Modulo_Atencion_Inicial.NUAT";
                case "Expediente_MP[nic]":
                case "Expediente_MPnic":
                    return "expediente_ministerio_publico.nic";
                case "Expediente_MASC[Numero_de_Folio]":
                case "Expediente_MASCNumero_de_Folio":
                    return "Solicitud.Numero_de_Folio";
                case "Tipo_de_Denuncia[Descripcion]":
                case "Tipo_de_DenunciaDescripcion":
                    return "Formato_de_Denuncia.Descripcion";
                case "Fecha_del_Delito":
                    return "Detalle_de_Delito.Fecha_del_Delito";
                case "Hora_del_Delito":
                    return "Detalle_de_Delito.Hora_del_Delito";
                case "Violencia_de_Genero":
                    return "Detalle_de_Delito.Violencia_de_Genero";
                case "Delito_Violencia_Genero[Descripcion]":
                case "Delito_Violencia_GeneroDescripcion":
                    return "Delitos_Violencia_Genero.Descripcion";
                case "Tipo_de_Delito[Descripcion]":
                case "Tipo_de_DelitoDescripcion":
                    return "Titulo_del_Delito.Descripcion";
                case "Grupo_Delito[Descripcion]":
                case "Grupo_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Circunstancia_Delito[Descripcion]":
                case "Circunstancia_DelitoDescripcion":
                    return "Circunstancia_del_Delito.Descripcion";
                case "Articulado_de_Delito":
                    return "Detalle_de_Delito.Articulado_de_Delito";
                case "Delito_Principal":
                    return "Detalle_de_Delito.Delito_Principal";
                case "Forma_Comision_Delito[Descripcion]":
                case "Forma_Comision_DelitoDescripcion":
                    return "Forma_Comision_Delito.Descripcion";
                case "Forma_Accion_Delito[Descripcion]":
                case "Forma_Accion_DelitoDescripcion":
                    return "Forma_Accion_Delito.Descripcion";
                case "Modalidad_Delito[Descripcion]":
                case "Modalidad_DelitoDescripcion":
                    return "Modalidad_Delito.Descripcion";
                case "Elementos_Comision_Delito[Descripcion]":
                case "Elementos_Comision_DelitoDescripcion":
                    return "Elementos_Comision_Delito.Descripcion";
                case "Clasificacion_con_Orden_de_Resultado[Descripcion]":
                case "Clasificacion_con_Orden_de_ResultadoDescripcion":
                    return "Clasificacion_en_Orden_de_Resultado.Descripcion";
                case "Concurso[Descripcion]":
                case "ConcursoDescripcion":
                    return "Concurso.Descripcion";
                case "Monto":
                    return "Detalle_de_Delito.Monto";
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
                    return "Detalle_de_Delito.Codigo_Postal";
                case "Calle":
                    return "Detalle_de_Delito.Calle";
                case "Entre_Calle":
                    return "Detalle_de_Delito.Entre_Calle";
                case "y_Calle":
                    return "Detalle_de_Delito.y_Calle";
                case "Numero_Exterior_del_Delito":
                    return "Detalle_de_Delito.Numero_Exterior_del_Delito";
                case "Numero_Interior_del_Delito":
                    return "Detalle_de_Delito.Numero_Interior_del_Delito";
                case "Referencia":
                    return "Detalle_de_Delito.Referencia";
                case "Latitud":
                    return "Detalle_de_Delito.Latitud";
                case "Longitud":
                    return "Detalle_de_Delito.Longitud";
                case "Puede_Ser_Canalizado_a_JA[Descripcion]":
                case "Puede_Ser_Canalizado_a_JADescripcion":
                    return "A_Tiempo.Descripcion";
                case "Motivo_de_no_canalizacion[Descripcion]":
                case "Motivo_de_no_canalizacionDescripcion":
                    return "Motivo_de_No_Canalizacion.Descripcion";
                case "Se_Informaron_sus_Derechos":
                    return "Detalle_de_Delito.Se_Informaron_sus_Derechos";
                case "Se_Informo_el_Procedimiento":
                    return "Detalle_de_Delito.Se_Informo_el_Procedimiento";
                case "Levantamiento_de_Cadaver":
                    return "Detalle_de_Delito.Levantamiento_de_Cadaver";
                case "Fecha_del_Robo":
                    return "Detalle_de_Delito.Fecha_del_Robo";
                case "Hora_del_Robo":
                    return "Detalle_de_Delito.Hora_del_Robo";
                case "Robo_de[Descripcion]":
                case "Robo_deDescripcion":
                    return "Elemento_Robado.Descripcion";
                case "Registro_Federal_Vehicular":
                    return "Detalle_de_Delito.Registro_Federal_Vehicular";
                case "Numero_de_Registro_Publico_Vehicular":
                    return "Detalle_de_Delito.Numero_de_Registro_Publico_Vehicular";
                case "Circunstancia_de_Vehiculo[Descripcion]":
                case "Circunstancia_de_VehiculoDescripcion":
                    return "Circunstancia_Vehiculo.Descripcion";
                case "Clase[Descripcion]":
                case "ClaseDescripcion":
                    return "Especifica_Vehiculo.Descripcion";
                case "Vehiculo_Robado":
                    return "Detalle_de_Delito.Vehiculo_Robado";
                case "Marca[Descripcion]":
                case "MarcaDescripcion":
                    return "Marca_del_Vehiculo.Descripcion";
                case "Sub_Marca[Descripcion]":
                case "Sub_MarcaDescripcion":
                    return "Sub_Marca_del_Vehiculo.Descripcion";
                case "Tipo_de_Vehiculo[Descripcion]":
                case "Tipo_de_VehiculoDescripcion":
                    return "Tipo_de_Vehiculo.Descripcion";
                case "Modelo":
                    return "Detalle_de_Delito.Modelo";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_Vehiculo.Descripcion";
                case "Placas":
                    return "Detalle_de_Delito.Placas";
                case "Estado_de_Origen_de_las_Placas[Nombre]":
                case "Estado_de_Origen_de_las_PlacasNombre":
                    return "Estado.Nombre";
                case "Numero_de_Motor":
                    return "Detalle_de_Delito.Numero_de_Motor";
                case "Numero_de_Serie":
                    return "Detalle_de_Delito.Numero_de_Serie";
                case "Estado_del_Robo[Nombre]":
                case "Estado_del_RoboNombre":
                    return "Estado.Nombre";
                case "Municipio_del_Robo[Nombre]":
                case "Municipio_del_RoboNombre":
                    return "Municipio.Nombre";
                case "Colonia_del_Robo[Nombre]":
                case "Colonia_del_RoboNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal_Robo":
                    return "Detalle_de_Delito.Codigo_Postal_Robo";
                case "Calle_Robo":
                    return "Detalle_de_Delito.Calle_Robo";
                case "Entre_Calle_Robo":
                    return "Detalle_de_Delito.Entre_Calle_Robo";
                case "y_Calle_Robo":
                    return "Detalle_de_Delito.y_Calle_Robo";
                case "Numero_Exterior_del_Delito_Robo":
                    return "Detalle_de_Delito.Numero_Exterior_del_Delito_Robo";
                case "Numero_Interior_del_Delito_Robo":
                    return "Detalle_de_Delito.Numero_Interior_del_Delito_Robo";
                case "Referencia_Robo":
                    return "Detalle_de_Delito.Referencia_Robo";
                case "Latitud_Robo":
                    return "Detalle_de_Delito.Latitud_Robo";
                case "Longitud_Robo":
                    return "Detalle_de_Delito.Longitud_Robo";
                case "Lugar_del_Robo[Descripcion]":
                case "Lugar_del_RoboDescripcion":
                    return "Tipo_de_Lugar_del_Robo.Descripcion";
                case "Zona_de_Robo[Descripcion]":
                case "Zona_de_RoboDescripcion":
                    return "Zona_de_Robo.Descripcion";
                case "El_Vehiculo_esta_Asegurado":
                    return "Detalle_de_Delito.El_Vehiculo_esta_Asegurado";
                case "Nombre_de_la_Aseguradora[Descripcion]":
                case "Nombre_de_la_AseguradoraDescripcion":
                    return "Aseguradora_de_Vehiculo.Descripcion";
                case "Motor":
                    return "Detalle_de_Delito.Motor";
                case "Serie":
                    return "Detalle_de_Delito.Serie";
                case "Tipo_de_Servicio[Descripcion]":
                case "Tipo_de_ServicioDescripcion":
                    return "Servicio_del_Vehiculo.Descripcion";
                case "Ruta_del_Servicio_Publico":
                    return "Detalle_de_Delito.Ruta_del_Servicio_Publico";
                case "Procedencia[Descripcion]":
                case "ProcedenciaDescripcion":
                    return "Procedencia_del_Vehiculo.Descripcion";
                case "Mercancia":
                    return "Detalle_de_Delito.Mercancia";
                case "Descripcion_de_lo_que_Transportaba":
                    return "Detalle_de_Delito.Descripcion_de_lo_que_Transportaba";
                case "Monto_de_la_Carga":
                    return "Detalle_de_Delito.Monto_de_la_Carga";
                case "Senas_Particulares":
                    return "Detalle_de_Delito.Senas_Particulares";
                case "Cuenta_con_GPS":
                    return "Detalle_de_Delito.Cuenta_con_GPS";
                case "Tipo_de_Robo[Descripcion]":
                case "Tipo_de_RoboDescripcion":
                    return "Tipo_de_Robo.Descripcion";
                case "Tipo_de_Lugar_del_Robo[Descripcion]":
                case "Tipo_de_Lugar_del_RoboDescripcion":
                    return "Tipo_de_Lugar_del_Robo.Descripcion";
                case "Tipo_de_Carretera[Descripcion]":
                case "Tipo_de_CarreteraDescripcion":
                    return "Tipo_de_Carretera.Descripcion";
                case "Modalidad_del_Robo[Descripcion]":
                case "Modalidad_del_RoboDescripcion":
                    return "Modalidad_de_Robo_de_Vehiculo.Descripcion";
                case "Causa_de_Muerte":
                    return "Detalle_de_Delito.Causa_de_Muerte";
                case "Circunstancia_Defuncion[Descripcion]":
                case "Circunstancia_DefuncionDescripcion":
                    return "Circunstancia_Defuncion.Descripcion";
                case "Consecuencia_Defuncion[Descripcion]":
                case "Consecuencia_DefuncionDescripcion":
                    return "Consecuencia_Defuncion.Descripcion";
                case "Fecha_Levantamiento":
                    return "Detalle_de_Delito.Fecha_Levantamiento";
                case "Hora_Levantamiento":
                    return "Detalle_de_Delito.Hora_Levantamiento";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Pais[Nombre]":
                case "PaisNombre":
                    return "Pais.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Colonia_no_Catalogada":
                    return "Detalle_de_Delito.Colonia_no_Catalogada";
                case "Numero_Exterior":
                    return "Detalle_de_Delito.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_de_Delito.Numero_Interior";
                case "Necropsia":
                    return "Detalle_de_Delito.Necropsia";
                case "Cronotanatodiagnostico":
                    return "Detalle_de_Delito.Cronotanatodiagnostico";
                case "Ruta":
                    return "Detalle_de_Delito.Ruta";
                case "Estado_del_Conductor":
                    return "Detalle_de_Delito.Estado_del_Conductor";
                case "Persona_Moral_Dueno":
                    return "Detalle_de_Delito.Persona_Moral_Dueno";
                case "Nombre_Completo[Nombre]":
                case "Nombre_CompletoNombre":
                    return "Detalle_de_Persona_Moral.Nombre";
                case "Persona_Fisica_Dueno":
                    return "Detalle_de_Delito.Persona_Fisica_Dueno";
                case "Nombre_Completo_Involucrado[Nombre_del_Tutor]":
                case "Nombre_Completo_InvolucradoNombre_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_del_Tutor";
                case "Denunciante_dueno":
                    return "Detalle_de_Delito.Denunciante_dueno";
                case "Nombre_Completo_Dueno[Nombre_del_Tutor]":
                case "Nombre_Completo_DuenoNombre_del_Tutor":
                    return "Detalle_de_Datos_Generales.Nombre_del_Tutor";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_de_Delito).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Robo_de_Vehiculo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_del_Delito")
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
            if (columnName == "Se_Informaron_sus_Derechos")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Se_Informo_el_Procedimiento")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Levantamiento_de_Cadaver")
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
            if (columnName == "Vehiculo_Robado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "El_Vehiculo_esta_Asegurado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Mercancia")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Cuenta_con_GPS")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_Levantamiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Estado_del_Conductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Moral_Dueno")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Persona_Fisica_Dueno")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Denunciante_dueno")
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

