using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Respuesta
{
    public interface IRespuestaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Respuesta.Respuesta> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Respuesta.RespuestaPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData RespuestaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData RespuestaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Respuesta.Respuesta entity, Spartane.Core.Domain.User.GlobalData RespuestaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Respuesta.RespuestaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Respuesta.Respuesta>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Respuesta.Respuesta_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Respuesta.Respuesta_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

