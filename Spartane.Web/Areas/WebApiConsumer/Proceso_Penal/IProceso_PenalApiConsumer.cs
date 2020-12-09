using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Proceso_Penal
{
    public interface IProceso_PenalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_PenalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_PenalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Fase_Complementaria(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Complementaria entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Complementaria> Get_Fase_Complementaria(string Key);

		ApiResponse<int> Update_Fase_Escrita(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Escrita entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Escrita> Get_Fase_Escrita(string Key);

		ApiResponse<int> Update_Audiencia_Intermedia(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Audiencia_Intermedia entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Audiencia_Intermedia> Get_Audiencia_Intermedia(string Key);

		ApiResponse<int> Update_Juicio_Oral(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Juicio_Oral entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Juicio_Oral> Get_Juicio_Oral(string Key);

		ApiResponse<int> Update_Resolucion(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Resolucion entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Resolucion> Get_Resolucion(string Key);

		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

