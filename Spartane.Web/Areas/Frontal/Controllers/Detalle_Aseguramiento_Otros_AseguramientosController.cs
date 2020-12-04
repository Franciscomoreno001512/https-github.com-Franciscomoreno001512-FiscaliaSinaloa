﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Core.Domain.Tipo_de_Equipo_Tactico;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;
using Spartane.Core.Domain.Unidad_de_Medida_de_Equipo_Tactico;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros_Aseguramientos;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_Tactico;
using Spartane.Web.Areas.WebApiConsumer.Modelo_de_equipo_tactico;
using Spartane.Web.Areas.WebApiConsumer.Unidad_de_Medida_de_Equipo_Tactico;

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
    public class Detalle_Aseguramiento_Otros_AseguramientosController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_Otros_AseguramientosService service = null;
        private IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer;
        private ITipo_de_Equipo_TacticoApiConsumer _ITipo_de_Equipo_TacticoApiConsumer;
        private IMarca_de_Equipo_TacticoApiConsumer _IMarca_de_Equipo_TacticoApiConsumer;
        private IModelo_de_equipo_tacticoApiConsumer _IModelo_de_equipo_tacticoApiConsumer;
        private IUnidad_de_Medida_de_Equipo_TacticoApiConsumer _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_Otros_AseguramientosController(IDetalle_Aseguramiento_Otros_AseguramientosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer Detalle_Aseguramiento_Otros_AseguramientosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_Equipo_TacticoApiConsumer Tipo_de_Equipo_TacticoApiConsumer , IMarca_de_Equipo_TacticoApiConsumer Marca_de_Equipo_TacticoApiConsumer , IModelo_de_equipo_tacticoApiConsumer Modelo_de_equipo_tacticoApiConsumer , IUnidad_de_Medida_de_Equipo_TacticoApiConsumer Unidad_de_Medida_de_Equipo_TacticoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer = Detalle_Aseguramiento_Otros_AseguramientosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_Equipo_TacticoApiConsumer = Tipo_de_Equipo_TacticoApiConsumer;
            this._IMarca_de_Equipo_TacticoApiConsumer = Marca_de_Equipo_TacticoApiConsumer;
            this._IModelo_de_equipo_tacticoApiConsumer = Modelo_de_equipo_tacticoApiConsumer;
            this._IUnidad_de_Medida_de_Equipo_TacticoApiConsumer = Unidad_de_Medida_de_Equipo_TacticoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Otros_Aseguramientos
        [ObjectAuth(ObjectId = (ModuleObjectId)45532, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45532);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Otros_Aseguramientos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45532, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45532);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Otros_Aseguramientos = new Detalle_Aseguramiento_Otros_AseguramientosModel();
			
            ViewBag.ObjectId = "45532";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_Otros_AseguramientosData = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Otros_Aseguramientoss[0];
                if (Detalle_Aseguramiento_Otros_AseguramientosData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Otros_Aseguramientos = new Detalle_Aseguramiento_Otros_AseguramientosModel
                {
                    Clave = (int)Detalle_Aseguramiento_Otros_AseguramientosData.Clave
                    ,Tipo = Detalle_Aseguramiento_Otros_AseguramientosData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Tipo), "Tipo_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                    ,Marca = Detalle_Aseguramiento_Otros_AseguramientosData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Marca), "Marca_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Marca_Marca_de_Equipo_Tactico.Descripcion
                    ,Modelo = Detalle_Aseguramiento_Otros_AseguramientosData.Modelo
                    ,ModeloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Modelo), "Modelo_de_equipo_tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Modelo_Modelo_de_equipo_tactico.Descripcion
                    ,Inventario = Detalle_Aseguramiento_Otros_AseguramientosData.Inventario
                    ,Serie = Detalle_Aseguramiento_Otros_AseguramientosData.Serie
                    ,Unidad_de_Medida = Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida
                    ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida), "Unidad_de_Medida_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
                    ,Cantidad = Detalle_Aseguramiento_Otros_AseguramientosData.Cantidad
                    ,Observaciones = Detalle_Aseguramiento_Otros_AseguramientosData.Observaciones

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Equipo_Tacticos_Tipo = _ITipo_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Tipo_de_Equipo_Tacticos_Tipo != null && Tipo_de_Equipo_Tacticos_Tipo.Resource != null)
                ViewBag.Tipo_de_Equipo_Tacticos_Tipo = Tipo_de_Equipo_Tacticos_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Equipo_Tacticos_Marca = _IMarca_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Marca_de_Equipo_Tacticos_Marca != null && Marca_de_Equipo_Tacticos_Marca.Resource != null)
                ViewBag.Marca_de_Equipo_Tacticos_Marca = Marca_de_Equipo_Tacticos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModelo_de_equipo_tacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modelo_de_equipo_tacticos_Modelo = _IModelo_de_equipo_tacticoApiConsumer.SelAll(true);
            if (Modelo_de_equipo_tacticos_Modelo != null && Modelo_de_equipo_tacticos_Modelo.Resource != null)
                ViewBag.Modelo_de_equipo_tacticos_Modelo = Modelo_de_equipo_tacticos_Modelo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modelo_de_equipo_tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida = _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida != null && Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida.Resource != null)
                ViewBag.Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida = Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad_de_Medida_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Otros_Aseguramientos);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Otros_Aseguramientos(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45532);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_Otros_AseguramientosModel varDetalle_Aseguramiento_Otros_Aseguramientos= new Detalle_Aseguramiento_Otros_AseguramientosModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_Otros_AseguramientossData = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Otros_Aseguramientos.Clave=" + id, "").Resource.Detalle_Aseguramiento_Otros_Aseguramientoss;
				
				if (Detalle_Aseguramiento_Otros_AseguramientossData != null && Detalle_Aseguramiento_Otros_AseguramientossData.Count > 0)
                {
					var Detalle_Aseguramiento_Otros_AseguramientosData = Detalle_Aseguramiento_Otros_AseguramientossData.First();
					varDetalle_Aseguramiento_Otros_Aseguramientos= new Detalle_Aseguramiento_Otros_AseguramientosModel
					{
						Clave  = Detalle_Aseguramiento_Otros_AseguramientosData.Clave 
	                    ,Tipo = Detalle_Aseguramiento_Otros_AseguramientosData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Tipo), "Tipo_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                    ,Marca = Detalle_Aseguramiento_Otros_AseguramientosData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Marca), "Marca_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Marca_Marca_de_Equipo_Tactico.Descripcion
                    ,Modelo = Detalle_Aseguramiento_Otros_AseguramientosData.Modelo
                    ,ModeloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Modelo), "Modelo_de_equipo_tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Modelo_Modelo_de_equipo_tactico.Descripcion
                    ,Inventario = Detalle_Aseguramiento_Otros_AseguramientosData.Inventario
                    ,Serie = Detalle_Aseguramiento_Otros_AseguramientosData.Serie
                    ,Unidad_de_Medida = Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida
                    ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida), "Unidad_de_Medida_de_Equipo_Tactico") ??  (string)Detalle_Aseguramiento_Otros_AseguramientosData.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
                    ,Cantidad = Detalle_Aseguramiento_Otros_AseguramientosData.Cantidad
                    ,Observaciones = Detalle_Aseguramiento_Otros_AseguramientosData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Equipo_Tacticos_Tipo = _ITipo_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Tipo_de_Equipo_Tacticos_Tipo != null && Tipo_de_Equipo_Tacticos_Tipo.Resource != null)
                ViewBag.Tipo_de_Equipo_Tacticos_Tipo = Tipo_de_Equipo_Tacticos_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Equipo_Tacticos_Marca = _IMarca_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Marca_de_Equipo_Tacticos_Marca != null && Marca_de_Equipo_Tacticos_Marca.Resource != null)
                ViewBag.Marca_de_Equipo_Tacticos_Marca = Marca_de_Equipo_Tacticos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModelo_de_equipo_tacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modelo_de_equipo_tacticos_Modelo = _IModelo_de_equipo_tacticoApiConsumer.SelAll(true);
            if (Modelo_de_equipo_tacticos_Modelo != null && Modelo_de_equipo_tacticos_Modelo.Resource != null)
                ViewBag.Modelo_de_equipo_tacticos_Modelo = Modelo_de_equipo_tacticos_Modelo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modelo_de_equipo_tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida = _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SelAll(true);
            if (Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida != null && Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida.Resource != null)
                ViewBag.Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida = Unidad_de_Medida_de_Equipo_Tacticos_Unidad_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad_de_Medida_de_Equipo_Tactico", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Aseguramiento_Otros_Aseguramientos", varDetalle_Aseguramiento_Otros_Aseguramientos);
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
        public ActionResult GetTipo_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Equipo_Tactico", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Equipo_Tactico", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModelo_de_equipo_tacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModelo_de_equipo_tacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModelo_de_equipo_tacticoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modelo_de_equipo_tactico", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetUnidad_de_Medida_de_Equipo_TacticoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidad_de_Medida_de_Equipo_TacticoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad_de_Medida_de_Equipo_Tactico", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Otros_AseguramientosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otros_Aseguramientoss == null)
                result.Detalle_Aseguramiento_Otros_Aseguramientoss = new List<Detalle_Aseguramiento_Otros_Aseguramientos>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Otros_Aseguramientoss.Select(m => new Detalle_Aseguramiento_Otros_AseguramientosGridModel
                    {
                    Clave = m.Clave
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_de_Equipo_Tactico.Descripcion
                        ,ModeloDescripcion = CultureHelper.GetTraduction(m.Modelo_Modelo_de_equipo_tactico.Clave.ToString(), "Descripcion") ?? (string)m.Modelo_Modelo_de_equipo_tactico.Descripcion
			,Inventario = m.Inventario
			,Serie = m.Serie
                        ,Unidad_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
			,Cantidad = m.Cantidad
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
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
                _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Otros_Aseguramientos varDetalle_Aseguramiento_Otros_Aseguramientos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_Otros_AseguramientosModel varDetalle_Aseguramiento_Otros_Aseguramientos)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_Otros_AseguramientosInfo = new Detalle_Aseguramiento_Otros_Aseguramientos
                    {
                        Clave = varDetalle_Aseguramiento_Otros_Aseguramientos.Clave
                        ,Tipo = varDetalle_Aseguramiento_Otros_Aseguramientos.Tipo
                        ,Marca = varDetalle_Aseguramiento_Otros_Aseguramientos.Marca
                        ,Modelo = varDetalle_Aseguramiento_Otros_Aseguramientos.Modelo
                        ,Inventario = varDetalle_Aseguramiento_Otros_Aseguramientos.Inventario
                        ,Serie = varDetalle_Aseguramiento_Otros_Aseguramientos.Serie
                        ,Unidad_de_Medida = varDetalle_Aseguramiento_Otros_Aseguramientos.Unidad_de_Medida
                        ,Cantidad = varDetalle_Aseguramiento_Otros_Aseguramientos.Cantidad
                        ,Observaciones = varDetalle_Aseguramiento_Otros_Aseguramientos.Observaciones

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Update(Detalle_Aseguramiento_Otros_AseguramientosInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.Insert(Detalle_Aseguramiento_Otros_AseguramientosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Aseguramiento_Otros_Aseguramientos script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_Otros_AseguramientosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_Otros_AseguramientosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros_Aseguramientos.js")))
            {
                strDetalle_Aseguramiento_Otros_AseguramientosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Otros_Aseguramientos element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_Otros_AseguramientosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(indexOfArray, strDetalle_Aseguramiento_Otros_AseguramientosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_Otros_AseguramientosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_Otros_AseguramientosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_Otros_AseguramientosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_Otros_AseguramientosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_Otros_AseguramientosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_Otros_AseguramientosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros_Aseguramientos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros_Aseguramientos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros_Aseguramientos.js")))
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
        public ActionResult Detalle_Aseguramiento_Otros_AseguramientosPropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_Otros_AseguramientosPropertyBag", "Detalle_Aseguramiento_Otros_Aseguramientos");
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

            _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Otros_AseguramientosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otros_Aseguramientoss == null)
                result.Detalle_Aseguramiento_Otros_Aseguramientoss = new List<Detalle_Aseguramiento_Otros_Aseguramientos>();

            var data = result.Detalle_Aseguramiento_Otros_Aseguramientoss.Select(m => new Detalle_Aseguramiento_Otros_AseguramientosGridModel
            {
                Clave = m.Clave
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Equipo_Tactico.Descripcion
                ,ModeloDescripcion = (string)m.Modelo_Modelo_de_equipo_tactico.Descripcion
                ,Inventario = m.Inventario
                ,Serie = m.Serie
                ,Unidad_de_MedidaDescripcion = (string)m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
                ,Cantidad = m.Cantidad
                ,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_Otros_AseguramientosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_Otros_AseguramientosList_" + DateTime.Now.ToString());
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

            _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Otros_AseguramientosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Otros_AseguramientosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otros_Aseguramientoss == null)
                result.Detalle_Aseguramiento_Otros_Aseguramientoss = new List<Detalle_Aseguramiento_Otros_Aseguramientos>();

            var data = result.Detalle_Aseguramiento_Otros_Aseguramientoss.Select(m => new Detalle_Aseguramiento_Otros_AseguramientosGridModel
            {
                Clave = m.Clave
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Equipo_Tactico.Descripcion
                ,MarcaDescripcion = (string)m.Marca_Marca_de_Equipo_Tactico.Descripcion
                ,ModeloDescripcion = (string)m.Modelo_Modelo_de_equipo_tactico.Descripcion
                ,Inventario = m.Inventario
                ,Serie = m.Serie
                ,Unidad_de_MedidaDescripcion = (string)m.Unidad_de_Medida_Unidad_de_Medida_de_Equipo_Tactico.Descripcion
                ,Cantidad = m.Cantidad
                ,Observaciones = m.Observaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}