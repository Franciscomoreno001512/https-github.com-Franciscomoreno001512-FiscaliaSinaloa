using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Area_Pericial
{
    public interface IArea_PericialApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Area_Pericial.Area_Pericial> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Area_Pericial.Area_PericialPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Area_Pericial.Area_Pericial entity, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Area_Pericial.Area_Pericial entity, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Area_Pericial.Area_PericialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Area_Pericial.Area_Pericial_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Area_Pericial.Area_Pericial_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

