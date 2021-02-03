using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Fotos;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Fotos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos;

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
    public class Detalle_de_FotosController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_FotosService service = null;
        private IDetalle_de_FotosApiConsumer _IDetalle_de_FotosApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_FotosController(IDetalle_de_FotosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_FotosApiConsumer Detalle_de_FotosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_FotosApiConsumer = Detalle_de_FotosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Fotos
        [ObjectAuth(ObjectId = (ModuleObjectId)45669, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45669);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Fotos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45669, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45669);
            ViewBag.Permission = permission;
            var varDetalle_de_Fotos = new Detalle_de_FotosModel();
			
            ViewBag.ObjectId = "45669";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_FotosData = _IDetalle_de_FotosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Fotoss[0];
                if (Detalle_de_FotosData == null)
                    return HttpNotFound();

                varDetalle_de_Fotos = new Detalle_de_FotosModel
                {
                    Clave = (int)Detalle_de_FotosData.Clave
                    ,Foto_Perfil_Izquierdo = Detalle_de_FotosData.Foto_Perfil_Izquierdo
                    ,Foto_Perfil_Derecho = Detalle_de_FotosData.Foto_Perfil_Derecho
                    ,Foto_de_Frente = Detalle_de_FotosData.Foto_de_Frente

                };
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_Perfil_IzquierdoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_Perfil_Izquierdo).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_Perfil_DerechoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_Perfil_Derecho).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_de_FrenteSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_de_Frente).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Fotos);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Fotos(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45669);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_FotosModel varDetalle_de_Fotos= new Detalle_de_FotosModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_FotossData = _IDetalle_de_FotosApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Fotos.Clave=" + id, "").Resource.Detalle_de_Fotoss;
				
				if (Detalle_de_FotossData != null && Detalle_de_FotossData.Count > 0)
                {
					var Detalle_de_FotosData = Detalle_de_FotossData.First();
					varDetalle_de_Fotos= new Detalle_de_FotosModel
					{
						Clave  = Detalle_de_FotosData.Clave 
	                    ,Foto_Perfil_Izquierdo = Detalle_de_FotosData.Foto_Perfil_Izquierdo
                    ,Foto_Perfil_Derecho = Detalle_de_FotosData.Foto_Perfil_Derecho
                    ,Foto_de_Frente = Detalle_de_FotosData.Foto_de_Frente

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_Perfil_IzquierdoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_Perfil_Izquierdo).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_Perfil_DerechoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_Perfil_Derecho).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Foto_de_FrenteSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Fotos.Foto_de_Frente).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_de_Fotos", varDetalle_de_Fotos);
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




        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_FotosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_FotosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Fotoss == null)
                result.Detalle_de_Fotoss = new List<Detalle_de_Fotos>();

            return Json(new
            {
                data = result.Detalle_de_Fotoss.Select(m => new Detalle_de_FotosGridModel
                    {
                    Clave = m.Clave
			,Foto_Perfil_Izquierdo = m.Foto_Perfil_Izquierdo
			,Foto_Perfil_Derecho = m.Foto_Perfil_Derecho
			,Foto_de_Frente = m.Foto_de_Frente

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
                _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Fotos varDetalle_de_Fotos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_FotosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_FotosModel varDetalle_de_Fotos)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Fotos.Foto_Perfil_IzquierdoRemoveAttachment != 0 && varDetalle_de_Fotos.Foto_Perfil_IzquierdoFile == null)
                    {
                        varDetalle_de_Fotos.Foto_Perfil_Izquierdo = 0;
                    }

                    if (varDetalle_de_Fotos.Foto_Perfil_IzquierdoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Fotos.Foto_Perfil_IzquierdoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Fotos.Foto_Perfil_Izquierdo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Fotos.Foto_Perfil_IzquierdoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varDetalle_de_Fotos.Foto_Perfil_DerechoRemoveAttachment != 0 && varDetalle_de_Fotos.Foto_Perfil_DerechoFile == null)
                    {
                        varDetalle_de_Fotos.Foto_Perfil_Derecho = 0;
                    }

                    if (varDetalle_de_Fotos.Foto_Perfil_DerechoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Fotos.Foto_Perfil_DerechoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Fotos.Foto_Perfil_Derecho = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Fotos.Foto_Perfil_DerechoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varDetalle_de_Fotos.Foto_de_FrenteRemoveAttachment != 0 && varDetalle_de_Fotos.Foto_de_FrenteFile == null)
                    {
                        varDetalle_de_Fotos.Foto_de_Frente = 0;
                    }

                    if (varDetalle_de_Fotos.Foto_de_FrenteFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Fotos.Foto_de_FrenteFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Fotos.Foto_de_Frente = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Fotos.Foto_de_FrenteFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_FotosInfo = new Detalle_de_Fotos
                    {
                        Clave = varDetalle_de_Fotos.Clave
                        ,Foto_Perfil_Izquierdo = (varDetalle_de_Fotos.Foto_Perfil_Izquierdo.HasValue && varDetalle_de_Fotos.Foto_Perfil_Izquierdo != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Fotos.Foto_Perfil_Izquierdo.Value)) : null

                        ,Foto_Perfil_Derecho = (varDetalle_de_Fotos.Foto_Perfil_Derecho.HasValue && varDetalle_de_Fotos.Foto_Perfil_Derecho != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Fotos.Foto_Perfil_Derecho.Value)) : null

                        ,Foto_de_Frente = (varDetalle_de_Fotos.Foto_de_Frente.HasValue && varDetalle_de_Fotos.Foto_de_Frente != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Fotos.Foto_de_Frente.Value)) : null


                    };

                    result = !IsNew ?
                        _IDetalle_de_FotosApiConsumer.Update(Detalle_de_FotosInfo, null, null).Resource.ToString() :
                         _IDetalle_de_FotosApiConsumer.Insert(Detalle_de_FotosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Fotos script
        /// </summary>
        /// <param name="oDetalle_de_FotosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_FotosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_FotosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Fotos.js")))
            {
                strDetalle_de_FotosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Fotos element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_FotosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_FotosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_FotosScript.Substring(indexOfArray, strDetalle_de_FotosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_FotosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_FotosScript.Substring(indexOfArrayHistory, strDetalle_de_FotosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_FotosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_FotosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_FotosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_FotosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_FotosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_FotosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_FotosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_FotosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Fotos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Fotos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Fotos.js")))
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
        public ActionResult Detalle_de_FotosPropertyBag()
        {
            return PartialView("Detalle_de_FotosPropertyBag", "Detalle_de_Fotos");
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

            _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_FotosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_FotosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Fotoss == null)
                result.Detalle_de_Fotoss = new List<Detalle_de_Fotos>();

            var data = result.Detalle_de_Fotoss.Select(m => new Detalle_de_FotosGridModel
            {
                Clave = m.Clave

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_FotosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_FotosList_" + DateTime.Now.ToString());
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

            _IDetalle_de_FotosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_FotosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_FotosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Fotoss == null)
                result.Detalle_de_Fotoss = new List<Detalle_de_Fotos>();

            var data = result.Detalle_de_Fotoss.Select(m => new Detalle_de_FotosGridModel
            {
                Clave = m.Clave

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
