using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial
{
    public interface IExpediente_InicialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_del_Caso(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Caso entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key);

		ApiResponse<int> Update_Datos_de_la_Victima(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Victima entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Victima> Get_Datos_de_la_Victima(string Key);

		ApiResponse<int> Update_Datos_del_Imputado(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Imputado entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Imputado> Get_Datos_del_Imputado(string Key);

		ApiResponse<int> Update_Datos_del_Delito(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Delito entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Delito> Get_Datos_del_Delito(string Key);

		ApiResponse<int> Update_Datos_de_los_Hechos(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key);

		ApiResponse<int> Update_Datos_de_la_Persona_Moral(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Persona_Moral entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Persona_Moral> Get_Datos_de_la_Persona_Moral(string Key);

		ApiResponse<int> Update_Servicios_de_Apoyo(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Servicios_de_Apoyo entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Servicios_de_Apoyo> Get_Servicios_de_Apoyo(string Key);

		ApiResponse<int> Update_Datos_del_Testigo(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Testigo entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Testigo> Get_Datos_del_Testigo(string Key);

		ApiResponse<int> Update_Asignar_MP(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Asignar_MP entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Asignar_MP> Get_Asignar_MP(string Key);

		ApiResponse<int> Update_Diligencias(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Diligencias entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Diligencias> Get_Diligencias(string Key);

		ApiResponse<int> Update_IPH(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_IPH entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_IPH> Get_IPH(string Key);

		ApiResponse<int> Update_Agenda_de_Audiencias_y_Citatorios(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios> Get_Agenda_de_Audiencias_y_Citatorios(string Key);

		ApiResponse<int> Update_Audiencias_Citatorios(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Audiencias_Citatorios entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Audiencias_Citatorios> Get_Audiencias_Citatorios(string Key);

		ApiResponse<int> Update_Documentos(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Documentos entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Documentos> Get_Documentos(string Key);

		ApiResponse<int> Update_Bitacora_de_Coincidencias(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Bitacora_de_Coincidencias entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key);

		ApiResponse<int> Update_Indicios(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Indicios entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Indicios> Get_Indicios(string Key);

		ApiResponse<int> Update_Canalizar(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Canalizar entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Canalizar> Get_Canalizar(string Key);

		ApiResponse<int> Update_Datos_del_Acuerdo(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Acuerdo entity);
		ApiResponse<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Acuerdo> Get_Datos_del_Acuerdo(string Key);


    }
}

