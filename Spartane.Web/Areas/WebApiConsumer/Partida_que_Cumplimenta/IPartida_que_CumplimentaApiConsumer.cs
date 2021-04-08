using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Partida_que_Cumplimenta
{
    public interface IPartida_que_CumplimentaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

