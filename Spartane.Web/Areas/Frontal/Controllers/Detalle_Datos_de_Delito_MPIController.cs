using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Datos_de_Delito_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_de_Delito_MPI;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

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
    public class Detalle_Datos_de_Delito_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_Datos_de_Delito_MPIService service = null;
        private IDetalle_Datos_de_Delito_MPIApiConsumer _IDetalle_Datos_de_Delito_MPIApiConsumer;
        private ITipo_DelitoApiConsumer _ITipo_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ICircunstancia_del_DelitoApiConsumer _ICircunstancia_del_DelitoApiConsumer;
        private IForma_Comision_DelitoApiConsumer _IForma_Comision_DelitoApiConsumer;
        private IForma_Accion_DelitoApiConsumer _IForma_Accion_DelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;
        private IElementos_Comision_DelitoApiConsumer _IElementos_Comision_DelitoApiConsumer;
        private ICircunstancia_VehiculoApiConsumer _ICircunstancia_VehiculoApiConsumer;
        private IEspecifica_VehiculoApiConsumer _IEspecifica_VehiculoApiConsumer;
        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IAseguradora_de_VehiculoApiConsumer _IAseguradora_de_VehiculoApiConsumer;
        private IServicio_del_VehiculoApiConsumer _IServicio_del_VehiculoApiConsumer;
        private IProcedencia_del_VehiculoApiConsumer _IProcedencia_del_VehiculoApiConsumer;
        private IModalidad_de_Robo_de_VehiculoApiConsumer _IModalidad_de_Robo_de_VehiculoApiConsumer;
        private ICircunstancia_DefuncionApiConsumer _ICircunstancia_DefuncionApiConsumer;
        private IConsecuencia_DefuncionApiConsumer _IConsecuencia_DefuncionApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IZonaApiConsumer _IZonaApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Datos_de_Delito_MPIController(IDetalle_Datos_de_Delito_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Datos_de_Delito_MPIApiConsumer Detalle_Datos_de_Delito_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_DelitoApiConsumer Tipo_DelitoApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ICircunstancia_del_DelitoApiConsumer Circunstancia_del_DelitoApiConsumer , IForma_Comision_DelitoApiConsumer Forma_Comision_DelitoApiConsumer , IForma_Accion_DelitoApiConsumer Forma_Accion_DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer , IElementos_Comision_DelitoApiConsumer Elementos_Comision_DelitoApiConsumer , ICircunstancia_VehiculoApiConsumer Circunstancia_VehiculoApiConsumer
, IEspecifica_VehiculoApiConsumer Especifica_VehiculoApiConsumer
, IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer
, ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer
, ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer
, IColor_VehiculoApiConsumer Color_VehiculoApiConsumer
, IEstadoApiConsumer EstadoApiConsumer
, IAseguradora_de_VehiculoApiConsumer Aseguradora_de_VehiculoApiConsumer
, IServicio_del_VehiculoApiConsumer Servicio_del_VehiculoApiConsumer
, IProcedencia_del_VehiculoApiConsumer Procedencia_del_VehiculoApiConsumer
, IModalidad_de_Robo_de_VehiculoApiConsumer Modalidad_de_Robo_de_VehiculoApiConsumer
, ICircunstancia_DefuncionApiConsumer Circunstancia_DefuncionApiConsumer
, IConsecuencia_DefuncionApiConsumer Consecuencia_DefuncionApiConsumer
, ILugar_TipoApiConsumer Lugar_TipoApiConsumer
, IPaisApiConsumer PaisApiConsumer
, IMunicipioApiConsumer MunicipioApiConsumer
, IZonaApiConsumer ZonaApiConsumer
, IColoniaApiConsumer ColoniaApiConsumer
)
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Datos_de_Delito_MPIApiConsumer = Detalle_Datos_de_Delito_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_DelitoApiConsumer = Tipo_DelitoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ICircunstancia_del_DelitoApiConsumer = Circunstancia_del_DelitoApiConsumer;
            this._IForma_Comision_DelitoApiConsumer = Forma_Comision_DelitoApiConsumer;
            this._IForma_Accion_DelitoApiConsumer = Forma_Accion_DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;
            this._IElementos_Comision_DelitoApiConsumer = Elementos_Comision_DelitoApiConsumer;
            this._ICircunstancia_VehiculoApiConsumer = Circunstancia_VehiculoApiConsumer;
            this._IEspecifica_VehiculoApiConsumer = Especifica_VehiculoApiConsumer;
            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IAseguradora_de_VehiculoApiConsumer = Aseguradora_de_VehiculoApiConsumer;
            this._IServicio_del_VehiculoApiConsumer = Servicio_del_VehiculoApiConsumer;
            this._IProcedencia_del_VehiculoApiConsumer = Procedencia_del_VehiculoApiConsumer;
            this._IModalidad_de_Robo_de_VehiculoApiConsumer = Modalidad_de_Robo_de_VehiculoApiConsumer;
            this._ICircunstancia_DefuncionApiConsumer = Circunstancia_DefuncionApiConsumer;
            this._IConsecuencia_DefuncionApiConsumer = Consecuencia_DefuncionApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Datos_de_Delito_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45118, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45118);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Datos_de_Delito_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45118, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45118);
            ViewBag.Permission = permission;
            var varDetalle_Datos_de_Delito_MPI = new Detalle_Datos_de_Delito_MPIModel();
			
            ViewBag.ObjectId = "45118";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Datos_de_Delito_MPIData = _IDetalle_Datos_de_Delito_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Datos_de_Delito_MPIs[0];
                if (Detalle_Datos_de_Delito_MPIData == null)
                    return HttpNotFound();

                varDetalle_Datos_de_Delito_MPI = new Detalle_Datos_de_Delito_MPIModel
                {
                    Clave = (int)Detalle_Datos_de_Delito_MPIData.Clave
                    ,Tipo_de_Delito = Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito), "Tipo_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito_Tipo_Delito.Descripcion
                    ,Grupo_Delito = Detalle_Datos_de_Delito_MPIData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Grupo_Delito), "Grupo_del_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_Datos_de_Delito_MPIData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Delito), "Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Delito_Delito.Descripcion
                    ,Circunstancia_Delito = Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito
                    ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito), "Circunstancia_del_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                    ,Delito_Principal = Detalle_Datos_de_Delito_MPIData.Delito_Principal.GetValueOrDefault()
                    ,Forma_Comision_Delito = Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = Detalle_Datos_de_Delito_MPIData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Modalidad_Delito), "Modalidad_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Monto = Detalle_Datos_de_Delito_MPIData.Monto
                    ,Violencia_de_Genero = Detalle_Datos_de_Delito_MPIData.Violencia_de_Genero.GetValueOrDefault()
                    ,Robo_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Levantamiento_de_Cadaver = Detalle_Datos_de_Delito_MPIData.Levantamiento_de_Cadaver.GetValueOrDefault()
                    ,Circunstancia_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo
                    ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Clase = Detalle_Datos_de_Delito_MPIData.Clase
                    ,ClaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Clase), "Especifica_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Clase_Especifica_Vehiculo.Descripcion
                    ,Vehiculo_Robado = Detalle_Datos_de_Delito_MPIData.Vehiculo_Robado.GetValueOrDefault()
                    ,Marca = Detalle_Datos_de_Delito_MPIData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_Datos_de_Delito_MPIData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_Datos_de_Delito_MPIData.Modelo
                    ,Color = Detalle_Datos_de_Delito_MPIData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Color), "Color_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_Datos_de_Delito_MPIData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Motor = Detalle_Datos_de_Delito_MPIData.Motor
                    ,Serie = Detalle_Datos_de_Delito_MPIData.Serie
                    ,El_Vehiculo_esta_Asegurado = Detalle_Datos_de_Delito_MPIData.El_Vehiculo_esta_Asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Tipo_de_Servicio = Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_Datos_de_Delito_MPIData.Ruta_del_Servicio_Publico
                    ,Procedencia = Detalle_Datos_de_Delito_MPIData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Mercancia = Detalle_Datos_de_Delito_MPIData.Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_Datos_de_Delito_MPIData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_la_Carga = Detalle_Datos_de_Delito_MPIData.Monto_de_la_Carga
                    ,Senas_Particulares = Detalle_Datos_de_Delito_MPIData.Senas_Particulares
                    ,Modalidad_del_Robo = Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Causa_de_Muerte = Detalle_Datos_de_Delito_MPIData.Causa_de_Muerte
                    ,Circunstancia_Defuncion = Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (Detalle_Datos_de_Delito_MPIData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(Detalle_Datos_de_Delito_MPIData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = Detalle_Datos_de_Delito_MPIData.Hora_Levantamiento
                    ,Tipo_de_Lugar_del_Hecho = Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Pais = Detalle_Datos_de_Delito_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Pais), "Pais") ??  (string)Detalle_Datos_de_Delito_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_Datos_de_Delito_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Estado), "Estado") ??  (string)Detalle_Datos_de_Delito_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_Datos_de_Delito_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Municipio), "Municipio") ??  (string)Detalle_Datos_de_Delito_MPIData.Municipio_Municipio.Nombre
                    ,Zona = Detalle_Datos_de_Delito_MPIData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Zona), "Zona") ??  (string)Detalle_Datos_de_Delito_MPIData.Zona_Zona.Descripcion
                    ,Colonia = Detalle_Datos_de_Delito_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Colonia), "Colonia") ??  (string)Detalle_Datos_de_Delito_MPIData.Colonia_Colonia.Nombre
                    ,Colonia_no_Catalogada = Detalle_Datos_de_Delito_MPIData.Colonia_no_Catalogada
                    ,Numero_Exterior = Detalle_Datos_de_Delito_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_Datos_de_Delito_MPIData.Numero_Interior
                    ,Necropsia = Detalle_Datos_de_Delito_MPIData.Necropsia
                    ,Cronotanatodiagnostico = Detalle_Datos_de_Delito_MPIData.Cronotanatodiagnostico
                    ,Ruta = Detalle_Datos_de_Delito_MPIData.Ruta
                    ,Estado_del_Conductor = Detalle_Datos_de_Delito_MPIData.Estado_del_Conductor.GetValueOrDefault()
                    ,Codigo_Postal = Detalle_Datos_de_Delito_MPIData.Codigo_Postal

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_Origen_de_las_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_Origen_de_las_Placas != null && Estados_Estado_de_Origen_de_las_Placas.Resource != null)
                ViewBag.Estados_Estado_de_Origen_de_las_Placas = Estados_Estado_de_Origen_de_las_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Datos_de_Delito_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Datos_de_Delito_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45118);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Datos_de_Delito_MPIModel varDetalle_Datos_de_Delito_MPI= new Detalle_Datos_de_Delito_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_Datos_de_Delito_MPIsData = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_Datos_de_Delito_MPI.Clave=" + id, "").Resource.Detalle_Datos_de_Delito_MPIs;
				
				if (Detalle_Datos_de_Delito_MPIsData != null && Detalle_Datos_de_Delito_MPIsData.Count > 0)
                {
					var Detalle_Datos_de_Delito_MPIData = Detalle_Datos_de_Delito_MPIsData.First();
					varDetalle_Datos_de_Delito_MPI= new Detalle_Datos_de_Delito_MPIModel
					{
						Clave  = Detalle_Datos_de_Delito_MPIData.Clave 
	                    ,Tipo_de_Delito = Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito), "Tipo_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Delito_Tipo_Delito.Descripcion
                    ,Grupo_Delito = Detalle_Datos_de_Delito_MPIData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Grupo_Delito), "Grupo_del_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_Datos_de_Delito_MPIData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Delito), "Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Delito_Delito.Descripcion
                    ,Circunstancia_Delito = Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito
                    ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito), "Circunstancia_del_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                    ,Delito_Principal = Detalle_Datos_de_Delito_MPIData.Delito_Principal.GetValueOrDefault()
                    ,Forma_Comision_Delito = Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = Detalle_Datos_de_Delito_MPIData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Modalidad_Delito), "Modalidad_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_Datos_de_Delito_MPIData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Monto = Detalle_Datos_de_Delito_MPIData.Monto
                    ,Violencia_de_Genero = Detalle_Datos_de_Delito_MPIData.Violencia_de_Genero.GetValueOrDefault()
                    ,Robo_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Levantamiento_de_Cadaver = Detalle_Datos_de_Delito_MPIData.Levantamiento_de_Cadaver.GetValueOrDefault()
                    ,Circunstancia_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo
                    ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Clase = Detalle_Datos_de_Delito_MPIData.Clase
                    ,ClaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Clase), "Especifica_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Clase_Especifica_Vehiculo.Descripcion
                    ,Vehiculo_Robado = Detalle_Datos_de_Delito_MPIData.Vehiculo_Robado.GetValueOrDefault()
                    ,Marca = Detalle_Datos_de_Delito_MPIData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_Datos_de_Delito_MPIData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_Datos_de_Delito_MPIData.Modelo
                    ,Color = Detalle_Datos_de_Delito_MPIData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Color), "Color_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_Datos_de_Delito_MPIData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_Datos_de_Delito_MPIData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Motor = Detalle_Datos_de_Delito_MPIData.Motor
                    ,Serie = Detalle_Datos_de_Delito_MPIData.Serie
                    ,El_Vehiculo_esta_Asegurado = Detalle_Datos_de_Delito_MPIData.El_Vehiculo_esta_Asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Tipo_de_Servicio = Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_Datos_de_Delito_MPIData.Ruta_del_Servicio_Publico
                    ,Procedencia = Detalle_Datos_de_Delito_MPIData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Mercancia = Detalle_Datos_de_Delito_MPIData.Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_Datos_de_Delito_MPIData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_la_Carga = Detalle_Datos_de_Delito_MPIData.Monto_de_la_Carga
                    ,Senas_Particulares = Detalle_Datos_de_Delito_MPIData.Senas_Particulares
                    ,Modalidad_del_Robo = Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)Detalle_Datos_de_Delito_MPIData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Causa_de_Muerte = Detalle_Datos_de_Delito_MPIData.Causa_de_Muerte
                    ,Circunstancia_Defuncion = Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)Detalle_Datos_de_Delito_MPIData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)Detalle_Datos_de_Delito_MPIData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (Detalle_Datos_de_Delito_MPIData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(Detalle_Datos_de_Delito_MPIData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = Detalle_Datos_de_Delito_MPIData.Hora_Levantamiento
                    ,Tipo_de_Lugar_del_Hecho = Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_Datos_de_Delito_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Pais = Detalle_Datos_de_Delito_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Pais), "Pais") ??  (string)Detalle_Datos_de_Delito_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_Datos_de_Delito_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Estado), "Estado") ??  (string)Detalle_Datos_de_Delito_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_Datos_de_Delito_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Municipio), "Municipio") ??  (string)Detalle_Datos_de_Delito_MPIData.Municipio_Municipio.Nombre
                    ,Zona = Detalle_Datos_de_Delito_MPIData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Zona), "Zona") ??  (string)Detalle_Datos_de_Delito_MPIData.Zona_Zona.Descripcion
                    ,Colonia = Detalle_Datos_de_Delito_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_de_Delito_MPIData.Colonia), "Colonia") ??  (string)Detalle_Datos_de_Delito_MPIData.Colonia_Colonia.Nombre
                    ,Colonia_no_Catalogada = Detalle_Datos_de_Delito_MPIData.Colonia_no_Catalogada
                    ,Numero_Exterior = Detalle_Datos_de_Delito_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_Datos_de_Delito_MPIData.Numero_Interior
                    ,Necropsia = Detalle_Datos_de_Delito_MPIData.Necropsia
                    ,Cronotanatodiagnostico = Detalle_Datos_de_Delito_MPIData.Cronotanatodiagnostico
                    ,Ruta = Detalle_Datos_de_Delito_MPIData.Ruta
                    ,Estado_del_Conductor = Detalle_Datos_de_Delito_MPIData.Estado_del_Conductor.GetValueOrDefault()
                    ,Codigo_Postal = Detalle_Datos_de_Delito_MPIData.Codigo_Postal

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_de_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_de_Delito != null && Tipo_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_de_Delito = Tipo_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia_Delito = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia_Delito != null && Circunstancia_del_Delitos_Circunstancia_Delito.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia_Delito = Circunstancia_del_Delitos_Circunstancia_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase != null && Especifica_Vehiculos_Clase.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase = Especifica_Vehiculos_Clase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_Origen_de_las_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_Origen_de_las_Placas != null && Estados_Estado_de_Origen_de_las_Placas.Resource != null)
                ViewBag.Estados_Estado_de_Origen_de_las_Placas = Estados_Estado_de_Origen_de_las_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora != null && Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora = Aseguradora_de_Vehiculos_Nombre_de_la_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Datos_de_Delito_MPI", varDetalle_Datos_de_Delito_MPI);
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
        public ActionResult GetTipo_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGrupo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Accion_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Accion_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetElementos_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IElementos_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEspecifica_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecifica_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSub_Marca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISub_Marca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetAseguradora_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguradora_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetServicio_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicio_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetProcedencia_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_de_Robo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetConsecuencia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
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
        public ActionResult GetZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IZonaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion")?? m.Descripcion,
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_de_Delito_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_de_Delito_MPIs == null)
                result.Detalle_Datos_de_Delito_MPIs = new List<Detalle_Datos_de_Delito_MPI>();

            return Json(new
            {
                data = result.Detalle_Datos_de_Delito_MPIs.Select(m => new Detalle_Datos_de_Delito_MPIGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,Circunstancia_DelitoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Delito_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,Violencia_de_Genero = m.Violencia_de_Genero
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                        ,Circunstancia_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,ClaseDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Vehiculo.Descripcion
			,Vehiculo_Robado = m.Vehiculo_Robado
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
			,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Mercancia = m.Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
			,Causa_de_Muerte = m.Causa_de_Muerte
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_del_Conductor = m.Estado_del_Conductor
			,Codigo_Postal = m.Codigo_Postal

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
                _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Datos_de_Delito_MPI varDetalle_Datos_de_Delito_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Datos_de_Delito_MPIModel varDetalle_Datos_de_Delito_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Datos_de_Delito_MPIInfo = new Detalle_Datos_de_Delito_MPI
                    {
                        Clave = varDetalle_Datos_de_Delito_MPI.Clave
                        ,Tipo_de_Delito = varDetalle_Datos_de_Delito_MPI.Tipo_de_Delito
                        ,Grupo_Delito = varDetalle_Datos_de_Delito_MPI.Grupo_Delito
                        ,Delito = varDetalle_Datos_de_Delito_MPI.Delito
                        ,Circunstancia_Delito = varDetalle_Datos_de_Delito_MPI.Circunstancia_Delito
                        ,Delito_Principal = varDetalle_Datos_de_Delito_MPI.Delito_Principal
                        ,Forma_Comision_Delito = varDetalle_Datos_de_Delito_MPI.Forma_Comision_Delito
                        ,Forma_Accion_Delito = varDetalle_Datos_de_Delito_MPI.Forma_Accion_Delito
                        ,Modalidad_Delito = varDetalle_Datos_de_Delito_MPI.Modalidad_Delito
                        ,Elementos_Comision_Delito = varDetalle_Datos_de_Delito_MPI.Elementos_Comision_Delito
                        ,Monto = varDetalle_Datos_de_Delito_MPI.Monto
                        ,Violencia_de_Genero = varDetalle_Datos_de_Delito_MPI.Violencia_de_Genero
                        ,Robo_de_Vehiculo = varDetalle_Datos_de_Delito_MPI.Robo_de_Vehiculo
                        ,Levantamiento_de_Cadaver = varDetalle_Datos_de_Delito_MPI.Levantamiento_de_Cadaver
                        ,Circunstancia_de_Vehiculo = varDetalle_Datos_de_Delito_MPI.Circunstancia_de_Vehiculo
                        ,Clase = varDetalle_Datos_de_Delito_MPI.Clase
                        ,Vehiculo_Robado = varDetalle_Datos_de_Delito_MPI.Vehiculo_Robado
                        ,Marca = varDetalle_Datos_de_Delito_MPI.Marca
                        ,Sub_Marca = varDetalle_Datos_de_Delito_MPI.Sub_Marca
                        ,Tipo_de_Vehiculo = varDetalle_Datos_de_Delito_MPI.Tipo_de_Vehiculo
                        ,Modelo = varDetalle_Datos_de_Delito_MPI.Modelo
                        ,Color = varDetalle_Datos_de_Delito_MPI.Color
                        ,Placas = varDetalle_Datos_de_Delito_MPI.Placas
                        ,Estado_de_Origen_de_las_Placas = varDetalle_Datos_de_Delito_MPI.Estado_de_Origen_de_las_Placas
                        ,Motor = varDetalle_Datos_de_Delito_MPI.Motor
                        ,Serie = varDetalle_Datos_de_Delito_MPI.Serie
                        ,El_Vehiculo_esta_Asegurado = varDetalle_Datos_de_Delito_MPI.El_Vehiculo_esta_Asegurado
                        ,Nombre_de_la_Aseguradora = varDetalle_Datos_de_Delito_MPI.Nombre_de_la_Aseguradora
                        ,Tipo_de_Servicio = varDetalle_Datos_de_Delito_MPI.Tipo_de_Servicio
                        ,Ruta_del_Servicio_Publico = varDetalle_Datos_de_Delito_MPI.Ruta_del_Servicio_Publico
                        ,Procedencia = varDetalle_Datos_de_Delito_MPI.Procedencia
                        ,Mercancia = varDetalle_Datos_de_Delito_MPI.Mercancia
                        ,Descripcion_de_lo_que_Transportaba = varDetalle_Datos_de_Delito_MPI.Descripcion_de_lo_que_Transportaba
                        ,Monto_de_la_Carga = varDetalle_Datos_de_Delito_MPI.Monto_de_la_Carga
                        ,Senas_Particulares = varDetalle_Datos_de_Delito_MPI.Senas_Particulares
                        ,Modalidad_del_Robo = varDetalle_Datos_de_Delito_MPI.Modalidad_del_Robo
                        ,Causa_de_Muerte = varDetalle_Datos_de_Delito_MPI.Causa_de_Muerte
                        ,Circunstancia_Defuncion = varDetalle_Datos_de_Delito_MPI.Circunstancia_Defuncion
                        ,Consecuencia_Defuncion = varDetalle_Datos_de_Delito_MPI.Consecuencia_Defuncion
                        ,Fecha_Levantamiento = (!String.IsNullOrEmpty(varDetalle_Datos_de_Delito_MPI.Fecha_Levantamiento)) ? DateTime.ParseExact(varDetalle_Datos_de_Delito_MPI.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Levantamiento = varDetalle_Datos_de_Delito_MPI.Hora_Levantamiento
                        ,Tipo_de_Lugar_del_Hecho = varDetalle_Datos_de_Delito_MPI.Tipo_de_Lugar_del_Hecho
                        ,Pais = varDetalle_Datos_de_Delito_MPI.Pais
                        ,Estado = varDetalle_Datos_de_Delito_MPI.Estado
                        ,Municipio = varDetalle_Datos_de_Delito_MPI.Municipio
                        ,Zona = varDetalle_Datos_de_Delito_MPI.Zona
                        ,Colonia = varDetalle_Datos_de_Delito_MPI.Colonia
                        ,Colonia_no_Catalogada = varDetalle_Datos_de_Delito_MPI.Colonia_no_Catalogada
                        ,Numero_Exterior = varDetalle_Datos_de_Delito_MPI.Numero_Exterior
                        ,Numero_Interior = varDetalle_Datos_de_Delito_MPI.Numero_Interior
                        ,Necropsia = varDetalle_Datos_de_Delito_MPI.Necropsia
                        ,Cronotanatodiagnostico = varDetalle_Datos_de_Delito_MPI.Cronotanatodiagnostico
                        ,Ruta = varDetalle_Datos_de_Delito_MPI.Ruta
                        ,Estado_del_Conductor = varDetalle_Datos_de_Delito_MPI.Estado_del_Conductor
                        ,Codigo_Postal = varDetalle_Datos_de_Delito_MPI.Codigo_Postal

                    };

                    result = !IsNew ?
                        _IDetalle_Datos_de_Delito_MPIApiConsumer.Update(Detalle_Datos_de_Delito_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_Datos_de_Delito_MPIApiConsumer.Insert(Detalle_Datos_de_Delito_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Datos_de_Delito_MPI script
        /// </summary>
        /// <param name="oDetalle_Datos_de_Delito_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Datos_de_Delito_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Datos_de_Delito_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_de_Delito_MPI.js")))
            {
                strDetalle_Datos_de_Delito_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Datos_de_Delito_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Datos_de_Delito_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Datos_de_Delito_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Datos_de_Delito_MPIScript.Substring(indexOfArray, strDetalle_Datos_de_Delito_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Datos_de_Delito_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Datos_de_Delito_MPIScript.Substring(indexOfArrayHistory, strDetalle_Datos_de_Delito_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Datos_de_Delito_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Datos_de_Delito_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Datos_de_Delito_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Datos_de_Delito_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Datos_de_Delito_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Datos_de_Delito_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Datos_de_Delito_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Datos_de_Delito_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_de_Delito_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_de_Delito_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_de_Delito_MPI.js")))
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
        public ActionResult Detalle_Datos_de_Delito_MPIPropertyBag()
        {
            return PartialView("Detalle_Datos_de_Delito_MPIPropertyBag", "Detalle_Datos_de_Delito_MPI");
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

            _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_de_Delito_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_de_Delito_MPIs == null)
                result.Detalle_Datos_de_Delito_MPIs = new List<Detalle_Datos_de_Delito_MPI>();

            var data = result.Detalle_Datos_de_Delito_MPIs.Select(m => new Detalle_Datos_de_Delito_MPIGridModel
            {
                Clave = m.Clave
                ,Tipo_de_DelitoDescripcion = (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                ,Grupo_DelitoDescripcion = (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,Circunstancia_DelitoDescripcion = (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                ,Delito_Principal = m.Delito_Principal
                ,Forma_Comision_DelitoDescripcion = (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                ,Forma_Accion_DelitoDescripcion = (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                ,Modalidad_DelitoDescripcion = (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                ,Elementos_Comision_DelitoDescripcion = (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                ,Monto = m.Monto
                ,Violencia_de_Genero = m.Violencia_de_Genero
                ,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                ,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                ,Circunstancia_de_VehiculoDescripcion = (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                ,ClaseDescripcion = (string)m.Clase_Especifica_Vehiculo.Descripcion
                ,Vehiculo_Robado = m.Vehiculo_Robado
                ,MarcaDescripcion = (string)m.Marca_Marca_del_Vehiculo.Descripcion
                ,Sub_MarcaDescripcion = (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                ,Tipo_de_VehiculoDescripcion = (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                ,Modelo = m.Modelo
                ,ColorDescripcion = (string)m.Color_Color_Vehiculo.Descripcion
                ,Placas = m.Placas
                ,Estado_de_Origen_de_las_PlacasNombre = (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
                ,Motor = m.Motor
                ,Serie = m.Serie
                ,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                ,Nombre_de_la_AseguradoraDescripcion = (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                ,Tipo_de_ServicioDescripcion = (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                ,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                ,ProcedenciaDescripcion = (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
                ,Mercancia = m.Mercancia
                ,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
                ,Monto_de_la_Carga = m.Monto_de_la_Carga
                ,Senas_Particulares = m.Senas_Particulares
                ,Modalidad_del_RoboDescripcion = (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                ,Causa_de_Muerte = m.Causa_de_Muerte
                ,Circunstancia_DefuncionDescripcion = (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                ,Consecuencia_DefuncionDescripcion = (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Levantamiento = m.Hora_Levantamiento
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ZonaDescripcion = (string)m.Zona_Zona.Descripcion
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Necropsia = m.Necropsia
                ,Cronotanatodiagnostico = m.Cronotanatodiagnostico
                ,Ruta = m.Ruta
                ,Estado_del_Conductor = m.Estado_del_Conductor
                ,Codigo_Postal = m.Codigo_Postal

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Datos_de_Delito_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Datos_de_Delito_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_Datos_de_Delito_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_de_Delito_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Datos_de_Delito_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_de_Delito_MPIs == null)
                result.Detalle_Datos_de_Delito_MPIs = new List<Detalle_Datos_de_Delito_MPI>();

            var data = result.Detalle_Datos_de_Delito_MPIs.Select(m => new Detalle_Datos_de_Delito_MPIGridModel
            {
                Clave = m.Clave
                ,Tipo_de_DelitoDescripcion = (string)m.Tipo_de_Delito_Tipo_Delito.Descripcion
                ,Grupo_DelitoDescripcion = (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,Circunstancia_DelitoDescripcion = (string)m.Circunstancia_Delito_Circunstancia_del_Delito.Descripcion
                ,Delito_Principal = m.Delito_Principal
                ,Forma_Comision_DelitoDescripcion = (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                ,Forma_Accion_DelitoDescripcion = (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                ,Modalidad_DelitoDescripcion = (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                ,Elementos_Comision_DelitoDescripcion = (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                ,Monto = m.Monto
                ,Violencia_de_Genero = m.Violencia_de_Genero
                ,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                ,Levantamiento_de_Cadaver = m.Levantamiento_de_Cadaver
                ,Circunstancia_de_VehiculoDescripcion = (string)m.Circunstancia_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                ,ClaseDescripcion = (string)m.Clase_Especifica_Vehiculo.Descripcion
                ,Vehiculo_Robado = m.Vehiculo_Robado
                ,MarcaDescripcion = (string)m.Marca_Marca_del_Vehiculo.Descripcion
                ,Sub_MarcaDescripcion = (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                ,Tipo_de_VehiculoDescripcion = (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                ,Modelo = m.Modelo
                ,ColorDescripcion = (string)m.Color_Color_Vehiculo.Descripcion
                ,Placas = m.Placas
                ,Estado_de_Origen_de_las_PlacasNombre = (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
                ,Motor = m.Motor
                ,Serie = m.Serie
                ,El_Vehiculo_esta_Asegurado = m.El_Vehiculo_esta_Asegurado
                ,Nombre_de_la_AseguradoraDescripcion = (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                ,Tipo_de_ServicioDescripcion = (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                ,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
                ,ProcedenciaDescripcion = (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
                ,Mercancia = m.Mercancia
                ,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
                ,Monto_de_la_Carga = m.Monto_de_la_Carga
                ,Senas_Particulares = m.Senas_Particulares
                ,Modalidad_del_RoboDescripcion = (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                ,Causa_de_Muerte = m.Causa_de_Muerte
                ,Circunstancia_DefuncionDescripcion = (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                ,Consecuencia_DefuncionDescripcion = (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Levantamiento = m.Hora_Levantamiento
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ZonaDescripcion = (string)m.Zona_Zona.Descripcion
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Necropsia = m.Necropsia
                ,Cronotanatodiagnostico = m.Cronotanatodiagnostico
                ,Ruta = m.Ruta
                ,Estado_del_Conductor = m.Estado_del_Conductor
                ,Codigo_Postal = m.Codigo_Postal

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
