using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Orientador;

namespace Spartane.Web.SqlModelMapper
{
    public class OrientadorPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Clave":
                    return "Orientador.Clave";
                case "Fecha_de_Registro":
                    return "Orientador.Fecha_de_Registro";
                case "Hora_de_Registro":
                    return "Orientador.Hora_de_Registro";
                case "Usuario_que_Registra[Name]":
                case "Usuario_que_RegistraName":
                    return "Spartan_User.Name";
                case "Atencion_Medica":
                    return "Orientador.Atencion_Medica";
                case "Atencion_Psicologica":
                    return "Orientador.Atencion_Psicologica";
                case "Traductor":
                    return "Orientador.Traductor";
                case "Narrativa_DM":
                    return "Orientador.Narrativa_DM";
                case "Narrativa_DP":
                    return "Orientador.Narrativa_DP";
                case "Idioma[Descripcion]":
                case "IdiomaDescripcion":
                    return "Idioma.Descripcion";
                case "Nombre":
                    return "Orientador.Nombre";
                case "Apellido_Paterno":
                    return "Orientador.Apellido_Paterno";
                case "Apellido_Materno":
                    return "Orientador.Apellido_Materno";
                case "Fecha_de_Nacimiento":
                    return "Orientador.Fecha_de_Nacimiento";
                case "Edad":
                    return "Orientador.Edad";
                case "Sexo[Descripcion]":
                case "SexoDescripcion":
                    return "Genero.Descripcion";
                case "Estado_Civil[Descripcion]":
                case "Estado_CivilDescripcion":
                    return "Estado_Civil.Descripcion";
                case "Tipo_de_Identificacion[Nombre]":
                case "Tipo_de_IdentificacionNombre":
                    return "Tipo_de_Identificacion.Nombre";
                case "Numero_de_Identificacion":
                    return "Orientador.Numero_de_Identificacion";
                case "Nacionalidad[NacionalidadC]":
                case "NacionalidadNacionalidadC":
                    return "Nacionalidad.NacionalidadC";
                case "Escolaridad[Descripcion]":
                case "EscolaridadDescripcion":
                    return "Escolaridad.Descripcion";
                case "Ocupacion[Descripcion]":
                case "OcupacionDescripcion":
                    return "Ocupacion.Descripcion";
                case "Calle":
                    return "Orientador.Calle";
                case "Numero_Exterior":
                    return "Orientador.Numero_Exterior";
                case "Numero_Interior":
                    return "Orientador.Numero_Interior";
                case "Colonia[Nombre]":
                case "ColoniaNombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal":
                    return "Orientador.Codigo_Postal";
                case "Localidad[Descripcion]":
                case "LocalidadDescripcion":
                    return "Localidad.Descripcion";
                case "Municipio[Nombre]":
                case "MunicipioNombre":
                    return "Municipio.Nombre";
                case "Estado[Nombre]":
                case "EstadoNombre":
                    return "Estado.Nombre";
                case "Telefono":
                    return "Orientador.Telefono";
                case "Celular":
                    return "Orientador.Celular";
                case "Correo_Electronico":
                    return "Orientador.Correo_Electronico";
                case "Fecha_del_Hecho":
                    return "Orientador.Fecha_del_Hecho";
                case "Hora_Aproximada_del_Hecho":
                    return "Orientador.Hora_Aproximada_del_Hecho";
                case "Tipo_de_Lugar_del_Hecho[Descripcion]":
                case "Tipo_de_Lugar_del_HechoDescripcion":
                    return "Lugar_Tipo.Descripcion";
                case "Calle2":
                    return "Orientador.Calle2";
                case "Numero_Exterior2":
                    return "Orientador.Numero_Exterior2";
                case "Numero_Interior2":
                    return "Orientador.Numero_Interior2";
                case "Colonia2[Nombre]":
                case "Colonia2Nombre":
                    return "Colonia.Nombre";
                case "Codigo_Postal2":
                    return "Orientador.Codigo_Postal2";
                case "Zona[Descripcion]":
                case "ZonaDescripcion":
                    return "Zona.Descripcion";
                case "Municipio2[Nombre]":
                case "Municipio2Nombre":
                    return "Municipio.Nombre";
                case "Estado2[Nombre]":
                case "Estado2Nombre":
                    return "Estado.Nombre";
                case "Grupo_Delito[Descripcion]":
                case "Grupo_DelitoDescripcion":
                    return "Grupo_del_Delito.Descripcion";
                case "Delito[Descripcion]":
                case "DelitoDescripcion":
                    return "Delito.Descripcion";
                case "Circunstancia[Descripcion]":
                case "CircunstanciaDescripcion":
                    return "Circunstancia_del_Delito.Descripcion";
                case "Tipo_Delito[Descripcion]":
                case "Tipo_DelitoDescripcion":
                    return "Tipo_Delito.Descripcion";
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
                    return "Orientador.Monto";
                case "HViolencia_de_Genero":
                    return "Orientador.HViolencia_de_Genero";
                case "Calificacion_del_Delito":
                    return "Orientador.Calificacion_del_Delito";
                case "CircunstanciaV[Descripcion]":
                case "CircunstanciaVDescripcion":
                    return "Circunstancia_Vehiculo.Descripcion";
                case "Clase_Especifica[Descripcion]":
                case "Clase_EspecificaDescripcion":
                    return "Especifica_Vehiculo.Descripcion";
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
                    return "Orientador.Modelo";
                case "Color[Descripcion]":
                case "ColorDescripcion":
                    return "Color_Vehiculo.Descripcion";
                case "Placas":
                    return "Orientador.Placas";
                case "Estado_Placas[Nombre]":
                case "Estado_PlacasNombre":
                    return "Estado.Nombre";
                case "Vehiculo_Robado":
                    return "Orientador.Vehiculo_Robado";
                case "Seguro":
                    return "Orientador.Seguro";
                case "Aseguradora[Descripcion]":
                case "AseguradoraDescripcion":
                    return "Aseguradora_de_Vehiculo.Descripcion";
                case "Tipo_de_Servicio[Descripcion]":
                case "Tipo_de_ServicioDescripcion":
                    return "Servicio_del_Vehiculo.Descripcion";
                case "Ruta_del_Servicio_Publico":
                    return "Orientador.Ruta_del_Servicio_Publico";
                case "Mercancia":
                    return "Orientador.Mercancia";
                case "Descripcion":
                    return "Orientador.Descripcion";
                case "Monto_de_la_Carga":
                    return "Orientador.Monto_de_la_Carga";
                case "Senas_Particulares":
                    return "Orientador.Senas_Particulares";
                case "Modalidad_del_Robo[Descripcion]":
                case "Modalidad_del_RoboDescripcion":
                    return "Modalidad_de_Robo_de_Vehiculo.Descripcion";
                case "Circunstancia_Defuncion[Descripcion]":
                case "Circunstancia_DefuncionDescripcion":
                    return "Circunstancia_Defuncion.Descripcion";
                case "Consecuencia_Defuncion[Descripcion]":
                case "Consecuencia_DefuncionDescripcion":
                    return "Consecuencia_Defuncion.Descripcion";
                case "Fecha_Levantamiento":
                    return "Orientador.Fecha_Levantamiento";
                case "Hora_Levantamiento":
                    return "Orientador.Hora_Levantamiento";
                case "Domicilio":
                    return "Orientador.Domicilio";
                case "Numero_Interior3":
                    return "Orientador.Numero_Interior3";
                case "Numero_Exterior3":
                    return "Orientador.Numero_Exterior3";
                case "Colonia3[Nombre]":
                case "Colonia3Nombre":
                    return "Colonia.Nombre";
                case "Colonia_no_Catalogada":
                    return "Orientador.Colonia_no_Catalogada";
                case "Zona2[Descripcion]":
                case "Zona2Descripcion":
                    return "Zona.Descripcion";
                case "Municipio3[Nombre]":
                case "Municipio3Nombre":
                    return "Municipio.Nombre";
                case "Estado3[Nombre]":
                case "Estado3Nombre":
                    return "Estado.Nombre";
                case "Necropsia":
                    return "Orientador.Necropsia";
                case "Cronotanatodiagnostico":
                    return "Orientador.Cronotanatodiagnostico";
                case "Ruta":
                    return "Orientador.Ruta";
                case "Estado_Operador":
                    return "Orientador.Estado_Operador";
                case "Delito_Principal_o_Secundario":
                    return "Orientador.Delito_Principal_o_Secundario";
                case "Concurso":
                    return "Orientador.Concurso";
                case "Compareciente[Descripcion]":
                case "ComparecienteDescripcion":
                    return "Tipo_de_Compareciente.Descripcion";
                case "NombreC":
                    return "Orientador.NombreC";
                case "Apellido_PaternoC":
                    return "Orientador.Apellido_PaternoC";
                case "Apellido_MaternoC":
                    return "Orientador.Apellido_MaternoC";
                case "NombreT":
                    return "Orientador.NombreT";
                case "Apellido_PaternoT":
                    return "Orientador.Apellido_PaternoT";
                case "Apellido_MaternoT":
                    return "Orientador.Apellido_MaternoT";
                case "CalleC":
                    return "Orientador.CalleC";
                case "Numero_ExteriorC":
                    return "Orientador.Numero_ExteriorC";
                case "Numero_InteriorC":
                    return "Orientador.Numero_InteriorC";
                case "ColoniaC[Nombre]":
                case "ColoniaCNombre":
                    return "Colonia.Nombre";
                case "Codigo_PostalC":
                    return "Orientador.Codigo_PostalC";
                case "ZonaC[Descripcion]":
                case "ZonaCDescripcion":
                    return "Zona.Descripcion";
                case "MunicipioC[Nombre]":
                case "MunicipioCNombre":
                    return "Municipio.Nombre";
                case "EstadoC[Nombre]":
                case "EstadoCNombre":
                    return "Estado.Nombre";
                case "NarrativaC":
                    return "Orientador.NarrativaC";
                case "Conocido":
                    return "Orientador.Conocido";
                case "Desconocido":
                    return "Orientador.Desconocido";
                case "Numero_de_Imputados":
                    return "Orientador.Numero_de_Imputados";
                case "Procedencia[Descripcion]":
                case "ProcedenciaDescripcion":
                    return "Procedencia_del_Vehiculo.Descripcion";
                case "Motor":
                    return "Orientador.Motor";
                case "Serie":
                    return "Orientador.Serie";
                case "Causa_de_Muerte":
                    return "Orientador.Causa_de_Muerte";
                case "Entre_Calle":
                    return "Orientador.Entre_Calle";
                case "Entre_Calle2":
                    return "Orientador.Entre_Calle2";
                case "Autoriza":
                    return "Orientador.Autoriza";
                case "Autoriza2":
                    return "Orientador.Autoriza2";
                case "Autoriza3":
                    return "Orientador.Autoriza3";
                case "Menor_de_Edad":
                    return "Orientador.Menor_de_Edad";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Orientador).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {
            if (columnName == "Fecha_de_Registro")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Atencion_Medica")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Atencion_Psicologica")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Traductor")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Fecha_de_Nacimiento")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "Fecha_del_Hecho")
            {
                try
                {
                    value = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {

                }
            }
            if (columnName == "HViolencia_de_Genero")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Vehiculo_Robado")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Seguro")
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
            if (columnName == "Estado_Operador")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Delito_Principal_o_Secundario")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Conocido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Desconocido")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Autoriza")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Autoriza2")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Autoriza3")
            {
                value = Convert.ToString(value) != string.Empty?(Convert.ToString(value) == "true"  ? 1 :0 ): value;
            }
            if (columnName == "Menor_de_Edad")
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

