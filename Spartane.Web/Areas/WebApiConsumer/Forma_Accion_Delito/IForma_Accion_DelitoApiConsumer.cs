using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito
{
    public interface IForma_Accion_DelitoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_DelitoPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito entity, Spartane.Core.Domain.User.GlobalData Forma_Accion_DelitoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_DelitoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Forma_Accion_Delito.Forma_Accion_Delito_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

