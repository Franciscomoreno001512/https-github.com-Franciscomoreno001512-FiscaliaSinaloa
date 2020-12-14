using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modo_de_Asegurado_de_Drogas
{
    public interface IModo_de_Asegurado_de_DrogasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Spartane.Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

