using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Correccion_de_Error_en_Estatus
{
    public interface ICorreccion_de_Error_en_EstatusApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

