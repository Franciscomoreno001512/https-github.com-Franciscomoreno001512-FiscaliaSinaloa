using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Requerido
{
    public interface IRequeridoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Requerido.Requerido> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Requerido.RequeridoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData RequeridoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData RequeridoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Requerido.Requerido entity, Spartane.Core.Domain.User.GlobalData RequeridoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Requerido.RequeridoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Requerido.Requerido>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Requerido.Requerido_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Requerido.Requerido_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

