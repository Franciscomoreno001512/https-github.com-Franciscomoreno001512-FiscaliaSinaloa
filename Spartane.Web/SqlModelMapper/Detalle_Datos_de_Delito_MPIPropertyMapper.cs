using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI;

namespace Spartane.Web.SqlModelMapper
{
    public class Detalle_Datos_de_Delito_MPIPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Detalle_Datos_de_Delito_MPI.Clave";
                case "Tipo_de_Delito[Descripcion]":
                case "Tipo_de_DelitoDescripcion":
                    return "Tipo_Delito.Descripcion";
                case "Grupo_Delito[Descripcion]":
                case "Grupo_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Circunstancia_Delito[Descripcion]":
                case "Circunstancia_DelitoDescripcion":
                    return "Circunstancia_del_Delito.Descripcion";
                case "Delito_Principal":
                    return "Detalle_Datos_de_Delito_MPI.Delito_Principal";
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
                case "Monto":
                    return "Detalle_Datos_de_Delito_MPI.Monto";
                case "Violencia_de_Genero":
                    return "Detalle_Datos_de_Delito_MPI.Violencia_de_Genero";
                case "Robo_de_Vehiculo":
                    return "Detalle_Datos_de_Delito_MPI.Robo_de_Vehiculo";
                case "Levantamiento_de_Cadaver":
                    return "Detalle_Datos_de_Delito_MPI.Levantamiento_de_Cadaver";
                case "Circunstancia_de_Vehiculo[Descripcion]":
                case "Circunstancia_de_VehiculoDescripcion":
                    return "Circunstancia_Vehiculo.Descripcion";
                case "Clase[Descripcion]":
                case "ClaseDescripcion":
                    return "Especifica_Vehiculo.Descripcion";
                case "Vehiculo_Robado":
                    return "Detalle_Datos_de_Delito_MPI.Vehiculo_Robado";
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
                    return "Detalle_Datos_de_Delito_MPI.Modelo";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_Vehiculo.Descripcion";
                case "Placas":
                    return "Detalle_Datos_de_Delito_MPI.Placas";
                case "Estado_de_Origen_de_las_Placas[Nombre]":
                case "Estado_de_Origen_de_las_PlacasNombre":
                    return "Estado.Nombre";
                case "Motor":
                    return "Detalle_Datos_de_Delito_MPI.Motor";
                case "Serie":
                    return "Detalle_Datos_de_Delito_MPI.Serie";
                case "El_Vehiculo_esta_Asegurado":
                    return "Detalle_Datos_de_Delito_MPI.El_Vehiculo_esta_Asegurado";
                case "Nombre_de_la_Aseguradora[Descripcion]":
                case "Nombre_de_la_AseguradoraDescripcion":
                    return "Aseguradora_de_Vehiculo.Descripcion";
                case "Tipo_de_Servicio[Descripcion]":
                case "Tipo_de_ServicioDescripcion":
                    return "Servicio_del_Vehiculo.Descripcion";
                case "Ruta_del_Servicio_Publico":
                    return "Detalle_Datos_de_Delito_MPI.Ruta_del_Servicio_Publico";
                case "Procedencia[Descripcion]":
                case "ProcedenciaDescripcion":
                    return "Procedencia_del_Vehiculo.Descripcion";
                case "Mercancia":
                    return "Detalle_Datos_de_Delito_MPI.Mercancia";
                case "Descripcion_de_lo_que_Transportaba":
                    return "Detalle_Datos_de_Delito_MPI.Descripcion_de_lo_que_Transportaba";
                case "Monto_de_la_Carga":
                    return "Detalle_Datos_de_Delito_MPI.Monto_de_la_Carga";
                case "Senas_Particulares":
                    return "Detalle_Datos_de_Delito_MPI.Senas_Particulares";
                case "Modalidad_del_Robo[Descripcion]":
                case "Modalidad_del_RoboDescripcion":
                    return "Modalidad_de_Robo_de_Vehiculo.Descripcion";
                case "Causa_de_Muerte":
                    return "Detalle_Datos_de_Delito_MPI.Causa_de_Muerte";
                case "Circunstancia_Defuncion[Descripcion]":
                case "Circunstancia_DefuncionDescripcion":
                    return "Circunstancia_Defuncion.Descripcion";
                case "Consecuencia_Defuncion[Descripcion]":
                case "Consecuencia_DefuncionDescripcion":
                    return "Consecuencia_Defuncion.Descripcion";
                case "Fecha_Levantamiento":
                    return "Detalle_Datos_de_Delito_MPI.Fecha_Levantamiento";
                case "Hora_Levantamiento":
                    return "Detalle_Datos_de_Delito_MPI.Hora_Levantamiento";
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
                case "Zona[Descripcion]":
                case "ZonaDescripcion":
                    return "Zona.Descripcion";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Colonia_no_Catalogada":
                    return "Detalle_Datos_de_Delito_MPI.Colonia_no_Catalogada";
                case "Numero_Exterior":
                    return "Detalle_Datos_de_Delito_MPI.Numero_Exterior";
                case "Numero_Interior":
                    return "Detalle_Datos_de_Delito_MPI.Numero_Interior";
                case "Necropsia":
                    return "Detalle_Datos_de_Delito_MPI.Necropsia";
                case "Cronotanatodiagnostico":
                    return "Detalle_Datos_de_Delito_MPI.Cronotanatodiagnostico";
                case "Ruta":
                    return "Detalle_Datos_de_Delito_MPI.Ruta";
                case "Estado_del_Conductor":
                    return "Detalle_Datos_de_Delito_MPI.Estado_del_Conductor";
                case "Codigo_Postal":
                    return "Detalle_Datos_de_Delito_MPI.Codigo_Postal";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Detalle_Datos_de_Delito_MPI).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Delito_Principal")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Violencia_de_Genero")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Robo_de_Vehiculo")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Levantamiento_de_Cadaver")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
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

