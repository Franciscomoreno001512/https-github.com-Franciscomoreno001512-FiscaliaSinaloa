using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Ente_que_localiza
{
    public interface IEnte_que_localizaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localizaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData Ente_que_localizaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localizaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

