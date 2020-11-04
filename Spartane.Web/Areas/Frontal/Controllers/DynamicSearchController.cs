using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Operations_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Record_Detail_Management;
using Spartane.Web.Areas.WebApiConsumer.SpartaneQuery;
using Spartane.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class DynamicSearchController : Controller
    {
        private ISpartan_Record_Detail_ManagementApiConsumer _service;
        private ITokenManager _tokenManager = null;
        private ISpartaneQueryApiConsumer _ISpartaneQueryApiConsumer;
        private ISpartan_RDM_Operations_DetailApiConsumer _ISpartan_RDM_Operations_DetailApiConsumer;
        private ISpartan_ObjectApiConsumer _ISpartan_ObjectApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;

        //public static int ID { get; set; }
        public static string WhereWF { get; set; }

        public DynamicSearchController(ITokenManager tokenManager, ISpartan_ObjectApiConsumer Spartan_ObjectApiConsumer, ISpartan_Record_Detail_ManagementApiConsumer service, ISpartaneQueryApiConsumer SpartaneQueryApiConsumer, ISpartan_RDM_Operations_DetailApiConsumer Spartan_RDM_Operations_DetailApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer)
        {
            _service = service;
            _tokenManager = tokenManager;
            _ISpartaneQueryApiConsumer = SpartaneQueryApiConsumer;
            _ISpartan_RDM_Operations_DetailApiConsumer = Spartan_RDM_Operations_DetailApiConsumer;
            _ISpartan_ObjectApiConsumer = Spartan_ObjectApiConsumer;
            _ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
        }

        // GET: Frontal/ManualTest
        public ActionResult Index(int id, int? wf, int? p)
        {

            //  ID = id;  ////fjmore borre esto porque cuando multiples clientes entran se planchan la variable de sesion y toma la ultima y eso descompone todo
            _tokenManager.GenerateToken();
            _service.SetAuthHeader(_tokenManager.Token);
            var management = _service.GetByKey(id, false).Resource;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, Convert.ToInt32(management.Object), 1);
            ViewBag.PermissionEdit = permission.Edit;
            Session["Management"] = management;
            ViewBag.UrlImage = ConfigurationManager.AppSettings["BaseUrl"];
            if (wf != null)
            {
                _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);
                //Obtener Where de la fase del workflow
                var filtro = _ISpartaneQueryApiConsumer.ExecuteQuery("exec uspGetFiltroWF " + wf.ToString() + "," + p.ToString()).Resource;
                WhereWF = filtro.ToString();

                //Obtener Nombre de la fase del workflow
                filtro = _ISpartaneQueryApiConsumer.ExecuteQuery("exec uspGetNombreFaseWF " + wf.ToString() + "," + p.ToString()).Resource;
                ViewBag.WorkFlow = filtro.ToString();
               
                GetResultSearchTable(null);
            }
            ViewBag.idTablero = id;
            return View();
        }

        public JsonResult GetSearchFields(int idTablero)
        {
            //_tokenManager.GenerateToken();
            //_service.SetAuthHeader(_tokenManager.Token);
            //string delitoValues = "<option value=\"-1\"> Seleccione Delito</option><option value=\"1\"> Robo</option>";
            //delitoValues += "<option value=\"2\">Contra la Salud</option>";
            //delitoValues += "<option value=\"3\"> Lesiones</option>";
            //List<ModelSearchFields> fields = new List<ModelSearchFields>();
            //fields.Add(new ModelSearchFields { Label = "Folio", FieldDB = "Folio_interno", TypeControl = "text" });
            //fields.Add(new ModelSearchFields { Label = "Fecha de Solicitud", FieldDB = "Fecha_de_Solicitud", TypeControl = "date" });
            //fields.Add(new ModelSearchFields { Label = "Nombre", FieldDB = "Nombre_Completo", TypeControl = "text" });
            //fields.Add(new ModelSearchFields { Label = "Delito", FieldDB = "Delito", TypeControl = "combobox", Values = delitoValues });
            //return Json(fields, JsonRequestBehavior.AllowGet);

            _tokenManager.GenerateToken();
            _service.SetAuthHeader(_tokenManager.Token);
            string fields = _ISpartaneQueryApiConsumer.ExecuteRawQuery(String.Format("spSelAllDynamic_Search {0}", idTablero)).Resource;
            List<ModelSearchFields> fieldsHTMl = GetFieldsHTML(fields);
            return Json(fieldsHTMl, JsonRequestBehavior.AllowGet);
        }

        private List<ModelSearchFields> GetFieldsHTML(string fields)
        {
            List<ModelSearchFields> modelSearchFields = JsonConvert.DeserializeObject<List<ModelSearchFields>>(fields);

            foreach (ModelSearchFields item in modelSearchFields)
            {
                if (item.TypeControl == "combobox")
                {
                    string items = _ISpartaneQueryApiConsumer.ExecuteRawQuery(String.Format("{0}", item.SelAllName)).Resource;
                    JArray jArray = JArray.Parse(items);
                    item.Values = "<option value=\"-1\">Seleccione " + item.SelAllName.Replace("sp_SelAll", "") + "</option>" + " " +
                                    jArray.Select(x => " <option value=\"" + (string)x["Clave"] + "\">" +
                                    (string)x["Descripcion"] + "</option>").Aggregate((i, j) => i + " " + j).ToString();
                }
            }
            return modelSearchFields;
        }

        public JsonResult EdtihRow(int folio)
        {
            _tokenManager.GenerateToken();
            Spartan_Record_Detail_Management srDetail = (Spartan_Record_Detail_Management)Session["Management"];
            //string viewEdit = _ISpartaneQueryApiConsumer.ExecuteRawQuery(String.Format("sp_GetURL_DynamicSearch {0}", srDetail.Object)).Resource;
            //viewEdit = ((dynamic)Newtonsoft.Json.JsonConvert.DeserializeObject(viewEdit))[0]["URL"].ToString();

            string df = srDetail.Object.ToString();

            List<string> result = new List<string>()
            {
                srDetail.Object.ToString(),
                folio.ToString()
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetResultSearchTable(List<ModelSearchFields> resultsSearch)
        {
            string where = "";
            if (resultsSearch != null)
            {
                foreach (var item in resultsSearch)
                {

                    if (!String.IsNullOrEmpty(item.Value))
                    {

                        switch (item.TypeControl)
                        {
                            case "text":
                                if (where != "")
                                    where += " AND ";
                                where += item.FieldDB + " LIKE '%" + item.Value + "%'";
                                break;
                            case "number":
                                if (where != "")
                                    where += " AND ";
                                where += item.FieldDB + "=" + item.Value;
                                break;
                            case "date":
                                if (where != "")
                                    where += " AND ";
                                if (item.FieldDB.Contains("_From") || item.FieldDB.Contains("_Desde"))
                                {
                                    where += item.FieldDB.Replace("_Desde", "") + ">='" + DateTime.Parse(item.Value).ToString("yyyyMMdd") + "'";
                                }
                                else
                                {
                                    where += item.FieldDB.Replace("_Hasta", "") + "<='" + DateTime.Parse(item.Value).ToString("yyyyMMdd") + "'";
                                }

                                break;
                            case "combobox":
                                if (item.Value != "-1")
                                {
                                    if (where != "")
                                        where += " AND ";
                                    where += item.FieldDB + "=" + item.Value;
                                }
                                break;
                        }
                    }
                }
            }
            //WHERE DE WORKFLOW
            if (WhereWF != null)
            {
                if (WhereWF != "")
                {
                    if (where != "")
                        where += " AND ";
                    where += WhereWF;
                }
            }

            //EJECUTO QUERY
            _tokenManager.GenerateToken();
            //_service.SetAuthHeader(_tokenManager.Token);
            _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);
            var management = (Spartan_Record_Detail_Management)Session["Management"];// _service.GetByKey(ID, false).Resource;
            if (where != "")
            {
                where = " WHERE " + where;
            }
            where = Helper.ReplaceGlobalQuery(where);
            string queryResult = management.Search_Result_Query + where;
            var dataTableJson = _ISpartaneQueryApiConsumer.ExecuteRawQuery(HttpUtility.UrlEncode(queryResult)).Resource;
            if (String.IsNullOrEmpty(dataTableJson) || dataTableJson == "[]")
            {
                ModelResultsFields resultError = new ModelResultsFields();
                resultError.Columns = null;
                resultError.ValuesColumns = null;

                return Json(resultError, JsonRequestBehavior.AllowGet);
            }
            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            dynamic obj = serializer.Deserialize(dataTableJson, typeof(object));

            List<ModelResultsValueFields> valuesColumns = new List<ModelResultsValueFields>();
            var columnsDictionary = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(dataTableJson);
            List<string> columns = new List<string>();
            foreach (var dict in columnsDictionary[0])
            {
                columns.Add(dict.Key);
            }
            foreach (var item in obj)
            {
                var row = new List<string>();
                foreach (var col in columns)
                {
                    row.Add(item[col] == null ? "" : item[col].ToString());
                }
                var values = new ModelResultsValueFields();
                values.Values = row;
                valuesColumns.Add(values);
            }

            ModelResultsFields result = new ModelResultsFields();
            result.Columns = columns;
            result.ValuesColumns = valuesColumns;
            Session["SearchResult"] = result;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDataToShow(string id, int idTablero)
        {
            Session["SpartanOperationId"] = id;
            _tokenManager.GenerateToken();
            ModelSearchResult resultFinal = new ModelSearchResult();
            List<ModelSearchFields> resultFinalFields = new List<ModelSearchFields>();
            var searchResult = (ModelResultsFields)Session["SearchResult"];
            var search = searchResult.ValuesColumns.Where(x => x.Values[0] == id).FirstOrDefault();
            var management = (Spartan_Record_Detail_Management)Session["Management"];
            string label = management.Reference_Label;
            string labelValue = search.Values[1];
            resultFinal.Label = label;
            resultFinal.LabelValue = labelValue;
            string query = management.Query_Data_Detail;
            query = query.Replace("@@LLAVE@@", id);
            _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);
            _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ISpartaneQueryApiConsumer.ExecuteRawQuery(HttpUtility.UrlEncode(query)).Resource;
            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
            dynamic obj = serializer.Deserialize(result, typeof(object));

            var columnsDictionary = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(result);
            List<string> columns = new List<string>();
            foreach (var dict in columnsDictionary[0])
            {
                columns.Add(dict.Key);
            }
            foreach (var item in obj)
            {
                var row = new List<string>();
                foreach (var col in columns)
                {
                    resultFinalFields.Add(new ModelSearchFields { Label = col, Value = item[col] == null ? "" : item[col].ToString(), Group = "" });
                }
            }
            resultFinal.Data = resultFinalFields;

            /*GRILLA DETALLE*/
            List<ResultGeneralDetail> resultDetail = new List<ResultGeneralDetail>();
            List<ModelSearchFields> resultFinalFieldsDetail = new List<ModelSearchFields>();
            ResultGeneralDetail aux;
            var details = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(0, 9999, "Spartan_RDM_Operations_Detail.Record_Detail_Management=" + idTablero.ToString(), "").Resource;
            if (details.RowCount > 0)
            {
                foreach (var item in details.Spartan_RDM_Operations_Details)
                {
                    aux = new ResultGeneralDetail();
                    aux.ObjectId = item.Object_Name.Value;
                    var counter = _ISpartaneQueryApiConsumer.ExecuteQuery(item.Count_Query.Replace("@@LLAVE@@", id)).Resource;
                    aux.Counter = Convert.ToInt32(counter);
                    aux.Label = item.Object_Label;

                    //Buscamos el nombre del archivo
                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    var fileInfo = _ISpartane_FileApiConsumer.GetByKey(item.Icono).Resource;
                    //preparamos la url del archivo fisico
                    aux.Icon = ConfigurationManager.AppSettings["BaseUrl"] + "/api/Spartan_File/Files/" + item.Icono + "/" + fileInfo.Description;

                    aux.Details = new ModelResultsFields();
                    string queryDataDetail = item.Query_Data.Replace("@@LLAVE@@", id);
                    var resultQueryDetail = _ISpartaneQueryApiConsumer.ExecuteRawQuery(HttpUtility.UrlEncode(queryDataDetail)).Resource;
                    if (resultQueryDetail != null && resultQueryDetail != "[]")
                    {
                        serializer = new JavaScriptSerializer();
                        serializer.RegisterConverters(new[] { new DynamicJsonConverter() });
                        dynamic objDetail = serializer.Deserialize(resultQueryDetail, typeof(object));

                        List<ModelResultsValueFields> valuesColumnsDetail = new List<ModelResultsValueFields>();
                        var columnsDictionaryDetail = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(resultQueryDetail);
                        List<string> columnsDetail = new List<string>();
                        foreach (var dict in columnsDictionaryDetail[0])
                        {
                            columnsDetail.Add(dict.Key);
                        }
                        aux.Details.Columns = columnsDetail;
                        aux.Details.ValuesColumns = new List<ModelResultsValueFields>();
                        foreach (var itemDetail in objDetail)
                        {
                            var row = new List<string>();
                            foreach (var col in columnsDetail)
                            {
                                row.Add(itemDetail[col] == null ? "" : itemDetail[col].ToString());
                            }
                            var values = new ModelResultsValueFields();
                            values.Values = row;
                            valuesColumnsDetail.Add(values);
                        }
                        ModelResultsFields resultDetailNew = new ModelResultsFields();
                        resultDetailNew.Columns = columnsDetail;
                        resultDetailNew.ValuesColumns = valuesColumnsDetail;
                        aux.Details = resultDetailNew;
                    }
                    resultDetail.Add(aux);
                }
                Session["DataByTab"] = resultDetail;
            }
            resultFinal.Details = resultDetail;
            return Json(resultFinal, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDetalleBySearchResult(string idTab)
        {
            List<ResultGeneralDetail> allData = (List<ResultGeneralDetail>)Session["DataByTab"];
            var data = allData.Where(x => x.Label == idTab).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCatalog(int objectId, string detalle)
        {

            string nameObject = "";
            _tokenManager.GenerateToken();
            _ISpartan_ObjectApiConsumer.SetAuthHeader(_tokenManager.Token);
            var objectsData = _ISpartan_ObjectApiConsumer.ListaSelAll(0, 10, "Spartan_Object.Object_Id=" + objectId, "").Resource;
            if (objectsData.RowCount > 0)
            {
                nameObject = objectsData.Spartan_Objects[0].URL;
            }

            Session["SpartanRDMId"] = ((Spartan_Record_Detail_Management)Session["Management"]).Process_Id;
            Session["SpartanRDMProcess"] = detalle;

            return Json(nameObject, JsonRequestBehavior.AllowGet);
        }

    }



    public class ModelSearchResult
    {
        public List<ModelSearchFields> Data { get; set; }
        public string Label { get; set; }
        public string LabelValue { get; set; }
        public List<ResultGeneralDetail> Details { get; set; }
    }

    public class ModelSearchFields
    {
        public string Label { get; set; }
        public string TypeControl { get; set; }
        public string FieldDB { get; set; }
        public string Value { get; set; }
        public string Values { get; set; }
        public string Group { get; set; }
        public string SelAllName { get; set; }
    }

    public class ModelResultsFields
    {
        public List<string> Columns { get; set; }
        public List<ModelResultsValueFields> ValuesColumns { get; set; }
    }

    public class ModelResultsValueFields
    {
        public List<string> Values { get; set; }
    }

    public class ResultGeneralDetail
    {
        public ModelResultsFields Details { get; set; }
        public int Counter { get; set; }
        public string Label { get; set; }
        public string Icon { get; set; }
        public int ObjectId { get; set; }
    }

}