using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Indigena
{
    public interface IIndigenaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Indigena.Indigena> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Indigena.IndigenaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData IndigenaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData IndigenaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData IndigenaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Indigena.IndigenaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Indigena.Indigena>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Indigena.Indigena_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Indigena.Indigena_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

