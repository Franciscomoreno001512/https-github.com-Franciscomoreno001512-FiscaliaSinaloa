using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.tipo_de_cierre
{
    public interface Itipo_de_cierreApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierrePagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierrePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

