using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Servicios_de_Apoyo_MP;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Servicios_de_Apoyo_MP;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Servicios_de_Apoyo_MP;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Diligencias_MP;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Servicios_de_Apoyo_MPController : Controller
    {
        #region "variable declaration"

        private IServicios_de_Apoyo_MPService service = null;
        private IServicios_de_Apoyo_MPApiConsumer _IServicios_de_Apoyo_MPApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ICategoria_de_Servicio_de_ApoyoApiConsumer _ICategoria_de_Servicio_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private IDiligencias_MPApiConsumer _IDiligencias_MPApiConsumer;

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

        
        public Servicios_de_Apoyo_MPController(IServicios_de_Apoyo_MPService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IServicios_de_Apoyo_MPApiConsumer Servicios_de_Apoyo_MPApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ICategoria_de_Servicio_de_ApoyoApiConsumer Categoria_de_Servicio_de_ApoyoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , IDiligencias_MPApiConsumer Diligencias_MPApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IServicios_de_Apoyo_MPApiConsumer = Servicios_de_Apoyo_MPApiConsumer;
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
            this._ICategoria_de_Servicio_de_ApoyoApiConsumer = Categoria_de_Servicio_de_ApoyoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._IDiligencias_MPApiConsumer = Diligencias_MPApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Servicios_de_Apoyo_MP
        [ObjectAuth(ObjectId = (ModuleObjectId)45476, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45476, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Servicios_de_Apoyo_MP/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45476, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45476, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varServicios_de_Apoyo_MP = new Servicios_de_Apoyo_MPModel();
			varServicios_de_Apoyo_MP.Clave = Id;
			
            ViewBag.ObjectId = "45476";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Servicios_de_Apoyo_MPsData = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll(0, 1000, "Servicios_de_Apoyo_MP.Clave=" + Id, "").Resource.Servicios_de_Apoyo_MPs;
				
				if (Servicios_de_Apoyo_MPsData != null && Servicios_de_Apoyo_MPsData.Count > 0)
                {
					var Servicios_de_Apoyo_MPData = Servicios_de_Apoyo_MPsData.First();
					varServicios_de_Apoyo_MP= new Servicios_de_Apoyo_MPModel
					{
						Clave  = Servicios_de_Apoyo_MPData.Clave 
	                    ,Expediente_MP = Servicios_de_Apoyo_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Servicios_de_Apoyo_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Servicios_de_Apoyo_MPData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Servicios_de_Apoyo_MPData.Hora_de_Registro
                    ,Usuario_que_Registra = Servicios_de_Apoyo_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Servicios_de_Apoyo_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Categoria = Servicios_de_Apoyo_MPData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Servicios_de_Apoyo_MPData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Tipo_de_Servicio = Servicios_de_Apoyo_MPData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Servicios_de_Apoyo_MPData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Solicitud = Servicios_de_Apoyo_MPData.Solicitud
                    ,Fecha_de_Termino_para_Entrega = (Servicios_de_Apoyo_MPData.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Termino_para_Entrega = Servicios_de_Apoyo_MPData.Hora_de_Termino_para_Entrega
                    ,Diligencia_a_Enviar = Servicios_de_Apoyo_MPData.Diligencia_a_Enviar
                    ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Diligencia_a_Enviar), "Diligencias_MP") ??  (string)Servicios_de_Apoyo_MPData.Diligencia_a_Enviar_Diligencias_MP.Descripcion
                    ,Archivo = Servicios_de_Apoyo_MPData.Archivo
                    ,Fecha_de_Atencion = (Servicios_de_Apoyo_MPData.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion = Servicios_de_Apoyo_MPData.Hora_de_Atencion
                    ,Usuario_que_Atiende = Servicios_de_Apoyo_MPData.Usuario_que_Atiende
                    ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Usuario_que_Atiende), "Spartan_User") ??  (string)Servicios_de_Apoyo_MPData.Usuario_que_Atiende_Spartan_User.Name
                    ,Archivo_Adjunto = Servicios_de_Apoyo_MPData.Archivo_Adjunto

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varServicios_de_Apoyo_MP.Archivo).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varServicios_de_Apoyo_MP.Archivo_Adjunto).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varServicios_de_Apoyo_MP);
        }
		
	[HttpGet]
        public ActionResult AddServicios_de_Apoyo_MP(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45476);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
			Servicios_de_Apoyo_MPModel varServicios_de_Apoyo_MP= new Servicios_de_Apoyo_MPModel();


            if (id.ToString() != "0")
            {
                var Servicios_de_Apoyo_MPsData = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll(0, 1000, "Servicios_de_Apoyo_MP.Clave=" + id, "").Resource.Servicios_de_Apoyo_MPs;
				
				if (Servicios_de_Apoyo_MPsData != null && Servicios_de_Apoyo_MPsData.Count > 0)
                {
					var Servicios_de_Apoyo_MPData = Servicios_de_Apoyo_MPsData.First();
					varServicios_de_Apoyo_MP= new Servicios_de_Apoyo_MPModel
					{
						Clave  = Servicios_de_Apoyo_MPData.Clave 
	                    ,Expediente_MP = Servicios_de_Apoyo_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Servicios_de_Apoyo_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Servicios_de_Apoyo_MPData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Servicios_de_Apoyo_MPData.Hora_de_Registro
                    ,Usuario_que_Registra = Servicios_de_Apoyo_MPData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Usuario_que_Registra), "Spartan_User") ??  (string)Servicios_de_Apoyo_MPData.Usuario_que_Registra_Spartan_User.Name
                    ,Categoria = Servicios_de_Apoyo_MPData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Servicios_de_Apoyo_MPData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Tipo_de_Servicio = Servicios_de_Apoyo_MPData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Servicios_de_Apoyo_MPData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Solicitud = Servicios_de_Apoyo_MPData.Solicitud
                    ,Fecha_de_Termino_para_Entrega = (Servicios_de_Apoyo_MPData.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Termino_para_Entrega = Servicios_de_Apoyo_MPData.Hora_de_Termino_para_Entrega
                    ,Diligencia_a_Enviar = Servicios_de_Apoyo_MPData.Diligencia_a_Enviar
                    ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Diligencia_a_Enviar), "Diligencias_MP") ??  (string)Servicios_de_Apoyo_MPData.Diligencia_a_Enviar_Diligencias_MP.Descripcion
                    ,Archivo = Servicios_de_Apoyo_MPData.Archivo
                    ,Fecha_de_Atencion = (Servicios_de_Apoyo_MPData.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(Servicios_de_Apoyo_MPData.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion = Servicios_de_Apoyo_MPData.Hora_de_Atencion
                    ,Usuario_que_Atiende = Servicios_de_Apoyo_MPData.Usuario_que_Atiende
                    ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(Convert.ToString(Servicios_de_Apoyo_MPData.Usuario_que_Atiende), "Spartan_User") ??  (string)Servicios_de_Apoyo_MPData.Usuario_que_Atiende_Spartan_User.Name
                    ,Archivo_Adjunto = Servicios_de_Apoyo_MPData.Archivo_Adjunto

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varServicios_de_Apoyo_MP.Archivo).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varServicios_de_Apoyo_MP.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddServicios_de_Apoyo_MP", varServicios_de_Apoyo_MP);
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
        public ActionResult GetCategoria_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio")?? m.Servicio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDiligencias_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligencias_MPApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Diligencias_MP", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Servicios_de_Apoyo_MPAdvanceSearchModel model, int idFilter = -1)
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

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Servicios_de_Apoyo_MPAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Servicios_de_Apoyo_MPAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Servicios_de_Apoyo_MPAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Servicios_de_Apoyo_MPPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_de_Apoyo_MPs == null)
                result.Servicios_de_Apoyo_MPs = new List<Servicios_de_Apoyo_MP>();

            return Json(new
            {
                data = result.Servicios_de_Apoyo_MPs.Select(m => new Servicios_de_Apoyo_MPGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Solicitud = m.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (m.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Termino_para_Entrega = m.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(m.Diligencia_a_Enviar_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Diligencia_a_Enviar_Diligencias_MP.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
			,Archivo_Adjunto = m.Archivo_Adjunto

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetServicios_de_Apoyo_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_de_Apoyo_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Servicios_de_Apoyo_MP", m.),
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
        /// Get List of Servicios_de_Apoyo_MP from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Servicios_de_Apoyo_MP Entity</returns>
        public ActionResult GetServicios_de_Apoyo_MPList(UrlParametersModel param)
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
            _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Servicios_de_Apoyo_MPPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Servicios_de_Apoyo_MPAdvanceSearchModel))
                {
					var advanceFilter =
                    (Servicios_de_Apoyo_MPAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Servicios_de_Apoyo_MPPropertyMapper oServicios_de_Apoyo_MPPropertyMapper = new Servicios_de_Apoyo_MPPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oServicios_de_Apoyo_MPPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_de_Apoyo_MPs == null)
                result.Servicios_de_Apoyo_MPs = new List<Servicios_de_Apoyo_MP>();

            return Json(new
            {
                aaData = result.Servicios_de_Apoyo_MPs.Select(m => new Servicios_de_Apoyo_MPGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Solicitud = m.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (m.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Termino_para_Entrega = m.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(m.Diligencia_a_Enviar_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Diligencia_a_Enviar_Diligencias_MP.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
			,Archivo_Adjunto = m.Archivo_Adjunto

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetServicios_de_Apoyo_MP_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetServicios_de_Apoyo_MP_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetServicios_de_Apoyo_MP_Diligencia_a_Enviar_Diligencias_MP(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Diligencias_MP.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Diligencias_MP.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDiligencias_MPApiConsumer.ListaSelAll(1, 20,elWhere , " Diligencias_MP.Descripcion ASC ").Resource;
               
                foreach (var item in result.Diligencias_MPs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Diligencias_MP", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Diligencias_MPs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetServicios_de_Apoyo_MP_Usuario_que_Atiende_Spartan_User(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Servicios_de_Apoyo_MPAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Servicios_de_Apoyo_MP.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Servicios_de_Apoyo_MP.Clave <= " + filter.ToClave;
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

                where += " AND Servicios_de_Apoyo_MP.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Servicios_de_Apoyo_MP.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCategoria))
            {
                switch (filter.CategoriaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Categoria_de_Servicio_de_Apoyo.Descripcion LIKE '" + filter.AdvanceCategoria + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Categoria_de_Servicio_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceCategoria + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Categoria_de_Servicio_de_Apoyo.Descripcion = '" + filter.AdvanceCategoria + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Categoria_de_Servicio_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceCategoria + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCategoriaMultiple != null && filter.AdvanceCategoriaMultiple.Count() > 0)
            {
                var CategoriaIds = string.Join(",", filter.AdvanceCategoriaMultiple);

                where += " AND Servicios_de_Apoyo_MP.Categoria In (" + CategoriaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Servicio))
            {
                switch (filter.Tipo_de_ServicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '%" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio = '" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '%" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ServicioMultiple != null && filter.AdvanceTipo_de_ServicioMultiple.Count() > 0)
            {
                var Tipo_de_ServicioIds = string.Join(",", filter.AdvanceTipo_de_ServicioMultiple);

                where += " AND Servicios_de_Apoyo_MP.Tipo_de_Servicio In (" + Tipo_de_ServicioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Solicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Servicios_de_Apoyo_MP.Solicitud LIKE '" + filter.Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Servicios_de_Apoyo_MP.Solicitud LIKE '%" + filter.Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Servicios_de_Apoyo_MP.Solicitud = '" + filter.Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Servicios_de_Apoyo_MP.Solicitud LIKE '%" + filter.Solicitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Termino_para_Entrega) || !string.IsNullOrEmpty(filter.ToFecha_de_Termino_para_Entrega))
            {
                var Fecha_de_Termino_para_EntregaFrom = DateTime.ParseExact(filter.FromFecha_de_Termino_para_Entrega, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Termino_para_EntregaTo = DateTime.ParseExact(filter.ToFecha_de_Termino_para_Entrega, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Termino_para_Entrega))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega >= '" + Fecha_de_Termino_para_EntregaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Termino_para_Entrega))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega <= '" + Fecha_de_Termino_para_EntregaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Termino_para_Entrega) || !string.IsNullOrEmpty(filter.ToHora_de_Termino_para_Entrega))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Termino_para_Entrega))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Termino_para_Entrega) >='" + filter.FromHora_de_Termino_para_Entrega + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Termino_para_Entrega))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Termino_para_Entrega) <='" + filter.ToHora_de_Termino_para_Entrega + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiligencia_a_Enviar))
            {
                switch (filter.Diligencia_a_EnviarFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '" + filter.AdvanceDiligencia_a_Enviar + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.AdvanceDiligencia_a_Enviar + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias_MP.Descripcion = '" + filter.AdvanceDiligencia_a_Enviar + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.AdvanceDiligencia_a_Enviar + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiligencia_a_EnviarMultiple != null && filter.AdvanceDiligencia_a_EnviarMultiple.Count() > 0)
            {
                var Diligencia_a_EnviarIds = string.Join(",", filter.AdvanceDiligencia_a_EnviarMultiple);

                where += " AND Servicios_de_Apoyo_MP.Diligencia_a_Enviar In (" + Diligencia_a_EnviarIds + ")";
            }

            if (filter.Archivo != RadioOptions.NoApply)
                where += " AND Servicios_de_Apoyo_MP.Archivo " + (filter.Archivo == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion) || !string.IsNullOrEmpty(filter.ToFecha_de_Atencion))
            {
                var Fecha_de_AtencionFrom = DateTime.ParseExact(filter.FromFecha_de_Atencion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AtencionTo = DateTime.ParseExact(filter.ToFecha_de_Atencion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Atencion >= '" + Fecha_de_AtencionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Atencion))
                    where += " AND Servicios_de_Apoyo_MP.Fecha_de_Atencion <= '" + Fecha_de_AtencionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion) || !string.IsNullOrEmpty(filter.ToHora_de_Atencion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Atencion) >='" + filter.FromHora_de_Atencion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Atencion))
                    where += " AND Convert(TIME,Servicios_de_Apoyo_MP.Hora_de_Atencion) <='" + filter.ToHora_de_Atencion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Atiende))
            {
                switch (filter.Usuario_que_AtiendeFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Atiende + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Atiende + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Atiende + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Atiende + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_AtiendeMultiple != null && filter.AdvanceUsuario_que_AtiendeMultiple.Count() > 0)
            {
                var Usuario_que_AtiendeIds = string.Join(",", filter.AdvanceUsuario_que_AtiendeMultiple);

                where += " AND Servicios_de_Apoyo_MP.Usuario_que_Atiende In (" + Usuario_que_AtiendeIds + ")";
            }

            if (filter.Archivo_Adjunto != RadioOptions.NoApply)
                where += " AND Servicios_de_Apoyo_MP.Archivo_Adjunto " + (filter.Archivo_Adjunto == RadioOptions.Yes ? ">" : "==") + " 0";


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
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

                Servicios_de_Apoyo_MP varServicios_de_Apoyo_MP = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IServicios_de_Apoyo_MPApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Servicios_de_Apoyo_MPModel varServicios_de_Apoyo_MP)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varServicios_de_Apoyo_MP.ArchivoRemoveAttachment != 0 && varServicios_de_Apoyo_MP.ArchivoFile == null)
                    {
                        varServicios_de_Apoyo_MP.Archivo = 0;
                    }

                    if (varServicios_de_Apoyo_MP.ArchivoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varServicios_de_Apoyo_MP.ArchivoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varServicios_de_Apoyo_MP.Archivo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varServicios_de_Apoyo_MP.ArchivoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varServicios_de_Apoyo_MP.Archivo_AdjuntoRemoveAttachment != 0 && varServicios_de_Apoyo_MP.Archivo_AdjuntoFile == null)
                    {
                        varServicios_de_Apoyo_MP.Archivo_Adjunto = 0;
                    }

                    if (varServicios_de_Apoyo_MP.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varServicios_de_Apoyo_MP.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varServicios_de_Apoyo_MP.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varServicios_de_Apoyo_MP.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Servicios_de_Apoyo_MPInfo = new Servicios_de_Apoyo_MP
                    {
                        Clave = varServicios_de_Apoyo_MP.Clave
                        ,Expediente_MP = varServicios_de_Apoyo_MP.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Registro)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varServicios_de_Apoyo_MP.Hora_de_Registro
                        ,Usuario_que_Registra = varServicios_de_Apoyo_MP.Usuario_que_Registra
                        ,Categoria = varServicios_de_Apoyo_MP.Categoria
                        ,Tipo_de_Servicio = varServicios_de_Apoyo_MP.Tipo_de_Servicio
                        ,Solicitud = varServicios_de_Apoyo_MP.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Termino_para_Entrega = varServicios_de_Apoyo_MP.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_Enviar = varServicios_de_Apoyo_MP.Diligencia_a_Enviar
                        ,Archivo = (varServicios_de_Apoyo_MP.Archivo.HasValue && varServicios_de_Apoyo_MP.Archivo != 0) ? ((int?)Convert.ToInt32(varServicios_de_Apoyo_MP.Archivo.Value)) : null

                        ,Fecha_de_Atencion = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Atencion)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Atencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion = varServicios_de_Apoyo_MP.Hora_de_Atencion
                        ,Usuario_que_Atiende = varServicios_de_Apoyo_MP.Usuario_que_Atiende
                        ,Archivo_Adjunto = (varServicios_de_Apoyo_MP.Archivo_Adjunto.HasValue && varServicios_de_Apoyo_MP.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varServicios_de_Apoyo_MP.Archivo_Adjunto.Value)) : null


                    };

                    result = !IsNew ?
                        _IServicios_de_Apoyo_MPApiConsumer.Update(Servicios_de_Apoyo_MPInfo, null, null).Resource.ToString() :
                         _IServicios_de_Apoyo_MPApiConsumer.Insert(Servicios_de_Apoyo_MPInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Servicios_de_Apoyo_MP script
        /// </summary>
        /// <param name="oServicios_de_Apoyo_MPElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Servicios_de_Apoyo_MPModuleAttributeList)
        {
            for (int i = 0; i < Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strServicios_de_Apoyo_MPScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Servicios_de_Apoyo_MP.js")))
            {
                strServicios_de_Apoyo_MPScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Servicios_de_Apoyo_MP element attributes
            string userChangeJson = jsSerialize.Serialize(Servicios_de_Apoyo_MPModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strServicios_de_Apoyo_MPScript.IndexOf("inpuElementArray");
            string splittedString = strServicios_de_Apoyo_MPScript.Substring(indexOfArray, strServicios_de_Apoyo_MPScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strServicios_de_Apoyo_MPScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strServicios_de_Apoyo_MPScript.Substring(indexOfArrayHistory, strServicios_de_Apoyo_MPScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strServicios_de_Apoyo_MPScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strServicios_de_Apoyo_MPScript.Substring(endIndexOfMainElement + indexOfArray, strServicios_de_Apoyo_MPScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Servicios_de_Apoyo_MPModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Servicios_de_Apoyo_MP.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Servicios_de_Apoyo_MP.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Servicios_de_Apoyo_MP.js")))
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
        public ActionResult Servicios_de_Apoyo_MPPropertyBag()
        {
            return PartialView("Servicios_de_Apoyo_MPPropertyBag", "Servicios_de_Apoyo_MP");
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
                var whereClauseFormat = "Object = 45476 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Servicios_de_Apoyo_MP.Clave= " + RecordId;
                            var result = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Servicios_de_Apoyo_MPPropertyMapper());
			
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
                    (Servicios_de_Apoyo_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Servicios_de_Apoyo_MPPropertyMapper oServicios_de_Apoyo_MPPropertyMapper = new Servicios_de_Apoyo_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oServicios_de_Apoyo_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_de_Apoyo_MPs == null)
                result.Servicios_de_Apoyo_MPs = new List<Servicios_de_Apoyo_MP>();

            var data = result.Servicios_de_Apoyo_MPs.Select(m => new Servicios_de_Apoyo_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Solicitud = m.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (m.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Termino_para_Entrega = m.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(m.Diligencia_a_Enviar_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Diligencia_a_Enviar_Diligencias_MP.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
			,Archivo_Adjunto = m.Archivo_Adjunto

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45476, arrayColumnsVisible), "Servicios_de_Apoyo_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45476, arrayColumnsVisible), "Servicios_de_Apoyo_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45476, arrayColumnsVisible), "Servicios_de_Apoyo_MPList_" + DateTime.Now.ToString());
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

            _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Servicios_de_Apoyo_MPPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Servicios_de_Apoyo_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Servicios_de_Apoyo_MPPropertyMapper oServicios_de_Apoyo_MPPropertyMapper = new Servicios_de_Apoyo_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oServicios_de_Apoyo_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IServicios_de_Apoyo_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_de_Apoyo_MPs == null)
                result.Servicios_de_Apoyo_MPs = new List<Servicios_de_Apoyo_MP>();

            var data = result.Servicios_de_Apoyo_MPs.Select(m => new Servicios_de_Apoyo_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Solicitud = m.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (m.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Termino_para_Entrega = m.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(m.Diligencia_a_Enviar_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Diligencia_a_Enviar_Diligencias_MP.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
			,Archivo_Adjunto = m.Archivo_Adjunto

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
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_de_Apoyo_MPApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Servicios_de_Apoyo_MP_Datos_GeneralesModel varServicios_de_Apoyo_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varServicios_de_Apoyo_MP.ArchivoRemoveAttachment != 0 && varServicios_de_Apoyo_MP.ArchivoFile == null)
                    {
                        varServicios_de_Apoyo_MP.Archivo = 0;
                    }

                    if (varServicios_de_Apoyo_MP.ArchivoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varServicios_de_Apoyo_MP.ArchivoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varServicios_de_Apoyo_MP.Archivo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varServicios_de_Apoyo_MP.ArchivoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Servicios_de_Apoyo_MP_Datos_GeneralesInfo = new Servicios_de_Apoyo_MP_Datos_Generales
                {
                    Clave = varServicios_de_Apoyo_MP.Clave
                                            ,Expediente_MP = varServicios_de_Apoyo_MP.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Registro)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varServicios_de_Apoyo_MP.Hora_de_Registro
                        ,Usuario_que_Registra = varServicios_de_Apoyo_MP.Usuario_que_Registra
                        ,Categoria = varServicios_de_Apoyo_MP.Categoria
                        ,Tipo_de_Servicio = varServicios_de_Apoyo_MP.Tipo_de_Servicio
                        ,Solicitud = varServicios_de_Apoyo_MP.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Termino_para_Entrega, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Termino_para_Entrega = varServicios_de_Apoyo_MP.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_Enviar = varServicios_de_Apoyo_MP.Diligencia_a_Enviar
                        ,Archivo = (varServicios_de_Apoyo_MP.Archivo.HasValue && varServicios_de_Apoyo_MP.Archivo != 0) ? ((int?)Convert.ToInt32(varServicios_de_Apoyo_MP.Archivo.Value)) : null

                    
                };

                result = _IServicios_de_Apoyo_MPApiConsumer.Update_Datos_Generales(Servicios_de_Apoyo_MP_Datos_GeneralesInfo).Resource.ToString();
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
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IServicios_de_Apoyo_MPApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Servicios_de_Apoyo_MP_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Categoria = m.Categoria
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Solicitud = m.Solicitud
                        ,Fecha_de_Termino_para_Entrega = (m.Fecha_de_Termino_para_Entrega == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Termino_para_Entrega).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Termino_para_Entrega = m.Hora_de_Termino_para_Entrega
                        ,Diligencia_a_Enviar = m.Diligencia_a_Enviar
                        ,Diligencia_a_EnviarDescripcion = CultureHelper.GetTraduction(m.Diligencia_a_Enviar_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Diligencia_a_Enviar_Diligencias_MP.Descripcion
			,Archivo = m.Archivo

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Contestacion(Servicios_de_Apoyo_MP_ContestacionModel varServicios_de_Apoyo_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varServicios_de_Apoyo_MP.Archivo_AdjuntoRemoveAttachment != 0 && varServicios_de_Apoyo_MP.Archivo_AdjuntoFile == null)
                    {
                        varServicios_de_Apoyo_MP.Archivo_Adjunto = 0;
                    }

                    if (varServicios_de_Apoyo_MP.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varServicios_de_Apoyo_MP.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varServicios_de_Apoyo_MP.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varServicios_de_Apoyo_MP.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Servicios_de_Apoyo_MP_ContestacionInfo = new Servicios_de_Apoyo_MP_Contestacion
                {
                    Clave = varServicios_de_Apoyo_MP.Clave
                                            ,Fecha_de_Atencion = (!String.IsNullOrEmpty(varServicios_de_Apoyo_MP.Fecha_de_Atencion)) ? DateTime.ParseExact(varServicios_de_Apoyo_MP.Fecha_de_Atencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion = varServicios_de_Apoyo_MP.Hora_de_Atencion
                        ,Usuario_que_Atiende = varServicios_de_Apoyo_MP.Usuario_que_Atiende
                        ,Archivo_Adjunto = (varServicios_de_Apoyo_MP.Archivo_Adjunto.HasValue && varServicios_de_Apoyo_MP.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varServicios_de_Apoyo_MP.Archivo_Adjunto.Value)) : null

                    
                };

                result = _IServicios_de_Apoyo_MPApiConsumer.Update_Contestacion(Servicios_de_Apoyo_MP_ContestacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Contestacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_de_Apoyo_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IServicios_de_Apoyo_MPApiConsumer.Get_Contestacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Servicios_de_Apoyo_MP_ContestacionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_Atiende = m.Usuario_que_Atiende
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
			,Archivo_Adjunto = m.Archivo_Adjunto

                    
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

