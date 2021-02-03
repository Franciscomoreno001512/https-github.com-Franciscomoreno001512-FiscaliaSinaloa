using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.estatus_mpi;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;




using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using Spartane.Core.Domain.Periodicidad;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.tipo_de_cierre;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.expediente_ministerio_publico;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.estatus_mpi;
using Spartane.Web.Areas.WebApiConsumer.detalle_de_observaciones_mpi;



using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Periodicidad;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.tipo_de_cierre;

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
    public class expediente_ministerio_publicoController : Controller
    {
        #region "variable declaration"

        private Iexpediente_ministerio_publicoService service = null;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_DenunciaApiConsumer _ITipo_de_DenunciaApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private Iestatus_mpiApiConsumer _Iestatus_mpiApiConsumer;
        private Idetalle_de_observaciones_mpiApiConsumer _Idetalle_de_observaciones_mpiApiConsumer;




        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private ITipo_de_AcuerdoApiConsumer _ITipo_de_AcuerdoApiConsumer;
        private IPeriodicidadApiConsumer _IPeriodicidadApiConsumer;
        private Itipo_de_cierreApiConsumer _Itipo_de_cierreApiConsumer;

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

        
        public expediente_ministerio_publicoController(Iexpediente_ministerio_publicoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_DenunciaApiConsumer Tipo_de_DenunciaApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IRegionApiConsumer RegionApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , Iestatus_mpiApiConsumer estatus_mpiApiConsumer , Idetalle_de_observaciones_mpiApiConsumer detalle_de_observaciones_mpiApiConsumer  , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ITipo_de_AcuerdoApiConsumer Tipo_de_AcuerdoApiConsumer , IPeriodicidadApiConsumer PeriodicidadApiConsumer , Itipo_de_cierreApiConsumer tipo_de_cierreApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
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
            this._ITipo_de_DenunciaApiConsumer = Tipo_de_DenunciaApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._Iestatus_mpiApiConsumer = estatus_mpiApiConsumer;
            this._Idetalle_de_observaciones_mpiApiConsumer = detalle_de_observaciones_mpiApiConsumer;



            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ITipo_de_AcuerdoApiConsumer = Tipo_de_AcuerdoApiConsumer;
            this._IPeriodicidadApiConsumer = PeriodicidadApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._Itipo_de_cierreApiConsumer = tipo_de_cierreApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/expediente_ministerio_publico
        [ObjectAuth(ObjectId = (ModuleObjectId)45468, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45468, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/expediente_ministerio_publico/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45468, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45468, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varexpediente_ministerio_publico = new expediente_ministerio_publicoModel();
			varexpediente_ministerio_publico.clave = Id;
			
            ViewBag.ObjectId = "45468";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissiondetalle_de_observaciones_mpi = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45469, ModuleId);
            ViewBag.Permissiondetalle_de_observaciones_mpi = permissiondetalle_de_observaciones_mpi;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var expediente_ministerio_publicosData = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(0, 1000, "expediente_ministerio_publico.clave=" + Id, "").Resource.expediente_ministerio_publicos;
				
				if (expediente_ministerio_publicosData != null && expediente_ministerio_publicosData.Count > 0)
                {
					var expediente_ministerio_publicoData = expediente_ministerio_publicosData.First();
					varexpediente_ministerio_publico= new expediente_ministerio_publicoModel
					{
						clave  = expediente_ministerio_publicoData.clave 
	                    ,fecha_de_registro = (expediente_ministerio_publicoData.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_registro = expediente_ministerio_publicoData.hora_de_registro
                    ,usuario_que_registra = expediente_ministerio_publicoData.usuario_que_registra
                    ,usuario_que_registraName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.usuario_que_registra), "Spartan_User") ??  (string)expediente_ministerio_publicoData.usuario_que_registra_Spartan_User.Name
                    ,Tipo_de_Denuncia = expediente_ministerio_publicoData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)expediente_ministerio_publicoData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,MP_Asignado = expediente_ministerio_publicoData.MP_Asignado
                    ,MP_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.MP_Asignado), "Spartan_User") ??  (string)expediente_ministerio_publicoData.MP_Asignado_Spartan_User.Name
                    ,unidad = expediente_ministerio_publicoData.unidad
                    ,unidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.unidad), "Unidad") ??  (string)expediente_ministerio_publicoData.unidad_Unidad.Descripcion
                    ,Municipio = expediente_ministerio_publicoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Municipio), "Municipio") ??  (string)expediente_ministerio_publicoData.Municipio_Municipio.Nombre
                    ,Region = expediente_ministerio_publicoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Region), "Region") ??  (string)expediente_ministerio_publicoData.Region_Region.Descripcion
                    ,nuat = expediente_ministerio_publicoData.nuat
                    ,nic = expediente_ministerio_publicoData.nic
                    ,detenido = expediente_ministerio_publicoData.detenido
                    ,detenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.detenido), "A_Tiempo") ??  (string)expediente_ministerio_publicoData.detenido_A_Tiempo.Descripcion
                    ,hora_del_detenido = expediente_ministerio_publicoData.hora_del_detenido
                    ,hora_puesto_a_disposicion = expediente_ministerio_publicoData.hora_puesto_a_disposicion
                    ,estatus = expediente_ministerio_publicoData.estatus
                    ,estatusdescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.estatus), "estatus_mpi") ??  (string)expediente_ministerio_publicoData.estatus_estatus_mpi.descripcion
                    ,Titulo_del_Hecho = expediente_ministerio_publicoData.Titulo_del_Hecho
                    ,Fecha_del_Hecho = (expediente_ministerio_publicoData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Narrativa_Breve_de_los_Hechos = expediente_ministerio_publicoData.Narrativa_Breve_de_los_Hechos
                    ,Hora_Aproximada_del_Hecho = expediente_ministerio_publicoData.Hora_Aproximada_del_Hecho
                    ,Lugar_de_los_Hechos = expediente_ministerio_publicoData.Lugar_de_los_Hechos
                    ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Lugar_de_los_Hechos), "Lugar_Tipo") ??  (string)expediente_ministerio_publicoData.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                    ,PaisH = expediente_ministerio_publicoData.PaisH
                    ,PaisHNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.PaisH), "Pais") ??  (string)expediente_ministerio_publicoData.PaisH_Pais.Nombre
                    ,Estado = expediente_ministerio_publicoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Estado), "Estado") ??  (string)expediente_ministerio_publicoData.Estado_Estado.Nombre
                    ,Municipio_Hechos = expediente_ministerio_publicoData.Municipio_Hechos
                    ,Municipio_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Municipio_Hechos), "Municipio") ??  (string)expediente_ministerio_publicoData.Municipio_Hechos_Municipio.Nombre
                    ,Poblacion = expediente_ministerio_publicoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Poblacion), "Colonia") ??  (string)expediente_ministerio_publicoData.Poblacion_Colonia.Nombre
                    ,ColoniaH = expediente_ministerio_publicoData.ColoniaH
                    ,ColoniaHNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.ColoniaH), "Colonia") ??  (string)expediente_ministerio_publicoData.ColoniaH_Colonia.Nombre
                    ,CalleH = expediente_ministerio_publicoData.CalleH
                    ,Numero_InteriorH = expediente_ministerio_publicoData.Numero_InteriorH
                    ,Numero_ExteriorH = expediente_ministerio_publicoData.Numero_ExteriorH
                    ,Codigo_PostalH = expediente_ministerio_publicoData.Codigo_PostalH
                    ,Entre_Calle = expediente_ministerio_publicoData.Entre_Calle
                    ,Y_Calle = expediente_ministerio_publicoData.Y_Calle
                    ,LongitudH = expediente_ministerio_publicoData.LongitudH
                    ,LatitudH = expediente_ministerio_publicoData.LatitudH
                    ,tipo_de_acuerdo = expediente_ministerio_publicoData.tipo_de_acuerdo
                    ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.tipo_de_acuerdo), "Tipo_de_Acuerdo") ??  (string)expediente_ministerio_publicoData.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,fecha_de_inicio_de_acuerdo = (expediente_ministerio_publicoData.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,fecha_de_cumplimiento = (expediente_ministerio_publicoData.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_cumplimiento = expediente_ministerio_publicoData.hora_de_cumplimiento
                    ,domicilio_para_el_cumplimiento = expediente_ministerio_publicoData.domicilio_para_el_cumplimiento
                    ,monto_de_reparacion_de_danos = expediente_ministerio_publicoData.monto_de_reparacion_de_danos
                    ,parcialidades = expediente_ministerio_publicoData.parcialidades
                    ,periodicidad = expediente_ministerio_publicoData.periodicidad
                    ,periodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.periodicidad), "Periodicidad") ??  (string)expediente_ministerio_publicoData.periodicidad_Periodicidad.Descripcion
                    ,acepta_acuerdo = expediente_ministerio_publicoData.acepta_acuerdo
                    ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.acepta_acuerdo), "A_Tiempo") ??  (string)expediente_ministerio_publicoData.acepta_acuerdo_A_Tiempo.Descripcion
                    ,motivo_de_rechazo_de_acuerdo = expediente_ministerio_publicoData.motivo_de_rechazo_de_acuerdo
                    ,fecha_de_cierre = (expediente_ministerio_publicoData.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_cierre = expediente_ministerio_publicoData.hora_de_cierre
                    ,Usuario_que_Cierra = expediente_ministerio_publicoData.Usuario_que_Cierra
                    ,Usuario_que_CierraName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Usuario_que_Cierra), "Spartan_User") ??  (string)expediente_ministerio_publicoData.Usuario_que_Cierra_Spartan_User.Name
                    ,tipo_de_cierre = expediente_ministerio_publicoData.tipo_de_cierre
                    ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.tipo_de_cierre), "tipo_de_cierre") ??  (string)expediente_ministerio_publicoData.tipo_de_cierre_tipo_de_cierre.descripcion
                    ,comentarios_de_cierre = expediente_ministerio_publicoData.comentarios_de_cierre

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_detenido != null && A_Tiempos_detenido.Resource != null)
                ViewBag.A_Tiempos_detenido = A_Tiempos_detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iestatus_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
            var estatus_mpis_estatus = _Iestatus_mpiApiConsumer.SelAll(true);
            if (estatus_mpis_estatus != null && estatus_mpis_estatus.Resource != null)
                ViewBag.estatus_mpis_estatus = estatus_mpis_estatus.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "estatus_mpi", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_tipo_de_acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_tipo_de_acuerdo != null && Tipo_de_Acuerdos_tipo_de_acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_tipo_de_acuerdo = Tipo_de_Acuerdos_tipo_de_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_periodicidad != null && Periodicidads_periodicidad.Resource != null)
                ViewBag.Periodicidads_periodicidad = Periodicidads_periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_acepta_acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_acepta_acuerdo != null && A_Tiempos_acepta_acuerdo.Resource != null)
                ViewBag.A_Tiempos_acepta_acuerdo = A_Tiempos_acepta_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Itipo_de_cierreApiConsumer.SetAuthHeader(_tokenManager.Token);
            var tipo_de_cierres_tipo_de_cierre = _Itipo_de_cierreApiConsumer.SelAll(true);
            if (tipo_de_cierres_tipo_de_cierre != null && tipo_de_cierres_tipo_de_cierre.Resource != null)
                ViewBag.tipo_de_cierres_tipo_de_cierre = tipo_de_cierres_tipo_de_cierre.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "tipo_de_cierre", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
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

				
            return View(varexpediente_ministerio_publico);
        }
		
	[HttpGet]
        public ActionResult Addexpediente_ministerio_publico(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45468);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
			expediente_ministerio_publicoModel varexpediente_ministerio_publico= new expediente_ministerio_publicoModel();
            var permissiondetalle_de_observaciones_mpi = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45469, ModuleId);
            ViewBag.Permissiondetalle_de_observaciones_mpi = permissiondetalle_de_observaciones_mpi;


            if (id.ToString() != "0")
            {
                var expediente_ministerio_publicosData = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(0, 1000, "expediente_ministerio_publico.clave=" + id, "").Resource.expediente_ministerio_publicos;
				
				if (expediente_ministerio_publicosData != null && expediente_ministerio_publicosData.Count > 0)
                {
					var expediente_ministerio_publicoData = expediente_ministerio_publicosData.First();
					varexpediente_ministerio_publico= new expediente_ministerio_publicoModel
					{
						clave  = expediente_ministerio_publicoData.clave 
	                    ,fecha_de_registro = (expediente_ministerio_publicoData.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_registro = expediente_ministerio_publicoData.hora_de_registro
                    ,usuario_que_registra = expediente_ministerio_publicoData.usuario_que_registra
                    ,usuario_que_registraName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.usuario_que_registra), "Spartan_User") ??  (string)expediente_ministerio_publicoData.usuario_que_registra_Spartan_User.Name
                    ,Tipo_de_Denuncia = expediente_ministerio_publicoData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)expediente_ministerio_publicoData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,MP_Asignado = expediente_ministerio_publicoData.MP_Asignado
                    ,MP_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.MP_Asignado), "Spartan_User") ??  (string)expediente_ministerio_publicoData.MP_Asignado_Spartan_User.Name
                    ,unidad = expediente_ministerio_publicoData.unidad
                    ,unidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.unidad), "Unidad") ??  (string)expediente_ministerio_publicoData.unidad_Unidad.Descripcion
                    ,Municipio = expediente_ministerio_publicoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Municipio), "Municipio") ??  (string)expediente_ministerio_publicoData.Municipio_Municipio.Nombre
                    ,Region = expediente_ministerio_publicoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Region), "Region") ??  (string)expediente_ministerio_publicoData.Region_Region.Descripcion
                    ,nuat = expediente_ministerio_publicoData.nuat
                    ,nic = expediente_ministerio_publicoData.nic
                    ,detenido = expediente_ministerio_publicoData.detenido
                    ,detenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.detenido), "A_Tiempo") ??  (string)expediente_ministerio_publicoData.detenido_A_Tiempo.Descripcion
                    ,hora_del_detenido = expediente_ministerio_publicoData.hora_del_detenido
                    ,hora_puesto_a_disposicion = expediente_ministerio_publicoData.hora_puesto_a_disposicion
                    ,estatus = expediente_ministerio_publicoData.estatus
                    ,estatusdescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.estatus), "estatus_mpi") ??  (string)expediente_ministerio_publicoData.estatus_estatus_mpi.descripcion
                    ,Titulo_del_Hecho = expediente_ministerio_publicoData.Titulo_del_Hecho
                    ,Fecha_del_Hecho = (expediente_ministerio_publicoData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Narrativa_Breve_de_los_Hechos = expediente_ministerio_publicoData.Narrativa_Breve_de_los_Hechos
                    ,Hora_Aproximada_del_Hecho = expediente_ministerio_publicoData.Hora_Aproximada_del_Hecho
                    ,Lugar_de_los_Hechos = expediente_ministerio_publicoData.Lugar_de_los_Hechos
                    ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Lugar_de_los_Hechos), "Lugar_Tipo") ??  (string)expediente_ministerio_publicoData.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                    ,PaisH = expediente_ministerio_publicoData.PaisH
                    ,PaisHNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.PaisH), "Pais") ??  (string)expediente_ministerio_publicoData.PaisH_Pais.Nombre
                    ,Estado = expediente_ministerio_publicoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Estado), "Estado") ??  (string)expediente_ministerio_publicoData.Estado_Estado.Nombre
                    ,Municipio_Hechos = expediente_ministerio_publicoData.Municipio_Hechos
                    ,Municipio_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Municipio_Hechos), "Municipio") ??  (string)expediente_ministerio_publicoData.Municipio_Hechos_Municipio.Nombre
                    ,Poblacion = expediente_ministerio_publicoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Poblacion), "Colonia") ??  (string)expediente_ministerio_publicoData.Poblacion_Colonia.Nombre
                    ,ColoniaH = expediente_ministerio_publicoData.ColoniaH
                    ,ColoniaHNombre = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.ColoniaH), "Colonia") ??  (string)expediente_ministerio_publicoData.ColoniaH_Colonia.Nombre
                    ,CalleH = expediente_ministerio_publicoData.CalleH
                    ,Numero_InteriorH = expediente_ministerio_publicoData.Numero_InteriorH
                    ,Numero_ExteriorH = expediente_ministerio_publicoData.Numero_ExteriorH
                    ,Codigo_PostalH = expediente_ministerio_publicoData.Codigo_PostalH
                    ,Entre_Calle = expediente_ministerio_publicoData.Entre_Calle
                    ,Y_Calle = expediente_ministerio_publicoData.Y_Calle
                    ,LongitudH = expediente_ministerio_publicoData.LongitudH
                    ,LatitudH = expediente_ministerio_publicoData.LatitudH
                    ,tipo_de_acuerdo = expediente_ministerio_publicoData.tipo_de_acuerdo
                    ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.tipo_de_acuerdo), "Tipo_de_Acuerdo") ??  (string)expediente_ministerio_publicoData.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                    ,fecha_de_inicio_de_acuerdo = (expediente_ministerio_publicoData.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                    ,fecha_de_cumplimiento = (expediente_ministerio_publicoData.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_cumplimiento = expediente_ministerio_publicoData.hora_de_cumplimiento
                    ,domicilio_para_el_cumplimiento = expediente_ministerio_publicoData.domicilio_para_el_cumplimiento
                    ,monto_de_reparacion_de_danos = expediente_ministerio_publicoData.monto_de_reparacion_de_danos
                    ,parcialidades = expediente_ministerio_publicoData.parcialidades
                    ,periodicidad = expediente_ministerio_publicoData.periodicidad
                    ,periodicidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.periodicidad), "Periodicidad") ??  (string)expediente_ministerio_publicoData.periodicidad_Periodicidad.Descripcion
                    ,acepta_acuerdo = expediente_ministerio_publicoData.acepta_acuerdo
                    ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.acepta_acuerdo), "A_Tiempo") ??  (string)expediente_ministerio_publicoData.acepta_acuerdo_A_Tiempo.Descripcion
                    ,motivo_de_rechazo_de_acuerdo = expediente_ministerio_publicoData.motivo_de_rechazo_de_acuerdo
                    ,fecha_de_cierre = (expediente_ministerio_publicoData.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(expediente_ministerio_publicoData.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
                    ,hora_de_cierre = expediente_ministerio_publicoData.hora_de_cierre
                    ,Usuario_que_Cierra = expediente_ministerio_publicoData.Usuario_que_Cierra
                    ,Usuario_que_CierraName = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.Usuario_que_Cierra), "Spartan_User") ??  (string)expediente_ministerio_publicoData.Usuario_que_Cierra_Spartan_User.Name
                    ,tipo_de_cierre = expediente_ministerio_publicoData.tipo_de_cierre
                    ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(Convert.ToString(expediente_ministerio_publicoData.tipo_de_cierre), "tipo_de_cierre") ??  (string)expediente_ministerio_publicoData.tipo_de_cierre_tipo_de_cierre.descripcion
                    ,comentarios_de_cierre = expediente_ministerio_publicoData.comentarios_de_cierre

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_detenido != null && A_Tiempos_detenido.Resource != null)
                ViewBag.A_Tiempos_detenido = A_Tiempos_detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iestatus_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
            var estatus_mpis_estatus = _Iestatus_mpiApiConsumer.SelAll(true);
            if (estatus_mpis_estatus != null && estatus_mpis_estatus.Resource != null)
                ViewBag.estatus_mpis_estatus = estatus_mpis_estatus.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "estatus_mpi", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_tipo_de_acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_tipo_de_acuerdo != null && Tipo_de_Acuerdos_tipo_de_acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_tipo_de_acuerdo = Tipo_de_Acuerdos_tipo_de_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_periodicidad != null && Periodicidads_periodicidad.Resource != null)
                ViewBag.Periodicidads_periodicidad = Periodicidads_periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_acepta_acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_acepta_acuerdo != null && A_Tiempos_acepta_acuerdo.Resource != null)
                ViewBag.A_Tiempos_acepta_acuerdo = A_Tiempos_acepta_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Itipo_de_cierreApiConsumer.SetAuthHeader(_tokenManager.Token);
            var tipo_de_cierres_tipo_de_cierre = _Itipo_de_cierreApiConsumer.SelAll(true);
            if (tipo_de_cierres_tipo_de_cierre != null && tipo_de_cierres_tipo_de_cierre.Resource != null)
                ViewBag.tipo_de_cierres_tipo_de_cierre = tipo_de_cierres_tipo_de_cierre.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "tipo_de_cierre", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();


            return PartialView("Addexpediente_ministerio_publico", varexpediente_ministerio_publico);
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
        public ActionResult GetTipo_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetRegionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetA_TiempoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IA_TiempoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Getestatus_mpiAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iestatus_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iestatus_mpiApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "estatus_mpi", "descripcion")?? m.descripcion,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetEstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_AcuerdoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AcuerdoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPeriodicidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPeriodicidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Gettipo_de_cierreAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Itipo_de_cierreApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Itipo_de_cierreApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "tipo_de_cierre", "descripcion")?? m.descripcion,
                    Value = Convert.ToString(m.clave)
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
        public ActionResult ShowAdvanceFilter(expediente_ministerio_publicoAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_detenido != null && A_Tiempos_detenido.Resource != null)
                ViewBag.A_Tiempos_detenido = A_Tiempos_detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iestatus_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
            var estatus_mpis_estatus = _Iestatus_mpiApiConsumer.SelAll(true);
            if (estatus_mpis_estatus != null && estatus_mpis_estatus.Resource != null)
                ViewBag.estatus_mpis_estatus = estatus_mpis_estatus.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "estatus_mpi", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_tipo_de_acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_tipo_de_acuerdo != null && Tipo_de_Acuerdos_tipo_de_acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_tipo_de_acuerdo = Tipo_de_Acuerdos_tipo_de_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_periodicidad != null && Periodicidads_periodicidad.Resource != null)
                ViewBag.Periodicidads_periodicidad = Periodicidads_periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_acepta_acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_acepta_acuerdo != null && A_Tiempos_acepta_acuerdo.Resource != null)
                ViewBag.A_Tiempos_acepta_acuerdo = A_Tiempos_acepta_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Itipo_de_cierreApiConsumer.SetAuthHeader(_tokenManager.Token);
            var tipo_de_cierres_tipo_de_cierre = _Itipo_de_cierreApiConsumer.SelAll(true);
            if (tipo_de_cierres_tipo_de_cierre != null && tipo_de_cierres_tipo_de_cierre.Resource != null)
                ViewBag.tipo_de_cierres_tipo_de_cierre = tipo_de_cierres_tipo_de_cierre.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "tipo_de_cierre", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_detenido != null && A_Tiempos_detenido.Resource != null)
                ViewBag.A_Tiempos_detenido = A_Tiempos_detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iestatus_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
            var estatus_mpis_estatus = _Iestatus_mpiApiConsumer.SelAll(true);
            if (estatus_mpis_estatus != null && estatus_mpis_estatus.Resource != null)
                ViewBag.estatus_mpis_estatus = estatus_mpis_estatus.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "estatus_mpi", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Acuerdos_tipo_de_acuerdo = _ITipo_de_AcuerdoApiConsumer.SelAll(true);
            if (Tipo_de_Acuerdos_tipo_de_acuerdo != null && Tipo_de_Acuerdos_tipo_de_acuerdo.Resource != null)
                ViewBag.Tipo_de_Acuerdos_tipo_de_acuerdo = Tipo_de_Acuerdos_tipo_de_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Acuerdo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPeriodicidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Periodicidads_periodicidad = _IPeriodicidadApiConsumer.SelAll(true);
            if (Periodicidads_periodicidad != null && Periodicidads_periodicidad.Resource != null)
                ViewBag.Periodicidads_periodicidad = Periodicidads_periodicidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Periodicidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_acepta_acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_acepta_acuerdo != null && A_Tiempos_acepta_acuerdo.Resource != null)
                ViewBag.A_Tiempos_acepta_acuerdo = A_Tiempos_acepta_acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Itipo_de_cierreApiConsumer.SetAuthHeader(_tokenManager.Token);
            var tipo_de_cierres_tipo_de_cierre = _Itipo_de_cierreApiConsumer.SelAll(true);
            if (tipo_de_cierres_tipo_de_cierre != null && tipo_de_cierres_tipo_de_cierre.Resource != null)
                ViewBag.tipo_de_cierres_tipo_de_cierre = tipo_de_cierres_tipo_de_cierre.Resource.Where(m => m.descripcion != null).OrderBy(m => m.descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "tipo_de_cierre", "descripcion") ?? m.descripcion.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();


            var previousFiltersObj = new expediente_ministerio_publicoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (expediente_ministerio_publicoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new expediente_ministerio_publicoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new expediente_ministerio_publicoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.expediente_ministerio_publicos == null)
                result.expediente_ministerio_publicos = new List<expediente_ministerio_publico>();

            return Json(new
            {
                data = result.expediente_ministerio_publicos.Select(m => new expediente_ministerio_publicoGridModel
                    {
                    clave = m.clave
                        ,fecha_de_registro = (m.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,hora_de_registro = m.hora_de_registro
                        ,usuario_que_registraName = CultureHelper.GetTraduction(m.usuario_que_registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_que_registra_Spartan_User.Name
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,MP_AsignadoName = CultureHelper.GetTraduction(m.MP_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Asignado_Spartan_User.Name
                        ,unidadDescripcion = CultureHelper.GetTraduction(m.unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,nuat = m.nuat
			,nic = m.nic
                        ,detenidoDescripcion = CultureHelper.GetTraduction(m.detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.detenido_A_Tiempo.Descripcion
			,hora_del_detenido = m.hora_del_detenido
			,hora_puesto_a_disposicion = m.hora_puesto_a_disposicion
                        ,estatusdescripcion = CultureHelper.GetTraduction(m.estatus_estatus_mpi.clave.ToString(), "descripcion") ?? (string)m.estatus_estatus_mpi.descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
                        ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(m.tipo_de_acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,fecha_de_inicio_de_acuerdo = (m.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(m.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,fecha_de_cumplimiento = (m.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cumplimiento = m.hora_de_cumplimiento
			,domicilio_para_el_cumplimiento = m.domicilio_para_el_cumplimiento
			,monto_de_reparacion_de_danos = m.monto_de_reparacion_de_danos
			,parcialidades = m.parcialidades
                        ,periodicidadDescripcion = CultureHelper.GetTraduction(m.periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.periodicidad_Periodicidad.Descripcion
                        ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(m.acepta_acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.acepta_acuerdo_A_Tiempo.Descripcion
			,motivo_de_rechazo_de_acuerdo = m.motivo_de_rechazo_de_acuerdo
                        ,fecha_de_cierre = (m.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cierre = m.hora_de_cierre
                        ,Usuario_que_CierraName = CultureHelper.GetTraduction(m.Usuario_que_Cierra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Cierra_Spartan_User.Name
                        ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(m.tipo_de_cierre_tipo_de_cierre.clave.ToString(), "descripcion") ?? (string)m.tipo_de_cierre_tipo_de_cierre.descripcion
			,comentarios_de_cierre = m.comentarios_de_cierre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.clave), "expediente_ministerio_publico", m.),
                     Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of expediente_ministerio_publico from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of expediente_ministerio_publico Entity</returns>
        public ActionResult Getexpediente_ministerio_publicoList(UrlParametersModel param)
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
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new expediente_ministerio_publicoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(expediente_ministerio_publicoAdvanceSearchModel))
                {
					var advanceFilter =
                    (expediente_ministerio_publicoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            expediente_ministerio_publicoPropertyMapper oexpediente_ministerio_publicoPropertyMapper = new expediente_ministerio_publicoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oexpediente_ministerio_publicoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.expediente_ministerio_publicos == null)
                result.expediente_ministerio_publicos = new List<expediente_ministerio_publico>();

            return Json(new
            {
                aaData = result.expediente_ministerio_publicos.Select(m => new expediente_ministerio_publicoGridModel
            {
                    clave = m.clave
                        ,fecha_de_registro = (m.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,hora_de_registro = m.hora_de_registro
                        ,usuario_que_registraName = CultureHelper.GetTraduction(m.usuario_que_registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_que_registra_Spartan_User.Name
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,MP_AsignadoName = CultureHelper.GetTraduction(m.MP_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Asignado_Spartan_User.Name
                        ,unidadDescripcion = CultureHelper.GetTraduction(m.unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,nuat = m.nuat
			,nic = m.nic
                        ,detenidoDescripcion = CultureHelper.GetTraduction(m.detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.detenido_A_Tiempo.Descripcion
			,hora_del_detenido = m.hora_del_detenido
			,hora_puesto_a_disposicion = m.hora_puesto_a_disposicion
                        ,estatusdescripcion = CultureHelper.GetTraduction(m.estatus_estatus_mpi.clave.ToString(), "descripcion") ?? (string)m.estatus_estatus_mpi.descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
                        ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(m.tipo_de_acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,fecha_de_inicio_de_acuerdo = (m.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(m.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,fecha_de_cumplimiento = (m.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cumplimiento = m.hora_de_cumplimiento
			,domicilio_para_el_cumplimiento = m.domicilio_para_el_cumplimiento
			,monto_de_reparacion_de_danos = m.monto_de_reparacion_de_danos
			,parcialidades = m.parcialidades
                        ,periodicidadDescripcion = CultureHelper.GetTraduction(m.periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.periodicidad_Periodicidad.Descripcion
                        ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(m.acepta_acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.acepta_acuerdo_A_Tiempo.Descripcion
			,motivo_de_rechazo_de_acuerdo = m.motivo_de_rechazo_de_acuerdo
                        ,fecha_de_cierre = (m.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cierre = m.hora_de_cierre
                        ,Usuario_que_CierraName = CultureHelper.GetTraduction(m.Usuario_que_Cierra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Cierra_Spartan_User.Name
                        ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(m.tipo_de_cierre_tipo_de_cierre.clave.ToString(), "descripcion") ?? (string)m.tipo_de_cierre_tipo_de_cierre.descripcion
			,comentarios_de_cierre = m.comentarios_de_cierre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_usuario_que_registra_Spartan_User(string query, string where)
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
        public JsonResult Getexpediente_ministerio_publico_MP_Asignado_Spartan_User(string query, string where)
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
        public JsonResult Getexpediente_ministerio_publico_unidad_Unidad(string query, string where)
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
        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_Municipio_Municipio(string query, string where)
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
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult Getdetalle_de_observaciones_mpi_usuario_que_realiza_observacion_Spartan_User(string query, string where)
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
        public JsonResult Getexpediente_ministerio_publico_PaisH_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_Estado_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_Municipio_Hechos_Municipio(string query, string where)
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
        public JsonResult Getexpediente_ministerio_publico_Poblacion_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_ColoniaH_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult Getexpediente_ministerio_publico_Usuario_que_Cierra_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(expediente_ministerio_publicoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.Fromclave) || !string.IsNullOrEmpty(filter.Toclave))
            {
                if (!string.IsNullOrEmpty(filter.Fromclave))
                    where += " AND expediente_ministerio_publico.clave >= " + filter.Fromclave;
                if (!string.IsNullOrEmpty(filter.Toclave))
                    where += " AND expediente_ministerio_publico.clave <= " + filter.Toclave;
            }

            if (!string.IsNullOrEmpty(filter.Fromfecha_de_registro) || !string.IsNullOrEmpty(filter.Tofecha_de_registro))
            {
                var fecha_de_registroFrom = DateTime.ParseExact(filter.Fromfecha_de_registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var fecha_de_registroTo = DateTime.ParseExact(filter.Tofecha_de_registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.Fromfecha_de_registro))
                    where += " AND expediente_ministerio_publico.fecha_de_registro >= '" + fecha_de_registroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.Tofecha_de_registro))
                    where += " AND expediente_ministerio_publico.fecha_de_registro <= '" + fecha_de_registroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_de_registro) || !string.IsNullOrEmpty(filter.Tohora_de_registro))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_de_registro))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_registro) >='" + filter.Fromhora_de_registro + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_de_registro))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_registro) <='" + filter.Tohora_de_registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.Advanceusuario_que_registra))
            {
                switch (filter.usuario_que_registraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.Advanceusuario_que_registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.Advanceusuario_que_registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.Advanceusuario_que_registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.Advanceusuario_que_registra + "%'";
                        break;
                }
            }
            else if (filter.Advanceusuario_que_registraMultiple != null && filter.Advanceusuario_que_registraMultiple.Count() > 0)
            {
                var usuario_que_registraIds = string.Join(",", filter.Advanceusuario_que_registraMultiple);

                where += " AND expediente_ministerio_publico.usuario_que_registra In (" + usuario_que_registraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND expediente_ministerio_publico.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMP_Asignado))
            {
                switch (filter.MP_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceMP_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceMP_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceMP_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceMP_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMP_AsignadoMultiple != null && filter.AdvanceMP_AsignadoMultiple.Count() > 0)
            {
                var MP_AsignadoIds = string.Join(",", filter.AdvanceMP_AsignadoMultiple);

                where += " AND expediente_ministerio_publico.MP_Asignado In (" + MP_AsignadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advanceunidad))
            {
                switch (filter.unidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.Advanceunidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.Advanceunidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.Advanceunidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.Advanceunidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceunidadMultiple != null && filter.AdvanceunidadMultiple.Count() > 0)
            {
                var unidadIds = string.Join(",", filter.AdvanceunidadMultiple);

                where += " AND expediente_ministerio_publico.unidad In (" + unidadIds + ")";
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

                where += " AND expediente_ministerio_publico.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRegion))
            {
                switch (filter.RegionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Region.Descripcion LIKE '" + filter.AdvanceRegion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Region.Descripcion = '" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRegionMultiple != null && filter.AdvanceRegionMultiple.Count() > 0)
            {
                var RegionIds = string.Join(",", filter.AdvanceRegionMultiple);

                where += " AND expediente_ministerio_publico.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.nuat))
            {
                switch (filter.nuatFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nuat LIKE '" + filter.nuat + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nuat LIKE '%" + filter.nuat + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nuat = '" + filter.nuat + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nuat LIKE '%" + filter.nuat + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.nic))
            {
                switch (filter.nicFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.nic + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.nic + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.nic + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.nic + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Advancedetenido))
            {
                switch (filter.detenidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.Advancedetenido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advancedetenido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.Advancedetenido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advancedetenido + "%'";
                        break;
                }
            }
            else if (filter.AdvancedetenidoMultiple != null && filter.AdvancedetenidoMultiple.Count() > 0)
            {
                var detenidoIds = string.Join(",", filter.AdvancedetenidoMultiple);

                where += " AND expediente_ministerio_publico.detenido In (" + detenidoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_del_detenido) || !string.IsNullOrEmpty(filter.Tohora_del_detenido))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_del_detenido))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_del_detenido) >='" + filter.Fromhora_del_detenido + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_del_detenido))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_del_detenido) <='" + filter.Tohora_del_detenido + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_puesto_a_disposicion) || !string.IsNullOrEmpty(filter.Tohora_puesto_a_disposicion))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_puesto_a_disposicion))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_puesto_a_disposicion) >='" + filter.Fromhora_puesto_a_disposicion + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_puesto_a_disposicion))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_puesto_a_disposicion) <='" + filter.Tohora_puesto_a_disposicion + "'";
            }

            if (!string.IsNullOrEmpty(filter.Advanceestatus))
            {
                switch (filter.estatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND estatus_mpi.descripcion LIKE '" + filter.Advanceestatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND estatus_mpi.descripcion LIKE '%" + filter.Advanceestatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND estatus_mpi.descripcion = '" + filter.Advanceestatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND estatus_mpi.descripcion LIKE '%" + filter.Advanceestatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceestatusMultiple != null && filter.AdvanceestatusMultiple.Count() > 0)
            {
                var estatusIds = string.Join(",", filter.AdvanceestatusMultiple);

                where += " AND expediente_ministerio_publico.estatus In (" + estatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND expediente_ministerio_publico.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND expediente_ministerio_publico.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,expediente_ministerio_publico.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,expediente_ministerio_publico.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLugar_de_los_Hechos))
            {
                switch (filter.Lugar_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceLugar_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceLugar_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceLugar_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceLugar_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLugar_de_los_HechosMultiple != null && filter.AdvanceLugar_de_los_HechosMultiple.Count() > 0)
            {
                var Lugar_de_los_HechosIds = string.Join(",", filter.AdvanceLugar_de_los_HechosMultiple);

                where += " AND expediente_ministerio_publico.Lugar_de_los_Hechos In (" + Lugar_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePaisH))
            {
                switch (filter.PaisHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePaisH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePaisH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePaisH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePaisH + "%'";
                        break;
                }
            }
            else if (filter.AdvancePaisHMultiple != null && filter.AdvancePaisHMultiple.Count() > 0)
            {
                var PaisHIds = string.Join(",", filter.AdvancePaisHMultiple);

                where += " AND expediente_ministerio_publico.PaisH In (" + PaisHIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado))
            {
                switch (filter.EstadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoMultiple != null && filter.AdvanceEstadoMultiple.Count() > 0)
            {
                var EstadoIds = string.Join(",", filter.AdvanceEstadoMultiple);

                where += " AND expediente_ministerio_publico.Estado In (" + EstadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_Hechos))
            {
                switch (filter.Municipio_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_HechosMultiple != null && filter.AdvanceMunicipio_HechosMultiple.Count() > 0)
            {
                var Municipio_HechosIds = string.Join(",", filter.AdvanceMunicipio_HechosMultiple);

                where += " AND expediente_ministerio_publico.Municipio_Hechos In (" + Municipio_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion))
            {
                switch (filter.PoblacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacionMultiple != null && filter.AdvancePoblacionMultiple.Count() > 0)
            {
                var PoblacionIds = string.Join(",", filter.AdvancePoblacionMultiple);

                where += " AND expediente_ministerio_publico.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColoniaH))
            {
                switch (filter.ColoniaHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColoniaH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColoniaH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaH + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaHMultiple != null && filter.AdvanceColoniaHMultiple.Count() > 0)
            {
                var ColoniaHIds = string.Join(",", filter.AdvanceColoniaHMultiple);

                where += " AND expediente_ministerio_publico.ColoniaH In (" + ColoniaHIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.CalleH))
            {
                switch (filter.CalleHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.CalleH LIKE '" + filter.CalleH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.CalleH LIKE '%" + filter.CalleH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.CalleH = '" + filter.CalleH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.CalleH LIKE '%" + filter.CalleH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_InteriorH))
            {
                switch (filter.Numero_InteriorHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Numero_InteriorH LIKE '" + filter.Numero_InteriorH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Numero_InteriorH LIKE '%" + filter.Numero_InteriorH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Numero_InteriorH = '" + filter.Numero_InteriorH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Numero_InteriorH LIKE '%" + filter.Numero_InteriorH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_ExteriorH))
            {
                switch (filter.Numero_ExteriorHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Numero_ExteriorH LIKE '" + filter.Numero_ExteriorH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Numero_ExteriorH LIKE '%" + filter.Numero_ExteriorH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Numero_ExteriorH = '" + filter.Numero_ExteriorH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Numero_ExteriorH LIKE '%" + filter.Numero_ExteriorH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_PostalH) || !string.IsNullOrEmpty(filter.ToCodigo_PostalH))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_PostalH))
                    where += " AND expediente_ministerio_publico.Codigo_PostalH >= " + filter.FromCodigo_PostalH;
                if (!string.IsNullOrEmpty(filter.ToCodigo_PostalH))
                    where += " AND expediente_ministerio_publico.Codigo_PostalH <= " + filter.ToCodigo_PostalH;
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.LongitudH))
            {
                switch (filter.LongitudHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.LongitudH LIKE '" + filter.LongitudH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.LongitudH LIKE '%" + filter.LongitudH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.LongitudH = '" + filter.LongitudH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.LongitudH LIKE '%" + filter.LongitudH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.LatitudH))
            {
                switch (filter.LatitudHFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.LatitudH LIKE '" + filter.LatitudH + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.LatitudH LIKE '%" + filter.LatitudH + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.LatitudH = '" + filter.LatitudH + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.LatitudH LIKE '%" + filter.LatitudH + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Advancetipo_de_acuerdo))
            {
                switch (filter.tipo_de_acuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '" + filter.Advancetipo_de_acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.Advancetipo_de_acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Acuerdo.Descripcion = '" + filter.Advancetipo_de_acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Acuerdo.Descripcion LIKE '%" + filter.Advancetipo_de_acuerdo + "%'";
                        break;
                }
            }
            else if (filter.Advancetipo_de_acuerdoMultiple != null && filter.Advancetipo_de_acuerdoMultiple.Count() > 0)
            {
                var tipo_de_acuerdoIds = string.Join(",", filter.Advancetipo_de_acuerdoMultiple);

                where += " AND expediente_ministerio_publico.tipo_de_acuerdo In (" + tipo_de_acuerdoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Fromfecha_de_inicio_de_acuerdo) || !string.IsNullOrEmpty(filter.Tofecha_de_inicio_de_acuerdo))
            {
                var fecha_de_inicio_de_acuerdoFrom = DateTime.ParseExact(filter.Fromfecha_de_inicio_de_acuerdo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var fecha_de_inicio_de_acuerdoTo = DateTime.ParseExact(filter.Tofecha_de_inicio_de_acuerdo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.Fromfecha_de_inicio_de_acuerdo))
                    where += " AND expediente_ministerio_publico.fecha_de_inicio_de_acuerdo >= '" + fecha_de_inicio_de_acuerdoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.Tofecha_de_inicio_de_acuerdo))
                    where += " AND expediente_ministerio_publico.fecha_de_inicio_de_acuerdo <= '" + fecha_de_inicio_de_acuerdoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromfecha_de_cumplimiento) || !string.IsNullOrEmpty(filter.Tofecha_de_cumplimiento))
            {
                var fecha_de_cumplimientoFrom = DateTime.ParseExact(filter.Fromfecha_de_cumplimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var fecha_de_cumplimientoTo = DateTime.ParseExact(filter.Tofecha_de_cumplimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.Fromfecha_de_cumplimiento))
                    where += " AND expediente_ministerio_publico.fecha_de_cumplimiento >= '" + fecha_de_cumplimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.Tofecha_de_cumplimiento))
                    where += " AND expediente_ministerio_publico.fecha_de_cumplimiento <= '" + fecha_de_cumplimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_de_cumplimiento) || !string.IsNullOrEmpty(filter.Tohora_de_cumplimiento))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_de_cumplimiento))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_cumplimiento) >='" + filter.Fromhora_de_cumplimiento + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_de_cumplimiento))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_cumplimiento) <='" + filter.Tohora_de_cumplimiento + "'";
            }

            if (!string.IsNullOrEmpty(filter.domicilio_para_el_cumplimiento))
            {
                switch (filter.domicilio_para_el_cumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.domicilio_para_el_cumplimiento LIKE '" + filter.domicilio_para_el_cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.domicilio_para_el_cumplimiento LIKE '%" + filter.domicilio_para_el_cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.domicilio_para_el_cumplimiento = '" + filter.domicilio_para_el_cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.domicilio_para_el_cumplimiento LIKE '%" + filter.domicilio_para_el_cumplimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Frommonto_de_reparacion_de_danos) || !string.IsNullOrEmpty(filter.Tomonto_de_reparacion_de_danos))
            {
                if (!string.IsNullOrEmpty(filter.Frommonto_de_reparacion_de_danos))
                    where += " AND expediente_ministerio_publico.monto_de_reparacion_de_danos >= " + filter.Frommonto_de_reparacion_de_danos;
                if (!string.IsNullOrEmpty(filter.Tomonto_de_reparacion_de_danos))
                    where += " AND expediente_ministerio_publico.monto_de_reparacion_de_danos <= " + filter.Tomonto_de_reparacion_de_danos;
            }

            if (!string.IsNullOrEmpty(filter.Fromparcialidades) || !string.IsNullOrEmpty(filter.Toparcialidades))
            {
                if (!string.IsNullOrEmpty(filter.Fromparcialidades))
                    where += " AND expediente_ministerio_publico.parcialidades >= " + filter.Fromparcialidades;
                if (!string.IsNullOrEmpty(filter.Toparcialidades))
                    where += " AND expediente_ministerio_publico.parcialidades <= " + filter.Toparcialidades;
            }

            if (!string.IsNullOrEmpty(filter.Advanceperiodicidad))
            {
                switch (filter.periodicidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Periodicidad.Descripcion LIKE '" + filter.Advanceperiodicidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.Advanceperiodicidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Periodicidad.Descripcion = '" + filter.Advanceperiodicidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Periodicidad.Descripcion LIKE '%" + filter.Advanceperiodicidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceperiodicidadMultiple != null && filter.AdvanceperiodicidadMultiple.Count() > 0)
            {
                var periodicidadIds = string.Join(",", filter.AdvanceperiodicidadMultiple);

                where += " AND expediente_ministerio_publico.periodicidad In (" + periodicidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advanceacepta_acuerdo))
            {
                switch (filter.acepta_acuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.Advanceacepta_acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advanceacepta_acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.Advanceacepta_acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.Advanceacepta_acuerdo + "%'";
                        break;
                }
            }
            else if (filter.Advanceacepta_acuerdoMultiple != null && filter.Advanceacepta_acuerdoMultiple.Count() > 0)
            {
                var acepta_acuerdoIds = string.Join(",", filter.Advanceacepta_acuerdoMultiple);

                where += " AND expediente_ministerio_publico.acepta_acuerdo In (" + acepta_acuerdoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.motivo_de_rechazo_de_acuerdo))
            {
                switch (filter.motivo_de_rechazo_de_acuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo LIKE '" + filter.motivo_de_rechazo_de_acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo LIKE '%" + filter.motivo_de_rechazo_de_acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo = '" + filter.motivo_de_rechazo_de_acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.motivo_de_rechazo_de_acuerdo LIKE '%" + filter.motivo_de_rechazo_de_acuerdo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Fromfecha_de_cierre) || !string.IsNullOrEmpty(filter.Tofecha_de_cierre))
            {
                var fecha_de_cierreFrom = DateTime.ParseExact(filter.Fromfecha_de_cierre, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var fecha_de_cierreTo = DateTime.ParseExact(filter.Tofecha_de_cierre, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.Fromfecha_de_cierre))
                    where += " AND expediente_ministerio_publico.fecha_de_cierre >= '" + fecha_de_cierreFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.Tofecha_de_cierre))
                    where += " AND expediente_ministerio_publico.fecha_de_cierre <= '" + fecha_de_cierreTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fromhora_de_cierre) || !string.IsNullOrEmpty(filter.Tohora_de_cierre))
            {
                if (!string.IsNullOrEmpty(filter.Fromhora_de_cierre))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_cierre) >='" + filter.Fromhora_de_cierre + "'";
                if (!string.IsNullOrEmpty(filter.Tohora_de_cierre))
                    where += " AND Convert(TIME,expediente_ministerio_publico.hora_de_cierre) <='" + filter.Tohora_de_cierre + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Cierra))
            {
                switch (filter.Usuario_que_CierraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Cierra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Cierra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Cierra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Cierra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_CierraMultiple != null && filter.AdvanceUsuario_que_CierraMultiple.Count() > 0)
            {
                var Usuario_que_CierraIds = string.Join(",", filter.AdvanceUsuario_que_CierraMultiple);

                where += " AND expediente_ministerio_publico.Usuario_que_Cierra In (" + Usuario_que_CierraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Advancetipo_de_cierre))
            {
                switch (filter.tipo_de_cierreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND tipo_de_cierre.descripcion LIKE '" + filter.Advancetipo_de_cierre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND tipo_de_cierre.descripcion LIKE '%" + filter.Advancetipo_de_cierre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND tipo_de_cierre.descripcion = '" + filter.Advancetipo_de_cierre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND tipo_de_cierre.descripcion LIKE '%" + filter.Advancetipo_de_cierre + "%'";
                        break;
                }
            }
            else if (filter.Advancetipo_de_cierreMultiple != null && filter.Advancetipo_de_cierreMultiple.Count() > 0)
            {
                var tipo_de_cierreIds = string.Join(",", filter.Advancetipo_de_cierreMultiple);

                where += " AND expediente_ministerio_publico.tipo_de_cierre In (" + tipo_de_cierreIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.comentarios_de_cierre))
            {
                switch (filter.comentarios_de_cierreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.comentarios_de_cierre LIKE '" + filter.comentarios_de_cierre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.comentarios_de_cierre LIKE '%" + filter.comentarios_de_cierre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.comentarios_de_cierre = '" + filter.comentarios_de_cierre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.comentarios_de_cierre LIKE '%" + filter.comentarios_de_cierre + "%'";
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

        public ActionResult Getdetalle_de_observaciones_mpi(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<detalle_de_observaciones_mpiGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "detalle_de_observaciones_mpi.expediente_inicial=" + RelationId;
            if("int" == "string")
            {
	           where = "detalle_de_observaciones_mpi.expediente_inicial='" + RelationId + "'";
            }
            var result = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.detalle_de_observaciones_mpis == null)
                result.detalle_de_observaciones_mpis = new List<detalle_de_observaciones_mpi>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.detalle_de_observaciones_mpis.Select(m => new detalle_de_observaciones_mpiGridModel
                {
                    clave = m.clave

			,observaciones = m.observaciones
			,fecha = (m.fecha == null ? string.Empty : Convert.ToDateTime(m.fecha).ToString(ConfigurationProperty.DateFormat))
			,hora = m.hora
                        ,usuario_que_realiza_observacion = m.usuario_que_realiza_observacion
                        ,usuario_que_realiza_observacionName = CultureHelper.GetTraduction(m.usuario_que_realiza_observacion_Spartan_User.Id_User.ToString(), "Name") ??(string)m.usuario_que_realiza_observacion_Spartan_User.Name

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<detalle_de_observaciones_mpiGridModel> Getdetalle_de_observaciones_mpiData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<detalle_de_observaciones_mpiGridModel> resultData = new List<detalle_de_observaciones_mpiGridModel>();
            string where = "detalle_de_observaciones_mpi.expediente_inicial=" + Id;
            if("int" == "string")
            {
                where = "detalle_de_observaciones_mpi.expediente_inicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.detalle_de_observaciones_mpis != null)
            {
                resultData = result.detalle_de_observaciones_mpis.Select(m => new detalle_de_observaciones_mpiGridModel
                    {
                        clave = m.clave

			,observaciones = m.observaciones
			,fecha = (m.fecha == null ? string.Empty : Convert.ToDateTime(m.fecha).ToString(ConfigurationProperty.DateFormat))
			,hora = m.hora
                        ,usuario_que_realiza_observacion = m.usuario_que_realiza_observacion
                        ,usuario_que_realiza_observacionName = CultureHelper.GetTraduction(m.usuario_que_realiza_observacion_Spartan_User.Id_User.ToString(), "Name") ??(string)m.usuario_que_realiza_observacion_Spartan_User.Name


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
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

                expediente_ministerio_publico varexpediente_ministerio_publico = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "detalle_de_observaciones_mpi.expediente_inicial=" + id;
                    if("int" == "string")
                    {
	                where = "detalle_de_observaciones_mpi.expediente_inicial='" + id + "'";
                    }
                    var detalle_de_observaciones_mpiInfo =
                        _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (detalle_de_observaciones_mpiInfo.detalle_de_observaciones_mpis.Count > 0)
                    {
                        var resultdetalle_de_observaciones_mpi = true;
                        //Removing associated job history with attachment
                        foreach (var detalle_de_observaciones_mpiItem in detalle_de_observaciones_mpiInfo.detalle_de_observaciones_mpis)
                            resultdetalle_de_observaciones_mpi = resultdetalle_de_observaciones_mpi
                                              && _Idetalle_de_observaciones_mpiApiConsumer.Delete(detalle_de_observaciones_mpiItem.clave, null,null).Resource;

                        if (!resultdetalle_de_observaciones_mpi)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _Iexpediente_ministerio_publicoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, expediente_ministerio_publicoModel varexpediente_ministerio_publico)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var expediente_ministerio_publicoInfo = new expediente_ministerio_publico
                    {
                        clave = varexpediente_ministerio_publico.clave
                        ,fecha_de_registro = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_registro)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_registro = varexpediente_ministerio_publico.hora_de_registro
                        ,usuario_que_registra = varexpediente_ministerio_publico.usuario_que_registra
                        ,Tipo_de_Denuncia = varexpediente_ministerio_publico.Tipo_de_Denuncia
                        ,MP_Asignado = varexpediente_ministerio_publico.MP_Asignado
                        ,unidad = varexpediente_ministerio_publico.unidad
                        ,Municipio = varexpediente_ministerio_publico.Municipio
                        ,Region = varexpediente_ministerio_publico.Region
                        ,nuat = varexpediente_ministerio_publico.nuat
                        ,nic = varexpediente_ministerio_publico.nic
                        ,detenido = varexpediente_ministerio_publico.detenido
                        ,hora_del_detenido = varexpediente_ministerio_publico.hora_del_detenido
                        ,hora_puesto_a_disposicion = varexpediente_ministerio_publico.hora_puesto_a_disposicion
                        ,estatus = varexpediente_ministerio_publico.estatus
                        ,Titulo_del_Hecho = varexpediente_ministerio_publico.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.Fecha_del_Hecho)) ? DateTime.ParseExact(varexpediente_ministerio_publico.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Narrativa_Breve_de_los_Hechos = varexpediente_ministerio_publico.Narrativa_Breve_de_los_Hechos
                        ,Hora_Aproximada_del_Hecho = varexpediente_ministerio_publico.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = varexpediente_ministerio_publico.Lugar_de_los_Hechos
                        ,PaisH = varexpediente_ministerio_publico.PaisH
                        ,Estado = varexpediente_ministerio_publico.Estado
                        ,Municipio_Hechos = varexpediente_ministerio_publico.Municipio_Hechos
                        ,Poblacion = varexpediente_ministerio_publico.Poblacion
                        ,ColoniaH = varexpediente_ministerio_publico.ColoniaH
                        ,CalleH = varexpediente_ministerio_publico.CalleH
                        ,Numero_InteriorH = varexpediente_ministerio_publico.Numero_InteriorH
                        ,Numero_ExteriorH = varexpediente_ministerio_publico.Numero_ExteriorH
                        ,Codigo_PostalH = varexpediente_ministerio_publico.Codigo_PostalH
                        ,Entre_Calle = varexpediente_ministerio_publico.Entre_Calle
                        ,Y_Calle = varexpediente_ministerio_publico.Y_Calle
                        ,LongitudH = varexpediente_ministerio_publico.LongitudH
                        ,LatitudH = varexpediente_ministerio_publico.LatitudH
                        ,tipo_de_acuerdo = varexpediente_ministerio_publico.tipo_de_acuerdo
                        ,fecha_de_inicio_de_acuerdo = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_inicio_de_acuerdo)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_inicio_de_acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,fecha_de_cumplimiento = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_cumplimiento)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_cumplimiento = varexpediente_ministerio_publico.hora_de_cumplimiento
                        ,domicilio_para_el_cumplimiento = varexpediente_ministerio_publico.domicilio_para_el_cumplimiento
                        ,monto_de_reparacion_de_danos = varexpediente_ministerio_publico.monto_de_reparacion_de_danos
                        ,parcialidades = varexpediente_ministerio_publico.parcialidades
                        ,periodicidad = varexpediente_ministerio_publico.periodicidad
                        ,acepta_acuerdo = varexpediente_ministerio_publico.acepta_acuerdo
                        ,motivo_de_rechazo_de_acuerdo = varexpediente_ministerio_publico.motivo_de_rechazo_de_acuerdo
                        ,fecha_de_cierre = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_cierre)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_cierre = varexpediente_ministerio_publico.hora_de_cierre
                        ,Usuario_que_Cierra = varexpediente_ministerio_publico.Usuario_que_Cierra
                        ,tipo_de_cierre = varexpediente_ministerio_publico.tipo_de_cierre
                        ,comentarios_de_cierre = varexpediente_ministerio_publico.comentarios_de_cierre

                    };

                    result = !IsNew ?
                        _Iexpediente_ministerio_publicoApiConsumer.Update(expediente_ministerio_publicoInfo, null, null).Resource.ToString() :
                         _Iexpediente_ministerio_publicoApiConsumer.Insert(expediente_ministerio_publicoInfo, null, null).Resource.ToString();
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
        public bool Copydetalle_de_observaciones_mpi(int MasterId, int referenceId, List<detalle_de_observaciones_mpiGridModelPost> detalle_de_observaciones_mpiItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

                var detalle_de_observaciones_mpiData = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll(1, int.MaxValue, "detalle_de_observaciones_mpi.expediente_inicial=" + referenceId,"").Resource;
                if (detalle_de_observaciones_mpiData == null || detalle_de_observaciones_mpiData.detalle_de_observaciones_mpis.Count == 0)
                    return true;

                var result = true;

                detalle_de_observaciones_mpiGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var vardetalle_de_observaciones_mpi in detalle_de_observaciones_mpiData.detalle_de_observaciones_mpis)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    detalle_de_observaciones_mpi detalle_de_observaciones_mpi1 = vardetalle_de_observaciones_mpi;

                    if (detalle_de_observaciones_mpiItems != null && detalle_de_observaciones_mpiItems.Any(m => m.clave == detalle_de_observaciones_mpi1.clave))
                    {
                        modelDataToChange = detalle_de_observaciones_mpiItems.FirstOrDefault(m => m.clave == detalle_de_observaciones_mpi1.clave);
                    }
                    //Chaning Id Value
                    vardetalle_de_observaciones_mpi.expediente_inicial = MasterId;
                    var insertId = _Idetalle_de_observaciones_mpiApiConsumer.Insert(vardetalle_de_observaciones_mpi,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.clave = insertId;

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
        public ActionResult Postdetalle_de_observaciones_mpi(List<detalle_de_observaciones_mpiGridModelPost> detalle_de_observaciones_mpiItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!Copydetalle_de_observaciones_mpi(MasterId, referenceId, detalle_de_observaciones_mpiItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (detalle_de_observaciones_mpiItems != null && detalle_de_observaciones_mpiItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var detalle_de_observaciones_mpiItem in detalle_de_observaciones_mpiItems)
                    {






                        //Removal Request
                        if (detalle_de_observaciones_mpiItem.Removed)
                        {
                            result = result && _Idetalle_de_observaciones_mpiApiConsumer.Delete(detalle_de_observaciones_mpiItem.clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							detalle_de_observaciones_mpiItem.clave = 0;

                        var detalle_de_observaciones_mpiData = new detalle_de_observaciones_mpi
                        {
                            expediente_inicial = MasterId
                            ,clave = detalle_de_observaciones_mpiItem.clave
                            ,observaciones = detalle_de_observaciones_mpiItem.observaciones
                            ,fecha = (detalle_de_observaciones_mpiItem.fecha!= null) ? DateTime.ParseExact(detalle_de_observaciones_mpiItem.fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,hora = detalle_de_observaciones_mpiItem.hora
                            ,usuario_que_realiza_observacion = (Convert.ToInt32(detalle_de_observaciones_mpiItem.usuario_que_realiza_observacion) == 0 ? (Int32?)null : Convert.ToInt32(detalle_de_observaciones_mpiItem.usuario_que_realiza_observacion))

                        };

                        var resultId = detalle_de_observaciones_mpiItem.clave > 0
                           ? _Idetalle_de_observaciones_mpiApiConsumer.Update(detalle_de_observaciones_mpiData,null,null).Resource
                           : _Idetalle_de_observaciones_mpiApiConsumer.Insert(detalle_de_observaciones_mpiData,null,null).Resource;

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
        public ActionResult Getdetalle_de_observaciones_mpi_Spartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Name= CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of expediente_ministerio_publico script
        /// </summary>
        /// <param name="oexpediente_ministerio_publicoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew expediente_ministerio_publicoModuleAttributeList)
        {
            for (int i = 0; i < expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strexpediente_ministerio_publicoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/expediente_ministerio_publico.js")))
            {
                strexpediente_ministerio_publicoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change expediente_ministerio_publico element attributes
            string userChangeJson = jsSerialize.Serialize(expediente_ministerio_publicoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strexpediente_ministerio_publicoScript.IndexOf("inpuElementArray");
            string splittedString = strexpediente_ministerio_publicoScript.Substring(indexOfArray, strexpediente_ministerio_publicoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strexpediente_ministerio_publicoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strexpediente_ministerio_publicoScript.Substring(indexOfArrayHistory, strexpediente_ministerio_publicoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strexpediente_ministerio_publicoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strexpediente_ministerio_publicoScript.Substring(endIndexOfMainElement + indexOfArray, strexpediente_ministerio_publicoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in expediente_ministerio_publicoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/expediente_ministerio_publico.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/expediente_ministerio_publico.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/expediente_ministerio_publico.js")))
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
        public ActionResult expediente_ministerio_publicoPropertyBag()
        {
            return PartialView("expediente_ministerio_publicoPropertyBag", "expediente_ministerio_publico");
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
        public ActionResult Adddetalle_de_observaciones_mpi(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../detalle_de_observaciones_mpi/Adddetalle_de_observaciones_mpi");
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
                var whereClauseFormat = "Object = 45468 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And expediente_ministerio_publico.clave= " + RecordId;
                            var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new expediente_ministerio_publicoPropertyMapper());
			
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
                    (expediente_ministerio_publicoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            expediente_ministerio_publicoPropertyMapper oexpediente_ministerio_publicoPropertyMapper = new expediente_ministerio_publicoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oexpediente_ministerio_publicoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.expediente_ministerio_publicos == null)
                result.expediente_ministerio_publicos = new List<expediente_ministerio_publico>();

            var data = result.expediente_ministerio_publicos.Select(m => new expediente_ministerio_publicoGridModel
            {
                clave = m.clave
                        ,fecha_de_registro = (m.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,hora_de_registro = m.hora_de_registro
                        ,usuario_que_registraName = CultureHelper.GetTraduction(m.usuario_que_registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_que_registra_Spartan_User.Name
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,MP_AsignadoName = CultureHelper.GetTraduction(m.MP_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Asignado_Spartan_User.Name
                        ,unidadDescripcion = CultureHelper.GetTraduction(m.unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,nuat = m.nuat
			,nic = m.nic
                        ,detenidoDescripcion = CultureHelper.GetTraduction(m.detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.detenido_A_Tiempo.Descripcion
			,hora_del_detenido = m.hora_del_detenido
			,hora_puesto_a_disposicion = m.hora_puesto_a_disposicion
                        ,estatusdescripcion = CultureHelper.GetTraduction(m.estatus_estatus_mpi.clave.ToString(), "descripcion") ?? (string)m.estatus_estatus_mpi.descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
                        ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(m.tipo_de_acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,fecha_de_inicio_de_acuerdo = (m.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(m.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,fecha_de_cumplimiento = (m.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cumplimiento = m.hora_de_cumplimiento
			,domicilio_para_el_cumplimiento = m.domicilio_para_el_cumplimiento
			,monto_de_reparacion_de_danos = m.monto_de_reparacion_de_danos
			,parcialidades = m.parcialidades
                        ,periodicidadDescripcion = CultureHelper.GetTraduction(m.periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.periodicidad_Periodicidad.Descripcion
                        ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(m.acepta_acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.acepta_acuerdo_A_Tiempo.Descripcion
			,motivo_de_rechazo_de_acuerdo = m.motivo_de_rechazo_de_acuerdo
                        ,fecha_de_cierre = (m.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cierre = m.hora_de_cierre
                        ,Usuario_que_CierraName = CultureHelper.GetTraduction(m.Usuario_que_Cierra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Cierra_Spartan_User.Name
                        ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(m.tipo_de_cierre_tipo_de_cierre.clave.ToString(), "descripcion") ?? (string)m.tipo_de_cierre_tipo_de_cierre.descripcion
			,comentarios_de_cierre = m.comentarios_de_cierre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45468, arrayColumnsVisible), "expediente_ministerio_publicoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45468, arrayColumnsVisible), "expediente_ministerio_publicoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45468, arrayColumnsVisible), "expediente_ministerio_publicoList_" + DateTime.Now.ToString());
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

            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new expediente_ministerio_publicoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (expediente_ministerio_publicoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            expediente_ministerio_publicoPropertyMapper oexpediente_ministerio_publicoPropertyMapper = new expediente_ministerio_publicoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oexpediente_ministerio_publicoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.expediente_ministerio_publicos == null)
                result.expediente_ministerio_publicos = new List<expediente_ministerio_publico>();

            var data = result.expediente_ministerio_publicos.Select(m => new expediente_ministerio_publicoGridModel
            {
                clave = m.clave
                        ,fecha_de_registro = (m.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,hora_de_registro = m.hora_de_registro
                        ,usuario_que_registraName = CultureHelper.GetTraduction(m.usuario_que_registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_que_registra_Spartan_User.Name
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,MP_AsignadoName = CultureHelper.GetTraduction(m.MP_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Asignado_Spartan_User.Name
                        ,unidadDescripcion = CultureHelper.GetTraduction(m.unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.unidad_Unidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,nuat = m.nuat
			,nic = m.nic
                        ,detenidoDescripcion = CultureHelper.GetTraduction(m.detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.detenido_A_Tiempo.Descripcion
			,hora_del_detenido = m.hora_del_detenido
			,hora_puesto_a_disposicion = m.hora_puesto_a_disposicion
                        ,estatusdescripcion = CultureHelper.GetTraduction(m.estatus_estatus_mpi.clave.ToString(), "descripcion") ?? (string)m.estatus_estatus_mpi.descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH
                        ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(m.tipo_de_acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,fecha_de_inicio_de_acuerdo = (m.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(m.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,fecha_de_cumplimiento = (m.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cumplimiento = m.hora_de_cumplimiento
			,domicilio_para_el_cumplimiento = m.domicilio_para_el_cumplimiento
			,monto_de_reparacion_de_danos = m.monto_de_reparacion_de_danos
			,parcialidades = m.parcialidades
                        ,periodicidadDescripcion = CultureHelper.GetTraduction(m.periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.periodicidad_Periodicidad.Descripcion
                        ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(m.acepta_acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.acepta_acuerdo_A_Tiempo.Descripcion
			,motivo_de_rechazo_de_acuerdo = m.motivo_de_rechazo_de_acuerdo
                        ,fecha_de_cierre = (m.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cierre = m.hora_de_cierre
                        ,Usuario_que_CierraName = CultureHelper.GetTraduction(m.Usuario_que_Cierra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Cierra_Spartan_User.Name
                        ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(m.tipo_de_cierre_tipo_de_cierre.clave.ToString(), "descripcion") ?? (string)m.tipo_de_cierre_tipo_de_cierre.descripcion
			,comentarios_de_cierre = m.comentarios_de_cierre

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
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_del_Caso(expediente_ministerio_publico_Datos_del_CasoModel varexpediente_ministerio_publico)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var expediente_ministerio_publico_Datos_del_CasoInfo = new expediente_ministerio_publico_Datos_del_Caso
                {
                    clave = varexpediente_ministerio_publico.clave
                                            ,fecha_de_registro = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_registro)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_registro = varexpediente_ministerio_publico.hora_de_registro
                        ,usuario_que_registra = varexpediente_ministerio_publico.usuario_que_registra
                        ,Tipo_de_Denuncia = varexpediente_ministerio_publico.Tipo_de_Denuncia
                        ,MP_Asignado = varexpediente_ministerio_publico.MP_Asignado
                        ,unidad = varexpediente_ministerio_publico.unidad
                        ,Municipio = varexpediente_ministerio_publico.Municipio
                        ,Region = varexpediente_ministerio_publico.Region
                        ,nuat = varexpediente_ministerio_publico.nuat
                        ,nic = varexpediente_ministerio_publico.nic
                        ,detenido = varexpediente_ministerio_publico.detenido
                        ,hora_del_detenido = varexpediente_ministerio_publico.hora_del_detenido
                        ,hora_puesto_a_disposicion = varexpediente_ministerio_publico.hora_puesto_a_disposicion
                        ,estatus = varexpediente_ministerio_publico.estatus
                    
                };

                result = _Iexpediente_ministerio_publicoApiConsumer.Update_Datos_del_Caso(expediente_ministerio_publico_Datos_del_CasoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Caso(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _Iexpediente_ministerio_publicoApiConsumer.Get_Datos_del_Caso(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_detalle_de_observaciones_mpi;
                var detalle_de_observaciones_mpiData = Getdetalle_de_observaciones_mpiData(Id.ToString(), 0, Int16.MaxValue, out RowCount_detalle_de_observaciones_mpi);

                var result = new expediente_ministerio_publico_Datos_del_CasoModel
                {
                    clave = m.clave
                        ,fecha_de_registro = (m.fecha_de_registro == null ? string.Empty : Convert.ToDateTime(m.fecha_de_registro).ToString(ConfigurationProperty.DateFormat))
			,hora_de_registro = m.hora_de_registro
                        ,usuario_que_registra = m.usuario_que_registra
                        ,usuario_que_registraName = CultureHelper.GetTraduction(m.usuario_que_registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.usuario_que_registra_Spartan_User.Name
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,MP_Asignado = m.MP_Asignado
                        ,MP_AsignadoName = CultureHelper.GetTraduction(m.MP_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Asignado_Spartan_User.Name
                        ,unidad = m.unidad
                        ,unidadDescripcion = CultureHelper.GetTraduction(m.unidad_Unidad.Clave.ToString(), "Unidad") ?? (string)m.unidad_Unidad.Descripcion
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
			,nuat = m.nuat
			,nic = m.nic
                        ,detenido = m.detenido
                        ,detenidoDescripcion = CultureHelper.GetTraduction(m.detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.detenido_A_Tiempo.Descripcion
			,hora_del_detenido = m.hora_del_detenido
			,hora_puesto_a_disposicion = m.hora_puesto_a_disposicion
                        ,estatus = m.estatus
                        ,estatusdescripcion = CultureHelper.GetTraduction(m.estatus_estatus_mpi.clave.ToString(), "descripcion") ?? (string)m.estatus_estatus_mpi.descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,observaciones = detalle_de_observaciones_mpiData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Hechos(expediente_ministerio_publico_HechosModel varexpediente_ministerio_publico)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var expediente_ministerio_publico_HechosInfo = new expediente_ministerio_publico_Hechos
                {
                    clave = varexpediente_ministerio_publico.clave
                                            ,Titulo_del_Hecho = varexpediente_ministerio_publico.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.Fecha_del_Hecho)) ? DateTime.ParseExact(varexpediente_ministerio_publico.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Narrativa_Breve_de_los_Hechos = varexpediente_ministerio_publico.Narrativa_Breve_de_los_Hechos
                        ,Hora_Aproximada_del_Hecho = varexpediente_ministerio_publico.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = varexpediente_ministerio_publico.Lugar_de_los_Hechos
                        ,PaisH = varexpediente_ministerio_publico.PaisH
                        ,Estado = varexpediente_ministerio_publico.Estado
                        ,Municipio_Hechos = varexpediente_ministerio_publico.Municipio_Hechos
                        ,Poblacion = varexpediente_ministerio_publico.Poblacion
                        ,ColoniaH = varexpediente_ministerio_publico.ColoniaH
                        ,CalleH = varexpediente_ministerio_publico.CalleH
                        ,Numero_InteriorH = varexpediente_ministerio_publico.Numero_InteriorH
                        ,Numero_ExteriorH = varexpediente_ministerio_publico.Numero_ExteriorH
                        ,Codigo_PostalH = varexpediente_ministerio_publico.Codigo_PostalH
                        ,Entre_Calle = varexpediente_ministerio_publico.Entre_Calle
                        ,Y_Calle = varexpediente_ministerio_publico.Y_Calle
                        ,LongitudH = varexpediente_ministerio_publico.LongitudH
                        ,LatitudH = varexpediente_ministerio_publico.LatitudH
                    
                };

                result = _Iexpediente_ministerio_publicoApiConsumer.Update_Hechos(expediente_ministerio_publico_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _Iexpediente_ministerio_publicoApiConsumer.Get_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_detalle_de_observaciones_mpi;
                var detalle_de_observaciones_mpiData = Getdetalle_de_observaciones_mpiData(Id.ToString(), 0, Int16.MaxValue, out RowCount_detalle_de_observaciones_mpi);

                var result = new expediente_ministerio_publico_HechosModel
                {
                    clave = m.clave
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = m.Lugar_de_los_Hechos
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,PaisH = m.PaisH
                        ,PaisHNombre = CultureHelper.GetTraduction(m.PaisH_Pais.Clave.ToString(), "Pais") ?? (string)m.PaisH_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio_Hechos = m.Municipio_Hechos
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaH = m.ColoniaH
                        ,ColoniaHNombre = CultureHelper.GetTraduction(m.ColoniaH_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaH_Colonia.Nombre
			,CalleH = m.CalleH
			,Numero_InteriorH = m.Numero_InteriorH
			,Numero_ExteriorH = m.Numero_ExteriorH
			,Codigo_PostalH = m.Codigo_PostalH
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,LongitudH = m.LongitudH
			,LatitudH = m.LatitudH

                    
                };
				var resultData = new
                {
                    data = result
                    ,observaciones = detalle_de_observaciones_mpiData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_del_Acuerdo(expediente_ministerio_publico_Datos_del_AcuerdoModel varexpediente_ministerio_publico)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var expediente_ministerio_publico_Datos_del_AcuerdoInfo = new expediente_ministerio_publico_Datos_del_Acuerdo
                {
                    clave = varexpediente_ministerio_publico.clave
                                            ,tipo_de_acuerdo = varexpediente_ministerio_publico.tipo_de_acuerdo
                        ,fecha_de_inicio_de_acuerdo = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_inicio_de_acuerdo)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_inicio_de_acuerdo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,fecha_de_cumplimiento = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_cumplimiento)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_cumplimiento = varexpediente_ministerio_publico.hora_de_cumplimiento
                        ,domicilio_para_el_cumplimiento = varexpediente_ministerio_publico.domicilio_para_el_cumplimiento
                        ,monto_de_reparacion_de_danos = varexpediente_ministerio_publico.monto_de_reparacion_de_danos
                        ,parcialidades = varexpediente_ministerio_publico.parcialidades
                        ,periodicidad = varexpediente_ministerio_publico.periodicidad
                        ,acepta_acuerdo = varexpediente_ministerio_publico.acepta_acuerdo
                        ,motivo_de_rechazo_de_acuerdo = varexpediente_ministerio_publico.motivo_de_rechazo_de_acuerdo
                    
                };

                result = _Iexpediente_ministerio_publicoApiConsumer.Update_Datos_del_Acuerdo(expediente_ministerio_publico_Datos_del_AcuerdoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Acuerdo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _Iexpediente_ministerio_publicoApiConsumer.Get_Datos_del_Acuerdo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_detalle_de_observaciones_mpi;
                var detalle_de_observaciones_mpiData = Getdetalle_de_observaciones_mpiData(Id.ToString(), 0, Int16.MaxValue, out RowCount_detalle_de_observaciones_mpi);

                var result = new expediente_ministerio_publico_Datos_del_AcuerdoModel
                {
                    clave = m.clave
                        ,tipo_de_acuerdo = m.tipo_de_acuerdo
                        ,tipo_de_acuerdoDescripcion = CultureHelper.GetTraduction(m.tipo_de_acuerdo_Tipo_de_Acuerdo.Clave.ToString(), "Descripcion") ?? (string)m.tipo_de_acuerdo_Tipo_de_Acuerdo.Descripcion
                        ,fecha_de_inicio_de_acuerdo = (m.fecha_de_inicio_de_acuerdo == null ? string.Empty : Convert.ToDateTime(m.fecha_de_inicio_de_acuerdo).ToString(ConfigurationProperty.DateFormat))
                        ,fecha_de_cumplimiento = (m.fecha_de_cumplimiento == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cumplimiento).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cumplimiento = m.hora_de_cumplimiento
			,domicilio_para_el_cumplimiento = m.domicilio_para_el_cumplimiento
			,monto_de_reparacion_de_danos = m.monto_de_reparacion_de_danos
			,parcialidades = m.parcialidades
                        ,periodicidad = m.periodicidad
                        ,periodicidadDescripcion = CultureHelper.GetTraduction(m.periodicidad_Periodicidad.Clave.ToString(), "Descripcion") ?? (string)m.periodicidad_Periodicidad.Descripcion
                        ,acepta_acuerdo = m.acepta_acuerdo
                        ,acepta_acuerdoDescripcion = CultureHelper.GetTraduction(m.acepta_acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.acepta_acuerdo_A_Tiempo.Descripcion
			,motivo_de_rechazo_de_acuerdo = m.motivo_de_rechazo_de_acuerdo

                    
                };
				var resultData = new
                {
                    data = result
                    ,observaciones = detalle_de_observaciones_mpiData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion_o_Dictaminacion(expediente_ministerio_publico_Resolucion_o_DictaminacionModel varexpediente_ministerio_publico)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var expediente_ministerio_publico_Resolucion_o_DictaminacionInfo = new expediente_ministerio_publico_Resolucion_o_Dictaminacion
                {
                    clave = varexpediente_ministerio_publico.clave
                                            ,fecha_de_cierre = (!String.IsNullOrEmpty(varexpediente_ministerio_publico.fecha_de_cierre)) ? DateTime.ParseExact(varexpediente_ministerio_publico.fecha_de_cierre, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora_de_cierre = varexpediente_ministerio_publico.hora_de_cierre
                        ,Usuario_que_Cierra = varexpediente_ministerio_publico.Usuario_que_Cierra
                        ,tipo_de_cierre = varexpediente_ministerio_publico.tipo_de_cierre
                        ,comentarios_de_cierre = varexpediente_ministerio_publico.comentarios_de_cierre
                    
                };

                result = _Iexpediente_ministerio_publicoApiConsumer.Update_Resolucion_o_Dictaminacion(expediente_ministerio_publico_Resolucion_o_DictaminacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion_o_Dictaminacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _Iexpediente_ministerio_publicoApiConsumer.Get_Resolucion_o_Dictaminacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_detalle_de_observaciones_mpi;
                var detalle_de_observaciones_mpiData = Getdetalle_de_observaciones_mpiData(Id.ToString(), 0, Int16.MaxValue, out RowCount_detalle_de_observaciones_mpi);

                var result = new expediente_ministerio_publico_Resolucion_o_DictaminacionModel
                {
                    clave = m.clave
                        ,fecha_de_cierre = (m.fecha_de_cierre == null ? string.Empty : Convert.ToDateTime(m.fecha_de_cierre).ToString(ConfigurationProperty.DateFormat))
			,hora_de_cierre = m.hora_de_cierre
                        ,Usuario_que_Cierra = m.Usuario_que_Cierra
                        ,Usuario_que_CierraName = CultureHelper.GetTraduction(m.Usuario_que_Cierra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Cierra_Spartan_User.Name
                        ,tipo_de_cierre = m.tipo_de_cierre
                        ,tipo_de_cierredescripcion = CultureHelper.GetTraduction(m.tipo_de_cierre_tipo_de_cierre.clave.ToString(), "descripcion") ?? (string)m.tipo_de_cierre_tipo_de_cierre.descripcion
			,comentarios_de_cierre = m.comentarios_de_cierre

                    
                };
				var resultData = new
                {
                    data = result
                    ,observaciones = detalle_de_observaciones_mpiData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

