using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares
{
    public interface IMedidas_CautelaresApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Medidas_Cautelares.Medidas_CautelaresPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Medidas_Cautelares.Medidas_CautelaresPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

