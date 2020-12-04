using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Plazo_Constitucional
{
    public interface IPlazo_ConstitucionalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Plazo_Constitucional.Plazo_ConstitucionalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional entity, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional entity, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Plazo_Constitucional.Plazo_ConstitucionalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

