using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI;







using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;















using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Tipo_de_Compareciente;

using Spartane.Core.Domain.Detalle_del_Abogado_Victima_MPI;

using Spartane.Core.Domain.Abogado;





using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;

using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;










using Spartane.Core.Domain.Prioridad_del_Hecho;


using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Lugar_Tipo;






using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;














using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;






using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;

using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;







using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Situacion_Fisica;





using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;



using Spartane.Core.Domain.Medidas_Cautelares;



using Spartane.Core.Domain.Medidas_Cautelares;


using Spartane.Core.Domain.Prioridad_del_Hecho;


using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI;

using Spartane.Core.Domain.Abogado;





using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;

using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;















using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;









using Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI;

using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Sentencia;





using Spartane.Core.Domain.Estatus_del_Imputado;


using Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI;

using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Circunstancia_del_Delito;

using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;




using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;

using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;

using Spartane.Core.Domain.Color_Vehiculo;

using Spartane.Core.Domain.Estado;



using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;

using Spartane.Core.Domain.Procedencia_del_Vehiculo;




using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;

using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;


using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Colonia;









using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_MPI;







using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo_MPI;

using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;


using Spartane.Core.Domain.Solicitante_MPI;

using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_MPI;







using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;















using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Tipo_de_Compareciente;


using Spartane.Core.Domain.Prioridad_del_Hecho;


using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;








using Spartane.Core.Domain.Lugar_Tipo;


using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_de_Agente_del_Ministerio_Publico;





using Spartane.Core.Domain.Tipo_de_Oficio;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Detalle_de_Servicios_Periciales;

using Spartane.Core.Domain.Servicios_Periciales;

using Spartane.Core.Domain.Estatus_del_Dictamen;



using Spartane.Core.Domain.Rol_de_Diligencia;


using Spartane.Core.Domain.Detalle_de_Oficio_de_Servicio_Pericial;

using Spartane.Core.Domain.Tipo_de_Oficios;
using Spartane.Core.Domain.Servicios_Periciales;

using Spartane.Core.Domain.Detalle_de_IPH_MPI;








using Spartane.Core.Domain.Tipo_de_Oficio;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Audiencias_MPI;

using Spartane.Core.Domain.Solicitante_MPI;


using Spartane.Core.Domain.Detalle_de_Requerido_en_Audiencias_MPI;

using Spartane.Core.Domain.Requerido_MPI;


using Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias;







using Spartane.Core.Domain.Detalle_de_Documentos_MPI;





using Spartane.Core.Domain.Detalle_de_Coincidencias_MPI;








using Spartane.Core.Domain.Detalle_de_Indicios;





using Spartane.Core.Domain.Servicios_Periciales;

using Spartane.Core.Domain.Estatus_de_Indicio;

using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI;



using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_Orientador;

using Spartane.Core.Domain.Delito_Principal_MPI;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Periodicidad;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Expediente_Inicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_Detenido_MPI;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_de_la_Victima_MPI;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Victima_MPI;

using Spartane.Web.Areas.WebApiConsumer.Abogado;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;


using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_MPI;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Cantidad_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Implantacion_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Complexion;
using Spartane.Web.Areas.WebApiConsumer.Color_Piel;
using Spartane.Web.Areas.WebApiConsumer.Frente;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Calvicie;
using Spartane.Web.Areas.WebApiConsumer.Color_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Ojos;
using Spartane.Web.Areas.WebApiConsumer.Froma_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Labios;
using Spartane.Web.Areas.WebApiConsumer.Boca;
using Spartane.Web.Areas.WebApiConsumer.Menton;
using Spartane.Web.Areas.WebApiConsumer.Barba;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Lobulo;
using Spartane.Web.Areas.WebApiConsumer.Bigote;
using Spartane.Web.Areas.WebApiConsumer.Situacion_Fisica;




using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_Detenido_MPI;


using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;

using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;


using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Imputado_MPI;

using Spartane.Web.Areas.WebApiConsumer.Abogado;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;




using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Sentencias_Imputado_MPI;

using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;




using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Imputado;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_de_Delito_MPI;

using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;

using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;




using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo;

using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Estado;

using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo;


using Spartane.Web.Areas.WebApiConsumer.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;


using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral_MPI;

using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

using Spartane.Web.Areas.WebApiConsumer.Dialecto;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo_MPI;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Solicitante_MPI;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Testigo_MPI;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;


using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;


using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Agente_del_Ministerio_Publico;


using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Oficio;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Agencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicios_Periciales;

using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Dictamen;

using Spartane.Web.Areas.WebApiConsumer.Rol_de_Diligencia;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Oficio_de_Servicio_Pericial;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Oficios;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_IPH_MPI;




using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Oficio;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Audiencias_MPI;

using Spartane.Web.Areas.WebApiConsumer.Solicitante_MPI;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Audiencias_MPI;

using Spartane.Web.Areas.WebApiConsumer.Requerido_MPI;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Citatorio_Audiencias;






using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPI;



using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Coincidencias_MPI;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Indicios;

using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Indicio;

using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Bitacora_de_Canalizacion_MPI;



using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;

using Spartane.Web.Areas.WebApiConsumer.Delito_Principal_MPI;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Periodicidad;

using Spartane.Web.AuthFilters;
using Spartane.Web.Helpers;
using Spartane.Web.Models;
using Spartane.Web.SqlModelMapper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Spartane.Core.Domain.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Process_Event_Detail;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permissions;
using Spartane.Web.Areas.WebApiConsumer.GeneratePDF;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Related;
using Spartane.Core.Domain.Spartan_Format;
using iTextSharp.text.pdf;


namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Expediente_InicialController : Controller
    {
        #region "variable declaration"

        private IExpediente_InicialService service = null;
        private IExpediente_InicialApiConsumer _IExpediente_InicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ICatalogo_Estatus_Detenido_MPIApiConsumer _ICatalogo_Estatus_Detenido_MPIApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private IDetalle_de_Datos_de_la_Victima_MPIApiConsumer _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer;


        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;


        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IDetalle_del_Abogado_Victima_MPIApiConsumer _IDetalle_del_Abogado_Victima_MPIApiConsumer;

        private IAbogadoApiConsumer _IAbogadoApiConsumer;



        private IPrioridad_del_HechoApiConsumer _IPrioridad_del_HechoApiConsumer;


        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;




        private IDetalle_de_Datos_del_Imputado_MPIApiConsumer _IDetalle_de_Datos_del_Imputado_MPIApiConsumer;


        private IForma_CaraApiConsumer _IForma_CaraApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
        private ICantidad_CabelloApiConsumer _ICantidad_CabelloApiConsumer;
        private IImplantacion_CabelloApiConsumer _IImplantacion_CabelloApiConsumer;
        private IComplexionApiConsumer _IComplexionApiConsumer;
        private IColor_PielApiConsumer _IColor_PielApiConsumer;
        private IFrenteApiConsumer _IFrenteApiConsumer;
        private IForma_CabelloApiConsumer _IForma_CabelloApiConsumer;
        private ICalvicieApiConsumer _ICalvicieApiConsumer;
        private IColor_OjosApiConsumer _IColor_OjosApiConsumer;
        private IOjosApiConsumer _IOjosApiConsumer;
        private IFroma_OjosApiConsumer _IFroma_OjosApiConsumer;
        private INariz_BaseApiConsumer _INariz_BaseApiConsumer;
        private ILabiosApiConsumer _ILabiosApiConsumer;
        private IBocaApiConsumer _IBocaApiConsumer;
        private IMentonApiConsumer _IMentonApiConsumer;
        private IBarbaApiConsumer _IBarbaApiConsumer;
        private IForma_OrejasApiConsumer _IForma_OrejasApiConsumer;
        private ITipo_LobuloApiConsumer _ITipo_LobuloApiConsumer;
        private IBigoteApiConsumer _IBigoteApiConsumer;
        private ISituacion_FisicaApiConsumer _ISituacion_FisicaApiConsumer;






        private IMedidas_CautelaresApiConsumer _IMedidas_CautelaresApiConsumer;




        private IDetalle_del_Abogado_Imputado_MPIApiConsumer _IDetalle_del_Abogado_Imputado_MPIApiConsumer;







        private IDetalle_de_Sentencias_Imputado_MPIApiConsumer _IDetalle_de_Sentencias_Imputado_MPIApiConsumer;

        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ISentenciaApiConsumer _ISentenciaApiConsumer;




        private IEstatus_del_ImputadoApiConsumer _IEstatus_del_ImputadoApiConsumer;


        private IDetalle_Datos_de_Delito_MPIApiConsumer _IDetalle_Datos_de_Delito_MPIApiConsumer;

        private ITipo_DelitoApiConsumer _ITipo_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private ICircunstancia_del_DelitoApiConsumer _ICircunstancia_del_DelitoApiConsumer;

        private IForma_Comision_DelitoApiConsumer _IForma_Comision_DelitoApiConsumer;
        private IForma_Accion_DelitoApiConsumer _IForma_Accion_DelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;
        private IElementos_Comision_DelitoApiConsumer _IElementos_Comision_DelitoApiConsumer;




        private ICircunstancia_VehiculoApiConsumer _ICircunstancia_VehiculoApiConsumer;
        private IEspecifica_VehiculoApiConsumer _IEspecifica_VehiculoApiConsumer;

        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;

        private IAseguradora_de_VehiculoApiConsumer _IAseguradora_de_VehiculoApiConsumer;
        private IServicio_del_VehiculoApiConsumer _IServicio_del_VehiculoApiConsumer;
        private IProcedencia_del_VehiculoApiConsumer _IProcedencia_del_VehiculoApiConsumer;


        private IModalidad_de_Robo_de_VehiculoApiConsumer _IModalidad_de_Robo_de_VehiculoApiConsumer;
        private ICircunstancia_DefuncionApiConsumer _ICircunstancia_DefuncionApiConsumer;
        private IConsecuencia_DefuncionApiConsumer _IConsecuencia_DefuncionApiConsumer;


        private IZonaApiConsumer _IZonaApiConsumer;


        private IDetalle_de_Persona_Moral_MPIApiConsumer _IDetalle_de_Persona_Moral_MPIApiConsumer;


        private IDialectoApiConsumer _IDialectoApiConsumer;
        private IIdiomaApiConsumer _IIdiomaApiConsumer;
        private IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer;

        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private ISolicitante_MPIApiConsumer _ISolicitante_MPIApiConsumer;

        private IDetalle_de_Datos_del_Testigo_MPIApiConsumer _IDetalle_de_Datos_del_Testigo_MPIApiConsumer;








        private IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer;


        private ITipo_de_OficioApiConsumer _ITipo_de_OficioApiConsumer;
        private IDelegacionApiConsumer _IDelegacionApiConsumer;
        private IAgenciaApiConsumer _IAgenciaApiConsumer;
        private IDetalle_de_Servicios_PericialesApiConsumer _IDetalle_de_Servicios_PericialesApiConsumer;

        private IServicios_PericialesApiConsumer _IServicios_PericialesApiConsumer;
        private IEstatus_del_DictamenApiConsumer _IEstatus_del_DictamenApiConsumer;

        private IRol_de_DiligenciaApiConsumer _IRol_de_DiligenciaApiConsumer;

        private IDetalle_de_Oficio_de_Servicio_PericialApiConsumer _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer;

        private ITipo_de_OficiosApiConsumer _ITipo_de_OficiosApiConsumer;

        private IDetalle_de_IPH_MPIApiConsumer _IDetalle_de_IPH_MPIApiConsumer;




        private IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer;


        private IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer;

        private IRequerido_MPIApiConsumer _IRequerido_MPIApiConsumer;

        private IDetalle_de_Citatorio_AudienciasApiConsumer _IDetalle_de_Citatorio_AudienciasApiConsumer;






        private IDetalle_de_Documentos_MPIApiConsumer _IDetalle_de_Documentos_MPIApiConsumer;



        private IDetalle_de_Coincidencias_MPIApiConsumer _IDetalle_de_Coincidencias_MPIApiConsumer;


        private IDetalle_de_IndiciosApiConsumer _IDetalle_de_IndiciosApiConsumer;

        private IEstatus_de_IndicioApiConsumer _IEstatus_de_IndicioApiConsumer;

        private IEstatus_de_Expediente_InicialApiConsumer _IEstatus_de_Expediente_InicialApiConsumer;
        private IEstatus_OrientadorApiConsumer _IEstatus_OrientadorApiConsumer;
        private IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer;




        private IDelito_Principal_MPIApiConsumer _IDelito_Principal_MPIApiConsumer;
        private ITipo_de_AcuerdoApiConsumer _ITipo_de_AcuerdoApiConsumer;
        private IPeriodicidadApiConsumer _IPeriodicidadApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;
        private IGeneratePDFApiConsumer _IGeneratePDFApiConsumer;
        private ISpartan_FormatApiConsumer _ISpartan_FormatApiConsumer;
        private ISpartan_Format_PermissionsApiConsumer _ISpartan_Format_PermissionsApiConsumer;
		private ISpartan_Format_RelatedApiConsumer _ISpartan_FormatRelatedApiConsumer;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Expediente_InicialController(IExpediente_InicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IExpediente_InicialApiConsumer Expediente_InicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ICatalogo_Estatus_Detenido_MPIApiConsumer Catalogo_Estatus_Detenido_MPIApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , IDetalle_de_Datos_de_la_Victima_MPIApiConsumer Detalle_de_Datos_de_la_Victima_MPIApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IDetalle_del_Abogado_Victima_MPIApiConsumer Detalle_del_Abogado_Victima_MPIApiConsumer , IAbogadoApiConsumer AbogadoApiConsumer  , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer  , IDetalle_de_Datos_del_Imputado_MPIApiConsumer Detalle_de_Datos_del_Imputado_MPIApiConsumer , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IFroma_OjosApiConsumer Froma_OjosApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IMentonApiConsumer MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer , IMedidas_CautelaresApiConsumer Medidas_CautelaresApiConsumer , IDetalle_del_Abogado_Imputado_MPIApiConsumer Detalle_del_Abogado_Imputado_MPIApiConsumer  , IDetalle_de_Sentencias_Imputado_MPIApiConsumer Detalle_de_Sentencias_Imputado_MPIApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ISentenciaApiConsumer SentenciaApiConsumer  , IEstatus_del_ImputadoApiConsumer Estatus_del_ImputadoApiConsumer  , IDetalle_Datos_de_Delito_MPIApiConsumer Detalle_Datos_de_Delito_MPIApiConsumer , ITipo_DelitoApiConsumer Tipo_DelitoApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , ICircunstancia_del_DelitoApiConsumer Circunstancia_del_DelitoApiConsumer , IForma_Comision_DelitoApiConsumer Forma_Comision_DelitoApiConsumer , IForma_Accion_DelitoApiConsumer Forma_Accion_DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer , IElementos_Comision_DelitoApiConsumer Elementos_Comision_DelitoApiConsumer , ICircunstancia_VehiculoApiConsumer Circunstancia_VehiculoApiConsumer , IEspecifica_VehiculoApiConsumer Especifica_VehiculoApiConsumer , IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer , ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer , ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer , IColor_VehiculoApiConsumer Color_VehiculoApiConsumer , IAseguradora_de_VehiculoApiConsumer Aseguradora_de_VehiculoApiConsumer , IServicio_del_VehiculoApiConsumer Servicio_del_VehiculoApiConsumer , IProcedencia_del_VehiculoApiConsumer Procedencia_del_VehiculoApiConsumer , IModalidad_de_Robo_de_VehiculoApiConsumer Modalidad_de_Robo_de_VehiculoApiConsumer , ICircunstancia_DefuncionApiConsumer Circunstancia_DefuncionApiConsumer , IConsecuencia_DefuncionApiConsumer Consecuencia_DefuncionApiConsumer , IZonaApiConsumer ZonaApiConsumer  , IDetalle_de_Persona_Moral_MPIApiConsumer Detalle_de_Persona_Moral_MPIApiConsumer  , IDialectoApiConsumer DialectoApiConsumer , IIdiomaApiConsumer IdiomaApiConsumer , IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer Detalle_de_Servicio_de_Apoyo_MPIApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , ISolicitante_MPIApiConsumer Solicitante_MPIApiConsumer  , IDetalle_de_Datos_del_Testigo_MPIApiConsumer Detalle_de_Datos_del_Testigo_MPIApiConsumer  , IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer Detalle_de_Agente_del_Ministerio_PublicoApiConsumer  , ITipo_de_OficioApiConsumer Tipo_de_OficioApiConsumer , IDelegacionApiConsumer DelegacionApiConsumer , IAgenciaApiConsumer AgenciaApiConsumer , IDetalle_de_Servicios_PericialesApiConsumer Detalle_de_Servicios_PericialesApiConsumer , IServicios_PericialesApiConsumer Servicios_PericialesApiConsumer , IEstatus_del_DictamenApiConsumer Estatus_del_DictamenApiConsumer , IRol_de_DiligenciaApiConsumer Rol_de_DiligenciaApiConsumer  , IDetalle_de_Oficio_de_Servicio_PericialApiConsumer Detalle_de_Oficio_de_Servicio_PericialApiConsumer , ITipo_de_OficiosApiConsumer Tipo_de_OficiosApiConsumer  , IDetalle_de_IPH_MPIApiConsumer Detalle_de_IPH_MPIApiConsumer  , IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer Detalle_de_Solicitante_en_Audiencias_MPIApiConsumer  , IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer Detalle_de_Requerido_en_Audiencias_MPIApiConsumer , IRequerido_MPIApiConsumer Requerido_MPIApiConsumer  , IDetalle_de_Citatorio_AudienciasApiConsumer Detalle_de_Citatorio_AudienciasApiConsumer  , IDetalle_de_Documentos_MPIApiConsumer Detalle_de_Documentos_MPIApiConsumer  , IDetalle_de_Coincidencias_MPIApiConsumer Detalle_de_Coincidencias_MPIApiConsumer  , IDetalle_de_IndiciosApiConsumer Detalle_de_IndiciosApiConsumer , IEstatus_de_IndicioApiConsumer Estatus_de_IndicioApiConsumer  , IEstatus_de_Expediente_InicialApiConsumer Estatus_de_Expediente_InicialApiConsumer , IEstatus_OrientadorApiConsumer Estatus_OrientadorApiConsumer , IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer Detalle_Bitacora_de_Canalizacion_MPIApiConsumer  , IDelito_Principal_MPIApiConsumer Delito_Principal_MPIApiConsumer , ITipo_de_AcuerdoApiConsumer Tipo_de_AcuerdoApiConsumer , IPeriodicidadApiConsumer PeriodicidadApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IExpediente_InicialApiConsumer = Expediente_InicialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ICatalogo_Estatus_Detenido_MPIApiConsumer = Catalogo_Estatus_Detenido_MPIApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._IDetalle_de_Datos_de_la_Victima_MPIApiConsumer = Detalle_de_Datos_de_la_Victima_MPIApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IDetalle_del_Abogado_Victima_MPIApiConsumer = Detalle_del_Abogado_Victima_MPIApiConsumer;

            this._IAbogadoApiConsumer = AbogadoApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;


            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IDetalle_de_Datos_del_Imputado_MPIApiConsumer = Detalle_de_Datos_del_Imputado_MPIApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IForma_CaraApiConsumer = Forma_CaraApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
            this._ICantidad_CabelloApiConsumer = Cantidad_CabelloApiConsumer;
            this._IImplantacion_CabelloApiConsumer = Implantacion_CabelloApiConsumer;
            this._IComplexionApiConsumer = ComplexionApiConsumer;
            this._IColor_PielApiConsumer = Color_PielApiConsumer;
            this._IFrenteApiConsumer = FrenteApiConsumer;
            this._IForma_CabelloApiConsumer = Forma_CabelloApiConsumer;
            this._ICalvicieApiConsumer = CalvicieApiConsumer;
            this._IColor_OjosApiConsumer = Color_OjosApiConsumer;
            this._IOjosApiConsumer = OjosApiConsumer;
            this._IFroma_OjosApiConsumer = Froma_OjosApiConsumer;
            this._INariz_BaseApiConsumer = Nariz_BaseApiConsumer;
            this._ILabiosApiConsumer = LabiosApiConsumer;
            this._IBocaApiConsumer = BocaApiConsumer;
            this._IMentonApiConsumer = MentonApiConsumer;
            this._IBarbaApiConsumer = BarbaApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._ITipo_LobuloApiConsumer = Tipo_LobuloApiConsumer;
            this._IBigoteApiConsumer = BigoteApiConsumer;
            this._ISituacion_FisicaApiConsumer = Situacion_FisicaApiConsumer;




            this._ICatalogo_Estatus_Detenido_MPIApiConsumer = Catalogo_Estatus_Detenido_MPIApiConsumer;


            this._IMedidas_CautelaresApiConsumer = Medidas_CautelaresApiConsumer;

            this._IMedidas_CautelaresApiConsumer = Medidas_CautelaresApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;


            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IDetalle_del_Abogado_Imputado_MPIApiConsumer = Detalle_del_Abogado_Imputado_MPIApiConsumer;

            this._IAbogadoApiConsumer = AbogadoApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;




            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IDetalle_de_Sentencias_Imputado_MPIApiConsumer = Detalle_de_Sentencias_Imputado_MPIApiConsumer;

            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ISentenciaApiConsumer = SentenciaApiConsumer;




            this._IEstatus_del_ImputadoApiConsumer = Estatus_del_ImputadoApiConsumer;


            this._IDetalle_Datos_de_Delito_MPIApiConsumer = Detalle_Datos_de_Delito_MPIApiConsumer;

            this._ITipo_DelitoApiConsumer = Tipo_DelitoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ICircunstancia_del_DelitoApiConsumer = Circunstancia_del_DelitoApiConsumer;

            this._IForma_Comision_DelitoApiConsumer = Forma_Comision_DelitoApiConsumer;
            this._IForma_Accion_DelitoApiConsumer = Forma_Accion_DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;
            this._IElementos_Comision_DelitoApiConsumer = Elementos_Comision_DelitoApiConsumer;




            this._ICircunstancia_VehiculoApiConsumer = Circunstancia_VehiculoApiConsumer;
            this._IEspecifica_VehiculoApiConsumer = Especifica_VehiculoApiConsumer;

            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;

            this._IAseguradora_de_VehiculoApiConsumer = Aseguradora_de_VehiculoApiConsumer;
            this._IServicio_del_VehiculoApiConsumer = Servicio_del_VehiculoApiConsumer;
            this._IProcedencia_del_VehiculoApiConsumer = Procedencia_del_VehiculoApiConsumer;


            this._IModalidad_de_Robo_de_VehiculoApiConsumer = Modalidad_de_Robo_de_VehiculoApiConsumer;
            this._ICircunstancia_DefuncionApiConsumer = Circunstancia_DefuncionApiConsumer;
            this._IConsecuencia_DefuncionApiConsumer = Consecuencia_DefuncionApiConsumer;


            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IDetalle_de_Persona_Moral_MPIApiConsumer = Detalle_de_Persona_Moral_MPIApiConsumer;

            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

            this._IDialectoApiConsumer = DialectoApiConsumer;
            this._IIdiomaApiConsumer = IdiomaApiConsumer;
            this._IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer = Detalle_de_Servicio_de_Apoyo_MPIApiConsumer;

            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._ISolicitante_MPIApiConsumer = Solicitante_MPIApiConsumer;

            this._IDetalle_de_Datos_del_Testigo_MPIApiConsumer = Detalle_de_Datos_del_Testigo_MPIApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;


            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;


            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer = Detalle_de_Agente_del_Ministerio_PublicoApiConsumer;


            this._ITipo_de_OficioApiConsumer = Tipo_de_OficioApiConsumer;
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._IAgenciaApiConsumer = AgenciaApiConsumer;
            this._IDetalle_de_Servicios_PericialesApiConsumer = Detalle_de_Servicios_PericialesApiConsumer;

            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;
            this._IEstatus_del_DictamenApiConsumer = Estatus_del_DictamenApiConsumer;

            this._IRol_de_DiligenciaApiConsumer = Rol_de_DiligenciaApiConsumer;

            this._IDetalle_de_Oficio_de_Servicio_PericialApiConsumer = Detalle_de_Oficio_de_Servicio_PericialApiConsumer;

            this._ITipo_de_OficiosApiConsumer = Tipo_de_OficiosApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;

            this._IDetalle_de_IPH_MPIApiConsumer = Detalle_de_IPH_MPIApiConsumer;




            this._ITipo_de_OficioApiConsumer = Tipo_de_OficioApiConsumer;
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer = Detalle_de_Solicitante_en_Audiencias_MPIApiConsumer;

            this._ISolicitante_MPIApiConsumer = Solicitante_MPIApiConsumer;

            this._IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer = Detalle_de_Requerido_en_Audiencias_MPIApiConsumer;

            this._IRequerido_MPIApiConsumer = Requerido_MPIApiConsumer;

            this._IDetalle_de_Citatorio_AudienciasApiConsumer = Detalle_de_Citatorio_AudienciasApiConsumer;






            this._IDetalle_de_Documentos_MPIApiConsumer = Detalle_de_Documentos_MPIApiConsumer;



            this._IDetalle_de_Coincidencias_MPIApiConsumer = Detalle_de_Coincidencias_MPIApiConsumer;


            this._IDetalle_de_IndiciosApiConsumer = Detalle_de_IndiciosApiConsumer;

            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;
            this._IEstatus_de_IndicioApiConsumer = Estatus_de_IndicioApiConsumer;

            this._IEstatus_de_Expediente_InicialApiConsumer = Estatus_de_Expediente_InicialApiConsumer;
            this._IEstatus_OrientadorApiConsumer = Estatus_OrientadorApiConsumer;
            this._IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer = Detalle_Bitacora_de_Canalizacion_MPIApiConsumer;



            this._IEstatus_de_Expediente_InicialApiConsumer = Estatus_de_Expediente_InicialApiConsumer;
            this._IEstatus_OrientadorApiConsumer = Estatus_OrientadorApiConsumer;

            this._IDelito_Principal_MPIApiConsumer = Delito_Principal_MPIApiConsumer;
            this._ITipo_de_AcuerdoApiConsumer = Tipo_de_AcuerdoApiConsumer;
            this._IPeriodicidadApiConsumer = PeriodicidadApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Expediente_Inicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45119, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index(int ModuleId=0)
        {
			if (Session["AdvanceReportFilter"] != null)
            {
                Session["AdvanceReportFilter"] = null;
                Session["AdvanceSearch"] = null;
            }
			if (ModuleId == 0)
            {
                ModuleId = Convert.ToInt32(Session["CurrentModuleId"]);
                if (ModuleId == 0)
                {
                    Response.Redirect("~/");
                }
            }
            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45119, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Expediente_Inicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45119, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45119, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varExpediente_Inicial = new Expediente_InicialModel();
			varExpediente_Inicial.Clave = Id;
			
            ViewBag.ObjectId = "45119";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Datos_de_la_Victima_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45120, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_de_la_Victima_MPI = permissionDetalle_de_Datos_de_la_Victima_MPI;
            var permissionDetalle_de_Datos_del_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45123, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Imputado_MPI = permissionDetalle_de_Datos_del_Imputado_MPI;
            var permissionDetalle_Datos_de_Delito_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45118, ModuleId);
            ViewBag.PermissionDetalle_Datos_de_Delito_MPI = permissionDetalle_Datos_de_Delito_MPI;
            var permissionDetalle_de_Persona_Moral_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45121, ModuleId);
            ViewBag.PermissionDetalle_de_Persona_Moral_MPI = permissionDetalle_de_Persona_Moral_MPI;
            var permissionDetalle_de_Servicio_de_Apoyo_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45122, ModuleId);
            ViewBag.PermissionDetalle_de_Servicio_de_Apoyo_MPI = permissionDetalle_de_Servicio_de_Apoyo_MPI;
            var permissionDetalle_de_Datos_del_Testigo_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45130, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Testigo_MPI = permissionDetalle_de_Datos_del_Testigo_MPI;
            var permissionDetalle_de_Agente_del_Ministerio_Publico = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45155, ModuleId);
            ViewBag.PermissionDetalle_de_Agente_del_Ministerio_Publico = permissionDetalle_de_Agente_del_Ministerio_Publico;
            var permissionDetalle_de_Servicios_Periciales = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45157, ModuleId);
            ViewBag.PermissionDetalle_de_Servicios_Periciales = permissionDetalle_de_Servicios_Periciales;
            var permissionDetalle_de_Oficio_de_Servicio_Pericial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45160, ModuleId);
            ViewBag.PermissionDetalle_de_Oficio_de_Servicio_Pericial = permissionDetalle_de_Oficio_de_Servicio_Pericial;
            var permissionDetalle_de_IPH_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45162, ModuleId);
            ViewBag.PermissionDetalle_de_IPH_MPI = permissionDetalle_de_IPH_MPI;
            var permissionDetalle_de_Solicitante_en_Audiencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45166, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Audiencias_MPI = permissionDetalle_de_Solicitante_en_Audiencias_MPI;
            var permissionDetalle_de_Requerido_en_Audiencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45167, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Audiencias_MPI = permissionDetalle_de_Requerido_en_Audiencias_MPI;
            var permissionDetalle_de_Citatorio_Audiencias = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45168, ModuleId);
            ViewBag.PermissionDetalle_de_Citatorio_Audiencias = permissionDetalle_de_Citatorio_Audiencias;
            var permissionDetalle_de_Documentos_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45163, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_MPI = permissionDetalle_de_Documentos_MPI;
            var permissionDetalle_de_Coincidencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45169, ModuleId);
            ViewBag.PermissionDetalle_de_Coincidencias_MPI = permissionDetalle_de_Coincidencias_MPI;
            var permissionDetalle_de_Indicios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45172, ModuleId);
            ViewBag.PermissionDetalle_de_Indicios = permissionDetalle_de_Indicios;
            var permissionDetalle_Bitacora_de_Canalizacion_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45177, ModuleId);
            ViewBag.PermissionDetalle_Bitacora_de_Canalizacion_MPI = permissionDetalle_Bitacora_de_Canalizacion_MPI;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Expediente_InicialsData = _IExpediente_InicialApiConsumer.ListaSelAll(0, 1000, "Expediente_Inicial.Clave=" + Id, "").Resource.Expediente_Inicials;
				
				if (Expediente_InicialsData != null && Expediente_InicialsData.Count > 0)
                {
					var Expediente_InicialData = Expediente_InicialsData.First();
					varExpediente_Inicial= new Expediente_InicialModel
					{
						Clave  = Expediente_InicialData.Clave 
	                    ,Fecha_de_Registro = (Expediente_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Expediente_InicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Expediente_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Expediente_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Detenido = Expediente_InicialData.Detenido
                    ,DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Detenido), "Catalogo_Estatus_Detenido_MPI") ??  (string)Expediente_InicialData.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                    ,NUC = Expediente_InicialData.NUC
                    ,NIC = Expediente_InicialData.NIC
                    ,Hora_del_Detenido = Expediente_InicialData.Hora_del_Detenido
                    ,Hora_Puesto_a_Disposicion = Expediente_InicialData.Hora_Puesto_a_Disposicion
                    ,Solicitar_Servicos_de_Apoyo = Expediente_InicialData.Solicitar_Servicos_de_Apoyo
                    ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Solicitar_Servicos_de_Apoyo), "Modulo_Atencion_Inicial") ??  (string)Expediente_InicialData.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
                    ,Narrativa_Breve_de_los_Hechos = Expediente_InicialData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Expediente_InicialData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Expediente_InicialData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Turno = Expediente_InicialData.Turno
                    ,Fecha_del_Hecho = (Expediente_InicialData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Hecho = Expediente_InicialData.Hora_del_Hecho
                    ,Pais_de_los_Hechos_MPI = Expediente_InicialData.Pais_de_los_Hechos_MPI
                    ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Pais_de_los_Hechos_MPI), "Pais") ??  (string)Expediente_InicialData.Pais_de_los_Hechos_MPI_Pais.Nombre
                    ,Estado_de_los_Hechos_MPI = Expediente_InicialData.Estado_de_los_Hechos_MPI
                    ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Estado_de_los_Hechos_MPI), "Estado") ??  (string)Expediente_InicialData.Estado_de_los_Hechos_MPI_Estado.Nombre
                    ,Municipio_de_los_Hechos_MPI = Expediente_InicialData.Municipio_de_los_Hechos_MPI
                    ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Municipio_de_los_Hechos_MPI), "Municipio") ??  (string)Expediente_InicialData.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                    ,Colonia_de_los_Hechos_MPI = Expediente_InicialData.Colonia_de_los_Hechos_MPI
                    ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Colonia_de_los_Hechos_MPI), "Colonia") ??  (string)Expediente_InicialData.Colonia_de_los_Hechos_MPI_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos_MPI = Expediente_InicialData.Codigo_Postal_de_los_Hechos_MPI
                    ,Calle_de_los_Hechos_MPI = Expediente_InicialData.Calle_de_los_Hechos_MPI
                    ,Entre_Calle_MPI = Expediente_InicialData.Entre_Calle_MPI
                    ,Y_Calle_MPI = Expediente_InicialData.Y_Calle_MPI
                    ,Numero_Exrterior_de_los_Hechos_MPI = Expediente_InicialData.Numero_Exrterior_de_los_Hechos_MPI
                    ,Numero_Interior_de_los_Hechos_MPI = Expediente_InicialData.Numero_Interior_de_los_Hechos_MPI
                    ,Latitud_MPI = Expediente_InicialData.Latitud_MPI
                    ,Longitud_MPI = Expediente_InicialData.Longitud_MPI
                    ,Tipo_de_Lugar_del_Hecho_MPI = Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI
                    ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI), "Lugar_Tipo") ??  (string)Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
                    ,Persona_Moral = Expediente_InicialData.Persona_Moral.GetValueOrDefault()
                    ,Requiere_Diligencia = Expediente_InicialData.Requiere_Diligencia.GetValueOrDefault()
                    ,Numero_de_Expediente_Victima = Expediente_InicialData.Numero_de_Expediente_Victima
                    ,Requiere_Traductor = Expediente_InicialData.Requiere_Traductor.GetValueOrDefault()
                    ,Lengua_Originaria = Expediente_InicialData.Lengua_Originaria
                    ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Lengua_Originaria), "Dialecto") ??  (string)Expediente_InicialData.Lengua_Originaria_Dialecto.Descripcion
                    ,Idioma = Expediente_InicialData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Idioma), "Idioma") ??  (string)Expediente_InicialData.Idioma_Idioma.Descripcion
                    ,Titulo_del_Hecho = Expediente_InicialData.Titulo_del_Hecho
                    ,Asignar_Agente_del_Ministerio_Publico = Expediente_InicialData.Asignar_Agente_del_Ministerio_Publico.GetValueOrDefault()
                    ,Nombre_de_Agente_del_Ministerio_Publico = Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico
                    ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico), "Spartan_User") ??  (string)Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                    ,Tipo_de_Oficio = Expediente_InicialData.Tipo_de_Oficio
                    ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Oficio), "Tipo_de_Oficio") ??  (string)Expediente_InicialData.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                    ,Delegacion = Expediente_InicialData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delegacion), "Delegacion") ??  (string)Expediente_InicialData.Delegacion_Delegacion.Descripcion
                    ,Agencia = Expediente_InicialData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Agencia), "Agencia") ??  (string)Expediente_InicialData.Agencia_Agencia.Descripcion
                    ,Solicitar_Diligencias = Expediente_InicialData.Solicitar_Diligencias.GetValueOrDefault()
                    ,NUC_Audiencias = Expediente_InicialData.NUC_Audiencias
                    ,NIC_Audiencias = Expediente_InicialData.NIC_Audiencias
                    ,Fecha_de_Registro_Audiencias = (Expediente_InicialData.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro_Audiencias = Expediente_InicialData.Hora_de_Registro_Audiencias
                    ,Tipo_de_Oficio_Audiencias = Expediente_InicialData.Tipo_de_Oficio_Audiencias
                    ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Oficio_Audiencias), "Tipo_de_Oficio") ??  (string)Expediente_InicialData.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                    ,Delegacion_Audiencias = Expediente_InicialData.Delegacion_Audiencias
                    ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delegacion_Audiencias), "Delegacion") ??  (string)Expediente_InicialData.Delegacion_Audiencias_Delegacion.Descripcion
                    ,Domicilio_Delegacion_A = Expediente_InicialData.Domicilio_Delegacion_A
                    ,Numero_de_Expediente = Expediente_InicialData.Numero_de_Expediente
                    ,NUAT = Expediente_InicialData.NUAT
                    ,Fecha_de_RegistroI = (Expediente_InicialData.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_RegistroI = Expediente_InicialData.Hora_de_RegistroI
                    ,Estatus = Expediente_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Estatus), "Estatus_de_Expediente_Inicial") ??  (string)Expediente_InicialData.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                    ,Canalizar_a = Expediente_InicialData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Canalizar_a), "Estatus_Orientador") ??  (string)Expediente_InicialData.Canalizar_a_Estatus_Orientador.Descripcion
                    ,Delito_Principal = Expediente_InicialData.Delito_Principal
                    ,Delito_PrincipalDelito = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delito_Principal), "Delito_Principal_MPI") ??  (string)Expediente_InicialData.Delito_Principal_Delito_Principal_MPI.Delito
                    ,Tipo_de_Acuerdo = Expediente_InicialData.Tipo_de_Acuerdo
                    ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Acuerdo), "Tipo_de_Acuerdo") ??  (string)Expediente_InicialData.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,Fecha_de_Inicio_de_Acuerdo = (Expediente_InicialData.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Cumplimiento = (Expediente_InicialData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cumplimiento = Expediente_InicialData.Hora_de_Cumplimiento
                    ,Domicilio_para_el_Cumplimiento = Expediente_InicialData.Domicilio_para_el_Cumplimiento
                    ,Monto_de_Reparacion_de_Danos = Expediente_InicialData.Monto_de_Reparacion_de_Danos
                    ,Parcialidades = Expediente_InicialData.Parcialidades
                    ,Periodicidad = Expediente_InicialData.Periodicidad
                    ,PeriodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Periodicidad), "Periodicidad") ??  (string)Expediente_InicialData.Periodicidad_Periodicidad.Descripcion
                    ,Acepta_Acuerdo = Expediente_InicialData.Acepta_Acuerdo.GetValueOrDefault()
                    ,Motivo_de_Rechazo_de_Acuerdo = Expediente_InicialData.Motivo_de_Rechazo_de_Acuerdo

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Detenido = Catalogo_Estatus_Detenido_MPIs_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo != null && Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource.Where(m => m.Folio != null).OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio") ?? m.Folio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos_MPI = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos_MPI != null && Paiss_Pais_de_los_Hechos_MPI.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos_MPI = Paiss_Pais_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos_MPI = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos_MPI != null && Estados_Estado_de_los_Hechos_MPI.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos_MPI = Estados_Estado_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos_MPI = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos_MPI != null && Municipios_Municipio_de_los_Hechos_MPI.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos_MPI = Municipios_Municipio_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos_MPI = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos_MPI != null && Colonias_Colonia_de_los_Hechos_MPI.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos_MPI = Colonias_Colonia_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico != null && Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource != null)
                ViewBag.Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio != null && Tipo_de_Oficios_Tipo_de_Oficio.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio = Tipo_de_Oficios_Tipo_de_Oficio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio_Audiencias != null && Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion_Audiencias = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion_Audiencias != null && Delegacions_Delegacion_Audiencias.Resource != null)
                ViewBag.Delegacions_Delegacion_Audiencias = Delegacions_Delegacion_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus != null && Estatus_de_Expediente_Inicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus = Estatus_de_Expediente_Inicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelito_Principal_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delito_Principal_MPIs_Delito_Principal = _IDelito_Principal_MPIApiConsumer.SelAll(true);
            if (Delito_Principal_MPIs_Delito_Principal != null && Delito_Principal_MPIs_Delito_Principal.Resource != null)
                ViewBag.Delito_Principal_MPIs_Delito_Principal = Delito_Principal_MPIs_Delito_Principal.Resource.Where(m => m.Delito != null).OrderBy(m => m.Delito).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito_Principal_MPI", "Delito") ?? m.Delito.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
				
			var viewInEframe = false;
			var isPartial = false;
            var isMR = false;
            var nameMR = string.Empty;
            var nameAttribute = string.Empty;

	        if (Request.QueryString["isPartial"]!= null)
                isPartial = Convert.ToBoolean(Request.QueryString["isPartial"]);

            if (Request.QueryString["isMR"] != null)
                isMR = Convert.ToBoolean(Request.QueryString["isMR"]);

            if (Request.QueryString["nameMR"] != null)
                nameMR = Request.QueryString["nameMR"].ToString();

            if (Request.QueryString["nameAttribute"] != null)
                nameAttribute = Request.QueryString["nameAttribute"].ToString();
				
			if (Request.QueryString["viewInEframe"] != null)
                viewInEframe = Convert.ToBoolean(Request.QueryString["viewInEframe"]);	
				
			ViewBag.isPartial=isPartial;
			ViewBag.isMR=isMR;
			ViewBag.nameMR=nameMR;
			ViewBag.nameAttribute=nameAttribute;
			ViewBag.viewInEframe = viewInEframe;

				
            return View(varExpediente_Inicial);
        }
		
	[HttpGet]
        public ActionResult AddExpediente_Inicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45119);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Expediente_InicialModel varExpediente_Inicial= new Expediente_InicialModel();
            var permissionDetalle_de_Datos_de_la_Victima_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45120, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_de_la_Victima_MPI = permissionDetalle_de_Datos_de_la_Victima_MPI;
            var permissionDetalle_de_Datos_del_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45123, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Imputado_MPI = permissionDetalle_de_Datos_del_Imputado_MPI;
            var permissionDetalle_Datos_de_Delito_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45118, ModuleId);
            ViewBag.PermissionDetalle_Datos_de_Delito_MPI = permissionDetalle_Datos_de_Delito_MPI;
            var permissionDetalle_de_Persona_Moral_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45121, ModuleId);
            ViewBag.PermissionDetalle_de_Persona_Moral_MPI = permissionDetalle_de_Persona_Moral_MPI;
            var permissionDetalle_de_Servicio_de_Apoyo_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45122, ModuleId);
            ViewBag.PermissionDetalle_de_Servicio_de_Apoyo_MPI = permissionDetalle_de_Servicio_de_Apoyo_MPI;
            var permissionDetalle_de_Datos_del_Testigo_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45130, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Testigo_MPI = permissionDetalle_de_Datos_del_Testigo_MPI;
            var permissionDetalle_de_Agente_del_Ministerio_Publico = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45155, ModuleId);
            ViewBag.PermissionDetalle_de_Agente_del_Ministerio_Publico = permissionDetalle_de_Agente_del_Ministerio_Publico;
            var permissionDetalle_de_Servicios_Periciales = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45157, ModuleId);
            ViewBag.PermissionDetalle_de_Servicios_Periciales = permissionDetalle_de_Servicios_Periciales;
            var permissionDetalle_de_Oficio_de_Servicio_Pericial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45160, ModuleId);
            ViewBag.PermissionDetalle_de_Oficio_de_Servicio_Pericial = permissionDetalle_de_Oficio_de_Servicio_Pericial;
            var permissionDetalle_de_IPH_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45162, ModuleId);
            ViewBag.PermissionDetalle_de_IPH_MPI = permissionDetalle_de_IPH_MPI;
            var permissionDetalle_de_Solicitante_en_Audiencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45166, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitante_en_Audiencias_MPI = permissionDetalle_de_Solicitante_en_Audiencias_MPI;
            var permissionDetalle_de_Requerido_en_Audiencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45167, ModuleId);
            ViewBag.PermissionDetalle_de_Requerido_en_Audiencias_MPI = permissionDetalle_de_Requerido_en_Audiencias_MPI;
            var permissionDetalle_de_Citatorio_Audiencias = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45168, ModuleId);
            ViewBag.PermissionDetalle_de_Citatorio_Audiencias = permissionDetalle_de_Citatorio_Audiencias;
            var permissionDetalle_de_Documentos_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45163, ModuleId);
            ViewBag.PermissionDetalle_de_Documentos_MPI = permissionDetalle_de_Documentos_MPI;
            var permissionDetalle_de_Coincidencias_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45169, ModuleId);
            ViewBag.PermissionDetalle_de_Coincidencias_MPI = permissionDetalle_de_Coincidencias_MPI;
            var permissionDetalle_de_Indicios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45172, ModuleId);
            ViewBag.PermissionDetalle_de_Indicios = permissionDetalle_de_Indicios;
            var permissionDetalle_Bitacora_de_Canalizacion_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45177, ModuleId);
            ViewBag.PermissionDetalle_Bitacora_de_Canalizacion_MPI = permissionDetalle_Bitacora_de_Canalizacion_MPI;


            if (id.ToString() != "0")
            {
                var Expediente_InicialsData = _IExpediente_InicialApiConsumer.ListaSelAll(0, 1000, "Expediente_Inicial.Clave=" + id, "").Resource.Expediente_Inicials;
				
				if (Expediente_InicialsData != null && Expediente_InicialsData.Count > 0)
                {
					var Expediente_InicialData = Expediente_InicialsData.First();
					varExpediente_Inicial= new Expediente_InicialModel
					{
						Clave  = Expediente_InicialData.Clave 
	                    ,Fecha_de_Registro = (Expediente_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Expediente_InicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Expediente_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Expediente_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Detenido = Expediente_InicialData.Detenido
                    ,DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Detenido), "Catalogo_Estatus_Detenido_MPI") ??  (string)Expediente_InicialData.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                    ,NUC = Expediente_InicialData.NUC
                    ,NIC = Expediente_InicialData.NIC
                    ,Hora_del_Detenido = Expediente_InicialData.Hora_del_Detenido
                    ,Hora_Puesto_a_Disposicion = Expediente_InicialData.Hora_Puesto_a_Disposicion
                    ,Solicitar_Servicos_de_Apoyo = Expediente_InicialData.Solicitar_Servicos_de_Apoyo
                    ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Solicitar_Servicos_de_Apoyo), "Modulo_Atencion_Inicial") ??  (string)Expediente_InicialData.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
                    ,Narrativa_Breve_de_los_Hechos = Expediente_InicialData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Expediente_InicialData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Expediente_InicialData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Turno = Expediente_InicialData.Turno
                    ,Fecha_del_Hecho = (Expediente_InicialData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Hecho = Expediente_InicialData.Hora_del_Hecho
                    ,Pais_de_los_Hechos_MPI = Expediente_InicialData.Pais_de_los_Hechos_MPI
                    ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Pais_de_los_Hechos_MPI), "Pais") ??  (string)Expediente_InicialData.Pais_de_los_Hechos_MPI_Pais.Nombre
                    ,Estado_de_los_Hechos_MPI = Expediente_InicialData.Estado_de_los_Hechos_MPI
                    ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Estado_de_los_Hechos_MPI), "Estado") ??  (string)Expediente_InicialData.Estado_de_los_Hechos_MPI_Estado.Nombre
                    ,Municipio_de_los_Hechos_MPI = Expediente_InicialData.Municipio_de_los_Hechos_MPI
                    ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Municipio_de_los_Hechos_MPI), "Municipio") ??  (string)Expediente_InicialData.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                    ,Colonia_de_los_Hechos_MPI = Expediente_InicialData.Colonia_de_los_Hechos_MPI
                    ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Colonia_de_los_Hechos_MPI), "Colonia") ??  (string)Expediente_InicialData.Colonia_de_los_Hechos_MPI_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos_MPI = Expediente_InicialData.Codigo_Postal_de_los_Hechos_MPI
                    ,Calle_de_los_Hechos_MPI = Expediente_InicialData.Calle_de_los_Hechos_MPI
                    ,Entre_Calle_MPI = Expediente_InicialData.Entre_Calle_MPI
                    ,Y_Calle_MPI = Expediente_InicialData.Y_Calle_MPI
                    ,Numero_Exrterior_de_los_Hechos_MPI = Expediente_InicialData.Numero_Exrterior_de_los_Hechos_MPI
                    ,Numero_Interior_de_los_Hechos_MPI = Expediente_InicialData.Numero_Interior_de_los_Hechos_MPI
                    ,Latitud_MPI = Expediente_InicialData.Latitud_MPI
                    ,Longitud_MPI = Expediente_InicialData.Longitud_MPI
                    ,Tipo_de_Lugar_del_Hecho_MPI = Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI
                    ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI), "Lugar_Tipo") ??  (string)Expediente_InicialData.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
                    ,Persona_Moral = Expediente_InicialData.Persona_Moral.GetValueOrDefault()
                    ,Requiere_Diligencia = Expediente_InicialData.Requiere_Diligencia.GetValueOrDefault()
                    ,Numero_de_Expediente_Victima = Expediente_InicialData.Numero_de_Expediente_Victima
                    ,Requiere_Traductor = Expediente_InicialData.Requiere_Traductor.GetValueOrDefault()
                    ,Lengua_Originaria = Expediente_InicialData.Lengua_Originaria
                    ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Lengua_Originaria), "Dialecto") ??  (string)Expediente_InicialData.Lengua_Originaria_Dialecto.Descripcion
                    ,Idioma = Expediente_InicialData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Idioma), "Idioma") ??  (string)Expediente_InicialData.Idioma_Idioma.Descripcion
                    ,Titulo_del_Hecho = Expediente_InicialData.Titulo_del_Hecho
                    ,Asignar_Agente_del_Ministerio_Publico = Expediente_InicialData.Asignar_Agente_del_Ministerio_Publico.GetValueOrDefault()
                    ,Nombre_de_Agente_del_Ministerio_Publico = Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico
                    ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico), "Spartan_User") ??  (string)Expediente_InicialData.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                    ,Tipo_de_Oficio = Expediente_InicialData.Tipo_de_Oficio
                    ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Oficio), "Tipo_de_Oficio") ??  (string)Expediente_InicialData.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                    ,Delegacion = Expediente_InicialData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delegacion), "Delegacion") ??  (string)Expediente_InicialData.Delegacion_Delegacion.Descripcion
                    ,Agencia = Expediente_InicialData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Agencia), "Agencia") ??  (string)Expediente_InicialData.Agencia_Agencia.Descripcion
                    ,Solicitar_Diligencias = Expediente_InicialData.Solicitar_Diligencias.GetValueOrDefault()
                    ,NUC_Audiencias = Expediente_InicialData.NUC_Audiencias
                    ,NIC_Audiencias = Expediente_InicialData.NIC_Audiencias
                    ,Fecha_de_Registro_Audiencias = (Expediente_InicialData.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro_Audiencias = Expediente_InicialData.Hora_de_Registro_Audiencias
                    ,Tipo_de_Oficio_Audiencias = Expediente_InicialData.Tipo_de_Oficio_Audiencias
                    ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Oficio_Audiencias), "Tipo_de_Oficio") ??  (string)Expediente_InicialData.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                    ,Delegacion_Audiencias = Expediente_InicialData.Delegacion_Audiencias
                    ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delegacion_Audiencias), "Delegacion") ??  (string)Expediente_InicialData.Delegacion_Audiencias_Delegacion.Descripcion
                    ,Domicilio_Delegacion_A = Expediente_InicialData.Domicilio_Delegacion_A
                    ,Numero_de_Expediente = Expediente_InicialData.Numero_de_Expediente
                    ,NUAT = Expediente_InicialData.NUAT
                    ,Fecha_de_RegistroI = (Expediente_InicialData.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_RegistroI = Expediente_InicialData.Hora_de_RegistroI
                    ,Estatus = Expediente_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Estatus), "Estatus_de_Expediente_Inicial") ??  (string)Expediente_InicialData.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                    ,Canalizar_a = Expediente_InicialData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Canalizar_a), "Estatus_Orientador") ??  (string)Expediente_InicialData.Canalizar_a_Estatus_Orientador.Descripcion
                    ,Delito_Principal = Expediente_InicialData.Delito_Principal
                    ,Delito_PrincipalDelito = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Delito_Principal), "Delito_Principal_MPI") ??  (string)Expediente_InicialData.Delito_Principal_Delito_Principal_MPI.Delito
                    ,Tipo_de_Acuerdo = Expediente_InicialData.Tipo_de_Acuerdo
                    ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Tipo_de_Acuerdo), "Tipo_de_Acuerdo") ??  (string)Expediente_InicialData.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,Fecha_de_Inicio_de_Acuerdo = (Expediente_InicialData.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Cumplimiento = (Expediente_InicialData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Expediente_InicialData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cumplimiento = Expediente_InicialData.Hora_de_Cumplimiento
                    ,Domicilio_para_el_Cumplimiento = Expediente_InicialData.Domicilio_para_el_Cumplimiento
                    ,Monto_de_Reparacion_de_Danos = Expediente_InicialData.Monto_de_Reparacion_de_Danos
                    ,Parcialidades = Expediente_InicialData.Parcialidades
                    ,Periodicidad = Expediente_InicialData.Periodicidad
                    ,PeriodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Expediente_InicialData.Periodicidad), "Periodicidad") ??  (string)Expediente_InicialData.Periodicidad_Periodicidad.Descripcion
                    ,Acepta_Acuerdo = Expediente_InicialData.Acepta_Acuerdo.GetValueOrDefault()
                    ,Motivo_de_Rechazo_de_Acuerdo = Expediente_InicialData.Motivo_de_Rechazo_de_Acuerdo

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Detenido = Catalogo_Estatus_Detenido_MPIs_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo != null && Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource.Where(m => m.Folio != null).OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio") ?? m.Folio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos_MPI = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos_MPI != null && Paiss_Pais_de_los_Hechos_MPI.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos_MPI = Paiss_Pais_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos_MPI = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos_MPI != null && Estados_Estado_de_los_Hechos_MPI.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos_MPI = Estados_Estado_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos_MPI = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos_MPI != null && Municipios_Municipio_de_los_Hechos_MPI.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos_MPI = Municipios_Municipio_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos_MPI = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos_MPI != null && Colonias_Colonia_de_los_Hechos_MPI.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos_MPI = Colonias_Colonia_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico != null && Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource != null)
                ViewBag.Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio != null && Tipo_de_Oficios_Tipo_de_Oficio.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio = Tipo_de_Oficios_Tipo_de_Oficio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio_Audiencias != null && Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion_Audiencias = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion_Audiencias != null && Delegacions_Delegacion_Audiencias.Resource != null)
                ViewBag.Delegacions_Delegacion_Audiencias = Delegacions_Delegacion_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus != null && Estatus_de_Expediente_Inicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus = Estatus_de_Expediente_Inicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelito_Principal_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delito_Principal_MPIs_Delito_Principal = _IDelito_Principal_MPIApiConsumer.SelAll(true);
            if (Delito_Principal_MPIs_Delito_Principal != null && Delito_Principal_MPIs_Delito_Principal.Resource != null)
                ViewBag.Delito_Principal_MPIs_Delito_Principal = Delito_Principal_MPIs_Delito_Principal.Resource.Where(m => m.Delito != null).OrderBy(m => m.Delito).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito_Principal_MPI", "Delito") ?? m.Delito.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddExpediente_Inicial", varExpediente_Inicial);
        }


        [HttpGet]
        public FileResult GetFile(int id)
        {

            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var fileInfo = _ISpartane_FileApiConsumer.GetByKey(id).Resource;
            if (fileInfo == null)
                return null;
            return File(fileInfo.File, System.Net.Mime.MediaTypeNames.Application.Octet, fileInfo.Description);
        }

		[HttpGet]
        public ActionResult GetSpartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name")?? m.Name,
                    Value = Convert.ToString(m.Id_User)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Estatus_Detenido_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPrioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetEstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetMunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDialectoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDialectoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetIdiomaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIdiomaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_OficioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_OficioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelegacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelegacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAgenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAgenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.ClaveID)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_Expediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_OrientadorAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_OrientadorApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelito_Principal_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelito_Principal_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelito_Principal_MPIApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Delito).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito_Principal_MPI", "Delito")?? m.Delito,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_AcuerdoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AcuerdoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPeriodicidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPeriodicidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Expediente_InicialAdvanceSearchModel model, int idFilter = -1)
        {
            if (ModelState.IsValid)
            {
                Session["AdvanceSearch"] = model;
				if (idFilter != -1)
                {
                    Session["AdvanceReportFilter"] = GetAdvanceFilter(model);
                    return RedirectToAction("Index", "Report", new { id = idFilter });
                }
                return RedirectToAction("Index");
            }
            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},
            };
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Detenido = Catalogo_Estatus_Detenido_MPIs_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo != null && Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource.Where(m => m.Folio != null).OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio") ?? m.Folio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos_MPI = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos_MPI != null && Paiss_Pais_de_los_Hechos_MPI.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos_MPI = Paiss_Pais_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos_MPI = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos_MPI != null && Estados_Estado_de_los_Hechos_MPI.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos_MPI = Estados_Estado_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos_MPI = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos_MPI != null && Municipios_Municipio_de_los_Hechos_MPI.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos_MPI = Municipios_Municipio_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos_MPI = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos_MPI != null && Colonias_Colonia_de_los_Hechos_MPI.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos_MPI = Colonias_Colonia_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico != null && Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource != null)
                ViewBag.Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio != null && Tipo_de_Oficios_Tipo_de_Oficio.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio = Tipo_de_Oficios_Tipo_de_Oficio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio_Audiencias != null && Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion_Audiencias = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion_Audiencias != null && Delegacions_Delegacion_Audiencias.Resource != null)
                ViewBag.Delegacions_Delegacion_Audiencias = Delegacions_Delegacion_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus != null && Estatus_de_Expediente_Inicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus = Estatus_de_Expediente_Inicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelito_Principal_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delito_Principal_MPIs_Delito_Principal = _IDelito_Principal_MPIApiConsumer.SelAll(true);
            if (Delito_Principal_MPIs_Delito_Principal != null && Delito_Principal_MPIs_Delito_Principal.Resource != null)
                ViewBag.Delito_Principal_MPIs_Delito_Principal = Delito_Principal_MPIs_Delito_Principal.Resource.Where(m => m.Delito != null).OrderBy(m => m.Delito).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito_Principal_MPI", "Delito") ?? m.Delito.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Detenido = Catalogo_Estatus_Detenido_MPIs_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo != null && Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo = Modulo_Atencion_Inicials_Solicitar_Servicos_de_Apoyo.Resource.Where(m => m.Folio != null).OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "Folio") ?? m.Folio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos_MPI = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos_MPI != null && Paiss_Pais_de_los_Hechos_MPI.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos_MPI = Paiss_Pais_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos_MPI = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos_MPI != null && Estados_Estado_de_los_Hechos_MPI.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos_MPI = Estados_Estado_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos_MPI = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos_MPI != null && Municipios_Municipio_de_los_Hechos_MPI.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos_MPI = Municipios_Municipio_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos_MPI = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos_MPI != null && Colonias_Colonia_de_los_Hechos_MPI.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos_MPI = Colonias_Colonia_de_los_Hechos_MPI.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI = Lugar_Tipos_Tipo_de_Lugar_del_Hecho_MPI.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico != null && Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource != null)
                ViewBag.Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico = Spartan_Users_Nombre_de_Agente_del_Ministerio_Publico.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio != null && Tipo_de_Oficios_Tipo_de_Oficio.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio = Tipo_de_Oficios_Tipo_de_Oficio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();
            _ITipo_de_OficioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = _ITipo_de_OficioApiConsumer.SelAll(true);
            if (Tipo_de_Oficios_Tipo_de_Oficio_Audiencias != null && Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource != null)
                ViewBag.Tipo_de_Oficios_Tipo_de_Oficio_Audiencias = Tipo_de_Oficios_Tipo_de_Oficio_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Oficio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion_Audiencias = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion_Audiencias != null && Delegacions_Delegacion_Audiencias.Resource != null)
                ViewBag.Delegacions_Delegacion_Audiencias = Delegacions_Delegacion_Audiencias.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus != null && Estatus_de_Expediente_Inicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus = Estatus_de_Expediente_Inicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelito_Principal_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delito_Principal_MPIs_Delito_Principal = _IDelito_Principal_MPIApiConsumer.SelAll(true);
            if (Delito_Principal_MPIs_Delito_Principal != null && Delito_Principal_MPIs_Delito_Principal.Resource != null)
                ViewBag.Delito_Principal_MPIs_Delito_Principal = Delito_Principal_MPIs_Delito_Principal.Resource.Where(m => m.Delito != null).OrderBy(m => m.Delito).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito_Principal_MPI", "Delito") ?? m.Delito.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_Tipo_de_Acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_Tipo_de_Acuerdo != null && Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_Tipo_de_Acuerdo = Tipo_de_Acuerdos_Tipo_de_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_Periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_Periodicidad != null && Periodicidads_Periodicidad.Resource != null)
                ViewBag.Periodicidads_Periodicidad = Periodicidads_Periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Expediente_InicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Expediente_InicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Expediente_InicialAdvanceSearchModel());
            }

            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},

            };

            return View(previousFiltersObj);
        }

        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Expediente_InicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IExpediente_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Expediente_Inicials == null)
                result.Expediente_Inicials = new List<Expediente_Inicial>();

            return Json(new
            {
                data = result.Expediente_Inicials.Select(m => new Expediente_InicialGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,DetenidoDescripcion = CultureHelper.GetTraduction(m.Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,NUC = m.NUC
			,NIC = m.NIC
			,Hora_del_Detenido = m.Hora_del_Detenido
			,Hora_Puesto_a_Disposicion = m.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Clave.ToString(), "Folio") ?? (string)m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Turno = m.Turno
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_MPI_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_MPI_Pais.Nombre
                        ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_MPI_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_MPI_Estado.Nombre
                        ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_MPI_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                        ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_MPI_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_MPI_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos_MPI = m.Codigo_Postal_de_los_Hechos_MPI
			,Calle_de_los_Hechos_MPI = m.Calle_de_los_Hechos_MPI
			,Entre_Calle_MPI = m.Entre_Calle_MPI
			,Y_Calle_MPI = m.Y_Calle_MPI
			,Numero_Exrterior_de_los_Hechos_MPI = m.Numero_Exrterior_de_los_Hechos_MPI
			,Numero_Interior_de_los_Hechos_MPI = m.Numero_Interior_de_los_Hechos_MPI
			,Latitud_MPI = m.Latitud_MPI
			,Longitud_MPI = m.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Requiere_Diligencia = m.Requiere_Diligencia
			,Numero_de_Expediente_Victima = m.Numero_de_Expediente_Victima
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Asignar_Agente_del_Ministerio_Publico = m.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                        ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Solicitar_Diligencias = m.Solicitar_Diligencias
			,NUC_Audiencias = m.NUC_Audiencias
			,NIC_Audiencias = m.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (m.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro_Audiencias = m.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                        ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(m.Delegacion_Audiencias_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Audiencias_Delegacion.Descripcion
			,Domicilio_Delegacion_A = m.Domicilio_Delegacion_A
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
                        ,Fecha_de_RegistroI = (m.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_RegistroI = m.Hora_de_RegistroI
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,Delito_PrincipalDelito = CultureHelper.GetTraduction(m.Delito_Principal_Delito_Principal_MPI.Clave.ToString(), "Delito") ?? (string)m.Delito_Principal_Delito_Principal_MPI.Delito
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cumplimiento = m.Hora_de_Cumplimiento
			,Domicilio_para_el_Cumplimiento = m.Domicilio_para_el_Cumplimiento
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Acepta_Acuerdo = m.Acepta_Acuerdo
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetExpediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IExpediente_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Expediente_Inicial", m.),
                     Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Expediente_Inicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Expediente_Inicial Entity</returns>
        public ActionResult GetExpediente_InicialList(UrlParametersModel param)
        {
			 int sEcho = param.sEcho;
            int iDisplayStart = param.iDisplayStart;
            int iDisplayLength = param.iDisplayLength;
            string where = param.where;
            string order = param.order;

            where = HttpUtility.UrlEncode(where);
            int sortColumn = -1;
            string sortDirection = "asc";
            if (iDisplayLength == -1)
            {
                //length = TOTAL_ROWS;
                iDisplayLength = Int32.MaxValue;
            }
            // note: we only sort one column at a time
            if (param.sortColumn != null)
            {
                sortColumn = int.Parse(param.sortColumn);
            }
            if (param.sortDirection != null)
            {
                sortDirection = param.sortDirection;
            }


            if (!_tokenManager.GenerateToken())
                return null;
            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Expediente_InicialPropertyMapper());
				
			if (!String.IsNullOrEmpty(where))
            {
                 configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (param.AdvanceSearch != null && param.AdvanceSearch == true && Session["AdvanceSearch"] != null)            
            {
				if (Session["AdvanceSearch"].GetType() == typeof(Expediente_InicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Expediente_InicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Expediente_InicialPropertyMapper oExpediente_InicialPropertyMapper = new Expediente_InicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oExpediente_InicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IExpediente_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Expediente_Inicials == null)
                result.Expediente_Inicials = new List<Expediente_Inicial>();

            return Json(new
            {
                aaData = result.Expediente_Inicials.Select(m => new Expediente_InicialGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,DetenidoDescripcion = CultureHelper.GetTraduction(m.Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,NUC = m.NUC
			,NIC = m.NIC
			,Hora_del_Detenido = m.Hora_del_Detenido
			,Hora_Puesto_a_Disposicion = m.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Clave.ToString(), "Folio") ?? (string)m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Turno = m.Turno
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_MPI_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_MPI_Pais.Nombre
                        ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_MPI_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_MPI_Estado.Nombre
                        ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_MPI_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                        ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_MPI_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_MPI_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos_MPI = m.Codigo_Postal_de_los_Hechos_MPI
			,Calle_de_los_Hechos_MPI = m.Calle_de_los_Hechos_MPI
			,Entre_Calle_MPI = m.Entre_Calle_MPI
			,Y_Calle_MPI = m.Y_Calle_MPI
			,Numero_Exrterior_de_los_Hechos_MPI = m.Numero_Exrterior_de_los_Hechos_MPI
			,Numero_Interior_de_los_Hechos_MPI = m.Numero_Interior_de_los_Hechos_MPI
			,Latitud_MPI = m.Latitud_MPI
			,Longitud_MPI = m.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Requiere_Diligencia = m.Requiere_Diligencia
			,Numero_de_Expediente_Victima = m.Numero_de_Expediente_Victima
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Asignar_Agente_del_Ministerio_Publico = m.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                        ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Solicitar_Diligencias = m.Solicitar_Diligencias
			,NUC_Audiencias = m.NUC_Audiencias
			,NIC_Audiencias = m.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (m.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro_Audiencias = m.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                        ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(m.Delegacion_Audiencias_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Audiencias_Delegacion.Descripcion
			,Domicilio_Delegacion_A = m.Domicilio_Delegacion_A
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
                        ,Fecha_de_RegistroI = (m.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_RegistroI = m.Hora_de_RegistroI
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,Delito_PrincipalDelito = CultureHelper.GetTraduction(m.Delito_Principal_Delito_Principal_MPI.Clave.ToString(), "Delito") ?? (string)m.Delito_Principal_Delito_Principal_MPI.Delito
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cumplimiento = m.Hora_de_Cumplimiento
			,Domicilio_para_el_Cumplimiento = m.Domicilio_para_el_Cumplimiento
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Acepta_Acuerdo = m.Acepta_Acuerdo
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetExpediente_Inicial_Usuario_que_Registra_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetExpediente_Inicial_Pais_de_los_Hechos_MPI_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetExpediente_Inicial_Estado_de_los_Hechos_MPI_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetExpediente_Inicial_Municipio_de_los_Hechos_MPI_Municipio(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Municipio.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Municipio.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMunicipioApiConsumer.ListaSelAll(1, 20,elWhere , " Municipio.Nombre ASC ").Resource;
               
                foreach (var item in result.Municipios)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Municipios.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetExpediente_Inicial_Colonia_de_los_Hechos_MPI_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetExpediente_Inicial_Nombre_de_Agente_del_Ministerio_Publico_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Expediente_InicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Expediente_Inicial.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Expediente_Inicial.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Expediente_Inicial.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Expediente_Inicial.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Registra))
            {
                switch (filter.Usuario_que_RegistraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RegistraMultiple != null && filter.AdvanceUsuario_que_RegistraMultiple.Count() > 0)
            {
                var Usuario_que_RegistraIds = string.Join(",", filter.AdvanceUsuario_que_RegistraMultiple);

                where += " AND Expediente_Inicial.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDetenido))
            {
                switch (filter.DetenidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Estatus_Detenido_MPI.Descripcion LIKE '" + filter.AdvanceDetenido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Estatus_Detenido_MPI.Descripcion LIKE '%" + filter.AdvanceDetenido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Estatus_Detenido_MPI.Descripcion = '" + filter.AdvanceDetenido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Estatus_Detenido_MPI.Descripcion LIKE '%" + filter.AdvanceDetenido + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDetenidoMultiple != null && filter.AdvanceDetenidoMultiple.Count() > 0)
            {
                var DetenidoIds = string.Join(",", filter.AdvanceDetenidoMultiple);

                where += " AND Expediente_Inicial.Detenido In (" + DetenidoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NUC))
            {
                switch (filter.NUCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NUC LIKE '" + filter.NUC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NUC LIKE '%" + filter.NUC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NUC = '" + filter.NUC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NUC LIKE '%" + filter.NUC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.NIC))
            {
                switch (filter.NICFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NIC LIKE '" + filter.NIC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NIC LIKE '%" + filter.NIC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NIC = '" + filter.NIC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NIC LIKE '%" + filter.NIC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Detenido) || !string.IsNullOrEmpty(filter.ToHora_del_Detenido))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Detenido))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_del_Detenido) >='" + filter.FromHora_del_Detenido + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Detenido))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_del_Detenido) <='" + filter.ToHora_del_Detenido + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Puesto_a_Disposicion) || !string.IsNullOrEmpty(filter.ToHora_Puesto_a_Disposicion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Puesto_a_Disposicion))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_Puesto_a_Disposicion) >='" + filter.FromHora_Puesto_a_Disposicion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Puesto_a_Disposicion))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_Puesto_a_Disposicion) <='" + filter.ToHora_Puesto_a_Disposicion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitar_Servicos_de_Apoyo))
            {
                switch (filter.Solicitar_Servicos_de_ApoyoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '" + filter.AdvanceSolicitar_Servicos_de_Apoyo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceSolicitar_Servicos_de_Apoyo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Folio = '" + filter.AdvanceSolicitar_Servicos_de_Apoyo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceSolicitar_Servicos_de_Apoyo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitar_Servicos_de_ApoyoMultiple != null && filter.AdvanceSolicitar_Servicos_de_ApoyoMultiple.Count() > 0)
            {
                var Solicitar_Servicos_de_ApoyoIds = string.Join(",", filter.AdvanceSolicitar_Servicos_de_ApoyoMultiple);

                where += " AND Expediente_Inicial.Solicitar_Servicos_de_Apoyo In (" + Solicitar_Servicos_de_ApoyoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePrioridad_del_Hecho))
            {
                switch (filter.Prioridad_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Prioridad_del_Hecho.Descripcion = '" + filter.AdvancePrioridad_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Prioridad_del_Hecho.Descripcion LIKE '%" + filter.AdvancePrioridad_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvancePrioridad_del_HechoMultiple != null && filter.AdvancePrioridad_del_HechoMultiple.Count() > 0)
            {
                var Prioridad_del_HechoIds = string.Join(",", filter.AdvancePrioridad_del_HechoMultiple);

                where += " AND Expediente_Inicial.Prioridad_del_Hecho In (" + Prioridad_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Turno))
            {
                switch (filter.TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Turno LIKE '" + filter.Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Turno LIKE '%" + filter.Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Turno = '" + filter.Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Turno LIKE '%" + filter.Turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Expediente_Inicial.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Expediente_Inicial.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Hecho))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_del_Hecho) >='" + filter.FromHora_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Hecho))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_del_Hecho) <='" + filter.ToHora_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_los_Hechos_MPI))
            {
                switch (filter.Pais_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_los_Hechos_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_los_Hechos_MPIMultiple != null && filter.AdvancePais_de_los_Hechos_MPIMultiple.Count() > 0)
            {
                var Pais_de_los_Hechos_MPIIds = string.Join(",", filter.AdvancePais_de_los_Hechos_MPIMultiple);

                where += " AND Expediente_Inicial.Pais_de_los_Hechos_MPI In (" + Pais_de_los_Hechos_MPIIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_de_los_Hechos_MPI))
            {
                switch (filter.Estado_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_los_Hechos_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_de_los_Hechos_MPIMultiple != null && filter.AdvanceEstado_de_los_Hechos_MPIMultiple.Count() > 0)
            {
                var Estado_de_los_Hechos_MPIIds = string.Join(",", filter.AdvanceEstado_de_los_Hechos_MPIMultiple);

                where += " AND Expediente_Inicial.Estado_de_los_Hechos_MPI In (" + Estado_de_los_Hechos_MPIIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_los_Hechos_MPI))
            {
                switch (filter.Municipio_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_los_Hechos_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_los_Hechos_MPIMultiple != null && filter.AdvanceMunicipio_de_los_Hechos_MPIMultiple.Count() > 0)
            {
                var Municipio_de_los_Hechos_MPIIds = string.Join(",", filter.AdvanceMunicipio_de_los_Hechos_MPIMultiple);

                where += " AND Expediente_Inicial.Municipio_de_los_Hechos_MPI In (" + Municipio_de_los_Hechos_MPIIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_de_los_Hechos_MPI))
            {
                switch (filter.Colonia_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_los_Hechos_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_de_los_Hechos_MPIMultiple != null && filter.AdvanceColonia_de_los_Hechos_MPIMultiple.Count() > 0)
            {
                var Colonia_de_los_Hechos_MPIIds = string.Join(",", filter.AdvanceColonia_de_los_Hechos_MPIMultiple);

                where += " AND Expediente_Inicial.Colonia_de_los_Hechos_MPI In (" + Colonia_de_los_Hechos_MPIIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos_MPI) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos_MPI))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_los_Hechos_MPI))
                    where += " AND Expediente_Inicial.Codigo_Postal_de_los_Hechos_MPI >= " + filter.FromCodigo_Postal_de_los_Hechos_MPI;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_de_los_Hechos_MPI))
                    where += " AND Expediente_Inicial.Codigo_Postal_de_los_Hechos_MPI <= " + filter.ToCodigo_Postal_de_los_Hechos_MPI;
            }

            if (!string.IsNullOrEmpty(filter.Calle_de_los_Hechos_MPI))
            {
                switch (filter.Calle_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Calle_de_los_Hechos_MPI LIKE '" + filter.Calle_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Calle_de_los_Hechos_MPI LIKE '%" + filter.Calle_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Calle_de_los_Hechos_MPI = '" + filter.Calle_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Calle_de_los_Hechos_MPI LIKE '%" + filter.Calle_de_los_Hechos_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_MPI))
            {
                switch (filter.Entre_Calle_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Entre_Calle_MPI LIKE '" + filter.Entre_Calle_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Entre_Calle_MPI LIKE '%" + filter.Entre_Calle_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Entre_Calle_MPI = '" + filter.Entre_Calle_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Entre_Calle_MPI LIKE '%" + filter.Entre_Calle_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle_MPI))
            {
                switch (filter.Y_Calle_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Y_Calle_MPI LIKE '" + filter.Y_Calle_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Y_Calle_MPI LIKE '%" + filter.Y_Calle_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Y_Calle_MPI = '" + filter.Y_Calle_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Y_Calle_MPI LIKE '%" + filter.Y_Calle_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exrterior_de_los_Hechos_MPI))
            {
                switch (filter.Numero_Exrterior_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI LIKE '" + filter.Numero_Exrterior_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI LIKE '%" + filter.Numero_Exrterior_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI = '" + filter.Numero_Exrterior_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI LIKE '%" + filter.Numero_Exrterior_de_los_Hechos_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_de_los_Hechos_MPI))
            {
                switch (filter.Numero_Interior_de_los_Hechos_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Numero_Interior_de_los_Hechos_MPI LIKE '" + filter.Numero_Interior_de_los_Hechos_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Numero_Interior_de_los_Hechos_MPI LIKE '%" + filter.Numero_Interior_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Numero_Interior_de_los_Hechos_MPI = '" + filter.Numero_Interior_de_los_Hechos_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Numero_Interior_de_los_Hechos_MPI LIKE '%" + filter.Numero_Interior_de_los_Hechos_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_MPI))
            {
                switch (filter.Latitud_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Latitud_MPI LIKE '" + filter.Latitud_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Latitud_MPI LIKE '%" + filter.Latitud_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Latitud_MPI = '" + filter.Latitud_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Latitud_MPI LIKE '%" + filter.Latitud_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_MPI))
            {
                switch (filter.Longitud_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Longitud_MPI LIKE '" + filter.Longitud_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Longitud_MPI LIKE '%" + filter.Longitud_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Longitud_MPI = '" + filter.Longitud_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Longitud_MPI LIKE '%" + filter.Longitud_MPI + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Lugar_del_Hecho_MPI))
            {
                switch (filter.Tipo_de_Lugar_del_Hecho_MPIFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceTipo_de_Lugar_del_Hecho_MPI + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho_MPI + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceTipo_de_Lugar_del_Hecho_MPI + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho_MPI + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Lugar_del_Hecho_MPIMultiple != null && filter.AdvanceTipo_de_Lugar_del_Hecho_MPIMultiple.Count() > 0)
            {
                var Tipo_de_Lugar_del_Hecho_MPIIds = string.Join(",", filter.AdvanceTipo_de_Lugar_del_Hecho_MPIMultiple);

                where += " AND Expediente_Inicial.Tipo_de_Lugar_del_Hecho_MPI In (" + Tipo_de_Lugar_del_Hecho_MPIIds + ")";
            }

            if (filter.Persona_Moral != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Persona_Moral = " + Convert.ToInt32(filter.Persona_Moral);

            if (filter.Requiere_Diligencia != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Requiere_Diligencia = " + Convert.ToInt32(filter.Requiere_Diligencia);

            if (!string.IsNullOrEmpty(filter.Numero_de_Expediente_Victima))
            {
                switch (filter.Numero_de_Expediente_VictimaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Numero_de_Expediente_Victima LIKE '" + filter.Numero_de_Expediente_Victima + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Numero_de_Expediente_Victima LIKE '%" + filter.Numero_de_Expediente_Victima + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Numero_de_Expediente_Victima = '" + filter.Numero_de_Expediente_Victima + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Numero_de_Expediente_Victima LIKE '%" + filter.Numero_de_Expediente_Victima + "%'";
                        break;
                }
            }

            if (filter.Requiere_Traductor != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Requiere_Traductor = " + Convert.ToInt32(filter.Requiere_Traductor);

            if (!string.IsNullOrEmpty(filter.AdvanceLengua_Originaria))
            {
                switch (filter.Lengua_OriginariaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dialecto.Descripcion LIKE '" + filter.AdvanceLengua_Originaria + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceLengua_Originaria + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dialecto.Descripcion = '" + filter.AdvanceLengua_Originaria + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceLengua_Originaria + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLengua_OriginariaMultiple != null && filter.AdvanceLengua_OriginariaMultiple.Count() > 0)
            {
                var Lengua_OriginariaIds = string.Join(",", filter.AdvanceLengua_OriginariaMultiple);

                where += " AND Expediente_Inicial.Lengua_Originaria In (" + Lengua_OriginariaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceIdioma))
            {
                switch (filter.IdiomaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Idioma.Descripcion LIKE '" + filter.AdvanceIdioma + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Idioma.Descripcion = '" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "%'";
                        break;
                }
            }
            else if (filter.AdvanceIdiomaMultiple != null && filter.AdvanceIdiomaMultiple.Count() > 0)
            {
                var IdiomaIds = string.Join(",", filter.AdvanceIdiomaMultiple);

                where += " AND Expediente_Inicial.Idioma In (" + IdiomaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (filter.Asignar_Agente_del_Ministerio_Publico != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Asignar_Agente_del_Ministerio_Publico = " + Convert.ToInt32(filter.Asignar_Agente_del_Ministerio_Publico);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_de_Agente_del_Ministerio_Publico))
            {
                switch (filter.Nombre_de_Agente_del_Ministerio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceNombre_de_Agente_del_Ministerio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNombre_de_Agente_del_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceNombre_de_Agente_del_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNombre_de_Agente_del_Ministerio_Publico + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_de_Agente_del_Ministerio_PublicoMultiple != null && filter.AdvanceNombre_de_Agente_del_Ministerio_PublicoMultiple.Count() > 0)
            {
                var Nombre_de_Agente_del_Ministerio_PublicoIds = string.Join(",", filter.AdvanceNombre_de_Agente_del_Ministerio_PublicoMultiple);

                where += " AND Expediente_Inicial.Nombre_de_Agente_del_Ministerio_Publico In (" + Nombre_de_Agente_del_Ministerio_PublicoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Oficio))
            {
                switch (filter.Tipo_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '" + filter.AdvanceTipo_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '%" + filter.AdvanceTipo_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Oficio.Descripcion = '" + filter.AdvanceTipo_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '%" + filter.AdvanceTipo_de_Oficio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_OficioMultiple != null && filter.AdvanceTipo_de_OficioMultiple.Count() > 0)
            {
                var Tipo_de_OficioIds = string.Join(",", filter.AdvanceTipo_de_OficioMultiple);

                where += " AND Expediente_Inicial.Tipo_de_Oficio In (" + Tipo_de_OficioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelegacion))
            {
                switch (filter.DelegacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Descripcion LIKE '" + filter.AdvanceDelegacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Descripcion = '" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelegacionMultiple != null && filter.AdvanceDelegacionMultiple.Count() > 0)
            {
                var DelegacionIds = string.Join(",", filter.AdvanceDelegacionMultiple);

                where += " AND Expediente_Inicial.Delegacion In (" + DelegacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgencia))
            {
                switch (filter.AgenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Agencia.Descripcion LIKE '" + filter.AdvanceAgencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Agencia.Descripcion = '" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgenciaMultiple != null && filter.AdvanceAgenciaMultiple.Count() > 0)
            {
                var AgenciaIds = string.Join(",", filter.AdvanceAgenciaMultiple);

                where += " AND Expediente_Inicial.Agencia In (" + AgenciaIds + ")";
            }

            if (filter.Solicitar_Diligencias != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Solicitar_Diligencias = " + Convert.ToInt32(filter.Solicitar_Diligencias);

            if (!string.IsNullOrEmpty(filter.NUC_Audiencias))
            {
                switch (filter.NUC_AudienciasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NUC_Audiencias LIKE '" + filter.NUC_Audiencias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NUC_Audiencias LIKE '%" + filter.NUC_Audiencias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NUC_Audiencias = '" + filter.NUC_Audiencias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NUC_Audiencias LIKE '%" + filter.NUC_Audiencias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.NIC_Audiencias))
            {
                switch (filter.NIC_AudienciasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NIC_Audiencias LIKE '" + filter.NIC_Audiencias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NIC_Audiencias LIKE '%" + filter.NIC_Audiencias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NIC_Audiencias = '" + filter.NIC_Audiencias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NIC_Audiencias LIKE '%" + filter.NIC_Audiencias + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro_Audiencias) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro_Audiencias))
            {
                var Fecha_de_Registro_AudienciasFrom = DateTime.ParseExact(filter.FromFecha_de_Registro_Audiencias, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Registro_AudienciasTo = DateTime.ParseExact(filter.ToFecha_de_Registro_Audiencias, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro_Audiencias))
                    where += " AND Expediente_Inicial.Fecha_de_Registro_Audiencias >= '" + Fecha_de_Registro_AudienciasFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro_Audiencias))
                    where += " AND Expediente_Inicial.Fecha_de_Registro_Audiencias <= '" + Fecha_de_Registro_AudienciasTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro_Audiencias) || !string.IsNullOrEmpty(filter.ToHora_de_Registro_Audiencias))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro_Audiencias))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Registro_Audiencias) >='" + filter.FromHora_de_Registro_Audiencias + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro_Audiencias))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Registro_Audiencias) <='" + filter.ToHora_de_Registro_Audiencias + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Oficio_Audiencias))
            {
                switch (filter.Tipo_de_Oficio_AudienciasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '" + filter.AdvanceTipo_de_Oficio_Audiencias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '%" + filter.AdvanceTipo_de_Oficio_Audiencias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Oficio.Descripcion = '" + filter.AdvanceTipo_de_Oficio_Audiencias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Oficio.Descripcion LIKE '%" + filter.AdvanceTipo_de_Oficio_Audiencias + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Oficio_AudienciasMultiple != null && filter.AdvanceTipo_de_Oficio_AudienciasMultiple.Count() > 0)
            {
                var Tipo_de_Oficio_AudienciasIds = string.Join(",", filter.AdvanceTipo_de_Oficio_AudienciasMultiple);

                where += " AND Expediente_Inicial.Tipo_de_Oficio_Audiencias In (" + Tipo_de_Oficio_AudienciasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelegacion_Audiencias))
            {
                switch (filter.Delegacion_AudienciasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Descripcion LIKE '" + filter.AdvanceDelegacion_Audiencias + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion_Audiencias + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Descripcion = '" + filter.AdvanceDelegacion_Audiencias + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion_Audiencias + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelegacion_AudienciasMultiple != null && filter.AdvanceDelegacion_AudienciasMultiple.Count() > 0)
            {
                var Delegacion_AudienciasIds = string.Join(",", filter.AdvanceDelegacion_AudienciasMultiple);

                where += " AND Expediente_Inicial.Delegacion_Audiencias In (" + Delegacion_AudienciasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Domicilio_Delegacion_A))
            {
                switch (filter.Domicilio_Delegacion_AFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Domicilio_Delegacion_A LIKE '" + filter.Domicilio_Delegacion_A + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Domicilio_Delegacion_A LIKE '%" + filter.Domicilio_Delegacion_A + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Domicilio_Delegacion_A = '" + filter.Domicilio_Delegacion_A + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Domicilio_Delegacion_A LIKE '%" + filter.Domicilio_Delegacion_A + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Numero_de_Expediente LIKE '" + filter.Numero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Numero_de_Expediente = '" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.NUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NUAT LIKE '" + filter.NUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NUAT LIKE '%" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NUAT = '" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NUAT LIKE '%" + filter.NUAT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_RegistroI) || !string.IsNullOrEmpty(filter.ToFecha_de_RegistroI))
            {
                var Fecha_de_RegistroIFrom = DateTime.ParseExact(filter.FromFecha_de_RegistroI, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroITo = DateTime.ParseExact(filter.ToFecha_de_RegistroI, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_RegistroI))
                    where += " AND Expediente_Inicial.Fecha_de_RegistroI >= '" + Fecha_de_RegistroIFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_RegistroI))
                    where += " AND Expediente_Inicial.Fecha_de_RegistroI <= '" + Fecha_de_RegistroITo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_RegistroI) || !string.IsNullOrEmpty(filter.ToHora_de_RegistroI))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_RegistroI))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_RegistroI) >='" + filter.FromHora_de_RegistroI + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_RegistroI))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_RegistroI) <='" + filter.ToHora_de_RegistroI + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Expediente_Inicial.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Expediente_Inicial.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Expediente_Inicial.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Expediente_Inicial.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Expediente_Inicial.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCanalizar_a))
            {
                switch (filter.Canalizar_aFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Orientador.Descripcion LIKE '" + filter.AdvanceCanalizar_a + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Orientador.Descripcion LIKE '%" + filter.AdvanceCanalizar_a + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Orientador.Descripcion = '" + filter.AdvanceCanalizar_a + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Orientador.Descripcion LIKE '%" + filter.AdvanceCanalizar_a + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCanalizar_aMultiple != null && filter.AdvanceCanalizar_aMultiple.Count() > 0)
            {
                var Canalizar_aIds = string.Join(",", filter.AdvanceCanalizar_aMultiple);

                where += " AND Expediente_Inicial.Canalizar_a In (" + Canalizar_aIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelito_Principal))
            {
                switch (filter.Delito_PrincipalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito_Principal_MPI.Delito LIKE '" + filter.AdvanceDelito_Principal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito_Principal_MPI.Delito LIKE '%" + filter.AdvanceDelito_Principal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito_Principal_MPI.Delito = '" + filter.AdvanceDelito_Principal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito_Principal_MPI.Delito LIKE '%" + filter.AdvanceDelito_Principal + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelito_PrincipalMultiple != null && filter.AdvanceDelito_PrincipalMultiple.Count() > 0)
            {
                var Delito_PrincipalIds = string.Join(",", filter.AdvanceDelito_PrincipalMultiple);

                where += " AND Expediente_Inicial.Delito_Principal In (" + Delito_PrincipalIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Acuerdo))
            {
                switch (filter.Tipo_de_AcuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '" + filter.AdvanceTipo_de_Acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Acuerdo.Descripcion = '" + filter.AdvanceTipo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Acuerdo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AcuerdoMultiple != null && filter.AdvanceTipo_de_AcuerdoMultiple.Count() > 0)
            {
                var Tipo_de_AcuerdoIds = string.Join(",", filter.AdvanceTipo_de_AcuerdoMultiple);

                where += " AND Expediente_Inicial.Tipo_de_Acuerdo In (" + Tipo_de_AcuerdoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio_de_Acuerdo) || !string.IsNullOrEmpty(filter.ToFecha_de_Inicio_de_Acuerdo))
            {
                var Fecha_de_Inicio_de_AcuerdoFrom = DateTime.ParseExact(filter.FromFecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Inicio_de_AcuerdoTo = DateTime.ParseExact(filter.ToFecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio_de_Acuerdo))
                    where += " AND Expediente_Inicial.Fecha_de_Inicio_de_Acuerdo >= '" + Fecha_de_Inicio_de_AcuerdoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Inicio_de_Acuerdo))
                    where += " AND Expediente_Inicial.Fecha_de_Inicio_de_Acuerdo <= '" + Fecha_de_Inicio_de_AcuerdoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
            {
                var Fecha_de_CumplimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CumplimientoTo = DateTime.ParseExact(filter.ToFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento))
                    where += " AND Expediente_Inicial.Fecha_de_Cumplimiento >= '" + Fecha_de_CumplimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
                    where += " AND Expediente_Inicial.Fecha_de_Cumplimiento <= '" + Fecha_de_CumplimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Cumplimiento) || !string.IsNullOrEmpty(filter.ToHora_de_Cumplimiento))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Cumplimiento))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Cumplimiento) >='" + filter.FromHora_de_Cumplimiento + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Cumplimiento))
                    where += " AND Convert(TIME,Expediente_Inicial.Hora_de_Cumplimiento) <='" + filter.ToHora_de_Cumplimiento + "'";
            }

            if (!string.IsNullOrEmpty(filter.Domicilio_para_el_Cumplimiento))
            {
                switch (filter.Domicilio_para_el_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Domicilio_para_el_Cumplimiento LIKE '" + filter.Domicilio_para_el_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Domicilio_para_el_Cumplimiento LIKE '%" + filter.Domicilio_para_el_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Domicilio_para_el_Cumplimiento = '" + filter.Domicilio_para_el_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Domicilio_para_el_Cumplimiento LIKE '%" + filter.Domicilio_para_el_Cumplimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_de_Danos) || !string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_de_Danos))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_de_Danos))
                    where += " AND Expediente_Inicial.Monto_de_Reparacion_de_Danos >= " + filter.FromMonto_de_Reparacion_de_Danos;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_de_Danos))
                    where += " AND Expediente_Inicial.Monto_de_Reparacion_de_Danos <= " + filter.ToMonto_de_Reparacion_de_Danos;
            }

            if (!string.IsNullOrEmpty(filter.Parcialidades))
            {
                switch (filter.ParcialidadesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Parcialidades LIKE '" + filter.Parcialidades + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Parcialidades LIKE '%" + filter.Parcialidades + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Parcialidades = '" + filter.Parcialidades + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Parcialidades LIKE '%" + filter.Parcialidades + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePeriodicidad))
            {
                switch (filter.PeriodicidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Periodicidad.Descripcion LIKE '" + filter.AdvancePeriodicidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.AdvancePeriodicidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Periodicidad.Descripcion = '" + filter.AdvancePeriodicidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.AdvancePeriodicidad + "%'";
                        break;
                }
            }
            else if (filter.AdvancePeriodicidadMultiple != null && filter.AdvancePeriodicidadMultiple.Count() > 0)
            {
                var PeriodicidadIds = string.Join(",", filter.AdvancePeriodicidadMultiple);

                where += " AND Expediente_Inicial.Periodicidad In (" + PeriodicidadIds + ")";
            }

            if (filter.Acepta_Acuerdo != RadioOptions.NoApply)
                where += " AND Expediente_Inicial.Acepta_Acuerdo = " + Convert.ToInt32(filter.Acepta_Acuerdo);

            if (!string.IsNullOrEmpty(filter.Motivo_de_Rechazo_de_Acuerdo))
            {
                switch (filter.Motivo_de_Rechazo_de_AcuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.Motivo_de_Rechazo_de_Acuerdo LIKE '" + filter.Motivo_de_Rechazo_de_Acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.Motivo_de_Rechazo_de_Acuerdo LIKE '%" + filter.Motivo_de_Rechazo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.Motivo_de_Rechazo_de_Acuerdo = '" + filter.Motivo_de_Rechazo_de_Acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.Motivo_de_Rechazo_de_Acuerdo LIKE '%" + filter.Motivo_de_Rechazo_de_Acuerdo + "%'";
                        break;
                }
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Datos_de_la_Victima_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Datos_de_la_Victima_MPIs == null)
                result.Detalle_de_Datos_de_la_Victima_MPIs = new List<Detalle_de_Datos_de_la_Victima_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Datos_de_la_Victima_MPIs.Select(m => new Detalle_de_Datos_de_la_Victima_MPIGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
			,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Localidad_del_Tutor = m.Localidad_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extencion_del_Tutor = m.Extencion_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos

			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_de_los_Hechos = m.Pais_de_los_Hechos
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_Hechos = m.Estado_de_los_Hechos
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_Hechos = m.Municipio_de_los_Hechos
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Colonia_de_los_Hechos = m.Colonia_de_los_Hechos
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_Calle_de_los_Hechos = m.Y_Calle_de_los_Hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Nombre_de_Persona_Moral = m.Nombre_de_Persona_Moral
			,Apellido_Paterno_de_Persona_Moral = m.Apellido_Paterno_de_Persona_Moral
			,Apellido_Materno_de_Persona_Moral = m.Apellido_Materno_de_Persona_Moral
			,Fecha_de_Nacimiento_de_Persona_Moral = (m.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
			,Edad_de_Persona_Moral = m.Edad_de_Persona_Moral
                        ,Sexo_de_Persona_Moral = m.Sexo_de_Persona_Moral
                        ,Sexo_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Sexo_de_Persona_Moral_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_de_Persona_Moral_Genero.Descripcion
                        ,Estado_Civil_de_Persona_Moral = m.Estado_Civil_de_Persona_Moral
                        ,Estado_Civil_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_de_Persona_Moral_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_de_Persona_Moral = m.Tipo_de_Identificacion_de_Persona_Moral
                        ,Tipo_de_Identificacion_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_de_Persona_Mora = m.Numero_de_Identificacion_de_Persona_Mora
                        ,Nacionalidad_de_Persona_Moral = m.Nacionalidad_de_Persona_Moral
                        ,Nacionalidad_de_Persona_MoralNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_de_Persona_Moral_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                        ,Escolaridad_de_Persona_Moral = m.Escolaridad_de_Persona_Moral
                        ,Escolaridad_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Escolaridad_de_Persona_Moral_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                        ,Ocupacion_de_Persona_Moral = m.Ocupacion_de_Persona_Moral
                        ,Ocupacion_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Ocupacion_de_Persona_Moral_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                        ,Pais_de_Persona_Moral = m.Pais_de_Persona_Moral
                        ,Pais_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Pais_de_Persona_Moral_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Persona_Moral_Pais.Nombre
                        ,Estado_de_Persona_Moral = m.Estado_de_Persona_Moral
                        ,Estado_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Estado_de_Persona_Moral_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_Persona_Moral_Estado.Nombre
                        ,Municipio_de_Persona_Moral = m.Municipio_de_Persona_Moral
                        ,Municipio_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Municipio_de_Persona_Moral_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_de_Persona_Moral_Municipio.Nombre
                        ,Colonia_de_Persona_Moral = m.Colonia_de_Persona_Moral
                        ,Colonia_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Colonia_de_Persona_Moral_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_de_Persona_Moral_Colonia.Nombre
			,Codigo_Postal_de_Persona_Moral = m.Codigo_Postal_de_Persona_Moral
			,Calle_de_Persona_Moral = m.Calle_de_Persona_Moral
			,Numero_Exterior_de_Persona_Moral = m.Numero_Exterior_de_Persona_Moral
			,Numero_Interior_de_Persona_Moral = m.Numero_Interior_de_Persona_Moral
			,Entre_Calle_de_Persona_Moral = m.Entre_Calle_de_Persona_Moral
			,Y_Calle_de_Persona_Moral = m.Y_Calle_de_Persona_Moral
			,Longitud_de_Persona_Moral = m.Longitud_de_Persona_Moral
			,Latitud_de_Persona_Moral = m.Latitud_de_Persona_Moral
			,Telefono_de_Persona_Moral = m.Telefono_de_Persona_Moral
			,Extension_de_Persona_Moral = m.Extension_de_Persona_Moral
			,Celular_de_Persona_Moral = m.Celular_de_Persona_Moral
			,Correo_Electronico_de_Persona_Moral = m.Correo_Electronico_de_Persona_Moral
			,Persona_Moral_Victima = m.Persona_Moral_Victima

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Datos_de_la_Victima_MPIGridModel> GetDetalle_de_Datos_de_la_Victima_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Datos_de_la_Victima_MPIGridModel> resultData = new List<Detalle_de_Datos_de_la_Victima_MPIGridModel>();
            string where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Datos_de_la_Victima_MPIs != null)
            {
                resultData = result.Detalle_de_Datos_de_la_Victima_MPIs.Select(m => new Detalle_de_Datos_de_la_Victima_MPIGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
			,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Localidad_del_Tutor = m.Localidad_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extencion_del_Tutor = m.Extencion_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos

			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_de_los_Hechos = m.Pais_de_los_Hechos
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_Hechos = m.Estado_de_los_Hechos
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_Hechos = m.Municipio_de_los_Hechos
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Colonia_de_los_Hechos = m.Colonia_de_los_Hechos
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_Calle_de_los_Hechos = m.Y_Calle_de_los_Hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Nombre_de_Persona_Moral = m.Nombre_de_Persona_Moral
			,Apellido_Paterno_de_Persona_Moral = m.Apellido_Paterno_de_Persona_Moral
			,Apellido_Materno_de_Persona_Moral = m.Apellido_Materno_de_Persona_Moral
			,Fecha_de_Nacimiento_de_Persona_Moral = (m.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
			,Edad_de_Persona_Moral = m.Edad_de_Persona_Moral
                        ,Sexo_de_Persona_Moral = m.Sexo_de_Persona_Moral
                        ,Sexo_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Sexo_de_Persona_Moral_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_de_Persona_Moral_Genero.Descripcion
                        ,Estado_Civil_de_Persona_Moral = m.Estado_Civil_de_Persona_Moral
                        ,Estado_Civil_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_de_Persona_Moral_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_de_Persona_Moral = m.Tipo_de_Identificacion_de_Persona_Moral
                        ,Tipo_de_Identificacion_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_de_Persona_Mora = m.Numero_de_Identificacion_de_Persona_Mora
                        ,Nacionalidad_de_Persona_Moral = m.Nacionalidad_de_Persona_Moral
                        ,Nacionalidad_de_Persona_MoralNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_de_Persona_Moral_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                        ,Escolaridad_de_Persona_Moral = m.Escolaridad_de_Persona_Moral
                        ,Escolaridad_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Escolaridad_de_Persona_Moral_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                        ,Ocupacion_de_Persona_Moral = m.Ocupacion_de_Persona_Moral
                        ,Ocupacion_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Ocupacion_de_Persona_Moral_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                        ,Pais_de_Persona_Moral = m.Pais_de_Persona_Moral
                        ,Pais_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Pais_de_Persona_Moral_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Persona_Moral_Pais.Nombre
                        ,Estado_de_Persona_Moral = m.Estado_de_Persona_Moral
                        ,Estado_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Estado_de_Persona_Moral_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_Persona_Moral_Estado.Nombre
                        ,Municipio_de_Persona_Moral = m.Municipio_de_Persona_Moral
                        ,Municipio_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Municipio_de_Persona_Moral_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_de_Persona_Moral_Municipio.Nombre
                        ,Colonia_de_Persona_Moral = m.Colonia_de_Persona_Moral
                        ,Colonia_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Colonia_de_Persona_Moral_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_de_Persona_Moral_Colonia.Nombre
			,Codigo_Postal_de_Persona_Moral = m.Codigo_Postal_de_Persona_Moral
			,Calle_de_Persona_Moral = m.Calle_de_Persona_Moral
			,Numero_Exterior_de_Persona_Moral = m.Numero_Exterior_de_Persona_Moral
			,Numero_Interior_de_Persona_Moral = m.Numero_Interior_de_Persona_Moral
			,Entre_Calle_de_Persona_Moral = m.Entre_Calle_de_Persona_Moral
			,Y_Calle_de_Persona_Moral = m.Y_Calle_de_Persona_Moral
			,Longitud_de_Persona_Moral = m.Longitud_de_Persona_Moral
			,Latitud_de_Persona_Moral = m.Latitud_de_Persona_Moral
			,Telefono_de_Persona_Moral = m.Telefono_de_Persona_Moral
			,Extension_de_Persona_Moral = m.Extension_de_Persona_Moral
			,Celular_de_Persona_Moral = m.Celular_de_Persona_Moral
			,Correo_Electronico_de_Persona_Moral = m.Correo_Electronico_de_Persona_Moral
			,Persona_Moral_Victima = m.Persona_Moral_Victima


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Datos_del_Imputado_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Datos_del_Imputado_MPIs == null)
                result.Detalle_de_Datos_del_Imputado_MPIs = new List<Detalle_de_Datos_del_Imputado_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Datos_del_Imputado_MPIs.Select(m => new Detalle_de_Datos_del_Imputado_MPIGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_Localidad.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Forma_Cara = m.Forma_Cara
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ??(string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Cejas = m.Cejas
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ??(string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_Cabello = m.Cantidad_Cabello
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_Cabello = m.Implantacion_Cabello
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,Complexion = m.Complexion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ??(string)m.Complexion_Complexion.Descripcion
                        ,Color_Piel = m.Color_Piel
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ??(string)m.Color_Piel_Color_Piel.Descrpicion
                        ,Frente = m.Frente
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ??(string)m.Frente_Frente.Descripcion
                        ,Forma_Cabello = m.Forma_Cabello
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Calvicie = m.Calvicie
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ??(string)m.Calvicie_Calvicie.Descripcion
                        ,Color_Ojos = m.Color_Ojos
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Ojos = m.Ojos
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Ojos_Ojos.Descripcion
                        //,Forma_Ojos = m.Forma_Ojos
                        //,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_Base = m.Nariz_Base
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ??(string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,Labios = m.Labios
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ??(string)m.Labios_Labios.Descripcion
                        ,Boca = m.Boca
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ??(string)m.Boca_Boca.Descripcion
                        ,Menton = m.Menton
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ??(string)m.Menton_Menton.Descripcion
                        ,Barba = m.Barba
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ??(string)m.Barba_Barba.Descripcion
                        ,Forma_Orejas = m.Forma_Orejas
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ??(string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_Orejas = m.Tamano_Orejas
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ??(string)m.Tamano_Orejas_Forma_Orejas.Descripcion
                        ,Tipo_Lobulo = m.Tipo_Lobulo
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,Bigote = m.Bigote
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ??(string)m.Bigote_Bigote.Descripcion
                        ,Situacion_Fisica = m.Situacion_Fisica
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ??(string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Alias_media_diliacion = m.Alias_media_diliacion
			,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Detencion = m.Hora_de_Detencion
			,Fecha_de_Puesto_a_Disposicion = (m.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Puesto_a_Disposicion = m.Hora_de_Puesto_a_Disposicion
                        ,Con_Detenido = m.Con_Detenido
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ??(string)m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
			,Tiempo_Restante_para_Vinculacion = m.Tiempo_Restante_para_Vinculacion
			,Vincular = m.Vincular
                        ,Medidas_Cautelares = m.Medidas_Cautelares
                        ,Medidas_CautelaresDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medidas_Cautelares_Medidas_Cautelares.Descripcion
			,Solicitar_Prorroga = m.Solicitar_Prorroga
			,Nuevo_Plazo = m.Nuevo_Plazo
			,Orden_de_Aprehension = m.Orden_de_Aprehension
                        ,Medidas_Cautelares_en_Imputado = m.Medidas_Cautelares_en_Imputado
                        ,Medidas_Cautelares_en_ImputadoDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = m.Pais_del_Hecho
                        ,Pais_del_HechoNombre = CultureHelper.GetTraduction(m.Pais_del_Hecho_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Hecho_Pais.Nombre
                        ,Estado_del_Hecho = m.Estado_del_Hecho
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_del_Hecho = m.Municipio_del_Hecho
                        ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(m.Municipio_del_Hecho_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Hecho_Municipio.Nombre
                        ,Colonia_del_Hecho = m.Colonia_del_Hecho
                        ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(m.Colonia_del_Hecho_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Hecho_Colonia.Nombre
			,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
			,Calle_del_Hecho = m.Calle_del_Hecho
			,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
			,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
			,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
			,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
			,Latitud_del_Hecho = m.Latitud_del_Hecho
			,Longitud_del_Hecho = m.Longitud_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion

			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Proteccion_de_Datos = m.Proteccion_de_Datos

                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_del_Imputado.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_del_Imputado.Descripcion
			,Judicializar = m.Judicializar

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Datos_del_Imputado_MPIGridModel> GetDetalle_de_Datos_del_Imputado_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Datos_del_Imputado_MPIGridModel> resultData = new List<Detalle_de_Datos_del_Imputado_MPIGridModel>();
            string where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Datos_del_Imputado_MPIs != null)
            {
                resultData = result.Detalle_de_Datos_del_Imputado_MPIs.Select(m => new Detalle_de_Datos_del_Imputado_MPIGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_Localidad.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Forma_Cara = m.Forma_Cara
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ??(string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,Cejas = m.Cejas
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ??(string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_Cabello = m.Cantidad_Cabello
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_Cabello = m.Implantacion_Cabello
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,Complexion = m.Complexion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ??(string)m.Complexion_Complexion.Descripcion
                        ,Color_Piel = m.Color_Piel
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ??(string)m.Color_Piel_Color_Piel.Descrpicion
                        ,Frente = m.Frente
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ??(string)m.Frente_Frente.Descripcion
                        ,Forma_Cabello = m.Forma_Cabello
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ??(string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,Calvicie = m.Calvicie
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ??(string)m.Calvicie_Calvicie.Descripcion
                        ,Color_Ojos = m.Color_Ojos
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,Ojos = m.Ojos
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Ojos_Ojos.Descripcion
                        //,Forma_Ojos = m.Forma_Ojos
                        //,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ??(string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_Base = m.Nariz_Base
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ??(string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,Labios = m.Labios
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ??(string)m.Labios_Labios.Descripcion
                        ,Boca = m.Boca
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ??(string)m.Boca_Boca.Descripcion
                        ,Menton = m.Menton
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ??(string)m.Menton_Menton.Descripcion
                        ,Barba = m.Barba
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ??(string)m.Barba_Barba.Descripcion
                        ,Forma_Orejas = m.Forma_Orejas
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ??(string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_Orejas = m.Tamano_Orejas
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ??(string)m.Tamano_Orejas_Forma_Orejas.Descripcion
                        ,Tipo_Lobulo = m.Tipo_Lobulo
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,Bigote = m.Bigote
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ??(string)m.Bigote_Bigote.Descripcion
                        ,Situacion_Fisica = m.Situacion_Fisica
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ??(string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Alias_media_diliacion = m.Alias_media_diliacion
			,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Detencion = m.Hora_de_Detencion
			,Fecha_de_Puesto_a_Disposicion = (m.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Puesto_a_Disposicion = m.Hora_de_Puesto_a_Disposicion
                        ,Con_Detenido = m.Con_Detenido
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ??(string)m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
			,Tiempo_Restante_para_Vinculacion = m.Tiempo_Restante_para_Vinculacion
			,Vincular = m.Vincular
                        ,Medidas_Cautelares = m.Medidas_Cautelares
                        ,Medidas_CautelaresDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medidas_Cautelares_Medidas_Cautelares.Descripcion
			,Solicitar_Prorroga = m.Solicitar_Prorroga
			,Nuevo_Plazo = m.Nuevo_Plazo
			,Orden_de_Aprehension = m.Orden_de_Aprehension
                        ,Medidas_Cautelares_en_Imputado = m.Medidas_Cautelares_en_Imputado
                        ,Medidas_Cautelares_en_ImputadoDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Clave.ToString(), "Descripcion") ??(string)m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = m.Pais_del_Hecho
                        ,Pais_del_HechoNombre = CultureHelper.GetTraduction(m.Pais_del_Hecho_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Hecho_Pais.Nombre
                        ,Estado_del_Hecho = m.Estado_del_Hecho
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_del_Hecho = m.Municipio_del_Hecho
                        ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(m.Municipio_del_Hecho_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Hecho_Municipio.Nombre
                        ,Colonia_del_Hecho = m.Colonia_del_Hecho
                        ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(m.Colonia_del_Hecho_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Hecho_Colonia.Nombre
			,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
			,Calle_del_Hecho = m.Calle_del_Hecho
			,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
			,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
			,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
			,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
			,Latitud_del_Hecho = m.Latitud_del_Hecho
			,Longitud_del_Hecho = m.Longitud_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion

			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Proteccion_de_Datos = m.Proteccion_de_Datos

                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_del_Imputado.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_del_Imputado.Descripcion
			,Judicializar = m.Judicializar


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Datos_de_Delito_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Datos_de_Delito_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Datos_de_Delito_MPIs == null)
                result.Detalle_Datos_de_Delito_MPIs = new List<Detalle_Datos_de_Delito_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Datos_de_Delito_MPIs.Select(m => new Detalle_Datos_de_Delito_MPIGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Delito = m.Tipo_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Grupo_Delito = m.Grupo_Delito
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ??(string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Circunstancia_Delito = m.Circunstancia_Delito
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_Delito = m.Forma_Comision_Delito
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ??(string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_Delito = m.Forma_Accion_Delito
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ??(string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_Delito = m.Modalidad_Delito
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_Delito = m.Elementos_Comision_Delito
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ??(string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,Violencia_de_Genero = m.Violencia_de_Genero
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Circunstancia_de_Vehiculo = m.Circunstancia_de_Vehiculo
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,Clase = m.Clase
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_Vehiculo = m.Tipo_de_Vehiculo
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_Placas = m.Estado_de_Origen_de_las_Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = m.Nombre_de_la_Aseguradora
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_Robo = m.Modalidad_del_Robo
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_Defuncion = m.Circunstancia_Defuncion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_Defuncion = m.Consecuencia_Defuncion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ??(string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
			,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ??(string)m.Zona_Zona.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Codigo_Postal = m.Codigo_Postal

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Datos_de_Delito_MPIGridModel> GetDetalle_Datos_de_Delito_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Datos_de_Delito_MPIGridModel> resultData = new List<Detalle_Datos_de_Delito_MPIGridModel>();
            string where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Datos_de_Delito_MPIs != null)
            {
                resultData = result.Detalle_Datos_de_Delito_MPIs.Select(m => new Detalle_Datos_de_Delito_MPIGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Delito = m.Tipo_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Grupo_Delito = m.Grupo_Delito
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ??(string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Circunstancia_Delito = m.Circunstancia_Delito
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_Delito = m.Forma_Comision_Delito
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ??(string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_Delito = m.Forma_Accion_Delito
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ??(string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_Delito = m.Modalidad_Delito
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_Delito = m.Elementos_Comision_Delito
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ??(string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,Violencia_de_Genero = m.Violencia_de_Genero
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Circunstancia_de_Vehiculo = m.Circunstancia_de_Vehiculo
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,Clase = m.Clase
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_Vehiculo = m.Tipo_de_Vehiculo
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_Placas = m.Estado_de_Origen_de_las_Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = m.Nombre_de_la_Aseguradora
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_Robo = m.Modalidad_del_Robo
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ??(string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_Defuncion = m.Circunstancia_Defuncion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ??(string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_Defuncion = m.Consecuencia_Defuncion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ??(string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
			,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ??(string)m.Zona_Zona.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Codigo_Postal = m.Codigo_Postal


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Persona_Moral_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Persona_Moral_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Persona_Moral_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Persona_Moral_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Persona_Moral_MPIs == null)
                result.Detalle_de_Persona_Moral_MPIs = new List<Detalle_de_Persona_Moral_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Persona_Moral_MPIs.Select(m => new Detalle_de_Persona_Moral_MPIGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_Localidad.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Persona_Moral_MPIGridModel> GetDetalle_de_Persona_Moral_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Persona_Moral_MPIGridModel> resultData = new List<Detalle_de_Persona_Moral_MPIGridModel>();
            string where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Persona_Moral_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Persona_Moral_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Persona_Moral_MPIs != null)
            {
                resultData = result.Detalle_de_Persona_Moral_MPIs.Select(m => new Detalle_de_Persona_Moral_MPIGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ??(string)m.Localidad_Localidad.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Servicio_de_Apoyo_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Servicio_de_Apoyo_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Servicio_de_Apoyo_MPIs == null)
                result.Detalle_de_Servicio_de_Apoyo_MPIs = new List<Detalle_de_Servicio_de_Apoyo_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Servicio_de_Apoyo_MPIs.Select(m => new Detalle_de_Servicio_de_Apoyo_MPIGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Dictamen = m.Dictamen
			,Responsable = m.Responsable
                        ,Victima = m.Victima
                        ,VictimaNombre = CultureHelper.GetTraduction(m.Victima_Solicitante_MPI.Clave.ToString(), "Nombre") ??(string)m.Victima_Solicitante_MPI.Nombre

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Servicio_de_Apoyo_MPIGridModel> GetDetalle_de_Servicio_de_Apoyo_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Servicio_de_Apoyo_MPIGridModel> resultData = new List<Detalle_de_Servicio_de_Apoyo_MPIGridModel>();
            string where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Servicio_de_Apoyo_MPIs != null)
            {
                resultData = result.Detalle_de_Servicio_de_Apoyo_MPIs.Select(m => new Detalle_de_Servicio_de_Apoyo_MPIGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Dictamen = m.Dictamen
			,Responsable = m.Responsable
                        ,Victima = m.Victima
                        ,VictimaNombre = CultureHelper.GetTraduction(m.Victima_Solicitante_MPI.Clave.ToString(), "Nombre") ??(string)m.Victima_Solicitante_MPI.Nombre


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Datos_del_Testigo_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Datos_del_Testigo_MPIs == null)
                result.Detalle_de_Datos_del_Testigo_MPIs = new List<Detalle_de_Datos_del_Testigo_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Datos_del_Testigo_MPIs.Select(m => new Detalle_de_Datos_del_Testigo_MPIGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
			,Fecha_de_Nacimento_del_Tutor = (m.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extencion_del_Tutor = m.Extencion_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Narrativa_del_Testigo = m.Narrativa_del_Testigo
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = m.Pais_del_Hecho
                        ,Pais_del_HechoNombre = CultureHelper.GetTraduction(m.Pais_del_Hecho_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Hecho_Pais.Nombre
                        ,Estado_del_Hecho = m.Estado_del_Hecho
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_del_Hecho = m.Municipio_del_Hecho
                        ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(m.Municipio_del_Hecho_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Hecho_Municipio.Nombre
                        ,Colonia_del_Hecho = m.Colonia_del_Hecho
                        ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(m.Colonia_del_Hecho_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Hecho_Colonia.Nombre
			,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
			,Calle_del_Hecho = m.Calle_del_Hecho
			,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
			,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
			,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
			,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
			,Latitud_del_Hecho = m.Latitud_del_Hecho
			,Longitud_del_Hecho = m.Longitud_del_Hecho
                        ,Tipo_del_Lugar_del_Hecho = m.Tipo_del_Lugar_del_Hecho
                        ,Tipo_del_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Datos_del_Testigo_MPIGridModel> GetDetalle_de_Datos_del_Testigo_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Datos_del_Testigo_MPIGridModel> resultData = new List<Detalle_de_Datos_del_Testigo_MPIGridModel>();
            string where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Datos_del_Testigo_MPIs != null)
            {
                resultData = result.Detalle_de_Datos_del_Testigo_MPIs.Select(m => new Detalle_de_Datos_del_Testigo_MPIGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
			,Fecha_de_Nacimento_del_Tutor = (m.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_Tutor = m.Pais_del_Tutor
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extencion_del_Tutor = m.Extencion_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Narrativa_del_Testigo = m.Narrativa_del_Testigo
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ??(string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = m.Pais_del_Hecho
                        ,Pais_del_HechoNombre = CultureHelper.GetTraduction(m.Pais_del_Hecho_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Hecho_Pais.Nombre
                        ,Estado_del_Hecho = m.Estado_del_Hecho
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_del_Hecho = m.Municipio_del_Hecho
                        ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(m.Municipio_del_Hecho_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Hecho_Municipio.Nombre
                        ,Colonia_del_Hecho = m.Colonia_del_Hecho
                        ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(m.Colonia_del_Hecho_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Hecho_Colonia.Nombre
			,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
			,Calle_del_Hecho = m.Calle_del_Hecho
			,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
			,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
			,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
			,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
			,Latitud_del_Hecho = m.Latitud_del_Hecho
			,Longitud_del_Hecho = m.Longitud_del_Hecho
                        ,Tipo_del_Lugar_del_Hecho = m.Tipo_del_Lugar_del_Hecho
                        ,Tipo_del_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ??(string)m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Agente_del_Ministerio_Publico(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Agente_del_Ministerio_PublicoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Agente_del_Ministerio_Publicos == null)
                result.Detalle_de_Agente_del_Ministerio_Publicos = new List<Detalle_de_Agente_del_Ministerio_Publico>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Agente_del_Ministerio_Publicos.Select(m => new Detalle_de_Agente_del_Ministerio_PublicoGridModel
                {
                    Clave = m.Clave

			,Agente_del_Ministerio_Publico = m.Agente_del_Ministerio_Publico
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Especialidad = m.Especialidad

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Agente_del_Ministerio_PublicoGridModel> GetDetalle_de_Agente_del_Ministerio_PublicoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Agente_del_Ministerio_PublicoGridModel> resultData = new List<Detalle_de_Agente_del_Ministerio_PublicoGridModel>();
            string where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Agente_del_Ministerio_Publicos != null)
            {
                resultData = result.Detalle_de_Agente_del_Ministerio_Publicos.Select(m => new Detalle_de_Agente_del_Ministerio_PublicoGridModel
                    {
                        Clave = m.Clave

			,Agente_del_Ministerio_Publico = m.Agente_del_Ministerio_Publico
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Especialidad = m.Especialidad


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Servicios_Periciales(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Servicios_PericialesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Servicios_Pericialess == null)
                result.Detalle_de_Servicios_Pericialess = new List<Detalle_de_Servicios_Periciales>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Servicios_Pericialess.Select(m => new Detalle_de_Servicios_PericialesGridModel
                {
                    Clave = m.Clave

                        ,Servicio = m.Servicio
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_Dictamen = m.Estatus_del_Dictamen
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ??(string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
			,Observaciones = m.Observaciones
			,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_Proviene = m.Rol_de_Donde_Proviene
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ??(string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,ObservacionesD = m.ObservacionesD

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Servicios_PericialesGridModel> GetDetalle_de_Servicios_PericialesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Servicios_PericialesGridModel> resultData = new List<Detalle_de_Servicios_PericialesGridModel>();
            string where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Servicios_Pericialess != null)
            {
                resultData = result.Detalle_de_Servicios_Pericialess.Select(m => new Detalle_de_Servicios_PericialesGridModel
                    {
                        Clave = m.Clave

                        ,Servicio = m.Servicio
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_Dictamen = m.Estatus_del_Dictamen
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ??(string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
			,Observaciones = m.Observaciones
			,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_Proviene = m.Rol_de_Donde_Proviene
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ??(string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,ObservacionesD = m.ObservacionesD


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Oficio_de_Servicio_Pericial(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Oficio_de_Servicio_PericialGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Oficio_de_Servicio_Pericials == null)
                result.Detalle_de_Oficio_de_Servicio_Pericials = new List<Detalle_de_Oficio_de_Servicio_Pericial>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Oficio_de_Servicio_Pericials.Select(m => new Detalle_de_Oficio_de_Servicio_PericialGridModel
                {
                    Clave = m.Clave

                        ,Oficio = m.Oficio
                        ,OficioDescripcion = CultureHelper.GetTraduction(m.Oficio_Tipo_de_Oficios.Clave.ToString(), "Descripcion") ??(string)m.Oficio_Tipo_de_Oficios.Descripcion
                        ,Servicio_Pericial = m.Servicio_Pericial
                        ,Servicio_PericialServicio = CultureHelper.GetTraduction(m.Servicio_Pericial_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Servicio_Pericial_Servicios_Periciales.Servicio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Oficio_de_Servicio_PericialGridModel> GetDetalle_de_Oficio_de_Servicio_PericialData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Oficio_de_Servicio_PericialGridModel> resultData = new List<Detalle_de_Oficio_de_Servicio_PericialGridModel>();
            string where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Oficio_de_Servicio_Pericials != null)
            {
                resultData = result.Detalle_de_Oficio_de_Servicio_Pericials.Select(m => new Detalle_de_Oficio_de_Servicio_PericialGridModel
                    {
                        Clave = m.Clave

                        ,Oficio = m.Oficio
                        ,OficioDescripcion = CultureHelper.GetTraduction(m.Oficio_Tipo_de_Oficios.Clave.ToString(), "Descripcion") ??(string)m.Oficio_Tipo_de_Oficios.Descripcion
                        ,Servicio_Pericial = m.Servicio_Pericial
                        ,Servicio_PericialServicio = CultureHelper.GetTraduction(m.Servicio_Pericial_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Servicio_Pericial_Servicios_Periciales.Servicio


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_IPH_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_IPH_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_IPH_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_IPH_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_IPH_MPIs == null)
                result.Detalle_de_IPH_MPIs = new List<Detalle_de_IPH_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_IPH_MPIs.Select(m => new Detalle_de_IPH_MPIGridModel
                {
                    Clave = m.Clave

			,NUE = m.NUE
			,Folio = m.Folio
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Documentos = m.Documentos
			,Archivo = m.Archivo
			,Hora = m.Hora

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_IPH_MPIGridModel> GetDetalle_de_IPH_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_IPH_MPIGridModel> resultData = new List<Detalle_de_IPH_MPIGridModel>();
            string where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_IPH_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_IPH_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_IPH_MPIs != null)
            {
                resultData = result.Detalle_de_IPH_MPIs.Select(m => new Detalle_de_IPH_MPIGridModel
                    {
                        Clave = m.Clave

			,NUE = m.NUE
			,Folio = m.Folio
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Documentos = m.Documentos
			,Archivo = m.Archivo
			,Hora = m.Hora


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Solicitante_en_Audiencias_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Solicitante_en_Audiencias_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Solicitante_en_Audiencias_MPIs == null)
                result.Detalle_de_Solicitante_en_Audiencias_MPIs = new List<Detalle_de_Solicitante_en_Audiencias_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Solicitante_en_Audiencias_MPIs.Select(m => new Detalle_de_Solicitante_en_Audiencias_MPIGridModel
                {
                    Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre = CultureHelper.GetTraduction(m.Nombre_Solicitante_MPI.Clave.ToString(), "Nombre") ??(string)m.Nombre_Solicitante_MPI.Nombre
			,Direccion = m.Direccion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Solicitante_en_Audiencias_MPIGridModel> GetDetalle_de_Solicitante_en_Audiencias_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Solicitante_en_Audiencias_MPIGridModel> resultData = new List<Detalle_de_Solicitante_en_Audiencias_MPIGridModel>();
            string where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Solicitante_en_Audiencias_MPIs != null)
            {
                resultData = result.Detalle_de_Solicitante_en_Audiencias_MPIs.Select(m => new Detalle_de_Solicitante_en_Audiencias_MPIGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre = CultureHelper.GetTraduction(m.Nombre_Solicitante_MPI.Clave.ToString(), "Nombre") ??(string)m.Nombre_Solicitante_MPI.Nombre
			,Direccion = m.Direccion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Requerido_en_Audiencias_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Requerido_en_Audiencias_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Requerido_en_Audiencias_MPIs == null)
                result.Detalle_de_Requerido_en_Audiencias_MPIs = new List<Detalle_de_Requerido_en_Audiencias_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Requerido_en_Audiencias_MPIs.Select(m => new Detalle_de_Requerido_en_Audiencias_MPIGridModel
                {
                    Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre = CultureHelper.GetTraduction(m.Nombre_Requerido_MPI.Clave.ToString(), "Nombre") ??(string)m.Nombre_Requerido_MPI.Nombre
			,Direccion = m.Direccion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Requerido_en_Audiencias_MPIGridModel> GetDetalle_de_Requerido_en_Audiencias_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Requerido_en_Audiencias_MPIGridModel> resultData = new List<Detalle_de_Requerido_en_Audiencias_MPIGridModel>();
            string where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Requerido_en_Audiencias_MPIs != null)
            {
                resultData = result.Detalle_de_Requerido_en_Audiencias_MPIs.Select(m => new Detalle_de_Requerido_en_Audiencias_MPIGridModel
                    {
                        Clave = m.Clave

                        ,Nombre = m.Nombre
                        ,NombreNombre = CultureHelper.GetTraduction(m.Nombre_Requerido_MPI.Clave.ToString(), "Nombre") ??(string)m.Nombre_Requerido_MPI.Nombre
			,Direccion = m.Direccion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Citatorio_Audiencias(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Citatorio_AudienciasGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Citatorio_AudienciasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Citatorio_AudienciasApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Citatorio_Audienciass == null)
                result.Detalle_de_Citatorio_Audienciass = new List<Detalle_de_Citatorio_Audiencias>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Citatorio_Audienciass.Select(m => new Detalle_de_Citatorio_AudienciasGridModel
                {
                    Clave = m.Clave

			,Numero_de_audiencia_citatorio = m.Numero_de_audiencia_citatorio
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Fecha_de_Aceptacion = (m.Fecha_de_Aceptacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aceptacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Aceptacion = m.Hora_de_Aceptacion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Citatorio_AudienciasGridModel> GetDetalle_de_Citatorio_AudienciasData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Citatorio_AudienciasGridModel> resultData = new List<Detalle_de_Citatorio_AudienciasGridModel>();
            string where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Citatorio_AudienciasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Citatorio_AudienciasApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Citatorio_Audienciass != null)
            {
                resultData = result.Detalle_de_Citatorio_Audienciass.Select(m => new Detalle_de_Citatorio_AudienciasGridModel
                    {
                        Clave = m.Clave

			,Numero_de_audiencia_citatorio = m.Numero_de_audiencia_citatorio
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Fecha_de_Aceptacion = (m.Fecha_de_Aceptacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Aceptacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Aceptacion = m.Hora_de_Aceptacion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Documentos_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Documentos_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Documentos_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Documentos_MPIs == null)
                result.Detalle_de_Documentos_MPIs = new List<Detalle_de_Documentos_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Documentos_MPIs.Select(m => new Detalle_de_Documentos_MPIGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Documento = m.Documento
			,Archivo = m.Archivo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Documentos_MPIGridModel> GetDetalle_de_Documentos_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Documentos_MPIGridModel> resultData = new List<Detalle_de_Documentos_MPIGridModel>();
            string where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Documentos_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Documentos_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Documentos_MPIs != null)
            {
                resultData = result.Detalle_de_Documentos_MPIs.Select(m => new Detalle_de_Documentos_MPIGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Documento = m.Documento
			,Archivo = m.Archivo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Coincidencias_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Coincidencias_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Coincidencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Coincidencias_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Coincidencias_MPIs == null)
                result.Detalle_de_Coincidencias_MPIs = new List<Detalle_de_Coincidencias_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Coincidencias_MPIs.Select(m => new Detalle_de_Coincidencias_MPIGridModel
                {
                    Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
			,NUC = m.NUC
			,Rol = m.Rol

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Coincidencias_MPIGridModel> GetDetalle_de_Coincidencias_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Coincidencias_MPIGridModel> resultData = new List<Detalle_de_Coincidencias_MPIGridModel>();
            string where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Coincidencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Coincidencias_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Coincidencias_MPIs != null)
            {
                resultData = result.Detalle_de_Coincidencias_MPIs.Select(m => new Detalle_de_Coincidencias_MPIGridModel
                    {
                        Clave = m.Clave

			,Nombre_Completo = m.Nombre_Completo
			,Alias = m.Alias
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
			,NUC = m.NUC
			,Rol = m.Rol


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Indicios(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_IndiciosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Indicios.Expediente_Inicial_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Indicios.Expediente_Inicial_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_IndiciosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Indicioss == null)
                result.Detalle_de_Indicioss = new List<Detalle_de_Indicios>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Indicioss.Select(m => new Detalle_de_IndiciosGridModel
                {
                    Clave = m.Clave

			,Numero_de_Indicio = m.Numero_de_Indicio
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Indicio = m.Descripcion_de_Indicio
			,Motivo_de_Indicio = m.Motivo_de_Indicio
                        ,Diligencia = m.Diligencia
                        ,DiligenciaServicio = CultureHelper.GetTraduction(m.Diligencia_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_Servicios_Periciales.Servicio
			,Ubicacion = m.Ubicacion
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Indicio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_de_Indicio.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_IndiciosGridModel> GetDetalle_de_IndiciosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_IndiciosGridModel> resultData = new List<Detalle_de_IndiciosGridModel>();
            string where = "Detalle_de_Indicios.Expediente_Inicial_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Indicios.Expediente_Inicial_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_IndiciosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Indicioss != null)
            {
                resultData = result.Detalle_de_Indicioss.Select(m => new Detalle_de_IndiciosGridModel
                    {
                        Clave = m.Clave

			,Numero_de_Indicio = m.Numero_de_Indicio
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Indicio = m.Descripcion_de_Indicio
			,Motivo_de_Indicio = m.Motivo_de_Indicio
                        ,Diligencia = m.Diligencia
                        ,DiligenciaServicio = CultureHelper.GetTraduction(m.Diligencia_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_Servicios_Periciales.Servicio
			,Ubicacion = m.Ubicacion
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Indicio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_de_Indicio.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Bitacora_de_Canalizacion_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Bitacora_de_Canalizacion_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial='" + RelationId + "'";
            }
            var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Bitacora_de_Canalizacion_MPIs == null)
                result.Detalle_Bitacora_de_Canalizacion_MPIs = new List<Detalle_Bitacora_de_Canalizacion_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Bitacora_de_Canalizacion_MPIs.Select(m => new Detalle_Bitacora_de_Canalizacion_MPIGridModel
                {
                    Clave = m.Clave

			,Fecha_de_Cambio_de_Estatus = (m.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cambio_de_Estatus = m.Hora_de_Cambio_de_Estatus
                        ,Estatus_Interno = m.Estatus_Interno
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                        ,Estatus_de_Canalizacion = m.Estatus_de_Canalizacion
                        ,Estatus_de_CanalizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Canalizacion_Estatus_Orientador.Clave.ToString(), "Descripcion") ??(string)m.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Bitacora_de_Canalizacion_MPIGridModel> GetDetalle_Bitacora_de_Canalizacion_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Bitacora_de_Canalizacion_MPIGridModel> resultData = new List<Detalle_Bitacora_de_Canalizacion_MPIGridModel>();
            string where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Bitacora_de_Canalizacion_MPIs != null)
            {
                resultData = result.Detalle_Bitacora_de_Canalizacion_MPIs.Select(m => new Detalle_Bitacora_de_Canalizacion_MPIGridModel
                    {
                        Clave = m.Clave

			,Fecha_de_Cambio_de_Estatus = (m.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cambio_de_Estatus = m.Hora_de_Cambio_de_Estatus
                        ,Estatus_Interno = m.Estatus_Interno
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                        ,Estatus_de_Canalizacion = m.Estatus_de_Canalizacion
                        ,Estatus_de_CanalizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Canalizacion_Estatus_Orientador.Clave.ToString(), "Descripcion") ??(string)m.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Expediente_Inicial varExpediente_Inicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Datos_de_la_Victima_MPIInfo =
                        _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Datos_de_la_Victima_MPIInfo.Detalle_de_Datos_de_la_Victima_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Datos_de_la_Victima_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Datos_de_la_Victima_MPIItem in Detalle_de_Datos_de_la_Victima_MPIInfo.Detalle_de_Datos_de_la_Victima_MPIs)
                            resultDetalle_de_Datos_de_la_Victima_MPI = resultDetalle_de_Datos_de_la_Victima_MPI
                                              && _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Delete(Detalle_de_Datos_de_la_Victima_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Datos_de_la_Victima_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Datos_del_Imputado_MPIInfo =
                        _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Datos_del_Imputado_MPIInfo.Detalle_de_Datos_del_Imputado_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Datos_del_Imputado_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Datos_del_Imputado_MPIItem in Detalle_de_Datos_del_Imputado_MPIInfo.Detalle_de_Datos_del_Imputado_MPIs)
                            resultDetalle_de_Datos_del_Imputado_MPI = resultDetalle_de_Datos_del_Imputado_MPI
                                              && _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Delete(Detalle_de_Datos_del_Imputado_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Datos_del_Imputado_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_Datos_de_Delito_MPIInfo =
                        _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Datos_de_Delito_MPIInfo.Detalle_Datos_de_Delito_MPIs.Count > 0)
                    {
                        var resultDetalle_Datos_de_Delito_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Datos_de_Delito_MPIItem in Detalle_Datos_de_Delito_MPIInfo.Detalle_Datos_de_Delito_MPIs)
                            resultDetalle_Datos_de_Delito_MPI = resultDetalle_Datos_de_Delito_MPI
                                              && _IDetalle_Datos_de_Delito_MPIApiConsumer.Delete(Detalle_Datos_de_Delito_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_Datos_de_Delito_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Persona_Moral_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Persona_Moral_MPIInfo =
                        _IDetalle_de_Persona_Moral_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Persona_Moral_MPIInfo.Detalle_de_Persona_Moral_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Persona_Moral_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Persona_Moral_MPIItem in Detalle_de_Persona_Moral_MPIInfo.Detalle_de_Persona_Moral_MPIs)
                            resultDetalle_de_Persona_Moral_MPI = resultDetalle_de_Persona_Moral_MPI
                                              && _IDetalle_de_Persona_Moral_MPIApiConsumer.Delete(Detalle_de_Persona_Moral_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Persona_Moral_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Servicio_de_Apoyo_MPIInfo =
                        _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Servicio_de_Apoyo_MPIInfo.Detalle_de_Servicio_de_Apoyo_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Servicio_de_Apoyo_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Servicio_de_Apoyo_MPIItem in Detalle_de_Servicio_de_Apoyo_MPIInfo.Detalle_de_Servicio_de_Apoyo_MPIs)
                            resultDetalle_de_Servicio_de_Apoyo_MPI = resultDetalle_de_Servicio_de_Apoyo_MPI
                                              && _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Delete(Detalle_de_Servicio_de_Apoyo_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Servicio_de_Apoyo_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Datos_del_Testigo_MPIInfo =
                        _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Datos_del_Testigo_MPIInfo.Detalle_de_Datos_del_Testigo_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Datos_del_Testigo_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Datos_del_Testigo_MPIItem in Detalle_de_Datos_del_Testigo_MPIInfo.Detalle_de_Datos_del_Testigo_MPIs)
                            resultDetalle_de_Datos_del_Testigo_MPI = resultDetalle_de_Datos_del_Testigo_MPI
                                              && _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Delete(Detalle_de_Datos_del_Testigo_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Datos_del_Testigo_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Agente_del_Ministerio_PublicoInfo =
                        _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Agente_del_Ministerio_PublicoInfo.Detalle_de_Agente_del_Ministerio_Publicos.Count > 0)
                    {
                        var resultDetalle_de_Agente_del_Ministerio_Publico = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Agente_del_Ministerio_PublicoItem in Detalle_de_Agente_del_Ministerio_PublicoInfo.Detalle_de_Agente_del_Ministerio_Publicos)
                            resultDetalle_de_Agente_del_Ministerio_Publico = resultDetalle_de_Agente_del_Ministerio_Publico
                                              && _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.Delete(Detalle_de_Agente_del_Ministerio_PublicoItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Agente_del_Ministerio_Publico)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Servicios_PericialesInfo =
                        _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Servicios_PericialesInfo.Detalle_de_Servicios_Pericialess.Count > 0)
                    {
                        var resultDetalle_de_Servicios_Periciales = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Servicios_PericialesItem in Detalle_de_Servicios_PericialesInfo.Detalle_de_Servicios_Pericialess)
                            resultDetalle_de_Servicios_Periciales = resultDetalle_de_Servicios_Periciales
                                              && _IDetalle_de_Servicios_PericialesApiConsumer.Delete(Detalle_de_Servicios_PericialesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Servicios_Periciales)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Oficio_de_Servicio_PericialInfo =
                        _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Oficio_de_Servicio_PericialInfo.Detalle_de_Oficio_de_Servicio_Pericials.Count > 0)
                    {
                        var resultDetalle_de_Oficio_de_Servicio_Pericial = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Oficio_de_Servicio_PericialItem in Detalle_de_Oficio_de_Servicio_PericialInfo.Detalle_de_Oficio_de_Servicio_Pericials)
                            resultDetalle_de_Oficio_de_Servicio_Pericial = resultDetalle_de_Oficio_de_Servicio_Pericial
                                              && _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.Delete(Detalle_de_Oficio_de_Servicio_PericialItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Oficio_de_Servicio_Pericial)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_IPH_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_IPH_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_IPH_MPIInfo =
                        _IDetalle_de_IPH_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_IPH_MPIInfo.Detalle_de_IPH_MPIs.Count > 0)
                    {
                        var resultDetalle_de_IPH_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_IPH_MPIItem in Detalle_de_IPH_MPIInfo.Detalle_de_IPH_MPIs)
                            resultDetalle_de_IPH_MPI = resultDetalle_de_IPH_MPI
                                              && _IDetalle_de_IPH_MPIApiConsumer.Delete(Detalle_de_IPH_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_IPH_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Solicitante_en_Audiencias_MPIInfo =
                        _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Solicitante_en_Audiencias_MPIInfo.Detalle_de_Solicitante_en_Audiencias_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Solicitante_en_Audiencias_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Solicitante_en_Audiencias_MPIItem in Detalle_de_Solicitante_en_Audiencias_MPIInfo.Detalle_de_Solicitante_en_Audiencias_MPIs)
                            resultDetalle_de_Solicitante_en_Audiencias_MPI = resultDetalle_de_Solicitante_en_Audiencias_MPI
                                              && _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.Delete(Detalle_de_Solicitante_en_Audiencias_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Solicitante_en_Audiencias_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Requerido_en_Audiencias_MPIInfo =
                        _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Requerido_en_Audiencias_MPIInfo.Detalle_de_Requerido_en_Audiencias_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Requerido_en_Audiencias_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Requerido_en_Audiencias_MPIItem in Detalle_de_Requerido_en_Audiencias_MPIInfo.Detalle_de_Requerido_en_Audiencias_MPIs)
                            resultDetalle_de_Requerido_en_Audiencias_MPI = resultDetalle_de_Requerido_en_Audiencias_MPI
                                              && _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.Delete(Detalle_de_Requerido_en_Audiencias_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Requerido_en_Audiencias_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Citatorio_AudienciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Citatorio_AudienciasInfo =
                        _IDetalle_de_Citatorio_AudienciasApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Citatorio_AudienciasInfo.Detalle_de_Citatorio_Audienciass.Count > 0)
                    {
                        var resultDetalle_de_Citatorio_Audiencias = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Citatorio_AudienciasItem in Detalle_de_Citatorio_AudienciasInfo.Detalle_de_Citatorio_Audienciass)
                            resultDetalle_de_Citatorio_Audiencias = resultDetalle_de_Citatorio_Audiencias
                                              && _IDetalle_de_Citatorio_AudienciasApiConsumer.Delete(Detalle_de_Citatorio_AudienciasItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Citatorio_Audiencias)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Documentos_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Documentos_MPIInfo =
                        _IDetalle_de_Documentos_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Documentos_MPIInfo.Detalle_de_Documentos_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Documentos_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Documentos_MPIItem in Detalle_de_Documentos_MPIInfo.Detalle_de_Documentos_MPIs)
                            resultDetalle_de_Documentos_MPI = resultDetalle_de_Documentos_MPI
                                              && _IDetalle_de_Documentos_MPIApiConsumer.Delete(Detalle_de_Documentos_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Documentos_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Coincidencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_Coincidencias_MPIInfo =
                        _IDetalle_de_Coincidencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Coincidencias_MPIInfo.Detalle_de_Coincidencias_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Coincidencias_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Coincidencias_MPIItem in Detalle_de_Coincidencias_MPIInfo.Detalle_de_Coincidencias_MPIs)
                            resultDetalle_de_Coincidencias_MPI = resultDetalle_de_Coincidencias_MPI
                                              && _IDetalle_de_Coincidencias_MPIApiConsumer.Delete(Detalle_de_Coincidencias_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Coincidencias_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Indicios.Expediente_Inicial_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Indicios.Expediente_Inicial_MPI='" + id + "'";
                    }
                    var Detalle_de_IndiciosInfo =
                        _IDetalle_de_IndiciosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_IndiciosInfo.Detalle_de_Indicioss.Count > 0)
                    {
                        var resultDetalle_de_Indicios = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_IndiciosItem in Detalle_de_IndiciosInfo.Detalle_de_Indicioss)
                            resultDetalle_de_Indicios = resultDetalle_de_Indicios
                                              && _IDetalle_de_IndiciosApiConsumer.Delete(Detalle_de_IndiciosItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Indicios)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial='" + id + "'";
                    }
                    var Detalle_Bitacora_de_Canalizacion_MPIInfo =
                        _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Bitacora_de_Canalizacion_MPIInfo.Detalle_Bitacora_de_Canalizacion_MPIs.Count > 0)
                    {
                        var resultDetalle_Bitacora_de_Canalizacion_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Bitacora_de_Canalizacion_MPIItem in Detalle_Bitacora_de_Canalizacion_MPIInfo.Detalle_Bitacora_de_Canalizacion_MPIs)
                            resultDetalle_Bitacora_de_Canalizacion_MPI = resultDetalle_Bitacora_de_Canalizacion_MPI
                                              && _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Delete(Detalle_Bitacora_de_Canalizacion_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_Bitacora_de_Canalizacion_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IExpediente_InicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Expediente_InicialModel varExpediente_Inicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Expediente_InicialInfo = new Expediente_Inicial
                    {
                        Clave = varExpediente_Inicial.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varExpediente_Inicial.Hora_de_Registro
                        ,Usuario_que_Registra = varExpediente_Inicial.Usuario_que_Registra
                        ,Detenido = varExpediente_Inicial.Detenido
                        ,NUC = varExpediente_Inicial.NUC
                        ,NIC = varExpediente_Inicial.NIC
                        ,Hora_del_Detenido = varExpediente_Inicial.Hora_del_Detenido
                        ,Hora_Puesto_a_Disposicion = varExpediente_Inicial.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_Apoyo = varExpediente_Inicial.Solicitar_Servicos_de_Apoyo
                        ,Narrativa_Breve_de_los_Hechos = varExpediente_Inicial.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varExpediente_Inicial.Prioridad_del_Hecho
                        ,Turno = varExpediente_Inicial.Turno
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_del_Hecho)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Hecho = varExpediente_Inicial.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPI = varExpediente_Inicial.Pais_de_los_Hechos_MPI
                        ,Estado_de_los_Hechos_MPI = varExpediente_Inicial.Estado_de_los_Hechos_MPI
                        ,Municipio_de_los_Hechos_MPI = varExpediente_Inicial.Municipio_de_los_Hechos_MPI
                        ,Colonia_de_los_Hechos_MPI = varExpediente_Inicial.Colonia_de_los_Hechos_MPI
                        ,Codigo_Postal_de_los_Hechos_MPI = varExpediente_Inicial.Codigo_Postal_de_los_Hechos_MPI
                        ,Calle_de_los_Hechos_MPI = varExpediente_Inicial.Calle_de_los_Hechos_MPI
                        ,Entre_Calle_MPI = varExpediente_Inicial.Entre_Calle_MPI
                        ,Y_Calle_MPI = varExpediente_Inicial.Y_Calle_MPI
                        ,Numero_Exrterior_de_los_Hechos_MPI = varExpediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI
                        ,Numero_Interior_de_los_Hechos_MPI = varExpediente_Inicial.Numero_Interior_de_los_Hechos_MPI
                        ,Latitud_MPI = varExpediente_Inicial.Latitud_MPI
                        ,Longitud_MPI = varExpediente_Inicial.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPI = varExpediente_Inicial.Tipo_de_Lugar_del_Hecho_MPI
                        ,Persona_Moral = varExpediente_Inicial.Persona_Moral
                        ,Requiere_Diligencia = varExpediente_Inicial.Requiere_Diligencia
                        ,Numero_de_Expediente_Victima = varExpediente_Inicial.Numero_de_Expediente_Victima
                        ,Requiere_Traductor = varExpediente_Inicial.Requiere_Traductor
                        ,Lengua_Originaria = varExpediente_Inicial.Lengua_Originaria
                        ,Idioma = varExpediente_Inicial.Idioma
                        ,Titulo_del_Hecho = varExpediente_Inicial.Titulo_del_Hecho
                        ,Asignar_Agente_del_Ministerio_Publico = varExpediente_Inicial.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_Publico = varExpediente_Inicial.Nombre_de_Agente_del_Ministerio_Publico
                        ,Tipo_de_Oficio = varExpediente_Inicial.Tipo_de_Oficio
                        ,Delegacion = varExpediente_Inicial.Delegacion
                        ,Agencia = varExpediente_Inicial.Agencia
                        ,Solicitar_Diligencias = varExpediente_Inicial.Solicitar_Diligencias
                        ,NUC_Audiencias = varExpediente_Inicial.NUC_Audiencias
                        ,NIC_Audiencias = varExpediente_Inicial.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Registro_Audiencias)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Registro_Audiencias, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro_Audiencias = varExpediente_Inicial.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_Audiencias = varExpediente_Inicial.Tipo_de_Oficio_Audiencias
                        ,Delegacion_Audiencias = varExpediente_Inicial.Delegacion_Audiencias
                        ,Domicilio_Delegacion_A = varExpediente_Inicial.Domicilio_Delegacion_A
                        ,Numero_de_Expediente = varExpediente_Inicial.Numero_de_Expediente
                        ,NUAT = varExpediente_Inicial.NUAT
                        ,Fecha_de_RegistroI = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_RegistroI)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_RegistroI, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_RegistroI = varExpediente_Inicial.Hora_de_RegistroI
                        ,Estatus = varExpediente_Inicial.Estatus
                        ,Canalizar_a = varExpediente_Inicial.Canalizar_a
                        ,Delito_Principal = varExpediente_Inicial.Delito_Principal
                        ,Tipo_de_Acuerdo = varExpediente_Inicial.Tipo_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Inicio_de_Acuerdo)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cumplimiento = varExpediente_Inicial.Hora_de_Cumplimiento
                        ,Domicilio_para_el_Cumplimiento = varExpediente_Inicial.Domicilio_para_el_Cumplimiento
                        ,Monto_de_Reparacion_de_Danos = varExpediente_Inicial.Monto_de_Reparacion_de_Danos
                        ,Parcialidades = varExpediente_Inicial.Parcialidades
                        ,Periodicidad = varExpediente_Inicial.Periodicidad
                        ,Acepta_Acuerdo = varExpediente_Inicial.Acepta_Acuerdo
                        ,Motivo_de_Rechazo_de_Acuerdo = varExpediente_Inicial.Motivo_de_Rechazo_de_Acuerdo

                    };

                    result = !IsNew ?
                        _IExpediente_InicialApiConsumer.Update(Expediente_InicialInfo, null, null).Resource.ToString() :
                         _IExpediente_InicialApiConsumer.Insert(Expediente_InicialInfo, null, null).Resource.ToString();
					Session["KeyValueInserted"] = result;
                    return Json(result, JsonRequestBehavior.AllowGet);
				//}
				//return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Datos_de_la_Victima_MPI(int MasterId, int referenceId, List<Detalle_de_Datos_de_la_Victima_MPIGridModelPost> Detalle_de_Datos_de_la_Victima_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Datos_de_la_Victima_MPIData = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Datos_de_la_Victima_MPIData == null || Detalle_de_Datos_de_la_Victima_MPIData.Detalle_de_Datos_de_la_Victima_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Datos_de_la_Victima_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Datos_de_la_Victima_MPI in Detalle_de_Datos_de_la_Victima_MPIData.Detalle_de_Datos_de_la_Victima_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Datos_de_la_Victima_MPI Detalle_de_Datos_de_la_Victima_MPI1 = varDetalle_de_Datos_de_la_Victima_MPI;

                    if (Detalle_de_Datos_de_la_Victima_MPIItems != null && Detalle_de_Datos_de_la_Victima_MPIItems.Any(m => m.Clave == Detalle_de_Datos_de_la_Victima_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Datos_de_la_Victima_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Datos_de_la_Victima_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Datos_de_la_Victima_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Insert(varDetalle_de_Datos_de_la_Victima_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Datos_de_la_Victima_MPI(List<Detalle_de_Datos_de_la_Victima_MPIGridModelPost> Detalle_de_Datos_de_la_Victima_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Datos_de_la_Victima_MPI(MasterId, referenceId, Detalle_de_Datos_de_la_Victima_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Datos_de_la_Victima_MPIItems != null && Detalle_de_Datos_de_la_Victima_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Datos_de_la_Victima_MPIItem in Detalle_de_Datos_de_la_Victima_MPIItems)
                    {








































































































                        //Removal Request
                        if (Detalle_de_Datos_de_la_Victima_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Delete(Detalle_de_Datos_de_la_Victima_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Datos_de_la_Victima_MPIItem.Clave = 0;

                        var Detalle_de_Datos_de_la_Victima_MPIData = new Detalle_de_Datos_de_la_Victima_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Datos_de_la_Victima_MPIItem.Clave
                            ,Nombre = Detalle_de_Datos_de_la_Victima_MPIItem.Nombre
                            ,Apellido_Paterno = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Materno
                            ,Nombre_Completo = Detalle_de_Datos_de_la_Victima_MPIItem.Nombre_Completo
                            ,Fecha_de_Nacimiento = (Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad = Detalle_de_Datos_de_la_Victima_MPIItem.Edad
                            ,Sexo = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil))
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion))
                            ,Numero_de_Identificacion = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_de_Identificacion
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad))
                            ,Escolaridad = (Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad))
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion))
                            ,Pais = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais))
                            ,Estado = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia))
                            ,Codigo_Postal = Detalle_de_Datos_de_la_Victima_MPIItem.Codigo_Postal
                            ,Calle = Detalle_de_Datos_de_la_Victima_MPIItem.Calle
                            ,Numero_Exterior = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Interior
                            ,Telefono = Detalle_de_Datos_de_la_Victima_MPIItem.Telefono
                            ,Extencion = Detalle_de_Datos_de_la_Victima_MPIItem.Extencion
                            ,Celular = Detalle_de_Datos_de_la_Victima_MPIItem.Celular
                            ,Correo_Electronico = Detalle_de_Datos_de_la_Victima_MPIItem.Correo_Electronico
                            ,Incapaz = Detalle_de_Datos_de_la_Victima_MPIItem.Incapaz
                            ,Nombre_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Nombre_del_Tutor
                            ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Paterno_del_Tutor
                            ,Apellido_Materno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Materno_del_Tutor
                            ,Nombre_Completo_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Nombre_Completo_del_Tutor
                            ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento_del_Tutor!= null) ? DateTime.ParseExact(Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Edad_del_Tutor
                            ,Sexo_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo_del_Tutor))
                            ,Estado_Civil_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil_del_Tutor))
                            ,Tipo_de_Identificacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion_del_Tutor))
                            ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_de_Identificacion_del_Tutor
                            ,Nacionalidad_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad_del_Tutor))
                            ,Escolaridad_del_Tutor = (Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad_del_Tutor) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad_del_Tutor))
                            ,Ocupacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion_del_Tutor))
                            ,Pais_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_del_Tutor))
                            ,Estado_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_del_Tutor))
                            ,Municipio_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_del_Tutor))
                            ,Localidad_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Localidad_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Localidad_del_Tutor))
                            ,Colonia_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_del_Tutor))
                            ,Codigo_Postal_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Codigo_Postal_del_Tutor
                            ,Calle_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Calle_del_Tutor
                            ,Numero_Exterior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Exterior_del_Tutor
                            ,Numero_Interior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Interior_del_Tutor
                            ,Telefono_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Telefono_del_Tutor
                            ,Extencion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Extencion_del_Tutor
                            ,Celular_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Celular_del_Tutor
                            ,Correo_Electronico_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIItem.Correo_Electronico_del_Tutor
                            ,Tipo_de_Compareciente = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Compareciente) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Compareciente))
                            ,Narrativa_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Narrativa_de_los_Hechos

                            ,Titulo_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIItem.Titulo_del_Hecho
                            ,Prioridad_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Prioridad_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Prioridad_del_Hecho))
                            ,Fecha_del_Hecho = (Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_del_Hecho!= null) ? DateTime.ParseExact(Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIItem.Hora_Aproximada_del_Hecho
                            ,Pais_de_los_Hechos = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_de_los_Hechos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_de_los_Hechos))
                            ,Estado_de_los_Hechos = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_de_los_Hechos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_de_los_Hechos))
                            ,Municipio_de_los_Hechos = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_de_los_Hechos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_de_los_Hechos))
                            ,Colonia_de_los_Hechos = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_de_los_Hechos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_de_los_Hechos))
                            ,Codigo_Postal_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Codigo_Postal_de_los_Hechos
                            ,Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Calle_de_los_Hechos
                            ,Entre_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Entre_Calle_de_los_Hechos
                            ,Y_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Y_Calle_de_los_Hechos
                            ,Numero_Exterior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Exterior_de_los_Hechos
                            ,Numero_Interior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Interior_de_los_Hechos
                            ,Latitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Latitud_de_los_Hechos
                            ,Longitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIItem.Longitud_de_los_Hechos
                            ,Tipo_de_Lugar_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Lugar_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Lugar_del_Hecho))
                            ,Proteccion_de_Datos = Detalle_de_Datos_de_la_Victima_MPIItem.Proteccion_de_Datos
                            ,Nombre_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Nombre_de_Persona_Moral
                            ,Apellido_Paterno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Paterno_de_Persona_Moral
                            ,Apellido_Materno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Apellido_Materno_de_Persona_Moral
                            ,Fecha_de_Nacimiento_de_Persona_Moral = (Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento_de_Persona_Moral!= null) ? DateTime.ParseExact(Detalle_de_Datos_de_la_Victima_MPIItem.Fecha_de_Nacimiento_de_Persona_Moral, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Edad_de_Persona_Moral
                            ,Sexo_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Sexo_de_Persona_Moral))
                            ,Estado_Civil_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_Civil_de_Persona_Moral))
                            ,Tipo_de_Identificacion_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Tipo_de_Identificacion_de_Persona_Moral))
                            ,Numero_de_Identificacion_de_Persona_Mora = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_de_Identificacion_de_Persona_Mora
                            ,Nacionalidad_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Nacionalidad_de_Persona_Moral))
                            ,Escolaridad_de_Persona_Moral = (Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad_de_Persona_Moral) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_de_la_Victima_MPIItem.Escolaridad_de_Persona_Moral))
                            ,Ocupacion_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Ocupacion_de_Persona_Moral))
                            ,Pais_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Pais_de_Persona_Moral))
                            ,Estado_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Estado_de_Persona_Moral))
                            ,Municipio_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Municipio_de_Persona_Moral))
                            ,Colonia_de_Persona_Moral = (Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_de_Persona_Moral) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_de_la_Victima_MPIItem.Colonia_de_Persona_Moral))
                            ,Codigo_Postal_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Codigo_Postal_de_Persona_Moral
                            ,Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Calle_de_Persona_Moral
                            ,Numero_Exterior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Exterior_de_Persona_Moral
                            ,Numero_Interior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Numero_Interior_de_Persona_Moral
                            ,Entre_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Entre_Calle_de_Persona_Moral
                            ,Y_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Y_Calle_de_Persona_Moral
                            ,Longitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Longitud_de_Persona_Moral
                            ,Latitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Latitud_de_Persona_Moral
                            ,Telefono_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Telefono_de_Persona_Moral
                            ,Extension_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Extension_de_Persona_Moral
                            ,Celular_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Celular_de_Persona_Moral
                            ,Correo_Electronico_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIItem.Correo_Electronico_de_Persona_Moral
                            ,Persona_Moral_Victima = Detalle_de_Datos_de_la_Victima_MPIItem.Persona_Moral_Victima

                        };

                        var resultId = Detalle_de_Datos_de_la_Victima_MPIItem.Clave > 0
                           ? _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Update(Detalle_de_Datos_de_la_Victima_MPIData,null,null).Resource
                           : _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Insert(Detalle_de_Datos_de_la_Victima_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_EscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Escolaridad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
















        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_LocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILocalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Localidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }








        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_Tipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Compareciente", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_Prioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Prioridad_del_Hecho", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }










        [HttpGet]
        public ActionResult GetDetalle_de_Datos_de_la_Victima_MPI_Lugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Lugar_Tipo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





















        [NonAction]
        public bool CopyDetalle_de_Datos_del_Imputado_MPI(int MasterId, int referenceId, List<Detalle_de_Datos_del_Imputado_MPIGridModelPost> Detalle_de_Datos_del_Imputado_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Datos_del_Imputado_MPIData = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Datos_del_Imputado_MPIData == null || Detalle_de_Datos_del_Imputado_MPIData.Detalle_de_Datos_del_Imputado_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Datos_del_Imputado_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Datos_del_Imputado_MPI in Detalle_de_Datos_del_Imputado_MPIData.Detalle_de_Datos_del_Imputado_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Datos_del_Imputado_MPI Detalle_de_Datos_del_Imputado_MPI1 = varDetalle_de_Datos_del_Imputado_MPI;

                    if (Detalle_de_Datos_del_Imputado_MPIItems != null && Detalle_de_Datos_del_Imputado_MPIItems.Any(m => m.Clave == Detalle_de_Datos_del_Imputado_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Datos_del_Imputado_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Datos_del_Imputado_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Datos_del_Imputado_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Insert(varDetalle_de_Datos_del_Imputado_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Datos_del_Imputado_MPI(List<Detalle_de_Datos_del_Imputado_MPIGridModelPost> Detalle_de_Datos_del_Imputado_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Datos_del_Imputado_MPI(MasterId, referenceId, Detalle_de_Datos_del_Imputado_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Datos_del_Imputado_MPIItems != null && Detalle_de_Datos_del_Imputado_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Datos_del_Imputado_MPIItem in Detalle_de_Datos_del_Imputado_MPIItems)
                    {















































































































                        //Removal Request
                        if (Detalle_de_Datos_del_Imputado_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Delete(Detalle_de_Datos_del_Imputado_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Datos_del_Imputado_MPIItem.Clave = 0;

                        var Detalle_de_Datos_del_Imputado_MPIData = new Detalle_de_Datos_del_Imputado_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Datos_del_Imputado_MPIItem.Clave
                            ,Nombre = Detalle_de_Datos_del_Imputado_MPIItem.Nombre
                            ,Apellido_Paterno = Detalle_de_Datos_del_Imputado_MPIItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_Datos_del_Imputado_MPIItem.Apellido_Materno
                            ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad = Detalle_de_Datos_del_Imputado_MPIItem.Edad
                            ,Sexo = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Sexo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Sexo))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_Civil))
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Identificacion))
                            ,Numero_de_Identificacion = Detalle_de_Datos_del_Imputado_MPIItem.Numero_de_Identificacion
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nacionalidad))
                            ,Escolaridad = (Convert.ToInt16(Detalle_de_Datos_del_Imputado_MPIItem.Escolaridad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_del_Imputado_MPIItem.Escolaridad))
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ocupacion))
                            ,Estado = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio))
                            ,Codigo_Postal = Detalle_de_Datos_del_Imputado_MPIItem.Codigo_Postal
                            ,Localidad = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Localidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Localidad))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia))
                            ,Calle_del_Imputado = Detalle_de_Datos_del_Imputado_MPIItem.Calle_del_Imputado
                            ,Numero_Exterior = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Interior
                            ,Telefono = Detalle_de_Datos_del_Imputado_MPIItem.Telefono
                            ,Extencion = Detalle_de_Datos_del_Imputado_MPIItem.Extencion
                            ,Celular = Detalle_de_Datos_del_Imputado_MPIItem.Celular
                            ,Correo_Electronico = Detalle_de_Datos_del_Imputado_MPIItem.Correo_Electronico
                            ,Pais = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais))
                            ,Forma_Cara = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Cara) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Cara))
                            ,Cejas = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Cejas) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Cejas))
                            ,Cantidad_Cabello = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Cantidad_Cabello) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Cantidad_Cabello))
                            ,Implantacion_Cabello = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Implantacion_Cabello) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Implantacion_Cabello))
                            ,Complexion = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Complexion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Complexion))
                            ,Color_Piel = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Color_Piel) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Color_Piel))
                            ,Frente = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Frente) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Frente))
                            ,Forma_Cabello = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Cabello) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Cabello))
                            ,Calvicie = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Calvicie) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Calvicie))
                            ,Color_Ojos = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Color_Ojos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Color_Ojos))
                            ,Ojos = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ojos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ojos))
                           // ,Forma_Ojos = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Ojos) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Ojos))
                            ,Nariz_Base = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nariz_Base) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nariz_Base))
                            ,Labios = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Labios) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Labios))
                            ,Boca = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Boca) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Boca))
                            ,Menton = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Menton) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Menton))
                            ,Barba = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Barba) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Barba))
                            ,Forma_Orejas = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Orejas) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Forma_Orejas))
                            ,Tamano_Orejas = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tamano_Orejas) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tamano_Orejas))
                            ,Tipo_Lobulo = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_Lobulo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_Lobulo))
                            ,Bigote = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Bigote) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Bigote))
                            ,Situacion_Fisica = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Situacion_Fisica) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Situacion_Fisica))
                            ,Alias_media_diliacion = Detalle_de_Datos_del_Imputado_MPIItem.Alias_media_diliacion
                            ,Fecha_de_Detencion = (Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Detencion!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Detencion = Detalle_de_Datos_del_Imputado_MPIItem.Hora_de_Detencion
                            ,Fecha_de_Puesto_a_Disposicion = (Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Puesto_a_Disposicion!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Puesto_a_Disposicion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Puesto_a_Disposicion = Detalle_de_Datos_del_Imputado_MPIItem.Hora_de_Puesto_a_Disposicion
                            ,Con_Detenido = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Con_Detenido) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Con_Detenido))
                            ,A_Quien_Resulte_Responsable = Detalle_de_Datos_del_Imputado_MPIItem.A_Quien_Resulte_Responsable
                            ,Tiempo_Restante_para_Vinculacion = Detalle_de_Datos_del_Imputado_MPIItem.Tiempo_Restante_para_Vinculacion
                            ,Vincular = Detalle_de_Datos_del_Imputado_MPIItem.Vincular
                            ,Medidas_Cautelares = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Medidas_Cautelares) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Medidas_Cautelares))
                            ,Solicitar_Prorroga = Detalle_de_Datos_del_Imputado_MPIItem.Solicitar_Prorroga
                            ,Nuevo_Plazo = Detalle_de_Datos_del_Imputado_MPIItem.Nuevo_Plazo
                            ,Orden_de_Aprehension = Detalle_de_Datos_del_Imputado_MPIItem.Orden_de_Aprehension
                            ,Medidas_Cautelares_en_Imputado = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Medidas_Cautelares_en_Imputado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Medidas_Cautelares_en_Imputado))
                            ,Titulo_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Titulo_del_Hecho
                            ,Narrativa_Breve_de_los_Hechos = Detalle_de_Datos_del_Imputado_MPIItem.Narrativa_Breve_de_los_Hechos
                            ,Prioridad_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Prioridad_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Prioridad_del_Hecho))
                            ,Fecha_del_Hecho = (Detalle_de_Datos_del_Imputado_MPIItem.Fecha_del_Hecho!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_MPIItem.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Hora_Aproximada_del_Hecho
                            ,Pais_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais_del_Hecho))
                            ,Estado_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_del_Hecho))
                            ,Municipio_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio_del_Hecho))
                            ,Colonia_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia_del_Hecho))
                            ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Codigo_Postal_del_Hecho
                            ,Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Calle_del_Hecho
                            ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Entre_Calle_del_Hecho
                            ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Y_Calle_del_Hecho
                            ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Exterior_del_Hecho
                            ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Interior_del_Hecho
                            ,Latitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Latitud_del_Hecho
                            ,Longitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIItem.Longitud_del_Hecho
                            ,Tipo_de_Lugar_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Lugar_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Lugar_del_Hecho))

                            ,Incapaz = Detalle_de_Datos_del_Imputado_MPIItem.Incapaz
                            ,Nombre_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Nombre_del_Tutor
                            ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Apellido_Paterno_del_Tutor
                            ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Apellido_Materno_del_Tutor
                            ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Nacimiento_del_Tutor!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_MPIItem.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Edad_del_Tutor
                            ,Sexo_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Sexo_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Sexo_del_Tutor))
                            ,Estado_Civil_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_Civil_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_Civil_del_Tutor))
                            ,Tipo_de_Identificacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Identificacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Tipo_de_Identificacion_del_Tutor))
                            ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Numero_de_Identificacion_del_Tutor
                            ,Nacionalidad_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nacionalidad_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Nacionalidad_del_Tutor))
                            ,Escolaridad_del_Tutor = (Convert.ToInt16(Detalle_de_Datos_del_Imputado_MPIItem.Escolaridad_del_Tutor) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_del_Imputado_MPIItem.Escolaridad_del_Tutor))
                            ,Ocupacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ocupacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Ocupacion_del_Tutor))
                            ,Pais_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Pais_del_Tutor))
                            ,Estado_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estado_del_Tutor))
                            ,Municipio_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Municipio_del_Tutor))
                            ,Colonia_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Colonia_del_Tutor))
                            ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Codigo_Postal_del_Tutor
                            ,Calle_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Calle_del_Tutor
                            ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Exterior_del_Tutor
                            ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Numero_Interior_del_Tutor
                            ,Telefono_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Telefono_del_Tutor
                            ,Extension_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Extension_del_Tutor
                            ,Celular_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Celular_del_Tutor
                            ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Imputado_MPIItem.Correo_Electronico_del_Tutor
                            ,Proteccion_de_Datos = Detalle_de_Datos_del_Imputado_MPIItem.Proteccion_de_Datos

                            ,Estatus = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estatus) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_MPIItem.Estatus))
                            ,Judicializar = Detalle_de_Datos_del_Imputado_MPIItem.Judicializar

                        };

                        var resultId = Detalle_de_Datos_del_Imputado_MPIItem.Clave > 0
                           ? _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Update(Detalle_de_Datos_del_Imputado_MPIData,null,null).Resource
                           : _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Insert(Detalle_de_Datos_del_Imputado_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }







        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_EscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Escolaridad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_LocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILocalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Localidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }







        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Forma_CaraAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CaraApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Forma_Cara", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_CejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICejasApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Cejas", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Cantidad_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICantidad_CabelloApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Cantidad_Cabello", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Implantacion_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IImplantacion_CabelloApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Implantacion_Cabello", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_ComplexionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IComplexionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Complexion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Color_PielAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_PielApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Color_Piel", "Descrpicion");
                  item.Descrpicion= trans??item.Descrpicion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_FrenteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFrenteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Frente", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Forma_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CabelloApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Forma_Cabello", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_CalvicieAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalvicieApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Calvicie", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Color_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_OjosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Color_Ojos", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOjosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ojos", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Froma_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFroma_OjosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Froma_Ojos", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Nariz_BaseAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INariz_BaseApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nariz_Base", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_LabiosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILabiosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Labios", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_BocaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBocaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Boca", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_MentonAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMentonApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Menton", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_BarbaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBarbaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Barba", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Forma_OrejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_OrejasApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Forma_Orejas", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Tipo_LobuloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_LobuloApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_Lobulo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_BigoteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBigoteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Bigote", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Situacion_FisicaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISituacion_FisicaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Situacion_Fisica", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Catalogo_Estatus_Detenido_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Medidas_CautelaresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedidas_CautelaresApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Medidas_Cautelares", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Prioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Prioridad_del_Hecho", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }










        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Lugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Lugar_Tipo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


















        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_MPI_Estatus_del_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_del_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_del_ImputadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_del_Imputado", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_Datos_de_Delito_MPI(int MasterId, int referenceId, List<Detalle_Datos_de_Delito_MPIGridModelPost> Detalle_Datos_de_Delito_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Datos_de_Delito_MPIData = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_Datos_de_Delito_MPIData == null || Detalle_Datos_de_Delito_MPIData.Detalle_Datos_de_Delito_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_Datos_de_Delito_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Datos_de_Delito_MPI in Detalle_Datos_de_Delito_MPIData.Detalle_Datos_de_Delito_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Datos_de_Delito_MPI Detalle_Datos_de_Delito_MPI1 = varDetalle_Datos_de_Delito_MPI;

                    if (Detalle_Datos_de_Delito_MPIItems != null && Detalle_Datos_de_Delito_MPIItems.Any(m => m.Clave == Detalle_Datos_de_Delito_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_Datos_de_Delito_MPIItems.FirstOrDefault(m => m.Clave == Detalle_Datos_de_Delito_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Datos_de_Delito_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_Datos_de_Delito_MPIApiConsumer.Insert(varDetalle_Datos_de_Delito_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_Datos_de_Delito_MPI(List<Detalle_Datos_de_Delito_MPIGridModelPost> Detalle_Datos_de_Delito_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Datos_de_Delito_MPI(MasterId, referenceId, Detalle_Datos_de_Delito_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Datos_de_Delito_MPIItems != null && Detalle_Datos_de_Delito_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Datos_de_Delito_MPIItem in Detalle_Datos_de_Delito_MPIItems)
                    {
























































                        //Removal Request
                        if (Detalle_Datos_de_Delito_MPIItem.Removed)
                        {
                            result = result && _IDetalle_Datos_de_Delito_MPIApiConsumer.Delete(Detalle_Datos_de_Delito_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Datos_de_Delito_MPIItem.Clave = 0;

                        var Detalle_Datos_de_Delito_MPIData = new Detalle_Datos_de_Delito_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_Datos_de_Delito_MPIItem.Clave
                            ,Tipo_de_Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Delito))
                            ,Grupo_Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Grupo_Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Grupo_Delito))
                            ,Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Delito))
                            ,Circunstancia_Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Circunstancia_Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Circunstancia_Delito))
                            ,Delito_Principal = Detalle_Datos_de_Delito_MPIItem.Delito_Principal
                            ,Forma_Comision_Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Forma_Comision_Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Forma_Comision_Delito))
                            ,Forma_Accion_Delito = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Forma_Accion_Delito) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Forma_Accion_Delito))
                            ,Modalidad_Delito = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Modalidad_Delito) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Modalidad_Delito))
                            ,Elementos_Comision_Delito = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Elementos_Comision_Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Elementos_Comision_Delito))
                            ,Monto = Detalle_Datos_de_Delito_MPIItem.Monto
                            ,Violencia_de_Genero = Detalle_Datos_de_Delito_MPIItem.Violencia_de_Genero
                            ,Robo_de_Vehiculo = Detalle_Datos_de_Delito_MPIItem.Robo_de_Vehiculo
                            ,Levantamiento_de_Cadaver = Detalle_Datos_de_Delito_MPIItem.Levantamiento_de_Cadaver
                            ,Circunstancia_de_Vehiculo = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Circunstancia_de_Vehiculo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Circunstancia_de_Vehiculo))
                            ,Clase = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Clase) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Clase))
                            ,Vehiculo_Robado = Detalle_Datos_de_Delito_MPIItem.Vehiculo_Robado
                            ,Marca = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Marca) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Marca))
                            ,Sub_Marca = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Sub_Marca) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Sub_Marca))
                            ,Tipo_de_Vehiculo = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Vehiculo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Vehiculo))
                            ,Modelo = Detalle_Datos_de_Delito_MPIItem.Modelo
                            ,Color = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Color) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Color))
                            ,Placas = Detalle_Datos_de_Delito_MPIItem.Placas
                            ,Estado_de_Origen_de_las_Placas = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Estado_de_Origen_de_las_Placas) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Estado_de_Origen_de_las_Placas))
                            ,Motor = Detalle_Datos_de_Delito_MPIItem.Motor
                            ,Serie = Detalle_Datos_de_Delito_MPIItem.Serie
                            ,El_Vehiculo_esta_Asegurado = Detalle_Datos_de_Delito_MPIItem.El_Vehiculo_esta_Asegurado
                            ,Nombre_de_la_Aseguradora = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Nombre_de_la_Aseguradora) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Nombre_de_la_Aseguradora))
                            ,Tipo_de_Servicio = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Servicio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Servicio))
                            ,Ruta_del_Servicio_Publico = Detalle_Datos_de_Delito_MPIItem.Ruta_del_Servicio_Publico
                            ,Procedencia = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Procedencia) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Procedencia))
                            ,Mercancia = Detalle_Datos_de_Delito_MPIItem.Mercancia
                            ,Descripcion_de_lo_que_Transportaba = Detalle_Datos_de_Delito_MPIItem.Descripcion_de_lo_que_Transportaba
                            ,Monto_de_la_Carga = Detalle_Datos_de_Delito_MPIItem.Monto_de_la_Carga
                            ,Senas_Particulares = Detalle_Datos_de_Delito_MPIItem.Senas_Particulares
                            ,Modalidad_del_Robo = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Modalidad_del_Robo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Modalidad_del_Robo))
                            ,Causa_de_Muerte = Detalle_Datos_de_Delito_MPIItem.Causa_de_Muerte
                            ,Circunstancia_Defuncion = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Circunstancia_Defuncion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Circunstancia_Defuncion))
                            ,Consecuencia_Defuncion = (Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Consecuencia_Defuncion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Datos_de_Delito_MPIItem.Consecuencia_Defuncion))
                            ,Fecha_Levantamiento = (Detalle_Datos_de_Delito_MPIItem.Fecha_Levantamiento!= null) ? DateTime.ParseExact(Detalle_Datos_de_Delito_MPIItem.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_Levantamiento = Detalle_Datos_de_Delito_MPIItem.Hora_Levantamiento
                            ,Tipo_de_Lugar_del_Hecho = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Lugar_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Tipo_de_Lugar_del_Hecho))
                            ,Pais = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Pais))
                            ,Estado = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Municipio))
                            ,Zona = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Zona) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Zona))
                            ,Colonia = (Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Datos_de_Delito_MPIItem.Colonia))
                            ,Colonia_no_Catalogada = Detalle_Datos_de_Delito_MPIItem.Colonia_no_Catalogada
                            ,Numero_Exterior = Detalle_Datos_de_Delito_MPIItem.Numero_Exterior
                            ,Numero_Interior = Detalle_Datos_de_Delito_MPIItem.Numero_Interior
                            ,Necropsia = Detalle_Datos_de_Delito_MPIItem.Necropsia
                            ,Cronotanatodiagnostico = Detalle_Datos_de_Delito_MPIItem.Cronotanatodiagnostico
                            ,Ruta = Detalle_Datos_de_Delito_MPIItem.Ruta
                            ,Estado_del_Conductor = Detalle_Datos_de_Delito_MPIItem.Estado_del_Conductor
                            ,Codigo_Postal = Detalle_Datos_de_Delito_MPIItem.Codigo_Postal

                        };

                        var resultId = Detalle_Datos_de_Delito_MPIItem.Clave > 0
                           ? _IDetalle_Datos_de_Delito_MPIApiConsumer.Update(Detalle_Datos_de_Delito_MPIData,null,null).Resource
                           : _IDetalle_Datos_de_Delito_MPIApiConsumer.Insert(Detalle_Datos_de_Delito_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Tipo_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Grupo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_del_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Grupo_del_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Circunstancia_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Circunstancia_del_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Forma_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Comision_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Forma_Comision_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Forma_Accion_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Accion_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Forma_Accion_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Modalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modalidad_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Elementos_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IElementos_Comision_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Elementos_Comision_Delito", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Circunstancia_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Circunstancia_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Especifica_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecifica_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Especifica_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Marca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_del_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_del_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Sub_Marca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISub_Marca_del_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Sub_Marca_del_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Tipo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Color_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Color_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Aseguradora_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguradora_de_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Aseguradora_de_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Servicio_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicio_del_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicio_del_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Procedencia_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Procedencia_del_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Modalidad_de_Robo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Circunstancia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_DefuncionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Circunstancia_Defuncion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Consecuencia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Consecuencia_Defuncion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_Lugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Lugar_Tipo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_ZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IZonaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Zona", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Datos_de_Delito_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }









        [NonAction]
        public bool CopyDetalle_de_Persona_Moral_MPI(int MasterId, int referenceId, List<Detalle_de_Persona_Moral_MPIGridModelPost> Detalle_de_Persona_Moral_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Persona_Moral_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Persona_Moral_MPIData = _IDetalle_de_Persona_Moral_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Persona_Moral_MPIData == null || Detalle_de_Persona_Moral_MPIData.Detalle_de_Persona_Moral_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Persona_Moral_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Persona_Moral_MPI in Detalle_de_Persona_Moral_MPIData.Detalle_de_Persona_Moral_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Persona_Moral_MPI Detalle_de_Persona_Moral_MPI1 = varDetalle_de_Persona_Moral_MPI;

                    if (Detalle_de_Persona_Moral_MPIItems != null && Detalle_de_Persona_Moral_MPIItems.Any(m => m.Clave == Detalle_de_Persona_Moral_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Persona_Moral_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Persona_Moral_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Persona_Moral_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Persona_Moral_MPIApiConsumer.Insert(varDetalle_de_Persona_Moral_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Persona_Moral_MPI(List<Detalle_de_Persona_Moral_MPIGridModelPost> Detalle_de_Persona_Moral_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Persona_Moral_MPI(MasterId, referenceId, Detalle_de_Persona_Moral_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Persona_Moral_MPIItems != null && Detalle_de_Persona_Moral_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Persona_Moral_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Persona_Moral_MPIItem in Detalle_de_Persona_Moral_MPIItems)
                    {




















                        //Removal Request
                        if (Detalle_de_Persona_Moral_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Persona_Moral_MPIApiConsumer.Delete(Detalle_de_Persona_Moral_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Persona_Moral_MPIItem.Clave = 0;

                        var Detalle_de_Persona_Moral_MPIData = new Detalle_de_Persona_Moral_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Persona_Moral_MPIItem.Clave
                            ,Nombre = Detalle_de_Persona_Moral_MPIItem.Nombre
                            ,Apellido_Paterno = Detalle_de_Persona_Moral_MPIItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_Persona_Moral_MPIItem.Apellido_Materno
                            ,Nombre_Completo = Detalle_de_Persona_Moral_MPIItem.Nombre_Completo
                            ,Calidad_Juridica = Detalle_de_Persona_Moral_MPIItem.Calidad_Juridica
                            ,Razon_Social = Detalle_de_Persona_Moral_MPIItem.Razon_Social
                            ,Pais = (Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Pais))
                            ,Estado = (Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Municipio))
                            ,Localidad = (Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Localidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Localidad))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Persona_Moral_MPIItem.Colonia))
                            ,Calle = Detalle_de_Persona_Moral_MPIItem.Calle
                            ,Numero_Exterior = Detalle_de_Persona_Moral_MPIItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Persona_Moral_MPIItem.Numero_Interior
                            ,Telefono = Detalle_de_Persona_Moral_MPIItem.Telefono
                            ,Extension = Detalle_de_Persona_Moral_MPIItem.Extension
                            ,Celular = Detalle_de_Persona_Moral_MPIItem.Celular
                            ,Correo_Electronico = Detalle_de_Persona_Moral_MPIItem.Correo_Electronico

                        };

                        var resultId = Detalle_de_Persona_Moral_MPIItem.Clave > 0
                           ? _IDetalle_de_Persona_Moral_MPIApiConsumer.Update(Detalle_de_Persona_Moral_MPIData,null,null).Resource
                           : _IDetalle_de_Persona_Moral_MPIApiConsumer.Insert(Detalle_de_Persona_Moral_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_MPI_LocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILocalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Localidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }








        [NonAction]
        public bool CopyDetalle_de_Servicio_de_Apoyo_MPI(int MasterId, int referenceId, List<Detalle_de_Servicio_de_Apoyo_MPIGridModelPost> Detalle_de_Servicio_de_Apoyo_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Servicio_de_Apoyo_MPIData = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Servicio_de_Apoyo_MPIData == null || Detalle_de_Servicio_de_Apoyo_MPIData.Detalle_de_Servicio_de_Apoyo_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Servicio_de_Apoyo_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Servicio_de_Apoyo_MPI in Detalle_de_Servicio_de_Apoyo_MPIData.Detalle_de_Servicio_de_Apoyo_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Servicio_de_Apoyo_MPI Detalle_de_Servicio_de_Apoyo_MPI1 = varDetalle_de_Servicio_de_Apoyo_MPI;

                    if (Detalle_de_Servicio_de_Apoyo_MPIItems != null && Detalle_de_Servicio_de_Apoyo_MPIItems.Any(m => m.Clave == Detalle_de_Servicio_de_Apoyo_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Servicio_de_Apoyo_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Servicio_de_Apoyo_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Servicio_de_Apoyo_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Insert(varDetalle_de_Servicio_de_Apoyo_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Servicio_de_Apoyo_MPI(List<Detalle_de_Servicio_de_Apoyo_MPIGridModelPost> Detalle_de_Servicio_de_Apoyo_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Servicio_de_Apoyo_MPI(MasterId, referenceId, Detalle_de_Servicio_de_Apoyo_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Servicio_de_Apoyo_MPIItems != null && Detalle_de_Servicio_de_Apoyo_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Servicio_de_Apoyo_MPIItem in Detalle_de_Servicio_de_Apoyo_MPIItems)
                    {






                        //Removal Request
                        if (Detalle_de_Servicio_de_Apoyo_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Delete(Detalle_de_Servicio_de_Apoyo_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Servicio_de_Apoyo_MPIItem.Clave = 0;

                        var Detalle_de_Servicio_de_Apoyo_MPIData = new Detalle_de_Servicio_de_Apoyo_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Servicio_de_Apoyo_MPIItem.Clave
                            ,Tipo_de_Servicio = (Convert.ToInt32(Detalle_de_Servicio_de_Apoyo_MPIItem.Tipo_de_Servicio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Servicio_de_Apoyo_MPIItem.Tipo_de_Servicio))
                            ,Dictamen = Detalle_de_Servicio_de_Apoyo_MPIItem.Dictamen
                            ,Responsable = Detalle_de_Servicio_de_Apoyo_MPIItem.Responsable
                            ,Victima = (Convert.ToInt32(Detalle_de_Servicio_de_Apoyo_MPIItem.Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Servicio_de_Apoyo_MPIItem.Victima))

                        };

                        var resultId = Detalle_de_Servicio_de_Apoyo_MPIItem.Clave > 0
                           ? _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Update(Detalle_de_Servicio_de_Apoyo_MPIData,null,null).Resource
                           : _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Insert(Detalle_de_Servicio_de_Apoyo_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Servicio_de_Apoyo_MPI_Tipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Servicio_de_Apoyo_MPI_Solicitante_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitante_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitante_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitante_MPI", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Datos_del_Testigo_MPI(int MasterId, int referenceId, List<Detalle_de_Datos_del_Testigo_MPIGridModelPost> Detalle_de_Datos_del_Testigo_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Datos_del_Testigo_MPIData = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Datos_del_Testigo_MPIData == null || Detalle_de_Datos_del_Testigo_MPIData.Detalle_de_Datos_del_Testigo_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Datos_del_Testigo_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Datos_del_Testigo_MPI in Detalle_de_Datos_del_Testigo_MPIData.Detalle_de_Datos_del_Testigo_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Datos_del_Testigo_MPI Detalle_de_Datos_del_Testigo_MPI1 = varDetalle_de_Datos_del_Testigo_MPI;

                    if (Detalle_de_Datos_del_Testigo_MPIItems != null && Detalle_de_Datos_del_Testigo_MPIItems.Any(m => m.Clave == Detalle_de_Datos_del_Testigo_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Datos_del_Testigo_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Datos_del_Testigo_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Datos_del_Testigo_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Insert(varDetalle_de_Datos_del_Testigo_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Datos_del_Testigo_MPI(List<Detalle_de_Datos_del_Testigo_MPIGridModelPost> Detalle_de_Datos_del_Testigo_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Datos_del_Testigo_MPI(MasterId, referenceId, Detalle_de_Datos_del_Testigo_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Datos_del_Testigo_MPIItems != null && Detalle_de_Datos_del_Testigo_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Datos_del_Testigo_MPIItem in Detalle_de_Datos_del_Testigo_MPIItems)
                    {









































































                        //Removal Request
                        if (Detalle_de_Datos_del_Testigo_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Delete(Detalle_de_Datos_del_Testigo_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Datos_del_Testigo_MPIItem.Clave = 0;

                        var Detalle_de_Datos_del_Testigo_MPIData = new Detalle_de_Datos_del_Testigo_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Datos_del_Testigo_MPIItem.Clave
                            ,Nombre = Detalle_de_Datos_del_Testigo_MPIItem.Nombre
                            ,Apellido_Paterno = Detalle_de_Datos_del_Testigo_MPIItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_Datos_del_Testigo_MPIItem.Apellido_Materno
                            ,Nombre_Completo = Detalle_de_Datos_del_Testigo_MPIItem.Nombre_Completo
                            ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Testigo_MPIItem.Fecha_de_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Testigo_MPIItem.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad = Detalle_de_Datos_del_Testigo_MPIItem.Edad
                            ,Sexo = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Sexo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Sexo))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_Civil))
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Identificacion))
                            ,Numero_de_Identificacion = Detalle_de_Datos_del_Testigo_MPIItem.Numero_de_Identificacion
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Nacionalidad))
                            ,Escolaridad = (Convert.ToInt16(Detalle_de_Datos_del_Testigo_MPIItem.Escolaridad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_del_Testigo_MPIItem.Escolaridad))
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Ocupacion))
                            ,Pais = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais))
                            ,Estado = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia))
                            ,Codigo_Postal = Detalle_de_Datos_del_Testigo_MPIItem.Codigo_Postal
                            ,Calle = Detalle_de_Datos_del_Testigo_MPIItem.Calle
                            ,Numero_Exterior = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Interior
                            ,Telefono = Detalle_de_Datos_del_Testigo_MPIItem.Telefono
                            ,Extencion = Detalle_de_Datos_del_Testigo_MPIItem.Extencion
                            ,Celular = Detalle_de_Datos_del_Testigo_MPIItem.Celular
                            ,Correo_Electronico = Detalle_de_Datos_del_Testigo_MPIItem.Correo_Electronico
                            ,Incapaz = Detalle_de_Datos_del_Testigo_MPIItem.Incapaz
                            ,Nombre_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Nombre_del_Tutor
                            ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Apellido_Paterno_del_Tutor
                            ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Apellido_Materno_del_Tutor
                            ,Nombre_Completo_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Nombre_Completo_del_Tutor
                            ,Fecha_de_Nacimento_del_Tutor = (Detalle_de_Datos_del_Testigo_MPIItem.Fecha_de_Nacimento_del_Tutor!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Testigo_MPIItem.Fecha_de_Nacimento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Edad_del_Tutor
                            ,Sexo_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Sexo_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Sexo_del_Tutor))
                            ,Estado_Civil_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_Civil_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_Civil_del_Tutor))
                            ,Tipo_de_Identificacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Identificacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Identificacion_del_Tutor))
                            ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Numero_de_Identificacion_del_Tutor
                            ,Nacionalidad_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Nacionalidad_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Nacionalidad_del_Tutor))
                            ,Escolaridad_del_Tutor = (Convert.ToInt16(Detalle_de_Datos_del_Testigo_MPIItem.Escolaridad_del_Tutor) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_del_Testigo_MPIItem.Escolaridad_del_Tutor))
                            ,Ocupacion_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Ocupacion_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Ocupacion_del_Tutor))
                            ,Pais_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais_del_Tutor))
                            ,Estado_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_del_Tutor))
                            ,Municipio_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio_del_Tutor))
                            ,Colonia_del_Tutor = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia_del_Tutor) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia_del_Tutor))
                            ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Codigo_Postal_del_Tutor
                            ,Calle_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Calle_del_Tutor
                            ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Exterior_del_Tutor
                            ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Interior_del_Tutor
                            ,Telefono_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Telefono_del_Tutor
                            ,Extencion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Extencion_del_Tutor
                            ,Celular_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Celular_del_Tutor
                            ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Testigo_MPIItem.Correo_Electronico_del_Tutor
                            ,Tipo_de_Compareciente = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Compareciente) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_de_Compareciente))
                            ,Narrativa_del_Testigo = Detalle_de_Datos_del_Testigo_MPIItem.Narrativa_del_Testigo
                            ,Titulo_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Titulo_del_Hecho
                            ,Prioridad_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Prioridad_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Prioridad_del_Hecho))
                            ,Fecha_del_Hecho = (Detalle_de_Datos_del_Testigo_MPIItem.Fecha_del_Hecho!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Testigo_MPIItem.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Hora_Aproximada_del_Hecho
                            ,Pais_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Pais_del_Hecho))
                            ,Estado_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Estado_del_Hecho))
                            ,Municipio_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Municipio_del_Hecho))
                            ,Colonia_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Colonia_del_Hecho))
                            ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Codigo_Postal_del_Hecho
                            ,Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Calle_del_Hecho
                            ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Entre_Calle_del_Hecho
                            ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Y_Calle_del_Hecho
                            ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Exterior_del_Hecho
                            ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Numero_Interior_del_Hecho
                            ,Latitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Latitud_del_Hecho
                            ,Longitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIItem.Longitud_del_Hecho
                            ,Tipo_del_Lugar_del_Hecho = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_del_Lugar_del_Hecho) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_MPIItem.Tipo_del_Lugar_del_Hecho))
                            ,Proteccion_de_Datos = Detalle_de_Datos_del_Testigo_MPIItem.Proteccion_de_Datos

                        };

                        var resultId = Detalle_de_Datos_del_Testigo_MPIItem.Clave > 0
                           ? _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Update(Detalle_de_Datos_del_Testigo_MPIData,null,null).Resource
                           : _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Insert(Detalle_de_Datos_del_Testigo_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_EscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Escolaridad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
























        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_Tipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Compareciente", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_Prioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Prioridad_del_Hecho", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }










        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_MPI_Lugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Lugar_Tipo", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Agente_del_Ministerio_Publico(int MasterId, int referenceId, List<Detalle_de_Agente_del_Ministerio_PublicoGridModelPost> Detalle_de_Agente_del_Ministerio_PublicoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Agente_del_Ministerio_PublicoData = _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Agente_del_Ministerio_PublicoData == null || Detalle_de_Agente_del_Ministerio_PublicoData.Detalle_de_Agente_del_Ministerio_Publicos.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Agente_del_Ministerio_PublicoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Agente_del_Ministerio_Publico in Detalle_de_Agente_del_Ministerio_PublicoData.Detalle_de_Agente_del_Ministerio_Publicos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Agente_del_Ministerio_Publico Detalle_de_Agente_del_Ministerio_Publico1 = varDetalle_de_Agente_del_Ministerio_Publico;

                    if (Detalle_de_Agente_del_Ministerio_PublicoItems != null && Detalle_de_Agente_del_Ministerio_PublicoItems.Any(m => m.Clave == Detalle_de_Agente_del_Ministerio_Publico1.Clave))
                    {
                        modelDataToChange = Detalle_de_Agente_del_Ministerio_PublicoItems.FirstOrDefault(m => m.Clave == Detalle_de_Agente_del_Ministerio_Publico1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Agente_del_Ministerio_Publico.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.Insert(varDetalle_de_Agente_del_Ministerio_Publico,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Agente_del_Ministerio_Publico(List<Detalle_de_Agente_del_Ministerio_PublicoGridModelPost> Detalle_de_Agente_del_Ministerio_PublicoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Agente_del_Ministerio_Publico(MasterId, referenceId, Detalle_de_Agente_del_Ministerio_PublicoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Agente_del_Ministerio_PublicoItems != null && Detalle_de_Agente_del_Ministerio_PublicoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Agente_del_Ministerio_PublicoItem in Detalle_de_Agente_del_Ministerio_PublicoItems)
                    {





                        //Removal Request
                        if (Detalle_de_Agente_del_Ministerio_PublicoItem.Removed)
                        {
                            result = result && _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.Delete(Detalle_de_Agente_del_Ministerio_PublicoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Agente_del_Ministerio_PublicoItem.Clave = 0;

                        var Detalle_de_Agente_del_Ministerio_PublicoData = new Detalle_de_Agente_del_Ministerio_Publico
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Agente_del_Ministerio_PublicoItem.Clave
                            ,Agente_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoItem.Agente_del_Ministerio_Publico
                            ,Carga_de_Trabajo = Detalle_de_Agente_del_Ministerio_PublicoItem.Carga_de_Trabajo
                            ,Especialidad = Detalle_de_Agente_del_Ministerio_PublicoItem.Especialidad

                        };

                        var resultId = Detalle_de_Agente_del_Ministerio_PublicoItem.Clave > 0
                           ? _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.Update(Detalle_de_Agente_del_Ministerio_PublicoData,null,null).Resource
                           : _IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer.Insert(Detalle_de_Agente_del_Ministerio_PublicoData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_Servicios_Periciales(int MasterId, int referenceId, List<Detalle_de_Servicios_PericialesGridModelPost> Detalle_de_Servicios_PericialesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Servicios_PericialesData = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Servicios_Periciales.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Servicios_PericialesData == null || Detalle_de_Servicios_PericialesData.Detalle_de_Servicios_Pericialess.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Servicios_PericialesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Servicios_Periciales in Detalle_de_Servicios_PericialesData.Detalle_de_Servicios_Pericialess)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Servicios_Periciales Detalle_de_Servicios_Periciales1 = varDetalle_de_Servicios_Periciales;

                    if (Detalle_de_Servicios_PericialesItems != null && Detalle_de_Servicios_PericialesItems.Any(m => m.Clave == Detalle_de_Servicios_Periciales1.Clave))
                    {
                        modelDataToChange = Detalle_de_Servicios_PericialesItems.FirstOrDefault(m => m.Clave == Detalle_de_Servicios_Periciales1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Servicios_Periciales.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Servicios_PericialesApiConsumer.Insert(varDetalle_de_Servicios_Periciales,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Servicios_Periciales(List<Detalle_de_Servicios_PericialesGridModelPost> Detalle_de_Servicios_PericialesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Servicios_Periciales(MasterId, referenceId, Detalle_de_Servicios_PericialesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Servicios_PericialesItems != null && Detalle_de_Servicios_PericialesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Servicios_PericialesItem in Detalle_de_Servicios_PericialesItems)
                    {










                        //Removal Request
                        if (Detalle_de_Servicios_PericialesItem.Removed)
                        {
                            result = result && _IDetalle_de_Servicios_PericialesApiConsumer.Delete(Detalle_de_Servicios_PericialesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Servicios_PericialesItem.Clave = 0;

                        var Detalle_de_Servicios_PericialesData = new Detalle_de_Servicios_Periciales
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Servicios_PericialesItem.Clave
                            ,Servicio = (Convert.ToInt32(Detalle_de_Servicios_PericialesItem.Servicio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Servicios_PericialesItem.Servicio))
                            ,Especialista = Detalle_de_Servicios_PericialesItem.Especialista
                            ,Estatus_del_Dictamen = (Convert.ToInt32(Detalle_de_Servicios_PericialesItem.Estatus_del_Dictamen) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Servicios_PericialesItem.Estatus_del_Dictamen))
                            ,Observaciones = Detalle_de_Servicios_PericialesItem.Observaciones
                            ,Fecha_del_Dictamen = (Detalle_de_Servicios_PericialesItem.Fecha_del_Dictamen!= null) ? DateTime.ParseExact(Detalle_de_Servicios_PericialesItem.Fecha_del_Dictamen, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Dictamen = Detalle_de_Servicios_PericialesItem.Dictamen
                            ,Rol_de_Donde_Proviene = (Convert.ToInt16(Detalle_de_Servicios_PericialesItem.Rol_de_Donde_Proviene) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Servicios_PericialesItem.Rol_de_Donde_Proviene))
                            ,ObservacionesD = Detalle_de_Servicios_PericialesItem.ObservacionesD

                        };

                        var resultId = Detalle_de_Servicios_PericialesItem.Clave > 0
                           ? _IDetalle_de_Servicios_PericialesApiConsumer.Update(Detalle_de_Servicios_PericialesData,null,null).Resource
                           : _IDetalle_de_Servicios_PericialesApiConsumer.Insert(Detalle_de_Servicios_PericialesData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Servicios_Periciales_Servicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicios_Periciales", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Servicios_Periciales_Estatus_del_DictamenAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_del_DictamenApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_del_Dictamen", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_de_Servicios_Periciales_Rol_de_DiligenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRol_de_DiligenciaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Rol_de_Diligencia", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Oficio_de_Servicio_Pericial(int MasterId, int referenceId, List<Detalle_de_Oficio_de_Servicio_PericialGridModelPost> Detalle_de_Oficio_de_Servicio_PericialItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Oficio_de_Servicio_PericialData = _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Oficio_de_Servicio_PericialData == null || Detalle_de_Oficio_de_Servicio_PericialData.Detalle_de_Oficio_de_Servicio_Pericials.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Oficio_de_Servicio_PericialGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Oficio_de_Servicio_Pericial in Detalle_de_Oficio_de_Servicio_PericialData.Detalle_de_Oficio_de_Servicio_Pericials)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Oficio_de_Servicio_Pericial Detalle_de_Oficio_de_Servicio_Pericial1 = varDetalle_de_Oficio_de_Servicio_Pericial;

                    if (Detalle_de_Oficio_de_Servicio_PericialItems != null && Detalle_de_Oficio_de_Servicio_PericialItems.Any(m => m.Clave == Detalle_de_Oficio_de_Servicio_Pericial1.Clave))
                    {
                        modelDataToChange = Detalle_de_Oficio_de_Servicio_PericialItems.FirstOrDefault(m => m.Clave == Detalle_de_Oficio_de_Servicio_Pericial1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Oficio_de_Servicio_Pericial.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.Insert(varDetalle_de_Oficio_de_Servicio_Pericial,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Oficio_de_Servicio_Pericial(List<Detalle_de_Oficio_de_Servicio_PericialGridModelPost> Detalle_de_Oficio_de_Servicio_PericialItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Oficio_de_Servicio_Pericial(MasterId, referenceId, Detalle_de_Oficio_de_Servicio_PericialItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Oficio_de_Servicio_PericialItems != null && Detalle_de_Oficio_de_Servicio_PericialItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Oficio_de_Servicio_PericialItem in Detalle_de_Oficio_de_Servicio_PericialItems)
                    {




                        //Removal Request
                        if (Detalle_de_Oficio_de_Servicio_PericialItem.Removed)
                        {
                            result = result && _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.Delete(Detalle_de_Oficio_de_Servicio_PericialItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Oficio_de_Servicio_PericialItem.Clave = 0;

                        var Detalle_de_Oficio_de_Servicio_PericialData = new Detalle_de_Oficio_de_Servicio_Pericial
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Oficio_de_Servicio_PericialItem.Clave
                            ,Oficio = (Convert.ToInt32(Detalle_de_Oficio_de_Servicio_PericialItem.Oficio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Oficio_de_Servicio_PericialItem.Oficio))
                            ,Servicio_Pericial = (Convert.ToInt32(Detalle_de_Oficio_de_Servicio_PericialItem.Servicio_Pericial) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Oficio_de_Servicio_PericialItem.Servicio_Pericial))

                        };

                        var resultId = Detalle_de_Oficio_de_Servicio_PericialItem.Clave > 0
                           ? _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.Update(Detalle_de_Oficio_de_Servicio_PericialData,null,null).Resource
                           : _IDetalle_de_Oficio_de_Servicio_PericialApiConsumer.Insert(Detalle_de_Oficio_de_Servicio_PericialData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Oficio_de_Servicio_Pericial_Tipo_de_OficiosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_OficiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_OficiosApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Oficios", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Oficio_de_Servicio_Pericial_Servicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicios_Periciales", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_IPH_MPI(int MasterId, int referenceId, List<Detalle_de_IPH_MPIGridModelPost> Detalle_de_IPH_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_IPH_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_IPH_MPIData = _IDetalle_de_IPH_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_IPH_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_IPH_MPIData == null || Detalle_de_IPH_MPIData.Detalle_de_IPH_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_IPH_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_IPH_MPI in Detalle_de_IPH_MPIData.Detalle_de_IPH_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_IPH_MPI Detalle_de_IPH_MPI1 = varDetalle_de_IPH_MPI;

                    if (Detalle_de_IPH_MPIItems != null && Detalle_de_IPH_MPIItems.Any(m => m.Clave == Detalle_de_IPH_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_IPH_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_IPH_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_IPH_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_IPH_MPIApiConsumer.Insert(varDetalle_de_IPH_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_IPH_MPI(List<Detalle_de_IPH_MPIGridModelPost> Detalle_de_IPH_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_IPH_MPI(MasterId, referenceId, Detalle_de_IPH_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_IPH_MPIItems != null && Detalle_de_IPH_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_IPH_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_IPH_MPIItem in Detalle_de_IPH_MPIItems)
                    {








                        //Removal Request
                        if (Detalle_de_IPH_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_IPH_MPIApiConsumer.Delete(Detalle_de_IPH_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_IPH_MPIItem.Clave = 0;

                        var Detalle_de_IPH_MPIData = new Detalle_de_IPH_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_IPH_MPIItem.Clave
                            ,NUE = Detalle_de_IPH_MPIItem.NUE
                            ,Folio = Detalle_de_IPH_MPIItem.Folio
                            ,Fecha = (Detalle_de_IPH_MPIItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_IPH_MPIItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Documentos = Detalle_de_IPH_MPIItem.Documentos
                            ,Archivo = Detalle_de_IPH_MPIItem.Archivo
                            ,Hora = Detalle_de_IPH_MPIItem.Hora

                        };

                        var resultId = Detalle_de_IPH_MPIItem.Clave > 0
                           ? _IDetalle_de_IPH_MPIApiConsumer.Update(Detalle_de_IPH_MPIData,null,null).Resource
                           : _IDetalle_de_IPH_MPIApiConsumer.Insert(Detalle_de_IPH_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }









        [NonAction]
        public bool CopyDetalle_de_Solicitante_en_Audiencias_MPI(int MasterId, int referenceId, List<Detalle_de_Solicitante_en_Audiencias_MPIGridModelPost> Detalle_de_Solicitante_en_Audiencias_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Solicitante_en_Audiencias_MPIData = _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Solicitante_en_Audiencias_MPIData == null || Detalle_de_Solicitante_en_Audiencias_MPIData.Detalle_de_Solicitante_en_Audiencias_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Solicitante_en_Audiencias_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Solicitante_en_Audiencias_MPI in Detalle_de_Solicitante_en_Audiencias_MPIData.Detalle_de_Solicitante_en_Audiencias_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Solicitante_en_Audiencias_MPI Detalle_de_Solicitante_en_Audiencias_MPI1 = varDetalle_de_Solicitante_en_Audiencias_MPI;

                    if (Detalle_de_Solicitante_en_Audiencias_MPIItems != null && Detalle_de_Solicitante_en_Audiencias_MPIItems.Any(m => m.Clave == Detalle_de_Solicitante_en_Audiencias_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Solicitante_en_Audiencias_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Solicitante_en_Audiencias_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Solicitante_en_Audiencias_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.Insert(varDetalle_de_Solicitante_en_Audiencias_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Solicitante_en_Audiencias_MPI(List<Detalle_de_Solicitante_en_Audiencias_MPIGridModelPost> Detalle_de_Solicitante_en_Audiencias_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Solicitante_en_Audiencias_MPI(MasterId, referenceId, Detalle_de_Solicitante_en_Audiencias_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Solicitante_en_Audiencias_MPIItems != null && Detalle_de_Solicitante_en_Audiencias_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Solicitante_en_Audiencias_MPIItem in Detalle_de_Solicitante_en_Audiencias_MPIItems)
                    {




                        //Removal Request
                        if (Detalle_de_Solicitante_en_Audiencias_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.Delete(Detalle_de_Solicitante_en_Audiencias_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Solicitante_en_Audiencias_MPIItem.Clave = 0;

                        var Detalle_de_Solicitante_en_Audiencias_MPIData = new Detalle_de_Solicitante_en_Audiencias_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Solicitante_en_Audiencias_MPIItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Solicitante_en_Audiencias_MPIItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitante_en_Audiencias_MPIItem.Nombre))
                            ,Direccion = Detalle_de_Solicitante_en_Audiencias_MPIItem.Direccion

                        };

                        var resultId = Detalle_de_Solicitante_en_Audiencias_MPIItem.Clave > 0
                           ? _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.Update(Detalle_de_Solicitante_en_Audiencias_MPIData,null,null).Resource
                           : _IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer.Insert(Detalle_de_Solicitante_en_Audiencias_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Solicitante_en_Audiencias_MPI_Solicitante_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitante_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitante_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitante_MPI", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Requerido_en_Audiencias_MPI(int MasterId, int referenceId, List<Detalle_de_Requerido_en_Audiencias_MPIGridModelPost> Detalle_de_Requerido_en_Audiencias_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Requerido_en_Audiencias_MPIData = _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Requerido_en_Audiencias_MPIData == null || Detalle_de_Requerido_en_Audiencias_MPIData.Detalle_de_Requerido_en_Audiencias_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Requerido_en_Audiencias_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Requerido_en_Audiencias_MPI in Detalle_de_Requerido_en_Audiencias_MPIData.Detalle_de_Requerido_en_Audiencias_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Requerido_en_Audiencias_MPI Detalle_de_Requerido_en_Audiencias_MPI1 = varDetalle_de_Requerido_en_Audiencias_MPI;

                    if (Detalle_de_Requerido_en_Audiencias_MPIItems != null && Detalle_de_Requerido_en_Audiencias_MPIItems.Any(m => m.Clave == Detalle_de_Requerido_en_Audiencias_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Requerido_en_Audiencias_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Requerido_en_Audiencias_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Requerido_en_Audiencias_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.Insert(varDetalle_de_Requerido_en_Audiencias_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Requerido_en_Audiencias_MPI(List<Detalle_de_Requerido_en_Audiencias_MPIGridModelPost> Detalle_de_Requerido_en_Audiencias_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Requerido_en_Audiencias_MPI(MasterId, referenceId, Detalle_de_Requerido_en_Audiencias_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Requerido_en_Audiencias_MPIItems != null && Detalle_de_Requerido_en_Audiencias_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Requerido_en_Audiencias_MPIItem in Detalle_de_Requerido_en_Audiencias_MPIItems)
                    {




                        //Removal Request
                        if (Detalle_de_Requerido_en_Audiencias_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.Delete(Detalle_de_Requerido_en_Audiencias_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Requerido_en_Audiencias_MPIItem.Clave = 0;

                        var Detalle_de_Requerido_en_Audiencias_MPIData = new Detalle_de_Requerido_en_Audiencias_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Requerido_en_Audiencias_MPIItem.Clave
                            ,Nombre = (Convert.ToInt32(Detalle_de_Requerido_en_Audiencias_MPIItem.Nombre) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Requerido_en_Audiencias_MPIItem.Nombre))
                            ,Direccion = Detalle_de_Requerido_en_Audiencias_MPIItem.Direccion

                        };

                        var resultId = Detalle_de_Requerido_en_Audiencias_MPIItem.Clave > 0
                           ? _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.Update(Detalle_de_Requerido_en_Audiencias_MPIData,null,null).Resource
                           : _IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer.Insert(Detalle_de_Requerido_en_Audiencias_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Requerido_en_Audiencias_MPI_Requerido_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRequerido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRequerido_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Requerido_MPI", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Citatorio_Audiencias(int MasterId, int referenceId, List<Detalle_de_Citatorio_AudienciasGridModelPost> Detalle_de_Citatorio_AudienciasItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Citatorio_AudienciasApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Citatorio_AudienciasData = _IDetalle_de_Citatorio_AudienciasApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Citatorio_AudienciasData == null || Detalle_de_Citatorio_AudienciasData.Detalle_de_Citatorio_Audienciass.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Citatorio_AudienciasGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Citatorio_Audiencias in Detalle_de_Citatorio_AudienciasData.Detalle_de_Citatorio_Audienciass)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Citatorio_Audiencias Detalle_de_Citatorio_Audiencias1 = varDetalle_de_Citatorio_Audiencias;

                    if (Detalle_de_Citatorio_AudienciasItems != null && Detalle_de_Citatorio_AudienciasItems.Any(m => m.Clave == Detalle_de_Citatorio_Audiencias1.Clave))
                    {
                        modelDataToChange = Detalle_de_Citatorio_AudienciasItems.FirstOrDefault(m => m.Clave == Detalle_de_Citatorio_Audiencias1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Citatorio_Audiencias.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Citatorio_AudienciasApiConsumer.Insert(varDetalle_de_Citatorio_Audiencias,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Citatorio_Audiencias(List<Detalle_de_Citatorio_AudienciasGridModelPost> Detalle_de_Citatorio_AudienciasItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Citatorio_Audiencias(MasterId, referenceId, Detalle_de_Citatorio_AudienciasItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Citatorio_AudienciasItems != null && Detalle_de_Citatorio_AudienciasItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Citatorio_AudienciasApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Citatorio_AudienciasItem in Detalle_de_Citatorio_AudienciasItems)
                    {







                        //Removal Request
                        if (Detalle_de_Citatorio_AudienciasItem.Removed)
                        {
                            result = result && _IDetalle_de_Citatorio_AudienciasApiConsumer.Delete(Detalle_de_Citatorio_AudienciasItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Citatorio_AudienciasItem.Clave = 0;

                        var Detalle_de_Citatorio_AudienciasData = new Detalle_de_Citatorio_Audiencias
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Citatorio_AudienciasItem.Clave
                            ,Numero_de_audiencia_citatorio = Detalle_de_Citatorio_AudienciasItem.Numero_de_audiencia_citatorio
                            ,Fecha = (Detalle_de_Citatorio_AudienciasItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Citatorio_AudienciasItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_de_Citatorio_AudienciasItem.Hora
                            ,Fecha_de_Aceptacion = (Detalle_de_Citatorio_AudienciasItem.Fecha_de_Aceptacion!= null) ? DateTime.ParseExact(Detalle_de_Citatorio_AudienciasItem.Fecha_de_Aceptacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Aceptacion = Detalle_de_Citatorio_AudienciasItem.Hora_de_Aceptacion

                        };

                        var resultId = Detalle_de_Citatorio_AudienciasItem.Clave > 0
                           ? _IDetalle_de_Citatorio_AudienciasApiConsumer.Update(Detalle_de_Citatorio_AudienciasData,null,null).Resource
                           : _IDetalle_de_Citatorio_AudienciasApiConsumer.Insert(Detalle_de_Citatorio_AudienciasData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        [NonAction]
        public bool CopyDetalle_de_Documentos_MPI(int MasterId, int referenceId, List<Detalle_de_Documentos_MPIGridModelPost> Detalle_de_Documentos_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Documentos_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Documentos_MPIData = _IDetalle_de_Documentos_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Documentos_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Documentos_MPIData == null || Detalle_de_Documentos_MPIData.Detalle_de_Documentos_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Documentos_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Documentos_MPI in Detalle_de_Documentos_MPIData.Detalle_de_Documentos_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Documentos_MPI Detalle_de_Documentos_MPI1 = varDetalle_de_Documentos_MPI;

                    if (Detalle_de_Documentos_MPIItems != null && Detalle_de_Documentos_MPIItems.Any(m => m.Clave == Detalle_de_Documentos_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Documentos_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Documentos_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Documentos_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Documentos_MPIApiConsumer.Insert(varDetalle_de_Documentos_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Documentos_MPI(List<Detalle_de_Documentos_MPIGridModelPost> Detalle_de_Documentos_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Documentos_MPI(MasterId, referenceId, Detalle_de_Documentos_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Documentos_MPIItems != null && Detalle_de_Documentos_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Documentos_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Documentos_MPIItem in Detalle_de_Documentos_MPIItems)
                    {





                        //Removal Request
                        if (Detalle_de_Documentos_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Documentos_MPIApiConsumer.Delete(Detalle_de_Documentos_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Documentos_MPIItem.Clave = 0;

                        var Detalle_de_Documentos_MPIData = new Detalle_de_Documentos_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Documentos_MPIItem.Clave
                            ,Fecha = (Detalle_de_Documentos_MPIItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Documentos_MPIItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Documento = Detalle_de_Documentos_MPIItem.Documento
                            ,Archivo = Detalle_de_Documentos_MPIItem.Archivo

                        };

                        var resultId = Detalle_de_Documentos_MPIItem.Clave > 0
                           ? _IDetalle_de_Documentos_MPIApiConsumer.Update(Detalle_de_Documentos_MPIData,null,null).Resource
                           : _IDetalle_de_Documentos_MPIApiConsumer.Insert(Detalle_de_Documentos_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_Coincidencias_MPI(int MasterId, int referenceId, List<Detalle_de_Coincidencias_MPIGridModelPost> Detalle_de_Coincidencias_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Coincidencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Coincidencias_MPIData = _IDetalle_de_Coincidencias_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Coincidencias_MPI.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Coincidencias_MPIData == null || Detalle_de_Coincidencias_MPIData.Detalle_de_Coincidencias_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Coincidencias_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Coincidencias_MPI in Detalle_de_Coincidencias_MPIData.Detalle_de_Coincidencias_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Coincidencias_MPI Detalle_de_Coincidencias_MPI1 = varDetalle_de_Coincidencias_MPI;

                    if (Detalle_de_Coincidencias_MPIItems != null && Detalle_de_Coincidencias_MPIItems.Any(m => m.Clave == Detalle_de_Coincidencias_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Coincidencias_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Coincidencias_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Coincidencias_MPI.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_Coincidencias_MPIApiConsumer.Insert(varDetalle_de_Coincidencias_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Coincidencias_MPI(List<Detalle_de_Coincidencias_MPIGridModelPost> Detalle_de_Coincidencias_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Coincidencias_MPI(MasterId, referenceId, Detalle_de_Coincidencias_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Coincidencias_MPIItems != null && Detalle_de_Coincidencias_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Coincidencias_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Coincidencias_MPIItem in Detalle_de_Coincidencias_MPIItems)
                    {








                        //Removal Request
                        if (Detalle_de_Coincidencias_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Coincidencias_MPIApiConsumer.Delete(Detalle_de_Coincidencias_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Coincidencias_MPIItem.Clave = 0;

                        var Detalle_de_Coincidencias_MPIData = new Detalle_de_Coincidencias_MPI
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_Coincidencias_MPIItem.Clave
                            ,Nombre_Completo = Detalle_de_Coincidencias_MPIItem.Nombre_Completo
                            ,Alias = Detalle_de_Coincidencias_MPIItem.Alias
                            ,Numero_de_Expediente = Detalle_de_Coincidencias_MPIItem.Numero_de_Expediente
                            ,NUAT = Detalle_de_Coincidencias_MPIItem.NUAT
                            ,NUC = Detalle_de_Coincidencias_MPIItem.NUC
                            ,Rol = Detalle_de_Coincidencias_MPIItem.Rol

                        };

                        var resultId = Detalle_de_Coincidencias_MPIItem.Clave > 0
                           ? _IDetalle_de_Coincidencias_MPIApiConsumer.Update(Detalle_de_Coincidencias_MPIData,null,null).Resource
                           : _IDetalle_de_Coincidencias_MPIApiConsumer.Insert(Detalle_de_Coincidencias_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }









        [NonAction]
        public bool CopyDetalle_de_Indicios(int MasterId, int referenceId, List<Detalle_de_IndiciosGridModelPost> Detalle_de_IndiciosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_IndiciosData = _IDetalle_de_IndiciosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Indicios.Expediente_Inicial_MPI=" + referenceId,"").Resource;
                if (Detalle_de_IndiciosData == null || Detalle_de_IndiciosData.Detalle_de_Indicioss.Count == 0)
                    return true;

                var result = true;

                Detalle_de_IndiciosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Indicios in Detalle_de_IndiciosData.Detalle_de_Indicioss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Indicios Detalle_de_Indicios1 = varDetalle_de_Indicios;

                    if (Detalle_de_IndiciosItems != null && Detalle_de_IndiciosItems.Any(m => m.Clave == Detalle_de_Indicios1.Clave))
                    {
                        modelDataToChange = Detalle_de_IndiciosItems.FirstOrDefault(m => m.Clave == Detalle_de_Indicios1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Indicios.Expediente_Inicial_MPI = MasterId;
                    var insertId = _IDetalle_de_IndiciosApiConsumer.Insert(varDetalle_de_Indicios,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Indicios(List<Detalle_de_IndiciosGridModelPost> Detalle_de_IndiciosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Indicios(MasterId, referenceId, Detalle_de_IndiciosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_IndiciosItems != null && Detalle_de_IndiciosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_IndiciosItem in Detalle_de_IndiciosItems)
                    {









                        //Removal Request
                        if (Detalle_de_IndiciosItem.Removed)
                        {
                            result = result && _IDetalle_de_IndiciosApiConsumer.Delete(Detalle_de_IndiciosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_IndiciosItem.Clave = 0;

                        var Detalle_de_IndiciosData = new Detalle_de_Indicios
                        {
                            Expediente_Inicial_MPI = MasterId
                            ,Clave = Detalle_de_IndiciosItem.Clave
                            ,Numero_de_Indicio = Detalle_de_IndiciosItem.Numero_de_Indicio
                            ,Nombre_de_Indicio = Detalle_de_IndiciosItem.Nombre_de_Indicio
                            ,Descripcion_de_Indicio = Detalle_de_IndiciosItem.Descripcion_de_Indicio
                            ,Motivo_de_Indicio = Detalle_de_IndiciosItem.Motivo_de_Indicio
                            ,Diligencia = (Convert.ToInt32(Detalle_de_IndiciosItem.Diligencia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_IndiciosItem.Diligencia))
                            ,Ubicacion = Detalle_de_IndiciosItem.Ubicacion
                            ,Estatus = (Convert.ToInt32(Detalle_de_IndiciosItem.Estatus) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_IndiciosItem.Estatus))

                        };

                        var resultId = Detalle_de_IndiciosItem.Clave > 0
                           ? _IDetalle_de_IndiciosApiConsumer.Update(Detalle_de_IndiciosData,null,null).Resource
                           : _IDetalle_de_IndiciosApiConsumer.Insert(Detalle_de_IndiciosData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [HttpGet]
        public ActionResult GetDetalle_de_Indicios_Servicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicios_Periciales", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Indicios_Estatus_de_IndicioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_IndicioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_de_Indicio", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_Bitacora_de_Canalizacion_MPI(int MasterId, int referenceId, List<Detalle_Bitacora_de_Canalizacion_MPIGridModelPost> Detalle_Bitacora_de_Canalizacion_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Bitacora_de_Canalizacion_MPIData = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial=" + referenceId,"").Resource;
                if (Detalle_Bitacora_de_Canalizacion_MPIData == null || Detalle_Bitacora_de_Canalizacion_MPIData.Detalle_Bitacora_de_Canalizacion_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_Bitacora_de_Canalizacion_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Bitacora_de_Canalizacion_MPI in Detalle_Bitacora_de_Canalizacion_MPIData.Detalle_Bitacora_de_Canalizacion_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Bitacora_de_Canalizacion_MPI Detalle_Bitacora_de_Canalizacion_MPI1 = varDetalle_Bitacora_de_Canalizacion_MPI;

                    if (Detalle_Bitacora_de_Canalizacion_MPIItems != null && Detalle_Bitacora_de_Canalizacion_MPIItems.Any(m => m.Clave == Detalle_Bitacora_de_Canalizacion_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_Bitacora_de_Canalizacion_MPIItems.FirstOrDefault(m => m.Clave == Detalle_Bitacora_de_Canalizacion_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Bitacora_de_Canalizacion_MPI.Expediente_Inicial = MasterId;
                    var insertId = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Insert(varDetalle_Bitacora_de_Canalizacion_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_Bitacora_de_Canalizacion_MPI(List<Detalle_Bitacora_de_Canalizacion_MPIGridModelPost> Detalle_Bitacora_de_Canalizacion_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Bitacora_de_Canalizacion_MPI(MasterId, referenceId, Detalle_Bitacora_de_Canalizacion_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Bitacora_de_Canalizacion_MPIItems != null && Detalle_Bitacora_de_Canalizacion_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Bitacora_de_Canalizacion_MPIItem in Detalle_Bitacora_de_Canalizacion_MPIItems)
                    {






                        //Removal Request
                        if (Detalle_Bitacora_de_Canalizacion_MPIItem.Removed)
                        {
                            result = result && _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Delete(Detalle_Bitacora_de_Canalizacion_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Bitacora_de_Canalizacion_MPIItem.Clave = 0;

                        var Detalle_Bitacora_de_Canalizacion_MPIData = new Detalle_Bitacora_de_Canalizacion_MPI
                        {
                            Expediente_Inicial = MasterId
                            ,Clave = Detalle_Bitacora_de_Canalizacion_MPIItem.Clave
                            ,Fecha_de_Cambio_de_Estatus = (Detalle_Bitacora_de_Canalizacion_MPIItem.Fecha_de_Cambio_de_Estatus!= null) ? DateTime.ParseExact(Detalle_Bitacora_de_Canalizacion_MPIItem.Fecha_de_Cambio_de_Estatus, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Cambio_de_Estatus = Detalle_Bitacora_de_Canalizacion_MPIItem.Hora_de_Cambio_de_Estatus
                            ,Estatus_Interno = (Convert.ToInt16(Detalle_Bitacora_de_Canalizacion_MPIItem.Estatus_Interno) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Bitacora_de_Canalizacion_MPIItem.Estatus_Interno))
                            ,Estatus_de_Canalizacion = (Convert.ToInt32(Detalle_Bitacora_de_Canalizacion_MPIItem.Estatus_de_Canalizacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Bitacora_de_Canalizacion_MPIItem.Estatus_de_Canalizacion))

                        };

                        var resultId = Detalle_Bitacora_de_Canalizacion_MPIItem.Clave > 0
                           ? _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Update(Detalle_Bitacora_de_Canalizacion_MPIData,null,null).Resource
                           : _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Insert(Detalle_Bitacora_de_Canalizacion_MPIData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }




        [HttpGet]
        public ActionResult GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_de_Expediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_de_Expediente_Inicial", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Bitacora_de_Canalizacion_MPI_Estatus_OrientadorAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_OrientadorApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_Orientador", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Expediente_Inicial script
        /// </summary>
        /// <param name="oExpediente_InicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Expediente_InicialModuleAttributeList)
        {
            for (int i = 0; i < Expediente_InicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Expediente_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Expediente_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Expediente_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Expediente_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Expediente_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Expediente_InicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Expediente_InicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Expediente_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Expediente_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Expediente_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Expediente_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strExpediente_InicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Expediente_Inicial.js")))
            {
                strExpediente_InicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Expediente_Inicial element attributes
            string userChangeJson = jsSerialize.Serialize(Expediente_InicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strExpediente_InicialScript.IndexOf("inpuElementArray");
            string splittedString = strExpediente_InicialScript.Substring(indexOfArray, strExpediente_InicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Expediente_InicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Expediente_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strExpediente_InicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strExpediente_InicialScript.Substring(indexOfArrayHistory, strExpediente_InicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strExpediente_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strExpediente_InicialScript.Substring(endIndexOfMainElement + indexOfArray, strExpediente_InicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Expediente_InicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Expediente_InicialModuleAttributeList.ChildModuleAttributeList)
                {
				if (item!= null && item.elements != null  && item.elements.Count>0)
                    ResponseChild += "\r\n  \n\r function set" + item.table + "Validation() { " +
                                    " \r\n var inpuElementChildArray =" + jsSerialize.Serialize(item.elements) + ";" +
                                    "  \r\n setInputEntityAttributes(inpuElementChildArray, \".\", 0);" +
                                    "  \r\n setDynamicRenderElement(); \n\r } ";

                }
            }
            finalResponse = finalResponse.Substring(0, finalResponse.IndexOf("});") + 4) +  "\n\r";
            finalResponse += ResponseChild;
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Expediente_Inicial.js")))
            {
                w.WriteLine(finalResponse);
            }
            
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public JsonResult ReadScriptSettings()
        {
            string strCustomScript = string.Empty;
            
            CustomElementAttribute oCustomElementAttribute = new CustomElementAttribute();

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Expediente_Inicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Expediente_Inicial.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("function set");
                string childJsonArray = "[";
                if (indexOfChildArray != -1)
                {
                    string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);

                    var funcionsValidations = splittedChildString.Split(new string[] { "function" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var str in funcionsValidations)
                    {
                        var tabla = str.Substring(0, str.IndexOf('('));
                        tabla = tabla.Trim().Replace("set", string.Empty).Replace("Validation", string.Empty);
                        childJsonArray += "{ \"table\": \"" + tabla + "\", \"elements\":";
                        int indexOfChildElement = str.IndexOf('[');
                        int endIndexOfChildElement = str.IndexOf(']') + 1;
                        childJsonArray += str.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement) + "},";
                    }
                }
                childJsonArray = childJsonArray.TrimEnd(',') + "]";
                var MainElementList = JsonConvert.DeserializeObject(mainJsonArray);
                var ChildElementList = JsonConvert.DeserializeObject(childJsonArray);

                oCustomElementAttribute.MainElement = MainElementList.ToString();

                if (indexOfChildArray != -1)
                {
                    oCustomElementAttribute.ChildElement = ChildElementList.ToString();
                }
            }
            else
            {
                oCustomElementAttribute.MainElement = string.Empty;
                oCustomElementAttribute.ChildElement = string.Empty;
            }        
            return Json(oCustomElementAttribute, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Expediente_InicialPropertyBag()
        {
            return PartialView("Expediente_InicialPropertyBag", "Expediente_Inicial");
        }
		
		public List<Spartan_Business_Rule> GetBusinessRules(int ObjectId, int Attribute)
        {
            if (!_tokenManager.GenerateToken())
                return null;
            List<Spartan_Business_Rule> result = new List<Spartan_Business_Rule>();
            _ISpartan_Business_RuleApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (Attribute != 0)
            {
                result = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId + " AND Attribute = " + Attribute, "").Resource.Spartan_Business_Rules;
            }
            else
            {
                List<Spartan_Business_Rule> partialResult = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId, "").Resource.Spartan_Business_Rules;
                foreach (var item in partialResult)
                {
                    if (item.Attribute == Attribute)
                    {
                        result.Add(item);
                    }
                    else//Busco las reglas con el event process en cuestion
                    {
                        _ISpartan_BR_Process_Event_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                        var eventProcess = _ISpartan_BR_Process_Event_DetailApiConsumer.ListaSelAll(0, 1000, "Business_Rule = " + item.BusinessRuleId, "").Resource;
                        if (Attribute == 0 && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 1).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 2) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 2 || x.Process_Event == 3).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 3) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 4 || x.Process_Event == 5).Count() > 0)
                        {
                            result.Add(item);
                        }
                        //TODO Faltan en la base de datos cuando creas una row de grilla
                    }
                }
            }
            return result;
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Datos_de_la_Victima_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Datos_de_la_Victima_MPI/AddDetalle_de_Datos_de_la_Victima_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Imputado_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Datos_del_Imputado_MPI/AddDetalle_de_Datos_del_Imputado_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_Datos_de_Delito_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Datos_de_Delito_MPI/AddDetalle_Datos_de_Delito_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Persona_Moral_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Persona_Moral_MPI/AddDetalle_de_Persona_Moral_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Servicio_de_Apoyo_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Servicio_de_Apoyo_MPI/AddDetalle_de_Servicio_de_Apoyo_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Testigo_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Datos_del_Testigo_MPI/AddDetalle_de_Datos_del_Testigo_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Agente_del_Ministerio_Publico(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Agente_del_Ministerio_Publico/AddDetalle_de_Agente_del_Ministerio_Publico");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Servicios_Periciales(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Servicios_Periciales/AddDetalle_de_Servicios_Periciales");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Oficio_de_Servicio_Pericial(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Oficio_de_Servicio_Pericial/AddDetalle_de_Oficio_de_Servicio_Pericial");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_IPH_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_IPH_MPI/AddDetalle_de_IPH_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Solicitante_en_Audiencias_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Solicitante_en_Audiencias_MPI/AddDetalle_de_Solicitante_en_Audiencias_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Requerido_en_Audiencias_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Requerido_en_Audiencias_MPI/AddDetalle_de_Requerido_en_Audiencias_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Citatorio_Audiencias(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Citatorio_Audiencias/AddDetalle_de_Citatorio_Audiencias");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Documentos_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Documentos_MPI/AddDetalle_de_Documentos_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Coincidencias_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Coincidencias_MPI/AddDetalle_de_Coincidencias_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Indicios(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Indicios/AddDetalle_de_Indicios");
        }

        [HttpGet]
        public ActionResult AddDetalle_Bitacora_de_Canalizacion_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Bitacora_de_Canalizacion_MPI/AddDetalle_Bitacora_de_Canalizacion_MPI");
        }



        #endregion "Controller Methods"

        #region "Custom methods"
		
		[HttpGet]
        public FileStreamResult PrintFormats(int idFormat, string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            _IGeneratePDFApiConsumer.SetAuthHeader(_tokenManager.Token);
            _ISpartan_FormatRelatedApiConsumer.SetAuthHeader(_tokenManager.Token);

            MemoryStream ms = new MemoryStream();
           
            //Buscar los Formatos Relacionados
            var relacionados = _ISpartan_FormatRelatedApiConsumer.ListaSelAll(0, 5000, "Spartan_Format_Related.FormatId = " + idFormat, "").Resource.Spartan_Format_Relateds.OrderBy(r => r.Order).ToList();
            if (relacionados.Count > 0)
            {
                var outputDocument = new iTextSharp.text.Document();
                var writer = new PdfCopy(outputDocument, ms);
                outputDocument.Open();
                foreach (var spartan_Format_Related in relacionados)
                {
                    var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(Convert.ToInt32(spartan_Format_Related.FormatId_Related), RecordId).Resource;
                    var reader = new PdfReader(bytePdf);
                    for (var j = 1; j <= reader.NumberOfPages; j++)
                    {
                        writer.AddPage(writer.GetImportedPage(reader, j));
                    }
                    writer.FreeReader(reader);
                    reader.Close();
                }
                writer.Close();
                outputDocument.Close();
                var allPagesContent = ms.GetBuffer();
                ms.Flush();
            }
            else {
                var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(idFormat, RecordId);
                ms.Write(bytePdf.Resource, 0, bytePdf.Resource.Length);           
            }
                
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Formatos.pdf");
            Response.Buffer = true;
            Response.Clear();
            Response.OutputStream.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
            Response.OutputStream.Flush();
            Response.End();

            return new FileStreamResult(Response.OutputStream, "application/pdf");
        }
		
		
		
		[HttpGet]
        public ActionResult GetFormats(string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            var formatList = new List<SelectListItem>();

            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);
            _ISpartan_Format_PermissionsApiConsumer.SetAuthHeader(_tokenManager.Token);
           _ISpartan_FormatApiConsumer.SetAuthHeader(_tokenManager.Token);

            var whereClause = " Spartan_Format_Permissions.Spartan_User_Role = " + SessionHelper.Role + " AND Spartan_Format_Permissions.Permission_Type = 1 AND Apply=1 ";
            var formatsPermisions = _ISpartan_Format_PermissionsApiConsumer.ListaSelAll(0, 500, whereClause, string.Empty).Resource;
            if (formatsPermisions.RowCount > 0)
            {
                var formats = string.Join(",", formatsPermisions.Spartan_Format_Permissionss.Select(f => f.Format).ToArray());
                var whereClauseFormat = "Object = 45119 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Expediente_Inicial.Clave= " + RecordId;
                            var result = _IExpediente_InicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
                            if (result != null && result.Resource != null && result.Resource.RowCount > 0)
                            {
                                formatList.Add(new SelectListItem
                                {
                                    Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                    Value = Convert.ToString(format.FormatId)
                                });
                            }
                        }
                        else
                        {
                            formatList.Add(new SelectListItem
                            {
                                Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                Value = Convert.ToString(format.FormatId)
                            });
                        }


                    }
                }
            }
            return Json(formatList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir, string where, string order, dynamic columnsVisible)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);
										  
			string[] arrayColumnsVisible = null;

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Expediente_InicialPropertyMapper());
			
			 if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Expediente_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Expediente_InicialPropertyMapper oExpediente_InicialPropertyMapper = new Expediente_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oExpediente_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IExpediente_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Expediente_Inicials == null)
                result.Expediente_Inicials = new List<Expediente_Inicial>();

            var data = result.Expediente_Inicials.Select(m => new Expediente_InicialGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,DetenidoDescripcion = CultureHelper.GetTraduction(m.Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,NUC = m.NUC
			,NIC = m.NIC
			,Hora_del_Detenido = m.Hora_del_Detenido
			,Hora_Puesto_a_Disposicion = m.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Clave.ToString(), "Folio") ?? (string)m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Turno = m.Turno
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_MPI_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_MPI_Pais.Nombre
                        ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_MPI_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_MPI_Estado.Nombre
                        ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_MPI_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                        ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_MPI_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_MPI_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos_MPI = m.Codigo_Postal_de_los_Hechos_MPI
			,Calle_de_los_Hechos_MPI = m.Calle_de_los_Hechos_MPI
			,Entre_Calle_MPI = m.Entre_Calle_MPI
			,Y_Calle_MPI = m.Y_Calle_MPI
			,Numero_Exrterior_de_los_Hechos_MPI = m.Numero_Exrterior_de_los_Hechos_MPI
			,Numero_Interior_de_los_Hechos_MPI = m.Numero_Interior_de_los_Hechos_MPI
			,Latitud_MPI = m.Latitud_MPI
			,Longitud_MPI = m.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Requiere_Diligencia = m.Requiere_Diligencia
			,Numero_de_Expediente_Victima = m.Numero_de_Expediente_Victima
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Asignar_Agente_del_Ministerio_Publico = m.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                        ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Solicitar_Diligencias = m.Solicitar_Diligencias
			,NUC_Audiencias = m.NUC_Audiencias
			,NIC_Audiencias = m.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (m.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro_Audiencias = m.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                        ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(m.Delegacion_Audiencias_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Audiencias_Delegacion.Descripcion
			,Domicilio_Delegacion_A = m.Domicilio_Delegacion_A
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
                        ,Fecha_de_RegistroI = (m.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_RegistroI = m.Hora_de_RegistroI
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,Delito_PrincipalDelito = CultureHelper.GetTraduction(m.Delito_Principal_Delito_Principal_MPI.Clave.ToString(), "Delito") ?? (string)m.Delito_Principal_Delito_Principal_MPI.Delito
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cumplimiento = m.Hora_de_Cumplimiento
			,Domicilio_para_el_Cumplimiento = m.Domicilio_para_el_Cumplimiento
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Acepta_Acuerdo = m.Acepta_Acuerdo
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45119, arrayColumnsVisible), "Expediente_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45119, arrayColumnsVisible), "Expediente_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45119, arrayColumnsVisible), "Expediente_InicialList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir,string where, string order)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

			where = HttpUtility.UrlEncode(where);
										   
            if (!_tokenManager.GenerateToken())
                return null;

            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Expediente_InicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Expediente_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Expediente_InicialPropertyMapper oExpediente_InicialPropertyMapper = new Expediente_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oExpediente_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IExpediente_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Expediente_Inicials == null)
                result.Expediente_Inicials = new List<Expediente_Inicial>();

            var data = result.Expediente_Inicials.Select(m => new Expediente_InicialGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,DetenidoDescripcion = CultureHelper.GetTraduction(m.Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,NUC = m.NUC
			,NIC = m.NIC
			,Hora_del_Detenido = m.Hora_del_Detenido
			,Hora_Puesto_a_Disposicion = m.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Clave.ToString(), "Folio") ?? (string)m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Turno = m.Turno
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_MPI_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_MPI_Pais.Nombre
                        ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_MPI_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_MPI_Estado.Nombre
                        ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_MPI_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                        ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_MPI_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_MPI_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos_MPI = m.Codigo_Postal_de_los_Hechos_MPI
			,Calle_de_los_Hechos_MPI = m.Calle_de_los_Hechos_MPI
			,Entre_Calle_MPI = m.Entre_Calle_MPI
			,Y_Calle_MPI = m.Y_Calle_MPI
			,Numero_Exrterior_de_los_Hechos_MPI = m.Numero_Exrterior_de_los_Hechos_MPI
			,Numero_Interior_de_los_Hechos_MPI = m.Numero_Interior_de_los_Hechos_MPI
			,Latitud_MPI = m.Latitud_MPI
			,Longitud_MPI = m.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
			,Persona_Moral = m.Persona_Moral
			,Requiere_Diligencia = m.Requiere_Diligencia
			,Numero_de_Expediente_Victima = m.Numero_de_Expediente_Victima
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Asignar_Agente_del_Ministerio_Publico = m.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name
                        ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Solicitar_Diligencias = m.Solicitar_Diligencias
			,NUC_Audiencias = m.NUC_Audiencias
			,NIC_Audiencias = m.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (m.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro_Audiencias = m.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                        ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(m.Delegacion_Audiencias_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Audiencias_Delegacion.Descripcion
			,Domicilio_Delegacion_A = m.Domicilio_Delegacion_A
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
                        ,Fecha_de_RegistroI = (m.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_RegistroI = m.Hora_de_RegistroI
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Expediente_Inicial.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,Delito_PrincipalDelito = CultureHelper.GetTraduction(m.Delito_Principal_Delito_Principal_MPI.Clave.ToString(), "Delito") ?? (string)m.Delito_Principal_Delito_Principal_MPI.Delito
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cumplimiento = m.Hora_de_Cumplimiento
			,Domicilio_para_el_Cumplimiento = m.Domicilio_para_el_Cumplimiento
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
			,Parcialidades = m.Parcialidades
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Acepta_Acuerdo = m.Acepta_Acuerdo
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
		
		[HttpGet]
        public JsonResult CreateID()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IExpediente_InicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_del_Caso(Expediente_Inicial_Datos_del_CasoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_del_CasoInfo = new Expediente_Inicial_Datos_del_Caso
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varExpediente_Inicial.Hora_de_Registro
                        ,Usuario_que_Registra = varExpediente_Inicial.Usuario_que_Registra
                        ,Detenido = varExpediente_Inicial.Detenido
                        ,NUC = varExpediente_Inicial.NUC
                        ,NIC = varExpediente_Inicial.NIC
                        ,Hora_del_Detenido = varExpediente_Inicial.Hora_del_Detenido
                        ,Hora_Puesto_a_Disposicion = varExpediente_Inicial.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_Apoyo = varExpediente_Inicial.Solicitar_Servicos_de_Apoyo
                        ,Tipo_de_Oficio = varExpediente_Inicial.Tipo_de_Oficio
                        ,Delegacion = varExpediente_Inicial.Delegacion
                        ,Agencia = varExpediente_Inicial.Agencia
                        ,Solicitar_Diligencias = varExpediente_Inicial.Solicitar_Diligencias
                        ,Numero_de_Expediente = varExpediente_Inicial.Numero_de_Expediente
                        ,NUAT = varExpediente_Inicial.NUAT
                        ,Estatus = varExpediente_Inicial.Estatus
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_del_Caso(Expediente_Inicial_Datos_del_CasoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Caso(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_del_Caso(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_del_CasoModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Detenido = m.Detenido
                        ,DetenidoDescripcion = CultureHelper.GetTraduction(m.Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,NUC = m.NUC
			,NIC = m.NIC
			,Hora_del_Detenido = m.Hora_del_Detenido
			,Hora_Puesto_a_Disposicion = m.Hora_Puesto_a_Disposicion
                        ,Solicitar_Servicos_de_Apoyo = m.Solicitar_Servicos_de_Apoyo
                        ,Solicitar_Servicos_de_ApoyoFolio = CultureHelper.GetTraduction(m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Clave.ToString(), "Folio") ?? (string)m.Solicitar_Servicos_de_Apoyo_Modulo_Atencion_Inicial.Folio
                        ,Tipo_de_Oficio = m.Tipo_de_Oficio
                        ,Tipo_de_OficioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Tipo_de_Oficio.Descripcion
                        ,Delegacion = m.Delegacion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,Agencia = m.Agencia
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Solicitar_Diligencias = m.Solicitar_Diligencias
			,Numero_de_Expediente = m.Numero_de_Expediente
			,NUAT = m.NUAT
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Expediente_Inicial.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_la_Victima(Expediente_Inicial_Datos_de_la_VictimaModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_de_la_VictimaInfo = new Expediente_Inicial_Datos_de_la_Victima
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Persona_Moral = varExpediente_Inicial.Persona_Moral
                        ,Requiere_Diligencia = varExpediente_Inicial.Requiere_Diligencia
                        ,Numero_de_Expediente_Victima = varExpediente_Inicial.Numero_de_Expediente_Victima
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_de_la_Victima(Expediente_Inicial_Datos_de_la_VictimaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_la_Victima(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_de_la_Victima(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_de_la_VictimaModel
                {
                    Clave = m.Clave
			,Persona_Moral = m.Persona_Moral
			,Requiere_Diligencia = m.Requiere_Diligencia
			,Numero_de_Expediente_Victima = m.Numero_de_Expediente_Victima

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Imputado(Expediente_Inicial_Datos_del_ImputadoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_del_ImputadoInfo = new Expediente_Inicial_Datos_del_Imputado
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_del_Imputado(Expediente_Inicial_Datos_del_ImputadoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Imputado(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_del_Imputado(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_del_ImputadoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Delito(Expediente_Inicial_Datos_del_DelitoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_del_DelitoInfo = new Expediente_Inicial_Datos_del_Delito
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_del_Delito(Expediente_Inicial_Datos_del_DelitoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Delito(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_del_Delito(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_del_DelitoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_los_Hechos(Expediente_Inicial_Datos_de_los_HechosModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_de_los_HechosInfo = new Expediente_Inicial_Datos_de_los_Hechos
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Narrativa_Breve_de_los_Hechos = varExpediente_Inicial.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varExpediente_Inicial.Prioridad_del_Hecho
                        ,Turno = varExpediente_Inicial.Turno
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_del_Hecho)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Hecho = varExpediente_Inicial.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPI = varExpediente_Inicial.Pais_de_los_Hechos_MPI
                        ,Estado_de_los_Hechos_MPI = varExpediente_Inicial.Estado_de_los_Hechos_MPI
                        ,Municipio_de_los_Hechos_MPI = varExpediente_Inicial.Municipio_de_los_Hechos_MPI
                        ,Colonia_de_los_Hechos_MPI = varExpediente_Inicial.Colonia_de_los_Hechos_MPI
                        ,Codigo_Postal_de_los_Hechos_MPI = varExpediente_Inicial.Codigo_Postal_de_los_Hechos_MPI
                        ,Calle_de_los_Hechos_MPI = varExpediente_Inicial.Calle_de_los_Hechos_MPI
                        ,Entre_Calle_MPI = varExpediente_Inicial.Entre_Calle_MPI
                        ,Y_Calle_MPI = varExpediente_Inicial.Y_Calle_MPI
                        ,Numero_Exrterior_de_los_Hechos_MPI = varExpediente_Inicial.Numero_Exrterior_de_los_Hechos_MPI
                        ,Numero_Interior_de_los_Hechos_MPI = varExpediente_Inicial.Numero_Interior_de_los_Hechos_MPI
                        ,Latitud_MPI = varExpediente_Inicial.Latitud_MPI
                        ,Longitud_MPI = varExpediente_Inicial.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPI = varExpediente_Inicial.Tipo_de_Lugar_del_Hecho_MPI
                        ,Titulo_del_Hecho = varExpediente_Inicial.Titulo_del_Hecho
                        ,Delito_Principal = varExpediente_Inicial.Delito_Principal
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_de_los_Hechos(Expediente_Inicial_Datos_de_los_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_de_los_HechosModel
                {
                    Clave = m.Clave
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = m.Prioridad_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
			,Turno = m.Turno
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Hecho = m.Hora_del_Hecho
                        ,Pais_de_los_Hechos_MPI = m.Pais_de_los_Hechos_MPI
                        ,Pais_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_MPI_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_los_Hechos_MPI_Pais.Nombre
                        ,Estado_de_los_Hechos_MPI = m.Estado_de_los_Hechos_MPI
                        ,Estado_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_MPI_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_los_Hechos_MPI_Estado.Nombre
                        ,Municipio_de_los_Hechos_MPI = m.Municipio_de_los_Hechos_MPI
                        ,Municipio_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_MPI_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_los_Hechos_MPI_Municipio.Nombre
                        ,Colonia_de_los_Hechos_MPI = m.Colonia_de_los_Hechos_MPI
                        ,Colonia_de_los_Hechos_MPINombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_MPI_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_los_Hechos_MPI_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos_MPI = m.Codigo_Postal_de_los_Hechos_MPI
			,Calle_de_los_Hechos_MPI = m.Calle_de_los_Hechos_MPI
			,Entre_Calle_MPI = m.Entre_Calle_MPI
			,Y_Calle_MPI = m.Y_Calle_MPI
			,Numero_Exrterior_de_los_Hechos_MPI = m.Numero_Exrterior_de_los_Hechos_MPI
			,Numero_Interior_de_los_Hechos_MPI = m.Numero_Interior_de_los_Hechos_MPI
			,Latitud_MPI = m.Latitud_MPI
			,Longitud_MPI = m.Longitud_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPI = m.Tipo_de_Lugar_del_Hecho_MPI
                        ,Tipo_de_Lugar_del_Hecho_MPIDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_MPI_Lugar_Tipo.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Delito_Principal = m.Delito_Principal
                        ,Delito_PrincipalDelito = CultureHelper.GetTraduction(m.Delito_Principal_Delito_Principal_MPI.Clave.ToString(), "Delito") ?? (string)m.Delito_Principal_Delito_Principal_MPI.Delito

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_la_Persona_Moral(Expediente_Inicial_Datos_de_la_Persona_MoralModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_de_la_Persona_MoralInfo = new Expediente_Inicial_Datos_de_la_Persona_Moral
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_de_la_Persona_Moral(Expediente_Inicial_Datos_de_la_Persona_MoralInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_la_Persona_Moral(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_de_la_Persona_Moral(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_de_la_Persona_MoralModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Servicios_de_Apoyo(Expediente_Inicial_Servicios_de_ApoyoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Servicios_de_ApoyoInfo = new Expediente_Inicial_Servicios_de_Apoyo
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Requiere_Traductor = varExpediente_Inicial.Requiere_Traductor
                        ,Lengua_Originaria = varExpediente_Inicial.Lengua_Originaria
                        ,Idioma = varExpediente_Inicial.Idioma
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Servicios_de_Apoyo(Expediente_Inicial_Servicios_de_ApoyoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Servicios_de_Apoyo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Servicios_de_Apoyo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Servicios_de_ApoyoModel
                {
                    Clave = m.Clave
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_Originaria = m.Lengua_Originaria
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,Idioma = m.Idioma
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Testigo(Expediente_Inicial_Datos_del_TestigoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_del_TestigoInfo = new Expediente_Inicial_Datos_del_Testigo
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_del_Testigo(Expediente_Inicial_Datos_del_TestigoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Testigo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_del_Testigo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_del_TestigoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignar_MP(Expediente_Inicial_Asignar_MPModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Asignar_MPInfo = new Expediente_Inicial_Asignar_MP
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Asignar_Agente_del_Ministerio_Publico = varExpediente_Inicial.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_Publico = varExpediente_Inicial.Nombre_de_Agente_del_Ministerio_Publico
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Asignar_MP(Expediente_Inicial_Asignar_MPInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignar_MP(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Asignar_MP(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Asignar_MPModel
                {
                    Clave = m.Clave
			,Asignar_Agente_del_Ministerio_Publico = m.Asignar_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_Publico = m.Nombre_de_Agente_del_Ministerio_Publico
                        ,Nombre_de_Agente_del_Ministerio_PublicoName = CultureHelper.GetTraduction(m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_de_Agente_del_Ministerio_Publico_Spartan_User.Name

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Diligencias(Expediente_Inicial_DiligenciasModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_DiligenciasInfo = new Expediente_Inicial_Diligencias
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Diligencias(Expediente_Inicial_DiligenciasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Diligencias(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Diligencias(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_DiligenciasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_IPH(Expediente_Inicial_IPHModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_IPHInfo = new Expediente_Inicial_IPH
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_IPH(Expediente_Inicial_IPHInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_IPH(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_IPH(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_IPHModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Agenda_de_Audiencias_y_Citatorios(Expediente_Inicial_Agenda_de_Audiencias_y_CitatoriosModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Agenda_de_Audiencias_y_CitatoriosInfo = new Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,NUC_Audiencias = varExpediente_Inicial.NUC_Audiencias
                        ,NIC_Audiencias = varExpediente_Inicial.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Registro_Audiencias)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Registro_Audiencias, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro_Audiencias = varExpediente_Inicial.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_Audiencias = varExpediente_Inicial.Tipo_de_Oficio_Audiencias
                        ,Delegacion_Audiencias = varExpediente_Inicial.Delegacion_Audiencias
                        ,Domicilio_Delegacion_A = varExpediente_Inicial.Domicilio_Delegacion_A
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Agenda_de_Audiencias_y_Citatorios(Expediente_Inicial_Agenda_de_Audiencias_y_CitatoriosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Agenda_de_Audiencias_y_Citatorios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Agenda_de_Audiencias_y_Citatorios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Agenda_de_Audiencias_y_CitatoriosModel
                {
                    Clave = m.Clave
			,NUC_Audiencias = m.NUC_Audiencias
			,NIC_Audiencias = m.NIC_Audiencias
                        ,Fecha_de_Registro_Audiencias = (m.Fecha_de_Registro_Audiencias == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro_Audiencias).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro_Audiencias = m.Hora_de_Registro_Audiencias
                        ,Tipo_de_Oficio_Audiencias = m.Tipo_de_Oficio_Audiencias
                        ,Tipo_de_Oficio_AudienciasDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Oficio_Audiencias_Tipo_de_Oficio.Descripcion
                        ,Delegacion_Audiencias = m.Delegacion_Audiencias
                        ,Delegacion_AudienciasDescripcion = CultureHelper.GetTraduction(m.Delegacion_Audiencias_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Audiencias_Delegacion.Descripcion
			,Domicilio_Delegacion_A = m.Domicilio_Delegacion_A

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Audiencias_Citatorios(Expediente_Inicial_Audiencias_CitatoriosModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Audiencias_CitatoriosInfo = new Expediente_Inicial_Audiencias_Citatorios
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Audiencias_Citatorios(Expediente_Inicial_Audiencias_CitatoriosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Audiencias_Citatorios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Audiencias_Citatorios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Audiencias_CitatoriosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Documentos(Expediente_Inicial_DocumentosModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_DocumentosInfo = new Expediente_Inicial_Documentos
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Documentos(Expediente_Inicial_DocumentosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Documentos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Documentos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_DocumentosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Bitacora_de_Coincidencias(Expediente_Inicial_Bitacora_de_CoincidenciasModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Bitacora_de_CoincidenciasInfo = new Expediente_Inicial_Bitacora_de_Coincidencias
                {
                    Clave = varExpediente_Inicial.Clave
                                        
                };

                result = _IExpediente_InicialApiConsumer.Update_Bitacora_de_Coincidencias(Expediente_Inicial_Bitacora_de_CoincidenciasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Bitacora_de_Coincidencias(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Bitacora_de_Coincidencias(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Bitacora_de_CoincidenciasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Indicios(Expediente_Inicial_IndiciosModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_IndiciosInfo = new Expediente_Inicial_Indicios
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Fecha_de_RegistroI = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_RegistroI)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_RegistroI, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_RegistroI = varExpediente_Inicial.Hora_de_RegistroI
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Indicios(Expediente_Inicial_IndiciosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Indicios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Indicios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_IndiciosModel
                {
                    Clave = m.Clave
                        ,Fecha_de_RegistroI = (m.Fecha_de_RegistroI == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_RegistroI).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_RegistroI = m.Hora_de_RegistroI

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Canalizar(Expediente_Inicial_CanalizarModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_CanalizarInfo = new Expediente_Inicial_Canalizar
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Canalizar_a = varExpediente_Inicial.Canalizar_a
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Canalizar(Expediente_Inicial_CanalizarInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Canalizar(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Canalizar(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_CanalizarModel
                {
                    Clave = m.Clave
                        ,Canalizar_a = m.Canalizar_a
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Acuerdo(Expediente_Inicial_Datos_del_AcuerdoModel varExpediente_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Expediente_Inicial_Datos_del_AcuerdoInfo = new Expediente_Inicial_Datos_del_Acuerdo
                {
                    Clave = varExpediente_Inicial.Clave
                                            ,Tipo_de_Acuerdo = varExpediente_Inicial.Tipo_de_Acuerdo
                        ,Fecha_de_Inicio_de_Acuerdo = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Inicio_de_Acuerdo)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Inicio_de_Acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varExpediente_Inicial.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varExpediente_Inicial.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cumplimiento = varExpediente_Inicial.Hora_de_Cumplimiento
                        ,Domicilio_para_el_Cumplimiento = varExpediente_Inicial.Domicilio_para_el_Cumplimiento
                        ,Monto_de_Reparacion_de_Danos = varExpediente_Inicial.Monto_de_Reparacion_de_Danos
                        ,Parcialidades = varExpediente_Inicial.Parcialidades
                        ,Periodicidad = varExpediente_Inicial.Periodicidad
                        ,Acepta_Acuerdo = varExpediente_Inicial.Acepta_Acuerdo
                        ,Motivo_de_Rechazo_de_Acuerdo = varExpediente_Inicial.Motivo_de_Rechazo_de_Acuerdo
                    
                };

                result = _IExpediente_InicialApiConsumer.Update_Datos_del_Acuerdo(Expediente_Inicial_Datos_del_AcuerdoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Acuerdo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IExpediente_InicialApiConsumer.Get_Datos_del_Acuerdo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Datos_de_la_Victima_MPI;
                var Detalle_de_Datos_de_la_Victima_MPIData = GetDetalle_de_Datos_de_la_Victima_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_de_la_Victima_MPI);
                int RowCount_Detalle_de_Datos_del_Imputado_MPI;
                var Detalle_de_Datos_del_Imputado_MPIData = GetDetalle_de_Datos_del_Imputado_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_MPI);
                int RowCount_Detalle_Datos_de_Delito_MPI;
                var Detalle_Datos_de_Delito_MPIData = GetDetalle_Datos_de_Delito_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Datos_de_Delito_MPI);
                int RowCount_Detalle_de_Persona_Moral_MPI;
                var Detalle_de_Persona_Moral_MPIData = GetDetalle_de_Persona_Moral_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Persona_Moral_MPI);
                int RowCount_Detalle_de_Servicio_de_Apoyo_MPI;
                var Detalle_de_Servicio_de_Apoyo_MPIData = GetDetalle_de_Servicio_de_Apoyo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicio_de_Apoyo_MPI);
                int RowCount_Detalle_de_Datos_del_Testigo_MPI;
                var Detalle_de_Datos_del_Testigo_MPIData = GetDetalle_de_Datos_del_Testigo_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_MPI);
                int RowCount_Detalle_de_Agente_del_Ministerio_Publico;
                var Detalle_de_Agente_del_Ministerio_PublicoData = GetDetalle_de_Agente_del_Ministerio_PublicoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Agente_del_Ministerio_Publico);
                int RowCount_Detalle_de_Servicios_Periciales;
                var Detalle_de_Servicios_PericialesData = GetDetalle_de_Servicios_PericialesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Servicios_Periciales);
                int RowCount_Detalle_de_Oficio_de_Servicio_Pericial;
                var Detalle_de_Oficio_de_Servicio_PericialData = GetDetalle_de_Oficio_de_Servicio_PericialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Oficio_de_Servicio_Pericial);
                int RowCount_Detalle_de_IPH_MPI;
                var Detalle_de_IPH_MPIData = GetDetalle_de_IPH_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_IPH_MPI);
                int RowCount_Detalle_de_Solicitante_en_Audiencias_MPI;
                var Detalle_de_Solicitante_en_Audiencias_MPIData = GetDetalle_de_Solicitante_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitante_en_Audiencias_MPI);
                int RowCount_Detalle_de_Requerido_en_Audiencias_MPI;
                var Detalle_de_Requerido_en_Audiencias_MPIData = GetDetalle_de_Requerido_en_Audiencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Requerido_en_Audiencias_MPI);
                int RowCount_Detalle_de_Citatorio_Audiencias;
                var Detalle_de_Citatorio_AudienciasData = GetDetalle_de_Citatorio_AudienciasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Citatorio_Audiencias);
                int RowCount_Detalle_de_Documentos_MPI;
                var Detalle_de_Documentos_MPIData = GetDetalle_de_Documentos_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Documentos_MPI);
                int RowCount_Detalle_de_Coincidencias_MPI;
                var Detalle_de_Coincidencias_MPIData = GetDetalle_de_Coincidencias_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Coincidencias_MPI);
                int RowCount_Detalle_de_Indicios;
                var Detalle_de_IndiciosData = GetDetalle_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios);
                int RowCount_Detalle_Bitacora_de_Canalizacion_MPI;
                var Detalle_Bitacora_de_Canalizacion_MPIData = GetDetalle_Bitacora_de_Canalizacion_MPIData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Bitacora_de_Canalizacion_MPI);

                var result = new Expediente_Inicial_Datos_del_AcuerdoModel
                {
                    Clave = m.Clave
                        ,Tipo_de_Acuerdo = m.Tipo_de_Acuerdo
                        ,Tipo_de_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,Fecha_de_Inicio_de_Acuerdo = (m.Fecha_de_Inicio_de_Acuerdo == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio_de_Acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cumplimiento = m.Hora_de_Cumplimiento
			,Domicilio_para_el_Cumplimiento = m.Domicilio_para_el_Cumplimiento
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
			,Parcialidades = m.Parcialidades
                        ,Periodicidad = m.Periodicidad
                        ,PeriodicidadDescripcion = CultureHelper.GetTraduction(m.Periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.Periodicidad_Periodicidad.Descripcion
			,Acepta_Acuerdo = m.Acepta_Acuerdo
			,Motivo_de_Rechazo_de_Acuerdo = m.Motivo_de_Rechazo_de_Acuerdo

                    
                };
				var resultData = new
                {
                    data = result
                    ,Datos_de_la_Victima = Detalle_de_Datos_de_la_Victima_MPIData
                    ,Datos_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData
                    ,Datos_del_Delito = Detalle_Datos_de_Delito_MPIData
                    ,Datos_de_la_Persona_Moral = Detalle_de_Persona_Moral_MPIData
                    ,Servicios_de_Apoyo = Detalle_de_Servicio_de_Apoyo_MPIData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData
                    ,Agentes_del_Ministerio_Publico = Detalle_de_Agente_del_Ministerio_PublicoData
                    ,Servicios_Periciales = Detalle_de_Servicios_PericialesData
                    ,Oficios = Detalle_de_Oficio_de_Servicio_PericialData
                    ,IPH = Detalle_de_IPH_MPIData
                    ,Solicitante_Audiencias = Detalle_de_Solicitante_en_Audiencias_MPIData
                    ,Requerido_Audiencias = Detalle_de_Requerido_en_Audiencias_MPIData
                    ,Citatorio_Audiencias = Detalle_de_Citatorio_AudienciasData
                    ,Documentos_MPI = Detalle_de_Documentos_MPIData
                    ,Coincidencias = Detalle_de_Coincidencias_MPIData
                    ,Indicio = Detalle_de_IndiciosData
                    ,Bitacora_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

