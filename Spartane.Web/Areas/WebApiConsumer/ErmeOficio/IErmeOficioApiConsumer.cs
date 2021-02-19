using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.ErmeOficio
{
    public interface IErmeOficioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.ErmeOficio.ErmeOficio> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.ErmeOficio.ErmeOficioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.ErmeOficio.ErmeOficio entity, Spartane.Core.Domain.User.GlobalData ErmeOficioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.ErmeOficio.ErmeOficioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.ErmeOficio.ErmeOficio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.ErmeOficio.ErmeOficio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.ErmeOficio.ErmeOficio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

