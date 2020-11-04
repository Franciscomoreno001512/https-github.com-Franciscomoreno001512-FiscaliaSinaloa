using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.A_Tiempo
{
    public interface IA_TiempoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.A_Tiempo.A_Tiempo> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.A_Tiempo.A_TiempoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.A_Tiempo.A_Tiempo entity, Spartane.Core.Domain.User.GlobalData A_TiempoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.A_Tiempo.A_TiempoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.A_Tiempo.A_Tiempo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.A_Tiempo.A_Tiempo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.A_Tiempo.A_Tiempo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

