using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
//using Autofac.Integration.WebApi;
using System.Web.Mvc;
using Spartane.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Core.Domain;
using Spartane.Services.Security;
using Spartane.Services.Authentication;
using Spartane.Services.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.SpartaneFile;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.SpartaneFunction;
using Spartane.Web.Areas.WebApiConsumer.SpartaneObject;
using Spartane.Web.Areas.WebApiConsumer.SpartaneUserRoleObjectFunction;
using Spartane.Web.Areas.WebApiConsumer.GeneratePDF;
using Spartane.Web.Controllers;
using Spartane.Core.Domain.Binnacle;
using Spartane.Core.Domain.User;
using Spartane.Services.Spartan_Format;
using Spartane.Core.Domain.Spartan_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format;
using Spartane.Services.Spartan_Format_Type;
using Spartane.Core.Domain.Spartan_Format_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Type;
using Spartane.Services.Spartan_Metadata;
using Spartane.Core.Domain.Spartan_Metadata;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Metadata;
using Spartane.Services.Spartan_Format_Configuration;
using Spartane.Core.Domain.Spartan_Format_Configuration;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Configuration;
using Spartane.Services.Spartan_Format_Field;
using Spartane.Core.Domain.Spartan_Format_Field;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Field;
using Spartane.Services.Spartan_Format_Permission_Type;
using Spartane.Core.Domain.Spartan_Format_Permission_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permission_Type;
using Spartane.Services.Spartan_Format_Permissions;
using Spartane.Core.Domain.Spartan_Format_Permissions;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permissions;
using Spartane.Services.Spartan_Report;
using Spartane.Core.Domain.Spartan_Report;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report;
using Spartane.Services.Spartan_Report_Field_Type;
using Spartane.Core.Domain.Spartan_Report_Field_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Field_Type;
using Spartane.Services.Spartan_Report_Fields_Detail;
using Spartane.Core.Domain.Spartan_Report_Fields_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Fields_Detail;
using Spartane.Services.Spartan_Report_Format;
using Spartane.Core.Domain.Spartan_Report_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Format;
using Spartane.Services.Spartan_Report_Function;
using Spartane.Core.Domain.Spartan_Report_Function;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Function;
using Spartane.Services.Spartan_Report_Order_Type;
using Spartane.Core.Domain.Spartan_Report_Order_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Order_Type;
using Spartane.Services.Spartan_Report_Permission_Type;
using Spartane.Core.Domain.Spartan_Report_Permission_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Permission_Type;
using Spartane.Services.Spartan_Report_Permissions;
using Spartane.Core.Domain.Spartan_Report_Permissions;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Permissions;
using Spartane.Services.Spartan_Report_Presentation_Type;
using Spartane.Core.Domain.Spartan_Report_Presentation_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Presentation_Type;
using Spartane.Services.Spartan_Report_Presentation_View;
using Spartane.Core.Domain.Spartan_Report_Presentation_View;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Presentation_View;
using Spartane.Services.Spartan_Report_Status;
using Spartane.Core.Domain.Spartan_Report_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Status;
using Spartane.Core.Domain.Spartan_Report_Filter;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Filter;
using Spartane.Core.Domain.Spartan_Report_Advance_Filter;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Report_Advance_Filter;

using Spartane.Services.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Services.Spartan_User_Role;
using Spartane.Core.Domain.Spartan_User_Role;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User_Role;
using Spartane.Services.Spartan_User_Role_Status;
using Spartane.Core.Domain.Spartan_User_Role_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User_Role_Status;
using Spartane.Services.Spartan_User_Status;
using Spartane.Core.Domain.Spartan_User_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User_Status;


using Spartane.Services.Spartan_Traduction_Concept_Type;
using Spartane.Core.Domain.Spartan_Traduction_Concept_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Concept_Type;
using Spartane.Services.Spartan_Traduction_Detail;
using Spartane.Core.Domain.Spartan_Traduction_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Detail;
using Spartane.Services.Spartan_Traduction_Language;
using Spartane.Core.Domain.Spartan_Traduction_Language;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Language;
using Spartane.Services.Spartan_Traduction_Object;
using Spartane.Core.Domain.Spartan_Traduction_Object;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Object;
using Spartane.Services.Spartan_Traduction_Object_Type;
using Spartane.Core.Domain.Spartan_Traduction_Object_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Object_Type;
using Spartane.Services.Spartan_Traduction_Process;
using Spartane.Core.Domain.Spartan_Traduction_Process;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Process;
using Spartane.Services.Spartan_Traduction_Process_Data;
using Spartane.Core.Domain.Spartan_Traduction_Process_Data;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Process_Data;
using Spartane.Services.Spartan_Traduction_Process_Workflow;
using Spartane.Core.Domain.Spartan_Traduction_Process_Workflow;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Traduction_Process_Workflow;

using Spartane.Services.Spartan_WorkFlow;
using Spartane.Core.Domain.Spartan_WorkFlow;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow;
using Spartane.Services.Spartan_WorkFlow_Condition;
using Spartane.Core.Domain.Spartan_WorkFlow_Condition;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Condition;
using Spartane.Services.Spartan_WorkFlow_Condition_Operator;
using Spartane.Core.Domain.Spartan_WorkFlow_Condition_Operator;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Condition_Operator;
using Spartane.Services.Spartan_WorkFlow_Conditions_by_State;
using Spartane.Core.Domain.Spartan_WorkFlow_Conditions_by_State;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Conditions_by_State;
using Spartane.Services.Spartan_WorkFlow_Information_by_State;
using Spartane.Core.Domain.Spartan_WorkFlow_Information_by_State;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Information_by_State;
using Spartane.Services.Spartan_WorkFlow_Matrix_of_States;
using Spartane.Core.Domain.Spartan_WorkFlow_Matrix_of_States;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Matrix_of_States;
using Spartane.Services.Spartan_WorkFlow_Operator;
using Spartane.Core.Domain.Spartan_WorkFlow_Operator;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Operator;
using Spartane.Services.Spartan_WorkFlow_Phase_Status;
using Spartane.Core.Domain.Spartan_WorkFlow_Phase_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Phase_Status;
using Spartane.Services.Spartan_WorkFlow_Phase_Type;
using Spartane.Core.Domain.Spartan_WorkFlow_Phase_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Phase_Type;
using Spartane.Services.Spartan_WorkFlow_Phases;
using Spartane.Core.Domain.Spartan_WorkFlow_Phases;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Phases;
using Spartane.Services.Spartan_WorkFlow_Roles_by_State;
using Spartane.Core.Domain.Spartan_WorkFlow_Roles_by_State;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Roles_by_State;
using Spartane.Services.Spartan_WorkFlow_State;
using Spartane.Core.Domain.Spartan_WorkFlow_State;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_State;
using Spartane.Services.Spartan_WorkFlow_Status;
using Spartane.Core.Domain.Spartan_WorkFlow_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Status;
using Spartane.Services.Spartan_WorkFlow_Type_Flow_Control;
using Spartane.Core.Domain.Spartan_WorkFlow_Type_Flow_Control;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Type_Flow_Control;
using Spartane.Services.Spartan_WorkFlow_Type_Work_Distribution;
using Spartane.Core.Domain.Spartan_WorkFlow_Type_Work_Distribution;
using Spartane.Web.Areas.WebApiConsumer.Spartan_WorkFlow_Type_Work_Distribution;
using Spartane.Services.Spartan_Object;
using Spartane.Core.Domain.Spartan_Object;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object;


using Spartane.Services.SpartanChangePasswordAutorizationEstatus;
using Spartane.Core.Domain.SpartanChangePasswordAutorizationEstatus;
using Spartane.Web.Areas.WebApiConsumer.SpartanChangePasswordAutorizationEstatus;
using Spartane.Services.Spartan_ChangePasswordAutorization;
using Spartane.Core.Domain.Spartan_ChangePasswordAutorization;
using Spartane.Web.Areas.WebApiConsumer.Spartan_ChangePasswordAutorization;
using Spartane.Services.Spartan_User_Historical_Password;
using Spartane.Core.Domain.Spartan_User_Historical_Password;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User_Historical_Password;
using Spartane.Services.Spartan_Settings;
using Spartane.Core.Domain.Spartan_Settings;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Settings;

using Spartane.Services.Dialecto;
using Spartane.Core.Domain.Dialecto;
using Spartane.Web.Areas.WebApiConsumer.Dialecto;
using Spartane.Services.Barba;
using Spartane.Core.Domain.Barba;
using Spartane.Web.Areas.WebApiConsumer.Barba;
using Spartane.Services.Boca;
using Spartane.Core.Domain.Boca;
using Spartane.Web.Areas.WebApiConsumer.Boca;
using Spartane.Services.PasaTurnos;
using Spartane.Core.Domain.PasaTurnos;
using Spartane.Web.Areas.WebApiConsumer.PasaTurnos;
using Spartane.Services.A_Tiempo;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Services.Abogado;
using Spartane.Core.Domain.Abogado;
using Spartane.Web.Areas.WebApiConsumer.Abogado;
using Spartane.Services.Acta_de_Lectura_de_Derechos;
using Spartane.Core.Domain.Acta_de_Lectura_de_Derechos;
using Spartane.Web.Areas.WebApiConsumer.Acta_de_Lectura_de_Derechos;
using Spartane.Services.Adicciones;
using Spartane.Core.Domain.Adicciones;
using Spartane.Web.Areas.WebApiConsumer.Adicciones;
using Spartane.Services.Adicciones_de_Involucrado;
using Spartane.Core.Domain.Adicciones_de_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_de_Involucrado;
using Spartane.Services.Adicciones_Probable_Responsable;
using Spartane.Core.Domain.Adicciones_Probable_Responsable;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_Probable_Responsable;
using Spartane.Services.Agencia;
using Spartane.Core.Domain.Agencia;
using Spartane.Web.Areas.WebApiConsumer.Agencia;
using Spartane.Services.Agente_del_Ministerio_Publico;
using Spartane.Core.Domain.Agente_del_Ministerio_Publico;
using Spartane.Web.Areas.WebApiConsumer.Agente_del_Ministerio_Publico;
using Spartane.Services.Agravantes;
using Spartane.Core.Domain.Agravantes;
using Spartane.Web.Areas.WebApiConsumer.Agravantes;
using Spartane.Services.Agravantes_del_Delito;
using Spartane.Core.Domain.Agravantes_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Agravantes_del_Delito;
using Spartane.Services.Anteojos;
using Spartane.Core.Domain.Anteojos;
using Spartane.Web.Areas.WebApiConsumer.Anteojos;
using Spartane.Services.Articulo;
using Spartane.Core.Domain.Articulo;
using Spartane.Web.Areas.WebApiConsumer.Articulo;
using Spartane.Services.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Services.Asignacion_de_Turnos;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos;
using Spartane.Services.Audiencia_de_Control_Fundamento;
using Spartane.Core.Domain.Audiencia_de_Control_Fundamento;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Fundamento;
using Spartane.Services.Audiencia_de_Control_Hechos;
using Spartane.Core.Domain.Audiencia_de_Control_Hechos;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Hechos;
using Spartane.Services.Audiencia_de_Control_Procedimiento;
using Spartane.Core.Domain.Audiencia_de_Control_Procedimiento;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Procedimiento;
using Spartane.Services.Audiencia_de_Control_Reiteracion;
using Spartane.Core.Domain.Audiencia_de_Control_Reiteracion;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Reiteracion;
using Spartane.Services.Audiencia_de_Control_Solicitud;
using Spartane.Core.Domain.Audiencia_de_Control_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Solicitud;
using Spartane.Services.Autoridad;
using Spartane.Core.Domain.Autoridad;
using Spartane.Web.Areas.WebApiConsumer.Autoridad;
using Spartane.Services.Solicitud;
using Spartane.Core.Domain.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Services.Bigote;
using Spartane.Core.Domain.Bigote;
using Spartane.Web.Areas.WebApiConsumer.Bigote;
using Spartane.Services.Binario;
using Spartane.Core.Domain.Binario;
using Spartane.Web.Areas.WebApiConsumer.Binario;
using Spartane.Services.Bitacora_de_Sincronizacion;
using Spartane.Core.Domain.Bitacora_de_Sincronizacion;
using Spartane.Web.Areas.WebApiConsumer.Bitacora_de_Sincronizacion;
using Spartane.Services.Bitacora_de_Usuarios;
using Spartane.Core.Domain.Bitacora_de_Usuarios;
using Spartane.Web.Areas.WebApiConsumer.Bitacora_de_Usuarios;
using Spartane.Services.Cadena_de_Custodia;
using Spartane.Core.Domain.Cadena_de_Custodia;
using Spartane.Web.Areas.WebApiConsumer.Cadena_de_Custodia;
using Spartane.Services.Calendario;
using Spartane.Core.Domain.Calendario;
using Spartane.Web.Areas.WebApiConsumer.Calendario;
using Spartane.Services.Calendario_de_Citas;
using Spartane.Core.Domain.Calendario_de_Citas;
using Spartane.Web.Areas.WebApiConsumer.Calendario_de_Citas;
using Spartane.Services.Calidad_Migratoria;
using Spartane.Core.Domain.Calidad_Migratoria;
using Spartane.Web.Areas.WebApiConsumer.Calidad_Migratoria;
using Spartane.Services.Calvicie;
using Spartane.Core.Domain.Calvicie;
using Spartane.Web.Areas.WebApiConsumer.Calvicie;
using Spartane.Services.Cantidad_Cabello;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Cantidad_Cabello;
using Spartane.Services.Carga_de_Documentos_Lectura_de_Derechos;
using Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos;
using Spartane.Web.Areas.WebApiConsumer.Carga_de_Documentos_Lectura_de_Derechos;
using Spartane.Services.Carga_de_Documentos_de_Legislacion;
using Spartane.Core.Domain.Carga_de_Documentos_de_Legislacion;
using Spartane.Web.Areas.WebApiConsumer.Carga_de_Documentos_de_Legislacion;
using Spartane.Services.Catalogo_de_Estatus_de_Folio;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Folio;
using Spartane.Services.Catalogo_de_Estatus_de_Traslado;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Traslado;
using Spartane.Services.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Services.Catalogo_de_Movil_para_traslado;
using Spartane.Core.Domain.Catalogo_de_Movil_para_traslado;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Movil_para_traslado;
using Spartane.Services.Catalogo_de_Recoleccion;
using Spartane.Core.Domain.Catalogo_de_Recoleccion;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Recoleccion;
using Spartane.Services.Catalogo_Estatus_CC;
using Spartane.Core.Domain.Catalogo_Estatus_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_CC;
using Spartane.Services.Catalogo_Estatus_de_Replicacion;
using Spartane.Core.Domain.Catalogo_Estatus_de_Replicacion;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_de_Replicacion;
using Spartane.Services.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_Detenido_MPI;
using Spartane.Services.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Services.Catalogo_Numero_de_Preguntas;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Numero_de_Preguntas;
using Spartane.Services.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Services.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Services.Catalogo_Tipo_de_Embalaje_CC;
using Spartane.Core.Domain.Catalogo_Tipo_de_Embalaje_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Embalaje_CC;
using Spartane.Services.Catalogo_Tipo_de_Fijacion_CC;
using Spartane.Core.Domain.Catalogo_Tipo_de_Fijacion_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Fijacion_CC;
using Spartane.Services.Catalogo_Tipo_de_Indicio_CC;
using Spartane.Core.Domain.Catalogo_Tipo_de_Indicio_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Indicio_CC;
using Spartane.Services.Catalogo_Unidad_Administrativa_CC;
using Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Administrativa_CC;
using Spartane.Services.Catalogo_Unidad_Policial;
using Spartane.Core.Domain.Catalogo_Unidad_Policial;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Policial;
using Spartane.Services.Causas_de_Interrupcion;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using Spartane.Web.Areas.WebApiConsumer.Causas_de_Interrupcion;
using Spartane.Services.Cejas;
using Spartane.Core.Domain.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Services.Certifica_Defuncion;
using Spartane.Core.Domain.Certifica_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Certifica_Defuncion;
using Spartane.Services.Circunstancia_Defuncion;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Defuncion;
using Spartane.Services.Circunstancia_del_Delito;
using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;
using Spartane.Services.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Services.Circunstancias;
using Spartane.Core.Domain.Circunstancias;
using Spartane.Web.Areas.WebApiConsumer.Circunstancias;
using Spartane.Services.Circunstancias_del_Delito;
using Spartane.Core.Domain.Circunstancias_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancias_del_Delito;
using Spartane.Services.Especifica_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo;
using Spartane.Services.Clasificacion_en_Orden_de_Resultado;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using Spartane.Web.Areas.WebApiConsumer.Clasificacion_en_Orden_de_Resultado;
using Spartane.Services.Codigo_Postal;
using Spartane.Core.Domain.Codigo_Postal;
using Spartane.Web.Areas.WebApiConsumer.Codigo_Postal;
using Spartane.Services.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Services.Color_de_Cabello;
using Spartane.Core.Domain.Color_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Color_de_Cabello;
using Spartane.Services.Color_Ojos;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Color_Ojos;
using Spartane.Services.Color_Piel;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Web.Areas.WebApiConsumer.Color_Piel;
using Spartane.Services.Color_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Services.Compareciente;
using Spartane.Core.Domain.Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Compareciente;
using Spartane.Services.Complexion;
using Spartane.Core.Domain.Complexion;
using Spartane.Web.Areas.WebApiConsumer.Complexion;
using Spartane.Services.Concurso;
using Spartane.Core.Domain.Concurso;
using Spartane.Web.Areas.WebApiConsumer.Concurso;
using Spartane.Services.Consecuencia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;
using Spartane.Services.Contingencia;
using Spartane.Core.Domain.Contingencia;
using Spartane.Web.Areas.WebApiConsumer.Contingencia;
using Spartane.Services.Control_de_Tiempos_JA;
using Spartane.Core.Domain.Control_de_Tiempos_JA;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Tiempos_JA;
using Spartane.Services.Registro_de_Tiempo_por_Estatus;
using Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Tiempo_por_Estatus;
using Spartane.Services.Convenio;
using Spartane.Core.Domain.Convenio;
using Spartane.Web.Areas.WebApiConsumer.Convenio;
using Spartane.Services.Corporacion;
using Spartane.Core.Domain.Corporacion;
using Spartane.Web.Areas.WebApiConsumer.Corporacion;
using Spartane.Services.Correccion_de_Error_en_Estatus;
using Spartane.Core.Domain.Correccion_de_Error_en_Estatus;
using Spartane.Web.Areas.WebApiConsumer.Correccion_de_Error_en_Estatus;
using Spartane.Services.Cumplimiento;
using Spartane.Core.Domain.Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Cumplimiento;
using Spartane.Services.Datos_Personales_Adicionales_Involucrado;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Involucrado;
using Spartane.Services.Datos_Personales_Adicionales_Probable_Responsable;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable;
using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Probable_Responsable;
using Spartane.Services.Delegacion;
using Spartane.Core.Domain.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Services.Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Services.Delito_Principal_MPI;
using Spartane.Core.Domain.Delito_Principal_MPI;
using Spartane.Web.Areas.WebApiConsumer.Delito_Principal_MPI;
using Spartane.Services.Delitos_Violencia_Genero;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using Spartane.Web.Areas.WebApiConsumer.Delitos_Violencia_Genero;
using Spartane.Services.Descarga_de_Archivo;
using Spartane.Core.Domain.Descarga_de_Archivo;
using Spartane.Web.Areas.WebApiConsumer.Descarga_de_Archivo;
using Spartane.Services.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Services.Detalle_Datos_de_Delito_MPI;
using Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_de_Delito_MPI;
using Spartane.Services.Detalle_de_Abogado;
using Spartane.Core.Domain.Detalle_de_Abogado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Abogado;
using Spartane.Services.Detalle_de_Agente_del_Ministerio_Publico;
using Spartane.Core.Domain.Detalle_de_Agente_del_Ministerio_Publico;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Agente_del_Ministerio_Publico;
using Spartane.Services.Detalle_de_Asignacion_de_Citas;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Asignacion_de_Citas;
using Spartane.Services.Detalle_de_Asignacion_de_Especialista;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Asignacion_de_Especialista;
using Spartane.Services.Detalle_de_Bitacora_de_Cambios;
using Spartane.Core.Domain.Detalle_de_Bitacora_de_Cambios;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Bitacora_de_Cambios;
using Spartane.Services.Detalle_de_Canalizar_Estatus;
using Spartane.Core.Domain.Detalle_de_Canalizar_Estatus;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Canalizar_Estatus;
using Spartane.Services.Detalle_de_Citatorio_Audiencias;
using Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Citatorio_Audiencias;
using Spartane.Services.Detalle_de_Coincidencias;
using Spartane.Core.Domain.Detalle_de_Coincidencias;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Coincidencias;
using Spartane.Services.Detalle_de_coincidencias_a;
using Spartane.Core.Domain.Detalle_de_coincidencias_a;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_coincidencias_a;
using Spartane.Services.Detalle_de_Coincidencias_MPI;
using Spartane.Core.Domain.Detalle_de_Coincidencias_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Coincidencias_MPI;
using Spartane.Services.Detalle_de_Datos_de_la_Victima_MPI;
using Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_de_la_Victima_MPI;
using Spartane.Services.Detalle_de_Datos_de_Tutor;
using Spartane.Core.Domain.Detalle_de_Datos_de_Tutor;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_de_Tutor;
using Spartane.Services.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Services.Detalle_de_Datos_del_Imputado_CC;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_CC;
using Spartane.Services.Detalle_de_Datos_del_Testigo_CC;
using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Testigo_CC;
using Spartane.Services.Detalle_de_Datos_del_Testigo_MPI;
using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Testigo_MPI;
using Spartane.Services.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Services.Detalle_de_Delito;
using Spartane.Core.Domain.Detalle_de_Delito;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito;
using Spartane.Services.Detalle_de_Delito_de_Justicia;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito_de_Justicia;
using Spartane.Services.Detalle_de_Descarga_de_Archivo;
using Spartane.Core.Domain.Detalle_de_Descarga_de_Archivo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Descarga_de_Archivo;
using Spartane.Services.Detalle_de_Descripcion_de_Evidencia_CC;
using Spartane.Core.Domain.Detalle_de_Descripcion_de_Evidencia_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Descripcion_de_Evidencia_CC;
using Spartane.Services.Detalle_de_Desestimacion;
using Spartane.Core.Domain.Detalle_de_Desestimacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Desestimacion;
using Spartane.Services.Detalle_de_Devolucion_de_Indicios;
using Spartane.Core.Domain.Detalle_de_Devolucion_de_Indicios;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Devolucion_de_Indicios;
using Spartane.Services.Detalle_de_Documento_MPO;
using Spartane.Core.Domain.Detalle_de_Documento_MPO;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documento_MPO;
using Spartane.Services.Detalle_de_documentos;
using Spartane.Core.Domain.Detalle_de_documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_documentos;
using Spartane.Services.Detalle_de_Documentos_de_Legislacion;
using Spartane.Core.Domain.Detalle_de_Documentos_de_Legislacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_de_Legislacion;
using Spartane.Services.Detalle_de_Documentos_de_MPO;
using Spartane.Core.Domain.Detalle_de_Documentos_de_MPO;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_de_MPO;
using Spartane.Services.Detalle_de_Documentos_MPI;
using Spartane.Core.Domain.Detalle_de_Documentos_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPI;
using Spartane.Services.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPO;
using Spartane.Services.Detalle_de_Folio_Asignado_de_Usuario;
using Spartane.Core.Domain.Detalle_de_Folio_Asignado_de_Usuario;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Folio_Asignado_de_Usuario;
using Spartane.Services.Detalle_de_Folio_NUE_CC;
using Spartane.Core.Domain.Detalle_de_Folio_NUE_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Folio_NUE_CC;
using Spartane.Services.Detalle_de_Fotos_CC;
using Spartane.Core.Domain.Detalle_de_Fotos_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos_CC;
using Spartane.Services.Detalle_de_Fotos_de_Emergencia_CC;
using Spartane.Core.Domain.Detalle_de_Fotos_de_Emergencia_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos_de_Emergencia_CC;
using Spartane.Services.Detalle_de_Galeria_de_Detenidos;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Detenidos;
using Spartane.Services.Detalle_de_Galeria_de_Intervinientes;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Intervinientes;
using Spartane.Services.Detalle_de_Galeria_de_Testigos;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Testigos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Testigos;
using Spartane.Services.Detalle_de_Hechos_Audiencia_Inicial;
using Spartane.Core.Domain.Detalle_de_Hechos_Audiencia_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Hechos_Audiencia_Inicial;
using Spartane.Services.Detalle_de_Historial_de_Emergencia_CC;
using Spartane.Core.Domain.Detalle_de_Historial_de_Emergencia_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Historial_de_Emergencia_CC;
using Spartane.Services.Detalle_de_Imputado;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Services.Detalle_de_Indicios;
using Spartane.Core.Domain.Detalle_de_Indicios;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Indicios;
using Spartane.Services.Detalle_de_IPH_MPI;
using Spartane.Core.Domain.Detalle_de_IPH_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_IPH_MPI;
using Spartane.Services.Detalle_de_Lista_de_Asignaciones;
using Spartane.Core.Domain.Detalle_de_Lista_de_Asignaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Lista_de_Asignaciones;
using Spartane.Services.Detalle_de_Lista_de_Documentos_CC;
using Spartane.Core.Domain.Detalle_de_Lista_de_Documentos_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Lista_de_Documentos_CC;
using Spartane.Services.Detalle_de_Mensaje_de_Historial;
using Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Mensaje_de_Historial;
using Spartane.Services.Detalle_de_Oficio_de_Servicio_Pericial;
using Spartane.Core.Domain.Detalle_de_Oficio_de_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Oficio_de_Servicio_Pericial;
using Spartane.Services.Detalle_de_Persona_Moral;
using Spartane.Core.Domain.Detalle_de_Persona_Moral;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral;
using Spartane.Services.Detalle_de_Persona_Moral_JA;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_JA;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral_JA;
using Spartane.Services.Detalle_de_Persona_Moral_MPI;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral_MPI;
using Spartane.Services.Detalle_de_Referencia;
using Spartane.Core.Domain.Detalle_de_Referencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Referencia;
using Spartane.Services.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Services.Detalle_de_Relaciones;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Relaciones;
using Spartane.Services.Detalle_de_Requerido_en_Audiencias_MPI;
using Spartane.Core.Domain.Detalle_de_Requerido_en_Audiencias_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Audiencias_MPI;
using Spartane.Services.Detalle_de_Requerido_en_Comparecencia;
using Spartane.Core.Domain.Detalle_de_Requerido_en_Comparecencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Comparecencia;
using Spartane.Services.Detalle_de_Requerido_en_Examen;
using Spartane.Core.Domain.Detalle_de_Requerido_en_Examen;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Examen;
using Spartane.Services.Detalle_de_Requerido_en_Invitaciones;
using Spartane.Core.Domain.Detalle_de_Requerido_en_Invitaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Invitaciones;
using Spartane.Services.Detalle_de_Requerido_en_Reuniones;
using Spartane.Core.Domain.Detalle_de_Requerido_en_Reuniones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requerido_en_Reuniones;
using Spartane.Services.Detalle_de_Requeridos_Faltantes;
using Spartane.Core.Domain.Detalle_de_Requeridos_Faltantes;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Requeridos_Faltantes;
using Spartane.Services.Detalle_de_Retroalimentacion;
using Spartane.Core.Domain.Detalle_de_Retroalimentacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Retroalimentacion;
using Spartane.Services.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Reuniones_de_Mediacion;
using Spartane.Services.Detalle_de_Seguimiento;
using Spartane.Core.Domain.Detalle_de_Seguimiento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Seguimiento;
using Spartane.Services.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Services.Detalle_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo;
using Spartane.Services.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Services.Detalle_de_Servicios_Periciales;
using Spartane.Core.Domain.Detalle_de_Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicios_Periciales;
using Spartane.Services.Detalle_de_Solicitante_en_Audiencias_JA;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Audiencias_JA;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Audiencias_JA;
using Spartane.Services.Detalle_de_Solicitante_en_Audiencias_MPI;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Audiencias_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Audiencias_MPI;
using Spartane.Services.Detalle_de_Solicitante_en_Comparecencia;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Comparecencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Comparecencia;
using Spartane.Services.Detalle_de_Solicitante_en_Examen;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Examen;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Examen;
using Spartane.Services.Detalle_de_Solicitante_en_Invitaciones;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Invitaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Invitaciones;
using Spartane.Services.Detalle_de_Solicitante_en_Reuniones;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_en_Reuniones;
using Spartane.Services.Detalle_de_Solicitante_Fundamentos_JA;
using Spartane.Core.Domain.Detalle_de_Solicitante_Fundamentos_JA;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_Fundamentos_JA;
using Spartane.Services.Detalle_de_Solicitante_Procedimiento;
using Spartane.Core.Domain.Detalle_de_Solicitante_Procedimiento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_Procedimiento;
using Spartane.Services.Detalle_de_Solicitante_Reiteracion_Salud;
using Spartane.Core.Domain.Detalle_de_Solicitante_Reiteracion_Salud;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitante_Reiteracion_Salud;
using Spartane.Services.Detalle_de_Solicitud_Bitacora_de_Coincid;
using Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Bitacora_de_Coincid;
using Spartane.Services.Detalle_de_Solicitud_Datos_de_Apoyo;
using Spartane.Core.Domain.Detalle_de_Solicitud_Datos_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Datos_de_Apoyo;
using Spartane.Services.Detalle_de_Solicitud_de_Indicio;
using Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_de_Indicio;
using Spartane.Services.Detalle_de_Solicitud_Representante_Legal;
using Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Representante_Legal;
using Spartane.Services.Detalle_de_Solicitud_Requerido;
using Spartane.Core.Domain.Detalle_de_Solicitud_Requerido;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Requerido;
using Spartane.Services.Detalle_de_Solicitud_Seguimiento;
using Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Seguimiento;
using Spartane.Services.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;
using Spartane.Services.Detalle_de_Solicitudes_de_Comparecencia;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Comparecencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitudes_de_Comparecencia;
using Spartane.Services.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Services.Detalle_de_Traslado_de_CC;
using Spartane.Core.Domain.Detalle_de_Traslado_de_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Traslado_de_CC;
using Spartane.Services.Detalle_de_Tutor;
using Spartane.Core.Domain.Detalle_de_Tutor;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Tutor;
using Spartane.Services.Detalle_de_Videos_CC;
using Spartane.Core.Domain.Detalle_de_Videos_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Videos_CC;
using Spartane.Services.Detalle_del_Abogado_Imputado_MPI;
using Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Imputado_MPI;
using Spartane.Services.Detalle_del_Abogado_Victima_MPI;
using Spartane.Core.Domain.Detalle_del_Abogado_Victima_MPI;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Victima_MPI;
using Spartane.Services.Detalle_del_Certificado_CC;
using Spartane.Core.Domain.Detalle_del_Certificado_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Certificado_CC;
using Spartane.Services.Detalle_del_Indicio;
using Spartane.Core.Domain.Detalle_del_Indicio;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Indicio;
using Spartane.Services.Detalle_Historico_JA;
using Spartane.Core.Domain.Detalle_Historico_JA;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Historico_JA;
using Spartane.Services.Detalle_Historico_MPO;
using Spartane.Core.Domain.Detalle_Historico_MPO;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Historico_MPO;
using Spartane.Services.Diligencias;
using Spartane.Core.Domain.Diligencias;
using Spartane.Web.Areas.WebApiConsumer.Diligencias;
using Spartane.Services.Director_de_Agencia;
using Spartane.Core.Domain.Director_de_Agencia;
using Spartane.Web.Areas.WebApiConsumer.Director_de_Agencia;
using Spartane.Services.Discapacidades_Fisicas;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Fisicas;
using Spartane.Services.Discapacidades_Mentales;
using Spartane.Core.Domain.Discapacidades_Mentales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Mentales;
using Spartane.Services.Discapacidades_Psicosociales;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Psicosociales;
using Spartane.Services.Discapacidades_Sensoriales;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using Spartane.Web.Areas.WebApiConsumer.Discapacidades_Sensoriales;
using Spartane.Services.Distrito_Judicial;
using Spartane.Core.Domain.Distrito_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Distrito_Judicial;
using Spartane.Services.Encuesta;
using Spartane.Core.Domain.Encuesta;
using Spartane.Web.Areas.WebApiConsumer.Encuesta;
using Spartane.Services.Elemento_Robado;
using Spartane.Core.Domain.Elemento_Robado;
using Spartane.Web.Areas.WebApiConsumer.Elemento_Robado;
using Spartane.Services.Elementos_Comision_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;
using Spartane.Services.Encuesta1;
using Spartane.Core.Domain.Encuesta1;
using Spartane.Web.Areas.WebApiConsumer.Encuesta1;
using Spartane.Services.Errores_de_Replicacion;
using Spartane.Core.Domain.Errores_de_Replicacion;
using Spartane.Web.Areas.WebApiConsumer.Errores_de_Replicacion;
using Spartane.Services.Escolaridad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Services.Especialidad;
using Spartane.Core.Domain.Especialidad;
using Spartane.Web.Areas.WebApiConsumer.Especialidad;
using Spartane.Services.Especialidad_MP;
using Spartane.Core.Domain.Especialidad_MP;
using Spartane.Web.Areas.WebApiConsumer.Especialidad_MP;
using Spartane.Services.Especialista_de_Justicia_Alternativa;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;
using Spartane.Web.Areas.WebApiConsumer.Especialista_de_Justicia_Alternativa;
using Spartane.Services.Estado;
using Spartane.Core.Domain.Estado;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Services.Estado_Civil;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Services.Estado_de_Involucrado;
using Spartane.Core.Domain.Estado_de_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Estado_de_Involucrado;
using Spartane.Services.Estatus;
using Spartane.Core.Domain.Estatus;
using Spartane.Web.Areas.WebApiConsumer.Estatus;
using Spartane.Services.Estatus_de_Actualizacion_de_Documento;
using Spartane.Core.Domain.Estatus_de_Actualizacion_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Actualizacion_de_Documento;
using Spartane.Services.Estatus_de_Asignacion;
using Spartane.Core.Domain.Estatus_de_Asignacion;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Asignacion;
using Spartane.Services.Estatus_de_Cita_Invitaciones;
using Spartane.Core.Domain.Estatus_de_Cita_Invitaciones;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Cita_Invitaciones;
using Spartane.Services.Estatus_Detalle_Documentos_Legislacion;
using Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Detalle_Documentos_Legislacion;
using Spartane.Services.Estatus_de_Documento;
using Spartane.Core.Domain.Estatus_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Documento;
using Spartane.Services.Estatus_de_Expediente;
using Spartane.Core.Domain.Estatus_de_Expediente;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente;
using Spartane.Services.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial;
using Spartane.Services.Estatus_de_Expediente_para_Reuniones;
using Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_para_Reuniones;
using Spartane.Services.Estatus_de_Indicio;
using Spartane.Core.Domain.Estatus_de_Indicio;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Indicio;
using Spartane.Services.Estatus_de_Notificacion;
using Spartane.Core.Domain.Estatus_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Notificacion;
using Spartane.Services.Estatus_de_Turno;
using Spartane.Core.Domain.Estatus_de_Turno;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Turno;
using Spartane.Services.Estatus_del_Dictamen;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Dictamen;
using Spartane.Services.Estatus_del_Imputado;
using Spartane.Core.Domain.Estatus_del_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Imputado;
using Spartane.Services.Estatus_Orientador;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;
using Spartane.Services.Estatus_Solicitud;
using Spartane.Core.Domain.Estatus_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Solicitud;
using Spartane.Services.Estudios_Superiores;
using Spartane.Core.Domain.Estudios_Superiores;
using Spartane.Web.Areas.WebApiConsumer.Estudios_Superiores;
using Spartane.Services.Etnia;
using Spartane.Core.Domain.Etnia;
using Spartane.Web.Areas.WebApiConsumer.Etnia;
using Spartane.Services.Expediente_Inicial;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial;
using Spartane.Services.Forma_Accion_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Services.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Services.Forma_Cara;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Services.Forma_de_Menton;
using Spartane.Core.Domain.Forma_de_Menton;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Menton;
using Spartane.Services.Forma_de_Nariz;
using Spartane.Core.Domain.Forma_de_Nariz;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Nariz;
using Spartane.Services.Froma_Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Froma_Ojos;
using Spartane.Services.Forma_Orejas;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Services.Forma_Cabello;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cabello;
using Spartane.Services.Formato_de_Control;
using Spartane.Core.Domain.Formato_de_Control;
using Spartane.Web.Areas.WebApiConsumer.Formato_de_Control;
using Spartane.Services.Formato_de_Seguimiento;
using Spartane.Core.Domain.Formato_de_Seguimiento;
using Spartane.Web.Areas.WebApiConsumer.Formato_de_Seguimiento;
using Spartane.Services.Frente;
using Spartane.Core.Domain.Frente;
using Spartane.Web.Areas.WebApiConsumer.Frente;
using Spartane.Services.Grosor_de_Labios;
using Spartane.Core.Domain.Grosor_de_Labios;
using Spartane.Web.Areas.WebApiConsumer.Grosor_de_Labios;
using Spartane.Services.Grupo_al_que_Pertenece;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using Spartane.Web.Areas.WebApiConsumer.Grupo_al_que_Pertenece;
using Spartane.Services.Grupo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Services.Grupo_Vulnerable;
using Spartane.Core.Domain.Grupo_Vulnerable;
using Spartane.Web.Areas.WebApiConsumer.Grupo_Vulnerable;
using Spartane.Services.Historial_de_Conversacion;
using Spartane.Core.Domain.Historial_de_Conversacion;
using Spartane.Web.Areas.WebApiConsumer.Historial_de_Conversacion;
using Spartane.Services.Identificacion;
using Spartane.Core.Domain.Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Identificacion;
using Spartane.Services.Idioma;
using Spartane.Core.Domain.Idioma;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
using Spartane.Services.Implantacion_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Implantacion_Cabello;
using Spartane.Services.Indicios;
using Spartane.Core.Domain.Indicios;
using Spartane.Web.Areas.WebApiConsumer.Indicios;
using Spartane.Services.Indicios_para_MPI;
using Spartane.Core.Domain.Indicios_para_MPI;
using Spartane.Web.Areas.WebApiConsumer.Indicios_para_MPI;
using Spartane.Services.Indigena;
using Spartane.Core.Domain.Indigena;
using Spartane.Web.Areas.WebApiConsumer.Indigena;
using Spartane.Services.Juez_de_Control;
using Spartane.Core.Domain.Juez_de_Control;
using Spartane.Web.Areas.WebApiConsumer.Juez_de_Control;
using Spartane.Services.Labios;
using Spartane.Core.Domain.Labios;
using Spartane.Web.Areas.WebApiConsumer.Labios;
using Spartane.Services.Largo_de_Cabello;
using Spartane.Core.Domain.Largo_de_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Largo_de_Cabello;
using Spartane.Services.Localidad;
using Spartane.Core.Domain.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Services.Lugar_de_Detencion;
using Spartane.Core.Domain.Lugar_de_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Lugar_de_Detencion;
using Spartane.Services.Lugar_del_Robo;
using Spartane.Core.Domain.Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Lugar_del_Robo;
using Spartane.Services.Lugar_Tipo;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Services.Lugares;
using Spartane.Core.Domain.Lugares;
using Spartane.Web.Areas.WebApiConsumer.Lugares;
using Spartane.Services.Lugares_Frecuentes_Involucrado;
using Spartane.Core.Domain.Lugares_Frecuentes_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Involucrado;
using Spartane.Services.Lugares_Frecuentes_Probable_Responsable;
using Spartane.Core.Domain.Lugares_Frecuentes_Probable_Responsable;
using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Probable_Responsable;
using Spartane.Services.Marca_del_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Services.Medidas_Cautelares;
using Spartane.Core.Domain.Medidas_Cautelares;
using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;
using Spartane.Services.Medios_Alternativos;
using Spartane.Core.Domain.Medios_Alternativos;
using Spartane.Web.Areas.WebApiConsumer.Medios_Alternativos;
using Spartane.Services.Menton;
using Spartane.Core.Domain.Menton;
using Spartane.Web.Areas.WebApiConsumer.Menton;
using Spartane.Services.Meses;
using Spartane.Core.Domain.Meses;
using Spartane.Web.Areas.WebApiConsumer.Meses;
using Spartane.Services.Jefes_de_Usuarios_del_Sistema;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using Spartane.Web.Areas.WebApiConsumer.Jefes_de_Usuarios_del_Sistema;
using Spartane.Services.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Services.Modalidad_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Services.Modulo;
using Spartane.Core.Domain.Modulo;
using Spartane.Web.Areas.WebApiConsumer.Modulo;
using Spartane.Services.Modulo_de_Atencion_Inicial;
using Spartane.Core.Domain.Modulo_de_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Modulo_de_Atencion_Inicial;
using Spartane.Services.Motivo_de_no_Acuerdo;
using Spartane.Core.Domain.Motivo_de_no_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_no_Acuerdo;
using Spartane.Services.Motivo_de_No_Canalizacion;
using Spartane.Core.Domain.Motivo_de_No_Canalizacion;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_No_Canalizacion;
using Spartane.Services.Motivo_de_Vehiculo;
using Spartane.Core.Domain.Motivo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Vehiculo;
using Spartane.Services.Motivo_Finalizacion_Turno;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;
using Spartane.Web.Areas.WebApiConsumer.Motivo_Finalizacion_Turno;
using Spartane.Services.Municipio;
using Spartane.Core.Domain.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Services.Nacionalidad;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Services.Nariz_Base;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Services.Nombre_Comparecencia;
using Spartane.Core.Domain.Nombre_Comparecencia;
using Spartane.Web.Areas.WebApiConsumer.Nombre_Comparecencia;
using Spartane.Services.Ocupacion;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Services.Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Web.Areas.WebApiConsumer.Ojos;
using Spartane.Services.Orientador;
using Spartane.Core.Domain.Orientador;
using Spartane.Web.Areas.WebApiConsumer.Orientador;
using Spartane.Services.Otras_Identificaciones_Involucrado;
using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Involucrado;
using Spartane.Services.Otras_Identificaciones_Probable_Responsable;
using Spartane.Core.Domain.Otras_Identificaciones_Probable_Responsable;
using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Probable_Responsable;
using Spartane.Services.Otros_Domicilios_Involucrado;
using Spartane.Core.Domain.Otros_Domicilios_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Involucrado;
using Spartane.Services.Otros_Domicilios_Probable_Responsable;
using Spartane.Core.Domain.Otros_Domicilios_Probable_Responsable;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Probable_Responsable;
using Spartane.Services.Otros_Nombres;
using Spartane.Core.Domain.Otros_Nombres;
using Spartane.Web.Areas.WebApiConsumer.Otros_Nombres;
using Spartane.Services.Pais;
using Spartane.Core.Domain.Pais;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Services.Parentesco;
using Spartane.Core.Domain.Parentesco;
using Spartane.Web.Areas.WebApiConsumer.Parentesco;
using Spartane.Services.Periodicidad;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Web.Areas.WebApiConsumer.Periodicidad;
using Spartane.Services.Prioridad_del_Hecho;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Services.Procedencia_del_Vehiculo;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo;
using Spartane.Services.Razon_de;
using Spartane.Core.Domain.Razon_de;
using Spartane.Web.Areas.WebApiConsumer.Razon_de;
using Spartane.Services.Razon_de_Incumplimiento;
using Spartane.Core.Domain.Razon_de_Incumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Razon_de_Incumplimiento;
using Spartane.Services.Recepcionistas;
using Spartane.Core.Domain.Recepcionistas;
using Spartane.Web.Areas.WebApiConsumer.Recepcionistas;
using Spartane.Services.Redes_Sociales;
using Spartane.Core.Domain.Redes_Sociales;
using Spartane.Web.Areas.WebApiConsumer.Redes_Sociales;
using Spartane.Services.Region;
using Spartane.Core.Domain.Region;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Services.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Services.Registro_de_Coincidencias;
using Spartane.Core.Domain.Registro_de_Coincidencias;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Coincidencias;
using Spartane.Services.Usuario;
using Spartane.Core.Domain.Usuario;
using Spartane.Web.Areas.WebApiConsumer.Usuario;
using Spartane.Services.Religion;
using Spartane.Core.Domain.Religion;
using Spartane.Web.Areas.WebApiConsumer.Religion;
using Spartane.Services.Reporte_Principal;
using Spartane.Core.Domain.Reporte_Principal;
using Spartane.Web.Areas.WebApiConsumer.Reporte_Principal;
using Spartane.Services.Requerido;
using Spartane.Core.Domain.Requerido;
using Spartane.Web.Areas.WebApiConsumer.Requerido;
using Spartane.Services.Requerido_MPI;
using Spartane.Core.Domain.Requerido_MPI;
using Spartane.Web.Areas.WebApiConsumer.Requerido_MPI;
using Spartane.Services.Requeridos_que_no_Asisten;
using Spartane.Core.Domain.Requeridos_que_no_Asisten;
using Spartane.Web.Areas.WebApiConsumer.Requeridos_que_no_Asisten;
using Spartane.Services.Respuesta;
using Spartane.Core.Domain.Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Respuesta;
using Spartane.Services.Rol_de_Diligencia;
using Spartane.Core.Domain.Rol_de_Diligencia;
using Spartane.Web.Areas.WebApiConsumer.Rol_de_Diligencia;
using Spartane.Services.Sentencia;
using Spartane.Core.Domain.Sentencia;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;
using Spartane.Services.Senas_Particulares;
using Spartane.Core.Domain.Senas_Particulares;
using Spartane.Web.Areas.WebApiConsumer.Senas_Particulares;
using Spartane.Services.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Services.Servicio_Medico;
using Spartane.Core.Domain.Servicio_Medico;
using Spartane.Web.Areas.WebApiConsumer.Servicio_Medico;
using Spartane.Services.Servicios_Alternativos;
using Spartane.Core.Domain.Servicios_Alternativos;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Alternativos;
using Spartane.Services.Servicios_de_Apoyo;
using Spartane.Core.Domain.Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Servicios_de_Apoyo;
using Spartane.Services.Servicios_Periciales;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;
using Spartane.Services.Agravantes_del_Delito_MASC;
using Spartane.Core.Domain.Agravantes_del_Delito_MASC;
using Spartane.Web.Areas.WebApiConsumer.Agravantes_del_Delito_MASC;
using Spartane.Services.Circunstancias_del_Delito_MASC;
using Spartane.Core.Domain.Circunstancias_del_Delito_MASC;
using Spartane.Web.Areas.WebApiConsumer.Circunstancias_del_Delito_MASC;
using Spartane.Services.Datos_Personales_Adicionales_Requerido_MASC;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Requerido_MASC;
using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Requerido_MASC;
using Spartane.Services.Datos_Personales_Adicionales_Solicitante_MASC;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Solicitante_MASC;
using Spartane.Services.Genero;
using Spartane.Core.Domain.Genero;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Services.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Services.Turnos;
using Spartane.Core.Domain.Turnos;
using Spartane.Web.Areas.WebApiConsumer.Turnos;
using Spartane.Services.Situacion_Fisica;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Web.Areas.WebApiConsumer.Situacion_Fisica;
using Spartane.Services.Solicitante;
using Spartane.Core.Domain.Solicitante;
using Spartane.Web.Areas.WebApiConsumer.Solicitante;
using Spartane.Services.Solicitante_MPI;
using Spartane.Core.Domain.Solicitante_MPI;
using Spartane.Web.Areas.WebApiConsumer.Solicitante_MPI;
using Spartane.Services.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Services.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Services.Tamano_de_Cejas;
using Spartane.Core.Domain.Tamano_de_Cejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Cejas;
using Spartane.Services.Tamano_de_Nariz;
using Spartane.Core.Domain.Tamano_de_Nariz;
using Spartane.Web.Areas.WebApiConsumer.Tamano_de_Nariz;
using Spartane.Services.Tamano_Orejas;
using Spartane.Core.Domain.Tamano_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tamano_Orejas;
using Spartane.Services.Tipo_Lobulo;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Lobulo;
using Spartane.Services.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Acuerdo;
using Spartane.Services.Tipo_de_Atencion;
using Spartane.Core.Domain.Tipo_de_Atencion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Atencion;
using Spartane.Services.Tipo_Cara;
using Spartane.Core.Domain.Tipo_Cara;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Cara;
using Spartane.Services.Tipo_de_Carretera;
using Spartane.Core.Domain.Tipo_de_Carretera;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Carretera;
using Spartane.Services.Tipo_de_Comparecencia;
using Spartane.Core.Domain.Tipo_de_Comparecencia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Comparecencia;
using Spartane.Services.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Services.Tipo_de_Denuncia;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
using Spartane.Services.Tipo_de_Diligencia_MASC;
using Spartane.Core.Domain.Tipo_de_Diligencia_MASC;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Diligencia_MASC;
using Spartane.Services.Tipo_de_Expediente;
using Spartane.Core.Domain.Tipo_de_Expediente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Expediente;
using Spartane.Services.Tipo_de_Funcion;
using Spartane.Core.Domain.Tipo_de_Funcion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Funcion;
using Spartane.Services.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Services.Tipo_de_Instancia;
using Spartane.Core.Domain.Tipo_de_Instancia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Instancia;
using Spartane.Services.Tipo_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Invitacion;
using Spartane.Services.Tipo_de_Lugar_del_Robo;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Lugar_del_Robo;
using Spartane.Services.Tipo_de_Mecanismo_Alterno;
using Spartane.Core.Domain.Tipo_de_Mecanismo_Alterno;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mecanismo_Alterno;
using Spartane.Services.Tipo_de_Notificacion;
using Spartane.Core.Domain.Tipo_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Notificacion;
using Spartane.Services.Tipo_de_Oficio;
using Spartane.Core.Domain.Tipo_de_Oficio;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Oficio;
using Spartane.Services.Tipo_de_Oficios;
using Spartane.Core.Domain.Tipo_de_Oficios;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Oficios;
using Spartane.Services.Tipo_de_Persona;
using Spartane.Core.Domain.Tipo_de_Persona;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Persona;
using Spartane.Services.Tipo_de_Robo;
using Spartane.Core.Domain.Tipo_de_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Robo;
using Spartane.Services.Tipo_de_Seguimiento;
using Spartane.Core.Domain.Tipo_de_Seguimiento;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Seguimiento;
using Spartane.Services.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Services.Tipo_de_Sesion;
using Spartane.Core.Domain.Tipo_de_Sesion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Sesion;
using Spartane.Services.Tipo_de_Tramite;
using Spartane.Core.Domain.Tipo_de_Tramite;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Tramite;
using Spartane.Services.Tipo_de_Urgencia;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Urgencia;
using Spartane.Services.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Services.Tipo_Delito;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;
using Spartane.Services.Titulo_del_Delito;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Titulo_del_Delito;
using Spartane.Services.TTFolioConsecutivo;
using Spartane.Core.Domain.TTFolioConsecutivo;
using Spartane.Web.Areas.WebApiConsumer.TTFolioConsecutivo;
using Spartane.Services.Unidad;
using Spartane.Core.Domain.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Services.Vigencia;
using Spartane.Core.Domain.Vigencia;
using Spartane.Web.Areas.WebApiConsumer.Vigencia;
using Spartane.Services.Violencia_de_Genero;
using Spartane.Core.Domain.Violencia_de_Genero;
using Spartane.Web.Areas.WebApiConsumer.Violencia_de_Genero;
using Spartane.Services.Zona;
using Spartane.Core.Domain.Zona;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Services.Control_de_Citas;
using Spartane.Core.Domain.Control_de_Citas;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Citas;
using Spartane.Services.Control_de_Documentos;
using Spartane.Core.Domain.Control_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Documentos;
using Spartane.Services.Detalle_Historial_Control_de_Documentos;
using Spartane.Core.Domain.Detalle_Historial_Control_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Historial_Control_de_Documentos;
using Spartane.Services.Origen_de_Invitacion;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Services.Documento_Extraviado;
using Spartane.Core.Domain.Documento_Extraviado;
using Spartane.Web.Areas.WebApiConsumer.Documento_Extraviado;
using Spartane.Services.Spartan_Object_ByPass;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass;
using Spartane.Services.Spartan_Attribute_Bypass;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass;
using Spartane.Services.Spartan_Record_Detail_Management;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Record_Detail_Management;
using Spartane.Services.Spartan_RDM_Filters_Detail;
using Spartane.Core.Domain.Spartan_RDM_Filters_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Filters_Detail;
using Spartane.Services.Spartan_RDM_Operations_Detail;
using Spartane.Core.Domain.Spartan_RDM_Operations_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Operations_Detail;
using Spartane.Services.Adicciones_de_Solicitante_MASC;
using Spartane.Core.Domain.Adicciones_de_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_de_Solicitante_MASC;
using Spartane.Services.Adicciones_Requerido_MASC;
using Spartane.Core.Domain.Adicciones_Requerido_MASC;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_Requerido_MASC;
using Spartane.Services.Detalle_de_Invitado_de_Notificacion;
using Spartane.Core.Domain.Detalle_de_Invitado_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Invitado_de_Notificacion;
using Spartane.Services.Dilgencia_MASC;
using Spartane.Core.Domain.Dilgencia_MASC;
using Spartane.Web.Areas.WebApiConsumer.Dilgencia_MASC;
using Spartane.Services.Detalle_Diligencias_MASC;
using Spartane.Core.Domain.Detalle_Diligencias_MASC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Diligencias_MASC;
using Spartane.Services.Incidente_con_Invitacion;
using Spartane.Core.Domain.Incidente_con_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Incidente_con_Invitacion;
using Spartane.Services.Lugares_Frecuentes_Requerido_MASC;
using Spartane.Core.Domain.Lugares_Frecuentes_Requerido_MASC;
using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Requerido_MASC;
using Spartane.Services.Lugares_Frecuentes_Solicitante_MASC;
using Spartane.Core.Domain.Lugares_Frecuentes_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Solicitante_MASC;
using Spartane.Services.Otras_Identificaciones_Requerido_MASC;
using Spartane.Core.Domain.Otras_Identificaciones_Requerido_MASC;
using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Requerido_MASC;
using Spartane.Services.Otras_Identificaciones_Solicitante_MASC;
using Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Solicitante_MASC;
using Spartane.Services.Otros_Domicilios_Requeridos_MASC;
using Spartane.Core.Domain.Otros_Domicilios_Requeridos_MASC;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Requeridos_MASC;
using Spartane.Services.Otros_Domicilios_Solicitante_MASC;
using Spartane.Core.Domain.Otros_Domicilios_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Solicitante_MASC;
using Spartane.Services.Otros_Nombres_Requerido_MASC;
using Spartane.Core.Domain.Otros_Nombres_Requerido_MASC;
using Spartane.Web.Areas.WebApiConsumer.Otros_Nombres_Requerido_MASC;
using Spartane.Services.Recepcion_de_Pago_MASC;
using Spartane.Core.Domain.Recepcion_de_Pago_MASC;
using Spartane.Web.Areas.WebApiConsumer.Recepcion_de_Pago_MASC;
using Spartane.Services.Resultado_de_Notificacion;
using Spartane.Core.Domain.Resultado_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Notificacion;
using Spartane.Services.Solicitud_de_Notificacion;
using Spartane.Core.Domain.Solicitud_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Notificacion;
using Spartane.Services.Relacion_Unidad_Usuario;
using Spartane.Core.Domain.Relacion_Unidad_Usuario;
using Spartane.Web.Areas.WebApiConsumer.Relacion_Unidad_Usuario;
using Spartane.Services.Resultado_de_Revision;
using Spartane.Core.Domain.Resultado_de_Revision;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Revision;
using Spartane.Services.Acuerdos_MASC;
using Spartane.Core.Domain.Acuerdos_MASC;
using Spartane.Web.Areas.WebApiConsumer.Acuerdos_MASC;
using Spartane.Services.Detalle_Requerido_Acuerdo;
using Spartane.Core.Domain.Detalle_Requerido_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Requerido_Acuerdo;
using Spartane.Services.Detalle_Solicitante_Acuerdo;
using Spartane.Core.Domain.Detalle_Solicitante_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitante_Acuerdo;
using Spartane.Services.Tipo_de_Conclusion_Anticipada;
using Spartane.Core.Domain.Tipo_de_Conclusion_Anticipada;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Conclusion_Anticipada;
using Spartane.Services.Detalle_Documentos_Solicitantes;
using Spartane.Core.Domain.Detalle_Documentos_Solicitantes;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Documentos_Solicitantes;
using Spartane.Services.Detalle_Documentos_Requeridos;
using Spartane.Core.Domain.Detalle_Documentos_Requeridos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Documentos_Requeridos;
using Spartane.Services.Formato_de_Denuncia;
using Spartane.Core.Domain.Formato_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Formato_de_Denuncia;
using Spartane.Services.Unidad_de_Atenciòn;
using Spartane.Core.Domain.Unidad_de_Atenciòn;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Atenciòn;
using Spartane.Services.Unidad_de_Atencion;
using Spartane.Core.Domain.Unidad_de_Atencion;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Atencion;
using Spartane.Services.Tipo_de_Documento;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Documento;
using Spartane.Services.Documento;
using Spartane.Core.Domain.Documento;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Services.Detalle_Involucrados_en_Documentos;
using Spartane.Core.Domain.Detalle_Involucrados_en_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Involucrados_en_Documentos;
using Spartane.Services.Detalle_Probable_Responsable_de_Documentos;
using Spartane.Core.Domain.Detalle_Probable_Responsable_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Probable_Responsable_de_Documentos;
using Spartane.Services.Detalle_Delitos_de_Documentos;
using Spartane.Core.Domain.Detalle_Delitos_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Delitos_de_Documentos;
using Spartane.Services.Motivo_de_Rechazo_de_Solicitud;
using Spartane.Core.Domain.Motivo_de_Rechazo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Rechazo_de_Solicitud;
using Spartane.Services.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Services.Forma_de_Cumplimiento;
using Spartane.Core.Domain.Forma_de_Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Cumplimiento;
using Spartane.Services.Tipo_de_Crimen;
using Spartane.Core.Domain.Tipo_de_Crimen;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Crimen;
using Spartane.Services.detalle_de_observaciones_mpi;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using Spartane.Web.Areas.WebApiConsumer.detalle_de_observaciones_mpi;
using Spartane.Services.estatus_mpi;
using Spartane.Core.Domain.estatus_mpi;
using Spartane.Web.Areas.WebApiConsumer.estatus_mpi;
using Spartane.Services.expediente_ministerio_publico;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Services.tipo_de_cierre;
using Spartane.Core.Domain.tipo_de_cierre;
using Spartane.Web.Areas.WebApiConsumer.tipo_de_cierre;
using Spartane.Services.Asignacion_de_Agente;
using Spartane.Core.Domain.Asignacion_de_Agente;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Agente;
using Spartane.Services.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Services.Diligencias_MP;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Web.Areas.WebApiConsumer.Diligencias_MP;
using Spartane.Services.Documentos_MP;
using Spartane.Core.Domain.Documentos_MP;
using Spartane.Web.Areas.WebApiConsumer.Documentos_MP;
using Spartane.Services.Indicios_MP;
using Spartane.Core.Domain.Indicios_MP;
using Spartane.Web.Areas.WebApiConsumer.Indicios_MP;
using Spartane.Services.IPH;
using Spartane.Core.Domain.IPH;
using Spartane.Web.Areas.WebApiConsumer.IPH;
using Spartane.Services.Servicios_de_Apoyo_MP;
using Spartane.Core.Domain.Servicios_de_Apoyo_MP;
using Spartane.Web.Areas.WebApiConsumer.Servicios_de_Apoyo_MP;
using Spartane.Services.Configuracion_de_Planeacion;
using Spartane.Core.Domain.Configuracion_de_Planeacion;
using Spartane.Web.Areas.WebApiConsumer.Configuracion_de_Planeacion;
using Spartane.Services.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Core.Domain.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Plan_Actos_de_Investigacion;
using Spartane.Services.Plan_de_Investigacion;
using Spartane.Core.Domain.Plan_de_Investigacion;
using Spartane.Web.Areas.WebApiConsumer.Plan_de_Investigacion;
using Spartane.Services.Tipo_de_Audiencia;
using Spartane.Core.Domain.Tipo_de_Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Audiencia;
using Spartane.Services.Audiencia;
using Spartane.Core.Domain.Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Audiencia;
using Spartane.Services.Resultado_de_Audiencia;
using Spartane.Core.Domain.Resultado_de_Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Audiencia;
using Spartane.Services.Audiencias_MP;
using Spartane.Core.Domain.Audiencias_MP;
using Spartane.Web.Areas.WebApiConsumer.Audiencias_MP;
using Spartane.Services.Detalle_Audiencia_Defensor_Imputado;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Imputado;
using Spartane.Services.Detalle_Audiencia_Defensor_Victima;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Victima;
using Spartane.Services.Detalle_Audiencia_Archivos_Adjuntos;
using Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Archivos_Adjuntos;
using Spartane.Services.Tipo_de_Asignacion_de_MP;
using Spartane.Core.Domain.Tipo_de_Asignacion_de_MP;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Asignacion_de_MP;
using Spartane.Services.Aparato_Electronicos_y_Multimedia;
using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using Spartane.Web.Areas.WebApiConsumer.Aparato_Electronicos_y_Multimedia;
using Spartane.Services.Calibre_de_Arma;
using Spartane.Core.Domain.Calibre_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Calibre_de_Arma;
using Spartane.Services.Clasificacion_de_Artefacto_y_Explosivo;
using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;
using Spartane.Web.Areas.WebApiConsumer.Clasificacion_de_Artefacto_y_Explosivo;
using Spartane.Services.Color_de_medio_de_trasporte;
using Spartane.Core.Domain.Color_de_medio_de_trasporte;
using Spartane.Web.Areas.WebApiConsumer.Color_de_medio_de_trasporte;
using Spartane.Services.Detencion;
using Spartane.Core.Domain.Detencion;
using Spartane.Web.Areas.WebApiConsumer.Detencion;
using Spartane.Services.Documentos_Multimedia;
using Spartane.Core.Domain.Documentos_Multimedia;
using Spartane.Web.Areas.WebApiConsumer.Documentos_Multimedia;
using Spartane.Services.Marca_de_Arma;
using Spartane.Core.Domain.Marca_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Arma;
using Spartane.Services.Marca_de_Equipo_de_Comunicacion;
using Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_de_Comunicacion;
using Spartane.Services.Marca_de_Equipo_Tactico;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_Tactico;
using Spartane.Services.Marca_de_Medio_de_transporte;
using Spartane.Core.Domain.Marca_de_Medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Medio_de_transporte;
using Spartane.Services.Metodo_de_Destruccion;
using Spartane.Core.Domain.Metodo_de_Destruccion;
using Spartane.Web.Areas.WebApiConsumer.Metodo_de_Destruccion;
using Spartane.Services.Modelo_de_equipo_tactico;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_equipo_tactico;
using Spartane.Services.Modelo_de_medio_de_transporte;
using Spartane.Core.Domain.Modelo_de_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_medio_de_transporte;
using Spartane.Services.Procedencia_del_medio_de_transporte;
using Spartane.Core.Domain.Procedencia_del_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_medio_de_transporte;
using Spartane.Services.Terreno_de_Inmuebles;
using Spartane.Core.Domain.Terreno_de_Inmuebles;
using Spartane.Web.Areas.WebApiConsumer.Terreno_de_Inmuebles;
using Spartane.Services.Tipo_Artefacto;
using Spartane.Core.Domain.Tipo_Artefacto;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Artefacto;
using Spartane.Services.Tipo_Clasificacion;
using Spartane.Core.Domain.Tipo_Clasificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Clasificacion;
using Spartane.Services.Tipo_de_Arma;
using Spartane.Core.Domain.Tipo_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Arma;
using Spartane.Services.Tipo_de_Dinero;
using Spartane.Core.Domain.Tipo_de_Dinero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Dinero;
using Spartane.Services.Tipo_de_Droga;
using Spartane.Core.Domain.Tipo_de_Droga;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Droga;
using Spartane.Services.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Services.Tipo_de_Equipo_Tactico;
using Spartane.Core.Domain.Tipo_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_Tactico;
using Spartane.Services.Tipo_de_Inmueble;
using Spartane.Core.Domain.Tipo_de_Inmueble;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inmueble;
using Spartane.Services.Tipo_de_medios_de_transporte;
using Spartane.Core.Domain.Tipo_de_medios_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_medios_de_transporte;
using Spartane.Services.Tipo_de_Moneda;
using Spartane.Core.Domain.Tipo_de_Moneda;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Moneda;
using Spartane.Services.Tipo_de_Orientacion;
using Spartane.Core.Domain.Tipo_de_Orientacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Orientacion;
using Spartane.Services.Tipo_de_Pirateria;
using Spartane.Core.Domain.Tipo_de_Pirateria;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Pirateria;
using Spartane.Services.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Services.Tipo_de_Plantio;
using Spartane.Core.Domain.Tipo_de_Plantio;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Plantio;
using Spartane.Services.Tipo_de_Suelo;
using Spartane.Core.Domain.Tipo_de_Suelo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Suelo;
using Spartane.Services.Tipo_de_Zona;
using Spartane.Core.Domain.Tipo_de_Zona;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Zona;
using Spartane.Services.Unidad_de_Medida_de_Equipo_Tactico;
using Spartane.Core.Domain.Unidad_de_Medida_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_Equipo_Tactico;
using Spartane.Services.Unidad_de_Medida_de_pirateria;
using Spartane.Core.Domain.Unidad_de_Medida_de_pirateria;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_pirateria;
using Spartane.Services.Unidad_de_medida_de_tipo_de_droga;
using Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_medida_de_tipo_de_droga;
using Spartane.Services.Uso_del_medio_de_transporte;
using Spartane.Core.Domain.Uso_del_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Uso_del_medio_de_transporte;
using Spartane.Services.Aseguramientos;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Web.Areas.WebApiConsumer.Aseguramientos;
using Spartane.Services.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Services.Detalle_Aseguramiento_Artefactos_y_Explosivos;
using Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Artefactos_y_Explosivos;
using Spartane.Services.Detalle_Aseguramiento_de_Cargador_Cartuchos;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Cargador_Cartuchos;
using Spartane.Services.Detalle_Aseguramiento_de_Drogas_Involucradas;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Drogas_Involucradas;
using Spartane.Services.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
using Spartane.Services.Detalle_Aseguramiento_de_Plantios;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Plantios;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Plantios;
using Spartane.Services.Detalle_Aseguramiento_Documentos;
using Spartane.Core.Domain.Detalle_Aseguramiento_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Documentos;
using Spartane.Services.Detalle_Aseguramiento_Electronicos_y_Multimedia;
using Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Electronicos_y_Multimedia;
using Spartane.Services.Detalle_Aseguramiento_Inmuebles;
using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Inmuebles;
using Spartane.Services.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Services.Detalle_Aseguramiento_Moneda;
using Spartane.Core.Domain.Detalle_Aseguramiento_Moneda;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Moneda;
using Spartane.Services.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Core.Domain.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Objetos_Asegurados;
using Spartane.Services.Detalle_Aseguramiento_Otros;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros;
using Spartane.Services.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Services.Detalle_Aseguramiento_Pirateria;
using Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Pirateria;
using Spartane.Services.Submarca_de_medio_de_transporte;
using Spartane.Core.Domain.Submarca_de_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Submarca_de_medio_de_transporte;
using Spartane.Services.Asignacion_de_Estatus_de_Agente;
using Spartane.Core.Domain.Asignacion_de_Estatus_de_Agente;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Estatus_de_Agente;
using Spartane.Services.Estatus_de_Agente_MP;
using Spartane.Core.Domain.Estatus_de_Agente_MP;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Agente_MP;
using Spartane.Services.Condiciones_en_Suspension_Condicional;
using Spartane.Core.Domain.Condiciones_en_Suspension_Condicional;
using Spartane.Web.Areas.WebApiConsumer.Condiciones_en_Suspension_Condicional;
using Spartane.Services.Generador_de_Turnos;
using Spartane.Core.Domain.Generador_de_Turnos;
using Spartane.Web.Areas.WebApiConsumer.Generador_de_Turnos;
using Spartane.Services.Auto_de_Vinculacion_a_Proceso;
using Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Auto_de_Vinculacion_a_Proceso;
using Spartane.Services.Resultado_de_Investigacion_Complementaria;
using Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Investigacion_Complementaria;
using Spartane.Services.Resolucion;
using Spartane.Core.Domain.Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;
using Spartane.Services.Plazo_de_Investigacion_Complementaria;
using Spartane.Core.Domain.Plazo_de_Investigacion_Complementaria;
using Spartane.Web.Areas.WebApiConsumer.Plazo_de_Investigacion_Complementaria;
using Spartane.Services.Especificacion_Detencion;
using Spartane.Core.Domain.Especificacion_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Especificacion_Detencion;
using Spartane.Services.Resultado_de_Audiencia_Intermedia;
using Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Audiencia_Intermedia;
using Spartane.Services.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Web.Areas.WebApiConsumer.Tribunal_de_Enjuiciamiento;
using Spartane.Services.Control_de_Detencion;
using Spartane.Core.Domain.Control_de_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Detencion;
using Spartane.Services.Audiencia_Inicial;
using Spartane.Core.Domain.Audiencia_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_Inicial;
using Spartane.Services.Continuacion_de_Proceso;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Continuacion_de_Proceso;
using Spartane.Services.Formulacion_de_Imputacion;
using Spartane.Core.Domain.Formulacion_de_Imputacion;
using Spartane.Web.Areas.WebApiConsumer.Formulacion_de_Imputacion;
using Spartane.Services.Plazo_Constitucional;
using Spartane.Core.Domain.Plazo_Constitucional;
using Spartane.Web.Areas.WebApiConsumer.Plazo_Constitucional;
using Spartane.Services.Vinculacion_a_Proceso;
using Spartane.Core.Domain.Vinculacion_a_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Vinculacion_a_Proceso;
using Spartane.Services.Detalle_Medios_Prueba_Victima;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Victima;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Victima;
using Spartane.Services.Proceso_Penal;
using Spartane.Core.Domain.Proceso_Penal;
using Spartane.Web.Areas.WebApiConsumer.Proceso_Penal;
using Spartane.Services.Detalle_Delitos_Proceso_Penal;
using Spartane.Core.Domain.Detalle_Delitos_Proceso_Penal;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Delitos_Proceso_Penal;
using Spartane.Services.Detalle_Medios_Prueba_Imputado;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Imputado;
using Spartane.Services.Detalle_Medidas_Cautelares_Proceso_Penal;
using Spartane.Core.Domain.Detalle_Medidas_Cautelares_Proceso_Penal;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medidas_Cautelares_Proceso_Penal;
using Spartane.Services.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Core.Domain.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Services.Detalle_Medios_Prueba_Admitidos;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Admitidos;
using Spartane.Services.Detalle_Condiciones_Proceso_Penal;
using Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Condiciones_Proceso_Penal;
//**@@INCLUDE_DECLARE@@**//
using Spartane.Services.Events;
using Spartane.Data.EF;
using System.Web.Http;
using System.Web;
using Autofac.Integration.WebApi;
using Spartane.Services.User.Mock;
using Spartane.Services.Security.Mock;
using Spartane.Core.Domain.Security;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.SpartanModule;
using Spartane.Web.Areas.WebApiConsumer.SpartanUserRoleModule;
using Spartane.Web.Areas.WebApiConsumer.SpartaneModuleObject;
using Spartane.Web.Areas.WebApiConsumer.SpartaneUserRoleModuleObject;
using Spartane.Services.TTArchivos;
using Spartane.Web.Areas.WebApiConsumer.SpartaneQuery;
/*Business Rules*/
using Spartane.Core.Domain.Spartan_BR_Action;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Action;
using Spartane.Core.Domain.Spartan_BR_Attribute_Restrictions_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Attribute_Restrictions_Detail;
using Spartane.Core.Domain.Spartan_BR_Action_Classification;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Action_Classification;
using Spartane.Core.Domain.Spartan_BR_Action_Configuration_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Action_Configuration_Detail;
using Spartane.Core.Domain.Spartan_BR_Event_Restrictions_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Event_Restrictions_Detail;
using Spartane.Core.Domain.Spartan_BR_Actions_False_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Actions_False_Detail;
using Spartane.Core.Domain.Spartan_BR_Operation_Restrictions_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Operation_Restrictions_Detail;
using Spartane.Core.Domain.Spartan_BR_Action_Param_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Action_Param_Type;
using Spartane.Core.Domain.Spartan_BR_Action_Result;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Action_Result;
using Spartane.Core.Domain.Spartan_BR_Actions_True_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Actions_True_Detail;
using Spartane.Core.Domain.Spartan_BR_Condition;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Condition;
using Spartane.Core.Domain.Spartan_BR_Condition_Operator;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Condition_Operator;
using Spartane.Core.Domain.Spartan_BR_Conditions_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Conditions_Detail;
using Spartane.Core.Domain.Spartan_BR_Operation;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Operation;
using Spartane.Core.Domain.Spartan_BR_Operation_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Operation_Detail;
using Spartane.Core.Domain.Spartan_BR_Operator_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Operator_Type;
using Spartane.Core.Domain.Spartan_BR_Presentation_Control_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Presentation_Control_Type;
using Spartane.Core.Domain.Spartan_BR_Process_Event;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Process_Event;
using Spartane.Core.Domain.Spartan_BR_Process_Event_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Process_Event_Detail;
using Spartane.Core.Domain.Spartan_BR_Scope;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Scope;
using Spartane.Core.Domain.Spartan_BR_Scope_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Scope_Detail;
using Spartane.Core.Domain.Spartan_BR_Status;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Status;
using Spartane.Core.Domain.Spartan_BR_Modifications_Log;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Modifications_Log;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Control_Type;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Type;
using Spartane.Services.Spartan_Attribute_Control_Type;
using Spartane.Services.Spartan_Attribute_Type;
using Spartane.Services.Spartan_Business_Rule;
using Spartane.Services.Spartan_BR_Action;
using Spartane.Services.Spartan_BR_Attribute_Restrictions_Detail;
using Spartane.Services.Spartan_BR_Action_Classification;
using Spartane.Services.Spartan_BR_Action_Configuration_Detail;
using Spartane.Services.Spartan_BR_Event_Restrictions_Detail;
using Spartane.Services.Spartan_BR_Actions_False_Detail;
using Spartane.Services.Spartan_BR_Operation_Restrictions_Detail;
using Spartane.Services.Spartan_BR_Action_Param_Type;
using Spartane.Services.Spartan_BR_Action_Result;
using Spartane.Services.Spartan_BR_Actions_True_Detail;
using Spartane.Services.Spartan_BR_Condition;
using Spartane.Services.Spartan_BR_Condition_Operator;
using Spartane.Services.Spartan_BR_Conditions_Detail;
using Spartane.Services.Spartan_BR_Operation;
using Spartane.Services.Spartan_BR_Operation_Detail;
using Spartane.Services.Spartan_BR_Operator_Type;
using Spartane.Services.Spartan_BR_Presentation_Control_Type;
using Spartane.Services.Spartan_BR_Process_Event;
using Spartane.Services.Spartan_BR_Process_Event_Detail;
using Spartane.Services.Spartan_BR_Scope;
using Spartane.Services.Spartan_BR_Scope_Detail;
using Spartane.Services.Spartan_BR_Status;
using Spartane.Services.Spartan_BR_Modifications_Log;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Bitacora_SQL;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Related;
using Spartane.Services.Business_Rule_Creation;
using Spartane.Web.Areas.WebApiConsumer.Business_Rule_Creation;
using Spartane.Services.Spartan_BR_Complexity;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Complexity;
using Spartane.Services.Spartan_BR_Peer_Review;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Peer_Review;
using Spartane.Services.Spartan_BR_Testing;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Testing;
using Spartane.Services.Spartan_BR_Rejection_Reason;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Rejection_Reason;
using Spartane.Services.Spartan_BR_History;
using Spartane.Services.Spartan_BR_Type_History;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_History;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Type_History;
using Spartane.Services.Spartan_Bitacora_SQL;

using Spartane.Services.Template_Dashboard_Editor;
using Spartane.Core.Domain.Template_Dashboard_Editor;
using Spartane.Web.Areas.WebApiConsumer.Template_Dashboard_Editor;
using Spartane.Services.Dashboard_Status;
using Spartane.Core.Domain.Dashboard_Status;
using Spartane.Web.Areas.WebApiConsumer.Dashboard_Status;
using Spartane.Services.Dashboard_Editor;
using Spartane.Core.Domain.Dashboard_Editor;
using Spartane.Web.Areas.WebApiConsumer.Dashboard_Editor;
using Spartane.Services.Template_Dashboard_Detail;
using Spartane.Core.Domain.Template_Dashboard_Detail;
using Spartane.Web.Areas.WebApiConsumer.Template_Dashboard_Detail;
using Spartane.Services.Dashboard_Config_Detail;
using Spartane.Core.Domain.Dashboard_Config_Detail;
using Spartane.Web.Areas.WebApiConsumer.Dashboard_Config_Detail;

namespace Spartane.Web
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //HTTP context and other related stuff
            builder.Register(c =>
                new HttpContextWrapper(HttpContext.Current) as HttpContextBase)
                .As<HttpContextBase>()
                .InstancePerLifetimeScope();
            
            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            // Register our Data dependencies
            builder.RegisterControllers();
           
            //data layer
            var dataSettigs = new DataSettings();
            dataSettigs.DataConnectionString = "name=spartaneEntities";//"data source=VM-SQL2012-01;initial catalog=spartane;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            dataSettigs.DataProvider = "sqlserver";
            builder.Register(x => new EFDataProviderManager(dataSettigs)).As<BaseDataProviderManager>().InstancePerLifetimeScope();
            builder.Register(x => x.Resolve<BaseDataProviderManager>().LoadDataProvider()).As<IDataProvider>().InstancePerLifetimeScope();
            builder.Register<IDbContext>(c => new TTObjectContext(dataSettigs.DataConnectionString)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(EFRepository<>)).As(typeof(IRepository<>));
            
            builder.RegisterType<PermissionService>().As<IPermissionService>().InstancePerLifetimeScope();
            builder.RegisterType<ModulesData>().As<BaseEntity>().InstancePerLifetimeScope();

            builder.RegisterType<Spartane.Core.Domain.User.GlobalData>();
            builder.RegisterType<DataLayerFieldsBitacora>();

            builder.RegisterType<Spartan_Module>();
            
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<MockSpartanUserService>().As<ISpartanUserService>().InstancePerLifetimeScope();
            

            //New Addons
            builder.RegisterType<AuthenticationApiConsumer>().As<IAuthenticationApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<TokenManager>().As<ITokenManager>().InstancePerLifetimeScope();
            builder.RegisterType<SpartaneFileApiConsumer>().As<ISpartaneFileApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartane_FileApiConsumer>().As<ISpartane_FileApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_FormatService>().As<ISpartan_FormatService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_FormatApiConsumer>().As<ISpartan_FormatApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_TypeService>().As<ISpartan_Format_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_TypeApiConsumer>().As<ISpartan_Format_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_MetadataService>().As<ISpartan_MetadataService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_MetadataApiConsumer>().As<ISpartan_MetadataApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_ConfigurationService>().As<ISpartan_Format_ConfigurationService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_ConfigurationApiConsumer>().As<ISpartan_Format_ConfigurationApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_FieldService>().As<ISpartan_Format_FieldService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_FieldApiConsumer>().As<ISpartan_Format_FieldApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_Permission_TypeService>().As<ISpartan_Format_Permission_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_Permission_TypeApiConsumer>().As<ISpartan_Format_Permission_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_PermissionsService>().As<ISpartan_Format_PermissionsService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Format_PermissionsApiConsumer>().As<ISpartan_Format_PermissionsApiConsumer>().InstancePerLifetimeScope();

builder.RegisterType<Spartan_ReportService>().As<ISpartan_ReportService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_ReportApiConsumer>().As<ISpartan_ReportApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Field_TypeService>().As<ISpartan_Report_Field_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Field_TypeApiConsumer>().As<ISpartan_Report_Field_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Fields_DetailService>().As<ISpartan_Report_Fields_DetailService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Fields_DetailApiConsumer>().As<ISpartan_Report_Fields_DetailApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_FormatService>().As<ISpartan_Report_FormatService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_FormatApiConsumer>().As<ISpartan_Report_FormatApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_FunctionService>().As<ISpartan_Report_FunctionService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_FunctionApiConsumer>().As<ISpartan_Report_FunctionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Order_TypeService>().As<ISpartan_Report_Order_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Order_TypeApiConsumer>().As<ISpartan_Report_Order_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Permission_TypeService>().As<ISpartan_Report_Permission_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Permission_TypeApiConsumer>().As<ISpartan_Report_Permission_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_PermissionsService>().As<ISpartan_Report_PermissionsService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_PermissionsApiConsumer>().As<ISpartan_Report_PermissionsApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Presentation_TypeService>().As<ISpartan_Report_Presentation_TypeService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Presentation_TypeApiConsumer>().As<ISpartan_Report_Presentation_TypeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Presentation_ViewService>().As<ISpartan_Report_Presentation_ViewService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Presentation_ViewApiConsumer>().As<ISpartan_Report_Presentation_ViewApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_StatusService>().As<ISpartan_Report_StatusService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_StatusApiConsumer>().As<ISpartan_Report_StatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_FilterApiConsumer>().As<ISpartan_Report_FilterApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Report_Advance_FilterApiConsumer>().As<ISpartan_Report_Advance_FilterApiConsumer>().InstancePerLifetimeScope();


builder.RegisterType<SpartanChangePasswordAutorizationEstatusService>().As<ISpartanChangePasswordAutorizationEstatusService>().InstancePerLifetimeScope();
builder.RegisterType<SpartanChangePasswordAutorizationEstatusApiConsumer>().As<ISpartanChangePasswordAutorizationEstatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_ChangePasswordAutorizationService>().As<ISpartan_ChangePasswordAutorizationService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_ChangePasswordAutorizationApiConsumer>().As<ISpartan_ChangePasswordAutorizationApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_User_Historical_PasswordService>().As<ISpartan_User_Historical_PasswordService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_User_Historical_PasswordApiConsumer>().As<ISpartan_User_Historical_PasswordApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_SettingsService>().As<ISpartan_SettingsService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_SettingsApiConsumer>().As<ISpartan_SettingsApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Business_Rule_CreationService>().As<IBusiness_Rule_CreationService>().InstancePerLifetimeScope();
builder.RegisterType<Business_Rule_CreationApiConsumer>().As<IBusiness_Rule_CreationApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_ComplexityService>().As<ISpartan_BR_ComplexityService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_ComplexityApiConsumer>().As<ISpartan_BR_ComplexityApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Peer_ReviewService>().As<ISpartan_BR_Peer_ReviewService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Peer_ReviewApiConsumer>().As<ISpartan_BR_Peer_ReviewApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Rejection_ReasonService>().As<ISpartan_BR_Rejection_ReasonService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Rejection_ReasonApiConsumer>().As<ISpartan_BR_Rejection_ReasonApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_TestingService>().As<ISpartan_BR_TestingService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_TestingApiConsumer>().As<ISpartan_BR_TestingApiConsumer>().InstancePerLifetimeScope();

builder.RegisterType<Spartan_BR_HistoryService>().As<ISpartan_BR_HistoryService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Type_HistoryService>().As<ISpartan_BR_Type_HistoryService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_HistoryApiConsumer>().As<ISpartan_BR_HistoryApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_BR_Type_HistoryApiConsumer>().As<ISpartan_BR_Type_HistoryApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Bitacora_SQLService>().As<ISpartan_Bitacora_SQLService>().InstancePerLifetimeScope();
builder.RegisterType<DialectoService>().As<IDialectoService>().InstancePerLifetimeScope();
builder.RegisterType<DialectoApiConsumer>().As<IDialectoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<BarbaService>().As<IBarbaService>().InstancePerLifetimeScope();
builder.RegisterType<BarbaApiConsumer>().As<IBarbaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<BocaService>().As<IBocaService>().InstancePerLifetimeScope();
builder.RegisterType<BocaApiConsumer>().As<IBocaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<PasaTurnosService>().As<IPasaTurnosService>().InstancePerLifetimeScope();
builder.RegisterType<PasaTurnosApiConsumer>().As<IPasaTurnosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<A_TiempoService>().As<IA_TiempoService>().InstancePerLifetimeScope();
builder.RegisterType<A_TiempoApiConsumer>().As<IA_TiempoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AbogadoService>().As<IAbogadoService>().InstancePerLifetimeScope();
builder.RegisterType<AbogadoApiConsumer>().As<IAbogadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Acta_de_Lectura_de_DerechosService>().As<IActa_de_Lectura_de_DerechosService>().InstancePerLifetimeScope();
builder.RegisterType<Acta_de_Lectura_de_DerechosApiConsumer>().As<IActa_de_Lectura_de_DerechosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AdiccionesService>().As<IAdiccionesService>().InstancePerLifetimeScope();
builder.RegisterType<AdiccionesApiConsumer>().As<IAdiccionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_de_InvolucradoService>().As<IAdicciones_de_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_de_InvolucradoApiConsumer>().As<IAdicciones_de_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_Probable_ResponsableService>().As<IAdicciones_Probable_ResponsableService>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_Probable_ResponsableApiConsumer>().As<IAdicciones_Probable_ResponsableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AgenciaService>().As<IAgenciaService>().InstancePerLifetimeScope();
builder.RegisterType<AgenciaApiConsumer>().As<IAgenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Agente_del_Ministerio_PublicoService>().As<IAgente_del_Ministerio_PublicoService>().InstancePerLifetimeScope();
builder.RegisterType<Agente_del_Ministerio_PublicoApiConsumer>().As<IAgente_del_Ministerio_PublicoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AgravantesService>().As<IAgravantesService>().InstancePerLifetimeScope();
builder.RegisterType<AgravantesApiConsumer>().As<IAgravantesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Agravantes_del_DelitoService>().As<IAgravantes_del_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Agravantes_del_DelitoApiConsumer>().As<IAgravantes_del_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AnteojosService>().As<IAnteojosService>().InstancePerLifetimeScope();
builder.RegisterType<AnteojosApiConsumer>().As<IAnteojosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ArticuloService>().As<IArticuloService>().InstancePerLifetimeScope();
builder.RegisterType<ArticuloApiConsumer>().As<IArticuloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Aseguradora_de_VehiculoService>().As<IAseguradora_de_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Aseguradora_de_VehiculoApiConsumer>().As<IAseguradora_de_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_TurnosService>().As<IAsignacion_de_TurnosService>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_TurnosApiConsumer>().As<IAsignacion_de_TurnosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_FundamentoService>().As<IAudiencia_de_Control_FundamentoService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_FundamentoApiConsumer>().As<IAudiencia_de_Control_FundamentoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_HechosService>().As<IAudiencia_de_Control_HechosService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_HechosApiConsumer>().As<IAudiencia_de_Control_HechosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_ProcedimientoService>().As<IAudiencia_de_Control_ProcedimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_ProcedimientoApiConsumer>().As<IAudiencia_de_Control_ProcedimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_ReiteracionService>().As<IAudiencia_de_Control_ReiteracionService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_ReiteracionApiConsumer>().As<IAudiencia_de_Control_ReiteracionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_SolicitudService>().As<IAudiencia_de_Control_SolicitudService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_de_Control_SolicitudApiConsumer>().As<IAudiencia_de_Control_SolicitudApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AutoridadService>().As<IAutoridadService>().InstancePerLifetimeScope();
builder.RegisterType<AutoridadApiConsumer>().As<IAutoridadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<SolicitudService>().As<ISolicitudService>().InstancePerLifetimeScope();
builder.RegisterType<SolicitudApiConsumer>().As<ISolicitudApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<BigoteService>().As<IBigoteService>().InstancePerLifetimeScope();
builder.RegisterType<BigoteApiConsumer>().As<IBigoteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<BinarioService>().As<IBinarioService>().InstancePerLifetimeScope();
builder.RegisterType<BinarioApiConsumer>().As<IBinarioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Bitacora_de_SincronizacionService>().As<IBitacora_de_SincronizacionService>().InstancePerLifetimeScope();
builder.RegisterType<Bitacora_de_SincronizacionApiConsumer>().As<IBitacora_de_SincronizacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Bitacora_de_UsuariosService>().As<IBitacora_de_UsuariosService>().InstancePerLifetimeScope();
builder.RegisterType<Bitacora_de_UsuariosApiConsumer>().As<IBitacora_de_UsuariosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Cadena_de_CustodiaService>().As<ICadena_de_CustodiaService>().InstancePerLifetimeScope();
builder.RegisterType<Cadena_de_CustodiaApiConsumer>().As<ICadena_de_CustodiaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CalendarioService>().As<ICalendarioService>().InstancePerLifetimeScope();
builder.RegisterType<CalendarioApiConsumer>().As<ICalendarioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Calendario_de_CitasService>().As<ICalendario_de_CitasService>().InstancePerLifetimeScope();
builder.RegisterType<Calendario_de_CitasApiConsumer>().As<ICalendario_de_CitasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Calidad_MigratoriaService>().As<ICalidad_MigratoriaService>().InstancePerLifetimeScope();
builder.RegisterType<Calidad_MigratoriaApiConsumer>().As<ICalidad_MigratoriaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CalvicieService>().As<ICalvicieService>().InstancePerLifetimeScope();
builder.RegisterType<CalvicieApiConsumer>().As<ICalvicieApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Cantidad_CabelloService>().As<ICantidad_CabelloService>().InstancePerLifetimeScope();
builder.RegisterType<Cantidad_CabelloApiConsumer>().As<ICantidad_CabelloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Carga_de_Documentos_Lectura_de_DerechosService>().As<ICarga_de_Documentos_Lectura_de_DerechosService>().InstancePerLifetimeScope();
builder.RegisterType<Carga_de_Documentos_Lectura_de_DerechosApiConsumer>().As<ICarga_de_Documentos_Lectura_de_DerechosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Carga_de_Documentos_de_LegislacionService>().As<ICarga_de_Documentos_de_LegislacionService>().InstancePerLifetimeScope();
builder.RegisterType<Carga_de_Documentos_de_LegislacionApiConsumer>().As<ICarga_de_Documentos_de_LegislacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Estatus_de_FolioService>().As<ICatalogo_de_Estatus_de_FolioService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Estatus_de_FolioApiConsumer>().As<ICatalogo_de_Estatus_de_FolioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Estatus_de_TrasladoService>().As<ICatalogo_de_Estatus_de_TrasladoService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Estatus_de_TrasladoApiConsumer>().As<ICatalogo_de_Estatus_de_TrasladoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Inicio_de_Cadena_de_CustodiaService>().As<ICatalogo_de_Inicio_de_Cadena_de_CustodiaService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer>().As<ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Movil_para_trasladoService>().As<ICatalogo_de_Movil_para_trasladoService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_Movil_para_trasladoApiConsumer>().As<ICatalogo_de_Movil_para_trasladoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_RecoleccionService>().As<ICatalogo_de_RecoleccionService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_de_RecoleccionApiConsumer>().As<ICatalogo_de_RecoleccionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_CCService>().As<ICatalogo_Estatus_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_CCApiConsumer>().As<ICatalogo_Estatus_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_de_ReplicacionService>().As<ICatalogo_Estatus_de_ReplicacionService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_de_ReplicacionApiConsumer>().As<ICatalogo_Estatus_de_ReplicacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_Detenido_MPIService>().As<ICatalogo_Estatus_Detenido_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Estatus_Detenido_MPIApiConsumer>().As<ICatalogo_Estatus_Detenido_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Motivo_de_Intervencion_CCService>().As<ICatalogo_Motivo_de_Intervencion_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Motivo_de_Intervencion_CCApiConsumer>().As<ICatalogo_Motivo_de_Intervencion_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Numero_de_PreguntasService>().As<ICatalogo_Numero_de_PreguntasService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Numero_de_PreguntasApiConsumer>().As<ICatalogo_Numero_de_PreguntasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_RespuestaService>().As<ICatalogo_RespuestaService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_RespuestaApiConsumer>().As<ICatalogo_RespuestaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Cargo_CCService>().As<ICatalogo_Tipo_de_Cargo_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Cargo_CCApiConsumer>().As<ICatalogo_Tipo_de_Cargo_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Embalaje_CCService>().As<ICatalogo_Tipo_de_Embalaje_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Embalaje_CCApiConsumer>().As<ICatalogo_Tipo_de_Embalaje_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Fijacion_CCService>().As<ICatalogo_Tipo_de_Fijacion_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Fijacion_CCApiConsumer>().As<ICatalogo_Tipo_de_Fijacion_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Indicio_CCService>().As<ICatalogo_Tipo_de_Indicio_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Tipo_de_Indicio_CCApiConsumer>().As<ICatalogo_Tipo_de_Indicio_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Unidad_Administrativa_CCService>().As<ICatalogo_Unidad_Administrativa_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Unidad_Administrativa_CCApiConsumer>().As<ICatalogo_Unidad_Administrativa_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Unidad_PolicialService>().As<ICatalogo_Unidad_PolicialService>().InstancePerLifetimeScope();
builder.RegisterType<Catalogo_Unidad_PolicialApiConsumer>().As<ICatalogo_Unidad_PolicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Causas_de_InterrupcionService>().As<ICausas_de_InterrupcionService>().InstancePerLifetimeScope();
builder.RegisterType<Causas_de_InterrupcionApiConsumer>().As<ICausas_de_InterrupcionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CejasService>().As<ICejasService>().InstancePerLifetimeScope();
builder.RegisterType<CejasApiConsumer>().As<ICejasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Certifica_DefuncionService>().As<ICertifica_DefuncionService>().InstancePerLifetimeScope();
builder.RegisterType<Certifica_DefuncionApiConsumer>().As<ICertifica_DefuncionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_DefuncionService>().As<ICircunstancia_DefuncionService>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_DefuncionApiConsumer>().As<ICircunstancia_DefuncionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_del_DelitoService>().As<ICircunstancia_del_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_del_DelitoApiConsumer>().As<ICircunstancia_del_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_VehiculoService>().As<ICircunstancia_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancia_VehiculoApiConsumer>().As<ICircunstancia_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CircunstanciasService>().As<ICircunstanciasService>().InstancePerLifetimeScope();
builder.RegisterType<CircunstanciasApiConsumer>().As<ICircunstanciasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancias_del_DelitoService>().As<ICircunstancias_del_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancias_del_DelitoApiConsumer>().As<ICircunstancias_del_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Especifica_VehiculoService>().As<IEspecifica_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Especifica_VehiculoApiConsumer>().As<IEspecifica_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Clasificacion_en_Orden_de_ResultadoService>().As<IClasificacion_en_Orden_de_ResultadoService>().InstancePerLifetimeScope();
builder.RegisterType<Clasificacion_en_Orden_de_ResultadoApiConsumer>().As<IClasificacion_en_Orden_de_ResultadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Codigo_PostalService>().As<ICodigo_PostalService>().InstancePerLifetimeScope();
builder.RegisterType<Codigo_PostalApiConsumer>().As<ICodigo_PostalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ColoniaService>().As<IColoniaService>().InstancePerLifetimeScope();
builder.RegisterType<ColoniaApiConsumer>().As<IColoniaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Color_de_CabelloService>().As<IColor_de_CabelloService>().InstancePerLifetimeScope();
builder.RegisterType<Color_de_CabelloApiConsumer>().As<IColor_de_CabelloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Color_OjosService>().As<IColor_OjosService>().InstancePerLifetimeScope();
builder.RegisterType<Color_OjosApiConsumer>().As<IColor_OjosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Color_PielService>().As<IColor_PielService>().InstancePerLifetimeScope();
builder.RegisterType<Color_PielApiConsumer>().As<IColor_PielApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Color_VehiculoService>().As<IColor_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Color_VehiculoApiConsumer>().As<IColor_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ComparecienteService>().As<IComparecienteService>().InstancePerLifetimeScope();
builder.RegisterType<ComparecienteApiConsumer>().As<IComparecienteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ComplexionService>().As<IComplexionService>().InstancePerLifetimeScope();
builder.RegisterType<ComplexionApiConsumer>().As<IComplexionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ConcursoService>().As<IConcursoService>().InstancePerLifetimeScope();
builder.RegisterType<ConcursoApiConsumer>().As<IConcursoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Consecuencia_DefuncionService>().As<IConsecuencia_DefuncionService>().InstancePerLifetimeScope();
builder.RegisterType<Consecuencia_DefuncionApiConsumer>().As<IConsecuencia_DefuncionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ContingenciaService>().As<IContingenciaService>().InstancePerLifetimeScope();
builder.RegisterType<ContingenciaApiConsumer>().As<IContingenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_Tiempos_JAService>().As<IControl_de_Tiempos_JAService>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_Tiempos_JAApiConsumer>().As<IControl_de_Tiempos_JAApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Registro_de_Tiempo_por_EstatusService>().As<IRegistro_de_Tiempo_por_EstatusService>().InstancePerLifetimeScope();
builder.RegisterType<Registro_de_Tiempo_por_EstatusApiConsumer>().As<IRegistro_de_Tiempo_por_EstatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ConvenioService>().As<IConvenioService>().InstancePerLifetimeScope();
builder.RegisterType<ConvenioApiConsumer>().As<IConvenioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CorporacionService>().As<ICorporacionService>().InstancePerLifetimeScope();
builder.RegisterType<CorporacionApiConsumer>().As<ICorporacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Correccion_de_Error_en_EstatusService>().As<ICorreccion_de_Error_en_EstatusService>().InstancePerLifetimeScope();
builder.RegisterType<Correccion_de_Error_en_EstatusApiConsumer>().As<ICorreccion_de_Error_en_EstatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<CumplimientoService>().As<ICumplimientoService>().InstancePerLifetimeScope();
builder.RegisterType<CumplimientoApiConsumer>().As<ICumplimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_InvolucradoService>().As<IDatos_Personales_Adicionales_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_InvolucradoApiConsumer>().As<IDatos_Personales_Adicionales_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Probable_ResponsableService>().As<IDatos_Personales_Adicionales_Probable_ResponsableService>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Probable_ResponsableApiConsumer>().As<IDatos_Personales_Adicionales_Probable_ResponsableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<DelegacionService>().As<IDelegacionService>().InstancePerLifetimeScope();
builder.RegisterType<DelegacionApiConsumer>().As<IDelegacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<DelitoService>().As<IDelitoService>().InstancePerLifetimeScope();
builder.RegisterType<DelitoApiConsumer>().As<IDelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Delito_Principal_MPIService>().As<IDelito_Principal_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Delito_Principal_MPIApiConsumer>().As<IDelito_Principal_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Delitos_Violencia_GeneroService>().As<IDelitos_Violencia_GeneroService>().InstancePerLifetimeScope();
builder.RegisterType<Delitos_Violencia_GeneroApiConsumer>().As<IDelitos_Violencia_GeneroApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Descarga_de_ArchivoService>().As<IDescarga_de_ArchivoService>().InstancePerLifetimeScope();
builder.RegisterType<Descarga_de_ArchivoApiConsumer>().As<IDescarga_de_ArchivoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Bitacora_de_Canalizacion_MPIService>().As<IDetalle_Bitacora_de_Canalizacion_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Bitacora_de_Canalizacion_MPIApiConsumer>().As<IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Datos_de_Delito_MPIService>().As<IDetalle_Datos_de_Delito_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Datos_de_Delito_MPIApiConsumer>().As<IDetalle_Datos_de_Delito_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_AbogadoService>().As<IDetalle_de_AbogadoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_AbogadoApiConsumer>().As<IDetalle_de_AbogadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Agente_del_Ministerio_PublicoService>().As<IDetalle_de_Agente_del_Ministerio_PublicoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Agente_del_Ministerio_PublicoApiConsumer>().As<IDetalle_de_Agente_del_Ministerio_PublicoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Asignacion_de_CitasService>().As<IDetalle_de_Asignacion_de_CitasService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Asignacion_de_CitasApiConsumer>().As<IDetalle_de_Asignacion_de_CitasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Asignacion_de_EspecialistaService>().As<IDetalle_de_Asignacion_de_EspecialistaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Asignacion_de_EspecialistaApiConsumer>().As<IDetalle_de_Asignacion_de_EspecialistaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Bitacora_de_CambiosService>().As<IDetalle_de_Bitacora_de_CambiosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Bitacora_de_CambiosApiConsumer>().As<IDetalle_de_Bitacora_de_CambiosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Canalizar_EstatusService>().As<IDetalle_de_Canalizar_EstatusService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Canalizar_EstatusApiConsumer>().As<IDetalle_de_Canalizar_EstatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Citatorio_AudienciasService>().As<IDetalle_de_Citatorio_AudienciasService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Citatorio_AudienciasApiConsumer>().As<IDetalle_de_Citatorio_AudienciasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_CoincidenciasService>().As<IDetalle_de_CoincidenciasService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_CoincidenciasApiConsumer>().As<IDetalle_de_CoincidenciasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_coincidencias_aService>().As<IDetalle_de_coincidencias_aService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_coincidencias_aApiConsumer>().As<IDetalle_de_coincidencias_aApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Coincidencias_MPIService>().As<IDetalle_de_Coincidencias_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Coincidencias_MPIApiConsumer>().As<IDetalle_de_Coincidencias_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_de_la_Victima_MPIService>().As<IDetalle_de_Datos_de_la_Victima_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_de_la_Victima_MPIApiConsumer>().As<IDetalle_de_Datos_de_la_Victima_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_de_TutorService>().As<IDetalle_de_Datos_de_TutorService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_de_TutorApiConsumer>().As<IDetalle_de_Datos_de_TutorApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Imputado_MPIService>().As<IDetalle_de_Datos_del_Imputado_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Imputado_MPIApiConsumer>().As<IDetalle_de_Datos_del_Imputado_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Imputado_CCService>().As<IDetalle_de_Datos_del_Imputado_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Imputado_CCApiConsumer>().As<IDetalle_de_Datos_del_Imputado_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Testigo_CCService>().As<IDetalle_de_Datos_del_Testigo_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Testigo_CCApiConsumer>().As<IDetalle_de_Datos_del_Testigo_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Testigo_MPIService>().As<IDetalle_de_Datos_del_Testigo_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_del_Testigo_MPIApiConsumer>().As<IDetalle_de_Datos_del_Testigo_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_GeneralesService>().As<IDetalle_de_Datos_GeneralesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Datos_GeneralesApiConsumer>().As<IDetalle_de_Datos_GeneralesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_DelitoService>().As<IDetalle_de_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_DelitoApiConsumer>().As<IDetalle_de_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Delito_de_JusticiaService>().As<IDetalle_de_Delito_de_JusticiaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Delito_de_JusticiaApiConsumer>().As<IDetalle_de_Delito_de_JusticiaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Descarga_de_ArchivoService>().As<IDetalle_de_Descarga_de_ArchivoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Descarga_de_ArchivoApiConsumer>().As<IDetalle_de_Descarga_de_ArchivoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Descripcion_de_Evidencia_CCService>().As<IDetalle_de_Descripcion_de_Evidencia_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Descripcion_de_Evidencia_CCApiConsumer>().As<IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_DesestimacionService>().As<IDetalle_de_DesestimacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_DesestimacionApiConsumer>().As<IDetalle_de_DesestimacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Devolucion_de_IndiciosService>().As<IDetalle_de_Devolucion_de_IndiciosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Devolucion_de_IndiciosApiConsumer>().As<IDetalle_de_Devolucion_de_IndiciosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documento_MPOService>().As<IDetalle_de_Documento_MPOService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documento_MPOApiConsumer>().As<IDetalle_de_Documento_MPOApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_documentosService>().As<IDetalle_de_documentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_documentosApiConsumer>().As<IDetalle_de_documentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_de_LegislacionService>().As<IDetalle_de_Documentos_de_LegislacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_de_LegislacionApiConsumer>().As<IDetalle_de_Documentos_de_LegislacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_de_MPOService>().As<IDetalle_de_Documentos_de_MPOService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_de_MPOApiConsumer>().As<IDetalle_de_Documentos_de_MPOApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_MPIService>().As<IDetalle_de_Documentos_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_MPIApiConsumer>().As<IDetalle_de_Documentos_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_MPOService>().As<IDetalle_de_Documentos_MPOService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Documentos_MPOApiConsumer>().As<IDetalle_de_Documentos_MPOApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Folio_Asignado_de_UsuarioService>().As<IDetalle_de_Folio_Asignado_de_UsuarioService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Folio_Asignado_de_UsuarioApiConsumer>().As<IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Folio_NUE_CCService>().As<IDetalle_de_Folio_NUE_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Folio_NUE_CCApiConsumer>().As<IDetalle_de_Folio_NUE_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Fotos_CCService>().As<IDetalle_de_Fotos_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Fotos_CCApiConsumer>().As<IDetalle_de_Fotos_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Fotos_de_Emergencia_CCService>().As<IDetalle_de_Fotos_de_Emergencia_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Fotos_de_Emergencia_CCApiConsumer>().As<IDetalle_de_Fotos_de_Emergencia_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_DetenidosService>().As<IDetalle_de_Galeria_de_DetenidosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_DetenidosApiConsumer>().As<IDetalle_de_Galeria_de_DetenidosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_IntervinientesService>().As<IDetalle_de_Galeria_de_IntervinientesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_IntervinientesApiConsumer>().As<IDetalle_de_Galeria_de_IntervinientesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_TestigosService>().As<IDetalle_de_Galeria_de_TestigosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Galeria_de_TestigosApiConsumer>().As<IDetalle_de_Galeria_de_TestigosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Hechos_Audiencia_InicialService>().As<IDetalle_de_Hechos_Audiencia_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Hechos_Audiencia_InicialApiConsumer>().As<IDetalle_de_Hechos_Audiencia_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Historial_de_Emergencia_CCService>().As<IDetalle_de_Historial_de_Emergencia_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Historial_de_Emergencia_CCApiConsumer>().As<IDetalle_de_Historial_de_Emergencia_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_ImputadoService>().As<IDetalle_de_ImputadoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_ImputadoApiConsumer>().As<IDetalle_de_ImputadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_IndiciosService>().As<IDetalle_de_IndiciosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_IndiciosApiConsumer>().As<IDetalle_de_IndiciosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_IPH_MPIService>().As<IDetalle_de_IPH_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_IPH_MPIApiConsumer>().As<IDetalle_de_IPH_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Lista_de_AsignacionesService>().As<IDetalle_de_Lista_de_AsignacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Lista_de_AsignacionesApiConsumer>().As<IDetalle_de_Lista_de_AsignacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Lista_de_Documentos_CCService>().As<IDetalle_de_Lista_de_Documentos_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Lista_de_Documentos_CCApiConsumer>().As<IDetalle_de_Lista_de_Documentos_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Mensaje_de_HistorialService>().As<IDetalle_de_Mensaje_de_HistorialService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Mensaje_de_HistorialApiConsumer>().As<IDetalle_de_Mensaje_de_HistorialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Oficio_de_Servicio_PericialService>().As<IDetalle_de_Oficio_de_Servicio_PericialService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Oficio_de_Servicio_PericialApiConsumer>().As<IDetalle_de_Oficio_de_Servicio_PericialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_MoralService>().As<IDetalle_de_Persona_MoralService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_MoralApiConsumer>().As<IDetalle_de_Persona_MoralApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_Moral_JAService>().As<IDetalle_de_Persona_Moral_JAService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_Moral_JAApiConsumer>().As<IDetalle_de_Persona_Moral_JAApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_Moral_MPIService>().As<IDetalle_de_Persona_Moral_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Persona_Moral_MPIApiConsumer>().As<IDetalle_de_Persona_Moral_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_ReferenciaService>().As<IDetalle_de_ReferenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_ReferenciaApiConsumer>().As<IDetalle_de_ReferenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Registro_de_Intervinientes_CCService>().As<IDetalle_de_Registro_de_Intervinientes_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Registro_de_Intervinientes_CCApiConsumer>().As<IDetalle_de_Registro_de_Intervinientes_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_RelacionesService>().As<IDetalle_de_RelacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_RelacionesApiConsumer>().As<IDetalle_de_RelacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_Audiencias_MPIService>().As<IDetalle_de_Requerido_en_Audiencias_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_Audiencias_MPIApiConsumer>().As<IDetalle_de_Requerido_en_Audiencias_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ComparecenciaService>().As<IDetalle_de_Requerido_en_ComparecenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ComparecenciaApiConsumer>().As<IDetalle_de_Requerido_en_ComparecenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ExamenService>().As<IDetalle_de_Requerido_en_ExamenService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ExamenApiConsumer>().As<IDetalle_de_Requerido_en_ExamenApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_InvitacionesService>().As<IDetalle_de_Requerido_en_InvitacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_InvitacionesApiConsumer>().As<IDetalle_de_Requerido_en_InvitacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ReunionesService>().As<IDetalle_de_Requerido_en_ReunionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requerido_en_ReunionesApiConsumer>().As<IDetalle_de_Requerido_en_ReunionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requeridos_FaltantesService>().As<IDetalle_de_Requeridos_FaltantesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Requeridos_FaltantesApiConsumer>().As<IDetalle_de_Requeridos_FaltantesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_RetroalimentacionService>().As<IDetalle_de_RetroalimentacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_RetroalimentacionApiConsumer>().As<IDetalle_de_RetroalimentacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Reuniones_de_MediacionService>().As<IDetalle_de_Reuniones_de_MediacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Reuniones_de_MediacionApiConsumer>().As<IDetalle_de_Reuniones_de_MediacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_SeguimientoService>().As<IDetalle_de_SeguimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_SeguimientoApiConsumer>().As<IDetalle_de_SeguimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Sentencias_Imputado_MPIService>().As<IDetalle_de_Sentencias_Imputado_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Sentencias_Imputado_MPIApiConsumer>().As<IDetalle_de_Sentencias_Imputado_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicio_de_ApoyoService>().As<IDetalle_de_Servicio_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicio_de_ApoyoApiConsumer>().As<IDetalle_de_Servicio_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicio_de_Apoyo_MPIService>().As<IDetalle_de_Servicio_de_Apoyo_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicio_de_Apoyo_MPIApiConsumer>().As<IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicios_PericialesService>().As<IDetalle_de_Servicios_PericialesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Servicios_PericialesApiConsumer>().As<IDetalle_de_Servicios_PericialesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_Audiencias_JAService>().As<IDetalle_de_Solicitante_en_Audiencias_JAService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_Audiencias_JAApiConsumer>().As<IDetalle_de_Solicitante_en_Audiencias_JAApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_Audiencias_MPIService>().As<IDetalle_de_Solicitante_en_Audiencias_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_Audiencias_MPIApiConsumer>().As<IDetalle_de_Solicitante_en_Audiencias_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ComparecenciaService>().As<IDetalle_de_Solicitante_en_ComparecenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ComparecenciaApiConsumer>().As<IDetalle_de_Solicitante_en_ComparecenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ExamenService>().As<IDetalle_de_Solicitante_en_ExamenService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ExamenApiConsumer>().As<IDetalle_de_Solicitante_en_ExamenApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_InvitacionesService>().As<IDetalle_de_Solicitante_en_InvitacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_InvitacionesApiConsumer>().As<IDetalle_de_Solicitante_en_InvitacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ReunionesService>().As<IDetalle_de_Solicitante_en_ReunionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_en_ReunionesApiConsumer>().As<IDetalle_de_Solicitante_en_ReunionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_Fundamentos_JAService>().As<IDetalle_de_Solicitante_Fundamentos_JAService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_Fundamentos_JAApiConsumer>().As<IDetalle_de_Solicitante_Fundamentos_JAApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_ProcedimientoService>().As<IDetalle_de_Solicitante_ProcedimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_ProcedimientoApiConsumer>().As<IDetalle_de_Solicitante_ProcedimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_Reiteracion_SaludService>().As<IDetalle_de_Solicitante_Reiteracion_SaludService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitante_Reiteracion_SaludApiConsumer>().As<IDetalle_de_Solicitante_Reiteracion_SaludApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Bitacora_de_CoincidService>().As<IDetalle_de_Solicitud_Bitacora_de_CoincidService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Bitacora_de_CoincidApiConsumer>().As<IDetalle_de_Solicitud_Bitacora_de_CoincidApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Datos_de_ApoyoService>().As<IDetalle_de_Solicitud_Datos_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Datos_de_ApoyoApiConsumer>().As<IDetalle_de_Solicitud_Datos_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_de_IndicioService>().As<IDetalle_de_Solicitud_de_IndicioService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_de_IndicioApiConsumer>().As<IDetalle_de_Solicitud_de_IndicioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Representante_LegalService>().As<IDetalle_de_Solicitud_Representante_LegalService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_Representante_LegalApiConsumer>().As<IDetalle_de_Solicitud_Representante_LegalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_RequeridoService>().As<IDetalle_de_Solicitud_RequeridoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_RequeridoApiConsumer>().As<IDetalle_de_Solicitud_RequeridoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_SeguimientoService>().As<IDetalle_de_Solicitud_SeguimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_SeguimientoApiConsumer>().As<IDetalle_de_Solicitud_SeguimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_SolicitanteService>().As<IDetalle_de_Solicitud_SolicitanteService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitud_SolicitanteApiConsumer>().As<IDetalle_de_Solicitud_SolicitanteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitudes_de_ComparecenciaService>().As<IDetalle_de_Solicitudes_de_ComparecenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitudes_de_ComparecenciaApiConsumer>().As<IDetalle_de_Solicitudes_de_ComparecenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitudes_de_InvitacionesService>().As<IDetalle_de_Solicitudes_de_InvitacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Solicitudes_de_InvitacionesApiConsumer>().As<IDetalle_de_Solicitudes_de_InvitacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Traslado_de_CCService>().As<IDetalle_de_Traslado_de_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Traslado_de_CCApiConsumer>().As<IDetalle_de_Traslado_de_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_TutorService>().As<IDetalle_de_TutorService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_TutorApiConsumer>().As<IDetalle_de_TutorApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Videos_CCService>().As<IDetalle_de_Videos_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Videos_CCApiConsumer>().As<IDetalle_de_Videos_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Abogado_Imputado_MPIService>().As<IDetalle_del_Abogado_Imputado_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Abogado_Imputado_MPIApiConsumer>().As<IDetalle_del_Abogado_Imputado_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Abogado_Victima_MPIService>().As<IDetalle_del_Abogado_Victima_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Abogado_Victima_MPIApiConsumer>().As<IDetalle_del_Abogado_Victima_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Certificado_CCService>().As<IDetalle_del_Certificado_CCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_Certificado_CCApiConsumer>().As<IDetalle_del_Certificado_CCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_IndicioService>().As<IDetalle_del_IndicioService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_del_IndicioApiConsumer>().As<IDetalle_del_IndicioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historico_JAService>().As<IDetalle_Historico_JAService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historico_JAApiConsumer>().As<IDetalle_Historico_JAApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historico_MPOService>().As<IDetalle_Historico_MPOService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historico_MPOApiConsumer>().As<IDetalle_Historico_MPOApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<DiligenciasService>().As<IDiligenciasService>().InstancePerLifetimeScope();
builder.RegisterType<DiligenciasApiConsumer>().As<IDiligenciasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Director_de_AgenciaService>().As<IDirector_de_AgenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Director_de_AgenciaApiConsumer>().As<IDirector_de_AgenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_FisicasService>().As<IDiscapacidades_FisicasService>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_FisicasApiConsumer>().As<IDiscapacidades_FisicasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_MentalesService>().As<IDiscapacidades_MentalesService>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_MentalesApiConsumer>().As<IDiscapacidades_MentalesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_PsicosocialesService>().As<IDiscapacidades_PsicosocialesService>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_PsicosocialesApiConsumer>().As<IDiscapacidades_PsicosocialesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_SensorialesService>().As<IDiscapacidades_SensorialesService>().InstancePerLifetimeScope();
builder.RegisterType<Discapacidades_SensorialesApiConsumer>().As<IDiscapacidades_SensorialesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Distrito_JudicialService>().As<IDistrito_JudicialService>().InstancePerLifetimeScope();
builder.RegisterType<Distrito_JudicialApiConsumer>().As<IDistrito_JudicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EncuestaService>().As<IEncuestaService>().InstancePerLifetimeScope();
builder.RegisterType<EncuestaApiConsumer>().As<IEncuestaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Elemento_RobadoService>().As<IElemento_RobadoService>().InstancePerLifetimeScope();
builder.RegisterType<Elemento_RobadoApiConsumer>().As<IElemento_RobadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Elementos_Comision_DelitoService>().As<IElementos_Comision_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Elementos_Comision_DelitoApiConsumer>().As<IElementos_Comision_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Encuesta1Service>().As<IEncuesta1Service>().InstancePerLifetimeScope();
builder.RegisterType<Encuesta1ApiConsumer>().As<IEncuesta1ApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Errores_de_ReplicacionService>().As<IErrores_de_ReplicacionService>().InstancePerLifetimeScope();
builder.RegisterType<Errores_de_ReplicacionApiConsumer>().As<IErrores_de_ReplicacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EscolaridadService>().As<IEscolaridadService>().InstancePerLifetimeScope();
builder.RegisterType<EscolaridadApiConsumer>().As<IEscolaridadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EspecialidadService>().As<IEspecialidadService>().InstancePerLifetimeScope();
builder.RegisterType<EspecialidadApiConsumer>().As<IEspecialidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Especialidad_MPService>().As<IEspecialidad_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Especialidad_MPApiConsumer>().As<IEspecialidad_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Especialista_de_Justicia_AlternativaService>().As<IEspecialista_de_Justicia_AlternativaService>().InstancePerLifetimeScope();
builder.RegisterType<Especialista_de_Justicia_AlternativaApiConsumer>().As<IEspecialista_de_Justicia_AlternativaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EstadoService>().As<IEstadoService>().InstancePerLifetimeScope();
builder.RegisterType<EstadoApiConsumer>().As<IEstadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estado_CivilService>().As<IEstado_CivilService>().InstancePerLifetimeScope();
builder.RegisterType<Estado_CivilApiConsumer>().As<IEstado_CivilApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estado_de_InvolucradoService>().As<IEstado_de_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Estado_de_InvolucradoApiConsumer>().As<IEstado_de_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EstatusService>().As<IEstatusService>().InstancePerLifetimeScope();
builder.RegisterType<EstatusApiConsumer>().As<IEstatusApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Actualizacion_de_DocumentoService>().As<IEstatus_de_Actualizacion_de_DocumentoService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Actualizacion_de_DocumentoApiConsumer>().As<IEstatus_de_Actualizacion_de_DocumentoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_AsignacionService>().As<IEstatus_de_AsignacionService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_AsignacionApiConsumer>().As<IEstatus_de_AsignacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Cita_InvitacionesService>().As<IEstatus_de_Cita_InvitacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Cita_InvitacionesApiConsumer>().As<IEstatus_de_Cita_InvitacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_Detalle_Documentos_LegislacionService>().As<IEstatus_Detalle_Documentos_LegislacionService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_Detalle_Documentos_LegislacionApiConsumer>().As<IEstatus_Detalle_Documentos_LegislacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_DocumentoService>().As<IEstatus_de_DocumentoService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_DocumentoApiConsumer>().As<IEstatus_de_DocumentoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_ExpedienteService>().As<IEstatus_de_ExpedienteService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_ExpedienteApiConsumer>().As<IEstatus_de_ExpedienteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Expediente_InicialService>().As<IEstatus_de_Expediente_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Expediente_InicialApiConsumer>().As<IEstatus_de_Expediente_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Expediente_para_ReunionesService>().As<IEstatus_de_Expediente_para_ReunionesService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Expediente_para_ReunionesApiConsumer>().As<IEstatus_de_Expediente_para_ReunionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_IndicioService>().As<IEstatus_de_IndicioService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_IndicioApiConsumer>().As<IEstatus_de_IndicioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_NotificacionService>().As<IEstatus_de_NotificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_NotificacionApiConsumer>().As<IEstatus_de_NotificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_TurnoService>().As<IEstatus_de_TurnoService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_TurnoApiConsumer>().As<IEstatus_de_TurnoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_del_DictamenService>().As<IEstatus_del_DictamenService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_del_DictamenApiConsumer>().As<IEstatus_del_DictamenApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_del_ImputadoService>().As<IEstatus_del_ImputadoService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_del_ImputadoApiConsumer>().As<IEstatus_del_ImputadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_OrientadorService>().As<IEstatus_OrientadorService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_OrientadorApiConsumer>().As<IEstatus_OrientadorApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_SolicitudService>().As<IEstatus_SolicitudService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_SolicitudApiConsumer>().As<IEstatus_SolicitudApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estudios_SuperioresService>().As<IEstudios_SuperioresService>().InstancePerLifetimeScope();
builder.RegisterType<Estudios_SuperioresApiConsumer>().As<IEstudios_SuperioresApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<EtniaService>().As<IEtniaService>().InstancePerLifetimeScope();
builder.RegisterType<EtniaApiConsumer>().As<IEtniaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Expediente_InicialService>().As<IExpediente_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Expediente_InicialApiConsumer>().As<IExpediente_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_Accion_DelitoService>().As<IForma_Accion_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_Accion_DelitoApiConsumer>().As<IForma_Accion_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_Comision_DelitoService>().As<IForma_Comision_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_Comision_DelitoApiConsumer>().As<IForma_Comision_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_CaraService>().As<IForma_CaraService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_CaraApiConsumer>().As<IForma_CaraApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_MentonService>().As<IForma_de_MentonService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_MentonApiConsumer>().As<IForma_de_MentonApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_NarizService>().As<IForma_de_NarizService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_NarizApiConsumer>().As<IForma_de_NarizApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Froma_OjosService>().As<IFroma_OjosService>().InstancePerLifetimeScope();
builder.RegisterType<Froma_OjosApiConsumer>().As<IFroma_OjosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_OrejasService>().As<IForma_OrejasService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_OrejasApiConsumer>().As<IForma_OrejasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_CabelloService>().As<IForma_CabelloService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_CabelloApiConsumer>().As<IForma_CabelloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_ControlService>().As<IFormato_de_ControlService>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_ControlApiConsumer>().As<IFormato_de_ControlApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_SeguimientoService>().As<IFormato_de_SeguimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_SeguimientoApiConsumer>().As<IFormato_de_SeguimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<FrenteService>().As<IFrenteService>().InstancePerLifetimeScope();
builder.RegisterType<FrenteApiConsumer>().As<IFrenteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Grosor_de_LabiosService>().As<IGrosor_de_LabiosService>().InstancePerLifetimeScope();
builder.RegisterType<Grosor_de_LabiosApiConsumer>().As<IGrosor_de_LabiosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_al_que_PerteneceService>().As<IGrupo_al_que_PerteneceService>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_al_que_PerteneceApiConsumer>().As<IGrupo_al_que_PerteneceApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_del_DelitoService>().As<IGrupo_del_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_del_DelitoApiConsumer>().As<IGrupo_del_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_VulnerableService>().As<IGrupo_VulnerableService>().InstancePerLifetimeScope();
builder.RegisterType<Grupo_VulnerableApiConsumer>().As<IGrupo_VulnerableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Historial_de_ConversacionService>().As<IHistorial_de_ConversacionService>().InstancePerLifetimeScope();
builder.RegisterType<Historial_de_ConversacionApiConsumer>().As<IHistorial_de_ConversacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<IdentificacionService>().As<IIdentificacionService>().InstancePerLifetimeScope();
builder.RegisterType<IdentificacionApiConsumer>().As<IIdentificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<IdiomaService>().As<IIdiomaService>().InstancePerLifetimeScope();
builder.RegisterType<IdiomaApiConsumer>().As<IIdiomaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Implantacion_CabelloService>().As<IImplantacion_CabelloService>().InstancePerLifetimeScope();
builder.RegisterType<Implantacion_CabelloApiConsumer>().As<IImplantacion_CabelloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<IndiciosService>().As<IIndiciosService>().InstancePerLifetimeScope();
builder.RegisterType<IndiciosApiConsumer>().As<IIndiciosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Indicios_para_MPIService>().As<IIndicios_para_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Indicios_para_MPIApiConsumer>().As<IIndicios_para_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<IndigenaService>().As<IIndigenaService>().InstancePerLifetimeScope();
builder.RegisterType<IndigenaApiConsumer>().As<IIndigenaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Juez_de_ControlService>().As<IJuez_de_ControlService>().InstancePerLifetimeScope();
builder.RegisterType<Juez_de_ControlApiConsumer>().As<IJuez_de_ControlApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<LabiosService>().As<ILabiosService>().InstancePerLifetimeScope();
builder.RegisterType<LabiosApiConsumer>().As<ILabiosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Largo_de_CabelloService>().As<ILargo_de_CabelloService>().InstancePerLifetimeScope();
builder.RegisterType<Largo_de_CabelloApiConsumer>().As<ILargo_de_CabelloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<LocalidadService>().As<ILocalidadService>().InstancePerLifetimeScope();
builder.RegisterType<LocalidadApiConsumer>().As<ILocalidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_de_DetencionService>().As<ILugar_de_DetencionService>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_de_DetencionApiConsumer>().As<ILugar_de_DetencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_del_RoboService>().As<ILugar_del_RoboService>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_del_RoboApiConsumer>().As<ILugar_del_RoboApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_TipoService>().As<ILugar_TipoService>().InstancePerLifetimeScope();
builder.RegisterType<Lugar_TipoApiConsumer>().As<ILugar_TipoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<LugaresService>().As<ILugaresService>().InstancePerLifetimeScope();
builder.RegisterType<LugaresApiConsumer>().As<ILugaresApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_InvolucradoService>().As<ILugares_Frecuentes_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_InvolucradoApiConsumer>().As<ILugares_Frecuentes_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Probable_ResponsableService>().As<ILugares_Frecuentes_Probable_ResponsableService>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Probable_ResponsableApiConsumer>().As<ILugares_Frecuentes_Probable_ResponsableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Marca_del_VehiculoService>().As<IMarca_del_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Marca_del_VehiculoApiConsumer>().As<IMarca_del_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Medidas_CautelaresService>().As<IMedidas_CautelaresService>().InstancePerLifetimeScope();
builder.RegisterType<Medidas_CautelaresApiConsumer>().As<IMedidas_CautelaresApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Medios_AlternativosService>().As<IMedios_AlternativosService>().InstancePerLifetimeScope();
builder.RegisterType<Medios_AlternativosApiConsumer>().As<IMedios_AlternativosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<MentonService>().As<IMentonService>().InstancePerLifetimeScope();
builder.RegisterType<MentonApiConsumer>().As<IMentonApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<MesesService>().As<IMesesService>().InstancePerLifetimeScope();
builder.RegisterType<MesesApiConsumer>().As<IMesesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Jefes_de_Usuarios_del_SistemaService>().As<IJefes_de_Usuarios_del_SistemaService>().InstancePerLifetimeScope();
builder.RegisterType<Jefes_de_Usuarios_del_SistemaApiConsumer>().As<IJefes_de_Usuarios_del_SistemaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modalidad_de_Robo_de_VehiculoService>().As<IModalidad_de_Robo_de_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Modalidad_de_Robo_de_VehiculoApiConsumer>().As<IModalidad_de_Robo_de_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modalidad_DelitoService>().As<IModalidad_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Modalidad_DelitoApiConsumer>().As<IModalidad_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ModuloService>().As<IModuloService>().InstancePerLifetimeScope();
builder.RegisterType<ModuloApiConsumer>().As<IModuloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modulo_de_Atencion_InicialService>().As<IModulo_de_Atencion_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Modulo_de_Atencion_InicialApiConsumer>().As<IModulo_de_Atencion_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_no_AcuerdoService>().As<IMotivo_de_no_AcuerdoService>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_no_AcuerdoApiConsumer>().As<IMotivo_de_no_AcuerdoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_No_CanalizacionService>().As<IMotivo_de_No_CanalizacionService>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_No_CanalizacionApiConsumer>().As<IMotivo_de_No_CanalizacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_VehiculoService>().As<IMotivo_de_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_VehiculoApiConsumer>().As<IMotivo_de_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_Finalizacion_TurnoService>().As<IMotivo_Finalizacion_TurnoService>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_Finalizacion_TurnoApiConsumer>().As<IMotivo_Finalizacion_TurnoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<MunicipioService>().As<IMunicipioService>().InstancePerLifetimeScope();
builder.RegisterType<MunicipioApiConsumer>().As<IMunicipioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<NacionalidadService>().As<INacionalidadService>().InstancePerLifetimeScope();
builder.RegisterType<NacionalidadApiConsumer>().As<INacionalidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Nariz_BaseService>().As<INariz_BaseService>().InstancePerLifetimeScope();
builder.RegisterType<Nariz_BaseApiConsumer>().As<INariz_BaseApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Nombre_ComparecenciaService>().As<INombre_ComparecenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Nombre_ComparecenciaApiConsumer>().As<INombre_ComparecenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<OcupacionService>().As<IOcupacionService>().InstancePerLifetimeScope();
builder.RegisterType<OcupacionApiConsumer>().As<IOcupacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<OjosService>().As<IOjosService>().InstancePerLifetimeScope();
builder.RegisterType<OjosApiConsumer>().As<IOjosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<OrientadorService>().As<IOrientadorService>().InstancePerLifetimeScope();
builder.RegisterType<OrientadorApiConsumer>().As<IOrientadorApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_InvolucradoService>().As<IOtras_Identificaciones_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_InvolucradoApiConsumer>().As<IOtras_Identificaciones_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Probable_ResponsableService>().As<IOtras_Identificaciones_Probable_ResponsableService>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Probable_ResponsableApiConsumer>().As<IOtras_Identificaciones_Probable_ResponsableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_InvolucradoService>().As<IOtros_Domicilios_InvolucradoService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_InvolucradoApiConsumer>().As<IOtros_Domicilios_InvolucradoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Probable_ResponsableService>().As<IOtros_Domicilios_Probable_ResponsableService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Probable_ResponsableApiConsumer>().As<IOtros_Domicilios_Probable_ResponsableApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_NombresService>().As<IOtros_NombresService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_NombresApiConsumer>().As<IOtros_NombresApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<PaisService>().As<IPaisService>().InstancePerLifetimeScope();
builder.RegisterType<PaisApiConsumer>().As<IPaisApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ParentescoService>().As<IParentescoService>().InstancePerLifetimeScope();
builder.RegisterType<ParentescoApiConsumer>().As<IParentescoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<PeriodicidadService>().As<IPeriodicidadService>().InstancePerLifetimeScope();
builder.RegisterType<PeriodicidadApiConsumer>().As<IPeriodicidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Prioridad_del_HechoService>().As<IPrioridad_del_HechoService>().InstancePerLifetimeScope();
builder.RegisterType<Prioridad_del_HechoApiConsumer>().As<IPrioridad_del_HechoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Procedencia_del_VehiculoService>().As<IProcedencia_del_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Procedencia_del_VehiculoApiConsumer>().As<IProcedencia_del_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Razon_deService>().As<IRazon_deService>().InstancePerLifetimeScope();
builder.RegisterType<Razon_deApiConsumer>().As<IRazon_deApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Razon_de_IncumplimientoService>().As<IRazon_de_IncumplimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Razon_de_IncumplimientoApiConsumer>().As<IRazon_de_IncumplimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<RecepcionistasService>().As<IRecepcionistasService>().InstancePerLifetimeScope();
builder.RegisterType<RecepcionistasApiConsumer>().As<IRecepcionistasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Redes_SocialesService>().As<IRedes_SocialesService>().InstancePerLifetimeScope();
builder.RegisterType<Redes_SocialesApiConsumer>().As<IRedes_SocialesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<RegionService>().As<IRegionService>().InstancePerLifetimeScope();
builder.RegisterType<RegionApiConsumer>().As<IRegionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modulo_Atencion_InicialService>().As<IModulo_Atencion_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Modulo_Atencion_InicialApiConsumer>().As<IModulo_Atencion_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Registro_de_CoincidenciasService>().As<IRegistro_de_CoincidenciasService>().InstancePerLifetimeScope();
builder.RegisterType<Registro_de_CoincidenciasApiConsumer>().As<IRegistro_de_CoincidenciasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<UsuarioService>().As<IUsuarioService>().InstancePerLifetimeScope();
builder.RegisterType<UsuarioApiConsumer>().As<IUsuarioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ReligionService>().As<IReligionService>().InstancePerLifetimeScope();
builder.RegisterType<ReligionApiConsumer>().As<IReligionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Reporte_PrincipalService>().As<IReporte_PrincipalService>().InstancePerLifetimeScope();
builder.RegisterType<Reporte_PrincipalApiConsumer>().As<IReporte_PrincipalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<RequeridoService>().As<IRequeridoService>().InstancePerLifetimeScope();
builder.RegisterType<RequeridoApiConsumer>().As<IRequeridoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Requerido_MPIService>().As<IRequerido_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Requerido_MPIApiConsumer>().As<IRequerido_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Requeridos_que_no_AsistenService>().As<IRequeridos_que_no_AsistenService>().InstancePerLifetimeScope();
builder.RegisterType<Requeridos_que_no_AsistenApiConsumer>().As<IRequeridos_que_no_AsistenApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<RespuestaService>().As<IRespuestaService>().InstancePerLifetimeScope();
builder.RegisterType<RespuestaApiConsumer>().As<IRespuestaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Rol_de_DiligenciaService>().As<IRol_de_DiligenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Rol_de_DiligenciaApiConsumer>().As<IRol_de_DiligenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<SentenciaService>().As<ISentenciaService>().InstancePerLifetimeScope();
builder.RegisterType<SentenciaApiConsumer>().As<ISentenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Senas_ParticularesService>().As<ISenas_ParticularesService>().InstancePerLifetimeScope();
builder.RegisterType<Senas_ParticularesApiConsumer>().As<ISenas_ParticularesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicio_del_VehiculoService>().As<IServicio_del_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Servicio_del_VehiculoApiConsumer>().As<IServicio_del_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicio_MedicoService>().As<IServicio_MedicoService>().InstancePerLifetimeScope();
builder.RegisterType<Servicio_MedicoApiConsumer>().As<IServicio_MedicoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_AlternativosService>().As<IServicios_AlternativosService>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_AlternativosApiConsumer>().As<IServicios_AlternativosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_de_ApoyoService>().As<IServicios_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_de_ApoyoApiConsumer>().As<IServicios_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_PericialesService>().As<IServicios_PericialesService>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_PericialesApiConsumer>().As<IServicios_PericialesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Agravantes_del_Delito_MASCService>().As<IAgravantes_del_Delito_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Agravantes_del_Delito_MASCApiConsumer>().As<IAgravantes_del_Delito_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancias_del_Delito_MASCService>().As<ICircunstancias_del_Delito_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Circunstancias_del_Delito_MASCApiConsumer>().As<ICircunstancias_del_Delito_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Requerido_MASCService>().As<IDatos_Personales_Adicionales_Requerido_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Requerido_MASCApiConsumer>().As<IDatos_Personales_Adicionales_Requerido_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Solicitante_MASCService>().As<IDatos_Personales_Adicionales_Solicitante_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Datos_Personales_Adicionales_Solicitante_MASCApiConsumer>().As<IDatos_Personales_Adicionales_Solicitante_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<GeneroService>().As<IGeneroService>().InstancePerLifetimeScope();
builder.RegisterType<GeneroApiConsumer>().As<IGeneroApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_IdentificacionService>().As<ITipo_de_IdentificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_IdentificacionApiConsumer>().As<ITipo_de_IdentificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<TurnosService>().As<ITurnosService>().InstancePerLifetimeScope();
builder.RegisterType<TurnosApiConsumer>().As<ITurnosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Situacion_FisicaService>().As<ISituacion_FisicaService>().InstancePerLifetimeScope();
builder.RegisterType<Situacion_FisicaApiConsumer>().As<ISituacion_FisicaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<SolicitanteService>().As<ISolicitanteService>().InstancePerLifetimeScope();
builder.RegisterType<SolicitanteApiConsumer>().As<ISolicitanteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Solicitante_MPIService>().As<ISolicitante_MPIService>().InstancePerLifetimeScope();
builder.RegisterType<Solicitante_MPIApiConsumer>().As<ISolicitante_MPIApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Solicitud_de_Servicios_de_ApoyoService>().As<ISolicitud_de_Servicios_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Solicitud_de_Servicios_de_ApoyoApiConsumer>().As<ISolicitud_de_Servicios_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Sub_Marca_del_VehiculoService>().As<ISub_Marca_del_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Sub_Marca_del_VehiculoApiConsumer>().As<ISub_Marca_del_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_de_CejasService>().As<ITamano_de_CejasService>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_de_CejasApiConsumer>().As<ITamano_de_CejasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_de_NarizService>().As<ITamano_de_NarizService>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_de_NarizApiConsumer>().As<ITamano_de_NarizApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_OrejasService>().As<ITamano_OrejasService>().InstancePerLifetimeScope();
builder.RegisterType<Tamano_OrejasApiConsumer>().As<ITamano_OrejasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_LobuloService>().As<ITipo_LobuloService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_LobuloApiConsumer>().As<ITipo_LobuloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AcuerdoService>().As<ITipo_de_AcuerdoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AcuerdoApiConsumer>().As<ITipo_de_AcuerdoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AtencionService>().As<ITipo_de_AtencionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AtencionApiConsumer>().As<ITipo_de_AtencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_CaraService>().As<ITipo_CaraService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_CaraApiConsumer>().As<ITipo_CaraApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_CarreteraService>().As<ITipo_de_CarreteraService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_CarreteraApiConsumer>().As<ITipo_de_CarreteraApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ComparecenciaService>().As<ITipo_de_ComparecenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ComparecenciaApiConsumer>().As<ITipo_de_ComparecenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ComparecienteService>().As<ITipo_de_ComparecienteService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ComparecienteApiConsumer>().As<ITipo_de_ComparecienteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DenunciaService>().As<ITipo_de_DenunciaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DenunciaApiConsumer>().As<ITipo_de_DenunciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Diligencia_MASCService>().As<ITipo_de_Diligencia_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Diligencia_MASCApiConsumer>().As<ITipo_de_Diligencia_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ExpedienteService>().As<ITipo_de_ExpedienteService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ExpedienteApiConsumer>().As<ITipo_de_ExpedienteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_FuncionService>().As<ITipo_de_FuncionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_FuncionApiConsumer>().As<ITipo_de_FuncionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InimputabilidadService>().As<ITipo_de_InimputabilidadService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InimputabilidadApiConsumer>().As<ITipo_de_InimputabilidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InstanciaService>().As<ITipo_de_InstanciaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InstanciaApiConsumer>().As<ITipo_de_InstanciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InvitacionService>().As<ITipo_de_InvitacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InvitacionApiConsumer>().As<ITipo_de_InvitacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Lugar_del_RoboService>().As<ITipo_de_Lugar_del_RoboService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Lugar_del_RoboApiConsumer>().As<ITipo_de_Lugar_del_RoboApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Mecanismo_AlternoService>().As<ITipo_de_Mecanismo_AlternoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Mecanismo_AlternoApiConsumer>().As<ITipo_de_Mecanismo_AlternoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_NotificacionService>().As<ITipo_de_NotificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_NotificacionApiConsumer>().As<ITipo_de_NotificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OficioService>().As<ITipo_de_OficioService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OficioApiConsumer>().As<ITipo_de_OficioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OficiosService>().As<ITipo_de_OficiosService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OficiosApiConsumer>().As<ITipo_de_OficiosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PersonaService>().As<ITipo_de_PersonaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PersonaApiConsumer>().As<ITipo_de_PersonaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_RoboService>().As<ITipo_de_RoboService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_RoboApiConsumer>().As<ITipo_de_RoboApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SeguimientoService>().As<ITipo_de_SeguimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SeguimientoApiConsumer>().As<ITipo_de_SeguimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Servicio_de_ApoyoService>().As<ITipo_de_Servicio_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Servicio_de_ApoyoApiConsumer>().As<ITipo_de_Servicio_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SesionService>().As<ITipo_de_SesionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SesionApiConsumer>().As<ITipo_de_SesionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_TramiteService>().As<ITipo_de_TramiteService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_TramiteApiConsumer>().As<ITipo_de_TramiteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_UrgenciaService>().As<ITipo_de_UrgenciaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_UrgenciaApiConsumer>().As<ITipo_de_UrgenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_VehiculoService>().As<ITipo_de_VehiculoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_VehiculoApiConsumer>().As<ITipo_de_VehiculoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_DelitoService>().As<ITipo_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_DelitoApiConsumer>().As<ITipo_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Titulo_del_DelitoService>().As<ITitulo_del_DelitoService>().InstancePerLifetimeScope();
builder.RegisterType<Titulo_del_DelitoApiConsumer>().As<ITitulo_del_DelitoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<TTFolioConsecutivoService>().As<ITTFolioConsecutivoService>().InstancePerLifetimeScope();
builder.RegisterType<TTFolioConsecutivoApiConsumer>().As<ITTFolioConsecutivoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<UnidadService>().As<IUnidadService>().InstancePerLifetimeScope();
builder.RegisterType<UnidadApiConsumer>().As<IUnidadApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<VigenciaService>().As<IVigenciaService>().InstancePerLifetimeScope();
builder.RegisterType<VigenciaApiConsumer>().As<IVigenciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Violencia_de_GeneroService>().As<IViolencia_de_GeneroService>().InstancePerLifetimeScope();
builder.RegisterType<Violencia_de_GeneroApiConsumer>().As<IViolencia_de_GeneroApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ZonaService>().As<IZonaService>().InstancePerLifetimeScope();
builder.RegisterType<ZonaApiConsumer>().As<IZonaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_CitasService>().As<IControl_de_CitasService>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_CitasApiConsumer>().As<IControl_de_CitasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_DocumentosService>().As<IControl_de_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_DocumentosApiConsumer>().As<IControl_de_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historial_Control_de_DocumentosService>().As<IDetalle_Historial_Control_de_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Historial_Control_de_DocumentosApiConsumer>().As<IDetalle_Historial_Control_de_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Origen_de_InvitacionService>().As<IOrigen_de_InvitacionService>().InstancePerLifetimeScope();
builder.RegisterType<Origen_de_InvitacionApiConsumer>().As<IOrigen_de_InvitacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Documento_ExtraviadoService>().As<IDocumento_ExtraviadoService>().InstancePerLifetimeScope();
builder.RegisterType<Documento_ExtraviadoApiConsumer>().As<IDocumento_ExtraviadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Object_ByPassService>().As<ISpartan_Object_ByPassService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Object_ByPassApiConsumer>().As<ISpartan_Object_ByPassApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Attribute_BypassService>().As<ISpartan_Attribute_BypassService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Attribute_BypassApiConsumer>().As<ISpartan_Attribute_BypassApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Record_Detail_ManagementService>().As<ISpartan_Record_Detail_ManagementService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_Record_Detail_ManagementApiConsumer>().As<ISpartan_Record_Detail_ManagementApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_RDM_Filters_DetailService>().As<ISpartan_RDM_Filters_DetailService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_RDM_Filters_DetailApiConsumer>().As<ISpartan_RDM_Filters_DetailApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_RDM_Operations_DetailService>().As<ISpartan_RDM_Operations_DetailService>().InstancePerLifetimeScope();
builder.RegisterType<Spartan_RDM_Operations_DetailApiConsumer>().As<ISpartan_RDM_Operations_DetailApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_de_Solicitante_MASCService>().As<IAdicciones_de_Solicitante_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_de_Solicitante_MASCApiConsumer>().As<IAdicciones_de_Solicitante_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_Requerido_MASCService>().As<IAdicciones_Requerido_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Adicciones_Requerido_MASCApiConsumer>().As<IAdicciones_Requerido_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Invitado_de_NotificacionService>().As<IDetalle_de_Invitado_de_NotificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_de_Invitado_de_NotificacionApiConsumer>().As<IDetalle_de_Invitado_de_NotificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Dilgencia_MASCService>().As<IDilgencia_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Dilgencia_MASCApiConsumer>().As<IDilgencia_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Diligencias_MASCService>().As<IDetalle_Diligencias_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Diligencias_MASCApiConsumer>().As<IDetalle_Diligencias_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Incidente_con_InvitacionService>().As<IIncidente_con_InvitacionService>().InstancePerLifetimeScope();
builder.RegisterType<Incidente_con_InvitacionApiConsumer>().As<IIncidente_con_InvitacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Requerido_MASCService>().As<ILugares_Frecuentes_Requerido_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Requerido_MASCApiConsumer>().As<ILugares_Frecuentes_Requerido_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Solicitante_MASCService>().As<ILugares_Frecuentes_Solicitante_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Lugares_Frecuentes_Solicitante_MASCApiConsumer>().As<ILugares_Frecuentes_Solicitante_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Requerido_MASCService>().As<IOtras_Identificaciones_Requerido_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Requerido_MASCApiConsumer>().As<IOtras_Identificaciones_Requerido_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Solicitante_MASCService>().As<IOtras_Identificaciones_Solicitante_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Otras_Identificaciones_Solicitante_MASCApiConsumer>().As<IOtras_Identificaciones_Solicitante_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Requeridos_MASCService>().As<IOtros_Domicilios_Requeridos_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Requeridos_MASCApiConsumer>().As<IOtros_Domicilios_Requeridos_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Solicitante_MASCService>().As<IOtros_Domicilios_Solicitante_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Domicilios_Solicitante_MASCApiConsumer>().As<IOtros_Domicilios_Solicitante_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Nombres_Requerido_MASCService>().As<IOtros_Nombres_Requerido_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Otros_Nombres_Requerido_MASCApiConsumer>().As<IOtros_Nombres_Requerido_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Recepcion_de_Pago_MASCService>().As<IRecepcion_de_Pago_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Recepcion_de_Pago_MASCApiConsumer>().As<IRecepcion_de_Pago_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_NotificacionService>().As<IResultado_de_NotificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_NotificacionApiConsumer>().As<IResultado_de_NotificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Solicitud_de_NotificacionService>().As<ISolicitud_de_NotificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Solicitud_de_NotificacionApiConsumer>().As<ISolicitud_de_NotificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Relacion_Unidad_UsuarioService>().As<IRelacion_Unidad_UsuarioService>().InstancePerLifetimeScope();
builder.RegisterType<Relacion_Unidad_UsuarioApiConsumer>().As<IRelacion_Unidad_UsuarioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_RevisionService>().As<IResultado_de_RevisionService>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_RevisionApiConsumer>().As<IResultado_de_RevisionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Acuerdos_MASCService>().As<IAcuerdos_MASCService>().InstancePerLifetimeScope();
builder.RegisterType<Acuerdos_MASCApiConsumer>().As<IAcuerdos_MASCApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Requerido_AcuerdoService>().As<IDetalle_Requerido_AcuerdoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Requerido_AcuerdoApiConsumer>().As<IDetalle_Requerido_AcuerdoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Solicitante_AcuerdoService>().As<IDetalle_Solicitante_AcuerdoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Solicitante_AcuerdoApiConsumer>().As<IDetalle_Solicitante_AcuerdoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Conclusion_AnticipadaService>().As<ITipo_de_Conclusion_AnticipadaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Conclusion_AnticipadaApiConsumer>().As<ITipo_de_Conclusion_AnticipadaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Documentos_SolicitantesService>().As<IDetalle_Documentos_SolicitantesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Documentos_SolicitantesApiConsumer>().As<IDetalle_Documentos_SolicitantesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Documentos_RequeridosService>().As<IDetalle_Documentos_RequeridosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Documentos_RequeridosApiConsumer>().As<IDetalle_Documentos_RequeridosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_DenunciaService>().As<IFormato_de_DenunciaService>().InstancePerLifetimeScope();
builder.RegisterType<Formato_de_DenunciaApiConsumer>().As<IFormato_de_DenunciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_AtenciònService>().As<IUnidad_de_AtenciònService>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_AtenciònApiConsumer>().As<IUnidad_de_AtenciònApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_AtencionService>().As<IUnidad_de_AtencionService>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_AtencionApiConsumer>().As<IUnidad_de_AtencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DocumentoService>().As<ITipo_de_DocumentoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DocumentoApiConsumer>().As<ITipo_de_DocumentoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<DocumentoService>().As<IDocumentoService>().InstancePerLifetimeScope();
builder.RegisterType<DocumentoApiConsumer>().As<IDocumentoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Involucrados_en_DocumentosService>().As<IDetalle_Involucrados_en_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Involucrados_en_DocumentosApiConsumer>().As<IDetalle_Involucrados_en_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Probable_Responsable_de_DocumentosService>().As<IDetalle_Probable_Responsable_de_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Probable_Responsable_de_DocumentosApiConsumer>().As<IDetalle_Probable_Responsable_de_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Delitos_de_DocumentosService>().As<IDetalle_Delitos_de_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Delitos_de_DocumentosApiConsumer>().As<IDetalle_Delitos_de_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_Rechazo_de_SolicitudService>().As<IMotivo_de_Rechazo_de_SolicitudService>().InstancePerLifetimeScope();
builder.RegisterType<Motivo_de_Rechazo_de_SolicitudApiConsumer>().As<IMotivo_de_Rechazo_de_SolicitudApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Solicitud_Historial_de_AsignacionesService>().As<IDetalle_Solicitud_Historial_de_AsignacionesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Solicitud_Historial_de_AsignacionesApiConsumer>().As<IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_CumplimientoService>().As<IForma_de_CumplimientoService>().InstancePerLifetimeScope();
builder.RegisterType<Forma_de_CumplimientoApiConsumer>().As<IForma_de_CumplimientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_CrimenService>().As<ITipo_de_CrimenService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_CrimenApiConsumer>().As<ITipo_de_CrimenApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<detalle_de_observaciones_mpiService>().As<Idetalle_de_observaciones_mpiService>().InstancePerLifetimeScope();
builder.RegisterType<detalle_de_observaciones_mpiApiConsumer>().As<Idetalle_de_observaciones_mpiApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<estatus_mpiService>().As<Iestatus_mpiService>().InstancePerLifetimeScope();
builder.RegisterType<estatus_mpiApiConsumer>().As<Iestatus_mpiApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<expediente_ministerio_publicoService>().As<Iexpediente_ministerio_publicoService>().InstancePerLifetimeScope();
builder.RegisterType<expediente_ministerio_publicoApiConsumer>().As<Iexpediente_ministerio_publicoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<tipo_de_cierreService>().As<Itipo_de_cierreService>().InstancePerLifetimeScope();
builder.RegisterType<tipo_de_cierreApiConsumer>().As<Itipo_de_cierreApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_AgenteService>().As<IAsignacion_de_AgenteService>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_AgenteApiConsumer>().As<IAsignacion_de_AgenteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Categoria_de_Servicio_de_ApoyoService>().As<ICategoria_de_Servicio_de_ApoyoService>().InstancePerLifetimeScope();
builder.RegisterType<Categoria_de_Servicio_de_ApoyoApiConsumer>().As<ICategoria_de_Servicio_de_ApoyoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Diligencias_MPService>().As<IDiligencias_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Diligencias_MPApiConsumer>().As<IDiligencias_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Documentos_MPService>().As<IDocumentos_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Documentos_MPApiConsumer>().As<IDocumentos_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Indicios_MPService>().As<IIndicios_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Indicios_MPApiConsumer>().As<IIndicios_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<IPHService>().As<IIPHService>().InstancePerLifetimeScope();
builder.RegisterType<IPHApiConsumer>().As<IIPHApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_de_Apoyo_MPService>().As<IServicios_de_Apoyo_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Servicios_de_Apoyo_MPApiConsumer>().As<IServicios_de_Apoyo_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Configuracion_de_PlaneacionService>().As<IConfiguracion_de_PlaneacionService>().InstancePerLifetimeScope();
builder.RegisterType<Configuracion_de_PlaneacionApiConsumer>().As<IConfiguracion_de_PlaneacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Plan_Actos_de_InvestigacionService>().As<IDetalle_Plan_Actos_de_InvestigacionService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Plan_Actos_de_InvestigacionApiConsumer>().As<IDetalle_Plan_Actos_de_InvestigacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Plan_de_InvestigacionService>().As<IPlan_de_InvestigacionService>().InstancePerLifetimeScope();
builder.RegisterType<Plan_de_InvestigacionApiConsumer>().As<IPlan_de_InvestigacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AudienciaService>().As<ITipo_de_AudienciaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_AudienciaApiConsumer>().As<ITipo_de_AudienciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AudienciaService>().As<IAudienciaService>().InstancePerLifetimeScope();
builder.RegisterType<AudienciaApiConsumer>().As<IAudienciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_AudienciaService>().As<IResultado_de_AudienciaService>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_AudienciaApiConsumer>().As<IResultado_de_AudienciaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencias_MPService>().As<IAudiencias_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencias_MPApiConsumer>().As<IAudiencias_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Defensor_ImputadoService>().As<IDetalle_Audiencia_Defensor_ImputadoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Defensor_ImputadoApiConsumer>().As<IDetalle_Audiencia_Defensor_ImputadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Defensor_VictimaService>().As<IDetalle_Audiencia_Defensor_VictimaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Defensor_VictimaApiConsumer>().As<IDetalle_Audiencia_Defensor_VictimaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Archivos_AdjuntosService>().As<IDetalle_Audiencia_Archivos_AdjuntosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Audiencia_Archivos_AdjuntosApiConsumer>().As<IDetalle_Audiencia_Archivos_AdjuntosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Asignacion_de_MPService>().As<ITipo_de_Asignacion_de_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Asignacion_de_MPApiConsumer>().As<ITipo_de_Asignacion_de_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Aparato_Electronicos_y_MultimediaService>().As<IAparato_Electronicos_y_MultimediaService>().InstancePerLifetimeScope();
builder.RegisterType<Aparato_Electronicos_y_MultimediaApiConsumer>().As<IAparato_Electronicos_y_MultimediaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Calibre_de_ArmaService>().As<ICalibre_de_ArmaService>().InstancePerLifetimeScope();
builder.RegisterType<Calibre_de_ArmaApiConsumer>().As<ICalibre_de_ArmaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Clasificacion_de_Artefacto_y_ExplosivoService>().As<IClasificacion_de_Artefacto_y_ExplosivoService>().InstancePerLifetimeScope();
builder.RegisterType<Clasificacion_de_Artefacto_y_ExplosivoApiConsumer>().As<IClasificacion_de_Artefacto_y_ExplosivoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Color_de_medio_de_trasporteService>().As<IColor_de_medio_de_trasporteService>().InstancePerLifetimeScope();
builder.RegisterType<Color_de_medio_de_trasporteApiConsumer>().As<IColor_de_medio_de_trasporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<DetencionService>().As<IDetencionService>().InstancePerLifetimeScope();
builder.RegisterType<DetencionApiConsumer>().As<IDetencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Documentos_MultimediaService>().As<IDocumentos_MultimediaService>().InstancePerLifetimeScope();
builder.RegisterType<Documentos_MultimediaApiConsumer>().As<IDocumentos_MultimediaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_ArmaService>().As<IMarca_de_ArmaService>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_ArmaApiConsumer>().As<IMarca_de_ArmaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Equipo_de_ComunicacionService>().As<IMarca_de_Equipo_de_ComunicacionService>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Equipo_de_ComunicacionApiConsumer>().As<IMarca_de_Equipo_de_ComunicacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Equipo_TacticoService>().As<IMarca_de_Equipo_TacticoService>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Equipo_TacticoApiConsumer>().As<IMarca_de_Equipo_TacticoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Medio_de_transporteService>().As<IMarca_de_Medio_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Marca_de_Medio_de_transporteApiConsumer>().As<IMarca_de_Medio_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Metodo_de_DestruccionService>().As<IMetodo_de_DestruccionService>().InstancePerLifetimeScope();
builder.RegisterType<Metodo_de_DestruccionApiConsumer>().As<IMetodo_de_DestruccionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modelo_de_equipo_tacticoService>().As<IModelo_de_equipo_tacticoService>().InstancePerLifetimeScope();
builder.RegisterType<Modelo_de_equipo_tacticoApiConsumer>().As<IModelo_de_equipo_tacticoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Modelo_de_medio_de_transporteService>().As<IModelo_de_medio_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Modelo_de_medio_de_transporteApiConsumer>().As<IModelo_de_medio_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Procedencia_del_medio_de_transporteService>().As<IProcedencia_del_medio_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Procedencia_del_medio_de_transporteApiConsumer>().As<IProcedencia_del_medio_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Terreno_de_InmueblesService>().As<ITerreno_de_InmueblesService>().InstancePerLifetimeScope();
builder.RegisterType<Terreno_de_InmueblesApiConsumer>().As<ITerreno_de_InmueblesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_ArtefactoService>().As<ITipo_ArtefactoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_ArtefactoApiConsumer>().As<ITipo_ArtefactoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_ClasificacionService>().As<ITipo_ClasificacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_ClasificacionApiConsumer>().As<ITipo_ClasificacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ArmaService>().As<ITipo_de_ArmaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ArmaApiConsumer>().As<ITipo_de_ArmaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DineroService>().As<ITipo_de_DineroService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DineroApiConsumer>().As<ITipo_de_DineroApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DrogaService>().As<ITipo_de_DrogaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_DrogaApiConsumer>().As<ITipo_de_DrogaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Equipo_de_ComunicacionService>().As<ITipo_de_Equipo_de_ComunicacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Equipo_de_ComunicacionApiConsumer>().As<ITipo_de_Equipo_de_ComunicacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Equipo_TacticoService>().As<ITipo_de_Equipo_TacticoService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Equipo_TacticoApiConsumer>().As<ITipo_de_Equipo_TacticoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InmuebleService>().As<ITipo_de_InmuebleService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_InmuebleApiConsumer>().As<ITipo_de_InmuebleApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_medios_de_transporteService>().As<ITipo_de_medios_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_medios_de_transporteApiConsumer>().As<ITipo_de_medios_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_MonedaService>().As<ITipo_de_MonedaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_MonedaApiConsumer>().As<ITipo_de_MonedaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OrientacionService>().As<ITipo_de_OrientacionService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_OrientacionApiConsumer>().As<ITipo_de_OrientacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PirateriaService>().As<ITipo_de_PirateriaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PirateriaApiConsumer>().As<ITipo_de_PirateriaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Pista_de_AterrizajeService>().As<ITipo_de_Pista_de_AterrizajeService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_Pista_de_AterrizajeApiConsumer>().As<ITipo_de_Pista_de_AterrizajeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PlantioService>().As<ITipo_de_PlantioService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_PlantioApiConsumer>().As<ITipo_de_PlantioApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SueloService>().As<ITipo_de_SueloService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_SueloApiConsumer>().As<ITipo_de_SueloApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ZonaService>().As<ITipo_de_ZonaService>().InstancePerLifetimeScope();
builder.RegisterType<Tipo_de_ZonaApiConsumer>().As<ITipo_de_ZonaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_Medida_de_Equipo_TacticoService>().As<IUnidad_de_Medida_de_Equipo_TacticoService>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_Medida_de_Equipo_TacticoApiConsumer>().As<IUnidad_de_Medida_de_Equipo_TacticoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_Medida_de_pirateriaService>().As<IUnidad_de_Medida_de_pirateriaService>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_Medida_de_pirateriaApiConsumer>().As<IUnidad_de_Medida_de_pirateriaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_medida_de_tipo_de_drogaService>().As<IUnidad_de_medida_de_tipo_de_drogaService>().InstancePerLifetimeScope();
builder.RegisterType<Unidad_de_medida_de_tipo_de_drogaApiConsumer>().As<IUnidad_de_medida_de_tipo_de_drogaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Uso_del_medio_de_transporteService>().As<IUso_del_medio_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Uso_del_medio_de_transporteApiConsumer>().As<IUso_del_medio_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<AseguramientosService>().As<IAseguramientosService>().InstancePerLifetimeScope();
builder.RegisterType<AseguramientosApiConsumer>().As<IAseguramientosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Armas_InvolucradasService>().As<IDetalle_Aseguramiento_Armas_InvolucradasService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Armas_InvolucradasApiConsumer>().As<IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Artefactos_y_ExplosivosService>().As<IDetalle_Aseguramiento_Artefactos_y_ExplosivosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer>().As<IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Cargador_CartuchosService>().As<IDetalle_Aseguramiento_de_Cargador_CartuchosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Cargador_CartuchosApiConsumer>().As<IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Drogas_InvolucradasService>().As<IDetalle_Aseguramiento_de_Drogas_InvolucradasService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer>().As<IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Pistas_de_AterrizajeService>().As<IDetalle_Aseguramiento_de_Pistas_de_AterrizajeService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer>().As<IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_PlantiosService>().As<IDetalle_Aseguramiento_de_PlantiosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_de_PlantiosApiConsumer>().As<IDetalle_Aseguramiento_de_PlantiosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_DocumentosService>().As<IDetalle_Aseguramiento_DocumentosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_DocumentosApiConsumer>().As<IDetalle_Aseguramiento_DocumentosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Electronicos_y_MultimediaService>().As<IDetalle_Aseguramiento_Electronicos_y_MultimediaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer>().As<IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_InmueblesService>().As<IDetalle_Aseguramiento_InmueblesService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_InmueblesApiConsumer>().As<IDetalle_Aseguramiento_InmueblesApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Medios_de_TransporteService>().As<IDetalle_Aseguramiento_Medios_de_TransporteService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Medios_de_TransporteApiConsumer>().As<IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_MonedaService>().As<IDetalle_Aseguramiento_MonedaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_MonedaApiConsumer>().As<IDetalle_Aseguramiento_MonedaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Objetos_AseguradosService>().As<IDetalle_Aseguramiento_Objetos_AseguradosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Objetos_AseguradosApiConsumer>().As<IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_OtrosService>().As<IDetalle_Aseguramiento_OtrosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_OtrosApiConsumer>().As<IDetalle_Aseguramiento_OtrosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Otros_AseguramientosService>().As<IDetalle_Aseguramiento_Otros_AseguramientosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_Otros_AseguramientosApiConsumer>().As<IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_PirateriaService>().As<IDetalle_Aseguramiento_PirateriaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Aseguramiento_PirateriaApiConsumer>().As<IDetalle_Aseguramiento_PirateriaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Submarca_de_medio_de_transporteService>().As<ISubmarca_de_medio_de_transporteService>().InstancePerLifetimeScope();
builder.RegisterType<Submarca_de_medio_de_transporteApiConsumer>().As<ISubmarca_de_medio_de_transporteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_Estatus_de_AgenteService>().As<IAsignacion_de_Estatus_de_AgenteService>().InstancePerLifetimeScope();
builder.RegisterType<Asignacion_de_Estatus_de_AgenteApiConsumer>().As<IAsignacion_de_Estatus_de_AgenteApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Agente_MPService>().As<IEstatus_de_Agente_MPService>().InstancePerLifetimeScope();
builder.RegisterType<Estatus_de_Agente_MPApiConsumer>().As<IEstatus_de_Agente_MPApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Condiciones_en_Suspension_CondicionalService>().As<ICondiciones_en_Suspension_CondicionalService>().InstancePerLifetimeScope();
builder.RegisterType<Condiciones_en_Suspension_CondicionalApiConsumer>().As<ICondiciones_en_Suspension_CondicionalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Generador_de_TurnosService>().As<IGenerador_de_TurnosService>().InstancePerLifetimeScope();
builder.RegisterType<Generador_de_TurnosApiConsumer>().As<IGenerador_de_TurnosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Auto_de_Vinculacion_a_ProcesoService>().As<IAuto_de_Vinculacion_a_ProcesoService>().InstancePerLifetimeScope();
builder.RegisterType<Auto_de_Vinculacion_a_ProcesoApiConsumer>().As<IAuto_de_Vinculacion_a_ProcesoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_Investigacion_ComplementariaService>().As<IResultado_de_Investigacion_ComplementariaService>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_Investigacion_ComplementariaApiConsumer>().As<IResultado_de_Investigacion_ComplementariaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<ResolucionService>().As<IResolucionService>().InstancePerLifetimeScope();
builder.RegisterType<ResolucionApiConsumer>().As<IResolucionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Plazo_de_Investigacion_ComplementariaService>().As<IPlazo_de_Investigacion_ComplementariaService>().InstancePerLifetimeScope();
builder.RegisterType<Plazo_de_Investigacion_ComplementariaApiConsumer>().As<IPlazo_de_Investigacion_ComplementariaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Especificacion_DetencionService>().As<IEspecificacion_DetencionService>().InstancePerLifetimeScope();
builder.RegisterType<Especificacion_DetencionApiConsumer>().As<IEspecificacion_DetencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_Audiencia_IntermediaService>().As<IResultado_de_Audiencia_IntermediaService>().InstancePerLifetimeScope();
builder.RegisterType<Resultado_de_Audiencia_IntermediaApiConsumer>().As<IResultado_de_Audiencia_IntermediaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Tribunal_de_EnjuiciamientoService>().As<ITribunal_de_EnjuiciamientoService>().InstancePerLifetimeScope();
builder.RegisterType<Tribunal_de_EnjuiciamientoApiConsumer>().As<ITribunal_de_EnjuiciamientoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_DetencionService>().As<IControl_de_DetencionService>().InstancePerLifetimeScope();
builder.RegisterType<Control_de_DetencionApiConsumer>().As<IControl_de_DetencionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_InicialService>().As<IAudiencia_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Audiencia_InicialApiConsumer>().As<IAudiencia_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Continuacion_de_ProcesoService>().As<IContinuacion_de_ProcesoService>().InstancePerLifetimeScope();
builder.RegisterType<Continuacion_de_ProcesoApiConsumer>().As<IContinuacion_de_ProcesoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Formulacion_de_ImputacionService>().As<IFormulacion_de_ImputacionService>().InstancePerLifetimeScope();
builder.RegisterType<Formulacion_de_ImputacionApiConsumer>().As<IFormulacion_de_ImputacionApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Plazo_ConstitucionalService>().As<IPlazo_ConstitucionalService>().InstancePerLifetimeScope();
builder.RegisterType<Plazo_ConstitucionalApiConsumer>().As<IPlazo_ConstitucionalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Vinculacion_a_ProcesoService>().As<IVinculacion_a_ProcesoService>().InstancePerLifetimeScope();
builder.RegisterType<Vinculacion_a_ProcesoApiConsumer>().As<IVinculacion_a_ProcesoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_VictimaService>().As<IDetalle_Medios_Prueba_VictimaService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_VictimaApiConsumer>().As<IDetalle_Medios_Prueba_VictimaApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Proceso_PenalService>().As<IProceso_PenalService>().InstancePerLifetimeScope();
builder.RegisterType<Proceso_PenalApiConsumer>().As<IProceso_PenalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Delitos_Proceso_PenalService>().As<IDetalle_Delitos_Proceso_PenalService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Delitos_Proceso_PenalApiConsumer>().As<IDetalle_Delitos_Proceso_PenalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_ImputadoService>().As<IDetalle_Medios_Prueba_ImputadoService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_ImputadoApiConsumer>().As<IDetalle_Medios_Prueba_ImputadoApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medidas_Cautelares_Proceso_PenalService>().As<IDetalle_Medidas_Cautelares_Proceso_PenalService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medidas_Cautelares_Proceso_PenalApiConsumer>().As<IDetalle_Medidas_Cautelares_Proceso_PenalApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Relaciones_Audiencia_InicialService>().As<IDetalle_Relaciones_Audiencia_InicialService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Relaciones_Audiencia_InicialApiConsumer>().As<IDetalle_Relaciones_Audiencia_InicialApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_AdmitidosService>().As<IDetalle_Medios_Prueba_AdmitidosService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Medios_Prueba_AdmitidosApiConsumer>().As<IDetalle_Medios_Prueba_AdmitidosApiConsumer>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Condiciones_Proceso_PenalService>().As<IDetalle_Condiciones_Proceso_PenalService>().InstancePerLifetimeScope();
builder.RegisterType<Detalle_Condiciones_Proceso_PenalApiConsumer>().As<IDetalle_Condiciones_Proceso_PenalApiConsumer>().InstancePerLifetimeScope();
//**@@INCLUDE_EXPOSE@@**//            

            builder.RegisterType<SpartanModuleApiConsumer>().As<ISpartanModuleApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartanUserRoleModuleApiConsumer>().As<ISpartanUserRoleModuleApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneModuleObjectApiConsumer>().As<ISpartaneModuleObjectApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneUserRoleModuleObjectApiConsumer>().As<ISpartaneUserRoleModuleObjectApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneObjectApiConsumer>().As<ISpartaneObjectApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneUserRoleObjectFunctionApiConsumer>().As<ISpartaneUserRoleObjectFunctionApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<LanguageApiConsumer>().As<ILanguageApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartanSecurityApiConsumer>().As<ISpartanSecurityApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<SpartanSessionApiConsumer>().As<ISpartanSessionApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneUserRoleObjectFunctionApiConsumer>().As<ISpartaneUserRoleObjectFunctionApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<SpartaneFunctionApiConsumer>().As<ISpartaneFunctionApiConsumer>().InstancePerLifetimeScope();
            //Till Here
            builder.RegisterType<TTArchivosService>().As<ITTArchivosService>().InstancePerLifetimeScope();

            //builder.RegisterType<MockSpartanDepartamentoService>().As<ISpartanDepartamentoService>().InstancePerLifetimeScope();

            builder.RegisterType<MockSpartanModuleService>().As<ISpartanModuleService>().InstancePerLifetimeScope().PreserveExistingDefaults();

            builder.RegisterType<FormsAuthenticationService>().As<IAuthenticationService>().InstancePerLifetimeScope();
            builder.RegisterType<SpartaneQueryApiConsumer>().As<ISpartaneQueryApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Attribute_Control_TypeService>().As<ISpartan_Attribute_Control_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Attribute_Control_TypeApiConsumer>().As<ISpartan_Attribute_Control_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Attribute_TypeService>().As<ISpartan_Attribute_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Attribute_TypeApiConsumer>().As<ISpartan_Attribute_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Business_RuleService>().As<ISpartan_Business_RuleService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Business_RuleApiConsumer>().As<ISpartan_Business_RuleApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ActionService>().As<ISpartan_BR_ActionService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ActionApiConsumer>().As<ISpartan_BR_ActionApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Attribute_Restrictions_DetailService>().As<ISpartan_BR_Attribute_Restrictions_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Attribute_Restrictions_DetailApiConsumer>().As<ISpartan_BR_Attribute_Restrictions_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_ClassificationService>().As<ISpartan_BR_Action_ClassificationService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_ClassificationApiConsumer>().As<ISpartan_BR_Action_ClassificationApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_Configuration_DetailService>().As<ISpartan_BR_Action_Configuration_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_Configuration_DetailApiConsumer>().As<ISpartan_BR_Action_Configuration_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Event_Restrictions_DetailService>().As<ISpartan_BR_Event_Restrictions_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Event_Restrictions_DetailApiConsumer>().As<ISpartan_BR_Event_Restrictions_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Actions_False_DetailService>().As<ISpartan_BR_Actions_False_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Actions_False_DetailApiConsumer>().As<ISpartan_BR_Actions_False_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operation_Restrictions_DetailService>().As<ISpartan_BR_Operation_Restrictions_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operation_Restrictions_DetailApiConsumer>().As<ISpartan_BR_Operation_Restrictions_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_Param_TypeService>().As<ISpartan_BR_Action_Param_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_Param_TypeApiConsumer>().As<ISpartan_BR_Action_Param_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_ResultService>().As<ISpartan_BR_Action_ResultService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Action_ResultApiConsumer>().As<ISpartan_BR_Action_ResultApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Actions_True_DetailService>().As<ISpartan_BR_Actions_True_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Actions_True_DetailApiConsumer>().As<ISpartan_BR_Actions_True_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ConditionService>().As<ISpartan_BR_ConditionService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ConditionApiConsumer>().As<ISpartan_BR_ConditionApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Condition_OperatorService>().As<ISpartan_BR_Condition_OperatorService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Condition_OperatorApiConsumer>().As<ISpartan_BR_Condition_OperatorApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Conditions_DetailService>().As<ISpartan_BR_Conditions_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Conditions_DetailApiConsumer>().As<ISpartan_BR_Conditions_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_OperationService>().As<ISpartan_BR_OperationService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_OperationApiConsumer>().As<ISpartan_BR_OperationApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operation_DetailService>().As<ISpartan_BR_Operation_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operation_DetailApiConsumer>().As<ISpartan_BR_Operation_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operator_TypeService>().As<ISpartan_BR_Operator_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Operator_TypeApiConsumer>().As<ISpartan_BR_Operator_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Presentation_Control_TypeService>().As<ISpartan_BR_Presentation_Control_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Presentation_Control_TypeApiConsumer>().As<ISpartan_BR_Presentation_Control_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Process_EventService>().As<ISpartan_BR_Process_EventService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Process_EventApiConsumer>().As<ISpartan_BR_Process_EventApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Process_Event_DetailService>().As<ISpartan_BR_Process_Event_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Process_Event_DetailApiConsumer>().As<ISpartan_BR_Process_Event_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ScopeService>().As<ISpartan_BR_ScopeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_ScopeApiConsumer>().As<ISpartan_BR_ScopeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Scope_DetailService>().As<ISpartan_BR_Scope_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Scope_DetailApiConsumer>().As<ISpartan_BR_Scope_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_StatusService>().As<ISpartan_BR_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_StatusApiConsumer>().As<ISpartan_BR_StatusApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Modifications_LogService>().As<ISpartan_BR_Modifications_LogService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_BR_Modifications_LogApiConsumer>().As<ISpartan_BR_Modifications_LogApiConsumer>().InstancePerLifetimeScope();


            
			
			
			builder.RegisterType<Spartan_UserService>().As<ISpartan_UserService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_UserApiConsumer>().As<ISpartan_UserApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_RoleService>().As<ISpartan_User_RoleService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_RoleApiConsumer>().As<ISpartan_User_RoleApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_Role_StatusService>().As<ISpartan_User_Role_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_Role_StatusApiConsumer>().As<ISpartan_User_Role_StatusApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_StatusService>().As<ISpartan_User_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_User_StatusApiConsumer>().As<ISpartan_User_StatusApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<Spartan_Traduction_Concept_TypeService>().As<ISpartan_Traduction_Concept_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Concept_TypeApiConsumer>().As<ISpartan_Traduction_Concept_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_DetailService>().As<ISpartan_Traduction_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_DetailApiConsumer>().As<ISpartan_Traduction_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_LanguageService>().As<ISpartan_Traduction_LanguageService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_LanguageApiConsumer>().As<ISpartan_Traduction_LanguageApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_ObjectService>().As<ISpartan_Traduction_ObjectService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_ObjectApiConsumer>().As<ISpartan_Traduction_ObjectApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Object_TypeService>().As<ISpartan_Traduction_Object_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Object_TypeApiConsumer>().As<ISpartan_Traduction_Object_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_ProcessService>().As<ISpartan_Traduction_ProcessService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_ProcessApiConsumer>().As<ISpartan_Traduction_ProcessApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<Spartan_Traduction_Process_WorkflowService>().As<ISpartan_Traduction_Process_WorkflowService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Process_WorkflowApiConsumer>().As<ISpartan_Traduction_Process_WorkflowApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Process_DataService>().As<ISpartan_Traduction_Process_DataService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Traduction_Process_DataApiConsumer>().As<ISpartan_Traduction_Process_DataApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<Spartan_WorkFlowService>().As<ISpartan_WorkFlowService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlowApiConsumer>().As<ISpartan_WorkFlowApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_ConditionService>().As<ISpartan_WorkFlow_ConditionService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_ConditionApiConsumer>().As<ISpartan_WorkFlow_ConditionApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Condition_OperatorService>().As<ISpartan_WorkFlow_Condition_OperatorService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Condition_OperatorApiConsumer>().As<ISpartan_WorkFlow_Condition_OperatorApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Conditions_by_StateService>().As<ISpartan_WorkFlow_Conditions_by_StateService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Conditions_by_StateApiConsumer>().As<ISpartan_WorkFlow_Conditions_by_StateApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Information_by_StateService>().As<ISpartan_WorkFlow_Information_by_StateService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Information_by_StateApiConsumer>().As<ISpartan_WorkFlow_Information_by_StateApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Matrix_of_StatesService>().As<ISpartan_WorkFlow_Matrix_of_StatesService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Matrix_of_StatesApiConsumer>().As<ISpartan_WorkFlow_Matrix_of_StatesApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_OperatorService>().As<ISpartan_WorkFlow_OperatorService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_OperatorApiConsumer>().As<ISpartan_WorkFlow_OperatorApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Phase_StatusService>().As<ISpartan_WorkFlow_Phase_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Phase_StatusApiConsumer>().As<ISpartan_WorkFlow_Phase_StatusApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Phase_TypeService>().As<ISpartan_WorkFlow_Phase_TypeService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Phase_TypeApiConsumer>().As<ISpartan_WorkFlow_Phase_TypeApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_PhasesService>().As<ISpartan_WorkFlow_PhasesService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_PhasesApiConsumer>().As<ISpartan_WorkFlow_PhasesApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Roles_by_StateService>().As<ISpartan_WorkFlow_Roles_by_StateService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Roles_by_StateApiConsumer>().As<ISpartan_WorkFlow_Roles_by_StateApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_StateService>().As<ISpartan_WorkFlow_StateService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_StateApiConsumer>().As<ISpartan_WorkFlow_StateApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_StatusService>().As<ISpartan_WorkFlow_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_StatusApiConsumer>().As<ISpartan_WorkFlow_StatusApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Type_Flow_ControlService>().As<ISpartan_WorkFlow_Type_Flow_ControlService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Type_Flow_ControlApiConsumer>().As<ISpartan_WorkFlow_Type_Flow_ControlApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Type_Work_DistributionService>().As<ISpartan_WorkFlow_Type_Work_DistributionService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_WorkFlow_Type_Work_DistributionApiConsumer>().As<ISpartan_WorkFlow_Type_Work_DistributionApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_ObjectService>().As<ISpartan_ObjectService>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_ObjectApiConsumer>().As<ISpartan_ObjectApiConsumer>().InstancePerLifetimeScope();
            
			

            builder.RegisterType<FormsAuthenticationService>().As<IAuthenticationService>().InstancePerLifetimeScope();
            builder.RegisterType<GeneratePDFApiConsumer>().As<IGeneratePDFApiConsumer>().InstancePerLifetimeScope();

            builder.RegisterType<Spartan_Bitacora_SQLApiConsumer>().As<ISpartan_Bitacora_SQLApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Spartan_Format_RelatedApiConsumer>().As<ISpartan_Format_RelatedApiConsumer>().InstancePerLifetimeScope();


            builder.RegisterType<HomeController>().As<Controller>();

            builder.RegisterType<Template_Dashboard_EditorService>().As<ITemplate_Dashboard_EditorService>().InstancePerLifetimeScope();
            builder.RegisterType<Template_Dashboard_EditorApiConsumer>().As<ITemplate_Dashboard_EditorApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_StatusService>().As<IDashboard_StatusService>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_StatusApiConsumer>().As<IDashboard_StatusApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_EditorService>().As<IDashboard_EditorService>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_EditorApiConsumer>().As<IDashboard_EditorApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Template_Dashboard_DetailService>().As<ITemplate_Dashboard_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Template_Dashboard_DetailApiConsumer>().As<ITemplate_Dashboard_DetailApiConsumer>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_Config_DetailService>().As<IDashboard_Config_DetailService>().InstancePerLifetimeScope();
            builder.RegisterType<Dashboard_Config_DetailApiConsumer>().As<IDashboard_Config_DetailApiConsumer>().InstancePerLifetimeScope();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //var resolver = new AutofacWebApiDependencyResolver(container);
            //config.DependencyResolver = resolver; 
        }

    }
}














































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































