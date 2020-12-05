using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resultado_de_Audiencia_Intermedia
{
    public interface IResultado_de_Audiencia_IntermediaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_IntermediaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Audiencia_IntermediaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_IntermediaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Resultado_de_Audiencia_Intermedia.Resultado_de_Audiencia_Intermedia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

