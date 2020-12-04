using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Control_de_Detencion
{
    public interface IControl_de_DetencionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Detencion.Control_de_DetencionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Control_de_DetencionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion entity, Spartane.Core.Domain.User.GlobalData Control_de_DetencionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion entity, Spartane.Core.Domain.User.GlobalData Control_de_DetencionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Control_de_Detencion.Control_de_DetencionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Detencion.Control_de_Detencion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

