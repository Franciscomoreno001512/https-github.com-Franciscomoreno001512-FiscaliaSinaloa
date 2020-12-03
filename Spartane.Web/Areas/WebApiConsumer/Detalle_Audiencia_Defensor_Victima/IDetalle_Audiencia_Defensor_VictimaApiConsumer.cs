using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Victima
{
    public interface IDetalle_Audiencia_Defensor_VictimaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_VictimaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_VictimaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

