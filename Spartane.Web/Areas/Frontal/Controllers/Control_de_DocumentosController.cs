using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Control_de_Documentos;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Detalle_Historial_Control_de_Documentos;



using Spartane.Core.Domain.Spartan_User;




using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Control_de_Documentos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Historial_Control_de_Documentos;



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
using System.Data;
using Spartane.Web.Areas.WebApiConsumer.SpartaneQuery;

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Control_de_DocumentosController : Controller
    {
        #region "variable declaration"

        private IControl_de_DocumentosService service = null;
        private IControl_de_DocumentosApiConsumer _IControl_de_DocumentosApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;
        private IDetalle_Historial_Control_de_DocumentosApiConsumer _IDetalle_Historial_Control_de_DocumentosApiConsumer;

        private ISpartaneQueryApiConsumer _ISpartaneQueryApiConsumer = null;



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


        public Control_de_DocumentosController(IControl_de_DocumentosService service, ITokenManager tokenManager, ISpartaneQueryApiConsumer SpartaneQueryApiConsumer, IAuthenticationApiConsumer authenticationApiConsumer, IControl_de_DocumentosApiConsumer Control_de_DocumentosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer, ISpartan_UserApiConsumer Spartan_UserApiConsumer, IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer, IDetalle_Historial_Control_de_DocumentosApiConsumer Detalle_Historial_Control_de_DocumentosApiConsumer)
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IControl_de_DocumentosApiConsumer = Control_de_DocumentosApiConsumer;
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
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;
            this._IDetalle_Historial_Control_de_DocumentosApiConsumer = Detalle_Historial_Control_de_DocumentosApiConsumer;
            this._ISpartaneQueryApiConsumer = SpartaneQueryApiConsumer;


            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Control_de_Documentos
        [ObjectAuth(ObjectId = (ModuleObjectId)45353, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index(int ModuleId = 0)
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45353, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;

            return View();
        }

        // GET: Frontal/Control_de_Documentos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45353, PermissionType = PermissionTypes.New,
          OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0, int consult = 0, int ModuleId = 0, string guid = null, string isCallFromCatalogoPopupTest = "FALSE")

        {
            string he = "";
            string body = "";
            string foo = "";
            if (guid != null)
            {
                var table = JsonConvert.DeserializeObject<DataTable>(_ISpartaneQueryApiConsumer.ExecuteRawQuery(string.Format("exec us_GetHtmlElementsTemp '{0}'", guid)).Resource);
                he = table.Rows[0]["Header"].ToString();
                body = table.Rows[0]["body"].ToString();
                foo = table.Rows[0]["footer"].ToString();

                he = he.Replace(' ', '+');
                body = body.Replace(' ', '+');
                foo = foo.Replace(' ', '+');

                //
              //  var elimina = _ISpartaneQueryApiConsumer.ExecuteRawQuery(string.Format("delete from  HtmlElementsTemp where guid =  '{0}'", guid)).Resource;

            }
            if (ModuleId == 0)
            {
                ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            }
            else
                Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45353, ModuleId);
            if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varControl_de_Documentos = new Control_de_DocumentosModel();
            varControl_de_Documentos.Folio = Id;

            ViewBag.ObjectId = "45353";
            ViewBag.Operation = "New";

            ViewBag.IsNew = true;

            var permissionDetalle_Historial_Control_de_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45354, ModuleId);
            ViewBag.PermissionDetalle_Historial_Control_de_Documentos = permissionDetalle_Historial_Control_de_Documentos;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {
                ViewBag.IsNew = false;
                ViewBag.Operation = "Update";

                _tokenManager.GenerateToken();
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Control_de_DocumentossData = _IControl_de_DocumentosApiConsumer.ListaSelAll(0, 1000, "Control_de_Documentos.Folio=" + Id, "").Resource.Control_de_Documentoss;

                if (Control_de_DocumentossData != null && Control_de_DocumentossData.Count > 0)
                {
                    var Control_de_DocumentosData = Control_de_DocumentossData.First();
                    varControl_de_Documentos = new Control_de_DocumentosModel
                    {
                        Folio = Control_de_DocumentosData.Folio
                        ,
                        Fecha_de_Registro = (Control_de_DocumentosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Control_de_DocumentosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,
                        Hora_de_Registro = Control_de_DocumentosData.Hora_de_Registro
                    ,
                        Usuario_que_Registra = Control_de_DocumentosData.Usuario_que_Registra
                    ,
                        Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Control_de_DocumentosData.Usuario_que_Registra), "Spartan_User") ?? (string)Control_de_DocumentosData.Usuario_que_Registra_Spartan_User.Name
                    ,
                        idFormato = Control_de_DocumentosData.idFormato
                    ,
                        LlaveRegistro = Control_de_DocumentosData.LlaveRegistro
                    ,
                        TablaPersona = Control_de_DocumentosData.TablaPersona
                    ,
                        LlaveRegistroPersona = Control_de_DocumentosData.LlaveRegistroPersona
                    ,
                        Proceso = Control_de_DocumentosData.Proceso
                    ,
                        ProcesoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Control_de_DocumentosData.Proceso), "Origen_de_Invitacion") ?? (string)Control_de_DocumentosData.Proceso_Origen_de_Invitacion.Descripcion
                    ,
                        Numero_de_Expediente = Control_de_DocumentosData.Numero_de_Expediente
                    ,
                        Cuerpo_del_Documento = Control_de_DocumentosData.Cuerpo_del_Documento
                    ,
                        Archivo = Control_de_DocumentosData.Archivo
                    ,
                        Encabezado = Control_de_DocumentosData.Encabezado
                    ,
                        Pie_de_Pagina = Control_de_DocumentosData.Pie_de_Pagina

                    };
                }

                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varControl_de_Documentos.Archivo).Resource;


            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(),
                    Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Proceso = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Proceso != null && Origen_de_Invitacions_Proceso.Resource != null)
                ViewBag.Origen_de_Invitacions_Proceso = Origen_de_Invitacions_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(),
                    Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
            if (consult == 1)
                ViewBag.Operation = "Consult";

            var viewInEframe = false;
            var isPartial = false;
            var isMR = false;
            var nameMR = string.Empty;
            var nameAttribute = string.Empty;

            if (Request.QueryString["isPartial"] != null)
                isPartial = Convert.ToBoolean(Request.QueryString["isPartial"]);

            if (Request.QueryString["isMR"] != null)
                isMR = Convert.ToBoolean(Request.QueryString["isMR"]);

            if (Request.QueryString["nameMR"] != null)
                nameMR = Request.QueryString["nameMR"].ToString();

            if (Request.QueryString["nameAttribute"] != null)
                nameAttribute = Request.QueryString["nameAttribute"].ToString();

            if (Request.QueryString["viewInEframe"] != null)
                viewInEframe = Convert.ToBoolean(Request.QueryString["viewInEframe"]);

            ViewBag.isPartial = isPartial;
            ViewBag.isMR = isMR;
            ViewBag.nameMR = nameMR;
            ViewBag.nameAttribute = nameAttribute;
            ViewBag.viewInEframe = viewInEframe;


            ViewBag.header = string.IsNullOrEmpty(he) ? varControl_de_Documentos.Encabezado : he;
            ViewBag.body = string.IsNullOrEmpty(body) ? varControl_de_Documentos.Cuerpo_del_Documento : body; ;
            ViewBag.footer = string.IsNullOrEmpty(foo) ? varControl_de_Documentos.Pie_de_Pagina : foo;

            if (string.IsNullOrEmpty(ViewBag.header) || ViewBag.header  == "undefined")
            {
                ViewBag.header = "";
            }

            if (string.IsNullOrEmpty(ViewBag.body) || ViewBag.body == "undefined")
            {
                ViewBag.body = "";
            }

            if (string.IsNullOrEmpty(ViewBag.footer) || ViewBag.footer == "undefined")
            {
                ViewBag.footer = "";
            }



            ViewBag.isCallFromCatalogoPopupTest = isCallFromCatalogoPopupTest;
            ViewBag.GUID_ = guid;

            return View(varControl_de_Documentos);
        }


        [HttpGet]
        public ActionResult GetHtmlObjects(string guid)
        {
            string he = "";
            string body = "";
            string foo = "";
            if (guid != null)
            {
                var table = JsonConvert.DeserializeObject<DataTable>(_ISpartaneQueryApiConsumer.ExecuteRawQuery(string.Format("exec us_GetHtmlElementsTemp '{0}'", guid)).Resource);
                he = table.Rows[0]["Header"].ToString();
                body = table.Rows[0]["body"].ToString();
                foo = table.Rows[0]["footer"].ToString();

                he = he.Replace(' ', '+');
                body = body.Replace(' ', '+');
                foo  = foo.Replace(' ', '+');

                var base64EncodedBytesHeader = System.Convert.FromBase64String(he);
                 he = System.Text.Encoding.UTF8.GetString(base64EncodedBytesHeader);


                var base64EncodedBytesBody = System.Convert.FromBase64String(body);
                 body = System.Text.Encoding.UTF8.GetString(base64EncodedBytesBody);

                var base64EncodedBytesfooter = System.Convert.FromBase64String(foo);
                foo = System.Text.Encoding.UTF8.GetString(base64EncodedBytesfooter);


            }

            var resultado = new {
                he,
                body,
                foo
            };

            return Json( resultado, JsonRequestBehavior.AllowGet);


        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult EncodingUTF8GetString(List<string> varName)
        {
            string resp = "";
            try
            {
                string text = "";
                
                text = varName[1];
                
                string testEncode = Base64Encode(text);

                string dec1 = Base64Decode(testEncode);
                
                resp = dec1;
            }
            catch (Exception ex)
            {

            }

            var resultado = new
            {
                resp
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);


        }

        public  string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public  string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        [HttpGet]
        public ActionResult AddControl_de_Documentos(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45353);
            ViewBag.Permission = permission;
            if (!_tokenManager.GenerateToken())
                return null;
            _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
            Control_de_DocumentosModel varControl_de_Documentos = new Control_de_DocumentosModel();
            var permissionDetalle_Historial_Control_de_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45354, ModuleId);
            ViewBag.PermissionDetalle_Historial_Control_de_Documentos = permissionDetalle_Historial_Control_de_Documentos;


            if (id.ToString() != "0")
            {
                var Control_de_DocumentossData = _IControl_de_DocumentosApiConsumer.ListaSelAll(0, 1000, "Control_de_Documentos.Folio=" + id, "").Resource.Control_de_Documentoss;

                if (Control_de_DocumentossData != null && Control_de_DocumentossData.Count > 0)
                {
                    var Control_de_DocumentosData = Control_de_DocumentossData.First();
                    varControl_de_Documentos = new Control_de_DocumentosModel
                    {
                        Folio = Control_de_DocumentosData.Folio
                        ,
                        Fecha_de_Registro = (Control_de_DocumentosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Control_de_DocumentosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,
                        Hora_de_Registro = Control_de_DocumentosData.Hora_de_Registro
                    ,
                        Usuario_que_Registra = Control_de_DocumentosData.Usuario_que_Registra
                    ,
                        Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Control_de_DocumentosData.Usuario_que_Registra), "Spartan_User") ?? (string)Control_de_DocumentosData.Usuario_que_Registra_Spartan_User.Name
                    ,
                        idFormato = Control_de_DocumentosData.idFormato
                    ,
                        LlaveRegistro = Control_de_DocumentosData.LlaveRegistro
                    ,
                        TablaPersona = Control_de_DocumentosData.TablaPersona
                    ,
                        LlaveRegistroPersona = Control_de_DocumentosData.LlaveRegistroPersona
                    ,
                        Proceso = Control_de_DocumentosData.Proceso
                    ,
                        ProcesoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Control_de_DocumentosData.Proceso), "Origen_de_Invitacion") ?? (string)Control_de_DocumentosData.Proceso_Origen_de_Invitacion.Descripcion
                    ,
                        Numero_de_Expediente = Control_de_DocumentosData.Numero_de_Expediente
                    ,
                        Cuerpo_del_Documento = Control_de_DocumentosData.Cuerpo_del_Documento
                    ,
                        Archivo = Control_de_DocumentosData.Archivo
                    ,
                        Encabezado = Control_de_DocumentosData.Encabezado
                    ,
                        Pie_de_Pagina = Control_de_DocumentosData.Pie_de_Pagina

                    };
                }
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varControl_de_Documentos.Archivo).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(),
                    Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Proceso = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Proceso != null && Origen_de_Invitacions_Proceso.Resource != null)
                ViewBag.Origen_de_Invitacions_Proceso = Origen_de_Invitacions_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(),
                    Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddControl_de_Documentos", varControl_de_Documentos);
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
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name,
                    Value = Convert.ToString(m.Id_User)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOrigen_de_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrigen_de_InvitacionApiConsumer.SelAll(false).Resource;

                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Control_de_DocumentosAdvanceSearchModel model, int idFilter = -1)
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
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(),
                    Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Proceso = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Proceso != null && Origen_de_Invitacions_Proceso.Resource != null)
                ViewBag.Origen_de_Invitacions_Proceso = Origen_de_Invitacions_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(),
                    Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(),
                    Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Proceso = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Proceso != null && Origen_de_Invitacions_Proceso.Resource != null)
                ViewBag.Origen_de_Invitacions_Proceso = Origen_de_Invitacions_Proceso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(),
                    Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Control_de_DocumentosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Control_de_DocumentosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Control_de_DocumentosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Control_de_DocumentosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IControl_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Documentoss == null)
                result.Control_de_Documentoss = new List<Control_de_Documentos>();

            return Json(new
            {
                data = result.Control_de_Documentoss.Select(m => new Control_de_DocumentosGridModel
                {
                    Folio = m.Folio
                        ,
                    Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
            ,
                    Hora_de_Registro = m.Hora_de_Registro
                        ,
                    Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
            ,
                    idFormato = m.idFormato
            ,
                    LlaveRegistro = m.LlaveRegistro
            ,
                    TablaPersona = m.TablaPersona
            ,
                    LlaveRegistroPersona = m.LlaveRegistroPersona
                        ,
                    ProcesoDescripcion = CultureHelper.GetTraduction(m.Proceso_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_Origen_de_Invitacion.Descripcion
            ,
                    Numero_de_Expediente = m.Numero_de_Expediente
            ,
                    Cuerpo_del_Documento = System.Net.WebUtility.HtmlDecode(m.Cuerpo_del_Documento)
            ,
                    Archivo = m.Archivo
            ,
                    Encabezado = System.Net.WebUtility.HtmlDecode(m.Encabezado)
            ,
                    Pie_de_Pagina = System.Net.WebUtility.HtmlDecode(m.Pie_de_Pagina)

                }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
        /*
		 [HttpGet]
        public ActionResult GetControl_de_DocumentosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IControl_de_DocumentosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Control_de_Documentos", m.),
                     Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Control_de_Documentos from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Control_de_Documentos Entity</returns>
        public ActionResult GetControl_de_DocumentosList(UrlParametersModel param)
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
            _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);


            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Control_de_DocumentosPropertyMapper());

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
                if (Session["AdvanceSearch"].GetType() == typeof(Control_de_DocumentosAdvanceSearchModel))
                {
                    var advanceFilter =
                    (Control_de_DocumentosAdvanceSearchModel)Session["AdvanceSearch"];
                    configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
                }
                else
                {
                    Session.Remove("AdvanceSearch");
                }
            }

            Control_de_DocumentosPropertyMapper oControl_de_DocumentosPropertyMapper = new Control_de_DocumentosPropertyMapper();
            if (String.IsNullOrEmpty(order))
            {
                if (sortColumn != -1)
                    configuration.OrderByClause = oControl_de_DocumentosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IControl_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Documentoss == null)
                result.Control_de_Documentoss = new List<Control_de_Documentos>();

            return Json(new
            {
                aaData = result.Control_de_Documentoss.Select(m => new Control_de_DocumentosGridModel
                {
                    Folio = m.Folio
                        ,
                    Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
            ,
                    Hora_de_Registro = m.Hora_de_Registro
                        ,
                    Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
            ,
                    idFormato = m.idFormato
            ,
                    LlaveRegistro = m.LlaveRegistro
            ,
                    TablaPersona = m.TablaPersona
            ,
                    LlaveRegistroPersona = m.LlaveRegistroPersona
                        ,
                    ProcesoDescripcion = CultureHelper.GetTraduction(m.Proceso_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_Origen_de_Invitacion.Descripcion
            ,
                    Numero_de_Expediente = m.Numero_de_Expediente
            ,
                    Cuerpo_del_Documento = System.Net.WebUtility.HtmlDecode(m.Cuerpo_del_Documento)
            ,
                    Archivo = m.Archivo
            ,
                    Encabezado = System.Net.WebUtility.HtmlDecode(m.Encabezado)
            ,
                    Pie_de_Pagina = System.Net.WebUtility.HtmlDecode(m.Pie_de_Pagina)

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        //Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Control_de_DocumentosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Control_de_Documentos.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Control_de_Documentos.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Control_de_Documentos.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Control_de_Documentos.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Control_de_Documentos.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Control_de_Documentos.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Control_de_Documentos.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromidFormato) || !string.IsNullOrEmpty(filter.ToidFormato))
            {
                if (!string.IsNullOrEmpty(filter.FromidFormato))
                    where += " AND Control_de_Documentos.idFormato >= " + filter.FromidFormato;
                if (!string.IsNullOrEmpty(filter.ToidFormato))
                    where += " AND Control_de_Documentos.idFormato <= " + filter.ToidFormato;
            }

            if (!string.IsNullOrEmpty(filter.FromLlaveRegistro) || !string.IsNullOrEmpty(filter.ToLlaveRegistro))
            {
                if (!string.IsNullOrEmpty(filter.FromLlaveRegistro))
                    where += " AND Control_de_Documentos.LlaveRegistro >= " + filter.FromLlaveRegistro;
                if (!string.IsNullOrEmpty(filter.ToLlaveRegistro))
                    where += " AND Control_de_Documentos.LlaveRegistro <= " + filter.ToLlaveRegistro;
            }

            if (!string.IsNullOrEmpty(filter.TablaPersona))
            {
                switch (filter.TablaPersonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Documentos.TablaPersona LIKE '" + filter.TablaPersona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Documentos.TablaPersona LIKE '%" + filter.TablaPersona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Documentos.TablaPersona = '" + filter.TablaPersona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Documentos.TablaPersona LIKE '%" + filter.TablaPersona + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromLlaveRegistroPersona) || !string.IsNullOrEmpty(filter.ToLlaveRegistroPersona))
            {
                if (!string.IsNullOrEmpty(filter.FromLlaveRegistroPersona))
                    where += " AND Control_de_Documentos.LlaveRegistroPersona >= " + filter.FromLlaveRegistroPersona;
                if (!string.IsNullOrEmpty(filter.ToLlaveRegistroPersona))
                    where += " AND Control_de_Documentos.LlaveRegistroPersona <= " + filter.ToLlaveRegistroPersona;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProceso))
            {
                switch (filter.ProcesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '" + filter.AdvanceProceso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceProceso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Origen_de_Invitacion.Descripcion = '" + filter.AdvanceProceso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceProceso + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProcesoMultiple != null && filter.AdvanceProcesoMultiple.Count() > 0)
            {
                var ProcesoIds = string.Join(",", filter.AdvanceProcesoMultiple);

                where += " AND Control_de_Documentos.Proceso In (" + ProcesoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Expediente))
            {
                switch (filter.Numero_de_ExpedienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Documentos.Numero_de_Expediente LIKE '" + filter.Numero_de_Expediente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Documentos.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Documentos.Numero_de_Expediente = '" + filter.Numero_de_Expediente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Documentos.Numero_de_Expediente LIKE '%" + filter.Numero_de_Expediente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Cuerpo_del_Documento))
            {
                switch (filter.Cuerpo_del_DocumentoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Documentos.Cuerpo_del_Documento LIKE '" + filter.Cuerpo_del_Documento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Documentos.Cuerpo_del_Documento LIKE '%" + filter.Cuerpo_del_Documento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Documentos.Cuerpo_del_Documento = '" + filter.Cuerpo_del_Documento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Documentos.Cuerpo_del_Documento LIKE '%" + filter.Cuerpo_del_Documento + "%'";
                        break;
                }
            }

            if (filter.Archivo != RadioOptions.NoApply)
                where += " AND Control_de_Documentos.Archivo " + (filter.Archivo == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Encabezado))
            {
                switch (filter.EncabezadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Documentos.Encabezado LIKE '" + filter.Encabezado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Documentos.Encabezado LIKE '%" + filter.Encabezado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Documentos.Encabezado = '" + filter.Encabezado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Documentos.Encabezado LIKE '%" + filter.Encabezado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Pie_de_Pagina))
            {
                switch (filter.Pie_de_PaginaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Documentos.Pie_de_Pagina LIKE '" + filter.Pie_de_Pagina + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Documentos.Pie_de_Pagina LIKE '%" + filter.Pie_de_Pagina + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Documentos.Pie_de_Pagina = '" + filter.Pie_de_Pagina + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Documentos.Pie_de_Pagina LIKE '%" + filter.Pie_de_Pagina + "%'";
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

        public ActionResult GetDetalle_Historial_Control_de_Documentos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Historial_Control_de_DocumentosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historial_Control_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos=" + RelationId;
            if ("int" == "string")
            {
                where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos='" + RelationId + "'";
            }
            var result = _IDetalle_Historial_Control_de_DocumentosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            if (result.Detalle_Historial_Control_de_Documentoss == null)
                result.Detalle_Historial_Control_de_Documentoss = new List<Detalle_Historial_Control_de_Documentos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Historial_Control_de_Documentoss.Select(m => new Detalle_Historial_Control_de_DocumentosGridModel
                {
                    Folio = m.Folio

            ,
                    Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
            ,
                    Hora = m.Hora
                        ,
                    Usuario = m.Usuario
                        ,
                    UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
            ,
                    Modificaciones_Realizadas = m.Modificaciones_Realizadas
            ,
                    Cuerpo_del_Documento = m.Cuerpo_del_Documento

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Historial_Control_de_DocumentosGridModel> GetDetalle_Historial_Control_de_DocumentosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Historial_Control_de_DocumentosGridModel> resultData = new List<Detalle_Historial_Control_de_DocumentosGridModel>();
            string where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos=" + Id;
            if ("int" == "string")
            {
                where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Historial_Control_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Historial_Control_de_DocumentosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Historial_Control_de_Documentoss != null)
            {
                resultData = result.Detalle_Historial_Control_de_Documentoss.Select(m => new Detalle_Historial_Control_de_DocumentosGridModel
                {
                    Folio = m.Folio

            ,
                    Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
            ,
                    Hora = m.Hora
                        ,
                    Usuario = m.Usuario
                        ,
                    UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Spartan_User.Name
            ,
                    Modificaciones_Realizadas = m.Modificaciones_Realizadas
            ,
                    Cuerpo_del_Documento = m.Cuerpo_del_Documento


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
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Control_de_Documentos varControl_de_Documentos = null;
                if (id.ToString() != "0")
                {
                    string where = "";
                    _IDetalle_Historial_Control_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos=" + id;
                    if ("int" == "string")
                    {
                        where = "Detalle_Historial_Control_de_Documentos.Control_de_Documentos='" + id + "'";
                    }
                    var Detalle_Historial_Control_de_DocumentosInfo =
                        _IDetalle_Historial_Control_de_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, where, "").Resource;

                    if (Detalle_Historial_Control_de_DocumentosInfo.Detalle_Historial_Control_de_Documentoss.Count > 0)
                    {
                        var resultDetalle_Historial_Control_de_Documentos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Historial_Control_de_DocumentosItem in Detalle_Historial_Control_de_DocumentosInfo.Detalle_Historial_Control_de_Documentoss)
                            resultDetalle_Historial_Control_de_Documentos = resultDetalle_Historial_Control_de_Documentos
                                              && _IDetalle_Historial_Control_de_DocumentosApiConsumer.Delete(Detalle_Historial_Control_de_DocumentosItem.Folio, null, null).Resource;

                        if (!resultDetalle_Historial_Control_de_Documentos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IControl_de_DocumentosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Control_de_DocumentosModel varControl_de_Documentos)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);


                if (varControl_de_Documentos.ArchivoRemoveAttachment != 0 && varControl_de_Documentos.ArchivoFile == null)
                {
                    varControl_de_Documentos.Archivo = 0;
                }

                if (varControl_de_Documentos.ArchivoFile != null)
                {
                    var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varControl_de_Documentos.ArchivoFile);
                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    varControl_de_Documentos.Archivo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                    {
                        File = fileAsBytes,
                        Description = varControl_de_Documentos.ArchivoFile.FileName,
                        File_Size = fileAsBytes.Length
                    }).Resource;
                }


                var result = "";
                var Control_de_DocumentosInfo = new Control_de_Documentos
                {
                    Folio = varControl_de_Documentos.Folio
                    ,
                    Fecha_de_Registro = (!String.IsNullOrEmpty(varControl_de_Documentos.Fecha_de_Registro)) ? DateTime.ParseExact(varControl_de_Documentos.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                    ,
                    Hora_de_Registro = varControl_de_Documentos.Hora_de_Registro
                    ,
                    Usuario_que_Registra = varControl_de_Documentos.Usuario_que_Registra
                    ,
                    idFormato = varControl_de_Documentos.idFormato
                    ,
                    LlaveRegistro = varControl_de_Documentos.LlaveRegistro
                    ,
                    TablaPersona = varControl_de_Documentos.TablaPersona
                    ,
                    LlaveRegistroPersona = varControl_de_Documentos.LlaveRegistroPersona
                    ,
                    Proceso = varControl_de_Documentos.Proceso
                    ,
                    Numero_de_Expediente = varControl_de_Documentos.Numero_de_Expediente
                    ,
                    Cuerpo_del_Documento = varControl_de_Documentos.Cuerpo_del_Documento
                    ,
                    Archivo = (varControl_de_Documentos.Archivo.HasValue && varControl_de_Documentos.Archivo != 0) ? ((int?)Convert.ToInt32(varControl_de_Documentos.Archivo.Value)) : null

                    ,
                    Encabezado = varControl_de_Documentos.Encabezado
                    ,
                    Pie_de_Pagina = varControl_de_Documentos.Pie_de_Pagina

                };

                result = !IsNew ?
                    _IControl_de_DocumentosApiConsumer.Update(Control_de_DocumentosInfo, null, null).Resource.ToString() :
                     _IControl_de_DocumentosApiConsumer.Insert(Control_de_DocumentosInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Historial_Control_de_Documentos(int MasterId, int referenceId, List<Detalle_Historial_Control_de_DocumentosGridModelPost> Detalle_Historial_Control_de_DocumentosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Historial_Control_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Historial_Control_de_DocumentosData = _IDetalle_Historial_Control_de_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Historial_Control_de_Documentos.Control_de_Documentos=" + referenceId, "").Resource;
                if (Detalle_Historial_Control_de_DocumentosData == null || Detalle_Historial_Control_de_DocumentosData.Detalle_Historial_Control_de_Documentoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Historial_Control_de_DocumentosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Historial_Control_de_Documentos in Detalle_Historial_Control_de_DocumentosData.Detalle_Historial_Control_de_Documentoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Historial_Control_de_Documentos Detalle_Historial_Control_de_Documentos1 = varDetalle_Historial_Control_de_Documentos;

                    if (Detalle_Historial_Control_de_DocumentosItems != null && Detalle_Historial_Control_de_DocumentosItems.Any(m => m.Folio == Detalle_Historial_Control_de_Documentos1.Folio))
                    {
                        modelDataToChange = Detalle_Historial_Control_de_DocumentosItems.FirstOrDefault(m => m.Folio == Detalle_Historial_Control_de_Documentos1.Folio);
                    }
                    //Chaning Id Value
                    varDetalle_Historial_Control_de_Documentos.Control_de_Documentos = MasterId;
                    var insertId = _IDetalle_Historial_Control_de_DocumentosApiConsumer.Insert(varDetalle_Historial_Control_de_Documentos, null, null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Folio = insertId;

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
        public ActionResult PostDetalle_Historial_Control_de_Documentos(List<Detalle_Historial_Control_de_DocumentosGridModelPost> Detalle_Historial_Control_de_DocumentosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Historial_Control_de_Documentos(MasterId, referenceId, Detalle_Historial_Control_de_DocumentosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Historial_Control_de_DocumentosItems != null && Detalle_Historial_Control_de_DocumentosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Historial_Control_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Historial_Control_de_DocumentosItem in Detalle_Historial_Control_de_DocumentosItems)
                    {







                        //Removal Request
                        if (Detalle_Historial_Control_de_DocumentosItem.Removed)
                        {
                            result = result && _IDetalle_Historial_Control_de_DocumentosApiConsumer.Delete(Detalle_Historial_Control_de_DocumentosItem.Folio, null, null).Resource;
                            continue;
                        }
                        if (referenceId.ToString() != MasterId.ToString())
                            Detalle_Historial_Control_de_DocumentosItem.Folio = 0;

                        var Detalle_Historial_Control_de_DocumentosData = new Detalle_Historial_Control_de_Documentos
                        {
                            Control_de_Documentos = MasterId
                            ,
                            Folio = Detalle_Historial_Control_de_DocumentosItem.Folio
                            ,
                            Fecha = (Detalle_Historial_Control_de_DocumentosItem.Fecha != null) ? DateTime.ParseExact(Detalle_Historial_Control_de_DocumentosItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,
                            Hora = Detalle_Historial_Control_de_DocumentosItem.Hora
                            ,
                            Usuario = (Convert.ToInt32(Detalle_Historial_Control_de_DocumentosItem.Usuario) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Historial_Control_de_DocumentosItem.Usuario))
                            ,
                            Modificaciones_Realizadas = Detalle_Historial_Control_de_DocumentosItem.Modificaciones_Realizadas
                            ,
                            Cuerpo_del_Documento = Detalle_Historial_Control_de_DocumentosItem.Cuerpo_del_Documento

                        };

                        var resultId = Detalle_Historial_Control_de_DocumentosItem.Folio > 0
                           ? _IDetalle_Historial_Control_de_DocumentosApiConsumer.Update(Detalle_Historial_Control_de_DocumentosData, null, null).Resource
                           : _IDetalle_Historial_Control_de_DocumentosApiConsumer.Insert(Detalle_Historial_Control_de_DocumentosData, null, null).Resource;

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
        public ActionResult GetDetalle_Historial_Control_de_Documentos_Spartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    var trans = CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name = trans ?? item.Name;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        /// <summary>
        /// Write Element Array of Control_de_Documentos script
        /// </summary>
        /// <param name="oControl_de_DocumentosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Control_de_DocumentosModuleAttributeList)
        {
            for (int i = 0; i < Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
            if (Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null)
            {
                for (int i = 0; i < Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
                {
                    for (int j = 0; j < Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
                    {
                        if (string.IsNullOrEmpty(Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
                        {
                            Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
                        }
                        if (string.IsNullOrEmpty(Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
                        {
                            Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
                        }
                    }
                }
            }
            string strControl_de_DocumentosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Control_de_Documentos.js")))
            {
                strControl_de_DocumentosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Control_de_Documentos element attributes
            string userChangeJson = jsSerialize.Serialize(Control_de_DocumentosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strControl_de_DocumentosScript.IndexOf("inpuElementArray");
            string splittedString = strControl_de_DocumentosScript.Substring(indexOfArray, strControl_de_DocumentosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList);
            int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
            if (Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null)
            {
                indexOfArrayHistory = strControl_de_DocumentosScript.IndexOf("});");
                if (indexOfArrayHistory != -1)
                {
                    splittedStringHistory = strControl_de_DocumentosScript.Substring(indexOfArrayHistory, strControl_de_DocumentosScript.Length - indexOfArrayHistory);
                    indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
                    endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
                }
            }
            string finalResponse = strControl_de_DocumentosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strControl_de_DocumentosScript.Substring(endIndexOfMainElement + indexOfArray, strControl_de_DocumentosScript.Length - (endIndexOfMainElement + indexOfArray));

            var ResponseChild = string.Empty;
            if (Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Control_de_DocumentosModuleAttributeList.ChildModuleAttributeList)
                {
                    if (item != null && item.elements != null && item.elements.Count > 0)
                        ResponseChild += "\r\n  \n\r function set" + item.table + "Validation() { " +
                                        " \r\n var inpuElementChildArray =" + jsSerialize.Serialize(item.elements) + ";" +
                                        "  \r\n setInputEntityAttributes(inpuElementChildArray, \".\", 0);" +
                                        "  \r\n setDynamicRenderElement(); \n\r } ";

                }
            }
            finalResponse = finalResponse.Substring(0, finalResponse.IndexOf("});") + 4) + "\n\r";
            finalResponse += ResponseChild;


            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Control_de_Documentos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Control_de_Documentos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Control_de_Documentos.js")))
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
        public ActionResult Control_de_DocumentosPropertyBag()
        {
            return PartialView("Control_de_DocumentosPropertyBag", "Control_de_Documentos");
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
        public ActionResult AddDetalle_Historial_Control_de_Documentos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Historial_Control_de_Documentos/AddDetalle_Historial_Control_de_Documentos");
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
            else
            {
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
                var whereClauseFormat = "Object = 45353 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Control_de_Documentos.Folio= " + RecordId;
                            var result = _IControl_de_DocumentosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
                            if (result != null && result.Resource != null && result.Resource.RowCount > 0)
                            {
                                formatList.Add(new SelectListItem
                                {
                                    Text = CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                    Value = Convert.ToString(format.FormatId)
                                });
                            }
                        }
                        else
                        {
                            formatList.Add(new SelectListItem
                            {
                                Text = CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
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

            _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Control_de_DocumentosPropertyMapper());

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
                    (Control_de_DocumentosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
            string sortDirection = "asc";

            Control_de_DocumentosPropertyMapper oControl_de_DocumentosPropertyMapper = new Control_de_DocumentosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause = oControl_de_DocumentosPropertyMapper.GetPropertyName(iSortCol) + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IControl_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Documentoss == null)
                result.Control_de_Documentoss = new List<Control_de_Documentos>();

            var data = result.Control_de_Documentoss.Select(m => new Control_de_DocumentosGridModel
            {
                Folio = m.Folio
                        ,
                Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
            ,
                Hora_de_Registro = m.Hora_de_Registro
                        ,
                Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
            ,
                idFormato = m.idFormato
            ,
                LlaveRegistro = m.LlaveRegistro
            ,
                TablaPersona = m.TablaPersona
            ,
                LlaveRegistroPersona = m.LlaveRegistroPersona
                        ,
                ProcesoDescripcion = CultureHelper.GetTraduction(m.Proceso_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_Origen_de_Invitacion.Descripcion
            ,
                Numero_de_Expediente = m.Numero_de_Expediente
            ,
                Cuerpo_del_Documento = System.Net.WebUtility.HtmlDecode(m.Cuerpo_del_Documento)
            ,
                Archivo = m.Archivo
            ,
                Encabezado = System.Net.WebUtility.HtmlDecode(m.Encabezado)
            ,
                Pie_de_Pagina = System.Net.WebUtility.HtmlDecode(m.Pie_de_Pagina)

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45353, arrayColumnsVisible), "Control_de_DocumentosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45353, arrayColumnsVisible), "Control_de_DocumentosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45353, arrayColumnsVisible), "Control_de_DocumentosList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir, string where, string order)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            where = HttpUtility.UrlEncode(where);

            if (!_tokenManager.GenerateToken())
                return null;

            _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Control_de_DocumentosPropertyMapper());


            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Control_de_DocumentosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Control_de_DocumentosPropertyMapper oControl_de_DocumentosPropertyMapper = new Control_de_DocumentosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause = oControl_de_DocumentosPropertyMapper.GetPropertyName(iSortCol) + " " + sortDirection;

            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IControl_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Control_de_Documentoss == null)
                result.Control_de_Documentoss = new List<Control_de_Documentos>();

            var data = result.Control_de_Documentoss.Select(m => new Control_de_DocumentosGridModel
            {
                Folio = m.Folio
                        ,
                Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
            ,
                Hora_de_Registro = m.Hora_de_Registro
                        ,
                Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
            ,
                idFormato = m.idFormato
            ,
                LlaveRegistro = m.LlaveRegistro
            ,
                TablaPersona = m.TablaPersona
            ,
                LlaveRegistroPersona = m.LlaveRegistroPersona
                        ,
                ProcesoDescripcion = CultureHelper.GetTraduction(m.Proceso_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_Origen_de_Invitacion.Descripcion
            ,
                Numero_de_Expediente = m.Numero_de_Expediente
            ,
                Cuerpo_del_Documento = System.Net.WebUtility.HtmlDecode(m.Cuerpo_del_Documento)
            ,
                Archivo = m.Archivo
            ,
                Encabezado = System.Net.WebUtility.HtmlDecode(m.Encabezado)
            ,
                Pie_de_Pagina = System.Net.WebUtility.HtmlDecode(m.Pie_de_Pagina)

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
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IControl_de_DocumentosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                // Session["control_de_documentosInseted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post_Datos_Generales(Control_de_Documentos_Datos_GeneralesModel varControl_de_Documentos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var result = "";
                var Control_de_Documentos_Datos_GeneralesInfo = new Control_de_Documentos_Datos_Generales
                {
                    Folio = varControl_de_Documentos.Folio
                                            ,
                    Fecha_de_Registro = (!String.IsNullOrEmpty(varControl_de_Documentos.Fecha_de_Registro)) ? DateTime.ParseExact(varControl_de_Documentos.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,
                    Hora_de_Registro = varControl_de_Documentos.Hora_de_Registro
                        ,
                    Usuario_que_Registra = varControl_de_Documentos.Usuario_que_Registra
                        ,
                    idFormato = varControl_de_Documentos.idFormato
                        ,
                    LlaveRegistro = varControl_de_Documentos.LlaveRegistro
                        ,
                    TablaPersona = varControl_de_Documentos.TablaPersona
                        ,
                    LlaveRegistroPersona = varControl_de_Documentos.LlaveRegistroPersona

                };

                result = _IControl_de_DocumentosApiConsumer.Update_Datos_Generales(Control_de_Documentos_Datos_GeneralesInfo).Resource.ToString();
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
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IControl_de_DocumentosApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
                int RowCount_Detalle_Historial_Control_de_Documentos;
                var Detalle_Historial_Control_de_DocumentosData = GetDetalle_Historial_Control_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historial_Control_de_Documentos);

                var result = new Control_de_Documentos_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,
                    Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
            ,
                    Hora_de_Registro = m.Hora_de_Registro
                        ,
                    Usuario_que_Registra = m.Usuario_que_Registra
                        ,
                    Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
            ,
                    idFormato = m.idFormato
            ,
                    LlaveRegistro = m.LlaveRegistro
            ,
                    TablaPersona = m.TablaPersona
            ,
                    LlaveRegistroPersona = m.LlaveRegistroPersona


                };
                var resultData = new
                {
                    data = result
                    ,
                    Historial_de_Cambios = Detalle_Historial_Control_de_DocumentosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Post_Documento(Control_de_Documentos_DocumentoModel varControl_de_Documentos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                if (varControl_de_Documentos.ArchivoRemoveAttachment != 0 && varControl_de_Documentos.ArchivoFile == null)
                {
                    varControl_de_Documentos.Archivo = 0;
                }

                if (varControl_de_Documentos.ArchivoFile != null)
                {
                    var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varControl_de_Documentos.ArchivoFile);
                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    varControl_de_Documentos.Archivo = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                    {
                        File = fileAsBytes,
                        Description = varControl_de_Documentos.ArchivoFile.FileName,
                        File_Size = fileAsBytes.Length
                    }).Resource;
                }

                var result = "";
                var Control_de_Documentos_DocumentoInfo = new Control_de_Documentos_Documento
                {
                    Folio = varControl_de_Documentos.Folio
                                            ,
                    Proceso = varControl_de_Documentos.Proceso
                        ,
                    Numero_de_Expediente = varControl_de_Documentos.Numero_de_Expediente
                        ,
                    Cuerpo_del_Documento = varControl_de_Documentos.Cuerpo_del_Documento
                        ,
                    Archivo = (varControl_de_Documentos.Archivo.HasValue && varControl_de_Documentos.Archivo != 0) ? ((int?)Convert.ToInt32(varControl_de_Documentos.Archivo.Value)) : null


                };

                result = _IControl_de_DocumentosApiConsumer.Update_Documento(Control_de_Documentos_DocumentoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Get_Documento(string Id)
        {
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IControl_de_DocumentosApiConsumer.Get_Documento(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
                int RowCount_Detalle_Historial_Control_de_Documentos;
                var Detalle_Historial_Control_de_DocumentosData = GetDetalle_Historial_Control_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historial_Control_de_Documentos);

                var result = new Control_de_Documentos_DocumentoModel
                {
                    Folio = m.Folio
                        ,
                    Proceso = m.Proceso
                        ,
                    ProcesoDescripcion = CultureHelper.GetTraduction(m.Proceso_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Proceso_Origen_de_Invitacion.Descripcion
            ,
                    Numero_de_Expediente = m.Numero_de_Expediente
            ,
                    Cuerpo_del_Documento = m.Cuerpo_del_Documento
            ,
                    Archivo = m.Archivo


                };
                var resultData = new
                {
                    data = result
                    ,
                    Historial_de_Cambios = Detalle_Historial_Control_de_DocumentosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Post_Secciones(Control_de_Documentos_SeccionesModel varControl_de_Documentos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var result = "";
                var Control_de_Documentos_SeccionesInfo = new Control_de_Documentos_Secciones
                {
                    Folio = varControl_de_Documentos.Folio
                                            ,
                    Encabezado = varControl_de_Documentos.Encabezado
                        ,
                    Pie_de_Pagina = varControl_de_Documentos.Pie_de_Pagina

                };

                result = _IControl_de_DocumentosApiConsumer.Update_Secciones(Control_de_Documentos_SeccionesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Get_Secciones(string Id)
        {
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IControl_de_DocumentosApiConsumer.Get_Secciones(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
                int RowCount_Detalle_Historial_Control_de_Documentos;
                var Detalle_Historial_Control_de_DocumentosData = GetDetalle_Historial_Control_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historial_Control_de_Documentos);

                var result = new Control_de_Documentos_SeccionesModel
                {
                    Folio = m.Folio
            ,
                    Encabezado = m.Encabezado
            ,
                    Pie_de_Pagina = m.Pie_de_Pagina


                };
                var resultData = new
                {
                    data = result
                    ,
                    Historial_de_Cambios = Detalle_Historial_Control_de_DocumentosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Post_Historial(Control_de_Documentos_HistorialModel varControl_de_Documentos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var result = "";
                var Control_de_Documentos_HistorialInfo = new Control_de_Documentos_Historial
                {
                    Folio = varControl_de_Documentos.Folio

                };

                result = _IControl_de_DocumentosApiConsumer.Update_Historial(Control_de_Documentos_HistorialInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult Get_Historial(string Id)
        {
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IControl_de_DocumentosApiConsumer.Get_Historial(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
                int RowCount_Detalle_Historial_Control_de_Documentos;
                var Detalle_Historial_Control_de_DocumentosData = GetDetalle_Historial_Control_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Historial_Control_de_Documentos);

                var result = new Control_de_Documentos_HistorialModel
                {
                    Folio = m.Folio


                };
                var resultData = new
                {
                    data = result
                    ,
                    Historial_de_Cambios = Detalle_Historial_Control_de_DocumentosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }


    }
}

