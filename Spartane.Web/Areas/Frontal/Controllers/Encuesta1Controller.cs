using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Encuesta1;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Catalogo_Respuesta;
using Spartane.Core.Domain.Estatus_Encuesta;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Encuesta1;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Encuesta1;
using Spartane.Web.Areas.WebApiConsumer.Estatus;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Numero_de_Preguntas;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Encuesta;

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
    public class Encuesta1Controller : Controller
    {
        #region "variable declaration"

        private IEncuesta1Service service = null;
        private IEncuesta1ApiConsumer _IEncuesta1ApiConsumer;
        private IEstatusApiConsumer _IEstatusApiConsumer;
        private ICatalogo_Numero_de_PreguntasApiConsumer _ICatalogo_Numero_de_PreguntasApiConsumer;
        private ICatalogo_RespuestaApiConsumer _ICatalogo_RespuestaApiConsumer;
        private IEstatus_EncuestaApiConsumer _IEstatus_EncuestaApiConsumer;

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

        
        public Encuesta1Controller(IEncuesta1Service service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IEncuesta1ApiConsumer Encuesta1ApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IEstatusApiConsumer EstatusApiConsumer , ICatalogo_Numero_de_PreguntasApiConsumer Catalogo_Numero_de_PreguntasApiConsumer , ICatalogo_RespuestaApiConsumer Catalogo_RespuestaApiConsumer , IEstatus_EncuestaApiConsumer Estatus_EncuestaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IEncuesta1ApiConsumer = Encuesta1ApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IEstatusApiConsumer = EstatusApiConsumer;
            this._ICatalogo_Numero_de_PreguntasApiConsumer = Catalogo_Numero_de_PreguntasApiConsumer;
            this._ICatalogo_RespuestaApiConsumer = Catalogo_RespuestaApiConsumer;
            this._ICatalogo_RespuestaApiConsumer = Catalogo_RespuestaApiConsumer;
            this._ICatalogo_RespuestaApiConsumer = Catalogo_RespuestaApiConsumer;
            this._ICatalogo_RespuestaApiConsumer = Catalogo_RespuestaApiConsumer;
            this._ICatalogo_RespuestaApiConsumer = Catalogo_RespuestaApiConsumer;
            this._IEstatus_EncuestaApiConsumer = Estatus_EncuestaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Encuesta1
        [ObjectAuth(ObjectId = (ModuleObjectId)45129, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45129, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Encuesta1/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45129, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45129, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varEncuesta1 = new Encuesta1Model();
			varEncuesta1.Clave = Id;
			
            ViewBag.ObjectId = "45129";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Encuesta1sData = _IEncuesta1ApiConsumer.ListaSelAll(0, 1000, "Encuesta1.Clave=" + Id, "").Resource.Encuesta1s;
				
				if (Encuesta1sData != null && Encuesta1sData.Count > 0)
                {
					var Encuesta1Data = Encuesta1sData.First();
					varEncuesta1= new Encuesta1Model
					{
						Clave  = Encuesta1Data.Clave 
	                    ,Folio = Encuesta1Data.Folio
                    ,Fecha_Enviado = (Encuesta1Data.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(Encuesta1Data.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Enviado = Encuesta1Data.Hora_Enviado
                    ,Fecha_Respuesta = (Encuesta1Data.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(Encuesta1Data.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Respuesta = Encuesta1Data.Hora_Respuesta
                    ,NUAT = Encuesta1Data.NUAT
                    ,Modulo = Encuesta1Data.Modulo
                    ,ModuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Modulo), "Estatus") ??  (string)Encuesta1Data.Modulo_Estatus.Descripcion
                    ,Numero_de_Preguntas = Encuesta1Data.Numero_de_Preguntas
                    ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Numero_de_Preguntas), "Catalogo_Numero_de_Preguntas") ??  (string)Encuesta1Data.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
                    ,Pregunta1 = Encuesta1Data.Pregunta1
                    ,Respuesta_1 = Encuesta1Data.Respuesta_1
                    ,Respuesta_1Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_1), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_1_Catalogo_Respuesta.Descripcion
                    ,Pregunta2 = Encuesta1Data.Pregunta2
                    ,Respuesta_2 = Encuesta1Data.Respuesta_2
                    ,Respuesta_2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_2), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_2_Catalogo_Respuesta.Descripcion
                    ,Pregunta3 = Encuesta1Data.Pregunta3
                    ,Respuesta_3 = Encuesta1Data.Respuesta_3
                    ,Respuesta_3Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_3), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_3_Catalogo_Respuesta.Descripcion
                    ,Pregunta4 = Encuesta1Data.Pregunta4
                    ,Respuesta_4 = Encuesta1Data.Respuesta_4
                    ,Respuesta_4Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_4), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_4_Catalogo_Respuesta.Descripcion
                    ,Pregunta5 = Encuesta1Data.Pregunta5
                    ,Respuesta_5 = Encuesta1Data.Respuesta_5
                    ,Respuesta_5Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_5), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_5_Catalogo_Respuesta.Descripcion
                    ,Estatus = Encuesta1Data.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Estatus), "Estatus_Encuesta") ??  (string)Encuesta1Data.Estatus_Estatus_Encuesta.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Modulo = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Modulo != null && Estatuss_Modulo.Resource != null)
                ViewBag.Estatuss_Modulo = Estatuss_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Numero_de_PreguntasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = _ICatalogo_Numero_de_PreguntasApiConsumer.SelAll(true);
            if (Catalogo_Numero_de_Preguntass_Numero_de_Preguntas != null && Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource != null)
                ViewBag.Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Numero_de_Preguntas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_1 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_1 != null && Catalogo_Respuestas_Respuesta_1.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_1 = Catalogo_Respuestas_Respuesta_1.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_2 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_2 != null && Catalogo_Respuestas_Respuesta_2.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_2 = Catalogo_Respuestas_Respuesta_2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_3 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_3 != null && Catalogo_Respuestas_Respuesta_3.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_3 = Catalogo_Respuestas_Respuesta_3.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_4 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_4 != null && Catalogo_Respuestas_Respuesta_4.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_4 = Catalogo_Respuestas_Respuesta_4.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_5 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_5 != null && Catalogo_Respuestas_Respuesta_5.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_5 = Catalogo_Respuestas_Respuesta_5.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Encuestas_Estatus = _IEstatus_EncuestaApiConsumer.SelAll(true);
            if (Estatus_Encuestas_Estatus != null && Estatus_Encuestas_Estatus.Resource != null)
                ViewBag.Estatus_Encuestas_Estatus = Estatus_Encuestas_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varEncuesta1);
        }
		
	[HttpGet]
        public ActionResult AddEncuesta1(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45129);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
			Encuesta1Model varEncuesta1= new Encuesta1Model();


            if (id.ToString() != "0")
            {
                var Encuesta1sData = _IEncuesta1ApiConsumer.ListaSelAll(0, 1000, "Encuesta1.Clave=" + id, "").Resource.Encuesta1s;
				
				if (Encuesta1sData != null && Encuesta1sData.Count > 0)
                {
					var Encuesta1Data = Encuesta1sData.First();
					varEncuesta1= new Encuesta1Model
					{
						Clave  = Encuesta1Data.Clave 
	                    ,Folio = Encuesta1Data.Folio
                    ,Fecha_Enviado = (Encuesta1Data.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(Encuesta1Data.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Enviado = Encuesta1Data.Hora_Enviado
                    ,Fecha_Respuesta = (Encuesta1Data.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(Encuesta1Data.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Respuesta = Encuesta1Data.Hora_Respuesta
                    ,NUAT = Encuesta1Data.NUAT
                    ,Modulo = Encuesta1Data.Modulo
                    ,ModuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Modulo), "Estatus") ??  (string)Encuesta1Data.Modulo_Estatus.Descripcion
                    ,Numero_de_Preguntas = Encuesta1Data.Numero_de_Preguntas
                    ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Numero_de_Preguntas), "Catalogo_Numero_de_Preguntas") ??  (string)Encuesta1Data.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
                    ,Pregunta1 = Encuesta1Data.Pregunta1
                    ,Respuesta_1 = Encuesta1Data.Respuesta_1
                    ,Respuesta_1Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_1), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_1_Catalogo_Respuesta.Descripcion
                    ,Pregunta2 = Encuesta1Data.Pregunta2
                    ,Respuesta_2 = Encuesta1Data.Respuesta_2
                    ,Respuesta_2Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_2), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_2_Catalogo_Respuesta.Descripcion
                    ,Pregunta3 = Encuesta1Data.Pregunta3
                    ,Respuesta_3 = Encuesta1Data.Respuesta_3
                    ,Respuesta_3Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_3), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_3_Catalogo_Respuesta.Descripcion
                    ,Pregunta4 = Encuesta1Data.Pregunta4
                    ,Respuesta_4 = Encuesta1Data.Respuesta_4
                    ,Respuesta_4Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_4), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_4_Catalogo_Respuesta.Descripcion
                    ,Pregunta5 = Encuesta1Data.Pregunta5
                    ,Respuesta_5 = Encuesta1Data.Respuesta_5
                    ,Respuesta_5Descripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Respuesta_5), "Catalogo_Respuesta") ??  (string)Encuesta1Data.Respuesta_5_Catalogo_Respuesta.Descripcion
                    ,Estatus = Encuesta1Data.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Encuesta1Data.Estatus), "Estatus_Encuesta") ??  (string)Encuesta1Data.Estatus_Estatus_Encuesta.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Modulo = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Modulo != null && Estatuss_Modulo.Resource != null)
                ViewBag.Estatuss_Modulo = Estatuss_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Numero_de_PreguntasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = _ICatalogo_Numero_de_PreguntasApiConsumer.SelAll(true);
            if (Catalogo_Numero_de_Preguntass_Numero_de_Preguntas != null && Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource != null)
                ViewBag.Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Numero_de_Preguntas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_1 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_1 != null && Catalogo_Respuestas_Respuesta_1.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_1 = Catalogo_Respuestas_Respuesta_1.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_2 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_2 != null && Catalogo_Respuestas_Respuesta_2.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_2 = Catalogo_Respuestas_Respuesta_2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_3 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_3 != null && Catalogo_Respuestas_Respuesta_3.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_3 = Catalogo_Respuestas_Respuesta_3.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_4 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_4 != null && Catalogo_Respuestas_Respuesta_4.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_4 = Catalogo_Respuestas_Respuesta_4.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_5 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_5 != null && Catalogo_Respuestas_Respuesta_5.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_5 = Catalogo_Respuestas_Respuesta_5.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Encuestas_Estatus = _IEstatus_EncuestaApiConsumer.SelAll(true);
            if (Estatus_Encuestas_Estatus != null && Estatus_Encuestas_Estatus.Resource != null)
                ViewBag.Estatus_Encuestas_Estatus = Estatus_Encuestas_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddEncuesta1", varEncuesta1);
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
        public ActionResult GetEstatusAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatusApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Numero_de_PreguntasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Numero_de_PreguntasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Numero_de_PreguntasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Numero_de_Preguntas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_RespuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_RespuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_EncuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_EncuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Encuesta", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Encuesta1AdvanceSearchModel model, int idFilter = -1)
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

            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Modulo = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Modulo != null && Estatuss_Modulo.Resource != null)
                ViewBag.Estatuss_Modulo = Estatuss_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Numero_de_PreguntasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = _ICatalogo_Numero_de_PreguntasApiConsumer.SelAll(true);
            if (Catalogo_Numero_de_Preguntass_Numero_de_Preguntas != null && Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource != null)
                ViewBag.Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Numero_de_Preguntas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_1 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_1 != null && Catalogo_Respuestas_Respuesta_1.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_1 = Catalogo_Respuestas_Respuesta_1.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_2 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_2 != null && Catalogo_Respuestas_Respuesta_2.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_2 = Catalogo_Respuestas_Respuesta_2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_3 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_3 != null && Catalogo_Respuestas_Respuesta_3.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_3 = Catalogo_Respuestas_Respuesta_3.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_4 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_4 != null && Catalogo_Respuestas_Respuesta_4.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_4 = Catalogo_Respuestas_Respuesta_4.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_5 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_5 != null && Catalogo_Respuestas_Respuesta_5.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_5 = Catalogo_Respuestas_Respuesta_5.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Encuestas_Estatus = _IEstatus_EncuestaApiConsumer.SelAll(true);
            if (Estatus_Encuestas_Estatus != null && Estatus_Encuestas_Estatus.Resource != null)
                ViewBag.Estatus_Encuestas_Estatus = Estatus_Encuestas_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Modulo = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Modulo != null && Estatuss_Modulo.Resource != null)
                ViewBag.Estatuss_Modulo = Estatuss_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Numero_de_PreguntasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = _ICatalogo_Numero_de_PreguntasApiConsumer.SelAll(true);
            if (Catalogo_Numero_de_Preguntass_Numero_de_Preguntas != null && Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource != null)
                ViewBag.Catalogo_Numero_de_Preguntass_Numero_de_Preguntas = Catalogo_Numero_de_Preguntass_Numero_de_Preguntas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Numero_de_Preguntas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_1 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_1 != null && Catalogo_Respuestas_Respuesta_1.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_1 = Catalogo_Respuestas_Respuesta_1.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_2 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_2 != null && Catalogo_Respuestas_Respuesta_2.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_2 = Catalogo_Respuestas_Respuesta_2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_3 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_3 != null && Catalogo_Respuestas_Respuesta_3.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_3 = Catalogo_Respuestas_Respuesta_3.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_4 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_4 != null && Catalogo_Respuestas_Respuesta_4.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_4 = Catalogo_Respuestas_Respuesta_4.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_RespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Respuestas_Respuesta_5 = _ICatalogo_RespuestaApiConsumer.SelAll(true);
            if (Catalogo_Respuestas_Respuesta_5 != null && Catalogo_Respuestas_Respuesta_5.Resource != null)
                ViewBag.Catalogo_Respuestas_Respuesta_5 = Catalogo_Respuestas_Respuesta_5.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_EncuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Encuestas_Estatus = _IEstatus_EncuestaApiConsumer.SelAll(true);
            if (Estatus_Encuestas_Estatus != null && Estatus_Encuestas_Estatus.Resource != null)
                ViewBag.Estatus_Encuestas_Estatus = Estatus_Encuestas_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Encuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Encuesta1AdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Encuesta1AdvanceSearchModel)(Session["AdvanceSearch"] ?? new Encuesta1AdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Encuesta1PropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IEncuesta1ApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Encuesta1s == null)
                result.Encuesta1s = new List<Encuesta1>();

            return Json(new
            {
                data = result.Encuesta1s.Select(m => new Encuesta1GridModel
                    {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_Enviado = (m.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(m.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
			,Hora_Enviado = m.Hora_Enviado
                        ,Fecha_Respuesta = (m.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(m.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
			,Hora_Respuesta = m.Hora_Respuesta
			,NUAT = m.NUAT
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Estatus.Descripcion
                        ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
			,Pregunta1 = m.Pregunta1
                        ,Respuesta_1Descripcion = CultureHelper.GetTraduction(m.Respuesta_1_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_1_Catalogo_Respuesta.Descripcion
			,Pregunta2 = m.Pregunta2
                        ,Respuesta_2Descripcion = CultureHelper.GetTraduction(m.Respuesta_2_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_2_Catalogo_Respuesta.Descripcion
			,Pregunta3 = m.Pregunta3
                        ,Respuesta_3Descripcion = CultureHelper.GetTraduction(m.Respuesta_3_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_3_Catalogo_Respuesta.Descripcion
			,Pregunta4 = m.Pregunta4
                        ,Respuesta_4Descripcion = CultureHelper.GetTraduction(m.Respuesta_4_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_4_Catalogo_Respuesta.Descripcion
			,Pregunta5 = m.Pregunta5
                        ,Respuesta_5Descripcion = CultureHelper.GetTraduction(m.Respuesta_5_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_5_Catalogo_Respuesta.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Encuesta.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetEncuesta1All()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEncuesta1ApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Encuesta1", m.),
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
        /// Get List of Encuesta1 from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Encuesta1 Entity</returns>
        public ActionResult GetEncuesta1List(UrlParametersModel param)
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
            _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Encuesta1PropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Encuesta1AdvanceSearchModel))
                {
					var advanceFilter =
                    (Encuesta1AdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Encuesta1PropertyMapper oEncuesta1PropertyMapper = new Encuesta1PropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oEncuesta1PropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IEncuesta1ApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Encuesta1s == null)
                result.Encuesta1s = new List<Encuesta1>();

            return Json(new
            {
                aaData = result.Encuesta1s.Select(m => new Encuesta1GridModel
            {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_Enviado = (m.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(m.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
			,Hora_Enviado = m.Hora_Enviado
                        ,Fecha_Respuesta = (m.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(m.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
			,Hora_Respuesta = m.Hora_Respuesta
			,NUAT = m.NUAT
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Estatus.Descripcion
                        ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
			,Pregunta1 = m.Pregunta1
                        ,Respuesta_1Descripcion = CultureHelper.GetTraduction(m.Respuesta_1_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_1_Catalogo_Respuesta.Descripcion
			,Pregunta2 = m.Pregunta2
                        ,Respuesta_2Descripcion = CultureHelper.GetTraduction(m.Respuesta_2_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_2_Catalogo_Respuesta.Descripcion
			,Pregunta3 = m.Pregunta3
                        ,Respuesta_3Descripcion = CultureHelper.GetTraduction(m.Respuesta_3_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_3_Catalogo_Respuesta.Descripcion
			,Pregunta4 = m.Pregunta4
                        ,Respuesta_4Descripcion = CultureHelper.GetTraduction(m.Respuesta_4_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_4_Catalogo_Respuesta.Descripcion
			,Pregunta5 = m.Pregunta5
                        ,Respuesta_5Descripcion = CultureHelper.GetTraduction(m.Respuesta_5_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_5_Catalogo_Respuesta.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Encuesta.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Encuesta1AdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Encuesta1.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Encuesta1.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Folio))
            {
                switch (filter.FolioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Folio LIKE '" + filter.Folio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Folio LIKE '%" + filter.Folio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Folio = '" + filter.Folio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Folio LIKE '%" + filter.Folio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Enviado) || !string.IsNullOrEmpty(filter.ToFecha_Enviado))
            {
                var Fecha_EnviadoFrom = DateTime.ParseExact(filter.FromFecha_Enviado, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_EnviadoTo = DateTime.ParseExact(filter.ToFecha_Enviado, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Enviado))
                    where += " AND Encuesta1.Fecha_Enviado >= '" + Fecha_EnviadoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Enviado))
                    where += " AND Encuesta1.Fecha_Enviado <= '" + Fecha_EnviadoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Enviado) || !string.IsNullOrEmpty(filter.ToHora_Enviado))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Enviado))
                    where += " AND Convert(TIME,Encuesta1.Hora_Enviado) >='" + filter.FromHora_Enviado + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Enviado))
                    where += " AND Convert(TIME,Encuesta1.Hora_Enviado) <='" + filter.ToHora_Enviado + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Respuesta) || !string.IsNullOrEmpty(filter.ToFecha_Respuesta))
            {
                var Fecha_RespuestaFrom = DateTime.ParseExact(filter.FromFecha_Respuesta, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_RespuestaTo = DateTime.ParseExact(filter.ToFecha_Respuesta, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Respuesta))
                    where += " AND Encuesta1.Fecha_Respuesta >= '" + Fecha_RespuestaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Respuesta))
                    where += " AND Encuesta1.Fecha_Respuesta <= '" + Fecha_RespuestaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Respuesta) || !string.IsNullOrEmpty(filter.ToHora_Respuesta))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Respuesta))
                    where += " AND Convert(TIME,Encuesta1.Hora_Respuesta) >='" + filter.FromHora_Respuesta + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Respuesta))
                    where += " AND Convert(TIME,Encuesta1.Hora_Respuesta) <='" + filter.ToHora_Respuesta + "'";
            }

            if (!string.IsNullOrEmpty(filter.NUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.NUAT LIKE '" + filter.NUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.NUAT LIKE '%" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.NUAT = '" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.NUAT LIKE '%" + filter.NUAT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo))
            {
                switch (filter.ModuloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus.Descripcion LIKE '" + filter.AdvanceModulo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceModulo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus.Descripcion = '" + filter.AdvanceModulo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceModulo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModuloMultiple != null && filter.AdvanceModuloMultiple.Count() > 0)
            {
                var ModuloIds = string.Join(",", filter.AdvanceModuloMultiple);

                where += " AND Encuesta1.Modulo In (" + ModuloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Preguntas))
            {
                switch (filter.Numero_de_PreguntasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Numero_de_Preguntas.Descripcion LIKE '" + filter.AdvanceNumero_de_Preguntas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Numero_de_Preguntas.Descripcion LIKE '%" + filter.AdvanceNumero_de_Preguntas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Numero_de_Preguntas.Descripcion = '" + filter.AdvanceNumero_de_Preguntas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Numero_de_Preguntas.Descripcion LIKE '%" + filter.AdvanceNumero_de_Preguntas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_PreguntasMultiple != null && filter.AdvanceNumero_de_PreguntasMultiple.Count() > 0)
            {
                var Numero_de_PreguntasIds = string.Join(",", filter.AdvanceNumero_de_PreguntasMultiple);

                where += " AND Encuesta1.Numero_de_Preguntas In (" + Numero_de_PreguntasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Pregunta1))
            {
                switch (filter.Pregunta1Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Pregunta1 LIKE '" + filter.Pregunta1 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Pregunta1 LIKE '%" + filter.Pregunta1 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Pregunta1 = '" + filter.Pregunta1 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Pregunta1 LIKE '%" + filter.Pregunta1 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRespuesta_1))
            {
                switch (filter.Respuesta_1Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '" + filter.AdvanceRespuesta_1 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_1 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Respuesta.Descripcion = '" + filter.AdvanceRespuesta_1 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_1 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRespuesta_1Multiple != null && filter.AdvanceRespuesta_1Multiple.Count() > 0)
            {
                var Respuesta_1Ids = string.Join(",", filter.AdvanceRespuesta_1Multiple);

                where += " AND Encuesta1.Respuesta_1 In (" + Respuesta_1Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Pregunta2))
            {
                switch (filter.Pregunta2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Pregunta2 LIKE '" + filter.Pregunta2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Pregunta2 LIKE '%" + filter.Pregunta2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Pregunta2 = '" + filter.Pregunta2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Pregunta2 LIKE '%" + filter.Pregunta2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRespuesta_2))
            {
                switch (filter.Respuesta_2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '" + filter.AdvanceRespuesta_2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Respuesta.Descripcion = '" + filter.AdvanceRespuesta_2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRespuesta_2Multiple != null && filter.AdvanceRespuesta_2Multiple.Count() > 0)
            {
                var Respuesta_2Ids = string.Join(",", filter.AdvanceRespuesta_2Multiple);

                where += " AND Encuesta1.Respuesta_2 In (" + Respuesta_2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Pregunta3))
            {
                switch (filter.Pregunta3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Pregunta3 LIKE '" + filter.Pregunta3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Pregunta3 LIKE '%" + filter.Pregunta3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Pregunta3 = '" + filter.Pregunta3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Pregunta3 LIKE '%" + filter.Pregunta3 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRespuesta_3))
            {
                switch (filter.Respuesta_3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '" + filter.AdvanceRespuesta_3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Respuesta.Descripcion = '" + filter.AdvanceRespuesta_3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_3 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRespuesta_3Multiple != null && filter.AdvanceRespuesta_3Multiple.Count() > 0)
            {
                var Respuesta_3Ids = string.Join(",", filter.AdvanceRespuesta_3Multiple);

                where += " AND Encuesta1.Respuesta_3 In (" + Respuesta_3Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Pregunta4))
            {
                switch (filter.Pregunta4Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Pregunta4 LIKE '" + filter.Pregunta4 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Pregunta4 LIKE '%" + filter.Pregunta4 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Pregunta4 = '" + filter.Pregunta4 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Pregunta4 LIKE '%" + filter.Pregunta4 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRespuesta_4))
            {
                switch (filter.Respuesta_4Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '" + filter.AdvanceRespuesta_4 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_4 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Respuesta.Descripcion = '" + filter.AdvanceRespuesta_4 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_4 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRespuesta_4Multiple != null && filter.AdvanceRespuesta_4Multiple.Count() > 0)
            {
                var Respuesta_4Ids = string.Join(",", filter.AdvanceRespuesta_4Multiple);

                where += " AND Encuesta1.Respuesta_4 In (" + Respuesta_4Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Pregunta5))
            {
                switch (filter.Pregunta5Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Encuesta1.Pregunta5 LIKE '" + filter.Pregunta5 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Encuesta1.Pregunta5 LIKE '%" + filter.Pregunta5 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Encuesta1.Pregunta5 = '" + filter.Pregunta5 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Encuesta1.Pregunta5 LIKE '%" + filter.Pregunta5 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRespuesta_5))
            {
                switch (filter.Respuesta_5Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '" + filter.AdvanceRespuesta_5 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_5 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Respuesta.Descripcion = '" + filter.AdvanceRespuesta_5 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Respuesta.Descripcion LIKE '%" + filter.AdvanceRespuesta_5 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRespuesta_5Multiple != null && filter.AdvanceRespuesta_5Multiple.Count() > 0)
            {
                var Respuesta_5Ids = string.Join(",", filter.AdvanceRespuesta_5Multiple);

                where += " AND Encuesta1.Respuesta_5 In (" + Respuesta_5Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Encuesta.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Encuesta.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Encuesta.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Encuesta.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Encuesta1.Estatus In (" + EstatusIds + ")";
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
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);

                Encuesta1 varEncuesta1 = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IEncuesta1ApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Encuesta1Model varEncuesta1)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Encuesta1Info = new Encuesta1
                    {
                        Clave = varEncuesta1.Clave
                        ,Folio = varEncuesta1.Folio
                        ,Fecha_Enviado = (!String.IsNullOrEmpty(varEncuesta1.Fecha_Enviado)) ? DateTime.ParseExact(varEncuesta1.Fecha_Enviado, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Enviado = varEncuesta1.Hora_Enviado
                        ,Fecha_Respuesta = (!String.IsNullOrEmpty(varEncuesta1.Fecha_Respuesta)) ? DateTime.ParseExact(varEncuesta1.Fecha_Respuesta, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Respuesta = varEncuesta1.Hora_Respuesta
                        ,NUAT = varEncuesta1.NUAT
                        ,Modulo = varEncuesta1.Modulo
                        ,Numero_de_Preguntas = varEncuesta1.Numero_de_Preguntas
                        ,Pregunta1 = varEncuesta1.Pregunta1
                        ,Respuesta_1 = varEncuesta1.Respuesta_1
                        ,Pregunta2 = varEncuesta1.Pregunta2
                        ,Respuesta_2 = varEncuesta1.Respuesta_2
                        ,Pregunta3 = varEncuesta1.Pregunta3
                        ,Respuesta_3 = varEncuesta1.Respuesta_3
                        ,Pregunta4 = varEncuesta1.Pregunta4
                        ,Respuesta_4 = varEncuesta1.Respuesta_4
                        ,Pregunta5 = varEncuesta1.Pregunta5
                        ,Respuesta_5 = varEncuesta1.Respuesta_5
                        ,Estatus = varEncuesta1.Estatus

                    };

                    result = !IsNew ?
                        _IEncuesta1ApiConsumer.Update(Encuesta1Info, null, null).Resource.ToString() :
                         _IEncuesta1ApiConsumer.Insert(Encuesta1Info, null, null).Resource.ToString();
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
        /// Write Element Array of Encuesta1 script
        /// </summary>
        /// <param name="oEncuesta1Elements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Encuesta1ModuleAttributeList)
        {
            for (int i = 0; i < Encuesta1ModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Encuesta1ModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Encuesta1ModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Encuesta1ModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Encuesta1ModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Encuesta1ModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Encuesta1ModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Encuesta1ModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Encuesta1ModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Encuesta1ModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Encuesta1ModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Encuesta1ModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strEncuesta1Script = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Encuesta1.js")))
            {
                strEncuesta1Script = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Encuesta1 element attributes
            string userChangeJson = jsSerialize.Serialize(Encuesta1ModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strEncuesta1Script.IndexOf("inpuElementArray");
            string splittedString = strEncuesta1Script.Substring(indexOfArray, strEncuesta1Script.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Encuesta1ModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Encuesta1ModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strEncuesta1Script.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strEncuesta1Script.Substring(indexOfArrayHistory, strEncuesta1Script.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strEncuesta1Script.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strEncuesta1Script.Substring(endIndexOfMainElement + indexOfArray, strEncuesta1Script.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Encuesta1ModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Encuesta1ModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Encuesta1.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Encuesta1.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Encuesta1.js")))
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
        public ActionResult Encuesta1PropertyBag()
        {
            return PartialView("Encuesta1PropertyBag", "Encuesta1");
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
                var whereClauseFormat = "Object = 45129 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Encuesta1.Clave= " + RecordId;
                            var result = _IEncuesta1ApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Encuesta1PropertyMapper());
			
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
                    (Encuesta1AdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Encuesta1PropertyMapper oEncuesta1PropertyMapper = new Encuesta1PropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oEncuesta1PropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IEncuesta1ApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Encuesta1s == null)
                result.Encuesta1s = new List<Encuesta1>();

            var data = result.Encuesta1s.Select(m => new Encuesta1GridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_Enviado = (m.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(m.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
			,Hora_Enviado = m.Hora_Enviado
                        ,Fecha_Respuesta = (m.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(m.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
			,Hora_Respuesta = m.Hora_Respuesta
			,NUAT = m.NUAT
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Estatus.Descripcion
                        ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
			,Pregunta1 = m.Pregunta1
                        ,Respuesta_1Descripcion = CultureHelper.GetTraduction(m.Respuesta_1_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_1_Catalogo_Respuesta.Descripcion
			,Pregunta2 = m.Pregunta2
                        ,Respuesta_2Descripcion = CultureHelper.GetTraduction(m.Respuesta_2_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_2_Catalogo_Respuesta.Descripcion
			,Pregunta3 = m.Pregunta3
                        ,Respuesta_3Descripcion = CultureHelper.GetTraduction(m.Respuesta_3_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_3_Catalogo_Respuesta.Descripcion
			,Pregunta4 = m.Pregunta4
                        ,Respuesta_4Descripcion = CultureHelper.GetTraduction(m.Respuesta_4_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_4_Catalogo_Respuesta.Descripcion
			,Pregunta5 = m.Pregunta5
                        ,Respuesta_5Descripcion = CultureHelper.GetTraduction(m.Respuesta_5_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_5_Catalogo_Respuesta.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Encuesta.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45129, arrayColumnsVisible), "Encuesta1List_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45129, arrayColumnsVisible), "Encuesta1List_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45129, arrayColumnsVisible), "Encuesta1List_" + DateTime.Now.ToString());
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

            _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Encuesta1PropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Encuesta1AdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Encuesta1PropertyMapper oEncuesta1PropertyMapper = new Encuesta1PropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oEncuesta1PropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IEncuesta1ApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Encuesta1s == null)
                result.Encuesta1s = new List<Encuesta1>();

            var data = result.Encuesta1s.Select(m => new Encuesta1GridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_Enviado = (m.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(m.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
			,Hora_Enviado = m.Hora_Enviado
                        ,Fecha_Respuesta = (m.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(m.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
			,Hora_Respuesta = m.Hora_Respuesta
			,NUAT = m.NUAT
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Estatus.Descripcion
                        ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
			,Pregunta1 = m.Pregunta1
                        ,Respuesta_1Descripcion = CultureHelper.GetTraduction(m.Respuesta_1_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_1_Catalogo_Respuesta.Descripcion
			,Pregunta2 = m.Pregunta2
                        ,Respuesta_2Descripcion = CultureHelper.GetTraduction(m.Respuesta_2_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_2_Catalogo_Respuesta.Descripcion
			,Pregunta3 = m.Pregunta3
                        ,Respuesta_3Descripcion = CultureHelper.GetTraduction(m.Respuesta_3_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_3_Catalogo_Respuesta.Descripcion
			,Pregunta4 = m.Pregunta4
                        ,Respuesta_4Descripcion = CultureHelper.GetTraduction(m.Respuesta_4_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_4_Catalogo_Respuesta.Descripcion
			,Pregunta5 = m.Pregunta5
                        ,Respuesta_5Descripcion = CultureHelper.GetTraduction(m.Respuesta_5_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_5_Catalogo_Respuesta.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Encuesta.Descripcion

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
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEncuesta1ApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Encuesta1_Datos_GeneralesModel varEncuesta1)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Encuesta1_Datos_GeneralesInfo = new Encuesta1_Datos_Generales
                {
                    Clave = varEncuesta1.Clave
                                            ,Folio = varEncuesta1.Folio
                        ,Fecha_Enviado = (!String.IsNullOrEmpty(varEncuesta1.Fecha_Enviado)) ? DateTime.ParseExact(varEncuesta1.Fecha_Enviado, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Enviado = varEncuesta1.Hora_Enviado
                        ,Fecha_Respuesta = (!String.IsNullOrEmpty(varEncuesta1.Fecha_Respuesta)) ? DateTime.ParseExact(varEncuesta1.Fecha_Respuesta, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Respuesta = varEncuesta1.Hora_Respuesta
                        ,NUAT = varEncuesta1.NUAT
                        ,Modulo = varEncuesta1.Modulo
                        ,Numero_de_Preguntas = varEncuesta1.Numero_de_Preguntas
                        ,Pregunta1 = varEncuesta1.Pregunta1
                        ,Respuesta_1 = varEncuesta1.Respuesta_1
                        ,Pregunta2 = varEncuesta1.Pregunta2
                        ,Respuesta_2 = varEncuesta1.Respuesta_2
                        ,Pregunta3 = varEncuesta1.Pregunta3
                        ,Respuesta_3 = varEncuesta1.Respuesta_3
                        ,Pregunta4 = varEncuesta1.Pregunta4
                        ,Respuesta_4 = varEncuesta1.Respuesta_4
                        ,Pregunta5 = varEncuesta1.Pregunta5
                        ,Respuesta_5 = varEncuesta1.Respuesta_5
                        ,Estatus = varEncuesta1.Estatus
                    
                };

                result = _IEncuesta1ApiConsumer.Update_Datos_Generales(Encuesta1_Datos_GeneralesInfo).Resource.ToString();
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
                _IEncuesta1ApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IEncuesta1ApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Encuesta1_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Folio = m.Folio
                        ,Fecha_Enviado = (m.Fecha_Enviado == null ? string.Empty : Convert.ToDateTime(m.Fecha_Enviado).ToString(ConfigurationProperty.DateFormat))
			,Hora_Enviado = m.Hora_Enviado
                        ,Fecha_Respuesta = (m.Fecha_Respuesta == null ? string.Empty : Convert.ToDateTime(m.Fecha_Respuesta).ToString(ConfigurationProperty.DateFormat))
			,Hora_Respuesta = m.Hora_Respuesta
			,NUAT = m.NUAT
                        ,Modulo = m.Modulo
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Estatus.Descripcion
                        ,Numero_de_Preguntas = m.Numero_de_Preguntas
                        ,Numero_de_PreguntasDescripcion = CultureHelper.GetTraduction(m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Clave.ToString(), "Descripcion") ?? (string)m.Numero_de_Preguntas_Catalogo_Numero_de_Preguntas.Descripcion
			,Pregunta1 = m.Pregunta1
                        ,Respuesta_1 = m.Respuesta_1
                        ,Respuesta_1Descripcion = CultureHelper.GetTraduction(m.Respuesta_1_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_1_Catalogo_Respuesta.Descripcion
			,Pregunta2 = m.Pregunta2
                        ,Respuesta_2 = m.Respuesta_2
                        ,Respuesta_2Descripcion = CultureHelper.GetTraduction(m.Respuesta_2_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_2_Catalogo_Respuesta.Descripcion
			,Pregunta3 = m.Pregunta3
                        ,Respuesta_3 = m.Respuesta_3
                        ,Respuesta_3Descripcion = CultureHelper.GetTraduction(m.Respuesta_3_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_3_Catalogo_Respuesta.Descripcion
			,Pregunta4 = m.Pregunta4
                        ,Respuesta_4 = m.Respuesta_4
                        ,Respuesta_4Descripcion = CultureHelper.GetTraduction(m.Respuesta_4_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_4_Catalogo_Respuesta.Descripcion
			,Pregunta5 = m.Pregunta5
                        ,Respuesta_5 = m.Respuesta_5
                        ,Respuesta_5Descripcion = CultureHelper.GetTraduction(m.Respuesta_5_Catalogo_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Respuesta_5_Catalogo_Respuesta.Descripcion
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Encuesta.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Encuesta.Descripcion

                    
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

