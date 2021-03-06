﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.Estatus_Orientador;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Bitacora_de_Canalizacion_MPI;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Orientador;

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
    public class Detalle_Bitacora_de_Canalizacion_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_Bitacora_de_Canalizacion_MPIService service = null;
        private IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer;
        private IEstatus_de_Expediente_InicialApiConsumer _IEstatus_de_Expediente_InicialApiConsumer;
        private IEstatus_OrientadorApiConsumer _IEstatus_OrientadorApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Bitacora_de_Canalizacion_MPIController(IDetalle_Bitacora_de_Canalizacion_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer Detalle_Bitacora_de_Canalizacion_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IEstatus_de_Expediente_InicialApiConsumer Estatus_de_Expediente_InicialApiConsumer , IEstatus_OrientadorApiConsumer Estatus_OrientadorApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer = Detalle_Bitacora_de_Canalizacion_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IEstatus_de_Expediente_InicialApiConsumer = Estatus_de_Expediente_InicialApiConsumer;
            this._IEstatus_OrientadorApiConsumer = Estatus_OrientadorApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Bitacora_de_Canalizacion_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45177, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45177);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Bitacora_de_Canalizacion_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45177, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45177);
            ViewBag.Permission = permission;
            var varDetalle_Bitacora_de_Canalizacion_MPI = new Detalle_Bitacora_de_Canalizacion_MPIModel();
			
            ViewBag.ObjectId = "45177";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Bitacora_de_Canalizacion_MPIData = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Bitacora_de_Canalizacion_MPIs[0];
                if (Detalle_Bitacora_de_Canalizacion_MPIData == null)
                    return HttpNotFound();

                varDetalle_Bitacora_de_Canalizacion_MPI = new Detalle_Bitacora_de_Canalizacion_MPIModel
                {
                    Clave = (int)Detalle_Bitacora_de_Canalizacion_MPIData.Clave
                    ,Fecha_de_Cambio_de_Estatus = (Detalle_Bitacora_de_Canalizacion_MPIData.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(Detalle_Bitacora_de_Canalizacion_MPIData.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cambio_de_Estatus = Detalle_Bitacora_de_Canalizacion_MPIData.Hora_de_Cambio_de_Estatus
                    ,Estatus_Interno = Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno
                    ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno), "Estatus_de_Expediente_Inicial") ??  (string)Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                    ,Estatus_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion
                    ,Estatus_de_CanalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion), "Estatus_Orientador") ??  (string)Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus_Interno = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus_Interno != null && Estatus_de_Expediente_Inicials_Estatus_Interno.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus_Interno = Estatus_de_Expediente_Inicials_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus_de_Canalizacion = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus_de_Canalizacion != null && Estatus_Orientadors_Estatus_de_Canalizacion.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus_de_Canalizacion = Estatus_Orientadors_Estatus_de_Canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Bitacora_de_Canalizacion_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Bitacora_de_Canalizacion_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45177);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Bitacora_de_Canalizacion_MPIModel varDetalle_Bitacora_de_Canalizacion_MPI= new Detalle_Bitacora_de_Canalizacion_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_Bitacora_de_Canalizacion_MPIsData = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_Bitacora_de_Canalizacion_MPI.Clave=" + id, "").Resource.Detalle_Bitacora_de_Canalizacion_MPIs;
				
				if (Detalle_Bitacora_de_Canalizacion_MPIsData != null && Detalle_Bitacora_de_Canalizacion_MPIsData.Count > 0)
                {
					var Detalle_Bitacora_de_Canalizacion_MPIData = Detalle_Bitacora_de_Canalizacion_MPIsData.First();
					varDetalle_Bitacora_de_Canalizacion_MPI= new Detalle_Bitacora_de_Canalizacion_MPIModel
					{
						Clave  = Detalle_Bitacora_de_Canalizacion_MPIData.Clave 
	                    ,Fecha_de_Cambio_de_Estatus = (Detalle_Bitacora_de_Canalizacion_MPIData.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(Detalle_Bitacora_de_Canalizacion_MPIData.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Cambio_de_Estatus = Detalle_Bitacora_de_Canalizacion_MPIData.Hora_de_Cambio_de_Estatus
                    ,Estatus_Interno = Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno
                    ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno), "Estatus_de_Expediente_Inicial") ??  (string)Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                    ,Estatus_de_Canalizacion = Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion
                    ,Estatus_de_CanalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion), "Estatus_Orientador") ??  (string)Detalle_Bitacora_de_Canalizacion_MPIData.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Expediente_Inicials_Estatus_Interno = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(true);
            if (Estatus_de_Expediente_Inicials_Estatus_Interno != null && Estatus_de_Expediente_Inicials_Estatus_Interno.Resource != null)
                ViewBag.Estatus_de_Expediente_Inicials_Estatus_Interno = Estatus_de_Expediente_Inicials_Estatus_Interno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_OrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Orientadors_Estatus_de_Canalizacion = _IEstatus_OrientadorApiConsumer.SelAll(true);
            if (Estatus_Orientadors_Estatus_de_Canalizacion != null && Estatus_Orientadors_Estatus_de_Canalizacion.Resource != null)
                ViewBag.Estatus_Orientadors_Estatus_de_Canalizacion = Estatus_Orientadors_Estatus_de_Canalizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Orientador", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Bitacora_de_Canalizacion_MPI", varDetalle_Bitacora_de_Canalizacion_MPI);
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
        public ActionResult GetEstatus_de_Expediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Expediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Expediente_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Expediente_Inicial", "Descripcion")?? m.Descripcion,
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Bitacora_de_Canalizacion_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Bitacora_de_Canalizacion_MPIs == null)
                result.Detalle_Bitacora_de_Canalizacion_MPIs = new List<Detalle_Bitacora_de_Canalizacion_MPI>();

            return Json(new
            {
                data = result.Detalle_Bitacora_de_Canalizacion_MPIs.Select(m => new Detalle_Bitacora_de_Canalizacion_MPIGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Cambio_de_Estatus = (m.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Cambio_de_Estatus = m.Hora_de_Cambio_de_Estatus
                        ,Estatus_InternoDescripcion = CultureHelper.GetTraduction(m.Estatus_Interno_Estatus_de_Expediente_Inicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                        ,Estatus_de_CanalizacionDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Canalizacion_Estatus_Orientador.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

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
                _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Bitacora_de_Canalizacion_MPI varDetalle_Bitacora_de_Canalizacion_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Bitacora_de_Canalizacion_MPIModel varDetalle_Bitacora_de_Canalizacion_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Bitacora_de_Canalizacion_MPIInfo = new Detalle_Bitacora_de_Canalizacion_MPI
                    {
                        Clave = varDetalle_Bitacora_de_Canalizacion_MPI.Clave
                        ,Fecha_de_Cambio_de_Estatus = (!String.IsNullOrEmpty(varDetalle_Bitacora_de_Canalizacion_MPI.Fecha_de_Cambio_de_Estatus)) ? DateTime.ParseExact(varDetalle_Bitacora_de_Canalizacion_MPI.Fecha_de_Cambio_de_Estatus, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Cambio_de_Estatus = varDetalle_Bitacora_de_Canalizacion_MPI.Hora_de_Cambio_de_Estatus
                        ,Estatus_Interno = varDetalle_Bitacora_de_Canalizacion_MPI.Estatus_Interno
                        ,Estatus_de_Canalizacion = varDetalle_Bitacora_de_Canalizacion_MPI.Estatus_de_Canalizacion

                    };

                    result = !IsNew ?
                        _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Update(Detalle_Bitacora_de_Canalizacion_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.Insert(Detalle_Bitacora_de_Canalizacion_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Bitacora_de_Canalizacion_MPI script
        /// </summary>
        /// <param name="oDetalle_Bitacora_de_Canalizacion_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Bitacora_de_Canalizacion_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Bitacora_de_Canalizacion_MPI.js")))
            {
                strDetalle_Bitacora_de_Canalizacion_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Bitacora_de_Canalizacion_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Bitacora_de_Canalizacion_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(indexOfArray, strDetalle_Bitacora_de_Canalizacion_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Bitacora_de_Canalizacion_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(indexOfArrayHistory, strDetalle_Bitacora_de_Canalizacion_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Bitacora_de_Canalizacion_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Bitacora_de_Canalizacion_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Bitacora_de_Canalizacion_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Bitacora_de_Canalizacion_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Bitacora_de_Canalizacion_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Bitacora_de_Canalizacion_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Bitacora_de_Canalizacion_MPI.js")))
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
        public ActionResult Detalle_Bitacora_de_Canalizacion_MPIPropertyBag()
        {
            return PartialView("Detalle_Bitacora_de_Canalizacion_MPIPropertyBag", "Detalle_Bitacora_de_Canalizacion_MPI");
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

            _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Bitacora_de_Canalizacion_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Bitacora_de_Canalizacion_MPIs == null)
                result.Detalle_Bitacora_de_Canalizacion_MPIs = new List<Detalle_Bitacora_de_Canalizacion_MPI>();

            var data = result.Detalle_Bitacora_de_Canalizacion_MPIs.Select(m => new Detalle_Bitacora_de_Canalizacion_MPIGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Cambio_de_Estatus = (m.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Cambio_de_Estatus = m.Hora_de_Cambio_de_Estatus
                ,Estatus_InternoDescripcion = (string)m.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                ,Estatus_de_CanalizacionDescripcion = (string)m.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Bitacora_de_Canalizacion_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Bitacora_de_Canalizacion_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Bitacora_de_Canalizacion_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Bitacora_de_Canalizacion_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Bitacora_de_Canalizacion_MPIs == null)
                result.Detalle_Bitacora_de_Canalizacion_MPIs = new List<Detalle_Bitacora_de_Canalizacion_MPI>();

            var data = result.Detalle_Bitacora_de_Canalizacion_MPIs.Select(m => new Detalle_Bitacora_de_Canalizacion_MPIGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Cambio_de_Estatus = (m.Fecha_de_Cambio_de_Estatus == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cambio_de_Estatus).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Cambio_de_Estatus = m.Hora_de_Cambio_de_Estatus
                ,Estatus_InternoDescripcion = (string)m.Estatus_Interno_Estatus_de_Expediente_Inicial.Descripcion
                ,Estatus_de_CanalizacionDescripcion = (string)m.Estatus_de_Canalizacion_Estatus_Orientador.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
