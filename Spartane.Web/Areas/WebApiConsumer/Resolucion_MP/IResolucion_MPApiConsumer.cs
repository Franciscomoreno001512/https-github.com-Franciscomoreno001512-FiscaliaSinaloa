using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resolucion_MP
{
    public interface IResolucion_MPApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Resolucion_MP.Resolucion_MPPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP entity, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP entity, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Resolucion_MP.Resolucion_MPPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Validacion(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP_Validacion entity);
		ApiResponse<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP_Validacion> Get_Validacion(string Key);


    }
}

