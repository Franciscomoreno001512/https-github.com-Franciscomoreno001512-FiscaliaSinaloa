using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Core.Domain.Tipo_de_medios_de_transporte;
using Spartane.Core.Domain.Marca_de_Medio_de_transporte;
using Spartane.Core.Domain.Modelo_de_medio_de_transporte;
using Spartane.Core.Domain.Color_de_medio_de_trasporte;
using Spartane.Core.Domain.Uso_del_medio_de_transporte;
using Spartane.Core.Domain.Procedencia_del_medio_de_transporte;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Medios_de_Transporte;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_medios_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Color_de_medio_de_trasporte;
using Spartane.Web.Areas.WebApiConsumer.Uso_del_medio_de_transporte;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_medio_de_transporte;

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

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Detalle_Aseguramiento_Medios_de_TransporteController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_Medios_de_TransporteService service = null;
        private IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer;
        private ITipo_de_medios_de_transporteApiConsumer _ITipo_de_medios_de_transporteApiConsumer;
        private IMarca_de_Medio_de_transporteApiConsumer _IMarca_de_Medio_de_transporteApiConsumer;
        private IModelo_de_medio_de_transporteApiConsumer _IModelo_de_medio_de_transporteApiConsumer;
        private IColor_de_medio_de_trasporteApiConsumer _IColor_de_medio_de_trasporteApiConsumer;
        private IUso_del_medio_de_transporteApiConsumer _IUso_del_medio_de_transporteApiConsumer;
        private IProcedencia_del_medio_de_transporteApiConsumer _IProcedencia_del_medio_de_transporteApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_Medios_de_TransporteController(IDetalle_Aseguramiento_Medios_de_TransporteService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer Detalle_Aseguramiento_Medios_de_TransporteApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_medios_de_transporteApiConsumer Tipo_de_medios_de_transporteApiConsumer , IMarca_de_Medio_de_transporteApiConsumer Marca_de_Medio_de_transporteApiConsumer , IModelo_de_medio_de_transporteApiConsumer Modelo_de_medio_de_transporteApiConsumer , IColor_de_medio_de_trasporteApiConsumer Color_de_medio_de_trasporteApiConsumer , IUso_del_medio_de_transporteApiConsumer Uso_del_medio_de_transporteApiConsumer , IProcedencia_del_medio_de_transporteApiConsumer Procedencia_del_medio_de_transporteApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer = Detalle_Aseguramiento_Medios_de_TransporteApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_medios_de_transporteApiConsumer = Tipo_de_medios_de_transporteApiConsumer;
            this._IMarca_de_Medio_de_transporteApiConsumer = Marca_de_Medio_de_transporteApiConsumer;
            this._IModelo_de_medio_de_transporteApiConsumer = Modelo_de_medio_de_transporteApiConsumer;
            this._IColor_de_medio_de_trasporteApiConsumer = Color_de_medio_de_trasporteApiConsumer;
            this._IUso_del_medio_de_transporteApiConsumer = Uso_del_medio_de_transporteApiConsumer;
            this._IProcedencia_del_medio_de_transporteApiConsumer = Procedencia_del_medio_de_transporteApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Medios_de_Transporte
        [ObjectAuth(ObjectId = (ModuleObjectId)45528, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45528);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Medios_de_Transporte/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45528, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45528);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Medios_de_Transporte = new Detalle_Aseguramiento_Medios_de_TransporteModel();
			
            ViewBag.ObjectId = "45528";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_Medios_de_TransporteData = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Medios_de_Transportes[0];
                if (Detalle_Aseguramiento_Medios_de_TransporteData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Medios_de_Transporte = new Detalle_Aseguramiento_Medios_de_TransporteModel
                {
                    Clave = (int)Detalle_Aseguramiento_Medios_de_TransporteData.Clave
                    ,Tipo = Detalle_Aseguramiento_Medios_de_TransporteData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Tipo), "Tipo_de_medios_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Tipo_Tipo_de_medios_de_transporte.Descripcion
                    ,Especifique = Detalle_Aseguramiento_Medios_de_TransporteData.Especifique
                    ,Marca = Detalle_Aseguramiento_Medios_de_TransporteData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Marca), "Marca_de_Medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Marca_Marca_de_Medio_de_transporte.Descripcion
                    ,Submarca = Detalle_Aseguramiento_Medios_de_TransporteData.Submarca
                    ,Modelo = Detalle_Aseguramiento_Medios_de_TransporteData.Modelo
                    ,ModeloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Modelo), "Modelo_de_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Modelo_Modelo_de_medio_de_transporte.Descripcion
                    ,Placas = Detalle_Aseguramiento_Medios_de_TransporteData.Placas
                    ,Color = Detalle_Aseguramiento_Medios_de_TransporteData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Color), "Color_de_medio_de_trasporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Color_Color_de_medio_de_trasporte.Descripcion
                    ,Numero_de_Motor = Detalle_Aseguramiento_Medios_de_TransporteData.Numero_de_Motor
                    ,Serie = Detalle_Aseguramiento_Medios_de_TransporteData.Serie
                    ,Uso = Detalle_Aseguramiento_Medios_de_TransporteData.Uso
                    ,UsoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Uso), "Uso_del_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Uso_Uso_del_medio_de_transporte.Descripcion
                    ,Cap__De_Pasajeros = Detalle_Aseguramiento_Medios_de_TransporteData.Cap__De_Pasajeros
                    ,Procedencia = Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia), "Procedencia_del_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
                    ,Empresa = Detalle_Aseguramiento_Medios_de_TransporteData.Empresa
                    ,Capacidad_de_Carga = Detalle_Aseguramiento_Medios_de_TransporteData.Capacidad_de_Carga
                    ,Origen = Detalle_Aseguramiento_Medios_de_TransporteData.Origen
                    ,Destino = Detalle_Aseguramiento_Medios_de_TransporteData.Destino
                    ,Observaciones = Detalle_Aseguramiento_Medios_de_TransporteData.Observaciones

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_medios_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_medios_de_transportes_Tipo = _ITipo_de_medios_de_transporteApiConsumer.SelAll(true);
            if (Tipo_de_medios_de_transportes_Tipo != null && Tipo_de_medios_de_transportes_Tipo.Resource != null)
                ViewBag.Tipo_de_medios_de_transportes_Tipo = Tipo_de_medios_de_transportes_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_medios_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_medio_de_trasporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_medio_de_trasportes_Color = _IColor_de_medio_de_trasporteApiConsumer.SelAll(true);
            if (Color_de_medio_de_trasportes_Color != null && Color_de_medio_de_trasportes_Color.Resource != null)
                ViewBag.Color_de_medio_de_trasportes_Color = Color_de_medio_de_trasportes_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_medio_de_trasporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUso_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Uso_del_medio_de_transportes_Uso = _IUso_del_medio_de_transporteApiConsumer.SelAll(true);
            if (Uso_del_medio_de_transportes_Uso != null && Uso_del_medio_de_transportes_Uso.Resource != null)
                ViewBag.Uso_del_medio_de_transportes_Uso = Uso_del_medio_de_transportes_Uso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Uso_del_medio_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_medio_de_transportes_Procedencia = _IProcedencia_del_medio_de_transporteApiConsumer.SelAll(true);
            if (Procedencia_del_medio_de_transportes_Procedencia != null && Procedencia_del_medio_de_transportes_Procedencia.Resource != null)
                ViewBag.Procedencia_del_medio_de_transportes_Procedencia = Procedencia_del_medio_de_transportes_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_medio_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Medios_de_Transporte);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Medios_de_Transporte(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45528);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_Medios_de_TransporteModel varDetalle_Aseguramiento_Medios_de_Transporte= new Detalle_Aseguramiento_Medios_de_TransporteModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_Medios_de_TransportesData = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Medios_de_Transporte.Clave=" + id, "").Resource.Detalle_Aseguramiento_Medios_de_Transportes;
				
				if (Detalle_Aseguramiento_Medios_de_TransportesData != null && Detalle_Aseguramiento_Medios_de_TransportesData.Count > 0)
                {
					var Detalle_Aseguramiento_Medios_de_TransporteData = Detalle_Aseguramiento_Medios_de_TransportesData.First();
					varDetalle_Aseguramiento_Medios_de_Transporte= new Detalle_Aseguramiento_Medios_de_TransporteModel
					{
						Clave  = Detalle_Aseguramiento_Medios_de_TransporteData.Clave 
	                    ,Tipo = Detalle_Aseguramiento_Medios_de_TransporteData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Tipo), "Tipo_de_medios_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Tipo_Tipo_de_medios_de_transporte.Descripcion
                    ,Especifique = Detalle_Aseguramiento_Medios_de_TransporteData.Especifique
                    ,Marca = Detalle_Aseguramiento_Medios_de_TransporteData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Marca), "Marca_de_Medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Marca_Marca_de_Medio_de_transporte.Descripcion
                    ,Submarca = Detalle_Aseguramiento_Medios_de_TransporteData.Submarca
                    ,Modelo = Detalle_Aseguramiento_Medios_de_TransporteData.Modelo
                    ,ModeloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Modelo), "Modelo_de_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Modelo_Modelo_de_medio_de_transporte.Descripcion
                    ,Placas = Detalle_Aseguramiento_Medios_de_TransporteData.Placas
                    ,Color = Detalle_Aseguramiento_Medios_de_TransporteData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Color), "Color_de_medio_de_trasporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Color_Color_de_medio_de_trasporte.Descripcion
                    ,Numero_de_Motor = Detalle_Aseguramiento_Medios_de_TransporteData.Numero_de_Motor
                    ,Serie = Detalle_Aseguramiento_Medios_de_TransporteData.Serie
                    ,Uso = Detalle_Aseguramiento_Medios_de_TransporteData.Uso
                    ,UsoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Uso), "Uso_del_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Uso_Uso_del_medio_de_transporte.Descripcion
                    ,Cap__De_Pasajeros = Detalle_Aseguramiento_Medios_de_TransporteData.Cap__De_Pasajeros
                    ,Procedencia = Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia), "Procedencia_del_medio_de_transporte") ??  (string)Detalle_Aseguramiento_Medios_de_TransporteData.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
                    ,Empresa = Detalle_Aseguramiento_Medios_de_TransporteData.Empresa
                    ,Capacidad_de_Carga = Detalle_Aseguramiento_Medios_de_TransporteData.Capacidad_de_Carga
                    ,Origen = Detalle_Aseguramiento_Medios_de_TransporteData.Origen
                    ,Destino = Detalle_Aseguramiento_Medios_de_TransporteData.Destino
                    ,Observaciones = Detalle_Aseguramiento_Medios_de_TransporteData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_medios_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_medios_de_transportes_Tipo = _ITipo_de_medios_de_transporteApiConsumer.SelAll(true);
            if (Tipo_de_medios_de_transportes_Tipo != null && Tipo_de_medios_de_transportes_Tipo.Resource != null)
                ViewBag.Tipo_de_medios_de_transportes_Tipo = Tipo_de_medios_de_transportes_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_medios_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_de_medio_de_trasporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_de_medio_de_trasportes_Color = _IColor_de_medio_de_trasporteApiConsumer.SelAll(true);
            if (Color_de_medio_de_trasportes_Color != null && Color_de_medio_de_trasportes_Color.Resource != null)
                ViewBag.Color_de_medio_de_trasportes_Color = Color_de_medio_de_trasportes_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_medio_de_trasporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUso_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Uso_del_medio_de_transportes_Uso = _IUso_del_medio_de_transporteApiConsumer.SelAll(true);
            if (Uso_del_medio_de_transportes_Uso != null && Uso_del_medio_de_transportes_Uso.Resource != null)
                ViewBag.Uso_del_medio_de_transportes_Uso = Uso_del_medio_de_transportes_Uso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Uso_del_medio_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_medio_de_transportes_Procedencia = _IProcedencia_del_medio_de_transporteApiConsumer.SelAll(true);
            if (Procedencia_del_medio_de_transportes_Procedencia != null && Procedencia_del_medio_de_transportes_Procedencia.Resource != null)
                ViewBag.Procedencia_del_medio_de_transportes_Procedencia = Procedencia_del_medio_de_transportes_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_medio_de_transporte", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Aseguramiento_Medios_de_Transporte", varDetalle_Aseguramiento_Medios_de_Transporte);
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
        public ActionResult GetTipo_de_medios_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_medios_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_medios_de_transporteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_medios_de_transporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetMarca_de_Medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Medio_de_transporteApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Medio_de_transporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetModelo_de_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModelo_de_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModelo_de_medio_de_transporteApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modelo_de_medio_de_transporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_de_medio_de_trasporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_de_medio_de_trasporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_de_medio_de_trasporteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_de_medio_de_trasporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetUso_del_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUso_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUso_del_medio_de_transporteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Uso_del_medio_de_transporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetProcedencia_del_medio_de_transporteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_medio_de_transporteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_medio_de_transporteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_medio_de_transporte", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Medios_de_TransportePropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Medios_de_Transportes == null)
                result.Detalle_Aseguramiento_Medios_de_Transportes = new List<Detalle_Aseguramiento_Medios_de_Transporte>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Medios_de_Transportes.Select(m => new Detalle_Aseguramiento_Medios_de_TransporteGridModel
                    {
                    Clave = m.Clave
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_medios_de_transporte.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_medios_de_transporte.Descripcion
			,Especifique = m.Especifique
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Medio_de_transporte.Clave.ToString(), "Marca_de_Medio_de_transporte") ?? (string)m.Marca_Marca_de_Medio_de_transporte.Descripcion
			,Submarca = m.Submarca
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_medio_de_transporte.Clave.ToString(), "Modelo_de_medio_de_transporte") ?? (string)m.Modelo_Modelo_de_medio_de_transporte.Descripcion
			,Placas = m.Placas
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_de_medio_de_trasporte.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_de_medio_de_trasporte.Descripcion
			,Numero_de_Motor = m.Numero_de_Motor
			,Serie = m.Serie
                        ,UsoDescripcion = CultureHelper.GetTraduction(m.Uso_Uso_del_medio_de_transporte.Clave.ToString(), "Descripcion") ?? (string)m.Uso_Uso_del_medio_de_transporte.Descripcion
			,Cap__De_Pasajeros = m.Cap__De_Pasajeros
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_medio_de_transporte.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
			,Empresa = m.Empresa
			,Capacidad_de_Carga = m.Capacidad_de_Carga
			,Origen = m.Origen
			,Destino = m.Destino
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


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
                _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Medios_de_Transporte varDetalle_Aseguramiento_Medios_de_Transporte = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_Medios_de_TransporteModel varDetalle_Aseguramiento_Medios_de_Transporte)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_Medios_de_TransporteInfo = new Detalle_Aseguramiento_Medios_de_Transporte
                    {
                        Clave = varDetalle_Aseguramiento_Medios_de_Transporte.Clave
                        ,Tipo = varDetalle_Aseguramiento_Medios_de_Transporte.Tipo
                        ,Especifique = varDetalle_Aseguramiento_Medios_de_Transporte.Especifique
                        ,Marca = varDetalle_Aseguramiento_Medios_de_Transporte.Marca
                        ,Submarca = varDetalle_Aseguramiento_Medios_de_Transporte.Submarca
                        ,Modelo = varDetalle_Aseguramiento_Medios_de_Transporte.Modelo
                        ,Placas = varDetalle_Aseguramiento_Medios_de_Transporte.Placas
                        ,Color = varDetalle_Aseguramiento_Medios_de_Transporte.Color
                        ,Numero_de_Motor = varDetalle_Aseguramiento_Medios_de_Transporte.Numero_de_Motor
                        ,Serie = varDetalle_Aseguramiento_Medios_de_Transporte.Serie
                        ,Uso = varDetalle_Aseguramiento_Medios_de_Transporte.Uso
                        ,Cap__De_Pasajeros = varDetalle_Aseguramiento_Medios_de_Transporte.Cap__De_Pasajeros
                        ,Procedencia = varDetalle_Aseguramiento_Medios_de_Transporte.Procedencia
                        ,Empresa = varDetalle_Aseguramiento_Medios_de_Transporte.Empresa
                        ,Capacidad_de_Carga = varDetalle_Aseguramiento_Medios_de_Transporte.Capacidad_de_Carga
                        ,Origen = varDetalle_Aseguramiento_Medios_de_Transporte.Origen
                        ,Destino = varDetalle_Aseguramiento_Medios_de_Transporte.Destino
                        ,Observaciones = varDetalle_Aseguramiento_Medios_de_Transporte.Observaciones

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Update(Detalle_Aseguramiento_Medios_de_TransporteInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.Insert(Detalle_Aseguramiento_Medios_de_TransporteInfo, null, null).Resource.ToString();

                    return Json(result, JsonRequestBehavior.AllowGet);
				}
				return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Detalle_Aseguramiento_Medios_de_Transporte script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_Medios_de_TransporteElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_Medios_de_TransporteScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Medios_de_Transporte.js")))
            {
                strDetalle_Aseguramiento_Medios_de_TransporteScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Medios_de_Transporte element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_Medios_de_TransporteScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(indexOfArray, strDetalle_Aseguramiento_Medios_de_TransporteScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_Medios_de_TransporteScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_Medios_de_TransporteScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_Medios_de_TransporteScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_Medios_de_TransporteModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_Medios_de_TransporteScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_Medios_de_TransporteScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Medios_de_Transporte.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Medios_de_Transporte.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Medios_de_Transporte.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("inpuElementChildArray");
				string childJsonArray = "";
                if (indexOfChildArray != -1)
                {
					string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);
					int indexOfChildElement = splittedChildString.IndexOf('[');
					int endIndexOfChildElement = splittedChildString.IndexOf(']') + 1;
					childJsonArray = splittedChildString.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement);
				}
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
        public ActionResult Detalle_Aseguramiento_Medios_de_TransportePropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_Medios_de_TransportePropertyBag", "Detalle_Aseguramiento_Medios_de_Transporte");
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
        public void Export(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Medios_de_TransportePropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Medios_de_Transportes == null)
                result.Detalle_Aseguramiento_Medios_de_Transportes = new List<Detalle_Aseguramiento_Medios_de_Transporte>();

            var data = result.Detalle_Aseguramiento_Medios_de_Transportes.Select(m => new Detalle_Aseguramiento_Medios_de_TransporteGridModel
            {
                Clave = m.Clave
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_medios_de_transporte.Descripcion
                ,Especifique = m.Especifique
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Medio_de_transporte.Descripcion
                ,Submarca = m.Submarca
                ,ModeloDescripcion = (string)m.Modelo_Modelo_de_medio_de_transporte.Descripcion
                ,Placas = m.Placas
                ,ColorDescripcion = (string)m.Color_Color_de_medio_de_trasporte.Descripcion
                ,Numero_de_Motor = m.Numero_de_Motor
                ,Serie = m.Serie
                ,UsoDescripcion = (string)m.Uso_Uso_del_medio_de_transporte.Descripcion
                ,Cap__De_Pasajeros = m.Cap__De_Pasajeros
                ,ProcedenciaDescripcion = (string)m.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
                ,Empresa = m.Empresa
                ,Capacidad_de_Carga = m.Capacidad_de_Carga
                ,Origen = m.Origen
                ,Destino = m.Destino
                ,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_Medios_de_TransporteList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_Medios_de_TransporteList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(), "EmployeeList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return null;

            _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Medios_de_TransportePropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Medios_de_TransporteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Medios_de_Transportes == null)
                result.Detalle_Aseguramiento_Medios_de_Transportes = new List<Detalle_Aseguramiento_Medios_de_Transporte>();

            var data = result.Detalle_Aseguramiento_Medios_de_Transportes.Select(m => new Detalle_Aseguramiento_Medios_de_TransporteGridModel
            {
                Clave = m.Clave
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_medios_de_transporte.Descripcion
                ,Especifique = m.Especifique
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Medio_de_transporte.Descripcion
                ,Submarca = m.Submarca
                ,ModeloDescripcion = (string)m.Modelo_Modelo_de_medio_de_transporte.Descripcion
                ,Placas = m.Placas
                ,ColorDescripcion = (string)m.Color_Color_de_medio_de_trasporte.Descripcion
                ,Numero_de_Motor = m.Numero_de_Motor
                ,Serie = m.Serie
                ,UsoDescripcion = (string)m.Uso_Uso_del_medio_de_transporte.Descripcion
                ,Cap__De_Pasajeros = m.Cap__De_Pasajeros
                ,ProcedenciaDescripcion = (string)m.Procedencia_Procedencia_del_medio_de_transporte.Descripcion
                ,Empresa = m.Empresa
                ,Capacidad_de_Carga = m.Capacidad_de_Carga
                ,Origen = m.Origen
                ,Destino = m.Destino
                ,Observaciones = m.Observaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
