using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Canalizacion;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Estatus_Orientador;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Detalle_Diligencias_Canalizacion;






using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Canalizacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Canalizacion;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Relaciones;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Diligencias_Canalizacion;




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
    public class CanalizacionController : Controller
    {
        #region "variable declaration"

        private ICanalizacionService service = null;
        private ICanalizacionApiConsumer _ICanalizacionApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IDetalle_de_RelacionesApiConsumer _IDetalle_de_RelacionesApiConsumer;
        private IEstatus_OrientadorApiConsumer _IEstatus_OrientadorApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IDetalle_Diligencias_CanalizacionApiConsumer _IDetalle_Diligencias_CanalizacionApiConsumer;




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

        
        public CanalizacionController(ICanalizacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICanalizacionApiConsumer CanalizacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IDetalle_de_RelacionesApiConsumer Detalle_de_RelacionesApiConsumer , IEstatus_OrientadorApiConsumer Estatus_OrientadorApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IDetalle_Diligencias_CanalizacionApiConsumer Detalle_Diligencias_CanalizacionApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICanalizacionApiConsumer = CanalizacionApiConsumer;
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
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDetalle_de_RelacionesApiConsumer = Detalle_de_RelacionesApiConsumer;
            this._IEstatus_OrientadorApiConsumer = Estatus_OrientadorApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IDetalle_Diligencias_CanalizacionApiConsumer = Detalle_Diligencias_CanalizacionApiConsumer;




        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Canalizacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45703, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45703, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Canalizacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45703, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45703, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varCanalizacion = new CanalizacionModel();
			varCanalizacion.Clave = Id;
			
            ViewBag.ObjectId = "45703";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Diligencias_Canalizacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45704, ModuleId);
            ViewBag.PermissionDetalle_Diligencias_Canalizacion = permissionDetalle_Diligencias_Canalizacion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var CanalizacionsData = _ICanalizacionApiConsumer.ListaSelAll(0, 1000, "Canalizacion.Clave=" + Id, "").Resource.Canalizacions;
				
				if (CanalizacionsData != null && CanalizacionsData.Count > 0)
                {
					var CanalizacionData = CanalizacionsData.First();
					varCanalizacion= new CanalizacionModel
					{
						Clave  = CanalizacionData.Clave 
	                    ,Expediente_MP = CanalizacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)CanalizacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_AT = CanalizacionData.Expediente_AT
                    ,Expediente_ATFolio = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)CanalizacionData.Expediente_AT_Modulo_Atencion_Inicial.Folio
                    ,Fecha_de_Canalizacion = (CanalizacionData.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(CanalizacionData.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Canalizacion = CanalizacionData.Hora_de_Canalizacion
                    ,Usuario_que_Canaliza = CanalizacionData.Usuario_que_Canaliza
                    ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Usuario_que_Canaliza), "Spartan_User") ??  (string)CanalizacionData.Usuario_que_Canaliza_Spartan_User.Name
                    ,Relacion_a_Canalizar = CanalizacionData.Relacion_a_Canalizar
                    ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Relacion_a_Canalizar), "Detalle_de_Relaciones") ??  (string)CanalizacionData.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                    ,Canalizar_a = CanalizacionData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Canalizar_a), "Estatus_Orientador") ??  (string)CanalizacionData.Canalizar_a_Estatus_Orientador.Descripcion
                    ,Municipio = CanalizacionData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Municipio), "Municipio") ??  (string)CanalizacionData.Municipio_Municipio.Nombre
                    ,Unidad = CanalizacionData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Unidad), "Unidad") ??  (string)CanalizacionData.Unidad_Unidad.Descripcion
                    ,Fecha_de_Resolucion = (CanalizacionData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(CanalizacionData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Resolucion = CanalizacionData.Hora_de_Resolucion
                    ,Hubo_modificacion_en_la_relacion = CanalizacionData.Hubo_modificacion_en_la_relacion.GetValueOrDefault()
                    ,Nueva_Relacion = CanalizacionData.Nueva_Relacion
                    ,ResolucionId = CanalizacionData.ResolucionId
                    ,Resolucion = CanalizacionData.Resolucion
                    ,Detalle_de_la_Resolucion = CanalizacionData.Detalle_de_la_Resolucion
                    ,Observaciones = CanalizacionData.Observaciones

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varCanalizacion);
        }
		
	[HttpGet]
        public ActionResult AddCanalizacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45703);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			CanalizacionModel varCanalizacion= new CanalizacionModel();
            var permissionDetalle_Diligencias_Canalizacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45704, ModuleId);
            ViewBag.PermissionDetalle_Diligencias_Canalizacion = permissionDetalle_Diligencias_Canalizacion;


            if (id.ToString() != "0")
            {
                var CanalizacionsData = _ICanalizacionApiConsumer.ListaSelAll(0, 1000, "Canalizacion.Clave=" + id, "").Resource.Canalizacions;
				
				if (CanalizacionsData != null && CanalizacionsData.Count > 0)
                {
					var CanalizacionData = CanalizacionsData.First();
					varCanalizacion= new CanalizacionModel
					{
						Clave  = CanalizacionData.Clave 
	                    ,Expediente_MP = CanalizacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)CanalizacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Expediente_AT = CanalizacionData.Expediente_AT
                    ,Expediente_ATFolio = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)CanalizacionData.Expediente_AT_Modulo_Atencion_Inicial.Folio
                    ,Fecha_de_Canalizacion = (CanalizacionData.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(CanalizacionData.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Canalizacion = CanalizacionData.Hora_de_Canalizacion
                    ,Usuario_que_Canaliza = CanalizacionData.Usuario_que_Canaliza
                    ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Usuario_que_Canaliza), "Spartan_User") ??  (string)CanalizacionData.Usuario_que_Canaliza_Spartan_User.Name
                    ,Relacion_a_Canalizar = CanalizacionData.Relacion_a_Canalizar
                    ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Relacion_a_Canalizar), "Detalle_de_Relaciones") ??  (string)CanalizacionData.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                    ,Canalizar_a = CanalizacionData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Canalizar_a), "Estatus_Orientador") ??  (string)CanalizacionData.Canalizar_a_Estatus_Orientador.Descripcion
                    ,Municipio = CanalizacionData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Municipio), "Municipio") ??  (string)CanalizacionData.Municipio_Municipio.Nombre
                    ,Unidad = CanalizacionData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(CanalizacionData.Unidad), "Unidad") ??  (string)CanalizacionData.Unidad_Unidad.Descripcion
                    ,Fecha_de_Resolucion = (CanalizacionData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(CanalizacionData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Resolucion = CanalizacionData.Hora_de_Resolucion
                    ,Hubo_modificacion_en_la_relacion = CanalizacionData.Hubo_modificacion_en_la_relacion.GetValueOrDefault()
                    ,Nueva_Relacion = CanalizacionData.Nueva_Relacion
                    ,ResolucionId = CanalizacionData.ResolucionId
                    ,Resolucion = CanalizacionData.Resolucion
                    ,Detalle_de_la_Resolucion = CanalizacionData.Detalle_de_la_Resolucion
                    ,Observaciones = CanalizacionData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddCanalizacion", varCanalizacion);
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
        public ActionResult GetDetalle_de_RelacionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_RelacionesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetUnidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(CanalizacionAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Canalizar_a = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Canalizar_a != null && Estatus_Orientadors_Canalizar_a.Resource != null)
                ViewBag.Estatus_Orientadors_Canalizar_a = Estatus_Orientadors_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new CanalizacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (CanalizacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new CanalizacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new CanalizacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICanalizacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Canalizacions == null)
                result.Canalizacions = new List<Canalizacion>();

            return Json(new
            {
                data = result.Canalizacions.Select(m => new CanalizacionGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_ATFolio = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.Folio
                        ,Fecha_de_Canalizacion = (m.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Canalizacion = m.Hora_de_Canalizacion
                        ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(m.Usuario_que_Canaliza_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Canaliza_Spartan_User.Name
                        ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(m.Relacion_a_Canalizar_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion = m.Hora_de_Resolucion
			,Hubo_modificacion_en_la_relacion = m.Hubo_modificacion_en_la_relacion
			,Nueva_Relacion = m.Nueva_Relacion
			,ResolucionId = m.ResolucionId
			,Resolucion = m.Resolucion
			,Detalle_de_la_Resolucion = m.Detalle_de_la_Resolucion
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetCanalizacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICanalizacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Canalizacion", m.),
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
        /// Get List of Canalizacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Canalizacion Entity</returns>
        public ActionResult GetCanalizacionList(UrlParametersModel param)
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
            _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new CanalizacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(CanalizacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (CanalizacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            CanalizacionPropertyMapper oCanalizacionPropertyMapper = new CanalizacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oCanalizacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ICanalizacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Canalizacions == null)
                result.Canalizacions = new List<Canalizacion>();

            return Json(new
            {
                aaData = result.Canalizacions.Select(m => new CanalizacionGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_ATFolio = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.Folio
                        ,Fecha_de_Canalizacion = (m.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Canalizacion = m.Hora_de_Canalizacion
                        ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(m.Usuario_que_Canaliza_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Canaliza_Spartan_User.Name
                        ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(m.Relacion_a_Canalizar_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion = m.Hora_de_Resolucion
			,Hubo_modificacion_en_la_relacion = m.Hubo_modificacion_en_la_relacion
			,Nueva_Relacion = m.Nueva_Relacion
			,ResolucionId = m.ResolucionId
			,Resolucion = m.Resolucion
			,Detalle_de_la_Resolucion = m.Detalle_de_la_Resolucion
			,Observaciones = m.Observaciones

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetCanalizacion_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetCanalizacion_Expediente_AT_Modulo_Atencion_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modulo_Atencion_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modulo_Atencion_Inicial.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Modulo_Atencion_Inicial.Folio ASC ").Resource;
               
                foreach (var item in result.Modulo_Atencion_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modulo_Atencion_Inicial", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Modulo_Atencion_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetCanalizacion_Usuario_que_Canaliza_Spartan_User(string query, string where)
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
        public JsonResult GetCanalizacion_Relacion_a_Canalizar_Detalle_de_Relaciones(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Relaciones.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Relaciones.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_RelacionesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Relaciones.Descripcion ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Relacioness)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Relaciones", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Detalle_de_Relacioness.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetCanalizacion_Municipio_Municipio(string query, string where)
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
        public JsonResult GetCanalizacion_Unidad_Unidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Unidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Unidad.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IUnidadApiConsumer.ListaSelAll(1, 20,elWhere , " Unidad.Descripcion ASC ").Resource;
               
                foreach (var item in result.Unidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Unidad", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Unidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(CanalizacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Canalizacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Canalizacion.Clave <= " + filter.ToClave;
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

                where += " AND Canalizacion.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_AT))
            {
                switch (filter.Expediente_ATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '" + filter.AdvanceExpediente_AT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceExpediente_AT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.Folio = '" + filter.AdvanceExpediente_AT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.Folio LIKE '%" + filter.AdvanceExpediente_AT + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_ATMultiple != null && filter.AdvanceExpediente_ATMultiple.Count() > 0)
            {
                var Expediente_ATIds = string.Join(",", filter.AdvanceExpediente_ATMultiple);

                where += " AND Canalizacion.Expediente_AT In (" + Expediente_ATIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Canalizacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Canalizacion))
            {
                var Fecha_de_CanalizacionFrom = DateTime.ParseExact(filter.FromFecha_de_Canalizacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CanalizacionTo = DateTime.ParseExact(filter.ToFecha_de_Canalizacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Canalizacion))
                    where += " AND Canalizacion.Fecha_de_Canalizacion >= '" + Fecha_de_CanalizacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Canalizacion))
                    where += " AND Canalizacion.Fecha_de_Canalizacion <= '" + Fecha_de_CanalizacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Canalizacion) || !string.IsNullOrEmpty(filter.ToHora_de_Canalizacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Canalizacion))
                    where += " AND Convert(TIME,Canalizacion.Hora_de_Canalizacion) >='" + filter.FromHora_de_Canalizacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Canalizacion))
                    where += " AND Convert(TIME,Canalizacion.Hora_de_Canalizacion) <='" + filter.ToHora_de_Canalizacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Canaliza))
            {
                switch (filter.Usuario_que_CanalizaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Canaliza + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Canaliza + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Canaliza + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Canaliza + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_CanalizaMultiple != null && filter.AdvanceUsuario_que_CanalizaMultiple.Count() > 0)
            {
                var Usuario_que_CanalizaIds = string.Join(",", filter.AdvanceUsuario_que_CanalizaMultiple);

                where += " AND Canalizacion.Usuario_que_Canaliza In (" + Usuario_que_CanalizaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRelacion_a_Canalizar))
            {
                switch (filter.Relacion_a_CanalizarFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '" + filter.AdvanceRelacion_a_Canalizar + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceRelacion_a_Canalizar + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Relaciones.Descripcion = '" + filter.AdvanceRelacion_a_Canalizar + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceRelacion_a_Canalizar + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRelacion_a_CanalizarMultiple != null && filter.AdvanceRelacion_a_CanalizarMultiple.Count() > 0)
            {
                var Relacion_a_CanalizarIds = string.Join(",", filter.AdvanceRelacion_a_CanalizarMultiple);

                where += " AND Canalizacion.Relacion_a_Canalizar In (" + Relacion_a_CanalizarIds + ")";
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

                where += " AND Canalizacion.Canalizar_a In (" + Canalizar_aIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio))
            {
                switch (filter.MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioMultiple != null && filter.AdvanceMunicipioMultiple.Count() > 0)
            {
                var MunicipioIds = string.Join(",", filter.AdvanceMunicipioMultiple);

                where += " AND Canalizacion.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad))
            {
                switch (filter.UnidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidadMultiple != null && filter.AdvanceUnidadMultiple.Count() > 0)
            {
                var UnidadIds = string.Join(",", filter.AdvanceUnidadMultiple);

                where += " AND Canalizacion.Unidad In (" + UnidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
            {
                var Fecha_de_ResolucionFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ResolucionTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion))
                    where += " AND Canalizacion.Fecha_de_Resolucion >= '" + Fecha_de_ResolucionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
                    where += " AND Canalizacion.Fecha_de_Resolucion <= '" + Fecha_de_ResolucionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Resolucion) || !string.IsNullOrEmpty(filter.ToHora_de_Resolucion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Resolucion))
                    where += " AND Convert(TIME,Canalizacion.Hora_de_Resolucion) >='" + filter.FromHora_de_Resolucion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Resolucion))
                    where += " AND Convert(TIME,Canalizacion.Hora_de_Resolucion) <='" + filter.ToHora_de_Resolucion + "'";
            }

            if (filter.Hubo_modificacion_en_la_relacion != RadioOptions.NoApply)
                where += " AND Canalizacion.Hubo_modificacion_en_la_relacion = " + Convert.ToInt32(filter.Hubo_modificacion_en_la_relacion);

            if (!string.IsNullOrEmpty(filter.Nueva_Relacion))
            {
                switch (filter.Nueva_RelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Canalizacion.Nueva_Relacion LIKE '" + filter.Nueva_Relacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Canalizacion.Nueva_Relacion LIKE '%" + filter.Nueva_Relacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Canalizacion.Nueva_Relacion = '" + filter.Nueva_Relacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Canalizacion.Nueva_Relacion LIKE '%" + filter.Nueva_Relacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromResolucionId) || !string.IsNullOrEmpty(filter.ToResolucionId))
            {
                if (!string.IsNullOrEmpty(filter.FromResolucionId))
                    where += " AND Canalizacion.ResolucionId >= " + filter.FromResolucionId;
                if (!string.IsNullOrEmpty(filter.ToResolucionId))
                    where += " AND Canalizacion.ResolucionId <= " + filter.ToResolucionId;
            }

            if (!string.IsNullOrEmpty(filter.Resolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Canalizacion.Resolucion LIKE '" + filter.Resolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Canalizacion.Resolucion LIKE '%" + filter.Resolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Canalizacion.Resolucion = '" + filter.Resolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Canalizacion.Resolucion LIKE '%" + filter.Resolucion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Detalle_de_la_Resolucion))
            {
                switch (filter.Detalle_de_la_ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Canalizacion.Detalle_de_la_Resolucion LIKE '" + filter.Detalle_de_la_Resolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Canalizacion.Detalle_de_la_Resolucion LIKE '%" + filter.Detalle_de_la_Resolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Canalizacion.Detalle_de_la_Resolucion = '" + filter.Detalle_de_la_Resolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Canalizacion.Detalle_de_la_Resolucion LIKE '%" + filter.Detalle_de_la_Resolucion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Canalizacion.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Canalizacion.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Canalizacion.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Canalizacion.Observaciones LIKE '%" + filter.Observaciones + "%'";
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

        public ActionResult GetDetalle_Diligencias_Canalizacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Diligencias_CanalizacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Diligencias_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Diligencias_Canalizacion.Canalizacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Diligencias_Canalizacion.Canalizacion='" + RelationId + "'";
            }
            var result = _IDetalle_Diligencias_CanalizacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Diligencias_Canalizacions == null)
                result.Detalle_Diligencias_Canalizacions = new List<Detalle_Diligencias_Canalizacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Diligencias_Canalizacions.Select(m => new Detalle_Diligencias_CanalizacionGridModel
                {
                    Clave = m.Clave

			,Diligencia = m.Diligencia
			,Ver_DocumentoFileInfo = m.Ver_Documento > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Ver_Documento).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Observaciones = m.Observaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Diligencias_CanalizacionGridModel> GetDetalle_Diligencias_CanalizacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Diligencias_CanalizacionGridModel> resultData = new List<Detalle_Diligencias_CanalizacionGridModel>();
            string where = "Detalle_Diligencias_Canalizacion.Canalizacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Diligencias_Canalizacion.Canalizacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Diligencias_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Diligencias_CanalizacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Diligencias_Canalizacions != null)
            {
                resultData = result.Detalle_Diligencias_Canalizacions.Select(m => new Detalle_Diligencias_CanalizacionGridModel
                    {
                        Clave = m.Clave

			,Diligencia = m.Diligencia
			,Ver_DocumentoFileInfo = m.Ver_Documento > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Ver_Documento).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }
			,Observaciones = m.Observaciones


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
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Canalizacion varCanalizacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Diligencias_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Diligencias_Canalizacion.Canalizacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Diligencias_Canalizacion.Canalizacion='" + id + "'";
                    }
                    var Detalle_Diligencias_CanalizacionInfo =
                        _IDetalle_Diligencias_CanalizacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Diligencias_CanalizacionInfo.Detalle_Diligencias_Canalizacions.Count > 0)
                    {
                        var resultDetalle_Diligencias_Canalizacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Diligencias_CanalizacionItem in Detalle_Diligencias_CanalizacionInfo.Detalle_Diligencias_Canalizacions)
                            resultDetalle_Diligencias_Canalizacion = resultDetalle_Diligencias_Canalizacion
                                              && _IDetalle_Diligencias_CanalizacionApiConsumer.Delete(Detalle_Diligencias_CanalizacionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Diligencias_Canalizacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ICanalizacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, CanalizacionModel varCanalizacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var CanalizacionInfo = new Canalizacion
                    {
                        Clave = varCanalizacion.Clave
                        ,Expediente_MP = varCanalizacion.Expediente_MP
                        ,Expediente_AT = varCanalizacion.Expediente_AT
                        ,Fecha_de_Canalizacion = (!String.IsNullOrEmpty(varCanalizacion.Fecha_de_Canalizacion)) ? DateTime.ParseExact(varCanalizacion.Fecha_de_Canalizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Canalizacion = varCanalizacion.Hora_de_Canalizacion
                        ,Usuario_que_Canaliza = varCanalizacion.Usuario_que_Canaliza
                        ,Relacion_a_Canalizar = varCanalizacion.Relacion_a_Canalizar
                        ,Canalizar_a = varCanalizacion.Canalizar_a
                        ,Municipio = varCanalizacion.Municipio
                        ,Unidad = varCanalizacion.Unidad
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varCanalizacion.Fecha_de_Resolucion)) ? DateTime.ParseExact(varCanalizacion.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Resolucion = varCanalizacion.Hora_de_Resolucion
                        ,Hubo_modificacion_en_la_relacion = varCanalizacion.Hubo_modificacion_en_la_relacion
                        ,Nueva_Relacion = varCanalizacion.Nueva_Relacion
                        ,ResolucionId = varCanalizacion.ResolucionId
                        ,Resolucion = varCanalizacion.Resolucion
                        ,Detalle_de_la_Resolucion = varCanalizacion.Detalle_de_la_Resolucion
                        ,Observaciones = varCanalizacion.Observaciones

                    };

                    result = !IsNew ?
                        _ICanalizacionApiConsumer.Update(CanalizacionInfo, null, null).Resource.ToString() :
                         _ICanalizacionApiConsumer.Insert(CanalizacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Diligencias_Canalizacion(int MasterId, int referenceId, List<Detalle_Diligencias_CanalizacionGridModelPost> Detalle_Diligencias_CanalizacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Diligencias_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Diligencias_CanalizacionData = _IDetalle_Diligencias_CanalizacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Diligencias_Canalizacion.Canalizacion=" + referenceId,"").Resource;
                if (Detalle_Diligencias_CanalizacionData == null || Detalle_Diligencias_CanalizacionData.Detalle_Diligencias_Canalizacions.Count == 0)
                    return true;

                var result = true;

                Detalle_Diligencias_CanalizacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Diligencias_Canalizacion in Detalle_Diligencias_CanalizacionData.Detalle_Diligencias_Canalizacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Diligencias_Canalizacion Detalle_Diligencias_Canalizacion1 = varDetalle_Diligencias_Canalizacion;

                    if (Detalle_Diligencias_CanalizacionItems != null && Detalle_Diligencias_CanalizacionItems.Any(m => m.Clave == Detalle_Diligencias_Canalizacion1.Clave))
                    {
                        modelDataToChange = Detalle_Diligencias_CanalizacionItems.FirstOrDefault(m => m.Clave == Detalle_Diligencias_Canalizacion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Diligencias_Canalizacion.Canalizacion = MasterId;
                    var insertId = _IDetalle_Diligencias_CanalizacionApiConsumer.Insert(varDetalle_Diligencias_Canalizacion,null,null).Resource;
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
        public ActionResult PostDetalle_Diligencias_Canalizacion(List<Detalle_Diligencias_CanalizacionGridModelPost> Detalle_Diligencias_CanalizacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Diligencias_Canalizacion(MasterId, referenceId, Detalle_Diligencias_CanalizacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Diligencias_CanalizacionItems != null && Detalle_Diligencias_CanalizacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Diligencias_CanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Diligencias_CanalizacionItem in Detalle_Diligencias_CanalizacionItems)
                    {


                        #region Ver_DocumentoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.Control != null && !Detalle_Diligencias_CanalizacionItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.Control);
                            Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_Diligencias_CanalizacionItem.Removed && Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.RemoveFile)
                        {
                            Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.FileId = 0;
                        }
                        #endregion Ver_DocumentoInfo


                        //Removal Request
                        if (Detalle_Diligencias_CanalizacionItem.Removed)
                        {
                            result = result && _IDetalle_Diligencias_CanalizacionApiConsumer.Delete(Detalle_Diligencias_CanalizacionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Diligencias_CanalizacionItem.Clave = 0;

                        var Detalle_Diligencias_CanalizacionData = new Detalle_Diligencias_Canalizacion
                        {
                            Canalizacion = MasterId
                            ,Clave = Detalle_Diligencias_CanalizacionItem.Clave
                            ,Diligencia = Detalle_Diligencias_CanalizacionItem.Diligencia
                            ,Ver_Documento = Detalle_Diligencias_CanalizacionItem.Ver_DocumentoInfo.FileId
                            ,Observaciones = Detalle_Diligencias_CanalizacionItem.Observaciones

                        };

                        var resultId = Detalle_Diligencias_CanalizacionItem.Clave > 0
                           ? _IDetalle_Diligencias_CanalizacionApiConsumer.Update(Detalle_Diligencias_CanalizacionData,null,null).Resource
                           : _IDetalle_Diligencias_CanalizacionApiConsumer.Insert(Detalle_Diligencias_CanalizacionData,null,null).Resource;

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
        /// Write Element Array of Canalizacion script
        /// </summary>
        /// <param name="oCanalizacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew CanalizacionModuleAttributeList)
        {
            for (int i = 0; i < CanalizacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(CanalizacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    CanalizacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(CanalizacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    CanalizacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (CanalizacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < CanalizacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < CanalizacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(CanalizacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							CanalizacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(CanalizacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							CanalizacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strCanalizacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Canalizacion.js")))
            {
                strCanalizacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Canalizacion element attributes
            string userChangeJson = jsSerialize.Serialize(CanalizacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCanalizacionScript.IndexOf("inpuElementArray");
            string splittedString = strCanalizacionScript.Substring(indexOfArray, strCanalizacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(CanalizacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (CanalizacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCanalizacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strCanalizacionScript.Substring(indexOfArrayHistory, strCanalizacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strCanalizacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCanalizacionScript.Substring(endIndexOfMainElement + indexOfArray, strCanalizacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (CanalizacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in CanalizacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Canalizacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Canalizacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Canalizacion.js")))
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
        public ActionResult CanalizacionPropertyBag()
        {
            return PartialView("CanalizacionPropertyBag", "Canalizacion");
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
        public ActionResult AddDetalle_Diligencias_Canalizacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Diligencias_Canalizacion/AddDetalle_Diligencias_Canalizacion");
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
                var whereClauseFormat = "Object = 45703 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Canalizacion.Clave= " + RecordId;
                            var result = _ICanalizacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new CanalizacionPropertyMapper());
			
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
                    (CanalizacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            CanalizacionPropertyMapper oCanalizacionPropertyMapper = new CanalizacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCanalizacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICanalizacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Canalizacions == null)
                result.Canalizacions = new List<Canalizacion>();

            var data = result.Canalizacions.Select(m => new CanalizacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_ATFolio = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.Folio
                        ,Fecha_de_Canalizacion = (m.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Canalizacion = m.Hora_de_Canalizacion
                        ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(m.Usuario_que_Canaliza_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Canaliza_Spartan_User.Name
                        ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(m.Relacion_a_Canalizar_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion = m.Hora_de_Resolucion
			,Hubo_modificacion_en_la_relacion = m.Hubo_modificacion_en_la_relacion
			,Nueva_Relacion = m.Nueva_Relacion
			,ResolucionId = m.ResolucionId
			,Resolucion = m.Resolucion
			,Detalle_de_la_Resolucion = m.Detalle_de_la_Resolucion
			,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45703, arrayColumnsVisible), "CanalizacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45703, arrayColumnsVisible), "CanalizacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45703, arrayColumnsVisible), "CanalizacionList_" + DateTime.Now.ToString());
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

            _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new CanalizacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (CanalizacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            CanalizacionPropertyMapper oCanalizacionPropertyMapper = new CanalizacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCanalizacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICanalizacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Canalizacions == null)
                result.Canalizacions = new List<Canalizacion>();

            var data = result.Canalizacions.Select(m => new CanalizacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_ATFolio = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.Folio
                        ,Fecha_de_Canalizacion = (m.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Canalizacion = m.Hora_de_Canalizacion
                        ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(m.Usuario_que_Canaliza_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Canaliza_Spartan_User.Name
                        ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(m.Relacion_a_Canalizar_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion = m.Hora_de_Resolucion
			,Hubo_modificacion_en_la_relacion = m.Hubo_modificacion_en_la_relacion
			,Nueva_Relacion = m.Nueva_Relacion
			,ResolucionId = m.ResolucionId
			,Resolucion = m.Resolucion
			,Detalle_de_la_Resolucion = m.Detalle_de_la_Resolucion
			,Observaciones = m.Observaciones

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
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICanalizacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Canalizacion_Datos_GeneralesModel varCanalizacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Canalizacion_Datos_GeneralesInfo = new Canalizacion_Datos_Generales
                {
                    Clave = varCanalizacion.Clave
                                            ,Expediente_MP = varCanalizacion.Expediente_MP
                        ,Expediente_AT = varCanalizacion.Expediente_AT
                        ,Fecha_de_Canalizacion = (!String.IsNullOrEmpty(varCanalizacion.Fecha_de_Canalizacion)) ? DateTime.ParseExact(varCanalizacion.Fecha_de_Canalizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Canalizacion = varCanalizacion.Hora_de_Canalizacion
                        ,Usuario_que_Canaliza = varCanalizacion.Usuario_que_Canaliza
                        ,Relacion_a_Canalizar = varCanalizacion.Relacion_a_Canalizar
                        ,Canalizar_a = varCanalizacion.Canalizar_a
                        ,Municipio = varCanalizacion.Municipio
                        ,Unidad = varCanalizacion.Unidad
                    
                };

                result = _ICanalizacionApiConsumer.Update_Datos_Generales(Canalizacion_Datos_GeneralesInfo).Resource.ToString();
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
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICanalizacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Diligencias_Canalizacion;
                var Detalle_Diligencias_CanalizacionData = GetDetalle_Diligencias_CanalizacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Diligencias_Canalizacion);

                var result = new Canalizacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Expediente_AT = m.Expediente_AT
                        ,Expediente_ATFolio = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.Folio
                        ,Fecha_de_Canalizacion = (m.Fecha_de_Canalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Canalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Canalizacion = m.Hora_de_Canalizacion
                        ,Usuario_que_Canaliza = m.Usuario_que_Canaliza
                        ,Usuario_que_CanalizaName = CultureHelper.GetTraduction(m.Usuario_que_Canaliza_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Canaliza_Spartan_User.Name
                        ,Relacion_a_Canalizar = m.Relacion_a_Canalizar
                        ,Relacion_a_CanalizarDescripcion = CultureHelper.GetTraduction(m.Relacion_a_Canalizar_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_a_Canalizar_Detalle_de_Relaciones.Descripcion
                        ,Canalizar_a = m.Canalizar_a
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_Estatus_Orientador.Descripcion
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Unidad_Unidad.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Diligencias_Generadas = Detalle_Diligencias_CanalizacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion(Canalizacion_ResolucionModel varCanalizacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Canalizacion_ResolucionInfo = new Canalizacion_Resolucion
                {
                    Clave = varCanalizacion.Clave
                                            ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varCanalizacion.Fecha_de_Resolucion)) ? DateTime.ParseExact(varCanalizacion.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Resolucion = varCanalizacion.Hora_de_Resolucion
                        ,Hubo_modificacion_en_la_relacion = varCanalizacion.Hubo_modificacion_en_la_relacion
                        ,Nueva_Relacion = varCanalizacion.Nueva_Relacion
                        ,ResolucionId = varCanalizacion.ResolucionId
                        ,Resolucion = varCanalizacion.Resolucion
                        ,Detalle_de_la_Resolucion = varCanalizacion.Detalle_de_la_Resolucion
                        ,Observaciones = varCanalizacion.Observaciones
                    
                };

                result = _ICanalizacionApiConsumer.Update_Resolucion(Canalizacion_ResolucionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICanalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICanalizacionApiConsumer.Get_Resolucion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Diligencias_Canalizacion;
                var Detalle_Diligencias_CanalizacionData = GetDetalle_Diligencias_CanalizacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Diligencias_Canalizacion);

                var result = new Canalizacion_ResolucionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Resolucion = m.Hora_de_Resolucion
			,Hubo_modificacion_en_la_relacion = m.Hubo_modificacion_en_la_relacion
			,Nueva_Relacion = m.Nueva_Relacion
			,ResolucionId = m.ResolucionId
			,Resolucion = m.Resolucion
			,Detalle_de_la_Resolucion = m.Detalle_de_la_Resolucion
			,Observaciones = m.Observaciones

                    
                };
				var resultData = new
                {
                    data = result
                    ,Diligencias_Generadas = Detalle_Diligencias_CanalizacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

