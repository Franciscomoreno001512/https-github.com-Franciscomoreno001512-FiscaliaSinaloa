using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Senas_Particulares
{
    public interface ISenas_ParticularesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Senas_Particulares.Senas_ParticularesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Senas_Particulares.Senas_ParticularesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

