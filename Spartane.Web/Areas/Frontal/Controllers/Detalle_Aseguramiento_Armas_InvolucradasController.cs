﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Core.Domain.Motivo_de_Registro;
using Spartane.Core.Domain.Tipo_de_Arma;
using Spartane.Core.Domain.Marca_de_Arma;
using Spartane.Core.Domain.Calibre_de_Arma;
using Spartane.Core.Domain.Tipo_Clasificacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Armas_Involucradas;
using Spartane.Web.Areas.WebApiConsumer.Motivo_de_Registro;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Marca_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Calibre_de_Arma;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Clasificacion;

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
    public class Detalle_Aseguramiento_Armas_InvolucradasController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_Armas_InvolucradasService service = null;
        private IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer;
        private IMotivo_de_RegistroApiConsumer _IMotivo_de_RegistroApiConsumer;
        private ITipo_de_ArmaApiConsumer _ITipo_de_ArmaApiConsumer;
        private IMarca_de_ArmaApiConsumer _IMarca_de_ArmaApiConsumer;
        private ICalibre_de_ArmaApiConsumer _ICalibre_de_ArmaApiConsumer;
        private ITipo_ClasificacionApiConsumer _ITipo_ClasificacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_Armas_InvolucradasController(IDetalle_Aseguramiento_Armas_InvolucradasService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer Detalle_Aseguramiento_Armas_InvolucradasApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IMotivo_de_RegistroApiConsumer Motivo_de_RegistroApiConsumer , ITipo_de_ArmaApiConsumer Tipo_de_ArmaApiConsumer , IMarca_de_ArmaApiConsumer Marca_de_ArmaApiConsumer , ICalibre_de_ArmaApiConsumer Calibre_de_ArmaApiConsumer , ITipo_ClasificacionApiConsumer Tipo_ClasificacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer = Detalle_Aseguramiento_Armas_InvolucradasApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IMotivo_de_RegistroApiConsumer = Motivo_de_RegistroApiConsumer;
            this._ITipo_de_ArmaApiConsumer = Tipo_de_ArmaApiConsumer;
            this._IMarca_de_ArmaApiConsumer = Marca_de_ArmaApiConsumer;
            this._ICalibre_de_ArmaApiConsumer = Calibre_de_ArmaApiConsumer;
            this._ITipo_ClasificacionApiConsumer = Tipo_ClasificacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Armas_Involucradas
        [ObjectAuth(ObjectId = (ModuleObjectId)45489, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45489);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Armas_Involucradas/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45489, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45489);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Armas_Involucradas = new Detalle_Aseguramiento_Armas_InvolucradasModel();
			
            ViewBag.ObjectId = "45489";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_Armas_InvolucradasData = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Armas_Involucradass[0];
                if (Detalle_Aseguramiento_Armas_InvolucradasData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Armas_Involucradas = new Detalle_Aseguramiento_Armas_InvolucradasModel
                {
                    Clave = (int)Detalle_Aseguramiento_Armas_InvolucradasData.Clave
                    ,Motivo_de_Registro = Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro
                    ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro), "Motivo_de_Registro") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                    ,Tipo = Detalle_Aseguramiento_Armas_InvolucradasData.Tipo
                    ,TipoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Tipo), "Tipo_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Tipo_Tipo_de_Arma.Nombre
                    ,Descripcion_del_Arma = Detalle_Aseguramiento_Armas_InvolucradasData.Descripcion_del_Arma
                    ,Marca = Detalle_Aseguramiento_Armas_InvolucradasData.Marca
                    ,MarcaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Marca), "Marca_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Marca_Marca_de_Arma.Nombre
                    ,Calibre = Detalle_Aseguramiento_Armas_InvolucradasData.Calibre
                    ,CalibreDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Calibre), "Calibre_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Calibre_Calibre_de_Arma.Descripcion
                    ,Matricula = Detalle_Aseguramiento_Armas_InvolucradasData.Matricula
                    ,Serie = Detalle_Aseguramiento_Armas_InvolucradasData.Serie
                    ,Arma_Oficial = Detalle_Aseguramiento_Armas_InvolucradasData.Arma_Oficial.GetValueOrDefault()
                    ,Inventario = Detalle_Aseguramiento_Armas_InvolucradasData.Inventario
                    ,Clasificacion = Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion
                    ,ClasificacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion), "Tipo_Clasificacion") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion_Tipo_Clasificacion.Descripcion
                    ,Valor_Estimado = Detalle_Aseguramiento_Armas_InvolucradasData.Valor_Estimado
                    ,Lugar_de_Hallazgo = Detalle_Aseguramiento_Armas_InvolucradasData.Lugar_de_Hallazgo
                    ,Observaciones = Detalle_Aseguramiento_Armas_InvolucradasData.Observaciones

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Registros_Motivo_de_Registro = _IMotivo_de_RegistroApiConsumer.SelAll(true);
            if (Motivo_de_Registros_Motivo_de_Registro != null && Motivo_de_Registros_Motivo_de_Registro.Resource != null)
                ViewBag.Motivo_de_Registros_Motivo_de_Registro = Motivo_de_Registros_Motivo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Armas_Tipo = _ITipo_de_ArmaApiConsumer.SelAll(true);
            if (Tipo_de_Armas_Tipo != null && Tipo_de_Armas_Tipo.Resource != null)
                ViewBag.Tipo_de_Armas_Tipo = Tipo_de_Armas_Tipo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Arma", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Armas_Marca = _IMarca_de_ArmaApiConsumer.SelAll(true);
            if (Marca_de_Armas_Marca != null && Marca_de_Armas_Marca.Resource != null)
                ViewBag.Marca_de_Armas_Marca = Marca_de_Armas_Marca.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Arma", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalibre_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calibre_de_Armas_Calibre = _ICalibre_de_ArmaApiConsumer.SelAll(true);
            if (Calibre_de_Armas_Calibre != null && Calibre_de_Armas_Calibre.Resource != null)
                ViewBag.Calibre_de_Armas_Calibre = Calibre_de_Armas_Calibre.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calibre_de_Arma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_ClasificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Clasificacions_Clasificacion = _ITipo_ClasificacionApiConsumer.SelAll(true);
            if (Tipo_Clasificacions_Clasificacion != null && Tipo_Clasificacions_Clasificacion.Resource != null)
                ViewBag.Tipo_Clasificacions_Clasificacion = Tipo_Clasificacions_Clasificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Clasificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Armas_Involucradas);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Armas_Involucradas(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45489);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_Armas_InvolucradasModel varDetalle_Aseguramiento_Armas_Involucradas= new Detalle_Aseguramiento_Armas_InvolucradasModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_Armas_InvolucradassData = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Armas_Involucradas.Clave=" + id, "").Resource.Detalle_Aseguramiento_Armas_Involucradass;
				
				if (Detalle_Aseguramiento_Armas_InvolucradassData != null && Detalle_Aseguramiento_Armas_InvolucradassData.Count > 0)
                {
					var Detalle_Aseguramiento_Armas_InvolucradasData = Detalle_Aseguramiento_Armas_InvolucradassData.First();
					varDetalle_Aseguramiento_Armas_Involucradas= new Detalle_Aseguramiento_Armas_InvolucradasModel
					{
						Clave  = Detalle_Aseguramiento_Armas_InvolucradasData.Clave 
	                    ,Motivo_de_Registro = Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro
                    ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro), "Motivo_de_Registro") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                    ,Tipo = Detalle_Aseguramiento_Armas_InvolucradasData.Tipo
                    ,TipoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Tipo), "Tipo_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Tipo_Tipo_de_Arma.Nombre
                    ,Descripcion_del_Arma = Detalle_Aseguramiento_Armas_InvolucradasData.Descripcion_del_Arma
                    ,Marca = Detalle_Aseguramiento_Armas_InvolucradasData.Marca
                    ,MarcaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Marca), "Marca_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Marca_Marca_de_Arma.Nombre
                    ,Calibre = Detalle_Aseguramiento_Armas_InvolucradasData.Calibre
                    ,CalibreDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Calibre), "Calibre_de_Arma") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Calibre_Calibre_de_Arma.Descripcion
                    ,Matricula = Detalle_Aseguramiento_Armas_InvolucradasData.Matricula
                    ,Serie = Detalle_Aseguramiento_Armas_InvolucradasData.Serie
                    ,Arma_Oficial = Detalle_Aseguramiento_Armas_InvolucradasData.Arma_Oficial.GetValueOrDefault()
                    ,Inventario = Detalle_Aseguramiento_Armas_InvolucradasData.Inventario
                    ,Clasificacion = Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion
                    ,ClasificacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion), "Tipo_Clasificacion") ??  (string)Detalle_Aseguramiento_Armas_InvolucradasData.Clasificacion_Tipo_Clasificacion.Descripcion
                    ,Valor_Estimado = Detalle_Aseguramiento_Armas_InvolucradasData.Valor_Estimado
                    ,Lugar_de_Hallazgo = Detalle_Aseguramiento_Armas_InvolucradasData.Lugar_de_Hallazgo
                    ,Observaciones = Detalle_Aseguramiento_Armas_InvolucradasData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_de_Registros_Motivo_de_Registro = _IMotivo_de_RegistroApiConsumer.SelAll(true);
            if (Motivo_de_Registros_Motivo_de_Registro != null && Motivo_de_Registros_Motivo_de_Registro.Resource != null)
                ViewBag.Motivo_de_Registros_Motivo_de_Registro = Motivo_de_Registros_Motivo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Armas_Tipo = _ITipo_de_ArmaApiConsumer.SelAll(true);
            if (Tipo_de_Armas_Tipo != null && Tipo_de_Armas_Tipo.Resource != null)
                ViewBag.Tipo_de_Armas_Tipo = Tipo_de_Armas_Tipo.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Arma", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_de_Armas_Marca = _IMarca_de_ArmaApiConsumer.SelAll(true);
            if (Marca_de_Armas_Marca != null && Marca_de_Armas_Marca.Resource != null)
                ViewBag.Marca_de_Armas_Marca = Marca_de_Armas_Marca.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Arma", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalibre_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calibre_de_Armas_Calibre = _ICalibre_de_ArmaApiConsumer.SelAll(true);
            if (Calibre_de_Armas_Calibre != null && Calibre_de_Armas_Calibre.Resource != null)
                ViewBag.Calibre_de_Armas_Calibre = Calibre_de_Armas_Calibre.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calibre_de_Arma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_ClasificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Clasificacions_Clasificacion = _ITipo_ClasificacionApiConsumer.SelAll(true);
            if (Tipo_Clasificacions_Clasificacion != null && Tipo_Clasificacions_Clasificacion.Resource != null)
                ViewBag.Tipo_Clasificacions_Clasificacion = Tipo_Clasificacions_Clasificacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Clasificacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Aseguramiento_Armas_Involucradas", varDetalle_Aseguramiento_Armas_Involucradas);
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
        public ActionResult GetMotivo_de_RegistroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_de_RegistroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_de_RegistroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_de_Registro", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ArmaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Arma", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_de_ArmaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_de_Arma", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCalibre_de_ArmaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalibre_de_ArmaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalibre_de_ArmaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calibre_de_Arma", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_ClasificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_ClasificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_ClasificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Clasificacion", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Armas_InvolucradasPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Armas_Involucradass == null)
                result.Detalle_Aseguramiento_Armas_Involucradass = new List<Detalle_Aseguramiento_Armas_Involucradas>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Armas_Involucradass.Select(m => new Detalle_Aseguramiento_Armas_InvolucradasGridModel
                    {
                    Clave = m.Clave
                        ,Motivo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Registro_Motivo_de_Registro.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                        ,TipoNombre = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Arma.Clave.ToString(), "Nombre") ?? (string)m.Tipo_Tipo_de_Arma.Nombre
			,Descripcion_del_Arma = m.Descripcion_del_Arma
                        ,MarcaNombre = CultureHelper.GetTraduction(m.Marca_Marca_de_Arma.Clave.ToString(), "Nombre") ?? (string)m.Marca_Marca_de_Arma.Nombre
                        ,CalibreDescripcion = CultureHelper.GetTraduction(m.Calibre_Calibre_de_Arma.Clave.ToString(), "Descripcion") ?? (string)m.Calibre_Calibre_de_Arma.Descripcion
			,Matricula = m.Matricula
			,Serie = m.Serie
			,Arma_Oficial = m.Arma_Oficial
			,Inventario = m.Inventario
                        ,ClasificacionDescripcion = CultureHelper.GetTraduction(m.Clasificacion_Tipo_Clasificacion.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_Tipo_Clasificacion.Descripcion
			,Valor_Estimado = m.Valor_Estimado
			,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
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
                _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Armas_Involucradas varDetalle_Aseguramiento_Armas_Involucradas = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_Armas_InvolucradasModel varDetalle_Aseguramiento_Armas_Involucradas)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_Armas_InvolucradasInfo = new Detalle_Aseguramiento_Armas_Involucradas
                    {
                        Clave = varDetalle_Aseguramiento_Armas_Involucradas.Clave
                        ,Motivo_de_Registro = varDetalle_Aseguramiento_Armas_Involucradas.Motivo_de_Registro
                        ,Tipo = varDetalle_Aseguramiento_Armas_Involucradas.Tipo
                        ,Descripcion_del_Arma = varDetalle_Aseguramiento_Armas_Involucradas.Descripcion_del_Arma
                        ,Marca = varDetalle_Aseguramiento_Armas_Involucradas.Marca
                        ,Calibre = varDetalle_Aseguramiento_Armas_Involucradas.Calibre
                        ,Matricula = varDetalle_Aseguramiento_Armas_Involucradas.Matricula
                        ,Serie = varDetalle_Aseguramiento_Armas_Involucradas.Serie
                        ,Arma_Oficial = varDetalle_Aseguramiento_Armas_Involucradas.Arma_Oficial
                        ,Inventario = varDetalle_Aseguramiento_Armas_Involucradas.Inventario
                        ,Clasificacion = varDetalle_Aseguramiento_Armas_Involucradas.Clasificacion
                        ,Valor_Estimado = varDetalle_Aseguramiento_Armas_Involucradas.Valor_Estimado
                        ,Lugar_de_Hallazgo = varDetalle_Aseguramiento_Armas_Involucradas.Lugar_de_Hallazgo
                        ,Observaciones = varDetalle_Aseguramiento_Armas_Involucradas.Observaciones

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Update(Detalle_Aseguramiento_Armas_InvolucradasInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.Insert(Detalle_Aseguramiento_Armas_InvolucradasInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Aseguramiento_Armas_Involucradas script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_Armas_InvolucradasElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_Armas_InvolucradasScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Armas_Involucradas.js")))
            {
                strDetalle_Aseguramiento_Armas_InvolucradasScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Armas_Involucradas element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_Armas_InvolucradasScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(indexOfArray, strDetalle_Aseguramiento_Armas_InvolucradasScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_Armas_InvolucradasScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_Armas_InvolucradasScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_Armas_InvolucradasScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_Armas_InvolucradasModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_Armas_InvolucradasScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_Armas_InvolucradasScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Armas_Involucradas.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Armas_Involucradas.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Armas_Involucradas.js")))
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
        public ActionResult Detalle_Aseguramiento_Armas_InvolucradasPropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_Armas_InvolucradasPropertyBag", "Detalle_Aseguramiento_Armas_Involucradas");
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

            _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Armas_InvolucradasPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Armas_Involucradass == null)
                result.Detalle_Aseguramiento_Armas_Involucradass = new List<Detalle_Aseguramiento_Armas_Involucradas>();

            var data = result.Detalle_Aseguramiento_Armas_Involucradass.Select(m => new Detalle_Aseguramiento_Armas_InvolucradasGridModel
            {
                Clave = m.Clave
                ,Motivo_de_RegistroDescripcion = (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                ,TipoNombre = (string)m.Tipo_Tipo_de_Arma.Nombre
                ,Descripcion_del_Arma = m.Descripcion_del_Arma
                ,MarcaNombre = (string)m.Marca_Marca_de_Arma.Nombre
                ,CalibreDescripcion = (string)m.Calibre_Calibre_de_Arma.Descripcion
                ,Matricula = m.Matricula
                ,Serie = m.Serie
                ,Arma_Oficial = m.Arma_Oficial
                ,Inventario = m.Inventario
                ,ClasificacionDescripcion = (string)m.Clasificacion_Tipo_Clasificacion.Descripcion
                ,Valor_Estimado = m.Valor_Estimado
                ,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
                ,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_Armas_InvolucradasList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_Armas_InvolucradasList_" + DateTime.Now.ToString());
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

            _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_Armas_InvolucradasPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_Armas_InvolucradasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Armas_Involucradass == null)
                result.Detalle_Aseguramiento_Armas_Involucradass = new List<Detalle_Aseguramiento_Armas_Involucradas>();

            var data = result.Detalle_Aseguramiento_Armas_Involucradass.Select(m => new Detalle_Aseguramiento_Armas_InvolucradasGridModel
            {
                Clave = m.Clave
                ,Motivo_de_RegistroDescripcion = (string)m.Motivo_de_Registro_Motivo_de_Registro.Descripcion
                ,TipoNombre = (string)m.Tipo_Tipo_de_Arma.Nombre
                ,Descripcion_del_Arma = m.Descripcion_del_Arma
                ,MarcaNombre = (string)m.Marca_Marca_de_Arma.Nombre
                ,CalibreDescripcion = (string)m.Calibre_Calibre_de_Arma.Descripcion
                ,Matricula = m.Matricula
                ,Serie = m.Serie
                ,Arma_Oficial = m.Arma_Oficial
                ,Inventario = m.Inventario
                ,ClasificacionDescripcion = (string)m.Clasificacion_Tipo_Clasificacion.Descripcion
                ,Valor_Estimado = m.Valor_Estimado
                ,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
                ,Observaciones = m.Observaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
