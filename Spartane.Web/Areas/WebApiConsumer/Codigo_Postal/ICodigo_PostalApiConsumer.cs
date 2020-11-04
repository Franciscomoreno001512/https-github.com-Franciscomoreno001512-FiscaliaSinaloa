using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Codigo_Postal
{
    public interface ICodigo_PostalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Codigo_Postal.Codigo_PostalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal entity, Spartane.Core.Domain.User.GlobalData Codigo_PostalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Codigo_Postal.Codigo_PostalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Codigo_Postal.Codigo_Postal_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Codigo_Postal.Codigo_Postal_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

