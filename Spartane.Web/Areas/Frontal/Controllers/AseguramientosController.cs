using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;

using Spartane.Core.Domain.Tipo_de_medios_de_transporte;

using Spartane.Core.Domain.Marca_de_Medio_de_transporte;
using Spartane.Core.Domain.Submarca_de_medio_de_transporte;
using Spartane.Core.Domain.Modelo_de_medio_de_transporte;

using Spartane.Core.Domain.Color_de_medio_de_trasporte;


using Spartane.Core.Domain.Uso_del_medio_de_transporte;

using Spartane.Core.Domain.Procedencia_del_medio_de_transporte;





using Spartane.Core.Domain.Detencion;

using Spartane.Core.Domain.Detalle_Aseguramiento_de_Drogas_Involucradas;

using Spartane.Core.Domain.Tipo_de_Droga;
using Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga;



using Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas;

using Spartane.Core.Domain.Tipo_de_Arma;

using Spartane.Core.Domain.Marca_de_Arma;
using Spartane.Core.Domain.Calibre_de_Arma;



using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;




using Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos;

using Spartane.Core.Domain.Tipo_Clasificacion;
using Spartane.Core.Domain.Tipo_Artefacto;




using Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos;






using Spartane.Core.Domain.Detalle_Aseguramiento_Objetos_Asegurados;


using Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion;



using Spartane.Core.Domain.Detalle_Aseguramiento_Documentos;

using Spartane.Core.Domain.Tipo_de_Documento;




using Spartane.Core.Domain.Detalle_Aseguramiento_Moneda;

using Spartane.Core.Domain.Tipo_de_Moneda;


using Spartane.Core.Domain.Tipo_de_Dinero;

using Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos;

using Spartane.Core.Domain.Tipo_de_Equipo_Tactico;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;


using Spartane.Core.Domain.Unidad_de_Medida_de_Equipo_Tactico;



using Spartane.Core.Domain.Detalle_Aseguramiento_Electronicos_y_Multimedia;

using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using Spartane.Core.Domain.Documentos_Multimedia;




using Spartane.Core.Domain.Detalle_Aseguramiento_Pirateria;

using Spartane.Core.Domain.Tipo_de_Pirateria;


using Spartane.Core.Domain.Unidad_de_Medida_de_pirateria;


using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;

using Spartane.Core.Domain.Tipo_de_Zona;
using Spartane.Core.Domain.Tipo_de_Inmueble;
using Spartane.Core.Domain.Terreno_de_Inmuebles;





using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;






using Spartane.Core.Domain.Detalle_Aseguramiento_de_Plantios;

using Spartane.Core.Domain.Tipo_de_Plantio;


using Spartane.Core.Domain.Metodo_de_Destruccion;









using Spartane.Core.Domain.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;

using Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Core.Domain.Tipo_de_Suelo;





using Spartane.Core.Domain.Tipo_de_Orientacion;
using Spartane.Core.Domain.Tipo_de_Orientacion;



using Spartane.Core.Domain.Detalle_Aseguramiento_Otros;







using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Aseguramientos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Aseguramientos;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Medios_de_Transporte;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_medios_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Submarca_de_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Color_de_medio_de_trasporte;
using Spartane.Web.Areas.WebApiConsumer.Uso_del_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Detencion;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Drogas_Involucradas;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Droga;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_medida_de_tipo_de_droga;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Armas_Involucradas;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Calibre_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Clasificacion_de_Artefacto_y_Explosivo;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Artefactos_y_Explosivos;

using Spartane.Web.Areas.WebApiConsumer.Tipo_Clasificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Artefacto;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Cargador_Cartuchos;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Objetos_Asegurados;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_de_Comunicacion;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_de_Comunicacion;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Documentos;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Documento;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Moneda;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Moneda;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Dinero;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros_Aseguramientos;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_equipo_tactico;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_Equipo_Tactico;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Electronicos_y_Multimedia;

using Spartane.Web.Areas.WebApiConsumer.Aparato_Electronicos_y_Multimedia;
using Spartane.Web.Areas.WebApiConsumer.Documentos_Multimedia;


using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Pirateria;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Pirateria;

using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_pirateria;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Inmuebles;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Zona;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inmueble;
using Spartane.Web.Areas.WebApiConsumer.Terreno_de_Inmuebles;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Plantios;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Plantio;

using Spartane.Web.Areas.WebApiConsumer.Metodo_de_Destruccion;



using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Suelo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Orientacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Orientacion;



using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros;




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
    public class AseguramientosController : Controller
    {
        #region "variable declaration"

        private IAseguramientosService service = null;
        private IAseguramientosApiConsumer _IAseguramientosApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer;

        private ITipo_de_medios_de_transporteApiConsumer _ITipo_de_medios_de_transporteApiConsumer;
        private IMarca_de_Medio_de_transporteApiConsumer _IMarca_de_Medio_de_transporteApiConsumer;
        private ISubmarca_de_medio_de_transporteApiConsumer _ISubmarca_de_medio_de_transporteApiConsumer;
        private IModelo_de_medio_de_transporteApiConsumer _IModelo_de_medio_de_transporteApiConsumer;
        private IColor_de_medio_de_trasporteApiConsumer _IColor_de_medio_de_trasporteApiConsumer;
        private IUso_del_medio_de_transporteApiConsumer _IUso_del_medio_de_transporteApiConsumer;
        private IProcedencia_del_medio_de_transporteApiConsumer _IProcedencia_del_medio_de_transporteApiConsumer;
        private IDetencionApiConsumer _IDetencionApiConsumer;

        private IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer;

        private ITipo_de_DrogaApiConsumer _ITipo_de_DrogaApiConsumer;
        private IUnidad_de_medida_de_tipo_de_drogaApiConsumer _IUnidad_de_medida_de_tipo_de_drogaApiConsumer;


        private IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer;

        private ITipo_de_ArmaApiConsumer _ITipo_de_ArmaApiConsumer;
        private IMarca_de_ArmaApiConsumer _IMarca_de_ArmaApiConsumer;
        private ICalibre_de_ArmaApiConsumer _ICalibre_de_ArmaApiConsumer;
        private IClasificacion_de_Artefacto_y_ExplosivoApiConsumer _IClasificacion_de_Artefacto_y_ExplosivoApiConsumer;

        private IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer;

        private ITipo_ClasificacionApiConsumer _ITipo_ClasificacionApiConsumer;
        private ITipo_ArtefactoApiConsumer _ITipo_ArtefactoApiConsumer;


        private IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer;


        private IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer;

        private ITipo_de_Equipo_de_ComunicacionApiConsumer _ITipo_de_Equipo_de_ComunicacionApiConsumer;
        private IMarca_de_Equipo_de_ComunicacionApiConsumer _IMarca_de_Equipo_de_ComunicacionApiConsumer;

        private IDetalle_Aseguramiento_DocumentosApiConsumer _IDetalle_Aseguramiento_DocumentosApiConsumer;

        private ITipo_de_DocumentoApiConsumer _ITipo_de_DocumentoApiConsumer;


        private IDetalle_Aseguramiento_MonedaApiConsumer _IDetalle_Aseguramiento_MonedaApiConsumer;

        private ITipo_de_MonedaApiConsumer _ITipo_de_MonedaApiConsumer;

        private ITipo_de_DineroApiConsumer _ITipo_de_DineroApiConsumer;

        private IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer;

        private ITipo_de_Equipo_TacticoApiConsumer _ITipo_de_Equipo_TacticoApiConsumer;
        private IMarca_de_Equipo_TacticoApiConsumer _IMarca_de_Equipo_TacticoApiConsumer;
        private IModelo_de_equipo_tacticoApiConsumer _IModelo_de_equipo_tacticoApiConsumer;
        private IUnidad_de_Medida_de_Equipo_TacticoApiConsumer _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer;


        private IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer;

        private IAparato_Electronicos_y_MultimediaApiConsumer _IAparato_Electronicos_y_MultimediaApiConsumer;
        private IDocumentos_MultimediaApiConsumer _IDocumentos_MultimediaApiConsumer;


        private IDetalle_Aseguramiento_PirateriaApiConsumer _IDetalle_Aseguramiento_PirateriaApiConsumer;

        private ITipo_de_PirateriaApiConsumer _ITipo_de_PirateriaApiConsumer;

        private IUnidad_de_Medida_de_pirateriaApiConsumer _IUnidad_de_Medida_de_pirateriaApiConsumer;

        private IDetalle_Aseguramiento_InmueblesApiConsumer _IDetalle_Aseguramiento_InmueblesApiConsumer;

        private ITipo_de_ZonaApiConsumer _ITipo_de_ZonaApiConsumer;
        private ITipo_de_InmuebleApiConsumer _ITipo_de_InmuebleApiConsumer;
        private ITerreno_de_InmueblesApiConsumer _ITerreno_de_InmueblesApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;

        private IDetalle_Aseguramiento_de_PlantiosApiConsumer _IDetalle_Aseguramiento_de_PlantiosApiConsumer;

        private ITipo_de_PlantioApiConsumer _ITipo_de_PlantioApiConsumer;

        private IMetodo_de_DestruccionApiConsumer _IMetodo_de_DestruccionApiConsumer;



        private IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer;

        private ITipo_de_Pista_de_AterrizajeApiConsumer _ITipo_de_Pista_de_AterrizajeApiConsumer;
        private ITipo_de_SueloApiConsumer _ITipo_de_SueloApiConsumer;
        private ITipo_de_OrientacionApiConsumer _ITipo_de_OrientacionApiConsumer;



        private IDetalle_Aseguramiento_OtrosApiConsumer _IDetalle_Aseguramiento_OtrosApiConsumer;




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

        
        public AseguramientosController(IAseguramientosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAseguramientosApiConsumer AseguramientosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer Detalle_Aseguramiento_Medios_de_TransporteApiConsumer , ITipo_de_medios_de_transporteApiConsumer Tipo_de_medios_de_transporteApiConsumer , IMarca_de_Medio_de_transporteApiConsumer Marca_de_Medio_de_transporteApiConsumer , ISubmarca_de_medio_de_transporteApiConsumer Submarca_de_medio_de_transporteApiConsumer , IModelo_de_medio_de_transporteApiConsumer Modelo_de_medio_de_transporteApiConsumer , IColor_de_medio_de_trasporteApiConsumer Color_de_medio_de_trasporteApiConsumer , IUso_del_medio_de_transporteApiConsumer Uso_del_medio_de_transporteApiConsumer , IProcedencia_del_medio_de_transporteApiConsumer Procedencia_del_medio_de_transporteApiConsumer , IDetencionApiConsumer DetencionApiConsumer  , IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer Detalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer , ITipo_de_DrogaApiConsumer Tipo_de_DrogaApiConsumer , IUnidad_de_medida_de_tipo_de_drogaApiConsumer Unidad_de_medida_de_tipo_de_drogaApiConsumer  , IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer Detalle_Aseguramiento_Armas_InvolucradasApiConsumer , ITipo_de_ArmaApiConsumer Tipo_de_ArmaApiConsumer , IMarca_de_ArmaApiConsumer Marca_de_ArmaApiConsumer , ICalibre_de_ArmaApiConsumer Calibre_de_ArmaApiConsumer , IClasificacion_de_Artefacto_y_ExplosivoApiConsumer Clasificacion_de_Artefacto_y_ExplosivoApiConsumer  , IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer Detalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer , ITipo_ClasificacionApiConsumer Tipo_ClasificacionApiConsumer , ITipo_ArtefactoApiConsumer Tipo_ArtefactoApiConsumer  , IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer Detalle_Aseguramiento_de_Cargador_CartuchosApiConsumer  , IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer Detalle_Aseguramiento_Objetos_AseguradosApiConsumer , ITipo_de_Equipo_de_ComunicacionApiConsumer Tipo_de_Equipo_de_ComunicacionApiConsumer , IMarca_de_Equipo_de_ComunicacionApiConsumer Marca_de_Equipo_de_ComunicacionApiConsumer  , IDetalle_Aseguramiento_DocumentosApiConsumer Detalle_Aseguramiento_DocumentosApiConsumer , ITipo_de_DocumentoApiConsumer Tipo_de_DocumentoApiConsumer  , IDetalle_Aseguramiento_MonedaApiConsumer Detalle_Aseguramiento_MonedaApiConsumer , ITipo_de_MonedaApiConsumer Tipo_de_MonedaApiConsumer , ITipo_de_DineroApiConsumer Tipo_de_DineroApiConsumer  , IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer Detalle_Aseguramiento_Otros_AseguramientosApiConsumer , ITipo_de_Equipo_TacticoApiConsumer Tipo_de_Equipo_TacticoApiConsumer , IMarca_de_Equipo_TacticoApiConsumer Marca_de_Equipo_TacticoApiConsumer , IModelo_de_equipo_tacticoApiConsumer Modelo_de_equipo_tacticoApiConsumer , IUnidad_de_Medida_de_Equipo_TacticoApiConsumer Unidad_de_Medida_de_Equipo_TacticoApiConsumer  , IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer Detalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer , IAparato_Electronicos_y_MultimediaApiConsumer Aparato_Electronicos_y_MultimediaApiConsumer , IDocumentos_MultimediaApiConsumer Documentos_MultimediaApiConsumer  , IDetalle_Aseguramiento_PirateriaApiConsumer Detalle_Aseguramiento_PirateriaApiConsumer , ITipo_de_PirateriaApiConsumer Tipo_de_PirateriaApiConsumer , IUnidad_de_Medida_de_pirateriaApiConsumer Unidad_de_Medida_de_pirateriaApiConsumer  , IDetalle_Aseguramiento_InmueblesApiConsumer Detalle_Aseguramiento_InmueblesApiConsumer , ITipo_de_ZonaApiConsumer Tipo_de_ZonaApiConsumer , ITipo_de_InmuebleApiConsumer Tipo_de_InmuebleApiConsumer , ITerreno_de_InmueblesApiConsumer Terreno_de_InmueblesApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer  , IDetalle_Aseguramiento_de_PlantiosApiConsumer Detalle_Aseguramiento_de_PlantiosApiConsumer , ITipo_de_PlantioApiConsumer Tipo_de_PlantioApiConsumer , IMetodo_de_DestruccionApiConsumer Metodo_de_DestruccionApiConsumer  , IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer Detalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer , ITipo_de_Pista_de_AterrizajeApiConsumer Tipo_de_Pista_de_AterrizajeApiConsumer , ITipo_de_SueloApiConsumer Tipo_de_SueloApiConsumer , ITipo_de_OrientacionApiConsumer Tipo_de_OrientacionApiConsumer  , IDetalle_Aseguramiento_OtrosApiConsumer Detalle_Aseguramiento_OtrosApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAseguramientosApiConsumer = AseguramientosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer = Detalle_Aseguramiento_Medios_de_TransporteApiConsumer;

            this._ITipo_de_medios_de_transporteApiConsumer = Tipo_de_medios_de_transporteApiConsumer;
            this._IMarca_de_Medio_de_transporteApiConsumer = Marca_de_Medio_de_transporteApiConsumer;
            this._ISubmarca_de_medio_de_transporteApiConsumer = Submarca_de_medio_de_transporteApiConsumer;
            this._IModelo_de_medio_de_transporteApiConsumer = Modelo_de_medio_de_transporteApiConsumer;
            this._IColor_de_medio_de_trasporteApiConsumer = Color_de_medio_de_trasporteApiConsumer;
            this._IUso_del_medio_de_transporteApiConsumer = Uso_del_medio_de_transporteApiConsumer;
            this._IProcedencia_del_medio_de_transporteApiConsumer = Procedencia_del_medio_de_transporteApiConsumer;
            this._IDetencionApiConsumer = DetencionApiConsumer;

            this._IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer = Detalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer;

            this._ITipo_de_DrogaApiConsumer = Tipo_de_DrogaApiConsumer;
            this._IUnidad_de_medida_de_tipo_de_drogaApiConsumer = Unidad_de_medida_de_tipo_de_drogaApiConsumer;


            this._IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer = Detalle_Aseguramiento_Armas_InvolucradasApiConsumer;

            this._ITipo_de_ArmaApiConsumer = Tipo_de_ArmaApiConsumer;
            this._IMarca_de_ArmaApiConsumer = Marca_de_ArmaApiConsumer;
            this._ICalibre_de_ArmaApiConsumer = Calibre_de_ArmaApiConsumer;
            this._IClasificacion_de_Artefacto_y_ExplosivoApiConsumer = Clasificacion_de_Artefacto_y_ExplosivoApiConsumer;

            this._IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer = Detalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer;

            this._ITipo_ClasificacionApiConsumer = Tipo_ClasificacionApiConsumer;
            this._ITipo_ArtefactoApiConsumer = Tipo_ArtefactoApiConsumer;


            this._IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer = Detalle_Aseguramiento_de_Cargador_CartuchosApiConsumer;


            this._IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer = Detalle_Aseguramiento_Objetos_AseguradosApiConsumer;

            this._ITipo_de_Equipo_de_ComunicacionApiConsumer = Tipo_de_Equipo_de_ComunicacionApiConsumer;
            this._IMarca_de_Equipo_de_ComunicacionApiConsumer = Marca_de_Equipo_de_ComunicacionApiConsumer;

            this._IDetalle_Aseguramiento_DocumentosApiConsumer = Detalle_Aseguramiento_DocumentosApiConsumer;

            this._ITipo_de_DocumentoApiConsumer = Tipo_de_DocumentoApiConsumer;


            this._IDetalle_Aseguramiento_MonedaApiConsumer = Detalle_Aseguramiento_MonedaApiConsumer;

            this._ITipo_de_MonedaApiConsumer = Tipo_de_MonedaApiConsumer;

            this._ITipo_de_DineroApiConsumer = Tipo_de_DineroApiConsumer;

            this._IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer = Detalle_Aseguramiento_Otros_AseguramientosApiConsumer;

            this._ITipo_de_Equipo_TacticoApiConsumer = Tipo_de_Equipo_TacticoApiConsumer;
            this._IMarca_de_Equipo_TacticoApiConsumer = Marca_de_Equipo_TacticoApiConsumer;
            this._IModelo_de_equipo_tacticoApiConsumer = Modelo_de_equipo_tacticoApiConsumer;
            this._IUnidad_de_Medida_de_Equipo_TacticoApiConsumer = Unidad_de_Medida_de_Equipo_TacticoApiConsumer;


            this._IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer = Detalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer;

            this._IAparato_Electronicos_y_MultimediaApiConsumer = Aparato_Electronicos_y_MultimediaApiConsumer;
            this._IDocumentos_MultimediaApiConsumer = Documentos_MultimediaApiConsumer;


            this._IDetalle_Aseguramiento_PirateriaApiConsumer = Detalle_Aseguramiento_PirateriaApiConsumer;

            this._ITipo_de_PirateriaApiConsumer = Tipo_de_PirateriaApiConsumer;

            this._IUnidad_de_Medida_de_pirateriaApiConsumer = Unidad_de_Medida_de_pirateriaApiConsumer;

            this._IDetalle_Aseguramiento_InmueblesApiConsumer = Detalle_Aseguramiento_InmueblesApiConsumer;

            this._ITipo_de_ZonaApiConsumer = Tipo_de_ZonaApiConsumer;
            this._ITipo_de_InmuebleApiConsumer = Tipo_de_InmuebleApiConsumer;
            this._ITerreno_de_InmueblesApiConsumer = Terreno_de_InmueblesApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;

            this._IDetalle_Aseguramiento_de_PlantiosApiConsumer = Detalle_Aseguramiento_de_PlantiosApiConsumer;

            this._ITipo_de_PlantioApiConsumer = Tipo_de_PlantioApiConsumer;

            this._IMetodo_de_DestruccionApiConsumer = Metodo_de_DestruccionApiConsumer;



            this._IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer = Detalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer;

            this._ITipo_de_Pista_de_AterrizajeApiConsumer = Tipo_de_Pista_de_AterrizajeApiConsumer;
            this._ITipo_de_SueloApiConsumer = Tipo_de_SueloApiConsumer;
            this._ITipo_de_OrientacionApiConsumer = Tipo_de_OrientacionApiConsumer;
            this._ITipo_de_OrientacionApiConsumer = Tipo_de_OrientacionApiConsumer;



            this._IDetalle_Aseguramiento_OtrosApiConsumer = Detalle_Aseguramiento_OtrosApiConsumer;




        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Aseguramientos
        [ObjectAuth(ObjectId = (ModuleObjectId)45488, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45488, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Aseguramientos/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45488, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45488, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAseguramientos = new AseguramientosModel();
			varAseguramientos.Clave = Id;
			
            ViewBag.ObjectId = "45488";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Aseguramiento_Medios_de_Transporte = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45528, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Medios_de_Transporte = permissionDetalle_Aseguramiento_Medios_de_Transporte;
            var permissionDetalle_Aseguramiento_de_Drogas_Involucradas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45535, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Drogas_Involucradas = permissionDetalle_Aseguramiento_de_Drogas_Involucradas;
            var permissionDetalle_Aseguramiento_Armas_Involucradas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45489, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Armas_Involucradas = permissionDetalle_Aseguramiento_Armas_Involucradas;
            var permissionDetalle_Aseguramiento_Artefactos_y_Explosivos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45527, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Artefactos_y_Explosivos = permissionDetalle_Aseguramiento_Artefactos_y_Explosivos;
            var permissionDetalle_Aseguramiento_de_Cargador_Cartuchos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45534, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Cargador_Cartuchos = permissionDetalle_Aseguramiento_de_Cargador_Cartuchos;
            var permissionDetalle_Aseguramiento_Objetos_Asegurados = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45530, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Objetos_Asegurados = permissionDetalle_Aseguramiento_Objetos_Asegurados;
            var permissionDetalle_Aseguramiento_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45538, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Documentos = permissionDetalle_Aseguramiento_Documentos;
            var permissionDetalle_Aseguramiento_Moneda = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45529, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Moneda = permissionDetalle_Aseguramiento_Moneda;
            var permissionDetalle_Aseguramiento_Otros_Aseguramientos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45532, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Otros_Aseguramientos = permissionDetalle_Aseguramiento_Otros_Aseguramientos;
            var permissionDetalle_Aseguramiento_Electronicos_y_Multimedia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45502, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Electronicos_y_Multimedia = permissionDetalle_Aseguramiento_Electronicos_y_Multimedia;
            var permissionDetalle_Aseguramiento_Pirateria = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45533, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Pirateria = permissionDetalle_Aseguramiento_Pirateria;
            var permissionDetalle_Aseguramiento_Inmuebles = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45511, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Inmuebles = permissionDetalle_Aseguramiento_Inmuebles;
            var permissionDetalle_Aseguramiento_de_Plantios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45537, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Plantios = permissionDetalle_Aseguramiento_de_Plantios;
            var permissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45536, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = permissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje;
            var permissionDetalle_Aseguramiento_Otros = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45531, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Otros = permissionDetalle_Aseguramiento_Otros;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var AseguramientossData = _IAseguramientosApiConsumer.ListaSelAll(0, 1000, "Aseguramientos.Clave=" + Id, "").Resource.Aseguramientoss;
				
				if (AseguramientossData != null && AseguramientossData.Count > 0)
                {
					var AseguramientosData = AseguramientossData.First();
					varAseguramientos= new AseguramientosModel
					{
						Clave  = AseguramientosData.Clave 
	                    ,Expediente = AseguramientosData.Expediente
                    ,Expedientenic = CultureHelper.GetTraduction(Convert.ToString(AseguramientosData.Expediente), "expediente_ministerio_publico") ??  (string)AseguramientosData.Expediente_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (AseguramientosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(AseguramientosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = AseguramientosData.Hora_de_Registro
                    ,Usuario_que_Registra = AseguramientosData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(AseguramientosData.Usuario_que_Registra), "Spartan_User") ??  (string)AseguramientosData.Usuario_que_Registra_Spartan_User.Name

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



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

				
            return View(varAseguramientos);
        }
		
	[HttpGet]
        public ActionResult AddAseguramientos(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45488);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
			AseguramientosModel varAseguramientos= new AseguramientosModel();
            var permissionDetalle_Aseguramiento_Medios_de_Transporte = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45528, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Medios_de_Transporte = permissionDetalle_Aseguramiento_Medios_de_Transporte;
            var permissionDetalle_Aseguramiento_de_Drogas_Involucradas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45535, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Drogas_Involucradas = permissionDetalle_Aseguramiento_de_Drogas_Involucradas;
            var permissionDetalle_Aseguramiento_Armas_Involucradas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45489, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Armas_Involucradas = permissionDetalle_Aseguramiento_Armas_Involucradas;
            var permissionDetalle_Aseguramiento_Artefactos_y_Explosivos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45527, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Artefactos_y_Explosivos = permissionDetalle_Aseguramiento_Artefactos_y_Explosivos;
            var permissionDetalle_Aseguramiento_de_Cargador_Cartuchos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45534, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Cargador_Cartuchos = permissionDetalle_Aseguramiento_de_Cargador_Cartuchos;
            var permissionDetalle_Aseguramiento_Objetos_Asegurados = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45530, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Objetos_Asegurados = permissionDetalle_Aseguramiento_Objetos_Asegurados;
            var permissionDetalle_Aseguramiento_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45538, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Documentos = permissionDetalle_Aseguramiento_Documentos;
            var permissionDetalle_Aseguramiento_Moneda = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45529, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Moneda = permissionDetalle_Aseguramiento_Moneda;
            var permissionDetalle_Aseguramiento_Otros_Aseguramientos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45532, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Otros_Aseguramientos = permissionDetalle_Aseguramiento_Otros_Aseguramientos;
            var permissionDetalle_Aseguramiento_Electronicos_y_Multimedia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45502, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Electronicos_y_Multimedia = permissionDetalle_Aseguramiento_Electronicos_y_Multimedia;
            var permissionDetalle_Aseguramiento_Pirateria = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45533, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Pirateria = permissionDetalle_Aseguramiento_Pirateria;
            var permissionDetalle_Aseguramiento_Inmuebles = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45511, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Inmuebles = permissionDetalle_Aseguramiento_Inmuebles;
            var permissionDetalle_Aseguramiento_de_Plantios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45537, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Plantios = permissionDetalle_Aseguramiento_de_Plantios;
            var permissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45536, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = permissionDetalle_Aseguramiento_de_Pistas_de_Aterrizaje;
            var permissionDetalle_Aseguramiento_Otros = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45531, ModuleId);
            ViewBag.PermissionDetalle_Aseguramiento_Otros = permissionDetalle_Aseguramiento_Otros;


            if (id.ToString() != "0")
            {
                var AseguramientossData = _IAseguramientosApiConsumer.ListaSelAll(0, 1000, "Aseguramientos.Clave=" + id, "").Resource.Aseguramientoss;
				
				if (AseguramientossData != null && AseguramientossData.Count > 0)
                {
					var AseguramientosData = AseguramientossData.First();
					varAseguramientos= new AseguramientosModel
					{
						Clave  = AseguramientosData.Clave 
	                    ,Expediente = AseguramientosData.Expediente
                    ,Expedientenic = CultureHelper.GetTraduction(Convert.ToString(AseguramientosData.Expediente), "expediente_ministerio_publico") ??  (string)AseguramientosData.Expediente_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (AseguramientosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(AseguramientosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = AseguramientosData.Hora_de_Registro
                    ,Usuario_que_Registra = AseguramientosData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(AseguramientosData.Usuario_que_Registra), "Spartan_User") ??  (string)AseguramientosData.Usuario_que_Registra_Spartan_User.Name

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddAseguramientos", varAseguramientos);
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
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic")?? m.nic,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(AseguramientosAdvanceSearchModel model, int idFilter = -1)
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



            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            var previousFiltersObj = new AseguramientosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (AseguramientosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new AseguramientosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new AseguramientosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Aseguramientoss == null)
                result.Aseguramientoss = new List<Aseguramientos>();

            return Json(new
            {
                data = result.Aseguramientoss.Select(m => new AseguramientosGridModel
                    {
                    Clave = m.Clave
                        ,Expedientenic = CultureHelper.GetTraduction(m.Expediente_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAseguramientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguramientosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Aseguramientos", m.),
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
        /// Get List of Aseguramientos from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Aseguramientos Entity</returns>
        public ActionResult GetAseguramientosList(UrlParametersModel param)
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
            _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new AseguramientosPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(AseguramientosAdvanceSearchModel))
                {
					var advanceFilter =
                    (AseguramientosAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            AseguramientosPropertyMapper oAseguramientosPropertyMapper = new AseguramientosPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAseguramientosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Aseguramientoss == null)
                result.Aseguramientoss = new List<Aseguramientos>();

            return Json(new
            {
                aaData = result.Aseguramientoss.Select(m => new AseguramientosGridModel
            {
                    Clave = m.Clave
                        ,Expedientenic = CultureHelper.GetTraduction(m.Expediente_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetAseguramientos_Expediente_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nic as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nic ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nic");
                    item.nic =trans ??item.nic;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetAseguramientos_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_Aseguramiento_Medios_de_Transporte_Marca_Marca_de_Medio_de_transporte(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Marca_de_Medio_de_transporte.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Marca_de_Medio_de_transporte.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMarca_de_Medio_de_transporteApiConsumer.ListaSelAll(1, 20,elWhere , " Marca_de_Medio_de_transporte.Descripcion ASC ").Resource;
               
                foreach (var item in result.Marca_de_Medio_de_transportes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_de_Medio_de_transporte", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Marca_de_Medio_de_transportes.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Aseguramiento_Medios_de_Transporte_Submarca_Submarca_de_medio_de_transporte(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubmarca_de_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Submarca_de_medio_de_transporte.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Submarca_de_medio_de_transporte.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISubmarca_de_medio_de_transporteApiConsumer.ListaSelAll(1, 20,elWhere , " Submarca_de_medio_de_transporte.Descripcion ASC ").Resource;
               
                foreach (var item in result.Submarca_de_medio_de_transportes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Submarca_de_medio_de_transporte", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Submarca_de_medio_de_transportes.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Aseguramiento_Medios_de_Transporte_Modelo_Modelo_de_medio_de_transporte(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModelo_de_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modelo_de_medio_de_transporte.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modelo_de_medio_de_transporte.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModelo_de_medio_de_transporteApiConsumer.ListaSelAll(1, 20,elWhere , " Modelo_de_medio_de_transporte.Descripcion ASC ").Resource;
               
                foreach (var item in result.Modelo_de_medio_de_transportes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modelo_de_medio_de_transporte", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Modelo_de_medio_de_transportes.ToArray(), JsonRequestBehavior.AllowGet);
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
        [HttpGet]
        public JsonResult GetDetalle_Aseguramiento_Inmuebles_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_Aseguramiento_Inmuebles_Municipio_Municipio(string query, string where)
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

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(AseguramientosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Aseguramientos.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Aseguramientos.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente))
            {
                switch (filter.ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpedienteMultiple != null && filter.AdvanceExpedienteMultiple.Count() > 0)
            {
                var ExpedienteIds = string.Join(",", filter.AdvanceExpedienteMultiple);

                where += " AND Aseguramientos.Expediente In (" + ExpedienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Aseguramientos.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Aseguramientos.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Aseguramientos.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Aseguramientos.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Aseguramientos.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Medios_de_TransporteGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Medios_de_Transportes == null)
                result.Detalle_Aseguramiento_Medios_de_Transportes = new List<Detalle_Aseguramiento_Medios_de_Transporte>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Medios_de_Transportes.Select(m => new Detalle_Aseguramiento_Medios_de_TransporteGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_medios_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_medios_de_transporte.Descripcion
			,Especifique = m.Especifique
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Medio_de_transporte.Descripcion
                        ,Submarca = m.Submarca
                        ,SubmarcaDescripcion = CultureHelper.GetTraduction(m.Submarca_Submarca_de_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Submarca_Submarca_de_medio_de_transporte.Descripcion
                        ,Modelo = m.Modelo
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Modelo_Modelo_de_medio_de_transporte.Descripcion
			,Placas = m.Placas
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_de_medio_de_trasporte.Clave.ToString(), "Descripcion") ??(string)m.Color_Color_de_medio_de_trasporte.Descripcion
			,Numero_de_Motor = m.Numero_de_Motor
			,Serie = m.Serie
                        ,Uso = m.Uso
                        ,UsoDescripcion = CultureHelper.GetTraduction(m.Uso_Uso_del_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Uso_Uso_del_medio_de_transporte.Descripcion
			,Cap__De_Pasajeros = m.Cap__De_Pasajeros
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
			,Empresa = m.Empresa
			,Capacidad_de_Carga = m.Capacidad_de_Carga
			,Origen = m.Origen
			,Destino = m.Destino
			,Observaciones = m.Observaciones
                        ,Detencion = m.Detencion
                        ,DetencionDescripcion = CultureHelper.GetTraduction(m.Detencion_Detencion.Clave.ToString(), "Descripcion") ??(string)m.Detencion_Detencion.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Medios_de_TransporteGridModel> GetDetalle_Aseguramiento_Medios_de_TransporteData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Medios_de_TransporteGridModel> resultData = new List<Detalle_Aseguramiento_Medios_de_TransporteGridModel>();
            string where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Medios_de_Transportes != null)
            {
                resultData = result.Detalle_Aseguramiento_Medios_de_Transportes.Select(m => new Detalle_Aseguramiento_Medios_de_TransporteGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_medios_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_medios_de_transporte.Descripcion
			,Especifique = m.Especifique
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Medio_de_transporte.Descripcion
                        ,Submarca = m.Submarca
                        ,SubmarcaDescripcion = CultureHelper.GetTraduction(m.Submarca_Submarca_de_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Submarca_Submarca_de_medio_de_transporte.Descripcion
                        ,Modelo = m.Modelo
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Modelo_Modelo_de_medio_de_transporte.Descripcion
			,Placas = m.Placas
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_de_medio_de_trasporte.Clave.ToString(), "Descripcion") ??(string)m.Color_Color_de_medio_de_trasporte.Descripcion
			,Numero_de_Motor = m.Numero_de_Motor
			,Serie = m.Serie
                        ,Uso = m.Uso
                        ,UsoDescripcion = CultureHelper.GetTraduction(m.Uso_Uso_del_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Uso_Uso_del_medio_de_transporte.Descripcion
			,Cap__De_Pasajeros = m.Cap__De_Pasajeros
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_medio_de_transporte.Clave.ToString(), "Descripcion") ??(string)m.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
			,Empresa = m.Empresa
			,Capacidad_de_Carga = m.Capacidad_de_Carga
			,Origen = m.Origen
			,Destino = m.Destino
			,Observaciones = m.Observaciones
                        ,Detencion = m.Detencion
                        ,DetencionDescripcion = CultureHelper.GetTraduction(m.Detencion_Detencion.Clave.ToString(), "Descripcion") ??(string)m.Detencion_Detencion.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_de_Drogas_Involucradas(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_de_Drogas_Involucradass == null)
                result.Detalle_Aseguramiento_de_Drogas_Involucradass = new List<Detalle_Aseguramiento_de_Drogas_Involucradas>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_de_Drogas_Involucradass.Select(m => new Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Droga.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Droga.Descripcion
                        ,Unidad_de_Medida = m.Unidad_de_Medida
                        ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel> GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel> resultData = new List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel>();
            string where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_de_Drogas_Involucradass != null)
            {
                resultData = result.Detalle_Aseguramiento_de_Drogas_Involucradass.Select(m => new Detalle_Aseguramiento_de_Drogas_InvolucradasGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Droga.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Droga.Descripcion
                        ,Unidad_de_Medida = m.Unidad_de_Medida
                        ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medida_Unidad_de_medida_de_tipo_de_droga.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Armas_Involucradas(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Armas_InvolucradasGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Armas_Involucradass == null)
                result.Detalle_Aseguramiento_Armas_Involucradass = new List<Detalle_Aseguramiento_Armas_Involucradas>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Armas_Involucradass.Select(m => new Detalle_Aseguramiento_Armas_InvolucradasGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoNombre = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Arma.Clave.ToString(), "Nombre") ??(string)m.Tipo_Tipo_de_Arma.Nombre
			,Descripcion_del_Arma = m.Descripcion_del_Arma
                        ,Marca = m.Marca
                        ,MarcaNombre = CultureHelper.GetTraduction(m.Marca_Marca_de_Arma.Clave.ToString(), "Nombre") ??(string)m.Marca_Marca_de_Arma.Nombre
                        ,Calibre = m.Calibre
                        ,CalibreDescripcion = CultureHelper.GetTraduction(m.Calibre_Calibre_de_Arma.Clave.ToString(), "Descripcion") ??(string)m.Calibre_Calibre_de_Arma.Descripcion
			,Matricula = m.Matricula
			,Serie = m.Serie
			,Inventario = m.Inventario
                        ,Clasificacion = m.Clasificacion
                        ,ClasificacionDescripcion = CultureHelper.GetTraduction(m.Clasificacion_Clasificacion_de_Artefacto_y_Explosivo.Clave.ToString(), "Descripcion") ??(string)m.Clasificacion_Clasificacion_de_Artefacto_y_Explosivo.Descripcion
			,Cantidad = m.Cantidad
			,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Armas_InvolucradasGridModel> GetDetalle_Aseguramiento_Armas_InvolucradasData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Armas_InvolucradasGridModel> resultData = new List<Detalle_Aseguramiento_Armas_InvolucradasGridModel>();
            string where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Armas_Involucradass != null)
            {
                resultData = result.Detalle_Aseguramiento_Armas_Involucradass.Select(m => new Detalle_Aseguramiento_Armas_InvolucradasGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoNombre = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Arma.Clave.ToString(), "Nombre") ??(string)m.Tipo_Tipo_de_Arma.Nombre
			,Descripcion_del_Arma = m.Descripcion_del_Arma
                        ,Marca = m.Marca
                        ,MarcaNombre = CultureHelper.GetTraduction(m.Marca_Marca_de_Arma.Clave.ToString(), "Nombre") ??(string)m.Marca_Marca_de_Arma.Nombre
                        ,Calibre = m.Calibre
                        ,CalibreDescripcion = CultureHelper.GetTraduction(m.Calibre_Calibre_de_Arma.Clave.ToString(), "Descripcion") ??(string)m.Calibre_Calibre_de_Arma.Descripcion
			,Matricula = m.Matricula
			,Serie = m.Serie
			,Inventario = m.Inventario
                        ,Clasificacion = m.Clasificacion
                        ,ClasificacionDescripcion = CultureHelper.GetTraduction(m.Clasificacion_Clasificacion_de_Artefacto_y_Explosivo.Clave.ToString(), "Descripcion") ??(string)m.Clasificacion_Clasificacion_de_Artefacto_y_Explosivo.Descripcion
			,Cantidad = m.Cantidad
			,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Artefactos_y_Explosivos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Artefactos_y_Explosivoss == null)
                result.Detalle_Aseguramiento_Artefactos_y_Explosivoss = new List<Detalle_Aseguramiento_Artefactos_y_Explosivos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Artefactos_y_Explosivoss.Select(m => new Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel
                {
                    Clave = m.Clave

                        ,Clasificacion = m.Clasificacion
                        ,ClasificacionDescripcion = CultureHelper.GetTraduction(m.Clasificacion_Tipo_Clasificacion.Clave.ToString(), "Descripcion") ??(string)m.Clasificacion_Tipo_Clasificacion.Descripcion
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_Artefacto.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_Artefacto.Descripcion
			,Cantidad = m.Cantidad
			,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel> GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel> resultData = new List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel>();
            string where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Artefactos_y_Explosivoss != null)
            {
                resultData = result.Detalle_Aseguramiento_Artefactos_y_Explosivoss.Select(m => new Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModel
                    {
                        Clave = m.Clave

                        ,Clasificacion = m.Clasificacion
                        ,ClasificacionDescripcion = CultureHelper.GetTraduction(m.Clasificacion_Tipo_Clasificacion.Clave.ToString(), "Descripcion") ??(string)m.Clasificacion_Tipo_Clasificacion.Descripcion
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_Artefacto.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_Artefacto.Descripcion
			,Cantidad = m.Cantidad
			,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_de_Cargador_Cartuchos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_de_Cargador_Cartuchoss == null)
                result.Detalle_Aseguramiento_de_Cargador_Cartuchoss = new List<Detalle_Aseguramiento_de_Cargador_Cartuchos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_de_Cargador_Cartuchoss.Select(m => new Detalle_Aseguramiento_de_Cargador_CartuchosGridModel
                {
                    Clave = m.Clave

			,cartuchos_municiones = m.cartuchos_municiones
			,Cartuchos_Habiles = m.Cartuchos_Habiles
			,Cartuchos_Percutidos = m.Cartuchos_Percutidos
			,cargadores = m.cargadores

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModel> GetDetalle_Aseguramiento_de_Cargador_CartuchosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModel> resultData = new List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModel>();
            string where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_de_Cargador_Cartuchoss != null)
            {
                resultData = result.Detalle_Aseguramiento_de_Cargador_Cartuchoss.Select(m => new Detalle_Aseguramiento_de_Cargador_CartuchosGridModel
                    {
                        Clave = m.Clave

			,cartuchos_municiones = m.cartuchos_municiones
			,Cartuchos_Habiles = m.Cartuchos_Habiles
			,Cartuchos_Percutidos = m.Cartuchos_Percutidos
			,cargadores = m.cargadores


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Objetos_Asegurados(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Objetos_AseguradosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Objetos_Aseguradoss == null)
                result.Detalle_Aseguramiento_Objetos_Aseguradoss = new List<Detalle_Aseguramiento_Objetos_Asegurados>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Objetos_Aseguradoss.Select(m => new Detalle_Aseguramiento_Objetos_AseguradosGridModel
                {
                    Clave = m.Clave

			,Numero = m.Numero
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
			,Serie = m.Serie
			,IMEI = m.IMEI

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Objetos_AseguradosGridModel> GetDetalle_Aseguramiento_Objetos_AseguradosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Objetos_AseguradosGridModel> resultData = new List<Detalle_Aseguramiento_Objetos_AseguradosGridModel>();
            string where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Objetos_Aseguradoss != null)
            {
                resultData = result.Detalle_Aseguramiento_Objetos_Aseguradoss.Select(m => new Detalle_Aseguramiento_Objetos_AseguradosGridModel
                    {
                        Clave = m.Clave

			,Numero = m.Numero
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Equipo_de_Comunicacion.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_de_Comunicacion.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Equipo_de_Comunicacion.Descripcion
			,Serie = m.Serie
			,IMEI = m.IMEI


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Documentos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_DocumentosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Documentos.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Documentos.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_DocumentosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Documentoss == null)
                result.Detalle_Aseguramiento_Documentoss = new List<Detalle_Aseguramiento_Documentos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Documentoss.Select(m => new Detalle_Aseguramiento_DocumentosGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Documento.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Documento.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones
			,Descipcion_de_Documento = m.Descipcion_de_Documento

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_DocumentosGridModel> GetDetalle_Aseguramiento_DocumentosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_DocumentosGridModel> resultData = new List<Detalle_Aseguramiento_DocumentosGridModel>();
            string where = "Detalle_Aseguramiento_Documentos.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Documentos.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_DocumentosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Documentoss != null)
            {
                resultData = result.Detalle_Aseguramiento_Documentoss.Select(m => new Detalle_Aseguramiento_DocumentosGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Documento.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Documento.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones
			,Descipcion_de_Documento = m.Descipcion_de_Documento


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Moneda(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_MonedaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Moneda.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Moneda.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_MonedaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Monedas == null)
                result.Detalle_Aseguramiento_Monedas = new List<Detalle_Aseguramiento_Moneda>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Monedas.Select(m => new Detalle_Aseguramiento_MonedaGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Moneda.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Moneda.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones
                        ,Descripcion = m.Descripcion
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Tipo_de_Dinero.Clave.ToString(), "Descripcion") ??(string)m.Descripcion_Tipo_de_Dinero.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_MonedaGridModel> GetDetalle_Aseguramiento_MonedaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_MonedaGridModel> resultData = new List<Detalle_Aseguramiento_MonedaGridModel>();
            string where = "Detalle_Aseguramiento_Moneda.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Moneda.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_MonedaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Monedas != null)
            {
                resultData = result.Detalle_Aseguramiento_Monedas.Select(m => new Detalle_Aseguramiento_MonedaGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Moneda.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Moneda.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones
                        ,Descripcion = m.Descripcion
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Tipo_de_Dinero.Clave.ToString(), "Descripcion") ??(string)m.Descripcion_Tipo_de_Dinero.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Otros_Aseguramientos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Otros_AseguramientosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Otros_Aseguramientoss == null)
                result.Detalle_Aseguramiento_Otros_Aseguramientoss = new List<Detalle_Aseguramiento_Otros_Aseguramientos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Otros_Aseguramientoss.Select(m => new Detalle_Aseguramiento_Otros_AseguramientosGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Equipo_Tactico.Descripcion
                        ,Modelo = m.Modelo
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_equipo_tactico.Clave.ToString(), "Descripcion") ??(string)m.Modelo_Modelo_de_equipo_tactico.Descripcion
			,Inventario = m.Inventario
			,Serie = m.Serie
                        ,Unidad_de_Medida = m.Unidad_de_Medida
                        ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Otros_AseguramientosGridModel> GetDetalle_Aseguramiento_Otros_AseguramientosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Otros_AseguramientosGridModel> resultData = new List<Detalle_Aseguramiento_Otros_AseguramientosGridModel>();
            string where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Otros_Aseguramientoss != null)
            {
                resultData = result.Detalle_Aseguramiento_Otros_Aseguramientoss.Select(m => new Detalle_Aseguramiento_Otros_AseguramientosGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Marca_Marca_de_Equipo_Tactico.Descripcion
                        ,Modelo = m.Modelo
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_equipo_tactico.Clave.ToString(), "Descripcion") ??(string)m.Modelo_Modelo_de_equipo_tactico.Descripcion
			,Inventario = m.Inventario
			,Serie = m.Serie
                        ,Unidad_de_Medida = m.Unidad_de_Medida
                        ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Electronicos_y_Multimedia(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Electronicos_y_Multimedias == null)
                result.Detalle_Aseguramiento_Electronicos_y_Multimedias = new List<Detalle_Aseguramiento_Electronicos_y_Multimedia>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Electronicos_y_Multimedias.Select(m => new Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel
                {
                    Clave = m.Clave

                        ,Aparatos = m.Aparatos
                        ,AparatosDescripcion = CultureHelper.GetTraduction(m.Aparatos_Aparato_Electronicos_y_Multimedia.Clave.ToString(), "Descripcion") ??(string)m.Aparatos_Aparato_Electronicos_y_Multimedia.Descripcion
                        ,Documentos_Multimedia = m.Documentos_Multimedia
                        ,Documentos_MultimediaDescripcion = CultureHelper.GetTraduction(m.Documentos_Multimedia_Documentos_Multimedia.Clave.ToString(), "Descripcion") ??(string)m.Documentos_Multimedia_Documentos_Multimedia.Descripcion
			,Descripcion = m.Descripcion
			,Cantidad = m.Cantidad
			,A_resguardo = m.A_resguardo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel> GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel> resultData = new List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel>();
            string where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Electronicos_y_Multimedias != null)
            {
                resultData = result.Detalle_Aseguramiento_Electronicos_y_Multimedias.Select(m => new Detalle_Aseguramiento_Electronicos_y_MultimediaGridModel
                    {
                        Clave = m.Clave

                        ,Aparatos = m.Aparatos
                        ,AparatosDescripcion = CultureHelper.GetTraduction(m.Aparatos_Aparato_Electronicos_y_Multimedia.Clave.ToString(), "Descripcion") ??(string)m.Aparatos_Aparato_Electronicos_y_Multimedia.Descripcion
                        ,Documentos_Multimedia = m.Documentos_Multimedia
                        ,Documentos_MultimediaDescripcion = CultureHelper.GetTraduction(m.Documentos_Multimedia_Documentos_Multimedia.Clave.ToString(), "Descripcion") ??(string)m.Documentos_Multimedia_Documentos_Multimedia.Descripcion
			,Descripcion = m.Descripcion
			,Cantidad = m.Cantidad
			,A_resguardo = m.A_resguardo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Pirateria(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_PirateriaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Pirateria.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Pirateria.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_PirateriaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Piraterias == null)
                result.Detalle_Aseguramiento_Piraterias = new List<Detalle_Aseguramiento_Pirateria>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Piraterias.Select(m => new Detalle_Aseguramiento_PirateriaGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Pirateria.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Pirateria.Descripcion
			,Descripcion = m.Descripcion
			,Cantidad = m.Cantidad
                        ,Unidad_de_Medicion = m.Unidad_de_Medicion
                        ,Unidad_de_MedicionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medicion_Unidad_de_Medida_de_pirateria.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medicion_Unidad_de_Medida_de_pirateria.Descripcion
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_PirateriaGridModel> GetDetalle_Aseguramiento_PirateriaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_PirateriaGridModel> resultData = new List<Detalle_Aseguramiento_PirateriaGridModel>();
            string where = "Detalle_Aseguramiento_Pirateria.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Pirateria.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_PirateriaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Piraterias != null)
            {
                resultData = result.Detalle_Aseguramiento_Piraterias.Select(m => new Detalle_Aseguramiento_PirateriaGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Pirateria.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Pirateria.Descripcion
			,Descripcion = m.Descripcion
			,Cantidad = m.Cantidad
                        ,Unidad_de_Medicion = m.Unidad_de_Medicion
                        ,Unidad_de_MedicionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medicion_Unidad_de_Medida_de_pirateria.Clave.ToString(), "Descripcion") ??(string)m.Unidad_de_Medicion_Unidad_de_Medida_de_pirateria.Descripcion
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Inmuebles(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_InmueblesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Inmuebless == null)
                result.Detalle_Aseguramiento_Inmuebless = new List<Detalle_Aseguramiento_Inmuebles>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Inmuebless.Select(m => new Detalle_Aseguramiento_InmueblesGridModel
                {
                    Clave = m.Clave

                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Tipo_de_Zona.Clave.ToString(), "Descripcion") ??(string)m.Zona_Tipo_de_Zona.Descripcion
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Inmueble.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Inmueble.Descripcion
                        ,Terreno = m.Terreno
                        ,TerrenoDescripcion = CultureHelper.GetTraduction(m.Terreno_Terreno_de_Inmuebles.Clave.ToString(), "Descripcion") ??(string)m.Terreno_Terreno_de_Inmuebles.Descripcion
			,Especifique_Otro = m.Especifique_Otro
			,Calle = m.Calle
			,Exterior = m.Exterior
			,Interior = m.Interior
			,C_P = m.C_P
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
			,Colonia = m.Colonia
			,Registro_Publico_Propiedad = m.Registro_Publico_Propiedad
			,Entrecalles = m.Entrecalles
			,Propietario = m.Propietario
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_InmueblesGridModel> GetDetalle_Aseguramiento_InmueblesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_InmueblesGridModel> resultData = new List<Detalle_Aseguramiento_InmueblesGridModel>();
            string where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Inmuebless != null)
            {
                resultData = result.Detalle_Aseguramiento_Inmuebless.Select(m => new Detalle_Aseguramiento_InmueblesGridModel
                    {
                        Clave = m.Clave

                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Tipo_de_Zona.Clave.ToString(), "Descripcion") ??(string)m.Zona_Tipo_de_Zona.Descripcion
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Inmueble.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Inmueble.Descripcion
                        ,Terreno = m.Terreno
                        ,TerrenoDescripcion = CultureHelper.GetTraduction(m.Terreno_Terreno_de_Inmuebles.Clave.ToString(), "Descripcion") ??(string)m.Terreno_Terreno_de_Inmuebles.Descripcion
			,Especifique_Otro = m.Especifique_Otro
			,Calle = m.Calle
			,Exterior = m.Exterior
			,Interior = m.Interior
			,C_P = m.C_P
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
			,Colonia = m.Colonia
			,Registro_Publico_Propiedad = m.Registro_Publico_Propiedad
			,Entrecalles = m.Entrecalles
			,Propietario = m.Propietario
			,Observaciones = m.Observaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_de_Plantios(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_de_PlantiosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_PlantiosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_de_PlantiosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_de_Plantioss == null)
                result.Detalle_Aseguramiento_de_Plantioss = new List<Detalle_Aseguramiento_de_Plantios>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_de_Plantioss.Select(m => new Detalle_Aseguramiento_de_PlantiosGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Plantio.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Plantio.Descripcion
			,No__de_Plantios = m.No__de_Plantios
			,Kilogramos = m.Kilogramos
                        ,Metodo_de_Destruccion = m.Metodo_de_Destruccion
                        ,Metodo_de_DestruccionDescripcion = CultureHelper.GetTraduction(m.Metodo_de_Destruccion_Metodo_de_Destruccion.Clave.ToString(), "Descripcion") ??(string)m.Metodo_de_Destruccion_Metodo_de_Destruccion.Descripcion
			,Superficie = m.Superficie
			,Altura = m.Altura
			,Densidad = m.Densidad
			,Peso_por_planta = m.Peso_por_planta
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Largo = m.Largo
			,Ancho = m.Ancho

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_de_PlantiosGridModel> GetDetalle_Aseguramiento_de_PlantiosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_de_PlantiosGridModel> resultData = new List<Detalle_Aseguramiento_de_PlantiosGridModel>();
            string where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_PlantiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_de_PlantiosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_de_Plantioss != null)
            {
                resultData = result.Detalle_Aseguramiento_de_Plantioss.Select(m => new Detalle_Aseguramiento_de_PlantiosGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Plantio.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Plantio.Descripcion
			,No__de_Plantios = m.No__de_Plantios
			,Kilogramos = m.Kilogramos
                        ,Metodo_de_Destruccion = m.Metodo_de_Destruccion
                        ,Metodo_de_DestruccionDescripcion = CultureHelper.GetTraduction(m.Metodo_de_Destruccion_Metodo_de_Destruccion.Clave.ToString(), "Descripcion") ??(string)m.Metodo_de_Destruccion_Metodo_de_Destruccion.Descripcion
			,Superficie = m.Superficie
			,Altura = m.Altura
			,Densidad = m.Densidad
			,Peso_por_planta = m.Peso_por_planta
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Largo = m.Largo
			,Ancho = m.Ancho


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes == null)
                result.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes = new List<Detalle_Aseguramiento_de_Pistas_de_Aterrizaje>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes.Select(m => new Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel
                {
                    Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Pista_de_Aterrizaje.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Pista_de_Aterrizaje.Descripcion
                        ,Suelo = m.Suelo
                        ,SueloDescripcion = CultureHelper.GetTraduction(m.Suelo_Tipo_de_Suelo.Clave.ToString(), "Descripcion") ??(string)m.Suelo_Tipo_de_Suelo.Descripcion
			,Descripcion = m.Descripcion
			,Localizacion_1 = m.Localizacion_1
			,Localizacion_2 = m.Localizacion_2
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Orientacion_de = m.Orientacion_de
                        ,Orientacion_deDescripcion = CultureHelper.GetTraduction(m.Orientacion_de_Tipo_de_Orientacion.Clave.ToString(), "Descripcion") ??(string)m.Orientacion_de_Tipo_de_Orientacion.Descripcion
                        ,Orientacion = m.Orientacion
                        ,OrientacionDescripcion = CultureHelper.GetTraduction(m.Orientacion_Tipo_de_Orientacion.Clave.ToString(), "Descripcion") ??(string)m.Orientacion_Tipo_de_Orientacion.Descripcion
			,Largo = m.Largo
			,Ancho = m.Ancho

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel> GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel> resultData = new List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel>();
            string where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes != null)
            {
                resultData = result.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes.Select(m => new Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModel
                    {
                        Clave = m.Clave

                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Pista_de_Aterrizaje.Clave.ToString(), "Descripcion") ??(string)m.Tipo_Tipo_de_Pista_de_Aterrizaje.Descripcion
                        ,Suelo = m.Suelo
                        ,SueloDescripcion = CultureHelper.GetTraduction(m.Suelo_Tipo_de_Suelo.Clave.ToString(), "Descripcion") ??(string)m.Suelo_Tipo_de_Suelo.Descripcion
			,Descripcion = m.Descripcion
			,Localizacion_1 = m.Localizacion_1
			,Localizacion_2 = m.Localizacion_2
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Orientacion_de = m.Orientacion_de
                        ,Orientacion_deDescripcion = CultureHelper.GetTraduction(m.Orientacion_de_Tipo_de_Orientacion.Clave.ToString(), "Descripcion") ??(string)m.Orientacion_de_Tipo_de_Orientacion.Descripcion
                        ,Orientacion = m.Orientacion
                        ,OrientacionDescripcion = CultureHelper.GetTraduction(m.Orientacion_Tipo_de_Orientacion.Clave.ToString(), "Descripcion") ??(string)m.Orientacion_Tipo_de_Orientacion.Descripcion
			,Largo = m.Largo
			,Ancho = m.Ancho


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Aseguramiento_Otros(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Aseguramiento_OtrosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Aseguramiento_Otros.Aseguramiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Aseguramiento_Otros.Aseguramiento='" + RelationId + "'";
            }
            var result = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Aseguramiento_Otross == null)
                result.Detalle_Aseguramiento_Otross = new List<Detalle_Aseguramiento_Otros>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Aseguramiento_Otross.Select(m => new Detalle_Aseguramiento_OtrosGridModel
                {
                    Clave = m.Clave

			,Tipo = m.Tipo
			,Unidad_de_medida = m.Unidad_de_medida
			,Cantidad = m.Cantidad
			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Aseguramiento_OtrosGridModel> GetDetalle_Aseguramiento_OtrosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Aseguramiento_OtrosGridModel> resultData = new List<Detalle_Aseguramiento_OtrosGridModel>();
            string where = "Detalle_Aseguramiento_Otros.Aseguramiento=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Aseguramiento_Otros.Aseguramiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Aseguramiento_Otross != null)
            {
                resultData = result.Detalle_Aseguramiento_Otross.Select(m => new Detalle_Aseguramiento_OtrosGridModel
                    {
                        Clave = m.Clave

			,Tipo = m.Tipo
			,Unidad_de_medida = m.Unidad_de_medida
			,Cantidad = m.Cantidad
			,Descripcion = m.Descripcion


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
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Aseguramientos varAseguramientos = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Medios_de_TransporteInfo =
                        _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Medios_de_TransporteInfo.Detalle_Aseguramiento_Medios_de_Transportes.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Medios_de_Transporte = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Medios_de_TransporteItem in Detalle_Aseguramiento_Medios_de_TransporteInfo.Detalle_Aseguramiento_Medios_de_Transportes)
                            resultDetalle_Aseguramiento_Medios_de_Transporte = resultDetalle_Aseguramiento_Medios_de_Transporte
                                              && _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Delete(Detalle_Aseguramiento_Medios_de_TransporteItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Medios_de_Transporte)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_de_Drogas_InvolucradasInfo =
                        _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_de_Drogas_InvolucradasInfo.Detalle_Aseguramiento_de_Drogas_Involucradass.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_de_Drogas_Involucradas = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_de_Drogas_InvolucradasItem in Detalle_Aseguramiento_de_Drogas_InvolucradasInfo.Detalle_Aseguramiento_de_Drogas_Involucradass)
                            resultDetalle_Aseguramiento_de_Drogas_Involucradas = resultDetalle_Aseguramiento_de_Drogas_Involucradas
                                              && _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.Delete(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_de_Drogas_Involucradas)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Armas_InvolucradasInfo =
                        _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Armas_InvolucradasInfo.Detalle_Aseguramiento_Armas_Involucradass.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Armas_Involucradas = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Armas_InvolucradasItem in Detalle_Aseguramiento_Armas_InvolucradasInfo.Detalle_Aseguramiento_Armas_Involucradass)
                            resultDetalle_Aseguramiento_Armas_Involucradas = resultDetalle_Aseguramiento_Armas_Involucradas
                                              && _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Delete(Detalle_Aseguramiento_Armas_InvolucradasItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Armas_Involucradas)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Artefactos_y_ExplosivosInfo =
                        _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Artefactos_y_ExplosivosInfo.Detalle_Aseguramiento_Artefactos_y_Explosivoss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Artefactos_y_Explosivos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Artefactos_y_ExplosivosItem in Detalle_Aseguramiento_Artefactos_y_ExplosivosInfo.Detalle_Aseguramiento_Artefactos_y_Explosivoss)
                            resultDetalle_Aseguramiento_Artefactos_y_Explosivos = resultDetalle_Aseguramiento_Artefactos_y_Explosivos
                                              && _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.Delete(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Artefactos_y_Explosivos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_de_Cargador_CartuchosInfo =
                        _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_de_Cargador_CartuchosInfo.Detalle_Aseguramiento_de_Cargador_Cartuchoss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_de_Cargador_Cartuchos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_de_Cargador_CartuchosItem in Detalle_Aseguramiento_de_Cargador_CartuchosInfo.Detalle_Aseguramiento_de_Cargador_Cartuchoss)
                            resultDetalle_Aseguramiento_de_Cargador_Cartuchos = resultDetalle_Aseguramiento_de_Cargador_Cartuchos
                                              && _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.Delete(Detalle_Aseguramiento_de_Cargador_CartuchosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_de_Cargador_Cartuchos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Objetos_AseguradosInfo =
                        _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Objetos_AseguradosInfo.Detalle_Aseguramiento_Objetos_Aseguradoss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Objetos_Asegurados = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Objetos_AseguradosItem in Detalle_Aseguramiento_Objetos_AseguradosInfo.Detalle_Aseguramiento_Objetos_Aseguradoss)
                            resultDetalle_Aseguramiento_Objetos_Asegurados = resultDetalle_Aseguramiento_Objetos_Asegurados
                                              && _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Delete(Detalle_Aseguramiento_Objetos_AseguradosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Objetos_Asegurados)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Documentos.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Documentos.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_DocumentosInfo =
                        _IDetalle_Aseguramiento_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_DocumentosInfo.Detalle_Aseguramiento_Documentoss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Documentos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_DocumentosItem in Detalle_Aseguramiento_DocumentosInfo.Detalle_Aseguramiento_Documentoss)
                            resultDetalle_Aseguramiento_Documentos = resultDetalle_Aseguramiento_Documentos
                                              && _IDetalle_Aseguramiento_DocumentosApiConsumer.Delete(Detalle_Aseguramiento_DocumentosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Documentos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Moneda.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Moneda.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_MonedaInfo =
                        _IDetalle_Aseguramiento_MonedaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_MonedaInfo.Detalle_Aseguramiento_Monedas.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Moneda = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_MonedaItem in Detalle_Aseguramiento_MonedaInfo.Detalle_Aseguramiento_Monedas)
                            resultDetalle_Aseguramiento_Moneda = resultDetalle_Aseguramiento_Moneda
                                              && _IDetalle_Aseguramiento_MonedaApiConsumer.Delete(Detalle_Aseguramiento_MonedaItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Moneda)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Otros_AseguramientosInfo =
                        _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Otros_AseguramientosInfo.Detalle_Aseguramiento_Otros_Aseguramientoss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Otros_Aseguramientos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Otros_AseguramientosItem in Detalle_Aseguramiento_Otros_AseguramientosInfo.Detalle_Aseguramiento_Otros_Aseguramientoss)
                            resultDetalle_Aseguramiento_Otros_Aseguramientos = resultDetalle_Aseguramiento_Otros_Aseguramientos
                                              && _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Delete(Detalle_Aseguramiento_Otros_AseguramientosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Otros_Aseguramientos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_Electronicos_y_MultimediaInfo =
                        _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_Electronicos_y_MultimediaInfo.Detalle_Aseguramiento_Electronicos_y_Multimedias.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Electronicos_y_Multimedia = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_Electronicos_y_MultimediaItem in Detalle_Aseguramiento_Electronicos_y_MultimediaInfo.Detalle_Aseguramiento_Electronicos_y_Multimedias)
                            resultDetalle_Aseguramiento_Electronicos_y_Multimedia = resultDetalle_Aseguramiento_Electronicos_y_Multimedia
                                              && _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.Delete(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Electronicos_y_Multimedia)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Pirateria.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Pirateria.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_PirateriaInfo =
                        _IDetalle_Aseguramiento_PirateriaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_PirateriaInfo.Detalle_Aseguramiento_Piraterias.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Pirateria = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_PirateriaItem in Detalle_Aseguramiento_PirateriaInfo.Detalle_Aseguramiento_Piraterias)
                            resultDetalle_Aseguramiento_Pirateria = resultDetalle_Aseguramiento_Pirateria
                                              && _IDetalle_Aseguramiento_PirateriaApiConsumer.Delete(Detalle_Aseguramiento_PirateriaItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Pirateria)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Inmuebles.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_InmueblesInfo =
                        _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_InmueblesInfo.Detalle_Aseguramiento_Inmuebless.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Inmuebles = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_InmueblesItem in Detalle_Aseguramiento_InmueblesInfo.Detalle_Aseguramiento_Inmuebless)
                            resultDetalle_Aseguramiento_Inmuebles = resultDetalle_Aseguramiento_Inmuebles
                                              && _IDetalle_Aseguramiento_InmueblesApiConsumer.Delete(Detalle_Aseguramiento_InmueblesItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Inmuebles)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_de_PlantiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_de_Plantios.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_de_PlantiosInfo =
                        _IDetalle_Aseguramiento_de_PlantiosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_de_PlantiosInfo.Detalle_Aseguramiento_de_Plantioss.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_de_Plantios = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_de_PlantiosItem in Detalle_Aseguramiento_de_PlantiosInfo.Detalle_Aseguramiento_de_Plantioss)
                            resultDetalle_Aseguramiento_de_Plantios = resultDetalle_Aseguramiento_de_Plantios
                                              && _IDetalle_Aseguramiento_de_PlantiosApiConsumer.Delete(Detalle_Aseguramiento_de_PlantiosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_de_Plantios)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_de_Pistas_de_AterrizajeInfo =
                        _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeInfo.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem in Detalle_Aseguramiento_de_Pistas_de_AterrizajeInfo.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes)
                            resultDetalle_Aseguramiento_de_Pistas_de_Aterrizaje = resultDetalle_Aseguramiento_de_Pistas_de_Aterrizaje
                                              && _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.Delete(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_de_Pistas_de_Aterrizaje)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Aseguramiento_Otros.Aseguramiento=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Aseguramiento_Otros.Aseguramiento='" + id + "'";
                    }
                    var Detalle_Aseguramiento_OtrosInfo =
                        _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Aseguramiento_OtrosInfo.Detalle_Aseguramiento_Otross.Count > 0)
                    {
                        var resultDetalle_Aseguramiento_Otros = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Aseguramiento_OtrosItem in Detalle_Aseguramiento_OtrosInfo.Detalle_Aseguramiento_Otross)
                            resultDetalle_Aseguramiento_Otros = resultDetalle_Aseguramiento_Otros
                                              && _IDetalle_Aseguramiento_OtrosApiConsumer.Delete(Detalle_Aseguramiento_OtrosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Aseguramiento_Otros)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IAseguramientosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, AseguramientosModel varAseguramientos)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var AseguramientosInfo = new Aseguramientos
                    {
                        Clave = varAseguramientos.Clave
                        ,Expediente = varAseguramientos.Expediente
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAseguramientos.Fecha_de_Registro)) ? DateTime.ParseExact(varAseguramientos.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAseguramientos.Hora_de_Registro
                        ,Usuario_que_Registra = varAseguramientos.Usuario_que_Registra

                    };

                    result = !IsNew ?
                        _IAseguramientosApiConsumer.Update(AseguramientosInfo, null, null).Resource.ToString() :
                         _IAseguramientosApiConsumer.Insert(AseguramientosInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Aseguramiento_Medios_de_Transporte(int MasterId, int referenceId, List<Detalle_Aseguramiento_Medios_de_TransporteGridModelPost> Detalle_Aseguramiento_Medios_de_TransporteItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Medios_de_TransporteData = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Medios_de_Transporte.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Medios_de_TransporteData == null || Detalle_Aseguramiento_Medios_de_TransporteData.Detalle_Aseguramiento_Medios_de_Transportes.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Medios_de_TransporteGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Medios_de_Transporte in Detalle_Aseguramiento_Medios_de_TransporteData.Detalle_Aseguramiento_Medios_de_Transportes)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Medios_de_Transporte Detalle_Aseguramiento_Medios_de_Transporte1 = varDetalle_Aseguramiento_Medios_de_Transporte;

                    if (Detalle_Aseguramiento_Medios_de_TransporteItems != null && Detalle_Aseguramiento_Medios_de_TransporteItems.Any(m => m.Clave == Detalle_Aseguramiento_Medios_de_Transporte1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Medios_de_TransporteItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Medios_de_Transporte1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Medios_de_Transporte.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Insert(varDetalle_Aseguramiento_Medios_de_Transporte,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Medios_de_Transporte(List<Detalle_Aseguramiento_Medios_de_TransporteGridModelPost> Detalle_Aseguramiento_Medios_de_TransporteItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Medios_de_Transporte(MasterId, referenceId, Detalle_Aseguramiento_Medios_de_TransporteItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Medios_de_TransporteItems != null && Detalle_Aseguramiento_Medios_de_TransporteItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Medios_de_TransporteItem in Detalle_Aseguramiento_Medios_de_TransporteItems)
                    {




















                        //Removal Request
                        if (Detalle_Aseguramiento_Medios_de_TransporteItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Delete(Detalle_Aseguramiento_Medios_de_TransporteItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Medios_de_TransporteItem.Clave = 0;

                        var Detalle_Aseguramiento_Medios_de_TransporteData = new Detalle_Aseguramiento_Medios_de_Transporte
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Medios_de_TransporteItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Tipo))
                            ,Especifique = Detalle_Aseguramiento_Medios_de_TransporteItem.Especifique
                            ,Marca = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Marca) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Marca))
                            ,Submarca = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Submarca) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Submarca))
                            ,Modelo = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Modelo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Modelo))
                            ,Placas = Detalle_Aseguramiento_Medios_de_TransporteItem.Placas
                            ,Color = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Color) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Color))
                            ,Numero_de_Motor = Detalle_Aseguramiento_Medios_de_TransporteItem.Numero_de_Motor
                            ,Serie = Detalle_Aseguramiento_Medios_de_TransporteItem.Serie
                            ,Uso = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Uso) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Uso))
                            ,Cap__De_Pasajeros = Detalle_Aseguramiento_Medios_de_TransporteItem.Cap__De_Pasajeros
                            ,Procedencia = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Procedencia) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Procedencia))
                            ,Empresa = Detalle_Aseguramiento_Medios_de_TransporteItem.Empresa
                            ,Capacidad_de_Carga = Detalle_Aseguramiento_Medios_de_TransporteItem.Capacidad_de_Carga
                            ,Origen = Detalle_Aseguramiento_Medios_de_TransporteItem.Origen
                            ,Destino = Detalle_Aseguramiento_Medios_de_TransporteItem.Destino
                            ,Observaciones = Detalle_Aseguramiento_Medios_de_TransporteItem.Observaciones
                            ,Detencion = (Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Detencion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Medios_de_TransporteItem.Detencion))

                        };

                        var resultId = Detalle_Aseguramiento_Medios_de_TransporteItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Update(Detalle_Aseguramiento_Medios_de_TransporteData,null,null).Resource
                           : _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Insert(Detalle_Aseguramiento_Medios_de_TransporteData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Tipo_de_medios_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_medios_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_medios_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_medios_de_transporte", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Marca_de_Medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Medio_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_de_Medio_de_transporte", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Submarca_de_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubmarca_de_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubmarca_de_medio_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Submarca_de_medio_de_transporte", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Modelo_de_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModelo_de_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModelo_de_medio_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modelo_de_medio_de_transporte", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Color_de_medio_de_trasporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_de_medio_de_trasporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_de_medio_de_trasporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Color_de_medio_de_trasporte", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Uso_del_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUso_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUso_del_medio_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Uso_del_medio_de_transporte", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_Procedencia_del_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_medio_de_transporteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Procedencia_del_medio_de_transporte", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Medios_de_Transporte_DetencionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetencionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detencion", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_de_Drogas_Involucradas(int MasterId, int referenceId, List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModelPost> Detalle_Aseguramiento_de_Drogas_InvolucradasItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_de_Drogas_InvolucradasData == null || Detalle_Aseguramiento_de_Drogas_InvolucradasData.Detalle_Aseguramiento_de_Drogas_Involucradass.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_de_Drogas_InvolucradasGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_de_Drogas_Involucradas in Detalle_Aseguramiento_de_Drogas_InvolucradasData.Detalle_Aseguramiento_de_Drogas_Involucradass)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_de_Drogas_Involucradas Detalle_Aseguramiento_de_Drogas_Involucradas1 = varDetalle_Aseguramiento_de_Drogas_Involucradas;

                    if (Detalle_Aseguramiento_de_Drogas_InvolucradasItems != null && Detalle_Aseguramiento_de_Drogas_InvolucradasItems.Any(m => m.Clave == Detalle_Aseguramiento_de_Drogas_Involucradas1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_de_Drogas_InvolucradasItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_de_Drogas_Involucradas1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_de_Drogas_Involucradas.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.Insert(varDetalle_Aseguramiento_de_Drogas_Involucradas,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_de_Drogas_Involucradas(List<Detalle_Aseguramiento_de_Drogas_InvolucradasGridModelPost> Detalle_Aseguramiento_de_Drogas_InvolucradasItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_de_Drogas_Involucradas(MasterId, referenceId, Detalle_Aseguramiento_de_Drogas_InvolucradasItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_de_Drogas_InvolucradasItems != null && Detalle_Aseguramiento_de_Drogas_InvolucradasItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_de_Drogas_InvolucradasItem in Detalle_Aseguramiento_de_Drogas_InvolucradasItems)
                    {






                        //Removal Request
                        if (Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.Delete(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Clave = 0;

                        var Detalle_Aseguramiento_de_Drogas_InvolucradasData = new Detalle_Aseguramiento_de_Drogas_Involucradas
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Tipo))
                            ,Unidad_de_Medida = (Convert.ToInt16(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Unidad_de_Medida) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Unidad_de_Medida))
                            ,Cantidad = Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Cantidad
                            ,Observaciones = Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_de_Drogas_InvolucradasItem.Clave > 0
                           ? _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.Update(Detalle_Aseguramiento_de_Drogas_InvolucradasData,null,null).Resource
                           : _IDetalle_Aseguramiento_de_Drogas_InvolucradasApiConsumer.Insert(Detalle_Aseguramiento_de_Drogas_InvolucradasData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_de_Drogas_Involucradas_Tipo_de_DrogaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DrogaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DrogaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Droga", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_de_Drogas_Involucradas_Unidad_de_medida_de_tipo_de_drogaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidad_de_medida_de_tipo_de_drogaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidad_de_medida_de_tipo_de_drogaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Unidad_de_medida_de_tipo_de_droga", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Armas_Involucradas(int MasterId, int referenceId, List<Detalle_Aseguramiento_Armas_InvolucradasGridModelPost> Detalle_Aseguramiento_Armas_InvolucradasItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Armas_InvolucradasData = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Armas_Involucradas.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Armas_InvolucradasData == null || Detalle_Aseguramiento_Armas_InvolucradasData.Detalle_Aseguramiento_Armas_Involucradass.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Armas_InvolucradasGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Armas_Involucradas in Detalle_Aseguramiento_Armas_InvolucradasData.Detalle_Aseguramiento_Armas_Involucradass)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Armas_Involucradas Detalle_Aseguramiento_Armas_Involucradas1 = varDetalle_Aseguramiento_Armas_Involucradas;

                    if (Detalle_Aseguramiento_Armas_InvolucradasItems != null && Detalle_Aseguramiento_Armas_InvolucradasItems.Any(m => m.Clave == Detalle_Aseguramiento_Armas_Involucradas1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Armas_InvolucradasItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Armas_Involucradas1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Armas_Involucradas.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Insert(varDetalle_Aseguramiento_Armas_Involucradas,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Armas_Involucradas(List<Detalle_Aseguramiento_Armas_InvolucradasGridModelPost> Detalle_Aseguramiento_Armas_InvolucradasItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Armas_Involucradas(MasterId, referenceId, Detalle_Aseguramiento_Armas_InvolucradasItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Armas_InvolucradasItems != null && Detalle_Aseguramiento_Armas_InvolucradasItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Armas_InvolucradasItem in Detalle_Aseguramiento_Armas_InvolucradasItems)
                    {













                        //Removal Request
                        if (Detalle_Aseguramiento_Armas_InvolucradasItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Delete(Detalle_Aseguramiento_Armas_InvolucradasItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Armas_InvolucradasItem.Clave = 0;

                        var Detalle_Aseguramiento_Armas_InvolucradasData = new Detalle_Aseguramiento_Armas_Involucradas
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Armas_InvolucradasItem.Clave
                            ,Tipo = (Convert.ToInt32(Detalle_Aseguramiento_Armas_InvolucradasItem.Tipo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_Armas_InvolucradasItem.Tipo))
                            ,Descripcion_del_Arma = Detalle_Aseguramiento_Armas_InvolucradasItem.Descripcion_del_Arma
                            ,Marca = (Convert.ToInt32(Detalle_Aseguramiento_Armas_InvolucradasItem.Marca) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_Armas_InvolucradasItem.Marca))
                            ,Calibre = (Convert.ToInt16(Detalle_Aseguramiento_Armas_InvolucradasItem.Calibre) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Armas_InvolucradasItem.Calibre))
                            ,Matricula = Detalle_Aseguramiento_Armas_InvolucradasItem.Matricula
                            ,Serie = Detalle_Aseguramiento_Armas_InvolucradasItem.Serie
                            ,Inventario = Detalle_Aseguramiento_Armas_InvolucradasItem.Inventario
                            ,Clasificacion = (Convert.ToInt16(Detalle_Aseguramiento_Armas_InvolucradasItem.Clasificacion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Armas_InvolucradasItem.Clasificacion))
                            ,Cantidad = Detalle_Aseguramiento_Armas_InvolucradasItem.Cantidad
                            ,Lugar_de_Hallazgo = Detalle_Aseguramiento_Armas_InvolucradasItem.Lugar_de_Hallazgo
                            ,Observaciones = Detalle_Aseguramiento_Armas_InvolucradasItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_Armas_InvolucradasItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Update(Detalle_Aseguramiento_Armas_InvolucradasData,null,null).Resource
                           : _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Insert(Detalle_Aseguramiento_Armas_InvolucradasData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Armas_Involucradas_Tipo_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ArmaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Arma", "Nombre");
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
        public ActionResult GetDetalle_Aseguramiento_Armas_Involucradas_Marca_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_ArmaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_de_Arma", "Nombre");
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
        public ActionResult GetDetalle_Aseguramiento_Armas_Involucradas_Calibre_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalibre_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalibre_de_ArmaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Calibre_de_Arma", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Armas_Involucradas_Clasificacion_de_Artefacto_y_ExplosivoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IClasificacion_de_Artefacto_y_ExplosivoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IClasificacion_de_Artefacto_y_ExplosivoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Clasificacion_de_Artefacto_y_Explosivo", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Artefactos_y_Explosivos(int MasterId, int referenceId, List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModelPost> Detalle_Aseguramiento_Artefactos_y_ExplosivosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Artefactos_y_ExplosivosData == null || Detalle_Aseguramiento_Artefactos_y_ExplosivosData.Detalle_Aseguramiento_Artefactos_y_Explosivoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Artefactos_y_Explosivos in Detalle_Aseguramiento_Artefactos_y_ExplosivosData.Detalle_Aseguramiento_Artefactos_y_Explosivoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Artefactos_y_Explosivos Detalle_Aseguramiento_Artefactos_y_Explosivos1 = varDetalle_Aseguramiento_Artefactos_y_Explosivos;

                    if (Detalle_Aseguramiento_Artefactos_y_ExplosivosItems != null && Detalle_Aseguramiento_Artefactos_y_ExplosivosItems.Any(m => m.Clave == Detalle_Aseguramiento_Artefactos_y_Explosivos1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Artefactos_y_ExplosivosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Artefactos_y_Explosivos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Artefactos_y_Explosivos.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.Insert(varDetalle_Aseguramiento_Artefactos_y_Explosivos,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Artefactos_y_Explosivos(List<Detalle_Aseguramiento_Artefactos_y_ExplosivosGridModelPost> Detalle_Aseguramiento_Artefactos_y_ExplosivosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Artefactos_y_Explosivos(MasterId, referenceId, Detalle_Aseguramiento_Artefactos_y_ExplosivosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Artefactos_y_ExplosivosItems != null && Detalle_Aseguramiento_Artefactos_y_ExplosivosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Artefactos_y_ExplosivosItem in Detalle_Aseguramiento_Artefactos_y_ExplosivosItems)
                    {







                        //Removal Request
                        if (Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.Delete(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clave = 0;

                        var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = new Detalle_Aseguramiento_Artefactos_y_Explosivos
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clave
                            ,Clasificacion = (Convert.ToInt32(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clasificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clasificacion))
                            ,Tipo = (Convert.ToInt32(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Tipo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Tipo))
                            ,Cantidad = Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Cantidad
                            ,Lugar_de_Hallazgo = Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Lugar_de_Hallazgo
                            ,Observaciones = Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_Artefactos_y_ExplosivosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.Update(Detalle_Aseguramiento_Artefactos_y_ExplosivosData,null,null).Resource
                           : _IDetalle_Aseguramiento_Artefactos_y_ExplosivosApiConsumer.Insert(Detalle_Aseguramiento_Artefactos_y_ExplosivosData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Tipo_ClasificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_ClasificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_ClasificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_Clasificacion", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Artefactos_y_Explosivos_Tipo_ArtefactoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_ArtefactoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_ArtefactoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_Artefacto", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_de_Cargador_Cartuchos(int MasterId, int referenceId, List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModelPost> Detalle_Aseguramiento_de_Cargador_CartuchosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_de_Cargador_CartuchosData = _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_de_Cargador_CartuchosData == null || Detalle_Aseguramiento_de_Cargador_CartuchosData.Detalle_Aseguramiento_de_Cargador_Cartuchoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_de_Cargador_CartuchosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_de_Cargador_Cartuchos in Detalle_Aseguramiento_de_Cargador_CartuchosData.Detalle_Aseguramiento_de_Cargador_Cartuchoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_de_Cargador_Cartuchos Detalle_Aseguramiento_de_Cargador_Cartuchos1 = varDetalle_Aseguramiento_de_Cargador_Cartuchos;

                    if (Detalle_Aseguramiento_de_Cargador_CartuchosItems != null && Detalle_Aseguramiento_de_Cargador_CartuchosItems.Any(m => m.Clave == Detalle_Aseguramiento_de_Cargador_Cartuchos1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_de_Cargador_CartuchosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_de_Cargador_Cartuchos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_de_Cargador_Cartuchos.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.Insert(varDetalle_Aseguramiento_de_Cargador_Cartuchos,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_de_Cargador_Cartuchos(List<Detalle_Aseguramiento_de_Cargador_CartuchosGridModelPost> Detalle_Aseguramiento_de_Cargador_CartuchosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_de_Cargador_Cartuchos(MasterId, referenceId, Detalle_Aseguramiento_de_Cargador_CartuchosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_de_Cargador_CartuchosItems != null && Detalle_Aseguramiento_de_Cargador_CartuchosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_de_Cargador_CartuchosItem in Detalle_Aseguramiento_de_Cargador_CartuchosItems)
                    {






                        //Removal Request
                        if (Detalle_Aseguramiento_de_Cargador_CartuchosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.Delete(Detalle_Aseguramiento_de_Cargador_CartuchosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_de_Cargador_CartuchosItem.Clave = 0;

                        var Detalle_Aseguramiento_de_Cargador_CartuchosData = new Detalle_Aseguramiento_de_Cargador_Cartuchos
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_de_Cargador_CartuchosItem.Clave
                            ,cartuchos_municiones = Detalle_Aseguramiento_de_Cargador_CartuchosItem.cartuchos_municiones
                            ,Cartuchos_Habiles = Detalle_Aseguramiento_de_Cargador_CartuchosItem.Cartuchos_Habiles
                            ,Cartuchos_Percutidos = Detalle_Aseguramiento_de_Cargador_CartuchosItem.Cartuchos_Percutidos
                            ,cargadores = Detalle_Aseguramiento_de_Cargador_CartuchosItem.cargadores

                        };

                        var resultId = Detalle_Aseguramiento_de_Cargador_CartuchosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.Update(Detalle_Aseguramiento_de_Cargador_CartuchosData,null,null).Resource
                           : _IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer.Insert(Detalle_Aseguramiento_de_Cargador_CartuchosData,null,null).Resource;

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
        public bool CopyDetalle_Aseguramiento_Objetos_Asegurados(int MasterId, int referenceId, List<Detalle_Aseguramiento_Objetos_AseguradosGridModelPost> Detalle_Aseguramiento_Objetos_AseguradosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Objetos_AseguradosData = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Objetos_Asegurados.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Objetos_AseguradosData == null || Detalle_Aseguramiento_Objetos_AseguradosData.Detalle_Aseguramiento_Objetos_Aseguradoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Objetos_AseguradosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Objetos_Asegurados in Detalle_Aseguramiento_Objetos_AseguradosData.Detalle_Aseguramiento_Objetos_Aseguradoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Objetos_Asegurados Detalle_Aseguramiento_Objetos_Asegurados1 = varDetalle_Aseguramiento_Objetos_Asegurados;

                    if (Detalle_Aseguramiento_Objetos_AseguradosItems != null && Detalle_Aseguramiento_Objetos_AseguradosItems.Any(m => m.Clave == Detalle_Aseguramiento_Objetos_Asegurados1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Objetos_AseguradosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Objetos_Asegurados1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Objetos_Asegurados.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Insert(varDetalle_Aseguramiento_Objetos_Asegurados,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Objetos_Asegurados(List<Detalle_Aseguramiento_Objetos_AseguradosGridModelPost> Detalle_Aseguramiento_Objetos_AseguradosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Objetos_Asegurados(MasterId, referenceId, Detalle_Aseguramiento_Objetos_AseguradosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Objetos_AseguradosItems != null && Detalle_Aseguramiento_Objetos_AseguradosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Objetos_AseguradosItem in Detalle_Aseguramiento_Objetos_AseguradosItems)
                    {







                        //Removal Request
                        if (Detalle_Aseguramiento_Objetos_AseguradosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Delete(Detalle_Aseguramiento_Objetos_AseguradosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Objetos_AseguradosItem.Clave = 0;

                        var Detalle_Aseguramiento_Objetos_AseguradosData = new Detalle_Aseguramiento_Objetos_Asegurados
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Objetos_AseguradosItem.Clave
                            ,Numero = Detalle_Aseguramiento_Objetos_AseguradosItem.Numero
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_Objetos_AseguradosItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Objetos_AseguradosItem.Tipo))
                            ,Marca = (Convert.ToInt16(Detalle_Aseguramiento_Objetos_AseguradosItem.Marca) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Objetos_AseguradosItem.Marca))
                            ,Serie = Detalle_Aseguramiento_Objetos_AseguradosItem.Serie
                            ,IMEI = Detalle_Aseguramiento_Objetos_AseguradosItem.IMEI

                        };

                        var resultId = Detalle_Aseguramiento_Objetos_AseguradosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Update(Detalle_Aseguramiento_Objetos_AseguradosData,null,null).Resource
                           : _IDetalle_Aseguramiento_Objetos_AseguradosApiConsumer.Insert(Detalle_Aseguramiento_Objetos_AseguradosData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Objetos_Asegurados_Tipo_de_Equipo_de_ComunicacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Equipo_de_ComunicacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Equipo_de_Comunicacion", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Objetos_Asegurados_Marca_de_Equipo_de_ComunicacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Equipo_de_ComunicacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Equipo_de_ComunicacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_de_Equipo_de_Comunicacion", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Documentos(int MasterId, int referenceId, List<Detalle_Aseguramiento_DocumentosGridModelPost> Detalle_Aseguramiento_DocumentosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_DocumentosData = _IDetalle_Aseguramiento_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Documentos.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_DocumentosData == null || Detalle_Aseguramiento_DocumentosData.Detalle_Aseguramiento_Documentoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_DocumentosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Documentos in Detalle_Aseguramiento_DocumentosData.Detalle_Aseguramiento_Documentoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Documentos Detalle_Aseguramiento_Documentos1 = varDetalle_Aseguramiento_Documentos;

                    if (Detalle_Aseguramiento_DocumentosItems != null && Detalle_Aseguramiento_DocumentosItems.Any(m => m.Clave == Detalle_Aseguramiento_Documentos1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_DocumentosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Documentos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Documentos.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_DocumentosApiConsumer.Insert(varDetalle_Aseguramiento_Documentos,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Documentos(List<Detalle_Aseguramiento_DocumentosGridModelPost> Detalle_Aseguramiento_DocumentosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Documentos(MasterId, referenceId, Detalle_Aseguramiento_DocumentosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_DocumentosItems != null && Detalle_Aseguramiento_DocumentosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_DocumentosItem in Detalle_Aseguramiento_DocumentosItems)
                    {






                        //Removal Request
                        if (Detalle_Aseguramiento_DocumentosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_DocumentosApiConsumer.Delete(Detalle_Aseguramiento_DocumentosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_DocumentosItem.Clave = 0;

                        var Detalle_Aseguramiento_DocumentosData = new Detalle_Aseguramiento_Documentos
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_DocumentosItem.Clave
                            ,Tipo = (Convert.ToInt32(Detalle_Aseguramiento_DocumentosItem.Tipo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_DocumentosItem.Tipo))
                            ,Cantidad = Detalle_Aseguramiento_DocumentosItem.Cantidad
                            ,Observaciones = Detalle_Aseguramiento_DocumentosItem.Observaciones
                            ,Descipcion_de_Documento = Detalle_Aseguramiento_DocumentosItem.Descipcion_de_Documento

                        };

                        var resultId = Detalle_Aseguramiento_DocumentosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_DocumentosApiConsumer.Update(Detalle_Aseguramiento_DocumentosData,null,null).Resource
                           : _IDetalle_Aseguramiento_DocumentosApiConsumer.Insert(Detalle_Aseguramiento_DocumentosData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Documentos_Tipo_de_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DocumentoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Documento", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Moneda(int MasterId, int referenceId, List<Detalle_Aseguramiento_MonedaGridModelPost> Detalle_Aseguramiento_MonedaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_MonedaData = _IDetalle_Aseguramiento_MonedaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Moneda.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_MonedaData == null || Detalle_Aseguramiento_MonedaData.Detalle_Aseguramiento_Monedas.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_MonedaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Moneda in Detalle_Aseguramiento_MonedaData.Detalle_Aseguramiento_Monedas)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Moneda Detalle_Aseguramiento_Moneda1 = varDetalle_Aseguramiento_Moneda;

                    if (Detalle_Aseguramiento_MonedaItems != null && Detalle_Aseguramiento_MonedaItems.Any(m => m.Clave == Detalle_Aseguramiento_Moneda1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_MonedaItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Moneda1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Moneda.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_MonedaApiConsumer.Insert(varDetalle_Aseguramiento_Moneda,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Moneda(List<Detalle_Aseguramiento_MonedaGridModelPost> Detalle_Aseguramiento_MonedaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Moneda(MasterId, referenceId, Detalle_Aseguramiento_MonedaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_MonedaItems != null && Detalle_Aseguramiento_MonedaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_MonedaItem in Detalle_Aseguramiento_MonedaItems)
                    {






                        //Removal Request
                        if (Detalle_Aseguramiento_MonedaItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_MonedaApiConsumer.Delete(Detalle_Aseguramiento_MonedaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_MonedaItem.Clave = 0;

                        var Detalle_Aseguramiento_MonedaData = new Detalle_Aseguramiento_Moneda
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_MonedaItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_MonedaItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_MonedaItem.Tipo))
                            ,Cantidad = Detalle_Aseguramiento_MonedaItem.Cantidad
                            ,Observaciones = Detalle_Aseguramiento_MonedaItem.Observaciones
                            ,Descripcion = (Convert.ToInt16(Detalle_Aseguramiento_MonedaItem.Descripcion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_MonedaItem.Descripcion))

                        };

                        var resultId = Detalle_Aseguramiento_MonedaItem.Clave > 0
                           ? _IDetalle_Aseguramiento_MonedaApiConsumer.Update(Detalle_Aseguramiento_MonedaData,null,null).Resource
                           : _IDetalle_Aseguramiento_MonedaApiConsumer.Insert(Detalle_Aseguramiento_MonedaData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Moneda_Tipo_de_MonedaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_MonedaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_MonedaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Moneda", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Moneda_Tipo_de_DineroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DineroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DineroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Dinero", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Otros_Aseguramientos(int MasterId, int referenceId, List<Detalle_Aseguramiento_Otros_AseguramientosGridModelPost> Detalle_Aseguramiento_Otros_AseguramientosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Otros_AseguramientosData = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Otros_AseguramientosData == null || Detalle_Aseguramiento_Otros_AseguramientosData.Detalle_Aseguramiento_Otros_Aseguramientoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Otros_AseguramientosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Otros_Aseguramientos in Detalle_Aseguramiento_Otros_AseguramientosData.Detalle_Aseguramiento_Otros_Aseguramientoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Otros_Aseguramientos Detalle_Aseguramiento_Otros_Aseguramientos1 = varDetalle_Aseguramiento_Otros_Aseguramientos;

                    if (Detalle_Aseguramiento_Otros_AseguramientosItems != null && Detalle_Aseguramiento_Otros_AseguramientosItems.Any(m => m.Clave == Detalle_Aseguramiento_Otros_Aseguramientos1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Otros_AseguramientosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Otros_Aseguramientos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Otros_Aseguramientos.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Insert(varDetalle_Aseguramiento_Otros_Aseguramientos,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Otros_Aseguramientos(List<Detalle_Aseguramiento_Otros_AseguramientosGridModelPost> Detalle_Aseguramiento_Otros_AseguramientosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Otros_Aseguramientos(MasterId, referenceId, Detalle_Aseguramiento_Otros_AseguramientosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Otros_AseguramientosItems != null && Detalle_Aseguramiento_Otros_AseguramientosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Otros_AseguramientosItem in Detalle_Aseguramiento_Otros_AseguramientosItems)
                    {










                        //Removal Request
                        if (Detalle_Aseguramiento_Otros_AseguramientosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Delete(Detalle_Aseguramiento_Otros_AseguramientosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Otros_AseguramientosItem.Clave = 0;

                        var Detalle_Aseguramiento_Otros_AseguramientosData = new Detalle_Aseguramiento_Otros_Aseguramientos
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Otros_AseguramientosItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Tipo))
                            ,Marca = (Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Marca) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Marca))
                            ,Modelo = (Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Modelo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Modelo))
                            ,Inventario = Detalle_Aseguramiento_Otros_AseguramientosItem.Inventario
                            ,Serie = Detalle_Aseguramiento_Otros_AseguramientosItem.Serie
                            ,Unidad_de_Medida = (Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Unidad_de_Medida) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Otros_AseguramientosItem.Unidad_de_Medida))
                            ,Cantidad = Detalle_Aseguramiento_Otros_AseguramientosItem.Cantidad
                            ,Observaciones = Detalle_Aseguramiento_Otros_AseguramientosItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_Otros_AseguramientosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Update(Detalle_Aseguramiento_Otros_AseguramientosData,null,null).Resource
                           : _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Insert(Detalle_Aseguramiento_Otros_AseguramientosData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Otros_Aseguramientos_Tipo_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Equipo_Tactico", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Otros_Aseguramientos_Marca_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_de_Equipo_Tactico", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Otros_Aseguramientos_Modelo_de_equipo_tacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModelo_de_equipo_tacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModelo_de_equipo_tacticoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modelo_de_equipo_tactico", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Otros_Aseguramientos_Unidad_de_Medida_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Unidad_de_Medida_de_Equipo_Tactico", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Electronicos_y_Multimedia(int MasterId, int referenceId, List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModelPost> Detalle_Aseguramiento_Electronicos_y_MultimediaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_Electronicos_y_MultimediaData == null || Detalle_Aseguramiento_Electronicos_y_MultimediaData.Detalle_Aseguramiento_Electronicos_y_Multimedias.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_Electronicos_y_MultimediaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Electronicos_y_Multimedia in Detalle_Aseguramiento_Electronicos_y_MultimediaData.Detalle_Aseguramiento_Electronicos_y_Multimedias)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Electronicos_y_Multimedia Detalle_Aseguramiento_Electronicos_y_Multimedia1 = varDetalle_Aseguramiento_Electronicos_y_Multimedia;

                    if (Detalle_Aseguramiento_Electronicos_y_MultimediaItems != null && Detalle_Aseguramiento_Electronicos_y_MultimediaItems.Any(m => m.Clave == Detalle_Aseguramiento_Electronicos_y_Multimedia1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_Electronicos_y_MultimediaItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Electronicos_y_Multimedia1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Electronicos_y_Multimedia.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.Insert(varDetalle_Aseguramiento_Electronicos_y_Multimedia,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Electronicos_y_Multimedia(List<Detalle_Aseguramiento_Electronicos_y_MultimediaGridModelPost> Detalle_Aseguramiento_Electronicos_y_MultimediaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Electronicos_y_Multimedia(MasterId, referenceId, Detalle_Aseguramiento_Electronicos_y_MultimediaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_Electronicos_y_MultimediaItems != null && Detalle_Aseguramiento_Electronicos_y_MultimediaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_Electronicos_y_MultimediaItem in Detalle_Aseguramiento_Electronicos_y_MultimediaItems)
                    {







                        //Removal Request
                        if (Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.Delete(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Clave = 0;

                        var Detalle_Aseguramiento_Electronicos_y_MultimediaData = new Detalle_Aseguramiento_Electronicos_y_Multimedia
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Clave
                            ,Aparatos = (Convert.ToInt16(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Aparatos) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Aparatos))
                            ,Documentos_Multimedia = (Convert.ToInt16(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Documentos_Multimedia) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Documentos_Multimedia))
                            ,Descripcion = Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Descripcion
                            ,Cantidad = Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Cantidad
                            ,A_resguardo = Detalle_Aseguramiento_Electronicos_y_MultimediaItem.A_resguardo

                        };

                        var resultId = Detalle_Aseguramiento_Electronicos_y_MultimediaItem.Clave > 0
                           ? _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.Update(Detalle_Aseguramiento_Electronicos_y_MultimediaData,null,null).Resource
                           : _IDetalle_Aseguramiento_Electronicos_y_MultimediaApiConsumer.Insert(Detalle_Aseguramiento_Electronicos_y_MultimediaData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Aparato_Electronicos_y_MultimediaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAparato_Electronicos_y_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAparato_Electronicos_y_MultimediaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Aparato_Electronicos_y_Multimedia", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Electronicos_y_Multimedia_Documentos_MultimediaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentos_MultimediaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentos_MultimediaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documentos_Multimedia", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Pirateria(int MasterId, int referenceId, List<Detalle_Aseguramiento_PirateriaGridModelPost> Detalle_Aseguramiento_PirateriaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_PirateriaData = _IDetalle_Aseguramiento_PirateriaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Pirateria.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_PirateriaData == null || Detalle_Aseguramiento_PirateriaData.Detalle_Aseguramiento_Piraterias.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_PirateriaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Pirateria in Detalle_Aseguramiento_PirateriaData.Detalle_Aseguramiento_Piraterias)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Pirateria Detalle_Aseguramiento_Pirateria1 = varDetalle_Aseguramiento_Pirateria;

                    if (Detalle_Aseguramiento_PirateriaItems != null && Detalle_Aseguramiento_PirateriaItems.Any(m => m.Clave == Detalle_Aseguramiento_Pirateria1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_PirateriaItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Pirateria1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Pirateria.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_PirateriaApiConsumer.Insert(varDetalle_Aseguramiento_Pirateria,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Pirateria(List<Detalle_Aseguramiento_PirateriaGridModelPost> Detalle_Aseguramiento_PirateriaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Pirateria(MasterId, referenceId, Detalle_Aseguramiento_PirateriaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_PirateriaItems != null && Detalle_Aseguramiento_PirateriaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_PirateriaItem in Detalle_Aseguramiento_PirateriaItems)
                    {







                        //Removal Request
                        if (Detalle_Aseguramiento_PirateriaItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_PirateriaApiConsumer.Delete(Detalle_Aseguramiento_PirateriaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_PirateriaItem.Clave = 0;

                        var Detalle_Aseguramiento_PirateriaData = new Detalle_Aseguramiento_Pirateria
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_PirateriaItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_PirateriaItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_PirateriaItem.Tipo))
                            ,Descripcion = Detalle_Aseguramiento_PirateriaItem.Descripcion
                            ,Cantidad = Detalle_Aseguramiento_PirateriaItem.Cantidad
                            ,Unidad_de_Medicion = (Convert.ToInt16(Detalle_Aseguramiento_PirateriaItem.Unidad_de_Medicion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_PirateriaItem.Unidad_de_Medicion))
                            ,Observaciones = Detalle_Aseguramiento_PirateriaItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_PirateriaItem.Clave > 0
                           ? _IDetalle_Aseguramiento_PirateriaApiConsumer.Update(Detalle_Aseguramiento_PirateriaData,null,null).Resource
                           : _IDetalle_Aseguramiento_PirateriaApiConsumer.Insert(Detalle_Aseguramiento_PirateriaData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Pirateria_Tipo_de_PirateriaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_PirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_PirateriaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Pirateria", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Pirateria_Unidad_de_Medida_de_pirateriaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidad_de_Medida_de_pirateriaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidad_de_Medida_de_pirateriaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Unidad_de_Medida_de_pirateria", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Inmuebles(int MasterId, int referenceId, List<Detalle_Aseguramiento_InmueblesGridModelPost> Detalle_Aseguramiento_InmueblesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_InmueblesData = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Inmuebles.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_InmueblesData == null || Detalle_Aseguramiento_InmueblesData.Detalle_Aseguramiento_Inmuebless.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_InmueblesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Inmuebles in Detalle_Aseguramiento_InmueblesData.Detalle_Aseguramiento_Inmuebless)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Inmuebles Detalle_Aseguramiento_Inmuebles1 = varDetalle_Aseguramiento_Inmuebles;

                    if (Detalle_Aseguramiento_InmueblesItems != null && Detalle_Aseguramiento_InmueblesItems.Any(m => m.Clave == Detalle_Aseguramiento_Inmuebles1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_InmueblesItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Inmuebles1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Inmuebles.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_InmueblesApiConsumer.Insert(varDetalle_Aseguramiento_Inmuebles,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Inmuebles(List<Detalle_Aseguramiento_InmueblesGridModelPost> Detalle_Aseguramiento_InmueblesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Inmuebles(MasterId, referenceId, Detalle_Aseguramiento_InmueblesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_InmueblesItems != null && Detalle_Aseguramiento_InmueblesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_InmueblesItem in Detalle_Aseguramiento_InmueblesItems)
                    {

















                        //Removal Request
                        if (Detalle_Aseguramiento_InmueblesItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_InmueblesApiConsumer.Delete(Detalle_Aseguramiento_InmueblesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_InmueblesItem.Clave = 0;

                        var Detalle_Aseguramiento_InmueblesData = new Detalle_Aseguramiento_Inmuebles
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_InmueblesItem.Clave
                            ,Zona = (Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Zona) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Zona))
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Tipo))
                            ,Terreno = (Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Terreno) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_InmueblesItem.Terreno))
                            ,Especifique_Otro = Detalle_Aseguramiento_InmueblesItem.Especifique_Otro
                            ,Calle = Detalle_Aseguramiento_InmueblesItem.Calle
                            ,Exterior = Detalle_Aseguramiento_InmueblesItem.Exterior
                            ,Interior = Detalle_Aseguramiento_InmueblesItem.Interior
                            ,C_P = Detalle_Aseguramiento_InmueblesItem.C_P
                            ,Estado = (Convert.ToInt32(Detalle_Aseguramiento_InmueblesItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_InmueblesItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_Aseguramiento_InmueblesItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_InmueblesItem.Municipio))
                            ,Colonia = Detalle_Aseguramiento_InmueblesItem.Colonia
                            ,Registro_Publico_Propiedad = Detalle_Aseguramiento_InmueblesItem.Registro_Publico_Propiedad
                            ,Entrecalles = Detalle_Aseguramiento_InmueblesItem.Entrecalles
                            ,Propietario = Detalle_Aseguramiento_InmueblesItem.Propietario
                            ,Observaciones = Detalle_Aseguramiento_InmueblesItem.Observaciones

                        };

                        var resultId = Detalle_Aseguramiento_InmueblesItem.Clave > 0
                           ? _IDetalle_Aseguramiento_InmueblesApiConsumer.Update(Detalle_Aseguramiento_InmueblesData,null,null).Resource
                           : _IDetalle_Aseguramiento_InmueblesApiConsumer.Insert(Detalle_Aseguramiento_InmueblesData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_Inmuebles_Tipo_de_ZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ZonaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Zona", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Inmuebles_Tipo_de_InmuebleAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InmuebleApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InmuebleApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Inmueble", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Inmuebles_Terreno_de_InmueblesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITerreno_de_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITerreno_de_InmueblesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Terreno_de_Inmuebles", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_Inmuebles_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Aseguramiento_Inmuebles_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_Aseguramiento_de_Plantios(int MasterId, int referenceId, List<Detalle_Aseguramiento_de_PlantiosGridModelPost> Detalle_Aseguramiento_de_PlantiosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_de_PlantiosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_de_PlantiosData = _IDetalle_Aseguramiento_de_PlantiosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_de_Plantios.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_de_PlantiosData == null || Detalle_Aseguramiento_de_PlantiosData.Detalle_Aseguramiento_de_Plantioss.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_de_PlantiosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_de_Plantios in Detalle_Aseguramiento_de_PlantiosData.Detalle_Aseguramiento_de_Plantioss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_de_Plantios Detalle_Aseguramiento_de_Plantios1 = varDetalle_Aseguramiento_de_Plantios;

                    if (Detalle_Aseguramiento_de_PlantiosItems != null && Detalle_Aseguramiento_de_PlantiosItems.Any(m => m.Clave == Detalle_Aseguramiento_de_Plantios1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_de_PlantiosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_de_Plantios1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_de_Plantios.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_de_PlantiosApiConsumer.Insert(varDetalle_Aseguramiento_de_Plantios,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_de_Plantios(List<Detalle_Aseguramiento_de_PlantiosGridModelPost> Detalle_Aseguramiento_de_PlantiosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_de_Plantios(MasterId, referenceId, Detalle_Aseguramiento_de_PlantiosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_de_PlantiosItems != null && Detalle_Aseguramiento_de_PlantiosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_de_PlantiosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_de_PlantiosItem in Detalle_Aseguramiento_de_PlantiosItems)
                    {














                        //Removal Request
                        if (Detalle_Aseguramiento_de_PlantiosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_de_PlantiosApiConsumer.Delete(Detalle_Aseguramiento_de_PlantiosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_de_PlantiosItem.Clave = 0;

                        var Detalle_Aseguramiento_de_PlantiosData = new Detalle_Aseguramiento_de_Plantios
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_de_PlantiosItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_de_PlantiosItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_de_PlantiosItem.Tipo))
                            ,No__de_Plantios = Detalle_Aseguramiento_de_PlantiosItem.No__de_Plantios
                            ,Kilogramos = Detalle_Aseguramiento_de_PlantiosItem.Kilogramos
                            ,Metodo_de_Destruccion = (Convert.ToInt16(Detalle_Aseguramiento_de_PlantiosItem.Metodo_de_Destruccion) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_de_PlantiosItem.Metodo_de_Destruccion))
                            ,Superficie = Detalle_Aseguramiento_de_PlantiosItem.Superficie
                            ,Altura = Detalle_Aseguramiento_de_PlantiosItem.Altura
                            ,Densidad = Detalle_Aseguramiento_de_PlantiosItem.Densidad
                            ,Peso_por_planta = Detalle_Aseguramiento_de_PlantiosItem.Peso_por_planta
                            ,Latitud = Detalle_Aseguramiento_de_PlantiosItem.Latitud
                            ,Longitud = Detalle_Aseguramiento_de_PlantiosItem.Longitud
                            ,Largo = Detalle_Aseguramiento_de_PlantiosItem.Largo
                            ,Ancho = Detalle_Aseguramiento_de_PlantiosItem.Ancho

                        };

                        var resultId = Detalle_Aseguramiento_de_PlantiosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_de_PlantiosApiConsumer.Update(Detalle_Aseguramiento_de_PlantiosData,null,null).Resource
                           : _IDetalle_Aseguramiento_de_PlantiosApiConsumer.Insert(Detalle_Aseguramiento_de_PlantiosData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_de_Plantios_Tipo_de_PlantioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_PlantioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_PlantioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Plantio", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_de_Plantios_Metodo_de_DestruccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMetodo_de_DestruccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMetodo_de_DestruccionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Metodo_de_Destruccion", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(int MasterId, int referenceId, List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModelPost> Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeData == null || Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_de_Pistas_de_Aterrizaje in Detalle_Aseguramiento_de_Pistas_de_AterrizajeData.Detalle_Aseguramiento_de_Pistas_de_Aterrizajes)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_de_Pistas_de_Aterrizaje Detalle_Aseguramiento_de_Pistas_de_Aterrizaje1 = varDetalle_Aseguramiento_de_Pistas_de_Aterrizaje;

                    if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems != null && Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems.Any(m => m.Clave == Detalle_Aseguramiento_de_Pistas_de_Aterrizaje1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_de_Pistas_de_Aterrizaje1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_de_Pistas_de_Aterrizaje.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.Insert(varDetalle_Aseguramiento_de_Pistas_de_Aterrizaje,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(List<Detalle_Aseguramiento_de_Pistas_de_AterrizajeGridModelPost> Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(MasterId, referenceId, Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems != null && Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem in Detalle_Aseguramiento_de_Pistas_de_AterrizajeItems)
                    {













                        //Removal Request
                        if (Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.Delete(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Clave = 0;

                        var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = new Detalle_Aseguramiento_de_Pistas_de_Aterrizaje
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Clave
                            ,Tipo = (Convert.ToInt16(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Tipo) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Tipo))
                            ,Suelo = (Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Suelo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Suelo))
                            ,Descripcion = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Descripcion
                            ,Localizacion_1 = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Localizacion_1
                            ,Localizacion_2 = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Localizacion_2
                            ,Latitud = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Latitud
                            ,Longitud = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Longitud
                            ,Orientacion_de = (Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Orientacion_de) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Orientacion_de))
                            ,Orientacion = (Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Orientacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Orientacion))
                            ,Largo = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Largo
                            ,Ancho = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Ancho

                        };

                        var resultId = Detalle_Aseguramiento_de_Pistas_de_AterrizajeItem.Clave > 0
                           ? _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.Update(Detalle_Aseguramiento_de_Pistas_de_AterrizajeData,null,null).Resource
                           : _IDetalle_Aseguramiento_de_Pistas_de_AterrizajeApiConsumer.Insert(Detalle_Aseguramiento_de_Pistas_de_AterrizajeData,null,null).Resource;

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
        public ActionResult GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_Pista_de_AterrizajeAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Pista_de_AterrizajeApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Pista_de_AterrizajeApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Pista_de_Aterrizaje", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_SueloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_SueloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_SueloApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Suelo", "Descripcion");
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
        public ActionResult GetDetalle_Aseguramiento_de_Pistas_de_Aterrizaje_Tipo_de_OrientacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_OrientacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_OrientacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Orientacion", "Descripcion");
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
        public bool CopyDetalle_Aseguramiento_Otros(int MasterId, int referenceId, List<Detalle_Aseguramiento_OtrosGridModelPost> Detalle_Aseguramiento_OtrosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Aseguramiento_OtrosData = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Aseguramiento_Otros.Aseguramiento=" + referenceId,"").Resource;
                if (Detalle_Aseguramiento_OtrosData == null || Detalle_Aseguramiento_OtrosData.Detalle_Aseguramiento_Otross.Count == 0)
                    return true;

                var result = true;

                Detalle_Aseguramiento_OtrosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Aseguramiento_Otros in Detalle_Aseguramiento_OtrosData.Detalle_Aseguramiento_Otross)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Aseguramiento_Otros Detalle_Aseguramiento_Otros1 = varDetalle_Aseguramiento_Otros;

                    if (Detalle_Aseguramiento_OtrosItems != null && Detalle_Aseguramiento_OtrosItems.Any(m => m.Clave == Detalle_Aseguramiento_Otros1.Clave))
                    {
                        modelDataToChange = Detalle_Aseguramiento_OtrosItems.FirstOrDefault(m => m.Clave == Detalle_Aseguramiento_Otros1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Aseguramiento_Otros.Aseguramiento = MasterId;
                    var insertId = _IDetalle_Aseguramiento_OtrosApiConsumer.Insert(varDetalle_Aseguramiento_Otros,null,null).Resource;
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
        public ActionResult PostDetalle_Aseguramiento_Otros(List<Detalle_Aseguramiento_OtrosGridModelPost> Detalle_Aseguramiento_OtrosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Aseguramiento_Otros(MasterId, referenceId, Detalle_Aseguramiento_OtrosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Aseguramiento_OtrosItems != null && Detalle_Aseguramiento_OtrosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Aseguramiento_OtrosItem in Detalle_Aseguramiento_OtrosItems)
                    {






                        //Removal Request
                        if (Detalle_Aseguramiento_OtrosItem.Removed)
                        {
                            result = result && _IDetalle_Aseguramiento_OtrosApiConsumer.Delete(Detalle_Aseguramiento_OtrosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Aseguramiento_OtrosItem.Clave = 0;

                        var Detalle_Aseguramiento_OtrosData = new Detalle_Aseguramiento_Otros
                        {
                            Aseguramiento = MasterId
                            ,Clave = Detalle_Aseguramiento_OtrosItem.Clave
                            ,Tipo = Detalle_Aseguramiento_OtrosItem.Tipo
                            ,Unidad_de_medida = Detalle_Aseguramiento_OtrosItem.Unidad_de_medida
                            ,Cantidad = Detalle_Aseguramiento_OtrosItem.Cantidad
                            ,Descripcion = Detalle_Aseguramiento_OtrosItem.Descripcion

                        };

                        var resultId = Detalle_Aseguramiento_OtrosItem.Clave > 0
                           ? _IDetalle_Aseguramiento_OtrosApiConsumer.Update(Detalle_Aseguramiento_OtrosData,null,null).Resource
                           : _IDetalle_Aseguramiento_OtrosApiConsumer.Insert(Detalle_Aseguramiento_OtrosData,null,null).Resource;

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









        /// <summary>
        /// Write Element Array of Aseguramientos script
        /// </summary>
        /// <param name="oAseguramientosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew AseguramientosModuleAttributeList)
        {
            for (int i = 0; i < AseguramientosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(AseguramientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    AseguramientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(AseguramientosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    AseguramientosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (AseguramientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < AseguramientosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < AseguramientosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(AseguramientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							AseguramientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(AseguramientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							AseguramientosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAseguramientosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Aseguramientos.js")))
            {
                strAseguramientosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Aseguramientos element attributes
            string userChangeJson = jsSerialize.Serialize(AseguramientosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAseguramientosScript.IndexOf("inpuElementArray");
            string splittedString = strAseguramientosScript.Substring(indexOfArray, strAseguramientosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(AseguramientosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (AseguramientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAseguramientosScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAseguramientosScript.Substring(indexOfArrayHistory, strAseguramientosScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAseguramientosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAseguramientosScript.Substring(endIndexOfMainElement + indexOfArray, strAseguramientosScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (AseguramientosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in AseguramientosModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Aseguramientos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Aseguramientos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Aseguramientos.js")))
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
        public ActionResult AseguramientosPropertyBag()
        {
            return PartialView("AseguramientosPropertyBag", "Aseguramientos");
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
        public ActionResult AddDetalle_Aseguramiento_Medios_de_Transporte(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Medios_de_Transporte/AddDetalle_Aseguramiento_Medios_de_Transporte");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_de_Drogas_Involucradas(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_de_Drogas_Involucradas/AddDetalle_Aseguramiento_de_Drogas_Involucradas");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Armas_Involucradas(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Armas_Involucradas/AddDetalle_Aseguramiento_Armas_Involucradas");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Artefactos_y_Explosivos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Artefactos_y_Explosivos/AddDetalle_Aseguramiento_Artefactos_y_Explosivos");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_de_Cargador_Cartuchos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_de_Cargador_Cartuchos/AddDetalle_Aseguramiento_de_Cargador_Cartuchos");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Objetos_Asegurados(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Objetos_Asegurados/AddDetalle_Aseguramiento_Objetos_Asegurados");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Documentos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Documentos/AddDetalle_Aseguramiento_Documentos");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Moneda(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Moneda/AddDetalle_Aseguramiento_Moneda");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Otros_Aseguramientos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Otros_Aseguramientos/AddDetalle_Aseguramiento_Otros_Aseguramientos");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Electronicos_y_Multimedia(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Electronicos_y_Multimedia/AddDetalle_Aseguramiento_Electronicos_y_Multimedia");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Pirateria(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Pirateria/AddDetalle_Aseguramiento_Pirateria");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Inmuebles(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Inmuebles/AddDetalle_Aseguramiento_Inmuebles");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_de_Plantios(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_de_Plantios/AddDetalle_Aseguramiento_de_Plantios");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_de_Pistas_de_Aterrizaje(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_de_Pistas_de_Aterrizaje/AddDetalle_Aseguramiento_de_Pistas_de_Aterrizaje");
        }

        [HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Otros(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Aseguramiento_Otros/AddDetalle_Aseguramiento_Otros");
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
                var whereClauseFormat = "Object = 45488 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Aseguramientos.Clave= " + RecordId;
                            var result = _IAseguramientosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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
										  
			string[] arrayColumnsVisible = ((string[])columnsVisible)[0].ToString().Split(',');

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new AseguramientosPropertyMapper());
			
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
                    (AseguramientosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            AseguramientosPropertyMapper oAseguramientosPropertyMapper = new AseguramientosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAseguramientosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Aseguramientoss == null)
                result.Aseguramientoss = new List<Aseguramientos>();

            var data = result.Aseguramientoss.Select(m => new AseguramientosGridModel
            {
                Clave = m.Clave
                        ,Expedientenic = CultureHelper.GetTraduction(m.Expediente_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45488, arrayColumnsVisible), "AseguramientosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45488, arrayColumnsVisible), "AseguramientosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45488, arrayColumnsVisible), "AseguramientosList_" + DateTime.Now.ToString());
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

            _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new AseguramientosPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (AseguramientosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            AseguramientosPropertyMapper oAseguramientosPropertyMapper = new AseguramientosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAseguramientosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Aseguramientoss == null)
                result.Aseguramientoss = new List<Aseguramientos>();

            var data = result.Aseguramientoss.Select(m => new AseguramientosGridModel
            {
                Clave = m.Clave
                        ,Expedientenic = CultureHelper.GetTraduction(m.Expediente_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

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
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguramientosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Aseguramientos_Datos_GeneralesModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Datos_GeneralesInfo = new Aseguramientos_Datos_Generales
                {
                    Clave = varAseguramientos.Clave
                                            ,Expediente = varAseguramientos.Expediente
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAseguramientos.Fecha_de_Registro)) ? DateTime.ParseExact(varAseguramientos.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAseguramientos.Hora_de_Registro
                        ,Usuario_que_Registra = varAseguramientos.Usuario_que_Registra
                    
                };

                result = _IAseguramientosApiConsumer.Update_Datos_Generales(Aseguramientos_Datos_GeneralesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_Generales(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente = m.Expediente
                        ,Expedientenic = CultureHelper.GetTraduction(m.Expediente_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Medios_de_Transporte_Involucrados(Aseguramientos_Medios_de_Transporte_InvolucradosModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Medios_de_Transporte_InvolucradosInfo = new Aseguramientos_Medios_de_Transporte_Involucrados
                {
                    Clave = varAseguramientos.Clave
                                        
                };

                result = _IAseguramientosApiConsumer.Update_Medios_de_Transporte_Involucrados(Aseguramientos_Medios_de_Transporte_InvolucradosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Medios_de_Transporte_Involucrados(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Medios_de_Transporte_Involucrados(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Medios_de_Transporte_InvolucradosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Drogas_Involucradas(Aseguramientos_Drogas_InvolucradasModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Drogas_InvolucradasInfo = new Aseguramientos_Drogas_Involucradas
                {
                    Clave = varAseguramientos.Clave
                                        
                };

                result = _IAseguramientosApiConsumer.Update_Drogas_Involucradas(Aseguramientos_Drogas_InvolucradasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Drogas_Involucradas(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Drogas_Involucradas(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Drogas_InvolucradasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Armas_Involucradas(Aseguramientos_Armas_InvolucradasModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Armas_InvolucradasInfo = new Aseguramientos_Armas_Involucradas
                {
                    Clave = varAseguramientos.Clave
                                        
                };

                result = _IAseguramientosApiConsumer.Update_Armas_Involucradas(Aseguramientos_Armas_InvolucradasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Armas_Involucradas(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Armas_Involucradas(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Armas_InvolucradasModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Objetos_Asegurados(Aseguramientos_Objetos_AseguradosModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Objetos_AseguradosInfo = new Aseguramientos_Objetos_Asegurados
                {
                    Clave = varAseguramientos.Clave
                                        
                };

                result = _IAseguramientosApiConsumer.Update_Objetos_Asegurados(Aseguramientos_Objetos_AseguradosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Objetos_Asegurados(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Objetos_Asegurados(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Objetos_AseguradosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Otros_Aseguramientos(Aseguramientos_Otros_AseguramientosModel varAseguramientos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Aseguramientos_Otros_AseguramientosInfo = new Aseguramientos_Otros_Aseguramientos
                {
                    Clave = varAseguramientos.Clave
                                        
                };

                result = _IAseguramientosApiConsumer.Update_Otros_Aseguramientos(Aseguramientos_Otros_AseguramientosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Otros_Aseguramientos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAseguramientosApiConsumer.Get_Otros_Aseguramientos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Aseguramiento_Medios_de_Transporte;
                var Detalle_Aseguramiento_Medios_de_TransporteData = GetDetalle_Aseguramiento_Medios_de_TransporteData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Medios_de_Transporte);
                int RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas;
                var Detalle_Aseguramiento_de_Drogas_InvolucradasData = GetDetalle_Aseguramiento_de_Drogas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Drogas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Armas_Involucradas;
                var Detalle_Aseguramiento_Armas_InvolucradasData = GetDetalle_Aseguramiento_Armas_InvolucradasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Armas_Involucradas);
                int RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos;
                var Detalle_Aseguramiento_Artefactos_y_ExplosivosData = GetDetalle_Aseguramiento_Artefactos_y_ExplosivosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Artefactos_y_Explosivos);
                int RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos;
                var Detalle_Aseguramiento_de_Cargador_CartuchosData = GetDetalle_Aseguramiento_de_Cargador_CartuchosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Cargador_Cartuchos);
                int RowCount_Detalle_Aseguramiento_Objetos_Asegurados;
                var Detalle_Aseguramiento_Objetos_AseguradosData = GetDetalle_Aseguramiento_Objetos_AseguradosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Objetos_Asegurados);
                int RowCount_Detalle_Aseguramiento_Documentos;
                var Detalle_Aseguramiento_DocumentosData = GetDetalle_Aseguramiento_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Documentos);
                int RowCount_Detalle_Aseguramiento_Moneda;
                var Detalle_Aseguramiento_MonedaData = GetDetalle_Aseguramiento_MonedaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Moneda);
                int RowCount_Detalle_Aseguramiento_Otros_Aseguramientos;
                var Detalle_Aseguramiento_Otros_AseguramientosData = GetDetalle_Aseguramiento_Otros_AseguramientosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros_Aseguramientos);
                int RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia;
                var Detalle_Aseguramiento_Electronicos_y_MultimediaData = GetDetalle_Aseguramiento_Electronicos_y_MultimediaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Electronicos_y_Multimedia);
                int RowCount_Detalle_Aseguramiento_Pirateria;
                var Detalle_Aseguramiento_PirateriaData = GetDetalle_Aseguramiento_PirateriaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Pirateria);
                int RowCount_Detalle_Aseguramiento_Inmuebles;
                var Detalle_Aseguramiento_InmueblesData = GetDetalle_Aseguramiento_InmueblesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Inmuebles);
                int RowCount_Detalle_Aseguramiento_de_Plantios;
                var Detalle_Aseguramiento_de_PlantiosData = GetDetalle_Aseguramiento_de_PlantiosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Plantios);
                int RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje;
                var Detalle_Aseguramiento_de_Pistas_de_AterrizajeData = GetDetalle_Aseguramiento_de_Pistas_de_AterrizajeData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_de_Pistas_de_Aterrizaje);
                int RowCount_Detalle_Aseguramiento_Otros;
                var Detalle_Aseguramiento_OtrosData = GetDetalle_Aseguramiento_OtrosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Aseguramiento_Otros);

                var result = new Aseguramientos_Otros_AseguramientosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medios_de_Transporte_Involucrados = Detalle_Aseguramiento_Medios_de_TransporteData
                    ,Drogas_Involucradas = Detalle_Aseguramiento_de_Drogas_InvolucradasData
                    ,Armas_Involucradas = Detalle_Aseguramiento_Armas_InvolucradasData
                    ,Artefactos_y_Explosivos = Detalle_Aseguramiento_Artefactos_y_ExplosivosData
                    ,Cargadores_y_Cartuchos = Detalle_Aseguramiento_de_Cargador_CartuchosData
                    ,Equipo_de_Comunicaciones = Detalle_Aseguramiento_Objetos_AseguradosData
                    ,Documentos = Detalle_Aseguramiento_DocumentosData
                    ,Moneda = Detalle_Aseguramiento_MonedaData
                    ,Equipo_Tactico = Detalle_Aseguramiento_Otros_AseguramientosData
                    ,Electronicos_y_Multimedia = Detalle_Aseguramiento_Electronicos_y_MultimediaData
                    ,Pirateria = Detalle_Aseguramiento_PirateriaData
                    ,Inmuebles = Detalle_Aseguramiento_InmueblesData
                    ,Plantios = Detalle_Aseguramiento_de_PlantiosData
                    ,Pistas_de_Aterrizaje = Detalle_Aseguramiento_de_Pistas_de_AterrizajeData
                    ,Otros = Detalle_Aseguramiento_OtrosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

