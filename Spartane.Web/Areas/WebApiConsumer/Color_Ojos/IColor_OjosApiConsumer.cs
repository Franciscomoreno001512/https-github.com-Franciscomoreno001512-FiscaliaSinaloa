using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Color_Ojos
{
    public interface IColor_OjosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_Ojos.Color_Ojos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_Ojos.Color_OjosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData Color_OjosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Color_Ojos.Color_OjosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Color_Ojos.Color_Ojos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Color_Ojos.Color_Ojos_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

