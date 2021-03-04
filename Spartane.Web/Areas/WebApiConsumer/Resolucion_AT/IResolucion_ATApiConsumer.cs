using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resolucion_AT
{
    public interface IResolucion_ATApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion_AT.Resolucion_ATPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT entity, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT entity, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Resolucion_AT.Resolucion_ATPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Dictaminacion(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Dictaminacion entity);
		ApiResponse<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Dictaminacion> Get_Dictaminacion(string Key);


    }
}

