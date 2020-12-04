using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resolucion
{
    public interface IResolucionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion.Resolucion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion.ResolucionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData ResolucionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData ResolucionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData ResolucionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Resolucion.ResolucionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion.Resolucion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Resolucion.Resolucion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Resolucion.Resolucion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

