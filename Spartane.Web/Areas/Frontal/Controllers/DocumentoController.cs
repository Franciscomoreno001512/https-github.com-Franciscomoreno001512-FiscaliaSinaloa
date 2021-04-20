﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Dilgencia_MASC;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Localizacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Documento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Dilgencia_MASC;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Localizacion;

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
    public class DocumentoController : Controller
    {
        #region "variable declaration"

        private IDocumentoService service = null;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IDilgencia_MASCApiConsumer _IDilgencia_MASCApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;
        private ITipo_de_DocumentoApiConsumer _ITipo_de_DocumentoApiConsumer;
        private IArea_de_Servicios_de_ApoyoApiConsumer _IArea_de_Servicios_de_ApoyoApiConsumer;
        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;
        private ITipo_de_LocalizacionApiConsumer _ITipo_de_LocalizacionApiConsumer;

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

        
        public DocumentoController(IDocumentoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDocumentoApiConsumer DocumentoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IDilgencia_MASCApiConsumer Dilgencia_MASCApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer , ITipo_de_DocumentoApiConsumer Tipo_de_DocumentoApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer , ITipo_de_LocalizacionApiConsumer Tipo_de_LocalizacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IDilgencia_MASCApiConsumer = Dilgencia_MASCApiConsumer;
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;
            this._ITipo_de_DocumentoApiConsumer = Tipo_de_DocumentoApiConsumer;
            this._IArea_de_Servicios_de_ApoyoApiConsumer = Area_de_Servicios_de_ApoyoApiConsumer;
            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;
            this._ITipo_de_LocalizacionApiConsumer = Tipo_de_LocalizacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Documento
        [ObjectAuth(ObjectId = (ModuleObjectId)45387, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45387, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Documento/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45387, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45387, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDocumento = new DocumentoModel();
			varDocumento.Clave = Id;
			
            ViewBag.ObjectId = "45387";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var DocumentosData = _IDocumentoApiConsumer.ListaSelAll(0, 1000, "Documento.Clave=" + Id, "").Resource.Documentos;
				
				if (DocumentosData != null && DocumentosData.Count > 0)
                {
					var DocumentoData = DocumentosData.First();
					varDocumento= new DocumentoModel
					{
						Clave  = DocumentoData.Clave 
	                    ,Descripcion = DocumentoData.Descripcion
                    ,Diligencia = DocumentoData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Diligencia), "Dilgencia_MASC") ??  (string)DocumentoData.Diligencia_Dilgencia_MASC.Descripcion
                    ,Origen = DocumentoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Origen), "Origen_de_Invitacion") ??  (string)DocumentoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Tipo_de_Documento = DocumentoData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)DocumentoData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Area_de_Servicios_de_Apoyo = DocumentoData.Area_de_Servicios_de_Apoyo
                    ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Area_de_Servicios_de_Apoyo), "Area_de_Servicios_de_Apoyo") ??  (string)DocumentoData.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_de_Servicios_de_Apoyo = DocumentoData.SubArea_de_Servicios_de_Apoyo
                    ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.SubArea_de_Servicios_de_Apoyo), "SubArea_de_Servicios_de_Apoyo") ??  (string)DocumentoData.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,idFormato = DocumentoData.idFormato
                    ,Requerido = DocumentoData.Requerido.GetValueOrDefault()
                    ,Solicitante = DocumentoData.Solicitante.GetValueOrDefault()
                    ,Requerido_o_Solicitante = DocumentoData.Requerido_o_Solicitante.GetValueOrDefault()
                    ,Solicitar_Archivo_Adjunto = DocumentoData.Solicitar_Archivo_Adjunto.GetValueOrDefault()
                    ,Solicitar_Numero_de_Oficio = DocumentoData.Solicitar_Numero_de_Oficio.GetValueOrDefault()
                    ,Tipo_de_Localizacion = DocumentoData.Tipo_de_Localizacion
                    ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Tipo_de_Localizacion), "Tipo_de_Localizacion") ??  (string)DocumentoData.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo != null && Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo != null && SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localizacions_Tipo_de_Localizacion = _ITipo_de_LocalizacionApiConsumer.SelAll(true);
            if (Tipo_de_Localizacions_Tipo_de_Localizacion != null && Tipo_de_Localizacions_Tipo_de_Localizacion.Resource != null)
                ViewBag.Tipo_de_Localizacions_Tipo_de_Localizacion = Tipo_de_Localizacions_Tipo_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDocumento);
        }
		
	[HttpGet]
        public ActionResult AddDocumento(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45387);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
			DocumentoModel varDocumento= new DocumentoModel();


            if (id.ToString() != "0")
            {
                var DocumentosData = _IDocumentoApiConsumer.ListaSelAll(0, 1000, "Documento.Clave=" + id, "").Resource.Documentos;
				
				if (DocumentosData != null && DocumentosData.Count > 0)
                {
					var DocumentoData = DocumentosData.First();
					varDocumento= new DocumentoModel
					{
						Clave  = DocumentoData.Clave 
	                    ,Descripcion = DocumentoData.Descripcion
                    ,Diligencia = DocumentoData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Diligencia), "Dilgencia_MASC") ??  (string)DocumentoData.Diligencia_Dilgencia_MASC.Descripcion
                    ,Origen = DocumentoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Origen), "Origen_de_Invitacion") ??  (string)DocumentoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Tipo_de_Documento = DocumentoData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)DocumentoData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Area_de_Servicios_de_Apoyo = DocumentoData.Area_de_Servicios_de_Apoyo
                    ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Area_de_Servicios_de_Apoyo), "Area_de_Servicios_de_Apoyo") ??  (string)DocumentoData.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_de_Servicios_de_Apoyo = DocumentoData.SubArea_de_Servicios_de_Apoyo
                    ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.SubArea_de_Servicios_de_Apoyo), "SubArea_de_Servicios_de_Apoyo") ??  (string)DocumentoData.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,idFormato = DocumentoData.idFormato
                    ,Requerido = DocumentoData.Requerido.GetValueOrDefault()
                    ,Solicitante = DocumentoData.Solicitante.GetValueOrDefault()
                    ,Requerido_o_Solicitante = DocumentoData.Requerido_o_Solicitante.GetValueOrDefault()
                    ,Solicitar_Archivo_Adjunto = DocumentoData.Solicitar_Archivo_Adjunto.GetValueOrDefault()
                    ,Solicitar_Numero_de_Oficio = DocumentoData.Solicitar_Numero_de_Oficio.GetValueOrDefault()
                    ,Tipo_de_Localizacion = DocumentoData.Tipo_de_Localizacion
                    ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(DocumentoData.Tipo_de_Localizacion), "Tipo_de_Localizacion") ??  (string)DocumentoData.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo != null && Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo != null && SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localizacions_Tipo_de_Localizacion = _ITipo_de_LocalizacionApiConsumer.SelAll(true);
            if (Tipo_de_Localizacions_Tipo_de_Localizacion != null && Tipo_de_Localizacions_Tipo_de_Localizacion.Resource != null)
                ViewBag.Tipo_de_Localizacions_Tipo_de_Localizacion = Tipo_de_Localizacions_Tipo_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDocumento", varDocumento);
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
        public ActionResult GetDilgencia_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDilgencia_MASCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOrigen_de_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrigen_de_InvitacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DocumentoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSubArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_LocalizacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_LocalizacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localizacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(DocumentoAdvanceSearchModel model, int idFilter = -1)
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

            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo != null && Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo != null && SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localizacions_Tipo_de_Localizacion = _ITipo_de_LocalizacionApiConsumer.SelAll(true);
            if (Tipo_de_Localizacions_Tipo_de_Localizacion != null && Tipo_de_Localizacions_Tipo_de_Localizacion.Resource != null)
                ViewBag.Tipo_de_Localizacions_Tipo_de_Localizacion = Tipo_de_Localizacions_Tipo_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDilgencia_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dilgencia_MASCs_Diligencia = _IDilgencia_MASCApiConsumer.SelAll(true);
            if (Dilgencia_MASCs_Diligencia != null && Dilgencia_MASCs_Diligencia.Resource != null)
                ViewBag.Dilgencia_MASCs_Diligencia = Dilgencia_MASCs_Diligencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dilgencia_MASC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo != null && Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo = Area_de_Servicios_de_Apoyos_Area_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo != null && SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo = SubArea_de_Servicios_de_Apoyos_SubArea_de_Servicios_de_Apoyo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Localizacions_Tipo_de_Localizacion = _ITipo_de_LocalizacionApiConsumer.SelAll(true);
            if (Tipo_de_Localizacions_Tipo_de_Localizacion != null && Tipo_de_Localizacions_Tipo_de_Localizacion.Resource != null)
                ViewBag.Tipo_de_Localizacions_Tipo_de_Localizacion = Tipo_de_Localizacions_Tipo_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new DocumentoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (DocumentoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new DocumentoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new DocumentoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDocumentoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Documentos == null)
                result.Documentos = new List<Documento>();

            return Json(new
            {
                data = result.Documentos.Select(m => new DocumentoGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
			,idFormato = m.idFormato
			,Requerido = m.Requerido
			,Solicitante = m.Solicitante
			,Requerido_o_Solicitante = m.Requerido_o_Solicitante
			,Solicitar_Archivo_Adjunto = m.Solicitar_Archivo_Adjunto
			,Solicitar_Numero_de_Oficio = m.Solicitar_Numero_de_Oficio
                        ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Localizacion_Tipo_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Documento", m.),
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
        /// Get List of Documento from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Documento Entity</returns>
        public ActionResult GetDocumentoList(UrlParametersModel param)
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
            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new DocumentoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(DocumentoAdvanceSearchModel))
                {
					var advanceFilter =
                    (DocumentoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            DocumentoPropertyMapper oDocumentoPropertyMapper = new DocumentoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDocumentoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDocumentoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Documentos == null)
                result.Documentos = new List<Documento>();

            return Json(new
            {
                aaData = result.Documentos.Select(m => new DocumentoGridModel
            {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
			,idFormato = m.idFormato
			,Requerido = m.Requerido
			,Solicitante = m.Solicitante
			,Requerido_o_Solicitante = m.Requerido_o_Solicitante
			,Solicitar_Archivo_Adjunto = m.Solicitar_Archivo_Adjunto
			,Solicitar_Numero_de_Oficio = m.Solicitar_Numero_de_Oficio
                        ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Localizacion_Tipo_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(DocumentoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Documento.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Documento.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiligencia))
            {
                switch (filter.DiligenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '" + filter.AdvanceDiligencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '%" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dilgencia_MASC.Descripcion = '" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dilgencia_MASC.Descripcion LIKE '%" + filter.AdvanceDiligencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiligenciaMultiple != null && filter.AdvanceDiligenciaMultiple.Count() > 0)
            {
                var DiligenciaIds = string.Join(",", filter.AdvanceDiligenciaMultiple);

                where += " AND Documento.Diligencia In (" + DiligenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrigen))
            {
                switch (filter.OrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '" + filter.AdvanceOrigen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Origen_de_Invitacion.Descripcion = '" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrigenMultiple != null && filter.AdvanceOrigenMultiple.Count() > 0)
            {
                var OrigenIds = string.Join(",", filter.AdvanceOrigenMultiple);

                where += " AND Documento.Origen In (" + OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Documento))
            {
                switch (filter.Tipo_de_DocumentoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '" + filter.AdvanceTipo_de_Documento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Documento.Descripcion = '" + filter.AdvanceTipo_de_Documento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DocumentoMultiple != null && filter.AdvanceTipo_de_DocumentoMultiple.Count() > 0)
            {
                var Tipo_de_DocumentoIds = string.Join(",", filter.AdvanceTipo_de_DocumentoMultiple);

                where += " AND Documento.Tipo_de_Documento In (" + Tipo_de_DocumentoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea_de_Servicios_de_Apoyo))
            {
                switch (filter.Area_de_Servicios_de_ApoyoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceArea_de_Servicios_de_Apoyo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_de_Servicios_de_Apoyo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceArea_de_Servicios_de_Apoyo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_de_Servicios_de_Apoyo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_de_Servicios_de_ApoyoMultiple != null && filter.AdvanceArea_de_Servicios_de_ApoyoMultiple.Count() > 0)
            {
                var Area_de_Servicios_de_ApoyoIds = string.Join(",", filter.AdvanceArea_de_Servicios_de_ApoyoMultiple);

                where += " AND Documento.Area_de_Servicios_de_Apoyo In (" + Area_de_Servicios_de_ApoyoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSubArea_de_Servicios_de_Apoyo))
            {
                switch (filter.SubArea_de_Servicios_de_ApoyoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceSubArea_de_Servicios_de_Apoyo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_de_Servicios_de_Apoyo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceSubArea_de_Servicios_de_Apoyo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_de_Servicios_de_Apoyo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSubArea_de_Servicios_de_ApoyoMultiple != null && filter.AdvanceSubArea_de_Servicios_de_ApoyoMultiple.Count() > 0)
            {
                var SubArea_de_Servicios_de_ApoyoIds = string.Join(",", filter.AdvanceSubArea_de_Servicios_de_ApoyoMultiple);

                where += " AND Documento.SubArea_de_Servicios_de_Apoyo In (" + SubArea_de_Servicios_de_ApoyoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromidFormato) || !string.IsNullOrEmpty(filter.ToidFormato))
            {
                if (!string.IsNullOrEmpty(filter.FromidFormato))
                    where += " AND Documento.idFormato >= " + filter.FromidFormato;
                if (!string.IsNullOrEmpty(filter.ToidFormato))
                    where += " AND Documento.idFormato <= " + filter.ToidFormato;
            }

            if (filter.Requerido != RadioOptions.NoApply)
                where += " AND Documento.Requerido = " + Convert.ToInt32(filter.Requerido);

            if (filter.Solicitante != RadioOptions.NoApply)
                where += " AND Documento.Solicitante = " + Convert.ToInt32(filter.Solicitante);

            if (filter.Requerido_o_Solicitante != RadioOptions.NoApply)
                where += " AND Documento.Requerido_o_Solicitante = " + Convert.ToInt32(filter.Requerido_o_Solicitante);

            if (filter.Solicitar_Archivo_Adjunto != RadioOptions.NoApply)
                where += " AND Documento.Solicitar_Archivo_Adjunto = " + Convert.ToInt32(filter.Solicitar_Archivo_Adjunto);

            if (filter.Solicitar_Numero_de_Oficio != RadioOptions.NoApply)
                where += " AND Documento.Solicitar_Numero_de_Oficio = " + Convert.ToInt32(filter.Solicitar_Numero_de_Oficio);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Localizacion))
            {
                switch (filter.Tipo_de_LocalizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Localizacion.Descripcion LIKE '" + filter.AdvanceTipo_de_Localizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Localizacion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Localizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Localizacion.Descripcion = '" + filter.AdvanceTipo_de_Localizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Localizacion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Localizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_LocalizacionMultiple != null && filter.AdvanceTipo_de_LocalizacionMultiple.Count() > 0)
            {
                var Tipo_de_LocalizacionIds = string.Join(",", filter.AdvanceTipo_de_LocalizacionMultiple);

                where += " AND Documento.Tipo_de_Localizacion In (" + Tipo_de_LocalizacionIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }



        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Documento varDocumento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDocumentoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, DocumentoModel varDocumento)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var DocumentoInfo = new Documento
                    {
                        Clave = varDocumento.Clave
                        ,Descripcion = varDocumento.Descripcion
                        ,Diligencia = varDocumento.Diligencia
                        ,Origen = varDocumento.Origen
                        ,Tipo_de_Documento = varDocumento.Tipo_de_Documento
                        ,Area_de_Servicios_de_Apoyo = varDocumento.Area_de_Servicios_de_Apoyo
                        ,SubArea_de_Servicios_de_Apoyo = varDocumento.SubArea_de_Servicios_de_Apoyo
                        ,idFormato = varDocumento.idFormato
                        ,Requerido = varDocumento.Requerido
                        ,Solicitante = varDocumento.Solicitante
                        ,Requerido_o_Solicitante = varDocumento.Requerido_o_Solicitante
                        ,Solicitar_Archivo_Adjunto = varDocumento.Solicitar_Archivo_Adjunto
                        ,Solicitar_Numero_de_Oficio = varDocumento.Solicitar_Numero_de_Oficio
                        ,Tipo_de_Localizacion = varDocumento.Tipo_de_Localizacion

                    };

                    result = !IsNew ?
                        _IDocumentoApiConsumer.Update(DocumentoInfo, null, null).Resource.ToString() :
                         _IDocumentoApiConsumer.Insert(DocumentoInfo, null, null).Resource.ToString();
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



        /// <summary>
        /// Write Element Array of Documento script
        /// </summary>
        /// <param name="oDocumentoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew DocumentoModuleAttributeList)
        {
            for (int i = 0; i < DocumentoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(DocumentoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    DocumentoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(DocumentoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    DocumentoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (DocumentoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < DocumentoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < DocumentoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(DocumentoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							DocumentoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(DocumentoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							DocumentoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDocumentoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Documento.js")))
            {
                strDocumentoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Documento element attributes
            string userChangeJson = jsSerialize.Serialize(DocumentoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDocumentoScript.IndexOf("inpuElementArray");
            string splittedString = strDocumentoScript.Substring(indexOfArray, strDocumentoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(DocumentoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (DocumentoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDocumentoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDocumentoScript.Substring(indexOfArrayHistory, strDocumentoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDocumentoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDocumentoScript.Substring(endIndexOfMainElement + indexOfArray, strDocumentoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (DocumentoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in DocumentoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Documento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Documento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Documento.js")))
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
        public ActionResult DocumentoPropertyBag()
        {
            return PartialView("DocumentoPropertyBag", "Documento");
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
                var whereClauseFormat = "Object = 45387 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Documento.Clave= " + RecordId;
                            var result = _IDocumentoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DocumentoPropertyMapper());
			
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
                    (DocumentoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            DocumentoPropertyMapper oDocumentoPropertyMapper = new DocumentoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDocumentoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDocumentoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Documentos == null)
                result.Documentos = new List<Documento>();

            var data = result.Documentos.Select(m => new DocumentoGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
			,idFormato = m.idFormato
			,Requerido = m.Requerido
			,Solicitante = m.Solicitante
			,Requerido_o_Solicitante = m.Requerido_o_Solicitante
			,Solicitar_Archivo_Adjunto = m.Solicitar_Archivo_Adjunto
			,Solicitar_Numero_de_Oficio = m.Solicitar_Numero_de_Oficio
                        ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Localizacion_Tipo_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45387, arrayColumnsVisible), "DocumentoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45387, arrayColumnsVisible), "DocumentoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45387, arrayColumnsVisible), "DocumentoList_" + DateTime.Now.ToString());
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

            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DocumentoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (DocumentoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            DocumentoPropertyMapper oDocumentoPropertyMapper = new DocumentoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDocumentoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDocumentoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Documentos == null)
                result.Documentos = new List<Documento>();

            var data = result.Documentos.Select(m => new DocumentoGridModel
            {
                Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
			,idFormato = m.idFormato
			,Requerido = m.Requerido
			,Solicitante = m.Solicitante
			,Requerido_o_Solicitante = m.Requerido_o_Solicitante
			,Solicitar_Archivo_Adjunto = m.Solicitar_Archivo_Adjunto
			,Solicitar_Numero_de_Oficio = m.Solicitar_Numero_de_Oficio
                        ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Localizacion_Tipo_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

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
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Documento_Datos_GeneralesModel varDocumento)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Documento_Datos_GeneralesInfo = new Documento_Datos_Generales
                {
                    Clave = varDocumento.Clave
                                            ,Descripcion = varDocumento.Descripcion
                        ,Diligencia = varDocumento.Diligencia
                        ,Origen = varDocumento.Origen
                        ,Tipo_de_Documento = varDocumento.Tipo_de_Documento
                        ,Area_de_Servicios_de_Apoyo = varDocumento.Area_de_Servicios_de_Apoyo
                        ,SubArea_de_Servicios_de_Apoyo = varDocumento.SubArea_de_Servicios_de_Apoyo
                        ,idFormato = varDocumento.idFormato
                        ,Requerido = varDocumento.Requerido
                        ,Solicitante = varDocumento.Solicitante
                        ,Requerido_o_Solicitante = varDocumento.Requerido_o_Solicitante
                        ,Solicitar_Archivo_Adjunto = varDocumento.Solicitar_Archivo_Adjunto
                        ,Solicitar_Numero_de_Oficio = varDocumento.Solicitar_Numero_de_Oficio
                        ,Tipo_de_Localizacion = varDocumento.Tipo_de_Localizacion
                    
                };

                result = _IDocumentoApiConsumer.Update_Datos_Generales(Documento_Datos_GeneralesInfo).Resource.ToString();
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
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDocumentoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Documento_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Descripcion = m.Descripcion
                        ,Diligencia = m.Diligencia
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Dilgencia_MASC.Clave.ToString(), "Descripcion") ?? (string)m.Diligencia_Dilgencia_MASC.Descripcion
                        ,Origen = m.Origen
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Tipo_de_Documento = m.Tipo_de_Documento
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Area_de_Servicios_de_Apoyo = m.Area_de_Servicios_de_Apoyo
                        ,Area_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_de_Servicios_de_Apoyo_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_de_Servicios_de_Apoyo = m.SubArea_de_Servicios_de_Apoyo
                        ,SubArea_de_Servicios_de_ApoyoDescripcion = CultureHelper.GetTraduction(m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_de_Servicios_de_Apoyo_SubArea_de_Servicios_de_Apoyo.Descripcion
			,idFormato = m.idFormato
			,Requerido = m.Requerido
			,Solicitante = m.Solicitante
			,Requerido_o_Solicitante = m.Requerido_o_Solicitante
			,Solicitar_Archivo_Adjunto = m.Solicitar_Archivo_Adjunto
			,Solicitar_Numero_de_Oficio = m.Solicitar_Numero_de_Oficio
                        ,Tipo_de_Localizacion = m.Tipo_de_Localizacion
                        ,Tipo_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Localizacion_Tipo_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Localizacion_Tipo_de_Localizacion.Descripcion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

