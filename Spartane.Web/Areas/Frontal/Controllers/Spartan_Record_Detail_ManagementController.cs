using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using Spartane.Core.Domain.Spartan_RDM_Filters_Detail;

using Spartane.Core.Domain.Spartan_Attribute_Bypass;






using Spartane.Core.Domain.Spartan_Attribute_Bypass;
using Spartane.Core.Domain.Spartan_RDM_Operations_Detail;

using Spartane.Core.Domain.Spartan_Object_ByPass;







using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Spartan_Record_Detail_Management;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Record_Detail_Management;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Filters_Detail;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Operations_Detail;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass;



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
    public class Spartan_Record_Detail_ManagementController : Controller
    {
        #region "variable declaration"

        private ISpartan_Record_Detail_ManagementService service = null;
        private ISpartan_Record_Detail_ManagementApiConsumer _ISpartan_Record_Detail_ManagementApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ISpartan_Object_ByPassApiConsumer _ISpartan_Object_ByPassApiConsumer;
        private ISpartan_Attribute_BypassApiConsumer _ISpartan_Attribute_BypassApiConsumer;
        private ISpartan_RDM_Filters_DetailApiConsumer _ISpartan_RDM_Filters_DetailApiConsumer;


        private ISpartan_RDM_Operations_DetailApiConsumer _ISpartan_RDM_Operations_DetailApiConsumer;




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

        
        public Spartan_Record_Detail_ManagementController(ISpartan_Record_Detail_ManagementService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISpartan_Record_Detail_ManagementApiConsumer Spartan_Record_Detail_ManagementApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ISpartan_Object_ByPassApiConsumer Spartan_Object_ByPassApiConsumer , ISpartan_Attribute_BypassApiConsumer Spartan_Attribute_BypassApiConsumer , ISpartan_RDM_Filters_DetailApiConsumer Spartan_RDM_Filters_DetailApiConsumer  , ISpartan_RDM_Operations_DetailApiConsumer Spartan_RDM_Operations_DetailApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISpartan_Record_Detail_ManagementApiConsumer = Spartan_Record_Detail_ManagementApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_Object_ByPassApiConsumer = Spartan_Object_ByPassApiConsumer;
            this._ISpartan_Attribute_BypassApiConsumer = Spartan_Attribute_BypassApiConsumer;
            this._ISpartan_RDM_Filters_DetailApiConsumer = Spartan_RDM_Filters_DetailApiConsumer;

            this._ISpartan_Attribute_BypassApiConsumer = Spartan_Attribute_BypassApiConsumer;

            this._ISpartan_Attribute_BypassApiConsumer = Spartan_Attribute_BypassApiConsumer;
            this._ISpartan_RDM_Operations_DetailApiConsumer = Spartan_RDM_Operations_DetailApiConsumer;

            this._ISpartan_Object_ByPassApiConsumer = Spartan_Object_ByPassApiConsumer;



        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Spartan_Record_Detail_Management
        [ObjectAuth(ObjectId = (ModuleObjectId)45361, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45361, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Spartan_Record_Detail_Management/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45361, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45361, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSpartan_Record_Detail_Management = new Spartan_Record_Detail_ManagementModel();
			varSpartan_Record_Detail_Management.Process_Id = Id;
			
            ViewBag.ObjectId = "45361";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionSpartan_RDM_Filters_Detail = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45362, ModuleId);
            ViewBag.PermissionSpartan_RDM_Filters_Detail = permissionSpartan_RDM_Filters_Detail;
            var permissionSpartan_RDM_Operations_Detail = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45363, ModuleId);
            ViewBag.PermissionSpartan_RDM_Operations_Detail = permissionSpartan_RDM_Operations_Detail;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Spartan_Record_Detail_ManagementsData = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll(0, 1000, "Spartan_Record_Detail_Management.Process_Id=" + Id, "").Resource.Spartan_Record_Detail_Managements;
				
				if (Spartan_Record_Detail_ManagementsData != null && Spartan_Record_Detail_ManagementsData.Count > 0)
                {
					var Spartan_Record_Detail_ManagementData = Spartan_Record_Detail_ManagementsData.First();
					varSpartan_Record_Detail_Management= new Spartan_Record_Detail_ManagementModel
					{
						Process_Id  = Spartan_Record_Detail_ManagementData.Process_Id 
	                    ,Register_Date = (Spartan_Record_Detail_ManagementData.Register_Date == null ? string.Empty : Convert.ToDateTime(Spartan_Record_Detail_ManagementData.Register_Date).ToString(ConfigurationProperty.DateFormat))
                    ,Register_Hour = Spartan_Record_Detail_ManagementData.Register_Hour
                    ,Register_User = Spartan_Record_Detail_ManagementData.Register_User
                    ,Register_UserName = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Register_User), "Spartan_User") ??  (string)Spartan_Record_Detail_ManagementData.Register_User_Spartan_User.Name
                    ,Description = Spartan_Record_Detail_ManagementData.Description
                    ,Object = Spartan_Record_Detail_ManagementData.Object
                    ,ObjectDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Object), "Spartan_Object_ByPass") ??  (string)Spartan_Record_Detail_ManagementData.Object_Spartan_Object_ByPass.Description
                    ,Reference_Label = Spartan_Record_Detail_ManagementData.Reference_Label
                    ,Reference_Field = Spartan_Record_Detail_ManagementData.Reference_Field
                    ,Reference_FieldDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Reference_Field), "Spartan_Attribute_Bypass") ??  (string)Spartan_Record_Detail_ManagementData.Reference_Field_Spartan_Attribute_Bypass.Description
                    ,Search_Result = Spartan_Record_Detail_ManagementData.Search_Result
                    ,Search_Result_Query = Spartan_Record_Detail_ManagementData.Search_Result_Query
                    ,Image_Field = Spartan_Record_Detail_ManagementData.Image_Field
                    ,Image_FieldDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Image_Field), "Spartan_Attribute_Bypass") ??  (string)Spartan_Record_Detail_ManagementData.Image_Field_Spartan_Attribute_Bypass.Description
                    ,Data_Detail = Spartan_Record_Detail_ManagementData.Data_Detail
                    ,Query_Data_Detail = Spartan_Record_Detail_ManagementData.Query_Data_Detail

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Register_User = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Register_User != null && Spartan_Users_Register_User.Resource != null)
                ViewBag.Spartan_Users_Register_User = Spartan_Users_Register_User.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object != null && Spartan_Object_ByPasss_Object.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object = Spartan_Object_ByPasss_Object.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Reference_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Reference_Field != null && Spartan_Attribute_Bypasss_Reference_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Reference_Field = Spartan_Attribute_Bypasss_Reference_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Image_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Image_Field != null && Spartan_Attribute_Bypasss_Image_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Image_Field = Spartan_Attribute_Bypasss_Image_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
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

				
            return View(varSpartan_Record_Detail_Management);
        }
		
	[HttpGet]
        public ActionResult AddSpartan_Record_Detail_Management(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45361);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
			Spartan_Record_Detail_ManagementModel varSpartan_Record_Detail_Management= new Spartan_Record_Detail_ManagementModel();
            var permissionSpartan_RDM_Filters_Detail = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45362, ModuleId);
            ViewBag.PermissionSpartan_RDM_Filters_Detail = permissionSpartan_RDM_Filters_Detail;
            var permissionSpartan_RDM_Operations_Detail = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45363, ModuleId);
            ViewBag.PermissionSpartan_RDM_Operations_Detail = permissionSpartan_RDM_Operations_Detail;


            if (id.ToString() != "0")
            {
                var Spartan_Record_Detail_ManagementsData = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll(0, 1000, "Spartan_Record_Detail_Management.Process_Id=" + id, "").Resource.Spartan_Record_Detail_Managements;
				
				if (Spartan_Record_Detail_ManagementsData != null && Spartan_Record_Detail_ManagementsData.Count > 0)
                {
					var Spartan_Record_Detail_ManagementData = Spartan_Record_Detail_ManagementsData.First();
					varSpartan_Record_Detail_Management= new Spartan_Record_Detail_ManagementModel
					{
						Process_Id  = Spartan_Record_Detail_ManagementData.Process_Id 
	                    ,Register_Date = (Spartan_Record_Detail_ManagementData.Register_Date == null ? string.Empty : Convert.ToDateTime(Spartan_Record_Detail_ManagementData.Register_Date).ToString(ConfigurationProperty.DateFormat))
                    ,Register_Hour = Spartan_Record_Detail_ManagementData.Register_Hour
                    ,Register_User = Spartan_Record_Detail_ManagementData.Register_User
                    ,Register_UserName = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Register_User), "Spartan_User") ??  (string)Spartan_Record_Detail_ManagementData.Register_User_Spartan_User.Name
                    ,Description = Spartan_Record_Detail_ManagementData.Description
                    ,Object = Spartan_Record_Detail_ManagementData.Object
                    ,ObjectDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Object), "Spartan_Object_ByPass") ??  (string)Spartan_Record_Detail_ManagementData.Object_Spartan_Object_ByPass.Description
                    ,Reference_Label = Spartan_Record_Detail_ManagementData.Reference_Label
                    ,Reference_Field = Spartan_Record_Detail_ManagementData.Reference_Field
                    ,Reference_FieldDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Reference_Field), "Spartan_Attribute_Bypass") ??  (string)Spartan_Record_Detail_ManagementData.Reference_Field_Spartan_Attribute_Bypass.Description
                    ,Search_Result = Spartan_Record_Detail_ManagementData.Search_Result
                    ,Search_Result_Query = Spartan_Record_Detail_ManagementData.Search_Result_Query
                    ,Image_Field = Spartan_Record_Detail_ManagementData.Image_Field
                    ,Image_FieldDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_Record_Detail_ManagementData.Image_Field), "Spartan_Attribute_Bypass") ??  (string)Spartan_Record_Detail_ManagementData.Image_Field_Spartan_Attribute_Bypass.Description
                    ,Data_Detail = Spartan_Record_Detail_ManagementData.Data_Detail
                    ,Query_Data_Detail = Spartan_Record_Detail_ManagementData.Query_Data_Detail

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Register_User = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Register_User != null && Spartan_Users_Register_User.Resource != null)
                ViewBag.Spartan_Users_Register_User = Spartan_Users_Register_User.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object != null && Spartan_Object_ByPasss_Object.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object = Spartan_Object_ByPasss_Object.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Reference_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Reference_Field != null && Spartan_Attribute_Bypasss_Reference_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Reference_Field = Spartan_Attribute_Bypasss_Reference_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Image_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Image_Field != null && Spartan_Attribute_Bypasss_Image_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Image_Field = Spartan_Attribute_Bypasss_Image_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();


            return PartialView("AddSpartan_Record_Detail_Management", varSpartan_Record_Detail_Management);
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
        public ActionResult GetSpartan_Object_ByPassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Object_ByPassApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description")?? m.Description,
                    Value = Convert.ToString(m.ObjectId)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSpartan_Attribute_BypassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Attribute_BypassApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description")?? m.Description,
                    Value = Convert.ToString(m.AttributeId)
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
        public ActionResult ShowAdvanceFilter(Spartan_Record_Detail_ManagementAdvanceSearchModel model, int idFilter = -1)
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

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Register_User = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Register_User != null && Spartan_Users_Register_User.Resource != null)
                ViewBag.Spartan_Users_Register_User = Spartan_Users_Register_User.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object != null && Spartan_Object_ByPasss_Object.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object = Spartan_Object_ByPasss_Object.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Reference_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Reference_Field != null && Spartan_Attribute_Bypasss_Reference_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Reference_Field = Spartan_Attribute_Bypasss_Reference_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Image_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Image_Field != null && Spartan_Attribute_Bypasss_Image_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Image_Field = Spartan_Attribute_Bypasss_Image_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Register_User = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Register_User != null && Spartan_Users_Register_User.Resource != null)
                ViewBag.Spartan_Users_Register_User = Spartan_Users_Register_User.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object != null && Spartan_Object_ByPasss_Object.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object = Spartan_Object_ByPasss_Object.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Reference_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Reference_Field != null && Spartan_Attribute_Bypasss_Reference_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Reference_Field = Spartan_Attribute_Bypasss_Reference_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();
            _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Attribute_Bypasss_Image_Field = _ISpartan_Attribute_BypassApiConsumer.SelAll(true);
            if (Spartan_Attribute_Bypasss_Image_Field != null && Spartan_Attribute_Bypasss_Image_Field.Resource != null)
                ViewBag.Spartan_Attribute_Bypasss_Image_Field = Spartan_Attribute_Bypasss_Image_Field.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.AttributeId), "Spartan_Attribute_Bypass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.AttributeId)
                }).ToList();


            var previousFiltersObj = new Spartan_Record_Detail_ManagementAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Spartan_Record_Detail_ManagementAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Spartan_Record_Detail_ManagementAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Spartan_Record_Detail_ManagementPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Record_Detail_Managements == null)
                result.Spartan_Record_Detail_Managements = new List<Spartan_Record_Detail_Management>();

            return Json(new
            {
                data = result.Spartan_Record_Detail_Managements.Select(m => new Spartan_Record_Detail_ManagementGridModel
                    {
                    Process_Id = m.Process_Id
                        ,Register_Date = (m.Register_Date == null ? string.Empty : Convert.ToDateTime(m.Register_Date).ToString(ConfigurationProperty.DateFormat))
			,Register_Hour = m.Register_Hour
                        ,Register_UserName = CultureHelper.GetTraduction(m.Register_User_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Register_User_Spartan_User.Name
			,Description = m.Description
                        ,ObjectDescription = CultureHelper.GetTraduction(m.Object_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Spartan_Object_ByPass.Description
			,Reference_Label = m.Reference_Label
                        ,Reference_FieldDescription = CultureHelper.GetTraduction(m.Reference_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Reference_Field_Spartan_Attribute_Bypass.Description
			,Search_Result = m.Search_Result
			,Search_Result_Query = m.Search_Result_Query
                        ,Image_FieldDescription = CultureHelper.GetTraduction(m.Image_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Image_Field_Spartan_Attribute_Bypass.Description
			,Data_Detail = m.Data_Detail
			,Query_Data_Detail = m.Query_Data_Detail

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSpartan_Record_Detail_ManagementAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Record_Detail_ManagementApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Process_Id), "Spartan_Record_Detail_Management", m.),
                     Value = Convert.ToString(m.Process_Id)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Spartan_Record_Detail_Management from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Spartan_Record_Detail_Management Entity</returns>
        public ActionResult GetSpartan_Record_Detail_ManagementList(UrlParametersModel param)
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
            _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Spartan_Record_Detail_ManagementPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Spartan_Record_Detail_ManagementAdvanceSearchModel))
                {
					var advanceFilter =
                    (Spartan_Record_Detail_ManagementAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Spartan_Record_Detail_ManagementPropertyMapper oSpartan_Record_Detail_ManagementPropertyMapper = new Spartan_Record_Detail_ManagementPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSpartan_Record_Detail_ManagementPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Record_Detail_Managements == null)
                result.Spartan_Record_Detail_Managements = new List<Spartan_Record_Detail_Management>();

            return Json(new
            {
                aaData = result.Spartan_Record_Detail_Managements.Select(m => new Spartan_Record_Detail_ManagementGridModel
            {
                    Process_Id = m.Process_Id
                        ,Register_Date = (m.Register_Date == null ? string.Empty : Convert.ToDateTime(m.Register_Date).ToString(ConfigurationProperty.DateFormat))
			,Register_Hour = m.Register_Hour
                        ,Register_UserName = CultureHelper.GetTraduction(m.Register_User_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Register_User_Spartan_User.Name
			,Description = m.Description
                        ,ObjectDescription = CultureHelper.GetTraduction(m.Object_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Spartan_Object_ByPass.Description
			,Reference_Label = m.Reference_Label
                        ,Reference_FieldDescription = CultureHelper.GetTraduction(m.Reference_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Reference_Field_Spartan_Attribute_Bypass.Description
			,Search_Result = m.Search_Result
			,Search_Result_Query = m.Search_Result_Query
                        ,Image_FieldDescription = CultureHelper.GetTraduction(m.Image_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Image_Field_Spartan_Attribute_Bypass.Description
			,Data_Detail = m.Data_Detail
			,Query_Data_Detail = m.Query_Data_Detail

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Spartan_Record_Detail_ManagementAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromProcess_Id) || !string.IsNullOrEmpty(filter.ToProcess_Id))
            {
                if (!string.IsNullOrEmpty(filter.FromProcess_Id))
                    where += " AND Spartan_Record_Detail_Management.Process_Id >= " + filter.FromProcess_Id;
                if (!string.IsNullOrEmpty(filter.ToProcess_Id))
                    where += " AND Spartan_Record_Detail_Management.Process_Id <= " + filter.ToProcess_Id;
            }

            if (!string.IsNullOrEmpty(filter.FromRegister_Date) || !string.IsNullOrEmpty(filter.ToRegister_Date))
            {
                var Register_DateFrom = DateTime.ParseExact(filter.FromRegister_Date, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Register_DateTo = DateTime.ParseExact(filter.ToRegister_Date, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromRegister_Date))
                    where += " AND Spartan_Record_Detail_Management.Register_Date >= '" + Register_DateFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToRegister_Date))
                    where += " AND Spartan_Record_Detail_Management.Register_Date <= '" + Register_DateTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromRegister_Hour) || !string.IsNullOrEmpty(filter.ToRegister_Hour))
            {
                if (!string.IsNullOrEmpty(filter.FromRegister_Hour))
                    where += " AND Convert(TIME,Spartan_Record_Detail_Management.Register_Hour) >='" + filter.FromRegister_Hour + "'";
                if (!string.IsNullOrEmpty(filter.ToRegister_Hour))
                    where += " AND Convert(TIME,Spartan_Record_Detail_Management.Register_Hour) <='" + filter.ToRegister_Hour + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRegister_User))
            {
                switch (filter.Register_UserFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceRegister_User + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceRegister_User + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceRegister_User + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceRegister_User + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRegister_UserMultiple != null && filter.AdvanceRegister_UserMultiple.Count() > 0)
            {
                var Register_UserIds = string.Join(",", filter.AdvanceRegister_UserMultiple);

                where += " AND Spartan_Record_Detail_Management.Register_User In (" + Register_UserIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Description))
            {
                switch (filter.DescriptionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Record_Detail_Management.Description LIKE '" + filter.Description + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Record_Detail_Management.Description LIKE '%" + filter.Description + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Record_Detail_Management.Description = '" + filter.Description + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Record_Detail_Management.Description LIKE '%" + filter.Description + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceObject))
            {
                switch (filter.ObjectFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Object_ByPass.Description LIKE '" + filter.AdvanceObject + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Object_ByPass.Description LIKE '%" + filter.AdvanceObject + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Object_ByPass.Description = '" + filter.AdvanceObject + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Object_ByPass.Description LIKE '%" + filter.AdvanceObject + "%'";
                        break;
                }
            }
            else if (filter.AdvanceObjectMultiple != null && filter.AdvanceObjectMultiple.Count() > 0)
            {
                var ObjectIds = string.Join(",", filter.AdvanceObjectMultiple);

                where += " AND Spartan_Record_Detail_Management.Object In (" + ObjectIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Reference_Label))
            {
                switch (filter.Reference_LabelFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Record_Detail_Management.Reference_Label LIKE '" + filter.Reference_Label + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Record_Detail_Management.Reference_Label LIKE '%" + filter.Reference_Label + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Record_Detail_Management.Reference_Label = '" + filter.Reference_Label + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Record_Detail_Management.Reference_Label LIKE '%" + filter.Reference_Label + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceReference_Field))
            {
                switch (filter.Reference_FieldFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '" + filter.AdvanceReference_Field + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.AdvanceReference_Field + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Attribute_Bypass.Description = '" + filter.AdvanceReference_Field + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.AdvanceReference_Field + "%'";
                        break;
                }
            }
            else if (filter.AdvanceReference_FieldMultiple != null && filter.AdvanceReference_FieldMultiple.Count() > 0)
            {
                var Reference_FieldIds = string.Join(",", filter.AdvanceReference_FieldMultiple);

                where += " AND Spartan_Record_Detail_Management.Reference_Field In (" + Reference_FieldIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromSearch_Result) || !string.IsNullOrEmpty(filter.ToSearch_Result))
            {
                if (!string.IsNullOrEmpty(filter.FromSearch_Result))
                    where += " AND Spartan_Record_Detail_Management.Search_Result >= " + filter.FromSearch_Result;
                if (!string.IsNullOrEmpty(filter.ToSearch_Result))
                    where += " AND Spartan_Record_Detail_Management.Search_Result <= " + filter.ToSearch_Result;
            }

            if (!string.IsNullOrEmpty(filter.Search_Result_Query))
            {
                switch (filter.Search_Result_QueryFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Record_Detail_Management.Search_Result_Query LIKE '" + filter.Search_Result_Query + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Record_Detail_Management.Search_Result_Query LIKE '%" + filter.Search_Result_Query + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Record_Detail_Management.Search_Result_Query = '" + filter.Search_Result_Query + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Record_Detail_Management.Search_Result_Query LIKE '%" + filter.Search_Result_Query + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceImage_Field))
            {
                switch (filter.Image_FieldFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '" + filter.AdvanceImage_Field + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.AdvanceImage_Field + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Attribute_Bypass.Description = '" + filter.AdvanceImage_Field + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Attribute_Bypass.Description LIKE '%" + filter.AdvanceImage_Field + "%'";
                        break;
                }
            }
            else if (filter.AdvanceImage_FieldMultiple != null && filter.AdvanceImage_FieldMultiple.Count() > 0)
            {
                var Image_FieldIds = string.Join(",", filter.AdvanceImage_FieldMultiple);

                where += " AND Spartan_Record_Detail_Management.Image_Field In (" + Image_FieldIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromData_Detail) || !string.IsNullOrEmpty(filter.ToData_Detail))
            {
                if (!string.IsNullOrEmpty(filter.FromData_Detail))
                    where += " AND Spartan_Record_Detail_Management.Data_Detail >= " + filter.FromData_Detail;
                if (!string.IsNullOrEmpty(filter.ToData_Detail))
                    where += " AND Spartan_Record_Detail_Management.Data_Detail <= " + filter.ToData_Detail;
            }

            if (!string.IsNullOrEmpty(filter.Query_Data_Detail))
            {
                switch (filter.Query_Data_DetailFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_Record_Detail_Management.Query_Data_Detail LIKE '" + filter.Query_Data_Detail + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_Record_Detail_Management.Query_Data_Detail LIKE '%" + filter.Query_Data_Detail + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_Record_Detail_Management.Query_Data_Detail = '" + filter.Query_Data_Detail + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_Record_Detail_Management.Query_Data_Detail LIKE '%" + filter.Query_Data_Detail + "%'";
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

        public ActionResult GetSpartan_RDM_Filters_Detail(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Spartan_RDM_Filters_DetailGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartan_RDM_Filters_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Spartan_RDM_Filters_Detail.Record_Detail_Management=" + RelationId;
            if("int" == "string")
            {
	           where = "Spartan_RDM_Filters_Detail.Record_Detail_Management='" + RelationId + "'";
            }
            var result = _ISpartan_RDM_Filters_DetailApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Spartan_RDM_Filters_Details == null)
                result.Spartan_RDM_Filters_Details = new List<Spartan_RDM_Filters_Detail>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Spartan_RDM_Filters_Details.Select(m => new Spartan_RDM_Filters_DetailGridModel
                {
                    Filters_Detail_Id = m.Filters_Detail_Id

                        ,Field_Name = m.Field_Name
                        ,Field_NameDescription = CultureHelper.GetTraduction(m.Field_Name_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ??(string)m.Field_Name_Spartan_Attribute_Bypass.Description
			,Field_Label = m.Field_Label
			,Order_Shown = m.Order_Shown
			,Field_Path = m.Field_Path
			,Physical_Field_Name = m.Physical_Field_Name
			,Logical_Field_Name = m.Logical_Field_Name

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Spartan_RDM_Filters_DetailGridModel> GetSpartan_RDM_Filters_DetailData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Spartan_RDM_Filters_DetailGridModel> resultData = new List<Spartan_RDM_Filters_DetailGridModel>();
            string where = "Spartan_RDM_Filters_Detail.Record_Detail_Management=" + Id;
            if("int" == "string")
            {
                where = "Spartan_RDM_Filters_Detail.Record_Detail_Management='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartan_RDM_Filters_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ISpartan_RDM_Filters_DetailApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Spartan_RDM_Filters_Details != null)
            {
                resultData = result.Spartan_RDM_Filters_Details.Select(m => new Spartan_RDM_Filters_DetailGridModel
                    {
                        Filters_Detail_Id = m.Filters_Detail_Id

                        ,Field_Name = m.Field_Name
                        ,Field_NameDescription = CultureHelper.GetTraduction(m.Field_Name_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ??(string)m.Field_Name_Spartan_Attribute_Bypass.Description
			,Field_Label = m.Field_Label
			,Order_Shown = m.Order_Shown
			,Field_Path = m.Field_Path
			,Physical_Field_Name = m.Physical_Field_Name
			,Logical_Field_Name = m.Logical_Field_Name


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetSpartan_RDM_Operations_Detail(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Spartan_RDM_Operations_DetailGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Spartan_RDM_Operations_Detail.Record_Detail_Management=" + RelationId;
            if("int" == "string")
            {
	           where = "Spartan_RDM_Operations_Detail.Record_Detail_Management='" + RelationId + "'";
            }
            var result = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Spartan_RDM_Operations_Details == null)
                result.Spartan_RDM_Operations_Details = new List<Spartan_RDM_Operations_Detail>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Spartan_RDM_Operations_Details.Select(m => new Spartan_RDM_Operations_DetailGridModel
                {
                    DetailId = m.DetailId

                        ,Object_Name = m.Object_Name
                        ,Object_NameDescription = CultureHelper.GetTraduction(m.Object_Name_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ??(string)m.Object_Name_Spartan_Object_ByPass.Description
			,Object_Label = m.Object_Label
			,Order_Shown = m.Order_Shown
			,Count_Query = m.Count_Query
			,Query_Data = m.Query_Data
			,IconoFileInfo = m.Icono > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Icono).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Spartan_RDM_Operations_DetailGridModel> GetSpartan_RDM_Operations_DetailData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Spartan_RDM_Operations_DetailGridModel> resultData = new List<Spartan_RDM_Operations_DetailGridModel>();
            string where = "Spartan_RDM_Operations_Detail.Record_Detail_Management=" + Id;
            if("int" == "string")
            {
                where = "Spartan_RDM_Operations_Detail.Record_Detail_Management='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Spartan_RDM_Operations_Details != null)
            {
                resultData = result.Spartan_RDM_Operations_Details.Select(m => new Spartan_RDM_Operations_DetailGridModel
                    {
                        DetailId = m.DetailId

                        ,Object_Name = m.Object_Name
                        ,Object_NameDescription = CultureHelper.GetTraduction(m.Object_Name_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ??(string)m.Object_Name_Spartan_Object_ByPass.Description
			,Object_Label = m.Object_Label
			,Order_Shown = m.Order_Shown
			,Count_Query = m.Count_Query
			,Query_Data = m.Query_Data
			,IconoFileInfo = m.Icono > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Icono).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


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
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);

                Spartan_Record_Detail_Management varSpartan_Record_Detail_Management = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _ISpartan_RDM_Filters_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Spartan_RDM_Filters_Detail.Record_Detail_Management=" + id;
                    if("int" == "string")
                    {
	                where = "Spartan_RDM_Filters_Detail.Record_Detail_Management='" + id + "'";
                    }
                    var Spartan_RDM_Filters_DetailInfo =
                        _ISpartan_RDM_Filters_DetailApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Spartan_RDM_Filters_DetailInfo.Spartan_RDM_Filters_Details.Count > 0)
                    {
                        var resultSpartan_RDM_Filters_Detail = true;
                        //Removing associated job history with attachment
                        foreach (var Spartan_RDM_Filters_DetailItem in Spartan_RDM_Filters_DetailInfo.Spartan_RDM_Filters_Details)
                            resultSpartan_RDM_Filters_Detail = resultSpartan_RDM_Filters_Detail
                                              && _ISpartan_RDM_Filters_DetailApiConsumer.Delete(Spartan_RDM_Filters_DetailItem.Filters_Detail_Id, null,null).Resource;

                        if (!resultSpartan_RDM_Filters_Detail)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Spartan_RDM_Operations_Detail.Record_Detail_Management=" + id;
                    if("int" == "string")
                    {
	                where = "Spartan_RDM_Operations_Detail.Record_Detail_Management='" + id + "'";
                    }
                    var Spartan_RDM_Operations_DetailInfo =
                        _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Spartan_RDM_Operations_DetailInfo.Spartan_RDM_Operations_Details.Count > 0)
                    {
                        var resultSpartan_RDM_Operations_Detail = true;
                        //Removing associated job history with attachment
                        foreach (var Spartan_RDM_Operations_DetailItem in Spartan_RDM_Operations_DetailInfo.Spartan_RDM_Operations_Details)
                            resultSpartan_RDM_Operations_Detail = resultSpartan_RDM_Operations_Detail
                                              && _ISpartan_RDM_Operations_DetailApiConsumer.Delete(Spartan_RDM_Operations_DetailItem.DetailId, null,null).Resource;

                        if (!resultSpartan_RDM_Operations_Detail)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ISpartan_Record_Detail_ManagementApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Spartan_Record_Detail_ManagementModel varSpartan_Record_Detail_Management)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Spartan_Record_Detail_ManagementInfo = new Spartan_Record_Detail_Management
                    {
                        Process_Id = varSpartan_Record_Detail_Management.Process_Id
                        ,Register_Date = (!String.IsNullOrEmpty(varSpartan_Record_Detail_Management.Register_Date)) ? DateTime.ParseExact(varSpartan_Record_Detail_Management.Register_Date, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Register_Hour = varSpartan_Record_Detail_Management.Register_Hour
                        ,Register_User = varSpartan_Record_Detail_Management.Register_User
                        ,Description = varSpartan_Record_Detail_Management.Description
                        ,Object = varSpartan_Record_Detail_Management.Object
                        ,Reference_Label = varSpartan_Record_Detail_Management.Reference_Label
                        ,Reference_Field = varSpartan_Record_Detail_Management.Reference_Field
                        ,Search_Result = varSpartan_Record_Detail_Management.Search_Result
                        ,Search_Result_Query = varSpartan_Record_Detail_Management.Search_Result_Query
                        ,Image_Field = varSpartan_Record_Detail_Management.Image_Field
                        ,Data_Detail = varSpartan_Record_Detail_Management.Data_Detail
                        ,Query_Data_Detail = varSpartan_Record_Detail_Management.Query_Data_Detail

                    };

                    result = !IsNew ?
                        _ISpartan_Record_Detail_ManagementApiConsumer.Update(Spartan_Record_Detail_ManagementInfo, null, null).Resource.ToString() :
                         _ISpartan_Record_Detail_ManagementApiConsumer.Insert(Spartan_Record_Detail_ManagementInfo, null, null).Resource.ToString();
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
        public bool CopySpartan_RDM_Filters_Detail(int MasterId, int referenceId, List<Spartan_RDM_Filters_DetailGridModelPost> Spartan_RDM_Filters_DetailItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ISpartan_RDM_Filters_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Spartan_RDM_Filters_DetailData = _ISpartan_RDM_Filters_DetailApiConsumer.ListaSelAll(1, int.MaxValue, "Spartan_RDM_Filters_Detail.Record_Detail_Management=" + referenceId,"").Resource;
                if (Spartan_RDM_Filters_DetailData == null || Spartan_RDM_Filters_DetailData.Spartan_RDM_Filters_Details.Count == 0)
                    return true;

                var result = true;

                Spartan_RDM_Filters_DetailGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varSpartan_RDM_Filters_Detail in Spartan_RDM_Filters_DetailData.Spartan_RDM_Filters_Details)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Spartan_RDM_Filters_Detail Spartan_RDM_Filters_Detail1 = varSpartan_RDM_Filters_Detail;

                    if (Spartan_RDM_Filters_DetailItems != null && Spartan_RDM_Filters_DetailItems.Any(m => m.Filters_Detail_Id == Spartan_RDM_Filters_Detail1.Filters_Detail_Id))
                    {
                        modelDataToChange = Spartan_RDM_Filters_DetailItems.FirstOrDefault(m => m.Filters_Detail_Id == Spartan_RDM_Filters_Detail1.Filters_Detail_Id);
                    }
                    //Chaning Id Value
                    varSpartan_RDM_Filters_Detail.Record_Detail_Management = MasterId;
                    var insertId = _ISpartan_RDM_Filters_DetailApiConsumer.Insert(varSpartan_RDM_Filters_Detail,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Filters_Detail_Id = insertId;

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
        public ActionResult PostSpartan_RDM_Filters_Detail(List<Spartan_RDM_Filters_DetailGridModelPost> Spartan_RDM_Filters_DetailItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopySpartan_RDM_Filters_Detail(MasterId, referenceId, Spartan_RDM_Filters_DetailItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Spartan_RDM_Filters_DetailItems != null && Spartan_RDM_Filters_DetailItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ISpartan_RDM_Filters_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Spartan_RDM_Filters_DetailItem in Spartan_RDM_Filters_DetailItems)
                    {








                        //Removal Request
                        if (Spartan_RDM_Filters_DetailItem.Removed)
                        {
                            result = result && _ISpartan_RDM_Filters_DetailApiConsumer.Delete(Spartan_RDM_Filters_DetailItem.Filters_Detail_Id, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Spartan_RDM_Filters_DetailItem.Filters_Detail_Id = 0;

                        var Spartan_RDM_Filters_DetailData = new Spartan_RDM_Filters_Detail
                        {
                            Record_Detail_Management = MasterId
                            ,Filters_Detail_Id = Spartan_RDM_Filters_DetailItem.Filters_Detail_Id
                            ,Field_Name = (Convert.ToInt32(Spartan_RDM_Filters_DetailItem.Field_Name) == 0 ? (Int32?)null : Convert.ToInt32(Spartan_RDM_Filters_DetailItem.Field_Name))
                            ,Field_Label = Spartan_RDM_Filters_DetailItem.Field_Label
                            ,Order_Shown = Spartan_RDM_Filters_DetailItem.Order_Shown
                            ,Field_Path = Spartan_RDM_Filters_DetailItem.Field_Path
                            ,Physical_Field_Name = Spartan_RDM_Filters_DetailItem.Physical_Field_Name
                            ,Logical_Field_Name = Spartan_RDM_Filters_DetailItem.Logical_Field_Name

                        };

                        var resultId = Spartan_RDM_Filters_DetailItem.Filters_Detail_Id > 0
                           ? _ISpartan_RDM_Filters_DetailApiConsumer.Update(Spartan_RDM_Filters_DetailData,null,null).Resource
                           : _ISpartan_RDM_Filters_DetailApiConsumer.Insert(Spartan_RDM_Filters_DetailData,null,null).Resource;

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


        [HttpGet]
        public ActionResult GetSpartan_RDM_Filters_Detail_Spartan_Attribute_BypassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Attribute_BypassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Attribute_BypassApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.AttributeId), "Spartan_Attribute_Bypass", "Description");
                  item.Description= trans??item.Description;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopySpartan_RDM_Operations_Detail(int MasterId, int referenceId, List<Spartan_RDM_Operations_DetailGridModelPost> Spartan_RDM_Operations_DetailItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Spartan_RDM_Operations_DetailData = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(1, int.MaxValue, "Spartan_RDM_Operations_Detail.Record_Detail_Management=" + referenceId,"").Resource;
                if (Spartan_RDM_Operations_DetailData == null || Spartan_RDM_Operations_DetailData.Spartan_RDM_Operations_Details.Count == 0)
                    return true;

                var result = true;

                Spartan_RDM_Operations_DetailGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varSpartan_RDM_Operations_Detail in Spartan_RDM_Operations_DetailData.Spartan_RDM_Operations_Details)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Spartan_RDM_Operations_Detail Spartan_RDM_Operations_Detail1 = varSpartan_RDM_Operations_Detail;

                    if (Spartan_RDM_Operations_DetailItems != null && Spartan_RDM_Operations_DetailItems.Any(m => m.DetailId == Spartan_RDM_Operations_Detail1.DetailId))
                    {
                        modelDataToChange = Spartan_RDM_Operations_DetailItems.FirstOrDefault(m => m.DetailId == Spartan_RDM_Operations_Detail1.DetailId);
                    }
                    //Chaning Id Value
                    varSpartan_RDM_Operations_Detail.Record_Detail_Management = MasterId;
                    var insertId = _ISpartan_RDM_Operations_DetailApiConsumer.Insert(varSpartan_RDM_Operations_Detail,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.DetailId = insertId;

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
        public ActionResult PostSpartan_RDM_Operations_Detail(List<Spartan_RDM_Operations_DetailGridModelPost> Spartan_RDM_Operations_DetailItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopySpartan_RDM_Operations_Detail(MasterId, referenceId, Spartan_RDM_Operations_DetailItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Spartan_RDM_Operations_DetailItems != null && Spartan_RDM_Operations_DetailItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Spartan_RDM_Operations_DetailItem in Spartan_RDM_Operations_DetailItems)
                    {






                        #region IconoInfo
                        //Checking if file exist if yes edit or add
                        if (Spartan_RDM_Operations_DetailItem.IconoInfo.Control != null && !Spartan_RDM_Operations_DetailItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Spartan_RDM_Operations_DetailItem.IconoInfo.Control);
                            Spartan_RDM_Operations_DetailItem.IconoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Spartan_RDM_Operations_DetailItem.IconoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Spartan_RDM_Operations_DetailItem.Removed && Spartan_RDM_Operations_DetailItem.IconoInfo.RemoveFile)
                        {
                            Spartan_RDM_Operations_DetailItem.IconoInfo.FileId = 0;
                        }
                        #endregion IconoInfo

                        //Removal Request
                        if (Spartan_RDM_Operations_DetailItem.Removed)
                        {
                            result = result && _ISpartan_RDM_Operations_DetailApiConsumer.Delete(Spartan_RDM_Operations_DetailItem.DetailId, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Spartan_RDM_Operations_DetailItem.DetailId = 0;

                        var Spartan_RDM_Operations_DetailData = new Spartan_RDM_Operations_Detail
                        {
                            Record_Detail_Management = MasterId
                            ,DetailId = Spartan_RDM_Operations_DetailItem.DetailId
                            ,Object_Name = (Convert.ToInt32(Spartan_RDM_Operations_DetailItem.Object_Name) == 0 ? (Int32?)null : Convert.ToInt32(Spartan_RDM_Operations_DetailItem.Object_Name))
                            ,Object_Label = Spartan_RDM_Operations_DetailItem.Object_Label
                            ,Order_Shown = Spartan_RDM_Operations_DetailItem.Order_Shown
                            ,Count_Query = Spartan_RDM_Operations_DetailItem.Count_Query
                            ,Query_Data = Spartan_RDM_Operations_DetailItem.Query_Data
                            ,Icono = Spartan_RDM_Operations_DetailItem.IconoInfo.FileId

                        };

                        var resultId = Spartan_RDM_Operations_DetailItem.DetailId > 0
                           ? _ISpartan_RDM_Operations_DetailApiConsumer.Update(Spartan_RDM_Operations_DetailData,null,null).Resource
                           : _ISpartan_RDM_Operations_DetailApiConsumer.Insert(Spartan_RDM_Operations_DetailData,null,null).Resource;

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


        [HttpGet]
        public ActionResult GetSpartan_RDM_Operations_Detail_Spartan_Object_ByPassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Object_ByPassApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.ObjectId), "Spartan_Object_ByPass", "Description");
                  item.Description= trans??item.Description;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }








        /// <summary>
        /// Write Element Array of Spartan_Record_Detail_Management script
        /// </summary>
        /// <param name="oSpartan_Record_Detail_ManagementElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Spartan_Record_Detail_ManagementModuleAttributeList)
        {
            for (int i = 0; i < Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSpartan_Record_Detail_ManagementScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_Record_Detail_Management.js")))
            {
                strSpartan_Record_Detail_ManagementScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Spartan_Record_Detail_Management element attributes
            string userChangeJson = jsSerialize.Serialize(Spartan_Record_Detail_ManagementModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSpartan_Record_Detail_ManagementScript.IndexOf("inpuElementArray");
            string splittedString = strSpartan_Record_Detail_ManagementScript.Substring(indexOfArray, strSpartan_Record_Detail_ManagementScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSpartan_Record_Detail_ManagementScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSpartan_Record_Detail_ManagementScript.Substring(indexOfArrayHistory, strSpartan_Record_Detail_ManagementScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSpartan_Record_Detail_ManagementScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSpartan_Record_Detail_ManagementScript.Substring(endIndexOfMainElement + indexOfArray, strSpartan_Record_Detail_ManagementScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Spartan_Record_Detail_ManagementModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Spartan_Record_Detail_Management.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Spartan_Record_Detail_Management.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_Record_Detail_Management.js")))
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
        public ActionResult Spartan_Record_Detail_ManagementPropertyBag()
        {
            return PartialView("Spartan_Record_Detail_ManagementPropertyBag", "Spartan_Record_Detail_Management");
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
        public ActionResult AddSpartan_RDM_Filters_Detail(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Spartan_RDM_Filters_Detail/AddSpartan_RDM_Filters_Detail");
        }

        [HttpGet]
        public ActionResult AddSpartan_RDM_Operations_Detail(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Spartan_RDM_Operations_Detail/AddSpartan_RDM_Operations_Detail");
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
                var whereClauseFormat = "Object = 45361 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Spartan_Record_Detail_Management.Process_Id= " + RecordId;
                            var result = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Spartan_Record_Detail_ManagementPropertyMapper());
			
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
                    (Spartan_Record_Detail_ManagementAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Spartan_Record_Detail_ManagementPropertyMapper oSpartan_Record_Detail_ManagementPropertyMapper = new Spartan_Record_Detail_ManagementPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSpartan_Record_Detail_ManagementPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Record_Detail_Managements == null)
                result.Spartan_Record_Detail_Managements = new List<Spartan_Record_Detail_Management>();

            var data = result.Spartan_Record_Detail_Managements.Select(m => new Spartan_Record_Detail_ManagementGridModel
            {
                Process_Id = m.Process_Id
                        ,Register_Date = (m.Register_Date == null ? string.Empty : Convert.ToDateTime(m.Register_Date).ToString(ConfigurationProperty.DateFormat))
			,Register_Hour = m.Register_Hour
                        ,Register_UserName = CultureHelper.GetTraduction(m.Register_User_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Register_User_Spartan_User.Name
			,Description = m.Description
                        ,ObjectDescription = CultureHelper.GetTraduction(m.Object_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Spartan_Object_ByPass.Description
			,Reference_Label = m.Reference_Label
                        ,Reference_FieldDescription = CultureHelper.GetTraduction(m.Reference_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Reference_Field_Spartan_Attribute_Bypass.Description
			,Search_Result = m.Search_Result
			,Search_Result_Query = m.Search_Result_Query
                        ,Image_FieldDescription = CultureHelper.GetTraduction(m.Image_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Image_Field_Spartan_Attribute_Bypass.Description
			,Data_Detail = m.Data_Detail
			,Query_Data_Detail = m.Query_Data_Detail

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45361, arrayColumnsVisible), "Spartan_Record_Detail_ManagementList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45361, arrayColumnsVisible), "Spartan_Record_Detail_ManagementList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45361, arrayColumnsVisible), "Spartan_Record_Detail_ManagementList_" + DateTime.Now.ToString());
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

            _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Spartan_Record_Detail_ManagementPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Spartan_Record_Detail_ManagementAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Spartan_Record_Detail_ManagementPropertyMapper oSpartan_Record_Detail_ManagementPropertyMapper = new Spartan_Record_Detail_ManagementPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSpartan_Record_Detail_ManagementPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_Record_Detail_ManagementApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_Record_Detail_Managements == null)
                result.Spartan_Record_Detail_Managements = new List<Spartan_Record_Detail_Management>();

            var data = result.Spartan_Record_Detail_Managements.Select(m => new Spartan_Record_Detail_ManagementGridModel
            {
                Process_Id = m.Process_Id
                        ,Register_Date = (m.Register_Date == null ? string.Empty : Convert.ToDateTime(m.Register_Date).ToString(ConfigurationProperty.DateFormat))
			,Register_Hour = m.Register_Hour
                        ,Register_UserName = CultureHelper.GetTraduction(m.Register_User_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Register_User_Spartan_User.Name
			,Description = m.Description
                        ,ObjectDescription = CultureHelper.GetTraduction(m.Object_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Spartan_Object_ByPass.Description
			,Reference_Label = m.Reference_Label
                        ,Reference_FieldDescription = CultureHelper.GetTraduction(m.Reference_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Reference_Field_Spartan_Attribute_Bypass.Description
			,Search_Result = m.Search_Result
			,Search_Result_Query = m.Search_Result_Query
                        ,Image_FieldDescription = CultureHelper.GetTraduction(m.Image_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Image_Field_Spartan_Attribute_Bypass.Description
			,Data_Detail = m.Data_Detail
			,Query_Data_Detail = m.Query_Data_Detail

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
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Record_Detail_ManagementApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Spartan_Record_Detail_Management_Datos_GeneralesModel varSpartan_Record_Detail_Management)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Spartan_Record_Detail_Management_Datos_GeneralesInfo = new Spartan_Record_Detail_Management_Datos_Generales
                {
                    Process_Id = varSpartan_Record_Detail_Management.Process_Id
                                            ,Register_Date = (!String.IsNullOrEmpty(varSpartan_Record_Detail_Management.Register_Date)) ? DateTime.ParseExact(varSpartan_Record_Detail_Management.Register_Date, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Register_Hour = varSpartan_Record_Detail_Management.Register_Hour
                        ,Register_User = varSpartan_Record_Detail_Management.Register_User
                        ,Description = varSpartan_Record_Detail_Management.Description
                        ,Object = varSpartan_Record_Detail_Management.Object
                        ,Reference_Label = varSpartan_Record_Detail_Management.Reference_Label
                        ,Reference_Field = varSpartan_Record_Detail_Management.Reference_Field
                    
                };

                result = _ISpartan_Record_Detail_ManagementApiConsumer.Update_Datos_Generales(Spartan_Record_Detail_Management_Datos_GeneralesInfo).Resource.ToString();
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
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISpartan_Record_Detail_ManagementApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Spartan_RDM_Filters_Detail;
                var Spartan_RDM_Filters_DetailData = GetSpartan_RDM_Filters_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Filters_Detail);
                int RowCount_Spartan_RDM_Operations_Detail;
                var Spartan_RDM_Operations_DetailData = GetSpartan_RDM_Operations_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Operations_Detail);

                var result = new Spartan_Record_Detail_Management_Datos_GeneralesModel
                {
                    Process_Id = m.Process_Id
                        ,Register_Date = (m.Register_Date == null ? string.Empty : Convert.ToDateTime(m.Register_Date).ToString(ConfigurationProperty.DateFormat))
			,Register_Hour = m.Register_Hour
                        ,Register_User = m.Register_User
                        ,Register_UserName = CultureHelper.GetTraduction(m.Register_User_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Register_User_Spartan_User.Name
			,Description = m.Description
                        ,Object = m.Object
                        ,ObjectDescription = CultureHelper.GetTraduction(m.Object_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Spartan_Object_ByPass.Description
			,Reference_Label = m.Reference_Label
                        ,Reference_Field = m.Reference_Field
                        ,Reference_FieldDescription = CultureHelper.GetTraduction(m.Reference_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Reference_Field_Spartan_Attribute_Bypass.Description

                    
                };
				var resultData = new
                {
                    data = result
                    ,Filters = Spartan_RDM_Filters_DetailData
                    ,Detail = Spartan_RDM_Operations_DetailData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Busqueda(Spartan_Record_Detail_Management_BusquedaModel varSpartan_Record_Detail_Management)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Spartan_Record_Detail_Management_BusquedaInfo = new Spartan_Record_Detail_Management_Busqueda
                {
                    Process_Id = varSpartan_Record_Detail_Management.Process_Id
                                            ,Search_Result = varSpartan_Record_Detail_Management.Search_Result
                        ,Search_Result_Query = varSpartan_Record_Detail_Management.Search_Result_Query
                    
                };

                result = _ISpartan_Record_Detail_ManagementApiConsumer.Update_Busqueda(Spartan_Record_Detail_Management_BusquedaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Busqueda(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISpartan_Record_Detail_ManagementApiConsumer.Get_Busqueda(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Spartan_RDM_Filters_Detail;
                var Spartan_RDM_Filters_DetailData = GetSpartan_RDM_Filters_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Filters_Detail);
                int RowCount_Spartan_RDM_Operations_Detail;
                var Spartan_RDM_Operations_DetailData = GetSpartan_RDM_Operations_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Operations_Detail);

                var result = new Spartan_Record_Detail_Management_BusquedaModel
                {
                    Process_Id = m.Process_Id
			,Search_Result = m.Search_Result
			,Search_Result_Query = m.Search_Result_Query

                    
                };
				var resultData = new
                {
                    data = result
                    ,Filters = Spartan_RDM_Filters_DetailData
                    ,Detail = Spartan_RDM_Operations_DetailData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Informacion_General(Spartan_Record_Detail_Management_Informacion_GeneralModel varSpartan_Record_Detail_Management)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Spartan_Record_Detail_Management_Informacion_GeneralInfo = new Spartan_Record_Detail_Management_Informacion_General
                {
                    Process_Id = varSpartan_Record_Detail_Management.Process_Id
                                            ,Image_Field = varSpartan_Record_Detail_Management.Image_Field
                        ,Data_Detail = varSpartan_Record_Detail_Management.Data_Detail
                        ,Query_Data_Detail = varSpartan_Record_Detail_Management.Query_Data_Detail
                    
                };

                result = _ISpartan_Record_Detail_ManagementApiConsumer.Update_Informacion_General(Spartan_Record_Detail_Management_Informacion_GeneralInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Informacion_General(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISpartan_Record_Detail_ManagementApiConsumer.Get_Informacion_General(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Spartan_RDM_Filters_Detail;
                var Spartan_RDM_Filters_DetailData = GetSpartan_RDM_Filters_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Filters_Detail);
                int RowCount_Spartan_RDM_Operations_Detail;
                var Spartan_RDM_Operations_DetailData = GetSpartan_RDM_Operations_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Operations_Detail);

                var result = new Spartan_Record_Detail_Management_Informacion_GeneralModel
                {
                    Process_Id = m.Process_Id
                        ,Image_Field = m.Image_Field
                        ,Image_FieldDescription = CultureHelper.GetTraduction(m.Image_Field_Spartan_Attribute_Bypass.AttributeId.ToString(), "Description") ?? (string)m.Image_Field_Spartan_Attribute_Bypass.Description
			,Data_Detail = m.Data_Detail
			,Query_Data_Detail = m.Query_Data_Detail

                    
                };
				var resultData = new
                {
                    data = result
                    ,Filters = Spartan_RDM_Filters_DetailData
                    ,Detail = Spartan_RDM_Operations_DetailData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Operaciones(Spartan_Record_Detail_Management_OperacionesModel varSpartan_Record_Detail_Management)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Spartan_Record_Detail_Management_OperacionesInfo = new Spartan_Record_Detail_Management_Operaciones
                {
                    Process_Id = varSpartan_Record_Detail_Management.Process_Id
                                        
                };

                result = _ISpartan_Record_Detail_ManagementApiConsumer.Update_Operaciones(Spartan_Record_Detail_Management_OperacionesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Operaciones(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Record_Detail_ManagementApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISpartan_Record_Detail_ManagementApiConsumer.Get_Operaciones(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Spartan_RDM_Filters_Detail;
                var Spartan_RDM_Filters_DetailData = GetSpartan_RDM_Filters_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Filters_Detail);
                int RowCount_Spartan_RDM_Operations_Detail;
                var Spartan_RDM_Operations_DetailData = GetSpartan_RDM_Operations_DetailData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Spartan_RDM_Operations_Detail);

                var result = new Spartan_Record_Detail_Management_OperacionesModel
                {
                    Process_Id = m.Process_Id

                    
                };
				var resultData = new
                {
                    data = result
                    ,Filters = Spartan_RDM_Filters_DetailData
                    ,Detail = Spartan_RDM_Operations_DetailData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

