using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Imputado;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Diligencias_MP;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Diligencias_MP;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;

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
    public class Diligencias_MPController : Controller
    {
        #region "variable declaration"

        private IDiligencias_MPService service = null;
        private IDiligencias_MPApiConsumer _IDiligencias_MPApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_DocumentoApiConsumer _ITipo_de_DocumentoApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;
        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;

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

        
        public Diligencias_MPController(IDiligencias_MPService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDiligencias_MPApiConsumer Diligencias_MPApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_DocumentoApiConsumer Tipo_de_DocumentoApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDiligencias_MPApiConsumer = Diligencias_MPApiConsumer;
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
            this._ITipo_de_DocumentoApiConsumer = Tipo_de_DocumentoApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;
            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Diligencias_MP
        [ObjectAuth(ObjectId = (ModuleObjectId)45474, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45474, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Diligencias_MP/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45474, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45474, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDiligencias_MP = new Diligencias_MPModel();
			varDiligencias_MP.Clave = Id;
			
            ViewBag.ObjectId = "45474";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Diligencias_MPsData = _IDiligencias_MPApiConsumer.ListaSelAll(0, 1000, "Diligencias_MP.Clave=" + Id, "").Resource.Diligencias_MPs;
				
				if (Diligencias_MPsData != null && Diligencias_MPsData.Count > 0)
                {
					var Diligencias_MPData = Diligencias_MPsData.First();
					varDiligencias_MP= new Diligencias_MPModel
					{
						Clave  = Diligencias_MPData.Clave 
	                    ,Expediente_MP = Diligencias_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Diligencias_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha = (Diligencias_MPData.Fecha == null ? string.Empty : Convert.ToDateTime(Diligencias_MPData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Diligencias_MPData.Hora
                    ,Usuario_que_Registra = Diligencias_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Diligencias_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Documento = Diligencias_MPData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)Diligencias_MPData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Documento = Diligencias_MPData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Documento), "Documento") ??  (string)Diligencias_MPData.Documento_Documento.Descripcion
                    ,Numero_de_Oficio = Diligencias_MPData.Numero_de_Oficio
                    ,Involucrado = Diligencias_MPData.Involucrado
                    ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Involucrado), "Detalle_de_Datos_Generales") ??  (string)Diligencias_MPData.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Probable_Responsable = Diligencias_MPData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Probable_Responsable), "Detalle_de_Imputado") ??  (string)Diligencias_MPData.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Archivo_Adjunto = Diligencias_MPData.Archivo_Adjunto
                    ,Observaciones = Diligencias_MPData.Observaciones
                    ,Archivo = Diligencias_MPData.Archivo
                    ,Descripcion = Diligencias_MPData.Descripcion
                    ,Lista_para_periciales = Diligencias_MPData.Lista_para_periciales.GetValueOrDefault()

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDiligencias_MP.Archivo_Adjunto).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDiligencias_MP);
        }
		
	[HttpGet]
        public ActionResult AddDiligencias_MP(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45474);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
			Diligencias_MPModel varDiligencias_MP= new Diligencias_MPModel();


            if (id.ToString() != "0")
            {
                var Diligencias_MPsData = _IDiligencias_MPApiConsumer.ListaSelAll(0, 1000, "Diligencias_MP.Clave=" + id, "").Resource.Diligencias_MPs;
				
				if (Diligencias_MPsData != null && Diligencias_MPsData.Count > 0)
                {
					var Diligencias_MPData = Diligencias_MPsData.First();
					varDiligencias_MP= new Diligencias_MPModel
					{
						Clave  = Diligencias_MPData.Clave 
	                    ,Expediente_MP = Diligencias_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Diligencias_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha = (Diligencias_MPData.Fecha == null ? string.Empty : Convert.ToDateTime(Diligencias_MPData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Diligencias_MPData.Hora
                    ,Usuario_que_Registra = Diligencias_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Diligencias_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Documento = Diligencias_MPData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)Diligencias_MPData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Documento = Diligencias_MPData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Documento), "Documento") ??  (string)Diligencias_MPData.Documento_Documento.Descripcion
                    ,Numero_de_Oficio = Diligencias_MPData.Numero_de_Oficio
                    ,Involucrado = Diligencias_MPData.Involucrado
                    ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Involucrado), "Detalle_de_Datos_Generales") ??  (string)Diligencias_MPData.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Probable_Responsable = Diligencias_MPData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Diligencias_MPData.Probable_Responsable), "Detalle_de_Imputado") ??  (string)Diligencias_MPData.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Archivo_Adjunto = Diligencias_MPData.Archivo_Adjunto
                    ,Observaciones = Diligencias_MPData.Observaciones
                    ,Archivo = Diligencias_MPData.Archivo
                    ,Descripcion = Diligencias_MPData.Descripcion
                    ,Lista_para_periciales = Diligencias_MPData.Lista_para_periciales.GetValueOrDefault()

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDiligencias_MP.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDiligencias_MP", varDiligencias_MP);
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
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo")?? m.Nombre_Completo,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_Detenido).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido")?? m.Nombre_Completo_Detenido,
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
        public ActionResult ShowAdvanceFilter(Diligencias_MPAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Diligencias_MPAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Diligencias_MPAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Diligencias_MPAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Diligencias_MPPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDiligencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligencias_MPs == null)
                result.Diligencias_MPs = new List<Diligencias_MP>();

            return Json(new
            {
                data = result.Diligencias_MPs.Select(m => new Diligencias_MPGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Descripcion = m.Descripcion
			,Lista_para_periciales = m.Lista_para_periciales

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDiligencias_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligencias_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Diligencias_MP", m.),
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
        /// Get List of Diligencias_MP from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Diligencias_MP Entity</returns>
        public ActionResult GetDiligencias_MPList(UrlParametersModel param)
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
            _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Diligencias_MPPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Diligencias_MPAdvanceSearchModel))
                {
					var advanceFilter =
                    (Diligencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Diligencias_MPPropertyMapper oDiligencias_MPPropertyMapper = new Diligencias_MPPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDiligencias_MPPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDiligencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligencias_MPs == null)
                result.Diligencias_MPs = new List<Diligencias_MP>();

            return Json(new
            {
                aaData = result.Diligencias_MPs.Select(m => new Diligencias_MPGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Descripcion = m.Descripcion
			,Lista_para_periciales = m.Lista_para_periciales

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDiligencias_MP_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetDiligencias_MP_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetDiligencias_MP_Documento_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDiligencias_MP_Involucrado_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDiligencias_MP_Probable_Responsable_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_Detenido as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_Detenido ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                    item.Nombre_Completo_Detenido =trans ??item.Nombre_Completo_Detenido;
                }
                return Json(result.Detalle_de_Imputados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Diligencias_MPAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Diligencias_MP.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Diligencias_MP.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MP))
            {
                switch (filter.Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPMultiple != null && filter.AdvanceExpediente_MPMultiple.Count() > 0)
            {
                var Expediente_MPIds = string.Join(",", filter.AdvanceExpediente_MPMultiple);

                where += " AND Diligencias_MP.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Diligencias_MP.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Diligencias_MP.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Diligencias_MP.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Diligencias_MP.Hora) <='" + filter.ToHora + "'";
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

                where += " AND Diligencias_MP.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
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

                where += " AND Diligencias_MP.Tipo_de_Documento In (" + Tipo_de_DocumentoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDocumento))
            {
                switch (filter.DocumentoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDocumento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDocumento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDocumento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDocumento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDocumentoMultiple != null && filter.AdvanceDocumentoMultiple.Count() > 0)
            {
                var DocumentoIds = string.Join(",", filter.AdvanceDocumentoMultiple);

                where += " AND Diligencias_MP.Documento In (" + DocumentoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio))
            {
                switch (filter.Numero_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias_MP.Numero_de_Oficio LIKE '" + filter.Numero_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias_MP.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias_MP.Numero_de_Oficio = '" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias_MP.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceInvolucrado))
            {
                switch (filter.InvolucradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '" + filter.AdvanceInvolucrado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceInvolucrado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo = '" + filter.AdvanceInvolucrado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceInvolucrado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceInvolucradoMultiple != null && filter.AdvanceInvolucradoMultiple.Count() > 0)
            {
                var InvolucradoIds = string.Join(",", filter.AdvanceInvolucradoMultiple);

                where += " AND Diligencias_MP.Involucrado In (" + InvolucradoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProbable_Responsable))
            {
                switch (filter.Probable_ResponsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '" + filter.AdvanceProbable_Responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido = '" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceProbable_Responsable + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProbable_ResponsableMultiple != null && filter.AdvanceProbable_ResponsableMultiple.Count() > 0)
            {
                var Probable_ResponsableIds = string.Join(",", filter.AdvanceProbable_ResponsableMultiple);

                where += " AND Diligencias_MP.Probable_Responsable In (" + Probable_ResponsableIds + ")";
            }

            if (filter.Archivo_Adjunto != RadioOptions.NoApply)
                where += " AND Diligencias_MP.Archivo_Adjunto " + (filter.Archivo_Adjunto == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias_MP.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias_MP.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias_MP.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias_MP.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromArchivo) || !string.IsNullOrEmpty(filter.ToArchivo))
            {
                if (!string.IsNullOrEmpty(filter.FromArchivo))
                    where += " AND Diligencias_MP.Archivo >= " + filter.FromArchivo;
                if (!string.IsNullOrEmpty(filter.ToArchivo))
                    where += " AND Diligencias_MP.Archivo <= " + filter.ToArchivo;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias_MP.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (filter.Lista_para_periciales != RadioOptions.NoApply)
                where += " AND Diligencias_MP.Lista_para_periciales = " + Convert.ToInt32(filter.Lista_para_periciales);


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
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

                Diligencias_MP varDiligencias_MP = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDiligencias_MPApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Diligencias_MPModel varDiligencias_MP)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDiligencias_MP.Archivo_AdjuntoRemoveAttachment != 0 && varDiligencias_MP.Archivo_AdjuntoFile == null)
                    {
                        varDiligencias_MP.Archivo_Adjunto = 0;
                    }

                    if (varDiligencias_MP.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDiligencias_MP.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDiligencias_MP.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDiligencias_MP.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Diligencias_MPInfo = new Diligencias_MP
                    {
                        Clave = varDiligencias_MP.Clave
                        ,Expediente_MP = varDiligencias_MP.Expediente_MP
                        ,Fecha = (!String.IsNullOrEmpty(varDiligencias_MP.Fecha)) ? DateTime.ParseExact(varDiligencias_MP.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDiligencias_MP.Hora
                        ,Usuario_que_Registra = varDiligencias_MP.Usuario_que_Registra
                        ,Tipo_de_Documento = varDiligencias_MP.Tipo_de_Documento
                        ,Documento = varDiligencias_MP.Documento
                        ,Numero_de_Oficio = varDiligencias_MP.Numero_de_Oficio
                        ,Involucrado = varDiligencias_MP.Involucrado
                        ,Probable_Responsable = varDiligencias_MP.Probable_Responsable
                        ,Archivo_Adjunto = (varDiligencias_MP.Archivo_Adjunto.HasValue && varDiligencias_MP.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDiligencias_MP.Archivo_Adjunto.Value)) : null

                        ,Observaciones = varDiligencias_MP.Observaciones
                        ,Archivo = varDiligencias_MP.Archivo
                        ,Descripcion = varDiligencias_MP.Descripcion
                        ,Lista_para_periciales = varDiligencias_MP.Lista_para_periciales

                    };

                    result = !IsNew ?
                        _IDiligencias_MPApiConsumer.Update(Diligencias_MPInfo, null, null).Resource.ToString() :
                         _IDiligencias_MPApiConsumer.Insert(Diligencias_MPInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Diligencias_MP script
        /// </summary>
        /// <param name="oDiligencias_MPElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Diligencias_MPModuleAttributeList)
        {
            for (int i = 0; i < Diligencias_MPModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Diligencias_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Diligencias_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Diligencias_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Diligencias_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Diligencias_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Diligencias_MPModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Diligencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Diligencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Diligencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Diligencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Diligencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDiligencias_MPScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Diligencias_MP.js")))
            {
                strDiligencias_MPScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Diligencias_MP element attributes
            string userChangeJson = jsSerialize.Serialize(Diligencias_MPModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDiligencias_MPScript.IndexOf("inpuElementArray");
            string splittedString = strDiligencias_MPScript.Substring(indexOfArray, strDiligencias_MPScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Diligencias_MPModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Diligencias_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDiligencias_MPScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDiligencias_MPScript.Substring(indexOfArrayHistory, strDiligencias_MPScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDiligencias_MPScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDiligencias_MPScript.Substring(endIndexOfMainElement + indexOfArray, strDiligencias_MPScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Diligencias_MPModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Diligencias_MPModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Diligencias_MP.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Diligencias_MP.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Diligencias_MP.js")))
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
        public ActionResult Diligencias_MPPropertyBag()
        {
            return PartialView("Diligencias_MPPropertyBag", "Diligencias_MP");
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
                var whereClauseFormat = "Object = 45474 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Diligencias_MP.Clave= " + RecordId;
                            var result = _IDiligencias_MPApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Diligencias_MPPropertyMapper());
			
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
                    (Diligencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Diligencias_MPPropertyMapper oDiligencias_MPPropertyMapper = new Diligencias_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDiligencias_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDiligencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligencias_MPs == null)
                result.Diligencias_MPs = new List<Diligencias_MP>();

            var data = result.Diligencias_MPs.Select(m => new Diligencias_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Descripcion = m.Descripcion
			,Lista_para_periciales = m.Lista_para_periciales

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45474, arrayColumnsVisible), "Diligencias_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45474, arrayColumnsVisible), "Diligencias_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45474, arrayColumnsVisible), "Diligencias_MPList_" + DateTime.Now.ToString());
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

            _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Diligencias_MPPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Diligencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Diligencias_MPPropertyMapper oDiligencias_MPPropertyMapper = new Diligencias_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDiligencias_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDiligencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Diligencias_MPs == null)
                result.Diligencias_MPs = new List<Diligencias_MP>();

            var data = result.Diligencias_MPs.Select(m => new Diligencias_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Descripcion = m.Descripcion
			,Lista_para_periciales = m.Lista_para_periciales

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
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligencias_MPApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Diligencias_MP_Datos_GeneralesModel varDiligencias_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDiligencias_MP.Archivo_AdjuntoRemoveAttachment != 0 && varDiligencias_MP.Archivo_AdjuntoFile == null)
                    {
                        varDiligencias_MP.Archivo_Adjunto = 0;
                    }

                    if (varDiligencias_MP.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDiligencias_MP.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDiligencias_MP.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDiligencias_MP.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Diligencias_MP_Datos_GeneralesInfo = new Diligencias_MP_Datos_Generales
                {
                    Clave = varDiligencias_MP.Clave
                                            ,Expediente_MP = varDiligencias_MP.Expediente_MP
                        ,Fecha = (!String.IsNullOrEmpty(varDiligencias_MP.Fecha)) ? DateTime.ParseExact(varDiligencias_MP.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDiligencias_MP.Hora
                        ,Usuario_que_Registra = varDiligencias_MP.Usuario_que_Registra
                        ,Tipo_de_Documento = varDiligencias_MP.Tipo_de_Documento
                        ,Documento = varDiligencias_MP.Documento
                        ,Numero_de_Oficio = varDiligencias_MP.Numero_de_Oficio
                        ,Involucrado = varDiligencias_MP.Involucrado
                        ,Probable_Responsable = varDiligencias_MP.Probable_Responsable
                        ,Archivo_Adjunto = (varDiligencias_MP.Archivo_Adjunto.HasValue && varDiligencias_MP.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDiligencias_MP.Archivo_Adjunto.Value)) : null

                        ,Observaciones = varDiligencias_MP.Observaciones
                        ,Archivo = varDiligencias_MP.Archivo
                        ,Descripcion = varDiligencias_MP.Descripcion
                        ,Lista_para_periciales = varDiligencias_MP.Lista_para_periciales
                    
                };

                result = _IDiligencias_MPApiConsumer.Update_Datos_Generales(Diligencias_MP_Datos_GeneralesInfo).Resource.ToString();
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
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDiligencias_MPApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Diligencias_MP_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Documento = m.Tipo_de_Documento
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Documento = m.Documento
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Involucrado = m.Involucrado
                        ,InvolucradoNombre_Completo = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Probable_Responsable = m.Probable_Responsable
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Descripcion = m.Descripcion
			,Lista_para_periciales = m.Lista_para_periciales

                    
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

